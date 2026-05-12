namespace elnet_recoverease.PatientStation.Forms
{
    partial class PatientMainForm
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
            lblAccountHeader = new Label();
            btnNavTreatment = new Panel();
            btnNavAppointments = new Panel();
            btnNavMeds = new Panel();
            btnNavDashboard = new Panel();
            lblMenuHeader = new Label();
            pnlNavDivider = new Panel();
            pnlLogoArea = new Panel();
            picLogo = new PictureBox();
            lblNavDashIcon = new Label();
            lblNavDashText = new Label();
            lblNavMedsIcon = new Label();
            lblNavMedsText = new Label();
            lblNavApptIcon = new Label();
            lblNavApptText = new Label();
            lblNavTreatmentIcon = new Label();
            lblNavTreatmentText = new Label();
            lblNavProfileIcon = new Label();
            lblNavProfileText = new Label();
            pnlTopBar = new Panel();
            lblWelcome = new Label();
            lblPageTitle = new Label();
            panelContainer = new Panel();
            pnlSidebar.SuspendLayout();
            pnlSidebarBottom.SuspendLayout();
            pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(238, 243, 247);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(btnNavProfile);
            pnlSidebar.Controls.Add(lblAccountHeader);
            pnlSidebar.Controls.Add(btnNavTreatment);
            pnlSidebar.Controls.Add(btnNavAppointments);
            pnlSidebar.Controls.Add(btnNavMeds);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(lblMenuHeader);
            pnlSidebar.Controls.Add(pnlNavDivider);
            pnlSidebar.Controls.Add(pnlLogoArea);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 900);
            pnlSidebar.TabIndex = 2;
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
            lblSidebarFooter.Text = "RecoverEase Healthcare Platform";
            lblSidebarFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLogout.Location = new Point(16, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(188, 26);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "⇠  Sign Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNavProfile
            // 
            btnNavProfile.Location = new Point(0, 0);
            btnNavProfile.Name = "btnNavProfile";
            btnNavProfile.Size = new Size(200, 100);
            btnNavProfile.TabIndex = 1;
            // 
            // lblAccountHeader
            // 
            lblAccountHeader.Location = new Point(0, 0);
            lblAccountHeader.Name = "lblAccountHeader";
            lblAccountHeader.Size = new Size(100, 23);
            lblAccountHeader.TabIndex = 2;
            // 
            // btnNavTreatment
            // 
            btnNavTreatment.Location = new Point(0, 0);
            btnNavTreatment.Name = "btnNavTreatment";
            btnNavTreatment.Size = new Size(200, 100);
            btnNavTreatment.TabIndex = 3;
            // 
            // btnNavAppointments
            // 
            btnNavAppointments.Location = new Point(0, 0);
            btnNavAppointments.Name = "btnNavAppointments";
            btnNavAppointments.Size = new Size(200, 100);
            btnNavAppointments.TabIndex = 4;
            // 
            // btnNavMeds
            // 
            btnNavMeds.Location = new Point(0, 0);
            btnNavMeds.Name = "btnNavMeds";
            btnNavMeds.Size = new Size(200, 100);
            btnNavMeds.TabIndex = 5;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Location = new Point(0, 0);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(200, 100);
            btnNavDashboard.TabIndex = 6;
            // 
            // lblMenuHeader
            // 
            lblMenuHeader.Location = new Point(0, 0);
            lblMenuHeader.Name = "lblMenuHeader";
            lblMenuHeader.Size = new Size(100, 23);
            lblMenuHeader.TabIndex = 7;
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
            // lblNavDashIcon
            // 
            lblNavDashIcon.Location = new Point(0, 0);
            lblNavDashIcon.Name = "lblNavDashIcon";
            lblNavDashIcon.Size = new Size(100, 23);
            lblNavDashIcon.TabIndex = 0;
            // 
            // lblNavDashText
            // 
            lblNavDashText.Location = new Point(0, 0);
            lblNavDashText.Name = "lblNavDashText";
            lblNavDashText.Size = new Size(100, 23);
            lblNavDashText.TabIndex = 0;
            // 
            // lblNavMedsIcon
            // 
            lblNavMedsIcon.Location = new Point(0, 0);
            lblNavMedsIcon.Name = "lblNavMedsIcon";
            lblNavMedsIcon.Size = new Size(100, 23);
            lblNavMedsIcon.TabIndex = 0;
            // 
            // lblNavMedsText
            // 
            lblNavMedsText.Location = new Point(0, 0);
            lblNavMedsText.Name = "lblNavMedsText";
            lblNavMedsText.Size = new Size(100, 23);
            lblNavMedsText.TabIndex = 0;
            // 
            // lblNavApptIcon
            // 
            lblNavApptIcon.Location = new Point(0, 0);
            lblNavApptIcon.Name = "lblNavApptIcon";
            lblNavApptIcon.Size = new Size(100, 23);
            lblNavApptIcon.TabIndex = 0;
            // 
            // lblNavApptText
            // 
            lblNavApptText.Location = new Point(0, 0);
            lblNavApptText.Name = "lblNavApptText";
            lblNavApptText.Size = new Size(100, 23);
            lblNavApptText.TabIndex = 0;
            // 
            // lblNavTreatmentIcon
            // 
            lblNavTreatmentIcon.Location = new Point(0, 0);
            lblNavTreatmentIcon.Name = "lblNavTreatmentIcon";
            lblNavTreatmentIcon.Size = new Size(100, 23);
            lblNavTreatmentIcon.TabIndex = 0;
            // 
            // lblNavTreatmentText
            // 
            lblNavTreatmentText.Location = new Point(0, 0);
            lblNavTreatmentText.Name = "lblNavTreatmentText";
            lblNavTreatmentText.Size = new Size(100, 23);
            lblNavTreatmentText.TabIndex = 0;
            // 
            // lblNavProfileIcon
            // 
            lblNavProfileIcon.Location = new Point(0, 0);
            lblNavProfileIcon.Name = "lblNavProfileIcon";
            lblNavProfileIcon.Size = new Size(100, 23);
            lblNavProfileIcon.TabIndex = 0;
            // 
            // lblNavProfileText
            // 
            lblNavProfileText.Location = new Point(0, 0);
            lblNavProfileText.Name = "lblNavProfileText";
            lblNavProfileText.Size = new Size(100, 23);
            lblNavProfileText.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblWelcome);
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(260, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1340, 90);
            pnlTopBar.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.FromArgb(113, 128, 150);
            lblWelcome.Location = new Point(24, 55);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(120, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(27, 58, 107);
            lblPageTitle.Location = new Point(24, 9);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(171, 41);
            lblPageTitle.TabIndex = 1;
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
            // PatientMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panelContainer);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            DoubleBuffered = true;
            Name = "PatientMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecoverEase - Patient Portal";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebarBottom.ResumeLayout(false);
            pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
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
        private System.Windows.Forms.Panel btnNavMeds;
        private System.Windows.Forms.Label lblNavMedsIcon;
        private System.Windows.Forms.Label lblNavMedsText;
        private System.Windows.Forms.Panel btnNavAppointments;
        private System.Windows.Forms.Label lblNavApptIcon;
        private System.Windows.Forms.Label lblNavApptText;
        private System.Windows.Forms.Panel btnNavTreatment;
        private System.Windows.Forms.Label lblNavTreatmentIcon;
        private System.Windows.Forms.Label lblNavTreatmentText;
        private System.Windows.Forms.Panel btnNavProfile;
        private System.Windows.Forms.Label lblNavProfileIcon;
        private System.Windows.Forms.Label lblNavProfileText;
        private System.Windows.Forms.Panel pnlSidebarBottom;
        private System.Windows.Forms.Label lblSidebarFooter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelContainer;
        private Label lblAccountHeader;
        private Label lblMenuHeader;
    }
}
