namespace elnet_recoverease.Doctor
{
    partial class Patient_Details
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlNotifBell = new System.Windows.Forms.Panel();
            this.lblBellIcon = new System.Windows.Forms.Label();
            this.lblNotifBadge = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();

            this.pnlContent = new System.Windows.Forms.Panel();

            // ── Profile Card ─────────────────────────────────────────
            this.pnlProfileCard = new System.Windows.Forms.Panel();
            this.pnlPatientAvatar = new System.Windows.Forms.Panel();
            this.lblPatientInitials = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.lblInfoAgeGen = new System.Windows.Forms.Label();
            this.lblInfoBlood = new System.Windows.Forms.Label();
            this.lblInfoContact = new System.Windows.Forms.Label();
            this.lblInfoAddress = new System.Windows.Forms.Label();
            this.lblInfoAgeGenVal = new System.Windows.Forms.Label();
            this.lblInfoBloodVal = new System.Windows.Forms.Label();
            this.lblInfoContactVal = new System.Windows.Forms.Label();
            this.lblInfoAddressVal = new System.Windows.Forms.Label();

            // ── Split View Bottom ─────────────────────────────────────
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftCol = new System.Windows.Forms.Panel();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.lblHistoryContent = new System.Windows.Forms.Label();
            this.pnlMeds = new System.Windows.Forms.Panel();
            this.lblMedsTitle = new System.Windows.Forms.Label();
            this.lblMedsContent = new System.Windows.Forms.Label();
            
            this.pnlRightCol = new System.Windows.Forms.Panel();
            this.pnlTreatment = new System.Windows.Forms.Panel();
            this.lblTreatmentTitle = new System.Windows.Forms.Label();
            this.lblTreatmentContent = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.lblActionsTitle = new System.Windows.Forms.Label();
            this.btnUpdatePlan = new System.Windows.Forms.Button();
            this.btnPrescribe = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();

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
            this.pnlProfileCard.SuspendLayout();
            this.pnlPatientAvatar.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.pnlLeftCol.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlMeds.SuspendLayout();
            this.pnlRightCol.SuspendLayout();
            this.pnlTreatment.SuspendLayout();
            this.pnlActions.SuspendLayout();
            
            this.btnNavDashboard.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavAppointments.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.btnNavProfile.SuspendLayout();

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

            // ══════════════════════════════════════════════════════════
            // FORM
            // ══════════════════════════════════════════════════════════
            this.Text = "RecoverEase — Patient Details";
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

            // ── Dashboard (Inactive)
            this.btnNavDashboard.Size = new System.Drawing.Size(260, 48);
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.BackColor = clrNavy;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavDashIcon.Text = "\u229E";
            this.lblNavDashIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavDashIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavDashIcon.AutoSize = true;
            this.lblNavDashIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavDashText.Text = "Dashboard";
            this.lblNavDashText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavDashText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavDashText.AutoSize = true;
            this.lblNavDashText.Location = new System.Drawing.Point(64, 13);
            this.btnNavDashboard.Controls.Add(this.lblNavDashIcon);
            this.btnNavDashboard.Controls.Add(this.lblNavDashText);

            // ── Patients (Active)
            this.btnNavPatients.Size = new System.Drawing.Size(260, 48);
            this.btnNavPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPatients.BackColor = clrNavyActive;
            this.btnNavPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            var acc_pat = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.lblNavPatientsIcon.Text = "\U0001F465"; 
            this.lblNavPatientsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsIcon.ForeColor = clrWhite;
            this.lblNavPatientsIcon.AutoSize = true;
            this.lblNavPatientsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavPatientsText.Text = "My Patients";
            this.lblNavPatientsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsText.ForeColor = clrWhite;
            this.lblNavPatientsText.AutoSize = true;
            this.lblNavPatientsText.Location = new System.Drawing.Point(64, 13);
            this.btnNavPatients.Controls.Add(acc_pat);
            this.btnNavPatients.Controls.Add(this.lblNavPatientsIcon);
            this.btnNavPatients.Controls.Add(this.lblNavPatientsText);

            // ── Appointments (Inactive)
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

            // ── Reports (Inactive)
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

            // ── Profile (Inactive)
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

            // Add in reverse order of display from bottom-to-top
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

            // Back button
            this.btnBack.Text = "← Back to Patient List";
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Regular);
            this.btnBack.ForeColor = clrTextMid;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Location = new System.Drawing.Point(24, 16);
            this.btnBack.Size = new System.Drawing.Size(200, 26);
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTopBar.Controls.Add(this.btnBack);

            this.lblPageTitle.Text = "Patient Profile";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 42);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            // Notification bell
            this.pnlNotifBell.Size = new System.Drawing.Size(38, 38);
            this.pnlNotifBell.BackColor = clrBg;
            this.pnlNotifBell.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlNotifBell.Location = new System.Drawing.Point(880, 28);
            this.pnlNotifBell.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblBellIcon.Text = "🔔";
            this.lblBellIcon.Font = new System.Drawing.Font("Segoe UI", 16f);
            this.lblBellIcon.AutoSize = true;
            this.lblBellIcon.Location = new System.Drawing.Point(2, 2);
            this.lblBellIcon.ForeColor = clrTextMid;

            this.lblNotifBadge.Text = "2";
            this.lblNotifBadge.Font = new System.Drawing.Font("Segoe UI", 6f, System.Drawing.FontStyle.Bold);
            this.lblNotifBadge.ForeColor = clrWhite;
            this.lblNotifBadge.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblNotifBadge.Size = new System.Drawing.Size(14, 14);
            this.lblNotifBadge.Location = new System.Drawing.Point(22, 2);
            this.lblNotifBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlNotifBell.Controls.Add(this.lblBellIcon);
            this.pnlNotifBell.Controls.Add(this.lblNotifBadge);

            // Avatar
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlAvatarTop.Location = new System.Drawing.Point(928, 27);
            this.pnlAvatarTop.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblAvatarInitials.Text = "Dr";
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);

            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Controls.Add(this.pnlNotifBell);
            this.pnlTopBar.Controls.Add(this.pnlAvatarTop);

            // ── Content area ──────────────────────────────────────────
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.AutoScroll = true;

            // ══════════════════════════════════════════════════════════
            // PROFILE CARD (TOP)
            // ══════════════════════════════════════════════════════════
            this.pnlProfileCard.BackColor = clrWhite;
            this.pnlProfileCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileCard.Height = 160;
            this.pnlProfileCard.Padding = new System.Windows.Forms.Padding(24);

            var accProfile = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.pnlProfileCard.Controls.Add(accProfile);

            // Avatar Area
            this.pnlPatientAvatar.Size = new System.Drawing.Size(100, 100);
            this.pnlPatientAvatar.Location = new System.Drawing.Point(24, 30);
            this.pnlPatientAvatar.BackColor = clrNavyLight;
            
            this.lblPatientInitials.Text = "--";
            this.lblPatientInitials.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblPatientInitials.ForeColor = clrNavyActive;
            this.lblPatientInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPatientInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlPatientAvatar.Controls.Add(this.lblPatientInitials);

            // Name & ID
            this.lblPatientName.Text = "--";
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 20f, System.Drawing.FontStyle.Bold);
            this.lblPatientName.ForeColor = clrTextDark;
            this.lblPatientName.Location = new System.Drawing.Point(144, 30);
            this.lblPatientName.AutoSize = true;

            this.lblPatientId.Text = "Patient ID: --";
            this.lblPatientId.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblPatientId.ForeColor = clrTextMid;
            this.lblPatientId.Location = new System.Drawing.Point(148, 70);
            this.lblPatientId.AutoSize = true;

            // Info grid layout using exact locations
            int infoStartX = 450;
            int infoGapY = 28;

            this.lblInfoAgeGen.Text = "Age / Gender:";
            this.lblInfoAgeGen.ForeColor = clrTextMid;
            this.lblInfoAgeGen.Location = new System.Drawing.Point(infoStartX, 35);
            this.lblInfoAgeGen.AutoSize = true;

            this.lblInfoAgeGenVal.Text = "-- / --";
            this.lblInfoAgeGenVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblInfoAgeGenVal.ForeColor = clrTextDark;
            this.lblInfoAgeGenVal.Location = new System.Drawing.Point(infoStartX + 100, 35);
            this.lblInfoAgeGenVal.AutoSize = true;

            this.lblInfoBlood.Text = "Blood Type:";
            this.lblInfoBlood.ForeColor = clrTextMid;
            this.lblInfoBlood.Location = new System.Drawing.Point(infoStartX, 35 + infoGapY);
            this.lblInfoBlood.AutoSize = true;

            this.lblInfoBloodVal.Text = "--";
            this.lblInfoBloodVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblInfoBloodVal.ForeColor = clrTextDark;
            this.lblInfoBloodVal.Location = new System.Drawing.Point(infoStartX + 100, 35 + infoGapY);
            this.lblInfoBloodVal.AutoSize = true;

            int infoStartX2 = infoStartX + 250;

            this.lblInfoContact.Text = "Contact:";
            this.lblInfoContact.ForeColor = clrTextMid;
            this.lblInfoContact.Location = new System.Drawing.Point(infoStartX2, 35);
            this.lblInfoContact.AutoSize = true;

            this.lblInfoContactVal.Text = "--";
            this.lblInfoContactVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblInfoContactVal.ForeColor = clrTextDark;
            this.lblInfoContactVal.Location = new System.Drawing.Point(infoStartX2 + 70, 35);
            this.lblInfoContactVal.AutoSize = true;

            this.lblInfoAddress.Text = "Address:";
            this.lblInfoAddress.ForeColor = clrTextMid;
            this.lblInfoAddress.Location = new System.Drawing.Point(infoStartX2, 35 + infoGapY);
            this.lblInfoAddress.AutoSize = true;

            this.lblInfoAddressVal.Text = "--";
            this.lblInfoAddressVal.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblInfoAddressVal.ForeColor = clrTextDark;
            this.lblInfoAddressVal.Location = new System.Drawing.Point(infoStartX2 + 70, 35 + infoGapY);
            this.lblInfoAddressVal.AutoSize = true;

            this.pnlProfileCard.Controls.Add(this.pnlPatientAvatar);
            this.pnlProfileCard.Controls.Add(this.lblPatientName);
            this.pnlProfileCard.Controls.Add(this.lblPatientId);
            this.pnlProfileCard.Controls.Add(this.lblInfoAgeGen);
            this.pnlProfileCard.Controls.Add(this.lblInfoAgeGenVal);
            this.pnlProfileCard.Controls.Add(this.lblInfoBlood);
            this.pnlProfileCard.Controls.Add(this.lblInfoBloodVal);
            this.pnlProfileCard.Controls.Add(this.lblInfoContact);
            this.pnlProfileCard.Controls.Add(this.lblInfoContactVal);
            this.pnlProfileCard.Controls.Add(this.lblInfoAddress);
            this.pnlProfileCard.Controls.Add(this.lblInfoAddressVal);

            // ══════════════════════════════════════════════════════════
            // SPLIT VIEW (BOTTOM)
            // ══════════════════════════════════════════════════════════
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.ColumnCount = 2;
            this.tlpDetails.RowCount = 1;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            // Left Column
            this.pnlLeftCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCol.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);

            // Medical History
            this.pnlHistory.BackColor = clrWhite;
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHistoryTitle.Text = "Medical History & Allergies";
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.ForeColor = clrNavyActive;
            this.lblHistoryTitle.Location = new System.Drawing.Point(16, 16);
            this.lblHistoryTitle.AutoSize = true;
            
            this.lblHistoryContent.Text = "No data available.";
            this.lblHistoryContent.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblHistoryContent.ForeColor = clrTextDark;
            this.lblHistoryContent.Location = new System.Drawing.Point(16, 50);
            this.lblHistoryContent.AutoSize = true;
            this.pnlHistory.Controls.Add(this.lblHistoryTitle);
            this.pnlHistory.Controls.Add(this.lblHistoryContent);

            // Current Medications
            this.pnlMeds.BackColor = clrWhite;
            this.pnlMeds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMeds.Height = 200;
            this.lblMedsTitle.Text = "Current Medications";
            this.lblMedsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblMedsTitle.ForeColor = clrNavyActive;
            this.lblMedsTitle.Location = new System.Drawing.Point(16, 16);
            this.lblMedsTitle.AutoSize = true;

            this.lblMedsContent.Text = "No active prescriptions.";
            this.lblMedsContent.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblMedsContent.ForeColor = clrTextMid;
            this.lblMedsContent.Location = new System.Drawing.Point(16, 50);
            this.lblMedsContent.AutoSize = true;
            this.pnlMeds.Controls.Add(this.lblMedsTitle);
            this.pnlMeds.Controls.Add(this.lblMedsContent);

            var spacerLeft = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 24 };
            this.pnlLeftCol.Controls.Add(this.pnlHistory);
            this.pnlLeftCol.Controls.Add(spacerLeft);
            this.pnlLeftCol.Controls.Add(this.pnlMeds);

            // Right Column
            this.pnlRightCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCol.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);

            // Active Treatment Plan
            this.pnlTreatment.BackColor = clrWhite;
            this.pnlTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTreatmentTitle.Text = "Active Treatment Plan";
            this.lblTreatmentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblTreatmentTitle.ForeColor = clrNavyActive;
            this.lblTreatmentTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTreatmentTitle.AutoSize = true;

            this.lblTreatmentContent.Text = "No active treatment plan set.";
            this.lblTreatmentContent.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblTreatmentContent.ForeColor = clrTextDark;
            this.lblTreatmentContent.Location = new System.Drawing.Point(16, 50);
            this.lblTreatmentContent.AutoSize = true;
            this.pnlTreatment.Controls.Add(this.lblTreatmentTitle);
            this.pnlTreatment.Controls.Add(this.lblTreatmentContent);

            // Quick Actions
            this.pnlActions.BackColor = clrWhite;
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Height = 200;
            this.lblActionsTitle.Text = "Quick Actions";
            this.lblActionsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblActionsTitle.ForeColor = clrNavyActive;
            this.lblActionsTitle.Location = new System.Drawing.Point(16, 16);
            this.lblActionsTitle.AutoSize = true;

            this.btnUpdatePlan.Text = "📝 Update Treatment Plan";
            this.btnUpdatePlan.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnUpdatePlan.BackColor = clrNavyLight;
            this.btnUpdatePlan.ForeColor = clrNavyActive;
            this.btnUpdatePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePlan.FlatAppearance.BorderSize = 0;
            this.btnUpdatePlan.Location = new System.Drawing.Point(16, 50);
            this.btnUpdatePlan.Size = new System.Drawing.Size(250, 40);
            this.btnUpdatePlan.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnPrescribe.Text = "💊 Prescribe Medication";
            this.btnPrescribe.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnPrescribe.BackColor = clrNavyLight;
            this.btnPrescribe.ForeColor = clrNavyActive;
            this.btnPrescribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescribe.FlatAppearance.BorderSize = 0;
            this.btnPrescribe.Location = new System.Drawing.Point(16, 100);
            this.btnPrescribe.Size = new System.Drawing.Size(250, 40);
            this.btnPrescribe.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnAddNote.Text = "📋 Add Clinical Note";
            this.btnAddNote.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnAddNote.BackColor = clrNavyLight;
            this.btnAddNote.ForeColor = clrNavyActive;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.FlatAppearance.BorderSize = 0;
            this.btnAddNote.Location = new System.Drawing.Point(16, 150);
            this.btnAddNote.Size = new System.Drawing.Size(250, 40);
            this.btnAddNote.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlActions.Controls.Add(this.lblActionsTitle);
            this.pnlActions.Controls.Add(this.btnUpdatePlan);
            this.pnlActions.Controls.Add(this.btnPrescribe);
            this.pnlActions.Controls.Add(this.btnAddNote);

            var spacerRight = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 24 };
            this.pnlRightCol.Controls.Add(this.pnlTreatment);
            this.pnlRightCol.Controls.Add(spacerRight);
            this.pnlRightCol.Controls.Add(this.pnlActions);

            this.tlpDetails.Controls.Add(this.pnlLeftCol, 0, 0);
            this.tlpDetails.Controls.Add(this.pnlRightCol, 1, 0);

            var pnlMainSpacer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 24 };

            // ── Assemble content
            this.pnlContent.Controls.Add(this.tlpDetails);
            this.pnlContent.Controls.Add(pnlMainSpacer);
            this.pnlContent.Controls.Add(this.pnlProfileCard);

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
            this.pnlProfileCard.ResumeLayout(false);
            this.pnlProfileCard.PerformLayout();
            this.pnlPatientAvatar.ResumeLayout(false);
            this.tlpDetails.ResumeLayout(false);
            this.pnlLeftCol.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            this.pnlMeds.ResumeLayout(false);
            this.pnlMeds.PerformLayout();
            this.pnlRightCol.ResumeLayout(false);
            this.pnlTreatment.ResumeLayout(false);
            this.pnlTreatment.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavAppointments.ResumeLayout(false);
            this.btnNavReports.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlNotifBell;
        private System.Windows.Forms.Label lblBellIcon;
        private System.Windows.Forms.Label lblNotifBadge;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        
        private System.Windows.Forms.Panel pnlContent;
        
        private System.Windows.Forms.Panel pnlProfileCard;
        private System.Windows.Forms.Panel pnlPatientAvatar;
        private System.Windows.Forms.Label lblPatientInitials;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label lblInfoAgeGen;
        private System.Windows.Forms.Label lblInfoBlood;
        private System.Windows.Forms.Label lblInfoContact;
        private System.Windows.Forms.Label lblInfoAddress;
        private System.Windows.Forms.Label lblInfoAgeGenVal;
        private System.Windows.Forms.Label lblInfoBloodVal;
        private System.Windows.Forms.Label lblInfoContactVal;
        private System.Windows.Forms.Label lblInfoAddressVal;

        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Panel pnlLeftCol;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Label lblHistoryContent;
        private System.Windows.Forms.Panel pnlMeds;
        private System.Windows.Forms.Label lblMedsTitle;
        private System.Windows.Forms.Label lblMedsContent;
        
        private System.Windows.Forms.Panel pnlRightCol;
        private System.Windows.Forms.Panel pnlTreatment;
        private System.Windows.Forms.Label lblTreatmentTitle;
        private System.Windows.Forms.Label lblTreatmentContent;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblActionsTitle;
        private System.Windows.Forms.Button btnUpdatePlan;
        private System.Windows.Forms.Button btnPrescribe;
        private System.Windows.Forms.Button btnAddNote;
    }
}