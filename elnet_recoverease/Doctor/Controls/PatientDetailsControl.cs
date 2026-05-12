using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System.Linq;
using System.Collections.Generic;
using elnet_recoverease.Core;
using elnet_recoverease.Doctor.Forms;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace elnet_recoverease.Doctor.Controls
{
    public partial class PatientDetailsControl : UserControl
    {
        private AppDbContext _db = new AppDbContext();
        private int _patientId;
        private elnet_recoverease.Models.Patient _patient;
        private List<Appointment> _currentAppts;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nL, int nT, int nR, int nB, int nW, int nH);

        public PatientDetailsControl(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
        }

        private void PatientDetailsControl_Load(object sender, EventArgs e) => LoadPatientData();

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is DoctorMainForm main) main.LoadPatientList();
        }

        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            using (var form = new Treatment_Plan_Form(_patientId))
            {
                if (form.ShowDialog() == DialogResult.OK) LoadPatientData();
            }
        }

        private void LoadPatientData()
        {
            using (var db = new AppDbContext())
            {
                _patient = db.Patients.FirstOrDefault(p => p.PatientID == _patientId);
                if (_patient == null) return;
                
                var appts = db.Appointments
                    .Where(a => a.PatientID == _patientId && a.Status == "Completed")
                    .OrderByDescending(a => a.AppointmentDate).ToList();

                var medIds = db.MedicationSchedules.Where(ms => ms.PatientID == _patientId).Select(ms => ms.MedicationID).Distinct().ToList();
                var meds = db.Medications.Where(m => medIds.Contains(m.MedicationID)).ToList();

                lblPatientName.Text = _patient.FullName;
                lblPatientId.Text = $"Patient ID: {_patient.PatientID:D4}";

                // Status Badge
                lblStatusBadge.Text = (_patient.Status ?? "Active").ToUpper();
                if (lblStatusBadge.Text == "DISCHARGED")
                {
                    lblStatusBadge.BackColor = Color.FromArgb(71, 85, 105); // Slate
                    btnActivate.Text = "↺ Re-activate Patient";
                    btnActivate.BackColor = Color.FromArgb(0, 168, 168); // Teal for primary action
                    btnActivate.ForeColor = Color.White;
                    btnActivate.FlatAppearance.BorderColor = Color.FromArgb(0, 168, 168);
                }
                else
                {
                    lblStatusBadge.BackColor = Color.FromArgb(0, 168, 168); // Teal
                    btnActivate.Text = "Discharge Patient";
                    btnActivate.BackColor = Color.White;
                    btnActivate.ForeColor = Color.FromArgb(71, 85, 105);
                    btnActivate.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
                }

                // Apply region after text is set for AutoSize to take effect
                this.BeginInvoke((MethodInvoker)delegate {
                    if (lblStatusBadge.Width > 0)
                        lblStatusBadge.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lblStatusBadge.Width, lblStatusBadge.Height, 8, 8));
                });

                // Ensure buttons are visible and properly parented
                if (!pnlPatientHeader.Controls.Contains(btnActivate)) pnlPatientHeader.Controls.Add(btnActivate);
                
                btnActivate.Visible = true;
                btnActivate.BringToFront();
                
                // Position status action button explicitly
                btnActivate.Location = new Point(pnlPatientHeader.Width - btnActivate.Width - 25, 35);

                // Hide update plan button if patient is discharged
                btnUpdatePlan.Visible = (lblStatusBadge.Text != "DISCHARGED");
                if (btnUpdatePlan.Visible) btnUpdatePlan.BringToFront();

                // Update Labels and Panels (Reuse logic from Form version)
                PopulateMedInfo(appts.FirstOrDefault());
                PopulateVitals(appts.FirstOrDefault());
                PopulateMedCards(meds);
                SetupAppointmentGrid(appts);
                LoadDiagnosisInfo(db);
            }
        }

        private void LoadDiagnosisInfo(AppDbContext db)
        {
            var latestPlan = db.TreatmentPlans.Where(tp => tp.PatientID == _patientId).OrderByDescending(tp => tp.CreatedAt).FirstOrDefault();
            pnlDiagGoals.Controls.Clear();
            pnlDiagGoals.Controls.Add(new Label { Text = "📋 Clinical Observations", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(27, 58, 107), AutoSize = true });

            string content = latestPlan?.PlanDetails ?? "No active treatment plan recorded.";
            var lbl = new Label { Text = content, Location = new Point(25, 70), Size = new Size(pnlDiagGoals.Width - 50, 250), Font = new Font("Segoe UI", 9.5f), ForeColor = Color.FromArgb(71, 85, 105) };
            pnlDiagGoals.Controls.Add(lbl);
        }

        private void PopulateMedInfo(Appointment latest)
        {
            pnlMedInfo.Controls.Clear();
            pnlMedInfo.Controls.Add(new Label { Text = "Medical Information", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(27, 58, 107), AutoSize = true });
            AddMedInfoCard(pnlMedInfo, "HEIGHT", latest?.Height ?? _patient.Height ?? "N/A", 25, 75);
            AddMedInfoCard(pnlMedInfo, "WEIGHT", latest?.Weight ?? _patient.Weight ?? "N/A", 245, 75);
            AddMedInfoCard(pnlMedInfo, "BLOOD TYPE", _patient.BloodType ?? "N/A", 25, 160);
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
            pnlLatestVitals.Controls.Add(new Label { Text = "⚡ Latest Vitals", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(0, 168, 168), AutoSize = true });
            int y = 75;
            AddVitalCard(pnlLatestVitals, "BP", latest?.BloodPressure ?? "N/A", 25, y); y += 85;
            AddVitalCard(pnlLatestVitals, "HR", latest?.HeartRate != null ? $"{latest.HeartRate} bpm" : "N/A", 25, y); y += 85;
            AddVitalCard(pnlLatestVitals, "TEMP", latest?.Temperature != null ? $"{latest.Temperature}°C" : "N/A", 25, y);
        }

        private void AddVitalCard(Panel parent, string title, string val, int x, int y)
        {
            var pnl = new Panel { Width = parent.Width - 50, Height = 75, Location = new Point(x, y), BackColor = Color.FromArgb(245, 248, 250), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            pnl.Controls.Add(new Label { Text = title, Location = new Point(15, 15), AutoSize = true, Font = new Font("Segoe UI", 8.5f), ForeColor = Color.Gray });
            pnl.Controls.Add(new Label { Text = val, Location = new Point(15, 38), AutoSize = true, Font = new Font("Segoe UI", 13, FontStyle.Bold), ForeColor = Color.FromArgb(30, 43, 60) });
            parent.Controls.Add(pnl);
        }

        private void PopulateMedCards(List<Medication> meds)
        {
            pnlCurrentMeds.Controls.Clear();
            pnlCurrentMeds.Controls.Add(new Label { Text = "💊 Prescriptions", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(27, 58, 107), AutoSize = true });
            int y = 75;
            foreach (var m in meds) {
                var card = new Panel { Width = pnlCurrentMeds.Width - 50, Height = 70, Location = new Point(25, y), BackColor = Color.FromArgb(245, 248, 250), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
                card.Controls.Add(new Label { Text = m.MedicationName, Location = new Point(15, 15), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) });
                pnlCurrentMeds.Controls.Add(card); y += 80;
            }
        }

        private void SetupAppointmentGrid(List<Appointment> appts)
        {
            _currentAppts = appts;
            pnlApptHistory.Controls.Clear();
            pnlApptHistory.Controls.Add(new Label { Text = "🗓️ History", Location = new Point(25, 25), Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(27, 58, 107), AutoSize = true });
            var dgv = new DataGridView { Location = new Point(25, 70), Size = new Size(pnlApptHistory.Width - 50, 200), BackgroundColor = Color.White, BorderStyle = BorderStyle.None, SelectionMode = DataGridViewSelectionMode.FullRowSelect, RowHeadersVisible = false, AllowUserToAddRows = false, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
            dgv.DataSource = appts.Select(a => new { Date = a.AppointmentDate?.ToString("MMM dd, yyyy"), Status = a.Status, Action = "View Details" }).ToList();
            
            dgv.CellContentClick += (s, e) => {
                if (e.RowIndex >= 0 && _currentAppts != null) {
                    var appt = _currentAppts[e.RowIndex];
                    using (var session = new Clinical_Session(appt.AppointmentID)) {
                        session.ShowDialog();
                        LoadPatientData();
                    }
                }
            };
            
            pnlApptHistory.Controls.Add(dgv);
        }

        private async void btnActivate_Click(object sender, EventArgs e)
        {
            string currentStatus = _patient.Status ?? "Active";
            string newStatus = currentStatus == "Discharged" ? "Active" : "Discharged";
            string confirmMsg = currentStatus == "Discharged" 
                ? $"Are you sure you want to re-activate {_patient.FullName} for new treatment?" 
                : $"Are you sure you want to discharge {_patient.FullName} from active care?";

            if (MessageBox.Show(confirmMsg, "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new AppDbContext())
                {
                    var p = db.Patients.Find(_patientId);
                    if (p != null)
                    {
                        p.Status = newStatus;
                        await db.SaveChangesAsync();
                        LoadPatientData();
                    }
                }
            }
        }
    }
}
