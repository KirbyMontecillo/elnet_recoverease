using elnet_recoverease.Core;
using elnet_recoverease.Models;

namespace elnet_recoverease
{
    public partial class Patient_Profile : Form
    {
        public Patient_Profile()
        {
            InitializeComponent();
            LoadLogo();
            WireNavigation();
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            var patient = UserSession.CurrentPatient;
            var user = UserSession.CurrentUser;

            if (patient == null) return;

            // Header info
            lblPatientName.Text = patient.FullName;
            lblPatientId.Text = $"Patient ID: P-{patient.PatientID:D4}";
            lblPatientAge.Text = $"Birth Date: {patient.DateOfBirth:MMM dd, yyyy}  |  Gender: {patient.Gender ?? "Not Specified"}";
            
            // Avatar initials
            string initials = "";
            var names = patient.FullName.Split(' ');
            if (names.Length > 0) initials += names[0][0];
            if (names.Length > 1) initials += names[names.Length - 1][0];
            lblAvatarInitials.Text = initials.ToUpper();
            lblAvatarLargeInitials.Text = initials.ToUpper();

            // Personal Info
            lblPhoneVal.Text = patient.ContactNumber ?? "--";
            lblEmailVal.Text = user?.Username ?? "--";
            lblAddressVal.Text = patient.Address ?? "--";
            lblEmergencyNameVal.Text = patient.EmergencyName ?? "--";
            lblEmergencyRelVal.Text = patient.EmergencyRelationship ?? "--";
            lblEmergencyPhoneVal.Text = patient.EmergencyPhone ?? "--";

            // Medical Overview
            lblBloodVal.Text = patient.BloodType ?? "--";
            lblHeightVal.Text = patient.Height ?? "--";
            lblWeightVal.Text = patient.Weight ?? "--";
            lblAllergiesVal.Text = patient.Allergies ?? "None Reported";
        }

        private void WireNavigation()
        {
            RegisterNavClick(btnNavDashboard, (s, e) => OpenForm(new Patient_Dashboard()));
            RegisterNavClick(btnNavProfile, (s, e) => { /* Already here */ });
            RegisterNavClick(btnNavMeds, (s, e) => OpenForm(new Medications()));
            RegisterNavClick(btnNavMedSchedule, (s, e) => OpenForm(new Medication_Schedule()));
            RegisterNavClick(btnNavAppointments, (s, e) => OpenForm(new Appointments()));
            RegisterNavClick(btnNavTreatment, (s, e) => OpenForm(new Treatment_Plans()));

            btnLogout.Click += (s, e) => {
                UserSession.Logout();
                new Login().Show();
                this.Close();
            };

            btnEditPersonal.Click += (s, e) => {
                using (var editForm = new Edit_Patient_Profile())
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPatientData(); // Refresh labels
                    }
                }
            };
        }

        private void RegisterNavClick(Panel panel, EventHandler handler)
        {
            panel.Click += handler;
            foreach (Control c in panel.Controls) c.Click += (s, e) => handler(panel, e);
        }

        private void OpenForm(Form childForm)
        {
            childForm.Show();
            this.Hide();
        }

        private void LoadLogo()
        {
            try
            {
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath))
                {
                    picLogo.Image = System.Drawing.Image.FromFile(logoPath);
                }
            }
            catch { }
        }

        private void Patient_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
