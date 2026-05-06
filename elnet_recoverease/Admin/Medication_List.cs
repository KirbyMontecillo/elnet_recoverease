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

        public Medication_List()
        {
            InitializeComponent();
            SetupForm();
            LoadMedicationData();
        }

        private void SetupForm()
        {
            try { this.picLogo.Image = Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }
            
            // Wire up navigation
            NavigationHelper.WireNavButton(this.btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Admin_Dashboard()));
            NavigationHelper.WireNavButton(this.btnNavStaff, () => NavigationHelper.SwitchForm(this, new Staff_List()));
            NavigationHelper.WireNavButton(this.btnNavReports, () => NavigationHelper.SwitchForm(this, new Admin_Report()));
            this.btnLogout.Click += (s, e) => NavigationHelper.Logout(this);

            // Filters
            this.txtSearch.TextChanged += (s, e) => FilterMedications();
            this.cmbFormFilter.SelectedIndexChanged += (s, e) => FilterMedications();

            // Add Med
            this.btnAddMed.Click += (s, e) => {
                using (var form = new Edit_Medicine()) {
                    if (form.ShowDialog() == DialogResult.OK) LoadMedicationData();
                }
            };

            // Grid Actions
            this.dgvMeds.CellContentClick += (s, e) => {
                if (e.RowIndex < 0) return;
                int medId = (int)dgvMeds.Rows[e.RowIndex].Tag;

                if (e.ColumnIndex == 4) // Edit
                {
                    using (var form = new Edit_Medicine(medId)) {
                        if (form.ShowDialog() == DialogResult.OK) LoadMedicationData();
                    }
                }
                else if (e.ColumnIndex == 5) // Delete
                {
                    if (MessageBox.Show("Are you sure you want to delete this medication?", "Confirm Delete", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (var db = new AppDbContext()) {
                            var med = db.Medications.Find(medId);
                            if (med != null) {
                                db.Medications.Remove(med);
                                db.SaveChanges();
                                LoadMedicationData();
                            }
                        }
                    }
                }
            };

            // Stats
            this.pnlStatTotal.Cursor = Cursors.Hand;
        }

        private void LoadMedicationData()
        {
            using (var db = new AppDbContext())
            {
                _allMeds = db.Medications.ToList();

                // If empty, add sample data as per user's screenshot
                if (_allMeds.Count == 0)
                {
                    SeedSampleData(db);
                    _allMeds = db.Medications.ToList();
                }

                UpdateStats();
                FilterMedications();
            }
        }

        private void SeedSampleData(AppDbContext db)
        {
            var samples = new List<Medication>
            {
                new Medication { MedicationName = "Amoxicillin", Category = "Antibiotic", DosageUnit = "500mg", Form = "Capsule", Frequency = "3x daily", Description = "Broad-spectrum antibiotic for bacterial infections." },
                new Medication { MedicationName = "Metformin", Category = "Antidiabetic", DosageUnit = "500mg", Form = "Tablet", Frequency = "2x daily", Description = "Oral diabetes medicine that helps control blood sugar levels." },
                new Medication { MedicationName = "Paracetamol", Category = "Analgesic", DosageUnit = "650mg", Form = "Tablet", Frequency = "Every 6 hours", Description = "Pain reliever and a fever reducer." },
                new Medication { MedicationName = "Salbutamol", Category = "Bronchodilator", DosageUnit = "2mg/5ml", Form = "Syrup", Frequency = "3x daily", Description = "Relief of bronchospasm in bronchial asthma." },
                new Medication { MedicationName = "Insulin Glargine", Category = "Antidiabetic", DosageUnit = "100 IU/ml", Form = "Injection", Frequency = "Once daily", Description = "Long-acting insulin used to improve blood sugar control." },
                new Medication { MedicationName = "Cetirizine", Category = "Antihistamine", DosageUnit = "10mg", Form = "Tablet", Frequency = "Once daily", Description = "Used to treat cold or allergy symptoms." },
                new Medication { MedicationName = "Ibuprofen", Category = "Anti-inflammatory", DosageUnit = "400mg", Form = "Tablet", Frequency = "Every 8 hours", Description = "Nonsteroidal anti-inflammatory drug (NSAID)." },
                new Medication { MedicationName = "Omeprazole", Category = "Antacid", DosageUnit = "20mg", Form = "Capsule", Frequency = "Once daily", Description = "Decreases the amount of acid produced in the stomach." }
            };
            db.Medications.AddRange(samples);
            db.SaveChanges();
        }

        private void UpdateStats()
        {
            lblStatTotalVal.Text = _allMeds.Count.ToString();
            
            // Mocking these for the UI effect
            lblStatMostVal.Text = "Amoxicillin";
            lblStatRecentVal.Text = "Insulin Glargine";
            lblStatRecentSub.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void FilterMedications()
        {
            string search = txtSearch.Text.ToLower();
            string formFilter = cmbFormFilter.SelectedItem?.ToString() ?? "All forms";

            var filtered = _allMeds.Where(m =>
                (string.IsNullOrEmpty(search) || m.MedicationName.ToLower().Contains(search) || m.Category.ToLower().Contains(search)) &&
                (formFilter == "All forms" || m.Form == formFilter)
            ).ToList();

            dgvMeds.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMeds.Columns[0].DefaultCellStyle.Padding = new Padding(5);

            dgvMeds.Rows.Clear();
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
            lblShowingCount.Text = $"Showing {filtered.Count} of {_allMeds.Count} medications";
        }
    }
}
