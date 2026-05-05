using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Data;

namespace elnet_recoverease
{
    public partial class Edit_Patient_Profile : Form
    {
        public Edit_Patient_Profile()
        {
            InitializeComponent();
            LoadCurrentData();
        }

        private void LoadCurrentData()
        {
            var p = UserSession.CurrentPatient;
            if (p == null) return;

            txtFullName.Text = p.FullName;
            txtPhone.Text = p.ContactNumber;
            txtAddress.Text = p.Address;
            txtEmergencyName.Text = p.EmergencyName;
            txtEmergencyRelationship.Text = p.EmergencyRelationship;
            txtEmergencyPhone.Text = p.EmergencyPhone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in the required fields (Name, Phone and Address).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    var p = db.Patients.FirstOrDefault(x => x.PatientID == UserSession.CurrentPatient.PatientID);
                    if (p != null)
                    {
                        p.FullName = txtFullName.Text.Trim();
                        p.ContactNumber = txtPhone.Text.Trim();
                        p.Address = txtAddress.Text.Trim();
                        p.EmergencyName = txtEmergencyName.Text.Trim();
                        p.EmergencyRelationship = txtEmergencyRelationship.Text.Trim();
                        p.EmergencyPhone = txtEmergencyPhone.Text.Trim();

                        db.SaveChanges();

                        // Update session
                        UserSession.CurrentPatient.FullName = p.FullName;
                        UserSession.CurrentPatient.ContactNumber = p.ContactNumber;
                        UserSession.CurrentPatient.Address = p.Address;
                        UserSession.CurrentPatient.EmergencyName = p.EmergencyName;
                        UserSession.CurrentPatient.EmergencyRelationship = p.EmergencyRelationship;
                        UserSession.CurrentPatient.EmergencyPhone = p.EmergencyPhone;

                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
