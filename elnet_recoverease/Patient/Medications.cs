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
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease
{
    public partial class Medications : Form
    {
        private AppDbContext _db = new AppDbContext();
        private List<MedicationSchedule> _todaySchedules = new List<MedicationSchedule>();
        private string _activeTab = "Morning";

        public Medications()
        {
            InitializeComponent();

            // Force Layout fix to prevent overlapping
            pnlMain.Controls.Remove(pnlTopBar);
            pnlMain.Controls.Remove(pnlContent);
            pnlMain.Controls.Add(pnlContent);
            pnlMain.Controls.Add(pnlTopBar);
            pnlTopBar.SendToBack();
            pnlContent.BringToFront();

            LoadLogo();
            WireNavigation();
            WireTabs();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Load += new EventHandler(Medications_Load);
            }
        }

        private void WireTabs()
        {
            btnTabMorning.Click += new EventHandler(btnTabMorning_Click);
            btnTabNoon.Click += new EventHandler(btnTabNoon_Click);
            btnTabEvening.Click += new EventHandler(btnTabEvening_Click);
        }

        private void btnTabMorning_Click(object sender, EventArgs e) { SwitchTab("Morning", btnTabMorning); RefreshTimeline(); }
        private void btnTabNoon_Click(object sender, EventArgs e) { SwitchTab("Noon", btnTabNoon); RefreshTimeline(); }
        private void btnTabEvening_Click(object sender, EventArgs e) { SwitchTab("Evening", btnTabEvening); RefreshTimeline(); }

        private async void Medications_Load(object sender, EventArgs e)
        {
            await LoadMedicationData();
        }

        private void SwitchTab(string tab, Button activeBtn)
        {
            _activeTab = tab;
            
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrTextDark = System.Drawing.ColorTranslator.FromHtml("#1E293B");

            btnTabMorning.BackColor = btnTabNoon.BackColor = btnTabEvening.BackColor = clrNavy;
            btnTabMorning.ForeColor = btnTabNoon.ForeColor = btnTabEvening.ForeColor = clrTextDark;
            
            activeBtn.BackColor = clrNavyActive;
            activeBtn.ForeColor = Color.White;
        }

        private async Task LoadMedicationData()
        {
            try
            {
                if (UserSession.CurrentPatient == null) return;

                int patientId = UserSession.CurrentPatient.PatientID;
                
                // Set Header Info
                lblAvatarInitials.Text = string.Join("", UserSession.CurrentPatient.FullName.Split(' ').Select(n => n[0])).ToUpper();

                var schedules = await _db.MedicationSchedules
                    .Where(m => m.PatientID == patientId)
                    .ToListAsync();

                // 1. Active Prescriptions (Unique medications with upcoming doses)
                var activeMeds = schedules
                    .Where(s => s.ScheduledDate >= DateOnly.FromDateTime(DateTime.Now))
                    .GroupBy(s => s.MedicationName)
                    .Select(g => g.First())
                    .ToList();

                lblCardActiveMedsValue.Text = activeMeds.Count.ToString().PadLeft(2, '0');

                lblCardActiveMedsValue.Text = activeMeds.Count.ToString().PadLeft(2, '0');

                // 3. Adherence Score
                var pastSchedules = schedules.Where(s => s.ScheduledDate < DateOnly.FromDateTime(DateTime.Now) || 
                                                       (s.ScheduledDate == DateOnly.FromDateTime(DateTime.Now) && s.ScheduledTime < TimeOnly.FromDateTime(DateTime.Now))).ToList();
                
                if (pastSchedules.Any())
                {
                    double score = (double)pastSchedules.Count(s => s.IsTaken) / pastSchedules.Count * 100;
                    lblCardAdhrValue.Text = $"{score:F0}%";
                }
                else
                {
                    lblCardAdhrValue.Text = "100%";
                }

                // 4. Populate Grid
                dgvMeds.Rows.Clear();
                foreach (var med in activeMeds)
                {
                    dgvMeds.Rows.Add(
                        med.MedicationName,
                        med.DosageUnit,
                        med.Frequency ?? "3x a day",
                        UserSession.CurrentPatient?.AttendingDoctor ?? "Not Assigned",
                        "Active"
                    );
                }

                if (dgvMeds.Rows.Count == 0)
                {
                    dgvMeds.Rows.Add("No active prescriptions found.", "-", "-", "-", "-");
                }

                // 5. Load Today's Schedule for Timeline
                var today = DateOnly.FromDateTime(DateTime.Now);
                _todaySchedules = schedules
                    .Where(s => s.ScheduledDate == today)
                    .OrderBy(s => s.ScheduledTime)
                    .ToList();

                RefreshTimeline();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medication data: " + ex.Message);
            }
        }

        private void RefreshTimeline()
        {
            pnlTimelineItems.Controls.Clear();
            
            TimeOnly start = new TimeOnly(0, 0);
            TimeOnly end = new TimeOnly(23, 59);

            if (_activeTab == "Morning") { start = new TimeOnly(0, 0); end = new TimeOnly(10, 59); }
            else if (_activeTab == "Noon") { start = new TimeOnly(11, 0); end = new TimeOnly(15, 59); }
            else if (_activeTab == "Evening") { start = new TimeOnly(16, 0); end = new TimeOnly(23, 59); }

            var periodMeds = _todaySchedules
                .Where(s => s.ScheduledTime >= start && s.ScheduledTime <= end)
                .ToList();

            int y = 10;
            foreach (var med in periodMeds)
            {
                var item = CreateTimelineItem(med, y);
                pnlTimelineItems.Controls.Add(item);
                y += 60;
            }

            if (!periodMeds.Any())
            {
                var lblEmpty = new Label
                {
                    Text = "No medications scheduled for this period.",
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 9)
                };
                pnlTimelineItems.Controls.Add(lblEmpty);
            }
        }

        private Panel CreateTimelineItem(MedicationSchedule schedule, int y)
        {
            var pnl = new Panel { Size = new Size(pnlTimelineItems.Width - 40, 50), Location = new Point(10, y), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            
            var circle = new Panel { Size = new Size(12, 12), Location = new Point(8, 19), BackColor = GetTimelineColor(schedule) };
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, circle.Width, circle.Height);
            circle.Region = new Region(path);

            var lblTime = new Label { Text = schedule.ScheduledTime?.ToString("h tt").ToLower(), Location = new Point(25, 17), AutoSize = true, Font = new Font("Segoe UI Semibold", 8), ForeColor = Color.FromArgb(100, 120, 145) };

            var card = new Panel { Location = new Point(60, 5), Size = new Size(pnl.Width - 70, 40), BackColor = Color.FromArgb(230, 245, 245), Padding = new Padding(10, 8, 10, 8), Cursor = Cursors.Hand };
            
            var chk = new CheckBox { Text = $"{schedule.MedicationName} ({schedule.DosageUnit})", Checked = schedule.IsTaken, Dock = DockStyle.Fill, Font = new Font("Segoe UI", 9), ForeColor = Color.FromArgb(30, 41, 59) };
            chk.Tag = new { Schedule = schedule, Circle = circle };
            chk.CheckedChanged += new EventHandler(Medication_CheckedChanged);

            card.Controls.Add(chk);
            pnl.Controls.AddRange(new Control[] { circle, lblTime, card });
            
            return pnl;
        }

        private async void Medication_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox chk && chk.Tag != null)
            {
                // Accessing anonymous type properties via dynamic or reflection - using dynamic for brevity in this specific UI case
                dynamic data = chk.Tag;
                MedicationSchedule schedule = data.Schedule;
                Panel circle = data.Circle;

                schedule.IsTaken = chk.Checked;
                schedule.IsMissed = !chk.Checked && (schedule.ScheduledTime < TimeOnly.FromDateTime(DateTime.Now));
                _db.Update(schedule);
                await _db.SaveChangesAsync();
                circle.BackColor = GetTimelineColor(schedule);

                // Refresh adherence score on the card
                var patientId = UserSession.CurrentPatient.PatientID;
                var allSchedules = await _db.MedicationSchedules.Where(m => m.PatientID == patientId).ToListAsync();
                var pastSchedules = allSchedules.Where(sch => sch.ScheduledDate < DateOnly.FromDateTime(DateTime.Now) || 
                                                       (sch.ScheduledDate == DateOnly.FromDateTime(DateTime.Now) && sch.ScheduledTime < TimeOnly.FromDateTime(DateTime.Now))).ToList();
                if (pastSchedules.Any())
                {
                    double score = (double)pastSchedules.Count(sch => sch.IsTaken) / pastSchedules.Count * 100;
                    lblCardAdhrValue.Text = $"{score:F0}%";
                }
            }
        }

        private Color GetTimelineColor(MedicationSchedule s)
        {
            if (s.IsTaken) return Color.FromArgb(39, 174, 96);
            if (s.IsMissed) return Color.FromArgb(192, 57, 43);
            return Color.FromArgb(0, 168, 168);
        }

        private void WireNavigation()
        {
            NavigationHelper.WireNavButton(btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(btnNavProfile, new EventHandler(btnNavProfile_Click));
            NavigationHelper.WireNavButton(btnNavMeds, new EventHandler(btnNavMeds_Click));
            NavigationHelper.WireNavButton(btnNavAppointments, new EventHandler(btnNavAppointments_Click));
            NavigationHelper.WireNavButton(btnNavTreatment, new EventHandler(btnNavTreatment_Click));

            btnLogout.Click += new EventHandler(btnLogout_Click);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Patient_Dashboard()); }
        private void btnNavProfile_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Patient_Profile()); }
        private void btnNavMeds_Click(object sender, EventArgs e) { /* Already here */ }
        private void btnNavAppointments_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Appointments()); }
        private void btnNavTreatment_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Treatment_Plans()); }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void OpenForm(Form childForm)
        {
            NavigationHelper.SwitchForm(this, childForm);
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
