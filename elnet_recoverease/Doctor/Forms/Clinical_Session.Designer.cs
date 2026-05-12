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
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 58, 107);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Clinical Session";

            // lblPatientName
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(20, 90);
            this.lblPatientName.Text = "Patient Name";

            // lblAppointmentDate
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppointmentDate.ForeColor = System.Drawing.Color.Gray;
            this.lblAppointmentDate.Location = new System.Drawing.Point(20, 120);
            this.lblAppointmentDate.Text = "Date";

            // Diagnosis
            this.lblDiagTitle.AutoSize = true;
            this.lblDiagTitle.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiagTitle.Location = new System.Drawing.Point(20, 160);
            this.lblDiagTitle.Text = "Diagnosis";
            this.txtDiagnosis.Location = new System.Drawing.Point(20, 190);
            this.txtDiagnosis.Size = new System.Drawing.Size(540, 60);
            this.txtDiagnosis.Multiline = true;

            // Goals
            this.lblGoalsTitle.AutoSize = true;
            this.lblGoalsTitle.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.lblGoalsTitle.Location = new System.Drawing.Point(20, 260);
            this.lblGoalsTitle.Text = "Treatment Goals";
            this.txtGoals.Location = new System.Drawing.Point(20, 290);
            this.txtGoals.Size = new System.Drawing.Size(540, 60);
            this.txtGoals.Multiline = true;

            // Notes
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotesTitle.Location = new System.Drawing.Point(20, 360);
            this.lblNotesTitle.Text = "Clinical Notes";
            this.txtNotes.Location = new System.Drawing.Point(20, 390);
            this.txtNotes.Size = new System.Drawing.Size(540, 120);
            this.txtNotes.Multiline = true;

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
            this.btnCancel.Location = new System.Drawing.Point(310, 530);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 600);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotesTitle);
            this.Controls.Add(this.txtGoals);
            this.Controls.Add(this.lblGoalsTitle);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.lblDiagTitle);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}
