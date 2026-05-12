namespace elnet_recoverease.PatientStation.Controls
{
    partial class PatientProfileControl
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
            this.tlpProfileCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardPersonalInfo = new System.Windows.Forms.Panel();
            this.lblPInfoTitle = new System.Windows.Forms.Label();
            this.btnEditPersonal = new System.Windows.Forms.Button();
            this.lblPhoneLbl = new System.Windows.Forms.Label();
            this.lblPhoneVal = new System.Windows.Forms.Label();
            this.lblEmailLbl = new System.Windows.Forms.Label();
            this.lblEmailVal = new System.Windows.Forms.Label();
            this.lblAddressLbl = new System.Windows.Forms.Label();
            this.lblAddressVal = new System.Windows.Forms.Label();
            this.lblEmergencyLbl = new System.Windows.Forms.Label();
            this.lblEmergencyNameLbl = new System.Windows.Forms.Label();
            this.lblEmergencyNameVal = new System.Windows.Forms.Label();
            this.lblEmergencyRelLbl = new System.Windows.Forms.Label();
            this.lblEmergencyRelVal = new System.Windows.Forms.Label();
            this.lblEmergencyPhoneLbl = new System.Windows.Forms.Label();
            this.lblEmergencyPhoneVal = new System.Windows.Forms.Label();
            this.cardMedicalOverview = new System.Windows.Forms.Panel();
            this.lblMedOverviewTitle = new System.Windows.Forms.Label();
            this.lblBloodLbl = new System.Windows.Forms.Label();
            this.lblBloodVal = new System.Windows.Forms.Label();
            this.lblHeightLbl = new System.Windows.Forms.Label();
            this.lblHeightVal = new System.Windows.Forms.Label();
            this.lblWeightLbl = new System.Windows.Forms.Label();
            this.lblWeightVal = new System.Windows.Forms.Label();
            this.lblAttendingDoctorLbl = new System.Windows.Forms.Label();
            this.lblAttendingDoctorVal = new System.Windows.Forms.Label();
            this.lblDocSpecialtyVal = new System.Windows.Forms.Label();
            this.lblDocContactVal = new System.Windows.Forms.Label();
            this.pnlHeaderCard = new System.Windows.Forms.Panel();
            this.pnlAvatarLarge = new System.Windows.Forms.Panel();
            this.lblAvatarLargeInitials = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.lblPatientAge = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEditPersonal = new System.Windows.Forms.Button();

            this.pnlContent.SuspendLayout();
            this.tlpProfileCards.SuspendLayout();
            this.cardPersonalInfo.SuspendLayout();
            this.cardMedicalOverview.SuspendLayout();
            this.pnlHeaderCard.SuspendLayout();
            this.pnlAvatarLarge.SuspendLayout();
            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(242, 247, 250);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(27, 58, 107);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrTextMid = System.Drawing.Color.FromArgb(100, 116, 139);

            // UserControl
            this.BackColor = clrBg;
            this.Size = new System.Drawing.Size(1200, 800);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.AutoScroll = true;

            // Header Card
            this.pnlHeaderCard.BackColor = clrWhite;
            this.pnlHeaderCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderCard.Height = 160;
            this.pnlHeaderCard.Padding = new System.Windows.Forms.Padding(32);
            
            this.pnlAvatarLarge.BackColor = clrTeal;
            this.pnlAvatarLarge.Location = new System.Drawing.Point(32, 32);
            this.pnlAvatarLarge.Size = new System.Drawing.Size(96, 96);
            
            this.lblAvatarLargeInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarLargeInitials.Font = new System.Drawing.Font("Segoe UI Semilight", 36F);
            this.lblAvatarLargeInitials.ForeColor = clrWhite;
            this.lblAvatarLargeInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlAvatarLarge.Controls.Add(this.lblAvatarLargeInitials);

            this.lblPatientName.Text = "Patient Name"; 
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI Bold", 20F, System.Drawing.FontStyle.Bold); 
            this.lblPatientName.ForeColor = clrNavy;
            this.lblPatientName.Location = new System.Drawing.Point(145, 38); 
            this.lblPatientName.AutoSize = true;

            this.lblPatientId.Text = "P-0000"; 
            this.lblPatientId.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold); 
            this.lblPatientId.ForeColor = clrTextMid; 
            this.lblPatientId.Location = new System.Drawing.Point(148, 75); 
            this.lblPatientId.AutoSize = true;

            this.lblPatientAge.Text = "Age / Gender"; 
            this.lblPatientAge.Font = new System.Drawing.Font("Segoe UI", 10F); 
            this.lblPatientAge.Location = new System.Drawing.Point(148, 100); 
            this.lblPatientAge.AutoSize = true;
            
            // lblStatus
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.BackColor = clrTeal;
            this.lblStatus.Location = new System.Drawing.Point(148, 125);
            this.lblStatus.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.lblStatus.Size = new System.Drawing.Size(80, 22);
            this.lblStatus.Text = "ACTIVE";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.AutoSize = true;
            this.pnlHeaderCard.Controls.Add(this.lblStatus);

            this.pnlHeaderCard.Controls.Add(this.pnlAvatarLarge); 
            this.pnlHeaderCard.Controls.Add(this.lblPatientName); 
            this.pnlHeaderCard.Controls.Add(this.lblPatientId); 
            this.pnlHeaderCard.Controls.Add(this.lblPatientAge);
            this.pnlHeaderCard.Controls.Add(this.lblStatus);
            this.pnlHeaderCard.Controls.Add(this.btnEditPersonal);
            this.pnlHeaderCard.Controls.Add(this.btnLogout);

            // btnEditPersonal
            this.btnEditPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnEditPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnEditPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPersonal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnEditPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnEditPersonal.Location = new System.Drawing.Point(1030, 20);
            this.btnEditPersonal.Name = "btnEditPersonal";
            this.btnEditPersonal.Size = new System.Drawing.Size(140, 45);
            this.btnEditPersonal.TabIndex = 4;
            this.btnEditPersonal.Text = "✏️ Edit Profile";
            this.btnEditPersonal.UseVisualStyleBackColor = false;
            this.btnEditPersonal.Click += new System.EventHandler(this.btnEditPersonal_Click);

            // btnLogout
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogout.Location = new System.Drawing.Point(1030, 75);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "⇠ Sign Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Profile Cards Layout
            this.tlpProfileCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpProfileCards.Height = 500;
            this.tlpProfileCards.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.tlpProfileCards.ColumnCount = 2;
            this.tlpProfileCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProfileCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

            // Personal Info Card
            this.cardPersonalInfo.BackColor = clrWhite;
            this.cardPersonalInfo.Padding = new System.Windows.Forms.Padding(24);
            this.cardPersonalInfo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.cardPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;

            var acc1 = new System.Windows.Forms.Panel { BackColor = clrNavy, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblPInfoTitle.Text = "Personal Information"; 
            this.lblPInfoTitle.Font = new System.Drawing.Font("Segoe UI Bold", 13F, System.Drawing.FontStyle.Bold); 
            this.lblPInfoTitle.ForeColor = clrNavy; 
            this.lblPInfoTitle.Location = new System.Drawing.Point(24, 28); 
            this.lblPInfoTitle.AutoSize = true;

            
            SetupProfileLabel(this.lblPhoneLbl, this.lblPhoneVal, "Phone Number", 80);
            SetupProfileLabel(this.lblEmailLbl, this.lblEmailVal, "Email Address", 80, 280);
            SetupProfileLabel(this.lblAddressLbl, this.lblAddressVal, "Home Address", 150);
            
            this.lblEmergencyLbl.Text = "EMERGENCY CONTACT"; 
            this.lblEmergencyLbl.Font = new System.Drawing.Font("Segoe UI Bold", 9F, System.Drawing.FontStyle.Bold); 
            this.lblEmergencyLbl.ForeColor = clrTeal; 
            this.lblEmergencyLbl.Location = new System.Drawing.Point(24, 230); 
            this.lblEmergencyLbl.AutoSize = true;
            
            SetupProfileLabel(this.lblEmergencyNameLbl, this.lblEmergencyNameVal, "Primary Contact", 260);
            SetupProfileLabel(this.lblEmergencyRelLbl, this.lblEmergencyRelVal, "Relationship", 260, 220);
            SetupProfileLabel(this.lblEmergencyPhoneLbl, this.lblEmergencyPhoneVal, "Emergency Phone", 260, 380);
            
            this.cardPersonalInfo.Controls.AddRange(new System.Windows.Forms.Control[] { acc1, this.lblPInfoTitle, this.lblPhoneLbl, this.lblPhoneVal, this.lblEmailLbl, this.lblEmailVal, this.lblAddressLbl, this.lblAddressVal, this.lblEmergencyLbl, this.lblEmergencyNameLbl, this.lblEmergencyNameVal, this.lblEmergencyRelLbl, this.lblEmergencyRelVal, this.lblEmergencyPhoneLbl, this.lblEmergencyPhoneVal });

            // Medical Overview Card
            this.cardMedicalOverview.BackColor = clrWhite;
            this.cardMedicalOverview.Padding = new System.Windows.Forms.Padding(24);
            this.cardMedicalOverview.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cardMedicalOverview.Dock = System.Windows.Forms.DockStyle.Fill;

            var acc2 = new System.Windows.Forms.Panel { BackColor = clrTeal, Dock = System.Windows.Forms.DockStyle.Top, Height = 4 };
            this.lblMedOverviewTitle.Text = "Medical Records Summary"; 
            this.lblMedOverviewTitle.Font = new System.Drawing.Font("Segoe UI Bold", 13F, System.Drawing.FontStyle.Bold); 
            this.lblMedOverviewTitle.ForeColor = clrNavy; 
            this.lblMedOverviewTitle.Location = new System.Drawing.Point(24, 28); 
            this.lblMedOverviewTitle.AutoSize = true;
            
            SetupProfileLabel(this.lblBloodLbl, this.lblBloodVal, "Blood Group", 80);
            SetupProfileLabel(this.lblHeightLbl, this.lblHeightVal, "Height (cm)", 80, 160);
            SetupProfileLabel(this.lblWeightLbl, this.lblWeightVal, "Weight (kg)", 80, 280);
            
            this.lblAttendingDoctorLbl.Text = "ASSIGNED CLINICIAN"; 
            this.lblAttendingDoctorLbl.Font = new System.Drawing.Font("Segoe UI Bold", 9F, System.Drawing.FontStyle.Bold); 
            this.lblAttendingDoctorLbl.ForeColor = clrTeal; 
            this.lblAttendingDoctorLbl.Location = new System.Drawing.Point(24, 230); 
            this.lblAttendingDoctorLbl.AutoSize = true;
            
            SetupProfileLabel(null, this.lblAttendingDoctorVal, "", 260);
            SetupProfileLabel(null, this.lblDocSpecialtyVal, "", 285);
            SetupProfileLabel(null, this.lblDocContactVal, "", 310);
            
            this.cardMedicalOverview.Controls.AddRange(new System.Windows.Forms.Control[] { acc2, this.lblMedOverviewTitle, this.lblBloodLbl, this.lblBloodVal, this.lblHeightLbl, this.lblHeightVal, this.lblWeightLbl, this.lblWeightVal, this.lblAttendingDoctorLbl, this.lblAttendingDoctorVal, this.lblDocSpecialtyVal, this.lblDocContactVal });

            tlpProfileCards.Controls.Add(this.cardPersonalInfo, 0, 0);
            tlpProfileCards.Controls.Add(this.cardMedicalOverview, 1, 0);

            this.pnlContent.Controls.Add(tlpProfileCards);
            this.pnlContent.Controls.Add(this.pnlHeaderCard);
            this.Controls.Add(this.pnlContent);

            this.pnlContent.ResumeLayout(false);
            this.tlpProfileCards.ResumeLayout(false);
            this.cardPersonalInfo.ResumeLayout(false);
            this.cardMedicalOverview.ResumeLayout(false);
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlAvatarLarge.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.PatientProfileControl_Load);
        }

        private void SetupProfileLabel(System.Windows.Forms.Label lbl, System.Windows.Forms.Label val, string lblText, int y, int x = 24)
        {
            if (lbl != null)
            {
                lbl.Text = lblText.ToUpper(); 
                lbl.Font = new System.Drawing.Font("Segoe UI Bold", 8.5F, System.Drawing.FontStyle.Bold); 
                lbl.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184); 
                lbl.Location = new System.Drawing.Point(x, y); 
                lbl.AutoSize = true;
            }
            val.Text = "--"; 
            val.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold); 
            val.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59); 
            val.Location = new System.Drawing.Point(x, lbl == null ? y : y + 22); 
            val.AutoSize = true;
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tlpProfileCards;
        private System.Windows.Forms.Panel cardPersonalInfo;
        private System.Windows.Forms.Label lblPInfoTitle;
        private System.Windows.Forms.Button btnEditPersonal;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPhoneLbl;
        private System.Windows.Forms.Label lblPhoneVal;
        private System.Windows.Forms.Label lblEmailLbl;
        private System.Windows.Forms.Label lblEmailVal;
        private System.Windows.Forms.Label lblAddressLbl;
        private System.Windows.Forms.Label lblAddressVal;
        private System.Windows.Forms.Label lblEmergencyLbl;
        private System.Windows.Forms.Label lblEmergencyNameLbl;
        private System.Windows.Forms.Label lblEmergencyNameVal;
        private System.Windows.Forms.Label lblEmergencyRelLbl;
        private System.Windows.Forms.Label lblEmergencyRelVal;
        private System.Windows.Forms.Label lblEmergencyPhoneLbl;
        private System.Windows.Forms.Label lblEmergencyPhoneVal;
        private System.Windows.Forms.Panel cardMedicalOverview;
        private System.Windows.Forms.Label lblMedOverviewTitle;
        private System.Windows.Forms.Label lblBloodLbl;
        private System.Windows.Forms.Label lblBloodVal;
        private System.Windows.Forms.Label lblHeightLbl;
        private System.Windows.Forms.Label lblHeightVal;
        private System.Windows.Forms.Label lblWeightLbl;
        private System.Windows.Forms.Label lblWeightVal;
        private System.Windows.Forms.Label lblAttendingDoctorLbl;
        private System.Windows.Forms.Label lblAttendingDoctorVal;
        private System.Windows.Forms.Label lblDocSpecialtyVal;
        private System.Windows.Forms.Label lblDocContactVal;
        private System.Windows.Forms.Panel pnlHeaderCard;
        private System.Windows.Forms.Panel pnlAvatarLarge;
        private System.Windows.Forms.Label lblAvatarLargeInitials;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label lblPatientAge;
        private System.Windows.Forms.Label lblStatus;
    }
}
