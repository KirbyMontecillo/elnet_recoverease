namespace elnet_recoverease.Doctor.Forms
{
    partial class Doctor_Report_Viewer
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnPdf;
        private System.Windows.Forms.ToolStripButton btnExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnPdf = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();

            // toolStrip
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            new System.Windows.Forms.ToolStripSeparator(),
            this.btnPdf,
            new System.Windows.Forms.ToolStripSeparator(),
            this.btnExcel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1100, 31);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";

            // btnPrint
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 28);
            this.btnPrint.Text = "🖨️ Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // btnPdf
            this.btnPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(110, 28);
            this.btnPdf.Text = "💾 Save PDF";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);

            // btnExcel
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 28);
            this.btnExcel.Text = "📊 Export CSV";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);

            // webView
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 31);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1100, 769);
            this.webView.TabIndex = 1;
            this.webView.ZoomFactor = 1D;

            // Doctor_Report_Viewer
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.toolStrip);
            this.Name = "Doctor_Report_Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinical Report Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
