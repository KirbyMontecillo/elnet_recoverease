namespace elnet_recoverease.PatientStation.Controls
{
    partial class PatientMedicationsControl
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
            this.tlpMedsCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardActiveMeds = new System.Windows.Forms.Panel();
            this.lblCardActiveMedsTitle = new System.Windows.Forms.Label();
            this.lblCardActiveMedsValue = new System.Windows.Forms.Label();
            this.lblCardActiveMedsIcon = new System.Windows.Forms.Label();
            this.cardAdherence = new System.Windows.Forms.Panel();
            this.lblCardAdhrTitle = new System.Windows.Forms.Label();
            this.lblCardAdhrValue = new System.Windows.Forms.Label();
            this.lblCardAdhrIcon = new System.Windows.Forms.Label();
            this.pnlMedsList = new System.Windows.Forms.Panel();
            this.lblMedsListTitle = new System.Windows.Forms.Label();
            this.dgvMeds = new System.Windows.Forms.DataGridView();
            this.colMedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrescriber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDailySchedule = new System.Windows.Forms.Panel();
            this.lblSchedTitle = new System.Windows.Forms.Label();
            this.pnlSchedTabs = new System.Windows.Forms.Panel();
            this.btnTabMorning = new System.Windows.Forms.Button();
            this.btnTabNoon = new System.Windows.Forms.Button();
            this.btnTabEvening = new System.Windows.Forms.Button();
            this.pnlTimelineCont = new System.Windows.Forms.Panel();
            this.lblTimelineFooter = new System.Windows.Forms.Label();
            this.pnlTimelineItems = new System.Windows.Forms.Panel();

            this.pnlContent.SuspendLayout();
            this.tlpMedsCards.SuspendLayout();
            this.cardActiveMeds.SuspendLayout();
            this.cardAdherence.SuspendLayout();
            this.pnlMedsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeds)).BeginInit();
            this.pnlDailySchedule.SuspendLayout();
            this.pnlSchedTabs.SuspendLayout();
            this.pnlTimelineCont.SuspendLayout();
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
            this.tlpMedsCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMedsCards.Height = 160;
            this.tlpMedsCards.ColumnCount = 2;
            this.tlpMedsCards.RowCount = 1;
            this.tlpMedsCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMedsCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            SetupStatCard(this.cardActiveMeds, this.lblCardActiveMedsTitle, this.lblCardActiveMedsValue, this.lblCardActiveMedsIcon, "ACTIVE PRESCRIPTIONS", "💊", clrTeal);
            SetupStatCard(this.cardAdherence, this.lblCardAdhrTitle, this.lblCardAdhrValue, this.lblCardAdhrIcon, "ADHERENCE SCORE", "📈", clrGreen);

            tlpMedsCards.Controls.Add(this.cardActiveMeds, 0, 0);
            tlpMedsCards.Controls.Add(this.cardAdherence, 1, 0);

            // Main Split Section
            var tlpMainSplit = new System.Windows.Forms.TableLayoutPanel();
            tlpMainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMainSplit.ColumnCount = 2;
            tlpMainSplit.RowCount = 1;
            tlpMainSplit.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            tlpMainSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            tlpMainSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));

            // Grid Panel
            this.pnlMedsList.BackColor = clrWhite;
            this.pnlMedsList.Padding = new System.Windows.Forms.Padding(24);
            this.pnlMedsList.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlMedsList.Dock = System.Windows.Forms.DockStyle.Fill;
            
            this.lblMedsListTitle.Text = "Current Prescriptions";
            this.lblMedsListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblMedsListTitle.ForeColor = clrNavy;
            this.lblMedsListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMedsListTitle.Height = 45;

            // dgvMeds Styling
            this.dgvMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMeds.BackgroundColor = clrWhite;
            this.dgvMeds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMeds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMeds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMeds.RowHeadersVisible = false;
            this.dgvMeds.AllowUserToAddRows = false;
            this.dgvMeds.AllowUserToDeleteRows = false;
            this.dgvMeds.AllowUserToResizeRows = false;
            this.dgvMeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeds.ReadOnly = true;
            this.dgvMeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeds.RowTemplate.Height = 50;
            this.dgvMeds.EnableHeadersVisualStyles = false;
            this.dgvMeds.GridColor = System.Drawing.Color.FromArgb(240, 244, 248);

            this.dgvMeds.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = System.Drawing.Color.FromArgb(248, 250, 252),
                ForeColor = System.Drawing.Color.FromArgb(100, 116, 139),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Padding = new System.Windows.Forms.Padding(10, 5, 0, 5),
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            };
            this.dgvMeds.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = clrWhite,
                ForeColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Font = new System.Drawing.Font("Segoe UI", 10F),
                Padding = new System.Windows.Forms.Padding(10, 0, 0, 0),
                SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249),
                SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 107)
            };

            this.colMedName.HeaderText = "MEDICATION NAME"; 
            this.colDosage.HeaderText = "DOSAGE"; 
            this.colFreq.HeaderText = "FREQUENCY"; 
            this.colPrescriber.HeaderText = "PRESCRIBER"; 
            this.colStatus.HeaderText = "STATUS";
            this.dgvMeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colMedName, this.colDosage, this.colFreq, this.colPrescriber, this.colStatus });
            this.pnlMedsList.Controls.Add(this.dgvMeds);
            this.pnlMedsList.Controls.Add(this.lblMedsListTitle);

            // Daily Schedule Panel
            this.pnlDailySchedule.BackColor = clrWhite;
            this.pnlDailySchedule.Padding = new System.Windows.Forms.Padding(24);
            this.pnlDailySchedule.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlDailySchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            
            this.lblSchedTitle.Text = "Daily Timeline";
            this.lblSchedTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblSchedTitle.ForeColor = clrNavy;
            this.lblSchedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSchedTitle.Height = 45;
            
            this.pnlSchedTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSchedTabs.Height = 50;
            this.pnlSchedTabs.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            
            SetupTabButton(this.btnTabMorning, "Morning", true);
            SetupTabButton(this.btnTabNoon, "Noon", false);
            SetupTabButton(this.btnTabEvening, "Evening", false);
            
            this.pnlSchedTabs.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnTabEvening, this.btnTabNoon, this.btnTabMorning });

            this.pnlTimelineCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimelineItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimelineItems.AutoScroll = true;
            this.lblTimelineFooter.Text = "💡 Tap to record dose taken."; 
            this.lblTimelineFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F); 
            this.lblTimelineFooter.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTimelineFooter.Dock = System.Windows.Forms.DockStyle.Bottom; 
            this.lblTimelineFooter.Height = 30;
            this.lblTimelineFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.pnlTimelineCont.Controls.Add(this.pnlTimelineItems);
            this.pnlDailySchedule.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlTimelineCont, this.lblTimelineFooter, this.pnlSchedTabs, this.lblSchedTitle });

            tlpMainSplit.Controls.Add(this.pnlMedsList, 0, 0);
            tlpMainSplit.Controls.Add(this.pnlDailySchedule, 1, 0);

            this.pnlContent.Controls.Add(tlpMainSplit);
            this.pnlContent.Controls.Add(tlpMedsCards);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.tlpMedsCards.ResumeLayout(false);
            this.cardActiveMeds.ResumeLayout(false);
            this.cardAdherence.ResumeLayout(false);
            this.pnlMedsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeds)).EndInit();
            this.pnlDailySchedule.ResumeLayout(false);
            this.pnlSchedTabs.ResumeLayout(false);
            this.btnTabMorning.Click += new System.EventHandler(this.btnTabMorning_Click);
            this.btnTabNoon.Click += new System.EventHandler(this.btnTabNoon_Click);
            this.btnTabEvening.Click += new System.EventHandler(this.btnTabEvening_Click);
            this.pnlTimelineCont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.PatientMedicationsControl_Load);
        }

        private void SetupTabButton(System.Windows.Forms.Button btn, string text, bool isActive)
        {
            btn.Text = text.ToUpper();
            btn.Dock = System.Windows.Forms.DockStyle.Left;
            btn.Width = 100;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.BackColor = isActive ? System.Drawing.Color.FromArgb(27, 58, 107) : System.Drawing.Color.FromArgb(238, 243, 247);
            btn.ForeColor = isActive ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(30, 41, 59);
        }

        private void SetupStatCard(System.Windows.Forms.Panel card, System.Windows.Forms.Label title, System.Windows.Forms.Label val, System.Windows.Forms.Label ico, string titleText, string iconText, System.Drawing.Color color)
        {
            card.BackColor = System.Drawing.Color.White;
            card.Padding = new System.Windows.Forms.Padding(20);
            card.Margin = new System.Windows.Forms.Padding(8);
            card.Dock = System.Windows.Forms.DockStyle.Fill;
            
            var acc = new System.Windows.Forms.Panel { BackColor = color, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            
            title.Text = titleText; 
            title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold); 
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
        private System.Windows.Forms.TableLayoutPanel tlpMedsCards;
        private System.Windows.Forms.Panel cardActiveMeds;
        private System.Windows.Forms.Label lblCardActiveMedsTitle;
        private System.Windows.Forms.Label lblCardActiveMedsValue;
        private System.Windows.Forms.Label lblCardActiveMedsIcon;
        private System.Windows.Forms.Panel cardAdherence;
        private System.Windows.Forms.Label lblCardAdhrTitle;
        private System.Windows.Forms.Label lblCardAdhrValue;
        private System.Windows.Forms.Label lblCardAdhrIcon;
        private System.Windows.Forms.Panel pnlMedsList;
        private System.Windows.Forms.Label lblMedsListTitle;
        private System.Windows.Forms.DataGridView dgvMeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrescriber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlDailySchedule;
        private System.Windows.Forms.Label lblSchedTitle;
        private System.Windows.Forms.Panel pnlSchedTabs;
        private System.Windows.Forms.Button btnTabMorning;
        private System.Windows.Forms.Button btnTabNoon;
        private System.Windows.Forms.Button btnTabEvening;
        private System.Windows.Forms.Panel pnlTimelineCont;
        private System.Windows.Forms.Label lblTimelineFooter;
        private System.Windows.Forms.Panel pnlTimelineItems;
    }
}
