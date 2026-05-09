using elnet_recoverease.Core;
using elnet_recoverease.Data;
using System.Linq;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace elnet_recoverease.Admin.Controls
{
    public partial class StaffListControl : UserControl
    {
        private List<Models.Staff> _allStaff = new List<Models.Staff>();

        public StaffListControl()
        {
            InitializeComponent();
            SetupControl();
        }

        private void SetupControl()
        {
            this.Load += new EventHandler(StaffListControl_Load);
            this.txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            this.cmbRoleFilter.SelectedIndexChanged += new EventHandler(FilterControls_Changed);
            this.cmbStatusFilter.SelectedIndexChanged += new EventHandler(FilterControls_Changed);
            this.dgvStaff.CellContentClick += new DataGridViewCellEventHandler(dgvStaff_CellContentClick);
            this.dgvStaff.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvStaff_CellFormatting);
            this.btnAddStaff.Click += new EventHandler(btnAddStaff_Click);
            
            // Hover effects for Add button
            this.btnAddStaff.MouseEnter += (s, e) => this.btnAddStaff.BackColor = Color.FromArgb(0, 140, 140);
            this.btnAddStaff.MouseLeave += (s, e) => this.btnAddStaff.BackColor = Color.FromArgb(0, 168, 168);
            
            this.cmbRoleFilter.SelectedIndex = 0;
            this.cmbStatusFilter.SelectedIndex = 0;
        }

        private void StaffListControl_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

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

                    var rowIndex = dgvStaff.Rows.Add(s.FullName, s.Role, s.Specialty, patientCountStr, s.Status);
                    dgvStaff.Rows[rowIndex].Tag = s.StaffID;
                }
            }
            lblShowingCount.Text = $"Showing {filtered.Count} of {_allStaff.Count}";
        }

        private void dgvStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Status Badge Styling
            if (dgvStaff.Columns[e.ColumnIndex].Name == "colStatus")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    if (status == "Active")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(56, 161, 105);
                        e.CellStyle.BackColor = Color.FromArgb(198, 246, 213);
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(113, 128, 150);
                        e.CellStyle.BackColor = Color.FromArgb(237, 242, 247);
                    }
                    e.FormattingApplied = true;
                }
            }

            // Action Buttons Styling
            if (dgvStaff.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                e.CellStyle.Padding = new Padding(5, 10, 5, 10);
                if (dgvStaff.Columns[e.ColumnIndex].Name == "colDelete")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(197, 48, 48);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(197, 48, 48);
                }
                else
                {
                    e.CellStyle.ForeColor = Color.FromArgb(27, 58, 107);
                    e.CellStyle.SelectionForeColor = Color.FromArgb(27, 58, 107);
                }
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int staffId = (int)dgvStaff.Rows[e.RowIndex].Tag;

            // Adjust indices based on the columns added in designer
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
