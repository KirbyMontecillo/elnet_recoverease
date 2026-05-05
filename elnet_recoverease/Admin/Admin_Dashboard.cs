using elnet_recoverease.Core;
using System.Windows.Forms.DataVisualization.Charting;

namespace elnet_recoverease.Admin
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
            try { this.picLogo.Image = System.Drawing.Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }
            
            // Wire up navigation
            NavigationHelper.WireNavButton(this.btnNavStaff, () => NavigationHelper.SwitchForm(this, new Staff_List()));
            NavigationHelper.WireNavButton(this.btnNavReports, () => NavigationHelper.SwitchForm(this, new Admin_Report()));
            NavigationHelper.WireNavButton(this.btnNavPatients, () => NavigationHelper.SwitchForm(this, new Medication_List()));
            this.btnLogout.Click += (s, e) => NavigationHelper.Logout(this);

            this.Load += (s, e) => {
                LoadDashboardData();
            };
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    // 1. Stats Summary
                    lblStatTotalUsersVal.Text = db.Users.Count().ToString();
                    lblStatActiveStaffVal.Text = db.Staff.Count(s => s.Status == "Active").ToString();
                    lblStatTotalPatientsVal.Text = db.Patients.Count().ToString();

                    // 2. Alerts Panel
                    LoadAlerts(db);

                    // 3. Recent Activity
                    LoadRecentActivity(db);
                }
            }
            catch (Exception ex)
            {
                // Silence or log
            }
        }

        private void LoadAlerts(elnet_recoverease.Data.AppDbContext db)
        {
            flpAlerts.Controls.Clear();
            
            // Missed Medications
            var missedMeds = db.MedicationSchedules
                .Where(m => m.IsMissed)
                .OrderByDescending(m => m.ScheduledDate)
                .Take(5)
                .ToList();

            foreach (var med in missedMeds)
            {
                var p = db.Patients.Find(med.PatientID);
                AddAlertItem($"Missed Med: {p?.FullName ?? "Unknown"}", Color.FromArgb(255, 235, 238), Color.FromArgb(198, 40, 40));
            }

            // Missed Appointments
            var missedApps = db.Appointments
                .Where(a => a.Status == "Missed")
                .OrderByDescending(a => a.AppointmentDate)
                .Take(5)
                .ToList();

            foreach (var app in missedApps)
            {
                var p = db.Patients.Find(app.PatientID);
                AddAlertItem($"Missed Appt: {p?.FullName ?? "Unknown"}", Color.FromArgb(255, 243, 224), Color.FromArgb(239, 108, 0));
            }

            if (flpAlerts.Controls.Count == 0)
            {
                var lbl = new Label { Text = "No critical alerts", ForeColor = Color.Gray, AutoSize = true, Padding = new Padding(10) };
                flpAlerts.Controls.Add(lbl);
            }
        }

        private void AddAlertItem(string text, Color bgColor, Color textColor)
        {
            var pnl = new Panel
            {
                Width = flpAlerts.Width - 30,
                Height = 45,
                BackColor = bgColor,
                Padding = new Padding(10),
                Margin = new Padding(0, 0, 0, 8)
            };
            var lbl = new Label
            {
                Text = text,
                ForeColor = textColor,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };
            pnl.Controls.Add(lbl);
            flpAlerts.Controls.Add(pnl);
        }

        private void LoadRecentActivity(elnet_recoverease.Data.AppDbContext db)
        {
            flpActivity.Controls.Clear();

            var patients = db.Patients.OrderByDescending(p => p.CreatedAt).Take(5).Select(p => new { Msg = $"New Patient: {p.FirstName} {p.LastName}", Date = p.CreatedAt }).ToList();
            var staff = db.Staff.OrderByDescending(s => s.CreatedAt).Take(5).Select(s => new { Msg = $"New Staff: {s.FullName}", Date = s.CreatedAt }).ToList();

            var combined = patients.Cast<dynamic>().Concat(staff.Cast<dynamic>())
                .OrderByDescending(x => x.Date)
                .Take(10);

            foreach (var act in combined)
            {
                var lbl = new Label
                {
                    Text = $"• {act.Msg} ({act.Date:MM/dd HH:mm})",
                    AutoSize = true,
                    Width = flpActivity.Width - 20,
                    Padding = new Padding(5),
                    Font = new Font("Segoe UI", 9)
                };
                flpActivity.Controls.Add(lbl);
            }
        }
    }
}

