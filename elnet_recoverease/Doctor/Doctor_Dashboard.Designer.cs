namespace elnet_recoverease.Doctor
{
    partial class Doctor_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Controls ──────────────────────────────────────────────
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

            // ── Main Layout ──────────────────────────────────────────────
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlNotifBell = new System.Windows.Forms.Panel();
            this.lblBellIcon = new System.Windows.Forms.Label();
            this.lblNotifBadge = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();

            this.pnlContent = new System.Windows.Forms.Panel();

            // ── Stat Cards ────────────────────────────────────────────
            this.cardPatients = new System.Windows.Forms.Panel();
            this.lblCardPatTitle = new System.Windows.Forms.Label();
            this.lblCardPatValue = new System.Windows.Forms.Label();
            this.lblCardPatIcon = new System.Windows.Forms.Label();
            this.lblCardPatSub = new System.Windows.Forms.Label();

            this.cardAppt = new System.Windows.Forms.Panel();
            this.lblCardApptTitle = new System.Windows.Forms.Label();
            this.lblCardApptValue = new System.Windows.Forms.Label();
            this.lblCardApptIcon = new System.Windows.Forms.Label();
            this.lblCardApptSub = new System.Windows.Forms.Label();

            this.cardPending = new System.Windows.Forms.Panel();
            this.lblCardPendTitle = new System.Windows.Forms.Label();
            this.lblCardPendValue = new System.Windows.Forms.Label();
            this.lblCardPendIcon = new System.Windows.Forms.Label();
            this.lblCardPendSub = new System.Windows.Forms.Label();

            this.cardAlerts = new System.Windows.Forms.Panel();
            this.lblCardAlertTitle = new System.Windows.Forms.Label();
            this.lblCardAlertValue = new System.Windows.Forms.Label();
            this.lblCardAlertIcon = new System.Windows.Forms.Label();
            this.lblCardAlertSub = new System.Windows.Forms.Label();

            // ── Bottom panels ─────────────────────────────────────────
            this.pnlSchedulePanel = new System.Windows.Forms.Panel();
            this.lblScheduleTitle = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlAlertsPanel = new System.Windows.Forms.Panel();
            this.lblAlertsTitle = new System.Windows.Forms.Label();
            this.pnlAlert1 = new System.Windows.Forms.Panel();
            this.lblAlert1Icon = new System.Windows.Forms.Label();
            this.lblAlert1Text = new System.Windows.Forms.Label();
            this.lblAlert1Time = new System.Windows.Forms.Label();
            this.pnlAlert2 = new System.Windows.Forms.Panel();
            this.lblAlert2Icon = new System.Windows.Forms.Label();
            this.lblAlert2Text = new System.Windows.Forms.Label();
            this.lblAlert2Time = new System.Windows.Forms.Label();
            this.pnlAlert3 = new System.Windows.Forms.Panel();
            this.lblAlert3Icon = new System.Windows.Forms.Label();
            this.lblAlert3Text = new System.Windows.Forms.Label();
            this.lblAlert3Time = new System.Windows.Forms.Label();

            // ─────────────────────────────────────────────────────────
            // Suspend layout
            // ─────────────────────────────────────────────────────────
            this.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlSchedulePanel.SuspendLayout();
            this.pnlAlertsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            
            this.btnNavDashboard.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavAppointments.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.btnNavProfile.SuspendLayout();

            this.cardPatients.SuspendLayout();
            this.cardAppt.SuspendLayout();
            this.cardPending.SuspendLayout();
            this.cardAlerts.SuspendLayout();

            // ══════════════════════════════════════════════════════════
            // COLORS  (RecoverEase brand palette)
            // ══════════════════════════════════════════════════════════
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyLight = System.Drawing.ColorTranslator.FromHtml("#D0DBE8");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrSidebarText = System.Drawing.ColorTranslator.FromHtml("#444444");
            System.Drawing.Color clrTextDark = System.Drawing.Color.FromArgb(30, 43, 60);
            System.Drawing.Color clrTextMid = System.Drawing.Color.FromArgb(100, 120, 145);
            System.Drawing.Color clrGreen = System.Drawing.Color.FromArgb(39, 174, 96);
            System.Drawing.Color clrOrange = System.Drawing.Color.FromArgb(230, 126, 34);
            System.Drawing.Color clrRed = System.Drawing.Color.FromArgb(192, 57, 43);

            // ══════════════════════════════════════════════════════════
            // FORM
            // ══════════════════════════════════════════════════════════
            this.Text = "RecoverEase — Doctor Dashboard";
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = clrBg;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // ══════════════════════════════════════════════════════════
            // SIDEBAR
            // ══════════════════════════════════════════════════════════
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 260;
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(0);

            // Logo area
            this.pnlLogoArea.BackColor = clrNavy;
            this.pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoArea.Height = 90;
            this.pnlLogoArea.Padding = new System.Windows.Forms.Padding(16, 18, 8, 8);

            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlLogoArea.Controls.Add(this.picLogo);

            // Divider
            this.pnlNavDivider.BackColor = System.Drawing.ColorTranslator.FromHtml("#D0DBE8");
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Height = 1;

            // ── Dashboard
            this.btnNavDashboard.Size = new System.Drawing.Size(260, 48);
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.BackColor = clrNavyActive;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            var acc_dash = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.lblNavDashIcon.Text = "\u229E";
            this.lblNavDashIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavDashIcon.ForeColor = clrWhite;
            this.lblNavDashIcon.AutoSize = true;
            this.lblNavDashIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavDashText.Text = "Dashboard";
            this.lblNavDashText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavDashText.ForeColor = clrWhite;
            this.lblNavDashText.AutoSize = true;
            this.lblNavDashText.Location = new System.Drawing.Point(64, 13);
            this.btnNavDashboard.Controls.Add(acc_dash);
            this.btnNavDashboard.Controls.Add(this.lblNavDashIcon);
            this.btnNavDashboard.Controls.Add(this.lblNavDashText);

            // ── Patients
            this.btnNavPatients.Size = new System.Drawing.Size(260, 48);
            this.btnNavPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPatients.BackColor = clrNavy;
            this.btnNavPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavPatientsIcon.Text = "\U0001F465"; // Two people icon
            this.lblNavPatientsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavPatientsIcon.AutoSize = true;
            this.lblNavPatientsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavPatientsText.Text = "My Patients";
            this.lblNavPatientsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavPatientsText.AutoSize = true;
            this.lblNavPatientsText.Location = new System.Drawing.Point(64, 13);
            this.btnNavPatients.Controls.Add(this.lblNavPatientsIcon);
            this.btnNavPatients.Controls.Add(this.lblNavPatientsText);

            // ── Appointments
            this.btnNavAppointments.Size = new System.Drawing.Size(260, 48);
            this.btnNavAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAppointments.BackColor = clrNavy;
            this.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavApptIcon.Text = "\U0001F4C5";
            this.lblNavApptIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavApptIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavApptIcon.AutoSize = true;
            this.lblNavApptIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavApptText.Text = "Appointments";
            this.lblNavApptText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavApptText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavApptText.AutoSize = true;
            this.lblNavApptText.Location = new System.Drawing.Point(64, 13);
            this.btnNavAppointments.Controls.Add(this.lblNavApptIcon);
            this.btnNavAppointments.Controls.Add(this.lblNavApptText);

            // ── Reports
            this.btnNavReports.Size = new System.Drawing.Size(260, 48);
            this.btnNavReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavReports.BackColor = clrNavy;
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavReportsIcon.Text = "\U0001F4C4";
            this.lblNavReportsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavReportsIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavReportsIcon.AutoSize = true;
            this.lblNavReportsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavReportsText.Text = "Reports & Analytics";
            this.lblNavReportsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavReportsText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavReportsText.AutoSize = true;
            this.lblNavReportsText.Location = new System.Drawing.Point(64, 13);
            this.btnNavReports.Controls.Add(this.lblNavReportsIcon);
            this.btnNavReports.Controls.Add(this.lblNavReportsText);

            // ── Profile
            this.btnNavProfile.Size = new System.Drawing.Size(260, 48);
            this.btnNavProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProfile.BackColor = clrNavy;
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavProfileIcon.Text = "\U0001F464";
            this.lblNavProfileIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavProfileIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavProfileIcon.AutoSize = true;
            this.lblNavProfileIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavProfileText.Text = "My Profile";
            this.lblNavProfileText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavProfileText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavProfileText.AutoSize = true;
            this.lblNavProfileText.Location = new System.Drawing.Point(64, 13);
            this.btnNavProfile.Controls.Add(this.lblNavProfileIcon);
            this.btnNavProfile.Controls.Add(this.lblNavProfileText);

            // Sidebar bottom
            this.pnlSidebarBottom.BackColor = clrNavy;
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Height = 70;
            this.pnlSidebarBottom.Padding = new System.Windows.Forms.Padding(20, 12, 16, 12);

            this.lblSidebarFooter.Text = "Secure Healthcare Platform";
            this.lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblSidebarFooter.ForeColor = clrTextMid;
            this.lblSidebarFooter.AutoSize = true;
            this.lblSidebarFooter.Location = new System.Drawing.Point(20, 10);

            this.btnLogout.Text = "⇠  Sign Out";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = clrSidebarText;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = clrNavyLight;
            this.btnLogout.Size = new System.Drawing.Size(188, 26);
            this.btnLogout.Location = new System.Drawing.Point(16, 32);
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlSidebarBottom.Controls.Add(this.lblSidebarFooter);
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);

            // Add in reverse order of display from bottom-to-top so they dock correctly
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);

            // ══════════════════════════════════════════════════════════
            // MAIN AREA
            // ══════════════════════════════════════════════════════════
            this.pnlMain.BackColor = clrBg;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;

            // ── Top Bar ───────────────────────────────────────────────
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 96;
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);

            var pnlTopBarBorder = new System.Windows.Forms.Panel();
            pnlTopBarBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlTopBarBorder.Height = 1;
            pnlTopBarBorder.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E8F0");
            this.pnlTopBar.Controls.Add(pnlTopBarBorder);

            this.lblPageTitle.Text = "Doctor Dashboard";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 16);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.lblWelcome.Text = "Welcome back. Here's your clinical overview for today.";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblWelcome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(28, 58);
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            // Notification bell
            this.pnlNotifBell.Size = new System.Drawing.Size(38, 38);
            this.pnlNotifBell.BackColor = clrBg;
            this.pnlNotifBell.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlNotifBell.Location = new System.Drawing.Point(880, 13);
            this.pnlNotifBell.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblBellIcon.Text = "🔔";
            this.lblBellIcon.Font = new System.Drawing.Font("Segoe UI", 16f);
            this.lblBellIcon.AutoSize = true;
            this.lblBellIcon.Location = new System.Drawing.Point(2, 2);
            this.lblBellIcon.ForeColor = clrTextMid;

            this.lblNotifBadge.Text = "2";
            this.lblNotifBadge.Font = new System.Drawing.Font("Segoe UI", 6f, System.Drawing.FontStyle.Bold);
            this.lblNotifBadge.ForeColor = clrWhite;
            this.lblNotifBadge.BackColor = clrRed;
            this.lblNotifBadge.Size = new System.Drawing.Size(14, 14);
            this.lblNotifBadge.Location = new System.Drawing.Point(22, 2);
            this.lblNotifBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlNotifBell.Controls.Add(this.lblBellIcon);
            this.pnlNotifBell.Controls.Add(this.lblNotifBadge);

            // Avatar
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlAvatarTop.Location = new System.Drawing.Point(928, 12);
            this.pnlAvatarTop.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblAvatarInitials.Text = "Dr";
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);

            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Controls.Add(this.lblWelcome);
            this.pnlTopBar.Controls.Add(this.pnlNotifBell);
            this.pnlTopBar.Controls.Add(this.pnlAvatarTop);

            // ── Content area ──────────────────────────────────────────
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlContent.AutoScroll = true;

            // ══════════════════════════════════════════════════════════
            // STAT CARDS
            // ══════════════════════════════════════════════════════════
            int cardH = 140; int cardGap = 20;

            var tlpCards = new System.Windows.Forms.TableLayoutPanel();
            tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            tlpCards.Height = cardH;
            tlpCards.ColumnCount = 4;
            tlpCards.RowCount = 1;
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            // Card 1
            this.cardPatients.BackColor = clrWhite;
            this.cardPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPatients.Margin = new System.Windows.Forms.Padding(0, 0, cardGap, 0);
            var acc1 = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardPatTitle.Text = "TOTAL PATIENTS";
            this.lblCardPatTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardPatTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardPatTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardPatTitle.AutoSize = true;
            this.lblCardPatValue.Text = "--";
            this.lblCardPatValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardPatValue.ForeColor = clrTeal;
            this.lblCardPatValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardPatValue.AutoSize = true;
            this.lblCardPatIcon.Text = "👥";
            this.lblCardPatIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardPatIcon.ForeColor = System.Drawing.Color.FromArgb(180, clrTeal.R, clrTeal.G, clrTeal.B);
            this.lblCardPatIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardPatIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardPatIcon.AutoSize = true;
            this.lblCardPatSub.Text = "Active under care";
            this.lblCardPatSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardPatSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardPatSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardPatSub.AutoSize = true;
            this.cardPatients.Controls.Add(acc1);
            this.cardPatients.Controls.Add(this.lblCardPatTitle);
            this.cardPatients.Controls.Add(this.lblCardPatValue);
            this.cardPatients.Controls.Add(this.lblCardPatIcon);
            this.cardPatients.Controls.Add(this.lblCardPatSub);

            // Card 2
            this.cardAppt.BackColor = clrWhite;
            this.cardAppt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAppt.Margin = new System.Windows.Forms.Padding(0, 0, cardGap, 0);
            var colNav = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            var acc2 = new System.Windows.Forms.Panel { BackColor = colNav, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardApptTitle.Text = "APPOINTMENTS TODAY";
            this.lblCardApptTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardApptTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardApptTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardApptTitle.AutoSize = true;
            this.lblCardApptValue.Text = "--";
            this.lblCardApptValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardApptValue.ForeColor = colNav;
            this.lblCardApptValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardApptValue.AutoSize = true;
            this.lblCardApptIcon.Text = "📅";
            this.lblCardApptIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardApptIcon.ForeColor = System.Drawing.Color.FromArgb(180, colNav.R, colNav.G, colNav.B);
            this.lblCardApptIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardApptIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardApptIcon.AutoSize = true;
            this.lblCardApptSub.Text = "3 remaining";
            this.lblCardApptSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardApptSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardApptSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardApptSub.AutoSize = true;
            this.cardAppt.Controls.Add(acc2);
            this.cardAppt.Controls.Add(this.lblCardApptTitle);
            this.cardAppt.Controls.Add(this.lblCardApptValue);
            this.cardAppt.Controls.Add(this.lblCardApptIcon);
            this.cardAppt.Controls.Add(this.lblCardApptSub);

            // Card 3
            this.cardPending.BackColor = clrWhite;
            this.cardPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPending.Margin = new System.Windows.Forms.Padding(0, 0, cardGap, 0);
            var acc3 = new System.Windows.Forms.Panel { BackColor = clrGreen, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardPendTitle.Text = "PENDING REPORTS";
            this.lblCardPendTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardPendTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardPendTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardPendTitle.AutoSize = true;
            this.lblCardPendValue.Text = "--";
            this.lblCardPendValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardPendValue.ForeColor = clrGreen;
            this.lblCardPendValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardPendValue.AutoSize = true;
            this.lblCardPendIcon.Text = "📋";
            this.lblCardPendIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardPendIcon.ForeColor = System.Drawing.Color.FromArgb(180, clrGreen.R, clrGreen.G, clrGreen.B);
            this.lblCardPendIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardPendIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardPendIcon.AutoSize = true;
            this.lblCardPendSub.Text = "Needs review";
            this.lblCardPendSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardPendSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardPendSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardPendSub.AutoSize = true;
            this.cardPending.Controls.Add(acc3);
            this.cardPending.Controls.Add(this.lblCardPendTitle);
            this.cardPending.Controls.Add(this.lblCardPendValue);
            this.cardPending.Controls.Add(this.lblCardPendIcon);
            this.cardPending.Controls.Add(this.lblCardPendSub);

            // Card 4
            this.cardAlerts.BackColor = clrWhite;
            this.cardAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAlerts.Margin = new System.Windows.Forms.Padding(0);
            var acc4 = new System.Windows.Forms.Panel { BackColor = clrOrange, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardAlertTitle.Text = "CLINICAL ALERTS";
            this.lblCardAlertTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardAlertTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardAlertTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardAlertTitle.AutoSize = true;
            this.lblCardAlertValue.Text = "--";
            this.lblCardAlertValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardAlertValue.ForeColor = clrOrange;
            this.lblCardAlertValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardAlertValue.AutoSize = true;
            this.lblCardAlertIcon.Text = "⚠";
            this.lblCardAlertIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardAlertIcon.ForeColor = System.Drawing.Color.FromArgb(180, clrOrange.R, clrOrange.G, clrOrange.B);
            this.lblCardAlertIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardAlertIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardAlertIcon.AutoSize = true;
            this.lblCardAlertSub.Text = "Requires attention";
            this.lblCardAlertSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardAlertSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardAlertSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardAlertSub.AutoSize = true;
            this.cardAlerts.Controls.Add(acc4);
            this.cardAlerts.Controls.Add(this.lblCardAlertTitle);
            this.cardAlerts.Controls.Add(this.lblCardAlertValue);
            this.cardAlerts.Controls.Add(this.lblCardAlertIcon);
            this.cardAlerts.Controls.Add(this.lblCardAlertSub);

            tlpCards.Controls.Add(this.cardPatients, 0, 0);
            tlpCards.Controls.Add(this.cardAppt, 1, 0);
            tlpCards.Controls.Add(this.cardPending, 2, 0);
            tlpCards.Controls.Add(this.cardAlerts, 3, 0);

            // ══════════════════════════════════════════════════════════
            // SCHEDULE TABLE
            // ══════════════════════════════════════════════════════════
            this.pnlSchedulePanel.BackColor = clrWhite;
            this.pnlSchedulePanel.Padding = new System.Windows.Forms.Padding(16, 46, 16, 16);

            this.lblScheduleTitle.Text = "Today's Appointments";
            this.lblScheduleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblScheduleTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            this.lblScheduleTitle.AutoSize = true;
            this.lblScheduleTitle.Location = new System.Drawing.Point(16, 14);

            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.BackgroundColor = clrWhite;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.GridColor = System.Drawing.ColorTranslator.FromHtml("#E2E8F0");
            this.dgvSchedule.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dgvSchedule.RowTemplate.Height = 44;

            this.dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F8FAFC");
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.dgvSchedule.ColumnHeadersHeight = 40;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#F8FAFC");
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 245, 245);
            this.dgvSchedule.DefaultCellStyle.SelectionForeColor = clrTextDark;

            this.colTime.HeaderText = "TIME"; this.colTime.FillWeight = 20;
            this.colPatient.HeaderText = "PATIENT"; this.colPatient.FillWeight = 35;
            this.colReason.HeaderText = "REASON"; this.colReason.FillWeight = 25;
            this.colStatus.HeaderText = "STATUS"; this.colStatus.FillWeight = 20;

            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTime, this.colPatient, this.colReason, this.colStatus
            });
            
            this.pnlSchedulePanel.Controls.Add(this.lblScheduleTitle);
            this.pnlSchedulePanel.Controls.Add(this.dgvSchedule);

            // ══════════════════════════════════════════════════════════
            // ALERTS PANEL
            // ══════════════════════════════════════════════════════════
            this.pnlAlertsPanel.BackColor = clrWhite;

            this.lblAlertsTitle.Text = "Recent Alerts";
            this.lblAlertsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblAlertsTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            this.lblAlertsTitle.AutoSize = true;
            this.lblAlertsTitle.Location = new System.Drawing.Point(14, 14);

            this.pnlAlertsPanel.Controls.Add(this.lblAlertsTitle);

            // Alert 1
            this.pnlAlert1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlert1.Height = 70;
            this.pnlAlert1.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.lblAlert1Icon.Text = "🔴";
            this.lblAlert1Icon.Font = new System.Drawing.Font("Segoe UI", 12f);
            this.lblAlert1Icon.Location = new System.Drawing.Point(16, 20);
            this.lblAlert1Icon.AutoSize = true;
            this.lblAlert1Text.Text = "--";
            this.lblAlert1Text.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblAlert1Text.ForeColor = clrTextDark;
            this.lblAlert1Text.Location = new System.Drawing.Point(50, 10);
            this.lblAlert1Text.Size = new System.Drawing.Size(250, 40);
            this.lblAlert1Text.AutoEllipsis = true;
            this.lblAlert1Time.Text = "";
            this.lblAlert1Time.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblAlert1Time.ForeColor = clrTextMid;
            this.lblAlert1Time.Location = new System.Drawing.Point(52, 50);
            this.lblAlert1Time.AutoSize = true;
            this.pnlAlert1.Controls.Add(this.lblAlert1Icon);
            this.pnlAlert1.Controls.Add(this.lblAlert1Text);
            this.pnlAlert1.Controls.Add(this.lblAlert1Time);
            
            // Alert 2
            this.pnlAlert2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlert2.Height = 70;
            this.pnlAlert2.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.lblAlert2Icon.Text = "🟡";
            this.lblAlert2Icon.Font = new System.Drawing.Font("Segoe UI", 12f);
            this.lblAlert2Icon.Location = new System.Drawing.Point(16, 20);
            this.lblAlert2Icon.AutoSize = true;
            this.lblAlert2Text.Text = "--";
            this.lblAlert2Text.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblAlert2Text.ForeColor = clrTextDark;
            this.lblAlert2Text.Location = new System.Drawing.Point(50, 10);
            this.lblAlert2Text.Size = new System.Drawing.Size(250, 40);
            this.lblAlert2Text.AutoEllipsis = true;
            this.lblAlert2Time.Text = "";
            this.lblAlert2Time.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblAlert2Time.ForeColor = clrTextMid;
            this.lblAlert2Time.Location = new System.Drawing.Point(52, 50);
            this.lblAlert2Time.AutoSize = true;
            this.pnlAlert2.Controls.Add(this.lblAlert2Icon);
            this.pnlAlert2.Controls.Add(this.lblAlert2Text);
            this.pnlAlert2.Controls.Add(this.lblAlert2Time);

            // Alert 3
            this.pnlAlert3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlert3.Height = 70;
            this.pnlAlert3.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.lblAlert3Icon.Text = "🔵";
            this.lblAlert3Icon.Font = new System.Drawing.Font("Segoe UI", 12f);
            this.lblAlert3Icon.Location = new System.Drawing.Point(16, 20);
            this.lblAlert3Icon.AutoSize = true;
            this.lblAlert3Text.Text = "--";
            this.lblAlert3Text.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblAlert3Text.ForeColor = clrTextDark;
            this.lblAlert3Text.Location = new System.Drawing.Point(50, 10);
            this.lblAlert3Text.Size = new System.Drawing.Size(250, 40);
            this.lblAlert3Text.AutoEllipsis = true;
            this.lblAlert3Time.Text = "";
            this.lblAlert3Time.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblAlert3Time.ForeColor = clrTextMid;
            this.lblAlert3Time.Location = new System.Drawing.Point(52, 50);
            this.lblAlert3Time.AutoSize = true;
            this.pnlAlert3.Controls.Add(this.lblAlert3Icon);
            this.pnlAlert3.Controls.Add(this.lblAlert3Text);
            this.pnlAlert3.Controls.Add(this.lblAlert3Time);
            
            var pnlAlertsSpacer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 50 };

            this.pnlAlertsPanel.Controls.Add(this.pnlAlert3);
            this.pnlAlertsPanel.Controls.Add(this.pnlAlert2);
            this.pnlAlertsPanel.Controls.Add(this.pnlAlert1);
            this.pnlAlertsPanel.Controls.Add(pnlAlertsSpacer);

            // Bottom layouts
            var tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpBottom.ColumnCount = 2;
            tlpBottom.RowCount = 1;
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));

            tlpBottom.Controls.Add(this.pnlSchedulePanel, 0, 0);
            this.pnlSchedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSchedulePanel.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);

            tlpBottom.Controls.Add(this.pnlAlertsPanel, 1, 0);
            this.pnlAlertsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlertsPanel.Margin = new System.Windows.Forms.Padding(0);

            var pnlSpacer = new System.Windows.Forms.Panel();
            pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSpacer.Height = 24;

            // ── Assemble content
            this.pnlContent.Controls.Add(tlpCards);
            this.pnlContent.Controls.Add(pnlSpacer);
            this.pnlContent.Controls.Add(tlpBottom);

            pnlSpacer.SendToBack();
            tlpCards.SendToBack();
            tlpBottom.BringToFront();

            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlTopBar.SendToBack();
            this.pnlContent.BringToFront();

            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);

            // Resume layouts
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlSchedulePanel.ResumeLayout(false);
            this.pnlSchedulePanel.PerformLayout();
            this.pnlAlertsPanel.ResumeLayout(false);
            this.pnlAlertsPanel.PerformLayout();
            this.pnlAlert1.ResumeLayout(false);
            this.pnlAlert1.PerformLayout();
            this.pnlAlert2.ResumeLayout(false);
            this.pnlAlert2.PerformLayout();
            this.pnlAlert3.ResumeLayout(false);
            this.pnlAlert3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavAppointments.ResumeLayout(false);
            this.btnNavReports.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            
            this.cardPatients.ResumeLayout(false);
            this.cardAppt.ResumeLayout(false);
            this.cardPending.ResumeLayout(false);
            this.cardAlerts.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────────
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogoArea;
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
        
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlNotifBell;
        private System.Windows.Forms.Label lblBellIcon;
        private System.Windows.Forms.Label lblNotifBadge;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Panel pnlContent;
        
        private System.Windows.Forms.Panel cardPatients;
        private System.Windows.Forms.Label lblCardPatTitle;
        private System.Windows.Forms.Label lblCardPatValue;
        private System.Windows.Forms.Label lblCardPatIcon;
        private System.Windows.Forms.Label lblCardPatSub;
        
        private System.Windows.Forms.Panel cardAppt;
        private System.Windows.Forms.Label lblCardApptTitle;
        private System.Windows.Forms.Label lblCardApptValue;
        private System.Windows.Forms.Label lblCardApptIcon;
        private System.Windows.Forms.Label lblCardApptSub;
        
        private System.Windows.Forms.Panel cardPending;
        private System.Windows.Forms.Label lblCardPendTitle;
        private System.Windows.Forms.Label lblCardPendValue;
        private System.Windows.Forms.Label lblCardPendIcon;
        private System.Windows.Forms.Label lblCardPendSub;
        
        private System.Windows.Forms.Panel cardAlerts;
        private System.Windows.Forms.Label lblCardAlertTitle;
        private System.Windows.Forms.Label lblCardAlertValue;
        private System.Windows.Forms.Label lblCardAlertIcon;
        private System.Windows.Forms.Label lblCardAlertSub;
        
        private System.Windows.Forms.Panel pnlSchedulePanel;
        private System.Windows.Forms.Label lblScheduleTitle;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        
        private System.Windows.Forms.Panel pnlAlertsPanel;
        private System.Windows.Forms.Label lblAlertsTitle;
        private System.Windows.Forms.Panel pnlAlert1;
        private System.Windows.Forms.Label lblAlert1Icon;
        private System.Windows.Forms.Label lblAlert1Text;
        private System.Windows.Forms.Label lblAlert1Time;
        private System.Windows.Forms.Panel pnlAlert2;
        private System.Windows.Forms.Label lblAlert2Icon;
        private System.Windows.Forms.Label lblAlert2Text;
        private System.Windows.Forms.Label lblAlert2Time;
        private System.Windows.Forms.Panel pnlAlert3;
        private System.Windows.Forms.Label lblAlert3Icon;
        private System.Windows.Forms.Label lblAlert3Text;
        private System.Windows.Forms.Label lblAlert3Time;
    }
}