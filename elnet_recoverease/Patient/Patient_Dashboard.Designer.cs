namespace elnet_recoverease
{
    partial class Patient_Dashboard
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

            // -- Controls --
                        this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogoArea = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavDivider = new System.Windows.Forms.Panel();
            this.btnNavDashboard = new System.Windows.Forms.Panel();
            this.lblNavDashIcon = new System.Windows.Forms.Label();
            this.lblNavDashText = new System.Windows.Forms.Label();
            this.btnNavProfile = new System.Windows.Forms.Panel();
            this.lblNavProfileIcon = new System.Windows.Forms.Label();
            this.lblNavProfileText = new System.Windows.Forms.Label();
            this.btnNavMeds = new System.Windows.Forms.Panel();
            this.lblNavMedsIcon = new System.Windows.Forms.Label();
            this.lblNavMedsText = new System.Windows.Forms.Label();
            this.btnNavAppointments = new System.Windows.Forms.Panel();
            this.lblNavApptIcon = new System.Windows.Forms.Label();
            this.lblNavApptText = new System.Windows.Forms.Label();
            this.btnNavTreatment = new System.Windows.Forms.Panel();
            this.lblNavTreatmentIcon = new System.Windows.Forms.Label();
            this.lblNavTreatmentText = new System.Windows.Forms.Label();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.lblSidebarFooter = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();

            // -- Main Layout --
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

            // -- Stat Cards --
            this.cardMeds = new System.Windows.Forms.Panel();
            this.lblCardMedsTitle = new System.Windows.Forms.Label();
            this.lblCardMedsValue = new System.Windows.Forms.Label();
            this.lblCardMedsIcon = new System.Windows.Forms.Label();
            this.lblCardMedsSub = new System.Windows.Forms.Label();

            this.cardAppt = new System.Windows.Forms.Panel();
            this.lblCardApptTitle = new System.Windows.Forms.Label();
            this.lblCardApptValue = new System.Windows.Forms.Label();
            this.lblCardApptIcon = new System.Windows.Forms.Label();
            this.lblCardApptSub = new System.Windows.Forms.Label();

            this.cardAdherence = new System.Windows.Forms.Panel();
            this.lblCardAdhrTitle = new System.Windows.Forms.Label();
            this.lblCardAdhrValue = new System.Windows.Forms.Label();
            this.lblCardAdhrIcon = new System.Windows.Forms.Label();
            this.lblCardAdhrSub = new System.Windows.Forms.Label();

            this.cardMissed = new System.Windows.Forms.Panel();
            this.lblCardMissTitle = new System.Windows.Forms.Label();
            this.lblCardMissValue = new System.Windows.Forms.Label();
            this.lblCardMissIcon = new System.Windows.Forms.Label();
            this.lblCardMissSub = new System.Windows.Forms.Label();

            // -- Bottom panels --
            this.pnlSchedulePanel = new System.Windows.Forms.Panel();
            this.lblScheduleTitle = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlRemindersPanel = new System.Windows.Forms.Panel();
            this.lblRemindersTitle = new System.Windows.Forms.Label();
            this.pnlRem1 = new System.Windows.Forms.Panel();
            this.lblRem1Icon = new System.Windows.Forms.Label();
            this.lblRem1Text = new System.Windows.Forms.Label();
            this.lblRem1Time = new System.Windows.Forms.Label();
            this.pnlRem2 = new System.Windows.Forms.Panel();
            this.lblRem2Icon = new System.Windows.Forms.Label();
            this.lblRem2Text = new System.Windows.Forms.Label();
            this.lblRem2Time = new System.Windows.Forms.Label();
            this.pnlRem3 = new System.Windows.Forms.Panel();
            this.lblRem3Icon = new System.Windows.Forms.Label();
            this.lblRem3Text = new System.Windows.Forms.Label();
            this.lblRem3Time = new System.Windows.Forms.Label();
            this.pnlRem4 = new System.Windows.Forms.Panel();
            this.lblRem4Icon = new System.Windows.Forms.Label();
            this.lblRem4Text = new System.Windows.Forms.Label();
            this.lblRem4Time = new System.Windows.Forms.Label();

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
            this.pnlRemindersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            
            this.btnNavDashboard.SuspendLayout();
            this.btnNavProfile.SuspendLayout();
            this.btnNavMeds.SuspendLayout();
            this.btnNavAppointments.SuspendLayout();
            this.cardMeds.SuspendLayout();
            this.cardAppt.SuspendLayout();
            this.cardAdherence.SuspendLayout();
            this.cardMissed.SuspendLayout();

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

            // ==========================================================
            this.Text = "RecoverEase - Patient Dashboard";
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = clrBg;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // ==========================================================
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

            // -- Dashboard
            this.btnNavDashboard.Size = new System.Drawing.Size(260, 48);
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.BackColor = clrNavyActive;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            var acc_dash = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.lblNavDashIcon.Text = "";
            this.lblNavDashIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavDashIcon.ForeColor = clrWhite;
            this.lblNavDashIcon.AutoSize = true;
            this.lblNavDashIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavDashText.Text = "Dashboard";
            this.lblNavDashText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavDashText.ForeColor = clrWhite;
            this.lblNavDashText.AutoSize = true;
            this.lblNavDashText.Location = new System.Drawing.Point(20, 13);
            this.btnNavDashboard.Controls.Add(acc_dash);
            this.btnNavDashboard.Controls.Add(this.lblNavDashIcon);
            this.btnNavDashboard.Controls.Add(this.lblNavDashText);

            // -- Profile
            this.btnNavProfile.Size = new System.Drawing.Size(260, 48);
            this.btnNavProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProfile.BackColor = clrNavy;
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavProfileIcon.Text = "";
            this.lblNavProfileIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavProfileIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavProfileIcon.AutoSize = true;
            this.lblNavProfileIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavProfileText.Text = "My Profile";
            this.lblNavProfileText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavProfileText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavProfileText.AutoSize = true;
            this.lblNavProfileText.Location = new System.Drawing.Point(20, 13);
            this.btnNavProfile.Controls.Add(this.lblNavProfileIcon);
            this.btnNavProfile.Controls.Add(this.lblNavProfileText);

            // -- Meds
            this.btnNavMeds.Size = new System.Drawing.Size(260, 48);
            this.btnNavMeds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMeds.BackColor = clrNavy;
            this.btnNavMeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavMedsIcon.Text = "";
            this.lblNavMedsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavMedsIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedsIcon.AutoSize = true;
            this.lblNavMedsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavMedsText.Text = "Medications & Schedule";
            this.lblNavMedsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavMedsText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedsText.AutoSize = true;
            this.lblNavMedsText.Location = new System.Drawing.Point(20, 13);
            this.btnNavMeds.Controls.Add(this.lblNavMedsIcon);
            this.btnNavMeds.Controls.Add(this.lblNavMedsText);


            // -- Appointments
            this.btnNavAppointments.Size = new System.Drawing.Size(260, 48);
            this.btnNavAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAppointments.BackColor = clrNavy;
            this.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavApptIcon.Text = "";
            this.lblNavApptIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavApptIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavApptIcon.AutoSize = true;
            this.lblNavApptIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavApptText.Text = "Appointments";
            this.lblNavApptText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavApptText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavApptText.AutoSize = true;
            this.lblNavApptText.Location = new System.Drawing.Point(20, 13);
            this.btnNavAppointments.Controls.Add(this.lblNavApptIcon);
            this.btnNavAppointments.Controls.Add(this.lblNavApptText);

            // -- Treatment Plans
            this.btnNavTreatment.Size = new System.Drawing.Size(260, 48);
            this.btnNavTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTreatment.BackColor = clrNavy;
            this.btnNavTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavTreatmentIcon.Text = "";
            this.lblNavTreatmentIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavTreatmentIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavTreatmentIcon.AutoSize = true;
            this.lblNavTreatmentIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavTreatmentText.Text = "Treatment Plans";
            this.lblNavTreatmentText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavTreatmentText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavTreatmentText.AutoSize = true;
            this.lblNavTreatmentText.Location = new System.Drawing.Point(20, 13);
            this.btnNavTreatment.Controls.Add(this.lblNavTreatmentIcon);
            this.btnNavTreatment.Controls.Add(this.lblNavTreatmentText);

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

            this.btnLogout.Text = "Sign Out";
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
            this.pnlSidebar.Controls.Add(this.btnNavTreatment);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavMeds);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);

            // ==========================================================
            this.pnlMain.BackColor = clrBg;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;

            // -- Top Bar --
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 96;
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);

            var pnlTopBarBorder = new System.Windows.Forms.Panel();
            pnlTopBarBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlTopBarBorder.Height = 1;
            pnlTopBarBorder.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E8F0");
            this.pnlTopBar.Controls.Add(pnlTopBarBorder);

            this.lblPageTitle.Text = "Patient Dashboard";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 16);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.lblWelcome.Text = "Welcome back, manage your health seamlessly.";
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

            this.lblBellIcon.Text = "";
            this.lblBellIcon.Font = new System.Drawing.Font("Segoe UI", 16f);
            this.lblBellIcon.AutoSize = true;
            this.lblBellIcon.Location = new System.Drawing.Point(2, 2);
            this.lblBellIcon.ForeColor = clrTextMid;

            this.lblNotifBadge.Text = "3";
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

            this.lblAvatarInitials.Text = "JD";
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);

            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Controls.Add(this.lblWelcome);
            this.pnlTopBar.Controls.Add(this.pnlNotifBell);
            this.pnlTopBar.Controls.Add(this.pnlAvatarTop);

            // -- Content area --
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlContent.AutoScroll = true;

            // ══════════════════════════════════════════════════════════
            // STAT CARDS (TableLayoutPanel to expand proportionally)
            // ══════════════════════════════════════════════════════════
            int cardH = 140; int cardGap = 20;

            // Table layout for cards to distribute evenly
            var tlpCards = new System.Windows.Forms.TableLayoutPanel();
            tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            tlpCards.Height = cardH;
            tlpCards.ColumnCount = 4;
            tlpCards.RowCount = 1;
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            // Setup Card 1
            this.cardMeds.BackColor = clrWhite;
            this.cardMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMeds.Margin = new System.Windows.Forms.Padding(0, 0, cardGap, 0);
            var acc1 = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardMedsTitle.Text = "MEDICATIONS TODAY";
            this.lblCardMedsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardMedsTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardMedsTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardMedsTitle.AutoSize = true;
            this.lblCardMedsValue.Text = "--";
            this.lblCardMedsValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardMedsValue.ForeColor = clrTeal;
            this.lblCardMedsValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardMedsValue.AutoSize = true;
            this.lblCardMedsIcon.Text = "";
            this.lblCardMedsIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardMedsIcon.ForeColor = System.Drawing.Color.FromArgb(180, clrTeal.R, clrTeal.G, clrTeal.B);
            this.lblCardMedsIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardMedsIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardMedsIcon.AutoSize = true;
            this.lblCardMedsSub.Text = "Scheduled for today";
            this.lblCardMedsSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardMedsSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardMedsSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardMedsSub.AutoSize = true;
            this.cardMeds.Controls.Add(acc1);
            this.cardMeds.Controls.Add(this.lblCardMedsTitle);
            this.cardMeds.Controls.Add(this.lblCardMedsValue);
            this.cardMeds.Controls.Add(this.lblCardMedsIcon);
            this.cardMeds.Controls.Add(this.lblCardMedsSub);

            // Setup Card 2
            this.cardAppt.BackColor = clrWhite;
            this.cardAppt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAppt.Margin = new System.Windows.Forms.Padding(0, 0, cardGap, 0);
            var colNav = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            var acc2 = new System.Windows.Forms.Panel { BackColor = colNav, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardApptTitle.Text = "NEXT APPOINTMENT";
            this.lblCardApptTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardApptTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardApptTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardApptTitle.AutoSize = true;
            this.lblCardApptValue.Text = "--";
            this.lblCardApptValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardApptValue.ForeColor = colNav;
            this.lblCardApptValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardApptValue.AutoSize = true;
            this.lblCardApptIcon.Text = "";
            this.lblCardApptIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardApptIcon.ForeColor = System.Drawing.Color.FromArgb(180, colNav.R, colNav.G, colNav.B);
            this.lblCardApptIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardApptIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardApptIcon.AutoSize = true;
            this.lblCardApptSub.Text = "Upcoming visit";
            this.lblCardApptSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardApptSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardApptSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardApptSub.AutoSize = true;
            this.cardAppt.Controls.Add(acc2);
            this.cardAppt.Controls.Add(this.lblCardApptTitle);
            this.cardAppt.Controls.Add(this.lblCardApptValue);
            this.cardAppt.Controls.Add(this.lblCardApptIcon);
            this.cardAppt.Controls.Add(this.lblCardApptSub);

            // Setup Card 3
            this.cardAdherence.BackColor = clrWhite;
            this.cardAdherence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAdherence.Margin = new System.Windows.Forms.Padding(0, 0, cardGap, 0);
            var acc3 = new System.Windows.Forms.Panel { BackColor = clrGreen, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardAdhrTitle.Text = "ADHERENCE RATE";
            this.lblCardAdhrTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardAdhrTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardAdhrTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardAdhrTitle.AutoSize = true;
            this.lblCardAdhrValue.Text = "--";
            this.lblCardAdhrValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardAdhrValue.ForeColor = clrGreen;
            this.lblCardAdhrValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardAdhrValue.AutoSize = true;
            this.lblCardAdhrIcon.Text = "";
            this.lblCardAdhrIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardAdhrIcon.ForeColor = System.Drawing.Color.FromArgb(180, clrGreen.R, clrGreen.G, clrGreen.B);
            this.lblCardAdhrIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardAdhrIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardAdhrIcon.AutoSize = true;
            this.lblCardAdhrSub.Text = "Last 30 days";
            this.lblCardAdhrSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardAdhrSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardAdhrSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardAdhrSub.AutoSize = true;
            this.cardAdherence.Controls.Add(acc3);
            this.cardAdherence.Controls.Add(this.lblCardAdhrTitle);
            this.cardAdherence.Controls.Add(this.lblCardAdhrValue);
            this.cardAdherence.Controls.Add(this.lblCardAdhrIcon);
            this.cardAdherence.Controls.Add(this.lblCardAdhrSub);

            // Setup Card 4
            this.cardMissed.BackColor = clrWhite;
            this.cardMissed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMissed.Margin = new System.Windows.Forms.Padding(0);
            var acc4 = new System.Windows.Forms.Panel { BackColor = clrOrange, Dock = System.Windows.Forms.DockStyle.Top, Height = 5 };
            this.lblCardMissTitle.Text = "MISSED DOSES";
            this.lblCardMissTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblCardMissTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.lblCardMissTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardMissTitle.AutoSize = true;
            this.lblCardMissValue.Text = "--";
            this.lblCardMissValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardMissValue.ForeColor = clrOrange;
            this.lblCardMissValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardMissValue.AutoSize = true;
            this.lblCardMissIcon.Text = "";
            this.lblCardMissIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardMissIcon.ForeColor = System.Drawing.Color.FromArgb(180, clrOrange.R, clrOrange.G, clrOrange.B);
            this.lblCardMissIcon.Location = new System.Drawing.Point(200, 26);
            this.lblCardMissIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardMissIcon.AutoSize = true;
            this.lblCardMissSub.Text = "Requires attention";
            this.lblCardMissSub.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCardMissSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            this.lblCardMissSub.Location = new System.Drawing.Point(16, 96);
            this.lblCardMissSub.AutoSize = true;
            this.cardMissed.Controls.Add(acc4);
            this.cardMissed.Controls.Add(this.lblCardMissTitle);
            this.cardMissed.Controls.Add(this.lblCardMissValue);
            this.cardMissed.Controls.Add(this.lblCardMissIcon);
            this.cardMissed.Controls.Add(this.lblCardMissSub);

            tlpCards.Controls.Add(this.cardMeds, 0, 0);
            tlpCards.Controls.Add(this.cardAppt, 1, 0);
            tlpCards.Controls.Add(this.cardAdherence, 2, 0);
            tlpCards.Controls.Add(this.cardMissed, 3, 0);

            // ==========================================================
            // SCHEDULE TABLE
            // ==========================================================
            this.pnlSchedulePanel.BackColor = clrWhite;
            this.pnlSchedulePanel.Padding = new System.Windows.Forms.Padding(16);

            this.lblScheduleTitle.Text = "Today's Medication Schedule";
            this.lblScheduleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblScheduleTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            this.lblScheduleTitle.AutoSize = false;
            this.lblScheduleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScheduleTitle.Height = 40;

            // DataGridView
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.BackgroundColor = clrWhite;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSchedule.GridColor = System.Drawing.ColorTranslator.FromHtml("#E2E8F0");
            this.dgvSchedule.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dgvSchedule.RowTemplate.Height = 44;

            // Header style
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F8FAFC");
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64748B");
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.dgvSchedule.ColumnHeadersHeight = 40;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#F8FAFC");
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 245, 245);
            this.dgvSchedule.DefaultCellStyle.SelectionForeColor = clrTextDark;

            // Columns
            this.colTime.HeaderText = "TIME"; this.colTime.FillWeight = 15;
            this.colMedication.HeaderText = "MEDICATION"; this.colMedication.FillWeight = 45;
            this.colDosage.HeaderText = "DOSAGE"; this.colDosage.FillWeight = 15;
            this.colStatus.HeaderText = "STATUS"; this.colStatus.FillWeight = 25;
            this.colStatus.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);

            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTime, this.colMedication, this.colDosage, this.colStatus
            });

            this.pnlSchedulePanel.Controls.Add(this.lblScheduleTitle);
            this.pnlSchedulePanel.Controls.Add(this.dgvSchedule);

            // ══════════════════════════════════════════════════════════
            // REMINDERS PANEL  (right column)
            // ══════════════════════════════════════════════════════════
            this.pnlRemindersPanel.BackColor = clrWhite;

            this.lblRemindersTitle.Text = "Reminders";
            this.lblRemindersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblRemindersTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            this.lblRemindersTitle.AutoSize = true;
            this.lblRemindersTitle.Location = new System.Drawing.Point(14, 14);

            this.pnlRemindersPanel.Controls.Add(this.lblRemindersTitle);

            // Bottom layouts
            var tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpBottom.ColumnCount = 2;
            tlpBottom.RowCount = 1;
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));

            tlpBottom.Controls.Add(this.pnlSchedulePanel, 0, 0);
            this.pnlSchedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSchedulePanel.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);

            tlpBottom.Controls.Add(this.pnlRemindersPanel, 1, 0);
            this.pnlRemindersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemindersPanel.Margin = new System.Windows.Forms.Padding(0);

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
            this.pnlRemindersPanel.ResumeLayout(false);
            this.pnlRemindersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavMeds.ResumeLayout(false);
            this.btnNavAppointments.ResumeLayout(false);
            
            this.cardMeds.ResumeLayout(false);
            this.cardAppt.ResumeLayout(false);
            this.cardAdherence.ResumeLayout(false);
            this.cardMissed.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // -- Field declarations --
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogoArea;
        private System.Windows.Forms.Panel pnlNavDivider;
        private System.Windows.Forms.Panel btnNavDashboard;
        private System.Windows.Forms.Label lblNavDashIcon;
        private System.Windows.Forms.Label lblNavDashText;
        private System.Windows.Forms.Panel btnNavProfile;
        private System.Windows.Forms.Label lblNavProfileIcon;
        private System.Windows.Forms.Label lblNavProfileText;
        private System.Windows.Forms.Panel btnNavMeds;
        private System.Windows.Forms.Label lblNavMedsIcon;
        private System.Windows.Forms.Label lblNavMedsText;
        private System.Windows.Forms.Panel btnNavAppointments;
        private System.Windows.Forms.Label lblNavApptIcon;
        private System.Windows.Forms.Label lblNavApptText;
        private System.Windows.Forms.Panel btnNavTreatment;
        private System.Windows.Forms.Label lblNavTreatmentIcon;
        private System.Windows.Forms.Label lblNavTreatmentText;
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
        private System.Windows.Forms.Panel cardMeds;
        private System.Windows.Forms.Label lblCardMedsTitle;
        private System.Windows.Forms.Label lblCardMedsValue;
        private System.Windows.Forms.Label lblCardMedsIcon;
        private System.Windows.Forms.Label lblCardMedsSub;
        private System.Windows.Forms.Panel cardAppt;
        private System.Windows.Forms.Label lblCardApptTitle;
        private System.Windows.Forms.Label lblCardApptValue;
        private System.Windows.Forms.Label lblCardApptIcon;
        private System.Windows.Forms.Label lblCardApptSub;
        private System.Windows.Forms.Panel cardAdherence;
        private System.Windows.Forms.Label lblCardAdhrTitle;
        private System.Windows.Forms.Label lblCardAdhrValue;
        private System.Windows.Forms.Label lblCardAdhrIcon;
        private System.Windows.Forms.Label lblCardAdhrSub;
        private System.Windows.Forms.Panel cardMissed;
        private System.Windows.Forms.Label lblCardMissTitle;
        private System.Windows.Forms.Label lblCardMissValue;
        private System.Windows.Forms.Label lblCardMissIcon;
        private System.Windows.Forms.Label lblCardMissSub;
        private System.Windows.Forms.Panel pnlSchedulePanel;
        private System.Windows.Forms.Label lblScheduleTitle;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedication;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlRemindersPanel;
        private System.Windows.Forms.Label lblRemindersTitle;
        private System.Windows.Forms.Panel pnlRem1;
        private System.Windows.Forms.Label lblRem1Icon;
        private System.Windows.Forms.Label lblRem1Text;
        private System.Windows.Forms.Label lblRem1Time;
        private System.Windows.Forms.Panel pnlRem2;
        private System.Windows.Forms.Label lblRem2Icon;
        private System.Windows.Forms.Label lblRem2Text;
        private System.Windows.Forms.Label lblRem2Time;
        private System.Windows.Forms.Panel pnlRem3;
        private System.Windows.Forms.Label lblRem3Icon;
        private System.Windows.Forms.Label lblRem3Text;
        private System.Windows.Forms.Label lblRem3Time;
        private System.Windows.Forms.Panel pnlRem4;
        private System.Windows.Forms.Label lblRem4Icon;
        private System.Windows.Forms.Label lblRem4Text;
        private System.Windows.Forms.Label lblRem4Time;
    }
}
