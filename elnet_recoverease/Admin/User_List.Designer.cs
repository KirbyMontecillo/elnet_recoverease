namespace elnet_recoverease.Admin
{
    partial class User_List
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogoArea = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavDivider = new System.Windows.Forms.Panel();
            this.btnNavDashboard = new System.Windows.Forms.Panel();
            this.lblNavDashIcon = new System.Windows.Forms.Label();
            this.lblNavDashText = new System.Windows.Forms.Label();
            this.btnNavStaff = new System.Windows.Forms.Panel();
            this.lblNavStaffIcon = new System.Windows.Forms.Label();
            this.lblNavStaffText = new System.Windows.Forms.Label();
            this.btnNavUsers = new System.Windows.Forms.Panel();
            this.lblNavUsersIcon = new System.Windows.Forms.Label();
            this.lblNavUsersText = new System.Windows.Forms.Label();
            this.btnNavPatients = new System.Windows.Forms.Panel();
            this.lblNavPatientsIcon = new System.Windows.Forms.Label();
            this.lblNavPatientsText = new System.Windows.Forms.Label();
            this.btnNavReports = new System.Windows.Forms.Panel();
            this.lblNavReportsIcon = new System.Windows.Forms.Label();
            this.lblNavReportsText = new System.Windows.Forms.Label();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.lblSidebarFooter = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlActionHeader = new System.Windows.Forms.Panel();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavStaff.SuspendLayout();
            this.btnNavUsers.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlActionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;

            // Sidebar
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.Controls.Add(this.btnNavStaff);
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

            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(208, 219, 232);
            this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDivider.Location = new System.Drawing.Point(0, 90);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(260, 1);
            this.pnlNavDivider.TabIndex = 1;

            // Nav Build Helper
            void SetupNavItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, string icoChar, string label, bool isActive)
            {
                pnl.Cursor = System.Windows.Forms.Cursors.Hand;
                pnl.Dock = System.Windows.Forms.DockStyle.Top;
                pnl.Size = new System.Drawing.Size(260, 48);
                if (isActive) pnl.BackColor = clrNavyActive;
                ico.AutoSize = true;
                ico.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
                ico.ForeColor = isActive ? clrWhite : System.Drawing.Color.FromArgb(45, 55, 72);
                ico.Location = new System.Drawing.Point(20, 11);
                ico.Text = icoChar;
                txt.AutoSize = true;
                txt.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
                txt.ForeColor = isActive ? clrWhite : System.Drawing.Color.FromArgb(45, 55, 72);
                txt.Location = new System.Drawing.Point(64, 13);
                txt.Text = label;
                pnl.Controls.Add(ico);
                pnl.Controls.Add(txt);
            }

            SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "\u229E", "Admin Dashboard", false);
            SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", false);
            SetupNavItem(this.btnNavUsers, this.lblNavUsersIcon, this.lblNavUsersText, "🔑", "User Accounts", true);
            SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "👥", "Global Patient List", false);
            SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", false);

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
            this.lblSidebarFooter.Text = "RecoverEase Admin Portal";
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
            this.lblPageTitle.Text = "User Account Management";

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
            this.lblAvatarInitials.Text = "AD";
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Content
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Controls.Add(this.dgvUsers);
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
            this.pnlActionHeader.Controls.Add(this.btnAddUser);
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
            this.lblSearchLabel.Text = "SEARCH USERS";

            this.txtSearch.BackColor = clrBg;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(20, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 25);
            this.txtSearch.TabIndex = 0;

            this.btnAddUser.BackColor = clrTeal;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = clrWhite;
            this.btnAddUser.Location = new System.Drawing.Point(1112, 20);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(160, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "+ Add New User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // DataGridView
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = clrWhite;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = clrNavy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = clrNavyActive;
            dataGridViewCellStyle1.SelectionBackColor = clrNavy;
            dataGridViewCellStyle1.SelectionForeColor = clrNavyActive;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeight = 50;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colRole,
            this.colDateCreated,
            this.colAction});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvUsers.Location = new System.Drawing.Point(24, 104);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 50;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1292, 692);
            this.dgvUsers.TabIndex = 1;

            // colUsername
            this.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsername.HeaderText = "USERNAME";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;

            // colRole
            this.colRole.HeaderText = "ROLE";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 200;

            // colDateCreated
            this.colDateCreated.HeaderText = "DATE CREATED";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.ReadOnly = true;
            this.colDateCreated.Width = 250;

            // colAction
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colAction.HeaderText = "ACTION";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Text = "Edit / Delete";
            this.colAction.UseColumnTextForButtonValue = true;
            this.colAction.Width = 150;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "User_List";
            this.Text = "RecoverEase - User Accounts";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.btnNavDashboard.ResumeLayout(false);
            this.btnNavDashboard.PerformLayout();
            this.btnNavStaff.ResumeLayout(false);
            this.btnNavStaff.PerformLayout();
            this.btnNavUsers.ResumeLayout(false);
            this.btnNavUsers.PerformLayout();
            this.btnNavPatients.ResumeLayout(false);
            this.btnNavPatients.PerformLayout();
            this.btnNavReports.ResumeLayout(false);
            this.btnNavReports.PerformLayout();
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlSidebarBottom.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlActionHeader.ResumeLayout(false);
            this.pnlActionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
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
        private System.Windows.Forms.Panel btnNavStaff;
        private System.Windows.Forms.Label lblNavStaffIcon;
        private System.Windows.Forms.Label lblNavStaffText;
        private System.Windows.Forms.Panel btnNavUsers;
        private System.Windows.Forms.Label lblNavUsersIcon;
        private System.Windows.Forms.Label lblNavUsersText;
        private System.Windows.Forms.Panel btnNavPatients;
        private System.Windows.Forms.Label lblNavPatientsIcon;
        private System.Windows.Forms.Label lblNavPatientsText;
        private System.Windows.Forms.Panel btnNavReports;
        private System.Windows.Forms.Label lblNavReportsIcon;
        private System.Windows.Forms.Label lblNavReportsText;
        private System.Windows.Forms.Panel pnlSidebarBottom;
        private System.Windows.Forms.Label lblSidebarFooter;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlActionHeader;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreated;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}