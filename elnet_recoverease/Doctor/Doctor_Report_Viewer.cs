using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;
using Microsoft.Web.WebView2.Core;

namespace elnet_recoverease.Doctor
{
    public partial class Doctor_Report_Viewer : Form
    {
        private string _currentReportType = "";
        private DateTime _currentFrom;
        private DateTime _currentTo;
        private string _currentDoctor = "";

        public Doctor_Report_Viewer()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            AddToolBar();
        }

        private void AddToolBar()
        {
            ToolStrip ts = new ToolStrip();
            ts.Dock = DockStyle.Top;
            ts.ImageScalingSize = new Size(24, 24);

            ToolStripButton btnPrint = new ToolStripButton("🖨️ Print", null, (s, e) => wvReport.CoreWebView2.ShowPrintUI());
            ToolStripButton btnPdf = new ToolStripButton("💾 Save as PDF", null, (s, e) => SaveToPdf());
            ToolStripButton btnExcel = new ToolStripButton("📊 Export to Excel", null, (s, e) => ExportToExcel());

            ts.Items.Add(btnPrint);
            ts.Items.Add(new ToolStripSeparator());
            ts.Items.Add(btnPdf);
            ts.Items.Add(new ToolStripSeparator());
            ts.Items.Add(btnExcel);

            this.Controls.Add(ts);
        }

        private async void SaveToPdf()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = $"{_currentReportType.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    await wvReport.CoreWebView2.PrintToPdfAsync(sfd.FileName);
                    if (MessageBox.Show("PDF saved successfully! Open it now?", "Success", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Save failed: " + ex.Message); }
        }

        private void ExportToExcel()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"{_currentReportType.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd}";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.Text.StringBuilder csv = new System.Text.StringBuilder();
                    using (var db = new AppDbContext())
                    {
                        var fromDateOnly = DateOnly.FromDateTime(_currentFrom);
                        var toDateOnly = DateOnly.FromDateTime(_currentTo);
                        var nowOnly = DateOnly.FromDateTime(DateTime.Now);

                        if (_currentReportType == "Patient Adherence")
                        {
                            csv.AppendLine("Patient Name,Scheduled,Taken,Adherence Rate");
                            var schedules = db.MedicationSchedules.Where(s => s.ScheduledDate >= fromDateOnly && s.ScheduledDate <= toDateOnly).ToList();
                            var patients = db.Patients.Where(p => p.AttendingDoctor == _currentDoctor).ToList();
                            foreach (var p in patients)
                            {
                                var pSchedules = schedules.Where(s => s.PatientID == p.PatientID).ToList();
                                if (pSchedules.Count == 0) continue;
                                int taken = pSchedules.Count(s => s.IsTaken);
                                double rate = (double)taken / pSchedules.Count * 100;
                                csv.AppendLine($"\"{p.FullName}\",\"{pSchedules.Count}\",\"{taken}\",\"{rate:F1}%\"");
                            }
                        }
                        else if (_currentReportType == "Missed Medication")
                        {
                            csv.AppendLine("Patient Name,Medication,Date,Time");
                            var missed = (from s in db.MedicationSchedules
                                         join p in db.Patients on s.PatientID equals p.PatientID
                                         join m in db.Medications on s.MedicationID equals m.MedicationID
                                         where s.ScheduledDate >= fromDateOnly && s.ScheduledDate <= toDateOnly
                                         && p.AttendingDoctor == _currentDoctor && !s.IsTaken && s.ScheduledDate < nowOnly
                                         select new { p.FullName, m.MedicationName, s.ScheduledDate, s.ScheduledTime }).ToList();
                            foreach (var x in missed) csv.AppendLine($"\"{x.FullName}\",\"{x.MedicationName}\",\"{x.ScheduledDate}\",\"{x.ScheduledTime}\"");
                        }
                        else if (_currentReportType == "Appointment Summary")
                        {
                            csv.AppendLine("Date,Patient Name,Notes,Status");
                            var appts = (from a in db.Appointments join p in db.Patients on a.PatientID equals p.PatientID
                                        where a.AppointmentDate >= _currentFrom && a.AppointmentDate <= _currentTo && p.AttendingDoctor == _currentDoctor
                                        select new { a.AppointmentDate, p.FullName, a.Notes, a.Status }).ToList();
                            foreach (var x in appts) csv.AppendLine($"\"{x.AppointmentDate}\",\"{x.FullName}\",\"{x.Notes}\",\"{x.Status}\"");
                        }
                        else if (_currentReportType == "Treatment Plan Progress")
                        {
                            csv.AppendLine("Patient Name,Plan Details,Start Date,Target End");
                            var plans = (from tp in db.TreatmentPlans join p in db.Patients on tp.PatientID equals p.PatientID
                                        where p.AttendingDoctor == _currentDoctor
                                        select new { p.FullName, tp.PlanDetails, tp.StartDate, tp.EndDate }).ToList();
                            foreach (var x in plans) csv.AppendLine($"\"{x.FullName}\",\"{x.PlanDetails}\",\"{x.StartDate}\",\"{x.EndDate}\"");
                        }
                    }
                    System.IO.File.WriteAllText(sfd.FileName, csv.ToString());
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
            catch (Exception ex) { MessageBox.Show("Export failed: " + ex.Message); }
        }

        public void GenerateLiveReport(string reportType, DateTime dateFrom, DateTime dateTo, string doctorName)
        {
            this.Text = $"Doctor Clinical Audit - {reportType}";
            UpdatePreview(reportType, dateFrom, dateTo, doctorName);
        }

        private async void UpdatePreview(string reportType, DateTime dateFrom, DateTime dateTo, string doctorName)
        {
            if (wvReport.CoreWebView2 == null) await wvReport.EnsureCoreWebView2Async(null);
            string html = GetReportHtml(reportType, dateFrom, dateTo, doctorName);
            wvReport.CoreWebView2.NavigateToString(html);
        }

        public string GetReportHtml(string reportType, DateTime dateFrom, DateTime dateTo, string doctor)
        {
            _currentReportType = reportType;
            _currentFrom = dateFrom;
            _currentTo = dateTo;
            _currentDoctor = doctor;

            ScheduleManager.UpdateMissedSchedules();
            string contentHtml = "";
            using (var db = new AppDbContext())
            {
                var fromDateOnly = DateOnly.FromDateTime(dateFrom);
                var toDateOnly = DateOnly.FromDateTime(dateTo);
                var nowOnly = DateOnly.FromDateTime(DateTime.Now);
                
                // For appointments, we need to cover the full range of the end date
                var rangeEnd = dateTo.Date.AddDays(1).AddSeconds(-1);
                var doctorLower = doctor?.ToLower() ?? "";

                if (reportType == "Patient Adherence")
                {
                    var schedules = db.MedicationSchedules
                        .Where(s => s.ScheduledDate >= fromDateOnly && s.ScheduledDate <= toDateOnly)
                        .ToList();

                    var patients = db.Patients
                        .Where(p => (p.AttendingDoctor != null && p.AttendingDoctor.ToLower() == doctorLower) || (p.AttendingDoctor == null && doctorLower == ""))
                        .ToList();
                    var adherenceData = new List<string[]>();

                    foreach (var p in patients)
                    {
                        var pSchedules = schedules.Where(s => s.PatientID == p.PatientID).ToList();
                        if (pSchedules.Count == 0) continue;

                        int taken = pSchedules.Count(s => s.IsTaken);
                        double rate = (double)taken / pSchedules.Count * 100;
                        adherenceData.Add(new[] { p.FullName, pSchedules.Count.ToString(), taken.ToString(), $"{rate:F1}%" });
                    }
                    contentHtml = BuildTableHtml(new[] { "Patient Name", "Scheduled", "Taken", "Adherence Rate" }, adherenceData);
                }
                else if (reportType == "Missed Medication")
                {
                    var missed = (from s in db.MedicationSchedules
                                 join p in db.Patients on s.PatientID equals p.PatientID
                                 join m in db.Medications on s.MedicationID equals m.MedicationID
                                 where s.ScheduledDate >= fromDateOnly && s.ScheduledDate <= toDateOnly
                                 && p.AttendingDoctor.ToLower() == doctorLower
                                 && s.IsMissed
                                 select new { p.FullName, m.MedicationName, s.ScheduledDate, s.ScheduledTime })
                                 .OrderByDescending(x => x.ScheduledDate).ToList();

                    contentHtml = BuildTableHtml(new[] { "Patient Name", "Medication", "Date", "Time" },
                        missed.Select(x => new[] { x.FullName, x.MedicationName, x.ScheduledDate.ToShortDateString(), x.ScheduledTime.ToString() }).ToList());
                }
                else if (reportType == "Appointment Summary")
                {
                    var appts = (from a in db.Appointments
                                join p in db.Patients on a.PatientID equals p.PatientID
                                where a.AppointmentDate >= dateFrom.Date && a.AppointmentDate <= rangeEnd
                                && p.AttendingDoctor.ToLower() == doctorLower
                                select new { a.AppointmentDate, p.FullName, a.Notes, a.Status })
                                .OrderBy(x => x.AppointmentDate).ToList();

                    contentHtml = BuildTableHtml(new[] { "Date", "Patient Name", "Notes", "Status" },
                        appts.Select(x => new[] { x.AppointmentDate?.ToString("MM/dd HH:mm") ?? "N/A", x.FullName, x.Notes, x.Status }).ToList());
                }
                else if (reportType == "Treatment Plan Progress")
                {
                    var plans = (from tp in db.TreatmentPlans
                                join p in db.Patients on tp.PatientID equals p.PatientID
                                where p.AttendingDoctor.ToLower() == doctorLower
                                select new { p.FullName, tp.PlanDetails, tp.StartDate, tp.EndDate })
                                .OrderBy(x => x.FullName).ToList();

                    contentHtml = BuildTableHtml(new[] { "Patient Name", "Plan Details", "Start Date", "Target End" },
                        plans.Select(x => new[] { x.FullName, x.PlanDetails, x.StartDate.ToShortDateString(), x.EndDate.ToShortDateString() }).ToList());
                }
            }

            return $@"
            <html>
            <head>
                <style>
                    body {{ font-family: 'Segoe UI', sans-serif; color: #1e293b; padding: 40px; background: #f8fafc; }}
                    .report-container {{ background: white; padding: 40px; border-radius: 12px; box-shadow: 0 4px 6px -1px rgba(0,0,0,0.1); border: 1px solid #e2e8f0; }}
                    .header {{ display: flex; justify-content: space-between; align-items: flex-start; border-bottom: 2px solid #00a8a8; padding-bottom: 20px; margin-bottom: 30px; }}
                    .logo-section h1 {{ color: #00a8a8; margin: 0; font-size: 28px; }}
                    .logo-section p {{ color: #64748b; margin: 5px 0 0 0; font-size: 14px; }}
                    .meta-section {{ text-align: right; }}
                    .meta-section h2 {{ margin: 0; color: #0f172a; font-size: 20px; text-transform: uppercase; letter-spacing: 1px; }}
                    .meta-section p {{ margin: 5px 0 0 0; color: #64748b; font-size: 13px; }}
                    table {{ width: 100%; border-collapse: collapse; margin-top: 20px; }}
                    th {{ text-align: left; background: #f1f5f9; color: #475569; font-size: 12px; text-transform: uppercase; padding: 15px; border-bottom: 1px solid #e2e8f0; }}
                    td {{ padding: 15px; border-bottom: 1px solid #f1f5f9; font-size: 14px; color: #334155; }}
                    tr:hover td {{ background: #f8fafc; }}
                    .no-data {{ padding: 50px; text-align: center; color: #94a3b8; font-style: italic; }}
                </style>
            </head>
            <body>
                <div class='report-container'>
                    <div class='header'>
                        <div class='logo-section'>
                            <h1>RecoverEase</h1>
                            <p>Clinical Practitioner Workstation</p>
                        </div>
                        <div class='meta-section'>
                            <h2>{reportType}</h2>
                            <p>Period: {dateFrom:MM/dd/yy} - {dateTo:MM/dd/yy}</p>
                            <p>Practitioner: {doctor}</p>
                        </div>
                    </div>
                    {contentHtml}
                </div>
            </body>
            </html>";
        }

        private string BuildTableHtml(string[] headers, List<string[]> rows)
        {
            if (rows == null || rows.Count == 0)
                return "<div class='no-data'>No clinical records found for the selected filters.</div>";

            string html = "<table><thead><tr>";
            foreach (var h in headers) html += $"<th>{h}</th>";
            html += "</tr></thead><tbody>";

            foreach (var row in rows)
            {
                html += "<tr>";
                foreach (var cell in row) html += $"<td>{cell}</td>";
                html += "</tr>";
            }
            html += "</tbody></table>";
            return html;
        }
    }
}
