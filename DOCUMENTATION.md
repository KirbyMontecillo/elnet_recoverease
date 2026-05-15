# RecoverEase System Documentation

## Project Overview
**RecoverEase** is a comprehensive healthcare management system designed to streamline clinical workflows, patient record-keeping, and medication tracking. Built on the .NET 8 framework, it provides a secure, modern, and professional interface tailored for healthcare providers and patients alike.

---

## 🛠 Tech Stack
- **Framework:** .NET 8.0 (Windows Desktop)
- **Programming Language:** C# 12.0
- **UI Framework:** 
  - Windows Forms (WinForms)
  - WPF Integration (for advanced UI components)
  - WebView2 (for embedded web content)
- **Database:** Microsoft SQL Server
- **ORM:** Entity Framework Core 8.0 (Code First)
- **Reporting:** SAP Crystal Reports
- **Data Visualization:** System.Windows.Forms.DataVisualization (Charts & Analytics)
- **Version Control:** GitHub

---

## 🚀 System Features

### 1. Core Features
- **User Login / Authentication:** Role-based secure access system for Admins, Doctors, and Patients.
- **Master File (CRUD):** 
  - **Patient Management:** Comprehensive records for patient registration and updates.
  - **Staff Management:** Administrative control over clinical personnel (Doctors, Nurses, Admins).
  - **Medicine Inventory:** Management of the medication database used within the system.
- **Transaction Module:** 
  - **Appointment Scheduling:** Real-time scheduling and management of clinical visits.
  - **Treatment Planning:** Long-term clinical strategy mapping for patient recovery.
- **Reports Generation:** Professional reporting via Crystal Reports for clinical data, patient history, and system logs.
- **Search and Filter:** Advanced filtering capabilities across all lists (Patients, Staff, Medications, Appointments).
- **Dashboard / Analytics:** Role-specific dashboards featuring real-time statistics and visual data charts.
- **Notifications:** In-app alerts for system updates and important clinical events.
- **Auto Medication Reminders:** Automated system to notify patients of their upcoming medication dosages.
- **Auto Warning for Missed Medication:** Proactive alerts for healthcare providers when a patient misses a scheduled dose.
- **File Attachment for Patient Records:** Secure storage and retrieval of external medical documents and attachments.

### 2. Additional Features (Not in standard list)
- **Clinic-wide Adherence Monitoring:** Real-time tracking of medication adherence percentages across all patients and attending doctors.
- **Critical Alert System:** Automated warnings for adherence slumps (below 85%) and missed medications today.
- **Clinical Documentation (Clinical Notes):** Dedicated module for doctors to record detailed consultation notes and assessments.
- **Multi-Role Module Architecture:** Completely isolated interfaces for **Admin**, **Doctor**, and **Patient** to ensure data privacy.
- **Recent Activity Feed:** Live tracking of new patient registrations, staff onboarding, and critical clinical warnings.
- **Patient Status Lifecycle:** Visual tracking of patient states (e.g., Active, Discharged, Pending).
- **Medication Schedule Mapping:** Visual timeline and scheduling tool for complex medication regimes.
- **Database Migrations:** Automated database schema management using EF Core Migrations for seamless updates.
- **Responsive Layout Design:** Professional docking and anchoring system ensuring the UI adapts to various screen resolutions.

---

## 📂 Project Structure
- **Admin/**: Contains controls and forms specific to system administration and inventory management.
- **Doctor/**: Contains modules for clinical consultation, patient lists, and appointment management.
- **PatientModule/**: Dedicated interface for patients to view their schedules, medications, and health progress.
- **Models/**: Entity definitions (Patient, Staff, Medication, Appointment, etc.).
- **Data/**: Database context and configuration.
- **Shared/**: Reusable UI components and utility classes used across the application.

---

## 🗄 Database Schema
The system utilizes a relational database structure including the following primary entities:
- `Patients`: Core demographics and clinical status.
- `Staff/Users`: Authentication and role-based data.
- `Medications`: Master list of available drugs and dosages.
- `Appointments`: Transactional records of doctor-patient meetings.
- `MedicationSchedules`: Logical mapping of dose timings and adherence.
- `ClinicalNotes`: Historical record of patient assessments.
- `PatientAttachments`: Metadata for uploaded medical files.
- `TreatmentPlans`: Structured recovery strategies.

---

## 🔧 Getting Started
1. **Prerequisites:** 
   - Visual Studio 2022
   - .NET 8 SDK
   - SQL Server (LocalDB or Express)
   - Crystal Reports Runtime for .NET
2. **Setup:**
   - Clone the repository from GitHub.
   - Update the connection string in the `DbContext` if necessary.
   - Run `Update-Database` in the Package Manager Console to initialize the schema.
   - Build and Run the project.
