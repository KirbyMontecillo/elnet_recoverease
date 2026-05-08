namespace elnet_recoverease.Doctor
{
    partial class Doctor_Profile
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
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogoArea = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnNavDashboard = new System.Windows.Forms.Panel();
            this.lblNavDashIcon = new System.Windows.Forms.Label();
            this.lblNavDashText = new System.Windows.Forms.Label();
            this.btnNavPatients = new System.Windows.Forms.Panel();
            this.lblNavPatientsIcon = new System.Windows.Forms.Label();
            this.lblNavPatientsText = new System.Windows.Forms.Label();
            this.btnNavAppointments = new System.Windows.Forms.Panel();
            this.lblNavApptIcon = new System.Windows.Forms.Label();
            this.lblNavApptText = new System.Windows.Forms.Label();
            this.btnNavReports = new System.Windows.Forms.Panel();
            this.lblNavReportsIcon = new System.Windows.Forms.Label();
            this.lblNavReportsText = new System.Windows.Forms.Label();
            this.btnNavProfile = new System.Windows.Forms.Panel();
            this.lblNavProfileIcon = new System.Windows.Forms.Label();
            this.lblNavProfileText = new System.Windows.Forms.Label();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlProfileHeader = new System.Windows.Forms.Panel();
            this.lblBioContent = new System.Windows.Forms.Label();
            this.lblBioTitle = new System.Windows.Forms.Label();
            this.picProfileLarge = new System.Windows.Forms.PictureBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.txtBioEdit = new System.Windows.Forms.TextBox();
            this.pnlInfoContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProfessionalInfo = new System.Windows.Forms.Panel();
            this.lblProfInfoTitle = new System.Windows.Forms.Label();
            this.pnlContactInfo = new System.Windows.Forms.Panel();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.lblLicenseLabel = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.lblExpLabel = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.lblAffiliationLabel = new System.Windows.Forms.Label();
            this.txtAffiliations = new System.Windows.Forms.TextBox();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlProfileHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).BeginInit();
            this.pnlInfoContainer.SuspendLayout();
            this.pnlProfessionalInfo.SuspendLayout();
            this.pnlContactInfo.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavyActive = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrTextDark = System.Drawing.Color.FromArgb(30, 43, 60);
            System.Drawing.Color clrTextMid = System.Drawing.Color.FromArgb(100, 120, 145);

            // Sidebar & Nav (Standard)
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(238, 243, 247);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(260, 900);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);

            // Sidebar bottom
            this.pnlSidebarBottom.BackColor = System.Drawing.Color.FromArgb(238, 243, 247);
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Height = 70;
            this.pnlSidebarBottom.Padding = new System.Windows.Forms.Padding(20, 12, 16, 12);

            var lblSidebarFooter = new System.Windows.Forms.Label();
            lblSidebarFooter.Text = "Secure Healthcare Platform";
            lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8f);
            lblSidebarFooter.ForeColor = clrTextMid;
            lblSidebarFooter.AutoSize = true;
            lblSidebarFooter.Location = new System.Drawing.Point(20, 10);

            this.btnLogout.Text = "⇠  Sign Out";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("#444444");
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#D0DBE8");
            this.btnLogout.Size = new System.Drawing.Size(188, 26);
            this.btnLogout.Location = new System.Drawing.Point(16, 32);
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlSidebarBottom.Controls.Add(lblSidebarFooter);
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);
 
            // Logo
            this.pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoArea.Height = 90;
            this.pnlLogoArea.Padding = new System.Windows.Forms.Padding(16, 18, 8, 8);
            this.pnlLogoArea.Controls.Add(this.picLogo);
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
 
            // Setup Nav Buttons
            SetupNavButton(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "\u229E", "Dashboard", false);
            SetupNavButton(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "👥", "My Patients", false);
            SetupNavButton(this.btnNavAppointments, this.lblNavApptIcon, this.lblNavApptText, "📅", "Appointments", false);
            SetupNavButton(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "Reports", false);
            SetupNavButton(this.btnNavProfile, this.lblNavProfileIcon, this.lblNavProfileText, "👤", "My Profile", true);
 
            this.btnNavProfile.BackColor = System.Drawing.Color.FromArgb(27, 58, 107);
            this.lblNavProfileIcon.ForeColor = System.Drawing.Color.White;
            this.lblNavProfileText.ForeColor = System.Drawing.Color.White;
            var acc_prof = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.btnNavProfile.Controls.Add(acc_prof);

            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Size = new System.Drawing.Size(1340, 80);
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
 
            this.lblPageTitle.Text = "My Profile";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.Location = new System.Drawing.Point(30, 20);
            this.lblPageTitle.AutoSize = true;

            // Content Area - Master Vertical Stack
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30, 10, 30, 50);

            // Add in reverse order of Dock.Top (Last added stays at bottom)
            this.pnlContent.Controls.Add(this.pnlContactInfo);
            this.pnlContent.Controls.Add(this.pnlProfessionalInfo);
            this.pnlContent.Controls.Add(this.pnlProfileHeader);
 
            // 1. Profile Header Card
            this.pnlProfileHeader.BackColor = clrWhite;
            this.pnlProfileHeader.Size = new System.Drawing.Size(1100, 180);
            this.pnlProfileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlProfileHeader.Padding = new System.Windows.Forms.Padding(20);
            this.pnlProfileHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            var lblHeaderTitle = new System.Windows.Forms.Label { Text = "Professional Profile", Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold), ForeColor = clrTextDark, Location = new System.Drawing.Point(20, 10), AutoSize = true };
            this.pnlProfileHeader.Controls.Add(lblHeaderTitle);
            this.pnlProfileHeader.Controls.Add(this.btnUploadPic);
            this.pnlProfileHeader.Controls.Add(this.btnEditProfile);
            this.pnlProfileHeader.Controls.Add(this.btnSaveProfile);
            this.pnlProfileHeader.Controls.Add(this.lblBioContent);
            this.pnlProfileHeader.Controls.Add(this.txtBioEdit);
            this.pnlProfileHeader.Controls.Add(this.lblBioTitle);
            this.pnlProfileHeader.Controls.Add(this.lblSpecialty);
            this.pnlProfileHeader.Controls.Add(this.lblDoctorName);
            this.pnlProfileHeader.Controls.Add(this.picProfileLarge);

            this.picProfileLarge.BackColor = System.Drawing.Color.FromArgb(230, 235, 240);
            this.picProfileLarge.Location = new System.Drawing.Point(25, 20);
            this.picProfileLarge.Size = new System.Drawing.Size(120, 120);
            this.picProfileLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            
            this.btnUploadPic.Text = "📷";
            this.btnUploadPic.Size = new System.Drawing.Size(25, 25);
            this.btnUploadPic.Location = new System.Drawing.Point(115, 110);
            this.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPic.BackColor = clrTeal;
            this.btnUploadPic.ForeColor = System.Drawing.Color.White;
            this.btnUploadPic.Visible = false;
 
            this.lblDoctorName.Text = "Dr. Name";
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI Semibold", 18, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.ForeColor = clrNavyActive;
            this.lblDoctorName.Location = new System.Drawing.Point(160, 45);
            this.lblDoctorName.AutoSize = true;
 
            this.lblSpecialty.Text = "Specialty";
            this.lblSpecialty.Font = new System.Drawing.Font("Segoe UI", 11);
            this.lblSpecialty.ForeColor = clrTextMid;
            this.lblSpecialty.Location = new System.Drawing.Point(160, 80);
            this.lblSpecialty.AutoSize = true;
 
            this.lblBioTitle.Visible = false; // Simplified per screenshot

            this.lblBioContent.Text = "Biography details here...";
            this.lblBioContent.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblBioContent.ForeColor = clrTextMid;
            this.lblBioContent.Location = new System.Drawing.Point(160, 105);
            this.lblBioContent.Size = new System.Drawing.Size(800, 40);
            this.lblBioContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
 
            this.txtBioEdit.Location = new System.Drawing.Point(160, 105);
            this.txtBioEdit.Size = new System.Drawing.Size(800, 40);
            this.txtBioEdit.Visible = false;

            this.btnEditProfile.Text = "✏️ Edit Profile";
            this.btnEditProfile.Size = new System.Drawing.Size(130, 38);
            this.btnEditProfile.Location = new System.Drawing.Point(950, 16);
            this.btnEditProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(240, 245, 250);
            this.btnEditProfile.ForeColor = clrTeal;
            this.btnEditProfile.FlatAppearance.BorderColor = clrTeal;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f);
 
            this.btnSaveProfile.Text = "💾 Save Profile";
            this.btnSaveProfile.Size = new System.Drawing.Size(130, 38);
            this.btnSaveProfile.Location = new System.Drawing.Point(950, 16);
            this.btnSaveProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveProfile.BackColor = clrTeal;
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9f);
            this.btnSaveProfile.Visible = false;

            // 2. Professional Information Card
            this.pnlProfessionalInfo.BackColor = clrWhite;
            this.pnlProfessionalInfo.Size = new System.Drawing.Size(1100, 260);
            this.pnlProfessionalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfessionalInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlProfessionalInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlProfessionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfessionalInfo.Controls.Add(this.lblProfInfoTitle);
            this.pnlProfessionalInfo.Controls.Add(this.lblLicenseLabel);
            this.pnlProfessionalInfo.Controls.Add(this.txtLicense);
            this.pnlProfessionalInfo.Controls.Add(this.lblExpLabel);
            this.pnlProfessionalInfo.Controls.Add(this.txtExperience);
            this.pnlProfessionalInfo.Controls.Add(this.lblAffiliationLabel);
            this.pnlProfessionalInfo.Controls.Add(this.txtAffiliations);
            
            this.lblProfInfoTitle.Text = "Professional Information";
            this.lblProfInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13, System.Drawing.FontStyle.Bold);
            this.lblProfInfoTitle.Location = new System.Drawing.Point(25, 20);
            this.lblProfInfoTitle.AutoSize = true;
 
            this.ConfigField(this.pnlProfessionalInfo, this.lblLicenseLabel, this.txtLicense, "LICENSE NUMBER", 25, 75);
            this.ConfigField(this.pnlProfessionalInfo, this.lblExpLabel, this.txtExperience, "YEARS OF EXPERIENCE", 25, 135);
            this.ConfigField(this.pnlProfessionalInfo, this.lblAffiliationLabel, this.txtAffiliations, "AFFILIATIONS", 25, 195);
 
            // 3. Contact Details Card
            this.pnlContactInfo.BackColor = clrWhite;
            this.pnlContactInfo.Size = new System.Drawing.Size(1100, 260);
            this.pnlContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContactInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.pnlContactInfo.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContactInfo.Controls.Add(this.lblContactInfoTitle);
            this.pnlContactInfo.Visible = true;
            
            this.lblContactInfoTitle.Text = "Contact Details Summary";
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblContactInfoTitle.Location = new System.Drawing.Point(20, 15);
            this.lblContactInfoTitle.AutoSize = true;
 
            this.ConfigField(this.pnlContactInfo, this.lblPhoneLabel, this.txtPhone, "PHONE NUMBER", 65, 75);
            this.ConfigField(this.pnlContactInfo, this.lblEmailLabel, this.txtEmail, "EMAIL ADDRESS", 65, 135);
            this.ConfigField(this.pnlContactInfo, this.lblAddressLabel, this.txtAddress, "CLINIC ADDRESS", 65, 195);
            
            {
                var iconPhoneContact = new System.Windows.Forms.Label { Text = "📞", Location = new System.Drawing.Point(25, 88), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 14), ForeColor = System.Drawing.Color.FromArgb(100, 120, 145) };
                var iconEmailContact = new System.Windows.Forms.Label { Text = "✉️", Location = new System.Drawing.Point(25, 148), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 14), ForeColor = System.Drawing.Color.FromArgb(100, 120, 145) };
                var iconAddrContact = new System.Windows.Forms.Label { Text = "📍", Location = new System.Drawing.Point(25, 208), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 14), ForeColor = System.Drawing.Color.FromArgb(100, 120, 145) };
                this.pnlContactInfo.Controls.AddRange(new System.Windows.Forms.Control[] { iconPhoneContact, iconEmailContact, iconAddrContact });
            }
            this.txtAddress.Multiline = true;
            this.txtAddress.Height = 100;
            
            // Avatar Top
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlAvatarTop.Location = new System.Drawing.Point(1250, 20);
            this.pnlAvatarTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAvatarInitials.Text = "Dr";
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlTopBar.Controls.Add(this.pnlAvatarTop);

            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Doctor_Profile";
            this.Text = "RecoverEase - My Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavDashboard.PerformLayout();
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavPatients.PerformLayout();
            this.btnNavAppointments.ResumeLayout(false);
            this.btnNavAppointments.PerformLayout();
            this.btnNavReports.ResumeLayout(false);
            this.btnNavReports.PerformLayout();
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavProfile.PerformLayout();
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlSidebarBottom.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlProfileHeader.ResumeLayout(false);
            this.pnlProfileHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).EndInit();
            this.pnlInfoContainer.ResumeLayout(false);
            this.pnlProfessionalInfo.ResumeLayout(false);
            this.pnlProfessionalInfo.PerformLayout();
            this.pnlContactInfo.ResumeLayout(false);
            this.pnlContactInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        private void AddLabelAndText(System.Windows.Forms.Panel p, string labelText, out System.Windows.Forms.Label lbl, out System.Windows.Forms.TextBox txt, int x, int y)
        {
            lbl = new System.Windows.Forms.Label { Text = labelText, Location = new System.Drawing.Point(x, y), Font = new System.Drawing.Font("Segoe UI Semibold", 8, System.Drawing.FontStyle.Bold), ForeColor = System.Drawing.Color.Gray, AutoSize = true };
            txt = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(x, y + 22), Size = new System.Drawing.Size(550, 40), Font = new System.Drawing.Font("Segoe UI", 11), BackColor = System.Drawing.Color.FromArgb(242, 247, 250), BorderStyle = System.Windows.Forms.BorderStyle.None, ReadOnly = true };
            p.Controls.Add(lbl);
            p.Controls.Add(txt);
        }

        private void SetupNavButton(System.Windows.Forms.Panel p, System.Windows.Forms.Label icon, System.Windows.Forms.Label text, string iconChar, string label, bool isActive)
        {
            p.Size = new System.Drawing.Size(260, 48);
            p.Dock = System.Windows.Forms.DockStyle.Top;
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Controls.Add(icon);
            p.Controls.Add(text);
            icon.Text = iconChar;
            icon.Location = new System.Drawing.Point(20, 11);
            icon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            icon.AutoSize = true;
            icon.ForeColor = isActive ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(100, 120, 145);
            text.Text = label;
            text.Location = new System.Drawing.Point(64, 13);
            text.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            text.AutoSize = true;
            text.ForeColor = isActive ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(30, 43, 60);
        }

        private void ConfigField(System.Windows.Forms.Panel p, System.Windows.Forms.Label lbl, System.Windows.Forms.TextBox txt, string label, int x, int y)
        {
            lbl.Text = label;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8);
            lbl.ForeColor = System.Drawing.Color.Gray;
            lbl.AutoSize = true;
            txt.Location = new System.Drawing.Point(x, y + 15);
            txt.Width = p.Width - (x * 2) - 20;
            txt.Height = 25;
            txt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt.BackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt.ReadOnly = true;
            txt.Font = new System.Drawing.Font("Segoe UI", 9);
            p.Controls.Add(lbl);
            p.Controls.Add(txt);
        }
 
        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogoArea;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel btnNavDashboard;
        private System.Windows.Forms.Label lblNavDashIcon;
        private System.Windows.Forms.Label lblNavDashText;
        private System.Windows.Forms.Panel btnNavPatients;
        private System.Windows.Forms.Label lblNavPatientsIcon;
        private System.Windows.Forms.Label lblNavPatientsText;
        private System.Windows.Forms.Panel btnNavAppointments;
        private System.Windows.Forms.Label lblNavApptIcon;
        private System.Windows.Forms.Label lblNavApptText;
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
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.TableLayoutPanel pnlInfoContainer;
        private System.Windows.Forms.Panel pnlProfessionalInfo;
        private System.Windows.Forms.Label lblProfInfoTitle;
        private System.Windows.Forms.Label lblLicenseLabel;
        private System.Windows.Forms.TextBox txtLicense;
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
        private System.Windows.Forms.Label lblBioTitle;
        private System.Windows.Forms.Label lblBioContent;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.TextBox txtBioEdit;
        private System.Windows.Forms.Label lblAffiliationLabel;
        private System.Windows.Forms.TextBox txtAffiliations;
    }
}