namespace elnet_recoverease.Doctor.Controls
{
    partial class PatientListControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlContent = new Panel();
            pnlGridContainer = new Panel();
            dgvPatients = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colLastVisit = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewButtonColumn();
            colSchedule = new DataGridViewButtonColumn();
            pnlActionHeader = new Panel();
            tlpHeader = new TableLayoutPanel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddPatient = new Button();
            pnlContent.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            pnlActionHeader.SuspendLayout();
            tlpHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(242, 247, 250);
            pnlContent.Controls.Add(pnlGridContainer);
            pnlContent.Controls.Add(pnlActionHeader);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(1060, 800);
            pnlContent.TabIndex = 0;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvPatients);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(20, 90);
            pnlGridContainer.Margin = new Padding(0, 20, 0, 0);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Size = new Size(1020, 690);
            pnlGridContainer.TabIndex = 0;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.BorderStyle = BorderStyle.None;
            dgvPatients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.ColumnHeadersHeight = 45;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colContact, colLastVisit, colAction, colSchedule });
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.Location = new Point(0, 0);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.Height = 55;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(1020, 690);
            dgvPatients.TabIndex = 0;
            dgvPatients.CellContentClick += new DataGridViewCellEventHandler(dgvPatients_CellContentClick);
            dgvPatients.CellPainting += new DataGridViewCellPaintingEventHandler(Dgv_CellPainting);
            // 
            // colId
            // 
            colId.FillWeight = 15F;
            colId.HeaderText = "Patient ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.FillWeight = 30F;
            colName.HeaderText = "Full Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colContact
            // 
            colContact.FillWeight = 20F;
            colContact.HeaderText = "Contact";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            colContact.ReadOnly = true;
            // 
            // colLastVisit
            // 
            colLastVisit.FillWeight = 15F;
            colLastVisit.HeaderText = "Last Visit";
            colLastVisit.MinimumWidth = 6;
            colLastVisit.Name = "colLastVisit";
            colLastVisit.ReadOnly = true;
            // 
            // colAction
            // 
            colAction.FillWeight = 10F;
            colAction.FlatStyle = FlatStyle.Flat;
            colAction.HeaderText = "Action";
            colAction.MinimumWidth = 6;
            colAction.Name = "colAction";
            colAction.ReadOnly = true;
            colAction.Text = "View";
            colAction.UseColumnTextForButtonValue = true;
            // 
            // colSchedule
            // 
            colSchedule.FillWeight = 10F;
            colSchedule.FlatStyle = FlatStyle.Flat;
            colSchedule.HeaderText = "Booking";
            colSchedule.MinimumWidth = 6;
            colSchedule.Name = "colSchedule";
            colSchedule.ReadOnly = true;
            colSchedule.Text = "Schedule";
            colSchedule.UseColumnTextForButtonValue = true;
            // 
            // pnlActionHeader
            // 
            pnlActionHeader.BackColor = Color.FromArgb(242, 247, 250);
            pnlActionHeader.Controls.Add(tlpHeader);
            pnlActionHeader.Dock = DockStyle.Top;
            pnlActionHeader.Location = new Point(20, 20);
            pnlActionHeader.Name = "pnlActionHeader";
            pnlActionHeader.Size = new Size(1020, 70);
            pnlActionHeader.TabIndex = 1;
            // 
            // tlpHeader
            // 
            tlpHeader.ColumnCount = 3;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHeader.Controls.Add(txtSearch, 0, 0);
            tlpHeader.Controls.Add(btnSearch, 1, 0);
            tlpHeader.Controls.Add(btnAddPatient, 2, 0);
            tlpHeader.Dock = DockStyle.Top;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1020, 60);
            tlpHeader.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(0, 10);
            txtSearch.Margin = new Padding(0, 10, 10, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name or ID...";
            txtSearch.Size = new Size(350, 32);
            txtSearch.TabIndex = 0;
            txtSearch.KeyDown += new KeyEventHandler(txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.Location = new Point(360, 10);
            btnSearch.Margin = new Padding(0, 10, 0, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 40);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += new EventHandler(btnSearch_Click);
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.FromArgb(0, 168, 168);
            btnAddPatient.Cursor = Cursors.Hand;
            btnAddPatient.Dock = DockStyle.Right;
            btnAddPatient.FlatAppearance.BorderSize = 0;
            btnAddPatient.FlatStyle = FlatStyle.Flat;
            btnAddPatient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddPatient.ForeColor = Color.White;
            btnAddPatient.Location = new Point(840, 10);
            btnAddPatient.Margin = new Padding(0, 10, 0, 10);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(180, 40);
            btnAddPatient.TabIndex = 2;
            btnAddPatient.Text = "+ Register Patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += new EventHandler(btnAddPatient_Click);
            // 
            // PatientListControl
            // 
            Controls.Add(pnlContent);
            Name = "PatientListControl";
            Size = new Size(1060, 800);
            pnlContent.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            pnlActionHeader.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            tlpHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlActionHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastVisit;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private System.Windows.Forms.DataGridViewButtonColumn colSchedule;
        private TableLayoutPanel tlpHeader;
    }
}
