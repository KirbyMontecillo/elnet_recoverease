using System;

namespace elnet_recoverease.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } // Doctor, Nurse, Admin, etc.
        public string Specialty { get; set; }
        public string LicenseNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Status { get; set; } // Active, Inactive, On Leave
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Optional: Link to User account for login
        public int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}
