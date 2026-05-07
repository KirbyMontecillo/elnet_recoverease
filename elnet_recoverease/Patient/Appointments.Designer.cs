using System.Drawing;
using System.Windows.Forms;

namespace elnet_recoverease
{
    partial class Appointments
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
            this.components = new System.ComponentModel.Container();
            
            // Panels
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogoArea = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlNavDivider = new System.Windows.Forms.Panel();
            this.btnNavDashboard = new System.Windows.Forms.Panel();
            this.lblNavDashIcon = new System.Windows.Forms.Label();
            this.lblNavDashText = new System.Windows.Forms.Label();
            this.btnNavProfile = new System.Windows.Forms.Panel();
            this.lblNavProfileIcon = new System.Windows.Forms.Label();
            this.lblNavProfileText = new System.Windows.Forms.Label();
            this.btnNavMeds = new System.Windows.Forms.Panel();
            this.lblNavMedsIcon = new System.Windows.Forms.Label();
            this.lblNavMedsText = new System.Windows.Forms.Label();
            this.btnNavAppointments = new System.Windows.Forms.Panel();
            this.lblNavApptIcon = new System.Windows.Forms.Label();
            this.lblNavApptText = new System.Windows.Forms.Label();
            this.btnNavTreatment = new System.Windows.Forms.Panel();
            this.lblNavTreatmentIcon = new System.Windows.Forms.Label();
            this.lblNavTreatmentText = new System.Windows.Forms.Label();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.lblSidebarFooter = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlNotifBell = new System.Windows.Forms.Panel();
            this.lblBellIcon = new System.Windows.Forms.Label();
            this.lblNotifBadge = new System.Windows.Forms.Label();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.lblAvatarInitials = new System.Windows.Forms.Label();
            
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tlpApptCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardNextAppt = new System.Windows.Forms.Panel();
            this.lblCardNextTitle = new System.Windows.Forms.Label();
            this.lblCardNextValue = new System.Windows.Forms.Label();
            this.lblCardNextIcon = new System.Windows.Forms.Label();
            
            this.cardUpcoming = new System.Windows.Forms.Panel();
            this.lblCardUpcomingTitle = new System.Windows.Forms.Label();
            this.lblCardUpcomingValue = new System.Windows.Forms.Label();
            this.lblCardUpcomingIcon = new System.Windows.Forms.Label();
            
            this.cardCompleted = new System.Windows.Forms.Panel();
            this.lblCardCompletedTitle = new System.Windows.Forms.Label();
            this.lblCardCompletedValue = new System.Windows.Forms.Label();
            this.lblCardCompletedIcon = new System.Windows.Forms.Label();
            
            this.pnlApptList = new System.Windows.Forms.Panel();
            this.lblApptListTitle = new System.Windows.Forms.Label();
            this.btnRequestAppt = new System.Windows.Forms.Button();
            this.dgvAppts = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlSidebar.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.btnNavDashboard.SuspendLayout();
            this.btnNavProfile.SuspendLayout();
            this.btnNavMeds.SuspendLayout();
            this.btnNavAppointments.SuspendLayout();
            this.btnNavTreatment.SuspendLayout();
            this.pnlSidebarBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlNotifBell.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpApptCards.SuspendLayout();
            this.cardNextAppt.SuspendLayout();
            this.cardUpcoming.SuspendLayout();
            this.cardCompleted.SuspendLayout();
            this.pnlApptList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppts)).BeginInit();
            this.SuspendLayout();

            // ==========================================================
            Color clrTeal = Color.FromArgb(0, 168, 168);
            Color clrNavy = ColorTranslator.FromHtml("#EEF3F7");
            Color clrNavyLight = ColorTranslator.FromHtml("#D0DBE8");
            Color clrNavyActive = ColorTranslator.FromHtml("#1B3A6B");
            Color clrBg = Color.FromArgb(242, 247, 250);
            Color clrWhite = Color.White;
            Color clrTextDark = ColorTranslator.FromHtml("#1E293B");
            Color clrTextMid = ColorTranslator.FromHtml("#64748B");
            Color clrNavText = ColorTranslator.FromHtml("#2D3748");
            Color clrGreen = Color.FromArgb(39, 174, 96);
            Color clrRed = Color.FromArgb(192, 57, 43);

            // Form
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.BackColor = clrBg;
            this.Font = new Font("Segoe UI", 9f);
            this.WindowState = FormWindowState.Maximized;

            // Sidebar
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.Width = 260;

            this.pnlLogoArea.Dock = DockStyle.Top;
            this.pnlLogoArea.Height = 90;
            this.pnlLogoArea.Padding = new Padding(25, 20, 25, 15);
            this.picLogo.Dock = DockStyle.Fill;
            this.picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            this.pnlLogoArea.Controls.Add(this.picLogo);

            this.pnlNavDivider.Dock = DockStyle.Top;
            this.pnlNavDivider.Height = 1;
            this.pnlNavDivider.BackColor = clrNavyLight;

            // Nav Fonts
            Font fntNav = new Font("Segoe UI Semibold", 11f, FontStyle.Bold);
            Font fntNavIcon = new Font("Segoe UI Semibold", 15f, FontStyle.Bold);

            // -- Dashboard
            this.btnNavDashboard.Dock = DockStyle.Top; this.btnNavDashboard.Height = 48; this.btnNavDashboard.Cursor = Cursors.Hand;
            this.lblNavDashIcon.Text = ""; this.lblNavDashIcon.Font = fntNavIcon; this.lblNavDashIcon.ForeColor = clrNavText; this.lblNavDashIcon.Location = new Point(20, 11); this.lblNavDashIcon.AutoSize = true;
            this.lblNavDashText.Text = "Dashboard"; this.lblNavDashText.Font = fntNav; this.lblNavDashText.ForeColor = clrNavText; this.lblNavDashText.Location = new Point(20, 13); this.lblNavDashText.AutoSize = true;
            this.btnNavDashboard.Controls.Add(this.lblNavDashIcon); this.btnNavDashboard.Controls.Add(this.lblNavDashText);

            // -- Profile
            this.btnNavProfile.Dock = DockStyle.Top; this.btnNavProfile.Height = 48; this.btnNavProfile.Cursor = Cursors.Hand;
            this.lblNavProfileIcon.Text = ""; this.lblNavProfileIcon.Font = fntNavIcon; this.lblNavProfileIcon.ForeColor = clrNavText; this.lblNavProfileIcon.Location = new Point(20, 11); this.lblNavProfileIcon.AutoSize = true;
            this.lblNavProfileText.Text = "My Profile"; this.lblNavProfileText.Font = fntNav; this.lblNavProfileText.ForeColor = clrNavText; this.lblNavProfileText.Location = new Point(20, 13); this.lblNavProfileText.AutoSize = true;
            this.btnNavProfile.Controls.Add(this.lblNavProfileIcon); this.btnNavProfile.Controls.Add(this.lblNavProfileText);

            // -- Meds
            this.btnNavMeds.Dock = DockStyle.Top; this.btnNavMeds.Height = 48; this.btnNavMeds.Cursor = Cursors.Hand;
            this.lblNavMedsIcon.Text = ""; this.lblNavMedsIcon.Font = fntNavIcon; this.lblNavMedsIcon.ForeColor = clrNavText; this.lblNavMedsIcon.Location = new Point(20, 11); this.lblNavMedsIcon.AutoSize = true;
            this.lblNavMedsText.Text = "Medications & Schedule"; this.lblNavMedsText.Font = fntNav; this.lblNavMedsText.ForeColor = clrNavText; this.lblNavMedsText.Location = new Point(20, 13); this.lblNavMedsText.AutoSize = true;
            this.btnNavMeds.Controls.Add(this.lblNavMedsIcon); this.btnNavMeds.Controls.Add(this.lblNavMedsText);


            // -- Appointments (ACTIVE)
            this.btnNavAppointments.Dock = DockStyle.Top; this.btnNavAppointments.Height = 48; this.btnNavAppointments.BackColor = clrNavyActive; this.btnNavAppointments.Cursor = Cursors.Hand;
            var acc = new Panel { Dock = DockStyle.Left, Width = 4, BackColor = clrTeal };
            this.lblNavApptIcon.Text = ""; this.lblNavApptIcon.Font = fntNavIcon; this.lblNavApptIcon.ForeColor = Color.White; this.lblNavApptIcon.Location = new Point(20, 11); this.lblNavApptIcon.AutoSize = true;
            this.lblNavApptText.Text = "Appointments"; this.lblNavApptText.Font = fntNav; this.lblNavApptText.ForeColor = Color.White; this.lblNavApptText.Location = new Point(20, 13); this.lblNavApptText.AutoSize = true;
            this.btnNavAppointments.Controls.Add(acc); this.btnNavAppointments.Controls.Add(this.lblNavApptIcon); this.btnNavAppointments.Controls.Add(this.lblNavApptText);

            // -- Treatment Plans
            this.btnNavTreatment.Dock = DockStyle.Top; this.btnNavTreatment.Height = 48; this.btnNavTreatment.Cursor = Cursors.Hand;
            this.lblNavTreatmentIcon.Text = ""; this.lblNavTreatmentIcon.Font = fntNavIcon; this.lblNavTreatmentIcon.ForeColor = clrNavText; this.lblNavTreatmentIcon.Location = new Point(20, 11); this.lblNavTreatmentIcon.AutoSize = true;
            this.lblNavTreatmentText.Text = "Treatment Plans"; this.lblNavTreatmentText.Font = fntNav; this.lblNavTreatmentText.ForeColor = clrNavText; this.lblNavTreatmentText.Location = new Point(20, 13); this.lblNavTreatmentText.AutoSize = true;
            this.btnNavTreatment.Controls.Add(this.lblNavTreatmentIcon); this.btnNavTreatment.Controls.Add(this.lblNavTreatmentText);

            this.pnlSidebarBottom.Dock = DockStyle.Bottom; this.pnlSidebarBottom.Height = 70;
            this.lblSidebarFooter.Text = "Secure Healthcare Platform"; this.lblSidebarFooter.Font = new Font("Segoe UI", 8f); this.lblSidebarFooter.ForeColor = clrTextMid; this.lblSidebarFooter.Location = new Point(20, 10); this.lblSidebarFooter.AutoSize = true;
            this.btnLogout.Text = "Sign Out"; this.btnLogout.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold); this.btnLogout.ForeColor = Color.FromArgb(68, 68, 68); this.btnLogout.FlatStyle = FlatStyle.Flat; this.btnLogout.FlatAppearance.BorderSize = 0; this.btnLogout.Location = new Point(16, 32); this.btnLogout.Size = new Size(188, 26); this.btnLogout.TextAlign = ContentAlignment.MiddleLeft; this.btnLogout.Cursor = Cursors.Hand;
            this.pnlSidebarBottom.Controls.Add(this.lblSidebarFooter); this.pnlSidebarBottom.Controls.Add(this.btnLogout);

            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavTreatment);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavMeds);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);

            // Main
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlTopBar);

            this.pnlTopBar.Dock = DockStyle.Top; this.pnlTopBar.Height = 90;
            this.pnlTopBar.BackColor = clrWhite;
            this.lblPageTitle.Text = "Appointments"; this.lblPageTitle.Font = new Font("Segoe UI", 18f, FontStyle.Bold); this.lblPageTitle.ForeColor = clrNavyActive; this.lblPageTitle.Location = new Point(20, 15); this.lblPageTitle.AutoSize = true;
            this.lblWelcome.Text = "Manage your follow-up clinic visits."; this.lblWelcome.ForeColor = clrTextMid; this.lblWelcome.Location = new Point(24, 52); this.lblWelcome.AutoSize = true;
            this.pnlTopBar.Controls.Add(this.lblPageTitle); this.pnlTopBar.Controls.Add(this.lblWelcome);

            this.pnlContent.Dock = DockStyle.Fill;
            this.pnlContent.Padding = new Padding(30);

            // Table
            this.tlpApptCards.Dock = DockStyle.Top;
            this.tlpApptCards.Height = 160;
            this.tlpApptCards.ColumnCount = 3;
            this.tlpApptCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            this.tlpApptCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            this.tlpApptCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));

            // Card 1
            this.cardNextAppt.BackColor = Color.White; this.cardNextAppt.Dock = DockStyle.Fill; this.cardNextAppt.Margin = new Padding(0, 0, 15, 0);
            var bar1 = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = clrNavyActive };
            this.lblCardNextTitle.Text = "NEXT APPOINTMENT"; this.lblCardNextTitle.Font = new Font("Segoe UI", 9f, FontStyle.Bold); this.lblCardNextTitle.ForeColor = clrTextMid; this.lblCardNextTitle.Dock = DockStyle.Top; this.lblCardNextTitle.Padding = new Padding(15, 15, 0, 0); this.lblCardNextTitle.Height = 40;
            this.lblCardNextValue.Text = "--"; this.lblCardNextValue.Font = new Font("Segoe UI", 28f, FontStyle.Bold); this.lblCardNextValue.ForeColor = clrNavyActive; this.lblCardNextValue.Dock = DockStyle.Fill; this.lblCardNextValue.Padding = new Padding(12, 0, 0, 0);
            this.lblCardNextIcon.Text = ""; this.lblCardNextIcon.Font = new Font("Segoe UI", 24f); this.lblCardNextIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right; this.lblCardNextIcon.Location = new Point(240, 50); this.lblCardNextIcon.AutoSize = true;
            this.cardNextAppt.Controls.Add(this.lblCardNextValue);
            this.cardNextAppt.Controls.Add(this.lblCardNextIcon);
            this.cardNextAppt.Controls.Add(this.lblCardNextTitle);
            this.cardNextAppt.Controls.Add(bar1);

            // Card 2
            this.cardUpcoming.BackColor = Color.White; this.cardUpcoming.Dock = DockStyle.Fill; this.cardUpcoming.Margin = new Padding(8, 0, 8, 0);
            var bar2 = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = clrTeal };
            this.lblCardUpcomingTitle.Text = "UPCOMING VISITS"; this.lblCardUpcomingTitle.Font = new Font("Segoe UI", 9f, FontStyle.Bold); this.lblCardUpcomingTitle.ForeColor = clrTextMid; this.lblCardUpcomingTitle.Dock = DockStyle.Top; this.lblCardUpcomingTitle.Padding = new Padding(15, 15, 0, 0); this.lblCardUpcomingTitle.Height = 40;
            this.lblCardUpcomingValue.Text = "--"; this.lblCardUpcomingValue.Font = new Font("Segoe UI", 28f, FontStyle.Bold); this.lblCardUpcomingValue.ForeColor = clrTeal; this.lblCardUpcomingValue.Dock = DockStyle.Fill; this.lblCardUpcomingValue.Padding = new Padding(12, 0, 0, 0);
            this.lblCardUpcomingIcon.Text = ""; this.lblCardUpcomingIcon.Font = new Font("Segoe UI", 24f); this.lblCardUpcomingIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right; this.lblCardUpcomingIcon.Location = new Point(240, 50); this.lblCardUpcomingIcon.AutoSize = true;
            this.cardUpcoming.Controls.Add(this.lblCardUpcomingValue);
            this.cardUpcoming.Controls.Add(this.lblCardUpcomingIcon);
            this.cardUpcoming.Controls.Add(this.lblCardUpcomingTitle);
            this.cardUpcoming.Controls.Add(bar2);

            // Card 3
            this.cardCompleted.BackColor = Color.White; this.cardCompleted.Dock = DockStyle.Fill; this.cardCompleted.Margin = new Padding(15, 0, 0, 0);
            var bar3 = new Panel { Dock = DockStyle.Top, Height = 4, BackColor = clrGreen };
            this.lblCardCompletedTitle.Text = "COMPLETED VISITS"; this.lblCardCompletedTitle.Font = new Font("Segoe UI", 9f, FontStyle.Bold); this.lblCardCompletedTitle.ForeColor = clrTextMid; this.lblCardCompletedTitle.Dock = DockStyle.Top; this.lblCardCompletedTitle.Padding = new Padding(15, 15, 0, 0); this.lblCardCompletedTitle.Height = 40;
            this.lblCardCompletedValue.Text = "--"; this.lblCardCompletedValue.Font = new Font("Segoe UI", 28f, FontStyle.Bold); this.lblCardCompletedValue.ForeColor = clrGreen; this.lblCardCompletedValue.Dock = DockStyle.Fill; this.lblCardCompletedValue.Padding = new Padding(12, 0, 0, 0);
            this.lblCardCompletedIcon.Text = ""; this.lblCardCompletedIcon.Font = new Font("Segoe UI", 24f); this.lblCardCompletedIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right; this.lblCardCompletedIcon.Location = new Point(240, 50); this.lblCardCompletedIcon.AutoSize = true;
            this.cardCompleted.Controls.Add(this.lblCardCompletedValue);
            this.cardCompleted.Controls.Add(this.lblCardCompletedIcon);
            this.cardCompleted.Controls.Add(this.lblCardCompletedTitle);
            this.cardCompleted.Controls.Add(bar3);

            this.tlpApptCards.Controls.Add(this.cardNextAppt, 0, 0);
            this.tlpApptCards.Controls.Add(this.cardUpcoming, 1, 0);
            this.tlpApptCards.Controls.Add(this.cardCompleted, 2, 0);

            // Grid
            this.pnlApptList.Dock = DockStyle.Fill;
            this.pnlApptList.BackColor = Color.White;
            this.pnlApptList.Padding = new Padding(20);
            this.lblApptListTitle.Text = "Appointment Schedule"; this.lblApptListTitle.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold); this.lblApptListTitle.Dock = DockStyle.Top; this.lblApptListTitle.Height = 40;
            
            this.dgvAppts.Dock = DockStyle.Fill;
            this.dgvAppts.BackgroundColor = Color.White;
            this.dgvAppts.BorderStyle = BorderStyle.None;
            this.dgvAppts.RowHeadersVisible = false;
            this.dgvAppts.AllowUserToAddRows = false;
            this.dgvAppts.ReadOnly = true;
            this.dgvAppts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppts.ColumnHeadersHeight = 40;
            this.dgvAppts.GridColor = clrNavyLight;
            this.dgvAppts.EnableHeadersVisualStyles = false;
            this.dgvAppts.ColumnHeadersDefaultCellStyle.BackColor = clrBg;
            this.dgvAppts.ColumnHeadersDefaultCellStyle.ForeColor = clrTextMid;
            this.dgvAppts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);

            // Columns
            this.colDate.HeaderText = "DATE"; this.colDate.FillWeight = 18;
            this.colTime.HeaderText = "TIME"; this.colTime.FillWeight = 12;
            this.colDoctor.HeaderText = "DOCTOR"; this.colDoctor.FillWeight = 22;
            this.colReason.HeaderText = "REASON / TYPE"; this.colReason.FillWeight = 23;
            this.colStatus.HeaderText = "STATUS"; this.colStatus.FillWeight = 12;
            this.colAction.HeaderText = "ACTION"; this.colAction.FillWeight = 13;
            this.colAction.Text = "View Details";
            this.colAction.UseColumnTextForButtonValue = true;
            this.colAction.FlatStyle = FlatStyle.Flat;
            this.colAction.DefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            this.colAction.DefaultCellStyle.ForeColor = clrNavyActive;
            this.colAction.DefaultCellStyle.SelectionBackColor = clrNavyActive;
            this.colAction.DefaultCellStyle.SelectionForeColor = Color.White;

            this.dgvAppts.Columns.AddRange(new DataGridViewColumn[] {
                this.colDate, this.colTime, this.colDoctor, this.colReason, this.colStatus, this.colAction
            });

            this.pnlApptList.Controls.Add(this.dgvAppts);
            this.pnlApptList.Controls.Add(this.lblApptListTitle);

            var spacer = new Panel { Dock = DockStyle.Top, Height = 25 };
            this.pnlContent.Controls.Add(this.pnlApptList);
            this.pnlContent.Controls.Add(spacer);
            this.pnlContent.Controls.Add(this.tlpApptCards);

            // Final
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.tlpApptCards.ResumeLayout(false);
            this.cardNextAppt.ResumeLayout(false);
            this.cardUpcoming.ResumeLayout(false);
            this.cardCompleted.ResumeLayout(false);
            this.pnlApptList.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlLogoArea;
        private PictureBox picLogo;
        private Panel pnlNavDivider;
        private Panel btnNavDashboard;
        private Label lblNavDashIcon;
        private Label lblNavDashText;
        private Panel btnNavProfile;
        private Label lblNavProfileIcon;
        private Label lblNavProfileText;
        private Panel btnNavMeds;
        private Label lblNavMedsIcon;
        private Label lblNavMedsText;
        private Panel btnNavAppointments;
        private Label lblNavApptIcon;
        private Label lblNavApptText;
        private Panel btnNavTreatment;
        private Label lblNavTreatmentIcon;
        private Label lblNavTreatmentText;
        private Panel pnlSidebarBottom;
        private Label lblSidebarFooter;
        private Button btnLogout;
        private Panel pnlMain;
        private Panel pnlTopBar;
        private Label lblPageTitle;
        private Label lblWelcome;
        private Panel pnlNotifBell;
        private Label lblBellIcon;
        private Label lblNotifBadge;
        private Panel pnlAvatarTop;
        private Label lblAvatarInitials;
        private Panel pnlContent;
        private TableLayoutPanel tlpApptCards;
        private Panel cardNextAppt;
        private Label lblCardNextTitle;
        private Label lblCardNextValue;
        private Label lblCardNextIcon;
        private Panel cardUpcoming;
        private Label lblCardUpcomingTitle;
        private Label lblCardUpcomingValue;
        private Label lblCardUpcomingIcon;
        private Panel cardCompleted;
        private Label lblCardCompletedTitle;
        private Label lblCardCompletedValue;
        private Label lblCardCompletedIcon;
        private Panel pnlApptList;
        private Label lblApptListTitle;
        private Button btnRequestAppt;
        private DataGridView dgvAppts;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colDoctor;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAction;
    }
}