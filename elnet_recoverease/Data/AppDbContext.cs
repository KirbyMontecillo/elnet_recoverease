using elnet_recoverease.Models;
// using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Models;

namespace elnet_recoverease.Data
{
    internal class AppDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<TreatmentPlan> TreatmentPlans { get; set; }
        public DbSet<MedicationSchedule> MedicationSchedules { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<PatientAttachment> PatientAttachments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(
                "Server=localhost\\SQLEXPRESS01;Database=RecoverEaseDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
    }
}
