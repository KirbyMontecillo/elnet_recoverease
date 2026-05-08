namespace elnet_recoverease.Admin
{
    partial class Staff_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlSidebar = new System.Windows.Forms.Panel();
            pnlSidebarBottom = new System.Windows.Forms.Panel();
            btnNavProfile = new System.Windows.Forms.Panel();
            btnNavReports = new System.Windows.Forms.Panel();
            btnNavPatients = new System.Windows.Forms.Panel();
            btnNavStaff = new System.Windows.Forms.Panel();
            btnNavDashboard = new System.Windows.Forms.Panel();
            pnlNavDivider = new System.Windows.Forms.Panel();
            pnlLogoArea = new System.Windows.Forms.Panel();
            lblSidebarFooter = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            lblNavDashIcon = new System.Windows.Forms.Label();
            lblNavDashText = new System.Windows.Forms.Label();
            lblNavStaffIcon = new System.Windows.Forms.Label();
            lblNavStaffText = new System.Windows.Forms.Label();
            lblNavPatientsIcon = new System.Windows.Forms.Label();
            lblNavPatientsText = new System.Windows.Forms.Label();
            lblNavReportsIcon = new System.Windows.Forms.Label();
            lblNavReportsText = new System.Windows.Forms.Label();
            lblNavProfileIcon = new System.Windows.Forms.Label();
            lblNavProfileText = new System.Windows.Forms.Label();
            pnlTopBar = new System.Windows.Forms.Panel();
            pnlTopIcons = new System.Windows.Forms.FlowLayoutPanel();
            pnlAvatarTop = new System.Windows.Forms.Panel();
            lblAvatarInitials = new System.Windows.Forms.Label();
            lblNotifIcon = new System.Windows.Forms.Label();
            lblPageSubtitle = new System.Windows.Forms.Label();
            lblPageTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            pnlListCard = new System.Windows.Forms.Panel();
            dgvStaff = new System.Windows.Forms.DataGridView();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPatients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colView = new System.Windows.Forms.DataGridViewButtonColumn();
            colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            pnlPagination = new System.Windows.Forms.Panel();
            lblShowingCount = new System.Windows.Forms.Label();
            pnlFilters = new System.Windows.Forms.Panel();
            lblSearchLabel = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            cmbRoleFilter = new System.Windows.Forms.ComboBox();
            cmbStatusFilter = new System.Windows.Forms.ComboBox();
            pnlListHeader = new System.Windows.Forms.Panel();
            lblListTitle = new System.Windows.Forms.Label();
            btnAddStaff = new System.Windows.Forms.Button();
            tlpStats = new System.Windows.Forms.TableLayoutPanel();
            pnlStatTotal = new System.Windows.Forms.Panel();
            lblStatTotalVal = new System.Windows.Forms.Label();
            lblStatTotalTitle = new System.Windows.Forms.Label();
            lblStatTotalSub = new System.Windows.Forms.Label();
            pnlStatDoctors = new System.Windows.Forms.Panel();
            lblStatDoctorsVal = new System.Windows.Forms.Label();
            lblStatDoctorsTitle = new System.Windows.Forms.Label();
            lblStatDoctorsSub = new System.Windows.Forms.Label();
            picLogo = new System.Windows.Forms.PictureBox();
            pnlSidebar.SuspendLayout();
            pnlLogoArea.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlTopIcons.SuspendLayout();
            pnlAvatarTop.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            pnlPagination.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlListHeader.SuspendLayout();
            tlpStats.SuspendLayout();
            pnlStatTotal.SuspendLayout();
            pnlStatDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(238, 243, 247);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(btnNavProfile);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnNavPatients);
            pnlSidebar.Controls.Add(btnNavStaff);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(pnlNavDivider);
            pnlSidebar.Controls.Add(pnlLogoArea);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(260, 900);
            pnlSidebar.TabIndex = 0;

            // Sidebar Bottom
            pnlSidebarBottom.Controls.Add(lblSidebarFooter);
            pnlSidebarBottom.Controls.Add(btnLogout);
            pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlSidebarBottom.Location = new System.Drawing.Point(0, 840);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Size = new System.Drawing.Size(260, 60);
            pnlSidebarBottom.TabIndex = 7;

            lblSidebarFooter.AutoSize = false;
            lblSidebarFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSidebarFooter.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSidebarFooter.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            lblSidebarFooter.Location = new System.Drawing.Point(0, 0);
            lblSidebarFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblSidebarFooter.Text = "RecoverEase Admin Portal";

            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btnLogout.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            btnLogout.Location = new System.Drawing.Point(16, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(188, 26);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "⇠  Sign Out";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.Visible = false;

            // Navigation Items
            SetupNavItem(btnNavProfile, lblNavProfileIcon, lblNavProfileText, "👤", "My Profile", false, System.Drawing.Color.FromArgb(27, 58, 107), System.Drawing.Color.White);
            SetupNavItem(btnNavReports, lblNavReportsIcon, lblNavReportsText, "📊", "System Reports", false, System.Drawing.Color.FromArgb(27, 58, 107), System.Drawing.Color.White);
            SetupNavItem(btnNavPatients, lblNavPatientsIcon, lblNavPatientsText, "💊", "Medication List", false, System.Drawing.Color.FromArgb(27, 58, 107), System.Drawing.Color.White);
            SetupNavItem(btnNavStaff, lblNavStaffIcon, lblNavStaffText, "🩺", "Staff Management", true, System.Drawing.Color.FromArgb(27, 58, 107), System.Drawing.Color.White);
            SetupNavItem(btnNavDashboard, lblNavDashIcon, lblNavDashText, "⊞", "Admin Dashboard", false, System.Drawing.Color.FromArgb(27, 58, 107), System.Drawing.Color.White);

            // 
            // pnlNavDivider
            // 
            pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top;
            pnlNavDivider.Location = new System.Drawing.Point(0, 120);
            pnlNavDivider.Name = "pnlNavDivider";
            pnlNavDivider.Size = new System.Drawing.Size(260, 1);
            pnlNavDivider.TabIndex = 1;

            // 
            // pnlLogoArea
            // 
            pnlLogoArea.BackColor = System.Drawing.Color.FromArgb(238, 243, 247);
            pnlLogoArea.Controls.Add(picLogo);
            pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogoArea.Location = new System.Drawing.Point(0, 0);
            pnlLogoArea.Name = "pnlLogoArea";
            pnlLogoArea.Padding = new System.Windows.Forms.Padding(35, 25, 35, 15);
            pnlLogoArea.Size = new System.Drawing.Size(260, 120);
            pnlLogoArea.TabIndex = 0;

            // picLogo
            picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            picLogo.Location = new System.Drawing.Point(35, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(190, 80);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;

            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = System.Drawing.Color.White;
            pnlTopBar.Controls.Add(pnlTopIcons);
            pnlTopBar.Controls.Add(lblPageSubtitle);
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopBar.Location = new System.Drawing.Point(260, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new System.Drawing.Size(1340, 90);
            pnlTopBar.TabIndex = 1;
            // 
            // pnlTopIcons
            // 
            pnlTopIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pnlTopIcons.Controls.Add(pnlAvatarTop);
            pnlTopIcons.Controls.Add(lblNotifIcon);
            pnlTopIcons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            pnlTopIcons.Location = new System.Drawing.Point(1100, 20);
            pnlTopIcons.Name = "pnlTopIcons";
            pnlTopIcons.Size = new System.Drawing.Size(220, 50);
            pnlTopIcons.TabIndex = 0;
            // 
            // pnlAvatarTop
            // 
            pnlAvatarTop.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            pnlAvatarTop.Controls.Add(lblAvatarInitials);
            pnlAvatarTop.Location = new System.Drawing.Point(177, 3);
            pnlAvatarTop.Name = "pnlAvatarTop";
            pnlAvatarTop.Size = new System.Drawing.Size(40, 40);
            pnlAvatarTop.TabIndex = 0;
            pnlAvatarTop.Visible = false;
            // 
            // lblAvatarInitials
            // 
            lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAvatarInitials.Location = new System.Drawing.Point(0, 0);
            lblAvatarInitials.Name = "lblAvatarInitials";
            lblAvatarInitials.Size = new System.Drawing.Size(40, 40);
            lblAvatarInitials.TabIndex = 0;
            lblAvatarInitials.Text = "AD";
            lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotifIcon
            // 
            lblNotifIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            lblNotifIcon.Location = new System.Drawing.Point(71, 0);
            lblNotifIcon.Name = "lblNotifIcon";
            lblNotifIcon.Size = new System.Drawing.Size(100, 23);
            lblNotifIcon.TabIndex = 1;
            lblNotifIcon.Text = "🔔";
            lblNotifIcon.Visible = false;
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new System.Drawing.Size(290, 23);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Manage doctors and healthcare staff";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblPageTitle.Location = new System.Drawing.Point(24, 15);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new System.Drawing.Size(281, 41);
            lblPageTitle.TabIndex = 2;
            lblPageTitle.Text = "Staff Management";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            pnlContent.Controls.Add(pnlListCard);
            pnlContent.Controls.Add(tlpStats);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(260, 90);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(24);
            pnlContent.Size = new System.Drawing.Size(1340, 810);
            pnlContent.TabIndex = 0;
            // 
            // pnlListCard
            // 
            pnlListCard.BackColor = System.Drawing.Color.White;
            pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlListCard.Controls.Add(dgvStaff);
            pnlListCard.Controls.Add(pnlPagination);
            pnlListCard.Controls.Add(pnlFilters);
            pnlListCard.Controls.Add(pnlListHeader);
            pnlListCard.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlListCard.Location = new System.Drawing.Point(24, 174);
            pnlListCard.Name = "pnlListCard";
            pnlListCard.Size = new System.Drawing.Size(1292, 612);
            pnlListCard.TabIndex = 0;
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.BackgroundColor = System.Drawing.Color.White;
            dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStaff.ColumnHeadersHeight = 50;
            dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colName, colRole, colSpecialty, colPatients, colStatus, colView, colEdit, colDelete });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvStaff.DefaultCellStyle = dataGridViewCellStyle4;
            dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.GridColor = System.Drawing.Color.FromArgb(237, 242, 247);
            dgvStaff.Location = new System.Drawing.Point(0, 145);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersVisible = false;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 65;
            dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new System.Drawing.Size(1290, 415);
            dgvStaff.TabIndex = 0;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            // 
            // colSpecialty
            // 
            colSpecialty.HeaderText = "Specialty";
            colSpecialty.MinimumWidth = 6;
            colSpecialty.Name = "colSpecialty";
            // 
            // colPatients
            // 
            colPatients.HeaderText = "Patients";
            colPatients.MinimumWidth = 6;
            colPatients.Name = "colPatients";
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            // 
            // colView
            // 
            colView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            colView.HeaderText = "Actions";
            colView.MinimumWidth = 6;
            colView.Name = "colView";
            colView.Text = "👁 View";
            colView.UseColumnTextForButtonValue = true;
            // 
            // colEdit
            // 
            colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.Text = "✏ Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑 Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlPagination
            // 
            pnlPagination.Controls.Add(lblShowingCount);
            pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlPagination.Location = new System.Drawing.Point(0, 560);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new System.Drawing.Size(1290, 50);
            pnlPagination.TabIndex = 1;
            // 
            // lblShowingCount
            // 
            lblShowingCount.AutoSize = true;
            lblShowingCount.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            lblShowingCount.Location = new System.Drawing.Point(24, 15);
            lblShowingCount.Name = "lblShowingCount";
            lblShowingCount.Size = new System.Drawing.Size(0, 20);
            lblShowingCount.TabIndex = 0;
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(lblSearchLabel);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(cmbRoleFilter);
            pnlFilters.Controls.Add(cmbStatusFilter);
            pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilters.Location = new System.Drawing.Point(0, 80);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new System.Drawing.Size(1290, 65);
            pnlFilters.TabIndex = 2;
            // 
            // lblSearchLabel
            // 
            lblSearchLabel.AutoSize = true;
            lblSearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            lblSearchLabel.Location = new System.Drawing.Point(24, 18);
            lblSearchLabel.Name = "lblSearchLabel";
            lblSearchLabel.Size = new System.Drawing.Size(59, 20);
            lblSearchLabel.TabIndex = 0;
            lblSearchLabel.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtSearch.Location = new System.Drawing.Point(100, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(200, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRoleFilter.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            cmbRoleFilter.Items.AddRange(new object[] { "All roles", "Doctor", "Admin" });
            cmbRoleFilter.Location = new System.Drawing.Point(330, 15);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new System.Drawing.Size(200, 31);
            cmbRoleFilter.TabIndex = 2;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            cmbStatusFilter.Items.AddRange(new object[] { "All status", "Active", "Inactive" });
            cmbStatusFilter.Location = new System.Drawing.Point(560, 15);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new System.Drawing.Size(200, 31);
            cmbStatusFilter.TabIndex = 3;
            // 
            // pnlListHeader
            // 
            pnlListHeader.Controls.Add(lblListTitle);
            pnlListHeader.Controls.Add(btnAddStaff);
            pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlListHeader.Location = new System.Drawing.Point(0, 0);
            pnlListHeader.Name = "pnlListHeader";
            pnlListHeader.Padding = new System.Windows.Forms.Padding(24, 15, 24, 15);
            pnlListHeader.Size = new Size(1290, 80);
            pnlListHeader.TabIndex = 3;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblListTitle.Location = new System.Drawing.Point(24, 25);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new System.Drawing.Size(107, 32);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Staff list";
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = System.Drawing.Color.FromArgb(0, 168, 168);
            btnAddStaff.Dock = System.Windows.Forms.DockStyle.Right;
            btnAddStaff.FlatAppearance.BorderSize = 0;
            btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddStaff.ForeColor = System.Drawing.Color.White;
            btnAddStaff.Location = new Point(1106, 15);
            btnAddStaff.Margin = new System.Windows.Forms.Padding(0, 15, 24, 15);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(160, 50);
            btnAddStaff.TabIndex = 1;
            btnAddStaff.Text = "+ Add new staff";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 2;
            tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpStats.Controls.Add(pnlStatTotal, 0, 0);
            tlpStats.Controls.Add(pnlStatDoctors, 1, 0);
            tlpStats.Dock = System.Windows.Forms.DockStyle.Top;
            tlpStats.Location = new System.Drawing.Point(24, 24);
            tlpStats.Name = "tlpStats";
            tlpStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpStats.Size = new Size(1292, 150);
            tlpStats.TabIndex = 1;
            // 
            // pnlStatTotal
            // 
            pnlStatTotal.BackColor = System.Drawing.Color.White;
            pnlStatTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlStatTotal.Controls.Add(lblStatTotalVal);
            pnlStatTotal.Controls.Add(lblStatTotalTitle);
            pnlStatTotal.Controls.Add(lblStatTotalSub);
            pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlStatTotal.Location = new System.Drawing.Point(0, 0);
            pnlStatTotal.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            pnlStatTotal.Name = "pnlStatTotal";
            pnlStatTotal.Size = new Size(634, 126);
            pnlStatTotal.TabIndex = 0;
            // 
            // lblStatTotalVal
            // 
            lblStatTotalVal.AutoSize = true;
            lblStatTotalVal.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            lblStatTotalVal.Location = new Point(18, 42);
            lblStatTotalVal.Name = "lblStatTotalVal";
            lblStatTotalVal.Size = new Size(50, 60);
            lblStatTotalVal.TabIndex = 0;
            lblStatTotalVal.Text = "3";
            // 
            // lblStatTotalTitle
            // 
            lblStatTotalTitle.AutoSize = true;
            lblStatTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblStatTotalTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            lblStatTotalTitle.Location = new Point(20, 15);
            lblStatTotalTitle.Name = "lblStatTotalTitle";
            lblStatTotalTitle.Size = new Size(83, 23);
            lblStatTotalTitle.TabIndex = 1;
            lblStatTotalTitle.Text = "Total staff";
            // 
            // lblStatTotalSub
            // 
            lblStatTotalSub.AutoSize = true;
            lblStatTotalSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblStatTotalSub.ForeColor = System.Drawing.Color.FromArgb(0, 168, 168);
            lblStatTotalSub.Location = new Point(20, 95);
            lblStatTotalSub.Name = "lblStatTotalSub";
            lblStatTotalSub.Size = new Size(108, 20);
            lblStatTotalSub.TabIndex = 2;
            lblStatTotalSub.Text = "across all roles";
            // 
            // pnlStatDoctors
            // 
            pnlStatDoctors.BackColor = System.Drawing.Color.White;
            pnlStatDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlStatDoctors.Controls.Add(lblStatDoctorsVal);
            pnlStatDoctors.Controls.Add(lblStatDoctorsTitle);
            pnlStatDoctors.Controls.Add(lblStatDoctorsSub);
            pnlStatDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlStatDoctors.Location = new Point(658, 0);
            pnlStatDoctors.Margin = new Padding(12, 0, 0, 0);
            pnlStatDoctors.Name = "pnlStatDoctors";
            pnlStatDoctors.Size = new Size(634, 126);
            pnlStatDoctors.TabIndex = 1;
            // 
            // lblStatDoctorsVal
            // 
            lblStatDoctorsVal.AutoSize = true;
            lblStatDoctorsVal.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            lblStatDoctorsVal.Location = new Point(18, 42);
            lblStatDoctorsVal.Name = "lblStatDoctorsVal";
            lblStatDoctorsVal.Size = new Size(50, 60);
            lblStatDoctorsVal.TabIndex = 0;
            lblStatDoctorsVal.Text = "0";
            // 
            // lblStatDoctorsTitle
            // 
            lblStatDoctorsTitle.AutoSize = true;
            lblStatDoctorsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblStatDoctorsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            lblStatDoctorsTitle.Location = new Point(20, 15);
            lblStatDoctorsTitle.Name = "lblStatDoctorsTitle";
            lblStatDoctorsTitle.Size = new Size(69, 23);
            lblStatDoctorsTitle.TabIndex = 1;
            lblStatDoctorsTitle.Text = "Doctors";
            // 
            // lblStatDoctorsSub
            // 
            lblStatDoctorsSub.AutoSize = true;
            lblStatDoctorsSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            lblStatDoctorsSub.ForeColor = System.Drawing.Color.FromArgb(0, 168, 168);
            lblStatDoctorsSub.Location = new Point(20, 95);
            lblStatDoctorsSub.Name = "lblStatDoctorsSub";
            lblStatDoctorsSub.Size = new Size(123, 20);
            lblStatDoctorsSub.TabIndex = 2;
            lblStatDoctorsSub.Text = "active physicians";
            // 
            // picLogo
            // 
            picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            picLogo.Location = new System.Drawing.Point(35, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(190, 80);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;

            // 
            // Staff_List
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1600, 900);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            Name = "Staff_List";
            Text = "RecoverEase - Staff Management";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlLogoArea.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlTopIcons.ResumeLayout(false);
            pnlAvatarTop.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            pnlPagination.ResumeLayout(false);
            pnlPagination.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlListHeader.ResumeLayout(false);
            pnlListHeader.PerformLayout();
            tlpStats.ResumeLayout(false);
            pnlStatTotal.ResumeLayout(false);
            pnlStatTotal.PerformLayout();
            pnlStatDoctors.ResumeLayout(false);
            pnlStatDoctors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private void SetupNavItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, string icoChar, string label, bool isActive, System.Drawing.Color activeColor, System.Drawing.Color whiteColor)
        {
            pnl.SuspendLayout();
            pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            pnl.Dock = System.Windows.Forms.DockStyle.Top;
            pnl.Height = 56;
            pnl.BackColor = isActive ? activeColor : System.Drawing.Color.Transparent;

            ico.AutoSize = false;
            ico.Size = new System.Drawing.Size(56, 56);
            ico.Location = new System.Drawing.Point(0, 0);
            ico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            ico.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            ico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ico.Text = icoChar;

            txt.AutoSize = false;
            txt.Size = new System.Drawing.Size(190, 56);
            txt.Location = new System.Drawing.Point(56, 0);
            txt.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            txt.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            txt.Text = label;

            pnl.Controls.Clear();
            pnl.Controls.Add(ico);
            pnl.Controls.Add(txt);
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogoArea;
        private System.Windows.Forms.Panel pnlNavDivider;
        private System.Windows.Forms.Panel btnNavDashboard;
        private System.Windows.Forms.Label lblNavDashIcon;
        private System.Windows.Forms.Label lblNavDashText;
        private System.Windows.Forms.Panel btnNavStaff;
        private System.Windows.Forms.Label lblNavStaffIcon;
        private System.Windows.Forms.Label lblNavStaffText;
        private System.Windows.Forms.Panel btnNavPatients;
        private System.Windows.Forms.Label lblNavPatientsIcon;
        private System.Windows.Forms.Label lblNavPatientsText;
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
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.FlowLayoutPanel pnlTopIcons;
        private System.Windows.Forms.Label lblNotifIcon;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Panel pnlStatTotal;
        private System.Windows.Forms.Label lblStatTotalVal;
        private System.Windows.Forms.Label lblStatTotalTitle;
        private System.Windows.Forms.Label lblStatTotalSub;
        private System.Windows.Forms.Panel pnlStatDoctors;
        private System.Windows.Forms.Label lblStatDoctorsVal;
        private System.Windows.Forms.Label lblStatDoctorsTitle;
        private System.Windows.Forms.Label lblStatDoctorsSub;
        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.Panel pnlListHeader;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbRoleFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblShowingCount;
        private System.Windows.Forms.PictureBox picLogo;
    }
}