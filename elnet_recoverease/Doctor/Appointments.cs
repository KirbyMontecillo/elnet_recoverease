using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Admin;

namespace elnet_recoverease.Doctor
{
    public partial class Appointments : Form
    {
        private AppDbContext _db = new AppDbContext();
        private Staff _doctor;
        private bool _userChangedDate = false;

        public Appointments()
        {
            InitializeComponent();
            _doctor = UserSession.CurrentStaff;
            
            SetLogo();
            InitializeUI();
            LoadAppointments();
        }

        private void SetLogo()
        {
            try 
            { 
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) picLogo.Image = Image.FromFile(logoPath);
            } 
            catch { }
        }

        private void InitializeUI()
        {
            if (_doctor != null)
            {
                lblAvatarInitials.Text = GetInitials(_doctor.FullName);
            }

            // Navigation Handlers
            NavigationHelper.WireNavButton(btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(btnNavProfile, new EventHandler(btnNavProfile_Click));
            btnLogout.Click += new EventHandler(btnLogout_Click);

            // Filter Handlers
            dtpFilterDate.ValueChanged += new EventHandler(dtpFilterDate_ValueChanged);
            cmbFilterStatus.SelectedIndexChanged += new EventHandler(cmbFilterStatus_SelectedIndexChanged);

            btnNewAppointment.Click += new EventHandler(btnNewAppointment_Click);

            // Grid Customization
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 245, 245); // Soft Teal Mist
            dgvAppointments.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 35, 65);
            
            dgvAppointments.CellFormatting += DgvAppointments_CellFormatting;
            dgvAppointments.CellPainting += Dgv_CellPainting; // Stylized buttons
            dgvAppointments.CellContentClick += new DataGridViewCellEventHandler(dgvAppointments_CellContentClick);
            dgvAppointments.CellDoubleClick += new DataGridViewCellEventHandler(dgvAppointments_CellDoubleClick);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Doctor_Dashboard());
        }

        private void btnNavPatients_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Patient_List());
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Reports());
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Doctor_Profile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
            _userChangedDate = true;
            LoadAppointments();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            using (var apptForm = new Appointment_Form())
            {
                if (apptForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAppointments();
                }
            }
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAppointments.Columns[e.ColumnIndex].HeaderText == "ACTION") {
                string status = dgvAppointments.Rows[e.RowIndex].Cells[2].Value?.ToString();
                if (status == "Scheduled") {
                    var apptId = (int)dgvAppointments.Rows[e.RowIndex].Tag;
                    StartConsultation(apptId);
                }
            }
        }

        private void dgvAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                var apptId = (int)dgvAppointments.Rows[e.RowIndex].Tag;
                StartConsultation(apptId);
            }
        }



        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "Dr";
            var parts = name.Split(' ');
            if (parts.Length == 1) return parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private async void LoadAppointments()
        {
            try
            {
                if (_doctor == null) 
                {
                    MessageBox.Show("No active doctor session found. Please log in again.", "Session Error");
                    return;
                }

                DateTime now = DateTime.Now;
                DateTime pastThreshold = now.AddMinutes(-30);

                // Auto-mark missed for this doctor
                var missedToUpdate = await _db.Appointments
                    .Where(a => (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)) 
                           && a.Status == "Scheduled" && a.AppointmentDate < pastThreshold)
                    .ToListAsync();
                
                if (missedToUpdate.Any())
                {
                    foreach (var a in missedToUpdate) a.Status = "Missed";
                    await _db.SaveChangesAsync();
                }

                // Cleanup: Revert any accidental 'InProgress' to 'Scheduled'
                var stuckInProgress = await _db.Appointments.Where(a => a.Status == "InProgress").ToListAsync();
                if (stuckInProgress.Any())
                {
                    foreach (var a in stuckInProgress) a.Status = "Scheduled";
                    await _db.SaveChangesAsync();
                }

                string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "All";

                // Dynamic Filtering
                var query = _db.Appointments
                    .Where(a => (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)))
                    .Join(_db.Patients, a => (int)a.PatientID, p => p.PatientID, (a, p) => new { a, p })
                    .Where(x => x.p.AttendingDoctor == _doctor.FullName);

                if (_userChangedDate)
                {
                    DateTime dayStart = dtpFilterDate.Value.Date;
                    DateTime dayEnd = dayStart.AddDays(1);
                    query = query.Where(x => x.a.AppointmentDate >= dayStart && x.a.AppointmentDate < dayEnd);
                }
                else
                {
                    // Default View: Show everything from "Today" onwards (and maybe 1 day past for 'Recent' context)
                    DateTime defaultThreshold = DateTime.Now.Date.AddDays(-1);
                    query = query.Where(x => x.a.AppointmentDate >= defaultThreshold);
                }

                if (filterStatus != "All")
                {
                    query = query.Where(x => x.a.Status == filterStatus);
                }

                var list = await query
                    .OrderBy(x => x.a.Status == "Scheduled" ? 0 : 1)
                    .ThenBy(x => x.a.AppointmentDate)
                    .ToListAsync();

                dgvAppointments.Rows.Clear();
                foreach (var item in list)
                {
                    int rowIndex = dgvAppointments.Rows.Add(
                        item.p.FullName,
                        item.a.AppointmentDate?.ToString("MMM dd, yyyy | hh:mm tt") ?? "N/A",
                        item.a.Status,
                        item.a.Notes ?? "No clinical notes.",
                        "CONSULT"
                    );
                    dgvAppointments.Rows[rowIndex].Tag = item.a.AppointmentID;
                }

                // New: Summary Alert
                if (list.Count == 0)
                {
                    var anyAppts = await _db.Appointments.AnyAsync(a => a.DoctorName == _doctor.FullName);
                    if (anyAppts)
                    {
                        // Optional: Show a small label or toast saying "You have appointments on other dates"
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching clinical data: " + ex.Message + "\n\nDetails: " + ex.InnerException?.Message, "Sync Error");
            }
        }

        private void DgvAppointments_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAppointments.Columns[e.ColumnIndex].HeaderText == "STATUS" && e.Value != null)
            {

                string status = e.Value.ToString();
                switch (status)
                {
                    case "Completed":
                        e.CellStyle.ForeColor = Color.FromArgb(39, 174, 96);
                        e.CellStyle.Font = new Font(dgvAppointments.Font, FontStyle.Bold);
                        break;
                    case "Cancelled":
                        e.CellStyle.ForeColor = Color.FromArgb(192, 57, 43);
                        break;
                    case "Scheduled":
                        e.CellStyle.ForeColor = Color.FromArgb(41, 128, 185);
                        break;
                    case "Missed":
                        e.CellStyle.ForeColor = Color.FromArgb(192, 57, 43);
                        e.CellStyle.Font = new Font(dgvAppointments.Font, FontStyle.Italic);
                        break;
                }
            }
        }

        private async void StartConsultation(int apptId)
        {
            try
            {
                var appt = await _db.Appointments
                    .Include(a => a.Patient)
                    .FirstOrDefaultAsync(a => a.AppointmentID == apptId);

                if (appt == null) return;

                DateTime now = DateTime.Now;
                DateTime apptTime = appt.AppointmentDate ?? DateTime.Now;

                // Step 1 & 2: Check if appointment time has not started yet
                if (now < apptTime)
                {
                    string timeStr = apptTime.ToString("hh:mm tt");
                    var result = MessageBox.Show(
                        $"The appointment for {appt.PatientName} is scheduled at {timeStr}. The patient may have arrived early. Do you want to start the consultation now?",
                        "Early Arrival",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No) return;
                }

                // Step 3: Proceed to consultation
                using (var sessionForm = new Clinical_Session(apptId))
                {
                    if (sessionForm.ShowDialog() == DialogResult.OK)
                    {
                        // Status is updated to 'Completed' inside Clinical_Session finalize
                    }
                    
                    LoadAppointments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting consultation: " + ex.Message);
            }
        }
        private void Dgv_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Target ACTION column (last column)
            if (dgvAppointments.Columns[e.ColumnIndex].HeaderText == "ACTION")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                
                var rect = e.CellBounds;
                rect.Inflate(-8, -6); // More button-like padding

                // Determine color based on status
                string status = dgvAppointments.Rows[e.RowIndex].Cells[2].Value?.ToString();
                bool isScheduled = status == "Scheduled";
                
                Color btnColor = isScheduled ? Color.FromArgb(0, 140, 140) : Color.FromArgb(180, 190, 200);
                if (status == "Missed") btnColor = Color.FromArgb(231, 76, 60); // Red for missed
                
                Color txtColor = (isScheduled || status == "Missed") ? Color.White : Color.FromArgb(100, 110, 120);

                // Draw Button Background
                using (var brush = new SolidBrush(btnColor))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }

                // Draw Button Text
                string btnText = isScheduled ? "CONSULT" : status.ToUpper();
                TextRenderer.DrawText(e.Graphics, btnText, new Font("Segoe UI", 8.5f, FontStyle.Bold), rect, txtColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                
                e.Handled = true;
            }
        }
    }
}
