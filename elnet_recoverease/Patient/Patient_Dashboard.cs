using System;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Models;

namespace elnet_recoverease
{
    public partial class Patient_Dashboard : Form
    {
        public Patient_Dashboard()
        {
            InitializeComponent();
            LoadLogo();
            WireNavigation();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            var patient = UserSession.CurrentPatient;
            if (patient == null) return;

            // Welcome Message
            lblWelcome.Text = $"Welcome back, {patient.FullName}! Manage your health seamlessly.";

            // Avatar Initials
            string initials = "";
            var names = patient.FullName.Split(' ');
            if (names.Length > 0 && !string.IsNullOrEmpty(names[0])) initials += names[0][0];
            if (names.Length > 1 && !string.IsNullOrEmpty(names[names.Length - 1])) initials += names[names.Length - 1][0];
            lblAvatarInitials.Text = initials.ToUpper();

            // Load Stats from Database
            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    // 1. Medications Today
                    var today = DateOnly.FromDateTime(DateTime.Today);
                    int medCount = db.MedicationSchedules
                        .Count(ms => ms.PatientID == patient.PatientID && ms.ScheduledDate == today);
                    lblCardMedsValue.Text = medCount.ToString();

                    // 2. Next Appointment
                    var nextAppt = db.Appointments
                        .Where(a => a.PatientID == patient.PatientID && a.AppointmentDate >= DateTime.Now)
                        .OrderBy(a => a.AppointmentDate)
                        .FirstOrDefault();
                    
                    if (nextAppt != null)
                        lblCardApptValue.Text = nextAppt.AppointmentDate.ToString("MMM dd");
                    else
                        lblCardApptValue.Text = "None";

                    // 3. Adherence (Mock logic for now)
                    lblCardAdhrValue.Text = "94%";
                    lblCardMissValue.Text = "1";
                }
            }
            catch { }
        }

        private void WireNavigation()
        {
            // Register click events for panels and their children
            RegisterNavClick(btnNavDashboard, (s, e) => { /* Already on Dashboard */ });
            RegisterNavClick(btnNavProfile, (s, e) => OpenForm(new Patient_Profile()));
            RegisterNavClick(btnNavMeds, (s, e) => OpenForm(new Medications()));
            RegisterNavClick(btnNavMedSchedule, (s, e) => OpenForm(new Medication_Schedule()));
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
            this.Hide();
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