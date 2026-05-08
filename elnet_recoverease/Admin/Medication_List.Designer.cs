using System.Windows.Forms;
using System.Drawing;

namespace elnet_recoverease.Admin
{
    partial class Medication_List
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            pnlSidebarBottom = new Panel();
            btnNavProfile = new Panel();
            btnNavReports = new Panel();
            btnNavPatients = new Panel();
            btnNavStaff = new Panel();
            btnNavDashboard = new Panel();
            pnlNavDivider = new Panel();
            pnlLogoArea = new Panel();
            lblSidebarFooter = new Label();
            btnLogout = new Button();
            lblNavDashIcon = new Label();
            lblNavDashText = new Label();
            lblNavStaffIcon = new Label();
            lblNavStaffText = new Label();
            lblNavPatientsIcon = new Label();
            lblNavPatientsText = new Label();
            lblNavReportsIcon = new Label();
            lblNavReportsText = new Label();
            lblNavProfileIcon = new Label();
            lblNavProfileText = new Label();
            pnlTopBar = new Panel();
            pnlTopIcons = new FlowLayoutPanel();
            pnlAvatarTop = new Panel();
            lblAvatarInitials = new Label();
            lblNotifIcon = new Label();
            lblPageSubtitle = new Label();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            pnlListCard = new Panel();
            dgvMeds = new DataGridView();
            colMed = new DataGridViewTextBoxColumn();
            colDosage = new DataGridViewTextBoxColumn();
            colForm = new DataGridViewTextBoxColumn();
            colFrequency = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlPagination = new Panel();
            lblShowingCount = new Label();
            pnlFilters = new Panel();
            lblSearchLabel = new Label();
            txtSearch = new TextBox();
            cmbFormFilter = new ComboBox();
            pnlListHeader = new Panel();
            lblListTitle = new Label();
            btnAddMed = new Button();
            tlpStats = new TableLayoutPanel();
            pnlStatTotal = new Panel();
            lblStatTotalVal = new Label();
            lblStatTotalTitle = new Label();
            lblStatTotalSub = new Label();
            pnlStatMost = new Panel();
            lblStatMostVal = new Label();
            lblStatMostTitle = new Label();
            lblStatMostSub = new Label();
            pnlStatRecent = new Panel();
            lblStatRecentVal = new Label();
            lblStatRecentTitle = new Label();
            lblStatRecentSub = new Label();
            picLogo = new PictureBox();
            pnlSidebar.SuspendLayout();
            pnlLogoArea.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlTopIcons.SuspendLayout();
            pnlAvatarTop.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeds).BeginInit();
            pnlPagination.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlListHeader.SuspendLayout();
            tlpStats.SuspendLayout();
            pnlStatTotal.SuspendLayout();
            pnlStatMost.SuspendLayout();
            pnlStatRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(238, 243, 247);
            pnlSidebar.Controls.Add(pnlSidebarBottom);
            pnlSidebar.Controls.Add(btnNavProfile);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnNavPatients);
            pnlSidebar.Controls.Add(btnNavStaff);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(pnlNavDivider);
            pnlSidebar.Controls.Add(pnlLogoArea);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 900);
            pnlSidebar.TabIndex = 0;

            // Sidebar Bottom
            pnlSidebarBottom.Controls.Add(lblSidebarFooter);
            pnlSidebarBottom.Controls.Add(btnLogout);
            pnlSidebarBottom.Dock = DockStyle.Bottom;
            pnlSidebarBottom.Location = new Point(0, 840);
            pnlSidebarBottom.Name = "pnlSidebarBottom";
            pnlSidebarBottom.Size = new Size(260, 60);
            pnlSidebarBottom.TabIndex = 7;

            lblSidebarFooter.AutoSize = false;
            lblSidebarFooter.Dock = DockStyle.Fill;
            lblSidebarFooter.Font = new Font("Segoe UI", 8F);
            lblSidebarFooter.ForeColor = Color.FromArgb(160, 174, 192);
            lblSidebarFooter.Location = new Point(0, 0);
            lblSidebarFooter.TextAlign = ContentAlignment.MiddleCenter;
            lblSidebarFooter.Text = "RecoverEase Admin Portal";

            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(68, 68, 68);
            btnLogout.Location = new Point(16, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(188, 26);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "⇠  Sign Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Visible = false;

            // Navigation Items
            SetupNavItem(btnNavProfile, lblNavProfileIcon, lblNavProfileText, "👤", "My Profile", false, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavReports, lblNavReportsIcon, lblNavReportsText, "📊", "System Reports", false, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavPatients, lblNavPatientsIcon, lblNavPatientsText, "💊", "Medication List", true, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavStaff, lblNavStaffIcon, lblNavStaffText, "🩺", "Staff Management", false, Color.FromArgb(27, 58, 107), Color.White);
            SetupNavItem(btnNavDashboard, lblNavDashIcon, lblNavDashText, "⊞", "Admin Dashboard", false, Color.FromArgb(27, 58, 107), Color.White);

            // 
            // pnlNavDivider
            // 
            pnlNavDivider.BackColor = Color.FromArgb(226, 232, 240);
            pnlNavDivider.Dock = DockStyle.Top;
            pnlNavDivider.Location = new Point(0, 120);
            pnlNavDivider.Name = "pnlNavDivider";
            pnlNavDivider.Size = new Size(260, 1);
            pnlNavDivider.TabIndex = 1;

            // 
            // pnlLogoArea
            // 
            pnlLogoArea.BackColor = Color.FromArgb(238, 243, 247);
            pnlLogoArea.Controls.Add(picLogo);
            pnlLogoArea.Dock = DockStyle.Top;
            pnlLogoArea.Location = new Point(0, 0);
            pnlLogoArea.Name = "pnlLogoArea";
            pnlLogoArea.Padding = new Padding(35, 25, 35, 15);
            pnlLogoArea.Size = new Size(260, 120);
            pnlLogoArea.TabIndex = 0;

            // picLogo
            picLogo.Dock = DockStyle.Fill;
            picLogo.Location = new Point(35, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(190, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;

            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(pnlTopIcons);
            pnlTopBar.Controls.Add(lblPageSubtitle);
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(260, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1340, 90);
            pnlTopBar.TabIndex = 1;
            // 
            // pnlTopIcons
            // 
            pnlTopIcons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlTopIcons.Controls.Add(pnlAvatarTop);
            pnlTopIcons.Controls.Add(lblNotifIcon);
            pnlTopIcons.FlowDirection = FlowDirection.RightToLeft;
            pnlTopIcons.Location = new Point(1100, 20);
            pnlTopIcons.Name = "pnlTopIcons";
            pnlTopIcons.Size = new Size(220, 50);
            pnlTopIcons.TabIndex = 0;
            // 
            // pnlAvatarTop
            // 
            pnlAvatarTop.BackColor = Color.FromArgb(226, 232, 240);
            pnlAvatarTop.Controls.Add(lblAvatarInitials);
            pnlAvatarTop.Location = new Point(177, 3);
            pnlAvatarTop.Name = "pnlAvatarTop";
            pnlAvatarTop.Size = new Size(40, 40);
            pnlAvatarTop.TabIndex = 0;
            pnlAvatarTop.Visible = false;
            // 
            // lblAvatarInitials
            // 
            lblAvatarInitials.Dock = DockStyle.Fill;
            lblAvatarInitials.Location = new Point(0, 0);
            lblAvatarInitials.Name = "lblAvatarInitials";
            lblAvatarInitials.Size = new Size(40, 40);
            lblAvatarInitials.TabIndex = 0;
            lblAvatarInitials.Text = "AD";
            lblAvatarInitials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNotifIcon
            // 
            lblNotifIcon.Font = new Font("Segoe UI", 16F);
            lblNotifIcon.Location = new Point(71, 0);
            lblNotifIcon.Name = "lblNotifIcon";
            lblNotifIcon.Size = new Size(100, 23);
            lblNotifIcon.TabIndex = 1;
            lblNotifIcon.Text = "🔔";
            lblNotifIcon.Visible = false;
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Font = new Font("Segoe UI", 10F);
            lblPageSubtitle.ForeColor = Color.FromArgb(113, 128, 150);
            lblPageSubtitle.Location = new Point(26, 50);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(316, 23);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "Master reference list for treatment plans";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.Location = new Point(24, 15);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(235, 41);
            lblPageTitle.TabIndex = 2;
            lblPageTitle.Text = "Medication List";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(242, 247, 250);
            pnlContent.Controls.Add(pnlListCard);
            pnlContent.Controls.Add(tlpStats);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(260, 90);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(24);
            pnlContent.Size = new Size(1340, 810);
            pnlContent.TabIndex = 0;
            // 
            // pnlListCard
            // 
            pnlListCard.BackColor = Color.White;
            pnlListCard.BorderStyle = BorderStyle.FixedSingle;
            pnlListCard.Controls.Add(dgvMeds);
            pnlListCard.Controls.Add(pnlPagination);
            pnlListCard.Controls.Add(pnlFilters);
            pnlListCard.Controls.Add(pnlListHeader);
            pnlListCard.Dock = DockStyle.Fill;
            pnlListCard.Location = new Point(24, 174);
            pnlListCard.Name = "pnlListCard";
            pnlListCard.Size = new Size(1292, 612);
            pnlListCard.TabIndex = 0;
            // 
            // dgvMeds
            // 
            dgvMeds.AllowUserToAddRows = false;
            dgvMeds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeds.BackgroundColor = Color.White;
            dgvMeds.BorderStyle = BorderStyle.None;
            dgvMeds.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(113, 128, 150);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMeds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMeds.ColumnHeadersHeight = 50;
            dgvMeds.Columns.AddRange(new DataGridViewColumn[] { colMed, colDosage, colForm, colFrequency, colEdit, colDelete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 247, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMeds.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMeds.Dock = DockStyle.Fill;
            dgvMeds.EnableHeadersVisualStyles = false;
            dgvMeds.GridColor = Color.FromArgb(237, 242, 247);
            dgvMeds.Location = new Point(0, 145);
            dgvMeds.Name = "dgvMeds";
            dgvMeds.RowHeadersVisible = false;
            dgvMeds.RowHeadersWidth = 51;
            dgvMeds.RowTemplate.Height = 65;
            dgvMeds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeds.Size = new Size(1290, 415);
            dgvMeds.TabIndex = 0;
            // 
            // colMed
            // 
            colMed.HeaderText = "Medication";
            colMed.MinimumWidth = 6;
            colMed.Name = "colMed";
            // 
            // colDosage
            // 
            colDosage.HeaderText = "Dosage";
            colDosage.MinimumWidth = 6;
            colDosage.Name = "colDosage";
            // 
            // colForm
            // 
            colForm.HeaderText = "Form";
            colForm.MinimumWidth = 6;
            colForm.Name = "colForm";
            // 
            // colFrequency
            // 
            colFrequency.HeaderText = "Frequency";
            colFrequency.MinimumWidth = 6;
            colFrequency.Name = "colFrequency";
            // 
            // colEdit
            // 
            colEdit.FlatStyle = FlatStyle.Flat;
            colEdit.HeaderText = "Actions";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.Text = "✏ Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.FlatStyle = FlatStyle.Flat;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑 Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlPagination
            // 
            pnlPagination.Controls.Add(lblShowingCount);
            pnlPagination.Dock = DockStyle.Bottom;
            pnlPagination.Location = new Point(0, 560);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(1290, 50);
            pnlPagination.TabIndex = 1;
            // 
            // lblShowingCount
            // 
            lblShowingCount.AutoSize = true;
            lblShowingCount.ForeColor = Color.FromArgb(113, 128, 150);
            lblShowingCount.Location = new Point(24, 15);
            lblShowingCount.Name = "lblShowingCount";
            lblShowingCount.Size = new Size(0, 20);
            lblShowingCount.TabIndex = 0;
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(lblSearchLabel);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(cmbFormFilter);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 80);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1290, 65);
            pnlFilters.TabIndex = 2;
            // 
            // lblSearchLabel
            // 
            lblSearchLabel.AutoSize = true;
            lblSearchLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSearchLabel.ForeColor = Color.FromArgb(45, 55, 72);
            lblSearchLabel.Location = new Point(24, 18);
            lblSearchLabel.Name = "lblSearchLabel";
            lblSearchLabel.Size = new Size(59, 20);
            lblSearchLabel.TabIndex = 0;
            lblSearchLabel.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.5F);
            txtSearch.Location = new Point(100, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbFormFilter
            // 
            cmbFormFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormFilter.Font = new Font("Segoe UI", 10.5F);
            cmbFormFilter.Items.AddRange(new object[] { "All forms", "Tablet", "Capsule", "Syrup", "Injection" });
            cmbFormFilter.Location = new Point(330, 15);
            cmbFormFilter.Name = "cmbFormFilter";
            cmbFormFilter.Size = new Size(200, 31);
            cmbFormFilter.TabIndex = 2;
            // 
            // pnlListHeader
            // 
            pnlListHeader.Controls.Add(lblListTitle);
            pnlListHeader.Controls.Add(btnAddMed);
            pnlListHeader.Dock = DockStyle.Top;
            pnlListHeader.Location = new Point(0, 0);
            pnlListHeader.Name = "pnlListHeader";
            pnlListHeader.Padding = new Padding(24, 15, 24, 15);
            pnlListHeader.Size = new Size(1290, 80);
            pnlListHeader.TabIndex = 3;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblListTitle.Location = new Point(24, 25);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(184, 32);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Medication list";
            // 
            // btnAddMed
            // 
            btnAddMed.BackColor = Color.FromArgb(0, 168, 168);
            btnAddMed.Dock = DockStyle.Right;
            btnAddMed.FlatAppearance.BorderSize = 0;
            btnAddMed.FlatStyle = FlatStyle.Flat;
            btnAddMed.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddMed.ForeColor = Color.White;
            btnAddMed.Location = new Point(1136, 15);
            btnAddMed.Margin = new Padding(0, 15, 0, 15);
            btnAddMed.Name = "btnAddMed";
            btnAddMed.Size = new Size(130, 50);
            btnAddMed.TabIndex = 1;
            btnAddMed.Text = "+ Add new";
            btnAddMed.UseVisualStyleBackColor = false;
            btnAddMed.Click += btnAddMed_Click;
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 3;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpStats.Controls.Add(pnlStatTotal, 0, 0);
            tlpStats.Controls.Add(pnlStatMost, 1, 0);
            tlpStats.Controls.Add(pnlStatRecent, 2, 0);
            tlpStats.Dock = DockStyle.Top;
            tlpStats.Location = new Point(24, 24);
            tlpStats.Name = "tlpStats";
            tlpStats.Padding = new Padding(0, 0, 0, 24);
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpStats.Size = new Size(1292, 150);
            tlpStats.TabIndex = 1;
            // 
            // pnlStatTotal
            // 
            pnlStatTotal.BackColor = Color.White;
            pnlStatTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlStatTotal.Controls.Add(lblStatTotalVal);
            pnlStatTotal.Controls.Add(lblStatTotalTitle);
            pnlStatTotal.Controls.Add(lblStatTotalSub);
            pnlStatTotal.Dock = DockStyle.Fill;
            pnlStatTotal.Location = new Point(0, 0);
            pnlStatTotal.Margin = new Padding(0, 0, 12, 0);
            pnlStatTotal.Name = "pnlStatTotal";
            pnlStatTotal.Size = new Size(418, 126);
            pnlStatTotal.TabIndex = 0;
            // 
            // lblStatTotalVal
            // 
            lblStatTotalVal.AutoSize = true;
            lblStatTotalVal.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblStatTotalVal.Location = new Point(18, 42);
            lblStatTotalVal.Name = "lblStatTotalVal";
            lblStatTotalVal.Size = new Size(75, 60);
            lblStatTotalVal.TabIndex = 0;
            lblStatTotalVal.Text = "48";
            // 
            // lblStatTotalTitle
            // 
            lblStatTotalTitle.AutoSize = true;
            lblStatTotalTitle.Font = new Font("Segoe UI", 10F);
            lblStatTotalTitle.ForeColor = Color.FromArgb(113, 128, 150);
            lblStatTotalTitle.Location = new Point(20, 15);
            lblStatTotalTitle.Name = "lblStatTotalTitle";
            lblStatTotalTitle.Size = new Size(143, 23);
            lblStatTotalTitle.TabIndex = 1;
            lblStatTotalTitle.Text = "Total medications";
            // 
            // lblStatTotalSub
            // 
            lblStatTotalSub.AutoSize = true;
            lblStatTotalSub.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatTotalSub.ForeColor = Color.FromArgb(0, 168, 168);
            lblStatTotalSub.Location = new Point(20, 95);
            lblStatTotalSub.Name = "lblStatTotalSub";
            lblStatTotalSub.Size = new Size(95, 20);
            lblStatTotalSub.TabIndex = 2;
            lblStatTotalSub.Text = "in master list";
            // 
            // pnlStatMost
            // 
            pnlStatMost.BackColor = Color.White;
            pnlStatMost.BorderStyle = BorderStyle.FixedSingle;
            pnlStatMost.Controls.Add(lblStatMostVal);
            pnlStatMost.Controls.Add(lblStatMostTitle);
            pnlStatMost.Controls.Add(lblStatMostSub);
            pnlStatMost.Dock = DockStyle.Fill;
            pnlStatMost.Location = new Point(442, 0);
            pnlStatMost.Margin = new Padding(12, 0, 12, 0);
            pnlStatMost.Name = "pnlStatMost";
            pnlStatMost.Size = new Size(406, 126);
            pnlStatMost.TabIndex = 1;
            // 
            // lblStatMostVal
            // 
            lblStatMostVal.AutoSize = true;
            lblStatMostVal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStatMostVal.Location = new Point(18, 50);
            lblStatMostVal.Name = "lblStatMostVal";
            lblStatMostVal.Size = new Size(201, 46);
            lblStatMostVal.TabIndex = 0;
            lblStatMostVal.Text = "Amoxicillin";
            // 
            // lblStatMostTitle
            // 
            lblStatMostTitle.AutoSize = true;
            lblStatMostTitle.Font = new Font("Segoe UI", 10F);
            lblStatMostTitle.ForeColor = Color.FromArgb(113, 128, 150);
            lblStatMostTitle.Location = new Point(20, 15);
            lblStatMostTitle.Name = "lblStatMostTitle";
            lblStatMostTitle.Size = new Size(119, 23);
            lblStatMostTitle.TabIndex = 1;
            lblStatMostTitle.Text = "Most assigned";
            // 
            // lblStatMostSub
            // 
            lblStatMostSub.AutoSize = true;
            lblStatMostSub.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatMostSub.ForeColor = Color.FromArgb(0, 168, 168);
            lblStatMostSub.Location = new Point(20, 95);
            lblStatMostSub.Name = "lblStatMostSub";
            lblStatMostSub.Size = new Size(82, 20);
            lblStatMostSub.TabIndex = 2;
            lblStatMostSub.Text = "this month";
            // 
            // pnlStatRecent
            // 
            pnlStatRecent.BackColor = Color.White;
            pnlStatRecent.BorderStyle = BorderStyle.FixedSingle;
            pnlStatRecent.Controls.Add(lblStatRecentVal);
            pnlStatRecent.Controls.Add(lblStatRecentTitle);
            pnlStatRecent.Controls.Add(lblStatRecentSub);
            pnlStatRecent.Dock = DockStyle.Fill;
            pnlStatRecent.Location = new Point(872, 0);
            pnlStatRecent.Margin = new Padding(12, 0, 0, 0);
            pnlStatRecent.Name = "pnlStatRecent";
            pnlStatRecent.Size = new Size(420, 126);
            pnlStatRecent.TabIndex = 2;
            // 
            // lblStatRecentVal
            // 
            lblStatRecentVal.AutoSize = true;
            lblStatRecentVal.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStatRecentVal.Location = new Point(18, 50);
            lblStatRecentVal.Name = "lblStatRecentVal";
            lblStatRecentVal.Size = new Size(274, 46);
            lblStatRecentVal.TabIndex = 0;
            lblStatRecentVal.Text = "Insulin Glargine";
            // 
            // lblStatRecentTitle
            // 
            lblStatRecentTitle.AutoSize = true;
            lblStatRecentTitle.Font = new Font("Segoe UI", 10F);
            lblStatRecentTitle.ForeColor = Color.FromArgb(113, 128, 150);
            lblStatRecentTitle.Location = new Point(20, 15);
            lblStatRecentTitle.Name = "lblStatRecentTitle";
            lblStatRecentTitle.Size = new Size(127, 23);
            lblStatRecentTitle.TabIndex = 1;
            lblStatRecentTitle.Text = "Recently added";
            // 
            // lblStatRecentSub
            // 
            lblStatRecentSub.AutoSize = true;
            lblStatRecentSub.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatRecentSub.ForeColor = Color.FromArgb(0, 168, 168);
            lblStatRecentSub.Location = new Point(20, 95);
            lblStatRecentSub.Name = "lblStatRecentSub";
            lblStatRecentSub.Size = new Size(91, 20);
            lblStatRecentSub.TabIndex = 2;
            lblStatRecentSub.Text = "May 5, 2026";
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Location = new Point(35, 25);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(190, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;

            // 
            // Medication_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            Name = "Medication_List";
            Text = "RecoverEase - Medication List";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlLogoArea.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlTopIcons.ResumeLayout(false);
            pnlAvatarTop.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMeds).EndInit();
            pnlPagination.ResumeLayout(false);
            pnlPagination.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlListHeader.ResumeLayout(false);
            pnlListHeader.PerformLayout();
            tlpStats.ResumeLayout(false);
            pnlStatTotal.ResumeLayout(false);
            pnlStatTotal.PerformLayout();
            pnlStatMost.ResumeLayout(false);
            pnlStatMost.PerformLayout();
            pnlStatRecent.ResumeLayout(false);
            pnlStatRecent.PerformLayout();
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

        private Panel pnlSidebar, pnlLogoArea, pnlNavDivider, btnNavDashboard, btnNavStaff, btnNavPatients, btnNavReports, btnNavProfile, pnlSidebarBottom, pnlTopBar, pnlContent, pnlStatTotal, pnlStatMost, pnlStatRecent, pnlListCard, pnlPagination, pnlFilters, pnlListHeader, pnlAvatarTop;
        private Label lblNavDashIcon, lblNavDashText, lblNavStaffIcon, lblNavStaffText, lblNavPatientsIcon, lblNavPatientsText, lblNavReportsIcon, lblNavReportsText, lblNavProfileIcon, lblNavProfileText, lblSidebarFooter, lblPageTitle, lblPageSubtitle, lblStatTotalVal, lblStatTotalTitle, lblStatTotalSub, lblStatMostVal, lblStatMostTitle, lblStatMostSub, lblStatRecentVal, lblStatRecentTitle, lblStatRecentSub, lblShowingCount, lblSearchLabel, lblListTitle, lblNotifIcon, lblAvatarInitials;
        private Button btnLogout, btnAddMed;
        private TableLayoutPanel tlpStats;
        private FlowLayoutPanel pnlTopIcons;
        private TextBox txtSearch;
        private ComboBox cmbFormFilter;
        private DataGridView dgvMeds;
        private DataGridViewTextBoxColumn colMed, colDosage, colForm, colFrequency;
        private DataGridViewButtonColumn colEdit, colDelete;
        private PictureBox picLogo;
    }
}