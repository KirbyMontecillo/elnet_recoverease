namespace elnet_recoverease.Admin.Controls
{
    partial class AdminProfileControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlContactInfo = new System.Windows.Forms.Panel();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlProfessionalInfo = new System.Windows.Forms.Panel();
            this.lblProfInfoTitle = new System.Windows.Forms.Label();
            this.lblExpLabel = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblAffiliationLabel = new System.Windows.Forms.Label();
            this.txtAffiliations = new System.Windows.Forms.TextBox();
            this.pnlProfileHeader = new System.Windows.Forms.Panel();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.lblBioContent = new System.Windows.Forms.Label();
            this.txtBioEdit = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.picProfileLarge = new System.Windows.Forms.PictureBox();
            this.btnLogoutProfile = new System.Windows.Forms.Button();
            
            this.pnlContactInfo.SuspendLayout();
            this.pnlProfessionalInfo.SuspendLayout();
            this.pnlProfileHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).BeginInit();
            this.SuspendLayout();
            
            // pnlContactInfo
            this.pnlContactInfo.BackColor = System.Drawing.Color.White;
            this.pnlContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContactInfo.Controls.Add(this.lblContactInfoTitle);
            this.pnlContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContactInfo.Location = new System.Drawing.Point(30, 380);
            this.pnlContactInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlContactInfo.Name = "pnlContactInfo";
            this.pnlContactInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContactInfo.Size = new System.Drawing.Size(1280, 200);
            
            // lblContactInfoTitle
            this.lblContactInfoTitle.AutoSize = true;
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblContactInfoTitle.Location = new System.Drawing.Point(20, 15);
            this.lblContactInfoTitle.Name = "lblContactInfoTitle";
            this.lblContactInfoTitle.Size = new System.Drawing.Size(187, 32);
            this.lblContactInfoTitle.Text = "Contact Details";
            
            // pnlProfessionalInfo
            this.pnlProfessionalInfo.BackColor = System.Drawing.Color.White;
            this.pnlProfessionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfessionalInfo.Controls.Add(this.lblProfInfoTitle);
            this.pnlProfessionalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfessionalInfo.Location = new System.Drawing.Point(30, 200);
            this.pnlProfessionalInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlProfessionalInfo.Name = "pnlProfessionalInfo";
            this.pnlProfessionalInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlProfessionalInfo.Size = new System.Drawing.Size(1280, 180);
            
            // lblProfInfoTitle
            this.lblProfInfoTitle.AutoSize = true;
            this.lblProfInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfInfoTitle.Location = new System.Drawing.Point(20, 15);
            this.lblProfInfoTitle.Name = "lblProfInfoTitle";
            this.lblProfInfoTitle.Size = new System.Drawing.Size(252, 32);
            this.lblProfInfoTitle.Text = "System Access & Roles";
            
            // pnlProfileHeader
            this.pnlProfileHeader.BackColor = System.Drawing.Color.White;
            this.pnlProfileHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfileHeader.Controls.Add(this.btnUploadPic);
            this.pnlProfileHeader.Controls.Add(this.btnEditProfile);
            this.pnlProfileHeader.Controls.Add(this.btnSaveProfile);
            this.pnlProfileHeader.Controls.Add(this.lblBioContent);
            this.pnlProfileHeader.Controls.Add(this.txtBioEdit);
            this.pnlProfileHeader.Controls.Add(this.lblRole);
            this.pnlProfileHeader.Controls.Add(this.lblAdminName);
            this.pnlProfileHeader.Controls.Add(this.picProfileLarge);
            this.pnlProfileHeader.Controls.Add(this.btnLogoutProfile);
            this.pnlProfileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileHeader.Location = new System.Drawing.Point(30, 20);
            this.pnlProfileHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlProfileHeader.Name = "pnlProfileHeader";
            this.pnlProfileHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlProfileHeader.Size = new System.Drawing.Size(1280, 180);
            
            // btnUploadPic
            this.btnUploadPic.BackColor = System.Drawing.Color.FromArgb(0, 168, 168);
            this.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPic.ForeColor = System.Drawing.Color.White;
            this.btnUploadPic.Location = new System.Drawing.Point(125, 120);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(30, 30);
            this.btnUploadPic.Text = "📷";
            this.btnUploadPic.UseVisualStyleBackColor = false;
            this.btnUploadPic.Visible = false;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            
            // btnEditProfile
            this.btnEditProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(240, 245, 250);
            this.btnEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 168, 168);
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnEditProfile.ForeColor = System.Drawing.Color.FromArgb(0, 168, 168);
            this.btnEditProfile.Location = new System.Drawing.Point(1115, 20);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(140, 45);
            this.btnEditProfile.Text = "✏️ Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            
            // btnSaveProfile
            this.btnSaveProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(0, 168, 168);
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(1115, 20);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(140, 45);
            this.btnSaveProfile.Text = "💾 Save Changes";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Visible = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            
            // lblBioContent
            this.lblBioContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblBioContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBioContent.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblBioContent.Location = new System.Drawing.Point(178, 123);
            this.lblBioContent.Name = "lblBioContent";
            this.lblBioContent.Size = new System.Drawing.Size(900, 45);
            this.lblBioContent.Text = "Administrator bio and responsibilities...";
            
            // txtBioEdit
            this.txtBioEdit.Location = new System.Drawing.Point(178, 115);
            this.txtBioEdit.Name = "txtBioEdit";
            this.txtBioEdit.Size = new System.Drawing.Size(800, 27);
            this.txtBioEdit.Visible = false;
            
            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblRole.Location = new System.Drawing.Point(178, 80);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(200, 28);
            this.lblRole.Text = "System Administrator";
            
            // lblAdminName
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(27, 58, 107);
            this.lblAdminName.Location = new System.Drawing.Point(175, 35);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(223, 46);
            this.lblAdminName.Text = "Admin Name";
            
            // picProfileLarge
            this.picProfileLarge.BackColor = System.Drawing.Color.FromArgb(230, 235, 240);
            this.picProfileLarge.Location = new System.Drawing.Point(25, 20);
            this.picProfileLarge.Name = "picProfileLarge";
            this.picProfileLarge.Size = new System.Drawing.Size(130, 130);
            this.picProfileLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileLarge.TabStop = false;
            
            // btnLogoutProfile
            this.btnLogoutProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogoutProfile.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnLogoutProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnLogoutProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLogoutProfile.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnLogoutProfile.Location = new System.Drawing.Point(955, 20);
            this.btnLogoutProfile.Name = "btnLogoutProfile";
            this.btnLogoutProfile.Size = new System.Drawing.Size(140, 45);
            this.btnLogoutProfile.Text = "⇠ Sign Out";
            this.btnLogoutProfile.UseVisualStyleBackColor = false;
            this.btnLogoutProfile.Click += new System.EventHandler(this.btnLogoutProfile_Click);
            
            // Fields configuration
            ConfigField(this.pnlContactInfo, this.lblEmailLabel, this.txtEmail, "Email Address", 25, 65);
            ConfigField(this.pnlContactInfo, this.lblPhoneLabel, this.txtPhone, "Phone Number", 400, 65);
            ConfigField(this.pnlContactInfo, this.lblAddressLabel, this.txtAddress, "Physical Address", 25, 125);
            ConfigField(this.pnlProfessionalInfo, this.lblExpLabel, this.txtExperience, "Years of Experience", 25, 60);
            ConfigField(this.pnlProfessionalInfo, this.lblAffiliationLabel, this.txtAffiliations, "Professional Affiliations", 400, 60);

            // AdminProfileControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            this.Controls.Add(this.pnlContactInfo);
            this.Controls.Add(this.pnlProfessionalInfo);
            this.Controls.Add(this.pnlProfileHeader);
            this.Name = "AdminProfileControl";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.Size = new System.Drawing.Size(1340, 810);
            this.Load += new System.EventHandler(this.AdminProfileControl_Load);
            
            this.pnlContactInfo.ResumeLayout(false);
            this.pnlContactInfo.PerformLayout();
            this.pnlProfessionalInfo.ResumeLayout(false);
            this.pnlProfessionalInfo.PerformLayout();
            this.pnlProfileHeader.ResumeLayout(false);
            this.pnlProfileHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).EndInit();
            this.ResumeLayout(false);
        }

        private void ConfigField(System.Windows.Forms.Panel p, System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt, string label, int x, int y)
        {
            lbl.Text = label;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8);
            lbl.ForeColor = System.Drawing.Color.Gray;
            lbl.AutoSize = true;
            
            txt.Location = new System.Drawing.Point(x, y + 18);
            txt.Width = 320;
            if (label.Contains("Address")) txt.Width = 700;
            txt.Height = 28;
            txt.BackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt.ReadOnly = true;
            txt.Font = new System.Drawing.Font("Segoe UI", 10);
            
            p.Controls.Add(lbl);
            p.Controls.Add(txt);
        }

        #endregion

        private System.Windows.Forms.Panel pnlProfileHeader;
        private System.Windows.Forms.PictureBox picProfileLarge;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Panel pnlProfessionalInfo;
        private System.Windows.Forms.Label lblProfInfoTitle;
        private System.Windows.Forms.Label lblExpLabel;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.Panel pnlContactInfo;
        private System.Windows.Forms.Label lblContactInfoTitle;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblBioContent;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.TextBox txtBioEdit;
        private System.Windows.Forms.Label lblAffiliationLabel;
        private System.Windows.Forms.TextBox txtAffiliations;
        private System.Windows.Forms.Button btnLogoutProfile;
    }
}
