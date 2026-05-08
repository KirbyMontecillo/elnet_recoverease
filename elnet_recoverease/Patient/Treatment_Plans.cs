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
    public partial class Treatment_Plans : Form
    {
        private AppDbContext _db = new AppDbContext();

        public Treatment_Plans()
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

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Load += new EventHandler(Treatment_Plans_Load);
            }
        }

        private async Task LoadTreatmentData()
        {
            try
            {
                if (UserSession.CurrentPatient == null) return;

                int patientId = UserSession.CurrentPatient.PatientID;
                
                // Set Header Info
                lblAvatarInitials.Text = string.Join("", UserSession.CurrentPatient.FullName.Split(' ').Select(n => n[0])).ToUpper();

                var plans = await _db.TreatmentPlans
                    .Where(p => p.PatientID == patientId)
                    .OrderByDescending(p => p.CreatedAt)
                    .ToListAsync();

                // 1. Stats
                if (plans.Any())
                {
                    var latest = plans.First();
                    lblCardActiveValue.Text = latest.StartDate.ToString("MMM dd") + " - " + latest.EndDate.ToString("MMM dd");
                }
                else
                {
                    lblCardActiveValue.Text = "No Plan Found";
                }

                // 2. Grid
                dgvTreatments.Rows.Clear();
                string attendingDoc = UserSession.CurrentPatient?.AttendingDoctor ?? "Not Assigned";

                foreach (var p in plans)
                {
                    string details = p.PlanDetails ?? "No details provided.";
                    if (details.Length > 80) details = details.Substring(0, 77) + "...";

                    dgvTreatments.Rows.Add(
                        p.EndDate.ToString("MMM dd, yyyy"),
                        details,
                        attendingDoc,
                        (p.EndDate >= DateTime.Now) ? "Active" : "Completed"
                    );
                }

                if (dgvTreatments.Rows.Count == 0)
                {
                    dgvTreatments.Rows.Add("-", "No treatment history found.", "-", "-");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading treatment plans: " + ex.Message);
            }
        }

        private async void Treatment_Plans_Load(object sender, EventArgs e)
        {
            await LoadTreatmentData();
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
        private void btnNavAppointments_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Appointments()); }
        private void btnNavTreatment_Click(object sender, EventArgs e) { /* Already here */ }

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
