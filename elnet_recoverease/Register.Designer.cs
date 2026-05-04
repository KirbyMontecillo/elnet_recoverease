namespace elnet_recoverease
{
    partial class Register
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
            lblSecure = new Label();
            pnlRight = new Panel();
            lblFormTitle = new Label();
            lblFormSub = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPass = new Label();
            txtConfirmPass = new TextBox();
            lblError = new Label();
            btnCreateAccount = new Button();
            lblHaveAccount = new Label();
            btnSignIn = new Button();
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
            pnlLeft.Controls.Add(lblSecure);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(360, 660);
            pnlLeft.TabIndex = 0;
            // 
            // pnlLogoCard
            // 
            pnlLogoCard.BackColor = Color.White;
            pnlLogoCard.BorderStyle = BorderStyle.FixedSingle;
            pnlLogoCard.Controls.Add(picLogo);
            pnlLogoCard.Location = new Point(35, 35);
            pnlLogoCard.Name = "pnlLogoCard";
            pnlLogoCard.Size = new Size(290, 100);
            pnlLogoCard.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
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
            lblB1.Text = "  •   Personal details";
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
            lblB2.Text = "  •   Contact information";
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
            lblB3.Text = "  •   Secure account setup";
            // 
            // lblSecure
            // 
            lblSecure.BackColor = Color.Transparent;
            lblSecure.Font = new Font("Segoe UI", 8.5F);
            lblSecure.ForeColor = Color.DarkGray;
            lblSecure.Location = new Point(35, 602);
            lblSecure.Name = "lblSecure";
            lblSecure.Size = new Size(290, 40);
            lblSecure.TabIndex = 5;
            lblSecure.Text = "Secure healthcare platform for patients and clinical staff.";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lblFormTitle);
            pnlRight.Controls.Add(lblFormSub);
            pnlRight.Controls.Add(lblFirstName);
            pnlRight.Controls.Add(txtFirstName);
            pnlRight.Controls.Add(lblLastName);
            pnlRight.Controls.Add(txtLastName);
            pnlRight.Controls.Add(lblEmail);
            pnlRight.Controls.Add(txtEmail);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(lblConfirmPass);
            pnlRight.Controls.Add(txtConfirmPass);
            pnlRight.Controls.Add(lblError);
            pnlRight.Controls.Add(btnCreateAccount);
            pnlRight.Controls.Add(lblHaveAccount);
            pnlRight.Controls.Add(btnSignIn);
            pnlRight.Location = new Point(360, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(740, 660);
            pnlRight.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(27, 58, 107);
            lblFormTitle.Location = new Point(70, 50);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(580, 34);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Create account";
            // 
            // lblFormSub
            // 
            lblFormSub.Font = new Font("Segoe UI", 10F);
            lblFormSub.ForeColor = Color.Gray;
            lblFormSub.Location = new Point(70, 88);
            lblFormSub.Name = "lblFormSub";
            lblFormSub.Size = new Size(580, 20);
            lblFormSub.TabIndex = 1;
            lblFormSub.Text = "Register to access the patient care portal.";
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.DimGray;
            lblFirstName.Location = new Point(70, 130);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(270, 18);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "FIRST NAME";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 11F);
            txtFirstName.Location = new Point(70, 150);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(278, 32);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLastName.ForeColor = Color.DimGray;
            lblLastName.Location = new Point(362, 130);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(270, 18);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "LAST NAME";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 11F);
            txtLastName.Location = new Point(362, 150);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(278, 32);
            txtLastName.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(70, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(580, 18);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "EMAIL ADDRESS";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(70, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(580, 32);
            txtEmail.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(70, 278);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(270, 18);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(70, 298);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(278, 32);
            txtPassword.TabIndex = 9;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblConfirmPass.ForeColor = Color.DimGray;
            lblConfirmPass.Location = new Point(362, 278);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(270, 18);
            lblConfirmPass.TabIndex = 10;
            lblConfirmPass.Text = "CONFIRM PASSWORD";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BackColor = Color.White;
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Segoe UI", 11F);
            txtConfirmPass.Location = new Point(362, 298);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '●';
            txtConfirmPass.Size = new Size(278, 32);
            txtConfirmPass.TabIndex = 11;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 8.5F);
            lblError.ForeColor = Color.Crimson;
            lblError.Location = new Point(70, 345);
            lblError.Name = "lblError";
            lblError.Size = new Size(580, 18);
            lblError.TabIndex = 12;
            lblError.Visible = false;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.White;
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.FlatAppearance.BorderColor = Color.FromArgb(27, 58, 107);
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateAccount.ForeColor = Color.FromArgb(27, 58, 107);
            btnCreateAccount.Location = new Point(70, 368);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(580, 46);
            btnCreateAccount.TabIndex = 13;
            btnCreateAccount.Text = "Create account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click_1;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.Font = new Font("Segoe UI", 10F);
            lblHaveAccount.ForeColor = Color.Gray;
            lblHaveAccount.Location = new Point(158, 435);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(215, 22);
            lblHaveAccount.TabIndex = 14;
            lblHaveAccount.Text = "Already have an account?";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.White;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderColor = Color.FromArgb(27, 58, 107);
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.FromArgb(27, 58, 107);
            btnSignIn.Location = new Point(378, 429);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(140, 34);
            btnSignIn.TabIndex = 15;
            btnSignIn.Text = "Sign in here";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            BackColor = Color.White;
            ClientSize = new Size(1100, 660);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1024, 600);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecoverEase — Create Account";
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
        private Label lblSecure;
        private Panel pnlRight;
        private Label lblFormTitle;
        private Label lblFormSub;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPass;
        private TextBox txtConfirmPass;
        private Label lblError;
        private Button btnCreateAccount;
        private Label lblHaveAccount;
        private Button btnSignIn;
    }
}