using elnet_recoverease.Core;
using elnet_recoverease.Models;
using elnet_recoverease;
using elnet_recoverease.PatientStation.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace elnet_recoverease.PatientStation.Forms
{
    public partial class PatientMainForm : Form
    {
        private Panel activeNavItem;

        public PatientMainForm()
        {
            InitializeComponent();
            SetupForm();
            SetupNavigationHandlers();
        }

        private void SetupForm()
        {
            try
            {
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) this.picLogo.Image = Image.FromFile(logoPath);
                
                if (elnet_recoverease.Core.UserSession.CurrentPatient != null)
                {
                    lblWelcome.Text = $"Welcome back, {elnet_recoverease.Core.UserSession.CurrentPatient.FirstName}";
                }
            }
            catch { }

            // 1. Setup UI First
            SetupSidebar();

            // 2. Default View
            LoadDashboard();
        }

        private void SetupSidebar()
        {
            Color activeColor = Color.FromArgb(27, 58, 107);
            Color whiteColor = Color.White;

            SetupNavItem(btnNavDashboard, lblNavDashIcon, lblNavDashText, "⊞", "Dashboard", true, activeColor, whiteColor);
            SetupNavItem(btnNavMeds, lblNavMedsIcon, lblNavMedsText, "💊", "My Medications", false, activeColor, whiteColor);
            SetupNavItem(btnNavAppointments, lblNavApptIcon, lblNavApptText, "📅", "Appointments", false, activeColor, whiteColor);
            SetupNavItem(btnNavTreatment, lblNavTreatmentIcon, lblNavTreatmentText, "📋", "Treatment Plans", false, activeColor, whiteColor);
            SetupNavItem(btnNavProfile, lblNavProfileIcon, lblNavProfileText, "👤", "My Profile", false, activeColor, whiteColor);
        }

        private void SetupNavItem(Panel pnl, Label ico, Label txt, string icoChar, string label, bool isActive, Color activeColor, Color whiteColor)
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

        private void SetupNavigationHandlers()
        {
            btnNavDashboard.Click += (s, e) => LoadDashboard();
            lblNavDashIcon.Click += (s, e) => LoadDashboard();
            lblNavDashText.Click += (s, e) => LoadDashboard();

            btnNavMeds.Click += (s, e) => LoadMedications();
            lblNavMedsIcon.Click += (s, e) => LoadMedications();
            lblNavMedsText.Click += (s, e) => LoadMedications();

            btnNavAppointments.Click += (s, e) => LoadAppointments();
            lblNavApptIcon.Click += (s, e) => LoadAppointments();
            lblNavApptText.Click += (s, e) => LoadAppointments();

            btnNavTreatment.Click += (s, e) => LoadTreatmentPlans();
            lblNavTreatmentIcon.Click += (s, e) => LoadTreatmentPlans();
            lblNavTreatmentText.Click += (s, e) => LoadTreatmentPlans();

            btnNavProfile.Click += (s, e) => LoadProfile();
            lblNavProfileIcon.Click += (s, e) => LoadProfile();
            lblNavProfileText.Click += (s, e) => LoadProfile();

            btnLogout.Click += BtnLogout_Click;
        }

        private void LoadControl(UserControl control, string title, Panel navItem)
        {
            panelContainer.SuspendLayout();
            panelContainer.Controls.Clear();
            
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control);
            
            lblPageTitle.Text = title;
            SetActiveNav(navItem);
            
            panelContainer.ResumeLayout();
        }

        private void SetActiveNav(Panel navItem)
        {
            if (activeNavItem != null)
                activeNavItem.BackColor = Color.Transparent;
            
            activeNavItem = navItem;
            activeNavItem.BackColor = Color.FromArgb(27, 58, 107); // Active color

            // Update text colors
            foreach (Control pnl in pnlSidebar.Controls)
            {
                if (pnl is Panel navPnl && navPnl.Name.StartsWith("btnNav"))
                {
                    bool isThis = (navPnl == navItem);
                    foreach (Control c in navPnl.Controls)
                    {
                        if (c is Label lbl)
                            lbl.ForeColor = isThis ? Color.White : Color.FromArgb(45, 55, 72);
                    }
                }
            }
        }

        public void LoadDashboard()
        {
            LoadControl(new PatientDashboardControl(), "Dashboard Overview", btnNavDashboard);
        }

        public void LoadMedications()
        {
            LoadControl(new PatientMedicationsControl(), "My Medications", btnNavMeds);
        }

        public void LoadAppointments()
        {
            LoadControl(new PatientAppointmentsControl(), "My Appointments", btnNavAppointments);
        }

        public void LoadTreatmentPlans()
        {
            LoadControl(new PatientTreatmentPlansControl(), "Treatment & Progress", btnNavTreatment);
        }

        public void LoadProfile()
        {
            LoadControl(new PatientProfileControl(), "My Profile", btnNavProfile);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                elnet_recoverease.Core.UserSession.Logout();
                var login = new Login();
                login.Show();
                this.Hide();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
