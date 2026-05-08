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
using elnet_recoverease.Admin;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Doctor
{
    public partial class Doctor_Dashboard : Form
    {
        private AppDbContext _db = new AppDbContext();
        private Staff _doctor;
        private System.Windows.Forms.Timer _notifTimer;

        public Doctor_Dashboard()
        {
            InitializeComponent();
            _doctor = UserSession.CurrentStaff;


            InitializeDashboard();
            InitializeAsyncData();
            StartNotifTimer();
        }

        private async void InitializeAsyncData()
        {
            await CheckPastAppointments();
            LoadDashboardData();
        }

        private void StartNotifTimer()
        {
            _notifTimer = new System.Windows.Forms.Timer();
            _notifTimer.Interval = 60000; // 1 minute
            _notifTimer.Tick += new System.EventHandler(Timer_Tick);
            _notifTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private async Task CheckPastAppointments()
        {
            try
            {
                if (_doctor == null) return;
                var now = DateTime.Now;
                var pastThreshold = now.AddMinutes(-30);

                var pastScheduled = await _db.Appointments
                    .Where(a => (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)) 
                           && a.Status == "Scheduled" && a.AppointmentDate < pastThreshold)
                    .ToListAsync();

                if (pastScheduled.Any())
                {
                    foreach (var appt in pastScheduled) appt.Status = "Missed";
                    await _db.SaveChangesAsync();
                }
            }
            catch { }
        }

        private void InitializeDashboard()
        {
            if (_doctor != null)
            {
                lblWelcome.Text = $"Welcome, Dr. {_doctor.FullName}.";
                lblAvatarInitials.Text = GetInitials(_doctor.FullName);
            }

            try 
            { 
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) picLogo.Image = Image.FromFile(logoPath);
            } 
            catch { }

            // Navigation Handlers - Classic way
            NavigationHelper.WireNavButton(btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(btnNavAppointments, new EventHandler(btnNavAppointments_Click));
            NavigationHelper.WireNavButton(btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(btnNavProfile, new EventHandler(btnNavProfile_Click));
            btnLogout.Click += new EventHandler(btnLogout_Click);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e) { }
        private void btnNavPatients_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Patient_List()); }
        private void btnNavAppointments_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Appointments()); }
        private void btnNavReports_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Reports()); }
        private void btnNavProfile_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Doctor_Profile()); }
        private void btnLogout_Click(object sender, EventArgs e) { NavigationHelper.Logout(this); }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "Dr";
            var parts = name.Split(' ');
            if (parts.Length == 1) return parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private async void LoadDashboardData()
        {
            try
            {
                ScheduleManager.UpdateMissedSchedules();
                if (_doctor == null) return;

                // 1. Stats Summary - Optimized queries
                int totalPatients = await _db.Patients.CountAsync(p => p.AttendingDoctor == _doctor.FullName);
                lblCardPatValue.Text = totalPatients.ToString();

                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);
                var now = DateTime.Now;

                var apptsToday = await _db.Appointments
                    .Where(a => a.AppointmentDate >= today && a.AppointmentDate < tomorrow 
                           && (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)))
                    .Join(_db.Patients, a => (int)a.PatientID, p => p.PatientID, (a, p) => new { a, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName)
                    .Select(x => new { x.a.AppointmentDate, x.p.FullName, x.a.Notes, x.a.Status })
                    .ToListAsync();
                
                lblCardApptValue.Text = apptsToday.Count.ToString();
                lblCardApptSub.Text = $"{apptsToday.Count(x => x.Status == "Completed")} completed";

                var missedMeds = await _db.MedicationSchedules
                    .Where(s => s.IsMissed && !s.IsTaken)
                    .Join(_db.Patients, s => s.PatientID, p => p.PatientID, (s, p) => new { s, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName)
                    .Select(x => new { x.s.ScheduledDate, x.s.ScheduledTime, x.p.PatientID, x.p.FullName })
                    .ToListAsync();

                var takenMeds = await _db.MedicationSchedules
                    .Where(s => s.IsTaken && s.ScheduledDate == DateOnly.FromDateTime(today))
                    .Join(_db.Patients, s => s.PatientID, p => p.PatientID, (s, p) => new { s, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName)
                    .Select(x => new { x.p.PatientID, x.p.FullName, x.s.MedicationName, x.s.ScheduledDate, x.s.ScheduledTime })
                    .ToListAsync();

                lblCardAlertValue.Text = missedMeds.Count.ToString();
                lblCardAlertValue.ForeColor = missedMeds.Count > 0 ? Color.FromArgb(192, 57, 43) : Color.FromArgb(0, 168, 168);

                // 2. Load Schedule Table
                dgvSchedule.Rows.Clear();
                foreach (var item in apptsToday.OrderBy(x => x.AppointmentDate))
                {
                    dgvSchedule.Rows.Add(
                        item.AppointmentDate?.ToString("hh:mm tt") ?? "N/A",
                        item.FullName,
                        item.Notes,
                        item.Status
                    );
                }

                // 3. Generate Alerts
                GenerateAlerts(missedMeds.Select(m => new { m.PatientID, m.FullName, m.ScheduledDate, m.ScheduledTime }).ToList(), 
                               apptsToday.Select(a => new { a.AppointmentDate, a.FullName, a.Status }).ToList(),
                               takenMeds.Select(t => new { t.PatientID, t.FullName, t.MedicationName, t.ScheduledDate, t.ScheduledTime }).ToList());
            }
            catch (Exception) { }
        }

        private void GenerateAlerts(IEnumerable<dynamic> missedMeds, IEnumerable<dynamic> appts, IEnumerable<dynamic> takenMeds)
        {
            var alerts = new List<DoctorAlert>();
            var now = DateTime.Now;

            // Missed Meds
            var grouped = missedMeds.GroupBy(x => x.PatientID);
            foreach (var group in grouped)
            {
                var days = group.Select(x => x.ScheduledDate).Distinct().Count();
                var latest = group.OrderByDescending(x => x.ScheduledDate).First(); // Just use the date for grouping time
                string timeStr = latest.ScheduledTime != null ? latest.ScheduledTime.ToString("hh:mm tt") : "";
                string dateStr = latest.ScheduledDate == DateOnly.FromDateTime(DateTime.Today) ? "Today" : latest.ScheduledDate.ToString("MMM dd");
                string formattedTime = string.IsNullOrEmpty(timeStr) ? dateStr : $"{dateStr}, {timeStr}";

                if (days >= 2)
                {
                    alerts.Add(new DoctorAlert { Priority = "Urgent", Icon = "🔴", Title = $"{group.First().FullName} missed meds for {days} days", TimeText = formattedTime });
                }
                else if (days == 1)
                {
                    alerts.Add(new DoctorAlert { Priority = "Warning", Icon = "🟡", Title = $"{group.First().FullName} missed meds recently", TimeText = formattedTime });
                }
            }

            // Taken Meds
            foreach(var taken in takenMeds)
            {
                string timeStr = taken.ScheduledTime != null ? taken.ScheduledTime.ToString("hh:mm tt") : "";
                string dateStr = taken.ScheduledDate == DateOnly.FromDateTime(DateTime.Today) ? "Today" : taken.ScheduledDate.ToString("MMM dd");
                string formattedTime = string.IsNullOrEmpty(timeStr) ? dateStr : $"{dateStr}, {timeStr}";

                alerts.Add(new DoctorAlert { Priority = "Info", Icon = "🟢", Title = $"{taken.FullName} took {taken.MedicationName}", TimeText = formattedTime });
            }

            // Appts
            foreach (var appt in appts)
            {
                if (appt.AppointmentDate == null) continue;
                DateTime dt = appt.AppointmentDate;
                if (appt.Status == "Missed" && dt.Date == DateTime.Today)
                    alerts.Add(new DoctorAlert { Priority = "Urgent", Icon = "🔴", Title = $"{appt.FullName} missed appointment", TimeText = dt.ToString("hh:mm tt") });
                else if (dt > now && dt <= now.AddHours(2) && appt.Status == "Scheduled")
                    alerts.Add(new DoctorAlert { Priority = "Warning", Icon = "🟡", Title = $"Appt with {appt.FullName} in 2h", TimeText = "Upcoming" });
            }

            var sorted = alerts.OrderBy(a => a.Priority == "Urgent" ? 0 : a.Priority == "Warning" ? 1 : 2).ToList();
            DisplayAlerts(sorted);
        }

        private void DisplayAlerts(List<DoctorAlert> alerts)
        {
            pnlAlert1.Visible = alerts.Count > 0;
            pnlAlert2.Visible = alerts.Count > 1;
            pnlAlert3.Visible = alerts.Count > 2;

            if (alerts.Count > 0) { lblAlert1Icon.Text = alerts[0].Icon; lblAlert1Text.Text = alerts[0].Title; lblAlert1Time.Text = alerts[0].TimeText; }
            if (alerts.Count > 1) { lblAlert2Icon.Text = alerts[1].Icon; lblAlert2Text.Text = alerts[1].Title; lblAlert2Time.Text = alerts[1].TimeText; }
            if (alerts.Count > 2) { lblAlert3Icon.Text = alerts[2].Icon; lblAlert3Text.Text = alerts[2].Title; lblAlert3Time.Text = alerts[2].TimeText; }
        }

        private class DoctorAlert
        {
            public string Priority { get; set; } = "Info";
            public string Icon { get; set; } = "🔵";
            public string Title { get; set; } = "";
            public string TimeText { get; set; } = "";
        }
    }
}
