using System;
using System.Windows.Forms;

namespace elnet_recoverease
{
    public partial class Patient_Dashboard : Form
    {
        public Patient_Dashboard()
        {
            InitializeComponent();
            LoadLogo();
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
                else
                {
                    string relPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\images\logo.png");
                    if (System.IO.File.Exists(relPath))
                    {
                        picLogo.Image = System.Drawing.Image.FromFile(relPath);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading logo: " + ex.Message);
            }
        }
    }
}