using System;

namespace elnet_recoverease.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Status { get; set; } // Active, Discharged, Archived
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
