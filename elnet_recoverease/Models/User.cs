using System;

namespace elnet_recoverease.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? Role { get; set; } // Admin, Doctor, Nurse, Patient
        public bool IsFirstLogin { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
