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

            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();


            // ── FORM ──────────────────────────────────────────────
            this.Text = "RecoverEase — Login";
            this.ClientSize = new Size(1100, 620);
            this.MinimumSize = new Size(1024, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 9F);
            this.Load += Login_Load;

            // ── LEFT PANEL ────────────────────────────────────────
            pnlLeft.Size = new Size(360, 620);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.BackColor = ColorTranslator.FromHtml("#EEF3F7");

            pnlLogoCard.BackColor = Color.Transparent;
            pnlLogoCard.BorderStyle = BorderStyle.None;
            pnlLogoCard.Controls.Add(picLogo);
            pnlLogoCard.Location = new Point(35, 35);
            pnlLogoCard.Size = new Size(290, 100);

            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.recoverease_logo_removebg_preview;
            picLogo.Location = new Point(0, 0);
            picLogo.Size = new Size(286, 96);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            pnlDivider.Size = new Size(290, 1);
            pnlDivider.Location = new Point(35, 150);
            pnlDivider.BackColor = ColorTranslator.FromHtml("#D0DBE8");

            // Feature bullet labels — fully explicit, no loops
            lblB1.Text = "  \u2022   Medication tracking";
            lblB1.Size = new Size(290, 22);
            lblB1.Location = new Point(35, 168);
            lblB1.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB1.Font = new Font("Segoe UI", 10F);
            lblB1.BackColor = Color.Transparent;

            lblB2.Text = "  \u2022   Treatment plans";
            lblB2.Size = new Size(290, 22);
            lblB2.Location = new Point(35, 196);
            lblB2.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB2.Font = new Font("Segoe UI", 10F);
            lblB2.BackColor = Color.Transparent;

            lblB3.Text = "  \u2022   Follow-up scheduling";
            lblB3.Size = new Size(290, 22);
            lblB3.Location = new Point(35, 224);
            lblB3.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB3.Font = new Font("Segoe UI", 10F);
            lblB3.BackColor = Color.Transparent;

            lblB4.Text = "  \u2022   Recovery reports";
            lblB4.Size = new Size(290, 22);
            lblB4.Location = new Point(35, 252);
            lblB4.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB4.Font = new Font("Segoe UI", 10F);
            lblB4.BackColor = Color.Transparent;

            lblB5.Text = "  \u2022   Appointment reminders";
            lblB5.Size = new Size(290, 22);
            lblB5.Location = new Point(35, 280);
            lblB5.ForeColor = ColorTranslator.FromHtml("#444444");
            lblB5.Font = new Font("Segoe UI", 10F);
            lblB5.BackColor = Color.Transparent;

            lblSecure.Text = "Secure healthcare platform for patients and clinical staff.";
            lblSecure.Size = new Size(290, 40);
            lblSecure.Location = new Point(35, 560);
            lblSecure.ForeColor = Color.DarkGray;
            lblSecure.Font = new Font("Segoe UI", 8.5F);
            lblSecure.BackColor = Color.Transparent;

            pnlLeft.Controls.AddRange(new Control[] {
                pnlLogoCard, pnlDivider,
                lblB1, lblB2, lblB3, lblB4, lblB5,
                lblSecure
            });

            // ── RIGHT PANEL ───────────────────────────────────────
            pnlRight.Size = new Size(740, 620);
            pnlRight.Location = new Point(360, 0);
            pnlRight.BackColor = Color.White;

            lblWelcome.Text = "Welcome back";
            lblWelcome.Size = new Size(580, 38);
            lblWelcome.Location = new Point(80, 110);
            lblWelcome.ForeColor = ColorTranslator.FromHtml("#1B3A6B");
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);

            lblSubtitle.Text = "Sign in to your RecoverEase account to continue.";
            lblSubtitle.Size = new Size(580, 20);
            lblSubtitle.Location = new Point(80, 152);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Font = new Font("Segoe UI", 10F);

            lblEmailLabel.Text = "EMAIL ADDRESS";
            lblEmailLabel.Size = new Size(580, 18);
            lblEmailLabel.Location = new Point(80, 205);
            lblEmailLabel.ForeColor = Color.DimGray;
            lblEmailLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            txtEmail.Size = new Size(580, 38);
            txtEmail.Location = new Point(80, 226);
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.BackColor = Color.White;

            lblPassLabel.Text = "PASSWORD";
            lblPassLabel.Size = new Size(580, 18);
            lblPassLabel.Location = new Point(80, 280);
            lblPassLabel.ForeColor = Color.DimGray;
            lblPassLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);

            txtPassword.Size = new Size(580, 38);
            txtPassword.Location = new Point(80, 301);
            txtPassword.PasswordChar = '\u25CF';
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.White;


            lblError.Text = "";
            lblError.Size = new Size(580, 18);
            lblError.Location = new Point(80, 376);
            lblError.ForeColor = Color.Crimson;
            lblError.Font = new Font("Segoe UI", 8.5F);
            lblError.Visible = false;

            btnLogin.Text = "Sign in";
            btnLogin.Size = new Size(580, 46);
            btnLogin.Location = new Point(80, 400);
            btnLogin.BackColor = Color.White;
            btnLogin.ForeColor = ColorTranslator.FromHtml("#1B3A6B");
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#1B3A6B");
            btnLogin.FlatAppearance.BorderSize = 1;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;

            pnlRight.Controls.AddRange(new Control[] {
                lblWelcome, lblSubtitle,
                lblEmailLabel, txtEmail,
                lblPassLabel, txtPassword,
                lblError, btnLogin
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