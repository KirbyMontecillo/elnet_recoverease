using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System.Linq;

using elnet_recoverease.Core;
using elnet_recoverease.Admin;

namespace elnet_recoverease.Doctor
{
    public partial class Treatment_Plan_Form : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _patientId;

        public Treatment_Plan_Form(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => this.Close();
            btnBack.Click += (s, e) => this.Close();
            
            // Set default dates
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddMonths(1);

            // Side nav
            NavigationHelper.WireNavButton(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            NavigationHelper.WireNavButton(btnNavPatients, () => NavigationHelper.SwitchForm(this, new Patient_List()));
            NavigationHelper.WireNavButton(btnNavAppointments, () => NavigationHelper.SwitchForm(this, new Appointments()));
            NavigationHelper.WireNavButton(btnNavReports, () => NavigationHelper.SwitchForm(this, new Reports()));
            NavigationHelper.WireNavButton(btnNavProfile, () => NavigationHelper.SwitchForm(this, new Doctor_Profile()));
        }

        private void AttachNavEvents(Panel pnl, Action action)
        {
            pnl.Click += (s, e) => action();
            foreach (Control c in pnl.Controls)
            {
                c.Click += (s, e) => action();
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDetails.Text))
            {
                MessageBox.Show("Please enter the treatment plan details.");
                return;
            }

            try
            {
                // Combine Diagnosis and Goals into the PlanDetails if needed, 
                // or just use the primary details box.
                string fullPlan = $"DIAGNOSIS: {txtDiagnosis.Text}\nGOALS: {txtGoals.Text}\n\nNOTES:\n{txtDetails.Text}";

                var plan = new TreatmentPlan
                {
                    PatientID = _patientId,
                    PlanDetails = fullPlan,
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    CreatedAt = DateTime.Now
                };

                _db.TreatmentPlans.Add(plan);
                await _db.SaveChangesAsync();

                MessageBox.Show("Treatment plan formalized successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving treatment plan: " + ex.Message);
            }
        }
    }
}
