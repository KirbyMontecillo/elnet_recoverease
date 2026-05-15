using System;
using System.IO;
using System.Windows.Forms;

namespace elnet_recoverease
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                // Ensure DB Schema is synced
                using (var db = new elnet_recoverease.Data.AppDbContext())
                {
                    try
                    {
                        db.EnsureSchemaUpdated();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database schema update failed:\n\n{ex.Message}\n\nThis usually happens if SQL Server is not running or the connection string is incorrect.", 
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Application.Run(new Login());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Application failed to start:\n\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", 
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
