namespace elnet_recoverease
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
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
                        MessageBox.Show($"Database schema update failed:\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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