namespace elnet_recoverease.Admin.Controls
{
    partial class AdminDashboardControl
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainScroll = new System.Windows.Forms.Panel();
            this.tlpTopCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.cardActive = new System.Windows.Forms.Panel();
            this.cardAppt = new System.Windows.Forms.Panel();
            this.cardMissed = new System.Windows.Forms.Panel();
            this.tlpMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAdherence = new System.Windows.Forms.Panel();
            this.lblAdherenceTitle = new System.Windows.Forms.Label();
            this.flpAdherence = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.flpActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblPatientsTitle = new System.Windows.Forms.Label();
            this.dgvRecentPatients = new System.Windows.Forms.DataGridView();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNextAppt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdherence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlMainScroll.SuspendLayout();
            this.tlpTopCards.SuspendLayout();
            this.tlpMiddle.SuspendLayout();
            this.pnlAdherence.SuspendLayout();
            this.pnlActivity.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPatients)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMainScroll
            // 
            this.pnlMainScroll.AutoScroll = true;
            this.pnlMainScroll.BackColor = System.Drawing.Color.White;
            this.pnlMainScroll.Controls.Add(this.pnlBottom);
            this.pnlMainScroll.Controls.Add(this.tlpMiddle);
            this.pnlMainScroll.Controls.Add(this.tlpTopCards);
            this.pnlMainScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainScroll.Location = new System.Drawing.Point(0, 0);
            this.pnlMainScroll.Name = "pnlMainScroll";
            this.pnlMainScroll.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.pnlMainScroll.Size = new System.Drawing.Size(1200, 800);
            this.pnlMainScroll.TabIndex = 0;

            // 
            // tlpTopCards
            // 
            this.tlpTopCards.ColumnCount = 4;
            this.tlpTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopCards.Controls.Add(this.cardTotal, 0, 0);
            this.tlpTopCards.Controls.Add(this.cardActive, 1, 0);
            this.tlpTopCards.Controls.Add(this.cardAppt, 2, 0);
            this.tlpTopCards.Controls.Add(this.cardMissed, 3, 0);
            this.tlpTopCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopCards.Height = 120;
            this.tlpTopCards.Name = "tlpTopCards";

            // Card place holders (populated in cs file for dynamic labels)
            this.cardTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTotal.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.cardTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.cardActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActive.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.cardActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.cardAppt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAppt.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.cardAppt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.cardMissed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMissed.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cardMissed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // tlpMiddle
            // 
            this.tlpMiddle.ColumnCount = 2;
            this.tlpMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpMiddle.Controls.Add(this.pnlAdherence, 0, 0);
            this.tlpMiddle.Controls.Add(this.pnlActivity, 1, 0);
            this.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMiddle.Height = 350;
            this.tlpMiddle.Name = "tlpMiddle";
            this.tlpMiddle.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);

            // pnlAdherence
            this.pnlAdherence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdherence.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlAdherence.Controls.Add(this.flpAdherence);
            this.pnlAdherence.Controls.Add(this.lblAdherenceTitle);

            this.lblAdherenceTitle.Text = "Patient adherence by doctor";
            this.lblAdherenceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdherenceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdherenceTitle.Height = 40;

            this.flpAdherence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAdherence.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAdherence.WrapContents = false;
            this.flpAdherence.AutoScroll = true;

            // pnlActivity
            this.pnlActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActivity.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pnlActivity.Controls.Add(this.flpActivity);
            this.pnlActivity.Controls.Add(this.lblActivityTitle);

            this.lblActivityTitle.Text = "Recent activity";
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActivityTitle.Height = 40;

            this.flpActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActivity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpActivity.WrapContents = false;
            this.flpActivity.AutoScroll = true;

            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottom.Height = 400;
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnlBottom.Controls.Add(this.dgvRecentPatients);
            this.pnlBottom.Controls.Add(this.lblPatientsTitle);

            this.lblPatientsTitle.Text = "Recent patients";
            this.lblPatientsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPatientsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatientsTitle.Height = 40;

            // dgvRecentPatients
            this.dgvRecentPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentPatients.AllowUserToAddRows = false;
            this.dgvRecentPatients.AllowUserToDeleteRows = false;
            this.dgvRecentPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentPatients.ColumnHeadersHeight = 40;
            
            this.dgvRecentPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colFullName, this.colDoctor, this.colPlan, this.colNextAppt, this.colAdherence, this.colStatus
            });

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentPatients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentPatients.EnableHeadersVisualStyles = false;
            this.dgvRecentPatients.ReadOnly = true;
            this.dgvRecentPatients.RowHeadersVisible = false;
            this.dgvRecentPatients.RowTemplate.Height = 45;
            this.dgvRecentPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.colFullName.HeaderText = "FullName"; this.colFullName.DataPropertyName = "FullName";
            this.colDoctor.HeaderText = "Doctor"; this.colDoctor.DataPropertyName = "Doctor";
            this.colPlan.HeaderText = "Plan"; this.colPlan.DataPropertyName = "Plan";
            this.colNextAppt.HeaderText = "NextAppt"; this.colNextAppt.DataPropertyName = "NextAppt";
            this.colAdherence.HeaderText = "Adherence"; this.colAdherence.DataPropertyName = "Adherence";
            this.colStatus.HeaderText = "Status"; this.colStatus.DataPropertyName = "Status";

            // AdminDashboardControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMainScroll);
            this.Name = "AdminDashboardControl";
            this.Size = new System.Drawing.Size(1200, 800);
            
            this.pnlMainScroll.ResumeLayout(false);
            this.tlpTopCards.ResumeLayout(false);
            this.tlpMiddle.ResumeLayout(false);
            this.pnlAdherence.ResumeLayout(false);
            this.pnlActivity.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPatients)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlMainScroll;
        private System.Windows.Forms.TableLayoutPanel tlpTopCards;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Panel cardAppt;
        private System.Windows.Forms.Panel cardMissed;
        private System.Windows.Forms.TableLayoutPanel tlpMiddle;
        private System.Windows.Forms.Panel pnlAdherence;
        private System.Windows.Forms.Label lblAdherenceTitle;
        private System.Windows.Forms.FlowLayoutPanel flpAdherence;
        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.FlowLayoutPanel flpActivity;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblPatientsTitle;
        private System.Windows.Forms.DataGridView dgvRecentPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNextAppt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdherence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
