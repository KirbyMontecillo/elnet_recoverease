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

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Please enter both username and password.");
                return;
            }

            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Username == txtEmail.Text);

                    if (user != null && user.Username == txtEmail.Text && user.PasswordHash == txtPassword.Text)
                    {
                        UserSession.CurrentUser = user;

                        if (user.Role == "Patient")
                        {
                            UserSession.CurrentPatient = db.Patients.FirstOrDefault(p => p.UserID == user.UserID);
                        }
                        else
                        {
                            UserSession.CurrentStaff = db.Staff.FirstOrDefault(s => s.UserID == user.UserID);
                        }

                        if (user.IsFirstLogin || user.PasswordHash == "123")
                        {
                            using (var cpForm = new Change_Password())
                            {
                                if (cpForm.ShowDialog() == DialogResult.OK)
                                {
                                    UserSession.CurrentUser = null;
                                    UserSession.CurrentPatient = null;
                                    UserSession.CurrentStaff = null;
                                    txtPassword.Clear();
                                    return;
                                }
                                else
                                {
                                    UserSession.CurrentUser = null;
                                    return;
                                }
                            }
                        }

                        if (user.Role == "Admin")
                        {
                            NavigationHelper.SwitchForm(this, new Admin.Forms.AdminMainForm());
                        }
                        else if (user.Role == "Doctor")
                        {
                            NavigationHelper.SwitchForm(this, new Doctor.Forms.DoctorMainForm());
                        }
                        else
                        {
                            NavigationHelper.SwitchForm(this, new Patient_Dashboard());
                        }
                    }
                    else
                    {
                        ShowError("Invalid username or password.");
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
    }
}
