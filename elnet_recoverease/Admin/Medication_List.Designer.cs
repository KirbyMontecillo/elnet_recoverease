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
            this.pnlStatMost = new System.Windows.Forms.Panel();
            this.lblStatMostVal = new System.Windows.Forms.Label();
            this.lblStatMostTitle = new System.Windows.Forms.Label();
            this.lblStatMostSub = new System.Windows.Forms.Label();
            this.pnlStatRecent = new System.Windows.Forms.Panel();
            this.lblStatRecentVal = new System.Windows.Forms.Label();
            this.lblStatRecentTitle = new System.Windows.Forms.Label();
            this.lblStatRecentSub = new System.Windows.Forms.Label();
            this.pnlListCard = new System.Windows.Forms.Panel();
            this.dgvMeds = new System.Windows.Forms.DataGridView();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblShowingCount = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFormFilter = new System.Windows.Forms.ComboBox();
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();

            // Columns
            this.colMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();

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
            this.pnlStatMost.SuspendLayout();
            this.pnlStatRecent.SuspendLayout();
            this.pnlListCard.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeds)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.pnlListHeader.SuspendLayout();
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
            this.SetupNavItem(this.btnNavStaff, this.lblNavStaffIcon, this.lblNavStaffText, "🩺", "Staff Management", false, clrNavyActive, clrWhite);
            this.SetupNavItem(this.btnNavPatients, this.lblNavPatientsIcon, this.lblNavPatientsText, "💊", "Medication List", true, clrNavyActive, clrWhite);
            this.SetupNavItem(this.btnNavReports, this.lblNavReportsIcon, this.lblNavReportsText, "📊", "System Reports", false, clrNavyActive, clrWhite);

            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlSidebarBottom.Height = 70;
            this.pnlSidebarBottom.Controls.AddRange(new Control[] { this.lblSidebarFooter, this.btnLogout });
            this.lblSidebarFooter.Text = "RecoverEase Admin Portal"; this.lblSidebarFooter.Location = new System.Drawing.Point(20, 10); this.lblSidebarFooter.AutoSize = true;
            this.btnLogout.Text = "⇠  Sign Out"; this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLogout.FlatAppearance.BorderSize = 0; this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold); this.btnLogout.Location = new System.Drawing.Point(16, 32); this.btnLogout.Size = new System.Drawing.Size(188, 26); this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Top Bar
            this.pnlTopBar.BackColor = clrWhite; this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTopBar.Height = 90;
            this.pnlTopBar.Controls.AddRange(new Control[] { this.pnlTopIcons, this.lblPageSubtitle, this.lblPageTitle });
            this.lblPageTitle.Text = "Medication List"; this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold); this.lblPageTitle.Location = new System.Drawing.Point(24, 15); this.lblPageTitle.AutoSize = true;
            this.lblPageSubtitle.Text = "Master reference list for treatment plans"; this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblPageSubtitle.ForeColor = clrTextSec; this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50); this.lblPageSubtitle.AutoSize = true;
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

            // Stats Cards (Consistent with rest)
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Top; this.tlpStats.Height = 150;
            this.tlpStats.ColumnCount = 3;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.tlpStats.Controls.Add(this.pnlStatTotal, 0, 0);
            this.tlpStats.Controls.Add(this.pnlStatMost, 1, 0);
            this.tlpStats.Controls.Add(this.pnlStatRecent, 2, 0);

            this.pnlStatTotal.BackColor = clrWhite; this.pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlStatTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.pnlStatTotal.Margin = new Padding(0,0,12,0);
            this.lblStatTotalVal.Text = "48"; this.lblStatTotalVal.Font = new Font("Segoe UI Bold", 26F, FontStyle.Bold); this.lblStatTotalVal.Location = new Point(18, 42); this.lblStatTotalVal.AutoSize = true;
            this.lblStatTotalTitle.Text = "Total medications"; this.lblStatTotalTitle.Font = new Font("Segoe UI", 10F); this.lblStatTotalTitle.ForeColor = clrTextSec; this.lblStatTotalTitle.Location = new Point(20, 15); this.lblStatTotalTitle.AutoSize = true;
            this.lblStatTotalSub.Text = "in master list"; this.lblStatTotalSub.Font = new Font("Segoe UI Semibold", 9.5F); this.lblStatTotalSub.ForeColor = clrTeal; this.lblStatTotalSub.Location = new Point(20, 95); this.lblStatTotalSub.AutoSize = true;
            this.pnlStatTotal.Controls.AddRange(new Control[] { this.lblStatTotalVal, this.lblStatTotalTitle, this.lblStatTotalSub });

            this.pnlStatMost.BackColor = clrWhite; this.pnlStatMost.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlStatMost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.pnlStatMost.Margin = new Padding(12,0,12,0);
            this.lblStatMostVal.Text = "Amoxicillin"; this.lblStatMostVal.Font = new Font("Segoe UI Bold", 20F, FontStyle.Bold); this.lblStatMostVal.Location = new Point(18, 50); this.lblStatMostVal.AutoSize = true;
            this.lblStatMostTitle.Text = "Most assigned"; this.lblStatMostTitle.Font = new Font("Segoe UI", 10F); this.lblStatMostTitle.ForeColor = clrTextSec; this.lblStatMostTitle.Location = new Point(20, 15); this.lblStatMostTitle.AutoSize = true;
            this.lblStatMostSub.Text = "this month"; this.lblStatMostSub.Font = new Font("Segoe UI Semibold", 9.5F); this.lblStatMostSub.ForeColor = clrTeal; this.lblStatMostSub.Location = new Point(20, 95); this.lblStatMostSub.AutoSize = true;
            this.pnlStatMost.Controls.AddRange(new Control[] { this.lblStatMostVal, this.lblStatMostTitle, this.lblStatMostSub });

            this.pnlStatRecent.BackColor = clrWhite; this.pnlStatRecent.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlStatRecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.pnlStatRecent.Margin = new Padding(12,0,0,0);
            this.lblStatRecentVal.Text = "Insulin Glargine"; this.lblStatRecentVal.Font = new Font("Segoe UI Bold", 20F, FontStyle.Bold); this.lblStatRecentVal.Location = new Point(18, 50); this.lblStatRecentVal.AutoSize = true;
            this.lblStatRecentTitle.Text = "Recently added"; this.lblStatRecentTitle.Font = new Font("Segoe UI", 10F); this.lblStatRecentTitle.ForeColor = clrTextSec; this.lblStatRecentTitle.Location = new Point(20, 15); this.lblStatRecentTitle.AutoSize = true;
            this.lblStatRecentSub.Text = "May 5, 2026"; this.lblStatRecentSub.Font = new Font("Segoe UI Semibold", 9.5F); this.lblStatRecentSub.ForeColor = clrTeal; this.lblStatRecentSub.Location = new Point(20, 95); this.lblStatRecentSub.AutoSize = true;
            this.pnlStatRecent.Controls.AddRange(new Control[] { this.lblStatRecentVal, this.lblStatRecentTitle, this.lblStatRecentSub });

            // List Card
            this.pnlListCard.BackColor = clrWhite; this.pnlListCard.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListCard.Controls.AddRange(new Control[] { this.dgvMeds, this.pnlPagination, this.pnlFilters, this.pnlListHeader });

            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top; this.pnlListHeader.Height = 80; this.pnlListHeader.Padding = new Padding(24, 15, 24, 15);
            this.lblListTitle.Text = "Medication list"; this.lblListTitle.Font = new Font("Segoe UI Bold", 14F, FontStyle.Bold); this.lblListTitle.Location = new Point(24, 25); this.lblListTitle.AutoSize = true;
            this.btnAddMed.Text = "+ Add medication"; this.btnAddMed.BackColor = clrTeal; this.btnAddMed.ForeColor = clrWhite; this.btnAddMed.FlatStyle = FlatStyle.Flat; this.btnAddMed.FlatAppearance.BorderSize = 0; this.btnAddMed.Font = new Font("Segoe UI Bold", 10F, FontStyle.Bold); this.btnAddMed.Size = new Size(160, 45); this.btnAddMed.Dock = DockStyle.Right;
            this.pnlListHeader.Controls.AddRange(new Control[] { this.lblListTitle, this.btnAddMed });

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

            this.cmbFormFilter.DropDownStyle = ComboBoxStyle.DropDownList; 
            this.cmbFormFilter.Size = new Size(200, 40); 
            this.cmbFormFilter.Location = new Point(330, 15); 
            this.cmbFormFilter.Font = new Font("Segoe UI", 10.5F);
            this.cmbFormFilter.Items.AddRange(new object[] { "All forms", "Tablet", "Capsule", "Syrup", "Injection" }); this.cmbFormFilter.SelectedIndex = 0;

            this.pnlFilters.Controls.AddRange(new Control[] { this.lblSearchLabel, this.txtSearch, this.cmbFormFilter });

            // DataGridView
            this.dgvMeds.BackgroundColor = clrWhite; this.dgvMeds.BorderStyle = BorderStyle.None; this.dgvMeds.Dock = DockStyle.Fill;
            this.dgvMeds.EnableHeadersVisualStyles = false; this.dgvMeds.RowHeadersVisible = false;
            this.dgvMeds.AllowUserToAddRows = false;
            this.dgvMeds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; this.dgvMeds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeds.ColumnHeadersHeight = 50; this.dgvMeds.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvMeds.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.dgvMeds.ColumnHeadersDefaultCellStyle.ForeColor = clrTextSec;
            this.dgvMeds.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.dgvMeds.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            this.dgvMeds.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            this.dgvMeds.DefaultCellStyle.SelectionBackColor = Color.FromArgb(242, 247, 250);
            this.dgvMeds.DefaultCellStyle.SelectionForeColor = clrTextMain;
            this.dgvMeds.RowTemplate.Height = 65;
            this.dgvMeds.GridColor = Color.FromArgb(237, 242, 247);

            this.colMed.HeaderText = "Medication"; this.colDosage.HeaderText = "Dosage"; this.colForm.HeaderText = "Form"; this.colFrequency.HeaderText = "Frequency";
            this.colEdit.HeaderText = "Actions"; this.colEdit.Text = "✏ Edit"; this.colEdit.UseColumnTextForButtonValue = true; this.colEdit.Width = 85; this.colEdit.FlatStyle = FlatStyle.Flat;
            this.colDelete.HeaderText = ""; this.colDelete.Text = "🗑 Delete"; this.colDelete.UseColumnTextForButtonValue = true; this.colDelete.Width = 85; this.colDelete.FlatStyle = FlatStyle.Flat;
            this.dgvMeds.Columns.AddRange(new DataGridViewColumn[] { this.colMed, this.colDosage, this.colForm, this.colFrequency, this.colEdit, this.colDelete });

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
            this.Text = "RecoverEase - Medication List";

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
            this.pnlStatMost.ResumeLayout(false); this.pnlStatMost.PerformLayout();
            this.pnlStatRecent.ResumeLayout(false); this.pnlStatRecent.PerformLayout();
            this.pnlListCard.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false); this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvMeds).EndInit();
            this.pnlPagination.ResumeLayout(false); this.pnlPagination.PerformLayout();
            this.pnlListHeader.ResumeLayout(false); this.pnlListHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private void SetupNavItem(Panel pnl, Label ico, Label txt, string icoChar, string label, bool isActive, Color activeColor, Color whiteColor)
        {
            pnl.Cursor = Cursors.Hand; pnl.Dock = DockStyle.Top; pnl.Height = 48;
            if (isActive) pnl.BackColor = activeColor;
            ico.AutoSize = true; ico.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            ico.ForeColor = isActive ? whiteColor : Color.FromArgb(45, 55, 72);
            ico.Location = new Point(20, 11); ico.Text = icoChar;
            txt.AutoSize = true; txt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txt.ForeColor = isActive ? whiteColor : Color.FromArgb(45, 55, 72);
            txt.Location = new Point(64, 13); txt.Text = label;
            pnl.Controls.AddRange(new Control[] { ico, txt });
        }

        private Label lblNavDashIcon, lblNavDashText, lblNavStaffIcon, lblNavStaffText, lblNavPatientsIcon, lblNavPatientsText, lblNavReportsIcon, lblNavReportsText, lblSidebarFooter, lblPageTitle, lblPageSubtitle, lblStatTotalVal, lblStatTotalTitle, lblStatTotalSub, lblStatMostVal, lblStatMostTitle, lblStatMostSub, lblStatRecentVal, lblStatRecentTitle, lblStatRecentSub, lblShowingCount, lblSearchLabel, lblListTitle, lblNotifIcon, lblAvatarInitials;
        private Panel pnlSidebar, pnlLogoArea, pnlNavDivider, btnNavDashboard, btnNavStaff, btnNavPatients, btnNavReports, pnlSidebarBottom, pnlTopBar, pnlContent, pnlStatTotal, pnlStatMost, pnlStatRecent, pnlListCard, pnlPagination, pnlFilters, pnlListHeader, pnlAvatarTop;
        private Button btnLogout, btnAddMed;
        private PictureBox picLogo;
        private TableLayoutPanel tlpStats;
        private FlowLayoutPanel pnlTopIcons;
        private TextBox txtSearch;
        private ComboBox cmbFormFilter;
        private DataGridView dgvMeds;
        private DataGridViewTextBoxColumn colMed, colDosage, colForm, colFrequency;
        private DataGridViewButtonColumn colEdit, colDelete;
    }
}