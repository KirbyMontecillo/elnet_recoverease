using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Models;
using elnet_recoverease.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace elnet_recoverease
{
    public partial class Patient_Dashboard : Form
    {
        private AppDbContext _db = new AppDbContext();
        private System.Windows.Forms.Timer _refreshTimer;

        public Patient_Dashboard()
        {
            InitializeComponent();
            LoadLogo();
            WireNavigation();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Load += async (s, e) => await LoadDashboardData();
                StartRefreshTimer();
            }
        }

        private void StartRefreshTimer()
        {
            _refreshTimer = new System.Windows.Forms.Timer();
            _refreshTimer.Interval = 30000; // Refresh every 30 seconds for precision
            _refreshTimer.Tick += async (s, e) => await LoadDashboardData();
            _refreshTimer.Start();
        }

        private async Task LoadDashboardData()
        {
            try
            {
                var patient = UserSession.CurrentPatient;
                if (patient == null) return;

                // Welcome Message
                lblWelcome.Text = $"Welcome back, {patient.FullName}! Manage your health seamlessly.";

                // Avatar Initials
                lblAvatarInitials.Text = string.Join("", patient.FullName.Split(' ').Select(n => n[0])).ToUpper();

                if (patient.Status == "Discharged")
                {
                    lblWelcome.Text = "Congratulations! Your treatment plan has been successfully completed.";
                    lblWelcome.ForeColor = Color.FromArgb(0, 168, 168); // Teal for success
                }
                else
                {
                    lblWelcome.Text = "Here is your health overview for today.";
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

                // 3. Adherence Score (Taken / Past Total)
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

                // A. Missed Doses
                int missedToday = todaySchedules.Count(s => s.IsMissed && !s.IsTaken);
                if (missedToday > 0)
                {
                    reminders.Add(new PatientReminder {
                        Priority = 1, Icon = "🔴",
                        Title = $"You missed {missedToday} doses today",
                        TimeText = "Action Required"
                    });
                }

                // B. Time-Sensitive Medication Notifications
                foreach (var s in todaySchedules.Where(x => !x.IsTaken))
                {
                    if (!s.ScheduledTime.HasValue) continue;
                    
                    var scheduledDateTime = DateTime.Today.Add(s.ScheduledTime.Value.ToTimeSpan());
                    var minutesUntil = (scheduledDateTime - DateTime.Now).TotalMinutes;

                    // 1. Exact Time (Within 2 minutes of the time)
                    if (minutesUntil >= -2 && minutesUntil <= 1)
                    {
                        reminders.Add(new PatientReminder {
                            Priority = -2, Icon = "🔔",
                            Title = $"Time to take: {s.MedicationName}",
                            TimeText = "Click to record now",
                            Action = () => OpenForm(new Medications())
                        });
                    }
                    // 2. Urgent (5 minutes or more past the time)
                    else if (minutesUntil < -5 && minutesUntil > -120) // Up to 2 hours past
                    {
                        reminders.Add(new PatientReminder {
                            Priority = -3, Icon = "🚨",
                            Title = $"URGENT: {s.MedicationName} OVERDUE",
                            TimeText = "Action required now",
                            Action = () => OpenForm(new Medications())
                        });
                    }
                    // 3. Preparation (60 minutes before)
                    else if (minutesUntil >= 55 && minutesUntil <= 65)
                    {
                        reminders.Add(new PatientReminder {
                            Priority = 0, Icon = "🕒",
                            Title = $"Preparation: {s.MedicationName}",
                            TimeText = "Due in 1 hour",
                            Action = () => OpenForm(new Medications())
                        });
                    }
                }

                // C. Next Upcoming Medication (General)
                var nextMed = todaySchedules.FirstOrDefault(s => !s.IsTaken && !s.IsMissed && s.ScheduledTime >= nowTime);
                if (nextMed != null && !reminders.Any(r => r.Title.Contains(nextMed.MedicationName)))
                {
                    reminders.Add(new PatientReminder {
                        Priority = 2, Icon = "🟡",
                        Title = $"Upcoming: {nextMed.MedicationName}",
                        TimeText = $"Scheduled at {nextMed.ScheduledTime?.ToString("hh:mm tt")}",
                        Action = () => OpenForm(new Medications())
                    });
                }

                // D. Upcoming Appointment
                if (nextAppt != null)
                {
                    var daysUntil = (nextAppt.AppointmentDate.Value.Date - DateTime.Today).Days;
                    string timeStr = nextAppt.AppointmentDate.Value.ToString("hh:mm tt");
                    
                    if (daysUntil == 0)
                    {
                        reminders.Add(new PatientReminder {
                            Priority = 3, Icon = "🔵",
                            Title = "Appointment today",
                            TimeText = $"At {timeStr}",
                            Action = () => OpenForm(new Appointments())
                        });
                    }
                    else if (daysUntil == 1)
                    {
                        reminders.Add(new PatientReminder {
                            Priority = 4, Icon = "🔵",
                            Title = "Appointment tomorrow",
                            TimeText = $"At {timeStr}",
                            Action = () => OpenForm(new Appointments())
                        });
                    }
                }

                // E. Treatment Plan Ending
                var activePlan = await _db.TreatmentPlans
                    .Where(tp => tp.PatientID == patient.PatientID && tp.EndDate >= DateTime.Today)
                    .OrderBy(tp => tp.EndDate)
                    .FirstOrDefaultAsync();

                if (activePlan != null)
                {
                    int daysLeft = (activePlan.EndDate.Date - DateTime.Today).Days;
                    if (daysLeft <= 3)
                    {
                        reminders.Add(new PatientReminder {
                            Priority = 5, Icon = "🔵",
                            Title = "Plan ends soon",
                            TimeText = daysLeft == 0 ? "Ends today" : $"Ends in {daysLeft} days",
                            Action = () => OpenForm(new Treatment_Plans())
                        });
                    }
                }

                LoadReminders(reminders.OrderBy(r => r.Priority).ToList());
            }
            catch (Exception)
            {
                // Silent fail
            }
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
            if (rem == null)
            {
                pnl.Visible = false;
                return;
            }

            pnl.Visible = true;
            icon.Text = rem.Icon;
            text.Text = rem.Title;
            time.Text = rem.TimeText;

            // Click handling
            pnl.Cursor = Cursors.Hand;
            pnl.Click += (s, e) => rem.Action?.Invoke();
            foreach (Control c in pnl.Controls)
            {
                c.Cursor = Cursors.Hand;
                c.Click += (s, e) => rem.Action?.Invoke();
            }

            // Priority colors
            if (rem.Priority == -3) // Urgent
            {
                text.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                pnl.BackColor = System.Drawing.Color.FromArgb(255, 240, 240);
            }
            else if (rem.Priority == -2) // Exact Time
            {
                text.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
                pnl.BackColor = System.Drawing.Color.FromArgb(255, 248, 240);
            }
            else
            {
                text.ForeColor = System.Drawing.Color.FromArgb(27, 58, 107);
                pnl.BackColor = System.Drawing.Color.White;
            }
        }

        private class PatientReminder
        {
            public int Priority { get; set; }
            public string Icon { get; set; }
            public string Title { get; set; }
            public string TimeText { get; set; }
            public Action Action { get; set; }
        }

        private void WireNavigation()
        {
            RegisterNavClick(btnNavDashboard, (s, e) => { /* Already on Dashboard */ });
            RegisterNavClick(btnNavProfile, (s, e) => OpenForm(new Patient_Profile()));
            RegisterNavClick(btnNavMeds, (s, e) => OpenForm(new Medications()));
            RegisterNavClick(btnNavAppointments, (s, e) => OpenForm(new Appointments()));
            RegisterNavClick(btnNavTreatment, (s, e) => OpenForm(new Treatment_Plans()));

            btnLogout.Click += (s, e) => {
                UserSession.Logout();
                new Login().Show();
                this.Close();
            };
        }

        private void RegisterNavClick(Panel panel, EventHandler handler)
        {
            panel.Click += handler;
            foreach (Control c in panel.Controls)
            {
                c.Click += (s, e) => handler(panel, e);
            }
        }

        private void OpenForm(Form childForm)
        {
            childForm.Show();
            this.Close(); // Use Close for consistency
        }

        private void LoadLogo()
        {
            try
            {
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath))
                {
                    picLogo.Image = System.Drawing.Image.FromFile(logoPath);
                }
            }
            catch { }
        }
    }
}