using elnet_recoverease.Models;

namespace elnet_recoverease.Core
{
    public static class UserSession
    {
        public static User? CurrentUser { get; set; }
        public static elnet_recoverease.Models.Patient? CurrentPatient { get; set; }
        public static Staff? CurrentStaff { get; set; }

        public static void Logout()
        {
            CurrentUser = null;
            CurrentPatient = null;
            CurrentStaff = null;
        }
    }
}
