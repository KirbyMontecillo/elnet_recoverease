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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
            this.btnUpdate.Click += (s, e) => UpdatePassword();
        }

        private void UpdatePassword()
        {
            if (string.IsNullOrWhiteSpace(txtOldPass.Text) || 
                string.IsNullOrWhiteSpace(txtNewPass.Text) || 
                string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPass.Text == "123")
            {
                MessageBox.Show("New password cannot be the default password '123'.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("New passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    var user = db.Users.Find(elnet_recoverease.Core.UserSession.CurrentUser.UserID);
                    if (user == null) return;

                    if (user.PasswordHash != txtOldPass.Text)
                    {
                        MessageBox.Show("Incorrect current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update password and flag
                    user.PasswordHash = txtNewPass.Text;
                    user.IsFirstLogin = false;
                    db.SaveChanges();

                    MessageBox.Show("Password updated successfully! Please log in again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
