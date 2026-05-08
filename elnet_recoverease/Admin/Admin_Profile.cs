using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Data;
using elnet_recoverease.Models;

namespace elnet_recoverease.Admin
{
    public partial class Admin_Profile : Form
    {
        private bool _isEditMode = false;
        private AppDbContext _db = new AppDbContext();

        public Admin_Profile()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            try 
            { 
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\images\logo.png");
                if (!System.IO.File.Exists(logoPath)) logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) this.picLogo.Image = Image.FromFile(logoPath); 
            } 
            catch { }

            // Navigation
            NavigationHelper.WireNavButton(this.btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(this.btnNavStaff, new EventHandler(btnNavStaff_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavReports, new EventHandler(btnNavReports_Click));
            this.btnLogout.Click += new EventHandler(btnLogout_Click);

            // Actions
            btnEditProfile.Click += new EventHandler(btnEditProfile_Click);
            btnSaveProfile.Click += new EventHandler(btnSaveProfile_Click);
            btnUploadPic.Click += new EventHandler(btnUploadPic_Click);

            this.Load += new EventHandler(Admin_Profile_Load);
        }

        private void Admin_Profile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Dashboard());
        }

        private void btnNavStaff_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Staff_List());
        }

        private void btnNavPatients_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Medication_List());
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Report());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
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

            if (!string.IsNullOrEmpty(staff.FullName))
            {
                var parts = staff.FullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 1) lblAvatarInitials.Text = (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
                else if (parts.Length == 1) lblAvatarInitials.Text = parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            }

            if (!string.IsNullOrEmpty(staff.ProfileImagePath) && System.IO.File.Exists(staff.ProfileImagePath))
            {
                try { picProfileLarge.Image = Image.FromFile(staff.ProfileImagePath); } catch { }
            }
        }

        private void ToggleEditMode(bool editing)
        {
            _isEditMode = editing;
            lblBioContent.Visible = !editing;
            txtBioEdit.Visible = editing;
            btnEditProfile.Visible = !editing;
            btnSaveProfile.Visible = editing;
            btnUploadPic.Visible = editing;

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

        private void lblContactInfoTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
