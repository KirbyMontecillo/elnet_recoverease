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
            pnlSidebar = new Panel();
            pnlSidebarBottom = new Panel();
            lblSidebarFooter = new Label();
            btnLogout = new Button();
            btnNavProfile = new Panel();
            lblNavProfileIcon = new Label();
            lblNavProfileText = new Label();
            lblAccountHeader = new Label();
            btnNavReports = new Panel();
            lblNavReportsIcon = new Label();
            lblNavReportsText = new Label();
            btnNavPatients = new Panel();
            lblNavPatientsIcon = new Label();
            lblNavPatientsText = new Label();
            btnNavStaff = new Panel();
            lblNavStaffIcon = new Label();
            lblNavStaffText = new Label();
            btnNavDashboard = new Panel();
            lblNavDashIcon = new Label();
            lblNavDashText = new Label();
            lblMenuHeader = new Label();
            pnlNavDivider = new Panel();
            pnlLogoArea = new Panel();
            picLogo = new PictureBox();
            pnlTopBar = new Panel();
            pnlTopIcons = new FlowLayoutPanel();
            pnlAvatarTop = new Panel();
            lblAvatarInitials = new Label();
            lblNotifIcon = new Label();
            pnlTitleDivider = new Panel();
            lblCurrentDate = new Label();
            lblPageTitle = new Label();
            panelContainer = new Panel();
            pnlSidebar.SuspendLayout();
            pnlSidebarBottom.SuspendLayout();
            btnNavProfile.SuspendLayout();
            btnNavReports.SuspendLayout();
            btnNavPatients.SuspendLayout();
            btnNavStaff.SuspendLayout();
            btnNavDashboard.SuspendLayout();
            pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTopBar.SuspendLayout();
            pnlTopIcons.SuspendLayout();
            pnlAvatarTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(238, 243, 247);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(btnNavProfile);
            pnlSidebar.Controls.Add(lblAccountHeader);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnNavPatients);
            pnlSidebar.Controls.Add(btnNavStaff);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(lblMenuHeader);
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
            pnlSidebarBottom.Location = new Point(0, 840);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Size = new Size(260, 60);
            pnlSidebarBottom.TabIndex = 0;
            // 
            // lblSidebarFooter
            // 
            lblSidebarFooter.Dock = DockStyle.Fill;
            lblSidebarFooter.Font = new Font("Segoe UI", 8F);
            lblSidebarFooter.ForeColor = Color.FromArgb(160, 174, 192);
            lblSidebarFooter.Location = new Point(0, 0);
            lblSidebarFooter.Name = "lblSidebarFooter";
            lblSidebarFooter.Size = new Size(260, 60);
            lblSidebarFooter.TabIndex = 0;
            lblSidebarFooter.Text = "RecoverEase Admin Portal";
            lblSidebarFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLogout.Location = new Point(16, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 30);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "⇠  Sign Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavProfile
            // 
            btnNavProfile.Dock = DockStyle.Top;
            btnNavProfile.Location = new Point(0, 391);
            btnNavProfile.Name = "btnNavProfile";
            btnNavProfile.Size = new Size(260, 56);
            btnNavProfile.TabIndex = 1;
            // 
            // lblAccountHeader
            // 
            lblAccountHeader.Dock = DockStyle.Top;
            lblAccountHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblAccountHeader.ForeColor = Color.FromArgb(160, 174, 192);
            lblAccountHeader.Location = new Point(0, 346);
            lblAccountHeader.Name = "lblAccountHeader";
            lblAccountHeader.Padding = new Padding(24, 20, 0, 5);
            lblAccountHeader.Size = new Size(260, 45);
            lblAccountHeader.TabIndex = 2;
            lblAccountHeader.Text = "ACCOUNT";
            // 
            // btnNavReports
            // 
            btnNavReports.Dock = DockStyle.Top;
            btnNavReports.Location = new Point(0, 290);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(260, 56);
            btnNavReports.TabIndex = 3;
            // 
            // btnNavPatients
            // 
            btnNavPatients.Dock = DockStyle.Top;
            btnNavPatients.Location = new Point(0, 234);
            btnNavPatients.Name = "btnNavPatients";
            btnNavPatients.Size = new Size(260, 56);
            btnNavPatients.TabIndex = 4;
            // 
            // btnNavStaff
            // 
            btnNavStaff.Dock = DockStyle.Top;
            btnNavStaff.Location = new Point(0, 212);
            btnNavStaff.Name = "btnNavStaff";
            btnNavStaff.Size = new Size(260, 56);
            btnNavStaff.TabIndex = 5;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Dock = DockStyle.Top;
            btnNavDashboard.Location = new Point(0, 156);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(260, 56);
            btnNavDashboard.TabIndex = 6;
            // 
            // lblMenuHeader
            // 
            lblMenuHeader.Dock = DockStyle.Top;
            lblMenuHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMenuHeader.ForeColor = Color.FromArgb(160, 174, 192);
            lblMenuHeader.Location = new Point(0, 121);
            lblMenuHeader.Name = "lblMenuHeader";
            lblMenuHeader.Padding = new Padding(24, 20, 0, 5);
            lblMenuHeader.Size = new Size(260, 45);
            lblMenuHeader.TabIndex = 7;
            lblMenuHeader.Text = "MENU";
            // 
            // pnlNavDivider
            // 
            pnlNavDivider.BackColor = Color.FromArgb(226, 232, 240);
            pnlNavDivider.Dock = DockStyle.Top;
            pnlNavDivider.Location = new Point(0, 120);
            pnlNavDivider.Name = "pnlNavDivider";
            pnlNavDivider.Size = new Size(260, 1);
            pnlNavDivider.TabIndex = 8;
            // 
            // pnlLogoArea
            // 
            pnlLogoArea.Controls.Add(picLogo);
            pnlLogoArea.Dock = DockStyle.Top;
            pnlLogoArea.Location = new Point(0, 0);
            pnlLogoArea.Name = "pnlLogoArea";
            pnlLogoArea.Padding = new Padding(35, 25, 35, 15);
            pnlLogoArea.Size = new Size(260, 120);
            pnlLogoArea.TabIndex = 9;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Location = new Point(35, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(190, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(pnlTopIcons);
            pnlTopBar.Controls.Add(pnlTitleDivider);
            pnlTopBar.Controls.Add(lblCurrentDate);
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(260, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1340, 90);
            pnlTopBar.TabIndex = 1;
            // 
            // pnlTopIcons
            // 
            pnlTopIcons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlTopIcons.Controls.Add(pnlAvatarTop);
            pnlTopIcons.Controls.Add(lblNotifIcon);
            pnlTopIcons.FlowDirection = FlowDirection.RightToLeft;
            pnlTopIcons.Location = new Point(1100, 20);
            pnlTopIcons.Name = "pnlTopIcons";
            pnlTopIcons.Size = new Size(220, 50);
            pnlTopIcons.TabIndex = 0;
            // 
            // pnlAvatarTop
            // 
            pnlAvatarTop.BackColor = Color.FromArgb(226, 232, 240);
            pnlAvatarTop.Controls.Add(lblAvatarInitials);
            pnlAvatarTop.Location = new Point(177, 3);
            pnlAvatarTop.Name = "pnlAvatarTop";
            pnlAvatarTop.Size = new Size(40, 40);
            pnlAvatarTop.TabIndex = 0;
            pnlAvatarTop.Visible = false;
            // 
            // lblAvatarInitials
            // 
            lblAvatarInitials.Dock = DockStyle.Fill;
            lblAvatarInitials.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAvatarInitials.Location = new Point(0, 0);
            lblAvatarInitials.Name = "lblAvatarInitials";
            lblAvatarInitials.Size = new Size(40, 40);
            lblAvatarInitials.TabIndex = 0;
            lblAvatarInitials.Text = "AD";
            lblAvatarInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotifIcon
            // 
            lblNotifIcon.Font = new Font("Segoe UI", 16F);
            lblNotifIcon.Location = new Point(71, 0);
            lblNotifIcon.Name = "lblNotifIcon";
            lblNotifIcon.Size = new Size(100, 40);
            lblNotifIcon.TabIndex = 1;
            lblNotifIcon.Text = "🔔";
            lblNotifIcon.Visible = false;
            // 
            // pnlTitleDivider
            // 
            pnlTitleDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTitleDivider.BackColor = Color.FromArgb(56, 161, 105);
            pnlTitleDivider.Location = new Point(26, 85);
            pnlTitleDivider.Name = "pnlTitleDivider";
            pnlTitleDivider.Size = new Size(1290, 2);
            pnlTitleDivider.TabIndex = 1;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Segoe UI", 10F);
            lblCurrentDate.ForeColor = Color.FromArgb(113, 128, 150);
            this.lblCurrentDate.Location = new System.Drawing.Point(26, 50);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(181, 23);
            lblCurrentDate.TabIndex = 2;
            lblCurrentDate.Text = "Tuesday, May 12, 2026";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(45, 55, 72);
            lblPageTitle.Location = new Point(26, 5);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(171, 41);
            lblPageTitle.TabIndex = 3;
            lblPageTitle.Text = "Dashboard";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(247, 250, 252);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(260, 90);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1340, 810);
            panelContainer.TabIndex = 0;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panelContainer);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            DoubleBuffered = true;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecoverEase - Admin Portal";
            WindowState = FormWindowState.Maximized;



            pnlSidebar.ResumeLayout(false);
            pnlSidebarBottom.ResumeLayout(false);
            btnNavProfile.ResumeLayout(false);
            btnNavReports.ResumeLayout(false);
            btnNavPatients.ResumeLayout(false);
            btnNavStaff.ResumeLayout(false);
            btnNavDashboard.ResumeLayout(false);
            pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlTopIcons.ResumeLayout(false);
            pnlAvatarTop.ResumeLayout(false);
            ResumeLayout(false);
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
