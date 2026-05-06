using elnet_recoverease.Core;
using elnet_recoverease.Data;
using System.Data;

namespace elnet_recoverease.Admin
{
    public partial class Admin_Report : Form
    {
        private string _selectedReport = "";

        public Admin_Report()
        {
            InitializeComponent();
            try { this.picLogo.Image = System.Drawing.Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }

            // Wire up navigation
            NavigationHelper.WireNavButton(this.btnNavDashboard, () => NavigationHelper.SwitchForm(this, new Admin_Dashboard()));
            NavigationHelper.WireNavButton(this.btnNavStaff, () => NavigationHelper.SwitchForm(this, new Staff_List()));
            NavigationHelper.WireNavButton(this.btnNavPatients, () => NavigationHelper.SwitchForm(this, new Medication_List()));
            this.btnLogout.Click += (s, e) => NavigationHelper.Logout(this);

            // Wire up report actions
            this.btnGenerateReport.Click += (s, e) => GenerateReport();
            
            LoadDoctors();
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
                // We launch the viewer
                Report_Viewer viewer = new Report_Viewer();
                viewer.Show();
                
                // NEW: We call the Live Generation engine!
                // This will fetch real data from your database and show it instantly.
                viewer.GenerateLiveReport(_selectedReport, fromDate, toDate, selectedDoctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching live report: " + ex.Message, "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateActivityReport()
        {
             try
            {
                using (var db = new AppDbContext())
                {
                    // For activity audit, we'll just show the viewer for now
                    // In a real scenario, you'd fetch logs from a Logs table
                    Report_Viewer viewer = new Report_Viewer();
                    viewer.Show();
                    
                    MessageBox.Show("Ready to bind 'System_Activity_Audit.rpt'.\n\nPlease create the report file in Visual Studio.", "Report Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating activity report: " + ex.Message);
            }
        }

        private void GenerateStaffReport()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var staffList = db.Staff.ToList();
                    DataTable dt = ToDataTable(staffList, "StaffData");

                    // This is where you would load your .rpt file
                    // For now, we show the viewer window
                    Report_Viewer viewer = new Report_Viewer();
                    viewer.Show();
                    
                    MessageBox.Show("Ready to bind 'Staff_Directory.rpt'.\n\nPlease create the report file in Visual Studio and link it here.", "Report Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating staff report: " + ex.Message);
            }
        }

        private void GenerateMedReport()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var meds = db.Medications.ToList();
                    DataTable dt = ToDataTable(meds, "MedicationData");

                    Report_Viewer viewer = new Report_Viewer();
                    viewer.Show();

                    MessageBox.Show("Ready to bind 'Medication_Inventory.rpt'.\n\nPlease create the report file in Visual Studio and link it here.", "Report Ready", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating medication report: " + ex.Message);
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
