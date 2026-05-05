using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elnet_recoverease.Doctor
{
    public partial class Patient_List : Form
    {
        public Patient_List()
        {
            InitializeComponent();
            try { this.picLogo.Image = System.Drawing.Image.FromFile(@"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png"); } catch { }

            this.btnAddPatient.Click += (s, e) => {
                using (var regForm = new Register_Patient())
                {
                    if (regForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh grid or something if needed
                        LoadPatients();
                    }
                }
            };
        }

        private void LoadPatients()
        {
            // Implementation for loading patients into the grid
        }

    }
}
