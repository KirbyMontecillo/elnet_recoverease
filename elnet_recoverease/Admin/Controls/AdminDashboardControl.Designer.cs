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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStatPatients = new System.Windows.Forms.Panel();
            this.pnlStatPatientsStrip = new System.Windows.Forms.Panel();
            this.lblStatPatientsVal = new System.Windows.Forms.Label();
            this.lblStatPatientsTitle = new System.Windows.Forms.Label();
            this.lblStatPatientsTrend = new System.Windows.Forms.Label();
            this.pnlStatDoctors = new System.Windows.Forms.Panel();
            this.pnlStatDoctorsStrip = new System.Windows.Forms.Panel();
            this.lblStatDoctorsVal = new System.Windows.Forms.Label();
            this.lblStatDoctorsTitle = new System.Windows.Forms.Label();
            this.lblStatDoctorsTrend = new System.Windows.Forms.Label();
            this.pnlStatAppointments = new System.Windows.Forms.Panel();
            this.pnlStatAppointmentsStrip = new System.Windows.Forms.Panel();
            this.lblStatAppointmentsVal = new System.Windows.Forms.Label();
            this.lblStatAppointmentsTitle = new System.Windows.Forms.Label();
            this.lblStatAppointmentsSub = new System.Windows.Forms.Label();
            this.pnlStatMissedMeds = new System.Windows.Forms.Panel();
            this.pnlStatMissedMedsStrip = new System.Windows.Forms.Panel();
            this.lblStatMissedMedsVal = new System.Windows.Forms.Label();
            this.lblStatMissedMedsTitle = new System.Windows.Forms.Label();
            this.lblStatMissedMedsSub = new System.Windows.Forms.Label();
            this.pnlCriticalAlert = new System.Windows.Forms.Panel();
            this.lblAlertText = new System.Windows.Forms.Label();
            this.lblAlertIcon = new System.Windows.Forms.Label();
            this.btnViewAllAlerts = new System.Windows.Forms.Label();
            this.tlpMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAdherenceCard = new System.Windows.Forms.Panel();
            this.lblAdherenceTitle = new System.Windows.Forms.Label();
            this.lblAdherenceDetails = new System.Windows.Forms.Label();
            this.flpAdherence = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlActivityCard = new System.Windows.Forms.Panel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.lblActivityViewLog = new System.Windows.Forms.Label();
            this.flpActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRecentPatientsCard = new System.Windows.Forms.Panel();
            this.lblRecentPatientsTitle = new System.Windows.Forms.Label();
            this.lblViewAllPatients = new System.Windows.Forms.Label();
            this.dgvRecentPatients = new System.Windows.Forms.DataGridView();

            this.tlpStats.SuspendLayout();
            this.pnlStatPatients.SuspendLayout();
            this.pnlStatDoctors.SuspendLayout();
            this.pnlStatAppointments.SuspendLayout();
            this.pnlStatMissedMeds.SuspendLayout();
            this.pnlCriticalAlert.SuspendLayout();
            this.tlpMainGrid.SuspendLayout();
            this.pnlAdherenceCard.SuspendLayout();
            this.pnlActivityCard.SuspendLayout();
            this.pnlRecentPatientsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPatients)).BeginInit();
            this.SuspendLayout();

            System.Drawing.Color clrWhite = System.Drawing.Color.White;

            // tlpStats
            this.tlpStats.ColumnCount = 4;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.Controls.Add(this.pnlStatPatients, 0, 0);
            this.tlpStats.Controls.Add(this.pnlStatDoctors, 1, 0);
            this.tlpStats.Controls.Add(this.pnlStatAppointments, 2, 0);
            this.tlpStats.Controls.Add(this.pnlStatMissedMeds, 3, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpStats.Location = new System.Drawing.Point(24, 24);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.Size = new System.Drawing.Size(1292, 145);
            this.tlpStats.RowCount = 1;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // Stat Card 1: Patients
            this.pnlStatPatients.BackColor = clrWhite;
            this.pnlStatPatients.Padding = new System.Windows.Forms.Padding(0);
            this.pnlStatPatients.Controls.Add(this.pnlStatPatientsStrip);
            this.pnlStatPatients.Controls.Add(this.lblStatPatientsVal);
            this.pnlStatPatients.Controls.Add(this.lblStatPatientsTitle);
            this.pnlStatPatients.Controls.Add(this.lblStatPatientsTrend);
            this.pnlStatPatients.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlStatPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatPatientsStrip.BackColor = System.Drawing.Color.FromArgb(56, 161, 105); // Green
            this.pnlStatPatientsStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatPatientsStrip.Height = 4;
            this.lblStatPatientsTitle.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatPatientsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatPatientsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatPatientsTitle.Text = "TOTAL PATIENTS";
            this.lblStatPatientsVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStatPatientsVal.Location = new System.Drawing.Point(18, 38);
            this.lblStatPatientsVal.AutoSize = true;
            this.lblStatPatientsVal.Text = "0";
            this.lblStatPatientsTrend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatPatientsTrend.ForeColor = System.Drawing.Color.FromArgb(56, 161, 105);
            this.lblStatPatientsTrend.Location = new System.Drawing.Point(20, 95);
            this.lblStatPatientsTrend.Text = "↑ 0 this week";

            // Stat Card 2: Doctors
            this.pnlStatDoctors.BackColor = clrWhite;
            this.pnlStatDoctors.Padding = new System.Windows.Forms.Padding(0);
            this.pnlStatDoctors.Controls.Add(this.pnlStatDoctorsStrip);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsVal);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsTitle);
            this.pnlStatDoctors.Controls.Add(this.lblStatDoctorsTrend);
            this.pnlStatDoctors.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlStatDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatDoctors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatDoctorsStrip.BackColor = System.Drawing.Color.FromArgb(44, 82, 130); // Navy
            this.pnlStatDoctorsStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatDoctorsStrip.Height = 4;
            this.lblStatDoctorsTitle.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatDoctorsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatDoctorsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatDoctorsTitle.Text = "ACTIVE";
            this.lblStatDoctorsVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStatDoctorsVal.Location = new System.Drawing.Point(18, 38);
            this.lblStatDoctorsVal.AutoSize = true;
            this.lblStatDoctorsVal.Text = "0";
            this.lblStatDoctorsTrend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatDoctorsTrend.ForeColor = System.Drawing.Color.FromArgb(56, 161, 105);
            this.lblStatDoctorsTrend.Location = new System.Drawing.Point(20, 95);
            this.lblStatDoctorsTrend.Text = "↑ 0 this week";

            // Stat Card 3: Appointments
            this.pnlStatAppointments.BackColor = clrWhite;
            this.pnlStatAppointments.Padding = new System.Windows.Forms.Padding(0);
            this.pnlStatAppointments.Controls.Add(this.pnlStatAppointmentsStrip);
            this.pnlStatAppointments.Controls.Add(this.lblStatAppointmentsVal);
            this.pnlStatAppointments.Controls.Add(this.lblStatAppointmentsTitle);
            this.pnlStatAppointments.Controls.Add(this.lblStatAppointmentsSub);
            this.pnlStatAppointments.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlStatAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatAppointmentsStrip.BackColor = System.Drawing.Color.FromArgb(160, 174, 192); // Grey
            this.pnlStatAppointmentsStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatAppointmentsStrip.Height = 4;
            this.lblStatAppointmentsTitle.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatAppointmentsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatAppointmentsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatAppointmentsTitle.Text = "APPOINTMENT";
            this.lblStatAppointmentsVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStatAppointmentsVal.Location = new System.Drawing.Point(18, 38);
            this.lblStatAppointmentsVal.AutoSize = true;
            this.lblStatAppointmentsVal.Text = "0";
            this.lblStatAppointmentsSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatAppointmentsSub.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatAppointmentsSub.Location = new System.Drawing.Point(20, 95);
            this.lblStatAppointmentsSub.Text = "0 scheduled";

            // Stat Card 4: Missed Medications
            this.pnlStatMissedMeds.BackColor = clrWhite;
            this.pnlStatMissedMeds.Padding = new System.Windows.Forms.Padding(0);
            this.pnlStatMissedMeds.Controls.Add(this.pnlStatMissedMedsStrip);
            this.pnlStatMissedMeds.Controls.Add(this.lblStatMissedMedsVal);
            this.pnlStatMissedMeds.Controls.Add(this.lblStatMissedMedsTitle);
            this.pnlStatMissedMeds.Controls.Add(this.lblStatMissedMedsSub);
            this.pnlStatMissedMeds.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.pnlStatMissedMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatMissedMeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatMissedMedsStrip.BackColor = System.Drawing.Color.FromArgb(197, 48, 48); // Red
            this.pnlStatMissedMedsStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatMissedMedsStrip.Height = 4;
            this.lblStatMissedMedsTitle.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatMissedMedsTitle.ForeColor = System.Drawing.Color.FromArgb(113, 128, 150);
            this.lblStatMissedMedsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatMissedMedsTitle.Text = "MISSED";
            this.lblStatMissedMedsVal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStatMissedMedsVal.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblStatMissedMedsVal.Location = new System.Drawing.Point(18, 38);
            this.lblStatMissedMedsVal.AutoSize = true;
            this.lblStatMissedMedsVal.Text = "0";
            this.lblStatMissedMedsSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatMissedMedsSub.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblStatMissedMedsSub.Location = new System.Drawing.Point(20, 95);
            this.lblStatMissedMedsSub.Text = "⚠ needs attention";

            // Critical Alert Banner
            this.pnlCriticalAlert.BackColor = System.Drawing.Color.FromArgb(255, 245, 245);
            this.pnlCriticalAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCriticalAlert.Controls.Add(this.btnViewAllAlerts);
            this.pnlCriticalAlert.Controls.Add(this.lblAlertText);
            this.pnlCriticalAlert.Controls.Add(this.lblAlertIcon);
            this.pnlCriticalAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCriticalAlert.Location = new System.Drawing.Point(24, 184);
            this.pnlCriticalAlert.Size = new System.Drawing.Size(1292, 60);
            this.pnlCriticalAlert.Visible = false;
            this.pnlCriticalAlert.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblAlertIcon.AutoSize = true;
            this.lblAlertIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAlertIcon.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblAlertIcon.Location = new System.Drawing.Point(15, 18);
            this.lblAlertIcon.Text = "⚠";
            this.lblAlertText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlertText.ForeColor = System.Drawing.Color.FromArgb(155, 44, 44);
            this.lblAlertText.Location = new System.Drawing.Point(45, 18);
            this.lblAlertText.Text = "0 patients missed their scheduled medications today.";
            this.btnViewAllAlerts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewAllAlerts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAllAlerts.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewAllAlerts.ForeColor = System.Drawing.Color.FromArgb(155, 44, 44);
            this.btnViewAllAlerts.Location = new System.Drawing.Point(1200, 18);
            this.btnViewAllAlerts.Text = "View all →";

            // Main Grid
            this.tlpMainGrid.ColumnCount = 2;
            this.tlpMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tlpMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlpMainGrid.Controls.Add(this.pnlAdherenceCard, 0, 0);
            this.tlpMainGrid.Controls.Add(this.pnlActivityCard, 1, 0);
            this.tlpMainGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMainGrid.Location = new System.Drawing.Point(24, 180);
            this.tlpMainGrid.Name = "tlpMainGrid";
            this.tlpMainGrid.RowCount = 1;
            this.tlpMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tlpMainGrid.Size = new System.Drawing.Size(1292, 450);

            // Adherence Card
            this.pnlAdherenceCard.BackColor = clrWhite;
            this.pnlAdherenceCard.Controls.Add(this.flpAdherence);
            this.pnlAdherenceCard.Controls.Add(this.lblAdherenceDetails);
            this.pnlAdherenceCard.Controls.Add(this.lblAdherenceTitle);
            this.pnlAdherenceCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdherenceCard.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlAdherenceCard.Padding = new System.Windows.Forms.Padding(20);
            this.lblAdherenceTitle.AutoSize = true;
            this.lblAdherenceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdherenceTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAdherenceTitle.Text = "Patient adherence by doctor";
            this.lblAdherenceDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdherenceDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdherenceDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAdherenceDetails.ForeColor = System.Drawing.Color.FromArgb(49, 151, 149);
            this.lblAdherenceDetails.Location = new System.Drawing.Point(380, 22);
            this.lblAdherenceDetails.Text = "Details";
            this.flpAdherence.AutoScroll = true;
            this.flpAdherence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAdherence.Location = new System.Drawing.Point(20, 60);
            this.flpAdherence.Size = new System.Drawing.Size(460, 370);

            // Activity Card
            this.pnlActivityCard.BackColor = clrWhite;
            this.pnlActivityCard.Controls.Add(this.flpActivity);
            this.pnlActivityCard.Controls.Add(this.lblActivityViewLog);
            this.pnlActivityCard.Controls.Add(this.lblActivityTitle);
            this.pnlActivityCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActivityCard.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlActivityCard.Padding = new System.Windows.Forms.Padding(20);
            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.Location = new System.Drawing.Point(20, 20);
            this.lblActivityTitle.Text = "Recent activity";
            this.lblActivityViewLog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblActivityViewLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblActivityViewLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblActivityViewLog.ForeColor = System.Drawing.Color.FromArgb(49, 151, 149);
            this.lblActivityViewLog.Location = new System.Drawing.Point(540, 22);
            this.lblActivityViewLog.Text = "View log";
            this.flpActivity.AutoScroll = true;
            this.flpActivity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpActivity.Location = new System.Drawing.Point(20, 60);
            this.flpActivity.Size = new System.Drawing.Size(632, 370);

            // Recent Patients Card
            this.pnlRecentPatientsCard.BackColor = clrWhite;
            this.pnlRecentPatientsCard.Controls.Add(this.dgvRecentPatients);
            this.pnlRecentPatientsCard.Controls.Add(this.lblViewAllPatients);
            this.pnlRecentPatientsCard.Controls.Add(this.lblRecentPatientsTitle);
            this.pnlRecentPatientsCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentPatientsCard.Location = new System.Drawing.Point(24, 650);
            this.pnlRecentPatientsCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRecentPatientsCard.Size = new System.Drawing.Size(1292, 300);
            this.lblRecentPatientsTitle.AutoSize = true;
            this.lblRecentPatientsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentPatientsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRecentPatientsTitle.Text = "Recent patients";
            this.lblViewAllPatients.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblViewAllPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblViewAllPatients.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblViewAllPatients.ForeColor = System.Drawing.Color.FromArgb(49, 151, 149);
            this.lblViewAllPatients.Location = new System.Drawing.Point(1150, 22);
            this.lblViewAllPatients.Text = "View all patients";
            this.lblViewAllPatients.Visible = false;
            this.dgvRecentPatients.BackgroundColor = clrWhite;
            this.dgvRecentPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRecentPatients.Location = new System.Drawing.Point(20, 60);
            this.dgvRecentPatients.Size = new System.Drawing.Size(1252, 220);
            this.dgvRecentPatients.ReadOnly = true;
            this.dgvRecentPatients.AllowUserToAddRows = false;
            this.dgvRecentPatients.RowHeadersVisible = false;
            this.dgvRecentPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentPatients.EnableHeadersVisualStyles = false;
            this.dgvRecentPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentPatients.ColumnHeadersHeight = 45;
            this.dgvRecentPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentPatients.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 58, 107);
            this.dgvRecentPatients.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecentPatients.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Bold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvRecentPatients.RowTemplate.Height = 40;
            this.dgvRecentPatients.GridColor = System.Drawing.Color.FromArgb(242, 247, 250);
            this.dgvRecentPatients.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(238, 243, 247);
            this.dgvRecentPatients.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 107);
            this.dgvRecentPatients.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecentPatients_CellFormatting);

            // AdminDashboardControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
            this.AutoScroll = true;
            this.Controls.Add(this.pnlRecentPatientsCard);
            this.Controls.Add(this.tlpMainGrid);
            this.Controls.Add(this.pnlCriticalAlert);
            this.Controls.Add(this.tlpStats);
            this.Name = "AdminDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Size = new System.Drawing.Size(1340, 810);
            this.Load += new System.EventHandler(this.AdminDashboardControl_Load);

            this.tlpStats.ResumeLayout(false);
            this.pnlStatPatients.ResumeLayout(false);
            this.pnlStatPatients.PerformLayout();
            this.pnlStatDoctors.ResumeLayout(false);
            this.pnlStatDoctors.PerformLayout();
            this.pnlStatAppointments.ResumeLayout(false);
            this.pnlStatAppointments.PerformLayout();
            this.pnlStatMissedMeds.ResumeLayout(false);
            this.pnlStatMissedMeds.PerformLayout();
            this.pnlCriticalAlert.ResumeLayout(false);
            this.pnlCriticalAlert.PerformLayout();
            this.tlpMainGrid.ResumeLayout(false);
            this.pnlAdherenceCard.ResumeLayout(false);
            this.pnlAdherenceCard.PerformLayout();
            this.pnlActivityCard.ResumeLayout(false);
            this.pnlActivityCard.PerformLayout();
            this.pnlRecentPatientsCard.ResumeLayout(false);
            this.pnlRecentPatientsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPatients)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Panel pnlStatPatients;
        private System.Windows.Forms.Panel pnlStatPatientsStrip;
        private System.Windows.Forms.Label lblStatPatientsVal;
        private System.Windows.Forms.Label lblStatPatientsTitle;
        private System.Windows.Forms.Label lblStatPatientsTrend;
        private System.Windows.Forms.Panel pnlStatDoctors;
        private System.Windows.Forms.Panel pnlStatDoctorsStrip;
        private System.Windows.Forms.Label lblStatDoctorsVal;
        private System.Windows.Forms.Label lblStatDoctorsTitle;
        private System.Windows.Forms.Label lblStatDoctorsTrend;
        private System.Windows.Forms.Panel pnlStatAppointments;
        private System.Windows.Forms.Panel pnlStatAppointmentsStrip;
        private System.Windows.Forms.Label lblStatAppointmentsVal;
        private System.Windows.Forms.Label lblStatAppointmentsTitle;
        private System.Windows.Forms.Label lblStatAppointmentsSub;
        private System.Windows.Forms.Panel pnlStatMissedMeds;
        private System.Windows.Forms.Panel pnlStatMissedMedsStrip;
        private System.Windows.Forms.Label lblStatMissedMedsVal;
        private System.Windows.Forms.Label lblStatMissedMedsTitle;
        private System.Windows.Forms.Label lblStatMissedMedsSub;
        private System.Windows.Forms.Panel pnlCriticalAlert;
        private System.Windows.Forms.Label lblAlertIcon;
        private System.Windows.Forms.Label lblAlertText;
        private System.Windows.Forms.Label btnViewAllAlerts;
        private System.Windows.Forms.TableLayoutPanel tlpMainGrid;
        private System.Windows.Forms.Panel pnlAdherenceCard;
        private System.Windows.Forms.Label lblAdherenceTitle;
        private System.Windows.Forms.Label lblAdherenceDetails;
        private System.Windows.Forms.FlowLayoutPanel flpAdherence;
        private System.Windows.Forms.Panel pnlActivityCard;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblActivityViewLog;
        private System.Windows.Forms.FlowLayoutPanel flpActivity;
        private System.Windows.Forms.Panel pnlRecentPatientsCard;
        private System.Windows.Forms.Label lblRecentPatientsTitle;
        private System.Windows.Forms.Label lblViewAllPatients;
        private System.Windows.Forms.DataGridView dgvRecentPatients;
    }
}
