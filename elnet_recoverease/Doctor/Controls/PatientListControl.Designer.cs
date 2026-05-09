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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlActionHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSchedule = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlContent.SuspendLayout();
            this.pnlActionHeader.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrNavyActive = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);

            // Action Header
            this.pnlActionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionHeader.Height = 80;
            this.pnlActionHeader.BackColor = clrBg;
            
            this.txtSearch.Location = new System.Drawing.Point(0, 20);
            this.txtSearch.Size = new System.Drawing.Size(350, 40);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.PlaceholderText = "Search by name or ID...";

            this.btnSearch.Location = new System.Drawing.Point(365, 20);
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.Text = "Search";
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.BackColor = clrWhite;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnAddPatient.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddPatient.Location = new System.Drawing.Point(880, 20);
            this.btnAddPatient.Size = new System.Drawing.Size(170, 40);
            this.btnAddPatient.Text = "+ Register Patient";
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.BackColor = clrTeal;
            this.btnAddPatient.ForeColor = clrWhite;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlActionHeader.Controls.Add(this.txtSearch);
            this.pnlActionHeader.Controls.Add(this.btnSearch);
            this.pnlActionHeader.Controls.Add(this.btnAddPatient);

            // Grid Container
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.BackColor = clrWhite;
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(0);
            this.pnlGridContainer.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);

            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.BackgroundColor = clrWhite;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.RowTemplate.Height = 55;
            this.dgvPatients.ColumnHeadersHeight = 45;
            this.dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvPatients.EnableHeadersVisualStyles = false;

            this.colId.HeaderText = "Patient ID"; this.colId.FillWeight = 15;
            this.colName.HeaderText = "Full Name"; this.colName.FillWeight = 30;
            this.colContact.HeaderText = "Contact"; this.colContact.FillWeight = 20;
            this.colLastVisit.HeaderText = "Last Visit"; this.colLastVisit.FillWeight = 15;
            
            this.colAction.HeaderText = "Action"; 
            this.colAction.FillWeight = 10;
            this.colAction.Text = "View";
            this.colAction.UseColumnTextForButtonValue = true;
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.colSchedule.HeaderText = "Booking";
            this.colSchedule.FillWeight = 10;
            this.colSchedule.Text = "Schedule";
            this.colSchedule.UseColumnTextForButtonValue = true;
            this.colSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colName, this.colContact, this.colLastVisit, this.colAction, this.colSchedule
            });
            
            this.pnlGridContainer.Controls.Add(this.dgvPatients);

            this.pnlContent.Controls.Add(this.pnlGridContainer);
            this.pnlContent.Controls.Add(this.pnlActionHeader);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.pnlActionHeader.ResumeLayout(false);
            this.pnlActionHeader.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
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
    }
}
