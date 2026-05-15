using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Data;
using elnet_recoverease.Models;

namespace elnet_recoverease.Doctor.Controls
{
    public partial class DoctorProfileControl : UserControl
    {
        private bool _isEditMode = false;
        private AppDbContext _db = new AppDbContext();

        public DoctorProfileControl()
        {
            InitializeComponent();
            LoadProfileData();
        }

        private void DoctorProfileControl_Load(object sender, EventArgs e) => SetupProfileButtons();
        private void DoctorProfileControl_SizeChanged(object sender, EventArgs e) => SetupProfileButtons();

        private void SetupProfileButtons()
        {
            // Force buttons into the header in case designer is stripping them
            pnlProfileHeader.Controls.Add(btnEditProfile);
            pnlProfileHeader.Controls.Add(btnLogout);
            pnlProfileHeader.Controls.Add(btnSaveProfile);
            pnlProfileHeader.Controls.Add(btnUploadPic);

            btnEditProfile.Location = new Point(pnlProfileHeader.Width - 160, 25);
            btnEditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditProfile.Visible = true;
            btnEditProfile.BringToFront();

            btnLogout.Location = new Point(pnlProfileHeader.Width - 160, 75);
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Visible = true;
            btnLogout.BringToFront();

            btnSaveProfile.Location = new Point(pnlProfileHeader.Width - 160, 25);
            btnSaveProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveProfile.Visible = false;
            btnSaveProfile.BringToFront();

            // Setup Upload Pic Button as an overlay
            btnUploadPic.Text = "📷";
            btnUploadPic.Size = new Size(35, 35);
            btnUploadPic.Location = new Point(picProfileLarge.Right - 35, picProfileLarge.Bottom - 35);
            btnUploadPic.FlatStyle = FlatStyle.Flat;
            btnUploadPic.BackColor = Color.FromArgb(240, 245, 250);
            btnUploadPic.ForeColor = Color.FromArgb(0, 168, 168);
            btnUploadPic.FlatAppearance.BorderColor = Color.FromArgb(0, 168, 168);
            btnUploadPic.Visible = false;
            btnUploadPic.BringToFront();

            // Wire up the event
            btnUploadPic.Click -= BtnUploadPic_Click; // Prevents double wiring
            btnUploadPic.Click += BtnUploadPic_Click;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this.FindForm());
        }

        private void btnEditProfile_Click(object sender, EventArgs e) => ToggleEditMode(true);
        private void btnSaveProfile_Click(object sender, EventArgs e) => SaveProfile();

        private void LoadProfileData()
        {
            var staffId = UserSession.CurrentStaff?.StaffID;
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

            var textboxes = new[] { txtLicense, txtExperience, txtAffiliations, txtPhone, txtEmail, txtAddress };
            foreach (var tb in textboxes)
            {
                tb.ReadOnly = !editing;
                tb.BackColor = editing ? Color.White : Color.FromArgb(248, 250, 252);
                tb.BorderStyle = editing ? BorderStyle.FixedSingle : BorderStyle.None;
            }
        }

        private void SaveProfile()
        {
            try
            {
                var staffId = UserSession.CurrentStaff?.StaffID;
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
                    LoadProfileData();
                    ToggleEditMode(false);
                    MessageBox.Show("Profile updated successfully!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error saving profile: " + ex.Message); }
        }

        private void BtnUploadPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var staffId = UserSession.CurrentStaff?.StaffID;
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
                    catch (Exception ex) { MessageBox.Show("Error uploading image: " + ex.Message); }
                }
            }
        }
    }
}
