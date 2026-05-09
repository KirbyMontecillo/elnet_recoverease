using elnet_recoverease.Core;
using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Doctor.Controls;

namespace elnet_recoverease.Doctor.Forms
{
    public partial class DoctorMainForm : Form
    {
        private UserControl _currentControl;

        public DoctorMainForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            try
            {
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) this.picLogo.Image = Image.FromFile(logoPath);
                
                if (UserSession.CurrentStaff != null)
                {
                    lblWelcome.Text = $"Welcome back, Dr. {UserSession.CurrentStaff.FullName}";
                    lblAvatarInitials.Text = GetInitials(UserSession.CurrentStaff.FullName);
                }
            }
            catch { }

            // Default View
            LoadDashboard();

            // Wire Up Sidebar Events
            NavigationHelper.WireNavButton(this.btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavAppointments, new EventHandler(btnNavAppointments_Click));
            NavigationHelper.WireNavButton(this.btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(this.btnNavProfile, new EventHandler(btnNavProfile_Click));
            
            this.btnLogout.Click += new EventHandler(btnLogout_Click);
        }

        private string GetInitials(string name)
        {
            if (string.IsNullOrEmpty(name)) return "DR";
            var parts = name.Split(' ');
            if (parts.Length == 1) return parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
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
                (btnNavPatients, lblNavPatientsIcon, lblNavPatientsText), 
                (btnNavAppointments, lblNavApptIcon, lblNavApptText), 
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
        private void btnNavPatients_Click(object sender, EventArgs e) => LoadPatientList();
        private void btnNavAppointments_Click(object sender, EventArgs e) => LoadAppointments();
        private void btnNavReports_Click(object sender, EventArgs e) => LoadReports();
        private void btnNavProfile_Click(object sender, EventArgs e) => LoadProfile();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        // Helper methods for specific navigation
        public void LoadDashboard()
        {
            LoadControl(new DoctorDashboardControl(), "Dashboard", btnNavDashboard);
        }

        public void LoadPatientList()
        {
            LoadControl(new PatientListControl(), "My Patients", btnNavPatients);
        }

        public void LoadAppointments()
        {
            LoadControl(new AppointmentsControl(), "Appointments", btnNavAppointments);
        }

        public void LoadReports()
        {
            LoadControl(new ReportsControl(), "Reports & Analytics", btnNavReports);
        }

        public void LoadProfile()
        {
            LoadControl(new DoctorProfileControl(), "My Profile", btnNavProfile);
        }

        public void LoadPatientDetails(int patientId)
        {
            LoadControl(new PatientDetailsControl(patientId), "Patient Record", btnNavPatients);
        }
    }
}
