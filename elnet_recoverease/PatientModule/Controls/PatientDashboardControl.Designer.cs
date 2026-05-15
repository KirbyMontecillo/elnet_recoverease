namespace elnet_recoverease.PatientStation.Controls
{
    partial class PatientDashboardControl
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
            this.components = new System.ComponentModel.Container();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.cardMeds = new System.Windows.Forms.Panel();
            this.lblCardMedsTitle = new System.Windows.Forms.Label();
            this.lblCardMedsValue = new System.Windows.Forms.Label();
            this.lblCardMedsIcon = new System.Windows.Forms.Label();
            this.lblCardMedsSub = new System.Windows.Forms.Label();
            this.cardAppt = new System.Windows.Forms.Panel();
            this.lblCardApptTitle = new System.Windows.Forms.Label();
            this.lblCardApptValue = new System.Windows.Forms.Label();
            this.lblCardApptIcon = new System.Windows.Forms.Label();
            this.lblCardApptSub = new System.Windows.Forms.Label();
            this.cardAdherence = new System.Windows.Forms.Panel();
            this.lblCardAdhrTitle = new System.Windows.Forms.Label();
            this.lblCardAdhrValue = new System.Windows.Forms.Label();
            this.lblCardAdhrIcon = new System.Windows.Forms.Label();
            this.lblCardAdhrSub = new System.Windows.Forms.Label();
            this.cardMissed = new System.Windows.Forms.Panel();
            this.lblCardMissTitle = new System.Windows.Forms.Label();
            this.lblCardMissValue = new System.Windows.Forms.Label();
            this.lblCardMissIcon = new System.Windows.Forms.Label();
            this.lblCardMissSub = new System.Windows.Forms.Label();
            this.pnlSchedulePanel = new System.Windows.Forms.Panel();
            this.lblScheduleTitle = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRemindersPanel = new System.Windows.Forms.Panel();
            this.lblRemindersTitle = new System.Windows.Forms.Label();
            this.pnlRem1 = new System.Windows.Forms.Panel();
            this.lblRem1Icon = new System.Windows.Forms.Label();
            this.lblRem1Text = new System.Windows.Forms.Label();
            this.lblRem1Time = new System.Windows.Forms.Label();
            this.pnlRem2 = new System.Windows.Forms.Panel();
            this.lblRem2Icon = new System.Windows.Forms.Label();
            this.lblRem2Text = new System.Windows.Forms.Label();
            this.lblRem2Time = new System.Windows.Forms.Label();
            this.pnlRem3 = new System.Windows.Forms.Panel();
            this.lblRem3Icon = new System.Windows.Forms.Label();
            this.lblRem3Text = new System.Windows.Forms.Label();
            this.lblRem3Time = new System.Windows.Forms.Label();
            this.pnlRem4 = new System.Windows.Forms.Panel();
            this.lblRem4Icon = new System.Windows.Forms.Label();
            this.lblRem4Text = new System.Windows.Forms.Label();
            this.lblRem4Time = new System.Windows.Forms.Label();

            this.pnlContent.SuspendLayout();
            this.pnlSchedulePanel.SuspendLayout();
            this.pnlRemindersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.cardMeds.SuspendLayout();
            this.cardAppt.SuspendLayout();
            this.cardAdherence.SuspendLayout();
            this.cardMissed.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrGreen = System.Drawing.Color.FromArgb(39, 174, 96);
            System.Drawing.Color clrOrange = System.Drawing.Color.FromArgb(230, 126, 34);

            // UserControl
            this.BackColor = clrBg;
            this.Size = new System.Drawing.Size(1200, 800);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.AutoScroll = true;

            // Stat Cards Layout
            var tlpCards = new System.Windows.Forms.TableLayoutPanel();
            tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            tlpCards.Height = 160;
            tlpCards.ColumnCount = 4;
            tlpCards.RowCount = 1;
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            SetupStatCard(this.cardMeds, this.lblCardMedsTitle, this.lblCardMedsValue, this.lblCardMedsIcon, this.lblCardMedsSub, "MEDICATIONS TODAY", "💊", clrTeal);
            SetupStatCard(this.cardAppt, this.lblCardApptTitle, this.lblCardApptValue, this.lblCardApptIcon, this.lblCardApptSub, "NEXT APPOINTMENT", "📅", clrNavy);
            SetupStatCard(this.cardAdherence, this.lblCardAdhrTitle, this.lblCardAdhrValue, this.lblCardAdhrIcon, this.lblCardAdhrSub, "ADHERENCE RATE", "📈", clrGreen);
            SetupStatCard(this.cardMissed, this.lblCardMissTitle, this.lblCardMissValue, this.lblCardMissIcon, this.lblCardMissSub, "MISSED DOSES", "⚠️", clrOrange);

            tlpCards.Controls.Add(this.cardMeds, 0, 0);
            tlpCards.Controls.Add(this.cardAppt, 1, 0);
            tlpCards.Controls.Add(this.cardAdherence, 2, 0);
            tlpCards.Controls.Add(this.cardMissed, 3, 0);

            // Bottom Section
            var tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpBottom.ColumnCount = 2;
            tlpBottom.RowCount = 1;
            tlpBottom.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));

            // Schedule Panel
            this.pnlSchedulePanel.BackColor = clrWhite;
            this.pnlSchedulePanel.Padding = new System.Windows.Forms.Padding(24);
            this.pnlSchedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSchedulePanel.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            
            this.lblScheduleTitle.Text = "Today's Medication Schedule";
            this.lblScheduleTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblScheduleTitle.ForeColor = clrNavy;
            this.lblScheduleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScheduleTitle.Height = 45;

            // dgvSchedule Styling
            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.BackgroundColor = clrWhite;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AllowUserToResizeRows = false;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.RowTemplate.Height = 50;
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(240, 244, 248);

            this.dgvSchedule.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = System.Drawing.Color.FromArgb(248, 250, 252),
                ForeColor = System.Drawing.Color.FromArgb(100, 116, 139),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Padding = new System.Windows.Forms.Padding(10, 5, 0, 5),
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            };
            this.dgvSchedule.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = clrWhite,
                ForeColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Font = new System.Drawing.Font("Segoe UI", 10F),
                Padding = new System.Windows.Forms.Padding(10, 0, 0, 0),
                SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249),
                SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 107)
            };

            this.colTime.HeaderText = "TIME"; 
            this.colMedication.HeaderText = "MEDICATION"; 
            this.colDosage.HeaderText = "DOSAGE"; 
            this.colStatus.HeaderText = "STATUS";
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colTime, this.colMedication, this.colDosage, this.colStatus });
            
            this.pnlSchedulePanel.Controls.Add(this.dgvSchedule);
            this.pnlSchedulePanel.Controls.Add(this.lblScheduleTitle);

            // Reminders Panel
            this.pnlRemindersPanel.BackColor = clrWhite;
            this.pnlRemindersPanel.Padding = new System.Windows.Forms.Padding(24);
            this.pnlRemindersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRemindersPanel.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);

            this.lblRemindersTitle.Text = "Recent Reminders";
            this.lblRemindersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblRemindersTitle.ForeColor = clrNavy;
            this.lblRemindersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRemindersTitle.Height = 45;

            var flpReminders = new System.Windows.Forms.FlowLayoutPanel { 
                Dock = System.Windows.Forms.DockStyle.Fill, 
                FlowDirection = System.Windows.Forms.FlowDirection.TopDown, 
                WrapContents = false,
                AutoScroll = true
            };
            
            SetupReminderItem(this.pnlRem1, this.lblRem1Icon, this.lblRem1Text, this.lblRem1Time);
            SetupReminderItem(this.pnlRem2, this.lblRem2Icon, this.lblRem2Text, this.lblRem2Time);
            SetupReminderItem(this.pnlRem3, this.lblRem3Icon, this.lblRem3Text, this.lblRem3Time);
            SetupReminderItem(this.pnlRem4, this.lblRem4Icon, this.lblRem4Text, this.lblRem4Time);

            flpReminders.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlRem1, this.pnlRem2, this.pnlRem3, this.pnlRem4 });
            this.pnlRemindersPanel.Controls.Add(flpReminders);
            this.pnlRemindersPanel.Controls.Add(this.lblRemindersTitle);

            tlpBottom.Controls.Add(this.pnlSchedulePanel, 0, 0);
            tlpBottom.Controls.Add(this.pnlRemindersPanel, 1, 0);

            this.pnlContent.Controls.Add(tlpBottom);
            this.pnlContent.Controls.Add(tlpCards);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.pnlSchedulePanel.ResumeLayout(false);
            this.pnlRemindersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.cardMeds.ResumeLayout(false);
            this.cardAppt.ResumeLayout(false);
            this.cardAdherence.ResumeLayout(false);
            this.cardMissed.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.PatientDashboardControl_Load);
        }

        private void SetupStatCard(System.Windows.Forms.Panel card, System.Windows.Forms.Label title, System.Windows.Forms.Label val, System.Windows.Forms.Label ico, System.Windows.Forms.Label sub, string titleText, string iconText, System.Drawing.Color color)
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
            
            sub.Text = "Daily Summary"; 
            sub.Font = new System.Drawing.Font("Segoe UI", 8.5F); 
            sub.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184); 
            sub.Location = new System.Drawing.Point(20, 120); 
            sub.AutoSize = true;
            sub.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            
            card.Controls.Add(acc); 
            card.Controls.Add(title); 
            card.Controls.Add(val); 
            card.Controls.Add(ico); 
            card.Controls.Add(sub);
        }

        private void SetupReminderItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, System.Windows.Forms.Label tm)
        {
            pnl.Size = new System.Drawing.Size(320, 70); 
            pnl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            pnl.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            pnl.Padding = new System.Windows.Forms.Padding(12);
            
            ico.Location = new System.Drawing.Point(12, 18); 
            ico.AutoSize = true; 
            ico.Font = new System.Drawing.Font("Segoe UI", 14F);
            
            txt.Location = new System.Drawing.Point(65, 14); 
            txt.Size = new System.Drawing.Size(240, 22); 
            txt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            txt.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            
            tm.Location = new System.Drawing.Point(65, 38); 
            tm.Font = new System.Drawing.Font("Segoe UI", 8.5F); 
            tm.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            
            pnl.Controls.Add(ico); 
            pnl.Controls.Add(txt); 
            pnl.Controls.Add(tm);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel cardMeds;
        private System.Windows.Forms.Label lblCardMedsTitle;
        private System.Windows.Forms.Label lblCardMedsValue;
        private System.Windows.Forms.Label lblCardMedsIcon;
        private System.Windows.Forms.Label lblCardMedsSub;
        private System.Windows.Forms.Panel cardAppt;
        private System.Windows.Forms.Label lblCardApptTitle;
        private System.Windows.Forms.Label lblCardApptValue;
        private System.Windows.Forms.Label lblCardApptIcon;
        private System.Windows.Forms.Label lblCardApptSub;
        private System.Windows.Forms.Panel cardAdherence;
        private System.Windows.Forms.Label lblCardAdhrTitle;
        private System.Windows.Forms.Label lblCardAdhrValue;
        private System.Windows.Forms.Label lblCardAdhrIcon;
        private System.Windows.Forms.Label lblCardAdhrSub;
        private System.Windows.Forms.Panel cardMissed;
        private System.Windows.Forms.Label lblCardMissTitle;
        private System.Windows.Forms.Label lblCardMissValue;
        private System.Windows.Forms.Label lblCardMissIcon;
        private System.Windows.Forms.Label lblCardMissSub;
        private System.Windows.Forms.Panel pnlSchedulePanel;
        private System.Windows.Forms.Label lblScheduleTitle;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedication;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlRemindersPanel;
        private System.Windows.Forms.Label lblRemindersTitle;
        private System.Windows.Forms.Panel pnlRem1;
        private System.Windows.Forms.Label lblRem1Icon;
        private System.Windows.Forms.Label lblRem1Text;
        private System.Windows.Forms.Label lblRem1Time;
        private System.Windows.Forms.Panel pnlRem2;
        private System.Windows.Forms.Label lblRem2Icon;
        private System.Windows.Forms.Label lblRem2Text;
        private System.Windows.Forms.Label lblRem2Time;
        private System.Windows.Forms.Panel pnlRem3;
        private System.Windows.Forms.Label lblRem3Icon;
        private System.Windows.Forms.Label lblRem3Text;
        private System.Windows.Forms.Label lblRem3Time;
        private System.Windows.Forms.Panel pnlRem4;
        private System.Windows.Forms.Label lblRem4Icon;
        private System.Windows.Forms.Label lblRem4Text;
        private System.Windows.Forms.Label lblRem4Time;
    }
}
