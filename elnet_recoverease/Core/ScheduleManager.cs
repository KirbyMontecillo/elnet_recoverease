using System;
using System.Linq;
using elnet_recoverease.Data;
using elnet_recoverease.Models;

namespace elnet_recoverease.Core
{
    public static class ScheduleManager
    {
        public static void UpdateMissedSchedules()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var today = DateOnly.FromDateTime(DateTime.Now);
                    var nowTime = TimeOnly.FromDateTime(DateTime.Now);

                    // Optimization: Filter as much as possible on the database side.
                    // We fetch schedules that are not taken, not missed, and from today or earlier.
                    var potentialMissed = db.MedicationSchedules
                        .Where(s => !s.IsTaken && !s.IsMissed && s.ScheduledDate <= today)
                        .ToList();

                    // Perform precise time check in memory (or use specialized EF functions if available)
                    var trulyMissed = potentialMissed
                        .Where(s => s.ScheduledDate < today || (s.ScheduledDate == today && s.ScheduledTime.HasValue && s.ScheduledTime.Value < nowTime))
                        .ToList();

                    if (trulyMissed.Any())
                    {
                        foreach (var s in trulyMissed)
                        {
                            s.IsMissed = true;
                            s.Status = "Missed";
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                // Silently fail or log
            }
        }
    }
}
