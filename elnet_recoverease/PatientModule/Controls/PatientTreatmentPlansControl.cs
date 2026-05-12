using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace elnet_recoverease.PatientStation.Controls
{
    public partial class PatientTreatmentPlansControl : UserControl
    {
        private AppDbContext _db = new AppDbContext();

        public PatientTreatmentPlansControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
            }
        }

        private async Task LoadTreatmentData()
        {
            try
            {
                if (elnet_recoverease.Core.UserSession.CurrentPatient == null) return;
                int patientId = elnet_recoverease.Core.UserSession.CurrentPatient.PatientID;

                var plans = await _db.TreatmentPlans
                    .Where(p => p.PatientID == patientId)
                    .OrderByDescending(p => p.CreatedAt)
                    .ToListAsync();

                if (plans.Any())
                {
                    var latest = plans.First();
                    lblCardActiveValue.Text = latest.StartDate.ToString("MMM dd") + " - " + latest.EndDate.ToString("MMM dd");
                }
                else { lblCardActiveValue.Text = "No Plan Found"; }

                dgvTreatments.Rows.Clear();
                string attendingDoc = elnet_recoverease.Core.UserSession.CurrentPatient?.AttendingDoctor ?? "Not Assigned";

                foreach (var p in plans)
                {
                    string details = p.PlanDetails ?? "No details provided.";
                    if (details.Length > 80) details = details.Substring(0, 77) + "...";

                    dgvTreatments.Rows.Add(p.EndDate.ToString("MMM dd, yyyy"), details, attendingDoc, (p.EndDate >= DateTime.Now) ? "Active" : "Completed");
                }

                if (dgvTreatments.Rows.Count == 0) dgvTreatments.Rows.Add("-", "No treatment history found.", "-", "-");
            }
            catch { }
        }

        private async void PatientTreatmentPlansControl_Load(object sender, EventArgs e)
        {
            await LoadTreatmentData();
        }
    }
}
