using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Doctor.Forms;

namespace elnet_recoverease.Doctor.Controls
{
    public partial class PatientListControl : UserControl
    {
        private AppDbContext _db = new AppDbContext();
        private Staff _doctor;

        public PatientListControl()
        {
            InitializeComponent();
            _doctor = UserSession.CurrentStaff;
            InitializeUI();
            LoadPatientsData();
        }

        private void InitializeUI()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadPatientsData(txtSearch.Text);

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoadPatientsData(txtSearch.Text);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (var regForm = new Register_Patient())
            {
                if (regForm.ShowDialog() == DialogResult.OK) LoadPatientsData();
            }
        }

        private async void LoadPatientsData(string searchTerm = "")
        {
            try
            {
                if (_doctor == null) return;

                var query = _db.Patients.Where(p => p.AttendingDoctor == _doctor.FullName);
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(p => p.FullName.Contains(searchTerm) || p.PatientCode.Contains(searchTerm));
                }

                var patientData = await query
                    .OrderBy(p => p.FullName)
                    .Select(p => new {
                        p.PatientID,
                        p.PatientCode,
                        p.FullName,
                        p.EmergencyPhone,
                        LastVisitDate = _db.Appointments
                            .Where(a => a.PatientID == p.PatientID && a.Status == "Completed")
                            .OrderByDescending(a => a.AppointmentDate)
                            .Select(a => a.AppointmentDate)
                            .FirstOrDefault()
                    })
                    .ToListAsync();

                dgvPatients.Rows.Clear();
                foreach (var item in patientData)
                {
                    string lastVisitStr = item.LastVisitDate.HasValue ? item.LastVisitDate.Value.ToString("MM/dd/yyyy") : "Never";
                    int rowIndex = dgvPatients.Rows.Add(
                        item.PatientCode ?? item.PatientID.ToString(),
                        item.FullName,
                        item.EmergencyPhone ?? "N/A",
                        lastVisitStr,
                        "Details",
                        "Schedule"
                    );
                    dgvPatients.Rows[rowIndex].Tag = item.PatientID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int patientId = (int)dgvPatients.Rows[e.RowIndex].Tag;

            if (dgvPatients.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                OpenPatientDetails(patientId);
            }
            else if (dgvPatients.Columns[e.ColumnIndex].HeaderText == "Booking")
            {
                using (var schedForm = new Appointment_Form(patientId))
                {
                    schedForm.ShowDialog();
                }
            }
        }

        private void OpenPatientDetails(int patientId)
        {
            if (this.ParentForm is DoctorMainForm main)
            {
                main.LoadPatientDetails(patientId);
            }
        }

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvPatients.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                var rect = e.CellBounds;
                rect.Inflate(-4, -6);

                bool isSchedule = dgvPatients.Columns[e.ColumnIndex].HeaderText == "Booking";
                Color btnColor = isSchedule ? Color.FromArgb(0, 168, 168) : Color.FromArgb(240, 245, 250);
                Color textColor = isSchedule ? Color.White : Color.FromArgb(20, 35, 65);
                string text = isSchedule ? "Schedule" : "Details";

                using (var brush = new SolidBrush(btnColor)) e.Graphics.FillRectangle(brush, rect);
                TextRenderer.DrawText(e.Graphics, text, e.CellStyle.Font, rect, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }
        }
    }
}
