using elnet_recoverease.Core;
using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Admin.Controls;

namespace elnet_recoverease.Admin.Forms
{
    public partial class AdminMainForm : Form
    {
        private UserControl _currentControl;

        public AdminMainForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            try
            {
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\images\logo.png");
                if (!System.IO.File.Exists(logoPath)) logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) this.picLogo.Image = Image.FromFile(logoPath);
            }
            catch { }

            // Default View
            LoadDashboard();

            // Wire Up Sidebar Events
            NavigationHelper.WireNavButton(this.btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(this.btnNavStaff, new EventHandler(btnNavStaff_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(this.btnNavProfile, new EventHandler(btnNavProfile_Click));
            
            this.btnLogout.Click += new EventHandler(btnLogout_Click);
        }

        public void LoadControl(UserControl control, string title, Panel navPanel = null)
        {
            panelContainer.SuspendLayout();

            // Cleanup
            if (_currentControl != null)
            {
                panelContainer.Controls.Remove(_currentControl);
                _currentControl.Dispose();
            }

            // Setup New
            _currentControl = control;
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);

            // Update UI
            lblPageTitle.Text = title;
            lblCurrentDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");

            if (navPanel != null) UpdateNavHighlight(navPanel);

            panelContainer.ResumeLayout();
        }

        private void UpdateNavHighlight(Panel activePanel)
        {
            Color activeColor = Color.FromArgb(27, 58, 107);
            Color activeText = Color.White;
            Color inactiveText = Color.FromArgb(45, 55, 72);

            var navItems = new[] { 
                (btnNavDashboard, lblNavDashIcon, lblNavDashText), 
                (btnNavStaff, lblNavStaffIcon, lblNavStaffText), 
                (btnNavPatients, lblNavPatientsIcon, lblNavPatientsText), 
                (btnNavReports, lblNavReportsIcon, lblNavReportsText), 
                (btnNavProfile, lblNavProfileIcon, lblNavProfileText) 
            };

            foreach (var item in navItems)
            {
                bool isActive = item.Item1 == activePanel;
                item.Item1.BackColor = isActive ? activeColor : Color.Transparent;
                item.Item2.ForeColor = isActive ? activeText : inactiveText;
                item.Item3.ForeColor = isActive ? activeText : inactiveText;
            }
        }

        private void btnNavDashboard_Click(object sender, EventArgs e) => LoadDashboard();
        private void btnNavStaff_Click(object sender, EventArgs e) => LoadStaffList();
        private void btnNavPatients_Click(object sender, EventArgs e) => LoadMedicationList();
        private void btnNavReports_Click(object sender, EventArgs e) => LoadReports();
        private void btnNavProfile_Click(object sender, EventArgs e) => LoadProfile();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        // Helper methods for specific navigation
        public void LoadDashboard()
        {
            LoadControl(new AdminDashboardControl(), "Dashboard", btnNavDashboard);
        }

        public void LoadStaffList()
        {
            LoadControl(new StaffListControl(), "Staff Management", btnNavStaff);
        }

        public void LoadMedicationList()
        {
            LoadControl(new MedicationListControl(), "Medication List", btnNavPatients);
        }

        public void LoadReports()
        {
            LoadControl(new AdminReportControl(), "System Reports", btnNavReports);
        }

        public void LoadProfile()
        {
            LoadControl(new AdminProfileControl(), "My Profile", btnNavProfile);
        }
        
        public void LoadReportViewer()
        {
            LoadControl(new ReportViewerControl(), "Report Viewer");
        }
    }
}
