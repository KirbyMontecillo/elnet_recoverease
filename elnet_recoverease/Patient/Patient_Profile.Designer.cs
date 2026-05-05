namespace elnet_recoverease
{
    partial class Patient_Profile
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

            // -- Profile Components --────
            this.pnlHeaderCard = new System.Windows.Forms.Panel();
            this.pnlAvatarLarge = new System.Windows.Forms.Panel();
            this.lblAvatarLargeInitials = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.lblPatientAge = new System.Windows.Forms.Label();

            this.tlpProfileCards = new System.Windows.Forms.TableLayoutPanel();
            
            // Personal Info Card
            this.cardPersonalInfo = new System.Windows.Forms.Panel();
            this.lblPInfoTitle = new System.Windows.Forms.Label();
            this.lblPhoneLbl = new System.Windows.Forms.Label();
            this.lblPhoneVal = new System.Windows.Forms.Label();
            this.lblEmailLbl = new System.Windows.Forms.Label();
            this.lblEmailVal = new System.Windows.Forms.Label();
            this.lblAddressLbl = new System.Windows.Forms.Label();
            this.lblAddressVal = new System.Windows.Forms.Label();
            
            this.lblEmergencyLbl = new System.Windows.Forms.Label();
            this.lblEmergencyNameLbl = new System.Windows.Forms.Label();
            this.lblEmergencyNameVal = new System.Windows.Forms.Label();
            this.lblEmergencyRelLbl = new System.Windows.Forms.Label();
            this.lblEmergencyRelVal = new System.Windows.Forms.Label();
            this.lblEmergencyPhoneLbl = new System.Windows.Forms.Label();
            this.lblEmergencyPhoneVal = new System.Windows.Forms.Label();
            this.btnEditPersonal = new System.Windows.Forms.Button();

            // Medical Overview Card
            this.cardMedicalOverview = new System.Windows.Forms.Panel();
            this.lblMedOverviewTitle = new System.Windows.Forms.Label();
            this.lblBloodLbl = new System.Windows.Forms.Label();
            this.lblBloodVal = new System.Windows.Forms.Label();
            this.lblHeightLbl = new System.Windows.Forms.Label();
            this.lblHeightVal = new System.Windows.Forms.Label();
            this.lblWeightLbl = new System.Windows.Forms.Label();
            this.lblWeightVal = new System.Windows.Forms.Label();
            this.lblAllergiesLbl = new System.Windows.Forms.Label();
            this.lblAllergiesVal = new System.Windows.Forms.Label();

            this.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlHeaderCard.SuspendLayout();
            this.pnlAvatarLarge.SuspendLayout();
            this.tlpProfileCards.SuspendLayout();
            this.cardPersonalInfo.SuspendLayout();
            this.cardMedicalOverview.SuspendLayout();
            
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
            this.Text = "RecoverEase - Patient Profile";
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
            this.lblNavDashText.Text = "Dashboard";
            this.lblNavDashText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavDashText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavDashText.AutoSize = true;
            this.lblNavDashText.Location = new System.Drawing.Point(20, 13);
            this.btnNavDashboard.Controls.Add(this.lblNavDashText);

            // -- Profile
            this.btnNavProfile.Size = new System.Drawing.Size(260, 48);
            this.btnNavProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProfile.BackColor = clrNavyActive;
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            var acc_prof = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
            this.lblNavProfileText.Text = "My Profile";
            this.lblNavProfileText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavProfileText.ForeColor = clrWhite;
            this.lblNavProfileText.AutoSize = true;
            this.lblNavProfileText.Location = new System.Drawing.Point(20, 13);
            this.btnNavProfile.Controls.Add(acc_prof);
            this.btnNavProfile.Controls.Add(this.lblNavProfileText);

            // -- Meds
            this.btnNavMeds.Size = new System.Drawing.Size(260, 48);
            this.btnNavMeds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMeds.BackColor = clrNavy;
            this.btnNavMeds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavMedsText.Text = "Medications";
            this.lblNavMedsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavMedsText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedsText.AutoSize = true;
            this.lblNavMedsText.Location = new System.Drawing.Point(20, 13);
            this.btnNavMeds.Controls.Add(this.lblNavMedsText);

            // -- Medication Schedule
            this.btnNavMedSchedule.Size = new System.Drawing.Size(260, 48);
            this.btnNavMedSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavMedSchedule.BackColor = clrNavy;
            this.btnNavMedSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavMedSchedText.Text = "Medication Schedule";
            this.lblNavMedSchedText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavMedSchedText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavMedSchedText.AutoSize = true;
            this.lblNavMedSchedText.Location = new System.Drawing.Point(20, 13);
            this.btnNavMedSchedule.Controls.Add(this.lblNavMedSchedText);

            // -- Appointments
            this.btnNavAppointments.Size = new System.Drawing.Size(260, 48);
            this.btnNavAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAppointments.BackColor = clrNavy;
            this.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavApptText.Text = "Appointments";
            this.lblNavApptText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavApptText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavApptText.AutoSize = true;
            this.lblNavApptText.Location = new System.Drawing.Point(20, 13);
            this.btnNavAppointments.Controls.Add(this.lblNavApptText);

            // -- Treatment Plans
            this.btnNavTreatment.Size = new System.Drawing.Size(260, 48);
            this.btnNavTreatment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavTreatment.BackColor = clrNavy;
            this.btnNavTreatment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavTreatmentText.Text = "Treatment Plans";
            this.lblNavTreatmentText.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblNavTreatmentText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2D3748");
            this.lblNavTreatmentText.AutoSize = true;
            this.lblNavTreatmentText.Location = new System.Drawing.Point(20, 13);
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
            this.pnlSidebar.Controls.Add(this.btnNavTreatment);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavMedSchedule);
            this.pnlSidebar.Controls.Add(this.btnNavMeds);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
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

            this.lblPageTitle.Text = "My Profile";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = clrNavyActive;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 16);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.lblWelcome.Text = "View and update your personal health information.";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lblWelcome.ForeColor = clrTextMid;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(28, 58);
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);

            this.pnlNotifBell.Size = new System.Drawing.Size(38, 38);
            this.pnlNotifBell.BackColor = clrBg;
            this.pnlNotifBell.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlNotifBell.Location = new System.Drawing.Point(880, 13);
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
            this.pnlAvatarTop.Location = new System.Drawing.Point(928, 12);
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

            // **********************************************************
            // PROFILE COMPONENTS
            // **********************************************************
            
            // -- Header Card --
            this.pnlHeaderCard.BackColor = clrWhite;
            this.pnlHeaderCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderCard.Height = 140;
            this.pnlHeaderCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlHeaderCard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            
            this.pnlAvatarLarge.Size = new System.Drawing.Size(80, 80);
            this.pnlAvatarLarge.Location = new System.Drawing.Point(24, 30);
            this.pnlAvatarLarge.BackColor = clrTeal;
            this.lblAvatarLargeInitials.Text = "";
            this.lblAvatarLargeInitials.Font = new System.Drawing.Font("Segoe UI", 40f);
            this.lblAvatarLargeInitials.ForeColor = clrWhite;
            this.lblAvatarLargeInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarLargeInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAvatarLarge.Controls.Add(this.lblAvatarLargeInitials);

            this.lblPatientName.Text = "--------------------";
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 24f, System.Drawing.FontStyle.Bold);
            this.lblPatientName.ForeColor = clrNavyActive;
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(120, 24);

            this.lblPatientId.Text = "Patient ID: --";
            this.lblPatientId.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblPatientId.ForeColor = clrTeal;
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Location = new System.Drawing.Point(124, 72);

            this.lblPatientAge.Text = "Birth Date: --  |  Gender: --";
            this.lblPatientAge.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblPatientAge.ForeColor = clrTextMid;
            this.lblPatientAge.AutoSize = true;
            this.lblPatientAge.Location = new System.Drawing.Point(124, 100);

            this.pnlHeaderCard.Controls.Add(this.pnlAvatarLarge);
            this.pnlHeaderCard.Controls.Add(this.lblPatientName);
            this.pnlHeaderCard.Controls.Add(this.lblPatientId);
            this.pnlHeaderCard.Controls.Add(this.lblPatientAge);

            var pnlSpacer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 24 };

            // -- Grid Layout for Cards --
            this.tlpProfileCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProfileCards.ColumnCount = 2;
            this.tlpProfileCards.RowCount = 1;
            this.tlpProfileCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProfileCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProfileCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // Helper function logic inline for creating standard labels
            System.Drawing.Font fntTitle = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fntLbl = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fntVal = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);

            // Card 1: Personal Info
            this.cardPersonalInfo.BackColor = clrWhite;
            this.cardPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPersonalInfo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            var accP1 = new System.Windows.Forms.Panel { BackColor = clrNavyActive, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblPInfoTitle.Text = "Personal Information";
            this.lblPInfoTitle.Font = fntTitle;
            this.lblPInfoTitle.ForeColor = clrNavyActive;
            this.lblPInfoTitle.Location = new System.Drawing.Point(24, 24);
            this.lblPInfoTitle.AutoSize = true;

            this.btnEditPersonal.Text = "Edit";
            this.btnEditPersonal.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnEditPersonal.ForeColor = clrWhite;
            this.btnEditPersonal.BackColor = clrNavyActive;
            this.btnEditPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPersonal.FlatAppearance.BorderSize = 0;
            this.btnEditPersonal.Size = new System.Drawing.Size(80, 30);
            this.btnEditPersonal.Location = new System.Drawing.Point(250, 30);
            this.btnEditPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnEditPersonal.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblPhoneLbl.Text = "Phone Number"; this.lblPhoneLbl.Font = fntLbl; this.lblPhoneLbl.ForeColor = clrTextLight; this.lblPhoneLbl.Location = new System.Drawing.Point(24, 70); this.lblPhoneLbl.AutoSize = true;
            this.lblPhoneVal.Text = "--"; this.lblPhoneVal.Font = fntVal; this.lblPhoneVal.ForeColor = clrTextDark; this.lblPhoneVal.Location = new System.Drawing.Point(24, 90); this.lblPhoneVal.AutoSize = true;

            this.lblEmailLbl.Text = "Email Address"; this.lblEmailLbl.Font = fntLbl; this.lblEmailLbl.ForeColor = clrTextLight; this.lblEmailLbl.Location = new System.Drawing.Point(250, 70); this.lblEmailLbl.AutoSize = true;
            this.lblEmailVal.Text = "--"; this.lblEmailVal.Font = fntVal; this.lblEmailVal.ForeColor = clrTextDark; this.lblEmailVal.Location = new System.Drawing.Point(250, 90); this.lblEmailVal.AutoSize = true;

            this.lblAddressLbl.Text = "Home Address"; this.lblAddressLbl.Font = fntLbl; this.lblAddressLbl.ForeColor = clrTextLight; this.lblAddressLbl.Location = new System.Drawing.Point(24, 140); this.lblAddressLbl.AutoSize = true;
            this.lblAddressVal.Text = "--"; this.lblAddressVal.Font = fntVal; this.lblAddressVal.ForeColor = clrTextDark; this.lblAddressVal.Location = new System.Drawing.Point(24, 160); this.lblAddressVal.AutoSize = true;

            this.lblEmergencyLbl.Text = "EMERGENCY CONTACT";
            this.lblEmergencyLbl.Font = fntLbl;
            this.lblEmergencyLbl.ForeColor = clrTeal;
            this.lblEmergencyLbl.Location = new System.Drawing.Point(24, 210);
            this.lblEmergencyLbl.AutoSize = true;

            this.lblEmergencyNameLbl.Text = "Name"; this.lblEmergencyNameLbl.Font = fntLbl; this.lblEmergencyNameLbl.ForeColor = clrTextLight; this.lblEmergencyNameLbl.Location = new System.Drawing.Point(24, 235); this.lblEmergencyNameLbl.AutoSize = true;
            this.lblEmergencyNameVal.Text = "--"; this.lblEmergencyNameVal.Font = fntVal; this.lblEmergencyNameVal.ForeColor = clrTextDark; this.lblEmergencyNameVal.Location = new System.Drawing.Point(24, 255); this.lblEmergencyNameVal.AutoSize = true;

            this.lblEmergencyRelLbl.Text = "Relationship"; this.lblEmergencyRelLbl.Font = fntLbl; this.lblEmergencyRelLbl.ForeColor = clrTextLight; this.lblEmergencyRelLbl.Location = new System.Drawing.Point(180, 235); this.lblEmergencyRelLbl.AutoSize = true;
            this.lblEmergencyRelVal.Text = "--"; this.lblEmergencyRelVal.Font = fntVal; this.lblEmergencyRelVal.ForeColor = clrTextDark; this.lblEmergencyRelVal.Location = new System.Drawing.Point(180, 255); this.lblEmergencyRelVal.AutoSize = true;

            this.lblEmergencyPhoneLbl.Text = "Phone"; this.lblEmergencyPhoneLbl.Font = fntLbl; this.lblEmergencyPhoneLbl.ForeColor = clrTextLight; this.lblEmergencyPhoneLbl.Location = new System.Drawing.Point(340, 235); this.lblEmergencyPhoneLbl.AutoSize = true;
            this.lblEmergencyPhoneVal.Text = "--"; this.lblEmergencyPhoneVal.Font = fntVal; this.lblEmergencyPhoneVal.ForeColor = clrTextDark; this.lblEmergencyPhoneVal.Location = new System.Drawing.Point(340, 255); this.lblEmergencyPhoneVal.AutoSize = true;

            this.cardPersonalInfo.Controls.AddRange(new System.Windows.Forms.Control[] { 
                accP1, this.lblPInfoTitle, this.btnEditPersonal, this.lblPhoneLbl, this.lblPhoneVal, this.lblEmailLbl, this.lblEmailVal, 
                this.lblAddressLbl, this.lblAddressVal, this.lblEmergencyLbl, 
                this.lblEmergencyNameLbl, this.lblEmergencyNameVal, 
                this.lblEmergencyRelLbl, this.lblEmergencyRelVal, 
                this.lblEmergencyPhoneLbl, this.lblEmergencyPhoneVal 
            });
            this.btnEditPersonal.BringToFront();

            // Card 2: Medical Overview
            this.cardMedicalOverview.BackColor = clrWhite;
            this.cardMedicalOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMedicalOverview.Margin = new System.Windows.Forms.Padding(12, 0, 0, 12);
            var accP2 = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblMedOverviewTitle.Text = "Medical Overview";
            this.lblMedOverviewTitle.Font = fntTitle;
            this.lblMedOverviewTitle.ForeColor = clrNavyActive;
            this.lblMedOverviewTitle.Location = new System.Drawing.Point(24, 24);
            this.lblMedOverviewTitle.AutoSize = true;

            this.lblBloodLbl.Text = "Blood Type"; this.lblBloodLbl.Font = fntLbl; this.lblBloodLbl.ForeColor = clrTextLight; this.lblBloodLbl.Location = new System.Drawing.Point(24, 70); this.lblBloodLbl.AutoSize = true;
            this.lblBloodVal.Text = "--"; this.lblBloodVal.Font = fntVal; this.lblBloodVal.ForeColor = clrTextDark; this.lblBloodVal.Location = new System.Drawing.Point(24, 90); this.lblBloodVal.AutoSize = true;

            this.lblHeightLbl.Text = "Height"; this.lblHeightLbl.Font = fntLbl; this.lblHeightLbl.ForeColor = clrTextLight; this.lblHeightLbl.Location = new System.Drawing.Point(150, 70); this.lblHeightLbl.AutoSize = true;
            this.lblHeightVal.Text = "--"; this.lblHeightVal.Font = fntVal; this.lblHeightVal.ForeColor = clrTextDark; this.lblHeightVal.Location = new System.Drawing.Point(150, 90); this.lblHeightVal.AutoSize = true;

            this.lblWeightLbl.Text = "Weight"; this.lblWeightLbl.Font = fntLbl; this.lblWeightLbl.ForeColor = clrTextLight; this.lblWeightLbl.Location = new System.Drawing.Point(280, 70); this.lblWeightLbl.AutoSize = true;
            this.lblWeightVal.Text = "--"; this.lblWeightVal.Font = fntVal; this.lblWeightVal.ForeColor = clrTextDark; this.lblWeightVal.Location = new System.Drawing.Point(280, 90); this.lblWeightVal.AutoSize = true;

            this.lblAllergiesLbl.Text = "Known Allergies"; this.lblAllergiesLbl.Font = fntLbl; this.lblAllergiesLbl.ForeColor = clrTextLight; this.lblAllergiesLbl.Location = new System.Drawing.Point(24, 140); this.lblAllergiesLbl.AutoSize = true;
            this.lblAllergiesVal.Text = "--"; this.lblAllergiesVal.Font = fntVal; this.lblAllergiesVal.ForeColor = clrTextDark; this.lblAllergiesVal.Location = new System.Drawing.Point(24, 160); this.lblAllergiesVal.AutoSize = true;

            this.cardMedicalOverview.Controls.AddRange(new System.Windows.Forms.Control[] { accP2, this.lblMedOverviewTitle, this.lblBloodLbl, this.lblBloodVal, this.lblHeightLbl, this.lblHeightVal, this.lblWeightLbl, this.lblWeightVal, this.lblAllergiesLbl, this.lblAllergiesVal });

            this.tlpProfileCards.Controls.Add(this.cardPersonalInfo, 0, 0);
            this.tlpProfileCards.Controls.Add(this.cardMedicalOverview, 1, 0);

            this.pnlContent.Controls.Add(this.tlpProfileCards);
            this.pnlContent.Controls.Add(pnlSpacer);
            this.pnlContent.Controls.Add(this.pnlHeaderCard);
            this.tlpProfileCards.BringToFront();
            pnlSpacer.SendToBack();
            this.pnlHeaderCard.SendToBack();

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
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlHeaderCard.PerformLayout();
            this.pnlAvatarLarge.ResumeLayout(false);
            this.tlpProfileCards.ResumeLayout(false);
            this.cardPersonalInfo.ResumeLayout(false);
            this.cardPersonalInfo.PerformLayout();
            this.cardMedicalOverview.ResumeLayout(false);
            this.cardMedicalOverview.PerformLayout();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavMeds.ResumeLayout(false);
            this.btnNavMedSchedule.ResumeLayout(false);
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
        
        // Profile components
        private System.Windows.Forms.Panel pnlHeaderCard;
        private System.Windows.Forms.Panel pnlAvatarLarge;
        private System.Windows.Forms.Label lblAvatarLargeInitials;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label lblPatientAge;
        
        private System.Windows.Forms.TableLayoutPanel tlpProfileCards;
        
        private System.Windows.Forms.Panel cardPersonalInfo;
        private System.Windows.Forms.Label lblPInfoTitle;
        private System.Windows.Forms.Label lblPhoneLbl;
        private System.Windows.Forms.Label lblPhoneVal;
        private System.Windows.Forms.Label lblEmailLbl;
        private System.Windows.Forms.Label lblEmailVal;
        private System.Windows.Forms.Label lblAddressLbl;
        private System.Windows.Forms.Label lblAddressVal;

        private System.Windows.Forms.Label lblEmergencyLbl;
        private System.Windows.Forms.Label lblEmergencyNameLbl;
        private System.Windows.Forms.Label lblEmergencyNameVal;
        private System.Windows.Forms.Label lblEmergencyRelLbl;
        private System.Windows.Forms.Label lblEmergencyRelVal;
        private System.Windows.Forms.Label lblEmergencyPhoneLbl;
        private System.Windows.Forms.Label lblEmergencyPhoneVal;
        private System.Windows.Forms.Button btnEditPersonal;

        private System.Windows.Forms.Panel cardMedicalOverview;
        private System.Windows.Forms.Label lblMedOverviewTitle;
        private System.Windows.Forms.Label lblBloodLbl;
        private System.Windows.Forms.Label lblBloodVal;
        private System.Windows.Forms.Label lblHeightLbl;
        private System.Windows.Forms.Label lblHeightVal;
        private System.Windows.Forms.Label lblWeightLbl;
        private System.Windows.Forms.Label lblWeightVal;
        private System.Windows.Forms.Label lblAllergiesLbl;
        private System.Windows.Forms.Label lblAllergiesVal;
    }
}
