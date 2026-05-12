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
                        reminders.Add(new PatientReminder { Priority = -2, Icon = "🔔", Title = $"Time to take: {s.MedicationName}", TimeText = "Click to record now", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });
                    else if (minutesUntil < -5 && minutesUntil > -120)
                        reminders.Add(new PatientReminder { Priority = -3, Icon = "🚨", Title = $"URGENT: {s.MedicationName} OVERDUE", TimeText = "Action required now", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });
                    else if (minutesUntil >= 55 && minutesUntil <= 65)
                        reminders.Add(new PatientReminder { Priority = 0, Icon = "🕒", Title = $"Preparation: {s.MedicationName}", TimeText = "Due in 1 hour", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });
                }

                var nextMed = todaySchedules.FirstOrDefault(s => !s.IsTaken && !s.IsMissed && s.ScheduledTime >= nowTime);
                if (nextMed != null && !reminders.Any(r => r.Title.Contains(nextMed.MedicationName)))
                    reminders.Add(new PatientReminder { Priority = 2, Icon = "🟡", Title = $"Upcoming: {nextMed.MedicationName}", TimeText = $"Scheduled at {nextMed.ScheduledTime?.ToString("hh:mm tt")}", Action = () => (this.ParentForm as PatientMainForm)?.LoadMedications() });

                if (nextAppt != null)
                {
                    var daysUntil = (nextAppt.AppointmentDate.Value.Date - DateTime.Today).Days;
                    if (daysUntil <= 1)
                        reminders.Add(new PatientReminder { Priority = 3, Icon = "🔵", Title = daysUntil == 0 ? "Appointment today" : "Appointment tomorrow", TimeText = $"At {nextAppt.AppointmentDate.Value:hh:mm tt}", Action = () => (this.ParentForm as PatientMainForm)?.LoadAppointments() });
                }

                LoadReminders(reminders.OrderBy(r => r.Priority).ToList());
            }
            catch { }
        }

        private void LoadReminders(List<PatientReminder> reminders)
        {
            SetupReminderPanel(pnlRem1, lblRem1Icon, lblRem1Text, lblRem1Time, reminders.Count > 0 ? reminders[0] : null);
            SetupReminderPanel(pnlRem2, lblRem2Icon, lblRem2Text, lblRem2Time, reminders.Count > 1 ? reminders[1] : null);
            SetupReminderPanel(pnlRem3, lblRem3Icon, lblRem3Text, lblRem3Time, reminders.Count > 2 ? reminders[2] : null);
            SetupReminderPanel(pnlRem4, lblRem4Icon, lblRem4Text, lblRem4Time, reminders.Count > 3 ? reminders[3] : null);
        }

        private void SetupReminderPanel(Panel pnl, Label icon, Label text, Label time, PatientReminder rem)
        {
            if (rem == null) { pnl.Visible = false; return; }
            pnl.Visible = true;
            icon.Text = rem.Icon;
            text.Text = rem.Title;
            time.Text = rem.TimeText;
            pnl.Tag = rem;
            pnl.Click += Reminder_Click;
            foreach (Control c in pnl.Controls) { c.Tag = rem; c.Click += Reminder_Control_Click; }

            if (rem.Priority == -3) { text.ForeColor = Color.FromArgb(192, 57, 43); pnl.BackColor = Color.FromArgb(255, 240, 240); }
            else if (rem.Priority == -2) { text.ForeColor = Color.FromArgb(230, 126, 34); pnl.BackColor = Color.FromArgb(255, 248, 240); }
            else { text.ForeColor = Color.FromArgb(30, 41, 59); pnl.BackColor = Color.FromArgb(248, 250, 252); }
        }

        private void Reminder_Click(object sender, EventArgs e) { if (sender is Panel pnl && pnl.Tag is PatientReminder rem) rem.Action?.Invoke(); }
        private void Reminder_Control_Click(object sender, EventArgs e) { if (sender is Control ctrl && ctrl.Tag is PatientReminder rem) rem.Action?.Invoke(); }

        private class PatientReminder
        {
            public int Priority { get; set; }
            public string Icon { get; set; }
            public string Title { get; set; }
            public string TimeText { get; set; }
            public Action Action { get; set; }
        }
    }
}
