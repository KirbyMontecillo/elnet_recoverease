namespace elnet_recoverease.Admin.Forms
{
    partial class AdminMainForm
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
            this.btnNavProfile = new System.Windows.Forms.Panel();
            this.lblNavProfileIcon = new System.Windows.Forms.Label();
            this.lblNavProfileText = new System.Windows.Forms.Label();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.lblSidebarFooter = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblMenuHeader = new System.Windows.Forms.Label();
            this.lblAccountHeader = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlTitleDivider = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.pnlTopIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.lblNotifIcon = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();

            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavStaff.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.btnNavProfile.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlTopIcons.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(238, 243, 247);
            System.Drawing.Color clrNavyActive = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;

            // Sidebar
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.lblAccountHeader);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavStaff);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.lblMenuHeader);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
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
            this.pnlLogoArea.Padding = new System.Windows.Forms.Padding(35, 25, 35, 15);
            this.pnlLogoArea.Size = new System.Drawing.Size(260, 120);

            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;

            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Location = new System.Drawing.Point(0, 120);
            this.pnlNavDivider.Size = new System.Drawing.Size(260, 1);

            // Navigation Items
            SetupNavItem(this.btnNavProfile, this.lblNavProfileIcon, this.lblNavProfileText, "👤", "My Profile", false, clrNavyActive, clrWhite);
            
            // lblAccountHeader
            this.lblAccountHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountHeader.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAccountHeader.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            this.lblAccountHeader.Location = new System.Drawing.Point(0, 401);
            this.lblAccountHeader.Padding = new System.Windows.Forms.Padding(24, 20, 0, 5);
            this.lblAccountHeader.Size = new System.Drawing.Size(260, 45);
            this.lblAccountHeader.Text = "ACCOUNT";

            SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "💊", "Medication List", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "⊞", "Admin Dashboard", true, clrNavyActive, clrWhite);

            // lblMenuHeader
            this.lblMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuHeader.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMenuHeader.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            this.lblMenuHeader.Location = new System.Drawing.Point(0, 121);
            this.lblMenuHeader.Padding = new System.Windows.Forms.Padding(24, 20, 0, 5);
            this.lblMenuHeader.Size = new System.Drawing.Size(260, 45);
            this.lblMenuHeader.Text = "MENU";

            // Sidebar Bottom
            this.pnlSidebarBottom.Controls.Add(this.lblSidebarFooter);
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Location = new System.Drawing.Point(0, 840);
            this.pnlSidebarBottom.Size = new System.Drawing.Size(260, 60);

            this.lblSidebarFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSidebarFooter.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            this.lblSidebarFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSidebarFooter.Text = "RecoverEase Admin Portal";

            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(16, 32);
            this.btnLogout.Size = new System.Drawing.Size(188, 26);
            this.btnLogout.Text = "⇠  Sign Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Visible = false;

            // TopBar
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Controls.Add(this.pnlTopIcons);
            this.pnlTopBar.Controls.Add(this.pnlTitleDivider);
            this.pnlTopBar.Controls.Add(this.lblCurrentDate);
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(260, 0);
            this.pnlTopBar.Size = new System.Drawing.Size(1340, 90);
            
            // pnlTitleDivider
            this.pnlTitleDivider.BackColor = System.Drawing.Color.FromArgb(56, 161, 105); // Matching green
            this.pnlTitleDivider.Location = new System.Drawing.Point(26, 85);
            this.pnlTitleDivider.Size = new System.Drawing.Size(1290, 2);
            this.pnlTitleDivider.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblPageTitle.Location = new System.Drawing.Point(24, 15);
            this.lblPageTitle.Text = "Dashboard";

            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCurrentDate.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblCurrentDate.Location = new System.Drawing.Point(26, 50);
            this.lblCurrentDate.Text = System.DateTime.Now.ToString("dddd, MMMM d, yyyy");

            this.pnlTopIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopIcons.Controls.Add(this.pnlAvatarTop);
            this.pnlTopIcons.Controls.Add(this.lblNotifIcon);
            this.pnlTopIcons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlTopIcons.Location = new System.Drawing.Point(1100, 20);
            this.pnlTopIcons.Size = new System.Drawing.Size(220, 50);

            this.pnlAvatarTop.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlAvatarTop.Location = new System.Drawing.Point(170, 0);
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.Visible = false;

            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvatarInitials.Text = "AD";

            this.lblNotifIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblNotifIcon.Text = "🔔";
            this.lblNotifIcon.Visible = false;

            // panelContainer
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(260, 90);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1340, 810);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.DoubleBuffered = true;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverEase - Admin Portal";
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
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavProfile.PerformLayout();
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlTopIcons.ResumeLayout(false);
            this.pnlAvatarTop.ResumeLayout(false);
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlTitleDivider;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.FlowLayoutPanel pnlTopIcons;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Label lblNotifIcon;
        private System.Windows.Forms.Label lblMenuHeader;
        private System.Windows.Forms.Label lblAccountHeader;
        private System.Windows.Forms.Panel panelContainer;
    }
}
