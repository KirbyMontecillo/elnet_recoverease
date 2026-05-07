using elnet_recoverease.Core;
using elnet_recoverease.Models;
using elnet_recoverease.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elnet_recoverease
{
    public partial class Patient_Profile : Form
    {
        public Patient_Profile()
        {
            InitializeComponent();
            LoadLogo();
            WireNavigation();
            
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.Load += async (s, e) => await LoadPatientData();
            }
        }

        private async Task LoadPatientData()
        {
            try
            {
                var currentSessionPatient = UserSession.CurrentPatient;
                if (currentSessionPatient == null) return;

                using (var db = new AppDbContext())
                {
                    // Fetch latest from DB to ensure sync
                    var patient = await db.Patients.FirstOrDefaultAsync(p => p.PatientID == currentSessionPatient.PatientID);
                    var user = await db.Users.FirstOrDefaultAsync(u => u.UserID == patient.UserID);

                    if (patient == null) return;

                    // Sync session just in case
                    UserSession.CurrentPatient = patient;

                    // Header info
                    lblPatientName.Text = patient.FullName;
                    lblPatientId.Text = $"Patient ID: P-{patient.PatientID:D4}";
                    lblPatientAge.Text = $"Birth Date: {patient.DateOfBirth:MMM dd, yyyy}  |  Gender: {patient.Gender ?? "Not Specified"}";
                    
                    // Avatar initials
                    string initialsText = "";
                    string fullName = patient.FullName ?? "Patient";
                    string[] nameParts = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    
                    if (nameParts.Length > 0) initialsText += nameParts[0][0];
                    if (nameParts.Length > 1) initialsText += nameParts[nameParts.Length - 1][0];
                    
                    if (string.IsNullOrEmpty(initialsText)) initialsText = "P";
                    
                    lblAvatarInitials.Text = initialsText.ToUpper();
                    lblAvatarLargeInitials.Text = initialsText.ToUpper();

                    // Personal Info
                    lblPhoneVal.Text = patient.ContactNumber ?? "--";
                    lblEmailVal.Text = user?.Username ?? "--";
                    lblAddressVal.Text = patient.Address ?? "--";
                    lblEmergencyNameVal.Text = patient.EmergencyName ?? "--";
                    lblEmergencyRelVal.Text = patient.EmergencyRelationship ?? "--";
                    lblEmergencyPhoneVal.Text = patient.EmergencyPhone ?? "--";

                    // 2. Fetch Latest Consultation for physical data (Weight, Height)
                    var latestConsultation = await db.Appointments
                        .Where(a => a.PatientID == patient.PatientID && a.Status == "Completed")
                        .OrderByDescending(a => a.AppointmentDate)
                        .FirstOrDefaultAsync();

                    // Medical Overview
                    lblBloodVal.Text = patient.BloodType ?? "N/A";
                    
                    // Priority: Use consultation data if available, fallback to profile data
                    lblHeightVal.Text = latestConsultation?.Height ?? patient.Height ?? "N/A";
                    lblWeightVal.Text = latestConsultation?.Weight ?? patient.Weight ?? "N/A";
                    
                    lblAllergiesVal.Text = patient.Allergies ?? "None Reported";

                    // 3. Fetch Attending Doctor Info
                    if (!string.IsNullOrEmpty(patient.AttendingDoctor))
                    {
                        var doctor = await db.Staff.FirstOrDefaultAsync(s => s.FullName == patient.AttendingDoctor);
                        if (doctor != null)
                        {
                            lblAttendingDoctorVal.Text = $"Dr. {doctor.FullName}";
                            lblDocSpecialtyVal.Text = doctor.Specialty ?? "General Practitioner";
                            lblDocContactVal.Text = $"Contact: {doctor.ContactNumber ?? "--"}";
                        }
                        else
                        {
                            lblAttendingDoctorVal.Text = patient.AttendingDoctor;
                            lblDocSpecialtyVal.Text = "No additional info available.";
                            lblDocContactVal.Text = "--";
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Silent fail or minimal error handling for profile load
            }
        }

        private void WireNavigation()
        {
            RegisterNavClick(btnNavDashboard, (s, e) => OpenForm(new Patient_Dashboard()));
            RegisterNavClick(btnNavProfile, (s, e) => { /* Already here */ });
            RegisterNavClick(btnNavMeds, (s, e) => OpenForm(new Medications()));
            RegisterNavClick(btnNavAppointments, (s, e) => OpenForm(new Appointments()));
            RegisterNavClick(btnNavTreatment, (s, e) => OpenForm(new Treatment_Plans()));

            btnLogout.Click += (s, e) => {
                UserSession.Logout();
                new Login().Show();
                this.Close();
            };

            btnEditPersonal.Click += async (s, e) => {
                using (var editForm = new Edit_Patient_Profile())
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        await LoadPatientData(); // Refresh labels
                    }
                }
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
            this.Close();
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
            catch (Exception)
            {
            }
        }

        private void Patient_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
