namespace elnet_recoverease
{
    partial class Treatment_Plans
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
            // -- Sidebar Controls --
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

            // -- Treatment Components --
            this.tlpTreatmentCards = new System.Windows.Forms.TableLayoutPanel();
            
            // Stat Cards
            this.cardActive = new System.Windows.Forms.Panel();
            this.lblCardActiveTitle = new System.Windows.Forms.Label();
            this.lblCardActiveValue = new System.Windows.Forms.Label();
            this.lblCardActiveIcon = new System.Windows.Forms.Label();

            this.cardProgress = new System.Windows.Forms.Panel();
            this.lblCardProgressTitle = new System.Windows.Forms.Label();
            this.lblCardProgressValue = new System.Windows.Forms.Label();
            this.lblCardProgressIcon = new System.Windows.Forms.Label();

            // Grid Panel
            this.pnlTreatmentList = new System.Windows.Forms.Panel();
            this.lblTreatmentListTitle = new System.Windows.Forms.Label();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpTreatmentCards.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.cardProgress.SuspendLayout();
            this.pnlTreatmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            
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

            // ==========================================================
            this.Text = "RecoverEase - Treatment Plans";
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
            this.btnNavTreatment.BackColor = clrNavyActive;
            this.btnNavTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            var acc_treat = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.lblNavTreatmentIcon.Text = "";
            this.lblNavTreatmentIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavTreatmentIcon.ForeColor = clrWhite;
            this.lblNavTreatmentIcon.AutoSize = true;
            this.lblNavTreatmentIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavTreatmentText.Text = "Treatment Plans";
            this.lblNavTreatmentText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavTreatmentText.ForeColor = clrWhite;
            this.lblNavTreatmentText.AutoSize = true;
            this.lblNavTreatmentText.Location = new System.Drawing.Point(20, 13);
            this.btnNavTreatment.Controls.Add(acc_treat);
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
            this.btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("#444444");
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
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
            var pnlTopBarBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 1, BackColor = clrNavyLight };
            this.pnlTopBar.Controls.Add(pnlTopBarBorder);

            this.lblPageTitle.Text = "Treatment Plans";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = clrNavyActive;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 16);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.lblWelcome.Text = "View your recovery plan and track your progress.";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblWelcome.ForeColor = clrTextMid;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(28, 58);
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.pnlNotifBell.Size = new System.Drawing.Size(38, 38);
            this.pnlNotifBell.BackColor = clrBg;
            this.pnlNotifBell.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlNotifBell.Location = new System.Drawing.Point(1280, 13);
            this.lblBellIcon.Text = "";
            this.lblBellIcon.Font = new System.Drawing.Font("Segoe UI", 16f);
            this.lblBellIcon.AutoSize = true;
            this.lblBellIcon.Location = new System.Drawing.Point(2, 2);
            this.lblNotifBadge.Text = "3";
            this.lblNotifBadge.Font = new System.Drawing.Font("Segoe UI", 6f, System.Drawing.FontStyle.Bold);
            this.lblNotifBadge.ForeColor = clrWhite;
            this.lblNotifBadge.BackColor = clrRed;
            this.lblNotifBadge.Size = new System.Drawing.Size(14, 14);
            this.lblNotifBadge.Location = new System.Drawing.Point(22, 2);
            this.lblNotifBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlNotifBell.Controls.Add(this.lblBellIcon);
            this.pnlNotifBell.Controls.Add(this.lblNotifBadge);

            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlAvatarTop.Location = new System.Drawing.Point(1328, 12);
            this.lblAvatarInitials.Text = "--";
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
            this.pnlContent.Padding = new System.Windows.Forms.Padding(32);
            this.pnlContent.AutoScroll = true;

            // ==========================================================
            // TREATMENT COMPONENTS
            // ==========================================================
            
            // -- Stat Cards --
            this.tlpTreatmentCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTreatmentCards.Height = 120;
            this.tlpTreatmentCards.ColumnCount = 1;
            this.tlpTreatmentCards.RowCount = 1;
            this.tlpTreatmentCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // Card 1
            this.cardActive.BackColor = clrWhite;
            this.cardActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActive.Margin = new System.Windows.Forms.Padding(0);
            var accT1 = new System.Windows.Forms.Panel { BackColor = clrNavyActive, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardActiveTitle.Text = "ACTIVE TREATMENT";
            this.lblCardActiveTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardActiveTitle.ForeColor = clrTextMid;
            this.lblCardActiveTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardActiveTitle.AutoSize = true;
            this.lblCardActiveValue.Text = "--";
            this.lblCardActiveValue.Font = new System.Drawing.Font("Segoe UI", 24f, System.Drawing.FontStyle.Bold);
            this.lblCardActiveValue.ForeColor = clrNavyActive;
            this.lblCardActiveValue.Location = new System.Drawing.Point(12, 40);
            this.lblCardActiveValue.AutoSize = true;
            this.lblCardActiveIcon.Text = "";
            this.lblCardActiveIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardActiveIcon.ForeColor = clrNavyActive;
            this.lblCardActiveIcon.Location = new System.Drawing.Point(400, 26);
            this.lblCardActiveIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardActiveIcon.AutoSize = true;
            this.cardActive.Controls.AddRange(new System.Windows.Forms.Control[] { accT1, this.lblCardActiveTitle, this.lblCardActiveValue, this.lblCardActiveIcon });

            // Card 2
            this.cardProgress.BackColor = clrWhite;
            this.cardProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardProgress.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            var accT2 = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardProgressTitle.Text = "OVERALL PROGRESS";
            this.lblCardProgressTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardProgressTitle.ForeColor = clrTextMid;
            this.lblCardProgressTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardProgressTitle.AutoSize = true;
            this.lblCardProgressValue.Text = "--";
            this.lblCardProgressValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardProgressValue.ForeColor = clrTeal;
            this.lblCardProgressValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardProgressValue.AutoSize = true;
            this.lblCardProgressIcon.Text = "";
            this.lblCardProgressIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardProgressIcon.ForeColor = clrTeal;
            this.lblCardProgressIcon.Location = new System.Drawing.Point(400, 26);
            this.lblCardProgressIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardProgressIcon.AutoSize = true;
            this.cardProgress.Controls.AddRange(new System.Windows.Forms.Control[] { accT2, this.lblCardProgressTitle, this.lblCardProgressValue, this.lblCardProgressIcon });

            this.tlpTreatmentCards.Controls.Add(this.cardActive, 0, 0);

            var pnlSpacer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 24 };

            // -- Grid Panel --
            this.pnlTreatmentList.BackColor = clrWhite;
            this.pnlTreatmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTreatmentList.Padding = new System.Windows.Forms.Padding(20);

            var pnlGridHeader = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 40 };

            this.lblTreatmentListTitle.Text = "Treatment Goals & Milestones";
            this.lblTreatmentListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblTreatmentListTitle.ForeColor = clrNavyActive;
            this.lblTreatmentListTitle.AutoSize = true;
            this.lblTreatmentListTitle.Location = new System.Drawing.Point(0, 0);
            pnlGridHeader.Controls.Add(this.lblTreatmentListTitle);

            // DataGridView
            this.dgvTreatments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreatments.BackgroundColor = clrWhite;
            this.dgvTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTreatments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTreatments.RowHeadersVisible = false;
            this.dgvTreatments.AllowUserToAddRows = false;
            this.dgvTreatments.AllowUserToDeleteRows = false;
            this.dgvTreatments.ReadOnly = true;
            this.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreatments.GridColor = clrNavyLight;
            this.dgvTreatments.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dgvTreatments.RowTemplate.Height = 44;

            this.dgvTreatments.ColumnHeadersDefaultCellStyle.BackColor = clrBg;
            this.dgvTreatments.ColumnHeadersDefaultCellStyle.ForeColor = clrTextMid;
            this.dgvTreatments.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.dgvTreatments.ColumnHeadersHeight = 40;
            this.dgvTreatments.ColumnHeadersDefaultCellStyle.SelectionBackColor = clrBg;
            this.dgvTreatments.EnableHeadersVisualStyles = false;
            this.dgvTreatments.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 245, 245);
            this.dgvTreatments.DefaultCellStyle.SelectionForeColor = clrTextDark;

            // Columns
            this.colDate.HeaderText = "TARGET DATE"; this.colDate.FillWeight = 20;
            this.colGoal.HeaderText = "GOAL / MILESTONE"; this.colGoal.FillWeight = 40;
            this.colAssignedBy.HeaderText = "ASSIGNED BY"; this.colAssignedBy.FillWeight = 25;
            this.colStatus.HeaderText = "STATUS"; this.colStatus.FillWeight = 15;

            this.dgvTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDate, this.colGoal, this.colAssignedBy, this.colStatus
            });

            this.pnlTreatmentList.Controls.Add(this.dgvTreatments);
            this.pnlTreatmentList.Controls.Add(pnlGridHeader);
            this.dgvTreatments.BringToFront();

            this.pnlContent.Controls.Add(this.pnlTreatmentList);
            this.pnlContent.Controls.Add(pnlSpacer);
            this.pnlContent.Controls.Add(this.tlpTreatmentCards);
            this.pnlTreatmentList.BringToFront();
            pnlSpacer.SendToBack();
            this.tlpTreatmentCards.SendToBack();

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
            this.tlpTreatmentCards.ResumeLayout(false);
            this.cardActive.ResumeLayout(false);
            this.cardActive.PerformLayout();
            this.cardProgress.ResumeLayout(false);
            this.cardProgress.PerformLayout();
            this.pnlTreatmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavMeds.ResumeLayout(false);
            this.btnNavAppointments.ResumeLayout(false);
            this.btnNavTreatment.ResumeLayout(false);
            
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
        
        // Treatment components
        private System.Windows.Forms.TableLayoutPanel tlpTreatmentCards;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Label lblCardActiveTitle;
        private System.Windows.Forms.Label lblCardActiveValue;
        private System.Windows.Forms.Label lblCardActiveIcon;
        
        private System.Windows.Forms.Panel cardProgress;
        private System.Windows.Forms.Label lblCardProgressTitle;
        private System.Windows.Forms.Label lblCardProgressValue;
        private System.Windows.Forms.Label lblCardProgressIcon;

        private System.Windows.Forms.Panel pnlTreatmentList;
        private System.Windows.Forms.Label lblTreatmentListTitle;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
