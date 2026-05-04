using System;

namespace elnet_recoverease.Models
{
    public class Medication
    {
        public int MedicationID { get; set; }
        public string MedicationName { get; set; }
        public string Category { get; set; }
        public string DosageUnit { get; set; }
        public string Status { get; set; } // Available, Out of Stock, Discontinued
        public string Description { get; set; }
    }
}
