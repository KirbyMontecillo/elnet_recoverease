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
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlTopIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNotifIcon = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStatTotal = new System.Windows.Forms.Panel();
            this.lblStatTotalVal = new System.Windows.Forms.Label();
            this.lblStatTotalTitle = new System.Windows.Forms.Label();
            this.lblStatTotalSub = new System.Windows.Forms.Label();
            this.pnlStatDoctors = new System.Windows.Forms.Panel();
            this.lblStatDoctorsVal = new System.Windows.Forms.Label();
            this.lblStatDoctorsTitle = new System.Windows.Forms.Label();
            this.lblStatDoctorsSub = new System.Windows.Forms.Label();

            this.pnlListCard = new System.Windows.Forms.Panel();
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbRoleFilter = new System.Windows.Forms.ComboBox();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();

            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblShowingCount = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavStaff.SuspendLayout();
            this.btnNavPatients.SuspendLayout();
            this.btnNavReports.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlTopIcons.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.pnlStatTotal.SuspendLayout();
            this.pnlStatDoctors.SuspendLayout();
            this.pnlListCard.SuspendLayout();
            this.pnlListHeader.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrNavy = System.Drawing.ColorTranslator.FromHtml("#EEF3F7");
            System.Drawing.Color clrNavyActive = System.Drawing.ColorTranslator.FromHtml("#1B3A6B");
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrTextMain = System.Drawing.Color.FromArgb(45, 55, 72);
            System.Drawing.Color clrTextSec = System.Drawing.Color.FromArgb(113, 128, 150);
            System.Drawing.Color clrBorder = System.Drawing.Color.FromArgb(226, 232, 240);

            // Sidebar
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 260;
            this.pnlSidebar.Controls.AddRange(new Control[] { this.btnNavReports, this.btnNavPatients, this.btnNavStaff, this.btnNavDashboard, this.pnlNavDivider, this.pnlLogoArea, this.pnlSidebarBottom });

            this.pnlLogoArea.Dock = System.Windows.Forms.DockStyle.Top; this.pnlLogoArea.Height = 90;
            this.pnlLogoArea.Controls.Add(this.picLogo);
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill; this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(208, 219, 232); this.pnlNavDivider.Dock = System.Windows.Forms.DockStyle.Top; this.pnlNavDivider.Height = 1;

            this.SetupNavItem(this.btnNavDashboard, this.lblNavDashIcon, this.lblNavDashText, "\u229E", "Admin Dashboard", false, clrNavyActive, clrWhite);
            this.SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", true, clrNavyActive, clrWhite);
            this.SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "💊", "Medication List", false, clrNavyActive, clrWhite);
            this.SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", false, clrNavyActive, clrWhite);

            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlSidebarBottom.Height = 70;
            this.pnlSidebarBottom.Controls.AddRange(new Control[] { this.lblSidebarFooter, this.btnLogout });
            this.lblSidebarFooter.Text = "RecoverEase Admin Portal"; this.lblSidebarFooter.Location = new System.Drawing.Point(20, 10); this.lblSidebarFooter.AutoSize = true;
            this.btnLogout.Text = "⇠  Sign Out"; this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLogout.FlatAppearance.BorderSize = 0; this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold); this.btnLogout.Location = new System.Drawing.Point(16, 32); this.btnLogout.Size = new System.Drawing.Size(188, 26); this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Top Bar
            this.pnlTopBar.BackColor = clrWhite; this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTopBar.Height = 90;
            this.pnlTopBar.Controls.AddRange(new Control[] { this.pnlTopIcons, this.lblPageSubtitle, this.lblPageTitle });
            this.lblPageTitle.Text = "Staff Management"; this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold); this.lblPageTitle.Location = new System.Drawing.Point(24, 15); this.lblPageTitle.AutoSize = true;
            this.lblPageSubtitle.Text = "Manage doctors and healthcare staff"; this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPageSubtitle.ForeColor = clrTextSec; this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50); this.lblPageSubtitle.AutoSize = true;
            this.pnlTopIcons.Anchor = AnchorStyles.Right | AnchorStyles.Top; this.pnlTopIcons.Location = new Point(1100, 20); this.pnlTopIcons.Size = new Size(220, 50);
            this.pnlTopIcons.FlowDirection = FlowDirection.RightToLeft;
            this.lblNotifIcon.Text = "🔔"; this.lblNotifIcon.Font = new Font("Segoe UI", 16F);
            this.pnlAvatarTop.BackColor = Color.FromArgb(226, 232, 240); this.pnlAvatarTop.Size = new Size(40, 40);
            this.lblAvatarInitials.Text = "AD"; this.lblAvatarInitials.Dock = DockStyle.Fill; this.lblAvatarInitials.TextAlign = ContentAlignment.MiddleCenter;
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlTopIcons.Controls.AddRange(new Control[] { this.pnlAvatarTop, this.lblNotifIcon });

            // Content
            this.pnlContent.BackColor = clrBg; this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Controls.AddRange(new Control[] { this.pnlListCard, this.tlpStats });

            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Top; this.tlpStats.Height = 150;
            this.tlpStats.ColumnCount = 2;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.tlpStats.Controls.Add(this.pnlStatTotal, 0, 0);
            this.tlpStats.Controls.Add(this.pnlStatDoctors, 1, 0);

            this.pnlStatTotal.BackColor = clrWhite; this.pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlStatTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.pnlStatTotal.Margin = new Padding(0,0,12,0);
            this.lblStatTotalVal.Text = "3"; this.lblStatTotalVal.Font = new Font("Segoe UI Bold", 26F, FontStyle.Bold); this.lblStatTotalVal.Location = new Point(18, 42); this.lblStatTotalVal.AutoSize = true;
            this.lblStatTotalTitle.Text = "Total staff"; this.lblStatTotalTitle.Font = new Font("Segoe UI", 10F); this.lblStatTotalTitle.ForeColor = clrTextSec; this.lblStatTotalTitle.Location = new Point(20, 15); this.lblStatTotalTitle.AutoSize = true;
            this.lblStatTotalSub.Text = "across all roles"; this.lblStatTotalSub.Font = new Font("Segoe UI Semibold", 9.5F); this.lblStatTotalSub.ForeColor = clrTeal; this.lblStatTotalSub.Location = new Point(20, 95); this.lblStatTotalSub.AutoSize = true;
            this.pnlStatTotal.Controls.AddRange(new Control[] { this.lblStatTotalVal, this.lblStatTotalTitle, this.lblStatTotalSub });

            this.pnlStatDoctors.BackColor = clrWhite; this.pnlStatDoctors.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlStatDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.pnlStatDoctors.Margin = new Padding(12,0,0,0);
            this.lblStatDoctorsVal.Text = "0"; this.lblStatDoctorsVal.Font = new Font("Segoe UI Bold", 26F, FontStyle.Bold); this.lblStatDoctorsVal.Location = new Point(18, 42); this.lblStatDoctorsVal.AutoSize = true;
            this.lblStatDoctorsTitle.Text = "Doctors"; this.lblStatDoctorsTitle.Font = new Font("Segoe UI", 10F); this.lblStatDoctorsTitle.ForeColor = clrTextSec; this.lblStatDoctorsTitle.Location = new Point(20, 15); this.lblStatDoctorsTitle.AutoSize = true;
            this.lblStatDoctorsSub.Text = "active physicians"; this.lblStatDoctorsSub.Font = new Font("Segoe UI Semibold", 9.5F); this.lblStatDoctorsSub.ForeColor = clrTeal; this.lblStatDoctorsSub.Location = new Point(20, 95); this.lblStatDoctorsSub.AutoSize = true;
            this.pnlStatDoctors.Controls.AddRange(new Control[] { this.lblStatDoctorsVal, this.lblStatDoctorsTitle, this.lblStatDoctorsSub });

            // List Card
            this.pnlListCard.BackColor = clrWhite; this.pnlListCard.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListCard.Controls.AddRange(new Control[] { this.dgvStaff, this.pnlPagination, this.pnlFilters, this.pnlListHeader });

            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top; this.pnlListHeader.Height = 80;
            this.lblListTitle.Text = "Staff list"; this.lblListTitle.Font = new Font("Segoe UI Bold", 14F, FontStyle.Bold); this.lblListTitle.Location = new Point(24, 25); this.lblListTitle.AutoSize = true;
            this.btnAddStaff.Text = "+ Add new staff"; this.btnAddStaff.BackColor = clrTeal; this.btnAddStaff.ForeColor = clrWhite; this.btnAddStaff.FlatStyle = FlatStyle.Flat; this.btnAddStaff.FlatAppearance.BorderSize = 0; this.btnAddStaff.Font = new Font("Segoe UI Bold", 10F, FontStyle.Bold); this.btnAddStaff.Size = new Size(160, 45); 
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddStaff.Margin = new Padding(0, 15, 24, 15);
            this.btnAddStaff.Visible = true;
            this.pnlListHeader.Padding = new Padding(24, 15, 24, 15);
            this.pnlListHeader.Controls.AddRange(new Control[] { this.lblListTitle, this.btnAddStaff });
            this.btnAddStaff.BringToFront();

            // Filters
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Height = 65;
            
            this.lblSearchLabel.Text = "Search:";
            this.lblSearchLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblSearchLabel.ForeColor = clrTextMain;
            this.lblSearchLabel.Location = new Point(24, 18);
            this.lblSearchLabel.AutoSize = true;

            this.txtSearch.Font = new Font("Segoe UI", 10.5F);
            this.txtSearch.Location = new Point(100, 15);
            this.txtSearch.Width = 200;
            this.txtSearch.BorderStyle = BorderStyle.FixedSingle;

            this.cmbRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList; 
            this.cmbRoleFilter.Size = new Size(200, 40); 
            this.cmbRoleFilter.Location = new Point(330, 15); 
            this.cmbRoleFilter.Font = new Font("Segoe UI", 10.5F);
            this.cmbRoleFilter.Items.AddRange(new object[] { "All roles", "Doctor", "Admin" }); this.cmbRoleFilter.SelectedIndex = 0;

            this.cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList; 
            this.cmbStatusFilter.Size = new Size(200, 40); 
            this.cmbStatusFilter.Location = new Point(560, 15); 
            this.cmbStatusFilter.Font = new Font("Segoe UI", 10.5F);
            this.cmbStatusFilter.Items.AddRange(new object[] { "All status", "Active", "Inactive" }); this.cmbStatusFilter.SelectedIndex = 0;

            this.pnlFilters.Controls.AddRange(new Control[] { this.lblSearchLabel, this.txtSearch, this.cmbRoleFilter, this.cmbStatusFilter });

            // DATA GRID (REMOVING UNNECESSARY BLUE)
            this.dgvStaff.BackgroundColor = clrWhite; this.dgvStaff.BorderStyle = BorderStyle.None; this.dgvStaff.Dock = DockStyle.Fill;
            this.dgvStaff.EnableHeadersVisualStyles = false; this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; this.dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.ColumnHeadersHeight = 50; this.dgvStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = clrTextSec;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.dgvStaff.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White; // Fix blue header
            this.dgvStaff.ColumnHeadersDefaultCellStyle.SelectionForeColor = clrTextSec;
            this.dgvStaff.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            this.dgvStaff.DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 247, 250); // Subtle light blue instead of harsh blue
            this.dgvStaff.DefaultCellStyle.SelectionForeColor = clrTextMain;
            this.dgvStaff.RowTemplate.Height = 65;
            this.dgvStaff.GridColor = Color.FromArgb(237, 242, 247);

            this.colName.HeaderText = "Name"; this.colRole.HeaderText = "Role"; this.colSpecialty.HeaderText = "Specialty"; this.colPatients.HeaderText = "Patients"; this.colStatus.HeaderText = "Status";
            
            // Actions
            this.colView.HeaderText = "Actions"; this.colView.Text = "👁 View"; this.colView.UseColumnTextForButtonValue = true; this.colView.Width = 85; this.colView.FlatStyle = FlatStyle.Flat; this.colView.Name = "colView";
            this.colEdit.HeaderText = ""; this.colEdit.Text = "✏ Edit"; this.colEdit.UseColumnTextForButtonValue = true; this.colEdit.Width = 85; this.colEdit.FlatStyle = FlatStyle.Flat; this.colEdit.Name = "colEdit";
            this.colDelete.HeaderText = ""; this.colDelete.Text = "🗑 Delete"; this.colDelete.UseColumnTextForButtonValue = true; this.colDelete.Width = 85; this.colDelete.FlatStyle = FlatStyle.Flat; this.colDelete.Name = "colDelete";
            this.dgvStaff.Columns.AddRange(new DataGridViewColumn[] { this.colName, this.colRole, this.colSpecialty, this.colPatients, this.colStatus, this.colView, this.colEdit, this.colDelete });

            // Pagination
            this.pnlPagination.Dock = DockStyle.Bottom; this.pnlPagination.Height = 50;
            this.lblShowingCount.ForeColor = clrTextSec; this.lblShowingCount.Location = new Point(24, 15); this.lblShowingCount.AutoSize = true;
            this.pnlPagination.Controls.Add(this.lblShowingCount);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(1600, 900);
            this.Controls.AddRange(new Control[] { this.pnlContent, this.pnlTopBar, this.pnlSidebar });
            this.WindowState = FormWindowState.Maximized;
            this.Text = "RecoverEase - Staff Management";

            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.picLogo).EndInit();
            this.btnNavDashboard.ResumeLayout(false); this.btnNavDashboard.PerformLayout();
            this.btnNavStaff.ResumeLayout(false); this.btnNavStaff.PerformLayout();
            this.btnNavPatients.ResumeLayout(false); this.btnNavPatients.PerformLayout();
            this.btnNavReports.ResumeLayout(false); this.btnNavReports.PerformLayout();
            this.pnlSidebarBottom.ResumeLayout(false); this.pnlSidebarBottom.PerformLayout();
            this.pnlTopBar.ResumeLayout(false); this.pnlTopBar.PerformLayout();
            this.pnlTopIcons.ResumeLayout(false);
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.pnlStatTotal.ResumeLayout(false); this.pnlStatTotal.PerformLayout();
            this.pnlStatDoctors.ResumeLayout(false); this.pnlStatDoctors.PerformLayout();
            this.pnlListCard.ResumeLayout(false);
            this.pnlListHeader.ResumeLayout(false); this.pnlListHeader.PerformLayout();
            this.pnlFilters.ResumeLayout(false); this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvStaff).EndInit();
            this.pnlPagination.ResumeLayout(false); this.pnlPagination.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private void SetupNavItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, string icoChar, string label, bool isActive, System.Drawing.Color activeColor, System.Drawing.Color whiteColor)
        {
            pnl.Cursor = System.Windows.Forms.Cursors.Hand;
            pnl.Dock = System.Windows.Forms.DockStyle.Top;
            pnl.Height = 48;
            if (isActive) pnl.BackColor = activeColor;
            ico.AutoSize = true;
            ico.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            ico.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            ico.Location = new System.Drawing.Point(20, 11);
            ico.Text = icoChar;
            txt.AutoSize = true;
            txt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            txt.ForeColor = isActive ? whiteColor : System.Drawing.Color.FromArgb(45, 55, 72);
            txt.Location = new System.Drawing.Point(64, 13);
            txt.Text = label;
            pnl.Controls.AddRange(new System.Windows.Forms.Control[] { ico, txt });
        }

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
    }
}