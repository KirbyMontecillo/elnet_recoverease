namespace elnet_recoverease.Admin
{
    partial class Admin_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlMetrics = new System.Windows.Forms.TableLayoutPanel();
            this.cardMetrics1 = new System.Windows.Forms.Panel();
            this.lblMetricVal1 = new System.Windows.Forms.Label();
            this.lblMetricTitle1 = new System.Windows.Forms.Label();
            this.cardMetrics2 = new System.Windows.Forms.Panel();
            this.lblMetricVal2 = new System.Windows.Forms.Label();
            this.lblMetricTitle2 = new System.Windows.Forms.Label();
            this.cardMetrics3 = new System.Windows.Forms.Panel();
            this.lblMetricVal3 = new System.Windows.Forms.Label();
            this.lblMetricTitle3 = new System.Windows.Forms.Label();
            this.pnlLogSection = new System.Windows.Forms.Panel();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.colTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlMetrics.SuspendLayout();
            this.cardMetrics1.SuspendLayout();
            this.cardMetrics2.SuspendLayout();
            this.cardMetrics3.SuspendLayout();
            this.pnlLogSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
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
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "👥", "Global Patient List", false);
            SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", true);

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
            this.lblPageTitle.Text = "System Analytics & Reports";

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
            this.pnlContent.Controls.Add(this.pnlLogSection);
            this.pnlContent.Controls.Add(this.pnlMetrics);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(1340, 820);
            this.pnlContent.TabIndex = 2;

            // Metrics Grid
            this.pnlMetrics.ColumnCount = 3;
            this.pnlMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlMetrics.Controls.Add(this.cardMetrics1, 0, 0);
            this.pnlMetrics.Controls.Add(this.cardMetrics2, 1, 0);
            this.pnlMetrics.Controls.Add(this.cardMetrics3, 2, 0);
            this.pnlMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMetrics.Location = new System.Drawing.Point(24, 24);
            this.pnlMetrics.Name = "pnlMetrics";
            this.pnlMetrics.RowCount = 1;
            this.pnlMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMetrics.Size = new System.Drawing.Size(1292, 150);
            this.pnlMetrics.TabIndex = 0;

            void SetupMetricCard(System.Windows.Forms.Panel card, System.Windows.Forms.Label title, System.Windows.Forms.Label val, string sTitle, string sVal)
            {
                card.BackColor = clrWhite;
                card.Dock = System.Windows.Forms.DockStyle.Fill;
                card.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
                title.AutoSize = true;
                title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
                title.Location = new System.Drawing.Point(24, 24);
                title.Text = sTitle.ToUpper();
                val.AutoSize = true;
                val.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
                val.ForeColor = clrNavyActive;
                val.Location = new System.Drawing.Point(24, 55);
                val.Text = sVal;
                card.Controls.Add(title);
                card.Controls.Add(val);
            }

            SetupMetricCard(this.cardMetrics1, this.lblMetricTitle1, this.lblMetricVal1, "Total Active Users", "0");
            SetupMetricCard(this.cardMetrics2, this.lblMetricTitle2, this.lblMetricVal2, "Global Appointments", "0");
            SetupMetricCard(this.cardMetrics3, this.lblMetricTitle3, this.lblMetricVal3, "System Health Score", "100%");

            // Log Section
            this.pnlLogSection.BackColor = clrWhite;
            this.pnlLogSection.Controls.Add(this.dgvLogs);
            this.pnlLogSection.Controls.Add(this.lblLogTitle);
            this.pnlLogSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogSection.Location = new System.Drawing.Point(24, 194);
            this.pnlLogSection.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlLogSection.Name = "pnlLogSection";
            this.pnlLogSection.Padding = new System.Windows.Forms.Padding(24);
            this.pnlLogSection.Size = new System.Drawing.Size(1292, 602);
            this.pnlLogSection.TabIndex = 1;

            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogTitle.ForeColor = clrNavyActive;
            this.lblLogTitle.Location = new System.Drawing.Point(24, 24);
            this.lblLogTitle.Text = "Recent System Activity Logs";

            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.BackgroundColor = clrBg;
            this.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = clrNavy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = clrNavyActive;
            dataGridViewCellStyle1.SelectionBackColor = clrNavy;
            dataGridViewCellStyle1.SelectionForeColor = clrNavyActive;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.ColumnHeadersHeight = 50;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimestamp,
            this.colUser,
            this.colAction,
            this.colDetails});
            this.dgvLogs.EnableHeadersVisualStyles = false;
            this.dgvLogs.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvLogs.Location = new System.Drawing.Point(24, 75);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowTemplate.Height = 45;
            this.dgvLogs.Size = new System.Drawing.Size(1244, 503);
            this.dgvLogs.TabIndex = 1;

            // colTimestamp
            this.colTimestamp.HeaderText = "TIMESTAMP";
            this.colTimestamp.Name = "colTimestamp";
            this.colTimestamp.ReadOnly = true;
            this.colTimestamp.Width = 200;

            // colUser
            this.colUser.HeaderText = "USER";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.Width = 150;

            // colAction
            this.colAction.HeaderText = "ACTION";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Width = 200;

            // colDetails
            this.colDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetails.HeaderText = "ACTIVITY DETAILS";
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Admin_Report";
            this.Text = "RecoverEase - System Reports";
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
            this.pnlMetrics.ResumeLayout(false);
            this.cardMetrics1.ResumeLayout(false);
            this.cardMetrics1.PerformLayout();
            this.cardMetrics2.ResumeLayout(false);
            this.cardMetrics2.PerformLayout();
            this.cardMetrics3.ResumeLayout(false);
            this.cardMetrics3.PerformLayout();
            this.pnlLogSection.ResumeLayout(false);
            this.pnlLogSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel pnlMetrics;
        private System.Windows.Forms.Panel cardMetrics1;
        private System.Windows.Forms.Label lblMetricTitle1;
        private System.Windows.Forms.Label lblMetricVal1;
        private System.Windows.Forms.Panel cardMetrics2;
        private System.Windows.Forms.Label lblMetricTitle2;
        private System.Windows.Forms.Label lblMetricVal2;
        private System.Windows.Forms.Panel cardMetrics3;
        private System.Windows.Forms.Label lblMetricTitle3;
        private System.Windows.Forms.Label lblMetricVal3;
        private System.Windows.Forms.Panel pnlLogSection;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
    }
}