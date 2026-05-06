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
            
            this.btnAddStaff.Click += (s, e) => {
                using (var form = new Edit_Staff())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadStaffData();
                    }
                }
            };

            this.Load += (s, e) => LoadStaffData();

            // Real-time filtering
            this.txtSearch.TextChanged += (s, e) => FilterStaff();
            this.cmbRoleFilter.SelectedIndexChanged += (s, e) => FilterStaff();
            this.cmbStatusFilter.SelectedIndexChanged += (s, e) => FilterStaff();

            // Grid Actions
            this.dgvStaff.CellContentClick += dgvStaff_CellContentClick;
        }

        private System.Collections.Generic.List<Models.Staff> _allStaff = new System.Collections.Generic.List<Models.Staff>();

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
                MessageBox.Show("Error loading staff: " + ex.Message);
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

            using (var db = new AppDbContext())
            {
                var allPatients = db.Patients.ToList();
                dgvStaff.Rows.Clear();
                
                foreach (var s in filtered)
                {
                    string patientCountStr = "-";
                    if (s.Role == "Doctor")
                    {
                        int count = allPatients.Count(p => p.AttendingDoctor == s.FullName);
                        patientCountStr = $"{count} patients";
                    }

                    // View, Edit and Delete
                    var rowIndex = dgvStaff.Rows.Add(s.FullName, s.Role, s.Specialty, patientCountStr, s.Status, "👁 View", "✏ Edit", "🗑 Delete");
                    dgvStaff.Rows[rowIndex].Tag = s.StaffID;
                }
            }
            lblShowingCount.Text = $"Showing {filtered.Count} of {_allStaff.Count} staff";
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var staffIdObj = dgvStaff.Rows[e.RowIndex].Tag;
            if (staffIdObj == null) return;
            int staffId = (int)staffIdObj;

            // View
            if (e.ColumnIndex == colView.Index)
            {
                var staff = _allStaff.FirstOrDefault(s => s.StaffID == staffId);
                if (staff != null)
                {
                    using (var form = new Edit_Staff(staff, true)) // true = IsReadOnly
                    {
                        form.ShowDialog();
                    }
                }
            }
            // Edit
            else if (e.ColumnIndex == colEdit.Index)
            {
                var staff = _allStaff.FirstOrDefault(s => s.StaffID == staffId);
                if (staff != null)
                {
                    using (var form = new Edit_Staff(staff))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            LoadStaffData();
                        }
                    }
                }
            }
            // Delete
            else if (e.ColumnIndex == colDelete.Index)
            {
                var staff = _allStaff.FirstOrDefault(s => s.StaffID == staffId);
                if (staff == null) return;

                var result = MessageBox.Show($"Are you sure you want to delete {staff.FullName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new AppDbContext())
                        {
                            var s = db.Staff.Find(staffId);
                            if (s != null)
                            {
                                if (s.UserID.HasValue)
                                {
                                    var u = db.Users.Find(s.UserID.Value);
                                    if (u != null) db.Users.Remove(u);
                                }
                                db.Staff.Remove(s);
                                db.SaveChanges();
                                LoadStaffData();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting staff: " + ex.Message);
                    }
                }
            }
        }
    }
}
