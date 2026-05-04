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
            this.flpStats = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlStatTotalUsers = new System.Windows.Forms.Panel();
            this.lblStatTotalUsersVal = new System.Windows.Forms.Label();
            this.lblStatTotalUsersTitle = new System.Windows.Forms.Label();
            this.pnlStatActiveStaff = new System.Windows.Forms.Panel();
            this.lblStatActiveStaffVal = new System.Windows.Forms.Label();
            this.lblStatActiveStaffTitle = new System.Windows.Forms.Label();
            this.pnlStatTotalPatients = new System.Windows.Forms.Panel();
            this.lblStatTotalPatientsVal = new System.Windows.Forms.Label();
            this.lblStatTotalPatientsTitle = new System.Windows.Forms.Label();
            this.pnlAdminWidgets = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSystemStatus = new System.Windows.Forms.Panel();
            this.lblSystemStatusTitle = new System.Windows.Forms.Label();
            this.lblStatusPlaceholder = new System.Windows.Forms.Label();
            this.pnlRecentUsers = new System.Windows.Forms.Panel();
            this.lblRecentUsersTitle = new System.Windows.Forms.Label();
            this.dgvRecentUsers = new System.Windows.Forms.DataGridView();
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
            this.flpStats.SuspendLayout();
            this.pnlStatTotalUsers.SuspendLayout();
            this.pnlStatActiveStaff.SuspendLayout();
            this.pnlStatTotalPatients.SuspendLayout();
            this.pnlAdminWidgets.SuspendLayout();
            this.pnlSystemStatus.SuspendLayout();
            this.pnlRecentUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentUsers)).BeginInit();
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

            SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "\u229E", "Admin Dashboard", true);
            SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", false);
            SetupNavItem(this.btnNavUsers, this.lblNavUsersIcon, this.lblNavUsersText, "🔑", "User Accounts", false);
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "👥", "Global Patient List", false);
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
            this.lblPageTitle.Text = "Admin Control Center";

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
            this.pnlContent.Controls.Add(this.pnlAdminWidgets);
            this.pnlContent.Controls.Add(this.flpStats);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(1340, 820);
            this.pnlContent.TabIndex = 2;

            // Stats FlowPanel
            this.flpStats.Controls.Add(this.pnlStatTotalUsers);
            this.flpStats.Controls.Add(this.pnlStatActiveStaff);
            this.flpStats.Controls.Add(this.pnlStatTotalPatients);
            this.flpStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpStats.Location = new System.Drawing.Point(24, 24);
            this.flpStats.Name = "flpStats";
            this.flpStats.Size = new System.Drawing.Size(1292, 140);
            this.flpStats.TabIndex = 0;

            // Stat Card Helper
            void SetupStatCard(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label val, System.Windows.Forms.Label title, string valTxt, string titleTxt)
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

            SetupStatCard(this.pnlStatTotalUsers, this.lblStatTotalUsersVal, this.lblStatTotalUsersTitle, "0", "TOTAL SYSTEM USERS");
            SetupStatCard(this.pnlStatActiveStaff, this.lblStatActiveStaffVal, this.lblStatActiveStaffTitle, "0", "ACTIVE MEDICAL STAFF");
            SetupStatCard(this.pnlStatTotalPatients, this.lblStatTotalPatientsVal, this.lblStatTotalPatientsTitle, "0", "TOTAL PATIENTS REGISTERED");

            // Admin Widgets Table
            this.pnlAdminWidgets.ColumnCount = 2;
            this.pnlAdminWidgets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlAdminWidgets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlAdminWidgets.Controls.Add(this.pnlSystemStatus, 0, 0);
            this.pnlAdminWidgets.Controls.Add(this.pnlRecentUsers, 1, 0);
            this.pnlAdminWidgets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminWidgets.Location = new System.Drawing.Point(24, 164);
            this.pnlAdminWidgets.Name = "pnlAdminWidgets";
            this.pnlAdminWidgets.RowCount = 1;
            this.pnlAdminWidgets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAdminWidgets.Size = new System.Drawing.Size(1292, 632);
            this.pnlAdminWidgets.TabIndex = 1;

            // System Status Panel
            this.pnlSystemStatus.BackColor = clrWhite;
            this.pnlSystemStatus.Controls.Add(this.lblStatusPlaceholder);
            this.pnlSystemStatus.Controls.Add(this.lblSystemStatusTitle);
            this.pnlSystemStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSystemStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlSystemStatus.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlSystemStatus.Name = "pnlSystemStatus";
            this.pnlSystemStatus.Padding = new System.Windows.Forms.Padding(24);
            this.pnlSystemStatus.TabIndex = 0;

            this.lblSystemStatusTitle.AutoSize = true;
            this.lblSystemStatusTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSystemStatusTitle.ForeColor = clrNavyActive;
            this.lblSystemStatusTitle.Location = new System.Drawing.Point(24, 24);
            this.lblSystemStatusTitle.Text = "System Health & Status";

            this.lblStatusPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusPlaceholder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblStatusPlaceholder.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblStatusPlaceholder.Location = new System.Drawing.Point(24, 24);
            this.lblStatusPlaceholder.Text = "[ Live Server & Database Status Metrics ]";
            this.lblStatusPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Recent Users Panel
            this.pnlRecentUsers.BackColor = clrWhite;
            this.pnlRecentUsers.Controls.Add(this.dgvRecentUsers);
            this.pnlRecentUsers.Controls.Add(this.lblRecentUsersTitle);
            this.pnlRecentUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentUsers.Location = new System.Drawing.Point(532, 0);
            this.pnlRecentUsers.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnlRecentUsers.Name = "pnlRecentUsers";
            this.pnlRecentUsers.Padding = new System.Windows.Forms.Padding(24);
            this.pnlRecentUsers.TabIndex = 1;

            this.lblRecentUsersTitle.AutoSize = true;
            this.lblRecentUsersTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentUsersTitle.ForeColor = clrNavyActive;
            this.lblRecentUsersTitle.Location = new System.Drawing.Point(24, 24);
            this.lblRecentUsersTitle.Text = "Latest User Registrations";

            this.dgvRecentUsers.BackgroundColor = clrWhite;
            this.dgvRecentUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentUsers.Location = new System.Drawing.Point(24, 70);
            this.dgvRecentUsers.Name = "dgvRecentUsers";
            this.dgvRecentUsers.Size = new System.Drawing.Size(710, 530);
            this.dgvRecentUsers.TabIndex = 1;
            this.dgvRecentUsers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Admin_Dashboard";
            this.Text = "RecoverEase - Admin Dashboard";
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
            this.flpStats.ResumeLayout(false);
            this.pnlStatTotalUsers.ResumeLayout(false);
            this.pnlStatTotalUsers.PerformLayout();
            this.pnlStatActiveStaff.ResumeLayout(false);
            this.pnlStatActiveStaff.PerformLayout();
            this.pnlStatTotalPatients.ResumeLayout(false);
            this.pnlStatTotalPatients.PerformLayout();
            this.pnlAdminWidgets.ResumeLayout(false);
            this.pnlSystemStatus.ResumeLayout(false);
            this.pnlSystemStatus.PerformLayout();
            this.pnlRecentUsers.ResumeLayout(false);
            this.pnlRecentUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentUsers)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flpStats;
        private System.Windows.Forms.Panel pnlStatTotalUsers;
        private System.Windows.Forms.Label lblStatTotalUsersVal;
        private System.Windows.Forms.Label lblStatTotalUsersTitle;
        private System.Windows.Forms.Panel pnlStatActiveStaff;
        private System.Windows.Forms.Label lblStatActiveStaffVal;
        private System.Windows.Forms.Label lblStatActiveStaffTitle;
        private System.Windows.Forms.Panel pnlStatTotalPatients;
        private System.Windows.Forms.Label lblStatTotalPatientsVal;
        private System.Windows.Forms.Label lblStatTotalPatientsTitle;
        private System.Windows.Forms.TableLayoutPanel pnlAdminWidgets;
        private System.Windows.Forms.Panel pnlSystemStatus;
        private System.Windows.Forms.Label lblSystemStatusTitle;
        private System.Windows.Forms.Label lblStatusPlaceholder;
        private System.Windows.Forms.Panel pnlRecentUsers;
        private System.Windows.Forms.Label lblRecentUsersTitle;
        private System.Windows.Forms.DataGridView dgvRecentUsers;
    }
}