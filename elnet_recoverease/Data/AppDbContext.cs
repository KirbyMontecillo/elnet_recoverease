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
        public DbSet<ClinicalNote> ClinicalNotes { get; set; }
        public AppDbContext()
        {
            EnsureSchemaUpdated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=RecoverEaseDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public void EnsureSchemaUpdated()
        {
            try
            {
                this.Database.OpenConnection();
                using (var command = this.Database.GetDbConnection().CreateCommand())
                {
                    // Add DoctorName
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'DoctorName') " +
                                         "ALTER TABLE Appointments ADD DoctorName NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    // Add AppointmentType
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'AppointmentType') " +
                                         "ALTER TABLE Appointments ADD AppointmentType NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    // Add CreatedAt
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'CreatedAt') " +
                                         "ALTER TABLE Appointments ADD CreatedAt DATETIME2 NULL;";
                    command.ExecuteNonQuery();

                    // Add RecoveryProgress
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'RecoveryProgress') " +
                                         "ALTER TABLE Appointments ADD RecoveryProgress INT DEFAULT 0;";
                    command.ExecuteNonQuery();

                    // Add Vitals
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'BloodPressure') " +
                                         "ALTER TABLE Appointments ADD BloodPressure NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'Temperature') " +
                                         "ALTER TABLE Appointments ADD Temperature NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'HeartRate') " +
                                         "ALTER TABLE Appointments ADD HeartRate NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'Weight') " +
                                         "ALTER TABLE Appointments ADD Weight NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'Height') " +
                                         "ALTER TABLE Appointments ADD Height NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'BMI') " +
                                         "ALTER TABLE Appointments ADD BMI NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'ChiefComplaint') " +
                                         "ALTER TABLE Appointments ADD ChiefComplaint NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'Diagnosis') " +
                                         "ALTER TABLE Appointments ADD Diagnosis NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'PlanNotes') " +
                                         "ALTER TABLE Appointments ADD PlanNotes NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'FinalizedAt') " +
                                         "ALTER TABLE Appointments ADD FinalizedAt DATETIME2 NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('MedicationSchedules') AND name = 'Notes') " +
                                         "ALTER TABLE MedicationSchedules ADD Notes NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    // Add ClinicalNotes Table
                    command.CommandText = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ClinicalNotes')
                                          CREATE TABLE ClinicalNotes (
                                              ClinicalNoteID INT PRIMARY KEY IDENTITY(1,1),
                                              PatientID INT NOT NULL,
                                              StaffID INT NOT NULL,
                                              NoteContent NVARCHAR(MAX) NOT NULL,
                                              CreatedAt DATETIME2 NOT NULL DEFAULT GETDATE()
                                          );";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'DoctorID') ALTER TABLE Appointments ADD DoctorID INT NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'DurationMinutes') ALTER TABLE Appointments ADD DurationMinutes INT NOT NULL DEFAULT 30;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'PatientName') ALTER TABLE Appointments ADD PatientName NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    // MedicationSchedule Updates
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('MedicationSchedules') AND name = 'MedicationName') ALTER TABLE MedicationSchedules ADD MedicationName NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('MedicationSchedules') AND name = 'DosageUnit') ALTER TABLE MedicationSchedules ADD DosageUnit NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('MedicationSchedules') AND name = 'Frequency') ALTER TABLE MedicationSchedules ADD Frequency NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('MedicationSchedules') AND name = 'Status') ALTER TABLE MedicationSchedules ADD Status NVARCHAR(MAX) NULL DEFAULT 'Pending';";
                    command.ExecuteNonQuery();

                    // Add TreatmentGoals and DoctorNotes to Appointments
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'TreatmentGoals') ALTER TABLE Appointments ADD TreatmentGoals NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Appointments') AND name = 'DoctorNotes') ALTER TABLE Appointments ADD DoctorNotes NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();

                    // Staff Profile Updates
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Staff') AND name = 'Biography') ALTER TABLE Staff ADD Biography NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Staff') AND name = 'YearsOfExperience') ALTER TABLE Staff ADD YearsOfExperience NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Staff') AND name = 'Affiliations') ALTER TABLE Staff ADD Affiliations NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Staff') AND name = 'ClinicAddress') ALTER TABLE Staff ADD ClinicAddress NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                    command.CommandText = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('Staff') AND name = 'ProfileImagePath') ALTER TABLE Staff ADD ProfileImagePath NVARCHAR(MAX) NULL;";
                    command.ExecuteNonQuery();
                }
            }
            catch { }
            finally { this.Database.CloseConnection(); }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Initial Admin User
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 1,
                Username = "admin",
                PasswordHash = "admin123", // In a real app, use BCrypt or similar hashing
                Role = "Admin",
                IsFirstLogin = false
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
                Email = "admin@recoverease.com",
                UserID = 1
            });
        }
    }
}
