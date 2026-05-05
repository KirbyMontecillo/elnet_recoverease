using elnet_recoverease.Core;
namespace elnet_recoverease
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
                        // 2. Success! Set Session
                        UserSession.CurrentUser = user;

                        // 3. Load Role-Specific Profile
                        if (user.Role == "Patient")
                        {
                            UserSession.CurrentPatient = db.Patients.FirstOrDefault(p => p.UserID == user.UserID);
                        }
                        else
                        {
                            UserSession.CurrentStaff = db.Staff.FirstOrDefault(s => s.UserID == user.UserID);
                        }

                        // 4. Enforce Password Change if needed
                        if (user.IsFirstLogin || user.PasswordHash == "123")
                        {
                            using (var cpForm = new Change_Password())
                            {
                                if (cpForm.ShowDialog() == DialogResult.OK)
                                {
                                    // Logout and force re-login
                                    UserSession.CurrentUser = null;
                                    UserSession.CurrentPatient = null;
                                    UserSession.CurrentStaff = null;
                                    txtPassword.Clear();
                                    return;
                                }
                                else
                                {
                                    // User cancelled forced change - log them out
                                    UserSession.CurrentUser = null;
                                    return;
                                }
                            }
                        }

                        // 5. Redirect based on Role
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

        private void Login_Load(object sender, EventArgs e) 
        { 
            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    var admin = db.Users.FirstOrDefault(u => u.Username == "admin");
                    if (admin == null)
                    {
                        db.Users.Add(new elnet_recoverease.Models.User
                        {
                            Username = "admin",
                            PasswordHash = "admin123",
                            Role = "Admin",
                            IsFirstLogin = false
                        });
                        db.SaveChanges();
                    }
                    else
                    {
                        // Ensure password is correct for the user's request
                        admin.PasswordHash = "admin123";
                        admin.Role = "Admin";
                        admin.IsFirstLogin = false;
                        db.SaveChanges();
                    }
                }
            }
            catch { }
        }
    }
}
