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
        private System.Collections.Generic.Dictionary<MedicationSchedule, int> _medIntervals = new System.Collections.Generic.Dictionary<MedicationSchedule, int>();

        public Clinical_Session(int appointmentId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            
            // Load appointment immediately to prevent NullReference
            try {
                _appointment = _db.Appointments.Find(_appointmentId);
            } catch { }

            btnMenuDiagnosis.Click += new EventHandler(BtnMenuDiagnosis_Click);
            btnMenuVitals.Click += new EventHandler(BtnMenuVitals_Click);
            btnMenuPrescription.Click += new EventHandler(BtnMenuPrescription_Click);
            
            this.Load += new EventHandler(Clinical_Session_Load);
            this.Shown += new EventHandler(Clinical_Session_Shown);
            
            this.cmbMedication.Text = "";
            this.txtDosage.Text = "";
            this.txtFrequency.Text = "";
            
            // Load medications when the form is shown, not in constructor
            
            
            // Wire up Auto-fetch early
            this.cmbMedication.SelectedIndexChanged -= CmbMedication_SelectedIndexChanged;
            this.cmbMedication.SelectedIndexChanged += CmbMedication_SelectedIndexChanged;
            this.cmbMedication.SelectionChangeCommitted -= CmbMedication_SelectedIndexChanged;
            this.cmbMedication.SelectionChangeCommitted += CmbMedication_SelectedIndexChanged;
            this.cmbMedication.TextChanged += (s, ev) => UpdateReminderPreview();
            this.txtFrequency.TextChanged += (s, ev) => UpdateReminderPreview();
            
            // Ensure Cancel button is active and visible
            this.btnCancel.Visible = true;
            this.btnCancel.Enabled = true;
            this.btnCancel.Click -= BtnCancel_Click;
            this.btnCancel.Click += BtnCancel_Click;
            
            // Vitals and Prescriptions will be wired in Clinical_Session_Shown for reliability
        }

        private void Clinical_Session_Shown(object sender, EventArgs e)
        {
            PopulateVitals();
            LoadPrescriptions();
            LoadMedicationLists();

            // Explicitly wire buttons once the form is fully rendered
            this.btnAddMed.Click -= BtnAddMed_Click;
            this.btnAddMed.Click += BtnAddMed_Click;

            this.btnSaveVitals.Click -= BtnSaveVitals_Click;
            this.btnSaveVitals.Click += BtnSaveVitals_Click;

            // Wire up Scheduling
            this.dtpStartTime.ValueChanged += (s, ev) => UpdateReminderPreview();
            this.numInterval.ValueChanged += (s, ev) => UpdateReminderPreview();
            UpdateReminderPreview();



            // Wire up BMI calculation
            txtWeight.TextChanged -= TxtVitals_TextChanged;
            txtWeight.TextChanged += TxtVitals_TextChanged;
            txtHeight.TextChanged -= TxtVitals_TextChanged;
            txtHeight.TextChanged += TxtVitals_TextChanged;
        }

        private void UpdateReminderPreview()
        {
            if (flpReminderPreview == null) return;
            flpReminderPreview.Controls.Clear();

            // Default state: no medication, no reminders
            if (string.IsNullOrWhiteSpace(cmbMedication.Text)) return;

            DateTime startTime = dtpStartTime.Value;
            int interval = (int)numInterval.Value;

            int maxBoxes = 24 / interval;
            
            // Derive exact box count from frequency text to match user expectation
            string freq = txtFrequency.Text.ToLower();
            if (freq.Contains("1x") || freq.Contains("once") || freq.Contains("one")) maxBoxes = 1;
            else if (freq.Contains("2x") || freq.Contains("twice") || freq.Contains("two")) maxBoxes = 2;
            else if (freq.Contains("3x") || freq.Contains("three")) maxBoxes = 3;
            else if (freq.Contains("4x") || freq.Contains("four")) maxBoxes = 4;
            else if (freq.Contains("5x") || freq.Contains("five")) maxBoxes = 5;
            
            if (maxBoxes > 6) maxBoxes = 6; // UI limit

            for (int i = 0; i < maxBoxes; i++)
            {
                DateTime reminderTime = startTime.AddHours(i * interval);

                var tag = new Label { 
                    Text = reminderTime.ToString("hh:mm tt"), 
                    AutoSize = true, 
                    BackColor = Color.White, 
                    ForeColor = Color.FromArgb(51, 65, 85),
                    Padding = new Padding(8, 4, 8, 4),
                    Margin = new Padding(0, 0, 8, 0),
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Segoe UI", 8.5F)
                };
                
                // Add rounded look to tag via logic or just standard padding
                flpReminderPreview.Controls.Add(tag);
            }
        }

        private void CmbMedication_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMedication.SelectedItem is Medication medInfo)
                {
                    txtDosage.Text = medInfo.DosageUnit;
                    txtFrequency.Text = medInfo.Frequency;

                    // Auto-adjust interval based on frequency keywords
                    string freq = medInfo.Frequency?.ToLower() ?? "";
                    if (freq.Contains("4 hours")) numInterval.Value = 4;
                    else if (freq.Contains("6 hours") || freq.Contains("4x")) numInterval.Value = 6;
                    else if (freq.Contains("8 hours") || freq.Contains("3x")) numInterval.Value = 8;
                    else if (freq.Contains("12 hours") || freq.Contains("2x")) numInterval.Value = 12;
                    else if (freq.Contains("once") || freq.Contains("24 hours") || freq.Contains("1x")) numInterval.Value = 24;

                    UpdateReminderPreview();
                }
            }
            catch { }
        }

        private void BtnMenuDiagnosis_Click(object sender, EventArgs e) => ShowSection(pnlDiagnosisSection, btnMenuDiagnosis);
        private void BtnMenuVitals_Click(object sender, EventArgs e) => ShowSection(pnlVitalsSection, btnMenuVitals);
        private void BtnMenuPrescription_Click(object sender, EventArgs e) => ShowSection(pnlPrescriptionsSection, btnMenuPrescription);

        private void TxtVitals_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
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
                    
                    int nameWidth = TextRenderer.MeasureText(_patient.FullName, lblPatientName.Font).Width;
                    lblAppointmentDate.Location = new Point(lblPatientName.Left + nameWidth + 10, lblPatientName.Top + 6);
                }
                txtDiagnosis.Text = _appointment.Diagnosis;
                txtChiefComplaint.Text = _appointment.ChiefComplaint; 
                txtPlanNotes.Text = _appointment.DoctorNotes;

                if (_appointment.Status == "Completed")
                {
                    txtDiagnosis.ReadOnly = true;
                    txtChiefComplaint.ReadOnly = true;
                    txtPlanNotes.ReadOnly = true;
                    txtGoal.ReadOnly = true;
                    dtpGoalDate.Enabled = false;
                    btnSave.Visible = false;
                    chkDischarge.Visible = false;
                    btnCancel.Text = "Close";
                    lblTitle.Text = "Clinical Session (Review)";

                    // Vitals
                    txtSystolic.ReadOnly = true;
                    txtDiastolic.ReadOnly = true;
                    txtHR.ReadOnly = true;
                    txtTemp.ReadOnly = true;
                    txtWeight.ReadOnly = true;
                    txtHeight.ReadOnly = true;
                    cmbBloodType.Enabled = false;
                    txtAllergies.ReadOnly = true;
                    btnSaveVitals.Visible = false;

                    // Prescriptions
                    cmbMedication.Enabled = false;
                    txtDosage.ReadOnly = true;
                    txtFrequency.ReadOnly = true;
                    dtpStartTime.Enabled = false;
                    numInterval.Enabled = false;
                    dtpStartDate.Enabled = false;
                    dtpEndDate.Enabled = false;
                    btnAddMed.Visible = false;
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
            
            // Fallback ensure patient is loaded
            if (_patient == null) {
                _patient = _db.Patients.Find(_appointment.PatientID);
            }

            txtSystolic.Text = _appointment.BloodPressure?.Split('/')[0];
            txtDiastolic.Text = _appointment.BloodPressure?.Split('/').Length > 1 ? _appointment.BloodPressure.Split('/')[1] : "";
            txtHR.Text = _appointment.HeartRate?.ToString();
            txtTemp.Text = _appointment.Temperature?.ToString();
            txtWeight.Text = _appointment.Weight?.ToString() ?? _patient?.Weight;
            txtHeight.Text = _appointment.Height?.ToString() ?? _patient?.Height;
            cmbBloodType.Text = _patient?.BloodType ?? "Unknown";
            txtAllergies.Text = _patient?.Allergies ?? "";
            CalculateBMI();
            LoadVitalsHistory();
        }

        private void LoadVitalsHistory()
        {
            if (_patient == null && _appointment != null)
            {
                _patient = _db.Patients.Find(_appointment.PatientID);
            }
            if (_patient == null) return;
            
            // Force a UI refresh by clearing the data source first
            dgvVitalsHistory.DataSource = null;
            
            var history = _db.Appointments
                .Where(a => a.PatientID == _patient.PatientID && (!string.IsNullOrEmpty(a.BloodPressure) || !string.IsNullOrEmpty(a.Weight)))
                .OrderByDescending(a => a.AppointmentDate)
                .ToList() // Pull to memory to ensure latest changes are seen
                .Select(a => new {
                    Date = a.AppointmentDate.HasValue ? a.AppointmentDate.Value.ToString("MM/dd/yy") : "N/A",
                    BP = a.BloodPressure ?? "N/A",
                    HR = a.HeartRate ?? "N/A",
                    Temp = a.Temperature != null ? a.Temperature + "°C" : "N/A",
                    Weight = a.Weight != null ? a.Weight + "kg" : "N/A",
                    BMI = a.BMI ?? "N/A"
                })
                .ToList();

            dgvVitalsHistory.DataSource = history;
        }

        private async void BtnSaveVitals_Click(object sender, EventArgs e)
        {
            try
            {
                if (_appointment == null) {
                    _appointment = _db.Appointments.Find(_appointmentId);
                }
                
                if (_appointment == null) {
                    MessageBox.Show("Error: Appointment record not found. Please try opening the session again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _appointment.BloodPressure = $"{txtSystolic.Text}/{txtDiastolic.Text}";
                _appointment.Temperature = txtTemp.Text;
                _appointment.HeartRate = txtHR.Text;
                _appointment.Weight = txtWeight.Text;
                _appointment.Height = txtHeight.Text;
                _appointment.BMI = lblBMI.Text;

                if (_patient != null)
                {
                    _patient.BloodType = cmbBloodType.Text;
                    _patient.Allergies = txtAllergies.Text;
                    _patient.Weight = txtWeight.Text;
                    _patient.Height = txtHeight.Text;
                    _db.Patients.Update(_patient);
                }

                await _db.SaveChangesAsync();
                LoadVitalsHistory();
                MessageBox.Show("Vital signs updated successfully!", "Vitals Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Error saving vitals: " + ex.Message); }
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
            try
            {
                cmbMedication.Items.Clear();
                cmbMedication.DisplayMember = "MedicationName"; // Explicitly force it to display the name
                
                using (var db = new AppDbContext())
                {
                    var dbMeds = db.Medications.OrderBy(m => m.MedicationName).ToList();
                    if (dbMeds.Any())
                    {
                        foreach (var med in dbMeds) cmbMedication.Items.Add(med);
                    }
                    else
                    {
                        cmbMedication.Items.Add(new Medication { MedicationName = "Ibuprofen", DosageUnit = "200mg", Frequency = "6 hours" });
                        cmbMedication.Items.Add(new Medication { MedicationName = "Paracetamol", DosageUnit = "500mg", Frequency = "4 hours" });
                        cmbMedication.Items.Add(new Medication { MedicationName = "Amoxicillin", DosageUnit = "500mg", Frequency = "8 hours" });
                    }
                }
                cmbMedication.SelectedIndex = -1;
                cmbMedication.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medications: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddMed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMedication.Text)) return;
            
            if (_appointment == null) {
                _appointment = _db.Appointments.Find(_appointmentId);
            }

            if (_appointment == null) {
                MessageBox.Show("Cannot add medication: Appointment data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedMedId = 0;
            if (cmbMedication.SelectedItem is Medication selectedMed) {
                selectedMedId = selectedMed.MedicationID;
            }

            var med = new MedicationSchedule {
                MedicationName = cmbMedication.Text,
                MedicationID = selectedMedId,
                DosageUnit = txtDosage.Text,
                Frequency = txtFrequency.Text,
                AppointmentID = _appointmentId,
                PatientID = _appointment.PatientID ?? 0,
                Status = "Active",
                ScheduledDate = DateOnly.FromDateTime(dtpStartDate.Value),
                ScheduledTime = TimeOnly.FromDateTime(dtpStartTime.Value)
            };
            _newPrescriptions.Add(med);
            _medIntervals[med] = (int)numInterval.Value;
            
            // Clear inputs for next entry
            cmbMedication.Text = "";
            txtDosage.Text = "";
            txtFrequency.Text = "";
            cmbMedication.Focus();
            
            RefreshPrescriptionPad();
        }

        private void RefreshPrescriptionPad()
        {
            if (pnlPrescriptions == null) return;
            pnlPrescriptions.Controls.Clear();

            // 1. Show Existing Prescriptions (from DB)
            var existing = _db.MedicationSchedules
                .Where(ms => ms.AppointmentID == _appointmentId)
                .ToList();

            foreach (var p in existing)
            {
                var card = CreateMedCard(p, false);
                pnlPrescriptions.Controls.Add(card);
            }

            // 2. Show New Prescriptions (Not yet saved)
            foreach (var p in _newPrescriptions)
            {
                var card = CreateMedCard(p, true);
                pnlPrescriptions.Controls.Add(card);
            }
            
            // Update the counter label (find it in the parent section)
            var lblMedCount = pnlPrescriptionsSection.Controls.OfType<Label>().FirstOrDefault(l => l.Text.Contains("medications"));
            if (lblMedCount != null)
            {
                int total = pnlPrescriptions.Controls.Count;
                if (pnlPrescriptions.Controls.Count == 1 && pnlPrescriptions.Controls[0] is Label l && l.Text.Contains("No medications"))
                {
                    total = 0;
                }
                lblMedCount.Text = $"{total} medications";
            }
            
            if (pnlPrescriptions.Controls.Count == 0)
            {
                pnlPrescriptions.Controls.Add(new Label { Text = "No medications prescribed.", ForeColor = Color.Gray, AutoSize = true, Margin = new Padding(10) });
            }
        }

        private Panel CreateMedCard(MedicationSchedule p, bool isNew)
        {
            var card = new Panel { Size = new Size(650, 60), BackColor = isNew ? Color.FromArgb(240, 253, 244) : Color.FromArgb(245, 248, 250), Margin = new Padding(0, 0, 0, 10) };
            card.Controls.Add(new Label { Text = $"💊 {p.MedicationName}", Location = new Point(15, 10), Font = new Font("Segoe UI", 10F, FontStyle.Bold), AutoSize = true });
            card.Controls.Add(new Label { Text = $"{p.DosageUnit} | {p.Frequency}", Location = new Point(15, 35), ForeColor = Color.Gray, AutoSize = true });
            
            if (isNew)
            {
                card.Controls.Add(new Label { Text = "NEW", Location = new Point(540, 10), Font = new Font("Segoe UI", 7F, FontStyle.Bold), ForeColor = Color.Green, AutoSize = true });
                var btnDel = new Button { Text = "🗑", Location = new Point(600, 15), Size = new Size(30, 30), FlatStyle = FlatStyle.Flat };
                btnDel.Click += (s, ev) => { _newPrescriptions.Remove(p); RefreshPrescriptionPad(); };
                card.Controls.Add(btnDel);
            }
            else
            {
                card.Controls.Add(new Label { Text = "SAVED", Location = new Point(580, 20), Font = new Font("Segoe UI", 8F), ForeColor = Color.LightSlateGray, AutoSize = true });
            }
            return card;
        }

        private void LoadPrescriptions()
        {
            RefreshPrescriptionPad();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
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
                
                // Handle Discharge if checked
                if (chkDischarge.Checked && _patient != null)
                {
                    _patient.Status = "Discharged";
                    _db.Patients.Update(_patient);
                }

                // Create a Treatment Plan from the Session
                if (_patient != null)
                {
                    string fullPlan = $"DIAGNOSIS/ASSESSMENT: {txtDiagnosis.Text}\r\nCHIEF COMPLAINT: {txtChiefComplaint.Text}\r\nGOAL: {txtGoal.Text}\r\n\r\nPLAN & MANAGEMENT:\r\n{txtPlanNotes.Text}";
                    
                    var plan = new TreatmentPlan
                    {
                        PatientID = _patient.PatientID,
                        PlanDetails = fullPlan,
                        StartDate = DateTime.Now,
                        EndDate = dtpGoalDate.Value,
                        CreatedAt = DateTime.Now
                    };
                    _db.TreatmentPlans.Add(plan);
                }

                if (_newPrescriptions.Any())
                {
                    var expandedPrescriptions = new System.Collections.Generic.List<MedicationSchedule>();
                    
                    foreach (var p in _newPrescriptions)
                    {
                        if (p.ScheduledDate == default) p.ScheduledDate = DateOnly.FromDateTime(DateTime.Today);
                        
                        int interval = _medIntervals.ContainsKey(p) ? _medIntervals[p] : 8;
                        int maxBoxes = 24 / interval;
                        if (maxBoxes < 1) maxBoxes = 1;
                        
                        DateTime startDt = p.ScheduledDate.ToDateTime(p.ScheduledTime ?? new TimeOnly(8, 0));
                        
                        // Generate doses for 7 days
                        for (int day = 0; day < 7; day++)
                        {
                            for (int dose = 0; dose < maxBoxes; dose++)
                            {
                                DateTime doseDt = startDt.AddDays(day).AddHours(dose * interval);
                                
                                expandedPrescriptions.Add(new MedicationSchedule {
                                    MedicationName = p.MedicationName,
                                    MedicationID = p.MedicationID,
                                    DosageUnit = p.DosageUnit,
                                    Frequency = p.Frequency,
                                    AppointmentID = p.AppointmentID,
                                    PatientID = p.PatientID,
                                    Status = p.Status,
                                    ScheduledDate = DateOnly.FromDateTime(doseDt),
                                    ScheduledTime = TimeOnly.FromDateTime(doseDt),
                                    IsTaken = false,
                                    IsMissed = false
                                });
                            }
                        }
                    }
                    _db.MedicationSchedules.AddRange(expandedPrescriptions);
                }

                try 
                {
                    await _db.SaveChangesAsync();
                    string msg = chkDischarge.Checked ? "Clinical session recorded and patient discharged." : "Clinical session recorded successfully.";
                    MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    string innerError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    MessageBox.Show("Failed to save session. Details: " + innerError, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) => this.Close();

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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84) m.Result = (IntPtr)0x2; // WM_NCHITTEST -> HTCAPTION
        }
    }
}
