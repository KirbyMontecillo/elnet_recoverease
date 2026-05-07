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
    public partial class Appointments : Form
    {
        private AppDbContext _db = new AppDbContext();

        public Appointments()
        {
            InitializeComponent();
            LoadLogo();
            WireNavigation();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Load += async (s, e) => await LoadAppointmentData();
                dgvAppts.CellContentClick += dgvAppts_CellContentClick;
            }
        }

        private void dgvAppts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colAction.Index && e.RowIndex >= 0)
            {
                var appt = dgvAppts.Rows[e.RowIndex].Tag as Appointment;
                if (appt != null)
                {
                    using (var details = new Appointment_Details_Form(appt))
                    {
                        details.ShowDialog();
                    }
                }
            }
        }

        private async Task LoadAppointmentData()
        {
            try
            {
                if (UserSession.CurrentPatient == null) return;

                int patientId = UserSession.CurrentPatient.PatientID;
                
                // Set Header Info
                lblAvatarInitials.Text = string.Join("", UserSession.CurrentPatient.FullName.Split(' ').Select(n => n[0])).ToUpper();

                var appts = await _db.Appointments
                    .Where(a => a.PatientID == patientId)
                    .OrderByDescending(a => a.AppointmentDate)
                    .ToListAsync();

                // 1. Stats
                var upcoming = appts.Where(a => a.Status == "Scheduled" && a.AppointmentDate >= DateTime.Now).OrderBy(a => a.AppointmentDate).ToList();
                var completed = appts.Where(a => a.Status == "Completed").ToList();

                lblCardNextValue.Text = upcoming.Any() ? upcoming.First().AppointmentDate?.ToString("MMM dd") : "--";
                lblCardUpcomingValue.Text = upcoming.Count.ToString().PadLeft(2, '0');
                lblCardCompletedValue.Text = completed.Count.ToString().PadLeft(2, '0');

                // 2. Grid
                dgvAppts.Rows.Clear();
                foreach (var a in appts)
                {
                    int rowIndex = dgvAppts.Rows.Add(
                        a.AppointmentDate?.ToString("MMM dd, yyyy") ?? "--",
                        a.AppointmentDate?.ToString("hh:mm tt") ?? "--",
                        a.DoctorName ?? "TBD",
                        a.AppointmentType ?? "Consultation",
                        a.Status,
                        "View Details"
                    );
                    dgvAppts.Rows[rowIndex].Tag = a;
                }

                if (dgvAppts.Rows.Count == 0)
                {
                    dgvAppts.Rows.Add("No appointments found.", "-", "-", "-", "-");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        private void WireNavigation()
        {
            // Register click events for panels and their children
            RegisterNavClick(btnNavDashboard, (s, e) => OpenForm(new Patient_Dashboard()));
            RegisterNavClick(btnNavProfile, (s, e) => OpenForm(new Patient_Profile()));
            RegisterNavClick(btnNavMeds, (s, e) => OpenForm(new Medications()));
            RegisterNavClick(btnNavAppointments, (s, e) => { /* Already here */ });
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
