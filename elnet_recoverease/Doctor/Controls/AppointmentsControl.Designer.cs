namespace elnet_recoverease.Doctor.Controls
{
    partial class AppointmentsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnNewAppointment = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);

            // Header (using TableLayoutPanel for absolute stability)
            System.Windows.Forms.TableLayoutPanel tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            tlpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            tlpHeader.Height = 85;
            tlpHeader.ColumnCount = 3;
            tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));

            // Date Filter Group
            System.Windows.Forms.Panel pnlDate = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Fill };
            this.lblFilterDate.Text = "DATE FILTER";
            this.lblFilterDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterDate.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFilterDate.Location = new System.Drawing.Point(0, 5);
            this.lblFilterDate.AutoSize = true;
            this.dtpFilterDate.Location = new System.Drawing.Point(0, 28);
            this.dtpFilterDate.Size = new System.Drawing.Size(220, 32);
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            pnlDate.Controls.Add(this.lblFilterDate);
            pnlDate.Controls.Add(this.dtpFilterDate);
            this.dtpFilterDate.ValueChanged += new System.EventHandler(this.dtpFilterDate_ValueChanged);

            // Status Filter Group
            System.Windows.Forms.Panel pnlStatus = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Fill };
            this.lblFilterStatus.Text = "STATUS";
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFilterStatus.Location = new System.Drawing.Point(0, 5);
            this.lblFilterStatus.AutoSize = true;
            this.cmbFilterStatus.Location = new System.Drawing.Point(0, 28);
            this.cmbFilterStatus.Size = new System.Drawing.Size(200, 32);
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Missed" });
            this.cmbFilterStatus.SelectedIndex = 0;
            pnlStatus.Controls.Add(this.lblFilterStatus);
            pnlStatus.Controls.Add(this.cmbFilterStatus);
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);

            // New Appointment Button
            this.btnNewAppointment.Text = "+ New Appointment";
            this.btnNewAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewAppointment.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnNewAppointment.BackColor = clrTeal;
            this.btnNewAppointment.ForeColor = clrWhite;
            this.btnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAppointment.FlatAppearance.BorderSize = 0;
            this.btnNewAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAppointment.Click += new System.EventHandler(this.btnNewAppointment_Click);

            tlpHeader.Controls.Add(pnlDate, 0, 0);
            tlpHeader.Controls.Add(pnlStatus, 1, 0);
            tlpHeader.Controls.Add(this.btnNewAppointment, 2, 0);

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
            this.dgvAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvAppointments_CellFormatting);
            this.dgvAppointments.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_CellPainting);
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellContentClick);
            this.dgvAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellDoubleClick);

            // Assembly
            this.pnlContent.Controls.Add(this.dgvAppointments);
            this.pnlContent.Controls.Add(tlpHeader);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Button btnNewAppointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
    }
}
