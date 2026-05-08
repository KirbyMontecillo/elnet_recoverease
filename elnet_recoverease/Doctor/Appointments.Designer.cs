namespace elnet_recoverease.Doctor
{
    partial class Appointments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();

            // ── Declare all controls ──────────────────────────────────
            this.pnlSidebar          = new System.Windows.Forms.Panel();
            this.pnlLogoArea         = new System.Windows.Forms.Panel();
            this.picLogo             = new System.Windows.Forms.PictureBox();
            this.pnlNavDivider       = new System.Windows.Forms.Panel();
            this.btnNavDashboard     = new System.Windows.Forms.Panel();
            this.lblNavDashIcon      = new System.Windows.Forms.Label();
            this.lblNavDashText      = new System.Windows.Forms.Label();
            this.btnNavPatients      = new System.Windows.Forms.Panel();
            this.lblNavPatientsIcon  = new System.Windows.Forms.Label();
            this.lblNavPatientsText  = new System.Windows.Forms.Label();
            this.btnNavAppointments  = new System.Windows.Forms.Panel();
            this.lblNavApptIcon      = new System.Windows.Forms.Label();
            this.lblNavApptText      = new System.Windows.Forms.Label();
            this.btnNavReports       = new System.Windows.Forms.Panel();
            this.lblNavReportsIcon   = new System.Windows.Forms.Label();
            this.lblNavReportsText   = new System.Windows.Forms.Label();
            this.btnNavProfile       = new System.Windows.Forms.Panel();
            this.lblNavProfileIcon   = new System.Windows.Forms.Label();
            this.lblNavProfileText   = new System.Windows.Forms.Label();
            this.pnlSidebarBottom    = new System.Windows.Forms.Panel();
            this.lblSidebarFooter    = new System.Windows.Forms.Label();
            this.btnLogout           = new System.Windows.Forms.Button();

            this.pnlMain             = new System.Windows.Forms.Panel();
            this.pnlTopBar           = new System.Windows.Forms.Panel();
            this.lblPageTitle        = new System.Windows.Forms.Label();
            this.pnlNotifBell        = new System.Windows.Forms.Panel();
            this.lblBellIcon         = new System.Windows.Forms.Label();
            this.lblNotifBadge       = new System.Windows.Forms.Label();
            this.pnlAvatarTop        = new System.Windows.Forms.Panel();
            this.lblAvatarInitials   = new System.Windows.Forms.Label();

            this.pnlContent          = new System.Windows.Forms.Panel();
            this.pnlActionHeader     = new System.Windows.Forms.Panel();
            this.lblFilterDate       = new System.Windows.Forms.Label();
            this.dtpFilterDate       = new System.Windows.Forms.DateTimePicker();
            this.lblFilterStatus     = new System.Windows.Forms.Label();
            this.cmbFilterStatus     = new System.Windows.Forms.ComboBox();
            this.btnNewAppointment   = new System.Windows.Forms.Button();
            this.dgvAppointments     = new System.Windows.Forms.DataGridView();

            // ── Suspend layout ────────────────────────────────────────
            this.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlActionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavAppointments.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.btnNavProfile.SuspendLayout();

            // ── Colors ────────────────────────────────────────────────
            System.Drawing.Color clrTeal       = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy       = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyLight  = System.Drawing.ColorTranslator.FromHtml("#D0DBE8");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg         = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite      = System.Drawing.Color.White;
            System.Drawing.Color clrTextDark   = System.Drawing.Color.FromArgb(30, 43, 60);
            System.Drawing.Color clrTextMid    = System.Drawing.Color.FromArgb(100, 120, 145);
            System.Drawing.Color clrBorder     = System.Drawing.ColorTranslator.FromHtml("#E2E8F0");

            // ══════════════════════════════════════════════════════════
            // FORM
            // ══════════════════════════════════════════════════════════
            this.Text = "RecoverEase — Appointments";
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackColor = clrBg;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            // ══════════════════════════════════════════════════════════
            // SIDEBAR
            // ══════════════════════════════════════════════════════════
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 260;

            // Logo
            this.pnlLogoArea.BackColor = clrNavy;
            this.pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoArea.Height = 90;
            this.pnlLogoArea.Padding = new System.Windows.Forms.Padding(16, 18, 8, 8);
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlLogoArea.Controls.Add(this.picLogo);

            // Divider
            this.pnlNavDivider.BackColor = clrNavyLight;
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

            // ── Patients (Inactive)
            this.btnNavPatients.Size = new System.Drawing.Size(260, 48);
            this.btnNavPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPatients.BackColor = clrNavy;
            this.btnNavPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavPatientsIcon.Text = "\U0001F465";
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

            // Appointments — ACTIVE
            this.btnNavAppointments.Size = new System.Drawing.Size(260, 48);
            this.btnNavAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAppointments.BackColor = clrNavyActive;
            this.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            var accAppt = new System.Windows.Forms.Panel { BackColor = clrTeal, Width = 4, Dock = System.Windows.Forms.DockStyle.Left };
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
            this.btnNavAppointments.Controls.Add(accAppt);
            this.btnNavAppointments.Controls.Add(this.lblNavApptIcon);
            this.btnNavAppointments.Controls.Add(this.lblNavApptText);

            // Sidebar bottom
            this.pnlSidebarBottom.BackColor = clrNavy;
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Height = 40;
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
            this.btnLogout.FlatAppearance.MouseOverBackColor = clrNavyLight;
            this.btnLogout.Size = new System.Drawing.Size(188, 26);
            this.btnLogout.Location = new System.Drawing.Point(16, 32);
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Visible = false;
            this.pnlSidebarBottom.Controls.Add(this.lblSidebarFooter);
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);

            // Add sidebar items (reverse dock order)
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);

            // ══════════════════════════════════════════════════════════
            // TOP BAR
            // ══════════════════════════════════════════════════════════
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 80;

            var pnlTopBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 1, BackColor = clrBorder };
            this.pnlTopBar.Controls.Add(pnlTopBorder);

            this.lblPageTitle.Text = "Appointments";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = clrNavyActive;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Location = new System.Drawing.Point(28, 22);
            this.pnlTopBar.Controls.Add(this.lblPageTitle);

            this.pnlNotifBell.Size = new System.Drawing.Size(38, 38);
            this.pnlNotifBell.BackColor = clrBg;
            this.pnlNotifBell.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlNotifBell.Location = new System.Drawing.Point(880, 20);
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
            this.pnlTopBar.Controls.Add(this.pnlNotifBell);

            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlAvatarTop.Location = new System.Drawing.Point(930, 20);
            this.pnlAvatarTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAvatarInitials.Text = "Dr";
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11f, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlTopBar.Controls.Add(this.pnlAvatarTop);

            // ══════════════════════════════════════════════════════════
            // CONTENT
            // ══════════════════════════════════════════════════════════
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);

            // ── Action Header ──────────────────────────────────────────
            this.pnlActionHeader.BackColor = clrWhite;
            this.pnlActionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionHeader.Height = 76;
            this.pnlActionHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            var pnlActionBorder = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Bottom, Height = 1, BackColor = clrBorder };
            this.pnlActionHeader.Controls.Add(pnlActionBorder);

            // Date Filter Label
            this.lblFilterDate.Text = "Date";
            this.lblFilterDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblFilterDate.ForeColor = clrTextDark;
            this.lblFilterDate.AutoSize = true;
            this.lblFilterDate.Location = new System.Drawing.Point(16, 12);
            this.pnlActionHeader.Controls.Add(this.lblFilterDate);

            this.dtpFilterDate.Location = new System.Drawing.Point(16, 34);
            this.dtpFilterDate.Size = new System.Drawing.Size(200, 32);
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pnlActionHeader.Controls.Add(this.dtpFilterDate);

            // Status Filter Label
            this.lblFilterStatus.Text = "Status";
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = clrTextDark;
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(236, 12);
            this.pnlActionHeader.Controls.Add(this.lblFilterStatus);

            this.cmbFilterStatus.Location = new System.Drawing.Point(236, 34);
            this.cmbFilterStatus.Size = new System.Drawing.Size(180, 32);
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Missed" });
            this.cmbFilterStatus.SelectedIndex = 0;
            this.pnlActionHeader.Controls.Add(this.cmbFilterStatus);

            // New Appointment button
            this.btnNewAppointment.Text = "+ New Appointment";
            this.btnNewAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 10f, System.Drawing.FontStyle.Bold);
            this.btnNewAppointment.BackColor = clrTeal;
            this.btnNewAppointment.ForeColor = clrWhite;
            this.btnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAppointment.FlatAppearance.BorderSize = 0;
            this.btnNewAppointment.Size = new System.Drawing.Size(190, 40);
            this.btnNewAppointment.Location = new System.Drawing.Point(440, 18);
            this.btnNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlActionHeader.Controls.Add(this.btnNewAppointment);

            // ── Appointments DataGridView ──────────────────────────────
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.BackgroundColor = clrWhite;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            headerStyle.BackColor = clrNavy;
            headerStyle.ForeColor = clrNavyActive;
            headerStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.SelectionBackColor = clrNavy;
            headerStyle.SelectionForeColor = clrNavyActive;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvAppointments.ColumnHeadersHeight = 48;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.GridColor = clrBorder;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 50;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            var colPatient  = new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "PATIENT NAME",  FillWeight = 22 };
            var colDate     = new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "DATE & TIME",   FillWeight = 20 };
            var colStatus   = new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "STATUS",        FillWeight = 14 };
            var colNotes    = new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "CLINICAL NOTES", FillWeight = 34 };
            var colAction   = new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "ACTION",        FillWeight = 10 };

            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colPatient, colDate, colStatus, colNotes, colAction
            });

            // Assemble content panel
            this.pnlContent.Controls.Add(this.dgvAppointments);
            this.pnlContent.Controls.Add(this.pnlActionHeader);

            // Assemble main
            this.pnlMain.BackColor = clrBg;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlTopBar);

            // Assemble form
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);

            // ── Resume layouts ────────────────────────────────────────
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlActionHeader.ResumeLayout(false);
            this.pnlActionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavAppointments.ResumeLayout(false);
            this.btnNavReports.ResumeLayout(false);
            this.btnNavProfile.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ─────────────────────────────────────────
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
        private System.Windows.Forms.Panel pnlNotifBell;
        private System.Windows.Forms.Label lblBellIcon;
        private System.Windows.Forms.Label lblNotifBadge;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlActionHeader;
        private System.Windows.Forms.Label lblFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
    }
}