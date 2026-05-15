using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Data;
using System.Linq;
using System.Collections.Generic;

namespace elnet_recoverease.Admin.Controls
{
    public partial class AdminDashboardControl : UserControl
    {
        public AdminDashboardControl()
        {
            InitializeComponent();
            this.Load += AdminDashboardControl_Load;
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var now = DateTime.Now;
                    var weekAgo = now.AddDays(-7);

                    // 1. Top Cards
                    int totalPatients = db.Patients.Count();
                    int newThisWeek = db.Patients.Count(p => p.CreatedAt >= weekAgo);
                    BuildTopCard(cardTotal, "Total patients", totalPatients.ToString(), $"↑ {newThisWeek} this week", Color.FromArgb(34, 197, 94));

                    int activePatients = db.Patients.Count(p => p.Status == "Active");
                    int activeNew = db.Patients.Count(p => p.Status == "Active" && p.CreatedAt >= weekAgo);
                    BuildTopCard(cardActive, "Active", activePatients.ToString(), $"↑ {activeNew} this week", Color.FromArgb(34, 197, 94));

                    int apptsScheduled = db.Appointments.Count(a => a.Status == "Scheduled" && a.AppointmentDate >= now.Date);
                    BuildTopCard(cardAppt, "Appointment", apptsScheduled.ToString(), $"{apptsScheduled} scheduled", Color.FromArgb(100, 116, 139));

                    int missedAppts = db.Appointments.Count(a => a.Status == "Missed");
                    int missedMeds = db.MedicationSchedules.Count(m => m.IsMissed);
                    int totalMissed = missedAppts + missedMeds;
                    BuildTopCard(cardMissed, "Missed", totalMissed.ToString(), "⚠ needs attention", Color.FromArgb(239, 68, 68), true);

                    // 2. Patient adherence by doctor
                    flpAdherence.Controls.Clear();
                    var doctors = db.Staff.Where(s => s.Role == "Doctor").ToList();
                    var schedules = db.MedicationSchedules.ToList();
                    var patients = db.Patients.ToList();

                    foreach (var doc in doctors)
                    {
                        var docPatients = patients.Where(p => p.AttendingDoctor == doc.FullName).Select(p => p.PatientID).ToList();
                        var docSchedules = schedules.Where(s => docPatients.Contains(s.PatientID)).ToList();
                        
                        int percentage = 0;
                        if (docSchedules.Count > 0)
                        {
                            int taken = docSchedules.Count(s => s.IsTaken);
                            percentage = (int)((taken / (float)docSchedules.Count) * 100);
                        }
                        BuildAdherenceBar(doc.FullName, percentage);
                    }

                    // 3. Recent activity
                    flpActivity.Controls.Clear();
                    var recentPatients = db.Patients.OrderByDescending(p => p.CreatedAt).Take(3).ToList();
                    var recentMissed = db.MedicationSchedules.Where(m => m.IsMissed).OrderByDescending(m => m.ScheduledDate).Take(3).ToList();

                    var activities = new List<dynamic>();
                    foreach (var rp in recentPatients) activities.Add(new { Date = rp.CreatedAt, Title = $"New patient {rp.FullName}", Sub = "Recently", Icon = "👤" });
                    foreach (var rm in recentMissed)
                    {
                        var pat = patients.FirstOrDefault(p => p.PatientID == rm.PatientID);
                        string pname = pat != null ? pat.FullName : "Unknown";
                        activities.Add(new { Date = rm.ScheduledDate.ToDateTime(TimeOnly.MinValue), Title = $"{pname} missed medication", Sub = "Action req.", Icon = "💊" });
                    }

                    foreach (var act in activities.OrderByDescending(a => a.Date).Take(5))
                    {
                        BuildActivityItem(act.Title, act.Sub, act.Icon);
                    }

                    // 4. Recent Patients Grid
                    var gridData = new List<dynamic>();
                    var recentAppts = db.Appointments.OrderByDescending(a => a.CreatedAt).Take(10).ToList();
                    
                    // We'll just grab all patients to match the layout
                    foreach (var p in patients)
                    {
                        var latestAppt = recentAppts.FirstOrDefault(a => a.PatientID == p.PatientID);
                        string nextAppt = latestAppt != null && latestAppt.AppointmentDate > now ? latestAppt.AppointmentDate.Value.ToString("MMM dd") : "None";
                        
                        var pSchedules = schedules.Where(s => s.PatientID == p.PatientID).ToList();
                        int pAdh = pSchedules.Count > 0 ? (int)((pSchedules.Count(s => s.IsTaken) / (float)pSchedules.Count) * 100) : 0;

                        gridData.Add(new {
                            FullName = p.FullName,
                            Doctor = p.AttendingDoctor ?? "Unassigned",
                            Plan = "Standard", // Placeholder
                            NextAppt = nextAppt,
                            Adherence = $"{pAdh}%",
                            Status = p.Status ?? "Active"
                        });
                    }
                    
                    dgvRecentPatients.AutoGenerateColumns = false;
                    dgvRecentPatients.DataSource = gridData;
                }
            }
            catch { }
        }

        private void BuildTopCard(Panel container, string title, string val, string sub, Color subColor, bool isAlert = false)
        {
            container.Controls.Clear();
            var lblTitle = new Label { Text = title, ForeColor = Color.FromArgb(100, 116, 139), Font = new Font("Segoe UI", 9F), Location = new Point(15, 15), AutoSize = true };
            var lblVal = new Label { Text = val, ForeColor = isAlert ? Color.FromArgb(239, 68, 68) : Color.FromArgb(15, 23, 42), Font = new Font("Segoe UI", 20F, FontStyle.Bold), Location = new Point(15, 35), AutoSize = true };
            var lblSub = new Label { Text = sub, ForeColor = subColor, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), Location = new Point(15, 80), AutoSize = true };
            
            container.Controls.Add(lblTitle);
            container.Controls.Add(lblVal);
            container.Controls.Add(lblSub);
        }

        private void BuildAdherenceBar(string doctorName, int percentage)
        {
            var pnlRow = new Panel { Width = 500, Height = 40, Margin = new Padding(0, 0, 0, 10) };
            var lblDoc = new Label { Text = doctorName, Font = new Font("Segoe UI", 9F), Location = new Point(0, 10), AutoSize = true, Width = 150 };
            
            var pnlTrack = new Panel { BackColor = Color.FromArgb(241, 245, 249), Height = 6, Width = 250, Location = new Point(160, 17) };
            var pnlFill = new Panel { BackColor = Color.FromArgb(56, 189, 248), Height = 6, Width = (int)(250 * (percentage / 100f)), Location = new Point(0, 0) };
            if (percentage > 0) pnlTrack.Controls.Add(pnlFill);
            
            var lblPct = new Label { Text = $"{percentage}%", Font = new Font("Segoe UI", 9F, FontStyle.Bold), Location = new Point(420, 10), AutoSize = true };
            
            pnlRow.Controls.Add(lblDoc);
            pnlRow.Controls.Add(pnlTrack);
            pnlRow.Controls.Add(lblPct);
            flpAdherence.Controls.Add(pnlRow);
        }

        private void BuildActivityItem(string title, string subtitle, string icon)
        {
            var pnlRow = new Panel { Width = 600, Height = 55, Margin = new Padding(0, 0, 0, 5) };
            var lblIcon = new Label { Text = icon, Font = new Font("Segoe UI", 12F), Location = new Point(0, 10), AutoSize = true };
            var lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), Location = new Point(35, 10), AutoSize = true };
            var lblSub = new Label { Text = subtitle, ForeColor = Color.Gray, Font = new Font("Segoe UI", 8F), Location = new Point(35, 30), AutoSize = true };
            
            pnlRow.Controls.Add(lblIcon);
            pnlRow.Controls.Add(lblTitle);
            pnlRow.Controls.Add(lblSub);
            flpActivity.Controls.Add(pnlRow);
        }
    }
}
