using elnet_recoverease.Core;
using elnet_recoverease.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace elnet_recoverease.Admin
{
    public partial class Admin_Report : Form
    {
        private string _selectedReport = "";

        public Admin_Report()
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
                if (System.IO.File.Exists(logoPath)) this.picLogo.Image = System.Drawing.Image.FromFile(logoPath); 
            } 
            catch { }

            // Navigation
            NavigationHelper.WireNavButton(this.btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(this.btnNavStaff, new EventHandler(btnNavStaff_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavProfile, new EventHandler(btnNavProfile_Click));
            NavigationHelper.WireNavButton(this.pnlAvatarTop, new EventHandler(btnNavProfile_Click));
            this.btnLogout.Click += new EventHandler(btnLogout_Click);

            // Report Actions
            this.btnGenerateReport.Click += new EventHandler(btnGenerateReport_Click);
            this.btnPreview.Click += new EventHandler(btnPreview_Click);
            
            LoadDoctors();
            SetAvatarInitials();
            this.Load += new EventHandler(Admin_Report_Load);
        }

        private void SetAvatarInitials()
        {
            var staff = elnet_recoverease.Core.UserSession.CurrentStaff;
            if (staff != null && !string.IsNullOrEmpty(staff.FullName))
            {
                var parts = staff.FullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 1) lblAvatarInitials.Text = (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
                else if (parts.Length == 1) lblAvatarInitials.Text = parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            }
        }

        private void Admin_Report_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblPageTitle;
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Dashboard());
        }

        private void btnNavStaff_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Staff_List());
        }

        private void btnNavPatients_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Medication_List());
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Profile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            UpdateInstantPreview();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
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
                    cmbDoctor.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void GenerateReport()
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
                Report_Viewer viewer = new Report_Viewer();
                viewer.Show();
                viewer.GenerateLiveReport(_selectedReport, fromDate, toDate, selectedDoctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching live report: " + ex.Message, "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper for Report cards (moved logic from Designer)
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

        public static DataTable ToDataTable<T>(List<T> items, string tableName)
        {
            DataTable dataTable = new DataTable(tableName);
            var props = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
