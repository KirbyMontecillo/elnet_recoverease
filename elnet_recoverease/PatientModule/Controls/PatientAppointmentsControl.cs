using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using elnet_recoverease.PatientStation.Forms;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.PatientStation.Controls
{
    public partial class PatientAppointmentsControl : UserControl
    {
        private AppDbContext _db = new AppDbContext();

        public PatientAppointmentsControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
            }
        }

        private void dgvAppts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colAction.Index && e.RowIndex >= 0)
            {
                var appt = dgvAppts.Rows[e.RowIndex].Tag as Appointment;
                if (appt != null)
                {
                    using (var details = new Appointment_Details_Form(appt))
                    {
                        details.ShowDialog();
                    }
                }
            }
        }

        private async Task LoadAppointmentData()
        {
            try
            {
                if (elnet_recoverease.Core.UserSession.CurrentPatient == null) return;
                int patientId = elnet_recoverease.Core.UserSession.CurrentPatient.PatientID;

                var appts = await _db.Appointments
                    .Where(a => a.PatientID == patientId)
                    .OrderByDescending(a => a.AppointmentDate)
                    .ToListAsync();

                var upcoming = appts.Where(a => a.Status == "Scheduled" && a.AppointmentDate >= DateTime.Now).OrderBy(a => a.AppointmentDate).ToList();
                var completed = appts.Where(a => a.Status == "Completed").ToList();

                lblCardNextValue.Text = upcoming.Any() ? upcoming.First().AppointmentDate?.ToString("MMM dd") : "--";
                lblCardUpcomingValue.Text = upcoming.Count.ToString().PadLeft(2, '0');
                lblCardCompletedValue.Text = completed.Count.ToString().PadLeft(2, '0');

                dgvAppts.Rows.Clear();
                foreach (var a in appts)
                {
                    int rowIndex = dgvAppts.Rows.Add(
                        a.AppointmentDate?.ToString("MMM dd, yyyy") ?? "--",
                        a.AppointmentDate?.ToString("hh:mm tt") ?? "--",
                        a.DoctorName ?? "TBD",
                        a.AppointmentType ?? "Consultation",
                        a.Status,
                        "View Details"
                    );
                    dgvAppts.Rows[rowIndex].Tag = a;
                }

                if (dgvAppts.Rows.Count == 0) dgvAppts.Rows.Add("No appointments found.", "-", "-", "-", "-");
            }
            catch { }
        }

        private async void PatientAppointmentsControl_Load(object sender, EventArgs e)
        {
            await LoadAppointmentData();
        }
    }
}
