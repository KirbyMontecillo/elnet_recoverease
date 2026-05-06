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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblSessionTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tcSession = new System.Windows.Forms.TabControl();
            this.tpEncounter = new System.Windows.Forms.TabPage();
            this.tpVitals = new System.Windows.Forms.TabPage();
            this.tpPrescription = new System.Windows.Forms.TabPage();
            
            // Encounter Tab Controls
            this.lblNotesLabel = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblRecoveryLabel = new System.Windows.Forms.Label();
            this.trbRecovery = new System.Windows.Forms.TrackBar();
            this.lblRecoveryValue = new System.Windows.Forms.Label();

            // Vitals Tab Controls
            this.lblBP = new System.Windows.Forms.Label();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblHR = new System.Windows.Forms.Label();
            this.txtHR = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();

            // Prescription Tab Controls
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.cmbMeds = new System.Windows.Forms.ComboBox();
            this.lblPrescriptionTag = new System.Windows.Forms.Label();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form Settings
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Text = "Clinical Consultation Session";
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            // Colors
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(20, 35, 65);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(245, 248, 252);

            // Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 100;
            this.pnlHeader.BackColor = clrNavy;
            this.lblSessionTitle.Text = "CLINICAL ENCOUNTER";
            this.lblSessionTitle.ForeColor = System.Drawing.Color.FromArgb(150, 165, 195);
            this.lblSessionTitle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblSessionTitle.Location = new System.Drawing.Point(30, 25);
            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(30, 45);
            this.lblPatientName.AutoSize = true;
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblSessionTitle, this.lblPatientName });

            // Tabs
            this.tcSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSession.Padding = new System.Drawing.Point(20, 10);
            this.tpEncounter.Text = "Session Minutes";
            this.tpVitals.Text = "Vital Signs";
            this.tpPrescription.Text = "Prescription Pad";
            this.tcSession.TabPages.AddRange(new System.Windows.Forms.TabPage[] { this.tpEncounter, this.tpVitals, this.tpPrescription });

            // Encounter Page
            this.lblNotesLabel.Text = "Clinical Journal / Minutes during session";
            this.lblNotesLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.lblNotesLabel.Location = new System.Drawing.Point(20, 20);
            this.txtMinutes.Location = new System.Drawing.Point(20, 50);
            this.txtMinutes.Size = new System.Drawing.Size(600, 350);
            this.txtMinutes.Multiline = true;
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblRecoveryLabel.Text = "Recovery Progress Tracking";
            this.lblRecoveryLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.lblRecoveryLabel.Location = new System.Drawing.Point(650, 20);
            this.trbRecovery.Location = new System.Drawing.Point(650, 60);
            this.trbRecovery.Size = new System.Drawing.Size(300, 45);
            this.trbRecovery.Maximum = 100;
            this.trbRecovery.TickFrequency = 10;
            this.trbRecovery.Scroll += (s, e) => this.lblRecoveryValue.Text = trbRecovery.Value + "% Recovered";
            this.lblRecoveryValue.Text = "0% Recovered";
            this.lblRecoveryValue.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblRecoveryValue.ForeColor = clrTeal;
            this.lblRecoveryValue.Location = new System.Drawing.Point(650, 110);
            this.lblRecoveryValue.AutoSize = true;

            this.tpEncounter.Controls.AddRange(new System.Windows.Forms.Control[] { 
                this.lblNotesLabel, this.txtMinutes, this.lblRecoveryLabel, this.trbRecovery, this.lblRecoveryValue 
            });

            // Vitals Page
            this.lblBP.Text = "Blood Pressure (mmHg)";
            this.lblBP.Location = new System.Drawing.Point(30, 30);
            this.txtBP.Location = new System.Drawing.Point(30, 55);
            this.txtBP.Size = new System.Drawing.Size(200, 30);

            this.lblTemp.Text = "Temperature (°C)";
            this.lblTemp.Location = new System.Drawing.Point(30, 100);
            this.txtTemp.Location = new System.Drawing.Point(30, 125);
            this.txtTemp.Size = new System.Drawing.Size(200, 30);

            this.lblHR.Text = "Heart Rate (BPM)";
            this.lblHR.Location = new System.Drawing.Point(30, 170);
            this.txtHR.Location = new System.Drawing.Point(30, 195);
            this.txtHR.Size = new System.Drawing.Size(200, 30);

            this.lblWeight.Text = "Weight (kg)";
            this.lblWeight.Location = new System.Drawing.Point(30, 240);
            this.txtWeight.Location = new System.Drawing.Point(30, 265);
            this.txtWeight.Size = new System.Drawing.Size(200, 30);

            this.tpVitals.Controls.AddRange(new System.Windows.Forms.Control[] { 
                this.lblBP, this.txtBP, this.lblTemp, this.txtTemp, this.lblHR, this.txtHR, this.lblWeight, this.txtWeight 
            });

            // Prescription Page
            this.lblPrescriptionTag.Text = "Active Prescriptions for this Session";
            this.lblPrescriptionTag.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionTag.Location = new System.Drawing.Point(20, 20);
            this.dgvPrescriptions.Location = new System.Drawing.Point(20, 120);
            this.dgvPrescriptions.Size = new System.Drawing.Size(930, 350);
            this.dgvPrescriptions.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cmbMeds.Location = new System.Drawing.Point(20, 60);
            this.cmbMeds.Size = new System.Drawing.Size(400, 35);
            this.btnAddMed.Text = "+ Add to Prescription Pad";
            this.btnAddMed.Location = new System.Drawing.Point(430, 58);
            this.btnAddMed.Size = new System.Drawing.Size(200, 38);
            this.btnAddMed.BackColor = clrTeal;
            this.btnAddMed.ForeColor = System.Drawing.Color.White;
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);

            this.tpPrescription.Controls.AddRange(new System.Windows.Forms.Control[] { 
                this.lblPrescriptionTag, this.dgvPrescriptions, this.cmbMeds, this.btnAddMed 
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
            this.btnCancel.Click += (s, e) => this.Close();

            this.pnlFooter.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnFinalize, this.btnCancel });

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.tcSession, this.pnlFooter, this.pnlHeader });

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblSessionTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tcSession;
        private System.Windows.Forms.TabPage tpEncounter;
        private System.Windows.Forms.TabPage tpVitals;
        private System.Windows.Forms.TabPage tpPrescription;
        private System.Windows.Forms.Label lblNotesLabel;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblRecoveryLabel;
        private System.Windows.Forms.TrackBar trbRecovery;
        private System.Windows.Forms.Label lblRecoveryValue;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.TextBox txtHR;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.ComboBox cmbMeds;
        private System.Windows.Forms.Label lblPrescriptionTag;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnCancel;
    }
}
