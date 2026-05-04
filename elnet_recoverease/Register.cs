using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elnet_recoverease
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            this.btnSignIn.Click += (s, e) =>
            {
                new Login().Show();
                this.Hide();
            };
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Reset error
            lblError.Visible = false;

            // 1. Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Please fill in all fields.");
                return;
            }

            if (txtPassword.Text != txtConfirmPass.Text)
            {
                ShowError("Passwords do not match.");
                return;
            }

            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    // 2. Check if user already exists
                    if (db.Users.Any(u => u.Username == txtEmail.Text))
                    {
                        ShowError("An account with this email already exists.");
                        return;
                    }

                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try {
                            // 3. Create User Account
                            var user = new elnet_recoverease.Models.User
                            {
                                Username = txtEmail.Text,
                                PasswordHash = txtPassword.Text,
                                Role = "Patient",
                                CreatedAt = DateTime.Now
                            };
                            db.Users.Add(user);
                            db.SaveChanges();

                            // 4. Create Patient Profile
                            var patient = new elnet_recoverease.Models.Patient
                            {
                                FullName = $"{txtFirstName.Text} {txtLastName.Text}",
                                DateOfBirth = new DateTime(1990, 1, 1),
                                ContactNumber = "000-000-0000",
                                Address = "Pending Update",
                                Status = "Active",
                                CreatedAt = DateTime.Now
                            };
                            db.Patients.Add(patient);
                            db.SaveChanges();

                            transaction.Commit();

                            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new Login().Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            ShowError("Database Error: " + (ex.InnerException?.Message ?? ex.Message));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("System Error: " + ex.Message);
            }
        }

        private void ShowError(string message)
        {
            lblError.Text = "⚠ " + message;
            lblError.Visible = true;
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {

        }
    }
}
