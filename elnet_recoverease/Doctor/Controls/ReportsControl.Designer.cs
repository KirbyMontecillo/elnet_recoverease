namespace elnet_recoverease.Doctor.Controls
{
    partial class ReportsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblSelectReportTitle = new System.Windows.Forms.Label();
            this.pnlReportSelection = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.wvPreview = new Microsoft.Web.WebView2.WinForms.WebView2();

            this.pnlContent.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvPreview)).BeginInit();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30, 10, 30, 30);
            this.pnlContent.AutoScroll = true;

            // 1. Title Label
            this.lblSelectReportTitle.Text = "SELECT ANALYTICAL CATEGORY";
            this.lblSelectReportTitle.Font = new System.Drawing.Font("Segoe UI Bold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectReportTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSelectReportTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelectReportTitle.Height = 40;
            this.lblSelectReportTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            // 2. Report Selection Grid
            this.pnlReportSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportSelection.Height = 175;
            this.pnlReportSelection.ColumnCount = 4;
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlReportSelection.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);

            AddReportCard("Adherence", "Medication consistency.", "📈", System.Drawing.Color.FromArgb(236, 253, 245), System.Drawing.Color.FromArgb(5, 150, 105), 0);
            AddReportCard("Missed Meds", "Audit failed intakes.", "⚠️", System.Drawing.Color.FromArgb(254, 242, 242), System.Drawing.Color.FromArgb(220, 38, 38), 1);
            AddReportCard("Appointments", "Consultation history.", "📅", System.Drawing.Color.FromArgb(239, 246, 255), System.Drawing.Color.FromArgb(37, 99, 235), 2);
            AddReportCard("Progress", "Track recovery plans.", "📋", System.Drawing.Color.FromArgb(255, 251, 235), System.Drawing.Color.FromArgb(217, 119, 6), 3);

            // 3. Filter Panel
            this.pnlFilters.BackColor = clrWhite;
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Height = 100;
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);

            var lblFrom = new System.Windows.Forms.Label { Text = "From Date", Location = new System.Drawing.Point(25, 18), AutoSize = true, Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F), ForeColor = System.Drawing.Color.FromArgb(71, 85, 105) };
            this.dtpFrom.Width = 200; this.dtpFrom.Location = new System.Drawing.Point(25, 42);
            
            var lblTo = new System.Windows.Forms.Label { Text = "To Date", Location = new System.Drawing.Point(245, 18), AutoSize = true, Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F), ForeColor = System.Drawing.Color.FromArgb(71, 85, 105) };
            this.dtpTo.Width = 200; this.dtpTo.Location = new System.Drawing.Point(245, 42);

            var pnlFilterActions = new System.Windows.Forms.FlowLayoutPanel { 
                Dock = System.Windows.Forms.DockStyle.Right, 
                Width = 350, 
                FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft, 
                Padding = new System.Windows.Forms.Padding(0, 15, 0, 0) 
            };
            
            this.btnPreview.Text = "👁️ Preview";
            this.btnPreview.BackColor = clrWhite;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnPreview.Size = new System.Drawing.Size(120, 42);
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);

            this.btnGenerateReport.Text = "🖨️ Generate Report";
            this.btnGenerateReport.BackColor = clrTeal;
            this.btnGenerateReport.ForeColor = clrWhite;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.Size = new System.Drawing.Size(180, 42);
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI Bold", 9F);

            pnlFilterActions.Controls.Add(this.btnGenerateReport);
            pnlFilterActions.Controls.Add(this.btnPreview);

            this.pnlFilters.Controls.AddRange(new System.Windows.Forms.Control[] { lblFrom, this.dtpFrom, lblTo, this.dtpTo, pnlFilterActions });

            // 4. Preview Panel
            this.pnlPreview.BackColor = clrWhite;
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Padding = new System.Windows.Forms.Padding(1);
            this.wvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Controls.Add(this.wvPreview);

            // Assembly (Order matters for Docking)
            this.pnlContent.Controls.Add(this.pnlPreview);
            this.pnlContent.Controls.Add(new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Top, Height = 25 }); // Spacer
            this.pnlContent.Controls.Add(this.pnlFilters);
            this.pnlContent.Controls.Add(this.pnlReportSelection);
            this.pnlContent.Controls.Add(this.lblSelectReportTitle);
            
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wvPreview)).EndInit();
            this.ResumeLayout(false);
        }

        private void AddReportCard(string title, string desc, string icon, System.Drawing.Color bgColor, System.Drawing.Color iconColor, int col)
        {
            var card = new System.Windows.Forms.Panel {
                BackColor = System.Drawing.Color.White,
                Padding = new System.Windows.Forms.Padding(1),
                Cursor = System.Windows.Forms.Cursors.Hand,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Tag = title,
                Margin = new System.Windows.Forms.Padding(8)
            };
            var pnlInner = new System.Windows.Forms.Panel { Dock = System.Windows.Forms.DockStyle.Fill, BackColor = System.Drawing.Color.White, Padding = new System.Windows.Forms.Padding(10) };
            card.Controls.Add(pnlInner);

            var lblIcon = new System.Windows.Forms.Label { 
                Text = icon, 
                Font = new System.Drawing.Font("Segoe UI", 16F), 
                BackColor = bgColor, 
                ForeColor = iconColor, 
                Size = new System.Drawing.Size(50, 50), 
                Location = new System.Drawing.Point((pnlInner.Width - 50) / 2, 15), 
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Anchor = System.Windows.Forms.AnchorStyles.Top
            };
            var lblTitle = new System.Windows.Forms.Label { 
                Text = title, 
                Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold), 
                ForeColor = System.Drawing.Color.FromArgb(30, 41, 59),
                Location = new System.Drawing.Point(0, 75), 
                Size = new System.Drawing.Size(220, 25),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right
            };
            var lblDesc = new System.Windows.Forms.Label { 
                Text = desc, 
                Font = new System.Drawing.Font("Segoe UI", 8.2F), 
                ForeColor = System.Drawing.Color.FromArgb(100, 116, 139), 
                Location = new System.Drawing.Point(0, 100), 
                Size = new System.Drawing.Size(220, 35),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right
            };
            
            pnlInner.Controls.AddRange(new System.Windows.Forms.Control[] { lblIcon, lblTitle, lblDesc });
            
            pnlInner.Resize += (s, e) => {
                lblIcon.Left = (pnlInner.Width - lblIcon.Width) / 2;
            };

            card.Click += (s, e) => ReportCard_Click(card, e);
            foreach (System.Windows.Forms.Control child in pnlInner.Controls) child.Click += (s, e) => ReportCard_Click(card, e);
            pnlInner.Click += (s, e) => ReportCard_Click(card, e);

            this.pnlReportSelection.Controls.Add(card, col, 0);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSelectReportTitle;
        private System.Windows.Forms.TableLayoutPanel pnlReportSelection;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel pnlPreview;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvPreview;
    }
}
