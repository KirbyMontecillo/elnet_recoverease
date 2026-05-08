using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Data;

namespace elnet_recoverease.Doctor
{
    public partial class Reports : Form
    {
        private string _selectedReport = "";
        private string _currentDoctorName = "";

        public Reports()
        {
            InitializeComponent();
            _currentDoctorName = UserSession.CurrentStaff?.FullName ?? "Unknown Doctor";
            
            SetLogo();
            InitializeNavigation();

            btnGenerateReport.Click += new EventHandler(btnGenerateReport_Click);
            btnPreview.Click += new EventHandler(btnPreview_Click);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            UpdateInstantPreview();
        }

        private void SetLogo()
        {
            try { picLogo.Image = Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }
        }

        private void InitializeNavigation()
        {
            NavigationHelper.WireNavButton(btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(btnNavAppointments, new EventHandler(btnNavAppointments_Click));
            NavigationHelper.WireNavButton(btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(btnNavProfile, new EventHandler(btnNavProfile_Click));
            btnLogout.Click += new EventHandler(btnLogout_Click);
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
            // Do nothing, already on Reports
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Doctor_Profile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void SelectCard(Panel card)
        {
            foreach (Control c in pnlReportSelection.Controls) if (c is Panel p) p.BackColor = Color.White;
            card.BackColor = Color.FromArgb(204, 251, 241);
            this._selectedReport = card.Tag?.ToString() ?? "";
            UpdateInstantPreview();
        }

        private async void UpdateInstantPreview()
        {
            try
            {
                if (wvPreview.CoreWebView2 == null) await wvPreview.EnsureCoreWebView2Async(null);
                var temp = new Doctor_Report_Viewer();
                string html = temp.GetReportHtml(this._selectedReport, dtpFrom.Value, dtpTo.Value, _currentDoctorName);
                wvPreview.CoreWebView2.NavigateToString(html);
            }
            catch { }
        }

        private void GenerateReport()
        {
            if (string.IsNullOrEmpty(_selectedReport))
            {
                MessageBox.Show("Please select an analytical category first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var viewer = new Doctor_Report_Viewer();
                viewer.Show();
                viewer.GenerateLiveReport(_selectedReport, dtpFrom.Value, dtpTo.Value, _currentDoctorName);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ReportCard_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            if (c == null) return;
            Panel card = c as Panel;
            if (card == null)
            {
                card = c.Parent as Panel;
            }
            if (card != null)
            {
                SelectCard(card);
            }
        }
    }
}
