using System;

namespace elnet_recoverease.Models
{
    public class ClinicalNote
    {
        public int ClinicalNoteID { get; set; }
        public int PatientID { get; set; }
        public int StaffID { get; set; } // The doctor/staff who wrote it
        public string NoteContent { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        // Navigation properties (optional for EF)
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
