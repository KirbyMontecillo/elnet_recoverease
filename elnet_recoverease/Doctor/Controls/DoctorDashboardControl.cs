using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Shared;

namespace elnet_recoverease.Doctor.Controls
{
    public partial class DoctorDashboardControl : UserControl
    {
        private AppDbContext _db = new AppDbContext();
        private Staff _doctor;
        private System.Windows.Forms.Timer _notifTimer;
        private List<DoctorAlert> _currentAlerts = new List<DoctorAlert>();

        public DoctorDashboardControl()
        {
            InitializeComponent();
            SetupDashboardLayout();
            _doctor = UserSession.CurrentStaff;
            InitializeAsyncData();
            StartNotifTimer();
        }

        private void SetupDashboardLayout()
        {
            // Setup stat cards (Teal, Navy, Green, Orange)
            SetupStatCard(cardPatients, "TOTAL PATIENTS", lblCardPatTitle, lblCardPatValue, lblCardPatIcon, "👥", lblCardPatSub, "Active under care", Color.FromArgb(0, 168, 168), 0);
            SetupStatCard(cardAppt, "APPOINTMENTS", lblCardApptTitle, lblCardApptValue, lblCardApptIcon, "📅", lblCardApptSub, "Remaining today", Color.FromArgb(27, 58, 107), 1);
            SetupStatCard(cardPending, "PENDING REPORTS", lblCardPendTitle, lblCardPendValue, lblCardPendIcon, "📋", lblCardPendSub, "Needs review", Color.FromArgb(39, 174, 96), 2);
            SetupStatCard(cardAlerts, "CLINICAL ALERTS", lblCardAlertTitle, lblCardAlertValue, lblCardAlertIcon, "⚠️", lblCardAlertSub, "Requires attention", Color.FromArgb(230, 126, 34), 3);

            // Setup alert items
            SetupAlertItem(pnlAlert1, lblAlert1Icon, lblAlert1Text, lblAlert1Time, Color.FromArgb(220, 38, 38));
            SetupAlertItem(pnlAlert2, lblAlert2Icon, lblAlert2Text, lblAlert2Time, Color.FromArgb(220, 38, 38));
            SetupAlertItem(pnlAlert3, lblAlert3Icon, lblAlert3Text, lblAlert3Time, Color.FromArgb(217, 119, 6));

            WireAlertClick(pnlAlert1, 0);
            WireAlertClick(pnlAlert2, 1);
            WireAlertClick(pnlAlert3, 2);
        }

        private void SetupStatCard(System.Windows.Forms.Panel card, string title, System.Windows.Forms.Label lblTitle, System.Windows.Forms.Label lblValue, System.Windows.Forms.Label lblIcon, string ico, System.Windows.Forms.Label lblSub, string sub, System.Drawing.Color color, int index)
        {
            card.BackColor = System.Drawing.Color.White;
            card.Margin = new System.Windows.Forms.Padding(index == 0 ? 0 : 12, 0, index == 3 ? 0 : 12, 0);
            card.Dock = System.Windows.Forms.DockStyle.Fill;
            card.Padding = new System.Windows.Forms.Padding(0);

            // Add Top Strip
            var pnlTopStrip = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 4, BackColor = color };
            
            lblTitle.Text = title;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTitle.Location = new System.Drawing.Point(20, 18);
            lblTitle.AutoSize = true;

            lblValue.Text = "0";
            lblValue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblValue.Location = new System.Drawing.Point(15, 40);
            lblValue.AutoSize = true;

            lblIcon.Text = ico;
            lblIcon.Font = new System.Drawing.Font("Segoe UI", 40F);
            lblIcon.ForeColor = System.Drawing.Color.FromArgb(40, color.R, color.G, color.B);
            lblIcon.Location = new System.Drawing.Point(110, 30);
            lblIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblIcon.AutoSize = true;

            lblSub.Text = sub;
            lblSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblSub.ForeColor = color;
            lblSub.Location = new System.Drawing.Point(20, 115);
            lblSub.AutoSize = true;

            card.Controls.Clear();
            card.Controls.Add(lblIcon);
            card.Controls.Add(lblValue);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblSub);
            card.Controls.Add(pnlTopStrip);
            
            lblIcon.SendToBack();
        }

        private void SetupAlertItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, System.Windows.Forms.Label time, System.Drawing.Color statusColor)
        {
            pnl.Dock = System.Windows.Forms.DockStyle.Top;
            pnl.Height = 85;
            pnl.Padding = new System.Windows.Forms.Padding(0);
            pnl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            pnl.BackColor = System.Drawing.Color.White;
            pnl.Visible = false;

            var pnlStatus = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Left, Width = 4, BackColor = statusColor };
            
            ico.Font = new System.Drawing.Font("Segoe UI", 12F);
            ico.Location = new System.Drawing.Point(15, 20);
            ico.ForeColor = statusColor;
            ico.AutoSize = true;

            txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            txt.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            txt.Location = new System.Drawing.Point(45, 18);
            txt.Size = new System.Drawing.Size(240, 45);
            txt.AutoEllipsis = true;

            time.Font = new System.Drawing.Font("Segoe UI", 8F);
            time.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            time.Location = new System.Drawing.Point(47, 58);
            time.AutoSize = true;

            pnl.Controls.Clear();
            pnl.Controls.Add(txt);
            pnl.Controls.Add(time);
            pnl.Controls.Add(ico);
            pnl.Controls.Add(pnlStatus);
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

        private async void LoadDashboardData()
        {
            try
            {
                ScheduleManager.UpdateMissedSchedules();
                if (_doctor == null) return;

                // 1. Stats Summary
                int totalPatients = await _db.Patients.CountAsync(p => p.AttendingDoctor == _doctor.FullName);
                lblCardPatValue.Text = totalPatients.ToString();

                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);

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
                        item.Notes
                    );
                }

                // 3. New Alerts: Patients missing treatment plans
                var patientsNoPlan = await _db.Patients
                    .Where(p => p.AttendingDoctor == _doctor.FullName && (p.Status == "Active" || p.Status == null))
                    .Where(p => !_db.TreatmentPlans.Any(tp => tp.PatientID == p.PatientID))
                    .Select(p => new { p.PatientID, p.FullName })
                    .ToListAsync();

                // 4. New Alerts: Abnormal Vitals (Recent Sessions)
                var recentSessions = await _db.Appointments
                    .Where(a => a.Status == "Completed" && (a.DoctorID == _doctor.StaffID || a.DoctorName == _doctor.FullName))
                    .OrderByDescending(a => a.AppointmentDate)
                    .Take(10)
                    .Select(a => new { a.BloodPressure, a.PatientID, a.PatientName, a.AppointmentDate })
                    .ToListAsync();

                // 5. New Alerts: Inactive Patients (No appointment in 14 days)
                var fourteenDaysAgo = DateTime.Now.AddDays(-14);
                var inactivePatients = await _db.Patients
                    .Where(p => p.AttendingDoctor == _doctor.FullName && (p.Status == "Active" || p.Status == null))
                    .Where(p => !_db.Appointments.Any(a => a.PatientID == p.PatientID && a.AppointmentDate > fourteenDaysAgo))
                    .Select(p => new { p.FullName })
                    .ToListAsync();

                // 6. Generate Alerts
                GenerateAlerts(missedMeds.Select(m => new { m.PatientID, m.FullName, m.ScheduledDate, m.ScheduledTime }).ToList(), 
                               apptsToday.Select(a => new { a.AppointmentDate, a.FullName, a.Status }).ToList(),
                               takenMeds.Select(t => new { t.PatientID, t.FullName, t.MedicationName, t.ScheduledDate, t.ScheduledTime }).ToList(),
                               patientsNoPlan,
                               recentSessions,
                               inactivePatients);
            }
            catch { }
        }

        private void GenerateAlerts(IEnumerable<dynamic> missedMeds, IEnumerable<dynamic> appts, IEnumerable<dynamic> takenMeds, IEnumerable<dynamic> patientsNoPlan, IEnumerable<dynamic> recentSessions, IEnumerable<dynamic> inactivePatients)
        {
            var alerts = new List<DoctorAlert>();
            var now = DateTime.Now;
            string nowStr = now.ToString("MMM dd, hh:mm tt");

            // Existing Med Alerts
            foreach (var group in missedMeds.GroupBy(x => x.PatientID))
            {
                var days = group.Select(x => x.ScheduledDate).Distinct().Count();
                var latest = group.OrderByDescending(x => x.ScheduledDate).First();
                string dateStr = $"{latest.ScheduledDate:MMM dd}, " + (latest.ScheduledTime != null ? latest.ScheduledTime.ToString("hh:mm tt") : "12:00 AM");
                if (days >= 2) alerts.Add(new DoctorAlert { Priority = "Urgent", Icon = "🔴", Title = $"{group.First().FullName} missed meds", Message = $"Patient has missed their prescribed medication schedule for {days} consecutive days. Immediate follow-up is required to ensure treatment continuity.", TimeText = dateStr, Color = Color.FromArgb(220, 38, 38) });
                else alerts.Add(new DoctorAlert { Priority = "Warning", Icon = "🟡", Title = $"{group.First().FullName} missed meds", Message = "Patient missed their most recent medication dose. Monitor adherence during the next check-in.", TimeText = dateStr, Color = Color.FromArgb(217, 119, 6) });
            }

            // High BP Alerts (Recent Sessions)
            foreach (var session in recentSessions)
            {
                if (IsAbnormalBP(session.BloodPressure))
                {
                    string sessionDate = session.AppointmentDate?.ToString("MMM dd, hh:mm tt") ?? nowStr;
                    alerts.Add(new DoctorAlert { Priority = "Urgent", Icon = "🩺", Title = $"High BP: {session.PatientName}", Message = $"Clinical session on {session.AppointmentDate:MMM dd} recorded a high blood pressure reading of {session.BloodPressure}. Evaluate if medication adjustment is necessary.", TimeText = sessionDate, Color = Color.FromArgb(220, 38, 38) });
                }
            }

            // Missing Plan Alerts
            foreach (var p in patientsNoPlan)
            {
                alerts.Add(new DoctorAlert { Priority = "Warning", Icon = "📝", Title = $"Missing Plan: {p.FullName}", Message = "This active patient does not have a finalized treatment plan. Please update their profile to include clinical goals.", TimeText = nowStr, Color = Color.FromArgb(217, 119, 6) });
            }

            // Inactive Patient Alerts (14+ Days)
            foreach (var p in inactivePatients)
            {
                alerts.Add(new DoctorAlert { Priority = "Warning", Icon = "🛌", Title = $"Inactivity: {p.FullName}", Message = "This patient hasn't had a consultation or appointment update in over 14 days. Consider scheduling a check-in call.", TimeText = nowStr, Color = Color.FromArgb(217, 119, 6) });
            }

            // Existing Info/Appt Alerts
            foreach(var taken in takenMeds)
            {
                string takenStr = $"{taken.ScheduledDate:MMM dd}, " + (taken.ScheduledTime != null ? taken.ScheduledTime.ToString("hh:mm tt") : "12:00 AM");
                alerts.Add(new DoctorAlert { Priority = "Info", Icon = "🟢", Title = $"{taken.FullName} took {taken.MedicationName}", Message = "The patient successfully logged their medication intake. Adherence is on track.", TimeText = takenStr, Color = Color.FromArgb(39, 174, 96) });
            }

            foreach (var appt in appts)
            {
                if (appt.AppointmentDate == null) continue;
                DateTime dt = appt.AppointmentDate;
                if (appt.Status == "Missed" && dt.Date == DateTime.Today)
                    alerts.Add(new DoctorAlert { Priority = "Urgent", Icon = "🔴", Title = $"{appt.FullName} missed appt", Message = "The scheduled consultation for today was not completed. Verify if the patient needs to reschedule.", TimeText = dt.ToString("MMM dd, hh:mm tt"), Color = Color.FromArgb(220, 38, 38) });
                else if (dt > now && dt <= now.AddHours(2) && appt.Status == "Scheduled")
                    alerts.Add(new DoctorAlert { Priority = "Warning", Icon = "🟡", Title = $"Upcoming Appt: {appt.FullName}", Message = "Scheduled consultation is starting in less than 2 hours.", TimeText = dt.ToString("MMM dd, hh:mm tt"), Color = Color.FromArgb(217, 119, 6) });
            }

            _currentAlerts = alerts.OrderBy(a => a.Priority == "Urgent" ? 0 : a.Priority == "Warning" ? 1 : 2).ToList();
            DisplayAlerts(_currentAlerts);
        }

        private bool IsAbnormalBP(string bp)
        {
            if (string.IsNullOrEmpty(bp)) return false;
            try {
                var parts = bp.Split('/');
                if (parts.Length == 2 && int.TryParse(parts[0], out int sys)) return sys >= 140; // Systolic >= 140
            } catch {}
            return false;
        }

        private FlowLayoutPanel flpAlerts;

        private void DisplayAlerts(List<DoctorAlert> alerts)
        {
            // Hide the old fixed placeholders
            if (pnlAlert1 != null) pnlAlert1.Visible = false;
            if (pnlAlert2 != null) pnlAlert2.Visible = false;
            if (pnlAlert3 != null) pnlAlert3.Visible = false;

            if (flpAlerts == null)
            {
                flpAlerts = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    Padding = new Padding(0)
                };
                pnlAlertsPanel.Controls.Add(flpAlerts);
                flpAlerts.BringToFront();
            }

            flpAlerts.Controls.Clear();

            int index = 0;
            foreach (var alert in alerts)
            {
                var card = new Panel 
                { 
                    Width = pnlAlertsPanel.Width - 60, 
                    Height = 70, 
                    Margin = new Padding(0, 0, 0, 10),
                    BackColor = alert.IsRead ? Color.White : Color.FromArgb(245, 248, 250)
                };
                
                var colorLine = new Panel { Width = 4, Dock = DockStyle.Left, BackColor = alert.Color };
                card.Controls.Add(colorLine);

                var icon = new Label { Text = alert.Icon, Location = new Point(15, 23), Font = new Font("Segoe UI", 12f), AutoSize = true };
                var title = new Label { Text = alert.Title, Location = new Point(55, 15), Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = Color.FromArgb(30, 43, 60), AutoSize = true };
                var time = new Label { Text = alert.TimeText, Location = new Point(55, 40), Font = new Font("Segoe UI", 8f), ForeColor = Color.Gray, AutoSize = true };

                card.Controls.Add(icon);
                card.Controls.Add(title);
                card.Controls.Add(time);

                WireAlertClick(card, index);
                foreach (Control c in card.Controls) WireAlertClick(c, index);

                flpAlerts.Controls.Add(card);
                index++;
            }
        }

        private void WireAlertClick(Control container, int index)
        {
            container.Tag = index;
            container.Cursor = Cursors.Hand;
            container.Click += Alert_Click;
            foreach (Control c in container.Controls)
            {
                c.Tag = index;
                c.Cursor = Cursors.Hand;
                c.Click += Alert_Click;
            }
        }

        private void Alert_Click(object sender, EventArgs e)
        {
            if (sender is Control c && c.Tag is int index)
            {
                OpenAlertDetails(index);
            }
        }

        private void OpenAlertDetails(int index)
        {
            if (index < _currentAlerts.Count)
            {
                var alert = _currentAlerts[index];
                using (var form = new Alert_Details_Form(alert.Icon, alert.Title, alert.Message, alert.TimeText, alert.Color))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        alert.IsRead = true;
                        DisplayAlerts(_currentAlerts);
                    }
                }
            }
        }

        private class DoctorAlert
        {
            public string Priority { get; set; } = "Info";
            public string Icon { get; set; } = "🔵";
            public string Title { get; set; } = "";
            public string Message { get; set; } = "";
            public string TimeText { get; set; } = "";
            public Color Color { get; set; } = Color.Gray;
            public bool IsRead { get; set; } = false;
        }
    }
}
