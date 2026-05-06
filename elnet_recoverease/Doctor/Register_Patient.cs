using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elnet_recoverease.Doctor
{
    public partial class Register_Patient : Form
    {
        public Register_Patient()
        {
            InitializeComponent();
            this.btnSave.Click += (s, e) => SavePatient();
            this.btnCancel.Click += (s, e) => this.Close();
            
            // Auto-fill Doctor
            this.txtAttendingDoctor.Text = elnet_recoverease.Core.UserSession.CurrentStaff?.FullName ?? "N/A";

            // Auto-calculate Age
            this.dtpDOB.ValueChanged += (s, e) => CalculateAge();
            CalculateAge(); // Initial call
        }

        private void CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - dtpDOB.Value.Year;
            if (dtpDOB.Value.Date > today.AddYears(-age)) age--;
            txtAge.Text = age.ToString();
        }


        private void SavePatient()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || 
                string.IsNullOrWhiteSpace(txtLastName.Text) || 
                string.IsNullOrWhiteSpace(txtUsername.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    // Check if username already exists
                    if (db.Users.Any(u => u.Username == txtUsername.Text))
                    {
                        MessageBox.Show("Username already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 1. Create User
                    var newUser = new elnet_recoverease.Models.User
                    {
                        Username = txtUsername.Text,
                        PasswordHash = "123", // Temporary password
                        Role = "Patient",
                        IsFirstLogin = true,
                        CreatedAt = DateTime.Now
                    };
                    db.Users.Add(newUser);
                    db.SaveChanges(); // Get UserID

                    // 2. Create Patient
                    var newPatient = new elnet_recoverease.Models.Patient
                    {
                        UserID = newUser.UserID,
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMiddleName.Text,
                        LastName = txtLastName.Text,
                        FullName = $"{txtFirstName.Text} {txtMiddleName.Text} {txtLastName.Text}".Replace("  ", " ").Trim(),
                        Email = txtEmail.Text,

                        ContactNumber = txtPhone.Text,
                        DateOfBirth = dtpDOB.Value,
                        Gender = cmbGender.SelectedItem?.ToString() ?? "Other",
                        Address = "N/A", // Added missing required field
                        EmergencyName = txtEName.Text,
                        EmergencyRelationship = txtERelation.Text,
                        EmergencyPhone = txtEPhone.Text,
                        AttendingDoctor = txtAttendingDoctor.Text,
                        PatientCode = GeneratePatientCode(db),
                        Status = "Active",
                        BloodType = "N/A", // Added missing clinical field
                        Height = "N/A",    // Added missing clinical field
                        Weight = "N/A",    // Added missing clinical field
                        Allergies = "None" // Added missing clinical field
                    };

                    db.Patients.Add(newPatient);
                    db.SaveChanges();



                    MessageBox.Show($"Patient registered successfully!\nUsername: {newUser.Username}\nTemp Password: 123", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving patient: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GeneratePatientCode(elnet_recoverease.Data.AppDbContext db)
        {
            int count = db.Patients.Count() + 1;
            return "P-" + count.ToString("D4");
        }

    }
}
