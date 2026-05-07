using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Doctor
{
    public partial class Clinical_Session : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _appointmentId;
        private Appointment _appt;
        private List<Medication> _availableMeds;
        private List<PrescriptionEntry> _prescribedMeds = new List<PrescriptionEntry>();

        private ComboBox cmbFrequency;
        private DateTimePicker dtpIntakeTime;

        public class PrescriptionEntry
        {
            public string MedicationName { get; set; }
            public string Dosage { get; set; }
            public string Frequency { get; set; }
            public DateOnly StartDate { get; set; }
            public DateOnly EndDate { get; set; }
            public List<TimeOnly> DoseTimes { get; set; } = new List<TimeOnly>();
            public int? MedicationId { get; set; }
        }

        public Clinical_Session(int appointmentId)
        {
            InitializeComponent();
            
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _appointmentId = appointmentId;
            this.Load += async (s, e) => await InitializeSession();
        }

        private async Task InitializeSession()
        {
            try
            {
                SetupSchedulingUI();

                _appt = await _db.Appointments.FirstOrDefaultAsync(a => a.AppointmentID == _appointmentId);
                if (_appt == null) { MessageBox.Show("Encounter not found."); this.Close(); return; }

                var patient = await _db.Patients.FirstOrDefaultAsync(p => p.PatientID == _appt.PatientID);
                lblPatientName.Text = patient?.FullName ?? "Unknown Patient";
                lblPatientInfo.Text = $"ID: {patient?.PatientCode ?? "N/A"} · {DateTime.Now:MMM dd, yyyy}";

                txtChiefComplaint.Text = _appt.ChiefComplaint;
                txtDiagnosis.Text = _appt.Diagnosis;
                txtPlanNotes.Text = _appt.PlanNotes;
                
                if (!string.IsNullOrEmpty(_appt.BloodPressure) && _appt.BloodPressure.Contains("/"))
                {
                    var parts = _appt.BloodPressure.Split('/');
                    txtSystolic.Text = parts[0];
                    txtDiastolic.Text = parts.Length > 1 ? parts[1] : "";
                }
                else
                {
                    txtSystolic.Text = _appt.BloodPressure;
                }

                txtTemp.Text = _appt.Temperature;
                txtHR.Text = _appt.HeartRate;
                txtWeight.Text = _appt.Weight;
                txtHeight.Text = _appt.Height;
                txtBMI.Text = _appt.BMI;

                txtWeight.TextChanged += (s, e) => CalculateBMI();
                txtHeight.TextChanged += (s, e) => CalculateBMI();

                if (!string.IsNullOrEmpty(patient?.BloodType))
                {
                    cmbBloodType.SelectedItem = patient.BloodType;
                }
                else
                {
                    cmbBloodType.SelectedIndex = 0; // "--"
                }

                await LoadVitalHistory();

                _availableMeds = await _db.Medications.ToListAsync();
                cmbMeds.DataSource = _availableMeds;
                cmbMeds.DisplayMember = "MedicationName";
                cmbMeds.ValueMember = "MedicationID";
                cmbMeds.SelectedIndex = -1; 
                cmbMeds.Text = "";

                cmbMeds.SelectedIndexChanged += (s, e) => {
                    if (cmbMeds.SelectedItem is Medication m) txtDosageUnit.Text = m.DosageUnit;
                };

                UpdatePrescriptionGrid();

                if (_appt.Status == "Completed")
                {
                    SetReadOnly();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting session: " + ex.Message);
            }
        }

        private void SetupSchedulingUI()
        {
            cmbFrequency = new ComboBox { 
                Location = new Point(700, 45), 
                Size = new Size(210, 35), 
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            cmbFrequency.Items.AddRange(new object[] { "Once daily", "Twice daily", "3x a day", "4x a day", "Every 4 hours", "As needed" });
            cmbFrequency.SelectedIndex = 0;

            dtpIntakeTime = new DateTimePicker { 
                Location = new Point(20, 120), 
                Size = new Size(210, 35), 
                Format = DateTimePickerFormat.Time, 
                ShowUpDown = true,
                Font = new Font("Segoe UI", 10)
            };

            cmbFrequency.SelectedIndexChanged += (s, e) => {
                UpdateIntervalDefault();
                UpdateReminderLabel();
            };
            dtpIntakeTime.ValueChanged += (s, e) => UpdateReminderLabel();
            txtInterval.TextChanged += (s, e) => UpdateReminderLabel();

            foreach (Control c in tpPrescription.Controls)
            {
                if (c is Panel p && p.BackColor != Color.Transparent) // The input card
                {
                    p.Controls.Add(cmbFrequency);
                    p.Controls.Add(dtpIntakeTime);
                    break;
                }
            }

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(7);
            
            UpdateIntervalDefault();
            UpdateReminderLabel();
        }

        private void UpdateIntervalDefault()
        {
            string freq = cmbFrequency.SelectedItem?.ToString() ?? "";
            switch (freq)
            {
                case "Once daily": txtInterval.Text = "24"; break;
                case "Twice daily": txtInterval.Text = "12"; break;
                case "3x a day": txtInterval.Text = "8"; break;
                case "4x a day": txtInterval.Text = "6"; break;
                case "Every 4 hours": txtInterval.Text = "4"; break;
                default: txtInterval.Text = "0"; break;
            }
        }

        private void CalculateBMI()
        {
            if (double.TryParse(txtWeight.Text, out double weight) && double.TryParse(txtHeight.Text, out double height) && height > 0)
            {
                // BMI = kg / m^2
                double heightInMeters = height / 100.0;
                double bmi = weight / (heightInMeters * heightInMeters);
                txtBMI.Text = bmi.ToString("F1");
            }
            else
            {
                txtBMI.Text = "";
            }
        }

        private async Task LoadVitalHistory()
        {
            try
            {
                dgvVitalHistory.Rows.Clear();

                var history = await _db.Appointments
                    .Where(a => a.PatientID == _appt.PatientID && a.Status == "Completed" && a.AppointmentID != _appt.AppointmentID)
                    .OrderByDescending(a => a.FinalizedAt ?? a.AppointmentDate)
                    .ToListAsync();

                if (history.Count == 0)
                {
                    lblVitalHistorySub.Text = "No previous clinical records found for this patient.";
                    lblVitalHistorySub.ForeColor = Color.DarkOrange;
                    return;
                }

                lblVitalHistorySub.Text = $"Showing {history.Count} previous session(s)";
                lblVitalHistorySub.ForeColor = Color.Gray;

                foreach (var h in history)
                {
                    dgvVitalHistory.Rows.Add(
                        (h.FinalizedAt ?? h.AppointmentDate)?.ToString("MMM dd, yyyy") ?? "--",
                        h.BloodPressure ?? "--",
                        h.HeartRate ?? "--",
                        h.Temperature ?? "--",
                        (h.Weight != null ? h.Weight + " kg" : "--"),
                        (h.Height != null ? h.Height + " cm" : "--"),
                        h.BMI ?? "--",
                        GetBMIStatus(h.BMI)
                    );
                }
            }
            catch (Exception ex)
            {
                // Silently fail or log for UI stability
                System.Diagnostics.Debug.WriteLine("Grid Load Error: " + ex.Message);
            }
        }

        private string GetBMIStatus(string bmiStr)
        {
            if (double.TryParse(bmiStr, out double bmi))
            {
                if (bmi < 18.5) return "Underweight";
                if (bmi < 25) return "Normal";
                if (bmi < 30) return "Overweight";
                return "Obese";
            }
            return "-";
        }

        private void UpdateReminderLabel()
        {
            if (cmbFrequency.SelectedItem == null) return;
            
            flpReminders.Controls.Clear();
            string freq = cmbFrequency.SelectedItem.ToString();
            
            if (freq == "As needed")
            {
                var lbl = new Label { Text = "No fixed schedule (PRN)", AutoSize = true, ForeColor = Color.Gray, Font = new Font("Segoe UI", 8.5f, FontStyle.Italic) };
                flpReminders.Controls.Add(lbl);
                return;
            }

            if (!int.TryParse(txtInterval.Text, out int interval) || interval <= 0)
            {
                return;
            }

            var times = CalculateDoseTimes(freq, TimeOnly.FromDateTime(dtpIntakeTime.Value), interval);
            foreach (var t in times)
            {
                var pill = new Label {
                    Text = t.ToString("hh:mm tt"),
                    BackColor = Color.FromArgb(240, 240, 240),
                    ForeColor = Color.FromArgb(60, 60, 60),
                    Padding = new Padding(8, 4, 8, 4),
                    Margin = new Padding(0, 0, 8, 0),
                    AutoSize = true,
                    Font = new Font("Segoe UI Semibold", 8.5f)
                };
                pill.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pill.PreferredWidth, pill.PreferredHeight, 10, 10));
                flpReminders.Controls.Add(pill);
            }
        }

        private List<TimeOnly> CalculateDoseTimes(TimeOnly startTime, int doseCount, int intervalHours)
        {
            List<TimeOnly> times = new List<TimeOnly>();

            for (int i = 0; i < doseCount; i++)
            {
                int totalHoursToAdd = i * intervalHours;
                
                // Use DateTime math to handle 24h wraps correctly
                DateTime startRef = DateTime.Today.Add(startTime.ToTimeSpan());
                DateTime doseTime = startRef.AddHours(totalHoursToAdd);
                
                times.Add(TimeOnly.FromDateTime(doseTime));
            }
            return times; // Removed .OrderBy to keep the sequence starting from user's input
        }

        private List<TimeOnly> CalculateDoseTimes(string frequency, TimeOnly startTime, int intervalHours)
        {
            int doseCount = 0;
            switch (frequency)
            {
                case "Once daily": doseCount = 1; break;
                case "Twice daily": doseCount = 2; break;
                case "3x a day": doseCount = 3; break;
                case "4x a day": doseCount = 4; break;
                case "Every 4 hours": doseCount = 24 / Math.Max(1, intervalHours); break;
                default: return new List<TimeOnly>();
            }

            return CalculateDoseTimes(startTime, doseCount, intervalHours);
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            string medName = cmbMeds.Text;
            string dosage = txtDosageUnit.Text;

            if (string.IsNullOrWhiteSpace(medName))
            {
                MessageBox.Show("Please enter or select a medication.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtInterval.Text, out int interval) || (interval <= 0 && cmbFrequency.Text != "As needed"))
            {
                MessageBox.Show("Please enter a valid numeric interval in hours.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string freq = cmbFrequency.SelectedItem?.ToString() ?? "Once daily";
            var startTime = TimeOnly.FromDateTime(dtpIntakeTime.Value);
            var doseTimes = CalculateDoseTimes(freq, startTime, interval);
            int? medId = (cmbMeds.SelectedItem as Medication)?.MedicationID;

            _prescribedMeds.Add(new PrescriptionEntry {
                MedicationName = medName,
                Dosage = dosage,
                Frequency = freq,
                StartDate = DateOnly.FromDateTime(dtpStartDate.Value),
                EndDate = DateOnly.FromDateTime(dtpEndDate.Value),
                DoseTimes = freq == "As needed" ? new List<TimeOnly>() : doseTimes,
                MedicationId = medId
            });

            UpdatePrescriptionGrid();
            
            cmbMeds.Text = "";
            cmbMeds.SelectedIndex = -1;
            txtDosageUnit.Text = "";
        }

        private void UpdatePrescriptionGrid()
        {
            flpPrescriptions.Controls.Clear();
            lblPrescriptionCount.Text = $"{_prescribedMeds.Count} medication" + (_prescribedMeds.Count != 1 ? "s" : "");

            foreach (var entry in _prescribedMeds)
            {
                var card = new Panel {
                    Size = new Size(910, 110),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(0, 0, 0, 15)
                };
                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 15, 15));
                card.Paint += (s, e) => {
                    using (Pen p = new Pen(Color.FromArgb(20, 35, 65), 1))
                    {
                        e.Graphics.DrawRectangle(p, 0, 0, card.Width - 1, card.Height - 1);
                    }
                };

                var lblIcon = new Label { Text = "🔗", Location = new Point(20, 20), AutoSize = true, Font = new Font("Segoe UI", 12) };
                var lblName = new Label { Text = entry.MedicationName, Location = new Point(60, 20), Font = new Font("Segoe UI", 11, FontStyle.Bold), AutoSize = true };
                
                var flpBadges = new FlowLayoutPanel { Location = new Point(20, 55), Size = new Size(600, 30), BackColor = Color.Transparent };
                
                var addBadge = new Action<string, string>((text, icon) => {
                    var b = new Label {
                        Text = $"{icon} {text}",
                        BackColor = Color.FromArgb(245, 245, 240),
                        Padding = new Padding(8, 3, 8, 3),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 8.5f),
                        Margin = new Padding(0, 0, 8, 0)
                    };
                    b.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, b.PreferredWidth, b.PreferredHeight, 8, 8));
                    flpBadges.Controls.Add(b);
                });

                addBadge(entry.Dosage, "💧");
                addBadge(entry.Frequency, "🔁");
                addBadge($"{entry.StartDate:MM/dd/yyyy} - {entry.EndDate:MM/dd/yyyy}", "📅");

                var lblTimes = new Label {
                    Text = "🕒 " + string.Join(" · ", entry.DoseTimes.Select(t => t.ToString("hh:mm tt"))),
                    Location = new Point(20, 85),
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 8.5f)
                };

                var btnDelete = new Button {
                    Text = "🗑",
                    Size = new Size(40, 40),
                    Location = new Point(850, 20),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(250, 240, 240),
                    ForeColor = Color.DarkRed
                };
                btnDelete.Click += (s, e) => {
                    _prescribedMeds.Remove(entry);
                    UpdatePrescriptionGrid();
                };
                if (_appt.Status == "Completed") btnDelete.Visible = false;

                card.Controls.AddRange(new Control[] { lblIcon, lblName, flpBadges, lblTimes, btnDelete });
                flpPrescriptions.Controls.Add(card);
            }
        }

        private async void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                _appt.ChiefComplaint = txtChiefComplaint.Text;
                _appt.Diagnosis = txtDiagnosis.Text;
                _appt.PlanNotes = txtPlanNotes.Text;
                _appt.BloodPressure = $"{txtSystolic.Text}/{txtDiastolic.Text}";
                _appt.Temperature = txtTemp.Text;
                _appt.HeartRate = txtHR.Text;
                _appt.Weight = txtWeight.Text;
                _appt.Height = txtHeight.Text;
                _appt.BMI = txtBMI.Text;
                _appt.Status = "Completed";
                _appt.FinalizedAt = DateTime.Now;

                _db.Appointments.Update(_appt);

                foreach (var entry in _prescribedMeds)
                {
                    var start = entry.StartDate.ToDateTime(TimeOnly.MinValue);
                    var end = entry.EndDate.ToDateTime(TimeOnly.MinValue);

                    for (var date = start; date <= end; date = date.AddDays(1))
                    {
                        if (entry.Frequency == "As needed")
                        {
                            _db.MedicationSchedules.Add(new MedicationSchedule {
                                PatientID = _appt.PatientID ?? 0,
                                MedicationID = entry.MedicationId ?? 0,
                                MedicationName = entry.MedicationName,
                                DosageUnit = entry.Dosage,
                                Frequency = entry.Frequency,
                                ScheduledDate = DateOnly.FromDateTime(date),
                                ScheduledTime = null,
                                IsTaken = false,
                                IsMissed = false,
                                Status = "Pending",
                                Notes = $"Prescribed during clinical session."
                            });
                        }
                        else
                        {
                            foreach (var time in entry.DoseTimes)
                            {
                                _db.MedicationSchedules.Add(new MedicationSchedule {
                                    PatientID = _appt.PatientID ?? 0,
                                    MedicationID = entry.MedicationId ?? 0,
                                    MedicationName = entry.MedicationName,
                                    DosageUnit = entry.Dosage,
                                    Frequency = entry.Frequency,
                                    ScheduledDate = DateOnly.FromDateTime(date),
                                    ScheduledTime = time,
                                    IsTaken = false,
                                    IsMissed = false,
                                    Status = "Pending",
                                    Notes = $"Prescribed during clinical session."
                                });
                            }
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtChiefComplaint.Text) || !string.IsNullOrWhiteSpace(txtDiagnosis.Text))
                {
                    string summary = $"[CLINICAL SESSION - {DateTime.Now:g}]\n" +
                                   $"CHIEF COMPLAINT: {txtChiefComplaint.Text}\n" +
                                   $"DIAGNOSIS: {txtDiagnosis.Text}\n" +
                                   $"PLAN: {txtPlanNotes.Text}";

                    _db.ClinicalNotes.Add(new ClinicalNote {
                        PatientID = _appt.PatientID ?? 0,
                        StaffID = UserSession.CurrentStaff?.StaffID ?? 1,
                        NoteContent = summary,
                        CreatedAt = DateTime.Now
                    });
                }

                // Update Patient Master Record
                var pId = _appt.PatientID ?? 0;
                var patientRecord = await _db.Patients.FindAsync(pId);
                if (patientRecord != null)
                {
                    patientRecord.Height = txtHeight.Text;
                    patientRecord.Weight = txtWeight.Text;
                    if (cmbBloodType.SelectedIndex > 0)
                        patientRecord.BloodType = cmbBloodType.SelectedItem.ToString();

                    // Discharge Logic
                    if (chkDischarge.Checked)
                    {
                        patientRecord.Status = "Discharged";
                    }
                }

                await _db.SaveChangesAsync();

                MessageBox.Show("Clinical session finalized successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finalizing session: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_appt.Status == "Completed") { this.Close(); return; }
            if (MessageBox.Show("Are you sure you want to discard this session? Any unsaved notes will be lost.", "Discard Session", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SetReadOnly()
        {
            // Session Minutes Tab
            txtChiefComplaint.ReadOnly = true;
            txtDiagnosis.ReadOnly = true;
            txtPlanNotes.ReadOnly = true;

            // Vital Signs Tab
            txtSystolic.ReadOnly = true;
            txtDiastolic.ReadOnly = true;
            txtTemp.ReadOnly = true;
            txtHR.ReadOnly = true;
            txtWeight.ReadOnly = true;
            txtHeight.ReadOnly = true;

            // Prescription Tab
            cmbMeds.Enabled = false;
            txtDosageUnit.ReadOnly = true;
            cmbFrequency.Enabled = false;
            txtInterval.ReadOnly = true;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            dtpIntakeTime.Enabled = false;
            btnAddMed.Enabled = false;

            // Footer
            btnFinalize.Enabled = false;
            btnFinalize.Text = "Record Finalized";
            btnFinalize.BackColor = Color.Gray;
            btnCancel.Text = "Close View";

        }
    }
}
