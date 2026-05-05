namespace elnet_recoverease
{
    partial class Edit_Patient_Profile
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmergencyHeader = new System.Windows.Forms.Label();
            this.lblEmergencyName = new System.Windows.Forms.Label();
            this.txtEmergencyName = new System.Windows.Forms.TextBox();
            this.lblEmergencyRel = new System.Windows.Forms.Label();
            this.txtEmergencyRelationship = new System.Windows.Forms.TextBox();
            this.lblEmergencyPhone = new System.Windows.Forms.Label();
            this.txtEmergencyPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(450, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Personal Info";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFullName.Location = new System.Drawing.Point(25, 75);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 15);
            this.lblFullName.TabIndex = 14;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFullName.Location = new System.Drawing.Point(25, 95);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(400, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhone.Location = new System.Drawing.Point(25, 135);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 15);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone.Location = new System.Drawing.Point(25, 155);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(400, 27);
            this.txtPhone.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAddress.Location = new System.Drawing.Point(25, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 15);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Home Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.Location = new System.Drawing.Point(25, 215);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 60);
            this.txtAddress.TabIndex = 4;
            // 
            // lblEmergencyHeader
            // 
            this.lblEmergencyHeader.AutoSize = true;
            this.lblEmergencyHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.lblEmergencyHeader.Location = new System.Drawing.Point(25, 295);
            this.lblEmergencyHeader.Name = "lblEmergencyHeader";
            this.lblEmergencyHeader.Size = new System.Drawing.Size(155, 19);
            this.lblEmergencyHeader.TabIndex = 5;
            this.lblEmergencyHeader.Text = "EMERGENCY CONTACT";
            // 
            // lblEmergencyName
            // 
            this.lblEmergencyName.AutoSize = true;
            this.lblEmergencyName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmergencyName.Location = new System.Drawing.Point(25, 325);
            this.lblEmergencyName.Name = "lblEmergencyName";
            this.lblEmergencyName.Size = new System.Drawing.Size(39, 15);
            this.lblEmergencyName.TabIndex = 6;
            this.lblEmergencyName.Text = "Name";
            // 
            // txtEmergencyName
            // 
            this.txtEmergencyName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmergencyName.Location = new System.Drawing.Point(25, 345);
            this.txtEmergencyName.Name = "txtEmergencyName";
            this.txtEmergencyName.Size = new System.Drawing.Size(400, 27);
            this.txtEmergencyName.TabIndex = 7;
            // 
            // lblEmergencyRel
            // 
            this.lblEmergencyRel.AutoSize = true;
            this.lblEmergencyRel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyRel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmergencyRel.Location = new System.Drawing.Point(25, 385);
            this.lblEmergencyRel.Name = "lblEmergencyRel";
            this.lblEmergencyRel.Size = new System.Drawing.Size(72, 15);
            this.lblEmergencyRel.TabIndex = 8;
            this.lblEmergencyRel.Text = "Relationship";
            // 
            // txtEmergencyRelationship
            // 
            this.txtEmergencyRelationship.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmergencyRelationship.Location = new System.Drawing.Point(25, 405);
            this.txtEmergencyRelationship.Name = "txtEmergencyRelationship";
            this.txtEmergencyRelationship.Size = new System.Drawing.Size(185, 27);
            this.txtEmergencyRelationship.TabIndex = 9;
            // 
            // lblEmergencyPhone
            // 
            this.lblEmergencyPhone.AutoSize = true;
            this.lblEmergencyPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmergencyPhone.Location = new System.Drawing.Point(240, 385);
            this.lblEmergencyPhone.Name = "lblEmergencyPhone";
            this.lblEmergencyPhone.Size = new System.Drawing.Size(41, 15);
            this.lblEmergencyPhone.TabIndex = 10;
            this.lblEmergencyPhone.Text = "Phone";
            // 
            // txtEmergencyPhone
            // 
            this.txtEmergencyPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmergencyPhone.Location = new System.Drawing.Point(240, 405);
            this.txtEmergencyPhone.Name = "txtEmergencyPhone";
            this.txtEmergencyPhone.Size = new System.Drawing.Size(185, 27);
            this.txtEmergencyPhone.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(325, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCancel.Location = new System.Drawing.Point(210, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Edit_Patient_Profile
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 530);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmergencyPhone);
            this.Controls.Add(this.lblEmergencyPhone);
            this.Controls.Add(this.txtEmergencyRelationship);
            this.Controls.Add(this.lblEmergencyRel);
            this.Controls.Add(this.txtEmergencyName);
            this.Controls.Add(this.lblEmergencyName);
            this.Controls.Add(this.lblEmergencyHeader);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Patient_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Profile";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmergencyHeader;
        private System.Windows.Forms.Label lblEmergencyName;
        private System.Windows.Forms.TextBox txtEmergencyName;
        private System.Windows.Forms.Label lblEmergencyRel;
        private System.Windows.Forms.TextBox txtEmergencyRelationship;
        private System.Windows.Forms.Label lblEmergencyPhone;
        private System.Windows.Forms.TextBox txtEmergencyPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlHeader;
    }
}
