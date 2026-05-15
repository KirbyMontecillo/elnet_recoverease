namespace elnet_recoverease.Admin.Controls
{
    partial class MedicationListControl
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
            this.dgvMeds = new System.Windows.Forms.DataGridView();
            this.colMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblShowingCount = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFormFilter = new System.Windows.Forms.ComboBox();
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnAddMed = new System.Windows.Forms.Button();
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
            
            this.pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeds)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlListHeader.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.pnlStatTotal.SuspendLayout();
            this.pnlStatMost.SuspendLayout();
            this.pnlStatRecent.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;

            // tlpStats
            this.tlpStats.ColumnCount = 3;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.Controls.Add(this.pnlStatTotal, 0, 0);
            this.tlpStats.Controls.Add(this.pnlStatMost, 1, 0);
            this.tlpStats.Controls.Add(this.pnlStatRecent, 2, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpStats.Location = new System.Drawing.Point(24, 24);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.tlpStats.Size = new System.Drawing.Size(1292, 150);
            this.tlpStats.TabIndex = 1;

            // pnlStatTotal
            this.pnlStatTotal.BackColor = clrWhite;
            this.pnlStatTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatTotal.Controls.Add(this.lblStatTotalVal);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalTitle);
            this.pnlStatTotal.Controls.Add(this.lblStatTotalSub);
            this.pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlStatTotal.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlStatTotal.Name = "pnlStatTotal";
            this.pnlStatTotal.Size = new System.Drawing.Size(418, 126);
            
            this.lblStatTotalVal.AutoSize = true;
            this.lblStatTotalVal.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalVal.Location = new System.Drawing.Point(18, 42);
            this.lblStatTotalVal.Name = "lblStatTotalVal";
            this.lblStatTotalVal.Text = "0";
            
            this.lblStatTotalTitle.AutoSize = true;
            this.lblStatTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatTotalTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatTotalTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatTotalTitle.Name = "lblStatTotalTitle";
            this.lblStatTotalTitle.Text = "Total medications";
            
            this.lblStatTotalSub.AutoSize = true;
            this.lblStatTotalSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalSub.ForeColor = clrTeal;
            this.lblStatTotalSub.Location = new System.Drawing.Point(20, 95);
            this.lblStatTotalSub.Name = "lblStatTotalSub";
            this.lblStatTotalSub.Text = "in master list";

            // pnlStatMost
            this.pnlStatMost.BackColor = clrWhite;
            this.pnlStatMost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatMost.Controls.Add(this.lblStatMostVal);
            this.pnlStatMost.Controls.Add(this.lblStatMostTitle);
            this.pnlStatMost.Controls.Add(this.lblStatMostSub);
            this.pnlStatMost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatMost.Location = new System.Drawing.Point(442, 0);
            this.pnlStatMost.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pnlStatMost.Name = "pnlStatMost";
            this.pnlStatMost.Size = new System.Drawing.Size(406, 126);
            
            this.lblStatMostVal.AutoSize = true;
            this.lblStatMostVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatMostVal.Location = new System.Drawing.Point(18, 50);
            this.lblStatMostVal.Name = "lblStatMostVal";
            this.lblStatMostVal.Text = "-";
            
            this.lblStatMostTitle.AutoSize = true;
            this.lblStatMostTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatMostTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatMostTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatMostTitle.Name = "lblStatMostTitle";
            this.lblStatMostTitle.Text = "Most assigned";
            
            this.lblStatMostSub.AutoSize = true;
            this.lblStatMostSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatMostSub.ForeColor = clrTeal;
            this.lblStatMostSub.Location = new System.Drawing.Point(20, 95);
            this.lblStatMostSub.Name = "lblStatMostSub";
            this.lblStatMostSub.Text = "this month";

            // pnlStatRecent
            this.pnlStatRecent.BackColor = clrWhite;
            this.pnlStatRecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatRecent.Controls.Add(this.lblStatRecentVal);
            this.pnlStatRecent.Controls.Add(this.lblStatRecentTitle);
            this.pnlStatRecent.Controls.Add(this.lblStatRecentSub);
            this.pnlStatRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatRecent.Location = new System.Drawing.Point(872, 0);
            this.pnlStatRecent.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlStatRecent.Name = "pnlStatRecent";
            this.pnlStatRecent.Size = new System.Drawing.Size(420, 126);
            
            this.lblStatRecentVal.AutoSize = true;
            this.lblStatRecentVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatRecentVal.Location = new System.Drawing.Point(18, 50);
            this.lblStatRecentVal.Name = "lblStatRecentVal";
            this.lblStatRecentVal.Text = "-";
            
            this.lblStatRecentTitle.AutoSize = true;
            this.lblStatRecentTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatRecentTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatRecentTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatRecentTitle.Name = "lblStatRecentTitle";
            this.lblStatRecentTitle.Text = "Recently added";
            
            this.lblStatRecentSub.AutoSize = true;
            this.lblStatRecentSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatRecentSub.ForeColor = clrTeal;
            this.lblStatRecentSub.Location = new System.Drawing.Point(20, 95);
            this.lblStatRecentSub.Name = "lblStatRecentSub";
            this.lblStatRecentSub.Text = "-";

            // pnlListCard
            this.pnlListCard.BackColor = clrWhite;
            this.pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListCard.Controls.Add(this.dgvMeds);
            this.pnlListCard.Controls.Add(this.pnlPagination);
            this.pnlListCard.Controls.Add(this.pnlFilters);
            this.pnlListCard.Controls.Add(this.pnlListHeader);
            this.pnlListCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListCard.Location = new System.Drawing.Point(24, 174);
            this.pnlListCard.Name = "pnlListCard";
            this.pnlListCard.Size = new System.Drawing.Size(1292, 612);

            // dgvMeds
            this.dgvMeds.AllowUserToAddRows = false;
            this.dgvMeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeds.BackgroundColor = clrWhite;
            this.dgvMeds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMeds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = clrWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            dataGridViewCellStyle1.SelectionBackColor = clrWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMeds.ColumnHeadersHeight = 50;
            this.dgvMeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colMed, this.colDosage, this.colForm, this.colFrequency, this.colEdit, this.colDelete });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeds.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeds.EnableHeadersVisualStyles = false;
            this.dgvMeds.GridColor = System.Drawing.Color.FromArgb(237, 242, 247);
            this.dgvMeds.Location = new System.Drawing.Point(0, 145);
            this.dgvMeds.Name = "dgvMeds";
            this.dgvMeds.RowHeadersVisible = false;
            this.dgvMeds.RowTemplate.Height = 65;
            this.dgvMeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMeds_CellContentClick);

            this.colMed.HeaderText = "Medication";
            this.colMed.Name = "colMed";
            this.colDosage.HeaderText = "Dosage";
            this.colDosage.Name = "colDosage";
            this.colForm.HeaderText = "Form";
            this.colForm.Name = "colForm";
            this.colFrequency.HeaderText = "Frequency";
            this.colFrequency.Name = "colFrequency";
            this.colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEdit.HeaderText = "Actions";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "✏ Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "🗑 Delete";
            this.colDelete.UseColumnTextForButtonValue = true;

            // pnlPagination
            this.pnlPagination.Controls.Add(this.lblShowingCount);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(0, 560);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(1290, 50);
            
            this.lblShowingCount.AutoSize = true;
            this.lblShowingCount.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblShowingCount.Location = new System.Drawing.Point(24, 15);
            this.lblShowingCount.Name = "lblShowingCount";
            this.lblShowingCount.Text = "";

            // pnlFilters
            this.pnlFilters.Controls.Add(this.lblSearchLabel);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.cmbFormFilter);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 80);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1290, 65);
            
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblSearchLabel.Location = new System.Drawing.Point(24, 18);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Text = "Search:";
            
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSearch.Location = new System.Drawing.Point(100, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 31);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            
            this.cmbFormFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormFilter.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbFormFilter.Items.AddRange(new object[] { "All forms", "Tablet", "Capsule", "Syrup", "Injection" });
            this.cmbFormFilter.Location = new System.Drawing.Point(330, 15);
            this.cmbFormFilter.Name = "cmbFormFilter";
            this.cmbFormFilter.Size = new System.Drawing.Size(200, 31);
            this.cmbFormFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFormFilter_SelectedIndexChanged);

            // pnlListHeader
            this.pnlListHeader.Controls.Add(this.lblListTitle);
            this.pnlListHeader.Controls.Add(this.btnAddMed);
            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlListHeader.Name = "pnlListHeader";
            this.pnlListHeader.Padding = new System.Windows.Forms.Padding(24, 15, 24, 15);
            this.pnlListHeader.Size = new System.Drawing.Size(1290, 80);
            
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.Location = new System.Drawing.Point(24, 25);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Text = "Medication list";
            
            this.btnAddMed.BackColor = clrTeal;
            this.btnAddMed.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddMed.FlatAppearance.BorderSize = 0;
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMed.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddMed.ForeColor = clrWhite;
            this.btnAddMed.Location = new System.Drawing.Point(1136, 15);
            this.btnAddMed.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(130, 50);
            this.btnAddMed.Text = "+ Add new";
            this.btnAddMed.UseVisualStyleBackColor = false;
            this.btnAddMed.Click += new System.EventHandler(this.BtnAddMed_Click);

            // MedicationListControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            this.Controls.Add(this.pnlListCard);
            this.Controls.Add(this.tlpStats);
            this.Name = "MedicationListControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(1340, 810);
            this.Load += new System.EventHandler(this.MedicationListControl_Load);
            
            this.pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeds)).EndInit();
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlListHeader.ResumeLayout(false);
            this.pnlListHeader.PerformLayout();
            this.tlpStats.ResumeLayout(false);
            this.pnlStatTotal.ResumeLayout(false);
            this.pnlStatTotal.PerformLayout();
            this.pnlStatMost.ResumeLayout(false);
            this.pnlStatMost.PerformLayout();
            this.pnlStatRecent.ResumeLayout(false);
            this.pnlStatRecent.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.DataGridView dgvMeds;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblShowingCount;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFormFilter;
        private System.Windows.Forms.Panel pnlListHeader;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Panel pnlStatTotal;
        private System.Windows.Forms.Label lblStatTotalVal;
        private System.Windows.Forms.Label lblStatTotalTitle;
        private System.Windows.Forms.Label lblStatTotalSub;
        private System.Windows.Forms.Panel pnlStatMost;
        private System.Windows.Forms.Label lblStatMostVal;
        private System.Windows.Forms.Label lblStatMostTitle;
        private System.Windows.Forms.Label lblStatMostSub;
        private System.Windows.Forms.Panel pnlStatRecent;
        private System.Windows.Forms.Label lblStatRecentVal;
        private System.Windows.Forms.Label lblStatRecentTitle;
        private System.Windows.Forms.Label lblStatRecentSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequency;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
