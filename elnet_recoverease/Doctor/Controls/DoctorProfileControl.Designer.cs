namespace elnet_recoverease.Doctor.Controls
{
    partial class DoctorProfileControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlProfileHeader = new System.Windows.Forms.Panel();
            this.picProfileLarge = new System.Windows.Forms.PictureBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblBioContent = new System.Windows.Forms.Label();
            this.txtBioEdit = new System.Windows.Forms.TextBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlProfessionalInfo = new System.Windows.Forms.Panel();
            this.lblProfInfoTitle = new System.Windows.Forms.Label();
            this.lblLicenseLabel = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.lblExpLabel = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblAffiliationLabel = new System.Windows.Forms.Label();
            this.txtAffiliations = new System.Windows.Forms.TextBox();
            this.pnlContactInfo = new System.Windows.Forms.Panel();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.pnlContent.SuspendLayout();
            this.pnlProfileHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).BeginInit();
            this.pnlProfessionalInfo.SuspendLayout();
            this.pnlContactInfo.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrNavyActive = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrTextMid = System.Drawing.Color.FromArgb(100, 120, 145);
            System.Drawing.Color clrRed = System.Drawing.Color.FromArgb(220, 38, 38);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);

            // Profile Header
            this.pnlProfileHeader.BackColor = clrWhite;
            this.pnlProfileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileHeader.Height = 180;
            this.pnlProfileHeader.Padding = new System.Windows.Forms.Padding(20);

            this.picProfileLarge.BackColor = System.Drawing.Color.FromArgb(230, 235, 240);
            this.picProfileLarge.Location = new System.Drawing.Point(25, 25);
            this.picProfileLarge.Size = new System.Drawing.Size(130, 130);
            this.picProfileLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.lblDoctorName.Text = "Doctor Name";
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.ForeColor = clrNavyActive;
            this.lblDoctorName.Location = new System.Drawing.Point(170, 35);
            this.lblDoctorName.AutoSize = true;

            this.lblSpecialty.Text = "Specialty";
            this.lblSpecialty.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSpecialty.ForeColor = clrTextMid;
            this.lblSpecialty.Location = new System.Drawing.Point(170, 75);
            this.lblSpecialty.AutoSize = true;

            this.lblBioContent.Text = "Bio details...";
            this.lblBioContent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBioContent.ForeColor = clrTextMid;
            this.lblBioContent.Location = new System.Drawing.Point(170, 105);
            this.lblBioContent.Size = new System.Drawing.Size(700, 45);

            this.txtBioEdit.Location = new System.Drawing.Point(170, 105);
            this.txtBioEdit.Size = new System.Drawing.Size(700, 45);
            this.txtBioEdit.Visible = false;
            this.txtBioEdit.Multiline = true;

            this.btnEditProfile.Text = "✏️ Edit Profile";
            this.btnEditProfile.Size = new System.Drawing.Size(140, 40);
            this.btnEditProfile.Location = new System.Drawing.Point(920, 25);
            this.btnEditProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(240, 245, 250);
            this.btnEditProfile.ForeColor = clrTeal;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.FlatAppearance.BorderColor = clrTeal;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);

            this.btnSaveProfile.Text = "💾 Save Profile";
            this.btnSaveProfile.Size = new System.Drawing.Size(140, 40);
            this.btnSaveProfile.Location = new System.Drawing.Point(920, 25);
            this.btnSaveProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveProfile.BackColor = clrTeal;
            this.btnSaveProfile.ForeColor = clrWhite;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Visible = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);

            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.Size = new System.Drawing.Size(140, 40);
            this.btnLogout.Location = new System.Drawing.Point(920, 75);
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnLogout.ForeColor = clrRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderColor = clrRed;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);

            this.pnlProfileHeader.Controls.Add(this.picProfileLarge);
            this.pnlProfileHeader.Controls.Add(this.lblDoctorName);
            this.pnlProfileHeader.Controls.Add(this.lblSpecialty);
            this.pnlProfileHeader.Controls.Add(this.lblBioContent);
            this.pnlProfileHeader.Controls.Add(this.txtBioEdit);
            this.pnlProfileHeader.Controls.Add(this.btnEditProfile);
            this.pnlProfileHeader.Controls.Add(this.btnSaveProfile);
            this.pnlProfileHeader.Controls.Add(this.btnLogout);

            // Professional Info
            this.pnlProfessionalInfo.BackColor = clrWhite;
            this.pnlProfessionalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfessionalInfo.Height = 240;
            this.pnlProfessionalInfo.Padding = new System.Windows.Forms.Padding(25);
            this.pnlProfessionalInfo.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);

            this.lblProfInfoTitle.Text = "Professional Information";
            this.lblProfInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblProfInfoTitle.Location = new System.Drawing.Point(25, 25);
            this.lblProfInfoTitle.AutoSize = true;

            ConfigField(this.pnlProfessionalInfo, this.lblLicenseLabel, this.txtLicense, "LICENSE NUMBER", 25, 80);
            ConfigField(this.pnlProfessionalInfo, this.lblExpLabel, this.txtExperience, "YEARS OF EXPERIENCE", 25, 130);
            ConfigField(this.pnlProfessionalInfo, this.lblAffiliationLabel, this.txtAffiliations, "AFFILIATIONS", 25, 180);

            // Contact Info
            this.pnlContactInfo.BackColor = clrWhite;
            this.pnlContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContactInfo.Height = 240;
            this.pnlContactInfo.Padding = new System.Windows.Forms.Padding(25);
            this.pnlContactInfo.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);

            this.lblContactInfoTitle.Text = "Contact Details";
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblContactInfoTitle.Location = new System.Drawing.Point(25, 25);
            this.lblContactInfoTitle.AutoSize = true;

            ConfigField(this.pnlContactInfo, this.lblEmailLabel, this.txtEmail, "EMAIL ADDRESS", 25, 80);
            ConfigField(this.pnlContactInfo, this.lblPhoneLabel, this.txtPhone, "PHONE NUMBER", 25, 130);
            ConfigField(this.pnlContactInfo, this.lblAddressLabel, this.txtAddress, "CLINIC ADDRESS", 25, 180);

            this.pnlContent.Controls.Add(this.pnlContactInfo);
            this.pnlContent.Controls.Add(this.pnlProfessionalInfo);
            this.pnlContent.Controls.Add(this.pnlProfileHeader);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.pnlProfileHeader.ResumeLayout(false);
            this.pnlProfileHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).EndInit();
            this.pnlProfessionalInfo.ResumeLayout(false);
            this.pnlProfessionalInfo.PerformLayout();
            this.pnlContactInfo.ResumeLayout(false);
            this.pnlContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.DoctorProfileControl_Load);
            this.SizeChanged += new System.EventHandler(this.DoctorProfileControl_SizeChanged);
        }

        private void ConfigField(System.Windows.Forms.Panel p, System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt, string label, int x, int y)
        {
            lbl.Text = label;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            lbl.AutoSize = true;

            txt.Location = new System.Drawing.Point(x, y + 20);
            txt.Size = new System.Drawing.Size(600, 25);
            txt.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txt.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt.ReadOnly = true;

            p.Controls.Add(lbl);
            p.Controls.Add(txt);
        }

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlProfileHeader;
        private System.Windows.Forms.PictureBox picProfileLarge;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblBioContent;
        private System.Windows.Forms.TextBox txtBioEdit;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.Panel pnlProfessionalInfo;
        private System.Windows.Forms.Label lblProfInfoTitle;
        private System.Windows.Forms.Label lblLicenseLabel;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label lblExpLabel;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Label lblAffiliationLabel;
        private System.Windows.Forms.TextBox txtAffiliations;
        private System.Windows.Forms.Panel pnlContactInfo;
        private System.Windows.Forms.Label lblContactInfoTitle;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.TextBox txtAddress;
    }
}
