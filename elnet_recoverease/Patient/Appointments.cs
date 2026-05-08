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
                this.Load += new EventHandler(Appointments_Load);
                dgvAppts.CellContentClick += new DataGridViewCellEventHandler(dgvAppts_CellContentClick);
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

        private async void Appointments_Load(object sender, EventArgs e)
        {
            await LoadAppointmentData();
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
        private void btnNavMeds_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Medications()); }
        private void btnNavAppointments_Click(object sender, EventArgs e) { /* Already here */ }
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
