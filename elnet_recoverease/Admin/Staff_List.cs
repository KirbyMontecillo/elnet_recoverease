using elnet_recoverease.Core;
using elnet_recoverease.Data;
using System.Linq;
using System;
using System.Windows.Forms;

namespace elnet_recoverease.Admin
{
    public partial class Staff_List : Form
    {
        public Staff_List()
        {
            InitializeComponent();
            try { this.picLogo.Image = System.Drawing.Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }

            // Wire up navigation
            NavigationHelper.WireNavButton(this.btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Admin_Dashboard()));
            NavigationHelper.WireNavButton(this.btnNavReports, () => NavigationHelper.SwitchForm(this, new Admin_Report()));
            NavigationHelper.WireNavButton(this.btnNavPatients, () => NavigationHelper.SwitchForm(this, new Medication_List()));
            this.btnLogout.Click += (s, e) => NavigationHelper.Logout(this);
            
            // Wire up Add Staff button
            this.btnAddStaff.Click += (s, e) => {
                using (var form = new Staff_Form())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadStaffData();
                    }
                }
            };

            this.Load += (s, e) => LoadStaffData();
        }

        private void LoadStaffData()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var staffList = db.Staff.ToList();
                    dgvStaff.Rows.Clear();
                    foreach (var s in staffList)
                    {
                        dgvStaff.Rows.Add(s.FullName, s.Role, s.Specialty, s.Status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message);
            }
        }
    }
}
