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

        public Doctor_Dashboard()
        {
            InitializeComponent();
            _doctor = UserSession.CurrentStaff;
            
            InitializeDashboard();
            LoadData();
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

                // 2. Appointments Today
                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);
                var apptsToday = await _db.Appointments
                    .Where(a => a.AppointmentDate >= today && a.AppointmentDate < tomorrow && a.DoctorName == _doctor.FullName)
                    .Join(_db.Patients, a => a.PatientID, p => p.PatientID, (a, p) => new { a, p })
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

                // 5. Load Recent Alerts in Sidebar
                LoadAlerts(missedMeds.Take(3).ToList());
            }
            catch (Exception ex)
            {
                // Silent fail or log
            }
        }

        private void LoadAlerts(dynamic alerts)
        {
            pnlAlert1.Visible = alerts.Count > 0;
            pnlAlert2.Visible = alerts.Count > 1;
            pnlAlert3.Visible = alerts.Count > 2;

            if (alerts.Count > 0)
            {
                lblAlert1Text.Text = $"Missed Med: {alerts[0].p.FullName}";
                lblAlert1Time.Text = $"Scheduled: {alerts[0].s.ScheduledTime}";
            }
            if (alerts.Count > 1)
            {
                lblAlert2Text.Text = $"Missed Med: {alerts[1].p.FullName}";
                lblAlert2Time.Text = $"Scheduled: {alerts[1].s.ScheduledTime}";
            }
            if (alerts.Count > 2)
            {
                lblAlert3Text.Text = $"Missed Med: {alerts[2].p.FullName}";
                lblAlert3Time.Text = $"Scheduled: {alerts[2].s.ScheduledTime}";
            }
        }
    }
}
