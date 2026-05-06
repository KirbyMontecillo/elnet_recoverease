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
            this.pnlReportSelection = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.lblSelectReportTitle = new System.Windows.Forms.Label();
            this.lblFiltersTitle = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.wvPreview = new Microsoft.Web.WebView2.WinForms.WebView2();

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
            this.pnlFilters.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvPreview)).BeginInit();
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

            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(208, 219, 232);
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Location = new System.Drawing.Point(0, 90);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(260, 1);
            this.pnlNavDivider.TabIndex = 1;

            SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "\u229E", "Dashboard", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "👥", "My Patients", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavAppointments, this.lblNavApptIcon, this.lblNavApptText, "📅", "Appointments", false, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "Reports & Analytics", true, clrNavyActive, clrWhite);
            SetupNavItem(this.btnNavProfile, this.lblNavProfileIcon, this.lblNavProfileText, "👤", "My Profile", false, clrNavyActive, clrWhite);

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
            this.lblSidebarFooter.Text = "RecoverEase Doctor Portal";
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
            this.lblPageTitle.Text = "Analytical Workstation";

            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlAvatarTop.Location = new System.Drawing.Point(1270, 20);
            this.pnlAvatarTop.Name = "pnlAvatarTop";
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.TabIndex = 2;
            this.pnlAvatarTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Location = new System.Drawing.Point(0, 0);
            this.lblAvatarInitials.Name = "lblAvatarInitials";
            this.lblAvatarInitials.Size = new System.Drawing.Size(40, 40);
            this.lblAvatarInitials.Text = "DR";
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Controls.Add(this.pnlPreview);
            this.pnlContent.Controls.Add(this.pnlFilters);
            this.pnlContent.Controls.Add(this.pnlReportSelection);
            this.pnlContent.Controls.Add(this.lblSelectReportTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.Size = new System.Drawing.Size(1340, 820);
            this.pnlContent.TabIndex = 2;

            this.lblSelectReportTitle.Text = "SELECT ANALYTICAL CATEGORY";
            this.lblSelectReportTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectReportTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSelectReportTitle.Location = new System.Drawing.Point(30, 20);
            this.lblSelectReportTitle.AutoSize = true;

            this.pnlReportSelection.Location = new System.Drawing.Point(30, 50);
            this.pnlReportSelection.Size = new System.Drawing.Size(1280, 200);
            this.pnlReportSelection.BackColor = System.Drawing.Color.Transparent;
            this.pnlReportSelection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlReportSelection.ColumnCount = 4;
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.RowCount = 1;
            this.pnlReportSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            AddReportCard("Patient Adherence", "Analyze medication intake consistency.", "📈", System.Drawing.Color.FromArgb(236, 253, 245), System.Drawing.Color.FromArgb(5, 150, 105));
            AddReportCard("Missed Medication", "Audit failed medication intakes.", "⚠️", System.Drawing.Color.FromArgb(254, 242, 242), System.Drawing.Color.FromArgb(220, 38, 38));
            AddReportCard("Appointment Summary", "Review consultation history.", "📅", System.Drawing.Color.FromArgb(239, 246, 255), System.Drawing.Color.FromArgb(37, 99, 235));
            AddReportCard("Treatment Plan Progress", "Track recovery roadmaps.", "📋", System.Drawing.Color.FromArgb(255, 251, 235), System.Drawing.Color.FromArgb(217, 119, 6));

            this.pnlFilters.BackColor = clrWhite;
            this.pnlFilters.Location = new System.Drawing.Point(30, 270);
            this.pnlFilters.Size = new System.Drawing.Size(1280, 80);
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            System.Windows.Forms.Label lblFrom = new System.Windows.Forms.Label { Text = "Date from", Location = new System.Drawing.Point(24, 30), AutoSize = true };
            this.dtpFrom.Location = new System.Drawing.Point(24, 48);
            this.dtpFrom.Width = 180;

            System.Windows.Forms.Label lblTo = new System.Windows.Forms.Label { Text = "Date to", Location = new System.Drawing.Point(300, 30), AutoSize = true };
            this.dtpTo.Location = new System.Drawing.Point(300, 48);
            this.dtpTo.Width = 180;

            this.btnGenerateReport.Text = "🖨️ Generate Full Report";
            this.btnGenerateReport.BackColor = clrTeal;
            this.btnGenerateReport.ForeColor = clrWhite;
            this.btnGenerateReport.FlatStyle = FlatStyle.Flat;
            this.btnGenerateReport.Size = new System.Drawing.Size(220, 40);
            this.btnGenerateReport.Location = new System.Drawing.Point(1030, 25);
            this.btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);

            this.pnlFilters.Controls.AddRange(new System.Windows.Forms.Control[] { lblFrom, this.dtpFrom, lblTo, this.dtpTo, this.btnGenerateReport });

            this.pnlPreview.BackColor = clrWhite;
            this.pnlPreview.Location = new System.Drawing.Point(30, 370);
            this.pnlPreview.Size = new System.Drawing.Size(1280, 420);
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.wvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Controls.Add(this.wvPreview);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wvPreview)).EndInit();
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

        private int _cardCount = 0;
        private void AddReportCard(string title, string desc, string icon, System.Drawing.Color bgColor, System.Drawing.Color iconColor)
        {
            System.Windows.Forms.Panel card = new System.Windows.Forms.Panel {
                Size = new System.Drawing.Size(300, 160),
                BackColor = System.Drawing.Color.White,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Margin = new System.Windows.Forms.Padding(0, 0, 20, 20),
                Cursor = System.Windows.Forms.Cursors.Hand,
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            System.Windows.Forms.Label lblIcon = new System.Windows.Forms.Label { Text = icon, Font = new System.Drawing.Font("Segoe UI", 20F), BackColor = bgColor, ForeColor = iconColor, Size = new System.Drawing.Size(50, 50), Location = new System.Drawing.Point(15, 15), TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            System.Windows.Forms.Label lblTitle = new System.Windows.Forms.Label { Text = title, Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold), Location = new System.Drawing.Point(15, 75), AutoSize = true };
            System.Windows.Forms.Label lblDesc = new System.Windows.Forms.Label { Text = desc, Font = new System.Drawing.Font("Segoe UI", 8F), ForeColor = System.Drawing.Color.FromArgb(100, 116, 139), Location = new System.Drawing.Point(15, 100), Size = new System.Drawing.Size(260, 50) };
            card.Controls.AddRange(new System.Windows.Forms.Control[] { lblIcon, lblTitle, lblDesc });
            int col = _cardCount % 4;
            this.pnlReportSelection.Controls.Add(card, col, 0);
            _cardCount++;
            card.Tag = title;
            card.Click += (s, e) => SelectCard(card);
            foreach (System.Windows.Forms.Control child in card.Controls) child.Click += (s, e) => SelectCard(card);
        }

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
        private System.Windows.Forms.TableLayoutPanel pnlReportSelection;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblSelectReportTitle;
        private System.Windows.Forms.Label lblFiltersTitle;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerateReport;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvPreview;
    }
}
