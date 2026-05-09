namespace elnet_recoverease.Doctor.Controls
{
    partial class AppointmentsControl
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
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnNewAppointment = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();

            this.pnlContent.SuspendLayout();
            this.pnlActionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrTextDark = System.Drawing.Color.FromArgb(30, 43, 60);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);

            // Action Header
            this.pnlActionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionHeader.Height = 85;
            this.pnlActionHeader.BackColor = clrBg;

            this.lblFilterDate.Text = "Date Filter";
            this.lblFilterDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterDate.ForeColor = clrTextDark;
            this.lblFilterDate.Location = new System.Drawing.Point(0, 5);
            this.lblFilterDate.AutoSize = true;

            this.dtpFilterDate.Location = new System.Drawing.Point(0, 28);
            this.dtpFilterDate.Size = new System.Drawing.Size(200, 35);
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblFilterStatus.Text = "Status";
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = clrTextDark;
            this.lblFilterStatus.Location = new System.Drawing.Point(220, 5);
            this.lblFilterStatus.AutoSize = true;

            this.cmbFilterStatus.Location = new System.Drawing.Point(220, 28);
            this.cmbFilterStatus.Size = new System.Drawing.Size(180, 35);
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Missed" });
            this.cmbFilterStatus.SelectedIndex = 0;

            this.btnNewAppointment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnNewAppointment.Location = new System.Drawing.Point(850, 25);
            this.btnNewAppointment.Size = new System.Drawing.Size(200, 40);
            this.btnNewAppointment.Text = "+ New Appointment";
            this.btnNewAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewAppointment.BackColor = clrTeal;
            this.btnNewAppointment.ForeColor = clrWhite;
            this.btnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAppointment.FlatAppearance.BorderSize = 0;
            this.btnNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlActionHeader.Controls.Add(this.lblFilterDate);
            this.pnlActionHeader.Controls.Add(this.dtpFilterDate);
            this.pnlActionHeader.Controls.Add(this.lblFilterStatus);
            this.pnlActionHeader.Controls.Add(this.cmbFilterStatus);
            this.pnlActionHeader.Controls.Add(this.btnNewAppointment);

            // DataGridView
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.BackgroundColor = clrWhite;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.RowTemplate.Height = 55;
            this.dgvAppointments.ColumnHeadersHeight = 45;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvAppointments.EnableHeadersVisualStyles = false;

            this.pnlContent.Controls.Add(this.dgvAppointments);
            this.pnlContent.Controls.Add(this.pnlActionHeader);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.pnlActionHeader.ResumeLayout(false);
            this.pnlActionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlActionHeader;
        private System.Windows.Forms.Label lblFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
    }
}
