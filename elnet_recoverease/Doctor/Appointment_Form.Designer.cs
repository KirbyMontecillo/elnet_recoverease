namespace elnet_recoverease.Doctor
{
    partial class Appointment_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblSection1 = new System.Windows.Forms.Label();
            this.pnlPatientCard = new System.Windows.Forms.Panel();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.lblSearchTag = new System.Windows.Forms.Label();
            this.cmbPatientSearch = new System.Windows.Forms.ComboBox();
            this.divider1 = new System.Windows.Forms.Panel();
            this.lblDoctorTag = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.lblApptTypeTag = new System.Windows.Forms.Label();
            this.cmbApptType = new System.Windows.Forms.ComboBox();
            this.divider2 = new System.Windows.Forms.Panel();
            this.lblSection2 = new System.Windows.Forms.Label();
            this.lblDateTag = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDurationTag = new System.Windows.Forms.Label();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.lblTimeTag = new System.Windows.Forms.Label();
            this.pnlTimeSlots = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblLegendSelected = new System.Windows.Forms.Label();
            this.lblLegendAvailable = new System.Windows.Forms.Label();
            this.lblLegendTaken = new System.Windows.Forms.Label();
            this.divider3 = new System.Windows.Forms.Panel();
            this.lblSection3 = new System.Windows.Forms.Label();
            this.lblNotesTag = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlReminder = new System.Windows.Forms.Panel();
            this.lblReminderIcon = new System.Windows.Forms.Label();
            this.lblReminderText = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Colors
            System.Drawing.Color clrNavy = System.Drawing.Color.FromArgb(20, 35, 65);
            System.Drawing.Color clrTeal = System.Drawing.Color.FromArgb(0, 168, 168);
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(245, 247, 250);
            System.Drawing.Color clrMuted = System.Drawing.Color.FromArgb(100, 120, 145);
            System.Drawing.Color clrReminderBg = System.Drawing.Color.FromArgb(235, 245, 255);
            System.Drawing.Color clrReminderBorder = System.Drawing.Color.FromArgb(180, 215, 255);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(680, 850);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Appointment";

            // Header (Gradient Style)
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.BackColor = clrNavy;
            
            // Header settings removed

            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 18);
            this.lblHeaderTitle.AutoSize = true;
            
            this.lblHeaderSub.Text = "RecoverEase - Post-treatment care";
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(180, 190, 210);
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblHeaderSub.Location = new System.Drawing.Point(24, 42);
            this.lblHeaderSub.AutoSize = true;
            
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);

            // Content Panel
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);

            // --- Section 1: Patient Information ---
            this.lblSection1.Text = "👤 PATIENT INFORMATION";
            this.lblSection1.Location = new System.Drawing.Point(24, 20);
            this.lblSection1.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblSection1.ForeColor = clrMuted;
            this.lblSection1.AutoSize = true;

            this.pnlPatientCard.Location = new System.Drawing.Point(24, 45);
            this.pnlPatientCard.Size = new System.Drawing.Size(610, 80);
            this.pnlPatientCard.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
            this.pnlPatientCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatientCard.Visible = false;

            this.pnlAvatar.Size = new System.Drawing.Size(50, 50);
            this.pnlAvatar.Location = new System.Drawing.Point(15, 15);
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(225, 240, 255);
            this.lblAvatarInitials.Text = "??";
            this.lblAvatarInitials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvatarInitials.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitials.ForeColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.pnlAvatar.Controls.Add(this.lblAvatarInitials);

            this.lblPatientName.Text = "No Patient Selected";
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            this.lblPatientName.Location = new System.Drawing.Point(75, 16);
            this.lblPatientName.AutoSize = true;

            this.lblPatientInfo.Text = "Search for a patient below to begin...";
            this.lblPatientInfo.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblPatientInfo.ForeColor = clrMuted;
            this.lblPatientInfo.Location = new System.Drawing.Point(75, 42);
            this.lblPatientInfo.AutoSize = true;

            this.lblStatusBadge.Text = "● Active care";
            this.lblStatusBadge.BackColor = System.Drawing.Color.FromArgb(235, 250, 240);
            this.lblStatusBadge.ForeColor = System.Drawing.Color.Green;
            this.lblStatusBadge.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblStatusBadge.Location = new System.Drawing.Point(500, 18);
            this.lblStatusBadge.Size = new System.Drawing.Size(90, 24);
            this.lblStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlPatientCard.Controls.Add(this.pnlAvatar);
            this.pnlPatientCard.Controls.Add(this.lblPatientName);
            this.pnlPatientCard.Controls.Add(this.lblPatientInfo);
            this.pnlPatientCard.Controls.Add(this.lblStatusBadge);

            this.lblSearchTag.Text = "Select Patient *";
            this.lblSearchTag.Location = new System.Drawing.Point(24, 140);
            this.lblSearchTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblSearchTag.AutoSize = true;
            this.cmbPatientSearch.Location = new System.Drawing.Point(24, 165);
            this.cmbPatientSearch.Size = new System.Drawing.Size(610, 32);
            this.cmbPatientSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientSearch.SelectedIndexChanged += new System.EventHandler(this.cmbPatientSearch_SelectedIndexChanged);

            this.lblDoctorTag.Text = "Attending doctor *";
            this.lblDoctorTag.Location = new System.Drawing.Point(24, 215);
            this.lblDoctorTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDoctorTag.AutoSize = true;
            this.cmbDoctor.Location = new System.Drawing.Point(24, 238);
            this.cmbDoctor.Size = new System.Drawing.Size(295, 32);
            this.cmbDoctor.Enabled = false;

            this.lblApptTypeTag.Text = "Appointment type *";
            this.lblApptTypeTag.Location = new System.Drawing.Point(339, 215);
            this.lblApptTypeTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblApptTypeTag.AutoSize = true;
            this.cmbApptType.Location = new System.Drawing.Point(339, 238);
            this.cmbApptType.Size = new System.Drawing.Size(295, 32);
            this.cmbApptType.Items.AddRange(new string[] { "Follow-up consultation", "Initial checkup", "Diagnostic test", "Treatment session" });
            this.cmbApptType.SelectedIndex = 0;

            this.divider1.Location = new System.Drawing.Point(24, 290);
            this.divider1.Size = new System.Drawing.Size(610, 1);
            this.divider1.BackColor = System.Drawing.Color.FromArgb(230, 235, 245);

            // --- Section 2: Date & Time ---
            this.lblSection2.Text = "📅 DATE & TIME";
            this.lblSection2.Location = new System.Drawing.Point(24, 310);
            this.lblSection2.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblSection2.ForeColor = clrMuted;
            this.lblSection2.AutoSize = true;

            this.lblDateTag.Text = "Appointment date *";
            this.lblDateTag.Location = new System.Drawing.Point(24, 335);
            this.lblDateTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDateTag.AutoSize = true;
            this.dtpDate.Location = new System.Drawing.Point(24, 358);
            this.dtpDate.Size = new System.Drawing.Size(295, 32);

            this.lblDurationTag.Text = "Duration";
            this.lblDurationTag.Location = new System.Drawing.Point(339, 335);
            this.lblDurationTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblDurationTag.AutoSize = true;
            this.cmbDuration.Location = new System.Drawing.Point(339, 358);
            this.cmbDuration.Size = new System.Drawing.Size(295, 32);
            this.cmbDuration.Items.AddRange(new string[] { "30 minutes", "1 hour", "1.5 hours" });
            this.cmbDuration.SelectedIndex = 0;

            this.lblTimeTag.Text = "Available time slots";
            this.lblTimeTag.Location = new System.Drawing.Point(24, 410);
            this.lblTimeTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblTimeTag.AutoSize = true;

            this.pnlTimeSlots.Location = new System.Drawing.Point(24, 435);
            this.pnlTimeSlots.Size = new System.Drawing.Size(610, 280);
            this.pnlTimeSlots.AutoSize = false;
            
            // Legend
            this.pnlLegend.Location = new System.Drawing.Point(24, 585);
            this.pnlLegend.Size = new System.Drawing.Size(610, 30);
            this.lblLegendSelected.Text = "● Selected"; this.lblLegendSelected.ForeColor = clrTeal; this.lblLegendSelected.Location = new System.Drawing.Point(0, 0); this.lblLegendSelected.AutoSize = true;
            this.lblLegendAvailable.Text = "○ Available"; this.lblLegendAvailable.ForeColor = clrMuted; this.lblLegendAvailable.Location = new System.Drawing.Point(80, 0); this.lblLegendAvailable.AutoSize = true;
            this.lblLegendTaken.Text = "● Taken"; this.lblLegendTaken.ForeColor = System.Drawing.Color.LightGray; this.lblLegendTaken.Location = new System.Drawing.Point(160, 0); this.lblLegendTaken.AutoSize = true;
            this.pnlLegend.Controls.AddRange(new Control[] { this.lblLegendSelected, this.lblLegendAvailable, this.lblLegendTaken });

            this.divider2.Location = new System.Drawing.Point(24, 725);
            this.divider2.Size = new System.Drawing.Size(610, 1);
            this.divider2.BackColor = System.Drawing.Color.FromArgb(230, 235, 245);

            // --- Section 3: Clinical Notes ---
            this.lblSection3.Text = "📝 CLINICAL DETAILS";
            this.lblSection3.Location = new System.Drawing.Point(24, 745);
            this.lblSection3.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold);
            this.lblSection3.ForeColor = clrMuted;
            this.lblSection3.AutoSize = true;

            this.lblNotesTag.Text = "Doctor's notes / instructions for patient";
            this.lblNotesTag.Location = new System.Drawing.Point(24, 770);
            this.lblNotesTag.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.lblNotesTag.AutoSize = true;
            this.txtNotes.Location = new System.Drawing.Point(24, 795);
            this.txtNotes.Size = new System.Drawing.Size(610, 100);
            this.txtNotes.Multiline = true;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Reminder Box
            this.pnlReminder.Location = new System.Drawing.Point(24, 905);
            this.pnlReminder.Size = new System.Drawing.Size(610, 50);
            this.pnlReminder.BackColor = clrReminderBg;
            this.pnlReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReminderIcon.Text = "🔔"; this.lblReminderIcon.Location = new System.Drawing.Point(15, 15); this.lblReminderIcon.AutoSize = true;
            this.lblReminderText.Text = "An in-app reminder will be sent to the patient 1 day before the appointment.";
            this.lblReminderText.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblReminderText.ForeColor = System.Drawing.Color.FromArgb(0, 80, 160);
            this.lblReminderText.Location = new System.Drawing.Point(45, 15);
            this.lblReminderText.AutoSize = true;
            this.pnlReminder.Controls.Add(this.lblReminderIcon);
            this.pnlReminder.Controls.Add(this.lblReminderText);

            // Footer
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 85;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);

            this.btnConfirm.Text = "Confirm appointment";
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirm.Size = new System.Drawing.Size(220, 45);
            this.btnConfirm.BackColor = clrTeal;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 210, 225);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.pnlFooter.Controls.Add(this.btnConfirm);
            this.pnlFooter.Controls.Add(this.btnCancel);

            // Assemble Content
            this.pnlContent.Controls.AddRange(new Control[] { 
                this.lblSection1, this.pnlPatientCard, this.lblSearchTag, this.cmbPatientSearch, this.lblDoctorTag, this.cmbDoctor, this.lblApptTypeTag, this.cmbApptType, this.divider1,
                this.lblSection2, this.lblDateTag, this.dtpDate, this.lblDurationTag, this.cmbDuration, this.lblTimeTag, this.pnlTimeSlots, this.pnlLegend, this.divider2,
                this.lblSection3, this.lblNotesTag, this.txtNotes, this.pnlReminder
            });

            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.Panel pnlPatientCard;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblAvatarInitials;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.Label lblStatusBadge;
        private System.Windows.Forms.Label lblSearchTag;
        private System.Windows.Forms.ComboBox cmbPatientSearch;
        private System.Windows.Forms.Panel divider1;
        private System.Windows.Forms.Label lblDoctorTag;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label lblApptTypeTag;
        private System.Windows.Forms.ComboBox cmbApptType;
        private System.Windows.Forms.Panel divider2;
        private System.Windows.Forms.Label lblSection2;
        private System.Windows.Forms.Label lblDateTag;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDurationTag;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.Label lblTimeTag;
        private System.Windows.Forms.FlowLayoutPanel pnlTimeSlots;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblLegendSelected;
        private System.Windows.Forms.Label lblLegendAvailable;
        private System.Windows.Forms.Label lblLegendTaken;
        private System.Windows.Forms.Panel divider3;
        private System.Windows.Forms.Label lblSection3;
        private System.Windows.Forms.Label lblNotesTag;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlReminder;
        private System.Windows.Forms.Label lblReminderIcon;
        private System.Windows.Forms.Label lblReminderText;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}