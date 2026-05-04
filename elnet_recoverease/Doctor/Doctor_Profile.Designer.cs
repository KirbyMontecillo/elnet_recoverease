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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogoArea = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavDivider = new System.Windows.Forms.Panel();
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
            this.lblSidebarFooter = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlProfileHeader = new System.Windows.Forms.Panel();
            this.picProfileLarge = new System.Windows.Forms.PictureBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.pnlInfoContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlProfessionalInfo = new System.Windows.Forms.Panel();
            this.lblProfInfoTitle = new System.Windows.Forms.Label();
            this.lblLicenseLabel = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.lblExpLabel = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.pnlContactInfo = new System.Windows.Forms.Panel();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavAppointments.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.btnNavProfile.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlProfileHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).BeginInit();
            this.pnlInfoContainer.SuspendLayout();
            this.pnlProfessionalInfo.SuspendLayout();
            this.pnlContactInfo.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;

            // Sidebar
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 900);
            this.pnlSidebar.TabIndex = 0;

            // Logo Area
            this.pnlLogoArea.Controls.Add(this.picLogo);
            this.pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoArea.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoArea.Name = "pnlLogoArea";
            this.pnlLogoArea.Padding = new System.Windows.Forms.Padding(16, 18, 8, 8);
            this.pnlLogoArea.Size = new System.Drawing.Size(260, 90);
            this.pnlLogoArea.TabIndex = 0;

            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(16, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(236, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;

            // Nav Items
            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(208, 219, 232);
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Location = new System.Drawing.Point(0, 90);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(260, 1);
            this.pnlNavDivider.TabIndex = 1;

            // Dashboard
            this.btnNavDashboard.Controls.Add(this.lblNavDashIcon);
            this.btnNavDashboard.Controls.Add(this.lblNavDashText);
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 91);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(260, 48);
            this.btnNavDashboard.TabIndex = 2;
            this.lblNavDashIcon.AutoSize = true;
            this.lblNavDashIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavDashIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavDashIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavDashIcon.Text = "\u229E";
            this.lblNavDashText.AutoSize = true;
            this.lblNavDashText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavDashText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavDashText.Location = new System.Drawing.Point(64, 13);
            this.lblNavDashText.Text = "Dashboard";

            // Patients
            this.btnNavPatients.Controls.Add(this.lblNavPatientsIcon);
            this.btnNavPatients.Controls.Add(this.lblNavPatientsText);
            this.btnNavPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPatients.Location = new System.Drawing.Point(0, 139);
            this.btnNavPatients.Name = "btnNavPatients";
            this.btnNavPatients.Size = new System.Drawing.Size(260, 48);
            this.btnNavPatients.TabIndex = 3;
            this.lblNavPatientsIcon.AutoSize = true;
            this.lblNavPatientsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavPatientsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavPatientsIcon.Text = "👥";
            this.lblNavPatientsText.AutoSize = true;
            this.lblNavPatientsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavPatientsText.Location = new System.Drawing.Point(64, 13);
            this.lblNavPatientsText.Text = "My Patients";

            // Appointments
            this.btnNavAppointments.Controls.Add(this.lblNavApptIcon);
            this.btnNavAppointments.Controls.Add(this.lblNavApptText);
            this.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAppointments.Location = new System.Drawing.Point(0, 187);
            this.btnNavAppointments.Name = "btnNavAppointments";
            this.btnNavAppointments.Size = new System.Drawing.Size(260, 48);
            this.btnNavAppointments.TabIndex = 4;
            this.lblNavApptIcon.AutoSize = true;
            this.lblNavApptIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavApptIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavApptIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavApptIcon.Text = "📅";
            this.lblNavApptText.AutoSize = true;
            this.lblNavApptText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavApptText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavApptText.Location = new System.Drawing.Point(64, 13);
            this.lblNavApptText.Text = "Appointments";

            // Reports
            this.btnNavReports.Controls.Add(this.lblNavReportsIcon);
            this.btnNavReports.Controls.Add(this.lblNavReportsText);
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavReports.Location = new System.Drawing.Point(0, 235);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(260, 48);
            this.btnNavReports.TabIndex = 5;
            this.lblNavReportsIcon.AutoSize = true;
            this.lblNavReportsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavReportsIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavReportsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavReportsIcon.Text = "📊";
            this.lblNavReportsText.AutoSize = true;
            this.lblNavReportsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavReportsText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavReportsText.Location = new System.Drawing.Point(64, 13);
            this.lblNavReportsText.Text = "Reports & Analytics";

            // Profile (Active)
            this.btnNavProfile.BackColor = clrNavyActive;
            this.btnNavProfile.Controls.Add(this.lblNavProfileIcon);
            this.btnNavProfile.Controls.Add(this.lblNavProfileText);
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProfile.Location = new System.Drawing.Point(0, 283);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(260, 48);
            this.btnNavProfile.TabIndex = 6;
            this.lblNavProfileIcon.AutoSize = true;
            this.lblNavProfileIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavProfileIcon.ForeColor = clrWhite;
            this.lblNavProfileIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavProfileIcon.Text = "👤";
            this.lblNavProfileText.AutoSize = true;
            this.lblNavProfileText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavProfileText.ForeColor = clrWhite;
            this.lblNavProfileText.Location = new System.Drawing.Point(64, 13);
            this.lblNavProfileText.Text = "My Profile";

            // Sidebar Bottom
            this.pnlSidebarBottom.Controls.Add(this.lblSidebarFooter);
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Location = new System.Drawing.Point(0, 830);
            this.pnlSidebarBottom.Name = "pnlSidebarBottom";
            this.pnlSidebarBottom.Size = new System.Drawing.Size(260, 70);
            this.pnlSidebarBottom.TabIndex = 7;
            this.lblSidebarFooter.AutoSize = true;
            this.lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSidebarFooter.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblSidebarFooter.Location = new System.Drawing.Point(20, 10);
            this.lblSidebarFooter.Text = "Secure Healthcare Platform";
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.btnLogout.Location = new System.Drawing.Point(16, 32);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 26);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "⇠  Sign Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;

            // TopBar
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Controls.Add(this.pnlAvatarTop);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(260, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1340, 80);
            this.pnlTopBar.TabIndex = 1;

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = clrNavyActive;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 22);
            this.lblPageTitle.Text = "My Profile";

            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlAvatarTop.Location = new System.Drawing.Point(1270, 20);
            this.pnlAvatarTop.Name = "pnlAvatarTop";
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.TabIndex = 2;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Location = new System.Drawing.Point(0, 0);
            this.lblAvatarInitials.Name = "lblAvatarInitials";
            this.lblAvatarInitials.Size = new System.Drawing.Size(40, 40);
            this.lblAvatarInitials.TabIndex = 0;
            this.lblAvatarInitials.Text = "Dr";
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Content
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Controls.Add(this.btnChangePassword);
            this.pnlContent.Controls.Add(this.pnlInfoContainer);
            this.pnlContent.Controls.Add(this.pnlProfileHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(1340, 820);
            this.pnlContent.TabIndex = 2;

            // Profile Header
            this.pnlProfileHeader.BackColor = clrWhite;
            this.pnlProfileHeader.Controls.Add(this.btnEditProfile);
            this.pnlProfileHeader.Controls.Add(this.lblSpecialty);
            this.pnlProfileHeader.Controls.Add(this.lblDoctorName);
            this.pnlProfileHeader.Controls.Add(this.picProfileLarge);
            this.pnlProfileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileHeader.Location = new System.Drawing.Point(24, 24);
            this.pnlProfileHeader.Name = "pnlProfileHeader";
            this.pnlProfileHeader.Size = new System.Drawing.Size(1292, 160);
            this.pnlProfileHeader.TabIndex = 0;

            this.picProfileLarge.BackColor = clrBg;
            this.picProfileLarge.Location = new System.Drawing.Point(24, 24);
            this.picProfileLarge.Name = "picProfileLarge";
            this.picProfileLarge.Size = new System.Drawing.Size(112, 112);
            this.picProfileLarge.TabIndex = 0;
            this.picProfileLarge.TabStop = false;

            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.ForeColor = clrNavyActive;
            this.lblDoctorName.Location = new System.Drawing.Point(152, 36);
            this.lblDoctorName.Text = "[Doctor Name]";

            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblSpecialty.Location = new System.Drawing.Point(152, 78);
            this.lblSpecialty.Text = "[Specialty / Department]";

            this.btnEditProfile.BackColor = clrTeal;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditProfile.ForeColor = clrWhite;
            this.btnEditProfile.Location = new System.Drawing.Point(1112, 60);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(156, 40);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // Info Container
            this.pnlInfoContainer.ColumnCount = 2;
            this.pnlInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInfoContainer.Controls.Add(this.pnlProfessionalInfo, 0, 0);
            this.pnlInfoContainer.Controls.Add(this.pnlContactInfo, 1, 0);
            this.pnlInfoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoContainer.Location = new System.Drawing.Point(24, 204);
            this.pnlInfoContainer.Name = "pnlInfoContainer";
            this.pnlInfoContainer.RowCount = 1;
            this.pnlInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInfoContainer.Size = new System.Drawing.Size(1292, 400);
            this.pnlInfoContainer.TabIndex = 1;

            // Professional Info
            this.pnlProfessionalInfo.BackColor = clrWhite;
            this.pnlProfessionalInfo.Controls.Add(this.lblProfInfoTitle);
            this.pnlProfessionalInfo.Controls.Add(this.lblLicenseLabel);
            this.pnlProfessionalInfo.Controls.Add(this.txtLicense);
            this.pnlProfessionalInfo.Controls.Add(this.lblExpLabel);
            this.pnlProfessionalInfo.Controls.Add(this.txtExperience);
            this.pnlProfessionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfessionalInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlProfessionalInfo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlProfessionalInfo.Name = "pnlProfessionalInfo";
            this.pnlProfessionalInfo.Padding = new System.Windows.Forms.Padding(24);
            this.pnlProfessionalInfo.TabIndex = 0;

            this.lblProfInfoTitle.AutoSize = true;
            this.lblProfInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfInfoTitle.ForeColor = clrNavyActive;
            this.lblProfInfoTitle.Location = new System.Drawing.Point(24, 24);
            this.lblProfInfoTitle.Text = "Professional Information";

            this.lblLicenseLabel.AutoSize = true;
            this.lblLicenseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicenseLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblLicenseLabel.Location = new System.Drawing.Point(24, 80);
            this.lblLicenseLabel.Text = "LICENSE NUMBER";

            this.txtLicense.BackColor = clrBg;
            this.txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicense.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLicense.Location = new System.Drawing.Point(24, 105);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.Size = new System.Drawing.Size(580, 36);
            this.txtLicense.TabIndex = 1;

            this.lblExpLabel.AutoSize = true;
            this.lblExpLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblExpLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblExpLabel.Location = new System.Drawing.Point(24, 165);
            this.lblExpLabel.Text = "YEARS OF EXPERIENCE";

            this.txtExperience.BackColor = clrBg;
            this.txtExperience.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExperience.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtExperience.Location = new System.Drawing.Point(24, 190);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.ReadOnly = true;
            this.txtExperience.Size = new System.Drawing.Size(580, 36);
            this.txtExperience.TabIndex = 2;

            // Contact Info
            this.pnlContactInfo.BackColor = clrWhite;
            this.pnlContactInfo.Controls.Add(this.lblContactInfoTitle);
            this.pnlContactInfo.Controls.Add(this.lblEmailLabel);
            this.pnlContactInfo.Controls.Add(this.txtEmail);
            this.pnlContactInfo.Controls.Add(this.lblPhoneLabel);
            this.pnlContactInfo.Controls.Add(this.txtPhone);
            this.pnlContactInfo.Controls.Add(this.lblAddressLabel);
            this.pnlContactInfo.Controls.Add(this.txtAddress);
            this.pnlContactInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContactInfo.Location = new System.Drawing.Point(658, 0);
            this.pnlContactInfo.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlContactInfo.Name = "pnlContactInfo";
            this.pnlContactInfo.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContactInfo.TabIndex = 1;

            this.lblContactInfoTitle.AutoSize = true;
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblContactInfoTitle.ForeColor = clrNavyActive;
            this.lblContactInfoTitle.Location = new System.Drawing.Point(24, 24);
            this.lblContactInfoTitle.Text = "Contact Details";

            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblEmailLabel.Location = new System.Drawing.Point(24, 80);
            this.lblEmailLabel.Text = "EMAIL ADDRESS";

            this.txtEmail.BackColor = clrBg;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(24, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(580, 36);
            this.txtEmail.TabIndex = 3;

            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblPhoneLabel.Location = new System.Drawing.Point(24, 165);
            this.lblPhoneLabel.Text = "PHONE NUMBER";

            this.txtPhone.BackColor = clrBg;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone.Location = new System.Drawing.Point(24, 190);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(580, 36);
            this.txtPhone.TabIndex = 4;

            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddressLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblAddressLabel.Location = new System.Drawing.Point(24, 250);
            this.lblAddressLabel.Text = "CLINIC ADDRESS";

            this.txtAddress.BackColor = clrBg;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.Location = new System.Drawing.Point(24, 275);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(580, 80);
            this.txtAddress.TabIndex = 5;

            // Change Password Button
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = clrNavyActive;
            this.btnChangePassword.Location = new System.Drawing.Point(24, 624);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(180, 36);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Doctor_Profile";
            this.Text = "RecoverEase - My Profile";
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

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogoArea;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlNavDivider;
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
        private System.Windows.Forms.Label lblSidebarFooter;
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
        private System.Windows.Forms.Button btnChangePassword;
    }
}