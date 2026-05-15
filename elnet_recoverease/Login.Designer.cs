namespace elnet_recoverease
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            pnlLogoCard = new Panel();
            picLogo = new PictureBox();
            pnlDivider = new Panel();
            lblB1 = new Label();
            lblB2 = new Label();
            lblB3 = new Label();
            lblB4 = new Label();
            lblB5 = new Label();
            lblSecure = new Label();
            pnlRight = new Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblEmailLabel = new Label();
            txtEmail = new TextBox();
            lblPassLabel = new Label();
            txtPassword = new TextBox();
            lblError = new Label();
            btnLogin = new Button();
            pnlLeft.SuspendLayout();
            pnlLogoCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(238, 243, 247);
            pnlLeft.Controls.Add(pnlLogoCard);
            pnlLeft.Controls.Add(pnlDivider);
            pnlLeft.Controls.Add(lblB1);
            pnlLeft.Controls.Add(lblB2);
            pnlLeft.Controls.Add(lblB3);
            pnlLeft.Controls.Add(lblB4);
            pnlLeft.Controls.Add(lblB5);
            pnlLeft.Controls.Add(lblSecure);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(360, 620);
            pnlLeft.TabIndex = 0;
            // 
            // pnlLogoCard
            // 
            pnlLogoCard.BackColor = Color.Transparent;
            pnlLogoCard.Controls.Add(picLogo);
            pnlLogoCard.Location = new Point(35, 35);
            pnlLogoCard.Name = "pnlLogoCard";
            pnlLogoCard.Size = new Size(290, 100);
            pnlLogoCard.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.recoverease_logo_removebg_preview;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(286, 96);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(208, 219, 232);
            pnlDivider.Location = new Point(35, 150);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(290, 1);
            pnlDivider.TabIndex = 1;
            // 
            // lblB1
            // 
            lblB1.BackColor = Color.Transparent;
            lblB1.Font = new Font("Segoe UI", 10F);
            lblB1.ForeColor = Color.FromArgb(68, 68, 68);
            lblB1.Location = new Point(35, 168);
            lblB1.Name = "lblB1";
            lblB1.Size = new Size(290, 22);
            lblB1.TabIndex = 2;
            lblB1.Text = "  •   Medication tracking";
            // 
            // lblB2
            // 
            lblB2.BackColor = Color.Transparent;
            lblB2.Font = new Font("Segoe UI", 10F);
            lblB2.ForeColor = Color.FromArgb(68, 68, 68);
            lblB2.Location = new Point(35, 196);
            lblB2.Name = "lblB2";
            lblB2.Size = new Size(290, 22);
            lblB2.TabIndex = 3;
            lblB2.Text = "  •   Treatment plans";
            // 
            // lblB3
            // 
            lblB3.BackColor = Color.Transparent;
            lblB3.Font = new Font("Segoe UI", 10F);
            lblB3.ForeColor = Color.FromArgb(68, 68, 68);
            lblB3.Location = new Point(35, 224);
            lblB3.Name = "lblB3";
            lblB3.Size = new Size(290, 22);
            lblB3.TabIndex = 4;
            lblB3.Text = "  •   Follow-up scheduling";
            // 
            // lblB4
            // 
            lblB4.BackColor = Color.Transparent;
            lblB4.Font = new Font("Segoe UI", 10F);
            lblB4.ForeColor = Color.FromArgb(68, 68, 68);
            lblB4.Location = new Point(35, 252);
            lblB4.Name = "lblB4";
            lblB4.Size = new Size(290, 22);
            lblB4.TabIndex = 5;
            lblB4.Text = "  •   Recovery reports";
            // 
            // lblB5
            // 
            lblB5.BackColor = Color.Transparent;
            lblB5.Font = new Font("Segoe UI", 10F);
            lblB5.ForeColor = Color.FromArgb(68, 68, 68);
            lblB5.Location = new Point(35, 280);
            lblB5.Name = "lblB5";
            lblB5.Size = new Size(290, 22);
            lblB5.TabIndex = 6;
            lblB5.Text = "  •   Appointment reminders";
            // 
            // lblSecure
            // 
            lblSecure.BackColor = Color.Transparent;
            lblSecure.Font = new Font("Segoe UI", 8.5F);
            lblSecure.ForeColor = Color.DarkGray;
            lblSecure.Location = new Point(35, 560);
            lblSecure.Name = "lblSecure";
            lblSecure.Size = new Size(290, 40);
            lblSecure.TabIndex = 7;
            lblSecure.Text = "Secure healthcare platform for patients and clinical staff.";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Controls.Add(lblSubtitle);
            pnlRight.Controls.Add(lblEmailLabel);
            pnlRight.Controls.Add(txtEmail);
            pnlRight.Controls.Add(lblPassLabel);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(lblError);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Location = new Point(360, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(740, 620);
            pnlRight.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(27, 58, 107);
            lblWelcome.Location = new Point(80, 97);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(580, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome ";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(80, 152);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(580, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign in to your RecoverEase account to continue.";
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmailLabel.ForeColor = Color.DimGray;
            lblEmailLabel.Location = new Point(80, 205);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(580, 18);
            lblEmailLabel.TabIndex = 2;
            lblEmailLabel.Text = "USERNAME";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(80, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(580, 32);
            txtEmail.TabIndex = 3;
            // 
            // lblPassLabel
            // 
            lblPassLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPassLabel.ForeColor = Color.DimGray;
            lblPassLabel.Location = new Point(80, 280);
            lblPassLabel.Name = "lblPassLabel";
            lblPassLabel.Size = new Size(580, 18);
            lblPassLabel.TabIndex = 4;
            lblPassLabel.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(80, 301);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(580, 32);
            txtPassword.TabIndex = 5;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 8.5F);
            lblError.ForeColor = Color.Crimson;
            lblError.Location = new Point(80, 376);
            lblError.Name = "lblError";
            lblError.Size = new Size(580, 18);
            lblError.TabIndex = 6;
            lblError.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(27, 58, 107);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(27, 58, 107);
            btnLogin.Location = new Point(80, 400);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(580, 46);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            BackColor = Color.White;
            ClientSize = new Size(1100, 620);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1024, 600);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecoverEase — Login";

            pnlLeft.ResumeLayout(false);
            pnlLogoCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlLogoCard;
        private PictureBox picLogo;
        private Panel pnlDivider;
        private Label lblB1;
        private Label lblB2;
        private Label lblB3;
        private Label lblB4;
        private Label lblB5;
        private Label lblSecure;
        private Panel pnlRight;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblEmailLabel;
        private TextBox txtEmail;
        private Label lblPassLabel;
        private TextBox txtPassword;
        private Label lblError;
        private Button btnLogin;
    }
}
