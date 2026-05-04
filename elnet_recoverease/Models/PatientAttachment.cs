using System;

namespace elnet_recoverease.Models
{
    public class PatientAttachment
    {
        public int PatientAttachmentID { get; set; }
        public int PatientID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.Now;
    }
}
