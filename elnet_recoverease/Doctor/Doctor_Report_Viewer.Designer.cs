namespace elnet_recoverease.Doctor
{
    partial class Doctor_Report_Viewer
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.wvReport = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // wvReport
            // 
            this.wvReport.AllowExternalDrop = true;
            this.wvReport.CreationProperties = null;
            this.wvReport.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvReport.Location = new System.Drawing.Point(0, 0);
            this.wvReport.Name = "wvReport";
            this.wvReport.Size = new System.Drawing.Size(1200, 800);
            this.wvReport.TabIndex = 0;
            this.wvReport.ZoomFactor = 1D;
            // 
            // Doctor_Report_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.wvReport);
            this.Name = "Doctor_Report_Viewer";
            this.Text = "Doctor Clinical Audit View";
            ((System.ComponentModel.ISupportInitialize)(this.wvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvReport;
    }
}
