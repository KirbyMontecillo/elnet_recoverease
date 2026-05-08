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
    public partial class Patient_List : Form
    {
        private AppDbContext _db = new AppDbContext();
        private Staff _doctor;

        public Patient_List()
        {
            InitializeComponent();
            _doctor = UserSession.CurrentStaff;

            SetLogo();
            InitializeUI();
            LoadPatientsData();
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

            // Navigation Handlers - Classic way (No lambdas)
            NavigationHelper.WireNavButton(btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(btnNavAppointments, new EventHandler(btnNavAppointments_Click));
            NavigationHelper.WireNavButton(btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(btnNavProfile, new EventHandler(btnNavProfile_Click));
            btnLogout.Click += new EventHandler(btnLogout_Click);

            // Action Handlers
            btnSearch.Click += new EventHandler(btnSearch_Click);
            txtSearch.KeyDown += new KeyEventHandler(txtSearch_KeyDown);
            btnAddPatient.Click += new EventHandler(btnAddPatient_Click);

            dgvPatients.CellContentClick += new DataGridViewCellEventHandler(dgvPatients_CellContentClick);
            dgvPatients.CellPainting += new DataGridViewCellPaintingEventHandler(Dgv_CellPainting);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Doctor_Dashboard());
        }

        private void btnNavAppointments_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Appointments());
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPatientsData(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadPatientsData(txtSearch.Text);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (var regForm = new Register_Patient())
            {
                if (regForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPatientsData();
                }
            }
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "Dr";
            var parts = name.Split(' ');
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private async void LoadPatientsData(string searchTerm = "")
        {
            try
            {
                if (_doctor == null) return;

                // Optimization: Fetch everything in ONE query to avoid N+1 problem
                var query = _db.Patients.Where(p => p.AttendingDoctor == _doctor.FullName);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(p => p.FullName.Contains(searchTerm) || p.PatientCode.Contains(searchTerm));
                }

                // Project into a simplified model including the last appointment date in one trip
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
                    string lastVisitStr = item.LastVisitDate.HasValue 
                        ? item.LastVisitDate.Value.ToString("MM/dd/yyyy") 
                        : "Never";

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

            if (dgvPatients.Columns[e.ColumnIndex].HeaderText == "ACTION")
            {
                OpenPatientDetails(patientId);
            }
            else if (dgvPatients.Columns[e.ColumnIndex].HeaderText == "BOOKING")
            {
                using (var schedForm = new Appointment_Form(patientId))
                {
                    schedForm.ShowDialog();
                }
            }
        }

        private void OpenPatientDetails(int patientId)
        {
            var detailsForm = new Patient_Details(patientId);
            NavigationHelper.SwitchForm(this, detailsForm);
        }

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Target ACTION and BOOKING columns
            if (dgvPatients.Columns[e.ColumnIndex].Name == "colAction" || dgvPatients.Columns[e.ColumnIndex].Name == "colSchedule")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                var rect = e.CellBounds;
                rect.Inflate(-4, -4);

                bool isSchedule = dgvPatients.Columns[e.ColumnIndex].Name == "colSchedule";
                Color btnColor = isSchedule ? Color.FromArgb(0, 168, 168) : Color.FromArgb(240, 245, 250);
                Color textColor = isSchedule ? Color.White : Color.FromArgb(20, 35, 65);
                string text = isSchedule ? "Schedule" : "Details";

                using (var brush = new SolidBrush(btnColor))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }

                TextRenderer.DrawText(e.Graphics, text, e.CellStyle.Font, rect, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);

                e.Handled = true;
            }
        }
    }
}
