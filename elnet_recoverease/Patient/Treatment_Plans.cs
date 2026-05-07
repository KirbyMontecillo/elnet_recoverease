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
            LoadLogo();
            WireNavigation();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Load += async (s, e) => await LoadTreatmentData();
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

        private void WireNavigation()
        {
            RegisterNavClick(btnNavDashboard, (s, e) => OpenForm(new Patient_Dashboard()));
            RegisterNavClick(btnNavProfile, (s, e) => OpenForm(new Patient_Profile()));
            RegisterNavClick(btnNavMeds, (s, e) => OpenForm(new Medications()));
            RegisterNavClick(btnNavAppointments, (s, e) => OpenForm(new Appointments()));
            RegisterNavClick(btnNavTreatment, (s, e) => { /* Already here */ });

            btnLogout.Click += (s, e) => {
                UserSession.Logout();
                new Login().Show();
                this.Close();
            };
        }

        private void RegisterNavClick(Panel panel, EventHandler handler)
        {
            panel.Click += handler;
            foreach (Control c in panel.Controls) c.Click += (s, e) => handler(panel, e);
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
