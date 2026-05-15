namespace elnet_recoverease.Admin
{
    partial class Edit_Staff
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnClose = new Button();
            pnlDivider1 = new Panel();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblDateHired = new Label();
            dtpDateHired = new DateTimePicker();
            pnlRoleSection = new Panel();
            lblRoleHeader = new Label();
            lblRoleLabel = new Label();
            cmbRole = new ComboBox();
            lblSpecialty = new Label();
            txtSpecialty = new TextBox();
            cmbSpecialty = new ComboBox();
            pnlAccountSection = new Panel();
            lblAccountHeader = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            pnlFooter = new Panel();
            lblRequired = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            pnlRoleSection.SuspendLayout();
            pnlAccountSection.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(540, 85);
            pnlHeader.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit staff details";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(113, 128, 150);
            lblSubtitle.Location = new Point(24, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(308, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Update the information for this staff member";
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(490, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            // 
            // pnlDivider1
            // 
            pnlDivider1.BackColor = Color.FromArgb(226, 232, 240);
            pnlDivider1.Dock = DockStyle.Top;
            pnlDivider1.Location = new Point(0, 85);
            pnlDivider1.Name = "pnlDivider1";
            pnlDivider1.Size = new Size(540, 1);
            pnlDivider1.TabIndex = 13;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.FromArgb(45, 55, 72);
            lblFirstName.Location = new Point(24, 100);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(91, 20);
            lblFirstName.TabIndex = 12;
            lblFirstName.Text = "First name *";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(24, 122);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 29);
            txtFirstName.TabIndex = 11;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLastName.ForeColor = Color.FromArgb(45, 55, 72);
            lblLastName.Location = new Point(274, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 20);
            lblLastName.TabIndex = 10;
            lblLastName.Text = "Last name *";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(274, 122);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 29);
            txtLastName.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 55, 72);
            lblEmail.Location = new Point(24, 165);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(113, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email address *";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(24, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(480, 29);
            txtEmail.TabIndex = 7;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(45, 55, 72);
            lblContact.Location = new Point(24, 230);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(119, 20);
            lblContact.TabIndex = 6;
            lblContact.Text = "Contact number";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 9.5F);
            txtContact.Location = new Point(24, 252);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(230, 29);
            txtContact.TabIndex = 5;
            // 
            // lblDateHired
            // 
            lblDateHired.AutoSize = true;
            lblDateHired.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDateHired.Location = new Point(274, 230);
            lblDateHired.Name = "lblDateHired";
            lblDateHired.Size = new Size(81, 20);
            lblDateHired.TabIndex = 4;
            lblDateHired.Text = "Date hired";
            // 
            // dtpDateHired
            // 
            dtpDateHired.Format = DateTimePickerFormat.Short;
            dtpDateHired.Location = new Point(274, 252);
            dtpDateHired.Name = "dtpDateHired";
            dtpDateHired.Size = new Size(230, 27);
            dtpDateHired.TabIndex = 3;
            // 
            // pnlRoleSection
            // 
            pnlRoleSection.Controls.Add(lblRoleHeader);
            pnlRoleSection.Controls.Add(lblRoleLabel);
            pnlRoleSection.Controls.Add(cmbRole);
            pnlRoleSection.Controls.Add(lblSpecialty);
            pnlRoleSection.Controls.Add(txtSpecialty);
            pnlRoleSection.Controls.Add(cmbSpecialty);
            pnlRoleSection.Location = new Point(0, 300);
            pnlRoleSection.Name = "pnlRoleSection";
            pnlRoleSection.Size = new Size(540, 150);
            pnlRoleSection.TabIndex = 2;
            // 
            // lblRoleHeader
            // 
            lblRoleHeader.ForeColor = Color.FromArgb(226, 232, 240);
            lblRoleHeader.Location = new Point(0, 5);
            lblRoleHeader.Name = "lblRoleHeader";
            lblRoleHeader.Size = new Size(540, 23);
            lblRoleHeader.TabIndex = 0;
            lblRoleHeader.Text = "───────── ROLE & SPECIALTY ─────────";
            lblRoleHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoleLabel
            // 
            lblRoleLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRoleLabel.Location = new Point(24, 28);
            lblRoleLabel.Name = "lblRoleLabel";
            lblRoleLabel.Size = new Size(100, 23);
            lblRoleLabel.TabIndex = 1;
            lblRoleLabel.Text = "Role *";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.Items.AddRange(new object[] { "Doctor", "Admin" });
            cmbRole.Location = new Point(24, 57);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(480, 29);
            cmbRole.TabIndex = 2;
            // 
            // lblSpecialty
            // 
            lblSpecialty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSpecialty.Location = new Point(24, 89);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(100, 23);
            lblSpecialty.TabIndex = 3;
            lblSpecialty.Text = "Specialty / area";
            // 
            // txtSpecialty
            // 
            txtSpecialty.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialty.Font = new Font("Segoe UI", 9.5F);
            txtSpecialty.Location = new Point(24, 117);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(480, 29);
            txtSpecialty.TabIndex = 4;
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.Font = new Font("Segoe UI", 9.5F);
            cmbSpecialty.Items.AddRange(new object[] { "General Medicine", "Surgery", "Cardiology", "Orthopedics", "Pediatrics" });
            cmbSpecialty.Location = new Point(24, 117);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(480, 29);
            cmbSpecialty.TabIndex = 5;
            // 
            // pnlAccountSection
            // 
            pnlAccountSection.Controls.Add(lblAccountHeader);
            pnlAccountSection.Controls.Add(lblUsername);
            pnlAccountSection.Controls.Add(txtUsername);
            pnlAccountSection.Location = new Point(0, 460);
            pnlAccountSection.Name = "pnlAccountSection";
            pnlAccountSection.Size = new Size(540, 90);
            pnlAccountSection.TabIndex = 1;
            // 
            // lblAccountHeader
            // 
            lblAccountHeader.ForeColor = Color.FromArgb(226, 232, 240);
            lblAccountHeader.Location = new Point(0, 5);
            lblAccountHeader.Name = "lblAccountHeader";
            lblAccountHeader.Size = new Size(540, 23);
            lblAccountHeader.TabIndex = 0;
            lblAccountHeader.Text = "────────────── ACCOUNT ──────────────";
            lblAccountHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsername.Location = new Point(24, 28);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username *";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 9.5F);
            txtUsername.Location = new Point(24, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(480, 29);
            txtUsername.TabIndex = 2;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(lblRequired);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 575);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(540, 75);
            pnlFooter.TabIndex = 0;
            // 
            // lblRequired
            // 
            lblRequired.AutoSize = true;
            lblRequired.ForeColor = Color.IndianRed;
            lblRequired.Location = new Point(24, 28);
            lblRequired.Name = "lblRequired";
            lblRequired.Size = new Size(119, 20);
            lblRequired.TabIndex = 0;
            lblRequired.Text = "* Required fields";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(290, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 168, 168);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(390, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Edit_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(540, 650);
            Controls.Add(pnlFooter);
            Controls.Add(pnlAccountSection);
            Controls.Add(pnlRoleSection);
            Controls.Add(dtpDateHired);
            Controls.Add(lblDateHired);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(pnlDivider1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit_Staff";
            StartPosition = FormStartPosition.CenterParent;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRoleSection.ResumeLayout(false);
            pnlRoleSection.PerformLayout();
            pnlAccountSection.ResumeLayout(false);
            pnlAccountSection.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblDateHired;
        private System.Windows.Forms.DateTimePicker dtpDateHired;
        private System.Windows.Forms.Panel pnlRoleSection;
        private System.Windows.Forms.Label lblRoleHeader;
        private System.Windows.Forms.Label lblRoleLabel;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Panel pnlAccountSection;
        private System.Windows.Forms.Label lblAccountHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
