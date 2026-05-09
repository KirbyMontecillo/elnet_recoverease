using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Core;
using elnet_recoverease.Data;

namespace elnet_recoverease.Doctor.Controls
{
    public partial class ReportsControl : UserControl
    {
        private string _selectedReport = "";
        private string _currentDoctorName = "";

        public ReportsControl()
        {
            InitializeComponent();
            _currentDoctorName = UserSession.CurrentStaff?.FullName ?? "Unknown Doctor";
            
            btnGenerateReport.Click += new EventHandler(btnGenerateReport_Click);
            btnPreview.Click += new EventHandler(btnPreview_Click);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e) => GenerateReport();
        private void btnPreview_Click(object sender, EventArgs e) => UpdateInstantPreview();

        private void SelectCard(Panel card)
        {
            // Reset all cards
            foreach (Control c in pnlReportSelection.Controls)
            {
                if (c is Panel p)
                {
                    p.BackColor = Color.FromArgb(226, 232, 240); // Reset border to light gray
                    if (p.Controls.Count > 0 && p.Controls[0] is Panel inner) inner.BackColor = Color.White;
                }
            }

            // Highlight selected card
            card.BackColor = Color.FromArgb(0, 168, 168); // Teal border
            if (card.Controls.Count > 0 && card.Controls[0] is Panel selectedInner) 
                selectedInner.BackColor = Color.FromArgb(240, 253, 250); // Very light teal background

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
                MessageBox.Show("Please select an analytical category first.");
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
            while (c != null && c.Tag == null && c.Parent != null)
            {
                c = c.Parent;
            }
            if (c is Panel card) SelectCard(card);
        }
    }
}
