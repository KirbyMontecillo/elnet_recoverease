using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace elnet_recoverease.Admin
{
    public partial class Edit_Staff : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private int _staffId;
        private bool _isReadOnly;

        // Add Drop Shadow effect
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Edit_Staff()
        {
            InitializeComponent();
            _staffId = 0;
            _isReadOnly = false;
            SetupEvents();
            lblTitle.Text = "Register New Staff Member";
        }

        public Edit_Staff(Staff staff, bool isReadOnly = false)
        {
            InitializeComponent();
            _staffId = staff.StaffID;
            _isReadOnly = isReadOnly;
            SetupEvents();
            LoadStaffData(staff);
            lblTitle.Text = isReadOnly ? "View Staff Profile" : "Edit Staff Profile";
            if (isReadOnly) ApplyReadOnlyMode();
        }

        private void ApplyReadOnlyMode()
        {
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContact.ReadOnly = true;
            txtUsername.ReadOnly = true;
            cmbRole.Enabled = false;
            cmbSpecialty.Enabled = false;
            txtSpecialty.ReadOnly = true;
            btnSave.Visible = false;
            btnCancel.Text = "Close";
        }

        private void SetupEvents()
        {
            this.pnlHeader.MouseDown += new MouseEventHandler(Header_MouseDown);
            this.cmbRole.SelectedIndexChanged += new EventHandler(Role_SelectedIndexChanged);
            this.btnClose.Click += new EventHandler(HandleClose);
            this.btnCancel.Click += new EventHandler(HandleClose);
            this.btnSave.Click += new EventHandler(HandleSave);
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleSpecialtyInput();
        }

        private void HandleClose(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void HandleSave(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void LoadStaffData(Staff s)
        {
            string[] names = s.FullName.Split(new char[] { ' ' }, 2);
            txtFirstName.Text = names.Length > 0 ? names[0] : "";
            txtLastName.Text = names.Length > 1 ? names[1] : "";
            txtEmail.Text = s.Email;
            txtContact.Text = s.ContactNumber;
            
            // Set Role
            for (int i = 0; i < cmbRole.Items.Count; i++)
            {
                if (cmbRole.Items[i].ToString() == s.Role)
                {
                    cmbRole.SelectedIndex = i;
                    break;
                }
            }

            ToggleSpecialtyInput();

            if (s.Role == "Doctor")
            {
                for (int i = 0; i < cmbSpecialty.Items.Count; i++)
                {
                    if (cmbSpecialty.Items[i].ToString() == s.Specialty)
                    {
                        cmbSpecialty.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                txtSpecialty.Text = s.Specialty;
            }

            // Load Username
            using (var db = new AppDbContext())
            {
                var user = db.Users.Find(s.UserID);
                if (user != null) txtUsername.Text = user.Username;
            }
        }

        private void ToggleSpecialtyInput()
        {
            string selectedRole = cmbRole.SelectedItem?.ToString();
            bool isDoctor = (selectedRole == "Doctor");
            
            cmbSpecialty.Visible = isDoctor;
            txtSpecialty.Visible = !isDoctor;
            
            if (isDoctor && cmbSpecialty.SelectedIndex == -1 && cmbSpecialty.Items.Count > 0) 
                cmbSpecialty.SelectedIndex = 0;
        }

        private void SaveChanges()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || 
                string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    Staff staff;
                    User user;

                    if (_staffId == 0)
                    {
                        // Check if username exists
                        string newUsername = txtUsername.Text.Trim();
                        if (db.Users.Any(u => u.Username == newUsername))
                        {
                            MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        user = new User { 
                            Username = newUsername,
                            PasswordHash = "123", // Default password
                            Role = cmbRole.SelectedItem?.ToString() ?? "Staff",
                            CreatedAt = DateTime.Now,
                            IsFirstLogin = true
                        };
                        
                        staff = new Staff { User = user, Status = "Active" };
                        db.Staff.Add(staff);
                    }
                    else
                    {
                        staff = db.Staff.Find(_staffId);
                        if (staff == null) return;
                        
                        user = db.Users.Find(staff.UserID);
                        if (user != null)
                        {
                            string newUsername = txtUsername.Text.Trim();
                            if (user.Username != newUsername)
                            {
                                if (db.Users.Any(u => u.Username == newUsername))
                                {
                                    MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                user.Username = newUsername;
                            }
                            user.Role = cmbRole.SelectedItem?.ToString() ?? "Staff";
                        }
                    }

                    string selectedRole = cmbRole.SelectedItem?.ToString() ?? "Staff";
                    staff.FullName = $"{txtFirstName.Text.Trim()} {txtLastName.Text.Trim()}";
                    staff.Role = selectedRole;
                    staff.Specialty = (selectedRole == "Doctor") ? cmbSpecialty.Text : txtSpecialty.Text.Trim();
                    staff.Email = txtEmail.Text.Trim();
                    staff.ContactNumber = txtContact.Text.Trim();
                    staff.LicenseNumber = staff.LicenseNumber ?? "PENDING"; // Fix NULL constraint
                    staff.CreatedAt = dtpDateHired.Value; // Sync with UI

                    db.SaveChanges();
                    MessageBox.Show(_staffId == 0 ? "Staff registered successfully!" : "Staff details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null) msg += "\n\nDetails: " + ex.InnerException.Message;
                MessageBox.Show("Error saving staff: " + msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
