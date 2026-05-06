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
            
            if (!string.IsNullOrEmpty(_currentDoctorName))
            {
                var parts = _currentDoctorName.Split(' ');
                if (parts.Length >= 2) lblAvatarInitials.Text = (parts[0][0].ToString() + parts[1][0].ToString()).ToUpper();
                else lblAvatarInitials.Text = _currentDoctorName.Substring(0, Math.Min(2, _currentDoctorName.Length)).ToUpper();
            }

            btnGenerateReport.Click += (s, e) => GenerateReport();
        }

        private void SetLogo()
        {
            try { picLogo.Image = Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }
        }

        private void InitializeNavigation()
        {
            NavigationHelper.WireNavButton(btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Doctor_Dashboard()));
            NavigationHelper.WireNavButton(btnNavPatients, () => NavigationHelper.SwitchForm(this, new Patient_List()));
            NavigationHelper.WireNavButton(btnNavAppointments, () => NavigationHelper.SwitchForm(this, new Appointments()));
            NavigationHelper.WireNavButton(btnNavReports, () => { });
            NavigationHelper.WireNavButton(btnNavProfile, () => NavigationHelper.SwitchForm(this, new Doctor_Profile()));
            btnLogout.Click += (s, e) => NavigationHelper.Logout(this);
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
    }
}
