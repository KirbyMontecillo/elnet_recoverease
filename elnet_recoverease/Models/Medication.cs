using System;

namespace elnet_recoverease.Models
{
    public class Medication
    {
        public int MedicationID { get; set; }
        public string? MedicationName { get; set; }
        public string? Category { get; set; }
        public string? DosageUnit { get; set; }
        public string? Form { get; set; } // Tablet, Capsule, Syrup, etc.
        public string? Frequency { get; set; } // Once daily, 2x daily, etc.
        public string? Description { get; set; }
        public string? Status { get; set; } = "Active"; // Available, Discontinued, etc.
    }
}
