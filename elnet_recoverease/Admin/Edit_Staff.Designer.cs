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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblDateHired = new System.Windows.Forms.Label();
            this.dtpDateHired = new System.Windows.Forms.DateTimePicker();
            this.pnlRoleSection = new System.Windows.Forms.Panel();
            this.lblRoleHeader = new System.Windows.Forms.Label();
            this.lblRoleLabel = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.pnlAccountSection = new System.Windows.Forms.Panel();
            this.lblAccountHeader = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblRequired = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlRoleSection.SuspendLayout();
            this.pnlAccountSection.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            
            // Colors & Fonts
            System.Drawing.Color clrMain = System.Drawing.Color.FromArgb(45, 55, 72);
            System.Drawing.Color clrSec = System.Drawing.Color.FromArgb(113, 128, 150);
            System.Drawing.Color clrBorder = System.Drawing.Color.FromArgb(226, 232, 240);
            System.Drawing.Font fntLabel = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fntInput = new System.Drawing.Font("Segoe UI", 10.5F);

            // Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 85;
            this.lblTitle.Text = "Edit staff details"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 14F, System.Drawing.FontStyle.Bold); this.lblTitle.Location = new System.Drawing.Point(24, 18); this.lblTitle.AutoSize = true;
            this.lblSubtitle.Text = "Update the information for this staff member"; this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F); this.lblSubtitle.ForeColor = clrSec; this.lblSubtitle.Location = new System.Drawing.Point(24, 48); this.lblSubtitle.AutoSize = true;
            this.btnClose.Text = "✕"; this.btnClose.Size = new System.Drawing.Size(32, 32); this.btnClose.Location = new System.Drawing.Point(490, 18); this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0;
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblSubtitle, this.btnClose });
            this.pnlDivider1.Dock = System.Windows.Forms.DockStyle.Top; this.pnlDivider1.Height = 1; this.pnlDivider1.BackColor = clrBorder;

            // Fields
            this.lblFirstName.Text = "First name *"; this.lblFirstName.Font = fntLabel; this.lblFirstName.ForeColor = clrMain; this.lblFirstName.Location = new System.Drawing.Point(24, 100); this.lblFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(24, 122); this.txtFirstName.Width = 230; this.txtFirstName.Font = fntInput; this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastName.Text = "Last name *"; this.lblLastName.Font = fntLabel; this.lblLastName.ForeColor = clrMain; this.lblLastName.Location = new System.Drawing.Point(274, 100); this.lblLastName.AutoSize = true;
            this.txtLastName.Location = new System.Drawing.Point(274, 122); this.txtLastName.Width = 230; this.txtLastName.Font = fntInput; this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Text = "Email address *"; this.lblEmail.Font = fntLabel; this.lblEmail.ForeColor = clrMain; this.lblEmail.Location = new System.Drawing.Point(24, 165); this.lblEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(24, 187); this.txtEmail.Width = 480; this.txtEmail.Font = fntInput; this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContact.Text = "Contact number"; this.lblContact.Font = fntLabel; this.lblContact.ForeColor = clrMain; this.lblContact.Location = new System.Drawing.Point(24, 230); this.lblContact.AutoSize = true;
            this.txtContact.Location = new System.Drawing.Point(24, 252); this.txtContact.Width = 230; this.txtContact.Font = fntInput; this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateHired.Text = "Date hired"; this.lblDateHired.Font = fntLabel; this.lblDateHired.Location = new System.Drawing.Point(274, 230); this.lblDateHired.AutoSize = true;
            this.dtpDateHired.Location = new System.Drawing.Point(274, 252); this.dtpDateHired.Width = 230; this.dtpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Role Section
            this.pnlRoleSection.Location = new System.Drawing.Point(0, 300); this.pnlRoleSection.Size = new System.Drawing.Size(540, 135);
            this.lblRoleHeader.Text = "───────── ROLE & SPECIALTY ─────────"; this.lblRoleHeader.ForeColor = clrBorder; this.lblRoleHeader.Location = new System.Drawing.Point(0, 5); this.lblRoleHeader.Width = 540; this.lblRoleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRoleLabel.Text = "Role *"; this.lblRoleLabel.Font = fntLabel; this.lblRoleLabel.Location = new System.Drawing.Point(24, 35);
            this.cmbRole.Location = new System.Drawing.Point(24, 57); this.cmbRole.Width = 480; this.cmbRole.Font = fntInput; this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Doctor", "Admin" });
            this.lblSpecialty.Text = "Specialty / area"; this.lblSpecialty.Font = fntLabel; this.lblSpecialty.Location = new System.Drawing.Point(24, 90);
            this.cmbSpecialty.Location = new System.Drawing.Point(24, 112); this.cmbSpecialty.Width = 480; this.cmbSpecialty.Font = fntInput; this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.Items.AddRange(new object[] { "General Medicine", "Surgery", "Cardiology", "Orthopedics", "Pediatrics" });
            this.txtSpecialty.Location = new System.Drawing.Point(24, 112); this.txtSpecialty.Width = 480; this.txtSpecialty.Font = fntInput; this.txtSpecialty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoleSection.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblRoleHeader, this.lblRoleLabel, this.cmbRole, this.lblSpecialty, this.txtSpecialty, this.cmbSpecialty });

            // Account Section
            this.pnlAccountSection.Location = new System.Drawing.Point(0, 440); this.pnlAccountSection.Size = new System.Drawing.Size(540, 75);
            this.lblAccountHeader.Text = "────────────── ACCOUNT ──────────────"; this.lblAccountHeader.ForeColor = clrBorder; this.lblAccountHeader.Location = new System.Drawing.Point(0, 5); this.lblAccountHeader.Width = 540; this.lblAccountHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.Text = "Username *"; this.lblUsername.Font = fntLabel; this.lblUsername.Location = new System.Drawing.Point(24, 30);
            this.txtUsername.Location = new System.Drawing.Point(24, 52); this.txtUsername.Width = 220; this.txtUsername.Font = fntInput; this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassword.Text = "Password *"; this.lblPassword.Font = fntLabel; this.lblPassword.Location = new System.Drawing.Point(274, 30);
            this.txtPassword.Location = new System.Drawing.Point(274, 52); this.txtPassword.Width = 230; this.txtPassword.Font = fntInput; this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.UseSystemPasswordChar = true;
            this.pnlAccountSection.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblAccountHeader, this.lblUsername, this.txtUsername, this.lblPassword, this.txtPassword });

            // Footer
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlFooter.Height = 75;
            this.lblRequired.Text = "* Required fields"; this.lblRequired.ForeColor = System.Drawing.Color.IndianRed; this.lblRequired.Location = new System.Drawing.Point(24, 28); this.lblRequired.AutoSize = true;
            this.btnCancel.Text = "Cancel"; this.btnCancel.Location = new System.Drawing.Point(290, 20); this.btnCancel.Size = new System.Drawing.Size(90, 36); this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Text = "Save changes"; // CHANGED BUTTON TEXT AS REQUESTED
            this.btnSave.Location = new System.Drawing.Point(390, 20); this.btnSave.Size = new System.Drawing.Size(125, 36); this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 168, 168); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Bold", 9.5F, System.Drawing.FontStyle.Bold);
            this.pnlFooter.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblRequired, this.btnCancel, this.btnSave });

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pnlFooter, this.pnlAccountSection, this.pnlRoleSection, this.dtpDateHired, this.lblDateHired, this.txtContact, this.lblContact, this.txtEmail, this.lblEmail, this.txtLastName, this.lblLastName, this.txtFirstName, this.lblFirstName, this.pnlDivider1, this.pnlHeader });
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlRoleSection.ResumeLayout(false);
            this.pnlRoleSection.PerformLayout();
            this.pnlAccountSection.ResumeLayout(false);
            this.pnlAccountSection.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}