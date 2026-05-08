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
            
            SetLogo();
            SetupEventHandlers();
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

        private void SetupEventHandlers()
        {
            btnSave.Click += new EventHandler(BtnSave_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            btnBack.Click += new EventHandler(btnBack_Click);
            
            // Set default dates
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddMonths(1);

            // Side nav
            NavigationHelper.WireNavButton(btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(btnNavAppointments, new EventHandler(btnNavAppointments_Click));
            NavigationHelper.WireNavButton(btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(btnNavProfile, new EventHandler(btnNavProfile_Click));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Doctor_Dashboard());
        }

        private void btnNavPatients_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Patient_List());
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
