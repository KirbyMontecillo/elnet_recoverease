using elnet_recoverease.Core;
using elnet_recoverease.Models;
using System.Data;
using System.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Shared;
using System.Collections.Generic;

namespace elnet_recoverease.Admin.Controls
{
    public partial class AdminDashboardControl : UserControl
    {
        private List<AdminAlert> _currentAlerts = new List<AdminAlert>();

        public AdminDashboardControl()
        {
            InitializeComponent();
            SetupControl();
        }

        private void SetupControl()
        {
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            ScheduleManager.UpdateMissedSchedules();
            LoadDashboardData();
            pnlRecentPatientsCard.Focus();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    lblStatPatientsVal.Text = db.Patients.Count().ToString();
                    lblStatDoctorsVal.Text = db.Staff.Count(s => s.Role == "Doctor" && s.Status == "Active").ToString();
                    
                    var startToday = DateTime.Today;
                    var endToday = startToday.AddDays(1);
                    var appointmentsToday = db.Appointments.Count(a => a.AppointmentDate >= startToday && a.AppointmentDate < endToday);
                    
                    lblStatAppointmentsVal.Text = appointmentsToday.ToString();
                    lblStatAppointmentsSub.Text = $"{appointmentsToday} scheduled";

                    var today = DateOnly.FromDateTime(DateTime.Now);
                    var missedMedsCount = db.MedicationSchedules.Count(m => m.IsMissed && m.ScheduledDate == today);
                    lblStatMissedMedsVal.Text = missedMedsCount.ToString();
                    
                    if (missedMedsCount > 0)
                    {
                        pnlCriticalAlert.Visible = true;
                        lblAlertText.Text = $"{missedMedsCount} patients have missed medications today — follow-up recommended.";
                    }

                    LoadAdherenceData(db);
                    LoadRecentActivity(db);
                    LoadRecentPatients(db);
                }
            }
            catch (Exception) { }
        }

        private void LoadAdherenceData(elnet_recoverease.Data.AppDbContext db)
        {
            flpAdherence.Controls.Clear();
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
        }

        private void AddAdherenceItem(string name, int percentage)
        {
            var pnl = new Panel { Width = flpAdherence.Width - 25, Height = 40, Margin = new Padding(0, 0, 0, 5) };
            var lblName = new Label { Text = name, AutoSize = true, Location = new Point(0, 5), Font = new Font("Segoe UI", 9) };
            var pnlBarBg = new Panel { Width = 150, Height = 8, BackColor = Color.FromArgb(237, 242, 247), Location = new Point(150, 14) };
            var pnlBarFill = new Panel { Width = (int)(150 * (percentage / 100.0)), Height = 8, BackColor = Color.FromArgb(49, 151, 149), Dock = DockStyle.Left };
            pnlBarBg.Controls.Add(pnlBarFill);
            var lblPct = new Label { Text = $"{percentage}%", AutoSize = true, Location = new Point(320, 5), Font = new Font("Segoe UI", 9, FontStyle.Bold) };

            pnl.Controls.Add(lblName);
            pnl.Controls.Add(pnlBarBg);
            pnl.Controls.Add(lblPct);
            flpAdherence.Controls.Add(pnl);
        }
        private void LoadRecentActivity(elnet_recoverease.Data.AppDbContext db)
        {
            flpActivity.Controls.Clear();
            _currentAlerts.Clear();

            // 1. New Patients
            var patients = db.Patients.OrderByDescending(p => p.CreatedAt).Take(3).ToList();
            foreach (var p in patients) 
                _currentAlerts.Add(new AdminAlert { Icon = "👤", Title = $"New patient: {p.FullName}", Message = "A new patient has been successfully registered in the system. Verify their details and assigned doctor.", Time = "Recently", IsImportant = false, Color = Color.FromArgb(44, 82, 130) });

            // 2. New Staff (Lifecycle #1)
            var newStaff = db.Staff.OrderByDescending(s => s.CreatedAt).Take(2).ToList();
            foreach (var s in newStaff)
                _currentAlerts.Add(new AdminAlert { Icon = "👨‍⚕️", Title = $"New staff: {s.FullName}", Message = $"A new {s.Role} has been onboarded to the clinic. Please ensure their credentials and access levels are correctly configured.", Time = "Recently", IsImportant = false, Color = Color.FromArgb(49, 151, 149) });

            // 3. Adherence Warning (Warning #2)
            var totalMeds = db.MedicationSchedules.Count();
            if (totalMeds > 0)
            {
                var takenMedsCount = db.MedicationSchedules.Count(m => m.IsTaken);
                var adherencePct = (takenMedsCount * 100.0) / totalMeds;
                if (adherencePct < 85)
                {
                    _currentAlerts.Add(new AdminAlert { 
                        Icon = "📉", 
                        Title = "Adherence Slump", 
                        Message = $"The overall clinic medication adherence has dropped to {adherencePct:F1}%. This is below the recommended 85% threshold. Clinical review of current patient treatment plans is suggested.", 
                        Time = "Critical", 
                        IsImportant = true, 
                        Color = Color.FromArgb(197, 48, 48) 
                    });
                }
            }

            // 4. Missed Medications
            var missedMeds = db.MedicationSchedules
                .Where(m => m.IsMissed)
                .OrderByDescending(m => m.ScheduledDate)
                .Take(3)
                .Select(m => new { m.PatientID, m.MedicationName, m.ScheduledDate })
                .ToList();

            foreach (var m in missedMeds)
            {
                var p = db.Patients.Find(m.PatientID);
                _currentAlerts.Add(new AdminAlert { 
                    Icon = "💊", 
                    Title = "Missed medication", 
                    Message = $"{p?.FullName ?? "Patient"} missed their dose of {m.MedicationName} on {m.ScheduledDate:MMM dd}. Administrative follow-up with the attending doctor is recommended.", 
                    Time = "Action Required", 
                    IsImportant = true, 
                    Color = Color.FromArgb(197, 48, 48) 
                });
            }

            for (int i = 0; i < _currentAlerts.Count; i++)
            {
                AddActivityItem(i);
            }
        }

        private void AddActivityItem(int index)
        {
            var alert = _currentAlerts[index];
            var isImportant = alert.IsImportant;

            var pnl = new Panel { 
                Width = flpActivity.Width - 25, 
                Height = 65, 
                Margin = new Padding(0, 0, 0, 8),
                BackColor = alert.IsRead ? Color.White : (isImportant ? Color.FromArgb(255, 245, 245) : Color.FromArgb(248, 250, 252)),
                Padding = new Padding(5),
                Cursor = Cursors.Hand
            };
            
            // Icon Circle
            var pnlCircle = new Panel {
                Size = new Size(32, 32),
                Location = new Point(15, 12),
                BackColor = isImportant ? Color.FromArgb(254, 215, 215) : Color.FromArgb(237, 242, 247),
            };
            
            var lblIcon = new Label { 
                Text = alert.Icon, 
                Font = new Font("Segoe UI", 10), 
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = isImportant ? Color.FromArgb(197, 48, 48) : Color.FromArgb(44, 82, 130)
            };
            pnlCircle.Controls.Add(lblIcon);
            
            var lblText = new Label { 
                Text = alert.Title, 
                AutoSize = true, 
                Location = new Point(60, 12), 
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                ForeColor = isImportant ? Color.FromArgb(155, 44, 44) : Color.FromArgb(27, 58, 107)
            };
            
            var lblTime = new Label { 
                Text = alert.Time, 
                AutoSize = true, 
                Location = new Point(60, 32), 
                ForeColor = isImportant ? Color.FromArgb(197, 48, 48) : Color.Gray, 
                Font = new Font("Segoe UI", 8.5F) 
            };
            
            pnl.Controls.Add(pnlCircle);
            pnl.Controls.Add(lblText);
            pnl.Controls.Add(lblTime);

            pnl.Click += (s, e) => OpenAlertDetails(index);
            foreach(Control c in pnl.Controls) {
                c.Cursor = Cursors.Hand;
                c.Click += (s, e) => OpenAlertDetails(index);
                foreach(Control child in c.Controls) {
                    child.Cursor = Cursors.Hand;
                    child.Click += (s, e) => OpenAlertDetails(index);
                }
            }

            flpActivity.Controls.Add(pnl);
        }

        private void OpenAlertDetails(int index)
        {
            if (index < _currentAlerts.Count)
            {
                var alert = _currentAlerts[index];
                using (var form = new Alert_Details_Form(alert.Icon, alert.Title, alert.Message, alert.Time, alert.Color))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        alert.IsRead = true;
                        LoadRecentActivityFromList();
                    }
                }
            }
        }

        private void LoadRecentActivityFromList()
        {
            flpActivity.Controls.Clear();
            for (int i = 0; i < _currentAlerts.Count; i++)
            {
                AddActivityItem(i);
            }
        }

        private class AdminAlert
        {
            public string Icon { get; set; }
            public string Title { get; set; }
            public string Message { get; set; }
            public string Time { get; set; }
            public bool IsImportant { get; set; }
            public Color Color { get; set; }
            public bool IsRead { get; set; } = false;
        }

        private void dgvRecentPatients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRecentPatients.Columns[e.ColumnIndex].Name == "Status" || dgvRecentPatients.Columns[e.ColumnIndex].HeaderText == "Status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    if (status == "Active")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(56, 161, 105);
                        e.CellStyle.BackColor = Color.FromArgb(198, 246, 213);
                    }
                    else if (status == "Discharged")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(197, 48, 48);
                        e.CellStyle.BackColor = Color.FromArgb(254, 215, 215);
                    }
                }
            }
        }

        private void LoadRecentPatients(elnet_recoverease.Data.AppDbContext db)
        {
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
                    AdherenceValue = db.MedicationSchedules.Count(s => s.PatientID == p.PatientID) > 0
                        ? (int)(db.MedicationSchedules.Count(s => s.PatientID == p.PatientID && s.IsTaken) * 100.0 / db.MedicationSchedules.Count(s => s.PatientID == p.PatientID))
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
