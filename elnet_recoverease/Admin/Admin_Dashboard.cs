using elnet_recoverease.Core;
using elnet_recoverease.Models;
using System.Data;
using System.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Admin
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();

            SetupForm();
        }

        private void SetupForm()
        {
            try 
            { 
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\images\logo.png");
                if (!System.IO.File.Exists(logoPath)) logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) this.picLogo.Image = System.Drawing.Image.FromFile(logoPath); 
            } 
            catch { }
            
            // Navigation - Classic way (No lambdas in form)
            NavigationHelper.WireNavButton(this.btnNavStaff, new EventHandler(btnNavStaff_Click));
            NavigationHelper.WireNavButton(this.btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavProfile, new EventHandler(btnNavProfile_Click));
            NavigationHelper.WireNavButton(this.pnlAvatarTop, new EventHandler(btnNavProfile_Click));
            this.lblAvatarInitials.Click += new EventHandler(btnNavProfile_Click);
            this.btnLogout.Click += new EventHandler(btnLogout_Click);

            this.Load += new EventHandler(Admin_Dashboard_Load);
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            ScheduleManager.UpdateMissedSchedules();
            LoadDashboardData();
            this.ActiveControl = lblPageTitle;
            pnlContent.AutoScrollPosition = new Point(0, 0);
        }

        private void btnNavStaff_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Staff_List());
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Report());
        }

        private void btnNavPatients_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Medication_List());
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Profile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    // 1. Stats Summary - Optimized (using Count directly on DB)
                    lblStatPatientsVal.Text = db.Patients.Count().ToString();
                    lblStatDoctorsVal.Text = db.Staff.Count(s => s.Role == "Doctor" && s.Status == "Active").ToString();
                    
                    var today = DateOnly.FromDateTime(DateTime.Now);
                    // For AppointmentDate (DateTime), we need a range for today
                    var startToday = DateTime.Today;
                    var endToday = startToday.AddDays(1);
                    
                    var appointmentsToday = db.Appointments
                        .Count(a => a.AppointmentDate >= startToday && a.AppointmentDate < endToday);
                    
                    lblStatAppointmentsVal.Text = appointmentsToday.ToString();
                    lblStatAppointmentsSub.Text = $"{appointmentsToday} scheduled";

                    var missedMedsCount = db.MedicationSchedules
                        .Count(m => m.IsMissed && m.ScheduledDate == today);
                    lblStatMissedMedsVal.Text = missedMedsCount.ToString();
                    
                    if (missedMedsCount > 0)
                    {
                        lblAlertText.Text = $"{missedMedsCount} patients have missed medications today — follow-up recommended.";
                    }

                    // 2. Patient Adherence by Doctor - Optimized
                    LoadAdherenceData(db);

                    // 3. Recent Activity
                    LoadRecentActivity(db);

                    // 4. Recent Patients Table - Optimized
                    LoadRecentPatients(db);
                }
            }
            catch (Exception) { }
        }

        private void LoadAdherenceData(elnet_recoverease.Data.AppDbContext db)
        {
            flpAdherence.Controls.Clear();
            
            // Optimization: Get doctor stats in one go
            var doctorStats = db.Staff
                .Where(s => s.Role == "Doctor" && s.Status == "Active")
                .Select(doc => new {
                    doc.FullName,
                    TakenCount = db.MedicationSchedules
                        .Count(s => db.Patients.Where(p => p.AttendingDoctor == doc.FullName).Select(p => p.PatientID).Contains(s.PatientID) && s.IsTaken),
                    TotalCount = db.MedicationSchedules
                        .Count(s => db.Patients.Where(p => p.AttendingDoctor == doc.FullName).Select(p => p.PatientID).Contains(s.PatientID))
                })
                .ToList();

            foreach (var stats in doctorStats)
            {
                int percentage = stats.TotalCount > 0 ? (int)(stats.TakenCount * 100.0 / stats.TotalCount) : 0;
                AddAdherenceItem(stats.FullName, percentage);
            }

            if (doctorStats.Count == 0)
            {
                flpAdherence.Controls.Add(new Label { Text = "No data", ForeColor = Color.Gray, AutoSize = true });
            }
        }

        private void AddAdherenceItem(string name, int percentage)
        {
            var pnl = new Panel { Width = flpAdherence.Width - 25, Height = 40, Margin = new Padding(0, 0, 0, 5) };
            var lblName = new Label { Text = name, AutoSize = true, Location = new Point(0, 5), Font = new Font("Segoe UI", 9) };
            
            var pnlBarBg = new Panel { Width = 120, Height = 6, BackColor = Color.FromArgb(237, 242, 247), Location = new Point(120, 12) };
            var pnlBarFill = new Panel { Width = (int)(120 * (percentage / 100.0)), Height = 6, BackColor = Color.FromArgb(49, 151, 149), Dock = DockStyle.Left };
            pnlBarBg.Controls.Add(pnlBarFill);

            var lblPct = new Label { Text = $"{percentage}%", AutoSize = true, Location = new Point(250, 5), Font = new Font("Segoe UI", 9, FontStyle.Bold) };

            pnl.Controls.Add(lblName);
            pnl.Controls.Add(pnlBarBg);
            pnl.Controls.Add(lblPct);
            flpAdherence.Controls.Add(pnl);
        }

        private void LoadRecentActivity(elnet_recoverease.Data.AppDbContext db)
        {
            flpActivity.Controls.Clear();

            var patients = db.Patients.OrderByDescending(p => p.CreatedAt).Take(3).ToList();
            foreach (var p in patients)
            {
                AddActivityItem("👤", $"New patient {p.FullName}", "Recently");
            }

            var missedMeds = db.MedicationSchedules
                .Where(m => m.IsMissed)
                .OrderByDescending(m => m.ScheduledDate)
                .Take(2)
                .Select(m => new { m.PatientID })
                .ToList();

            foreach (var m in missedMeds)
            {
                var p = db.Patients.Find(m.PatientID);
                AddActivityItem("💊", $"{p?.FullName ?? "Patient"} missed medication", "Action req.");
            }
        }

        private void AddActivityItem(string icon, string text, string time)
        {
            var pnl = new Panel { Width = flpActivity.Width - 25, Height = 50, Margin = new Padding(0, 0, 0, 5) };
            var lblIcon = new Label { Text = icon, Font = new Font("Segoe UI", 12), Location = new Point(5, 5), Size = new Size(25, 25) };
            var lblText = new Label { Text = text, AutoSize = true, Location = new Point(35, 5), Font = new Font("Segoe UI", 8, FontStyle.Bold) };
            var lblTime = new Label { Text = time, AutoSize = true, Location = new Point(35, 22), ForeColor = Color.Gray, Font = new Font("Segoe UI", 7) };

            pnl.Controls.Add(lblIcon);
            pnl.Controls.Add(lblText);
            pnl.Controls.Add(lblTime);
            flpActivity.Controls.Add(pnl);
        }

        private void LoadRecentPatients(elnet_recoverease.Data.AppDbContext db)
        {
            // Optimization: Fetch only what's needed for the top 10 patients
            var now = DateTime.Now;
            var data = db.Patients
                .OrderByDescending(p => p.CreatedAt)
                .Take(10)
                .Select(p => new {
                    p.FullName,
                    Doctor = p.AttendingDoctor,
                    Plan = "Standard",
                    NextApptDate = db.Appointments
                        .Where(a => a.PatientID == p.PatientID && a.AppointmentDate >= now)
                        .OrderBy(a => a.AppointmentDate)
                        .Select(a => a.AppointmentDate)
                        .FirstOrDefault(),
                    AdherenceValue = db.MedicationSchedules.Where(s => s.PatientID == p.PatientID).Count() > 0
                        ? (int)(db.MedicationSchedules.Where(s => s.PatientID == p.PatientID && s.IsTaken).Count() * 100.0 / db.MedicationSchedules.Where(s => s.PatientID == p.PatientID).Count())
                        : 0,
                    p.Status
                })
                .ToList()
                .Select(x => new {
                    x.FullName,
                    x.Doctor,
                    x.Plan,
                    NextAppt = x.NextApptDate?.ToString("MMM dd") ?? "None",
                    Adherence = $"{x.AdherenceValue}%",
                    x.Status
                }).ToList();

            dgvRecentPatients.DataSource = data;
        }
    }
}
