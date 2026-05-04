namespace elnet_recoverease.Doctor
{
    partial class Patient_Attachments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlActionHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateUploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.pnlActionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
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

            // Nav Items
            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(208, 219, 232);
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Location = new System.Drawing.Point(0, 90);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(260, 1);
            this.pnlNavDivider.TabIndex = 1;

            // Dashboard
            this.btnNavDashboard.Controls.Add(this.lblNavDashIcon);
            this.btnNavDashboard.Controls.Add(this.lblNavDashText);
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 91);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(260, 48);
            this.btnNavDashboard.TabIndex = 2;
            this.lblNavDashIcon.AutoSize = true;
            this.lblNavDashIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavDashIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavDashIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavDashIcon.Text = "\u229E";
            this.lblNavDashText.AutoSize = true;
            this.lblNavDashText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavDashText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavDashText.Location = new System.Drawing.Point(64, 13);
            this.lblNavDashText.Text = "Dashboard";

            // Patients (Active for context)
            this.btnNavPatients.BackColor = clrNavyActive;
            this.btnNavPatients.Controls.Add(this.lblNavPatientsIcon);
            this.btnNavPatients.Controls.Add(this.lblNavPatientsText);
            this.btnNavPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPatients.Location = new System.Drawing.Point(0, 139);
            this.btnNavPatients.Name = "btnNavPatients";
            this.btnNavPatients.Size = new System.Drawing.Size(260, 48);
            this.btnNavPatients.TabIndex = 3;
            this.lblNavPatientsIcon.AutoSize = true;
            this.lblNavPatientsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsIcon.ForeColor = clrWhite;
            this.lblNavPatientsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavPatientsIcon.Text = "👥";
            this.lblNavPatientsText.AutoSize = true;
            this.lblNavPatientsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavPatientsText.ForeColor = clrWhite;
            this.lblNavPatientsText.Location = new System.Drawing.Point(64, 13);
            this.lblNavPatientsText.Text = "My Patients";

            // Appointments
            this.btnNavAppointments.Controls.Add(this.lblNavApptIcon);
            this.btnNavAppointments.Controls.Add(this.lblNavApptText);
            this.btnNavAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAppointments.Location = new System.Drawing.Point(0, 187);
            this.btnNavAppointments.Name = "btnNavAppointments";
            this.btnNavAppointments.Size = new System.Drawing.Size(260, 48);
            this.btnNavAppointments.TabIndex = 4;
            this.lblNavApptIcon.AutoSize = true;
            this.lblNavApptIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavApptIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavApptIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavApptIcon.Text = "📅";
            this.lblNavApptText.AutoSize = true;
            this.lblNavApptText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavApptText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavApptText.Location = new System.Drawing.Point(64, 13);
            this.lblNavApptText.Text = "Appointments";

            // Reports
            this.btnNavReports.Controls.Add(this.lblNavReportsIcon);
            this.btnNavReports.Controls.Add(this.lblNavReportsText);
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavReports.Location = new System.Drawing.Point(0, 235);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(260, 48);
            this.btnNavReports.TabIndex = 5;
            this.lblNavReportsIcon.AutoSize = true;
            this.lblNavReportsIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavReportsIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavReportsIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavReportsIcon.Text = "📊";
            this.lblNavReportsText.AutoSize = true;
            this.lblNavReportsText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavReportsText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavReportsText.Location = new System.Drawing.Point(64, 13);
            this.lblNavReportsText.Text = "Reports & Analytics";

            // Profile
            this.btnNavProfile.Controls.Add(this.lblNavProfileIcon);
            this.btnNavProfile.Controls.Add(this.lblNavProfileText);
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProfile.Location = new System.Drawing.Point(0, 283);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(260, 48);
            this.btnNavProfile.TabIndex = 6;
            this.lblNavProfileIcon.AutoSize = true;
            this.lblNavProfileIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblNavProfileIcon.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavProfileIcon.Location = new System.Drawing.Point(20, 11);
            this.lblNavProfileIcon.Text = "👤";
            this.lblNavProfileText.AutoSize = true;
            this.lblNavProfileText.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavProfileText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNavProfileText.Location = new System.Drawing.Point(64, 13);
            this.lblNavProfileText.Text = "My Profile";

            // Sidebar Bottom
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
            this.lblSidebarFooter.Text = "Secure Healthcare Platform";
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
            this.btnLogout.UseVisualStyleBackColor = true;

            // TopBar
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
            this.lblPageTitle.Text = "Patient Documents & Attachments";

            this.pnlAvatarTop.BackColor = clrTeal;
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlAvatarTop.Location = new System.Drawing.Point(1270, 20);
            this.pnlAvatarTop.Name = "pnlAvatarTop";
            this.pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarTop.TabIndex = 2;
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = clrWhite;
            this.lblAvatarInitials.Location = new System.Drawing.Point(0, 0);
            this.lblAvatarInitials.Name = "lblAvatarInitials";
            this.lblAvatarInitials.Size = new System.Drawing.Size(40, 40);
            this.lblAvatarInitials.TabIndex = 0;
            this.lblAvatarInitials.Text = "Dr";
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Content
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Controls.Add(this.dgvAttachments);
            this.pnlContent.Controls.Add(this.pnlActionHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(1340, 820);
            this.pnlContent.TabIndex = 2;

            // Action Header
            this.pnlActionHeader.BackColor = clrWhite;
            this.pnlActionHeader.Controls.Add(this.lblSearchLabel);
            this.pnlActionHeader.Controls.Add(this.btnUpload);
            this.pnlActionHeader.Controls.Add(this.txtSearch);
            this.pnlActionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionHeader.Location = new System.Drawing.Point(24, 24);
            this.pnlActionHeader.Name = "pnlActionHeader";
            this.pnlActionHeader.Size = new System.Drawing.Size(1292, 80);
            this.pnlActionHeader.TabIndex = 0;

            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 145);
            this.lblSearchLabel.Location = new System.Drawing.Point(20, 14);
            this.lblSearchLabel.Text = "SEARCH BY FILENAME";

            this.txtSearch.BackColor = clrBg;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(20, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 25);
            this.txtSearch.TabIndex = 0;

            this.btnUpload.BackColor = clrTeal;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = clrWhite;
            this.btnUpload.Location = new System.Drawing.Point(1112, 20);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(160, 40);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "+ Upload File";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // DataGridView
            this.dgvAttachments.AllowUserToAddRows = false;
            this.dgvAttachments.AllowUserToDeleteRows = false;
            this.dgvAttachments.BackgroundColor = clrWhite;
            this.dgvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttachments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = clrNavy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = clrNavyActive;
            dataGridViewCellStyle1.SelectionBackColor = clrNavy;
            dataGridViewCellStyle1.SelectionForeColor = clrNavyActive;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttachments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttachments.ColumnHeadersHeight = 50;
            this.dgvAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colDateUploaded,
            this.colAction});
            this.dgvAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttachments.EnableHeadersVisualStyles = false;
            this.dgvAttachments.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvAttachments.Location = new System.Drawing.Point(24, 104);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.ReadOnly = true;
            this.dgvAttachments.RowHeadersVisible = false;
            this.dgvAttachments.RowTemplate.Height = 50;
            this.dgvAttachments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttachments.Size = new System.Drawing.Size(1292, 692);
            this.dgvAttachments.TabIndex = 1;

            // colFileName
            this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFileName.HeaderText = "FILE NAME";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;

            // colDateUploaded
            this.colDateUploaded.HeaderText = "DATE UPLOADED";
            this.colDateUploaded.Name = "colDateUploaded";
            this.colDateUploaded.ReadOnly = true;
            this.colDateUploaded.Width = 250;

            // colAction
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colAction.HeaderText = "ACTION";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Text = "View / Delete";
            this.colAction.UseColumnTextForButtonValue = true;
            this.colAction.Width = 150;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Patient_Attachments";
            this.Text = "RecoverEase - Patient Attachments";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavDashboard.PerformLayout();
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavPatients.PerformLayout();
            this.btnNavAppointments.ResumeLayout(false);
            this.btnNavAppointments.PerformLayout();
            this.btnNavReports.ResumeLayout(false);
            this.btnNavReports.PerformLayout();
            this.btnNavProfile.ResumeLayout(false);
            this.btnNavProfile.PerformLayout();
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlSidebarBottom.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlActionHeader.ResumeLayout(false);
            this.pnlActionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

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
        private System.Windows.Forms.Panel pnlActionHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.DataGridView dgvAttachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateUploaded;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}