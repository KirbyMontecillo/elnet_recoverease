using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Doctor
{
    public partial class Prescribe_Medicine : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _patientId;
        private List<Medication> _medications;

        // UI Controls
        private ComboBox cmbMedication = new ComboBox();
        private ComboBox cmbFrequency = new ComboBox();
        private DateTimePicker dtpStart = new DateTimePicker();
        private DateTimePicker dtpEnd = new DateTimePicker();
        private TextBox txtNotes = new TextBox();
        private Button btnPrescribe = new Button();
        private Button btnCancel = new Button();

        public Prescribe_Medicine(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            SetupUI();
            LoadMedications();
        }

        private void SetupUI()
        {
            this.Text = "Digital Prescription Pad";
            this.Size = new Size(500, 550);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(242, 247, 250);
            this.Font = new Font("Segoe UI", 9f);

            Panel pnlHeader = new Panel {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(0, 168, 168),
                Padding = new Padding(20, 15, 0, 0)
            };
            Label lblTitle = new Label {
                Text = "PRESCRIPTION WORKSTATION",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblTitle);

            // Labels and Inputs
            Label lblMed = new Label { Text = "Select Medication:", Location = new Point(30, 80), AutoSize = true };
            cmbMedication.Location = new Point(30, 105);
            cmbMedication.Width = 420;
            cmbMedication.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblFreq = new Label { Text = "Frequency (Intakes per day):", Location = new Point(30, 155), AutoSize = true };
            cmbFrequency.Items.AddRange(new object[] { "1x Daily", "2x Daily", "3x Daily", "4x Daily", "As Needed" });
            cmbFrequency.Location = new Point(30, 180);
            cmbFrequency.Width = 200;
            cmbFrequency.DropDownStyle = ComboBoxStyle.DropDownList;

            Label lblStart = new Label { Text = "Start Date:", Location = new Point(30, 230), AutoSize = true };
            dtpStart.Location = new Point(30, 255);
            dtpStart.Width = 200;
            dtpStart.Format = DateTimePickerFormat.Short;

            Label lblEnd = new Label { Text = "End Date (Target Completion):", Location = new Point(250, 230), AutoSize = true };
            dtpEnd.Location = new Point(250, 255);
            dtpEnd.Width = 200;
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Value = DateTime.Now.AddDays(7);

            Label lblNotes = new Label { Text = "Special Instructions / Notes:", Location = new Point(30, 305), AutoSize = true };
            txtNotes.Location = new Point(30, 330);
            txtNotes.Size = new Size(420, 100);
            txtNotes.Multiline = true;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;

            btnPrescribe.Text = "Issue Prescription";
            btnPrescribe.Location = new Point(250, 450);
            btnPrescribe.Size = new Size(200, 40);
            btnPrescribe.BackColor = Color.FromArgb(0, 168, 168);
            btnPrescribe.ForeColor = Color.White;
            btnPrescribe.FlatStyle = FlatStyle.Flat;
            btnPrescribe.FlatAppearance.BorderSize = 0;
            btnPrescribe.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(140, 450);
            btnCancel.Size = new Size(100, 40);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Click += new EventHandler(btnCancel_Click);

            btnPrescribe.Click += BtnPrescribe_Click;

            this.Controls.Add(pnlHeader);
            this.Controls.Add(lblMed);
            this.Controls.Add(cmbMedication);
            this.Controls.Add(lblFreq);
            this.Controls.Add(cmbFrequency);
            this.Controls.Add(lblStart);
            this.Controls.Add(dtpStart);
            this.Controls.Add(lblEnd);
            this.Controls.Add(dtpEnd);
            this.Controls.Add(lblNotes);
            this.Controls.Add(txtNotes);
            this.Controls.Add(btnPrescribe);
            this.Controls.Add(btnCancel);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LoadMedications()
        {
            _medications = await _db.Medications.ToListAsync();
            cmbMedication.DataSource = _medications;
            cmbMedication.DisplayMember = "MedicationName";
            cmbMedication.ValueMember = "MedicationID";
        }

        private async void BtnPrescribe_Click(object sender, EventArgs e)
        {
            if (cmbMedication.SelectedItem == null || cmbFrequency.SelectedItem == null)
            {
                MessageBox.Show("Please select both medication and frequency.");
                return;
            }

            try
            {
                var med = (Medication)cmbMedication.SelectedItem;
                int timesPerDay = cmbFrequency.SelectedIndex + 1; // 1x, 2x, etc.
                if (cmbFrequency.Text == "As Needed") timesPerDay = 1;

                TimeSpan interval = TimeSpan.FromHours(24.0 / timesPerDay);
                DateTime current = dtpStart.Value.Date.AddHours(8); // Start at 8 AM

                List<MedicationSchedule> schedules = new List<MedicationSchedule>();

                for (DateTime d = dtpStart.Value.Date; d <= dtpEnd.Value.Date; d = d.AddDays(1))
                {
                    for (int i = 0; i < timesPerDay; i++)
                    {
                        DateTime scheduled = d.AddHours(8).Add(TimeSpan.FromTicks(interval.Ticks * i));
                        
                        schedules.Add(new MedicationSchedule
                        {
                            PatientID = _patientId,
                            MedicationID = med.MedicationID,
                            ScheduledDate = DateOnly.FromDateTime(scheduled),
                            ScheduledTime = TimeOnly.FromDateTime(scheduled),
                            IsTaken = false,
                            IsMissed = false,
                            Notes = txtNotes.Text
                        });
                    }
                }

                _db.MedicationSchedules.AddRange(schedules);
                await _db.SaveChangesAsync();

                MessageBox.Show($"Prescription issued! {schedules.Count} intake sessions scheduled.", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing prescription: " + ex.Message);
            }
        }
    }
}
