using elnet_recoverease.Core;
using elnet_recoverease.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

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
                    var totalPatients = db.Patients.Count();
                    lblStatPatientsVal.Text = totalPatients.ToString();
                    
                    var activeDoctors = db.Staff.Count(s => s.Role == "Doctor" && s.Status == "Active");
                    lblStatDoctorsVal.Text = activeDoctors.ToString();
                    
                    var today = DateOnly.FromDateTime(DateTime.Now);
                    var appointmentsToday = db.Appointments.AsEnumerable()
                        .Count(a => a.AppointmentDate.HasValue && DateOnly.FromDateTime(a.AppointmentDate.Value) == today);
                    lblStatAppointmentsVal.Text = appointmentsToday.ToString();
                    lblStatAppointmentsSub.Text = $"{appointmentsToday} remaining"; // Simplified logic

                    var missedMedsCount = db.MedicationSchedules.Count(m => m.IsMissed && m.ScheduledDate == today);
                    lblStatMissedMedsVal.Text = missedMedsCount.ToString();
                    
                    // Critical Alert Visibility
                    pnlCriticalAlert.Visible = missedMedsCount > 0;
                    if (missedMedsCount > 0)
                    {
                        lblAlertText.Text = $"{missedMedsCount} patients have missed their scheduled medications today — immediate follow-up recommended.";
                    }

                    // 2. Patient Adherence by Doctor
                    LoadAdherenceData(db);

                    // 3. Recent Activity
                    LoadRecentActivity(db);

                    // 4. Recent Patients Table
                    LoadRecentPatients(db);
                }
            }
            catch (Exception)
            {
                // Silence or log
            }
        }

        private void LoadAdherenceData(elnet_recoverease.Data.AppDbContext db)
        {
            flpAdherence.Controls.Clear();
            var doctors = db.Staff.Where(s => s.Role == "Doctor" && s.Status == "Active").ToList();
            var allPatients = db.Patients.ToList();
            var allSchedules = db.MedicationSchedules.ToList();

            foreach (var doc in doctors)
            {
                // Find patients for this doctor
                var docPatients = allPatients.Where(p => p.AttendingDoctor == doc.FullName).Select(p => p.PatientID).ToList();
                
                int percentage = 0;
                if (docPatients.Count > 0)
                {
                    // Find schedules for these patients
                    var docSchedules = allSchedules.Where(s => docPatients.Contains(s.PatientID)).ToList();
                    if (docSchedules.Count > 0)
                    {
                        int taken = docSchedules.Count(s => s.IsTaken);
                        percentage = (int)((taken * 100.0) / docSchedules.Count);
                    }
                }

                AddAdherenceItem(doc.FullName, percentage);
            }

            if (doctors.Count == 0)
            {
                flpAdherence.Controls.Add(new Label { Text = "No doctor data available", ForeColor = Color.Gray, AutoSize = true, Font = new Font("Segoe UI", 9) });
            }
        }

        private void AddAdherenceItem(string name, int percentage)
        {
            var pnl = new Panel { Width = flpAdherence.Width - 25, Height = 50, Margin = new Padding(0, 0, 0, 10) };
            var lblName = new Label { Text = name, AutoSize = true, Location = new Point(0, 5), Font = new Font("Segoe UI", 9) };
            
            var pnlBarBg = new Panel { Width = 150, Height = 8, BackColor = Color.FromArgb(237, 242, 247), Location = new Point(120, 12) };
            var pnlBarFill = new Panel { Width = (int)(150 * (percentage / 100.0)), Height = 8, BackColor = Color.FromArgb(49, 151, 149), Dock = DockStyle.Left };
            pnlBarBg.Controls.Add(pnlBarFill);

            var lblPct = new Label { Text = $"{percentage}%", AutoSize = true, Location = new Point(280, 5), Font = new Font("Segoe UI", 9, FontStyle.Bold) };

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
                AddActivityItem("👤", $"New patient {p.FullName} registered", "1 hr ago");
            }

            var missedMeds = db.MedicationSchedules.Where(m => m.IsMissed).OrderByDescending(m => m.ScheduledDate).Take(2).ToList();
            foreach (var m in missedMeds)
            {
                var p = db.Patients.Find(m.PatientID);
                AddActivityItem("💊", $"{p?.FullName ?? "Patient"} missed morning medication", "10 min ago");
            }
        }

        private void AddActivityItem(string icon, string text, string time)
        {
            var pnl = new Panel { Width = flpActivity.Width - 25, Height = 60, Margin = new Padding(0, 0, 0, 10) };
            var lblIcon = new Label { Text = icon, Font = new Font("Segoe UI", 14), Location = new Point(5, 10), Size = new Size(30, 30), TextAlign = ContentAlignment.MiddleCenter };
            var lblText = new Label { Text = text, AutoSize = true, Location = new Point(45, 10), Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            var lblTime = new Label { Text = time, AutoSize = true, Location = new Point(45, 30), ForeColor = Color.Gray, Font = new Font("Segoe UI", 8) };

            pnl.Controls.Add(lblIcon);
            pnl.Controls.Add(lblText);
            pnl.Controls.Add(lblTime);
            flpActivity.Controls.Add(pnl);
        }

        private void LoadRecentPatients(elnet_recoverease.Data.AppDbContext db)
        {
            var recentPatients = db.Patients
                .OrderByDescending(p => p.CreatedAt)
                .Take(10)
                .ToList();

            var schedules = db.MedicationSchedules.ToList();
            var appointments = db.Appointments.ToList();

            var data = recentPatients.Select(p => {
                // Calculate patient specific adherence
                var pSchedules = schedules.Where(s => s.PatientID == p.PatientID).ToList();
                string adherence = "0%";
                if (pSchedules.Count > 0)
                {
                    int taken = pSchedules.Count(s => s.IsTaken);
                    adherence = $"{(int)((taken * 100.0) / pSchedules.Count)}%";
                }

                // Get next appointment
                var nextAppt = appointments
                    .Where(a => a.PatientID == p.PatientID && a.AppointmentDate >= DateTime.Now)
                    .OrderBy(a => a.AppointmentDate)
                    .FirstOrDefault();
                string apptStr = nextAppt?.AppointmentDate?.ToString("MMM dd, yyyy") ?? "No appt";

                return new
                {
                    p.FullName,
                    Doctor = p.AttendingDoctor,
                    Plan = "Standard", // This could be a real field in Patient if needed
                    NextAppt = apptStr,
                    Adherence = adherence,
                    p.Status
                };
            }).ToList();

            dgvRecentPatients.DataSource = data;
        }
    }
}

