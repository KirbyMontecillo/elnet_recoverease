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
        private AppDbContext _db = new AppDbContext();

        public Doctor_Profile()
        {
            InitializeComponent();
            InitializeNavigation();
            LoadProfileData();
            
            btnEditProfile.Click += new EventHandler(btnEditProfile_Click);
            btnSaveProfile.Click += new EventHandler(btnSaveProfile_Click);
            btnUploadPic.Click += BtnUploadPic_Click;
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ToggleEditMode(true);
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }

        private void LoadProfileData()
        {
            var staffId = elnet_recoverease.Core.UserSession.CurrentStaff?.StaffID;
            if (!staffId.HasValue) return;

            var staff = _db.Staff.Find(staffId.Value);
            if (staff == null) return;

            lblDoctorName.Text = staff.FullName;
            lblSpecialty.Text = staff.Specialty ?? "General Practitioner";
            lblBioContent.Text = staff.Biography ?? "No biography recorded.";
            txtBioEdit.Text = staff.Biography;

            txtLicense.Text = staff.LicenseNumber ?? "N/A";
            txtExperience.Text = staff.YearsOfExperience ?? "Not specified";
            txtAffiliations.Text = staff.Affiliations ?? "No clinical affiliations recorded";

            txtPhone.Text = staff.ContactNumber ?? "Not specified";
            txtEmail.Text = staff.Email ?? "Not specified";
            txtAddress.Text = staff.ClinicAddress ?? "Not specified";

            if (!string.IsNullOrEmpty(staff.ProfileImagePath) && System.IO.File.Exists(staff.ProfileImagePath))
            {
                picProfileLarge.Image = Image.FromFile(staff.ProfileImagePath);
            }
            

        }

        private void ToggleEditMode(bool editing)
        {
            _isEditMode = editing;
            
            // Toggle visibility
            lblBioContent.Visible = !editing;
            txtBioEdit.Visible = editing;
            
            btnEditProfile.Visible = !editing;
            btnSaveProfile.Visible = editing;
            btnUploadPic.Visible = editing;

            // Toggle ReadOnly for textboxes
            txtLicense.ReadOnly = !editing;
            txtExperience.ReadOnly = !editing;
            txtAffiliations.ReadOnly = !editing;
            txtPhone.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            txtAddress.ReadOnly = !editing;

            // Visual feedback for edit mode
            Color bgColor = editing ? Color.White : Color.FromArgb(242, 247, 250);
            BorderStyle border = editing ? BorderStyle.FixedSingle : BorderStyle.None;

            var textboxes = new[] { txtLicense, txtExperience, txtAffiliations, txtPhone, txtEmail, txtAddress };
            foreach (var tb in textboxes)
            {
                tb.BackColor = bgColor;
                tb.BorderStyle = border;
            }
        }

        private void SaveProfile()
        {
            try
            {
                var staffId = elnet_recoverease.Core.UserSession.CurrentStaff?.StaffID;
                if (!staffId.HasValue) return;

                var staff = _db.Staff.Find(staffId.Value);
                if (staff != null)
                {
                    staff.Biography = txtBioEdit.Text;
                    staff.LicenseNumber = txtLicense.Text;
                    staff.YearsOfExperience = txtExperience.Text;
                    staff.Affiliations = txtAffiliations.Text;
                    staff.ContactNumber = txtPhone.Text;
                    staff.Email = txtEmail.Text;
                    staff.ClinicAddress = txtAddress.Text;

                    _db.SaveChanges();
                    
                    // Refresh UI
                    LoadProfileData();
                    ToggleEditMode(false);
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message);
            }
        }

        private void BtnUploadPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var staffId = elnet_recoverease.Core.UserSession.CurrentStaff?.StaffID;
                        var staff = _db.Staff.Find(staffId);
                        if (staff != null)
                        {
                            string destDir = System.IO.Path.Combine(Application.StartupPath, "uploads", "profiles");
                            if (!System.IO.Directory.Exists(destDir)) System.IO.Directory.CreateDirectory(destDir);
                            
                            string destPath = System.IO.Path.Combine(destDir, $"staff_{staffId}.png");
                            System.IO.File.Copy(ofd.FileName, destPath, true);
                            
                            staff.ProfileImagePath = destPath;
                            _db.SaveChanges();
                            
                            picProfileLarge.Image = Image.FromFile(destPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error uploading image: " + ex.Message);
                    }
                }
            }
        }


        private void InitializeNavigation()
        {
            try {
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) picLogo.Image = Image.FromFile(logoPath);
                picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            } catch { }

            NavigationHelper.WireNavButton(btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(btnNavAppointments, new EventHandler(btnNavAppointments_Click));
            NavigationHelper.WireNavButton(btnNavReports, new EventHandler(btnNavReports_Click));
            btnLogout.Click += new EventHandler(btnLogout_Click);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Doctor_Dashboard());
        }

        private void btnNavPatients_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Patient_List());
        }

        private void btnNavAppointments_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Appointments());
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Reports());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }
    }
}
