using System;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Data;
using elnet_recoverease.Models;

namespace elnet_recoverease
{
    public partial class Appointment_Details_Form : Form
    {
        private Appointment _appointment;
        private List<string> _prescribedMeds = new List<string>();

        public Appointment_Details_Form(Appointment appt)
        {
            _appointment = appt;
            SetupDesign();
            LoadMedicationData();
        }

        private void LoadMedicationData()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    // Find unique medications starting on the appointment date for this patient
                    if (_appointment.AppointmentDate.HasValue)
                    {
                        var apptDate = DateOnly.FromDateTime(_appointment.AppointmentDate.Value);
                        _prescribedMeds = db.MedicationSchedules
                            .Where(m => m.PatientID == _appointment.PatientID && m.ScheduledDate == apptDate)
                            .Select(m => $"{m.MedicationName} - {m.DosageUnit} ({m.Frequency})")
                            .Distinct()
                            .ToList();
                    }
                }
            }
            catch { }
            
            LoadAppointmentData();
        }

        private void SetupDesign()
        {
            this.Text = "Appointment Details";
            this.Size = new Size(600, 800);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;

            // Header Panel
            Panel pnlHeader = new Panel { Dock = DockStyle.Top, Height = 70, BackColor = Color.FromArgb(27, 58, 107) };
            Label lblTitle = new Label {
                Text = "Clinical Record",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblTitle);
            this.Controls.Add(pnlHeader);

            // Footer Panel
            Panel pnlFooter = new Panel { Dock = DockStyle.Bottom, Height = 60, BackColor = Color.FromArgb(248, 250, 252) };
            Button btnClose = new Button {
                Text = "Close",
                Size = new Size(120, 40),
                Location = new Point(440, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(27, 58, 107),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            pnlFooter.Controls.Add(btnClose);
            this.Controls.Add(pnlFooter);
        }

        private void LoadAppointmentData()
        {
            FlowLayoutPanel pnlBody = new FlowLayoutPanel {
                Dock = DockStyle.Fill,
                Padding = new Padding(30, 25, 30, 100), // Significant bottom padding
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                BackColor = Color.White
            };

            int itemWidth = 510; // Wider content area

            // Basic Info Header
            AddDetailItem(pnlBody, "Consultation Date", _appointment.AppointmentDate?.ToString("MMMM dd, yyyy - hh:mm tt") ?? "N/A", itemWidth);
            AddDetailItem(pnlBody, "Attending Physician", _appointment.DoctorName ?? "General Staff", itemWidth);
            AddDetailItem(pnlBody, "Session Status", _appointment.Status, itemWidth, _appointment.Status == "Completed" ? Color.Green : Color.Navy);

            // 1. Clinical Notes Section
            AddSectionHeader(pnlBody, "CLINICAL NOTES", itemWidth);
            AddDetailItem(pnlBody, "Chief Complaint", _appointment.ChiefComplaint ?? "No complaints recorded.", itemWidth);
            AddDetailItem(pnlBody, "Diagnosis", _appointment.Diagnosis ?? "No diagnosis recorded.", itemWidth);

            // 2. Vital Signs Section
            AddSectionHeader(pnlBody, "VITAL SIGNS", itemWidth);
            AddVitalsRow(pnlBody, "Blood Pressure", _appointment.BloodPressure ?? "--", "Temperature", _appointment.Temperature ?? "--", itemWidth);
            AddVitalsRow(pnlBody, "Heart Rate", _appointment.HeartRate ?? "--", "BMI", _appointment.BMI ?? "--", itemWidth);
            AddVitalsRow(pnlBody, "Height", _appointment.Height ?? "--", "Weight", _appointment.Weight ?? "--", itemWidth);

            // 3. Prescription & Plan Section
            AddSectionHeader(pnlBody, "PRESCRIPTION & PLAN", itemWidth);
            AddPrescriptionBox(pnlBody, _appointment.PlanNotes ?? "No specific plan recorded for this session.", itemWidth);

            if (_appointment.RecoveryProgress.HasValue)
            {
                AddDetailItem(pnlBody, "Recovery Progress", $"{_appointment.RecoveryProgress}%", itemWidth, Color.FromArgb(0, 168, 168));
            }

            this.Controls.Add(pnlBody);
            pnlBody.BringToFront();
        }

        private void AddSectionHeader(FlowLayoutPanel parent, string title, int width)
        {
            Label lbl = new Label {
                Text = title,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                Margin = new Padding(0, 25, 0, 10),
                AutoSize = true
            };
            parent.Controls.Add(lbl);
            
            // Subtle underline
            Panel line = new Panel { Width = width, Height = 1, BackColor = Color.FromArgb(226, 232, 240), Margin = new Padding(0, 0, 0, 15) };
            parent.Controls.Add(line);
        }

        private void AddDetailItem(FlowLayoutPanel parent, string label, string value, int width, Color? valueColor = null)
        {
            FlowLayoutPanel p = new FlowLayoutPanel { 
                Width = width, 
                AutoSize = true, 
                FlowDirection = FlowDirection.TopDown,
                Margin = new Padding(0, 0, 0, 15)
            };
            
            Label l = new Label { 
                Text = label, 
                Font = new Font("Segoe UI", 8f, FontStyle.Bold), 
                ForeColor = Color.FromArgb(148, 163, 184), 
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 2)
            };
            
            Label v = new Label { 
                Text = value, 
                Font = new Font("Segoe UI", 10f), 
                ForeColor = valueColor ?? Color.FromArgb(30, 41, 59), 
                Width = width - 10,
                AutoSize = true,
                MaximumSize = new Size(width - 10, 0),
                Margin = new Padding(0)
            };
            
            p.Controls.Add(l);
            p.Controls.Add(v);
            parent.Controls.Add(p);
        }

        private void AddPrescriptionBox(FlowLayoutPanel parent, string notes, int width)
        {
            Panel container = new Panel { 
                Width = width, 
                AutoSize = true, 
                BackColor = Color.FromArgb(248, 250, 252),
                Padding = new Padding(15, 20, 15, 20),
                BorderStyle = BorderStyle.None,
                Margin = new Padding(0, 0, 0, 20)
            };

            // Combine Medications and Notes
            string fullPrescription = "";
            if (_prescribedMeds != null && _prescribedMeds.Any())
            {
                fullPrescription += "PRESCRIBED MEDICATIONS:\n";
                foreach (var med in _prescribedMeds)
                {
                    fullPrescription += $" • {med}\n";
                }
                fullPrescription += "\nCLINICAL INSTRUCTIONS:\n";
            }
            fullPrescription += notes;

            Label lbl = new Label {
                Text = fullPrescription,
                Font = new Font("Consolas", 10f),
                ForeColor = Color.FromArgb(30, 41, 59),
                Width = width - 40,
                AutoSize = true,
                MaximumSize = new Size(width - 40, 0),
                Location = new Point(15, 15)
            };

            container.Controls.Add(lbl);
            parent.Controls.Add(container);
            
            // Add a small "Rx" icon/label
            Label rx = new Label {
                Text = "℞",
                Font = new Font("Segoe UI", 16f, FontStyle.Italic),
                ForeColor = Color.FromArgb(203, 213, 225),
                Location = new Point(width - 45, 5),
                AutoSize = true
            };
            container.Controls.Add(rx);
            rx.BringToFront();
        }

        private void AddVitalsRow(FlowLayoutPanel parent, string label1, string val1, string label2, string val2, int width)
        {
            TableLayoutPanel t = new TableLayoutPanel { Width = width, Height = 55, ColumnCount = 2, Margin = new Padding(0, 0, 0, 5) };
            t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));

            Panel p1 = new Panel { Dock = DockStyle.Fill };
            p1.Controls.Add(new Label { Text = label1, Font = new Font("Segoe UI", 8f, FontStyle.Bold), ForeColor = Color.FromArgb(148, 163, 184), Location = new Point(0, 5), AutoSize = true });
            p1.Controls.Add(new Label { Text = val1, Font = new Font("Segoe UI", 10f), ForeColor = Color.FromArgb(30, 41, 59), Location = new Point(0, 22), AutoSize = true });

            Panel p2 = new Panel { Dock = DockStyle.Fill };
            p2.Controls.Add(new Label { Text = label2, Font = new Font("Segoe UI", 8f, FontStyle.Bold), ForeColor = Color.FromArgb(148, 163, 184), Location = new Point(0, 5), AutoSize = true });
            p2.Controls.Add(new Label { Text = val2, Font = new Font("Segoe UI", 10f), ForeColor = Color.FromArgb(30, 41, 59), Location = new Point(0, 22), AutoSize = true });

            t.Controls.Add(p1, 0, 0);
            t.Controls.Add(p2, 1, 0);
            parent.Controls.Add(t);
        }
    }
}
