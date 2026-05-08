namespace elnet_recoverease.Doctor
{
    partial class Treatment_Plan_Form
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

            // ── Form Container ─────────────────────────────────────────
            this.pnlFormContainer = new System.Windows.Forms.Panel();
            this.lblFormHeader = new System.Windows.Forms.Label();
            
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            
            this.lblGoals = new System.Windows.Forms.Label();
            this.txtGoals = new System.Windows.Forms.TextBox();

            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();

            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();

            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

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
            this.pnlFormContainer.SuspendLayout();
            
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
            this.Text = "RecoverEase — Treatment Plan";
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

            // ── Patients (Active - Contextual)
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
            this.pnlSidebarBottom.Height = 40;
            this.pnlSidebarBottom.Padding = new System.Windows.Forms.Padding(20, 12, 16, 12);

            this.lblSidebarFooter.Text = "Secure Healthcare Platform";
            this.lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblSidebarFooter.ForeColor = clrTextMid;
            this.lblSidebarFooter.AutoSize = true;
            this.lblSidebarFooter.Location = new System.Drawing.Point(20, 10);

            this.pnlSidebarBottom.Controls.Add(this.lblSidebarFooter);

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
            this.btnBack.Text = "← Back to Patient Details";
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

            this.lblPageTitle.Text = "Treatment Plan";
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
            // FORM CONTAINER
            // ══════════════════════════════════════════════════════════
            this.pnlFormContainer.BackColor = clrWhite;
            this.pnlFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContainer.Size = new System.Drawing.Size(1200, 750);
            this.pnlFormContainer.Padding = new System.Windows.Forms.Padding(40);

            // Top accent bar for container
            var accForm = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.pnlFormContainer.Controls.Add(accForm);

            this.lblFormHeader.Text = "Treatment Roadmap Details";
            this.lblFormHeader.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblFormHeader.ForeColor = clrNavyActive;
            this.lblFormHeader.Location = new System.Drawing.Point(40, 45); // Moved down slightly
            this.lblFormHeader.AutoSize = true;

            // Diagnosis
            this.lblDiagnosis.Text = "Diagnosis";
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblDiagnosis.ForeColor = clrTextDark;
            this.lblDiagnosis.Location = new System.Drawing.Point(40, 90);
            this.lblDiagnosis.AutoSize = true;

            this.txtDiagnosis.Location = new System.Drawing.Point(40, 120);
            this.txtDiagnosis.Size = new System.Drawing.Size(1120, 36);
            this.txtDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Goals
            this.lblGoals.Text = "Treatment Goals";
            this.lblGoals.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblGoals.ForeColor = clrTextDark;
            this.lblGoals.Location = new System.Drawing.Point(40, 180);
            this.lblGoals.AutoSize = true;

            this.txtGoals.Location = new System.Drawing.Point(40, 210);
            this.txtGoals.Size = new System.Drawing.Size(1120, 80);
            this.txtGoals.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtGoals.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtGoals.Multiline = true;
            this.txtGoals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGoals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Details
            this.lblDetails.Text = "Plan Details & Clinical Notes";
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = clrTextDark;
            this.lblDetails.Location = new System.Drawing.Point(40, 310);
            this.lblDetails.AutoSize = true;

            this.txtDetails.Location = new System.Drawing.Point(40, 340);
            this.txtDetails.Size = new System.Drawing.Size(1120, 150);
            this.txtDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtDetails.Multiline = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Start Date
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = clrTextDark;
            this.lblStartDate.Location = new System.Drawing.Point(40, 520);
            this.lblStartDate.AutoSize = true;

            this.dtpStartDate.Location = new System.Drawing.Point(40, 550);
            this.dtpStartDate.Size = new System.Drawing.Size(340, 32);
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // End Date
            this.lblEndDate.Text = "Target End Date";
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = clrTextDark;
            this.lblEndDate.Location = new System.Drawing.Point(420, 520);
            this.lblEndDate.AutoSize = true;

            this.dtpEndDate.Location = new System.Drawing.Point(420, 550);
            this.dtpEndDate.Size = new System.Drawing.Size(340, 32);
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Divider Line
            var pnlFormDivider = new System.Windows.Forms.Panel();
            pnlFormDivider.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E8F0");
            pnlFormDivider.Location = new System.Drawing.Point(40, 620);
            pnlFormDivider.Size = new System.Drawing.Size(1120, 1);
            pnlFormDivider.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // Buttons
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10f, System.Drawing.FontStyle.Bold);
            this.btnCancel.BackColor = clrWhite;
            this.btnCancel.ForeColor = clrTextDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#CBD5E1");
            this.btnCancel.Location = new System.Drawing.Point(830, 650);
            this.btnCancel.Size = new System.Drawing.Size(120, 42);
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnSave.Text = "Save Treatment Plan";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10f, System.Drawing.FontStyle.Bold);
            this.btnSave.BackColor = clrTeal;
            this.btnSave.ForeColor = clrWhite;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(970, 650);
            this.btnSave.Size = new System.Drawing.Size(190, 42);
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlFormContainer.Controls.Add(this.lblFormHeader);
            this.pnlFormContainer.Controls.Add(this.lblDiagnosis);
            this.pnlFormContainer.Controls.Add(this.txtDiagnosis);
            this.pnlFormContainer.Controls.Add(this.lblGoals);
            this.pnlFormContainer.Controls.Add(this.txtGoals);
            this.pnlFormContainer.Controls.Add(this.lblDetails);
            this.pnlFormContainer.Controls.Add(this.txtDetails);
            this.pnlFormContainer.Controls.Add(this.lblStartDate);
            this.pnlFormContainer.Controls.Add(this.dtpStartDate);
            this.pnlFormContainer.Controls.Add(this.lblEndDate);
            this.pnlFormContainer.Controls.Add(this.dtpEndDate);
            this.pnlFormContainer.Controls.Add(pnlFormDivider);
            this.pnlFormContainer.Controls.Add(this.btnCancel);
            this.pnlFormContainer.Controls.Add(this.btnSave);

            // ── Assemble content
            this.pnlContent.Controls.Add(this.pnlFormContainer);

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
            this.pnlFormContainer.ResumeLayout(false);
            this.pnlFormContainer.PerformLayout();
            
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
        
        private System.Windows.Forms.Panel pnlFormContainer;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.TextBox txtGoals;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}