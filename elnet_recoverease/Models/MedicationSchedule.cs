using System;

namespace elnet_recoverease.Models
{
    public class MedicationSchedule
    {
        public int MedicationScheduleID { get; set; }
        public int PatientID { get; set; }
        public int MedicationID { get; set; }
        public string? MedicationName { get; set; }
        public string? DosageUnit { get; set; }
        public string? Frequency { get; set; }
        public TimeOnly? ScheduledTime { get; set; }
        public bool IsTaken { get; set; }
        public DateOnly ScheduledDate { get; set; }
        public bool IsMissed { get; set; }
        public string? Status { get; set; } // Pending, Taken, Missed
        public string? Notes { get; set; }
        public int? AppointmentID { get; set; }
    }
}
