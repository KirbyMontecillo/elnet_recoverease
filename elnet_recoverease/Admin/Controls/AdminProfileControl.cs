using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Data;
using elnet_recoverease.Models;

namespace elnet_recoverease.Admin.Controls
{
    public partial class AdminProfileControl : UserControl
    {
        private bool _isEditMode = false;
        private AppDbContext _db = new AppDbContext();

        public AdminProfileControl()
        {
            InitializeComponent();
            SetupControl();
        }

        private void SetupControl()
        {
        }

        private void AdminProfileControl_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ToggleEditMode(true);
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
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

                            string destPath = System.IO.Path.Combine(destDir, $"admin_{staffId}.png");
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

        private void LoadProfileData()
        {
            var staffId = elnet_recoverease.Core.UserSession.CurrentStaff?.StaffID;
            if (!staffId.HasValue) return;

            var staff = _db.Staff.Find(staffId.Value);
            if (staff == null) return;

            lblAdminName.Text = staff.FullName;
            lblRole.Text = staff.Role ?? "System Administrator";
            lblBioContent.Text = staff.Biography ?? "No biography recorded.";
            txtBioEdit.Text = staff.Biography;

            txtExperience.Text = staff.YearsOfExperience ?? "Not specified";
            txtAffiliations.Text = staff.Affiliations ?? "No professional affiliations recorded";

            txtPhone.Text = staff.ContactNumber ?? "Not specified";
            txtEmail.Text = staff.Email ?? "Not specified";
            txtAddress.Text = staff.ClinicAddress ?? "Not specified";

            if (!string.IsNullOrEmpty(staff.ProfileImagePath) && System.IO.File.Exists(staff.ProfileImagePath))
            {
                try { picProfileLarge.Image = Image.FromFile(staff.ProfileImagePath); } catch { }
            }
            
            // Inform the parent form to update the Avatar initials if necessary
            var mainForm = this.FindForm() as Forms.AdminMainForm;
            // The top bar initials might be handled directly in the MainForm loading,
            // but we ensure the local fields are updated.
        }

        private void ToggleEditMode(bool editing)
        {
            _isEditMode = editing;
            lblBioContent.Visible = !editing;
            txtBioEdit.Visible = editing;
            btnEditProfile.Visible = !editing;
            btnSaveProfile.Visible = editing;
            btnUploadPic.Visible = editing;
            btnLogoutProfile.Visible = !editing;

            txtExperience.ReadOnly = !editing;
            txtAffiliations.ReadOnly = !editing;
            txtPhone.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            txtAddress.ReadOnly = !editing;

            Color bgColor = editing ? Color.White : Color.FromArgb(242, 247, 250);
            BorderStyle border = editing ? BorderStyle.FixedSingle : BorderStyle.None;

            var textboxes = new[] { txtExperience, txtAffiliations, txtPhone, txtEmail, txtAddress };
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
                    staff.YearsOfExperience = txtExperience.Text;
                    staff.Affiliations = txtAffiliations.Text;
                    staff.ContactNumber = txtPhone.Text;
                    staff.Email = txtEmail.Text;
                    staff.ClinicAddress = txtAddress.Text;

                    _db.SaveChanges();
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
        private void btnLogoutProfile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var mainForm = this.FindForm();
                if (mainForm != null) NavigationHelper.Logout(mainForm);
            }
        }
    }
}
