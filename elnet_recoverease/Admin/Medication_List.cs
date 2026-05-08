using elnet_recoverease.Core;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace elnet_recoverease.Admin
{
    public partial class Medication_List : Form
    {
        private List<Medication> _allMeds = new List<Medication>();
        private System.Windows.Forms.Timer _searchTimer;

        public Medication_List()
        {
            InitializeComponent();
            
            InitializeSearchTimer();
            SetupForm();
            LoadMedicationData();
            this.Load += new System.EventHandler(Medication_List_Load);
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

        private void SetupForm()
        {
            try 
            { 
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\images\logo.png");
                if (!System.IO.File.Exists(logoPath)) logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath)) this.picLogo.Image = Image.FromFile(logoPath); 
            } 
            catch { }
            
            // Navigation
            NavigationHelper.WireNavButton(this.btnNavDashboard, new EventHandler(btnNavDashboard_Click));
            NavigationHelper.WireNavButton(this.btnNavStaff, new EventHandler(btnNavStaff_Click));
            NavigationHelper.WireNavButton(this.btnNavPatients, new EventHandler(btnNavPatients_Click));
            NavigationHelper.WireNavButton(this.btnNavReports, new EventHandler(btnNavReports_Click));
            NavigationHelper.WireNavButton(this.btnNavProfile, new EventHandler(btnNavProfile_Click));
            NavigationHelper.WireNavButton(this.pnlAvatarTop, new EventHandler(btnNavProfile_Click));
            this.btnLogout.Click += new System.EventHandler(btnLogout_Click);

            // Filters
            this.cmbFormFilter.SelectedIndexChanged += new System.EventHandler(cmbFormFilter_SelectedIndexChanged);

            // Actions
            this.dgvMeds.CellContentClick += new DataGridViewCellEventHandler(dgvMeds_CellContentClick);
        }

        private void Medication_List_Load(object sender, EventArgs e)
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
            /* Current Form */
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Report());
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            NavigationHelper.SwitchForm(this, new Admin_Profile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.Logout(this);
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

            if (e.ColumnIndex == 4) // Edit
            {
                using (var form = new Edit_Medicine(medId))
                {
                    if (form.ShowDialog() == DialogResult.OK) LoadMedicationData();
                }
            }
            else if (e.ColumnIndex == 5) // Delete
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
            
            // Optimization: Batch row adding if there were many, but dgvMeds is usually small enough.
            foreach (var m in filtered)
            {
                var rowIndex = dgvMeds.Rows.Add(
                    $"{m.MedicationName} \n({m.Category})",
                    m.DosageUnit,
                    m.Form,
                    m.Frequency,
                    "✏ Edit",
                    "🗑 Delete"
                );
                dgvMeds.Rows[rowIndex].Tag = m.MedicationID;
            }
            lblShowingCount.Text = $"Showing {filtered.Count} of {_allMeds.Count}";
        }
    }
}
