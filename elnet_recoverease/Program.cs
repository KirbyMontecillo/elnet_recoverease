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

            // Ensure DB Schema is synced
            using (var db = new elnet_recoverease.Data.AppDbContext())
            {
                db.EnsureSchemaUpdated();
            }

            Application.Run(new Login());

            //         Application.Run(new Login());
        }
    }
}