using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using Microsoft.EntityFrameworkCore;

namespace elnet_recoverease.Admin
{
    public partial class Report_Viewer : Form
    {
        private AppDbContext _db = new AppDbContext();
        private string _currentReportType = "";
        private DateTime _currentFrom;
        private DateTime _currentTo;
        private string _currentDoctor = "";

        public Report_Viewer()
        {
            InitializeComponent();
            InitializeWebView();
            AddToolBar();
        }

        private void AddToolBar()
        {
            ToolStrip ts = new ToolStrip();
            ts.Dock = DockStyle.Top;
            ts.ImageScalingSize = new Size(24, 24);

            ToolStripButton btnPrint = new ToolStripButton("🖨️ Print", null, (s, e) => webView.CoreWebView2.ShowPrintUI());
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
                    await webView.CoreWebView2.PrintToPdfAsync(sfd.FileName);
                    if (MessageBox.Show("PDF saved successfully! Open it now?", "Success", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ProcessStartInfo psi = new ProcessStartInfo(sfd.FileName) { UseShellExecute = true };
                        Process.Start(psi);
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
                    StringBuilder csv = new StringBuilder();
                    using (var db = new AppDbContext())
                    {
                        bool isAllDoctors = string.IsNullOrEmpty(_currentDoctor) || _currentDoctor == "All Doctors";

                        if (_currentReportType == "Staff Directory")
                        {
                            csv.AppendLine("Name,Role,Specialty,Contact,Status");
                            var query = db.Staff.AsQueryable();
                            if (!isAllDoctors) query = query.Where(s => s.Role == _currentDoctor || s.FullName.Contains(_currentDoctor));
                            var staff = query.OrderBy(s => s.FullName).ToList();
                            foreach (var s in staff) csv.AppendLine($"\"{s.FullName}\",\"{s.Role}\",\"{s.Specialty}\",\"{s.ContactNumber}\",\"{s.Status}\"");
                        }
                        else if (_currentReportType == "Patient Master List")
                        {
                            csv.AppendLine("Patient ID,Name,Birthday,Gender,Doctor,Status");
                            var query = db.Patients.Where(p => p.CreatedAt >= _currentFrom && p.CreatedAt <= _currentTo);
                            if (!isAllDoctors) query = query.Where(p => p.AttendingDoctor == _currentDoctor);
                            var patients = query.OrderBy(p => p.FullName).ToList();
                            foreach (var p in patients) csv.AppendLine($"\"{p.PatientCode}\",\"{p.FullName}\",\"{p.DateOfBirth:yyyy-MM-dd}\",\"{p.Gender}\",\"{p.AttendingDoctor}\",\"{p.Status}\"");
                        }
                        else if (_currentReportType == "Appointment Summary")
                        {
                            csv.AppendLine("Date,Patient ID,Notes,Status");
                            var query = db.Appointments.Where(a => a.AppointmentDate >= _currentFrom && a.AppointmentDate <= _currentTo);
                            // For Appointment Summary, we filter by joining with Patient
                            var data = (from a in query
                                       join p in db.Patients on a.PatientID equals p.PatientID
                                       where isAllDoctors || p.AttendingDoctor == _currentDoctor
                                       select a).OrderBy(a => a.AppointmentDate).ToList();
                            foreach (var a in data) csv.AppendLine($"\"{a.AppointmentDate:yyyy-MM-dd HH:mm}\",\"{a.PatientID}\",\"{a.Notes}\",\"{a.Status}\"");
                        }
                    }
                    File.WriteAllText(sfd.FileName, csv.ToString());
                    Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
            catch (Exception ex) { MessageBox.Show("Export failed: " + ex.Message); }
        }

        private async void InitializeWebView()
        {
            try { await webView.EnsureCoreWebView2Async(null); }
            catch (Exception ex) { MessageBox.Show("WebView2 Error: " + ex.Message); }
        }

        public string GetReportHtml(string reportType, DateTime from, DateTime to, string doctor)
        {
            _currentReportType = reportType;
            _currentFrom = from;
            _currentTo = to;
            _currentDoctor = doctor;

            try
            {
                string title = reportType.ToUpper();
                string contentHtml = "";
                bool isAllDoctors = string.IsNullOrEmpty(doctor) || doctor == "All Doctors";

                using (var db = new AppDbContext())
                {
                    if (reportType == "Staff Directory")
                    {
                        var query = db.Staff.AsQueryable();
                        if (!isAllDoctors) query = query.Where(s => s.Role == doctor || s.FullName.Contains(doctor));
                        var staff = query.OrderBy(s => s.FullName).ToList();
                        contentHtml = BuildTableHtml(new[] { "Name", "Role", "Specialty", "Contact", "Status" },
                            staff.Select(s => new[] { s.FullName, s.Role, s.Specialty, s.ContactNumber, s.Status }).ToList());
                    }
                    else if (reportType == "Patient Master List")
                    {
                        // Filter by Registration Date and Attending Doctor
                        var query = db.Patients.Where(p => p.CreatedAt >= from && p.CreatedAt <= to);
                        if (!isAllDoctors) query = query.Where(p => p.AttendingDoctor == doctor);
                        
                        var patients = query.OrderBy(p => p.FullName).ToList();
                        contentHtml = BuildTableHtml(new[] { "ID", "Name", "Birthday", "Gender", "Doctor", "Status" },
                            patients.Select(p => new[] { p.PatientCode ?? p.PatientID.ToString(), p.FullName, p.DateOfBirth.ToShortDateString(), p.Gender, p.AttendingDoctor, p.Status }).ToList());
                    }
                    else if (reportType == "Appointment Summary")
                    {
                        var query = db.Appointments.Where(a => a.AppointmentDate >= from && a.AppointmentDate <= to);
                        var appointments = (from a in query
                                           join p in db.Patients on a.PatientID equals p.PatientID
                                           where isAllDoctors || p.AttendingDoctor == doctor
                                           select new { a.AppointmentDate, a.PatientID, p.FullName, a.Notes, a.Status })
                                           .OrderBy(x => x.AppointmentDate).ToList();

                        contentHtml = BuildTableHtml(new[] { "Date", "Patient Name", "Notes", "Status" },
                            appointments.Select(x => new[] { x.AppointmentDate?.ToString("MM/dd/yyyy HH:mm") ?? "N/A", x.FullName, x.Notes, x.Status }).ToList());
                    }
                    else if (reportType == "System Activity Audit")
                    {
                        // Placeholder for audit logs
                        contentHtml = "<div class='no-data'>System activity audit logs are currently being synchronized. Check back shortly.</div>";
                    }
                    else
                    {
                        contentHtml = $"<div style='padding:50px; text-align:center;'><h3>{reportType}</h3><p>Selected Filter: {from:MM/dd/yy} - {to:MM/dd/yy} | {doctor}</p></div>";
                    }
                }

                return $@"
                <html>
                <head>
                    <style>
                        body {{ font-family: 'Segoe UI', sans-serif; background-color: #f1f5f9; margin: 0; padding: 20px; }}
                        .report-container {{ background: white; border-radius: 8px; box-shadow: 0 4px 6px rgba(0,0,0,0.1); padding: 30px; }}
                        .header {{ border-bottom: 2px solid #0d9488; padding-bottom: 15px; margin-bottom: 20px; display: flex; justify-content: space-between; align-items: center; }}
                        .logo-text {{ font-size: 20px; font-weight: bold; color: #0d9488; }}
                        .report-title {{ font-size: 18px; font-weight: bold; color: #1e293b; margin: 0; }}
                        .meta {{ font-size: 12px; color: #64748b; margin-top: 3px; }}
                        table {{ width: 100%; border-collapse: collapse; margin-top: 15px; }}
                        th {{ background: #f8fafc; text-align: left; padding: 10px; border-bottom: 2px solid #e2e8f0; color: #475569; font-size: 12px; text-transform: uppercase; }}
                        td {{ padding: 10px; border-bottom: 1px solid #f1f5f9; color: #1e293b; font-size: 13px; }}
                        tr:nth-child(even) {{ background: #fafafa; }}
                    </style>
                </head>
                <body>
                    <div class='report-container'>
                        <div class='header'>
                            <div>
                                <div class='logo-text'>RecoverEase</div>
                                <div class='meta'>Filtered System Report</div>
                            </div>
                            <div style='text-align: right;'>
                                <h2 class='report-title'>{title}</h2>
                                <div class='meta'>Period: {from:MM/dd/yy} - {to:MM/dd/yy}</div>
                                <div class='meta'>Doctor: {doctor}</div>
                            </div>
                        </div>
                        {contentHtml}
                    </div>
                </body>
                </html>";
            }
            catch (Exception ex) { return "<html><body>Error: " + ex.Message + "</body></html>"; }
        }

        public async void GenerateLiveReport(string reportType, DateTime from, DateTime to, string doctor)
        {
            if (webView.CoreWebView2 == null) await webView.EnsureCoreWebView2Async(null);
            string html = GetReportHtml(reportType, from, to, doctor);
            webView.CoreWebView2.NavigateToString(html);
        }

        private string BuildTableHtml(string[] headers, List<string[]> rows)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table><thead><tr>");
            foreach (var h in headers) sb.Append($"<th>{h}</th>");
            sb.Append("</tr></thead><tbody>");
            if (rows.Count == 0) sb.Append($"<tr><td colspan='{headers.Length}' style='text-align:center; padding: 20px; color: #64748b;'>No records found for the selected filters.</td></tr>");
            else foreach (var row in rows) { sb.Append("<tr>"); foreach (var cell in row) sb.Append($"<td>{cell ?? "N/A"}</td>"); sb.Append("</tr>"); }
            sb.Append("</tbody></table>");
            return sb.ToString();
        }

        public void LoadAndShowReport(ReportDocument report, string reportName)
        {
            try
            {
                string tempFolder = Path.Combine(Path.GetTempPath(), "RecoverEase_Reports");
                if (!Directory.Exists(tempFolder)) Directory.CreateDirectory(tempFolder);
                string fileName = $"{reportName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string fullPath = Path.Combine(tempFolder, fileName);
                report.ExportToDisk(ExportFormatType.PortableDocFormat, fullPath);
                webView.CoreWebView2.Navigate(fullPath);
                this.Text = $"Crystal Report: {reportName}";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
