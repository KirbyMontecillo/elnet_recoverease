using elnet_recoverease.Models;
using elnet_recoverease.Data;

namespace elnet_recoverease.Admin
{
    public partial class Staff_Form : Form
    {
        public Staff_Form()
        {
            InitializeComponent();
            try { this.picLogo.Image = System.Drawing.Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }
            
            this.btnSave.Click += (s, e) => SaveStaff();
            this.btnCancel.Click += (s, e) => this.Close();
        }

        private void SaveStaff()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || 
                string.IsNullOrWhiteSpace(txtUsername.Text) || 
                cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill in Name, Username and Role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    // 1. Create User
                    var user = new User
                    {
                        Username = txtUsername.Text.Trim(),
                        PasswordHash = "123", // Default password
                        Role = cmbRole.SelectedItem.ToString(),
                        IsFirstLogin = true,
                        CreatedAt = DateTime.Now
                    };
                    db.Users.Add(user);
                    db.SaveChanges(); // Save to get UserID

                    // 2. Create Staff
                    var staff = new Staff
                    {
                        FullName = txtFullName.Text.Trim(),
                        Role = cmbRole.SelectedItem.ToString(),
                        Specialty = txtSpecialty.Text.Trim(),
                        LicenseNumber = txtLicense.Text.Trim(),
                        Status = cmbStatus.SelectedItem?.ToString() ?? "Active",
                        Email = txtEmail.Text.Trim(),
                        UserID = user.UserID,
                        CreatedAt = DateTime.Now
                    };
                    db.Staff.Add(staff);
                    db.SaveChanges();

                    MessageBox.Show($"Staff member {staff.FullName} registered successfully!\nDefault password is '123'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving staff: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
