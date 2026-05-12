namespace elnet_recoverease.PatientStation.Controls
{
    partial class PatientAppointmentsControl
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
            this.tlpApptCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardNextAppt = new System.Windows.Forms.Panel();
            this.lblCardNextTitle = new System.Windows.Forms.Label();
            this.lblCardNextValue = new System.Windows.Forms.Label();
            this.lblCardNextIcon = new System.Windows.Forms.Label();
            this.cardUpcoming = new System.Windows.Forms.Panel();
            this.lblCardUpcomingTitle = new System.Windows.Forms.Label();
            this.lblCardUpcomingValue = new System.Windows.Forms.Label();
            this.lblCardUpcomingIcon = new System.Windows.Forms.Label();
            this.cardCompleted = new System.Windows.Forms.Panel();
            this.lblCardCompletedTitle = new System.Windows.Forms.Label();
            this.lblCardCompletedValue = new System.Windows.Forms.Label();
            this.lblCardCompletedIcon = new System.Windows.Forms.Label();
            this.pnlApptList = new System.Windows.Forms.Panel();
            this.lblApptListTitle = new System.Windows.Forms.Label();
            this.dgvAppts = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlContent.SuspendLayout();
            this.tlpApptCards.SuspendLayout();
            this.cardNextAppt.SuspendLayout();
            this.cardUpcoming.SuspendLayout();
            this.cardCompleted.SuspendLayout();
            this.pnlApptList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppts)).BeginInit();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrGreen = System.Drawing.Color.FromArgb(39, 174, 96);

            // UserControl
            this.BackColor = clrBg;
            this.Size = new System.Drawing.Size(1200, 800);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.AutoScroll = true;

            // Stat Cards
            this.tlpApptCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpApptCards.Height = 160;
            this.tlpApptCards.ColumnCount = 3;
            this.tlpApptCards.RowCount = 1;
            this.tlpApptCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpApptCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpApptCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));

            SetupStatCard(this.cardNextAppt, this.lblCardNextTitle, this.lblCardNextValue, this.lblCardNextIcon, "NEXT APPOINTMENT", "📅", clrNavy);
            SetupStatCard(this.cardUpcoming, this.lblCardUpcomingTitle, this.lblCardUpcomingValue, this.lblCardUpcomingIcon, "UPCOMING VISITS", "🕒", clrTeal);
            SetupStatCard(this.cardCompleted, this.lblCardCompletedTitle, this.lblCardCompletedValue, this.lblCardCompletedIcon, "COMPLETED VISITS", "✅", clrGreen);

            tlpApptCards.Controls.Add(this.cardNextAppt, 0, 0);
            tlpApptCards.Controls.Add(this.cardUpcoming, 1, 0);
            tlpApptCards.Controls.Add(this.cardCompleted, 2, 0);

            // Grid Section
            this.pnlApptList.BackColor = clrWhite;
            this.pnlApptList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApptList.Padding = new System.Windows.Forms.Padding(24);
            this.pnlApptList.Margin = new System.Windows.Forms.Padding(0, 24, 0, 0);
            
            this.lblApptListTitle.Text = "Appointment History";
            this.lblApptListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblApptListTitle.ForeColor = clrNavy;
            this.lblApptListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApptListTitle.Height = 45;

            // dgvAppts Styling
            this.dgvAppts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppts.BackgroundColor = clrWhite;
            this.dgvAppts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppts.RowHeadersVisible = false;
            this.dgvAppts.AllowUserToAddRows = false;
            this.dgvAppts.AllowUserToDeleteRows = false;
            this.dgvAppts.AllowUserToResizeRows = false;
            this.dgvAppts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppts.ReadOnly = true;
            this.dgvAppts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppts.RowTemplate.Height = 50;
            this.dgvAppts.EnableHeadersVisualStyles = false;
            this.dgvAppts.GridColor = System.Drawing.Color.FromArgb(240, 244, 248);

            this.dgvAppts.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = System.Drawing.Color.FromArgb(248, 250, 252),
                ForeColor = System.Drawing.Color.FromArgb(100, 116, 139),
                Font = new System.Drawing.Font("Segoe UI Bold", 9F, System.Drawing.FontStyle.Bold),
                Padding = new System.Windows.Forms.Padding(10, 5, 0, 5),
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            };
            this.dgvAppts.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = clrWhite,
                ForeColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Font = new System.Drawing.Font("Segoe UI", 10F),
                Padding = new System.Windows.Forms.Padding(10, 0, 0, 0),
                SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249),
                SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 107)
            };

            this.colDate.HeaderText = "DATE"; 
            this.colTime.HeaderText = "TIME"; 
            this.colDoctor.HeaderText = "DOCTOR"; 
            this.colReason.HeaderText = "REASON / TYPE"; 
            this.colStatus.HeaderText = "STATUS"; 
            this.colAction.HeaderText = "DETAILS";
            this.colAction.Text = "View"; 
            this.colAction.UseColumnTextForButtonValue = true; 
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colAction.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(238, 243, 247);
            this.colAction.DefaultCellStyle.ForeColor = clrNavy;
            this.colAction.DefaultCellStyle.SelectionBackColor = clrNavy;
            this.colAction.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            this.dgvAppts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colDate, this.colTime, this.colDoctor, this.colReason, this.colStatus, this.colAction });
            this.pnlApptList.Controls.Add(this.dgvAppts);
            this.pnlApptList.Controls.Add(this.lblApptListTitle);

            var pnlContainer = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Fill, Padding = new System.Windows.Forms.Padding(0, 24, 0, 0) };
            pnlContainer.Controls.Add(this.pnlApptList);

            this.pnlContent.Controls.Add(pnlContainer);
            this.pnlContent.Controls.Add(tlpApptCards);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.tlpApptCards.ResumeLayout(false);
            this.cardNextAppt.ResumeLayout(false);
            this.cardUpcoming.ResumeLayout(false);
            this.cardCompleted.ResumeLayout(false);
            this.pnlApptList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppts)).EndInit();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.PatientAppointmentsControl_Load);
            this.dgvAppts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppts_CellContentClick);
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
        private System.Windows.Forms.TableLayoutPanel tlpApptCards;
        private System.Windows.Forms.Panel cardNextAppt;
        private System.Windows.Forms.Label lblCardNextTitle;
        private System.Windows.Forms.Label lblCardNextValue;
        private System.Windows.Forms.Label lblCardNextIcon;
        private System.Windows.Forms.Panel cardUpcoming;
        private System.Windows.Forms.Label lblCardUpcomingTitle;
        private System.Windows.Forms.Label lblCardUpcomingValue;
        private System.Windows.Forms.Label lblCardUpcomingIcon;
        private System.Windows.Forms.Panel cardCompleted;
        private System.Windows.Forms.Label lblCardCompletedTitle;
        private System.Windows.Forms.Label lblCardCompletedValue;
        private System.Windows.Forms.Label lblCardCompletedIcon;
        private System.Windows.Forms.Panel pnlApptList;
        private System.Windows.Forms.Label lblApptListTitle;
        private System.Windows.Forms.DataGridView dgvAppts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}
