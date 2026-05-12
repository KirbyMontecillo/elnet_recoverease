using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System.Linq;

namespace elnet_recoverease.Doctor.Forms
{
    public partial class Clinical_Session : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _appointmentId;
        private Appointment _appointment;
        private elnet_recoverease.Models.Patient _patient;

        public Clinical_Session(int appointmentId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            this.Load += Clinical_Session_Load;
        }

        private void Clinical_Session_Load(object sender, EventArgs e)
        {
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
                txtGoals.Text = _appointment.TreatmentGoals;
                txtNotes.Text = _appointment.DoctorNotes;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_appointment != null)
            {
                _appointment.Diagnosis = txtDiagnosis.Text;
                _appointment.TreatmentGoals = txtGoals.Text;
                _appointment.DoctorNotes = txtNotes.Text;
                _appointment.Status = "Completed";
                
                await _db.SaveChangesAsync();
                MessageBox.Show("Clinical session recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
