using Microsoft.EntityFrameworkCore;
using elnet_recoverease.Models;

namespace elnet_recoverease.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<TreatmentPlan> TreatmentPlans { get; set; }
        public DbSet<MedicationSchedule> MedicationSchedules { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<PatientAttachment> PatientAttachments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Update the connection string if your SQL Server instance name is different
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=RecoverEaseDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Initial Admin User
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 1,
                Username = "admin",
                PasswordHash = "admin123", // In a real app, use BCrypt or similar hashing
                Role = "Admin"
            });

            // Seed Initial Staff Profile for Admin
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffID = 1,
                FullName = "System Administrator",
                Role = "Admin",
                Specialty = "Systems",
                LicenseNumber = "ADMIN-001",
                ContactNumber = "000-000-0000",
                Status = "Active",
                UserID = 1
            });
        }
    }
}
