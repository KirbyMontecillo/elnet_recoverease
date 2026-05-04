namespace elnet_recoverease.Admin
{
    partial class Admin_Patient_Details
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
            this.btnNavStaff = new System.Windows.Forms.Panel();
            this.lblNavStaffIcon = new System.Windows.Forms.Label();
            this.lblNavStaffText = new System.Windows.Forms.Label();
            this.btnNavUsers = new System.Windows.Forms.Panel();
            this.lblNavUsersIcon = new System.Windows.Forms.Label();
            this.lblNavUsersText = new System.Windows.Forms.Label();
            this.btnNavPatients = new System.Windows.Forms.Panel();
            this.lblNavPatientsIcon = new System.Windows.Forms.Label();
            this.lblNavPatientsText = new System.Windows.Forms.Label();
            this.btnNavReports = new System.Windows.Forms.Panel();
            this.lblNavReportsIcon = new System.Windows.Forms.Label();
            this.lblNavReportsText = new System.Windows.Forms.Label();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.lblSidebarFooter = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlProfileHeader = new System.Windows.Forms.Panel();
            this.lblPatientStatus = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.picProfileLarge = new System.Windows.Forms.PictureBox();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.pnlInfoGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.lblPersonalTitle = new System.Windows.Forms.Label();
            this.lblContactLabel = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlClinicalInfo = new System.Windows.Forms.Panel();
            this.lblClinicalTitle = new System.Windows.Forms.Label();
            this.lblDoctorLabel = new System.Windows.Forms.Label();
            this.txtAssignedDoc = new System.Windows.Forms.TextBox();
            this.lblHistoryLabel = new System.Windows.Forms.Label();
            this.txtMedHistory = new System.Windows.Forms.TextBox();
            this.btnArchivePatient = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavStaff.SuspendLayout();
            this.btnNavUsers.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlProfileHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).BeginInit();
            this.pnlInfoGrid.SuspendLayout();
            this.pnlPersonalInfo.SuspendLayout();
            this.pnlClinicalInfo.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;

            // Sidebar
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.Controls.Add(this.btnNavStaff);
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

            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(208, 219, 232);
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Location = new System.Drawing.Point(0, 90);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(260, 1);
            this.pnlNavDivider.TabIndex = 1;

            // Nav Build Helper
            void SetupNavItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, string icoChar, string label, bool isActive)
            {
                pnl.Cursor = System.Windows.Forms.Cursors.Hand;
                pnl.Dock = System.Windows.Forms.DockStyle.Top;
                pnl.Size = new System.Drawing.Size(260, 48);
                if (isActive) pnl.BackColor = clrNavyActive;
                ico.AutoSize = true;
                ico.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
                ico.ForeColor = isActive ? clrWhite : System.Drawing.Color.FromArgb(45, 55, 72);
                ico.Location = new System.Drawing.Point(20, 11);
                ico.Text = icoChar;
                txt.AutoSize = true;
                txt.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
                txt.ForeColor = isActive ? clrWhite : System.Drawing.Color.FromArgb(45, 55, 72);
                txt.Location = new System.Drawing.Point(64, 13);
                txt.Text = label;
                pnl.Controls.Add(ico);
                pnl.Controls.Add(txt);
            }

            SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "\u229E", "Admin Dashboard", false);
            SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", false);
            SetupNavItem(this.btnNavUsers, this.lblNavUsersIcon, this.lblNavUsersText, "🔑", "User Accounts", false);
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "👥", "Global Patient List", true);
            SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", false);

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
            this.lblSidebarFooter.Text = "RecoverEase Admin Portal";
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
            this.lblPageTitle.Text = "Patient Master Profile";

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
            this.lblAvatarInitials.Text = "AD";
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Content
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Controls.Add(this.btnArchivePatient);
            this.pnlContent.Controls.Add(this.pnlInfoGrid);
            this.pnlContent.Controls.Add(this.pnlProfileHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(1340, 820);
            this.pnlContent.TabIndex = 2;

            // Profile Header
            this.pnlProfileHeader.BackColor = clrWhite;
            this.pnlProfileHeader.Controls.Add(this.btnEditPatient);
            this.pnlProfileHeader.Controls.Add(this.lblPatientStatus);
            this.pnlProfileHeader.Controls.Add(this.lblPatientName);
            this.pnlProfileHeader.Controls.Add(this.lblPatientID);
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

            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.ForeColor = clrNavyActive;
            this.lblPatientName.Location = new System.Drawing.Point(152, 36);
            this.lblPatientName.Text = "[Patient Full Name]";

            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPatientID.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblPatientID.Location = new System.Drawing.Point(152, 78);
            this.lblPatientID.Text = "PATIENT ID: #00000";

            this.lblPatientStatus.AutoSize = true;
            this.lblPatientStatus.BackColor = System.Drawing.Color.FromArgb(230, 246, 246);
            this.lblPatientStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPatientStatus.ForeColor = clrTeal;
            this.lblPatientStatus.Location = new System.Drawing.Point(152, 110);
            this.lblPatientStatus.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblPatientStatus.Text = "ACTIVE";

            this.btnEditPatient.BackColor = clrTeal;
            this.btnEditPatient.FlatAppearance.BorderSize = 0;
            this.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditPatient.ForeColor = clrWhite;
            this.btnEditPatient.Location = new System.Drawing.Point(1112, 60);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(156, 40);
            this.btnEditPatient.TabIndex = 3;
            this.btnEditPatient.Text = "Edit Profile";
            this.btnEditPatient.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // Info Grid
            this.pnlInfoGrid.ColumnCount = 2;
            this.pnlInfoGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInfoGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlInfoGrid.Controls.Add(this.pnlPersonalInfo, 0, 0);
            this.pnlInfoGrid.Controls.Add(this.pnlClinicalInfo, 1, 0);
            this.pnlInfoGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoGrid.Location = new System.Drawing.Point(24, 204);
            this.pnlInfoGrid.Name = "pnlInfoGrid";
            this.pnlInfoGrid.RowCount = 1;
            this.pnlInfoGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlInfoGrid.Size = new System.Drawing.Size(1292, 450);
            this.pnlInfoGrid.TabIndex = 1;

            // Personal Info Panel
            this.pnlPersonalInfo.BackColor = clrWhite;
            this.pnlPersonalInfo.Controls.Add(this.lblPersonalTitle);
            this.pnlPersonalInfo.Controls.Add(this.lblContactLabel);
            this.pnlPersonalInfo.Controls.Add(this.txtContact);
            this.pnlPersonalInfo.Controls.Add(this.lblAddressLabel);
            this.pnlPersonalInfo.Controls.Add(this.txtAddress);
            this.pnlPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPersonalInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonalInfo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Padding = new System.Windows.Forms.Padding(24);
            this.pnlPersonalInfo.TabIndex = 0;

            this.lblPersonalTitle.AutoSize = true;
            this.lblPersonalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPersonalTitle.ForeColor = clrNavyActive;
            this.lblPersonalTitle.Location = new System.Drawing.Point(24, 24);
            this.lblPersonalTitle.Text = "Personal Information";

            this.lblContactLabel.AutoSize = true;
            this.lblContactLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblContactLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblContactLabel.Location = new System.Drawing.Point(24, 80);
            this.lblContactLabel.Text = "CONTACT NUMBER";

            this.txtContact.BackColor = clrBg;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContact.Location = new System.Drawing.Point(24, 105);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(580, 36);

            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddressLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblAddressLabel.Location = new System.Drawing.Point(24, 165);
            this.lblAddressLabel.Text = "RESIDENTIAL ADDRESS";

            this.txtAddress.BackColor = clrBg;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.Location = new System.Drawing.Point(24, 190);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(580, 100);

            // Clinical Info Panel
            this.pnlClinicalInfo.BackColor = clrWhite;
            this.pnlClinicalInfo.Controls.Add(this.lblClinicalTitle);
            this.pnlClinicalInfo.Controls.Add(this.lblDoctorLabel);
            this.pnlClinicalInfo.Controls.Add(this.txtAssignedDoc);
            this.pnlClinicalInfo.Controls.Add(this.lblHistoryLabel);
            this.pnlClinicalInfo.Controls.Add(this.txtMedHistory);
            this.pnlClinicalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClinicalInfo.Location = new System.Drawing.Point(658, 0);
            this.pnlClinicalInfo.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlClinicalInfo.Name = "pnlClinicalInfo";
            this.pnlClinicalInfo.Padding = new System.Windows.Forms.Padding(24);
            this.pnlClinicalInfo.TabIndex = 1;

            this.lblClinicalTitle.AutoSize = true;
            this.lblClinicalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblClinicalTitle.ForeColor = clrNavyActive;
            this.lblClinicalTitle.Location = new System.Drawing.Point(24, 24);
            this.lblClinicalTitle.Text = "Clinical Overview";

            this.lblDoctorLabel.AutoSize = true;
            this.lblDoctorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoctorLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblDoctorLabel.Location = new System.Drawing.Point(24, 80);
            this.lblDoctorLabel.Text = "PRIMARY ASSIGNED DOCTOR";

            this.txtAssignedDoc.BackColor = clrBg;
            this.txtAssignedDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAssignedDoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAssignedDoc.Location = new System.Drawing.Point(24, 105);
            this.txtAssignedDoc.Name = "txtAssignedDoc";
            this.txtAssignedDoc.ReadOnly = true;
            this.txtAssignedDoc.Size = new System.Drawing.Size(580, 36);

            this.lblHistoryLabel.AutoSize = true;
            this.lblHistoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblHistoryLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblHistoryLabel.Location = new System.Drawing.Point(24, 165);
            this.lblHistoryLabel.Text = "PRIMARY DIAGNOSIS / HISTORY";

            this.txtMedHistory.BackColor = clrBg;
            this.txtMedHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedHistory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMedHistory.Location = new System.Drawing.Point(24, 190);
            this.txtMedHistory.Multiline = true;
            this.txtMedHistory.Name = "txtMedHistory";
            this.txtMedHistory.ReadOnly = true;
            this.txtMedHistory.Size = new System.Drawing.Size(580, 100);

            // Archive Button
            this.btnArchivePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivePatient.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnArchivePatient.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnArchivePatient.Location = new System.Drawing.Point(24, 674);
            this.btnArchivePatient.Name = "btnArchivePatient";
            this.btnArchivePatient.Size = new System.Drawing.Size(180, 36);
            this.btnArchivePatient.TabIndex = 2;
            this.btnArchivePatient.Text = "Archive Patient";
            this.btnArchivePatient.UseVisualStyleBackColor = true;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Admin_Patient_Details";
            this.Text = "RecoverEase - Patient Master Profile";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavDashboard.PerformLayout();
            this.btnNavStaff.ResumeLayout(false);
            this.btnNavStaff.PerformLayout();
            this.btnNavUsers.ResumeLayout(false);
            this.btnNavUsers.PerformLayout();
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavPatients.PerformLayout();
            this.btnNavReports.ResumeLayout(false);
            this.btnNavReports.PerformLayout();
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlSidebarBottom.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlProfileHeader.ResumeLayout(false);
            this.pnlProfileHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileLarge)).EndInit();
            this.pnlInfoGrid.ResumeLayout(false);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlPersonalInfo.PerformLayout();
            this.pnlClinicalInfo.ResumeLayout(false);
            this.pnlClinicalInfo.PerformLayout();
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
        private System.Windows.Forms.Panel btnNavStaff;
        private System.Windows.Forms.Label lblNavStaffIcon;
        private System.Windows.Forms.Label lblNavStaffText;
        private System.Windows.Forms.Panel btnNavUsers;
        private System.Windows.Forms.Label lblNavUsersIcon;
        private System.Windows.Forms.Label lblNavUsersText;
        private System.Windows.Forms.Panel btnNavPatients;
        private System.Windows.Forms.Label lblNavPatientsIcon;
        private System.Windows.Forms.Label lblNavPatientsText;
        private System.Windows.Forms.Panel btnNavReports;
        private System.Windows.Forms.Label lblNavReportsIcon;
        private System.Windows.Forms.Label lblNavReportsText;
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
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientStatus;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.TableLayoutPanel pnlInfoGrid;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Label lblPersonalTitle;
        private System.Windows.Forms.Label lblContactLabel;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlClinicalInfo;
        private System.Windows.Forms.Label lblClinicalTitle;
        private System.Windows.Forms.Label lblDoctorLabel;
        private System.Windows.Forms.TextBox txtAssignedDoc;
        private System.Windows.Forms.Label lblHistoryLabel;
        private System.Windows.Forms.TextBox txtMedHistory;
        private System.Windows.Forms.Button btnArchivePatient;
    }
}