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

            // Navigation Handlers (with click bubbling)
            NavigationHelper.WireNavButton(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            NavigationHelper.WireNavButton(btnNavPatients, () => NavigationHelper.SwitchForm(this, new Patient_List()));
            NavigationHelper.WireNavButton(btnNavReports, () => NavigationHelper.SwitchForm(this, new Reports()));
            NavigationHelper.WireNavButton(btnNavProfile, () => NavigationHelper.SwitchForm(this, new Doctor_Profile()));
            btnLogout.Click += (s, e) => NavigationHelper.Logout(this);

            // Filter Handlers
            dtpFilterDate.ValueChanged += (s, e) => LoadAppointments();
            cmbFilterStatus.SelectedIndexChanged += (s, e) => LoadAppointments();

            btnNewAppointment.Click += (s, e) => {
                using (var apptForm = new Appointment_Form())
                {
                    if (apptForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadAppointments();
                    }
                }
            };

            // Grid Customization
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 245, 245); // Soft Teal Mist
            dgvAppointments.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 35, 65);
            
            dgvAppointments.CellFormatting += DgvAppointments_CellFormatting;
            dgvAppointments.CellPainting += Dgv_CellPainting; // Stylized buttons
            dgvAppointments.CellDoubleClick += (s, e) => {
                if (e.RowIndex >= 0) {
                    var apptId = (int)dgvAppointments.Rows[e.RowIndex].Tag;
                    EditAppointment(apptId);
                }
            };
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

                DateTime dayStart = dtpFilterDate.Value.Date;
                DateTime dayEnd = dayStart.AddDays(1);
                string filterStatus = cmbFilterStatus.SelectedItem?.ToString() ?? "All";

                // Use range-based filtering for maximum reliability in SQL
                var query = _db.Appointments
                    .Where(a => a.AppointmentDate >= dayStart && a.AppointmentDate < dayEnd && (a.DoctorName == _doctor.FullName || a.DoctorName == null))
                    .Join(_db.Patients, a => (int)a.PatientID, p => p.PatientID, (a, p) => new { a, p });

                if (filterStatus != "All")
                {
                    query = query.Where(x => x.a.Status == filterStatus);
                }

                var list = await query.OrderBy(x => x.a.AppointmentDate).ToListAsync();

                dgvAppointments.Rows.Clear();
                foreach (var item in list)
                {
                    int rowIndex = dgvAppointments.Rows.Add(
                        item.p.FullName,
                        item.a.AppointmentDate?.ToString("hh:mm tt") ?? "N/A",
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

        private void DgvAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                }
            }
        }

        private void EditAppointment(int apptId)
        {
            using (var sessionForm = new Clinical_Session(apptId))
            {
                if (sessionForm.ShowDialog() == DialogResult.OK)
                {
                    // Ensure the user sees the 'Completed' status by switching to 'All'
                    if (cmbFilterStatus.SelectedItem?.ToString() == "Scheduled")
                    {
                        cmbFilterStatus.SelectedItem = "All";
                    }
                    LoadAppointments();
                }
            }
        }
        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Target ACTION column (last column)
            if (dgvAppointments.Columns[e.ColumnIndex].HeaderText == "ACTION")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                
                var rect = e.CellBounds;
                rect.Inflate(-8, -6); // More button-like padding

                // Draw Button Background (Teal)
                using (var brush = new SolidBrush(Color.FromArgb(0, 140, 140)))
                {
                    // Basic rounded look
                    e.Graphics.FillRectangle(brush, rect);
                }

                // Draw Button Text (White)
                TextRenderer.DrawText(e.Graphics, "CONSULT", new Font("Segoe UI", 8.5f, FontStyle.Bold), rect, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                
                e.Handled = true;
            }
        }
    }
}
