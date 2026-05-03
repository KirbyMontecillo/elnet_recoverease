using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elnet_recoverease.Models
{
    public class MedicationSchedule
    {
        public int ScheduleID { get; set; }
        public int PatientID { get; set; }
        public int MedicationID { get; set; }
        public TimeOnly ScheduledTime { get; set; }
        public bool IsTaken { get; set; }
        public DateOnly ScheduledDate { get; set; }
        public bool IsMissed { get; set; }
    }
}
