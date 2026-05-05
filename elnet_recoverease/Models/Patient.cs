using System;

namespace elnet_recoverease.Models
{
    public class Patient
    {
        public int PatientID { get; set; } // Primary Key
        public string PatientCode { get; set; } // "P-0001" format
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyPhone { get; set; }
        public string EmergencyRelationship { get; set; }
        public string Gender { get; set; }
        public string AttendingDoctor { get; set; }
        public string Status { get; set; } // Active, Discharged, Archived
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Medical Info (Doctors only)
        public string BloodType { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Allergies { get; set; }

        // Link to User account
        public int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}
