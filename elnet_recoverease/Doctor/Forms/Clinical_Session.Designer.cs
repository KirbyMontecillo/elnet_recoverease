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
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.btnAddMed = new System.Windows.Forms.Button();
            
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
            this.btnCloseX.Location = new System.Drawing.Point(550, 5);
            this.btnCloseX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseX.Click += (s, e) => this.Close();
            this.pnlHeader.Controls.Add(this.btnCloseX);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 14F, System.Drawing.FontStyle.Bold);
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

            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI Bold", 13F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(200, 85);
            this.lblPatientName.Text = "Patient Name";

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
            this.txtChiefComplaint.Size = new System.Drawing.Size(700, 80);
            this.txtChiefComplaint.Multiline = true;

            var lblAssessment = CreateFieldLabel("DIAGNOSIS / ASSESSMENT", 10, 115);
            this.txtDiagnosis.Location = new System.Drawing.Point(10, 140);
            this.txtDiagnosis.Size = new System.Drawing.Size(700, 30);

            var lblPlan = CreateFieldLabel("PLAN & MANAGEMENT NOTES", 10, 185);
            this.txtPlanNotes.Location = new System.Drawing.Point(10, 210);
            this.txtPlanNotes.Size = new System.Drawing.Size(700, 250);
            this.txtPlanNotes.Multiline = true;

            this.pnlDiagnosisSection.Controls.AddRange(new Control[] { lblChief, this.txtChiefComplaint, lblAssessment, this.txtDiagnosis, lblPlan, this.txtPlanNotes });

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 168, 168);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(440, 530);
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Text = "Complete";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(330, 830);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

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

            var btnSaveVitals = new Button { 
                Text = "💾 Save Vital Signs", Location = new Point(540, 150), 
                Size = new Size(140, 35), BackColor = Color.White, FlatStyle = FlatStyle.Flat 
            };
            pnlVitalsEntry.Controls.AddRange(new Control[] { this.txtSystolic, this.txtDiastolic, this.txtHR, this.txtTemp, this.txtWeight, this.txtHeight, this.lblBMI, btnSaveVitals });

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

            var pnlAddMed = new Panel { 
                Location = new Point(10, 10), Size = new Size(700, 180), 
                BackColor = Color.FromArgb(254, 253, 247),
                BorderStyle = BorderStyle.FixedSingle 
            };
            pnlAddMed.Controls.Add(CreateFieldLabel("MEDICATION", 15, 15));
            this.cmbMedication.Location = new Point(15, 40); this.cmbMedication.Size = new Size(250, 25);
            
            pnlAddMed.Controls.Add(CreateFieldLabel("DOSAGE", 280, 15));
            this.txtDosage.Location = new Point(280, 40); this.txtDosage.Size = new Size(150, 25);

            pnlAddMed.Controls.Add(CreateFieldLabel("FREQUENCY", 450, 15));
            this.cmbFrequency.Location = new Point(450, 40); this.cmbFrequency.Size = new Size(150, 25);

            this.btnAddMed.Text = "+ Add to pad"; this.btnAddMed.Location = new Point(560, 130);
            this.btnAddMed.Size = new Size(120, 35); this.btnAddMed.BackColor = Color.White; this.btnAddMed.FlatStyle = FlatStyle.Flat;
            pnlAddMed.Controls.AddRange(new Control[] { this.cmbMedication, this.txtDosage, this.cmbFrequency, this.btnAddMed });

            var lblPad = CreateFieldLabel("PRESCRIPTION PAD", 10, 205);
            this.pnlPrescriptions.Location = new System.Drawing.Point(10, 230);
            this.pnlPrescriptions.Size = new System.Drawing.Size(700, 240);
            this.pnlPrescriptions.AutoScroll = true;
            this.pnlPrescriptions.BackColor = Color.White;

            this.pnlPrescriptionsSection.Controls.AddRange(new Control[] { pnlAddMed, lblPad, this.pnlPrescriptions });

            // btnSave position update
            this.btnSave.Location = new System.Drawing.Point(780, 650);
            this.btnCancel.Location = new System.Drawing.Point(650, 650);

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

        // Vitals
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.TextBox txtHR;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.DataGridView dgvVitalsHistory;

        // Prescription
        private System.Windows.Forms.ComboBox cmbMedication;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Button btnAddMed;

        private Label CreateFieldLabel(string text, int x, int y)
        {
            return new Label { 
                Text = text, Location = new Point(x, y), 
                Font = new Font("Segoe UI Bold", 8F, FontStyle.Bold), 
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
            btn.Font = new Font("Segoe UI Bold", 9F, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.ForeColor = Color.FromArgb(71, 85, 105);
        }
    }
}
