using elnet_recoverease.Core;

namespace elnet_recoverease.Admin
{
    public partial class Admin_Report : Form
    {
        public Admin_Report()
        {
            InitializeComponent();
            try { this.picLogo.Image = System.Drawing.Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }

            // Wire up navigation
            NavigationHelper.WireNavButton(this.btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Admin_Dashboard()));
            NavigationHelper.WireNavButton(this.btnNavStaff, () => NavigationHelper.SwitchForm(this, new Staff_List()));
            NavigationHelper.WireNavButton(this.btnNavPatients, () => NavigationHelper.SwitchForm(this, new Medication_List()));
            this.btnLogout.Click += (s, e) => NavigationHelper.Logout(this);
        }
    }
}
