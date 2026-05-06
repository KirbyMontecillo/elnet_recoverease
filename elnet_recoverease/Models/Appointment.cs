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
        public string? DoctorName { get; set; }
        public string? AppointmentType { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string? Notes { get; set; }
        public string? Status { get; set; } // Scheduled, Completed, Cancelled
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        // Clinical Session Data
        public int? RecoveryProgress { get; set; } // 0-100%
        public string? BloodPressure { get; set; }
        public string? Temperature { get; set; }
        public string? HeartRate { get; set; }
        public string? Weight { get; set; }
        public DateTime? FinalizedAt { get; set; }
    }
}
