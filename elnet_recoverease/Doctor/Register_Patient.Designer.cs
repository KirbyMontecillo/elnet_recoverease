namespace elnet_recoverease.Doctor
{
    partial class Register_Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.txtERelation = new System.Windows.Forms.TextBox();
            this.txtEPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAttendingDoctor = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(20, 30, 70);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 150, 150);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(245, 247, 250);

            this.SuspendLayout();

            // Form properties
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 950);
            this.Text = "Patient Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.BackColor = clrBg;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Title Bar
            var pnlTitle = new System.Windows.Forms.Panel();
            pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitle.Height = 60;
            pnlTitle.BackColor = clrNavy;
            this.Controls.Add(pnlTitle);

            var lblTitle = new System.Windows.Forms.Label();
            lblTitle.Text = "Register New Patient";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.AutoSize = true;
            pnlTitle.Controls.Add(lblTitle);

            // Names row
            var lblFN = new System.Windows.Forms.Label(); lblFN.Text = "FIRST NAME"; lblFN.Location = new System.Drawing.Point(50, 80); lblFN.AutoSize = true; lblFN.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblFN.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.Location = new System.Drawing.Point(50, 100); this.txtFirstName.Size = new System.Drawing.Size(175, 32); this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);

            var lblMN = new System.Windows.Forms.Label(); lblMN.Text = "MIDDLE NAME"; lblMN.Location = new System.Drawing.Point(235, 80); lblMN.AutoSize = true; lblMN.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblMN.ForeColor = System.Drawing.Color.DimGray;
            this.txtMiddleName.Location = new System.Drawing.Point(235, 100); this.txtMiddleName.Size = new System.Drawing.Size(175, 32); this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 11F);

            var lblLN = new System.Windows.Forms.Label(); lblLN.Text = "LAST NAME"; lblLN.Location = new System.Drawing.Point(420, 80); lblLN.AutoSize = true; lblLN.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblLN.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.Location = new System.Drawing.Point(420, 100); this.txtLastName.Size = new System.Drawing.Size(180, 32); this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11F);

            // Email, Username, Phone
            var lblE = new System.Windows.Forms.Label(); lblE.Text = "EMAIL ADDRESS"; lblE.Location = new System.Drawing.Point(50, 145); lblE.AutoSize = true; lblE.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblE.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(50, 165); this.txtEmail.Size = new System.Drawing.Size(550, 32); this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);

            var lblU = new System.Windows.Forms.Label(); lblU.Text = "USERNAME"; lblU.Location = new System.Drawing.Point(50, 210); lblU.AutoSize = true; lblU.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblU.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(50, 230); this.txtUsername.Size = new System.Drawing.Size(550, 32); this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);

            var lblP = new System.Windows.Forms.Label(); lblP.Text = "CONTACT NUMBER"; lblP.Location = new System.Drawing.Point(50, 275); lblP.AutoSize = true; lblP.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblP.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.Location = new System.Drawing.Point(50, 295); this.txtPhone.Size = new System.Drawing.Size(550, 32); this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);

            // DOB & Gender row
            var lblDOB = new System.Windows.Forms.Label(); lblDOB.Text = "DATE OF BIRTH"; lblDOB.Location = new System.Drawing.Point(50, 340); lblDOB.AutoSize = true; lblDOB.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblDOB.ForeColor = System.Drawing.Color.DimGray;
            this.dtpDOB.Location = new System.Drawing.Point(50, 360); this.dtpDOB.Size = new System.Drawing.Size(265, 32); this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 11F);
            
            var lblAge = new System.Windows.Forms.Label(); lblAge.Text = "AGE"; lblAge.Location = new System.Drawing.Point(335, 340); lblAge.AutoSize = true; lblAge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblAge.ForeColor = System.Drawing.Color.DimGray;
            this.txtAge.Location = new System.Drawing.Point(335, 360); this.txtAge.Size = new System.Drawing.Size(120, 32); this.txtAge.Font = new System.Drawing.Font("Segoe UI", 11F); this.txtAge.ReadOnly = true; this.txtAge.BackColor = System.Drawing.Color.White;

            var lblGender = new System.Windows.Forms.Label(); lblGender.Text = "GENDER"; lblGender.Location = new System.Drawing.Point(470, 340); lblGender.AutoSize = true; lblGender.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblGender.ForeColor = System.Drawing.Color.DimGray;
            this.cmbGender.Location = new System.Drawing.Point(470, 360); this.cmbGender.Size = new System.Drawing.Size(130, 32); this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 11F); this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            this.cmbGender.SelectedIndex = 0;

            // Attending Doctor
            var lblDoc = new System.Windows.Forms.Label(); lblDoc.Text = "ATTENDING DOCTOR"; lblDoc.Location = new System.Drawing.Point(50, 405); lblDoc.AutoSize = true; lblDoc.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblDoc.ForeColor = System.Drawing.Color.DimGray;
            this.txtAttendingDoctor.Location = new System.Drawing.Point(50, 425); this.txtAttendingDoctor.Size = new System.Drawing.Size(550, 32); this.txtAttendingDoctor.Font = new System.Drawing.Font("Segoe UI", 11F); this.txtAttendingDoctor.ReadOnly = true; this.txtAttendingDoctor.BackColor = System.Drawing.Color.White;

            // -- Emergency Contact Section --
            var lblEHeader = new System.Windows.Forms.Label();
            lblEHeader.Text = "EMERGENCY CONTACT";
            lblEHeader.Location = new System.Drawing.Point(50, 480);
            lblEHeader.AutoSize = true;
            lblEHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblEHeader.ForeColor = clrTeal;

            var lblEN = new System.Windows.Forms.Label(); lblEN.Text = "CONTACT NAME"; lblEN.Location = new System.Drawing.Point(50, 530); lblEN.AutoSize = true; lblEN.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblEN.ForeColor = System.Drawing.Color.DimGray;
            this.txtEName.Location = new System.Drawing.Point(50, 550); this.txtEName.Size = new System.Drawing.Size(550, 32); this.txtEName.Font = new System.Drawing.Font("Segoe UI", 11F);

            var lblER = new System.Windows.Forms.Label(); lblER.Text = "RELATIONSHIP"; lblER.Location = new System.Drawing.Point(50, 595); lblER.AutoSize = true; lblER.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblER.ForeColor = System.Drawing.Color.DimGray;
            this.txtERelation.Location = new System.Drawing.Point(50, 615); this.txtERelation.Size = new System.Drawing.Size(550, 32); this.txtERelation.Font = new System.Drawing.Font("Segoe UI", 11F);

            var lblEP = new System.Windows.Forms.Label(); lblEP.Text = "EMERGENCY PHONE"; lblEP.Location = new System.Drawing.Point(50, 660); lblEP.AutoSize = true; lblEP.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold); lblEP.ForeColor = System.Drawing.Color.DimGray;
            this.txtEPhone.Location = new System.Drawing.Point(50, 680); this.txtEPhone.Size = new System.Drawing.Size(550, 32); this.txtEPhone.Font = new System.Drawing.Font("Segoe UI", 11F);

            // Buttons
            this.btnSave.Text = "Register Patient";
            this.btnSave.Location = new System.Drawing.Point(350, 880);
            this.btnSave.Size = new System.Drawing.Size(250, 45);
            this.btnSave.BackColor = clrTeal;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatAppearance.BorderSize = 0;

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(230, 880);
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;

            this.Controls.Add(lblFN); this.Controls.Add(this.txtFirstName);
            this.Controls.Add(lblMN); this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(lblLN); this.Controls.Add(this.txtLastName);
            this.Controls.Add(lblE); this.Controls.Add(this.txtEmail);
            this.Controls.Add(lblU); this.Controls.Add(this.txtUsername);
            this.Controls.Add(lblP); this.Controls.Add(this.txtPhone);
            this.Controls.Add(lblDOB); this.Controls.Add(this.dtpDOB);
            this.Controls.Add(lblAge); this.Controls.Add(this.txtAge);
            this.Controls.Add(lblGender); this.Controls.Add(this.cmbGender);
            this.Controls.Add(lblDoc); this.Controls.Add(this.txtAttendingDoctor);
            this.Controls.Add(lblEHeader);
            this.Controls.Add(lblEN); this.Controls.Add(this.txtEName);
            this.Controls.Add(lblER); this.Controls.Add(this.txtERelation);
            this.Controls.Add(lblEP); this.Controls.Add(this.txtEPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.TextBox txtERelation;
        private System.Windows.Forms.TextBox txtEPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAttendingDoctor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;




        #endregion
    }
}