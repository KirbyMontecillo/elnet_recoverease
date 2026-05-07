using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elnet_recoverease.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int? PatientID { get; set; }
        public int? DoctorID { get; set; }
        public string? DoctorName { get; set; }
        public string? AppointmentType { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string? Notes { get; set; }
        public string? Status { get; set; } // Scheduled, Completed, Cancelled
        public int DurationMinutes { get; set; } = 30;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        // Clinical Session Data
        public int? RecoveryProgress { get; set; } // 0-100%
        public string? BloodPressure { get; set; }
        public string? Temperature { get; set; }
        public string? HeartRate { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public string? BMI { get; set; }
        public string? ChiefComplaint { get; set; }
        public string? Diagnosis { get; set; }
        public string? TreatmentGoals { get; set; }
        public string? DoctorNotes { get; set; }
        public string? PlanNotes { get; set; }
        public DateTime? FinalizedAt { get; set; }

        // Navigation Properties
        public string? PatientName { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
