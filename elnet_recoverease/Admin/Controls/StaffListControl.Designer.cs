namespace elnet_recoverease.Admin.Controls
{
    partial class StaffListControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlListCard = new System.Windows.Forms.Panel();
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
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbRoleFilter = new System.Windows.Forms.ComboBox();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStatTotal = new System.Windows.Forms.Panel();
            this.lblStatTotalVal = new System.Windows.Forms.Label();
            this.lblStatTotalTitle = new System.Windows.Forms.Label();
            this.lblStatTotalSub = new System.Windows.Forms.Label();
            this.pnlStatTotalStrip = new System.Windows.Forms.Panel();
            this.pnlStatDoctors = new System.Windows.Forms.Panel();
            this.pnlStatDoctorsStrip = new System.Windows.Forms.Panel();
            this.lblStatDoctorsVal = new System.Windows.Forms.Label();
            this.lblStatDoctorsTitle = new System.Windows.Forms.Label();
            this.lblStatDoctorsSub = new System.Windows.Forms.Label();

            this.pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlListHeader.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.pnlStatTotal.SuspendLayout();
            this.pnlStatDoctors.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrLightBg = System.Drawing.Color.FromArgb(247, 250, 252);
            System.Drawing.Color clrBorder = System.Drawing.Color.FromArgb(226, 232, 240);
            System.Drawing.Color clrTextMuted = System.Drawing.Color.FromArgb(74, 85, 104);

            // tlpStats
            this.tlpStats.ColumnCount = 2;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStats.Controls.Add(this.pnlStatTotal, 0, 0);
            this.tlpStats.Controls.Add(this.pnlStatDoctors, 1, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpStats.Location = new System.Drawing.Point(24, 24);
            this.tlpStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.tlpStats.Size = new System.Drawing.Size(1292, 200);

            // pnlStatTotal
            this.pnlStatTotal.BackColor = clrWhite;
            this.pnlStatTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatTotal.Controls.Add(this.pnlStatTotalStrip);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalVal);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalTitle);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalSub);
            this.pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlStatTotal.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            
            this.pnlStatTotalStrip.BackColor = clrTeal;
            this.pnlStatTotalStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatTotalStrip.Height = 4;

            this.lblStatTotalVal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalVal.Location = new System.Drawing.Point(18, 55);
            this.lblStatTotalVal.AutoSize = true;
            this.lblStatTotalVal.Text = "0";
            this.lblStatTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalTitle.ForeColor = clrTextMuted;
            this.lblStatTotalTitle.Location = new System.Drawing.Point(20, 25);
            this.lblStatTotalTitle.AutoSize = true;
            this.lblStatTotalTitle.Text = "TOTAL STAFF";
            this.lblStatTotalSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatTotalSub.ForeColor = clrTextMuted;
            this.lblStatTotalSub.Location = new System.Drawing.Point(20, 130);
            this.lblStatTotalSub.AutoSize = true;
            this.lblStatTotalSub.Text = "across all departments";

            // pnlStatDoctors
            this.pnlStatDoctors.BackColor = clrWhite;
            this.pnlStatDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatDoctors.Controls.Add(this.pnlStatDoctorsStrip);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsVal);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsTitle);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsSub);
            this.pnlStatDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatDoctors.Location = new System.Drawing.Point(658, 0);
            this.pnlStatDoctors.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);

            this.pnlStatDoctorsStrip.BackColor = clrNavy;
            this.pnlStatDoctorsStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatDoctorsStrip.Height = 4;

            this.lblStatDoctorsVal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblStatDoctorsVal.Location = new System.Drawing.Point(18, 55);
            this.lblStatDoctorsVal.AutoSize = true;
            this.lblStatDoctorsVal.Text = "0";
            this.lblStatDoctorsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatDoctorsTitle.ForeColor = clrTextMuted;
            this.lblStatDoctorsTitle.Location = new System.Drawing.Point(20, 25);
            this.lblStatDoctorsTitle.AutoSize = true;
            this.lblStatDoctorsTitle.Text = "DOCTORS";
            this.lblStatDoctorsSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatDoctorsSub.ForeColor = clrTextMuted;
            this.lblStatDoctorsSub.Location = new System.Drawing.Point(20, 130);
            this.lblStatDoctorsSub.AutoSize = true;
            this.lblStatDoctorsSub.Text = "active practitioners";

            // pnlListCard
            this.pnlListCard.BackColor = clrWhite;
            this.pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListCard.Controls.Add(this.dgvStaff);
            this.pnlListCard.Controls.Add(this.pnlPagination);
            this.pnlListCard.Controls.Add(this.pnlFilters);
            this.pnlListCard.Controls.Add(this.pnlListHeader);
            this.pnlListCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListCard.Location = new System.Drawing.Point(24, 174);
            this.pnlListCard.Size = new System.Drawing.Size(1292, 612);

            // dgvStaff
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = clrWhite;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.ColumnHeadersHeight = 50;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colName, this.colRole, this.colSpecialty, this.colPatients, this.colStatus, this.colView, this.colEdit, this.colDelete });
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(237, 242, 247);
            this.dgvStaff.Location = new System.Drawing.Point(0, 145);
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowTemplate.Height = 65;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            this.dgvStaff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStaff_CellFormatting);

            this.colName.HeaderText = "Name";
            this.colRole.HeaderText = "Role";
            this.colSpecialty.HeaderText = "Specialty";
            this.colPatients.HeaderText = "Patients";
            this.colStatus.HeaderText = "Status";
            
            // Header Style
            this.dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = clrNavy;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = clrWhite;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvStaff.ColumnHeadersHeight = 45;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            
            this.colView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colView.HeaderText = "Actions";
            this.colView.Text = "👁 View";
            this.colView.UseColumnTextForButtonValue = true;
            this.colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEdit.Text = "✏ Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.Text = "🗑 Delete";
            this.colDelete.UseColumnTextForButtonValue = true;

            this.dgvStaff.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(238, 243, 247);
            this.dgvStaff.DefaultCellStyle.SelectionForeColor = clrNavy;
            this.dgvStaff.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // pnlPagination
            this.pnlPagination.Controls.Add(this.lblShowingCount);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Height = 50;
            this.lblShowingCount.AutoSize = true;
            this.lblShowingCount.Location = new System.Drawing.Point(24, 15);

            // pnlFilters
            this.pnlFilters.Controls.Add(this.lblSearchLabel);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.cmbRoleFilter);
            this.pnlFilters.Controls.Add(this.cmbStatusFilter);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Height = 75;
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(250, 252, 254);
            
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchLabel.ForeColor = clrTextMuted;
            this.lblSearchLabel.Location = new System.Drawing.Point(24, 25);
            this.lblSearchLabel.Text = "Search:";
            
            this.txtSearch.Location = new System.Drawing.Point(100, 21);
            this.txtSearch.Size = new System.Drawing.Size(260, 31);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            
            this.cmbRoleFilter.Items.AddRange(new object[] { "All roles", "Doctor", "Admin" });
            this.cmbRoleFilter.Location = new System.Drawing.Point(380, 21);
            this.cmbRoleFilter.Size = new System.Drawing.Size(180, 31);
            this.cmbRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleFilter.SelectedIndexChanged += new System.EventHandler(this.FilterControls_Changed);
            
            this.cmbStatusFilter.Items.AddRange(new object[] { "All status", "Active", "Inactive" });
            this.cmbStatusFilter.Location = new System.Drawing.Point(580, 21);
            this.cmbStatusFilter.Size = new System.Drawing.Size(180, 31);
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.FilterControls_Changed);

            // pnlListHeader
            this.pnlListHeader.Controls.Add(this.lblListTitle);
            this.pnlListHeader.Controls.Add(this.btnAddStaff);
            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListHeader.Height = 80;
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.Location = new System.Drawing.Point(24, 25);
            this.lblListTitle.Text = "Staff list";
            this.btnAddStaff.BackColor = clrTeal;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.ForeColor = clrWhite;
            this.btnAddStaff.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddStaff.Location = new System.Drawing.Point(1108, 15);
            this.btnAddStaff.Size = new System.Drawing.Size(160, 45);
            this.btnAddStaff.Text = "+ Add new staff";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);

            // StaffListControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            this.Controls.Add(this.pnlListCard);
            this.Controls.Add(this.tlpStats);
            this.Name = "StaffListControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(1340, 810);
            this.Load += new System.EventHandler(this.StaffListControl_Load);

            this.pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlListHeader.ResumeLayout(false);
            this.pnlListHeader.PerformLayout();
            this.tlpStats.ResumeLayout(false);
            this.pnlStatTotal.ResumeLayout(false);
            this.pnlStatTotal.PerformLayout();
            this.pnlStatDoctors.ResumeLayout(false);
            this.pnlStatDoctors.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblShowingCount;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbRoleFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Panel pnlListHeader;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Panel pnlStatTotal;
        private System.Windows.Forms.Panel pnlStatTotalStrip;
        private System.Windows.Forms.Label lblStatTotalVal;
        private System.Windows.Forms.Label lblStatTotalTitle;
        private System.Windows.Forms.Label lblStatTotalSub;
        private System.Windows.Forms.Panel pnlStatDoctors;
        private System.Windows.Forms.Panel pnlStatDoctorsStrip;
        private System.Windows.Forms.Label lblStatDoctorsVal;
        private System.Windows.Forms.Label lblStatDoctorsTitle;
        private System.Windows.Forms.Label lblStatDoctorsSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
