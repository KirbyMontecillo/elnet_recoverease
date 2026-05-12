using elnet_recoverease.Core;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Data;

namespace elnet_recoverease.PatientStation.Forms
{
    public partial class Edit_Patient_Profile : Form
    {
        public Edit_Patient_Profile()
        {
            InitializeComponent();
            LoadCurrentData();
            SetupDragging();
            LoadAvatar();
            SetupAvatarHover();
        }

        private void LoadAvatar()
        {
            try
            {
                var patient = elnet_recoverease.Core.UserSession.CurrentPatient;
                if (patient != null)
                {
                    string initials = string.Join("", patient.FullName.Split(' ').Select(n => n[0])).ToUpper();
                    // For now, use initials if no image is stored
                    // In a real app, you'd load from DB or File
                }
            }
            catch { }
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = Image.FromFile(ofd.FileName);
                    // In a real app, you'd save this to DB or File
                }
            }
        }

        private void SetupAvatarHover()
        {
            btnChangePhoto.MouseEnter += (s, e) => btnChangePhoto.BackColor = System.Drawing.Color.FromArgb(220, 0, 168, 168);
            btnChangePhoto.MouseLeave += (s, e) => btnChangePhoto.BackColor = System.Drawing.Color.FromArgb(180, 0, 0, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000; // CS_DROPSHADOW
                return cp;
            }
        }

        private void SetupDragging()
        {
            bool dragging = false;
            System.Drawing.Point dragCursorPoint = System.Drawing.Point.Empty;
            System.Drawing.Point dragFormPoint = System.Drawing.Point.Empty;

            pnlHeader.MouseDown += (s, e) => { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; };
            pnlHeader.MouseMove += (s, e) => { if (dragging) { System.Drawing.Point dif = System.Drawing.Point.Subtract(Cursor.Position, new System.Drawing.Size(dragCursorPoint)); this.Location = System.Drawing.Point.Add(dragFormPoint, new System.Drawing.Size(dif)); } };
            pnlHeader.MouseUp += (s, e) => { dragging = false; };
            
            lblTitle.MouseDown += (s, e) => { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; };
            lblTitle.MouseMove += (s, e) => { if (dragging) { System.Drawing.Point dif = System.Drawing.Point.Subtract(Cursor.Position, new System.Drawing.Size(dragCursorPoint)); this.Location = System.Drawing.Point.Add(dragFormPoint, new System.Drawing.Size(dif)); } };
            lblTitle.MouseUp += (s, e) => { dragging = false; };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCurrentData()
        {
            var p = elnet_recoverease.Core.UserSession.CurrentPatient;
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
                    var p = db.Patients.FirstOrDefault(x => x.PatientID == elnet_recoverease.Core.UserSession.CurrentPatient.PatientID);
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
                        elnet_recoverease.Core.UserSession.CurrentPatient.FullName = p.FullName;
                        elnet_recoverease.Core.UserSession.CurrentPatient.ContactNumber = p.ContactNumber;
                        elnet_recoverease.Core.UserSession.CurrentPatient.Address = p.Address;
                        elnet_recoverease.Core.UserSession.CurrentPatient.EmergencyName = p.EmergencyName;
                        elnet_recoverease.Core.UserSession.CurrentPatient.EmergencyRelationship = p.EmergencyRelationship;
                        elnet_recoverease.Core.UserSession.CurrentPatient.EmergencyPhone = p.EmergencyPhone;

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
