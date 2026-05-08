using elnet_recoverease.Core;
using elnet_recoverease.Data;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace elnet_recoverease.Admin
{
    public partial class Staff_List : Form
    {
        private List<Models.Staff> _allStaff = new List<Models.Staff>();

        public Staff_List()
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

            // Navigation - Classic way
            NavigationHelper.WireNavButton(this.btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(this.btnNavStaff, new EventHandler(btnNavStaff_Click));
            NavigationHelper.WireNavButton(this.btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavProfile, new EventHandler(btnNavProfile_Click));
            NavigationHelper.WireNavButton(this.pnlAvatarTop, new EventHandler(btnNavProfile_Click));
            this.btnLogout.Click += new EventHandler(btnLogout_Click);

            // Filters
            this.cmbRoleFilter.SelectedIndexChanged += new EventHandler(FilterControls_Changed);
            this.cmbStatusFilter.SelectedIndexChanged += new EventHandler(FilterControls_Changed);

            // Actions
            this.dgvStaff.CellContentClick += new DataGridViewCellEventHandler(dgvStaff_CellContentClick);
            
            this.Load += new EventHandler(Staff_List_Load);
        }

        private void Staff_List_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            this.ActiveControl = lblPageTitle;
        }

        private void btnNavDashboard_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Admin_Dashboard()); }
        private void btnNavStaff_Click(object sender, EventArgs e) { /* Current Form */ }
        private void btnNavReports_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Admin_Report()); }
        private void btnNavPatients_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Medication_List()); }
        private void btnNavProfile_Click(object sender, EventArgs e) { NavigationHelper.SwitchForm(this, new Admin_Profile()); }
        private void btnLogout_Click(object sender, EventArgs e) { NavigationHelper.Logout(this); }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (var form = new Edit_Staff())
            {
                if (form.ShowDialog() == DialogResult.OK) LoadStaffData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) { FilterStaff(); }
        private void FilterControls_Changed(object sender, EventArgs e) { FilterStaff(); }

        private void LoadStaffData()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    _allStaff = db.Staff.ToList();
                    UpdateStats();
                    FilterStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateStats()
        {
            lblStatTotalVal.Text = _allStaff.Count.ToString();
            lblStatDoctorsVal.Text = _allStaff.Count(s => s.Role == "Doctor").ToString();
        }

        private void FilterStaff()
        {
            string searchTerm = txtSearch.Text.ToLower();
            string roleFilter = cmbRoleFilter.SelectedItem?.ToString() ?? "All roles";
            string statusFilter = cmbStatusFilter.SelectedItem?.ToString() ?? "All status";

            var filtered = _allStaff.Where(s =>
                (string.IsNullOrEmpty(searchTerm) || s.FullName.ToLower().Contains(searchTerm) || s.Specialty.ToLower().Contains(searchTerm)) &&
                (roleFilter == "All roles" || s.Role == roleFilter) &&
                (statusFilter == "All status" || s.Status == statusFilter)
            ).ToList();

            dgvStaff.Rows.Clear();

            // Optimization: Get counts from DB instead of loading all patients
            using (var db = new AppDbContext())
            {
                foreach (var s in filtered)
                {
                    string patientCountStr = "-";
                    if (s.Role == "Doctor")
                    {
                        int count = db.Patients.Count(p => p.AttendingDoctor == s.FullName);
                        patientCountStr = $"{count} patients";
                    }

                    var rowIndex = dgvStaff.Rows.Add(s.FullName, s.Role, s.Specialty, patientCountStr, s.Status, "👁 View", "✏ Edit", "🗑 Delete");
                    dgvStaff.Rows[rowIndex].Tag = s.StaffID;
                }
            }
            lblShowingCount.Text = $"Showing {filtered.Count} of {_allStaff.Count}";
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int staffId = (int)dgvStaff.Rows[e.RowIndex].Tag;

            if (e.ColumnIndex == colView.Index || e.ColumnIndex == colEdit.Index)
            {
                var staff = _allStaff.FirstOrDefault(s => s.StaffID == staffId);
                if (staff != null)
                {
                    bool readOnly = e.ColumnIndex == colView.Index;
                    using (var form = new Edit_Staff(staff, readOnly))
                    {
                        if (form.ShowDialog() == DialogResult.OK && !readOnly) LoadStaffData();
                    }
                }
            }
            else if (e.ColumnIndex == colDelete.Index)
            {
                if (MessageBox.Show("Delete this staff?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new AppDbContext())
                    {
                        var s = db.Staff.Find(staffId);
                        if (s != null)
                        {
                            db.Staff.Remove(s);
                            db.SaveChanges();
                            LoadStaffData();
                        }
                    }
                }
            }
        }
    }
}
