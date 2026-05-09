namespace elnet_recoverease.Doctor.Controls
{
    partial class DoctorDashboardControl
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
            this.cardPatients = new System.Windows.Forms.Panel();
            this.lblCardPatTitle = new System.Windows.Forms.Label();
            this.lblCardPatValue = new System.Windows.Forms.Label();
            this.lblCardPatIcon = new System.Windows.Forms.Label();
            this.lblCardPatSub = new System.Windows.Forms.Label();
            this.cardAppt = new System.Windows.Forms.Panel();
            this.lblCardApptTitle = new System.Windows.Forms.Label();
            this.lblCardApptValue = new System.Windows.Forms.Label();
            this.lblCardApptIcon = new System.Windows.Forms.Label();
            this.lblCardApptSub = new System.Windows.Forms.Label();
            this.cardPending = new System.Windows.Forms.Panel();
            this.lblCardPendTitle = new System.Windows.Forms.Label();
            this.lblCardPendValue = new System.Windows.Forms.Label();
            this.lblCardPendIcon = new System.Windows.Forms.Label();
            this.lblCardPendSub = new System.Windows.Forms.Label();
            this.cardAlerts = new System.Windows.Forms.Panel();
            this.lblCardAlertTitle = new System.Windows.Forms.Label();
            this.lblCardAlertValue = new System.Windows.Forms.Label();
            this.lblCardAlertIcon = new System.Windows.Forms.Label();
            this.lblCardAlertSub = new System.Windows.Forms.Label();
            this.pnlSchedulePanel = new System.Windows.Forms.Panel();
            this.lblScheduleTitle = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAlertsPanel = new System.Windows.Forms.Panel();
            this.lblAlertsTitle = new System.Windows.Forms.Label();
            this.pnlAlert1 = new System.Windows.Forms.Panel();
            this.lblAlert1Icon = new System.Windows.Forms.Label();
            this.lblAlert1Text = new System.Windows.Forms.Label();
            this.lblAlert1Time = new System.Windows.Forms.Label();
            this.pnlAlert2 = new System.Windows.Forms.Panel();
            this.lblAlert2Icon = new System.Windows.Forms.Label();
            this.lblAlert2Text = new System.Windows.Forms.Label();
            this.lblAlert2Time = new System.Windows.Forms.Label();
            this.pnlAlert3 = new System.Windows.Forms.Panel();
            this.lblAlert3Icon = new System.Windows.Forms.Label();
            this.lblAlert3Text = new System.Windows.Forms.Label();
            this.lblAlert3Time = new System.Windows.Forms.Label();

            this.pnlContent.SuspendLayout();
            this.pnlSchedulePanel.SuspendLayout();
            this.pnlAlertsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.cardPatients.SuspendLayout();
            this.cardAppt.SuspendLayout();
            this.cardPending.SuspendLayout();
            this.cardAlerts.SuspendLayout();
            this.pnlAlert1.SuspendLayout();
            this.pnlAlert2.SuspendLayout();
            this.pnlAlert3.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24, 15, 24, 24);
            this.pnlContent.AutoScroll = true;

            // Stat Cards Layout
            var tlpCards = new System.Windows.Forms.TableLayoutPanel {
                Dock = System.Windows.Forms.DockStyle.Top,
                Height = 110,
                ColumnCount = 4,
                RowCount = 1
            };
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            SetupStatCard(this.cardPatients, "TOTAL PATIENTS", this.lblCardPatTitle, this.lblCardPatValue, this.lblCardPatIcon, "👥", this.lblCardPatSub, "Active under care", clrTeal, 0);
            SetupStatCard(this.cardAppt, "APPOINTMENTS", this.lblCardApptTitle, this.lblCardApptValue, this.lblCardApptIcon, "📅", this.lblCardApptSub, "Remaining today", clrNavy, 1);
            SetupStatCard(this.cardPending, "PENDING REPORTS", this.lblCardPendTitle, this.lblCardPendValue, this.lblCardPendIcon, "📋", this.lblCardPendSub, "Needs review", System.Drawing.Color.FromArgb(39, 174, 96), 2);
            SetupStatCard(this.cardAlerts, "CLINICAL ALERTS", this.lblCardAlertTitle, this.lblCardAlertValue, this.lblCardAlertIcon, "⚠️", this.lblCardAlertSub, "Requires attention", System.Drawing.Color.FromArgb(230, 126, 34), 3);

            tlpCards.Controls.Add(this.cardPatients, 0, 0);
            tlpCards.Controls.Add(this.cardAppt, 1, 0);
            tlpCards.Controls.Add(this.cardPending, 2, 0);
            tlpCards.Controls.Add(this.cardAlerts, 3, 0);

            // Bottom Grid Layout
            var tlpBottom = new System.Windows.Forms.TableLayoutPanel {
                Dock = System.Windows.Forms.DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Margin = new System.Windows.Forms.Padding(0, 24, 0, 0)
            };
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));

            // 1. Schedule Panel
            this.pnlSchedulePanel.BackColor = clrWhite;
            this.pnlSchedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSchedulePanel.Margin = new System.Windows.Forms.Padding(0, 24, 12, 0);
            this.pnlSchedulePanel.Padding = new System.Windows.Forms.Padding(20, 70, 20, 20);

            this.lblScheduleTitle.Text = "📅 Today's Appointments";
            this.lblScheduleTitle.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblScheduleTitle.ForeColor = clrNavy;
            this.lblScheduleTitle.Location = new System.Drawing.Point(20, 25);
            this.lblScheduleTitle.AutoSize = true;

            this.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedule.BackgroundColor = clrWhite;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.RowTemplate.Height = 50;
            this.dgvSchedule.ColumnHeadersHeight = 45;
            this.dgvSchedule.EnableHeadersVisualStyles = false;
            this.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = clrNavy;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.ForeColor = clrWhite;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Bold", 9F);
            this.dgvSchedule.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.dgvSchedule.DefaultCellStyle.SelectionForeColor = clrNavy;

            this.colTime.HeaderText = "TIME"; this.colTime.FillWeight = 25;
            this.colPatient.HeaderText = "PATIENT"; this.colPatient.FillWeight = 40;
            this.colReason.HeaderText = "REASON"; this.colReason.FillWeight = 35;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colTime, this.colPatient, this.colReason });

            this.pnlSchedulePanel.Controls.Add(this.lblScheduleTitle);
            this.pnlSchedulePanel.Controls.Add(this.dgvSchedule);

            // 2. Alerts Panel
            this.pnlAlertsPanel.BackColor = clrWhite;
            this.pnlAlertsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlertsPanel.Margin = new System.Windows.Forms.Padding(12, 24, 0, 0);
            this.pnlAlertsPanel.Padding = new System.Windows.Forms.Padding(20, 70, 20, 20);

            this.lblAlertsTitle.Text = "⚠️ Clinical Alerts";
            this.lblAlertsTitle.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlertsTitle.ForeColor = clrNavy;
            this.lblAlertsTitle.Location = new System.Drawing.Point(20, 25);
            this.lblAlertsTitle.AutoSize = true;

            SetupAlertItem(this.pnlAlert1, this.lblAlert1Icon, this.lblAlert1Text, this.lblAlert1Time, System.Drawing.Color.FromArgb(220, 38, 38));
            SetupAlertItem(this.pnlAlert2, this.lblAlert2Icon, this.lblAlert2Text, this.lblAlert2Time, System.Drawing.Color.FromArgb(220, 38, 38));
            SetupAlertItem(this.pnlAlert3, this.lblAlert3Icon, this.lblAlert3Text, this.lblAlert3Time, System.Drawing.Color.FromArgb(217, 119, 6));

            this.pnlAlertsPanel.Controls.Add(this.lblAlertsTitle);
            this.pnlAlertsPanel.Controls.Add(this.pnlAlert3);
            this.pnlAlertsPanel.Controls.Add(this.pnlAlert2);
            this.pnlAlertsPanel.Controls.Add(this.pnlAlert1);

            tlpBottom.Controls.Add(this.pnlSchedulePanel, 0, 0);
            tlpBottom.Controls.Add(this.pnlAlertsPanel, 1, 0);

            this.pnlContent.Controls.Add(tlpBottom);
            this.pnlContent.Controls.Add(tlpCards);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.pnlSchedulePanel.ResumeLayout(false);
            this.pnlSchedulePanel.PerformLayout();
            this.pnlAlertsPanel.ResumeLayout(false);
            this.pnlAlertsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.cardPatients.ResumeLayout(false);
            this.cardAppt.ResumeLayout(false);
            this.cardPending.ResumeLayout(false);
            this.cardAlerts.ResumeLayout(false);
            this.pnlAlert1.ResumeLayout(false);
            this.pnlAlert2.ResumeLayout(false);
            this.pnlAlert3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void SetupStatCard(System.Windows.Forms.Panel card, string title, System.Windows.Forms.Label lblTitle, System.Windows.Forms.Label lblValue, System.Windows.Forms.Label lblIcon, string ico, System.Windows.Forms.Label lblSub, string sub, System.Drawing.Color color, int index)
        {
            card.BackColor = System.Drawing.Color.White;
            card.Margin = new System.Windows.Forms.Padding(index == 0 ? 0 : 12, 0, index == 3 ? 0 : 12, 0);
            card.Padding = new System.Windows.Forms.Padding(0);

            var pnlTopStrip = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 4, BackColor = color };
            
            lblTitle.Text = title;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.AutoSize = true;

            lblValue.Text = "0";
            lblValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            lblValue.Location = new System.Drawing.Point(15, 38);
            lblValue.AutoSize = true;

            lblIcon.Text = ico;
            lblIcon.Font = new System.Drawing.Font("Segoe UI", 20F);
            lblIcon.ForeColor = System.Drawing.Color.FromArgb(30, color.R, color.G, color.B);
            lblIcon.Location = new System.Drawing.Point(220, 32);
            lblIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblIcon.AutoSize = true;

            lblSub.Text = sub;
            lblSub.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            lblSub.ForeColor = color;
            lblSub.Location = new System.Drawing.Point(20, 82);
            lblSub.AutoSize = true;

            card.Controls.Add(lblIcon);
            card.Controls.Add(lblValue);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblSub);
            card.Controls.Add(pnlTopStrip);
        }

        private void SetupAlertItem(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label ico, System.Windows.Forms.Label txt, System.Windows.Forms.Label time, System.Drawing.Color statusColor)
        {
            pnl.Dock = System.Windows.Forms.DockStyle.Top;
            pnl.Height = 85;
            pnl.Padding = new System.Windows.Forms.Padding(0);
            pnl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            pnl.BackColor = System.Drawing.Color.White;
            pnl.Visible = false;

            var pnlStatus = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Left, Width = 4, BackColor = statusColor };
            
            ico.Font = new System.Drawing.Font("Segoe UI", 12F);
            ico.Location = new System.Drawing.Point(15, 20);
            ico.ForeColor = statusColor;
            ico.AutoSize = true;

            txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            txt.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            txt.Location = new System.Drawing.Point(45, 18);
            txt.Size = new System.Drawing.Size(240, 45);
            txt.AutoEllipsis = true;

            time.Font = new System.Drawing.Font("Segoe UI", 8F);
            time.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            time.Location = new System.Drawing.Point(47, 58);
            time.AutoSize = true;

            pnl.Controls.Add(txt);
            pnl.Controls.Add(time);
            pnl.Controls.Add(ico);
            pnl.Controls.Add(pnlStatus);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel cardPatients;
        private System.Windows.Forms.Label lblCardPatTitle;
        private System.Windows.Forms.Label lblCardPatValue;
        private System.Windows.Forms.Label lblCardPatIcon;
        private System.Windows.Forms.Label lblCardPatSub;
        private System.Windows.Forms.Panel cardAppt;
        private System.Windows.Forms.Label lblCardApptTitle;
        private System.Windows.Forms.Label lblCardApptValue;
        private System.Windows.Forms.Label lblCardApptIcon;
        private System.Windows.Forms.Label lblCardApptSub;
        private System.Windows.Forms.Panel cardPending;
        private System.Windows.Forms.Label lblCardPendTitle;
        private System.Windows.Forms.Label lblCardPendValue;
        private System.Windows.Forms.Label lblCardPendIcon;
        private System.Windows.Forms.Label lblCardPendSub;
        private System.Windows.Forms.Panel cardAlerts;
        private System.Windows.Forms.Label lblCardAlertTitle;
        private System.Windows.Forms.Label lblCardAlertValue;
        private System.Windows.Forms.Label lblCardAlertIcon;
        private System.Windows.Forms.Label lblCardAlertSub;
        private System.Windows.Forms.Panel pnlSchedulePanel;
        private System.Windows.Forms.Label lblScheduleTitle;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.Panel pnlAlertsPanel;
        private System.Windows.Forms.Label lblAlertsTitle;
        private System.Windows.Forms.Panel pnlAlert1;
        private System.Windows.Forms.Label lblAlert1Icon;
        private System.Windows.Forms.Label lblAlert1Text;
        private System.Windows.Forms.Label lblAlert1Time;
        private System.Windows.Forms.Panel pnlAlert2;
        private System.Windows.Forms.Label lblAlert2Icon;
        private System.Windows.Forms.Label lblAlert2Text;
        private System.Windows.Forms.Label lblAlert2Time;
        private System.Windows.Forms.Panel pnlAlert3;
        private System.Windows.Forms.Label lblAlert3Icon;
        private System.Windows.Forms.Label lblAlert3Text;
        private System.Windows.Forms.Label lblAlert3Time;
    }
}
