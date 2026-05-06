using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Doctor
{
    public partial class Appointment_Form : Form
    {
        private AppDbContext _db = new AppDbContext();
        private Patient _selectedPatient;
        private int? _patientId;
        private string _selectedTime = "";

        public Appointment_Form(int? patientId = null)
        {
            InitializeComponent();

            // Shield the designer from database calls
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;

            _patientId = patientId;
            
            // Critical: Ensure database has the latest columns
            _db.EnsureSchemaUpdated();

            this.Load += async (s, e) => await InitializeForm();
        }

        private async Task InitializeForm()
        {
            try
            {
                // Setup Time Slots
                SetupTimeSlots();

                // Load Patients - Ensure dropdown starts EMPTY
                var patients = await _db.Patients.OrderBy(p => p.FullName).ToListAsync();
                cmbPatientSearch.DataSource = null;
                cmbPatientSearch.DataSource = patients;
                cmbPatientSearch.DisplayMember = "FullName";
                cmbPatientSearch.ValueMember = "PatientID";
                cmbPatientSearch.SelectedIndex = -1; // Force empty default

                // Load Doctors & Set Current
                var doctors = await _db.Staff.Where(s => s.Role == "Doctor").ToListAsync();
                cmbDoctor.DataSource = doctors;
                cmbDoctor.DisplayMember = "FullName";
                
                if (elnet_recoverease.Core.UserSession.CurrentStaff != null)
                {
                    var currentDoc = doctors.FirstOrDefault(d => d.StaffID == elnet_recoverease.Core.UserSession.CurrentStaff.StaffID);
                    if (currentDoc != null) cmbDoctor.SelectedItem = currentDoc;
                }

                // If patientId passed, auto-select
                if (_patientId.HasValue)
                {
                    var p = patients.FirstOrDefault(x => x.PatientID == _patientId.Value);
                    if (p != null)
                    {
                        cmbPatientSearch.SelectedItem = p;
                        UpdatePatientCard(p);
                    }
                }
                else
                {
                    pnlPatientCard.Visible = false; // Ensure it's hidden if no ID passed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void SetupTimeSlots()
        {
            string[] times = { "8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM" };
            
            pnlTimeSlots.Controls.Clear();
            foreach (var t in times)
            {
                var btn = new Button 
                { 
                    Text = t, 
                    Size = new Size(142, 40), 
                    FlatStyle = FlatStyle.Flat, 
                    BackColor = Color.White,
                    Font = new Font("Segoe UI", 9),
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 235);
                
                btn.Click += (s, e) => {
                    foreach (Control c in pnlTimeSlots.Controls) if (c is Button b) { 
                        b.BackColor = Color.White; 
                        b.ForeColor = Color.Black; 
                        b.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 235);
                    }
                    btn.BackColor = Color.FromArgb(0, 168, 168);
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(0, 140, 140);
                    _selectedTime = btn.Text;
                };

                pnlTimeSlots.Controls.Add(btn);
            }
        }

        private void cmbPatientSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatientSearch.SelectedIndex != -1 && cmbPatientSearch.SelectedItem is Patient p)
            {
                UpdatePatientCard(p);
            }
            else
            {
                pnlPatientCard.Visible = false;
            }
        }

        private void UpdatePatientCard(Patient p)
        {
            _selectedPatient = p;
            pnlPatientCard.Visible = true;
            lblPatientName.Text = p.FullName;
            lblPatientInfo.Text = $"ID: {p.PatientCode} | Gender: {p.Gender} | DOB: {p.DateOfBirth.ToString("MMMM dd, yyyy")}";
            lblAvatarInitials.Text = GetInitials(p.FullName);
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "??";
            var parts = name.Split(' ');
            if (parts.Length == 1) return parts[0][0].ToString().ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_selectedPatient == null) { MessageBox.Show("Please select a patient."); return; }
            if (string.IsNullOrEmpty(_selectedTime)) { MessageBox.Show("Please select a time slot."); return; }

            try
            {
                // CRITICAL: Merge Date and Time for Calendar support
                DateTime appointmentDateTime = dtpDate.Value.Date.Add(DateTime.Parse(_selectedTime).TimeOfDay);

                var appt = new Appointment
                {
                    PatientID = _selectedPatient.PatientID,
                    DoctorName = cmbDoctor.Text,
                    AppointmentType = cmbApptType.Text,
                    AppointmentDate = appointmentDateTime, // Full precision for calendar
                    Status = "Scheduled",
                    Notes = txtNotes.Text ?? "",
                    CreatedAt = DateTime.Now
                };

                _db.Appointments.Add(appt);
                await _db.SaveChangesAsync();

                MessageBox.Show("Appointment successfully scheduled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // SHOW DETAILED ERROR FOR DEBUGGING
                string errorMsg = ex.Message;
                if (ex.InnerException != null) errorMsg += "\n\nDetails: " + ex.InnerException.Message;
                
                MessageBox.Show("Error saving appointment: " + errorMsg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
