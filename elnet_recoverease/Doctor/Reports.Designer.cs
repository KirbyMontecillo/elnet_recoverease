namespace elnet_recoverease.Doctor
{
    partial class Reports
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
            this.flpStats = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatTotalPatients = new System.Windows.Forms.Panel();
            this.lblStatTotalPatientsVal = new System.Windows.Forms.Label();
            this.lblStatTotalPatientsTitle = new System.Windows.Forms.Label();
            this.pnlStatMonthlyAppts = new System.Windows.Forms.Panel();
            this.lblStatMonthlyApptsVal = new System.Windows.Forms.Label();
            this.lblStatMonthlyApptsTitle = new System.Windows.Forms.Label();
            this.pnlStatActivePlans = new System.Windows.Forms.Panel();
            this.lblStatActivePlansVal = new System.Windows.Forms.Label();
            this.lblStatActivePlansTitle = new System.Windows.Forms.Label();
            this.pnlChartsArea = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChartPatientTrends = new System.Windows.Forms.Panel();
            this.lblChartPatientTrendsTitle = new System.Windows.Forms.Label();
            this.lblChartPlaceholder1 = new System.Windows.Forms.Label();
            this.pnlRecentActivity = new System.Windows.Forms.Panel();
            this.lblRecentActivityTitle = new System.Windows.Forms.Label();
            this.dgvRecentActivity = new System.Windows.Forms.DataGridView();
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
            this.flpStats.SuspendLayout();
            this.pnlStatTotalPatients.SuspendLayout();
            this.pnlStatMonthlyAppts.SuspendLayout();
            this.pnlStatActivePlans.SuspendLayout();
            this.pnlChartsArea.SuspendLayout();
            this.pnlChartPatientTrends.SuspendLayout();
            this.pnlRecentActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).BeginInit();
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

            // Reports (Active)
            this.btnNavReports.BackColor = clrNavyActive;
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
            this.lblNavReportsIcon.ForeColor = clrWhite;
            this.lblNavReportsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavReportsIcon.Text = "📊";
            this.lblNavReportsText.AutoSize = true;
            this.lblNavReportsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavReportsText.ForeColor = clrWhite;
            this.lblNavReportsText.Location = new System.Drawing.Point(64, 13);
            this.lblNavReportsText.Text = "Reports & Analytics";

            // Profile
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
            this.lblNavProfileIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavProfileIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavProfileIcon.Text = "👤";
            this.lblNavProfileText.AutoSize = true;
            this.lblNavProfileText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavProfileText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
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
            this.lblPageTitle.Text = "Reports & Analytics";

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
            this.pnlContent.Controls.Add(this.pnlChartsArea);
            this.pnlContent.Controls.Add(this.flpStats);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(1340, 820);
            this.pnlContent.TabIndex = 2;

            // Stats FlowPanel
            this.flpStats.Controls.Add(this.pnlStatTotalPatients);
            this.flpStats.Controls.Add(this.pnlStatMonthlyAppts);
            this.flpStats.Controls.Add(this.pnlStatActivePlans);
            this.flpStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpStats.Location = new System.Drawing.Point(24, 24);
            this.flpStats.Name = "flpStats";
            this.flpStats.Size = new System.Drawing.Size(1292, 140);
            this.flpStats.TabIndex = 0;

            // Stat Cards
            void BuildStatCard(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label val, System.Windows.Forms.Label title, string valTxt, string titleTxt)
            {
                pnl.BackColor = clrWhite;
                pnl.Controls.Add(val);
                pnl.Controls.Add(title);
                pnl.Margin = new System.Windows.Forms.Padding(0, 0, 16, 16);
                pnl.Size = new System.Drawing.Size(280, 120);
                val.AutoSize = true;
                val.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
                val.ForeColor = clrNavyActive;
                val.Location = new System.Drawing.Point(16, 40);
                val.Text = valTxt;
                title.AutoSize = true;
                title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
                title.Location = new System.Drawing.Point(16, 16);
                title.Text = titleTxt;
            }

            BuildStatCard(this.pnlStatTotalPatients, this.lblStatTotalPatientsVal, this.lblStatTotalPatientsTitle, "0", "TOTAL PATIENTS");
            BuildStatCard(this.pnlStatMonthlyAppts, this.lblStatMonthlyApptsVal, this.lblStatMonthlyApptsTitle, "0", "MONTHLY APPOINTMENTS");
            BuildStatCard(this.pnlStatActivePlans, this.lblStatActivePlansVal, this.lblStatActivePlansTitle, "0", "ACTIVE TREATMENT PLANS");

            // Charts Area
            this.pnlChartsArea.ColumnCount = 2;
            this.pnlChartsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlChartsArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlChartsArea.Controls.Add(this.pnlChartPatientTrends, 0, 0);
            this.pnlChartsArea.Controls.Add(this.pnlRecentActivity, 1, 0);
            this.pnlChartsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartsArea.Location = new System.Drawing.Point(24, 164);
            this.pnlChartsArea.Name = "pnlChartsArea";
            this.pnlChartsArea.RowCount = 1;
            this.pnlChartsArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlChartsArea.Size = new System.Drawing.Size(1292, 632);
            this.pnlChartsArea.TabIndex = 1;

            // Patient Trends Panel
            this.pnlChartPatientTrends.BackColor = clrWhite;
            this.pnlChartPatientTrends.Controls.Add(this.lblChartPlaceholder1);
            this.pnlChartPatientTrends.Controls.Add(this.lblChartPatientTrendsTitle);
            this.pnlChartPatientTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartPatientTrends.Location = new System.Drawing.Point(0, 0);
            this.pnlChartPatientTrends.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlChartPatientTrends.Name = "pnlChartPatientTrends";
            this.pnlChartPatientTrends.Padding = new System.Windows.Forms.Padding(24);
            this.pnlChartPatientTrends.TabIndex = 0;

            this.lblChartPatientTrendsTitle.AutoSize = true;
            this.lblChartPatientTrendsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblChartPatientTrendsTitle.ForeColor = clrNavyActive;
            this.lblChartPatientTrendsTitle.Location = new System.Drawing.Point(24, 24);
            this.lblChartPatientTrendsTitle.Text = "Patient Growth Trends";

            this.lblChartPlaceholder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChartPlaceholder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblChartPlaceholder1.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblChartPlaceholder1.Location = new System.Drawing.Point(24, 24);
            this.lblChartPlaceholder1.Text = "[ Chart Component Placeholder ]";
            this.lblChartPlaceholder1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Recent Activity Panel
            this.pnlRecentActivity.BackColor = clrWhite;
            this.pnlRecentActivity.Controls.Add(this.dgvRecentActivity);
            this.pnlRecentActivity.Controls.Add(this.lblRecentActivityTitle);
            this.pnlRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentActivity.Location = new System.Drawing.Point(775, 0);
            this.pnlRecentActivity.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnlRecentActivity.Name = "pnlRecentActivity";
            this.pnlRecentActivity.Padding = new System.Windows.Forms.Padding(24);
            this.pnlRecentActivity.TabIndex = 1;

            this.lblRecentActivityTitle.AutoSize = true;
            this.lblRecentActivityTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentActivityTitle.ForeColor = clrNavyActive;
            this.lblRecentActivityTitle.Location = new System.Drawing.Point(24, 24);
            this.lblRecentActivityTitle.Text = "Recent Activity";

            this.dgvRecentActivity.BackgroundColor = clrWhite;
            this.dgvRecentActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentActivity.Location = new System.Drawing.Point(24, 70);
            this.dgvRecentActivity.Name = "dgvRecentActivity";
            this.dgvRecentActivity.Size = new System.Drawing.Size(460, 530);
            this.dgvRecentActivity.TabIndex = 1;
            this.dgvRecentActivity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Reports";
            this.Text = "RecoverEase - Reports";
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
            this.flpStats.ResumeLayout(false);
            this.pnlStatTotalPatients.ResumeLayout(false);
            this.pnlStatTotalPatients.PerformLayout();
            this.pnlStatMonthlyAppts.ResumeLayout(false);
            this.pnlStatMonthlyAppts.PerformLayout();
            this.pnlStatActivePlans.ResumeLayout(false);
            this.pnlStatActivePlans.PerformLayout();
            this.pnlChartsArea.ResumeLayout(false);
            this.pnlChartPatientTrends.ResumeLayout(false);
            this.pnlChartPatientTrends.PerformLayout();
            this.pnlRecentActivity.ResumeLayout(false);
            this.pnlRecentActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivity)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flpStats;
        private System.Windows.Forms.Panel pnlStatTotalPatients;
        private System.Windows.Forms.Label lblStatTotalPatientsVal;
        private System.Windows.Forms.Label lblStatTotalPatientsTitle;
        private System.Windows.Forms.Panel pnlStatMonthlyAppts;
        private System.Windows.Forms.Label lblStatMonthlyApptsVal;
        private System.Windows.Forms.Label lblStatMonthlyApptsTitle;
        private System.Windows.Forms.Panel pnlStatActivePlans;
        private System.Windows.Forms.Label lblStatActivePlansVal;
        private System.Windows.Forms.Label lblStatActivePlansTitle;
        private System.Windows.Forms.TableLayoutPanel pnlChartsArea;
        private System.Windows.Forms.Panel pnlChartPatientTrends;
        private System.Windows.Forms.Label lblChartPatientTrendsTitle;
        private System.Windows.Forms.Label lblChartPlaceholder1;
        private System.Windows.Forms.Panel pnlRecentActivity;
        private System.Windows.Forms.Label lblRecentActivityTitle;
        private System.Windows.Forms.DataGridView dgvRecentActivity;
    }
}