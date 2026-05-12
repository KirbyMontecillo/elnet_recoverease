namespace elnet_recoverease.PatientStation.Controls
{
    partial class PatientTreatmentPlansControl
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
            this.tlpTreatmentCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardActive = new System.Windows.Forms.Panel();
            this.lblCardActiveTitle = new System.Windows.Forms.Label();
            this.lblCardActiveValue = new System.Windows.Forms.Label();
            this.lblCardActiveIcon = new System.Windows.Forms.Label();
            this.pnlTreatmentList = new System.Windows.Forms.Panel();
            this.lblTreatmentListTitle = new System.Windows.Forms.Label();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlContent.SuspendLayout();
            this.tlpTreatmentCards.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.pnlTreatmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);

            // UserControl
            this.BackColor = clrBg;
            this.Size = new System.Drawing.Size(1200, 800);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.AutoScroll = true;

            // Stat Cards
            this.tlpTreatmentCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTreatmentCards.Height = 160;
            this.tlpTreatmentCards.ColumnCount = 1;
            this.tlpTreatmentCards.RowCount = 1;
            this.tlpTreatmentCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            SetupStatCard(this.cardActive, this.lblCardActiveTitle, this.lblCardActiveValue, this.lblCardActiveIcon, "CURRENT TREATMENT PROGRESS", "🩹", clrNavy);
            tlpTreatmentCards.Controls.Add(this.cardActive, 0, 0);

            // Grid Section
            this.pnlTreatmentList.BackColor = clrWhite;
            this.pnlTreatmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTreatmentList.Padding = new System.Windows.Forms.Padding(24);
            this.pnlTreatmentList.Margin = new System.Windows.Forms.Padding(0, 24, 0, 0);
            
            this.lblTreatmentListTitle.Text = "Goals & Recovery Milestones";
            this.lblTreatmentListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTreatmentListTitle.ForeColor = clrNavy;
            this.lblTreatmentListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTreatmentListTitle.Height = 45;

            // dgvTreatments Styling
            this.dgvTreatments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreatments.BackgroundColor = clrWhite;
            this.dgvTreatments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTreatments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTreatments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTreatments.RowHeadersVisible = false;
            this.dgvTreatments.AllowUserToAddRows = false;
            this.dgvTreatments.AllowUserToDeleteRows = false;
            this.dgvTreatments.AllowUserToResizeRows = false;
            this.dgvTreatments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatments.ReadOnly = true;
            this.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreatments.RowTemplate.Height = 50;
            this.dgvTreatments.EnableHeadersVisualStyles = false;
            this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(240, 244, 248);

            this.dgvTreatments.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = System.Drawing.Color.FromArgb(248, 250, 252),
                ForeColor = System.Drawing.Color.FromArgb(100, 116, 139),
                Font = new System.Drawing.Font("Segoe UI Bold", 9F, System.Drawing.FontStyle.Bold),
                Padding = new System.Windows.Forms.Padding(10, 5, 0, 5),
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            };
            this.dgvTreatments.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = clrWhite,
                ForeColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Font = new System.Drawing.Font("Segoe UI", 10F),
                Padding = new System.Windows.Forms.Padding(10, 0, 0, 0),
                SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249),
                SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 107)
            };

            this.colDate.HeaderText = "TARGET DATE"; 
            this.colGoal.HeaderText = "GOAL / MILESTONE"; 
            this.colAssignedBy.HeaderText = "ASSIGNED BY"; 
            this.colStatus.HeaderText = "STATUS";
            this.dgvTreatments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colDate, this.colGoal, this.colAssignedBy, this.colStatus });
            this.pnlTreatmentList.Controls.Add(this.dgvTreatments);
            this.pnlTreatmentList.Controls.Add(this.lblTreatmentListTitle);

            var pnlContainer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Fill, Padding = new System.Windows.Forms.Padding(0, 24, 0, 0) };
            pnlContainer.Controls.Add(this.pnlTreatmentList);

            this.pnlContent.Controls.Add(pnlContainer);
            this.pnlContent.Controls.Add(tlpTreatmentCards);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.tlpTreatmentCards.ResumeLayout(false);
            this.cardActive.ResumeLayout(false);
            this.pnlTreatmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.PatientTreatmentPlansControl_Load);
        }

        private void SetupStatCard(System.Windows.Forms.Panel card, System.Windows.Forms.Label title, System.Windows.Forms.Label val, System.Windows.Forms.Label ico, string titleText, string iconText, System.Drawing.Color color)
        {
            card.BackColor = System.Drawing.Color.White;
            card.Padding = new System.Windows.Forms.Padding(20);
            card.Margin = new System.Windows.Forms.Padding(8);
            card.Dock = System.Windows.Forms.DockStyle.Fill;
            
            var acc = new System.Windows.Forms.Panel { BackColor = color, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            
            title.Text = titleText; 
            title.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold); 
            title.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139); 
            title.Location = new System.Drawing.Point(20, 28); 
            title.AutoSize = true;
            
            val.Text = "--"; 
            val.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold); 
            val.ForeColor = color; 
            val.Location = new System.Drawing.Point(16, 60); 
            val.AutoSize = true;
            
            ico.Text = iconText; 
            ico.Font = new System.Drawing.Font("Segoe UI", 24F); 
            ico.ForeColor = System.Drawing.Color.FromArgb(30, color); 
            ico.Location = new System.Drawing.Point(card.Width - 70, 25); 
            ico.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ico.AutoSize = true;
            
            card.Controls.Add(acc); 
            card.Controls.Add(title); 
            card.Controls.Add(val); 
            card.Controls.Add(ico);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tlpTreatmentCards;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Label lblCardActiveTitle;
        private System.Windows.Forms.Label lblCardActiveValue;
        private System.Windows.Forms.Label lblCardActiveIcon;
        private System.Windows.Forms.Panel pnlTreatmentList;
        private System.Windows.Forms.Label lblTreatmentListTitle;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
