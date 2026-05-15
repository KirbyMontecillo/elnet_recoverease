namespace elnet_recoverease
{
    partial class Change_Password
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
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // Colors (Base UI Palette)
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrMain = System.Drawing.Color.FromArgb(45, 55, 72);
            System.Drawing.Color clrSec = System.Drawing.Color.FromArgb(113, 128, 150);
            System.Drawing.Color clrBorder = System.Drawing.Color.FromArgb(226, 232, 240);
            System.Drawing.Font fntTitle = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fntLabel = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fntInput = new System.Drawing.Font("Segoe UI", 11F);

            // Header
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 85;
            this.lblTitle.Text = "Setup New Password"; this.lblTitle.Font = fntTitle; this.lblTitle.Location = new System.Drawing.Point(24, 18); this.lblTitle.AutoSize = true;
            this.lblSubtitle.Text = "Please update your password for security"; this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblSubtitle.ForeColor = clrSec; this.lblSubtitle.Location = new System.Drawing.Point(24, 48); this.lblSubtitle.AutoSize = true;
            this.btnClose.Text = "✕"; this.btnClose.Size = new System.Drawing.Size(32, 32); this.btnClose.Location = new System.Drawing.Point(360, 18); this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblSubtitle, this.btnClose });
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top; this.pnlDivider.Height = 1; this.pnlDivider.BackColor = clrBorder;

            // Fields
            this.lblOldPass.Text = "Current Password"; this.lblOldPass.Font = fntLabel; this.lblOldPass.ForeColor = clrMain; this.lblOldPass.Location = new System.Drawing.Point(24, 105); this.lblOldPass.AutoSize = true;
            this.txtOldPass.Location = new System.Drawing.Point(24, 127); this.txtOldPass.Width = 350; this.txtOldPass.Font = fntInput; this.txtOldPass.UseSystemPasswordChar = true; this.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblNewPass.Text = "New Password"; this.lblNewPass.Font = fntLabel; this.lblNewPass.ForeColor = clrMain; this.lblNewPass.Location = new System.Drawing.Point(24, 175); this.lblNewPass.AutoSize = true;
            this.txtNewPass.Location = new System.Drawing.Point(24, 197); this.txtNewPass.Width = 350; this.txtNewPass.Font = fntInput; this.txtNewPass.UseSystemPasswordChar = true; this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblConfirmPass.Text = "Confirm New Password"; this.lblConfirmPass.Font = fntLabel; this.lblConfirmPass.ForeColor = clrMain; this.lblConfirmPass.Location = new System.Drawing.Point(24, 245); this.lblConfirmPass.AutoSize = true;
            this.txtConfirmPass.Location = new System.Drawing.Point(24, 267); this.txtConfirmPass.Width = 350; this.txtConfirmPass.Font = fntInput; this.txtConfirmPass.UseSystemPasswordChar = true; this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Footer
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlFooter.Height = 85;
            this.btnUpdate.Text = "Update Password"; this.btnUpdate.BackColor = clrTeal; this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnUpdate.FlatAppearance.BorderSize = 0; this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnUpdate.Location = new System.Drawing.Point(210, 22); this.btnUpdate.Size = new System.Drawing.Size(164, 40); this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Text = "Cancel"; this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnCancel.FlatAppearance.BorderColor = clrBorder; this.btnCancel.Location = new System.Drawing.Point(110, 22); this.btnCancel.Size = new System.Drawing.Size(90, 40); this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFooter.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnUpdate, this.btnCancel });

            // Form Properties (Shrinked height)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 410);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlHeader);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}
