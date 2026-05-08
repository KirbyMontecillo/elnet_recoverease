using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace elnet_recoverease.Admin
{
    public partial class Edit_Medicine : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private int _medicationId;

        public Edit_Medicine()
        {
            InitializeComponent();
            _medicationId = 0;
            SetupEvents();
            this.lblTitle.Text = "Add New Medication";
        }

        public Edit_Medicine(int medId)
        {
            InitializeComponent();
            _medicationId = medId;
            SetupEvents();
            LoadMedicationData();
            this.lblTitle.Text = "Edit Medication Details";
        }

        private void SetupEvents()
        {
            this.pnlHeader.MouseDown += new MouseEventHandler(this.pnlHeader_MouseDown);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void LoadMedicationData()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var med = db.Medications.Find(_medicationId);
                    if (med == null)
                    {
                        MessageBox.Show("Medication not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    txtMedName.Text = med.MedicationName;
                    txtDosage.Text = med.DosageUnit;
                    txtFrequency.Text = med.Frequency;
                    txtDescription.Text = med.Description;

                    // Set combo boxes
                    SetComboValue(cmbCategory, med.Category);
                    SetComboValue(cmbForm, med.Form);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetComboValue(ComboBox cmb, string value)
        {
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if (cmb.Items[i].ToString() == value)
                {
                    cmb.SelectedIndex = i;
                    return;
                }
            }
            if (cmb.Items.Count > 0) cmb.SelectedIndex = 0;
        }

        private void SaveChanges()
        {
            if (string.IsNullOrWhiteSpace(txtMedName.Text) ||
                string.IsNullOrWhiteSpace(txtDosage.Text) ||
                string.IsNullOrWhiteSpace(txtFrequency.Text))
            {
                MessageBox.Show("Please fill in all required fields (*) to proceed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    Medication med;
                    if (_medicationId == 0)
                    {
                        med = new Medication();
                        db.Medications.Add(med);
                    }
                    else
                    {
                        med = db.Medications.Find(_medicationId);
                        if (med == null) return;
                    }

                    med.MedicationName = txtMedName.Text.Trim();
                    med.Category = cmbCategory.SelectedItem?.ToString() ?? "General";
                    med.DosageUnit = txtDosage.Text.Trim();
                    med.Form = cmbForm.SelectedItem?.ToString() ?? "Tablet";
                    med.Frequency = txtFrequency.Text.Trim();
                    med.Description = txtDescription.Text.Trim();

                    db.SaveChanges();

                    MessageBox.Show(_medicationId == 0 ? "Medication added successfully!" : "Medication updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null) msg += "\n\nDetails: " + ex.InnerException.Message;
                MessageBox.Show("Error saving medication: " + msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
