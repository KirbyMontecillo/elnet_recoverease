using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Models;
using elnet_recoverease.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using elnet_recoverease.PatientStation.Forms;
using elnet_recoverease.Shared;

namespace elnet_recoverease.PatientStation.Controls
{
    public partial class PatientDashboardControl : UserControl
    {
        private AppDbContext _db = new AppDbContext();
        private System.Windows.Forms.Timer _refreshTimer;

        public PatientDashboardControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                StartRefreshTimer();
            }
        }

        private void StartRefreshTimer()
        {
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 30000; // Refresh every 30 seconds
            _refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            _refreshTimer.Start();
        }

        private async void PatientDashboardControl_Load(object sender, EventArgs e)
        {
            await LoadDashboardData();
        }

        private async void RefreshTimer_Tick(object sender, EventArgs e)
        {
            await LoadDashboardData();
        }

        private async Task LoadDashboardData()
        {
            try
            {
                var patient = elnet_recoverease.Core.UserSession.CurrentPatient;
                if (patient == null) return;

                // Welcome Message - Update parent if available
                if (this.ParentForm is PatientMainForm main)
                {
                    // main.lblWelcome is updated in MainForm constructor, 
                    // but we can update specific page sub-welcome if needed.
                }

                // 1. Medications Today
                var today = DateOnly.FromDateTime(DateTime.Today);
                var nowTime = TimeOnly.FromDateTime(DateTime.Now);

                var todaySchedules = await _db.MedicationSchedules
                    .Where(ms => ms.PatientID == patient.PatientID && ms.ScheduledDate == today)
                    .OrderBy(ms => ms.ScheduledTime)
                    .ToListAsync();
                
                lblCardMedsValue.Text = todaySchedules.Count.ToString().PadLeft(2, '0');

                // Populate Grid
                dgvSchedule.Rows.Clear();
                foreach (var s in todaySchedules)
                {
                    dgvSchedule.Rows.Add(
                        s.ScheduledTime?.ToString("hh:mm tt") ?? "--",
                        s.MedicationName,
                        s.DosageUnit,
                        s.IsTaken ? "Taken" : (s.IsMissed ? "Missed" : "Scheduled")
                    );
                }

                // 2. Next Appointment
                var nextAppt = await _db.Appointments
                    .Where(a => a.PatientID == patient.PatientID && 
                           a.Status == "Scheduled" && 
                           a.AppointmentDate >= DateTime.Now)
                    .OrderBy(a => a.AppointmentDate)
                    .FirstOrDefaultAsync();
                
                lblCardApptValue.Text = nextAppt?.AppointmentDate?.ToString("MMM dd") ?? "--";

                // 3. Adherence Score
                var pastSchedules = await _db.MedicationSchedules
                    .Where(ms => ms.PatientID == patient.PatientID && 
                           (ms.ScheduledDate < today || (ms.ScheduledDate == today && ms.ScheduledTime < nowTime)))
                    .ToListAsync();

                if (pastSchedules.Any())
                {
                    double score = (double)pastSchedules.Count(s => s.IsTaken) / pastSchedules.Count * 100;
                    lblCardAdhrValue.Text = $"{score:F0}%";
                }
                else
                {
                    lblCardAdhrValue.Text = "100%";
                }

                // 4. Missed Doses Today
                lblCardMissValue.Text = todaySchedules.Count(s => s.IsMissed).ToString().PadLeft(2, '0');

                // 5. Generate Reminders
                var reminders = new List<PatientReminder>();

                int missedToday = todaySchedules.Count(s => s.IsMissed && !s.IsTaken);
                if (missedToday > 0)
                {
                    reminders.Add(new PatientReminder {
                        Priority = 1, Icon = "🔴",
                        Title = $"You missed {missedToday} doses today",
                        TimeText = "Action Required"
                    });
                }

                foreach (var s in todaySchedules.Where(x => !x.IsTaken))
                {
                    if (!s.ScheduledTime.HasValue) continue;
                    var scheduledDateTime = DateTime.Today.Add(s.ScheduledTime.Value.ToTimeSpan());
                    var minutesUntil = (scheduledDateTime - DateTime.Now).TotalMinutes;

                    if (minutesUntil >= -2 && minutesUntil <= 1)
                        reminders.Add(new PatientReminder { Priority = -2, Icon = "🔔", Title = $"Time to take: {s.MedicationName}", Message = $"It's time for your {s.DosageUnit} of {s.MedicationName}. Please record it now to maintain your recovery schedule.", TimeText = "Now", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });
                    else if (minutesUntil < -5 && minutesUntil > -120)
                        reminders.Add(new PatientReminder { Priority = -3, Icon = "🚨", Title = $"OVERDUE: {s.MedicationName}", Message = $"You missed your {s.ScheduledTime:hh:mm tt} dose of {s.MedicationName}. Please take it as soon as possible.", TimeText = "Overdue", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });
                    else if (minutesUntil >= 55 && minutesUntil <= 65)
                        reminders.Add(new PatientReminder { Priority = 0, Icon = "🕒", Title = $"Preparation: {s.MedicationName}", Message = $"Your next dose of {s.MedicationName} is due in 1 hour. Make sure you have it ready.", TimeText = "Due in 1h", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });
                }

                var nextMed = todaySchedules.FirstOrDefault(s => !s.IsTaken && !s.IsMissed && s.ScheduledTime >= nowTime);
                if (nextMed != null && !reminders.Any(r => r.Title.Contains(nextMed.MedicationName)))
                    reminders.Add(new PatientReminder { Priority = 2, Icon = "🟡", Title = $"Upcoming: {nextMed.MedicationName}", Message = $"Your next scheduled medication is {nextMed.MedicationName} at {nextMed.ScheduledTime:hh:mm tt}.", TimeText = $"{nextMed.ScheduledTime:hh:mm tt}", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });

                if (nextAppt != null)
                {
                    var daysUntil = (nextAppt.AppointmentDate.Value.Date - DateTime.Today).Days;
                    if (daysUntil <= 1)
                        reminders.Add(new PatientReminder { Priority = 3, Icon = "🔵", Title = daysUntil == 0 ? "Appointment today" : "Appointment tomorrow", Message = $"You have a consultation scheduled with your doctor at {nextAppt.AppointmentDate.Value:hh:mm tt}. Please be on time.", TimeText = $"{nextAppt.AppointmentDate.Value:hh:mm tt}", Action = () => (this.ParentForm as PatientMainForm)?.LoadAppointments() });
                }

                // 6. Status Alerts (Discharged / Active)
                if (patient.Status == "Discharged")
                {
                    reminders.Add(new PatientReminder { 
                        Priority = -10, Icon = "🎉", 
                        Title = "Recovery Milestone: Discharged", 
                        Message = "Congratulations! Your doctor has officially marked you as Discharged. You have successfully completed this phase of your recovery program. Stay healthy!", 
                        TimeText = "Completed" 
                    });
                }
                else if (patient.Status == "Active")
                {
                    reminders.Add(new PatientReminder { 
                        Priority = 10, Icon = "✨", 
                        Title = "Status: Active Care", 
                        Message = "You are currently in Active Care. Your healthcare team is monitoring your progress through your daily medications and scheduled appointments.", 
                        TimeText = "Ongoing" 
                    });
                }

                _currentReminders = reminders.OrderBy(r => r.Priority).ToList();
                LoadReminders(_currentReminders);
            }
            catch { }
        }

        private List<PatientReminder> _currentReminders = new List<PatientReminder>();

        private void LoadReminders(List<PatientReminder> reminders)
        {
            SetupReminderPanel(pnlRem1, lblRem1Icon, lblRem1Text, lblRem1Time, reminders.Count > 0 ? 0 : -1);
            SetupReminderPanel(pnlRem2, lblRem2Icon, lblRem2Text, lblRem2Time, reminders.Count > 1 ? 1 : -1);
            SetupReminderPanel(pnlRem3, lblRem3Icon, lblRem3Text, lblRem3Time, reminders.Count > 2 ? 2 : -1);
            SetupReminderPanel(pnlRem4, lblRem4Icon, lblRem4Text, lblRem4Time, reminders.Count > 3 ? 3 : -1);
        }

        private void SetupReminderPanel(Panel pnl, Label icon, Label text, Label time, int index)
        {
            if (index == -1 || index >= _currentReminders.Count) { pnl.Visible = false; return; }
            var rem = _currentReminders[index];
            pnl.Visible = true;
            icon.Text = rem.Icon;
            text.Text = rem.Title;
            time.Text = rem.TimeText;
            pnl.Cursor = Cursors.Hand;
            
            pnl.Click -= (s, e) => OpenAlertDetails(index);
            pnl.Click += (s, e) => OpenAlertDetails(index);
            foreach (Control c in pnl.Controls) {
                c.Cursor = Cursors.Hand;
                c.Click -= (s, e) => OpenAlertDetails(index);
                c.Click += (s, e) => OpenAlertDetails(index);
            }

            if (rem.IsRead) { pnl.BackColor = Color.White; text.ForeColor = Color.FromArgb(71, 85, 105); }
            else if (rem.Priority == -3) { text.ForeColor = Color.FromArgb(192, 57, 43); pnl.BackColor = Color.FromArgb(255, 240, 240); }
            else if (rem.Priority == -2) { text.ForeColor = Color.FromArgb(230, 126, 34); pnl.BackColor = Color.FromArgb(255, 248, 240); }
            else { text.ForeColor = Color.FromArgb(30, 41, 59); pnl.BackColor = Color.FromArgb(248, 250, 252); }
        }

        private void OpenAlertDetails(int index)
        {
            if (index < _currentReminders.Count)
            {
                var rem = _currentReminders[index];
                Color pColor = rem.Priority == -3 ? Color.FromArgb(192, 57, 43) : (rem.Priority == -2 ? Color.FromArgb(230, 126, 34) : Color.FromArgb(0, 168, 168));
                using (var form = new Alert_Details_Form(rem.Icon, rem.Title, rem.Message, rem.TimeText, pColor))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        rem.IsRead = true;
                        LoadReminders(_currentReminders);
                    }
                }
            }
        }

        private class PatientReminder
        {
            public int Priority { get; set; }
            public string Icon { get; set; }
            public string Title { get; set; }
            public string Message { get; set; }
            public string TimeText { get; set; }
            public Action Action { get; set; }
            public bool IsRead { get; set; } = false;
        }
    }
}
