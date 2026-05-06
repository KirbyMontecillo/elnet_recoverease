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

        // New UI Controls for scheduling
        private ComboBox cmbFrequency;
        private DateTimePicker dtpIntakeTime;

        public class PrescriptionEntry
        {
            public Medication Medication { get; set; }
            public string Frequency { get; set; }
            public TimeOnly StartTime { get; set; }
        }

        public Clinical_Session(int appointmentId)
        {
            InitializeComponent();
            
            // Designer safety
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            _appointmentId = appointmentId;
            this.Load += async (s, e) => await InitializeSession();
        }

        private async Task InitializeSession()
        {
            try
            {
                // 1. Setup New Inputs Programmatically
                SetupSchedulingUI();

                // 2. Load Appointment & Patient
                _appt = await _db.Appointments.FirstOrDefaultAsync(a => a.AppointmentID == _appointmentId);
                if (_appt == null) { MessageBox.Show("Encounter not found."); this.Close(); return; }

                var patient = await _db.Patients.FirstOrDefaultAsync(p => p.PatientID == _appt.PatientID);
                lblPatientName.Text = patient?.FullName ?? "Unknown Patient";

                // 3. Load Existing Data
                txtMinutes.Text = _appt.Notes;
                trbRecovery.Value = Math.Clamp(_appt.RecoveryProgress ?? 0, 0, 100);
                lblRecoveryValue.Text = trbRecovery.Value + "% Recovered";

                txtBP.Text = _appt.BloodPressure;
                txtTemp.Text = _appt.Temperature;
                txtHR.Text = _appt.HeartRate;
                txtWeight.Text = _appt.Weight;

                // 4. Load Available Medications
                _availableMeds = await _db.Medications.ToListAsync();
                cmbMeds.DataSource = _availableMeds;
                cmbMeds.DisplayMember = "MedicationName";
                cmbMeds.ValueMember = "MedicationID";

                UpdatePrescriptionGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting session: " + ex.Message);
            }
        }

        private void SetupSchedulingUI()
        {
            // Frequency Label
            Label lblFreq = new Label { Text = "Frequency:", Location = new Point(20, 100), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            
            // Frequency Combo
            cmbFrequency = new ComboBox { 
                Location = new Point(20, 120), 
                Size = new Size(180, 30), 
                DropDownStyle = ComboBoxStyle.DropDownList 
            };
            cmbFrequency.Items.AddRange(new object[] { "Once daily", "Twice daily", "3x a day", "4x a day", "Every 4 hours", "As needed" });
            cmbFrequency.SelectedIndex = 0;

            // Time Label
            Label lblTime = new Label { Text = "Start Time:", Location = new Point(220, 100), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            
            // Time Picker
            dtpIntakeTime = new DateTimePicker { 
                Location = new Point(220, 120), 
                Size = new Size(150, 30), 
                Format = DateTimePickerFormat.Time, 
                ShowUpDown = true 
            };

            // Shift existing grid down
            dgvPrescriptions.Location = new Point(20, 170);
            dgvPrescriptions.Height = 300;

            tpPrescription.Controls.Add(lblFreq);
            tpPrescription.Controls.Add(cmbFrequency);
            tpPrescription.Controls.Add(lblTime);
            tpPrescription.Controls.Add(dtpIntakeTime);
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            if (cmbMeds.SelectedItem is Medication selectedMed)
            {
                if (!_prescribedMeds.Any(m => m.Medication.MedicationID == selectedMed.MedicationID))
                {
                    _prescribedMeds.Add(new PrescriptionEntry {
                        Medication = selectedMed,
                        Frequency = cmbFrequency.SelectedItem.ToString(),
                        StartTime = TimeOnly.FromDateTime(dtpIntakeTime.Value)
                    });
                    UpdatePrescriptionGrid();
                }
            }
        }

        private void UpdatePrescriptionGrid()
        {
            dgvPrescriptions.DataSource = null;
            dgvPrescriptions.DataSource = _prescribedMeds.Select(m => new {
                Medication = m.Medication.MedicationName,
                m.Medication.DosageUnit,
                m.Frequency,
                StartAt = m.StartTime.ToString("hh:mm tt")
            }).ToList();
        }

        private async void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Update Appointment
                _appt.Notes = txtMinutes.Text;
                _appt.RecoveryProgress = trbRecovery.Value;
                _appt.BloodPressure = txtBP.Text;
                _appt.Temperature = txtTemp.Text;
                _appt.HeartRate = txtHR.Text;
                _appt.Weight = txtWeight.Text;
                _appt.Status = "Completed";
                _appt.FinalizedAt = DateTime.Now;

                _db.Appointments.Update(_appt);

                // 2. Process Prescriptions & Schedules
                foreach (var entry in _prescribedMeds)
                {
                    var schedule = new MedicationSchedule
                    {
                        PatientID = _appt.PatientID ?? 0,
                        MedicationID = entry.Medication.MedicationID,
                        ScheduledDate = DateOnly.FromDateTime(DateTime.Now),
                        ScheduledTime = entry.StartTime,
                        IsTaken = false,
                        IsMissed = false,
                        Notes = $"Freq: {entry.Frequency}. Prescribed during clinical session."
                    };
                    _db.MedicationSchedules.Add(schedule);
                }

                // 3. Automated Clinical Documentation (New)
                if (!string.IsNullOrWhiteSpace(txtMinutes.Text))
                {
                    var clinicalNote = new ClinicalNote
                    {
                        PatientID = _appt.PatientID ?? 0,
                        StaffID = elnet_recoverease.Core.UserSession.CurrentStaff?.StaffID ?? 0,
                        NoteContent = $"[CLINICAL SESSION MINUTES - {DateTime.Now:g}]\n{txtMinutes.Text}",
                        CreatedAt = DateTime.Now
                    };
                    _db.ClinicalNotes.Add(clinicalNote);
                }

                await _db.SaveChangesAsync();

                MessageBox.Show("Clinical session finalized. Medication intake schedules have been generated for the patient.", "Session Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finalizing session: " + ex.Message);
            }
        }
    }
}
