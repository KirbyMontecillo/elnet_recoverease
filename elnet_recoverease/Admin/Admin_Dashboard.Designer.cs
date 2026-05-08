namespace elnet_recoverease.Admin
{
    partial class Admin_Dashboard
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
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.pnlTopIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.lblNotifIcon = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.flpStats = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatPatients = new System.Windows.Forms.Panel();
            this.lblStatPatientsVal = new System.Windows.Forms.Label();
            this.lblStatPatientsTitle = new System.Windows.Forms.Label();
            this.lblStatPatientsTrend = new System.Windows.Forms.Label();
            this.pnlStatDoctors = new System.Windows.Forms.Panel();
            this.lblStatDoctorsVal = new System.Windows.Forms.Label();
            this.lblStatDoctorsTitle = new System.Windows.Forms.Label();
            this.lblStatDoctorsTrend = new System.Windows.Forms.Label();
            this.pnlStatAppointments = new System.Windows.Forms.Panel();
            this.lblStatAppointmentsVal = new System.Windows.Forms.Label();
            this.lblStatAppointmentsTitle = new System.Windows.Forms.Label();
            this.lblStatAppointmentsSub = new System.Windows.Forms.Label();
            this.pnlStatMissedMeds = new System.Windows.Forms.Panel();
            this.lblStatMissedMedsVal = new System.Windows.Forms.Label();
            this.lblStatMissedMedsTitle = new System.Windows.Forms.Label();
            this.lblStatMissedMedsSub = new System.Windows.Forms.Label();
            this.pnlCriticalAlert = new System.Windows.Forms.Panel();
            this.lblAlertText = new System.Windows.Forms.Label();
            this.lblAlertIcon = new System.Windows.Forms.Label();
            this.btnViewAllAlerts = new System.Windows.Forms.Label();
            this.tlpMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAdherenceCard = new System.Windows.Forms.Panel();
            this.lblAdherenceTitle = new System.Windows.Forms.Label();
            this.lblAdherenceDetails = new System.Windows.Forms.Label();
            this.flpAdherence = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlActivityCard = new System.Windows.Forms.Panel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.lblActivityViewLog = new System.Windows.Forms.Label();
            this.flpActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRecentPatientsCard = new System.Windows.Forms.Panel();
            this.lblRecentPatientsTitle = new System.Windows.Forms.Label();
            this.lblViewAllPatients = new System.Windows.Forms.Label();
            this.dgvRecentPatients = new System.Windows.Forms.DataGridView();

            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavStaff.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlTopIcons.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.flpStats.SuspendLayout();
            this.pnlStatPatients.SuspendLayout();
            this.pnlStatDoctors.SuspendLayout();
            this.pnlStatAppointments.SuspendLayout();
            this.pnlStatMissedMeds.SuspendLayout();
            this.pnlCriticalAlert.SuspendLayout();
            this.tlpMainGrid.SuspendLayout();
            this.pnlAdherenceCard.SuspendLayout();
            this.pnlActivityCard.SuspendLayout();
            this.pnlRecentPatientsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPatients)).BeginInit();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrBorder = System.Drawing.Color.FromArgb(226, 232, 240);

            // Sidebar
            this.pnlSidebar.BackColor = clrNavy;
            this.btnNavProfile = new System.Windows.Forms.Panel();
            this.lblNavProfileIcon = new System.Windows.Forms.Label();
            this.lblNavProfileText = new System.Windows.Forms.Label();
            // Sidebar Setup
            this.pnlSidebar.BackColor = Color.FromArgb(238, 243, 247);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavStaff);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 900);
            this.pnlSidebar.TabIndex = 0;

            // Logo Area
            this.pnlLogoArea.BackColor = Color.FromArgb(238, 243, 247);
            this.pnlLogoArea.Controls.Add(this.picLogo);
            this.pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoArea.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoArea.Name = "pnlLogoArea";
            this.pnlLogoArea.Padding = new System.Windows.Forms.Padding(35, 25, 35, 15);
            this.pnlLogoArea.Size = new System.Drawing.Size(260, 120);
            this.pnlLogoArea.TabIndex = 0;

            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Location = new System.Drawing.Point(35, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(190, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;

            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Location = new System.Drawing.Point(0, 120);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(260, 1);
            this.pnlNavDivider.TabIndex = 1;

            // Navigation Items
            SetupNavItem(this.btnNavProfile, this.lblNavProfileIcon, this.lblNavProfileText, "👤", "My Profile", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "💊", "Medication List", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "⊞", "Admin Dashboard", true, clrNavyActive, clrWhite);

            // Sidebar Bottom
            this.pnlSidebarBottom.Controls.Add(this.lblSidebarFooter);
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Location = new System.Drawing.Point(0, 840);
            this.pnlSidebarBottom.Name = "pnlSidebarBottom";
            this.pnlSidebarBottom.Size = new System.Drawing.Size(260, 60);
            this.pnlSidebarBottom.TabIndex = 7;

            this.lblSidebarFooter.AutoSize = false;
            this.lblSidebarFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSidebarFooter.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            this.lblSidebarFooter.Location = new System.Drawing.Point(0, 0);
            this.lblSidebarFooter.TextAlign = ContentAlignment.MiddleCenter;
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
            this.btnLogout.Visible = false;

            // TopBar
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Controls.Add(this.pnlTopIcons);
            this.pnlTopBar.Controls.Add(this.lblCurrentDate);
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(260, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1340, 90);
            this.pnlTopBar.TabIndex = 1;

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblPageTitle.Location = new System.Drawing.Point(24, 15);
            this.lblPageTitle.Text = "Dashboard";

            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentDate.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblCurrentDate.Location = new System.Drawing.Point(26, 50);
            this.lblCurrentDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");

            this.pnlTopIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopIcons.Controls.Add(this.pnlAvatarTop);
            this.pnlTopIcons.Controls.Add(this.lblNotifIcon);
            this.pnlTopIcons.Controls.Add(this.lblSearchIcon);
            this.pnlTopIcons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlTopIcons.Location = new System.Drawing.Point(1100, 20);
            this.pnlTopIcons.Name = "pnlTopIcons";
            this.pnlTopIcons.Size = new System.Drawing.Size(220, 50);
            this.pnlTopIcons.TabIndex = 3;

            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblSearchIcon.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lblSearchIcon.Text = "🔍";
            this.lblSearchIcon.Cursor = Cursors.Hand;
            this.lblSearchIcon.Visible = false;

            this.lblNotifIcon.AutoSize = true;
            this.lblNotifIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblNotifIcon.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblNotifIcon.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.lblNotifIcon.Text = "🔔";
            this.lblNotifIcon.Cursor = Cursors.Hand;
            this.lblNotifIcon.Visible = false;

            this.pnlAvatarTop.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlAvatarTop.Location = new System.Drawing.Point(170, 0);
            this.pnlAvatarTop.Name = "pnlAvatarTop";
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.TabIndex = 2;
            this.pnlAvatarTop.Visible = false;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = System.Drawing.Color.FromArgb(74, 85, 104);
            this.lblAvatarInitials.Location = new System.Drawing.Point(0, 0);
            this.lblAvatarInitials.Name = "lblAvatarInitials";
            this.lblAvatarInitials.Size = new System.Drawing.Size(40, 40);
            this.lblAvatarInitials.Text = "AD";
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Content
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.pnlRecentPatientsCard);
            this.pnlContent.Controls.Add(this.tlpMainGrid);
            this.pnlContent.Controls.Add(this.pnlCriticalAlert);
            this.pnlContent.Controls.Add(this.flpStats);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 90);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(1340, 810);
            this.pnlContent.TabIndex = 2;

            // Stats FlowPanel
            this.flpStats.Controls.Add(this.pnlStatPatients);
            this.flpStats.Controls.Add(this.pnlStatDoctors);
            this.flpStats.Controls.Add(this.pnlStatAppointments);
            this.flpStats.Controls.Add(this.pnlStatMissedMeds);
            this.flpStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpStats.Location = new System.Drawing.Point(24, 24);
            this.flpStats.Name = "flpStats";
            this.flpStats.Size = new System.Drawing.Size(1292, 140);
            this.flpStats.TabIndex = 0;

            // Stat Card 1: Patients
            this.pnlStatPatients.BackColor = clrWhite;
            this.pnlStatPatients.Padding = new System.Windows.Forms.Padding(20);
            this.pnlStatPatients.Controls.Add(this.lblStatPatientsVal);
            this.pnlStatPatients.Controls.Add(this.lblStatPatientsTitle);
            this.pnlStatPatients.Controls.Add(this.lblStatPatientsTrend);
            this.pnlStatPatients.Margin = new System.Windows.Forms.Padding(0, 0, 15, 20);
            this.pnlStatPatients.Size = new System.Drawing.Size(310, 110);
            this.pnlStatPatients.BorderStyle = BorderStyle.FixedSingle;
            this.lblStatPatientsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatPatientsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblStatPatientsTitle.Size = new System.Drawing.Size(280, 20);
            this.lblStatPatientsTitle.Text = "Total patients";
            
            this.lblStatPatientsVal.AutoSize = true;
            this.lblStatPatientsVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatPatientsVal.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblStatPatientsVal.Location = new System.Drawing.Point(12, 32);
            this.lblStatPatientsVal.Text = "0";
            
            this.lblStatPatientsTrend.AutoSize = true;
            this.lblStatPatientsTrend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatPatientsTrend.ForeColor = System.Drawing.Color.FromArgb(72, 187, 120);
            this.lblStatPatientsTrend.Location = new System.Drawing.Point(15, 80);
            this.lblStatPatientsTrend.Text = "↑ 0 this week";

            // Stat Card 2: Doctors
            this.pnlStatDoctors.BackColor = clrWhite;
            this.pnlStatDoctors.Padding = new System.Windows.Forms.Padding(20);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsVal);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsTitle);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsTrend);
            this.pnlStatDoctors.Margin = new System.Windows.Forms.Padding(0, 0, 15, 20);
            this.pnlStatDoctors.Size = new System.Drawing.Size(310, 110);
            this.pnlStatDoctors.BorderStyle = BorderStyle.FixedSingle;
            this.lblStatDoctorsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatDoctorsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblStatDoctorsTitle.Size = new System.Drawing.Size(280, 20);
            this.lblStatDoctorsTitle.Text = "Active doctors";
            
            this.lblStatDoctorsVal.AutoSize = true;
            this.lblStatDoctorsVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatDoctorsVal.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblStatDoctorsVal.Location = new System.Drawing.Point(12, 32);
            this.lblStatDoctorsVal.Text = "0";
            
            this.lblStatDoctorsTrend.AutoSize = true;
            this.lblStatDoctorsTrend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatDoctorsTrend.ForeColor = System.Drawing.Color.FromArgb(72, 187, 120);
            this.lblStatDoctorsTrend.Location = new System.Drawing.Point(15, 80);
            this.lblStatDoctorsTrend.Text = "↑ 0 this week";

            // Stat Card 3: Appointments
            this.pnlStatAppointments.BackColor = clrWhite;
            this.pnlStatAppointments.Padding = new System.Windows.Forms.Padding(20);
            this.pnlStatAppointments.Controls.Add(this.lblStatAppointmentsVal);
            this.pnlStatAppointments.Controls.Add(this.lblStatAppointmentsTitle);
            this.pnlStatAppointments.Controls.Add(this.lblStatAppointmentsSub);
            this.pnlStatAppointments.Margin = new System.Windows.Forms.Padding(0, 0, 15, 20);
            this.pnlStatAppointments.Size = new System.Drawing.Size(310, 110);
            this.pnlStatAppointments.BorderStyle = BorderStyle.FixedSingle;
            this.lblStatAppointmentsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatAppointmentsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblStatAppointmentsTitle.Size = new System.Drawing.Size(280, 20);
            this.lblStatAppointmentsTitle.Text = "Appointments today";
            
            this.lblStatAppointmentsVal.AutoSize = true;
            this.lblStatAppointmentsVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatAppointmentsVal.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblStatAppointmentsVal.Location = new System.Drawing.Point(12, 32);
            this.lblStatAppointmentsVal.Text = "0";
            
            this.lblStatAppointmentsSub.AutoSize = true;
            this.lblStatAppointmentsSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatAppointmentsSub.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatAppointmentsSub.Location = new System.Drawing.Point(15, 80);
            this.lblStatAppointmentsSub.Text = "0 remaining";

            // Stat Card 4: Missed Medications
            this.pnlStatMissedMeds.BackColor = clrWhite;
            this.pnlStatMissedMeds.Padding = new System.Windows.Forms.Padding(20);
            this.pnlStatMissedMeds.Controls.Add(this.lblStatMissedMedsVal);
            this.pnlStatMissedMeds.Controls.Add(this.lblStatMissedMedsTitle);
            this.pnlStatMissedMeds.Controls.Add(this.lblStatMissedMedsSub);
            this.pnlStatMissedMeds.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlStatMissedMeds.Size = new System.Drawing.Size(310, 110);
            this.pnlStatMissedMeds.BorderStyle = BorderStyle.FixedSingle;
            this.lblStatMissedMedsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatMissedMedsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblStatMissedMedsTitle.Size = new System.Drawing.Size(280, 20);
            this.lblStatMissedMedsTitle.Text = "Missed medications";
            
            this.lblStatMissedMedsVal.AutoSize = true;
            this.lblStatMissedMedsVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatMissedMedsVal.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblStatMissedMedsVal.Location = new System.Drawing.Point(12, 32);
            this.lblStatMissedMedsVal.Text = "0";
            
            this.lblStatMissedMedsSub.AutoSize = true;
            this.lblStatMissedMedsSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatMissedMedsSub.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblStatMissedMedsSub.Location = new System.Drawing.Point(15, 80);
            this.lblStatMissedMedsSub.Text = "⚠ needs review";
            
            // Critical Alert Banner
            this.pnlCriticalAlert.BackColor = System.Drawing.Color.FromArgb(255, 245, 245);
            this.pnlCriticalAlert.BorderStyle = BorderStyle.FixedSingle;
            this.pnlCriticalAlert.Controls.Add(this.btnViewAllAlerts);
            this.pnlCriticalAlert.Controls.Add(this.lblAlertText);
            this.pnlCriticalAlert.Controls.Add(this.lblAlertIcon);
            this.pnlCriticalAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCriticalAlert.Location = new System.Drawing.Point(24, 184);
            this.pnlCriticalAlert.Name = "pnlCriticalAlert";
            this.pnlCriticalAlert.Size = new System.Drawing.Size(1292, 60);
            this.pnlCriticalAlert.TabIndex = 4;
            this.pnlCriticalAlert.Visible = false;
            this.pnlCriticalAlert.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);

            this.lblAlertIcon.AutoSize = true;
            this.lblAlertIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAlertIcon.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblAlertIcon.Location = new System.Drawing.Point(15, 18);
            this.lblAlertIcon.Text = "⚠";

            this.lblAlertText.AutoSize = true;
            this.lblAlertText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlertText.ForeColor = System.Drawing.Color.FromArgb(155, 44, 44);
            this.lblAlertText.Location = new System.Drawing.Point(45, 18);
            this.lblAlertText.Text = "0 patients have missed their scheduled medications today — immediate follow-up recommended.";

            this.btnViewAllAlerts.Anchor = AnchorStyles.Right;
            this.btnViewAllAlerts.AutoSize = true;
            this.btnViewAllAlerts.Cursor = Cursors.Hand;
            this.btnViewAllAlerts.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewAllAlerts.ForeColor = System.Drawing.Color.FromArgb(155, 44, 44);
            this.btnViewAllAlerts.Location = new System.Drawing.Point(1200, 18);
            this.btnViewAllAlerts.Text = "View all →";

            // Main Grid
            this.tlpMainGrid.ColumnCount = 2;
            this.tlpMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlpMainGrid.Controls.Add(this.pnlAdherenceCard, 0, 0);
            this.tlpMainGrid.Controls.Add(this.pnlActivityCard, 1, 0);
            this.tlpMainGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMainGrid.Location = new System.Drawing.Point(24, 180);
            this.tlpMainGrid.Name = "tlpMainGrid";
            this.tlpMainGrid.RowCount = 1;
            this.tlpMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tlpMainGrid.Size = new System.Drawing.Size(1292, 450);
            this.tlpMainGrid.TabIndex = 1;

            // Adherence Card
            this.pnlAdherenceCard.BackColor = clrWhite;
            this.pnlAdherenceCard.Controls.Add(this.flpAdherence);
            this.pnlAdherenceCard.Controls.Add(this.lblAdherenceDetails);
            this.pnlAdherenceCard.Controls.Add(this.lblAdherenceTitle);
            this.pnlAdherenceCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdherenceCard.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlAdherenceCard.Name = "pnlAdherenceCard";
            this.pnlAdherenceCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlAdherenceCard.TabIndex = 0;

            this.lblAdherenceTitle.AutoSize = true;
            this.lblAdherenceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdherenceTitle.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblAdherenceTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAdherenceTitle.Text = "Patient adherence by doctor";

            this.lblAdherenceDetails.Anchor = AnchorStyles.Right;
            this.lblAdherenceDetails.AutoSize = true;
            this.lblAdherenceDetails.Cursor = Cursors.Hand;
            this.lblAdherenceDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAdherenceDetails.ForeColor = System.Drawing.Color.FromArgb(49, 151, 149);
            this.lblAdherenceDetails.Location = new System.Drawing.Point(380, 22);
            this.lblAdherenceDetails.Text = "Details";

            this.flpAdherence.AutoScroll = true;
            this.flpAdherence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAdherence.Location = new System.Drawing.Point(20, 60);
            this.flpAdherence.Name = "flpAdherence";
            this.flpAdherence.Size = new System.Drawing.Size(460, 370);
            this.flpAdherence.TabIndex = 1;

            // Activity Card
            this.pnlActivityCard.BackColor = clrWhite;
            this.pnlActivityCard.Controls.Add(this.flpActivity);
            this.pnlActivityCard.Controls.Add(this.lblActivityViewLog);
            this.pnlActivityCard.Controls.Add(this.lblActivityTitle);
            this.pnlActivityCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActivityCard.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlActivityCard.Name = "pnlActivityCard";
            this.pnlActivityCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlActivityCard.TabIndex = 1;

            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblActivityTitle.Location = new System.Drawing.Point(20, 20);
            this.lblActivityTitle.Text = "Recent activity";

            this.lblActivityViewLog.Anchor = AnchorStyles.Right;
            this.lblActivityViewLog.AutoSize = true;
            this.lblActivityViewLog.Cursor = Cursors.Hand;
            this.lblActivityViewLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblActivityViewLog.ForeColor = System.Drawing.Color.FromArgb(49, 151, 149);
            this.lblActivityViewLog.Location = new System.Drawing.Point(540, 22);
            this.lblActivityViewLog.Text = "View log";

            this.flpActivity.AutoScroll = true;
            this.flpActivity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpActivity.Location = new System.Drawing.Point(20, 60);
            this.flpActivity.Name = "flpActivity";
            this.flpActivity.Size = new System.Drawing.Size(632, 370);
            this.flpActivity.TabIndex = 1;

            // Recent Patients Card
            this.pnlRecentPatientsCard.BackColor = clrWhite;
            this.pnlRecentPatientsCard.Controls.Add(this.dgvRecentPatients);
            this.pnlRecentPatientsCard.Controls.Add(this.lblViewAllPatients);
            this.pnlRecentPatientsCard.Controls.Add(this.lblRecentPatientsTitle);
            this.pnlRecentPatientsCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentPatientsCard.Location = new System.Drawing.Point(24, 650);
            this.pnlRecentPatientsCard.Name = "pnlRecentPatientsCard";
            this.pnlRecentPatientsCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRecentPatientsCard.Size = new System.Drawing.Size(1292, 300);
            this.pnlRecentPatientsCard.TabIndex = 5;

            this.lblRecentPatientsTitle.AutoSize = true;
            this.lblRecentPatientsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentPatientsTitle.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblRecentPatientsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRecentPatientsTitle.Text = "Recent patients";

            this.lblViewAllPatients.Anchor = AnchorStyles.Right;
            this.lblViewAllPatients.AutoSize = true;
            this.lblViewAllPatients.Cursor = Cursors.Hand;
            this.lblViewAllPatients.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblViewAllPatients.ForeColor = System.Drawing.Color.FromArgb(49, 151, 149);
            this.lblViewAllPatients.Location = new System.Drawing.Point(1150, 22);
            this.lblViewAllPatients.Text = "View all patients";
            this.lblViewAllPatients.Visible = false;

            this.dgvRecentPatients.BackgroundColor = clrWhite;
            this.dgvRecentPatients.BorderStyle = BorderStyle.None;
            this.dgvRecentPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRecentPatients.Location = new System.Drawing.Point(20, 60);
            this.dgvRecentPatients.Name = "dgvRecentPatients";
            this.dgvRecentPatients.Size = new System.Drawing.Size(1252, 220);
            this.dgvRecentPatients.TabIndex = 2;
            this.dgvRecentPatients.ReadOnly = true;
            this.dgvRecentPatients.AllowUserToAddRows = false;
            this.dgvRecentPatients.RowHeadersVisible = false;
            this.dgvRecentPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Admin_Dashboard";
            this.Text = "RecoverEase - Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavDashboard.PerformLayout();
            this.btnNavStaff.ResumeLayout(false);
            this.btnNavStaff.PerformLayout();
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavPatients.PerformLayout();
            this.btnNavReports.ResumeLayout(false);
            this.btnNavReports.PerformLayout();
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlSidebarBottom.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlTopIcons.ResumeLayout(false);
            this.pnlTopIcons.PerformLayout();
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.flpStats.ResumeLayout(false);
            this.pnlStatPatients.ResumeLayout(false);
            this.pnlStatPatients.PerformLayout();
            this.pnlStatDoctors.ResumeLayout(false);
            this.pnlStatDoctors.PerformLayout();
            this.pnlStatAppointments.ResumeLayout(false);
            this.pnlStatAppointments.PerformLayout();
            this.pnlStatMissedMeds.ResumeLayout(false);
            this.pnlStatMissedMeds.PerformLayout();
            this.pnlCriticalAlert.ResumeLayout(false);
            this.pnlCriticalAlert.PerformLayout();
            this.tlpMainGrid.ResumeLayout(false);
            this.pnlAdherenceCard.ResumeLayout(false);
            this.pnlAdherenceCard.PerformLayout();
            this.pnlActivityCard.ResumeLayout(false);
            this.pnlActivityCard.PerformLayout();
            this.pnlRecentPatientsCard.ResumeLayout(false);
            this.pnlRecentPatientsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPatients)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

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
        private System.Windows.Forms.Label lblSidebarFooter;
        private System.Windows.Forms.Button btnLogout;
        
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.FlowLayoutPanel pnlTopIcons;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Label lblNotifIcon;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpStats;
        
        private System.Windows.Forms.Panel pnlStatPatients;
        private System.Windows.Forms.Label lblStatPatientsVal;
        private System.Windows.Forms.Label lblStatPatientsTitle;
        private System.Windows.Forms.Label lblStatPatientsTrend;

        private System.Windows.Forms.Panel pnlStatDoctors;
        private System.Windows.Forms.Label lblStatDoctorsVal;
        private System.Windows.Forms.Label lblStatDoctorsTitle;
        private System.Windows.Forms.Label lblStatDoctorsTrend;

        private System.Windows.Forms.Panel pnlStatAppointments;
        private System.Windows.Forms.Label lblStatAppointmentsVal;
        private System.Windows.Forms.Label lblStatAppointmentsTitle;
        private System.Windows.Forms.Label lblStatAppointmentsSub;

        private System.Windows.Forms.Panel pnlStatMissedMeds;
        private System.Windows.Forms.Label lblStatMissedMedsVal;
        private System.Windows.Forms.Label lblStatMissedMedsTitle;
        private System.Windows.Forms.Label lblStatMissedMedsSub;

        private System.Windows.Forms.Panel pnlCriticalAlert;
        private System.Windows.Forms.Label lblAlertIcon;
        private System.Windows.Forms.Label lblAlertText;
        private System.Windows.Forms.Label btnViewAllAlerts;

        private System.Windows.Forms.TableLayoutPanel tlpMainGrid;
        
        private System.Windows.Forms.Panel pnlAdherenceCard;
        private System.Windows.Forms.Label lblAdherenceTitle;
        private System.Windows.Forms.Label lblAdherenceDetails;
        private System.Windows.Forms.FlowLayoutPanel flpAdherence;

        private System.Windows.Forms.Panel pnlActivityCard;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblActivityViewLog;
        private System.Windows.Forms.FlowLayoutPanel flpActivity;

        private System.Windows.Forms.Panel pnlRecentPatientsCard;
        private System.Windows.Forms.Label lblRecentPatientsTitle;
        private System.Windows.Forms.Label lblViewAllPatients;
        private System.Windows.Forms.DataGridView dgvRecentPatients;

    }
}