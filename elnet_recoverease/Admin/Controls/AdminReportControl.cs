using elnet_recoverease.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Admin.Forms;

namespace elnet_recoverease.Admin.Controls
{
    public partial class AdminReportControl : UserControl
    {
        private string _selectedReport = "";
        private int _cardCount = 0;

        public AdminReportControl()
        {
            InitializeComponent();
            SetupControl();
        }

        private void SetupControl()
        {
            this.Load += new EventHandler(AdminReportControl_Load);
            this.btnGenerateReport.Click += new EventHandler(btnGenerateReport_Click);
            this.btnPreview.Click += new EventHandler(btnPreview_Click);
            
            LoadDoctors();
            InitializeReportCards();
        }

        private void AdminReportControl_Load(object sender, EventArgs e)
        {
            // Initial state
        }

        private void InitializeReportCards()
        {
            AddReportCard("Patient Demographics", "Distribution by age, gender, and status", "👥", System.Drawing.Color.FromArgb(230, 246, 255), System.Drawing.Color.FromArgb(2, 132, 199));
            AddReportCard("Medication Inventory", "Current stock levels and utilization", "💊", System.Drawing.Color.FromArgb(254, 243, 199), System.Drawing.Color.FromArgb(217, 119, 6));
            AddReportCard("Doctor Performance", "Patient load and adherence rates", "🩺", System.Drawing.Color.FromArgb(220, 252, 231), System.Drawing.Color.FromArgb(22, 163, 74));
            AddReportCard("Missed Medications", "Non-adherence logs and critical alerts", "⚠️", System.Drawing.Color.FromArgb(254, 226, 226), System.Drawing.Color.FromArgb(220, 38, 38));
            AddReportCard("System Audit Log", "User activities and security events", "📋", System.Drawing.Color.FromArgb(243, 244, 246), System.Drawing.Color.FromArgb(75, 85, 99));
            AddReportCard("Financial Summary", "Revenue from treatments and consultations", "💰", System.Drawing.Color.FromArgb(243, 232, 255), System.Drawing.Color.FromArgb(147, 51, 234));
        }

        private void AddReportCard(string title, string desc, string icon, System.Drawing.Color bgColor, System.Drawing.Color iconColor)
        {
            System.Windows.Forms.Panel card = new System.Windows.Forms.Panel {
                Size = new System.Drawing.Size(350, 140),
                BackColor = System.Drawing.Color.White,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Margin = new System.Windows.Forms.Padding(0, 0, 20, 20),
                Cursor = System.Windows.Forms.Cursors.Hand,
                Dock = System.Windows.Forms.DockStyle.Fill
            };

            System.Windows.Forms.Label lblIcon = new System.Windows.Forms.Label {
                Text = icon,
                Font = new System.Drawing.Font("Segoe UI", 20F),
                BackColor = bgColor,
                ForeColor = iconColor,
                Size = new System.Drawing.Size(50, 50),
                Location = new System.Drawing.Point(15, 15),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            System.Windows.Forms.Label lblTitle = new System.Windows.Forms.Label {
                Text = title,
                Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(15, 75),
                AutoSize = true
            };

            System.Windows.Forms.Label lblDesc = new System.Windows.Forms.Label {
                Text = desc,
                Font = new System.Drawing.Font("Segoe UI", 8F),
                ForeColor = System.Drawing.Color.FromArgb(100, 116, 139),
                Location = new System.Drawing.Point(15, 100),
                Size = new System.Drawing.Size(320, 35)
            };

            card.Controls.AddRange(new System.Windows.Forms.Control[] { lblIcon, lblTitle, lblDesc });
            
            int row = _cardCount / 3;
            int col = _cardCount % 3;
            this.pnlReportSelection.Controls.Add(card, col, row);
            _cardCount++;
            
            card.Tag = title;
            card.Click += new EventHandler(HandleCardClick);
            
            foreach (System.Windows.Forms.Control child in card.Controls)
            {
                child.Click += new EventHandler(HandleCardClick);
            }
        }

        public void HandleCardClick(object sender, EventArgs e)
        {
            Panel card = null;
            if (sender is Panel) card = (Panel)sender;
            else if (sender is Control) card = (Panel)((Control)sender).Parent;

            if (card != null)
            {
                SelectCard(card);
            }
        }

        private void SelectCard(System.Windows.Forms.Panel card)
        {
            System.Drawing.Color clrDefault = System.Drawing.Color.White;
            System.Drawing.Color clrSelected = System.Drawing.Color.FromArgb(204, 251, 241);

            foreach (System.Windows.Forms.Control c in pnlReportSelection.Controls) 
                if (c is System.Windows.Forms.Panel p) p.BackColor = clrDefault;
            
            card.BackColor = clrSelected;
            this._selectedReport = card.Tag?.ToString() ?? "";

            UpdateInstantPreview();
        }

        private void LoadDoctors()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var doctors = db.Staff.Where(s => s.Role == "Doctor").Select(s => s.FullName).ToList();
                    cmbDoctor.Items.Clear();
                    cmbDoctor.Items.Add("All Doctors");
                    cmbDoctor.Items.AddRange(doctors.ToArray());
                    if (cmbDoctor.Items.Count > 0) cmbDoctor.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            UpdateInstantPreview();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedReport))
            {
                MessageBox.Show("Please select a report type first by clicking on one of the cards.", "No Report Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;
            string selectedDoctor = cmbDoctor.SelectedItem?.ToString() ?? "All Doctors";

            try
            {
                var mainForm = this.FindForm() as AdminMainForm;
                if (mainForm != null)
                {
                    // ReportViewerControl will be created next
                    var viewerControl = new ReportViewerControl();
                    mainForm.LoadControl(viewerControl, "Report Viewer");
                    viewerControl.GenerateLiveReport(_selectedReport, fromDate, toDate, selectedDoctor);
                }
                else
                {
                    // Fallback to old behavior if not in MainForm
                    Form tempForm = new Form { Text = "Report Viewer", WindowState = FormWindowState.Maximized };
                    ReportViewerControl viewer = new ReportViewerControl();
                    viewer.Dock = DockStyle.Fill;
                    tempForm.Controls.Add(viewer);
                    tempForm.Show();
                    viewer.GenerateLiveReport(_selectedReport, fromDate, toDate, selectedDoctor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching live report: " + ex.Message, "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateInstantPreview()
        {
            if (wvPreview.CoreWebView2 == null) await wvPreview.EnsureCoreWebView2Async(null);
            
            // Generate temporary HTML
            var temp = new ReportViewerControl(); // Fallback for generating HTML
            string html = temp.GetReportHtml(this._selectedReport, dtpFrom.Value, dtpTo.Value, cmbDoctor.SelectedItem?.ToString() ?? "All Doctors");
            wvPreview.CoreWebView2.NavigateToString(html);
        }
    }
}
