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
            LoadPatients();
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
            NavigationHelper.WireNavButton(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            NavigationHelper.WireNavButton(btnNavPatients, () => { });
            NavigationHelper.WireNavButton(btnNavAppointments, () => NavigationHelper.SwitchForm(this, new Appointments()));
            NavigationHelper.WireNavButton(btnNavReports, () => NavigationHelper.SwitchForm(this, new Reports()));
            NavigationHelper.WireNavButton(btnNavProfile, () => NavigationHelper.SwitchForm(this, new Doctor_Profile()));
            btnLogout.Click += (s, e) => NavigationHelper.Logout(this);

            // Action Handlers
            btnSearch.Click += (s, e) => LoadPatients(txtSearch.Text);
            txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) LoadPatients(txtSearch.Text); };

            btnAddPatient.Click += (s, e) => {
                using (var regForm = new Register_Patient())
                {
                    if (regForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadPatients();
                    }
                }
            };

            dgvPatients.CellContentClick += dgvPatients_CellContentClick;
            dgvPatients.CellPainting += Dgv_CellPainting;
        }

        private void AttachNavEvents(Panel pnl, Action action)
        {
            pnl.Click += (s, e) => action();
            foreach (Control c in pnl.Controls)
            {
                c.Click += (s, e) => action();
                c.Cursor = Cursors.Hand;
            }
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "Dr";
            var parts = name.Split(' ');
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
        }

        private async void LoadPatients(string searchTerm = "")
        {
            try
            {
                if (_doctor == null) return;

                var query = _db.Patients
                    .Where(p => p.AttendingDoctor == _doctor.FullName);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(p => p.FullName.Contains(searchTerm) || p.PatientCode.Contains(searchTerm));
                }

                var patients = await query.OrderBy(p => p.FullName).ToListAsync();

                dgvPatients.Rows.Clear();
                foreach (var p in patients)
                {
                    // Find last visit
                    var lastAppt = await _db.Appointments
                        .Where(a => a.PatientID == p.PatientID && a.Status == "Completed")
                        .OrderByDescending(a => a.AppointmentDate)
                        .FirstOrDefaultAsync();

                    string lastVisitStr = lastAppt != null ? lastAppt.AppointmentDate?.ToString("MM/dd/yyyy") ?? "N/A" : "Never";

            dgvPatients.Rows.Add(
                        p.PatientCode ?? p.PatientID.ToString(),
                        p.FullName,
                        p.EmergencyPhone ?? "N/A",
                        lastVisitStr,
                        "Details",
                        "Schedule"
                    );
                    dgvPatients.Rows[dgvPatients.Rows.Count - 1].Tag = p.PatientID;
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
