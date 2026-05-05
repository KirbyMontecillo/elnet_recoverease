namespace elnet_recoverease
{
    partial class Change_Password
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
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();

            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(20, 30, 70);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 150, 150);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(245, 247, 250);

            this.SuspendLayout();

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Text = "Change Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.BackColor = clrBg;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Title
            var lblHeader = new System.Windows.Forms.Label();
            lblHeader.Text = "Change Password";
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = clrNavy;
            lblHeader.Location = new System.Drawing.Point(40, 30);
            lblHeader.AutoSize = true;

            var lblSub = new System.Windows.Forms.Label();
            lblSub.Text = "You are using a temporary password. Please update it.";
            lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSub.ForeColor = System.Drawing.Color.DimGray;
            lblSub.Location = new System.Drawing.Point(40, 60);
            lblSub.AutoSize = true;

            // Labels
            var lblO = new System.Windows.Forms.Label(); lblO.Text = "CURRENT PASSWORD"; lblO.Location = new System.Drawing.Point(40, 110); lblO.AutoSize = true; lblO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); lblO.ForeColor = System.Drawing.Color.DimGray;
            var lblN = new System.Windows.Forms.Label(); lblN.Text = "NEW PASSWORD"; lblN.Location = new System.Drawing.Point(40, 200); lblN.AutoSize = true; lblN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); lblN.ForeColor = System.Drawing.Color.DimGray;
            var lblC = new System.Windows.Forms.Label(); lblC.Text = "CONFIRM NEW PASSWORD"; lblC.Location = new System.Drawing.Point(40, 290); lblC.AutoSize = true; lblC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); lblC.ForeColor = System.Drawing.Color.DimGray;

            // Textboxes
            this.txtOldPass.Location = new System.Drawing.Point(40, 130); this.txtOldPass.Size = new System.Drawing.Size(370, 32); this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 11F); this.txtOldPass.PasswordChar = '●';
            this.txtNewPass.Location = new System.Drawing.Point(40, 220); this.txtNewPass.Size = new System.Drawing.Size(370, 32); this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 11F); this.txtNewPass.PasswordChar = '●';
            this.txtConfirmPass.Location = new System.Drawing.Point(40, 310); this.txtConfirmPass.Size = new System.Drawing.Size(370, 32); this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F); this.txtConfirmPass.PasswordChar = '●';

            // Button
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.Location = new System.Drawing.Point(40, 390);
            this.btnUpdate.Size = new System.Drawing.Size(370, 45);
            this.btnUpdate.BackColor = clrTeal;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.FlatAppearance.BorderSize = 0;

            this.Controls.Add(lblHeader);
            this.Controls.Add(lblSub);
            this.Controls.Add(lblO); this.Controls.Add(this.txtOldPass);
            this.Controls.Add(lblN); this.Controls.Add(this.txtNewPass);
            this.Controls.Add(lblC); this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.btnUpdate);

            this.ResumeLayout(false);
            this.PerformLayout();
        }



        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnUpdate;


        #endregion
    }
}