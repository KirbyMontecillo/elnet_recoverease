using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Admin;

namespace elnet_recoverease.Doctor
{
    public partial class Doctor_Profile : Form
    {
        private bool _isEditMode = false;
        private string _currentDoctorName = "";

        public Doctor_Profile()
        {
            InitializeComponent();
            _currentDoctorName = elnet_recoverease.Core.UserSession.CurrentStaff?.FullName ?? "Doctor";
            
            SetLogo();
            InitializeNavigation();
            LoadProfileData();
            
            btnEditProfile.Click += BtnEditProfile_Click;
            btnChangePassword.Click += BtnChangePassword_Click;

            // Set initials for avatar
            if (!string.IsNullOrEmpty(_currentDoctorName))
            {
                var parts = _currentDoctorName.Split(' ');
                if (parts.Length >= 2) lblAvatarInitials.Text = (parts[0][0].ToString() + parts[1][0].ToString()).ToUpper();
                else lblAvatarInitials.Text = _currentDoctorName.Substring(0, Math.Min(2, _currentDoctorName.Length)).ToUpper();
            }
        }

        private void LoadProfileData()
        {
            var staff = elnet_recoverease.Core.UserSession.CurrentStaff;
            if (staff != null)
            {
                lblDoctorName.Text = staff.FullName;
                lblSpecialty.Text = staff.Specialty ?? "General Practitioner";
                txtLicense.Text = "LIC-" + staff.StaffID.ToString("D5"); // Placeholder for license
                txtExperience.Text = "5 Years"; // Placeholder
                txtPhone.Text = staff.ContactNumber ?? "Not Set";
                txtAddress.Text = "RecoverEase Medical Center, Suite 402";
                
                using (var db = new AppDbContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == staff.UserID);
                    if (user != null) txtEmail.Text = user.Username;
                }
            }
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                // Enter Edit Mode
                _isEditMode = true;
                btnEditProfile.Text = "Save Changes";
                btnEditProfile.BackColor = Color.FromArgb(16, 185, 129); // Success Green
                
                txtPhone.ReadOnly = false;
                txtPhone.BackColor = Color.White;
                txtPhone.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                // Save Changes
                SaveProfile();
                
                _isEditMode = false;
                btnEditProfile.Text = "Edit Profile";
                btnEditProfile.BackColor = Color.FromArgb(0, 168, 168); // Original Teal
                
                txtPhone.ReadOnly = true;
                txtPhone.BackColor = Color.FromArgb(242, 247, 250);
                txtPhone.BorderStyle = BorderStyle.None;
            }
        }

        private void SaveProfile()
        {
            try
            {
                var staff = elnet_recoverease.Core.UserSession.CurrentStaff;
                if (staff == null) return;

                using (var db = new AppDbContext())
                {
                    var dbStaff = db.Staff.Find(staff.StaffID);
                    if (dbStaff != null)
                    {
                        dbStaff.ContactNumber = txtPhone.Text;
                        db.SaveChanges();
                        
                        // Update session
                        elnet_recoverease.Core.UserSession.CurrentStaff.ContactNumber = txtPhone.Text;
                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            // For now, redirect or show a simple input
            MessageBox.Show("Security settings are managed by the system administrator. Please contact IT for password resets.", "Security Policy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetLogo()
        {
            try 
            { 
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) picLogo.Image = Image.FromFile(logoPath);
            } 
            catch { }
        }

        private void InitializeNavigation()
        {
            AttachNavEvents(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            AttachNavEvents(btnNavPatients, () => NavigationHelper.SwitchForm(this, new Patient_List()));
            AttachNavEvents(btnNavAppointments, () => NavigationHelper.SwitchForm(this, new Appointments()));
            AttachNavEvents(btnNavReports, () => NavigationHelper.SwitchForm(this, new Reports()));
            AttachNavEvents(btnNavProfile, () => { /* Already here */ });
            btnLogout.Click += (s, e) => NavigationHelper.Logout(this);
        }

        private void AttachNavEvents(Panel pnl, Action action)
        {
            pnl.Click += (s, e) => action();
            foreach (Control c in pnl.Controls)
            {
                c.Click += (s, e) => action();
            }
        }
    }
}
