namespace elnet_recoverease.Admin
{
    partial class Admin_Profile
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlAvatarTop = new Panel();
            lblAvatarInitials = new Label();
            pnlSidebar = new Panel();
            pnlSidebarBottom = new Panel();
            lblSidebarFooter = new Label();
            btnLogout = new Button();
            btnNavProfile = new Panel();
            btnNavReports = new Panel();
            btnNavPatients = new Panel();
            btnNavStaff = new Panel();
            btnNavDashboard = new Panel();
            pnlNavDivider = new Panel();
            pnlLogoArea = new Panel();
            picLogo = new PictureBox();
            lblNavDashIcon = new Label();
            lblNavDashText = new Label();
            lblNavStaffIcon = new Label();
            lblNavStaffText = new Label();
            lblNavPatientsIcon = new Label();
            lblNavPatientsText = new Label();
            lblNavReportsIcon = new Label();
            lblNavReportsText = new Label();
            lblNavProfileIcon = new Label();
            lblNavProfileText = new Label();
            pnlTopBar = new Panel();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            pnlContactInfo = new Panel();
            lblContactInfoTitle = new Label();
            lblEmailLabel = new Label();
            txtEmail = new TextBox();
            lblPhoneLabel = new Label();
            txtPhone = new TextBox();
            lblAddressLabel = new Label();
            txtAddress = new TextBox();
            pnlProfessionalInfo = new Panel();
            lblProfInfoTitle = new Label();
            lblExpLabel = new Label();
            txtExperience = new TextBox();
            lblAffiliationLabel = new Label();
            txtAffiliations = new TextBox();
            pnlProfileHeader = new Panel();
            btnUploadPic = new Button();
            btnEditProfile = new Button();
            btnSaveProfile = new Button();
            lblBioContent = new Label();
            txtBioEdit = new TextBox();
            lblRole = new Label();
            lblAdminName = new Label();
            picProfileLarge = new PictureBox();
            lblHeaderTitle = new Label();
            lblBioTitle = new Label();
            pnlAvatarTop.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlSidebarBottom.SuspendLayout();
            pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTopBar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlContactInfo.SuspendLayout();
            pnlProfessionalInfo.SuspendLayout();
            pnlProfileHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfileLarge).BeginInit();
            SuspendLayout();
            // 
            // pnlAvatarTop
            // 
            pnlAvatarTop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAvatarTop.BackColor = Color.FromArgb(0, 168, 168);
            pnlAvatarTop.Controls.Add(lblAvatarInitials);
            pnlAvatarTop.Cursor = Cursors.Hand;
            pnlAvatarTop.Location = new Point(1280, 20);
            pnlAvatarTop.Name = "pnlAvatarTop";
            pnlAvatarTop.Size = new Size(40, 40);
            pnlAvatarTop.TabIndex = 1;
            // 
            // lblAvatarInitials
            // 
            lblAvatarInitials.Dock = DockStyle.Fill;
            lblAvatarInitials.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAvatarInitials.ForeColor = Color.White;
            lblAvatarInitials.Location = new Point(0, 0);
            lblAvatarInitials.Name = "lblAvatarInitials";
            lblAvatarInitials.Size = new Size(40, 40);
            lblAvatarInitials.TabIndex = 0;
            lblAvatarInitials.Text = "AD";
            lblAvatarInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(238, 243, 247);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(btnNavProfile);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnNavPatients);
            pnlSidebar.Controls.Add(btnNavStaff);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(pnlNavDivider);
            pnlSidebar.Controls.Add(pnlLogoArea);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 900);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlSidebarBottom
            // 
            pnlSidebarBottom.Controls.Add(lblSidebarFooter);
            pnlSidebarBottom.Controls.Add(btnLogout);
            pnlSidebarBottom.Dock = DockStyle.Bottom;
            pnlSidebarBottom.Location = new Point(0, 810);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Size = new Size(260, 90);
            pnlSidebarBottom.TabIndex = 7;
            // 
            // lblSidebarFooter
            // 
            lblSidebarFooter.Dock = DockStyle.Bottom;
            lblSidebarFooter.Font = new Font("Segoe UI", 8F);
            lblSidebarFooter.ForeColor = Color.FromArgb(160, 174, 192);
            lblSidebarFooter.Location = new Point(0, 60);
            lblSidebarFooter.Name = "lblSidebarFooter";
            lblSidebarFooter.Size = new Size(260, 30);
            lblSidebarFooter.TabIndex = 0;
            lblSidebarFooter.Text = "RecoverEase Admin Portal";
            lblSidebarFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(68, 68, 68);
            btnLogout.Location = new Point(20, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 40);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "⇠   Sign Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Navigation Items
            SetupNavItem(btnNavProfile, lblNavProfileIcon, lblNavProfileText, "👤", "My Profile", true, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavReports, lblNavReportsIcon, lblNavReportsText, "📊", "System Reports", false, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavPatients, lblNavPatientsIcon, lblNavPatientsText, "💊", "Medication List", false, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavStaff, lblNavStaffIcon, lblNavStaffText, "🩺", "Staff Management", false, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavDashboard, lblNavDashIcon, lblNavDashText, "⊞", "Admin Dashboard", false, Color.FromArgb(27, 58, 107), Color.White);
            // 
            // pnlNavDivider
            // 
            pnlNavDivider.BackColor = Color.FromArgb(226, 232, 240);
            pnlNavDivider.Dock = DockStyle.Top;
            pnlNavDivider.Location = new Point(0, 120);
            pnlNavDivider.Name = "pnlNavDivider";
            pnlNavDivider.Size = new Size(260, 1);
            pnlNavDivider.TabIndex = 1;
            // 
            // pnlLogoArea
            // 
            pnlLogoArea.BackColor = Color.FromArgb(238, 243, 247);
            pnlLogoArea.Controls.Add(picLogo);
            pnlLogoArea.Dock = DockStyle.Top;
            pnlLogoArea.Location = new Point(0, 0);
            pnlLogoArea.Name = "pnlLogoArea";
            pnlLogoArea.Padding = new Padding(35, 25, 35, 15);
            pnlLogoArea.Size = new Size(260, 120);
            pnlLogoArea.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Location = new Point(35, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(190, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Controls.Add(pnlAvatarTop);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(260, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1340, 80);
            pnlTopBar.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.Location = new Point(30, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(165, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "My Profile";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlContactInfo);
            pnlContent.Controls.Add(pnlProfessionalInfo);
            pnlContent.Controls.Add(pnlProfileHeader);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(260, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(30, 20, 30, 20);
            pnlContent.Size = new Size(1340, 820);
            pnlContent.TabIndex = 0;
            // 
            // pnlContactInfo
            // 
            pnlContactInfo.BackColor = Color.White;
            pnlContactInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlContactInfo.Controls.Add(lblContactInfoTitle);
            pnlContactInfo.Dock = DockStyle.Top;
            pnlContactInfo.Location = new Point(30, 380);
            pnlContactInfo.Margin = new Padding(0, 0, 0, 20);
            pnlContactInfo.Name = "pnlContactInfo";
            pnlContactInfo.Padding = new Padding(20);
            pnlContactInfo.Size = new Size(1280, 200);
            pnlContactInfo.TabIndex = 0;
            // 
            // lblContactInfoTitle
            // 
            lblContactInfoTitle.AutoSize = true;
            lblContactInfoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblContactInfoTitle.Location = new Point(20, 15);
            lblContactInfoTitle.Name = "lblContactInfoTitle";
            lblContactInfoTitle.Size = new Size(187, 32);
            lblContactInfoTitle.TabIndex = 0;
            lblContactInfoTitle.Text = "Contact Details";
            // 
            // pnlProfessionalInfo
            // 
            pnlProfessionalInfo.BackColor = Color.White;
            pnlProfessionalInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlProfessionalInfo.Controls.Add(lblProfInfoTitle);
            pnlProfessionalInfo.Dock = DockStyle.Top;
            pnlProfessionalInfo.Location = new Point(30, 200);
            pnlProfessionalInfo.Margin = new Padding(0, 0, 0, 20);
            pnlProfessionalInfo.Name = "pnlProfessionalInfo";
            pnlProfessionalInfo.Padding = new Padding(20);
            pnlProfessionalInfo.Size = new Size(1280, 180);
            pnlProfessionalInfo.TabIndex = 1;
            // 
            // lblProfInfoTitle
            // 
            lblProfInfoTitle.AutoSize = true;
            lblProfInfoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProfInfoTitle.Location = new Point(20, 15);
            lblProfInfoTitle.Name = "lblProfInfoTitle";
            lblProfInfoTitle.Size = new Size(252, 32);
            lblProfInfoTitle.TabIndex = 0;
            lblProfInfoTitle.Text = "System Access & Roles";
            // 
            // pnlProfileHeader
            // 
            pnlProfileHeader.BackColor = Color.White;
            pnlProfileHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlProfileHeader.Controls.Add(btnUploadPic);
            pnlProfileHeader.Controls.Add(btnEditProfile);
            pnlProfileHeader.Controls.Add(btnSaveProfile);
            pnlProfileHeader.Controls.Add(lblBioContent);
            pnlProfileHeader.Controls.Add(txtBioEdit);
            pnlProfileHeader.Controls.Add(lblRole);
            pnlProfileHeader.Controls.Add(lblAdminName);
            pnlProfileHeader.Controls.Add(picProfileLarge);
            pnlProfileHeader.Dock = DockStyle.Top;
            pnlProfileHeader.Location = new Point(30, 20);
            pnlProfileHeader.Margin = new Padding(0, 0, 0, 10);
            pnlProfileHeader.Name = "pnlProfileHeader";
            pnlProfileHeader.Padding = new Padding(20);
            pnlProfileHeader.Size = new Size(1280, 180);
            pnlProfileHeader.TabIndex = 2;
            // 
            // btnUploadPic
            // 
            btnUploadPic.BackColor = Color.FromArgb(0, 168, 168);
            btnUploadPic.FlatStyle = FlatStyle.Flat;
            btnUploadPic.ForeColor = Color.White;
            btnUploadPic.Location = new Point(125, 120);
            btnUploadPic.Name = "btnUploadPic";
            btnUploadPic.Size = new Size(30, 30);
            btnUploadPic.TabIndex = 1;
            btnUploadPic.Text = "📷";
            btnUploadPic.UseVisualStyleBackColor = false;
            btnUploadPic.Visible = false;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditProfile.BackColor = Color.FromArgb(240, 245, 250);
            btnEditProfile.FlatAppearance.BorderColor = Color.FromArgb(0, 168, 168);
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI Semibold", 10F);
            btnEditProfile.ForeColor = Color.FromArgb(0, 168, 168);
            btnEditProfile.Location = new Point(1115, 20);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(140, 45);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "✏️ Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveProfile.BackColor = Color.FromArgb(0, 168, 168);
            btnSaveProfile.FlatStyle = FlatStyle.Flat;
            btnSaveProfile.Font = new Font("Segoe UI Semibold", 10F);
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.Location = new Point(1115, 20);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(140, 45);
            btnSaveProfile.TabIndex = 3;
            btnSaveProfile.Text = "💾 Save Changes";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Visible = false;
            // 
            // lblBioContent
            // 
            lblBioContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBioContent.Font = new Font("Segoe UI", 10F);
            lblBioContent.ForeColor = Color.FromArgb(100, 120, 145);
            lblBioContent.Location = new Point(178, 123);
            lblBioContent.Name = "lblBioContent";
            lblBioContent.Size = new Size(900, 45);
            lblBioContent.TabIndex = 4;
            lblBioContent.Text = "Administrator bio and responsibilities...";
            // 
            // txtBioEdit
            // 
            txtBioEdit.Location = new Point(178, 115);
            txtBioEdit.Name = "txtBioEdit";
            txtBioEdit.Size = new Size(800, 27);
            txtBioEdit.TabIndex = 5;
            txtBioEdit.Visible = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F);
            lblRole.ForeColor = Color.FromArgb(100, 120, 145);
            lblRole.Location = new Point(178, 80);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(200, 28);
            lblRole.TabIndex = 7;
            lblRole.Text = "System Administrator";
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.FromArgb(27, 58, 107);
            lblAdminName.Location = new Point(175, 35);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(223, 46);
            lblAdminName.TabIndex = 8;
            lblAdminName.Text = "Admin Name";
            // 
            // picProfileLarge
            // 
            picProfileLarge.BackColor = Color.FromArgb(230, 235, 240);
            picProfileLarge.Location = new Point(25, 20);
            picProfileLarge.Name = "picProfileLarge";
            picProfileLarge.Size = new Size(130, 130);
            picProfileLarge.SizeMode = PictureBoxSizeMode.Zoom;
            picProfileLarge.TabIndex = 9;
            picProfileLarge.TabStop = false;
            // 
            // Fields configuration
            ConfigField(pnlContactInfo, lblEmailLabel, txtEmail, "Email Address", 25, 65);
            ConfigField(pnlContactInfo, lblPhoneLabel, txtPhone, "Phone Number", 400, 65);
            ConfigField(pnlContactInfo, lblAddressLabel, txtAddress, "Physical Address", 25, 125);
            ConfigField(pnlProfessionalInfo, lblExpLabel, txtExperience, "Years of Experience", 25, 60);
            ConfigField(pnlProfessionalInfo, lblAffiliationLabel, txtAffiliations, "Professional Affiliations", 400, 60);

            // Admin_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            Name = "Admin_Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecoverEase - Admin Profile";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebarBottom.ResumeLayout(false);
            pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContactInfo.ResumeLayout(false);
            pnlContactInfo.PerformLayout();
            pnlProfessionalInfo.ResumeLayout(false);
            pnlProfessionalInfo.PerformLayout();
            pnlProfileHeader.ResumeLayout(false);
            pnlProfileHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfileLarge).EndInit();
            ResumeLayout(false);
        }

        private void SetupNavItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, string icoChar, string label, bool isActive, System.Drawing.Color activeColor, System.Drawing.Color whiteColor)
        {
            pnl.SuspendLayout();
            pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            pnl.Dock = System.Windows.Forms.DockStyle.Top;
            pnl.Height = 56;
            pnl.BackColor = isActive ? activeColor : System.Drawing.Color.Transparent;

            ico.AutoSize = false;
            ico.Size = new System.Drawing.Size(56, 56);
            ico.Location = new System.Drawing.Point(0, 0);
            ico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            ico.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            ico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ico.Text = icoChar;

            txt.AutoSize = false;
            txt.Size = new System.Drawing.Size(190, 56);
            txt.Location = new System.Drawing.Point(56, 0);
            txt.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            txt.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            txt.Text = label;

            pnl.Controls.Clear();
            pnl.Controls.Add(ico);
            pnl.Controls.Add(txt);
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
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

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogoArea;
        private System.Windows.Forms.Panel pnlNavDivider;
        private System.Windows.Forms.Panel btnNavDashboard;
        private System.Windows.Forms.Label lblNavDashIcon;
        private System.Windows.Forms.Label lblNavDashText;
        private System.Windows.Forms.Panel btnNavStaff;
        private System.Windows.Forms.Label lblNavStaffIcon;
        private System.Windows.Forms.Label lblNavStaffText;
        private System.Windows.Forms.Panel btnNavPatients;
        private System.Windows.Forms.Label lblNavPatientsIcon;
        private System.Windows.Forms.Label lblNavPatientsText;
        private System.Windows.Forms.Panel btnNavReports;
        private System.Windows.Forms.Label lblNavReportsIcon;
        private System.Windows.Forms.Label lblNavReportsText;
        private System.Windows.Forms.Panel btnNavProfile;
        private System.Windows.Forms.Label lblNavProfileIcon;
        private System.Windows.Forms.Label lblNavProfileText;
        private System.Windows.Forms.Panel pnlSidebarBottom;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Panel pnlContent;
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
        private System.Windows.Forms.Label lblBioTitle;
        private System.Windows.Forms.Label lblSidebarFooter;
        private System.Windows.Forms.Label lblHeaderTitle;
        private PictureBox picLogo;
    }
}
