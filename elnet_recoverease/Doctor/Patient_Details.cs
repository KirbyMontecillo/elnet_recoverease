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

using elnet_recoverease.Core;
using elnet_recoverease.Admin;

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
            
            InitializeNavigation();
            LoadPatientData();
        }

        private void InitializeNavigation()
        {
            // Navbar handlers
            NavigationHelper.WireNavButton(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            NavigationHelper.WireNavButton(btnNavPatients, () => NavigationHelper.SwitchForm(this, new Patient_List()));
            NavigationHelper.WireNavButton(btnNavAppointments, () => NavigationHelper.SwitchForm(this, new Appointments()));
            NavigationHelper.WireNavButton(btnNavReports, () => NavigationHelper.SwitchForm(this, new Reports()));
            NavigationHelper.WireNavButton(btnNavProfile, () => NavigationHelper.SwitchForm(this, new Doctor_Profile()));
            btnLogout.Click += (s, e) => NavigationHelper.Logout(this);
        }

        private void AttachNavEvents(Panel pnl, Action action)
        {
            pnl.Click += (s, e) => action();
            foreach (Control c in pnl.Controls)
            {
                c.Click += (s, e) => action();
            }
        }

        private async void LoadPatientData()
        {
            try
            {
                _patient = await _db.Patients
                    .Include(p => p.User)
                    .FirstOrDefaultAsync(p => p.PatientID == _patientId);

                if (_patient == null)
                {
                    MessageBox.Show("Patient not found.");
                    this.Close();
                    return;
                }

                // Fetch Appointments
                var appts = await _db.Appointments
                    .Where(a => a.PatientID == _patientId)
                    .OrderByDescending(a => a.AppointmentDate)
                    .Take(5)
                    .ToListAsync();

                // Fetch Medications through Schedule
                var meds = await _db.MedicationSchedules
                    .Where(ms => ms.PatientID == _patientId)
                    .Select(ms => _db.Medications.FirstOrDefault(m => m.MedicationID == ms.MedicationID))
                    .Where(m => m != null)
                    .Distinct()
                    .ToListAsync();

                // Fetch Treatment Plan
                var plan = await _db.TreatmentPlans
                    .Where(tp => tp.PatientID == _patientId)
                    .OrderByDescending(tp => tp.CreatedAt)
                    .FirstOrDefaultAsync();

                UpdateProfileUI(appts, meds, plan);
                SetLogo();
                SetupNavigation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patient: " + ex.Message);
            }
        }

        private void SetLogo()
        {
            try 
            { 
                string logoPath = System.IO.Path.Combine(Application.StartupPath, "images", "logo.png");
                if (!System.IO.File.Exists(logoPath)) logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) picLogo.Image = Image.FromFile(logoPath);
            } 
            catch { }
        }

        private void SetupNavigation()
        {
            // Navbar
            NavigationHelper.WireNavButton(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            NavigationHelper.WireNavButton(btnNavPatients, () => NavigationHelper.SwitchForm(this, new Patient_List()));
            NavigationHelper.WireNavButton(btnNavAppointments, () => NavigationHelper.SwitchForm(this, new Appointments()));
            NavigationHelper.WireNavButton(btnNavReports, () => NavigationHelper.SwitchForm(this, new Reports()));
            NavigationHelper.WireNavButton(btnNavProfile, () => NavigationHelper.SwitchForm(this, new Doctor_Profile()));
            
            btnBack.Click += (s, e) => this.Close();
            btnLogout.Click += (s, e) => NavigationHelper.Logout(this);

            // Quick Actions
            btnUpdatePlan.Click += (s, e) => {
                using (var planForm = new Treatment_Plan_Form(_patientId))
                {
                    if (planForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPatientData(); // Refresh UI
                    }
                }
            };
            btnPrescribe.Click += (s, e) => {
                using (var prescForm = new Prescribe_Medicine(_patientId))
                {
                    if (prescForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPatientData(); // Refresh UI
                    }
                }
            };
            btnAddNote.Click += (s, e) => {
                using (var notesForm = new Clinical_Notes(_patientId))
                {
                    if (notesForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPatientData(); // Refresh UI
                    }
                }
            };
        }

        private DataGridView dgvApptHistory;

        private void UpdateProfileUI(List<Appointment> appts, List<Medication> meds, TreatmentPlan plan)
        {
            // Identity Card
            lblPatientName.Text = _patient.FullName;
            lblPatientId.Text = $"Patient ID: {_patient.PatientCode ?? _patient.PatientID.ToString()}";
            lblPatientInitials.Text = GetInitials(_patient.FullName);

            int age = DateTime.Today.Year - _patient.DateOfBirth.Year;
            lblInfoAgeGenVal.Text = $"{age} / {_patient.Gender}";
            lblInfoBloodVal.Text = _patient.BloodType ?? "N/A";
            lblInfoContactVal.Text = _patient.EmergencyPhone ?? "No contact set";
            lblInfoAddressVal.Text = _patient.Address ?? "No address recorded";

            // Smart Vitals Extraction (Pull from latest COMPLETED session if available)
            var latestCompleted = appts.FirstOrDefault(a => a.Status == "Completed");
            
            // Medical History (Vitals/Allergies Only)
            StringBuilder history = new StringBuilder();
            history.AppendLine($"● Height: {latestCompleted?.BloodPressure ?? _patient.Height ?? "N/A"}"); 
            history.AppendLine($"● Weight: {latestCompleted?.Weight ?? _patient.Weight ?? "N/A"}");
            history.AppendLine($"● Allergies: {_patient.Allergies ?? "None recorded"}");
            lblHistoryContent.Text = history.ToString();

            // Latest Appointments Card (New Panel & Grid)
            SetupAppointmentGrid(appts);
            
            // Medications
            if (meds != null && meds.Any())
            {
                StringBuilder medList = new StringBuilder();
                foreach (var m in meds)
                {
                    medList.AppendLine($"💊 {m.MedicationName} ({m.DosageUnit})");
                }
                lblMedsContent.Text = medList.ToString();
            }
            else lblMedsContent.Text = "No active prescriptions.";

            // Treatment Plan
            if (plan != null)
            {
                lblTreatmentContent.Text = $"{plan.PlanDetails}\n\nPERIOD: {plan.StartDate:MM/dd/yyyy} - {plan.EndDate:MM/dd/yyyy}";
            }
            else lblTreatmentContent.Text = "No active treatment plan set.";

            // Doctor Info (Top Bar)
            if (elnet_recoverease.Core.UserSession.CurrentStaff != null)
            {
                lblAvatarInitials.Text = GetInitials(elnet_recoverease.Core.UserSession.CurrentStaff.FullName);
            }
        }

        private void SetupAppointmentGrid(List<Appointment> appts)
        {
            if (dgvApptHistory == null)
            {
                Panel pnlAppts = new Panel {
                    BackColor = Color.White,
                    Location = new Point(16, 180),
                    Size = new Size(pnlHistory.Width - 32, 250),
                    Padding = new Padding(10)
                };
                
                Label lblTitle = new Label { 
                    Text = "LATEST APPOINTMENTS", 
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(27, 58, 107),
                    Dock = DockStyle.Top,
                    Height = 30
                };

                dgvApptHistory = new DataGridView {
                    Dock = DockStyle.Fill,
                    BackgroundColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AllowUserToAddRows = false,
                    RowHeadersVisible = false,
                    ReadOnly = true
                };

                dgvApptHistory.Columns.Add("Date", "DATE");
                dgvApptHistory.Columns.Add("Status", "STATUS");
                
                DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn {
                    Name = "Action",
                    Text = "VIEW",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "ACTION",
                    FlatStyle = FlatStyle.Flat
                };
                dgvApptHistory.Columns.Add(viewBtn);

                dgvApptHistory.CellContentClick += (s, e) => {
                    if (e.ColumnIndex == dgvApptHistory.Columns["Action"].Index && e.RowIndex >= 0)
                    {
                        var apptId = (int)dgvApptHistory.Rows[e.RowIndex].Tag;
                        new Clinical_Session(apptId).ShowDialog();
                        LoadPatientData(); // Refresh on return
                    }
                };

                pnlAppts.Controls.Add(dgvApptHistory);
                pnlAppts.Controls.Add(lblTitle);
                pnlHistory.Controls.Add(pnlAppts);
                pnlAppts.BringToFront();
            }

            dgvApptHistory.Rows.Clear();
            foreach (var a in appts)
            {
                int rowIndex = dgvApptHistory.Rows.Add(a.AppointmentDate?.ToShortDateString(), a.Status);
                dgvApptHistory.Rows[rowIndex].Tag = a.AppointmentID;
            }
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "P";
            var parts = name.Split(' ');
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }
    }
}
