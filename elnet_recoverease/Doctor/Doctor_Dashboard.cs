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
            await CheckPastAppointments(); // Run once on login
            LoadData();
        }

        private void StartNotifTimer()
        {
            _notifTimer = new System.Windows.Forms.Timer();
            _notifTimer.Interval = 60000; // 1 minute
            _notifTimer.Tick += (s, e) => LoadData();
            _notifTimer.Start();
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
            // Set welcome message
            if (_doctor != null)
            {
                lblWelcome.Text = $"Welcome back, Dr. {_doctor.FullName}. Here's your clinical overview for today.";
                lblAvatarInitials.Text = GetInitials(_doctor.FullName);
            }

            // Set Logo
            try 
            { 
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) picLogo.Image = Image.FromFile(logoPath);
            } 
            catch { }

            // Navigation Handlers
            NavigationHelper.WireNavButton(btnNavDashboard, () => { });
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
                c.Cursor = Cursors.Hand;
            }
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "Dr";
            var parts = name.Split(' ');
            if (parts.Length == 1) return parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private void OpenForm(Form childForm)
        {
            childForm.Show();
            // In a real MDI setup, we might dock it, but for now we'll just show it.
        }

        private async void LoadData()
        {
            try
            {
                if (_doctor == null) return;

                // 1. Total Patients under this doctor
                int totalPatients = await _db.Patients.CountAsync(p => p.AttendingDoctor == _doctor.FullName);
                lblCardPatValue.Text = totalPatients.ToString();

                // 2. Appointments Today - Filter by StaffID
                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);
                var dayAfter = today.AddDays(2);
                var now = DateTime.Now;

                // Auto-mark missed during refresh
                var pastThreshold = now.AddMinutes(-30);
                var missedToUpdate = await _db.Appointments
                    .Where(a => (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)) 
                           && a.Status == "Scheduled" && a.AppointmentDate < pastThreshold)
                    .ToListAsync();
                
                if (missedToUpdate.Any())
                {
                    foreach (var a in missedToUpdate) a.Status = "Missed";
                    await _db.SaveChangesAsync();
                }

                var apptsToday = await _db.Appointments
                    .Where(a => a.AppointmentDate >= today && a.AppointmentDate < tomorrow 
                           && (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)))
                    .Join(_db.Patients, a => (int)a.PatientID, p => p.PatientID, (a, p) => new { a, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName) // Strict patient assignment check
                    .ToListAsync();
                
                lblCardApptValue.Text = apptsToday.Count.ToString();
                lblCardApptSub.Text = $"{apptsToday.Count(x => x.a.Status == "Completed")} completed today";

                // 3. Clinical Alerts (Missed Meds)
                var missedMeds = await _db.MedicationSchedules
                    .Where(s => s.IsMissed && !s.IsTaken)
                    .Join(_db.Patients, s => s.PatientID, p => p.PatientID, (s, p) => new { s, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName)
                    .ToListAsync();

                lblCardAlertValue.Text = missedMeds.Count.ToString();
                lblCardAlertSub.Text = missedMeds.Count > 0 ? $"{missedMeds.Count} critical issues" : "All patients on track";
                lblCardAlertValue.ForeColor = missedMeds.Count > 0 ? Color.FromArgb(192, 57, 43) : Color.FromArgb(0, 168, 168);

                // 4. Load Schedule Table
                dgvSchedule.Rows.Clear();
                foreach (var item in apptsToday.OrderBy(x => x.a.AppointmentDate))
                {
                    dgvSchedule.Rows.Add(
                        item.a.AppointmentDate?.ToString("hh:mm tt") ?? "N/A",
                        item.p.FullName,
                        item.a.Notes,
                        item.a.Status
                    );
                }

                // 5. Generate Advanced Alerts
                var doctorAlerts = new List<DoctorAlert>();

                // A. Missed Meds
                var groupedMissed = missedMeds.GroupBy(x => x.p.PatientID);
                foreach (var group in groupedMissed)
                {
                    var patient = group.First().p;
                    var uniqueDaysMissed = group.Select(x => x.s.ScheduledDate).Distinct().Count();
                    
                    if (uniqueDaysMissed >= 2)
                    {
                        doctorAlerts.Add(new DoctorAlert {
                            Priority = "Urgent", Icon = "🔴",
                            Title = $"{patient.FullName} missed medications for {uniqueDaysMissed} days",
                            TimeText = "Action Required"
                        });
                    }
                }

                // B. Appointment Notifications Logic
                var allUpcoming = await _db.Appointments
                    .Where(a => a.AppointmentDate >= today && a.AppointmentDate < dayAfter 
                           && (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)))
                    .Join(_db.Patients, a => (int)a.PatientID, p => p.PatientID, (a, p) => new { a, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName) // Strict patient assignment check
                    .ToListAsync();

                foreach (var item in allUpcoming)
                {
                    if (!item.a.AppointmentDate.HasValue) continue;
                    var apptDate = item.a.AppointmentDate.Value;
                    string timeStr = apptDate.ToString("hh:mm tt");

                    // 1. Missed (Auto-updated above)
                    if (item.a.Status == "Missed" && apptDate.Date == today)
                    {
                        doctorAlerts.Add(new DoctorAlert {
                            Priority = "Urgent", Icon = "🔴",
                            Title = $"{item.p.FullName}'s appointment was missed",
                            TimeText = $"Scheduled for {timeStr}"
                        });
                    }
                    // 2. 2 hours before
                    else if (apptDate > now && apptDate <= now.AddHours(2) && apptDate.Date == today && item.a.Status == "Scheduled")
                    {
                        doctorAlerts.Add(new DoctorAlert {
                            Priority = "Warning", Icon = "🟡",
                            Title = $"{item.p.FullName} has an appointment in 2 hours at {timeStr}",
                            TimeText = "Upcoming Today"
                        });
                    }
                    // 3. 1 day before
                    else if (apptDate.Date == today.AddDays(1) && item.a.Status == "Scheduled")
                    {
                        doctorAlerts.Add(new DoctorAlert {
                            Priority = "Info", Icon = "🔵",
                            Title = $"{item.p.FullName} has an appointment tomorrow at {timeStr}",
                            TimeText = "Reminder"
                        });
                    }
                }

                // C. Treatment Plans ending soon
                var endingPlans = await _db.TreatmentPlans
                    .Where(tp => tp.EndDate >= today && tp.EndDate <= today.AddDays(3))
                    .Join(_db.Patients, tp => tp.PatientID, p => p.PatientID, (tp, p) => new { tp, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName)
                    .ToListAsync();

                foreach (var item in endingPlans)
                {
                    int daysLeft = (item.tp.EndDate.Date - today).Days;
                    doctorAlerts.Add(new DoctorAlert {
                        Priority = "Info",
                        Icon = "🔵",
                        Title = $"{item.p.FullName}'s treatment plan ends in {daysLeft} days",
                        TimeText = $"Ends on {item.tp.EndDate:MMM dd}"
                    });
                }

                // Sort by Priority (Urgent > Warning > Info)
                var sortedAlerts = doctorAlerts.OrderBy(a => a.Priority == "Urgent" ? 0 : a.Priority == "Warning" ? 1 : 2).ToList();
                LoadAlerts(sortedAlerts);
            }
            catch (Exception) { }
        }

        private void LoadAlerts(List<DoctorAlert> alerts)
        {
            pnlAlert1.Visible = alerts.Count > 0;
            pnlAlert2.Visible = alerts.Count > 1;
            pnlAlert3.Visible = alerts.Count > 2;

            if (alerts.Count > 0)
            {
                lblAlert1Icon.Text = alerts[0].Icon;
                lblAlert1Text.Text = alerts[0].Title;
                lblAlert1Time.Text = alerts[0].TimeText;
            }
            if (alerts.Count > 1)
            {
                lblAlert2Icon.Text = alerts[1].Icon;
                lblAlert2Text.Text = alerts[1].Title;
                lblAlert2Time.Text = alerts[1].TimeText;
            }
            if (alerts.Count > 2)
            {
                lblAlert3Icon.Text = alerts[2].Icon;
                lblAlert3Text.Text = alerts[2].Title;
                lblAlert3Time.Text = alerts[2].TimeText;
            }
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
