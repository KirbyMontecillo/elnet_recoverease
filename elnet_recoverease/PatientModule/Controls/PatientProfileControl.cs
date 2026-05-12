using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Models;
using elnet_recoverease.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using elnet_recoverease.PatientStation.Forms;

namespace elnet_recoverease.PatientStation.Controls
{
    public partial class PatientProfileControl : UserControl
    {
        public PatientProfileControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
            }
        }

        private async void PatientProfileControl_Load(object sender, EventArgs e)
        {
            await LoadPatientData();
        }

        private async Task LoadPatientData()
        {
            try
            {
                var currentSessionPatient = elnet_recoverease.Core.UserSession.CurrentPatient;
                if (currentSessionPatient == null) return;

                using (var db = new AppDbContext())
                {
                    var patient = await db.Patients.FirstOrDefaultAsync(p => p.PatientID == currentSessionPatient.PatientID);
                    var user = await db.Users.FirstOrDefaultAsync(u => u.UserID == patient.UserID);

                    if (patient == null) return;
                    elnet_recoverease.Core.UserSession.CurrentPatient = patient;

                    lblPatientName.Text = patient.FullName;
                    lblPatientId.Text = $"Patient ID: P-{patient.PatientID:D4}";
                    lblPatientAge.Text = $"Birth Date: {patient.DateOfBirth:MMM dd, yyyy}  |  Gender: {patient.Gender ?? "Not Specified"}";

                    // Status Badge
                    lblStatus.Text = (patient.Status ?? "Active").ToUpper();
                    if (lblStatus.Text == "DISCHARGED")
                    {
                        lblStatus.BackColor = System.Drawing.Color.FromArgb(239, 68, 68); // Red
                    }
                    else
                    {
                        lblStatus.BackColor = System.Drawing.Color.FromArgb(0, 168, 168); // Teal
                    }

                    string initials = string.Join("", patient.FullName.Split(' ').Select(n => n[0])).ToUpper();
                    lblAvatarLargeInitials.Text = initials;

                    lblPhoneVal.Text = patient.ContactNumber ?? "--";
                    lblEmailVal.Text = user?.Username ?? "--";
                    lblAddressVal.Text = patient.Address ?? "--";
                    lblEmergencyNameVal.Text = patient.EmergencyName ?? "--";
                    lblEmergencyRelVal.Text = patient.EmergencyRelationship ?? "--";
                    lblEmergencyPhoneVal.Text = patient.EmergencyPhone ?? "--";

                    var latestConsultation = await db.Appointments
                        .Where(a => a.PatientID == patient.PatientID && a.Status == "Completed")
                        .OrderByDescending(a => a.AppointmentDate)
                        .FirstOrDefaultAsync();

                    lblBloodVal.Text = patient.BloodType ?? "N/A";
                    lblHeightVal.Text = latestConsultation?.Height ?? patient.Height ?? "N/A";
                    lblWeightVal.Text = latestConsultation?.Weight ?? patient.Weight ?? "N/A";

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
            catch { }
        }

        private async void btnEditPersonal_Click(object sender, EventArgs e)
        {
            using (var editForm = new Edit_Patient_Profile())
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    await LoadPatientData();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                elnet_recoverease.Core.UserSession.Logout();
                var login = new Login();
                login.Show();
                this.FindForm()?.Hide();
            }
        }
    }
}
