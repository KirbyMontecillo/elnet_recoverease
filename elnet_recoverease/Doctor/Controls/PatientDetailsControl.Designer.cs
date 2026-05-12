namespace elnet_recoverease.Doctor.Controls
{
    partial class PatientDetailsControl
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
            this.pnlActionHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdatePlan = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.pnlPatientHeader = new System.Windows.Forms.Panel();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.pnlMainStack = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeftCol = new System.Windows.Forms.Panel();
            this.pnlRightCol = new System.Windows.Forms.Panel();
            this.pnlMedInfo = new System.Windows.Forms.Panel();
            this.pnlDiagGoals = new System.Windows.Forms.Panel();
            this.pnlApptHistory = new System.Windows.Forms.Panel();
            this.pnlLatestVitals = new System.Windows.Forms.Panel();
            this.pnlCurrentMeds = new System.Windows.Forms.Panel();

            this.pnlContent.SuspendLayout();
            this.pnlActionHeader.SuspendLayout();
            this.pnlPatientHeader.SuspendLayout();
            this.pnlMainStack.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = clrBg;
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30, 20, 30, 30);

            // Action Header
            this.pnlActionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionHeader.Height = 60;
            this.btnBack.Text = "← Back to List";
            this.btnBack.Location = new System.Drawing.Point(0, 10);
            this.btnBack.Size = new System.Drawing.Size(140, 35);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBack.ForeColor = clrTeal;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.btnUpdatePlan.Text = "+ Update Treatment Plan";
            this.btnUpdatePlan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdatePlan.Location = new System.Drawing.Point(820, 10);
            this.btnUpdatePlan.Size = new System.Drawing.Size(200, 35);
            this.btnUpdatePlan.BackColor = clrTeal;
            this.btnUpdatePlan.ForeColor = clrWhite;
            this.btnUpdatePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePlan.Click += new System.EventHandler(this.btnUpdatePlan_Click);

            this.pnlActionHeader.Controls.Add(this.btnBack);
            this.pnlActionHeader.Controls.Add(this.btnUpdatePlan);

            // Patient Header Card
            this.pnlPatientHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatientHeader.Height = 120;
            this.pnlPatientHeader.BackColor = clrWhite;
            this.pnlPatientHeader.Padding = new System.Windows.Forms.Padding(25);
            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI Bold", 20F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(25, 25);
            this.lblPatientName.AutoSize = true;
            this.lblPatientId.Text = "ID: 0000";
            this.lblPatientId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPatientId.Location = new System.Drawing.Point(25, 65);
            this.lblPatientId.AutoSize = true;
            this.lblStatusBadge.Text = "ACTIVE";
            this.lblStatusBadge.BackColor = clrTeal;
            this.lblStatusBadge.ForeColor = clrWhite;
            this.lblStatusBadge.Location = new System.Drawing.Point(250, 35);
            this.lblStatusBadge.Size = new System.Drawing.Size(80, 25);
            this.lblStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlPatientHeader.Controls.Add(this.lblPatientName);
            this.pnlPatientHeader.Controls.Add(this.lblPatientId);
            this.pnlPatientHeader.Controls.Add(this.lblStatusBadge);

            // Main Stack (Split Layout)
            this.pnlMainStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainStack.Height = 1000; // Large to accommodate scroll
            this.pnlMainStack.ColumnCount = 2;
            this.pnlMainStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlMainStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pnlMainStack.RowCount = 1;
            this.pnlMainStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.pnlLeftCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCol.Padding = new System.Windows.Forms.Padding(0, 25, 12, 0);
            this.pnlRightCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCol.Padding = new System.Windows.Forms.Padding(12, 25, 0, 0);

            // Cards within Columns
            this.pnlMedInfo.Dock = System.Windows.Forms.DockStyle.Top; this.pnlMedInfo.Height = 250; this.pnlMedInfo.BackColor = clrWhite; this.pnlMedInfo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.pnlDiagGoals.Dock = System.Windows.Forms.DockStyle.Top; this.pnlDiagGoals.Height = 350; this.pnlDiagGoals.BackColor = clrWhite; this.pnlDiagGoals.Margin = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.pnlApptHistory.Dock = System.Windows.Forms.DockStyle.Top; this.pnlApptHistory.Height = 300; this.pnlApptHistory.BackColor = clrWhite;

            this.pnlLatestVitals.Dock = System.Windows.Forms.DockStyle.Top; this.pnlLatestVitals.Height = 450; this.pnlLatestVitals.BackColor = clrWhite; this.pnlLatestVitals.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.pnlCurrentMeds.Dock = System.Windows.Forms.DockStyle.Top; this.pnlCurrentMeds.Height = 400; this.pnlCurrentMeds.BackColor = clrWhite;

            this.pnlLeftCol.Controls.Add(this.pnlApptHistory);
            this.pnlLeftCol.Controls.Add(new System.Windows.Forms.Panel { Height = 25 });
            this.pnlLeftCol.Controls.Add(this.pnlDiagGoals);
            this.pnlLeftCol.Controls.Add(new System.Windows.Forms.Panel { Height = 25 });
            this.pnlLeftCol.Controls.Add(this.pnlMedInfo);

            this.pnlRightCol.Controls.Add(this.pnlCurrentMeds);
            this.pnlRightCol.Controls.Add(new System.Windows.Forms.Panel { Height = 25 });
            this.pnlRightCol.Controls.Add(this.pnlLatestVitals);

            this.pnlMainStack.Controls.Add(this.pnlLeftCol, 0, 0);
            this.pnlMainStack.Controls.Add(this.pnlRightCol, 1, 0);

            this.pnlContent.Controls.Add(this.pnlMainStack);
            this.pnlContent.Controls.Add(new System.Windows.Forms.Panel { Height = 25, Dock = System.Windows.Forms.DockStyle.Top });
            this.pnlContent.Controls.Add(this.pnlPatientHeader);
            this.pnlContent.Controls.Add(this.pnlActionHeader);

            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.pnlActionHeader.ResumeLayout(false);
            this.pnlPatientHeader.ResumeLayout(false);
            this.pnlPatientHeader.PerformLayout();
            this.pnlMainStack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.PatientDetailsControl_Load);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlActionHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdatePlan;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Panel pnlPatientHeader;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label lblStatusBadge;
        private System.Windows.Forms.TableLayoutPanel pnlMainStack;
        private System.Windows.Forms.Panel pnlLeftCol;
        private System.Windows.Forms.Panel pnlRightCol;
        private System.Windows.Forms.Panel pnlMedInfo;
        private System.Windows.Forms.Panel pnlDiagGoals;
        private System.Windows.Forms.Panel pnlApptHistory;
        private System.Windows.Forms.Panel pnlLatestVitals;
        private System.Windows.Forms.Panel pnlCurrentMeds;
    }
}
