using elnet_recoverease.Core;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace elnet_recoverease.Admin.Controls
{
    public partial class MedicationListControl : UserControl
    {
        private List<Medication> _allMeds = new List<Medication>();
        private System.Windows.Forms.Timer _searchTimer;

        public MedicationListControl()
        {
            InitializeComponent();
            InitializeSearchTimer();
            SetupControl();
        }

        private void InitializeSearchTimer()
        {
            _searchTimer = new System.Windows.Forms.Timer();
            _searchTimer.Interval = 300; // 300ms delay
            _searchTimer.Tick += new System.EventHandler(SearchTimer_Tick);
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            FilterMedications();
        }

        private void SetupControl()
        {
            this.Load += new System.EventHandler(MedicationListControl_Load);
            this.txtSearch.TextChanged += new System.EventHandler(txtSearch_TextChanged);
            this.cmbFormFilter.SelectedIndexChanged += new System.EventHandler(cmbFormFilter_SelectedIndexChanged);
            this.dgvMeds.CellContentClick += new DataGridViewCellEventHandler(dgvMeds_CellContentClick);
            this.btnAddMed.Click += new System.EventHandler(btnAddMed_Click);

            if (this.cmbFormFilter.Items.Count > 0)
                this.cmbFormFilter.SelectedIndex = 0;
        }

        private void MedicationListControl_Load(object sender, EventArgs e)
        {
            LoadMedicationData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Reset timer on every keystroke
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void cmbFormFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMedications();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            using (var form = new Edit_Medicine())
            {
                if (form.ShowDialog() == DialogResult.OK) LoadMedicationData();
            }
        }

        private void dgvMeds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int medId = (int)dgvMeds.Rows[e.RowIndex].Tag;

            if (e.ColumnIndex == colEdit.Index) // Edit
            {
                using (var form = new Edit_Medicine(medId))
                {
                    if (form.ShowDialog() == DialogResult.OK) LoadMedicationData();
                }
            }
            else if (e.ColumnIndex == colDelete.Index) // Delete
            {
                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new AppDbContext())
                    {
                        var med = db.Medications.Find(medId);
                        if (med != null)
                        {
                            db.Medications.Remove(med);
                            db.SaveChanges();
                            LoadMedicationData();
                        }
                    }
                }
            }
        }

        private void LoadMedicationData()
        {
            using (var db = new AppDbContext())
            {
                _allMeds = db.Medications.ToList();
                UpdateStats();
                FilterMedications();
            }
        }

        private void UpdateStats()
        {
            lblStatTotalVal.Text = _allMeds.Count.ToString();
            
            using (var db = new AppDbContext())
            {
                // Most Common (by treatment plan mentions)
                var mostCommon = db.MedicationSchedules
                    .GroupBy(m => m.MedicationName)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "None";
                
                lblStatMostVal.Text = mostCommon;

                // Most Recent
                var recentMed = db.Medications
                    .OrderByDescending(m => m.MedicationID)
                    .Select(m => m.MedicationName)
                    .FirstOrDefault() ?? "None";
                
                lblStatRecentVal.Text = recentMed;
                lblStatRecentSub.Text = DateTime.Now.ToString("MMM dd, yyyy");
            }
        }

        private void FilterMedications()
        {
            string search = txtSearch.Text.ToLower();
            string formFilter = cmbFormFilter.SelectedItem?.ToString() ?? "All forms";

            var filtered = _allMeds.Where(m =>
                (string.IsNullOrEmpty(search) || m.MedicationName.ToLower().Contains(search) || m.Category.ToLower().Contains(search)) &&
                (formFilter == "All forms" || m.Form == formFilter)
            ).ToList();

            dgvMeds.Rows.Clear();
            
            foreach (var m in filtered)
            {
                var rowIndex = dgvMeds.Rows.Add(
                    $"{m.MedicationName} \n({m.Category})",
                    m.DosageUnit,
                    m.Form,
                    m.Frequency
                );
                dgvMeds.Rows[rowIndex].Tag = m.MedicationID;
            }
            lblShowingCount.Text = $"Showing {filtered.Count} of {_allMeds.Count}";
        }
    }
}
