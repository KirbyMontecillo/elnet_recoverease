using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Core;

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
                // Initial Load of Time Slots
                await UpdateAvailableTimeSlots();

                // Wire up change events
                dtpDate.ValueChanged += async (s, e) => await UpdateAvailableTimeSlots();
                cmbDoctor.SelectedIndexChanged += async (s, e) => await UpdateAvailableTimeSlots();
                cmbDuration.SelectedIndexChanged += async (s, e) => await UpdateAvailableTimeSlots();

                // Load Patients - Only show patients assigned to THIS doctor
                string currentDoctor = UserSession.CurrentStaff?.FullName ?? "";
                var patients = await _db.Patients
                    .Where(p => p.AttendingDoctor == currentDoctor)
                    .OrderBy(p => p.FullName)
                    .ToListAsync();
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

        private async Task UpdateAvailableTimeSlots()
        {
            try
            {
                // Continuous slots from 8:00 AM to 5:00 PM
                string[] times = { 
                    "8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM",
                    "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", 
                    "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM" 
                };
                
                DateTime selectedDate = dtpDate.Value.Date;
                DateTime now = DateTime.Now;
                string selectedDoctor = cmbDoctor.Text;
                int selectedDuration = GetDurationInMinutes(cmbDuration.Text);
                int neededSlots = selectedDuration / 30;

                // 1. Fetch existing appointments (with duration)
                var existingData = await _db.Appointments
                    .Where(a => a.AppointmentDate.HasValue && a.AppointmentDate.Value.Date == selectedDate 
                           && (a.DoctorID == (cmbDoctor.SelectedItem as Staff).StaffID || a.DoctorName == selectedDoctor)
                           && a.Status == "Scheduled")
                    .Select(a => new { a.AppointmentDate.Value, a.DurationMinutes })
                    .ToListAsync();

                // Build a map of "Blocked" times based on existing appointments + their duration
                var blockedByExisting = new HashSet<DateTime>();
                foreach (var appt in existingData)
                {
                    int slotsToBlock = Math.Max(1, appt.DurationMinutes / 30);
                    for (int i = 0; i < slotsToBlock; i++)
                    {
                        blockedByExisting.Add(appt.Value.AddMinutes(i * 30));
                    }
                }

                pnlTimeSlots.Controls.Clear();
                bool isPastDate = selectedDate < now.Date;
                bool isToday = selectedDate == now.Date;

                var buttons = new List<Button>();

                for (int i = 0; i < times.Length; i++)
                {
                    string t = times[i];
                    DateTime timePart = DateTime.ParseExact(t, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime slotDateTime = selectedDate.Date.Add(timePart.TimeOfDay);
                    
                    bool isBooked = blockedByExisting.Contains(slotDateTime);
                    bool isPassed = isToday && slotDateTime < now;
                    bool isSelectionBlocked = false;

                    // If we have a selected time, we need to check if THIS slot falls into its duration
                    if (!string.IsNullOrEmpty(_selectedTime))
                    {
                        DateTime selStartTime = selectedDate.Date.Add(DateTime.ParseExact(_selectedTime, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture).TimeOfDay);
                        if (slotDateTime >= selStartTime && slotDateTime < selStartTime.AddMinutes(selectedDuration))
                        {
                            isSelectionBlocked = true;
                        }
                    }

                    var btn = new Button 
                    { 
                        Text = isBooked ? $"{t}\n(Taken)" : t, 
                        Size = new Size(142, 50),
                        FlatStyle = FlatStyle.Flat, 
                        Font = new Font("Segoe UI", 9),
                        Cursor = Cursors.Hand,
                        Tag = slotDateTime // Store the full DateTime
                    };
                    btn.FlatAppearance.BorderColor = Color.FromArgb(220, 225, 235);

                    // --- COMBINED BLOCKING LOGIC ---
                    if (isBooked)
                    {
                        btn.BackColor = Color.FromArgb(245, 235, 235); // Light Red
                        btn.ForeColor = Color.FromArgb(180, 100, 100); 
                        btn.FlatAppearance.BorderColor = Color.FromArgb(230, 210, 210);
                        btn.Enabled = false;
                    }
                    else if (isPastDate || isPassed)
                    {
                        btn.BackColor = Color.FromArgb(242, 244, 246); // Faded Gray
                        btn.ForeColor = Color.FromArgb(80, 80, 80); // Darker Gray for readability
                        btn.FlatAppearance.BorderColor = Color.FromArgb(230, 235, 240);
                        btn.Enabled = false;
                        btn.Cursor = Cursors.Default;
                    }
                    else if (isSelectionBlocked)
                    {
                        btn.BackColor = Color.FromArgb(0, 168, 168); // Teal (Part of selection)
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(0, 140, 140);
                        btn.Enabled = true;
                    }
                    else
                    {
                        // Available
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.FromArgb(20, 35, 65);
                        btn.Enabled = true;

                        // PEER CHECK: If selecting this slot would overlap an existing appointment, disable it
                        bool wouldOverlap = false;
                        for (int j = 0; j < neededSlots; j++)
                        {
                            if (blockedByExisting.Contains(slotDateTime.AddMinutes(j * 30))) wouldOverlap = true;
                            // Also check if the slot even exists in our schedule
                            if (!times.Any(tm => DateTime.ParseExact(tm, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture).TimeOfDay == slotDateTime.AddMinutes(j * 30).TimeOfDay))
                                wouldOverlap = true;
                        }
                        if (wouldOverlap)
                        {
                            btn.BackColor = Color.FromArgb(250, 250, 250);
                            btn.ForeColor = Color.LightGray;
                            btn.Enabled = false;
                            btn.Text = $"{t}\n(No Space)";
                        }
                    }

                    btn.Click += async (s, e) => {
                        _selectedTime = t;
                        await UpdateAvailableTimeSlots(); // Re-run to show duration blocking
                    };

                    pnlTimeSlots.Controls.Add(btn);
                    buttons.Add(btn);
                }

                if (isPastDate) MessageBox.Show("Past dates cannot be selected.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch { }
        }

        private int GetDurationInMinutes(string durationText)
        {
            if (durationText.Contains("30")) return 30;
            if (durationText.Contains("1.5")) return 90;
            if (durationText.Contains("1")) return 60;
            return 30;
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

                // --- FIX: Clean up past-due "Scheduled" appointments first so they don't block new ones ---
                DateTime now = DateTime.Now;
                var pastDue = await _db.Appointments
                    .Where(a => a.PatientID == _selectedPatient.PatientID && a.Status == "Scheduled" && a.AppointmentDate < now.AddMinutes(-30))
                    .ToListAsync();
                
                if (pastDue.Any())
                {
                    foreach (var a in pastDue) a.Status = "Missed";
                    await _db.SaveChangesAsync();
                }

                // Logic Enhancement: Prevent multiple active appointments
                var activeAppt = await _db.Appointments
                    .Where(a => a.PatientID == _selectedPatient.PatientID && a.Status == "Scheduled")
                    .FirstOrDefaultAsync();

                if (activeAppt != null)
                {
                    string apptInfo = activeAppt.AppointmentDate.HasValue 
                        ? activeAppt.AppointmentDate.Value.ToString("f") 
                        : "an upcoming date";
                        
                    MessageBox.Show($"{_selectedPatient.FullName} already has an active scheduled appointment for {apptInfo}.\n\nPatients can only have one active appointment at a time. Please complete or cancel the existing one first.", "Active Appointment Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? doctorId = (cmbDoctor.SelectedItem as Staff)?.StaffID;

                var appt = new Appointment
                {
                    PatientID = _selectedPatient.PatientID,
                    DoctorID = doctorId,
                    DoctorName = cmbDoctor.Text,
                    AppointmentType = cmbApptType.Text,
                    AppointmentDate = appointmentDateTime, // Full precision for calendar
                    DurationMinutes = GetDurationInMinutes(cmbDuration.Text),
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
