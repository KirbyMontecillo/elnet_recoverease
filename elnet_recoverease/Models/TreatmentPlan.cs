using System;

namespace elnet_recoverease.Models
{
    public class TreatmentPlan
    {
        public int TreatmentPlanID { get; set; }
        public int PatientID { get; set; }
        public string PlanDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
