using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elnet_recoverease
{
    public partial class Treatment_Plans : Form
    {
        public Treatment_Plans()
        {
            InitializeComponent();
            LoadLogo();
            WireNavigation();
        }

        private void WireNavigation()
        {
            RegisterNavClick(btnNavDashboard, (s, e) => OpenForm(new Patient_Dashboard()));
            RegisterNavClick(btnNavProfile, (s, e) => OpenForm(new Patient_Profile()));
            RegisterNavClick(btnNavMeds, (s, e) => OpenForm(new Medications()));
            RegisterNavClick(btnNavMedSchedule, (s, e) => OpenForm(new Medication_Schedule()));
            RegisterNavClick(btnNavAppointments, (s, e) => OpenForm(new Appointments()));
            RegisterNavClick(btnNavTreatment, (s, e) => { /* Already here */ });

            btnLogout.Click += (s, e) => {
                new Login().Show();
                this.Close();
            };
        }

        private void RegisterNavClick(Panel panel, EventHandler handler)
        {
            panel.Click += handler;
            foreach (Control c in panel.Controls) c.Click += (s, e) => handler(panel, e);
        }

        private void OpenForm(Form childForm)
        {
            childForm.Show();
            this.Hide();
        }

        private void LoadLogo()
        {
            try
            {
                string logoPath = @"C:\Users\Kirby\OneDrive\Desktop\elnet_recoverease\elnet_recoverease\images\logo.png";
                if (System.IO.File.Exists(logoPath))
                {
                    picLogo.Image = System.Drawing.Image.FromFile(logoPath);
                }
            }
            catch { }
        }
    }
}
