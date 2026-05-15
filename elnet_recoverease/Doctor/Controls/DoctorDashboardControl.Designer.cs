namespace elnet_recoverease.Doctor.Controls
{
    partial class DoctorDashboardControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlContent = new Panel();
            tlpBottom = new TableLayoutPanel();
            pnlSchedulePanel = new Panel();
            lblScheduleTitle = new Label();
            dgvSchedule = new DataGridView();
            colTime = new DataGridViewTextBoxColumn();
            colPatient = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            pnlAlertsPanel = new Panel();
            lblAlertsTitle = new Label();
            pnlAlert3 = new Panel();
            pnlAlert2 = new Panel();
            pnlAlert1 = new Panel();
            tlpCards = new TableLayoutPanel();
            cardPatients = new Panel();
            cardAppt = new Panel();
            cardPending = new Panel();
            cardAlerts = new Panel();
            lblCardPatTitle = new Label();
            lblCardPatValue = new Label();
            lblCardPatIcon = new Label();
            lblCardPatSub = new Label();
            lblCardApptTitle = new Label();
            lblCardApptValue = new Label();
            lblCardApptIcon = new Label();
            lblCardApptSub = new Label();
            lblCardPendTitle = new Label();
            lblCardPendValue = new Label();
            lblCardPendIcon = new Label();
            lblCardPendSub = new Label();
            lblCardAlertTitle = new Label();
            lblCardAlertValue = new Label();
            lblCardAlertIcon = new Label();
            lblCardAlertSub = new Label();
            lblAlert1Icon = new Label();
            lblAlert1Text = new Label();
            lblAlert1Time = new Label();
            lblAlert2Icon = new Label();
            lblAlert2Text = new Label();
            lblAlert2Time = new Label();
            lblAlert3Icon = new Label();
            lblAlert3Text = new Label();
            lblAlert3Time = new Label();
            pnlContent.SuspendLayout();
            tlpBottom.SuspendLayout();
            pnlSchedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            pnlAlertsPanel.SuspendLayout();
            tlpCards.SuspendLayout();
            SuspendLayout();

            // pnlContent
            pnlContent.AutoScroll = true;
            pnlContent.BackColor = Color.FromArgb(242, 247, 250);
            pnlContent.Controls.Add(tlpBottom);
            pnlContent.Controls.Add(tlpCards);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(24, 15, 24, 24);
            pnlContent.TabIndex = 0;

            // tlpCards
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cardPatients, 0, 0);
            tlpCards.Controls.Add(cardAppt, 1, 0);
            tlpCards.Controls.Add(cardPending, 2, 0);
            tlpCards.Controls.Add(cardAlerts, 3, 0);
            tlpCards.Dock = DockStyle.Top;
            tlpCards.Height = 160;
            tlpCards.TabIndex = 1;

            // tlpBottom
            tlpBottom.ColumnCount = 2;
            tlpBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpBottom.Controls.Add(pnlSchedulePanel, 0, 0);
            tlpBottom.Controls.Add(pnlAlertsPanel, 1, 0);
            tlpBottom.Dock = DockStyle.Fill;
            tlpBottom.Location = new Point(24, 145);
            tlpBottom.RowCount = 1;
            tlpBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottom.TabIndex = 0;

            // pnlSchedulePanel
            pnlSchedulePanel.BackColor = Color.White;
            pnlSchedulePanel.Controls.Add(lblScheduleTitle);
            pnlSchedulePanel.Controls.Add(dgvSchedule);
            pnlSchedulePanel.Dock = DockStyle.Fill;
            pnlSchedulePanel.Padding = new Padding(20, 70, 20, 20);

            lblScheduleTitle.AutoSize = true;
            lblScheduleTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblScheduleTitle.ForeColor = Color.FromArgb(27, 58, 107);
            lblScheduleTitle.Location = new Point(20, 25);
            lblScheduleTitle.Text = "📅 Today's Appointments";

            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.BackgroundColor = Color.White;
            dgvSchedule.BorderStyle = BorderStyle.None;
            dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSchedule.ColumnHeadersHeight = 45;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { colTime, colPatient, colReason });
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.EnableHeadersVisualStyles = false;
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            colTime.HeaderText = "TIME";
            colPatient.HeaderText = "PATIENT";
            colReason.HeaderText = "REASON";

            // pnlAlertsPanel
            pnlAlertsPanel.BackColor = Color.White;
            pnlAlertsPanel.Controls.Add(lblAlertsTitle);
            pnlAlertsPanel.Controls.Add(pnlAlert3);
            pnlAlertsPanel.Controls.Add(pnlAlert2);
            pnlAlertsPanel.Controls.Add(pnlAlert1);
            pnlAlertsPanel.Dock = DockStyle.Fill;
            pnlAlertsPanel.Padding = new Padding(20, 70, 20, 20);

            lblAlertsTitle.AutoSize = true;
            lblAlertsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAlertsTitle.ForeColor = Color.FromArgb(27, 58, 107);
            lblAlertsTitle.Location = new Point(20, 25);
            lblAlertsTitle.Text = "⚠️ Clinical Alerts";

            // Card Placeholders
            cardPatients.Name = "cardPatients"; cardAppt.Name = "cardAppt"; cardPending.Name = "cardPending"; cardAlerts.Name = "cardAlerts";
            lblCardPatTitle.Name = "lblCardPatTitle"; lblCardPatValue.Name = "lblCardPatValue"; lblCardPatIcon.Name = "lblCardPatIcon"; lblCardPatSub.Name = "lblCardPatSub";
            lblCardApptTitle.Name = "lblCardApptTitle"; lblCardApptValue.Name = "lblCardApptValue"; lblCardApptIcon.Name = "lblCardApptIcon"; lblCardApptSub.Name = "lblCardApptSub";
            lblCardPendTitle.Name = "lblCardPendTitle"; lblCardPendValue.Name = "lblCardPendValue"; lblCardPendIcon.Name = "lblCardPendIcon"; lblCardPendSub.Name = "lblCardPendSub";
            lblCardAlertTitle.Name = "lblCardAlertTitle"; lblCardAlertValue.Name = "lblCardAlertValue"; lblCardAlertIcon.Name = "lblCardAlertIcon"; lblCardAlertSub.Name = "lblCardAlertSub";
            
            // Alert Placeholders
            pnlAlert1.Name = "pnlAlert1"; lblAlert1Icon.Name = "lblAlert1Icon"; lblAlert1Text.Name = "lblAlert1Text"; lblAlert1Time.Name = "lblAlert1Time";
            pnlAlert2.Name = "pnlAlert2"; lblAlert2Icon.Name = "lblAlert2Icon"; lblAlert2Text.Name = "lblAlert2Text"; lblAlert2Time.Name = "lblAlert2Time";
            pnlAlert3.Name = "pnlAlert3"; lblAlert3Icon.Name = "lblAlert3Icon"; lblAlert3Text.Name = "lblAlert3Text"; lblAlert3Time.Name = "lblAlert3Time";

            // DoctorDashboardControl
            Controls.Add(pnlContent);
            Name = "DoctorDashboardControl";
            Size = new Size(1000, 700);

            pnlContent.ResumeLayout(false);
            tlpBottom.ResumeLayout(false);
            pnlSchedulePanel.ResumeLayout(false);
            pnlSchedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            pnlAlertsPanel.ResumeLayout(false);
            pnlAlertsPanel.PerformLayout();
            tlpCards.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlContent;
        private Panel cardPatients;
        private Label lblCardPatTitle;
        private Label lblCardPatValue;
        private Label lblCardPatIcon;
        private Label lblCardPatSub;
        private Panel cardAppt;
        private Label lblCardApptTitle;
        private Label lblCardApptValue;
        private Label lblCardApptIcon;
        private Label lblCardApptSub;
        private Panel cardPending;
        private Label lblCardPendTitle;
        private Label lblCardPendValue;
        private Label lblCardPendIcon;
        private Label lblCardPendSub;
        private Panel cardAlerts;
        private Label lblCardAlertTitle;
        private Label lblCardAlertValue;
        private Label lblCardAlertIcon;
        private Label lblCardAlertSub;
        private Panel pnlSchedulePanel;
        private Label lblScheduleTitle;
        private DataGridView dgvSchedule;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colPatient;
        private DataGridViewTextBoxColumn colReason;
        private Panel pnlAlertsPanel;
        private Label lblAlertsTitle;
        private Panel pnlAlert1;
        private Label lblAlert1Icon;
        private Label lblAlert1Text;
        private Label lblAlert1Time;
        private Panel pnlAlert2;
        private Label lblAlert2Icon;
        private Label lblAlert2Text;
        private Label lblAlert2Time;
        private Panel pnlAlert3;
        private Label lblAlert3Icon;
        private Label lblAlert3Text;
        private Label lblAlert3Time;
        private TableLayoutPanel tlpBottom;
        private TableLayoutPanel tlpCards;
    }
}
