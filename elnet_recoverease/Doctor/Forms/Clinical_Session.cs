using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System.Linq;
using System.Runtime.InteropServices;

namespace elnet_recoverease.Doctor.Forms
{
    public partial class Clinical_Session : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _appointmentId;
        private Appointment _appointment;
        private elnet_recoverease.Models.Patient _patient;
        private System.Collections.Generic.List<MedicationSchedule> _newPrescriptions = new System.Collections.Generic.List<MedicationSchedule>();

        public Clinical_Session(int appointmentId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            btnMenuDiagnosis.Click += (s, e) => ShowSection(pnlDiagnosisSection, btnMenuDiagnosis);
            btnMenuVitals.Click += (s, e) => ShowSection(pnlVitalsSection, btnMenuVitals);
            btnMenuPrescription.Click += (s, e) => ShowSection(pnlPrescriptionsSection, btnMenuPrescription);
            
            this.Shown += (s, e) => {
                PopulateVitals();
                LoadPrescriptions();
                LoadMedicationLists();
            };
            
            this.cmbMedication.Text = "";
            this.txtDosage.Text = "";
            this.cmbFrequency.Text = "";
            this.btnAddMed.Click += btnAddMed_Click;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nL, int nT, int nR, int nB, int nW, int nH);

        private void Clinical_Session_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _appointment = _db.Appointments.Find(_appointmentId);
            if (_appointment != null)
            {
                _patient = _db.Patients.Find(_appointment.PatientID);
                if (_patient != null)
                {
                    lblPatientName.Text = _patient.FullName;
                    lblAppointmentDate.Text = _appointment.AppointmentDate?.ToString("MMM dd, yyyy hh:mm tt");
                }
                txtDiagnosis.Text = _appointment.Diagnosis;
                txtChiefComplaint.Text = _appointment.ChiefComplaint; 
                txtPlanNotes.Text = _appointment.DoctorNotes;

                if (_appointment.Status == "Completed")
                {
                    txtDiagnosis.ReadOnly = true;
                    txtGoals.ReadOnly = true;
                    txtNotes.ReadOnly = true;
                    btnSave.Visible = false;
                    btnCancel.Text = "Close";
                    lblTitle.Text = "Clinical Session (Review)";
                }

                ShowSection(pnlDiagnosisSection, btnMenuDiagnosis);
            }
        }

        private void ShowSection(Panel section, Button menuBtn)
        {
            pnlDiagnosisSection.Visible = (section == pnlDiagnosisSection);
            pnlVitalsSection.Visible = (section == pnlVitalsSection);
            pnlPrescriptionsSection.Visible = (section == pnlPrescriptionsSection);

            btnMenuDiagnosis.BackColor = Color.Transparent;
            btnMenuVitals.BackColor = Color.Transparent;
            btnMenuPrescription.BackColor = Color.Transparent;
            btnMenuDiagnosis.ForeColor = Color.FromArgb(71, 85, 105);
            btnMenuVitals.ForeColor = Color.FromArgb(71, 85, 105);
            btnMenuPrescription.ForeColor = Color.FromArgb(71, 85, 105);

            menuBtn.BackColor = Color.FromArgb(226, 232, 240);
            menuBtn.ForeColor = Color.FromArgb(27, 58, 107);
        }

        private void PopulateVitals()
        {
            if (_appointment == null) return;
            txtSystolic.Text = _appointment.BloodPressure?.Split('/')[0];
            txtDiastolic.Text = _appointment.BloodPressure?.Split('/').Length > 1 ? _appointment.BloodPressure.Split('/')[1] : "";
            txtHR.Text = _appointment.HeartRate?.ToString();
            txtTemp.Text = _appointment.Temperature?.ToString();
            txtWeight.Text = _appointment.Weight?.ToString();
            txtHeight.Text = _appointment.Height?.ToString();
            CalculateBMI();
        }

        private void CalculateBMI()
        {
            if (double.TryParse(txtWeight.Text, out double w) && double.TryParse(txtHeight.Text, out double h) && h > 0)
            {
                double bmi = w / ((h / 100) * (h / 100));
                lblBMI.Text = bmi.ToString("F1");
                lblBMI.ForeColor = (bmi < 18.5 || bmi > 25) ? Color.Red : Color.Green;
            }
            else lblBMI.Text = "--";
        }

        private void LoadMedicationLists()
        {
            cmbMedication.Items.AddRange(new string[] { "Paracetamol", "Amoxicillin", "Ibuprofen", "Metformin", "Amlodipine" });
            cmbFrequency.Items.AddRange(new string[] { "Once a day", "2x a day", "3x a day", "Every 4 hours", "Before bedtime" });
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMedication.Text)) return;
            var med = new MedicationSchedule {
                MedicationName = cmbMedication.Text,
                DosageUnit = txtDosage.Text,
                Frequency = cmbFrequency.Text,
                AppointmentID = _appointmentId,
                PatientID = _appointment.PatientID ?? 0,
                Status = "Active"
            };
            _newPrescriptions.Add(med);
            RefreshPrescriptionPad();
        }

        private void RefreshPrescriptionPad()
        {
            if (pnlPrescriptions == null) return;
            pnlPrescriptions.Controls.Clear();
            foreach (var p in _newPrescriptions)
            {
                var card = new Panel { Size = new Size(650, 60), BackColor = Color.FromArgb(245, 248, 250), Margin = new Padding(0, 0, 0, 10) };
                card.Controls.Add(new Label { Text = $"💊 {p.MedicationName}", Location = new Point(15, 10), Font = new Font("Segoe UI Bold", 10F), AutoSize = true });
                card.Controls.Add(new Label { Text = $"{p.DosageUnit} | {p.Frequency}", Location = new Point(15, 35), ForeColor = Color.Gray, AutoSize = true });
                var btnDel = new Button { Text = "🗑", Location = new Point(600, 15), Size = new Size(30, 30), FlatStyle = FlatStyle.Flat };
                btnDel.Click += (s, ev) => { _newPrescriptions.Remove(p); RefreshPrescriptionPad(); };
                card.Controls.Add(btnDel);
                pnlPrescriptions.Controls.Add(card);
            }
        }

        private void LoadPrescriptions()
        {
            pnlPrescriptions.Controls.Clear();
            var prescriptions = _db.MedicationSchedules
                .Where(ms => ms.AppointmentID == _appointmentId)
                .ToList();

            if (!prescriptions.Any())
            {
                pnlPrescriptions.Controls.Add(new Label { Text = "No medications prescribed during this session.", ForeColor = Color.Gray, AutoSize = true, Margin = new Padding(10) });
                return;
            }

            foreach (var p in prescriptions)
            {
                var card = new Panel { Size = new Size(530, 50), BackColor = Color.White, Margin = new Padding(0, 0, 0, 8) };
                card.Controls.Add(new Label { Text = $"💊 {p.MedicationName}", Location = new Point(10, 15), Font = new Font("Segoe UI Bold", 9.5f), AutoSize = true });
                card.Controls.Add(new Label { Text = $"{p.Frequency} | {p.DosageUnit}", Location = new Point(350, 15), Font = new Font("Segoe UI", 9), ForeColor = Color.Gray, AutoSize = true });
                pnlPrescriptions.Controls.Add(card);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_appointment != null)
            {
                _appointment.Diagnosis = txtDiagnosis.Text;
                _appointment.ChiefComplaint = txtChiefComplaint.Text;
                _appointment.DoctorNotes = txtPlanNotes.Text;
                _appointment.BloodPressure = $"{txtSystolic.Text}/{txtDiastolic.Text}";
                
                _appointment.Temperature = txtTemp.Text;
                _appointment.HeartRate = txtHR.Text;
                _appointment.Weight = txtWeight.Text;
                _appointment.Height = txtHeight.Text;
                _appointment.BMI = lblBMI.Text;

                _appointment.Status = "Completed";
                
                if (_newPrescriptions.Any())
                {
                    _db.MedicationSchedules.AddRange(_newPrescriptions);
                }

                await _db.SaveChangesAsync();
                MessageBox.Show("Clinical session recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84) m.Result = (IntPtr)0x2; // WM_NCHITTEST -> HTCAPTION
        }
    }
}
