namespace elnet_recoverease.Doctor
{
    partial class Clinical_Session
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.chkDischarge = new System.Windows.Forms.CheckBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.pnlStatusBadge = new System.Windows.Forms.Panel();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.tcSession = new System.Windows.Forms.TabControl();
            this.tpEncounter = new System.Windows.Forms.TabPage();
            this.tpVitals = new System.Windows.Forms.TabPage();
            this.tpPrescription = new System.Windows.Forms.TabPage();
            
            this.lblChiefComplaint = new System.Windows.Forms.Label();
            this.txtChiefComplaint = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblPlanNotes = new System.Windows.Forms.Label();
            this.txtPlanNotes = new System.Windows.Forms.TextBox();

            this.lblBP = new System.Windows.Forms.Label();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblHR = new System.Windows.Forms.Label();
            this.txtHR = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblVitalHistory = new System.Windows.Forms.Label();
            this.lblVitalHistorySub = new System.Windows.Forms.Label();
            this.dgvVitalHistory = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBMIStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpPrescriptions = new System.Windows.Forms.FlowLayoutPanel();
            this.flpReminders = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPrescriptionCount = new System.Windows.Forms.Label();
            this.lblRemindersTitle = new System.Windows.Forms.Label();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.cmbMeds = new System.Windows.Forms.ComboBox();
            this.lblMedicationLabel = new System.Windows.Forms.Label();
            this.lblDosageUnitLabel = new System.Windows.Forms.Label();
            this.txtDosageUnit = new System.Windows.Forms.TextBox();
            this.lblFrequencyLabel = new System.Windows.Forms.Label();
            this.lblStartTimeLabel = new System.Windows.Forms.Label();
            this.lblStartDateLabel = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDateLabel = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblPrescriptionTag = new System.Windows.Forms.Label();
            this.lblReminderTimes = new System.Windows.Forms.Label();
            this.lblIntervalLabel = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(20, 35, 65);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(245, 248, 252);

            // Form
            this.ClientSize = new System.Drawing.Size(1000, 780);
            this.Text = "Clinical Consultation Session";
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            // Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 110;
            this.pnlHeader.BackColor = clrNavy;

            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(30, 20);
            this.lblPatientName.AutoSize = true;

            this.lblPatientInfo.Text = "ID: P-0000 · May 07, 2026";
            this.lblPatientInfo.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
            this.lblPatientInfo.Font = new System.Drawing.Font("Segoe UI", 10);
            this.lblPatientInfo.Location = new System.Drawing.Point(30, 60);
            this.lblPatientInfo.AutoSize = true;

            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblPatientName, this.lblPatientInfo });

            // Tabs
            this.tcSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSession.Padding = new System.Drawing.Point(20, 10);
            this.tpEncounter.Text = "Session Minutes";
            this.tpVitals.Text = "Vital Signs";
            this.tpPrescription.Text = "Prescription Pad";
            this.tcSession.TabPages.AddRange(new System.Windows.Forms.TabPage[] { this.tpEncounter, this.tpVitals, this.tpPrescription });

            // Encounter Tab (Session Minutes)
            var pnlEncounterCard = new System.Windows.Forms.Panel {
                BackColor = System.Drawing.Color.FromArgb(248, 247, 242),
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(950, 560),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };

            var lblSectionTitle = new System.Windows.Forms.Label {
                Text = "SESSION NOTES",
                Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gray,
                Location = new System.Drawing.Point(20, 15),
                AutoSize = true
            };

            this.lblChiefComplaint.Text = "Chief complaint";
            this.lblChiefComplaint.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblChiefComplaint.Location = new System.Drawing.Point(20, 45);
            this.txtChiefComplaint.Location = new System.Drawing.Point(20, 70);
            this.txtChiefComplaint.Size = new System.Drawing.Size(910, 120);
            this.txtChiefComplaint.Multiline = true;
            this.txtChiefComplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblDiagnosis.Text = "Diagnosis / Assessment";
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDiagnosis.Location = new System.Drawing.Point(20, 205);
            this.txtDiagnosis.Location = new System.Drawing.Point(20, 230);
            this.txtDiagnosis.Size = new System.Drawing.Size(910, 35);
            this.txtDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblPlanNotes.Text = "Plan & management notes";
            this.lblPlanNotes.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblPlanNotes.Location = new System.Drawing.Point(20, 280);
            this.txtPlanNotes.Location = new System.Drawing.Point(20, 305);
            this.txtPlanNotes.Size = new System.Drawing.Size(910, 150);
            this.txtPlanNotes.Multiline = true;
            this.txtPlanNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            pnlEncounterCard.Controls.AddRange(new System.Windows.Forms.Control[] { 
                lblSectionTitle,
                this.lblChiefComplaint, this.txtChiefComplaint, 
                this.lblDiagnosis, this.txtDiagnosis, 
                this.lblPlanNotes, this.txtPlanNotes 
            });

            this.tpEncounter.Controls.Add(pnlEncounterCard);

            // Vitals Tab
            var pnlVitalsInput = new System.Windows.Forms.Panel {
                BackColor = System.Drawing.Color.FromArgb(248, 247, 242),
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(950, 230),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };

            this.lblBP.Text = "Blood pressure (mmHg)";
            this.lblBP.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblBP.Location = new System.Drawing.Point(20, 15);
            this.txtSystolic.Location = new System.Drawing.Point(20, 40);
            this.txtSystolic.Size = new System.Drawing.Size(120, 35);
            this.lblSlash.Text = "/";
            this.lblSlash.Location = new System.Drawing.Point(145, 45);
            this.lblSlash.Size = new System.Drawing.Size(20, 30);
            this.txtDiastolic.Location = new System.Drawing.Point(165, 40);
            this.txtDiastolic.Size = new System.Drawing.Size(120, 35);

            this.lblHR.Text = "Heart rate (bpm)";
            this.lblHR.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblHR.Location = new System.Drawing.Point(320, 15);
            this.txtHR.Location = new System.Drawing.Point(320, 40);
            this.txtHR.Size = new System.Drawing.Size(280, 35);

            this.lblTemp.Text = "Temperature (°C)";
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblTemp.Location = new System.Drawing.Point(630, 15);
            this.txtTemp.Location = new System.Drawing.Point(630, 40);
            this.txtTemp.Size = new System.Drawing.Size(280, 35);

            this.lblWeight.Text = "Weight (kg)";
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(20, 95);
            this.txtWeight.Location = new System.Drawing.Point(20, 120);
            this.txtWeight.Size = new System.Drawing.Size(280, 35);

            this.lblHeight.Text = "Height (cm)";
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblHeight.Location = new System.Drawing.Point(320, 95);
            this.txtHeight.Location = new System.Drawing.Point(320, 120);
            this.txtHeight.Size = new System.Drawing.Size(280, 35);

            this.txtBMI.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            
            this.lblBloodType.Text = "Blood Type (set once)";
            this.lblBloodType.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblBloodType.Location = new System.Drawing.Point(20, 165);
            this.cmbBloodType.Location = new System.Drawing.Point(20, 190);
            this.cmbBloodType.Size = new System.Drawing.Size(280, 35);
            this.cmbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodType.Items.AddRange(new object[] { "--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });

            pnlVitalsInput.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBP, this.txtSystolic, this.lblSlash, this.txtDiastolic,
                this.lblHR, this.txtHR,
                this.lblTemp, this.txtTemp,
                this.lblWeight, this.txtWeight,
                this.lblHeight, this.txtHeight,
                this.lblBMI, this.txtBMI,
                this.lblBloodType, this.cmbBloodType
            });

            this.lblVitalHistory.Text = "Vital Signs History";
            this.lblVitalHistory.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.lblVitalHistory.Location = new System.Drawing.Point(20, 265);
            this.lblVitalHistory.AutoSize = true;

            this.lblVitalHistorySub.Text = "Previous readings for this patient";
            this.lblVitalHistorySub.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Italic);
            this.lblVitalHistorySub.ForeColor = System.Drawing.Color.Gray;
            this.lblVitalHistorySub.Location = new System.Drawing.Point(750, 265);
            this.lblVitalHistorySub.AutoSize = true;

            this.dgvVitalHistory.Location = new System.Drawing.Point(20, 295);
            this.dgvVitalHistory.Size = new System.Drawing.Size(950, 270);
            this.dgvVitalHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvVitalHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVitalHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVitalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVitalHistory.ColumnHeadersHeight = 40;
            this.dgvVitalHistory.ColumnHeadersVisible = true;
            this.dgvVitalHistory.EnableHeadersVisualStyles = false;
            this.dgvVitalHistory.RowHeadersVisible = false;
            this.dgvVitalHistory.AllowUserToAddRows = false;
            this.dgvVitalHistory.ReadOnly = true;
            this.dgvVitalHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVitalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVitalHistory.GridColor = System.Drawing.Color.FromArgb(230, 235, 245);
            
            // Header Style
            this.dgvVitalHistory.ColumnHeadersDefaultCellStyle.BackColor = clrNavy;
            this.dgvVitalHistory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVitalHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvVitalHistory.ColumnHeadersDefaultCellStyle.SelectionBackColor = clrNavy;

            // Columns
            this.colDate.HeaderText = "DATE"; this.colDate.Name = "colDate";
            this.colBP.HeaderText = "B/P"; this.colBP.Name = "colBP";
            this.colHR.HeaderText = "HR (bpm)"; this.colHR.Name = "colHR";
            this.colTemp.HeaderText = "TEMP (°C)"; this.colTemp.Name = "colTemp";
            this.colWeight.HeaderText = "WEIGHT"; this.colWeight.Name = "colWeight";
            this.colHeight.HeaderText = "HEIGHT"; this.colHeight.Name = "colHeight";
            this.colBMI.HeaderText = "BMI"; this.colBMI.Name = "colBMI";
            this.colBMIStatus.HeaderText = "STATUS"; this.colBMIStatus.Name = "colBMIStatus";

            this.dgvVitalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDate, this.colBP, this.colHR, this.colTemp, this.colWeight, this.colHeight, this.colBMI, this.colBMIStatus
            });

            this.tpVitals.Controls.AddRange(new System.Windows.Forms.Control[] { 
                pnlVitalsInput, this.lblVitalHistory, this.lblVitalHistorySub, this.dgvVitalHistory 
            });

            // Prescription Tab
            var pnlPrescriptionInput = new System.Windows.Forms.Panel {
                BackColor = System.Drawing.Color.FromArgb(248, 247, 242),
                Location = new System.Drawing.Point(20, 50),
                Size = new System.Drawing.Size(950, 280),
                BorderStyle = System.Windows.Forms.BorderStyle.None
            };
            pnlPrescriptionInput.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 950, 280, 15, 15));

            var lblAddMedTitle = new System.Windows.Forms.Label {
                Text = "⊕ ADD MEDICATION",
                Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Gray,
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };

            this.lblMedicationLabel.Text = "Medication";
            this.lblMedicationLabel.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblMedicationLabel.Location = new System.Drawing.Point(20, 20);
            this.cmbMeds.Location = new System.Drawing.Point(20, 45);
            this.cmbMeds.Size = new System.Drawing.Size(430, 35);
            this.cmbMeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblDosageUnitLabel.Text = "Dosage (e.g. 500mg)";
            this.lblDosageUnitLabel.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDosageUnitLabel.Location = new System.Drawing.Point(470, 20);
            this.txtDosageUnit.Location = new System.Drawing.Point(470, 45);
            this.txtDosageUnit.Size = new System.Drawing.Size(210, 35);

            this.lblFrequencyLabel.Text = "Frequency";
            this.lblFrequencyLabel.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblFrequencyLabel.Location = new System.Drawing.Point(700, 20);
            // cmbFrequency is added dynamically in Clinical_Session.cs, but we'll set its bounds here
            // Note: cmbFrequency is a private field in Clinical_Session.cs, not the designer.
            // I'll adjust the logic in Clinical_Session.cs to place it correctly.

            this.lblStartTimeLabel.Text = "Start time";
            this.lblStartTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblStartTimeLabel.Location = new System.Drawing.Point(20, 95);

            this.lblIntervalLabel.Text = "Interval (hrs)";
            this.lblIntervalLabel.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblIntervalLabel.Location = new System.Drawing.Point(250, 95);
            this.txtInterval.Location = new System.Drawing.Point(250, 120);
            this.txtInterval.Size = new System.Drawing.Size(200, 35);

            this.lblStartDateLabel.Text = "Start date";
            this.lblStartDateLabel.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblStartDateLabel.Location = new System.Drawing.Point(470, 95);
            this.dtpStartDate.Location = new System.Drawing.Point(470, 120);
            this.dtpStartDate.Size = new System.Drawing.Size(210, 35);

            this.lblEndDateLabel.Text = "End date";
            this.lblEndDateLabel.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblEndDateLabel.Location = new System.Drawing.Point(700, 95);
            this.dtpEndDate.Location = new System.Drawing.Point(700, 120);
            this.dtpEndDate.Size = new System.Drawing.Size(210, 35);

            this.lblRemindersTitle.Text = "🕒 Reminders at:";
            this.lblRemindersTitle.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblRemindersTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblRemindersTitle.Location = new System.Drawing.Point(20, 175);
            this.lblRemindersTitle.AutoSize = true;

            this.flpReminders.Location = new System.Drawing.Point(20, 200);
            this.flpReminders.Size = new System.Drawing.Size(600, 45);
            this.flpReminders.BackColor = System.Drawing.Color.Transparent;

            this.btnAddMed.Text = "＋ Add to pad";
            this.btnAddMed.Size = new System.Drawing.Size(180, 42);
            this.btnAddMed.Location = new System.Drawing.Point(730, 200);
            this.btnAddMed.BackColor = System.Drawing.Color.White;
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5f);
            this.btnAddMed.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 180, 42, 10, 10));
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);

            pnlPrescriptionInput.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMedicationLabel, this.cmbMeds, this.lblDosageUnitLabel, this.txtDosageUnit,
                this.lblFrequencyLabel, this.lblStartTimeLabel, this.btnAddMed,
                this.lblStartDateLabel, this.dtpStartDate, this.lblEndDateLabel, this.dtpEndDate,
                this.lblIntervalLabel, this.txtInterval, this.lblRemindersTitle, this.flpReminders
            });

            this.lblPrescriptionTag.Text = "📋 PRESCRIPTION PAD";
            this.lblPrescriptionTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionTag.ForeColor = System.Drawing.Color.Gray;
            this.lblPrescriptionTag.Location = new System.Drawing.Point(20, 350);
            this.lblPrescriptionTag.AutoSize = true;

            this.lblPrescriptionCount.Text = "0 medications";
            this.lblPrescriptionCount.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionCount.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.lblPrescriptionCount.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.lblPrescriptionCount.Location = new System.Drawing.Point(830, 345);
            this.lblPrescriptionCount.AutoSize = true;

            this.flpPrescriptions.Location = new System.Drawing.Point(20, 380);
            this.flpPrescriptions.Size = new System.Drawing.Size(950, 200);
            this.flpPrescriptions.AutoScroll = true;
            this.flpPrescriptions.BackColor = System.Drawing.Color.White;

            this.tpPrescription.Controls.AddRange(new System.Windows.Forms.Control[] { 
                lblAddMedTitle, pnlPrescriptionInput, this.lblPrescriptionTag, this.lblPrescriptionCount, this.flpPrescriptions
            });

            // Footer
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 80;
            this.pnlFooter.BackColor = clrBg;
            this.btnFinalize.Text = "Finalize Session";
            this.btnFinalize.BackColor = clrTeal;
            this.btnFinalize.ForeColor = System.Drawing.Color.White;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnFinalize.Size = new System.Drawing.Size(200, 45);
            this.btnFinalize.Location = new System.Drawing.Point(770, 18);
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);

            this.btnCancel.Text = "Discard Session";
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.Location = new System.Drawing.Point(30, 18);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.chkDischarge.Text = "Mark as Final Session (Discharge Patient)";
            this.chkDischarge.Font = new System.Drawing.Font("Segoe UI Semibold", 9f);
            this.chkDischarge.ForeColor = System.Drawing.ColorTranslator.FromHtml("#475569");
            this.chkDischarge.Location = new System.Drawing.Point(460, 28);
            this.chkDischarge.Size = new System.Drawing.Size(300, 24);
            this.chkDischarge.Cursor = System.Windows.Forms.Cursors.Hand;

            this.pnlFooter.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnFinalize, this.btnCancel, this.chkDischarge });

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.tcSession, this.pnlFooter, this.pnlHeader });

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.Panel pnlStatusBadge;
        private System.Windows.Forms.Label lblStatusText;
        
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        private System.Windows.Forms.TabControl tcSession;
        private System.Windows.Forms.TabPage tpEncounter;
        private System.Windows.Forms.TabPage tpVitals;
        private System.Windows.Forms.TabPage tpPrescription;
        private System.Windows.Forms.Label lblChiefComplaint;
        private System.Windows.Forms.TextBox txtChiefComplaint;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblPlanNotes;
        private System.Windows.Forms.TextBox txtPlanNotes;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.TextBox txtHR;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.Label lblVitalHistory;
        private System.Windows.Forms.Label lblVitalHistorySub;
        private System.Windows.Forms.DataGridView dgvVitalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBMIStatus;
        private System.Windows.Forms.FlowLayoutPanel flpPrescriptions;
        private System.Windows.Forms.FlowLayoutPanel flpReminders;
        private System.Windows.Forms.Label lblPrescriptionCount;
        private System.Windows.Forms.Label lblRemindersTitle;
        private System.Windows.Forms.DataGridView dgvPrescriptions; // Keeping for reference if needed, but not used in UI now
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.ComboBox cmbMeds;
        private System.Windows.Forms.Label lblMedicationLabel;
        private System.Windows.Forms.Label lblDosageUnitLabel;
        private System.Windows.Forms.TextBox txtDosageUnit;
        private System.Windows.Forms.Label lblFrequencyLabel;
        private System.Windows.Forms.Label lblStartTimeLabel;
        private System.Windows.Forms.Label lblStartDateLabel;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDateLabel;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblPrescriptionTag;
        private System.Windows.Forms.Label lblReminderTimes;
        private System.Windows.Forms.Label lblIntervalLabel;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkDischarge;
    }
}
