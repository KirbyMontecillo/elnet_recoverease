namespace elnet_recoverease.Admin.Controls
{
    partial class AdminReportControl
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
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.wvPreview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblDoc = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.pnlReportSelection = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectReportTitle = new System.Windows.Forms.Label();
            
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvPreview)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            
            // pnlPreview
            this.pnlPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlPreview.BackColor = System.Drawing.Color.White;
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreview.Controls.Add(this.wvPreview);
            this.pnlPreview.Location = new System.Drawing.Point(30, 480);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(1280, 310);
            
            // wvPreview
            this.wvPreview.AllowExternalDrop = true;
            this.wvPreview.CreationProperties = null;
            this.wvPreview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvPreview.Location = new System.Drawing.Point(0, 0);
            this.wvPreview.Name = "wvPreview";
            this.wvPreview.Size = new System.Drawing.Size(1278, 308);
            this.wvPreview.ZoomFactor = 1D;
            
            // pnlFilters
            this.pnlFilters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.lblFrom);
            this.pnlFilters.Controls.Add(this.dtpFrom);
            this.pnlFilters.Controls.Add(this.lblTo);
            this.pnlFilters.Controls.Add(this.dtpTo);
            this.pnlFilters.Controls.Add(this.lblDoc);
            this.pnlFilters.Controls.Add(this.cmbDoctor);
            this.pnlFilters.Controls.Add(this.btnPreview);
            this.pnlFilters.Controls.Add(this.btnGenerateReport);
            this.pnlFilters.Location = new System.Drawing.Point(30, 360);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1280, 100);
            
            // lblFrom
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(24, 19);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(76, 20);
            this.lblFrom.Text = "From Date";
            
            // dtpFrom
            this.dtpFrom.Location = new System.Drawing.Point(24, 42);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(264, 27);
            
            // lblTo
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(306, 18);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(58, 20);
            this.lblTo.Text = "To Date";
            
            // dtpTo
            this.dtpTo.Location = new System.Drawing.Point(306, 41);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(264, 27);
            
            // lblDoc
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(599, 18);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(55, 20);
            this.lblDoc.Text = "Doctor";
            
            // cmbDoctor
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.Location = new System.Drawing.Point(599, 41);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(260, 28);
            
            // btnPreview
            this.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnPreview.BackColor = System.Drawing.Color.White;
            this.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Location = new System.Drawing.Point(1000, 41);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(120, 35);
            this.btnPreview.Text = "👁️ Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            
            // btnGenerateReport
            this.btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerateReport.BackColor = System.Drawing.Color.White;
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Location = new System.Drawing.Point(1130, 41);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 35);
            this.btnGenerateReport.Text = "🖨️ Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            
            // pnlReportSelection
            this.pnlReportSelection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlReportSelection.BackColor = System.Drawing.Color.Transparent;
            this.pnlReportSelection.ColumnCount = 3;
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlReportSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.pnlReportSelection.Location = new System.Drawing.Point(30, 50);
            this.pnlReportSelection.Name = "pnlReportSelection";
            this.pnlReportSelection.RowCount = 2;
            this.pnlReportSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlReportSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlReportSelection.Size = new System.Drawing.Size(1280, 290);
            
            // lblSelectReportTitle
            this.lblSelectReportTitle.AutoSize = true;
            this.lblSelectReportTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectReportTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSelectReportTitle.Location = new System.Drawing.Point(30, 20);
            this.lblSelectReportTitle.Name = "lblSelectReportTitle";
            this.lblSelectReportTitle.Size = new System.Drawing.Size(262, 23);
            this.lblSelectReportTitle.Text = "SELECT A REPORT TO GENERATE";

            // AdminReportControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 247, 250);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlReportSelection);
            this.Controls.Add(this.lblSelectReportTitle);
            this.Name = "AdminReportControl";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1340, 810);
            
            this.pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wvPreview)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlReportSelection;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblSelectReportTitle;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnGenerateReport;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvPreview;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDoc;
    }
}
