using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elnet_recoverease.Models
{
    public class PatientAttachment
    {
        public int AttachmentID { get; set; }
        public int PatientID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
