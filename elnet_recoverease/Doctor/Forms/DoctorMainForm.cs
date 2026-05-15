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
                }
            }
            catch { }

            // Default View
            LoadDashboard();

            this.btnLogout.Click += new EventHandler(BtnLogout_Click);

            // 1. Setup UI First (Create controls)
            SetupSidebar();

            // 2. Wire Up Sidebar Events (Attach handlers to created controls)
            NavigationHelper.WireNavButton(this.btnNavDashboard, new EventHandler(BtnNavDashboard_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(BtnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavAppointments, new EventHandler(BtnNavAppointments_Click));
            NavigationHelper.WireNavButton(this.btnNavReports, new EventHandler(BtnNavReports_Click));
            NavigationHelper.WireNavButton(this.btnNavProfile, new EventHandler(BtnNavProfile_Click));
        }

        private void SetupSidebar()
        {
            Color activeColor = Color.FromArgb(27, 58, 107);
            Color whiteColor = Color.White;

            SetupNavItem(btnNavDashboard, lblNavDashIcon, lblNavDashText, "⊞", "Doctor Dashboard", true, activeColor, whiteColor);
            SetupNavItem(btnNavPatients, lblNavPatientsIcon, lblNavPatientsText, "👥", "My Patients", false, activeColor, whiteColor);
            SetupNavItem(btnNavAppointments, lblNavApptIcon, lblNavApptText, "📅", "Appointments", false, activeColor, whiteColor);
            SetupNavItem(btnNavReports, lblNavReportsIcon, lblNavReportsText, "📊", "Reports & Analytics", false, activeColor, whiteColor);
            SetupNavItem(btnNavProfile, lblNavProfileIcon, lblNavProfileText, "👤", "My Profile", false, activeColor, whiteColor);
        }

        private static void SetupNavItem(Panel pnl, Label ico, Label txt, string icoChar, string label, bool isActive, Color activeColor, Color whiteColor)
        {
            pnl.SuspendLayout();
            pnl.Cursor = Cursors.Hand;
            pnl.Dock = DockStyle.Top;
            pnl.Height = 56;
            pnl.BackColor = isActive ? activeColor : Color.Transparent;

            ico.AutoSize = false;
            ico.Size = new Size(56, 56);
            ico.Location = new Point(0, 0);
            ico.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            ico.ForeColor = isActive ? whiteColor : Color.FromArgb(45, 55, 72);
            ico.TextAlign = ContentAlignment.MiddleCenter;
            ico.Text = icoChar;

            txt.AutoSize = false;
            txt.Size = new Size(190, 56);
            txt.Location = new Point(56, 0);
            txt.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            txt.ForeColor = isActive ? whiteColor : Color.FromArgb(45, 55, 72);
            txt.TextAlign = ContentAlignment.MiddleLeft;
            txt.Text = label;

            pnl.Controls.Clear();
            pnl.Controls.Add(ico);
            pnl.Controls.Add(txt);
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
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

        private void BtnNavDashboard_Click(object sender, EventArgs e) => LoadDashboard();
        private void BtnNavPatients_Click(object sender, EventArgs e) => LoadPatientList();
        private void BtnNavAppointments_Click(object sender, EventArgs e) => LoadAppointments();
        private void BtnNavReports_Click(object sender, EventArgs e) => LoadReports();
        private void BtnNavProfile_Click(object sender, EventArgs e) => LoadProfile();

        private void BtnLogout_Click(object sender, EventArgs e)
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
