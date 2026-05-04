namespace elnet_recoverease
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnCreateAccount.Click += (s, e) => {
                new Register().Show();
                this.Hide();
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Please enter both email and password.");
                return;
            }

            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    // 1. Find user in database
                    var user = db.Users.FirstOrDefault(u => u.Username == txtEmail.Text && u.PasswordHash == txtPassword.Text);

                    if (user != null)
                    {
                        // 2. Success! Redirect based on Role
                        if (user.Role == "Admin")
                        {
                            new Admin.Admin_Dashboard().Show();
                        }
                        else if (user.Role == "Doctor")
                        {
                            new Doctor.Doctor_Dashboard().Show();
                        }
                        else
                        {
                            // Patient_Dashboard is in the root namespace
                            new Patient_Dashboard().Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        ShowError("Invalid email or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Login failed: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void ShowError(string message)
        {
            lblError.Text = "⚠ " + message;
            lblError.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e) { }
    }
}
