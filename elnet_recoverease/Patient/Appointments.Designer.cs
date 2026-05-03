namespace elnet_recoverease
{
    partial class Appointments
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
            this.btnNavMedSchedule = new System.Windows.Forms.Panel();
            this.lblNavMedSchedIcon = new System.Windows.Forms.Label();
            this.lblNavMedSchedText = new System.Windows.Forms.Label();
            this.btnNavAppointments = new System.Windows.Forms.Panel();
            this.lblNavApptIcon = new System.Windows.Forms.Label();
            this.lblNavApptText = new System.Windows.Forms.Label();
            this.btnNavTreatment = new System.Windows.Forms.Panel();
            this.lblNavTreatmentIcon = new System.Windows.Forms.Label();
            this.lblNavTreatmentText = new System.Windows.Forms.Label();
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

            // ── Appointments Components ──────────────────────────────────
            this.tlpApptCards = new System.Windows.Forms.TableLayoutPanel();
            
            // Stat Cards
            this.cardNextAppt = new System.Windows.Forms.Panel();
            this.lblCardNextTitle = new System.Windows.Forms.Label();
            this.lblCardNextValue = new System.Windows.Forms.Label();
            this.lblCardNextIcon = new System.Windows.Forms.Label();

            this.cardUpcoming = new System.Windows.Forms.Panel();
            this.lblCardUpcomingTitle = new System.Windows.Forms.Label();
            this.lblCardUpcomingValue = new System.Windows.Forms.Label();
            this.lblCardUpcomingIcon = new System.Windows.Forms.Label();

            this.cardCompleted = new System.Windows.Forms.Panel();
            this.lblCardCompletedTitle = new System.Windows.Forms.Label();
            this.lblCardCompletedValue = new System.Windows.Forms.Label();
            this.lblCardCompletedIcon = new System.Windows.Forms.Label();

            // Appt List Panel
            this.pnlApptList = new System.Windows.Forms.Panel();
            this.lblApptListTitle = new System.Windows.Forms.Label();
            this.btnRequestAppt = new System.Windows.Forms.Button();
            this.dgvAppts = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpApptCards.SuspendLayout();
            this.cardNextAppt.SuspendLayout();
            this.cardUpcoming.SuspendLayout();
            this.cardCompleted.SuspendLayout();
            this.pnlApptList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppts)).BeginInit();
            
            // ══════════════════════════════════════════════════════════
            // COLORS
            // ══════════════════════════════════════════════════════════
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

            // ══════════════════════════════════════════════════════════
            // FORM
            // ══════════════════════════════════════════════════════════
            this.Text = "RecoverEase — Appointments";
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = clrBg;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

            this.pnlNavDivider.BackColor = clrNavyLight;
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Height = 1;

            // ── Dashboard
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

            // ── Meds
            this.btnNavMeds.Size = new System.Drawing.Size(260, 48);
            this.btnNavMeds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMeds.BackColor = clrNavy;
            this.btnNavMeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavMedsIcon.Text = "\U0001F48A";
            this.lblNavMedsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavMedsIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedsIcon.AutoSize = true;
            this.lblNavMedsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavMedsText.Text = "Medications";
            this.lblNavMedsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavMedsText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedsText.AutoSize = true;
            this.lblNavMedsText.Location = new System.Drawing.Point(64, 13);
            this.btnNavMeds.Controls.Add(this.lblNavMedsIcon);
            this.btnNavMeds.Controls.Add(this.lblNavMedsText);

            // ── Medication Schedule
            this.btnNavMedSchedule.Size = new System.Drawing.Size(260, 48);
            this.btnNavMedSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMedSchedule.BackColor = clrNavy;
            this.btnNavMedSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavMedSchedIcon.Text = "\U0001F552";
            this.lblNavMedSchedIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavMedSchedIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedSchedIcon.AutoSize = true;
            this.lblNavMedSchedIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavMedSchedText.Text = "Medication Schedule";
            this.lblNavMedSchedText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavMedSchedText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedSchedText.AutoSize = true;
            this.lblNavMedSchedText.Location = new System.Drawing.Point(64, 13);
            this.btnNavMedSchedule.Controls.Add(this.lblNavMedSchedIcon);
            this.btnNavMedSchedule.Controls.Add(this.lblNavMedSchedText);

            // ── Appointments
            this.btnNavAppointments.Size = new System.Drawing.Size(260, 48);
            this.btnNavAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAppointments.BackColor = clrNavyActive;
            this.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            var acc_appt = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.lblNavApptIcon.Text = "\U0001F4C5";
            this.lblNavApptIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavApptIcon.ForeColor = clrWhite;
            this.lblNavApptIcon.AutoSize = true;
            this.lblNavApptIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavApptText.Text = "Appointments";
            this.lblNavApptText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavApptText.ForeColor = clrWhite;
            this.lblNavApptText.AutoSize = true;
            this.lblNavApptText.Location = new System.Drawing.Point(64, 13);
            this.btnNavAppointments.Controls.Add(acc_appt);
            this.btnNavAppointments.Controls.Add(this.lblNavApptIcon);
            this.btnNavAppointments.Controls.Add(this.lblNavApptText);

            // ── Treatment Plans
            this.btnNavTreatment.Size = new System.Drawing.Size(260, 48);
            this.btnNavTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTreatment.BackColor = clrNavy;
            this.btnNavTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavTreatmentIcon.Text = "\U0001F4DD";
            this.lblNavTreatmentIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15f, System.Drawing.FontStyle.Bold);
            this.lblNavTreatmentIcon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavTreatmentIcon.AutoSize = true;
            this.lblNavTreatmentIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavTreatmentText.Text = "Treatment Plans";
            this.lblNavTreatmentText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavTreatmentText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavTreatmentText.AutoSize = true;
            this.lblNavTreatmentText.Location = new System.Drawing.Point(64, 13);
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
            this.btnLogout.Text = "⇠  Sign Out";
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
            this.pnlSidebar.Controls.Add(this.btnNavTreatment);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavMedSchedule);
            this.pnlSidebar.Controls.Add(this.btnNavMeds);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);

            // ══════════════════════════════════════════════════════════
            // MAIN AREA
            // ══════════════════════════════════════════════════════════
            this.pnlMain.BackColor = clrBg;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;

            // ── Top Bar
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 96;
            this.pnlTopBar.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            var pnlTopBarBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 1, BackColor = clrNavyLight };
            this.pnlTopBar.Controls.Add(pnlTopBarBorder);

            this.lblPageTitle.Text = "Appointments";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = clrNavyActive;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 16);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.lblWelcome.Text = "Schedule and manage your follow-up clinic visits.";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblWelcome.ForeColor = clrTextMid;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(28, 58);
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.pnlNotifBell.Size = new System.Drawing.Size(38, 38);
            this.pnlNotifBell.BackColor = clrBg;
            this.pnlNotifBell.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlNotifBell.Location = new System.Drawing.Point(1280, 13);
            this.lblBellIcon.Text = "🔔";
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

            // ── Content area
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(32);
            this.pnlContent.AutoScroll = true;

            // ══════════════════════════════════════════════════════════
            // APPOINTMENTS COMPONENTS
            // ══════════════════════════════════════════════════════════
            
            // ── Stat Cards
            this.tlpApptCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpApptCards.Height = 120;
            this.tlpApptCards.ColumnCount = 3;
            this.tlpApptCards.RowCount = 1;
            this.tlpApptCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpApptCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpApptCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));

            // Card 1
            this.cardNextAppt.BackColor = clrWhite;
            this.cardNextAppt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardNextAppt.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            var accA1 = new System.Windows.Forms.Panel { BackColor = clrNavyActive, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardNextTitle.Text = "NEXT APPOINTMENT";
            this.lblCardNextTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardNextTitle.ForeColor = clrTextMid;
            this.lblCardNextTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardNextTitle.AutoSize = true;
            this.lblCardNextValue.Text = "--";
            this.lblCardNextValue.Font = new System.Drawing.Font("Segoe UI", 24f, System.Drawing.FontStyle.Bold);
            this.lblCardNextValue.ForeColor = clrNavyActive;
            this.lblCardNextValue.Location = new System.Drawing.Point(12, 40);
            this.lblCardNextValue.AutoSize = true;
            this.lblCardNextIcon.Text = "📅";
            this.lblCardNextIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardNextIcon.ForeColor = clrNavyActive;
            this.lblCardNextIcon.Location = new System.Drawing.Point(240, 26);
            this.lblCardNextIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardNextIcon.AutoSize = true;
            this.cardNextAppt.Controls.AddRange(new System.Windows.Forms.Control[] { accA1, this.lblCardNextTitle, this.lblCardNextValue, this.lblCardNextIcon });

            // Card 2
            this.cardUpcoming.BackColor = clrWhite;
            this.cardUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardUpcoming.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            var accA2 = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardUpcomingTitle.Text = "UPCOMING VISITS";
            this.lblCardUpcomingTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardUpcomingTitle.ForeColor = clrTextMid;
            this.lblCardUpcomingTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardUpcomingTitle.AutoSize = true;
            this.lblCardUpcomingValue.Text = "--";
            this.lblCardUpcomingValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardUpcomingValue.ForeColor = clrTeal;
            this.lblCardUpcomingValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardUpcomingValue.AutoSize = true;
            this.lblCardUpcomingIcon.Text = "🩺";
            this.lblCardUpcomingIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardUpcomingIcon.ForeColor = clrTeal;
            this.lblCardUpcomingIcon.Location = new System.Drawing.Point(240, 26);
            this.lblCardUpcomingIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardUpcomingIcon.AutoSize = true;
            this.cardUpcoming.Controls.AddRange(new System.Windows.Forms.Control[] { accA2, this.lblCardUpcomingTitle, this.lblCardUpcomingValue, this.lblCardUpcomingIcon });

            // Card 3
            this.cardCompleted.BackColor = clrWhite;
            this.cardCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCompleted.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            var accA3 = new System.Windows.Forms.Panel { BackColor = clrGreen, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblCardCompletedTitle.Text = "COMPLETED VISITS";
            this.lblCardCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCardCompletedTitle.ForeColor = clrTextMid;
            this.lblCardCompletedTitle.Location = new System.Drawing.Point(16, 16);
            this.lblCardCompletedTitle.AutoSize = true;
            this.lblCardCompletedValue.Text = "--";
            this.lblCardCompletedValue.Font = new System.Drawing.Font("Segoe UI", 28f, System.Drawing.FontStyle.Bold);
            this.lblCardCompletedValue.ForeColor = clrGreen;
            this.lblCardCompletedValue.Location = new System.Drawing.Point(12, 34);
            this.lblCardCompletedValue.AutoSize = true;
            this.lblCardCompletedIcon.Text = "✔";
            this.lblCardCompletedIcon.Font = new System.Drawing.Font("Segoe UI", 24f);
            this.lblCardCompletedIcon.ForeColor = clrGreen;
            this.lblCardCompletedIcon.Location = new System.Drawing.Point(240, 26);
            this.lblCardCompletedIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCardCompletedIcon.AutoSize = true;
            this.cardCompleted.Controls.AddRange(new System.Windows.Forms.Control[] { accA3, this.lblCardCompletedTitle, this.lblCardCompletedValue, this.lblCardCompletedIcon });

            this.tlpApptCards.Controls.Add(this.cardNextAppt, 0, 0);
            this.tlpApptCards.Controls.Add(this.cardUpcoming, 1, 0);
            this.tlpApptCards.Controls.Add(this.cardCompleted, 2, 0);

            var pnlSpacer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 24 };

            // ── Grid Panel
            this.pnlApptList.BackColor = clrWhite;
            this.pnlApptList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApptList.Padding = new System.Windows.Forms.Padding(20);

            var pnlGridHeader = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 40 };

            this.lblApptListTitle.Text = "Appointment Schedule";
            this.lblApptListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12f, System.Drawing.FontStyle.Bold);
            this.lblApptListTitle.ForeColor = clrNavyActive;
            this.lblApptListTitle.AutoSize = true;
            this.lblApptListTitle.Location = new System.Drawing.Point(0, 8);

            this.btnRequestAppt.Text = "+ Request Appointment";
            this.btnRequestAppt.BackColor = clrTeal;
            this.btnRequestAppt.ForeColor = clrWhite;
            this.btnRequestAppt.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.btnRequestAppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestAppt.FlatAppearance.BorderSize = 0;
            this.btnRequestAppt.Size = new System.Drawing.Size(180, 32);
            this.btnRequestAppt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnRequestAppt.Location = new System.Drawing.Point(1250, 4); // Relative to header
            this.btnRequestAppt.Cursor = System.Windows.Forms.Cursors.Hand;

            pnlGridHeader.Controls.Add(this.lblApptListTitle);
            pnlGridHeader.Controls.Add(this.btnRequestAppt);

            // DataGridView
            this.dgvAppts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppts.BackgroundColor = clrWhite;
            this.dgvAppts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppts.RowHeadersVisible = false;
            this.dgvAppts.AllowUserToAddRows = false;
            this.dgvAppts.AllowUserToDeleteRows = false;
            this.dgvAppts.ReadOnly = true;
            this.dgvAppts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppts.GridColor = clrNavyLight;
            this.dgvAppts.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dgvAppts.RowTemplate.Height = 44;

            this.dgvAppts.ColumnHeadersDefaultCellStyle.BackColor = clrBg;
            this.dgvAppts.ColumnHeadersDefaultCellStyle.ForeColor = clrTextMid;
            this.dgvAppts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.dgvAppts.ColumnHeadersHeight = 40;
            this.dgvAppts.ColumnHeadersDefaultCellStyle.SelectionBackColor = clrBg;
            this.dgvAppts.EnableHeadersVisualStyles = false;
            this.dgvAppts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 245, 245);
            this.dgvAppts.DefaultCellStyle.SelectionForeColor = clrTextDark;

            // Columns
            this.colDate.HeaderText = "DATE"; this.colDate.FillWeight = 15;
            this.colTime.HeaderText = "TIME"; this.colTime.FillWeight = 15;
            this.colDoctor.HeaderText = "DOCTOR / CLINIC"; this.colDoctor.FillWeight = 25;
            this.colReason.HeaderText = "REASON FOR VISIT"; this.colReason.FillWeight = 30;
            this.colStatus.HeaderText = "STATUS"; this.colStatus.FillWeight = 15;

            this.dgvAppts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDate, this.colTime, this.colDoctor, this.colReason, this.colStatus
            });

            this.pnlApptList.Controls.Add(this.dgvAppts);
            this.pnlApptList.Controls.Add(pnlGridHeader);
            this.dgvAppts.BringToFront();

            this.pnlContent.Controls.Add(this.pnlApptList);
            this.pnlContent.Controls.Add(pnlSpacer);
            this.pnlContent.Controls.Add(this.tlpApptCards);
            this.pnlApptList.BringToFront();
            pnlSpacer.SendToBack();
            this.tlpApptCards.SendToBack();

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
            this.tlpApptCards.ResumeLayout(false);
            this.cardNextAppt.ResumeLayout(false);
            this.cardNextAppt.PerformLayout();
            this.cardUpcoming.ResumeLayout(false);
            this.cardUpcoming.PerformLayout();
            this.cardCompleted.ResumeLayout(false);
            this.cardCompleted.PerformLayout();
            this.pnlApptList.ResumeLayout(false);
            this.pnlApptList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppts)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavMeds.ResumeLayout(false);
            this.btnNavMedSchedule.ResumeLayout(false);
            this.btnNavAppointments.ResumeLayout(false);
            
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
        private System.Windows.Forms.Panel btnNavProfile;
        private System.Windows.Forms.Label lblNavProfileIcon;
        private System.Windows.Forms.Label lblNavProfileText;
        private System.Windows.Forms.Panel btnNavMeds;
        private System.Windows.Forms.Label lblNavMedsIcon;
        private System.Windows.Forms.Label lblNavMedsText;
        private System.Windows.Forms.Panel btnNavMedSchedule;
        private System.Windows.Forms.Label lblNavMedSchedIcon;
        private System.Windows.Forms.Label lblNavMedSchedText;
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
        
        // Appts components
        private System.Windows.Forms.TableLayoutPanel tlpApptCards;
        private System.Windows.Forms.Panel cardNextAppt;
        private System.Windows.Forms.Label lblCardNextTitle;
        private System.Windows.Forms.Label lblCardNextValue;
        private System.Windows.Forms.Label lblCardNextIcon;
        
        private System.Windows.Forms.Panel cardUpcoming;
        private System.Windows.Forms.Label lblCardUpcomingTitle;
        private System.Windows.Forms.Label lblCardUpcomingValue;
        private System.Windows.Forms.Label lblCardUpcomingIcon;
        
        private System.Windows.Forms.Panel cardCompleted;
        private System.Windows.Forms.Label lblCardCompletedTitle;
        private System.Windows.Forms.Label lblCardCompletedValue;
        private System.Windows.Forms.Label lblCardCompletedIcon;

        private System.Windows.Forms.Panel pnlApptList;
        private System.Windows.Forms.Label lblApptListTitle;
        private System.Windows.Forms.Button btnRequestAppt;
        private System.Windows.Forms.DataGridView dgvAppts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
