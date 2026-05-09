using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Doctor.Controls
{
    public partial class AppointmentsControl : UserControl
    {
        private AppDbContext _db = new AppDbContext();
        private Staff _doctor;
        private bool _userChangedDate = false;

        public AppointmentsControl()
        {
            InitializeComponent();
            _doctor = UserSession.CurrentStaff;
            InitializeUI();
            LoadAppointments();
        }

        private void InitializeUI()
        {
            dtpFilterDate.ValueChanged += new EventHandler(dtpFilterDate_ValueChanged);
            cmbFilterStatus.SelectedIndexChanged += new EventHandler(cmbFilterStatus_SelectedIndexChanged);
            btnNewAppointment.Click += new EventHandler(btnNewAppointment_Click);

            dgvAppointments.CellFormatting += DgvAppointments_CellFormatting;
            dgvAppointments.CellPainting += Dgv_CellPainting;
            dgvAppointments.CellContentClick += new DataGridViewCellEventHandler(dgvAppointments_CellContentClick);
            dgvAppointments.CellDoubleClick += new DataGridViewCellEventHandler(dgvAppointments_CellDoubleClick);

            SetupColumns();
        }

        private void SetupColumns()
        {
            dgvAppointments.Columns.Clear();
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Patient Name", FillWeight = 22 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date & Time", FillWeight = 20 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", FillWeight = 14 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Clinical Notes", FillWeight = 34 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Action", FillWeight = 10 });
        }

        private void dtpFilterDate_ValueChanged(object sender, EventArgs e) { _userChangedDate = true; LoadAppointments(); }
        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadAppointments();

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            using (var apptForm = new Appointment_Form())
            {
                if (apptForm.ShowDialog() == DialogResult.OK) LoadAppointments();
            }
        }

        private async void LoadAppointments()
        {
            try
            {
                if (_doctor == null) return;

                DateTime now = DateTime.Now;
                DateTime pastThreshold = now.AddMinutes(-30);

                var missedToUpdate = await _db.Appointments
                    .Where(a => (a.DoctorID == _doctor.StaffID || (a.DoctorID == null && a.DoctorName == _doctor.FullName)) 
                           && a.Status == "Scheduled" && a.AppointmentDate < pastThreshold)
                    .ToListAsync();
                
                if (missedToUpdate.Any())
                {
                    foreach (var a in missedToUpdate) a.Status = "Missed";
                    await _db.SaveChangesAsync();
                }

                var stuckInProgress = await _db.Appointments.Where(a => a.Status == "InProgress").ToListAsync();
                if (stuckInProgress.Any())
                {
                    foreach (var a in stuckInProgress) a.Status = "Scheduled";
                    await _db.SaveChangesAsync();
                }

                string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "All";
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
                    DateTime defaultThreshold = DateTime.Now.Date.AddDays(-1);
                    query = query.Where(x => x.a.AppointmentDate >= defaultThreshold);
                }

                if (filterStatus != "All") query = query.Where(x => x.a.Status == filterStatus);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching clinical data: " + ex.Message);
            }
        }

        private void DgvAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAppointments.Columns[e.ColumnIndex].HeaderText == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                switch (status)
                {
                    case "Completed": e.CellStyle.ForeColor = Color.FromArgb(39, 174, 96); break;
                    case "Cancelled": e.CellStyle.ForeColor = Color.FromArgb(192, 57, 43); break;
                    case "Scheduled": e.CellStyle.ForeColor = Color.FromArgb(41, 128, 185); break;
                    case "Missed": e.CellStyle.ForeColor = Color.FromArgb(192, 57, 43); e.CellStyle.Font = new Font(dgvAppointments.Font, FontStyle.Italic); break;
                }
            }
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAppointments.Columns[e.ColumnIndex].HeaderText == "Action") {
                string status = dgvAppointments.Rows[e.RowIndex].Cells[2].Value?.ToString();
                if (status == "Scheduled") StartConsultation((int)dgvAppointments.Rows[e.RowIndex].Tag);
            }
        }

        private void dgvAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) StartConsultation((int)dgvAppointments.Rows[e.RowIndex].Tag);
        }

        private async void StartConsultation(int apptId)
        {
            try
            {
                var appt = await _db.Appointments.Include(a => a.Patient).FirstOrDefaultAsync(a => a.AppointmentID == apptId);
                if (appt == null) return;

                if (DateTime.Now < appt.AppointmentDate)
                {
                    if (MessageBox.Show($"Early arrival for {appt.PatientName}. Start consultation now?", "Early Arrival", MessageBoxButtons.YesNo) == DialogResult.No) return;
                }

                using (var sessionForm = new Clinical_Session(apptId))
                {
                    sessionForm.ShowDialog();
                    LoadAppointments();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error starting consultation: " + ex.Message); }
        }

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvAppointments.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                var rect = e.CellBounds;
                rect.Inflate(-8, -10);

                string status = dgvAppointments.Rows[e.RowIndex].Cells[2].Value?.ToString();
                bool isScheduled = status == "Scheduled";
                Color btnColor = isScheduled ? Color.FromArgb(0, 140, 140) : Color.FromArgb(180, 190, 200);
                if (status == "Missed") btnColor = Color.FromArgb(231, 76, 60);
                Color txtColor = (isScheduled || status == "Missed") ? Color.White : Color.FromArgb(100, 110, 120);

                using (var brush = new SolidBrush(btnColor)) e.Graphics.FillRectangle(brush, rect);
                TextRenderer.DrawText(e.Graphics, isScheduled ? "CONSULT" : status.ToUpper(), new Font("Segoe UI", 8.5f, FontStyle.Bold), rect, txtColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }
        }
    }
}
