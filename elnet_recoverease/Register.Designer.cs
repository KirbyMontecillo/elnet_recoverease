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

            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();

            // ── FORM ──────────────────────────────────────────────
            this.Text = "RecoverEase — Create Account";
            this.ClientSize = new Size(1100, 660);
            this.MinimumSize = new Size(1024, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9F);

            // ── LEFT PANEL ────────────────────────────────────────
            pnlLeft.Size = new Size(360, 660);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.BackColor = ColorTranslator.FromHtml("#EEF3F7");

            pnlLogoCard.Size = new Size(290, 100);
            pnlLogoCard.Location = new Point(35, 35);
            pnlLogoCard.BackColor = Color.White;
            pnlLogoCard.BorderStyle = BorderStyle.FixedSingle;

            picLogo.Size = new Size(286, 96);
            picLogo.Location = new Point(0, 0);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.BackColor = Color.White;
            picLogo.Image = Properties.Resources.recoverease_logo_removebg_preview;

            pnlLogoCard.Controls.Add(picLogo);

            pnlDivider.Size = new Size(290, 1);
            pnlDivider.Location = new Point(35, 150);
            pnlDivider.BackColor = ColorTranslator.FromHtml("#D0DBE8");

            lblB1.Text = "  \u2022   Personal details";
            lblB1.Size = new Size(290, 22);
            lblB1.Location = new Point(35, 168);
            lblB1.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB1.Font = new Font("Segoe UI", 10F);
            lblB1.BackColor = Color.Transparent;

            lblB2.Text = "  \u2022   Contact information";
            lblB2.Size = new Size(290, 22);
            lblB2.Location = new Point(35, 196);
            lblB2.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB2.Font = new Font("Segoe UI", 10F);
            lblB2.BackColor = Color.Transparent;

            lblB3.Text = "  \u2022   Secure account setup";
            lblB3.Size = new Size(290, 22);
            lblB3.Location = new Point(35, 224);
            lblB3.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB3.Font = new Font("Segoe UI", 10F);
            lblB3.BackColor = Color.Transparent;

            lblSecure.Text = "Secure healthcare platform for patients and clinical staff.";
            lblSecure.Size = new Size(290, 40);
            lblSecure.Location = new Point(35, 602);
            lblSecure.ForeColor = Color.DarkGray;
            lblSecure.Font = new Font("Segoe UI", 8.5F);
            lblSecure.BackColor = Color.Transparent;

            pnlLeft.Controls.AddRange(new Control[] {
                pnlLogoCard, pnlDivider,
                lblB1, lblB2, lblB3,
                lblSecure
            });

            // ── RIGHT PANEL ───────────────────────────────────────
            pnlRight.Size = new Size(740, 660);
            pnlRight.Location = new Point(360, 0);
            pnlRight.BackColor = Color.White;

            lblFormTitle.Text = "Create account";
            lblFormTitle.Size = new Size(580, 34);
            lblFormTitle.Location = new Point(70, 50);
            lblFormTitle.ForeColor = ColorTranslator.FromHtml("#1B3A6B");
            lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            lblFormSub.Text = "Register to access the patient care portal.";
            lblFormSub.Size = new Size(580, 20);
            lblFormSub.Location = new Point(70, 88);
            lblFormSub.ForeColor = Color.Gray;
            lblFormSub.Font = new Font("Segoe UI", 10F);

            // ── First Name ────────────────────────────────────────
            lblFirstName.Text = "FIRST NAME";
            lblFirstName.Size = new Size(270, 18);
            lblFirstName.Location = new Point(70, 130);
            lblFirstName.ForeColor = Color.DimGray;
            lblFirstName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            txtFirstName.Size = new Size(278, 36);
            txtFirstName.Location = new Point(70, 150);
            txtFirstName.Font = new Font("Segoe UI", 11F);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.BackColor = Color.White;

            // ── Last Name ─────────────────────────────────────────
            lblLastName.Text = "LAST NAME";
            lblLastName.Size = new Size(270, 18);
            lblLastName.Location = new Point(362, 130);
            lblLastName.ForeColor = Color.DimGray;
            lblLastName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            txtLastName.Size = new Size(278, 36);
            txtLastName.Location = new Point(362, 150);
            txtLastName.Font = new Font("Segoe UI", 11F);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.BackColor = Color.White;

            // ── Email ─────────────────────────────────────────────
            lblEmail.Text = "EMAIL ADDRESS";
            lblEmail.Size = new Size(580, 18);
            lblEmail.Location = new Point(70, 205);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            txtEmail.Size = new Size(580, 36);
            txtEmail.Location = new Point(70, 225);
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.BackColor = Color.White;

            // ── Password ──────────────────────────────────────────
            lblPassword.Text = "PASSWORD";
            lblPassword.Size = new Size(270, 18);
            lblPassword.Location = new Point(70, 278);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            txtPassword.Size = new Size(278, 36);
            txtPassword.Location = new Point(70, 298);
            txtPassword.PasswordChar = '\u25CF';
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.White;

            // ── Confirm Password ──────────────────────────────────
            lblConfirmPass.Text = "CONFIRM PASSWORD";
            lblConfirmPass.Size = new Size(270, 18);
            lblConfirmPass.Location = new Point(362, 278);
            lblConfirmPass.ForeColor = Color.DimGray;
            lblConfirmPass.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            txtConfirmPass.Size = new Size(278, 36);
            txtConfirmPass.Location = new Point(362, 298);
            txtConfirmPass.PasswordChar = '\u25CF';
            txtConfirmPass.Font = new Font("Segoe UI", 11F);
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.BackColor = Color.White;

            // ── Error Label ───────────────────────────────────────
            lblError.Text = "";
            lblError.Size = new Size(580, 18);
            lblError.Location = new Point(70, 345);
            lblError.ForeColor = Color.Crimson;
            lblError.Font = new Font("Segoe UI", 8.5F);
            lblError.Visible = false;

            // ── Create Account Button ─────────────────────────────
            btnCreateAccount.Text = "Create account";
            btnCreateAccount.Size = new Size(580, 46);
            btnCreateAccount.Location = new Point(70, 368);
            btnCreateAccount.BackColor = Color.White;
            btnCreateAccount.ForeColor = ColorTranslator.FromHtml("#1B3A6B");
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#1B3A6B");
            btnCreateAccount.FlatAppearance.BorderSize = 1;
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateAccount.Cursor = Cursors.Hand;

            // ── Already Have Account ──────────────────────────────
            lblHaveAccount.Text = "Already have an account?";
            lblHaveAccount.Size = new Size(215, 22);
            lblHaveAccount.Location = new Point(158, 435);
            lblHaveAccount.ForeColor = Color.Gray;
            lblHaveAccount.Font = new Font("Segoe UI", 10F);

            btnSignIn.Text = "Sign in here";
            btnSignIn.Size = new Size(140, 34);
            btnSignIn.Location = new Point(378, 429);
            btnSignIn.BackColor = Color.White;
            btnSignIn.ForeColor = ColorTranslator.FromHtml("#1B3A6B");
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#1B3A6B");
            btnSignIn.FlatAppearance.BorderSize = 1;
            btnSignIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSignIn.Cursor = Cursors.Hand;

            pnlRight.Controls.AddRange(new Control[] {
                lblFormTitle, lblFormSub,
                lblFirstName, txtFirstName,
                lblLastName, txtLastName,
                lblEmail, txtEmail,
                lblPassword, txtPassword,
                lblConfirmPass, txtConfirmPass,
                lblError, btnCreateAccount,
                lblHaveAccount, btnSignIn
            });

            this.Controls.Add(pnlLeft);
            this.Controls.Add(pnlRight);

            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
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