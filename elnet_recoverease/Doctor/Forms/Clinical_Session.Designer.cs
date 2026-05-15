namespace elnet_recoverease.Doctor.Forms
{
    partial class Clinical_Session
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblDiagTitle = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblGoalsTitle = new System.Windows.Forms.Label();
            this.txtGoals = new System.Windows.Forms.TextBox();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnMenuDiagnosis = new System.Windows.Forms.Button();
            this.btnMenuVitals = new System.Windows.Forms.Button();
            this.btnMenuPrescription = new System.Windows.Forms.Button();
            this.pnlDiagnosisSection = new System.Windows.Forms.Panel();
            this.pnlVitalsSection = new System.Windows.Forms.Panel();
            this.pnlPrescriptionsSection = new System.Windows.Forms.Panel();
            this.lblVitalsTitle = new System.Windows.Forms.Label();
            this.pnlVitals = new System.Windows.Forms.Panel();
            this.lblPrescriptionsTitle = new System.Windows.Forms.Label();
            this.pnlPrescriptions = new System.Windows.Forms.FlowLayoutPanel();
            
            // New Session Minutes Fields
            this.txtChiefComplaint = new System.Windows.Forms.TextBox();
            this.txtPlanNotes = new System.Windows.Forms.TextBox();
            
            // New Vitals Fields
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.txtHR = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.dgvVitalsHistory = new System.Windows.Forms.DataGridView();
            
            // New Prescription Fields
            this.cmbMedication = new System.Windows.Forms.ComboBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.flpReminderPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.chkDischarge = new System.Windows.Forms.CheckBox();
            
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 58, 107);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;

            // btnCloseX
            this.btnCloseX = new System.Windows.Forms.Button();
            this.btnCloseX.Text = "✕";
            this.btnCloseX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseX.ForeColor = System.Drawing.Color.White;
            this.btnCloseX.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseX.FlatAppearance.BorderSize = 0;
            this.btnCloseX.Size = new System.Drawing.Size(40, 40);
            this.btnCloseX.Location = new System.Drawing.Point(955, 15);
            this.btnCloseX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseX.Click += (s, e) => this.Close();
            this.pnlHeader.Controls.Add(this.btnCloseX);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Clinical Session";

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 180;
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);

            this.btnMenuDiagnosis = new System.Windows.Forms.Button();
            this.btnMenuVitals = new System.Windows.Forms.Button();
            this.btnMenuPrescription = new System.Windows.Forms.Button();

            SetupMenuButton(this.btnMenuDiagnosis, "DIAGNOSIS", 0);
            SetupMenuButton(this.btnMenuVitals, "VITAL SIGNS", 1);
            SetupMenuButton(this.btnMenuPrescription, "PRESCRIPTIONS", 2);

            this.pnlSidebar.Controls.Add(this.btnMenuPrescription);
            this.pnlSidebar.Controls.Add(this.btnMenuVitals);
            this.pnlSidebar.Controls.Add(this.btnMenuDiagnosis);

            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(200, 85);
            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.AutoSize = true;

            // lblAppointmentDate
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppointmentDate.ForeColor = System.Drawing.Color.Gray;
            this.lblAppointmentDate.Location = new System.Drawing.Point(200, 120);
            this.lblAppointmentDate.Text = "Date";

            // pnlDiagnosisSection (Session Minutes)
            this.pnlDiagnosisSection.Location = new System.Drawing.Point(200, 160);
            this.pnlDiagnosisSection.Size = new System.Drawing.Size(720, 480);
            this.pnlDiagnosisSection.Visible = true;

            var lblChief = CreateFieldLabel("CHIEF COMPLAINT", 10, 0);
            this.txtChiefComplaint.Location = new System.Drawing.Point(10, 25);
            this.txtChiefComplaint.Size = new System.Drawing.Size(700, 55);
            this.txtChiefComplaint.Multiline = true;

            var lblAssessment = CreateFieldLabel("DIAGNOSIS / ASSESSMENT", 10, 90);
            this.txtDiagnosis.Location = new System.Drawing.Point(10, 115);
            this.txtDiagnosis.Size = new System.Drawing.Size(700, 25);

            var lblGoal = CreateFieldLabel("TREATMENT GOAL", 10, 150);
            this.txtGoal = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(10, 175), Size = new System.Drawing.Size(480, 25) };

            var lblGoalDate = CreateFieldLabel("TARGET DATE", 510, 150);
            this.dtpGoalDate = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(510, 175), Size = new System.Drawing.Size(200, 25), Format = System.Windows.Forms.DateTimePickerFormat.Short };

            var lblPlan = CreateFieldLabel("PLAN & MANAGEMENT NOTES", 10, 215);
            this.txtPlanNotes.Location = new System.Drawing.Point(10, 240);
            this.txtPlanNotes.Size = new System.Drawing.Size(700, 160);
            this.txtPlanNotes.Multiline = true;

            this.pnlDiagnosisSection.Controls.AddRange(new Control[] { lblChief, this.txtChiefComplaint, lblAssessment, this.txtDiagnosis, lblGoal, this.txtGoal, lblGoalDate, this.dtpGoalDate, lblPlan, this.txtPlanNotes });

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 168, 168);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(440, 530);
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Text = "Complete";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(330, 830);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

            // Vitals Section
            this.pnlVitalsSection.Location = new System.Drawing.Point(200, 160);
            this.pnlVitalsSection.Size = new System.Drawing.Size(720, 480);
            this.pnlVitalsSection.Visible = false;

            var pnlVitalsEntry = new Panel { 
                Location = new Point(10, 10), Size = new Size(700, 200), 
                BackColor = Color.FromArgb(254, 253, 247),
                BorderStyle = BorderStyle.FixedSingle 
            };
            
            pnlVitalsEntry.Controls.Add(CreateFieldLabel("BP (mmHg)", 15, 15));
            this.txtSystolic.Location = new Point(15, 40); this.txtSystolic.Size = new Size(60, 25);
            pnlVitalsEntry.Controls.Add(new Label { Text = "/", Location = new Point(80, 42), AutoSize = true });
            this.txtDiastolic.Location = new Point(100, 40); this.txtDiastolic.Size = new Size(60, 25);

            pnlVitalsEntry.Controls.Add(CreateFieldLabel("HEART RATE", 180, 15));
            this.txtHR.Location = new Point(180, 40); this.txtHR.Size = new Size(100, 25);

            pnlVitalsEntry.Controls.Add(CreateFieldLabel("TEMP (°C)", 300, 15));
            this.txtTemp.Location = new Point(300, 40); this.txtTemp.Size = new Size(100, 25);

            pnlVitalsEntry.Controls.Add(CreateFieldLabel("WEIGHT (kg)", 15, 80));
            this.txtWeight.Location = new Point(15, 105); this.txtWeight.Size = new Size(100, 25);

            pnlVitalsEntry.Controls.Add(CreateFieldLabel("HEIGHT (cm)", 130, 80));
            this.txtHeight.Location = new Point(130, 105); this.txtHeight.Size = new Size(100, 25);

            pnlVitalsEntry.Controls.Add(CreateFieldLabel("BMI", 250, 80));
            this.lblBMI.Location = new Point(250, 105); this.lblBMI.Size = new Size(100, 25);
            this.lblBMI.BackColor = Color.White; this.lblBMI.TextAlign = ContentAlignment.MiddleCenter;
            this.lblBMI.BorderStyle = BorderStyle.FixedSingle;

            pnlVitalsEntry.Controls.Add(CreateFieldLabel("BLOOD TYPE", 370, 80));
            this.cmbBloodType = new ComboBox { Location = new Point(370, 105), Size = new Size(70, 25), DropDownStyle = ComboBoxStyle.DropDownList };
            this.cmbBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "Unknown" });

            pnlVitalsEntry.Controls.Add(CreateFieldLabel("ALLERGIES", 460, 80));
            this.txtAllergies = new TextBox { Location = new Point(460, 105), Size = new Size(220, 25) };

            this.btnSaveVitals = new Button { 
                Text = "💾 Save Vital Signs", Location = new Point(540, 150), 
                Size = new Size(140, 35), BackColor = Color.White, FlatStyle = FlatStyle.Flat 
            };
            this.btnSaveVitals.Click += new EventHandler(this.BtnSaveVitals_Click);
            pnlVitalsEntry.Controls.AddRange(new Control[] { this.txtSystolic, this.txtDiastolic, this.txtHR, this.txtTemp, this.txtWeight, this.txtHeight, this.lblBMI, this.cmbBloodType, this.txtAllergies, this.btnSaveVitals });

            var lblHistory = CreateFieldLabel("VITAL SIGNS HISTORY", 10, 225);
            this.dgvVitalsHistory.Location = new Point(10, 250);
            this.dgvVitalsHistory.Size = new Size(700, 220);
            this.dgvVitalsHistory.BackgroundColor = Color.White;
            this.dgvVitalsHistory.RowHeadersVisible = false;
            this.dgvVitalsHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.pnlVitalsSection.Controls.AddRange(new Control[] { pnlVitalsEntry, lblHistory, this.dgvVitalsHistory });

            // Prescriptions Section
            this.pnlPrescriptionsSection.Location = new System.Drawing.Point(200, 160);
            this.pnlPrescriptionsSection.Size = new System.Drawing.Size(720, 480);
            this.pnlPrescriptionsSection.Visible = false;

            // Row 1 Header
            Label lblAddMedHeader = new Label { Text = "⊕ ADD MEDICATION", Location = new Point(10, 0), Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true };
            Panel pnlMedEntry = new Panel { Size = new Size(700, 240), BackColor = Color.FromArgb(250, 251, 248), Location = new Point(10, 25), BorderStyle = BorderStyle.None };
            
            // First Row: Med, Dosage, Freq
            pnlMedEntry.Controls.Add(CreateFieldLabel("Medication", 15, 15));
            this.cmbMedication.Location = new Point(15, 40);
            this.cmbMedication.Size = new Size(300, 30);
            this.cmbMedication.Font = new Font("Segoe UI", 10F);
            this.cmbMedication.DropDownStyle = ComboBoxStyle.DropDown;
            
            pnlMedEntry.Controls.Add(CreateFieldLabel("Dosage (e.g.", 335, 15));
            this.txtDosage.Location = new Point(335, 40);
            this.txtDosage.Size = new Size(160, 30);
            this.txtDosage.Font = new Font("Segoe UI", 10F);
            
            pnlMedEntry.Controls.Add(CreateFieldLabel("Frequency", 515, 15));
            this.txtFrequency.Location = new Point(515, 40);
            this.txtFrequency.Size = new Size(160, 30);
            this.txtFrequency.Font = new Font("Segoe UI", 10F);

            // Second Row: Start Time, Interval, Start Date, End Date
            pnlMedEntry.Controls.Add(CreateFieldLabel("Start time", 15, 85));
            this.dtpStartTime.Location = new Point(15, 110);
            this.dtpStartTime.Size = new Size(130, 30);
            this.dtpStartTime.Format = DateTimePickerFormat.Custom;
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.ShowUpDown = true;
            
            pnlMedEntry.Controls.Add(CreateFieldLabel("Interval", 165, 85));
            this.numInterval.Location = new Point(165, 110);
            this.numInterval.Size = new Size(130, 30);
            this.numInterval.Value = 4;
            this.numInterval.Minimum = 1;
            this.numInterval.Maximum = 24;

            pnlMedEntry.Controls.Add(CreateFieldLabel("Start date", 315, 85));
            this.dtpStartDate.Location = new Point(315, 110);
            this.dtpStartDate.Size = new Size(150, 30);
            this.dtpStartDate.Format = DateTimePickerFormat.Short;

            pnlMedEntry.Controls.Add(CreateFieldLabel("End date", 485, 85));
            this.dtpEndDate.Location = new Point(485, 110);
            this.dtpEndDate.Size = new Size(150, 30);
            this.dtpEndDate.Format = DateTimePickerFormat.Short;

            // Reminders
            Label lblReminders = new Label { Text = "🕒 Reminders at:", Location = new Point(15, 160), Font = new Font("Segoe UI", 8.5F), ForeColor = Color.Gray, AutoSize = true };
            this.flpReminderPreview.Location = new Point(15, 185);
            this.flpReminderPreview.Size = new Size(450, 45);
            this.flpReminderPreview.FlowDirection = FlowDirection.LeftToRight;

            this.btnAddMed.Text = "+ Add to pad";
            this.btnAddMed.Location = new Point(530, 185);
            this.btnAddMed.Size = new Size(145, 40);
            this.btnAddMed.BackColor = Color.White;
            this.btnAddMed.FlatStyle = FlatStyle.Flat;
            this.btnAddMed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnAddMed.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            this.btnAddMed.Click += new EventHandler(this.BtnAddMed_Click);

            pnlMedEntry.Controls.AddRange(new Control[] { 
                this.cmbMedication, this.txtDosage, this.txtFrequency, 
                this.dtpStartTime, this.numInterval, this.dtpStartDate, this.dtpEndDate,
                lblReminders, this.flpReminderPreview, this.btnAddMed 
            });

            // Prescription Pad Area
            Label lblPadHeader = new Label { Text = "📋 PRESCRIPTION PAD", Location = new Point(10, 280), Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(71, 85, 105), AutoSize = true };
            Label lblMedCount = new Label { Text = "0 medications", Location = new Point(590, 280), Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Color.Gray, AutoSize = true };
            
            this.pnlPrescriptions.Location = new Point(10, 305);
            this.pnlPrescriptions.Size = new Size(700, 330);
            this.pnlPrescriptions.AutoScroll = true;
            this.pnlPrescriptions.BackColor = Color.White;
            this.pnlPrescriptionsSection.Controls.AddRange(new Control[] { lblAddMedHeader, pnlMedEntry, lblPadHeader, lblMedCount, this.pnlPrescriptions });

            // Bottom Bar Refinement
            this.btnCancel.Text = "Discard Session";
            this.btnCancel.BackColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Size = new Size(140, 40);
            this.btnCancel.Location = new Point(200, 660); // Move away from edge
            this.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(71, 85, 105);
            this.btnCancel.BringToFront();

            this.chkDischarge.Text = "Mark as Final Session (Discharge)";
            this.chkDischarge.Location = new Point(400, 665);
            this.chkDischarge.AutoSize = true;
            this.chkDischarge.Font = new Font("Segoe UI", 9F);

            this.btnSave.Text = "Finalize Session";
            this.btnSave.BackColor = Color.FromArgb(0, 168, 168); // Teal
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.Size = new Size(160, 40);
            this.btnSave.Location = new Point(770, 660);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.Controls.Add(this.pnlDiagnosisSection);
            this.Controls.Add(this.pnlVitalsSection);
            this.Controls.Add(this.pnlPrescriptionsSection);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkDischarge);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clinical_Session";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblDiagTitle;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblGoalsTitle;
        private System.Windows.Forms.TextBox txtGoals;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCloseX;
        private System.Windows.Forms.Label lblVitalsTitle;
        private System.Windows.Forms.Panel pnlVitals;
        private System.Windows.Forms.Label lblPrescriptionsTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlPrescriptions;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnMenuDiagnosis;
        private System.Windows.Forms.Button btnMenuVitals;
        private System.Windows.Forms.Button btnMenuPrescription;
        private System.Windows.Forms.Panel pnlDiagnosisSection;
        private System.Windows.Forms.Panel pnlVitalsSection;
        private System.Windows.Forms.Panel pnlPrescriptionsSection;
        
        // Session Minutes
        private System.Windows.Forms.TextBox txtChiefComplaint;
        private System.Windows.Forms.TextBox txtPlanNotes;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.DateTimePicker dtpGoalDate;

        // Vitals
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.TextBox txtHR;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.DataGridView dgvVitalsHistory;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.TextBox txtAllergies;
        // Prescription
        private System.Windows.Forms.ComboBox cmbMedication;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.FlowLayoutPanel flpReminderPreview;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Button btnSaveVitals;
        private System.Windows.Forms.CheckBox chkDischarge;

        private Label CreateFieldLabel(string text, int x, int y)
        {
            return new Label { 
                Text = text, Location = new Point(x, y), 
                Font = new Font("Segoe UI", 8F, FontStyle.Bold), 
                ForeColor = Color.FromArgb(100, 116, 139), AutoSize = true 
            };
        }

        private void SetupMenuButton(Button btn, string text, int index)
        {
            btn.Text = text;
            btn.Size = new Size(180, 50);
            btn.Location = new Point(0, 80 + (index * 50));
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.ForeColor = Color.FromArgb(71, 85, 105);
        }
    }
}
