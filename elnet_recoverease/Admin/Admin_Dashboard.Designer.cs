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
            this.tlpMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAlertsCard = new System.Windows.Forms.Panel();
            this.lblAlertsTitle = new System.Windows.Forms.Label();
            this.flpAlerts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlActivityCard = new System.Windows.Forms.Panel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.flpActivity = new System.Windows.Forms.FlowLayoutPanel();

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
            this.tlpMainGrid.SuspendLayout();
            this.pnlAlertsCard.SuspendLayout();
            this.pnlActivityCard.SuspendLayout();
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

            SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "\u229E", "Admin Dashboard", true, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavUsers, this.lblNavUsersIcon, this.lblNavUsersText, "🔑", "User Accounts", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "💊", "Medication List", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", false, clrNavyActive, clrWhite);

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
            this.pnlContent.Controls.Add(this.tlpMainGrid);
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
                pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pnl.Controls.Add(val);
                pnl.Controls.Add(title);
                pnl.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
                pnl.Size = new System.Drawing.Size(320, 120);
                
                val.AutoSize = true;
                val.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
                val.ForeColor = clrNavyActive;
                val.Location = new System.Drawing.Point(20, 40);
                val.Text = valTxt;
                
                title.AutoSize = true;
                title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
                title.Location = new System.Drawing.Point(22, 18);
                title.Text = titleTxt;
            }

            SetupStatCard(this.pnlStatTotalUsers, this.lblStatTotalUsersVal, this.lblStatTotalUsersTitle, "0", "TOTAL SYSTEM USERS");
            SetupStatCard(this.pnlStatActiveStaff, this.lblStatActiveStaffVal, this.lblStatActiveStaffTitle, "0", "ACTIVE MEDICAL STAFF");
            SetupStatCard(this.pnlStatTotalPatients, this.lblStatTotalPatientsVal, this.lblStatTotalPatientsTitle, "0", "TOTAL PATIENTS REGISTERED");

            // Main Grid
            this.tlpMainGrid.ColumnCount = 2;
            this.tlpMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainGrid.Controls.Add(this.pnlAlertsCard, 0, 0);
            this.tlpMainGrid.Controls.Add(this.pnlActivityCard, 1, 0);
            this.tlpMainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainGrid.Location = new System.Drawing.Point(24, 164);
            this.tlpMainGrid.Name = "tlpMainGrid";
            this.tlpMainGrid.RowCount = 1;
            this.tlpMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainGrid.Size = new System.Drawing.Size(1292, 632);
            this.tlpMainGrid.TabIndex = 1;

            // Alerts Card
            this.pnlAlertsCard.BackColor = clrWhite;
            this.pnlAlertsCard.Controls.Add(this.flpAlerts);
            this.pnlAlertsCard.Controls.Add(this.lblAlertsTitle);
            this.pnlAlertsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlertsCard.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlAlertsCard.Name = "pnlAlertsCard";
            this.pnlAlertsCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlAlertsCard.TabIndex = 0;
            this.pnlAlertsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblAlertsTitle.AutoSize = true;
            this.lblAlertsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAlertsTitle.ForeColor = clrNavyActive;
            this.lblAlertsTitle.Location = new System.Drawing.Point(24, 24);
            this.lblAlertsTitle.Text = "🔔 System Alerts";

            this.flpAlerts.AutoScroll = true;
            this.flpAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAlerts.Location = new System.Drawing.Point(24, 65);
            this.flpAlerts.Name = "flpAlerts";
            this.flpAlerts.Size = new System.Drawing.Size(582, 530);
            this.flpAlerts.TabIndex = 1;

            // Activity Card
            this.pnlActivityCard.BackColor = clrWhite;
            this.pnlActivityCard.Controls.Add(this.flpActivity);
            this.pnlActivityCard.Controls.Add(this.lblActivityTitle);
            this.pnlActivityCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActivityCard.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlActivityCard.Name = "pnlActivityCard";
            this.pnlActivityCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlActivityCard.TabIndex = 1;
            this.pnlActivityCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = clrNavyActive;
            this.lblActivityTitle.Location = new System.Drawing.Point(24, 24);
            this.lblActivityTitle.Text = "🕒 Recent Activity";

            this.flpActivity.AutoScroll = true;
            this.flpActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActivity.Location = new System.Drawing.Point(24, 65);
            this.flpActivity.Name = "flpActivity";
            this.flpActivity.Size = new System.Drawing.Size(582, 530);
            this.flpActivity.TabIndex = 1;

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
            this.tlpMainGrid.ResumeLayout(false);
            this.pnlAlertsCard.ResumeLayout(false);
            this.pnlAlertsCard.PerformLayout();
            this.pnlActivityCard.ResumeLayout(false);
            this.pnlActivityCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private void SetupNavItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, string icoChar, string label, bool isActive, System.Drawing.Color activeColor, System.Drawing.Color whiteColor)
        {
            pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            pnl.Dock = System.Windows.Forms.DockStyle.Top;
            pnl.Size = new System.Drawing.Size(260, 48);
            if (isActive) pnl.BackColor = activeColor;
            ico.AutoSize = true;
            ico.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            ico.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            ico.Location = new System.Drawing.Point(20, 11);
            ico.Text = icoChar;
            txt.AutoSize = true;
            txt.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            txt.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            txt.Location = new System.Drawing.Point(64, 13);
            txt.Text = label;
            pnl.Controls.Add(ico);
            pnl.Controls.Add(txt);
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
        
        private System.Windows.Forms.TableLayoutPanel tlpMainGrid;
        
        private System.Windows.Forms.Panel pnlAlertsCard;
        private System.Windows.Forms.Label lblAlertsTitle;
        private System.Windows.Forms.FlowLayoutPanel flpAlerts;
        private System.Windows.Forms.Panel pnlActivityCard;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.FlowLayoutPanel flpActivity;

    }
}