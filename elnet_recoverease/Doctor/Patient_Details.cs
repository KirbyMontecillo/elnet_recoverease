using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System.Linq;
using System.Collections.Generic;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Doctor
{
    public partial class Patient_Details : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _patientId;
        private Patient _patient;

        public Patient_Details(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            
            this.Load += (s, e) => LoadPatientData();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnBack.Click += (s, e) => NavigationHelper.SwitchForm(this, new Patient_List());
            btnUpdatePlan.Click += (s, e) => {
                using (var form = new Treatment_Plan_Form(_patientId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadPatientData();
                    }
                }
            };

            btnLogout.Click += (s, e) => NavigationHelper.Logout(this);
            
            // Sidebar Nav
            NavigationHelper.WireNavButton(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            NavigationHelper.WireNavButton(btnNavPatients, () => NavigationHelper.SwitchForm(this, new Patient_List()));
            NavigationHelper.WireNavButton(btnNavAppointments, () => NavigationHelper.SwitchForm(this, new Appointments()));
            NavigationHelper.WireNavButton(btnNavReports, () => NavigationHelper.SwitchForm(this, new Reports()));
            NavigationHelper.WireNavButton(btnNavProfile, () => NavigationHelper.SwitchForm(this, new Doctor_Profile()));
        }

        private void LoadPatientData()
        {
            // Load Sidebar Logo
            try {
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) {
                    picLogo.Image = Image.FromFile(logoPath);
                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                }
            } catch { }

            using (var db = new AppDbContext())
            {
                _patient = db.Patients.FirstOrDefault(p => p.PatientID == _patientId);
                
                if (_patient == null) return;
                
                var appts = db.Appointments
                    .Where(a => a.PatientID == _patientId && a.Status == "Completed")
                    .OrderByDescending(a => a.AppointmentDate)
                    .ToList();

                var medIds = db.MedicationSchedules
                    .Where(ms => ms.PatientID == _patientId)
                    .Select(ms => ms.MedicationID)
                    .Distinct()
                    .ToList();

                var meds = db.Medications
                    .Where(m => medIds.Contains(m.MedicationID))
                    .ToList();

                lblPatientName.Text = _patient.FullName;
                lblPatientId.Text = $"Patient ID: {_patient.PatientID:D4}";
                lblPatientInitials.Text = GetInitials(_patient.FullName);
                lblAvatarInitials.Text = GetInitials(UserSession.CurrentStaff?.FullName ?? "Dr");

                lblInfoAgeGenVal.Text = $"👤 Age: {_patient.Age} / {_patient.Gender}";
                lblInfoContactVal.Text = $"📞 {_patient.ContactNumber}";
                lblInfoBloodVal.Text = $"🩸 Blood Type: {_patient.BloodType ?? "N/A"}";
                lblInfoAddressVal.Text = $"📍 {_patient.Address}";

                // Status Badge
                lblStatusBadge.Text = _patient.Status?.ToUpper() ?? "ACTIVE";
                if (_patient.Status == "Discharged")
                {
                    lblStatusBadge.BackColor = Color.FromArgb(71, 85, 105); // Slate gray
                    btnActivate.Visible = true;
                    btnActivate.Click -= BtnActivate_Click;
                    btnActivate.Click += BtnActivate_Click;
                }
                else
                {
                    lblStatusBadge.BackColor = Color.FromArgb(0, 168, 168); // Teal for active
                    btnActivate.Visible = false;
                }
                
                // Refresh badge region for rounding
                lblStatusBadge.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblStatusBadge.Width, lblStatusBadge.Height, 10, 10));

                var latestAppt = appts.FirstOrDefault();
                var latestPlan = db.TreatmentPlans
                    .Where(tp => tp.PatientID == _patientId)
                    .OrderByDescending(tp => tp.CreatedAt)
                    .FirstOrDefault();
                
                if (latestPlan != null)
                {
                    string details = latestPlan.PlanDetails ?? "";
                    lblDiagContent.Text = ExtractSection(details, "DIAGNOSIS:") ?? "Recorded in plan.";
                    lblGoalContent.Text = ExtractSection(details, "GOALS:") ?? "See plan details.";
                    lblNoteContent.Text = ExtractSection(details, "NOTES:") ?? details;
                }
                else if (latestAppt != null && !string.IsNullOrEmpty(latestAppt.Diagnosis))
                {
                    lblDiagContent.Text = latestAppt.Diagnosis;
                    lblGoalContent.Text = latestAppt.TreatmentGoals ?? "No specific goals set.";
                    lblNoteContent.Text = latestAppt.DoctorNotes ?? "No additional clinical notes recorded.";
                }
                else
                {
                    lblDiagContent.Text = "No active diagnosis.";
                    lblGoalContent.Text = "—";
                    lblNoteContent.Text = "Select '+ Update Treatment Plan' to record a new plan.";
                }

                PopulateMedInfo(latestAppt);
                PopulateVitals(latestAppt);
                PopulateMedCards(meds);
                SetupAppointmentGrid(appts);
            }
        }

        private void PopulateMedInfo(Appointment latest)
        {
            pnlMedInfo.Controls.Clear();
            pnlMedInfo.Controls.Add(new Label { Text = "Medical Information", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(27, 58, 107), AutoSize = true });

            int startX = 25, startY = 75, gapX = 220, gapY = 95;
            
            AddMedInfoCard(pnlMedInfo, "HEIGHT", latest?.Height ?? _patient.Height ?? "N/A", startX, startY);
            AddMedInfoCard(pnlMedInfo, "WEIGHT", latest?.Weight ?? _patient.Weight ?? "N/A", startX + gapX, startY);
            AddMedInfoCard(pnlMedInfo, "BMI", latest?.BMI ?? "N/A", startX, startY + gapY);
            AddMedInfoCard(pnlMedInfo, "BLOOD TYPE", _patient.BloodType ?? "N/A", startX + gapX, startY + gapY);

            var lblAllergies = new Label { Text = "Allergies", Location = new Point(25, 255), Font = new Font("Segoe UI Semibold", 9), ForeColor = Color.FromArgb(100, 120, 145), AutoSize = true };
            var lblAllergiesVal = new Label { Text = _patient.Allergies ?? "No known allergies recorded", Location = new Point(25, 280), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Italic), ForeColor = Color.FromArgb(30, 43, 60) };
            pnlMedInfo.Controls.Add(lblAllergies);
            pnlMedInfo.Controls.Add(lblAllergiesVal);
        }

        private void AddMedInfoCard(Panel parent, string title, string val, int x, int y)
        {
            var pnl = new Panel { Size = new Size(200, 75), Location = new Point(x, y), BackColor = Color.FromArgb(245, 248, 250) };
            pnl.Controls.Add(new Label { Text = title, Location = new Point(12, 12), AutoSize = true, Font = new Font("Segoe UI", 7, FontStyle.Bold), ForeColor = Color.Gray });
            pnl.Controls.Add(new Label { Text = val, Location = new Point(12, 32), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(30, 43, 60) });
            parent.Controls.Add(pnl);
        }

        private void PopulateVitals(Appointment latest)
        {
            pnlLatestVitals.Controls.Clear();
            pnlLatestVitals.Controls.Add(new Label { Text = "⚡ Latest Vital Signs", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(0, 168, 168), AutoSize = true });

            int startX = 25, startY = 85, gapY = 95;
            AddVitalCard(pnlLatestVitals, "Blood Pressure", latest?.BloodPressure ?? "N/A", startX, startY);
            AddVitalCard(pnlLatestVitals, "Heart Rate", latest?.HeartRate != null ? $"{latest.HeartRate} bpm" : "N/A", startX, startY + gapY);
            AddVitalCard(pnlLatestVitals, "Temperature", latest?.Temperature != null ? $"{latest.Temperature}°C" : "N/A", startX, startY + gapY * 2);
            AddVitalCard(pnlLatestVitals, "Weight", latest?.Weight != null ? $"{latest.Weight} kg" : "N/A", startX, startY + gapY * 3);
        }

        private void AddVitalCard(Panel parent, string title, string val, int x, int y)
        {
            var pnl = new Panel { Size = new Size(420, 80), Location = new Point(x, y), BackColor = Color.FromArgb(245, 248, 250) };
            pnl.Controls.Add(new Label { Text = title, Location = new Point(15, 15), AutoSize = true, Font = new Font("Segoe UI", 8.5f), ForeColor = Color.Gray });
            pnl.Controls.Add(new Label { Text = val, Location = new Point(15, 38), AutoSize = true, Font = new Font("Segoe UI", 13, FontStyle.Bold), ForeColor = Color.FromArgb(30, 43, 60) });
            parent.Controls.Add(pnl);
        }

        private void PopulateMedCards(List<Medication> meds)
        {
            pnlCurrentMeds.Controls.Clear();
            pnlCurrentMeds.Controls.Add(new Label { Text = "💊 Current Medications", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(27, 58, 107), AutoSize = true });

            if (meds == null || !meds.Any())
            {
                pnlCurrentMeds.Controls.Add(new Label { Text = "No active prescriptions.", Location = new Point(25, 75), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Italic), ForeColor = Color.Gray });
                return;
            }

            int startY = 75;
            foreach (var m in meds)
            {
                var card = new Panel { Size = new Size(430, 75), Location = new Point(25, startY), BackColor = Color.FromArgb(245, 248, 250) };
                card.Controls.Add(new Label { Text = "💊", Location = new Point(12, 20), Font = new Font("Segoe UI", 14), AutoSize = true });
                card.Controls.Add(new Label { Text = m.MedicationName, Location = new Point(55, 18), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.FromArgb(30, 43, 60) });
                card.Controls.Add(new Label { Text = "Active Prescription", Location = new Point(55, 42), AutoSize = true, Font = new Font("Segoe UI", 8.5f), ForeColor = Color.FromArgb(100, 120, 145) });
                pnlCurrentMeds.Controls.Add(card);
                startY += 85;
            }
        }

        private void SetupAppointmentGrid(List<Appointment> appts)
        {
            pnlApptHistory.Controls.Clear();
            pnlApptHistory.Controls.Add(new Label { Text = "🗓️ Appointment History", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(27, 58, 107), AutoSize = true });

            dgvApptHistory = new DataGridView { Location = new Point(25, 75), Size = new Size(940, 220), BackgroundColor = Color.White, BorderStyle = BorderStyle.None, SelectionMode = DataGridViewSelectionMode.FullRowSelect, RowHeadersVisible = false, AllowUserToAddRows = false, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, RowTemplate = { Height = 45 }, GridColor = Color.FromArgb(240, 240, 240) };
            dgvApptHistory.DataSource = appts.Select(a => new { Date = a.AppointmentDate?.ToString("MMM dd, yyyy"), Status = a.Status, Diagnosis = a.Diagnosis ?? "N/A", Action = "View Details" }).ToList();

            dgvApptHistory.CellContentClick += (s, e) => {
                if (e.RowIndex >= 0)
                {
                    var appt = appts[e.RowIndex];
                    using (var session = new Clinical_Session(appt.AppointmentID))
                    {
                        session.ShowDialog();
                        LoadPatientData();
                    }
                }
            };
            pnlApptHistory.Controls.Add(dgvApptHistory);
        }

        private async void BtnActivate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to re-activate {_patient.FullName} for new treatment?", "Re-activate Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new AppDbContext())
                {
                    var p = db.Patients.Find(_patientId);
                    if (p != null)
                    {
                        p.Status = "Active";
                        await db.SaveChangesAsync();
                        MessageBox.Show("Patient status set to Active.", "Success");
                        LoadPatientData();
                    }
                }
            }
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "P";
            var parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private string ExtractSection(string text, string sectionName)
        {
            if (string.IsNullOrEmpty(text) || !text.Contains(sectionName)) return null;
            int start = text.IndexOf(sectionName) + sectionName.Length;
            int nextSection = text.IndexOf("\n", start);
            if (nextSection == -1) return text.Substring(start).Trim();
            return text.Substring(start, nextSection - start).Trim();
        }
    }
}
