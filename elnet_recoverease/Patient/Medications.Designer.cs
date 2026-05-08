namespace elnet_recoverease
{
    partial class Medications
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
            // ── Sidebar Controls ──────────────────────────────────────────────
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

            // -- Main Layout ----------------------------------------------
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

            // -- Meds Components --------------------------------------
            this.tlpMedsCards = new System.Windows.Forms.TableLayoutPanel();
            
            // Stat Cards
            this.cardActiveMeds = new System.Windows.Forms.Panel();
            this.lblCardActiveMedsTitle = new System.Windows.Forms.Label();
            this.lblCardActiveMedsValue = new System.Windows.Forms.Label();
            this.lblCardActiveMedsIcon = new System.Windows.Forms.Label();

            this.cardPendingRefills = new System.Windows.Forms.Panel();
            this.lblCardPendingTitle = new System.Windows.Forms.Label();
            this.lblCardPendingValue = new System.Windows.Forms.Label();
            this.lblCardPendingIcon = new System.Windows.Forms.Label();

            this.cardAdherence = new System.Windows.Forms.Panel();
            this.lblCardAdhrTitle = new System.Windows.Forms.Label();
            this.lblCardAdhrValue = new System.Windows.Forms.Label();
            this.lblCardAdhrIcon = new System.Windows.Forms.Label();

            // Meds List Panel
            this.pnlMedsList = new System.Windows.Forms.Panel();
            this.lblMedsListTitle = new System.Windows.Forms.Label();
            this.dgvMeds = new System.Windows.Forms.DataGridView();
            this.colMedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrescriber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // -- Schedule Panel Components --
            this.pnlDailySchedule = new System.Windows.Forms.Panel();
            this.lblSchedTitle = new System.Windows.Forms.Label();
            this.pnlSchedTabs = new System.Windows.Forms.Panel();
            this.btnTabMorning = new System.Windows.Forms.Button();
            this.btnTabNoon = new System.Windows.Forms.Button();
            this.btnTabEvening = new System.Windows.Forms.Button();
            this.pnlTimelineCont = new System.Windows.Forms.Panel();
            this.lblTimelineFooter = new System.Windows.Forms.Label();
            this.pnlTimelineItems = new System.Windows.Forms.Panel();

            this.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpMedsCards.SuspendLayout();
            this.cardActiveMeds.SuspendLayout();
            this.cardPendingRefills.SuspendLayout();
            this.cardAdherence.SuspendLayout();
            this.pnlMedsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeds)).BeginInit();
            
            // ==========================================================
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyLight = System.Drawing.ColorTranslator.FromHtml("#D0DBE8");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrTextDark = System.Drawing.ColorTranslator.FromHtml("#1E293B");
            System.Drawing.Color clrTextMid = System.Drawing.ColorTranslator.FromHtml("#64748B");
            System.Drawing.Color clrTextLight = System.Drawing.ColorTranslator.FromHtml("#94A3B8");
            System.Drawing.Color clrRed = System.Drawing.Color.FromArgb(192, 57, 43);
            System.Drawing.Color clrGreen = System.Drawing.Color.FromArgb(39, 174, 96);
            System.Drawing.Color clrOrange = System.Drawing.Color.FromArgb(230, 126, 34);

            // ==========================================================
            this.Text = "RecoverEase - Medications & Schedule";
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = clrBg;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

            this.pnlNavDivider.BackColor = clrNavyLight;
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Height = 1;

            // -- Dashboard
            this.btnNavDashboard.Size = new System.Drawing.Size(260, 48);
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.BackColor = clrNavy;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavDashIcon.Text = "";
            this.lblNavDashIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavDashIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavDashIcon.AutoSize = true;
            this.lblNavDashIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavDashText.Text = "Dashboard";
            this.lblNavDashText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavDashText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavDashText.AutoSize = true;
            this.lblNavDashText.Location = new System.Drawing.Point(20, 13);
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
            this.btnNavMeds.BackColor = clrNavyActive;
            this.btnNavMeds.Cursor = System.Windows.Forms.Cursors.Hand;
            var acc_meds = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.lblNavMedsIcon.Text = "";
            this.lblNavMedsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavMedsIcon.ForeColor = clrWhite;
            this.lblNavMedsIcon.AutoSize = true;
            this.lblNavMedsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavMedsText.Text = "Medications & Schedule";
            this.lblNavMedsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavMedsText.ForeColor = clrWhite;
            this.lblNavMedsText.AutoSize = true;
            this.lblNavMedsText.Location = new System.Drawing.Point(20, 13);
            this.btnNavMeds.Controls.Add(acc_meds);
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
            this.pnlSidebarBottom.Height = 40;
            this.pnlSidebarBottom.Padding = new System.Windows.Forms.Padding(20, 12, 16, 12);
            this.lblSidebarFooter.Text = "Secure Healthcare Platform";
            this.lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblSidebarFooter.ForeColor = clrTextMid;
            this.lblSidebarFooter.AutoSize = true;
            this.lblSidebarFooter.Location = new System.Drawing.Point(20, 10);
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("#444444");
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Size = new System.Drawing.Size(188, 26);
            this.btnLogout.Location = new System.Drawing.Point(16, 32);
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Visible = false;
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

            // -- Top Bar
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 96;
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            var pnlTopBarBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 1, BackColor = clrNavyLight };
            this.pnlTopBar.Controls.Add(pnlTopBarBorder);

            this.lblPageTitle.Text = "Medications & Schedule";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = clrNavyActive;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 16);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.lblWelcome.Text = "Manage your prescriptions and track adherence.";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblWelcome.ForeColor = clrTextMid;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(28, 58);
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);





            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Controls.Add(this.lblWelcome);

            // -- Content area
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(32);
            this.pnlContent.AutoScroll = true;

            // ==========================================================
            
            // -- Stat Cards
            this.tlpMedsCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMedsCards.Height = 120;
            this.tlpMedsCards.ColumnCount = 2;
            this.tlpMedsCards.RowCount = 1;
            this.tlpMedsCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMedsCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            // Card 1
            this.cardActiveMeds.BackColor = clrWhite;
            this.cardActiveMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActiveMeds.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            var accM1 = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardActiveMedsTitle.Text = "ACTIVE PRESCRIPTIONS";
            this.lblCardActiveMedsTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardActiveMedsTitle.ForeColor = clrTextMid;
            this.lblCardActiveMedsTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardActiveMedsTitle.AutoSize = true;
            this.lblCardActiveMedsValue.Text = "--";
            this.lblCardActiveMedsValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardActiveMedsValue.ForeColor = clrTeal;
            this.lblCardActiveMedsValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardActiveMedsValue.AutoSize = true;
            this.lblCardActiveMedsIcon.Text = "";
            this.lblCardActiveMedsIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardActiveMedsIcon.ForeColor = clrTeal;
            this.lblCardActiveMedsIcon.Location = new System.Drawing.Point(240, 26);
            this.lblCardActiveMedsIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardActiveMedsIcon.AutoSize = true;
            this.cardActiveMeds.Controls.AddRange(new System.Windows.Forms.Control[] { accM1, this.lblCardActiveMedsTitle, this.lblCardActiveMedsValue, this.lblCardActiveMedsIcon });

            // Card 2
            this.cardPendingRefills.BackColor = clrWhite;
            this.cardPendingRefills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPendingRefills.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            var accM2 = new System.Windows.Forms.Panel { BackColor = clrOrange, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardPendingTitle.Text = "PENDING REFILLS";
            this.lblCardPendingTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardPendingTitle.ForeColor = clrTextMid;
            this.lblCardPendingTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardPendingTitle.AutoSize = true;
            this.lblCardPendingValue.Text = "--";
            this.lblCardPendingValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardPendingValue.ForeColor = clrOrange;
            this.lblCardPendingValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardPendingValue.AutoSize = true;
            this.lblCardPendingIcon.Text = "";
            this.lblCardPendingIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardPendingIcon.ForeColor = clrOrange;
            this.lblCardPendingIcon.Location = new System.Drawing.Point(240, 26);
            this.lblCardPendingIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardPendingIcon.AutoSize = true;
            this.cardPendingRefills.Controls.AddRange(new System.Windows.Forms.Control[] { accM2, this.lblCardPendingTitle, this.lblCardPendingValue, this.lblCardPendingIcon });

            // Card 3
            this.cardAdherence.BackColor = clrWhite;
            this.cardAdherence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAdherence.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            var accM3 = new System.Windows.Forms.Panel { BackColor = clrGreen, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardAdhrTitle.Text = "ADHERENCE SCORE";
            this.lblCardAdhrTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardAdhrTitle.ForeColor = clrTextMid;
            this.lblCardAdhrTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardAdhrTitle.AutoSize = true;
            this.lblCardAdhrValue.Text = "--";
            this.lblCardAdhrValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardAdhrValue.ForeColor = clrGreen;
            this.lblCardAdhrValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardAdhrValue.AutoSize = true;
            this.lblCardAdhrIcon.Text = "";
            this.lblCardAdhrIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardAdhrIcon.ForeColor = clrGreen;
            this.lblCardAdhrIcon.Location = new System.Drawing.Point(240, 26);
            this.lblCardAdhrIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardAdhrIcon.AutoSize = true;
            this.cardAdherence.Controls.AddRange(new System.Windows.Forms.Control[] { accM3, this.lblCardAdhrTitle, this.lblCardAdhrValue, this.lblCardAdhrIcon });

            this.tlpMedsCards.Controls.Add(this.cardActiveMeds, 0, 0);
            this.tlpMedsCards.Controls.Add(this.cardAdherence, 1, 0);

            var pnlSpacer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 24 };

            // ── Grid Panel
            this.pnlMedsList.BackColor = clrWhite;
            this.pnlMedsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedsList.Padding = new System.Windows.Forms.Padding(20);

            var pnlGridHeader = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 40 };

            this.lblMedsListTitle.Text = "Current Prescriptions";
            this.lblMedsListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblMedsListTitle.ForeColor = clrNavyActive;
            this.lblMedsListTitle.AutoSize = true;
            this.lblMedsListTitle.Location = new System.Drawing.Point(0, 0);
            pnlGridHeader.Controls.Add(this.lblMedsListTitle);

            // DataGridView
            this.dgvMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeds.BackgroundColor = clrWhite;
            this.dgvMeds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMeds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMeds.RowHeadersVisible = false;
            this.dgvMeds.AllowUserToAddRows = false;
            this.dgvMeds.AllowUserToDeleteRows = false;
            this.dgvMeds.ReadOnly = true;
            this.dgvMeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeds.GridColor = clrNavyLight;
            this.dgvMeds.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dgvMeds.RowTemplate.Height = 44;

            this.dgvMeds.ColumnHeadersDefaultCellStyle.BackColor = clrBg;
            this.dgvMeds.ColumnHeadersDefaultCellStyle.ForeColor = clrTextMid;
            this.dgvMeds.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.dgvMeds.ColumnHeadersHeight = 40;
            this.dgvMeds.ColumnHeadersDefaultCellStyle.SelectionBackColor = clrBg;
            this.dgvMeds.EnableHeadersVisualStyles = false;
            this.dgvMeds.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 245, 245);
            this.dgvMeds.DefaultCellStyle.SelectionForeColor = clrTextDark;

            // Columns
            this.colMedName.HeaderText = "MEDICATION NAME"; this.colMedName.FillWeight = 30;
            this.colDosage.HeaderText = "DOSAGE"; this.colDosage.FillWeight = 15;
            this.colFreq.HeaderText = "FREQUENCY"; this.colFreq.FillWeight = 20;
            this.colPrescriber.HeaderText = "PRESCRIBER"; this.colPrescriber.FillWeight = 25;
            this.colStatus.HeaderText = "STATUS"; this.colStatus.FillWeight = 10;

            this.dgvMeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMedName, this.colDosage, this.colFreq, this.colPrescriber, this.colStatus
            });

            this.pnlMedsList.Controls.Add(this.dgvMeds);
            this.pnlMedsList.Controls.Add(pnlGridHeader);
            // pnlGridHeader is Dock.Top, dgvMeds is Dock.Fill

            // -- Layout Split --
            var tlpMainSplit = new System.Windows.Forms.TableLayoutPanel();
            tlpMainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMainSplit.ColumnCount = 2;
            tlpMainSplit.RowCount = 1;
            tlpMainSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tlpMainSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));

            // -- Daily Schedule Panel --
            this.pnlDailySchedule.BackColor = clrWhite;
            this.pnlDailySchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDailySchedule.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDailySchedule.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);

            this.lblSchedTitle.Text = "Daily Medication Schedule";
            this.lblSchedTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblSchedTitle.ForeColor = clrNavyActive;
            this.lblSchedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSchedTitle.Height = 30;

            this.pnlSchedTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSchedTabs.Height = 40;
            this.pnlSchedTabs.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);

            this.btnTabMorning.Text = "MORNING\n(8 AM)";
            this.btnTabMorning.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTabMorning.Width = 100;
            this.btnTabMorning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabMorning.BackColor = clrNavyActive;
            this.btnTabMorning.ForeColor = clrWhite;
            this.btnTabMorning.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);

            this.btnTabNoon.Text = "NOON\n(12 PM)";
            this.btnTabNoon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTabNoon.Width = 100;
            this.btnTabNoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabNoon.BackColor = clrNavy;
            this.btnTabNoon.ForeColor = clrTextDark;
            this.btnTabNoon.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);

            this.btnTabEvening.Text = "EVENING\n(6 PM)";
            this.btnTabEvening.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTabEvening.Width = 100;
            this.btnTabEvening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabEvening.BackColor = clrNavy;
            this.btnTabEvening.ForeColor = clrTextDark;
            this.btnTabEvening.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);

            this.pnlSchedTabs.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnTabEvening, this.btnTabNoon, this.btnTabMorning });

            this.lblTimelineFooter.Text = "Tap to check doses taken.";
            this.lblTimelineFooter.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblTimelineFooter.ForeColor = clrTextMid;
            this.lblTimelineFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimelineFooter.Height = 30;
            this.lblTimelineFooter.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            this.pnlTimelineCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimelineCont.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            
            // Vertical Line
            var pnlLine = new System.Windows.Forms.Panel { BackColor = clrNavyLight, Width = 2, Location = new System.Drawing.Point(20, 20), Height = 300, Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom };
            this.pnlTimelineCont.Controls.Add(pnlLine);

            this.pnlTimelineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimelineItems.AutoScroll = true;
            this.pnlTimelineCont.Controls.Add(this.pnlTimelineItems);
            this.pnlTimelineItems.BringToFront();

            this.pnlDailySchedule.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlTimelineCont, this.lblTimelineFooter, this.pnlSchedTabs, this.lblSchedTitle });

            tlpMainSplit.Controls.Add(this.pnlMedsList, 0, 0);
            tlpMainSplit.Controls.Add(this.pnlDailySchedule, 1, 0);
            this.pnlMedsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedsList.Margin = new System.Windows.Forms.Padding(0);

            this.pnlContent.Controls.Add(tlpMainSplit);
            this.pnlContent.Controls.Add(pnlSpacer);
            this.pnlContent.Controls.Add(this.tlpMedsCards);
            
            tlpMainSplit.BringToFront();
            pnlSpacer.SendToBack();
            this.tlpMedsCards.SendToBack();

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
            this.tlpMedsCards.ResumeLayout(false);
            this.cardActiveMeds.ResumeLayout(false);
            this.cardActiveMeds.PerformLayout();
            this.cardPendingRefills.ResumeLayout(false);
            this.cardPendingRefills.PerformLayout();
            this.cardAdherence.ResumeLayout(false);
            this.cardAdherence.PerformLayout();
            this.pnlMedsList.ResumeLayout(false);
            this.pnlMedsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeds)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavMeds.ResumeLayout(false);
            this.btnNavAppointments.ResumeLayout(false);
            
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
        
        // Meds components
        private System.Windows.Forms.TableLayoutPanel tlpMedsCards;
        private System.Windows.Forms.Panel cardActiveMeds;
        private System.Windows.Forms.Label lblCardActiveMedsTitle;
        private System.Windows.Forms.Label lblCardActiveMedsValue;
        private System.Windows.Forms.Label lblCardActiveMedsIcon;
        
        private System.Windows.Forms.Panel cardPendingRefills;
        private System.Windows.Forms.Label lblCardPendingTitle;
        private System.Windows.Forms.Label lblCardPendingValue;
        private System.Windows.Forms.Label lblCardPendingIcon;
        
        private System.Windows.Forms.Panel cardAdherence;
        private System.Windows.Forms.Label lblCardAdhrTitle;
        private System.Windows.Forms.Label lblCardAdhrValue;
        private System.Windows.Forms.Label lblCardAdhrIcon;

        private System.Windows.Forms.Panel pnlMedsList;
        private System.Windows.Forms.Label lblMedsListTitle;
        private System.Windows.Forms.DataGridView dgvMeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrescriber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefills;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        // Schedule components
        private System.Windows.Forms.Panel pnlDailySchedule;
        private System.Windows.Forms.Label lblSchedTitle;
        private System.Windows.Forms.Panel pnlSchedTabs;
        private System.Windows.Forms.Button btnTabMorning;
        private System.Windows.Forms.Button btnTabNoon;
        private System.Windows.Forms.Button btnTabEvening;
        private System.Windows.Forms.Panel pnlTimelineCont;
        private System.Windows.Forms.Label lblTimelineFooter;
        private System.Windows.Forms.Panel pnlTimelineItems;
    }
}
