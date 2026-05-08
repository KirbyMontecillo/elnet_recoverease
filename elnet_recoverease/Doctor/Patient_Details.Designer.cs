using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace elnet_recoverease.Doctor
{
    partial class Patient_Details
    {
        private System.ComponentModel.IContainer components = null;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(int nL, int nT, int nR, int nB, int nW, int nH);

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Standard Design System ───────────────────────────────
            Color clrTeal = Color.FromArgb(0, 168, 168);
            Color clrNavy = ColorTranslator.FromHtml("#EEF3F7");
            Color clrNavyActive = ColorTranslator.FromHtml("#1B3A6B");
            Color clrBg = Color.FromArgb(242, 247, 250);
            Color clrWhite = Color.White;
            Color clrTextDark = Color.FromArgb(30, 43, 60);
            Color clrTextMid = Color.FromArgb(100, 120, 145);
            Font fntTitle = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fntBody = new Font("Segoe UI", 9);

            // ── Sidebar ──
            this.pnlSidebar = new Panel();
            this.pnlLogoArea = new Panel();
            this.picLogo = new PictureBox();
            this.btnNavDashboard = new Panel();
            this.lblNavDashIcon = new Label();
            this.lblNavDashText = new Label();
            this.btnNavPatients = new Panel();
            this.lblNavPatientsIcon = new Label();
            this.lblNavPatientsText = new Label();
            this.btnNavAppointments = new Panel();
            this.lblNavApptIcon = new Label();
            this.lblNavApptText = new Label();
            this.btnNavReports = new Panel();
            this.lblNavReportsIcon = new Label();
            this.lblNavReportsText = new Label();
            this.btnNavProfile = new Panel();
            this.lblNavProfileIcon = new Label();
            this.lblNavProfileText = new Label();
            this.pnlSidebarBottom = new Panel();
            this.btnLogout = new Button();

            // ── Main Layout ──
            this.pnlMain = new Panel();
            this.pnlTopBar = new Panel();
            this.btnBack = new Button();
            this.lblPageTitle = new Label();
            this.pnlAvatarTop = new Panel();
            this.lblAvatarInitials = new Label();

            this.pnlContent = new Panel();
            this.flpDashboard = new FlowLayoutPanel();
            this.pnlProfileCard = new Panel();
            this.pnlMedInfo = new Panel();
            this.pnlLatestVitals = new Panel();
            this.pnlApptHistory = new Panel();
            this.pnlTreatmentPlan = new Panel();
            this.pnlCurrentMeds = new Panel();
            
            // New structured treatment plan labels
            this.lblDiagHeader = new Label();
            this.lblDiagContent = new Label();
            this.lblGoalHeader = new Label();
            this.lblGoalContent = new Label();
            this.lblNoteHeader = new Label();
            this.lblNoteContent = new Label();

            this.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.flpDashboard.SuspendLayout();

            // ── Form ──
            this.Text = "RecoverEase — Patient Profile";
            this.ClientSize = new Size(1600, 900);
            this.BackColor = clrBg;
            this.Font = fntBody;
            this.WindowState = FormWindowState.Maximized;

            // ── Sidebar (Restored) ──
            this.pnlSidebar.BackColor = clrNavy;
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.Width = 260;
            this.pnlLogoArea.Dock = DockStyle.Top;
            this.pnlLogoArea.Height = 100;
            this.pnlLogoArea.Padding = new Padding(20);
            this.picLogo = new PictureBox { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            this.pnlLogoArea.Controls.Add(this.picLogo);
            SetupBaseNav(btnNavProfile, lblNavProfileIcon, lblNavProfileText, "👤", "My Profile", false, clrNavy, clrNavyActive, clrWhite);
            SetupBaseNav(btnNavReports, lblNavReportsIcon, lblNavReportsText, "📊", "Reports", false, clrNavy, clrNavyActive, clrWhite);
            SetupBaseNav(btnNavAppointments, lblNavApptIcon, lblNavApptText, "📅", "Appointments", false, clrNavy, clrNavyActive, clrWhite);
            SetupBaseNav(btnNavPatients, lblNavPatientsIcon, lblNavPatientsText, "👥", "My Patients", true, clrNavy, clrNavyActive, clrWhite);
            SetupBaseNav(btnNavDashboard, lblNavDashIcon, lblNavDashText, "⊞", "Dashboard", false, clrNavy, clrNavyActive, clrWhite);
            this.pnlSidebarBottom.Dock = DockStyle.Bottom;
            this.pnlSidebarBottom.Height = 0;
            this.btnLogout = new Button { 
                Text = "Sign Out", 
                Dock = DockStyle.Bottom, 
                Height = 50,
                FlatStyle = FlatStyle.Flat, 
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(20, 35, 65),
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0)
            };
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Visible = false;
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnNavProfile);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavAppointments);
            this.pnlSidebar.Controls.Add(this.btnNavPatients);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlLogoArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);

            // ── Main Area ──
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlTopBar.BackColor = clrWhite;
            this.pnlTopBar.Dock = DockStyle.Top;
            this.pnlTopBar.Height = 90;
            this.pnlTopBar.Padding = new Padding(25, 0, 25, 0);

            this.btnBack = new Button { Text = "← Back to Patient List", Location = new Point(25, 15), AutoSize = true, FlatStyle = FlatStyle.Flat, ForeColor = clrTeal, Font = new Font("Segoe UI Semibold", 9) };
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.lblPageTitle = new Label { Text = "Patient Profile", Location = new Point(25, 42), Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = clrNavyActive, AutoSize = true };
            
            this.pnlAvatarTop = new Panel { Size = new Size(40, 40), Location = new Point(1250, 25), BackColor = clrTeal, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            this.lblAvatarInitials = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.pnlAvatarTop.Controls.Add(this.lblAvatarInitials);
            this.pnlTopBar.Controls.AddRange(new Control[] { btnBack, lblPageTitle, pnlAvatarTop });

            // Content Area
            this.pnlContent.Dock = DockStyle.Fill;
            this.pnlContent.Padding = new Padding(30);
            this.flpDashboard.Dock = DockStyle.Fill;
            this.flpDashboard.AutoScroll = true;

            int fullW = 1500; int col1W = 480; int col2W = 990;

            // 1. Profile Card (Fixed Area)
            this.pnlProfileCard.BackColor = clrWhite;
            this.pnlProfileCard.Size = new Size(fullW, 180);
            this.pnlProfileCard.Margin = new Padding(0, 0, 0, 30);
            this.pnlProfileCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, fullW, 180, 20, 20));
            this.pnlPatientAvatar = new Panel { Size = new Size(100, 100), Location = new Point(35, 40), BackColor = clrNavyActive };
            this.pnlPatientAvatar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 100, 100, 15, 15));
            this.lblPatientInitials = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 32, FontStyle.Bold), ForeColor = Color.White };
            this.pnlPatientAvatar.Controls.Add(this.lblPatientInitials);
            
            this.lblPatientName = new Label { Location = new Point(160, 35), Font = new Font("Segoe UI", 24, FontStyle.Bold), ForeColor = clrTextDark, AutoSize = true };
            this.lblPatientId = new Label { Location = new Point(162, 88), Font = new Font("Segoe UI Semibold", 10), ForeColor = clrTextMid, AutoSize = true };
            
            // Info Row with better spacing
            this.lblInfoAgeGenVal = new Label { Location = new Point(162, 118), Font = new Font("Segoe UI Semibold", 10.5f), AutoSize = true };
            this.lblInfoContactVal = new Label { Location = new Point(162, 145), Font = new Font("Segoe UI", 10), ForeColor = clrTextDark, AutoSize = true };
            this.lblInfoBloodVal = new Label { Location = new Point(420, 145), Font = new Font("Segoe UI", 10), ForeColor = clrTextDark, AutoSize = true };
            this.lblInfoAddressVal = new Label { Location = new Point(640, 145), Font = new Font("Segoe UI", 10), ForeColor = clrTextDark, AutoSize = true };
            this.lblStatusBadge = new Label { Location = new Point(160, 10), Font = new Font("Segoe UI", 8, FontStyle.Bold), ForeColor = Color.White, AutoSize = true, TextAlign = ContentAlignment.MiddleCenter, Padding = new Padding(8, 2, 8, 2) };
            this.btnActivate = new Button { Text = "↺ Re-activate Patient", Location = new Point(1250, 120), Size = new Size(200, 35), FlatStyle = FlatStyle.Flat, ForeColor = clrTeal, Font = new Font("Segoe UI Bold", 9), Visible = false };
            this.btnActivate.FlatAppearance.BorderColor = clrTeal;

            this.pnlProfileCard.Controls.AddRange(new Control[] { pnlPatientAvatar, lblPatientName, lblPatientId, lblInfoAgeGenVal, lblInfoContactVal, lblInfoBloodVal, lblInfoAddressVal, lblStatusBadge, btnActivate });

            // Widgets (Swapped Positions)
            this.pnlMedInfo.BackColor = clrWhite; this.pnlMedInfo.Size = new Size(col1W, 320); this.pnlMedInfo.Margin = new Padding(0, 0, 30, 30);
            this.pnlMedInfo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, col1W, 320, 20, 20));

            // Appointment History moved to Top Right
            this.pnlApptHistory.BackColor = clrWhite; this.pnlApptHistory.Size = new Size(col2W, 320); this.pnlApptHistory.Margin = new Padding(0, 0, 0, 30);
            this.pnlApptHistory.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, col2W, 320, 20, 20));

            // Latest Vitals moved to Bottom Left
            this.pnlLatestVitals.BackColor = clrWhite; this.pnlLatestVitals.Size = new Size(col1W, 500); this.pnlLatestVitals.Margin = new Padding(0, 0, 30, 30);
            this.pnlLatestVitals.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, col1W, 500, 20, 20));

            // Treatment Plan
            this.pnlTreatmentPlan.BackColor = clrWhite; this.pnlTreatmentPlan.Size = new Size(col2W, 500); this.pnlTreatmentPlan.Margin = new Padding(0, 0, 0, 30);
            this.pnlTreatmentPlan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, col2W, 500, 20, 20));
            
            var lblPlanTitle = new Label { Text = "📋 Active Treatment Plan", Location = new Point(30, 30), Font = fntTitle, ForeColor = clrNavyActive, AutoSize = true };
            
            this.lblDiagHeader.Text = "DIAGNOSIS"; this.lblDiagHeader.Location = new Point(35, 80); this.lblDiagHeader.Font = new Font("Segoe UI Bold", 9); this.lblDiagHeader.ForeColor = clrTextMid; this.lblDiagHeader.AutoSize = true;
            this.lblDiagContent.Location = new Point(35, 105); this.lblDiagContent.Font = new Font("Segoe UI Semibold", 11); this.lblDiagContent.ForeColor = clrTextDark; this.lblDiagContent.AutoSize = true;

            this.lblGoalHeader.Text = "GOALS"; this.lblGoalHeader.Location = new Point(35, 160); this.lblGoalHeader.Font = new Font("Segoe UI Bold", 9); this.lblGoalHeader.ForeColor = clrTextMid; this.lblGoalHeader.AutoSize = true;
            this.lblGoalContent.Location = new Point(35, 185); this.lblGoalContent.Font = new Font("Segoe UI Semibold", 11); this.lblGoalContent.ForeColor = clrTextDark; this.lblGoalContent.AutoSize = true;

            this.lblNoteHeader.Text = "NOTES"; this.lblNoteHeader.Location = new Point(35, 240); this.lblNoteHeader.Font = new Font("Segoe UI Bold", 9); this.lblNoteHeader.ForeColor = clrTextMid; this.lblNoteHeader.AutoSize = true;
            this.lblNoteContent.Location = new Point(35, 265); this.lblNoteContent.Size = new Size(920, 150); this.lblNoteContent.Font = new Font("Segoe UI", 10.5f); this.lblNoteContent.ForeColor = clrTextDark;
            this.lblNoteContent.BackColor = Color.FromArgb(248, 250, 252);
            this.lblNoteContent.Padding = new Padding(15);
            this.lblNoteContent.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 920, 150, 10, 10));

            this.btnUpdatePlan = new Button { Text = "+ Update Treatment Plan", Location = new Point(730, 430), Size = new Size(230, 45), FlatStyle = FlatStyle.Flat, ForeColor = clrTeal, Font = new Font("Segoe UI Bold", 10) };
            this.btnUpdatePlan.FlatAppearance.BorderColor = clrTeal;
            this.btnUpdatePlan.FlatAppearance.BorderSize = 2;
            
            this.pnlTreatmentPlan.Controls.AddRange(new Control[] { lblPlanTitle, lblDiagHeader, lblDiagContent, lblGoalHeader, lblGoalContent, lblNoteHeader, lblNoteContent, btnUpdatePlan });

            this.pnlCurrentMeds.BackColor = clrWhite; this.pnlCurrentMeds.Size = new Size(col1W, 300); this.pnlCurrentMeds.Margin = new Padding(0, 0, 30, 30);
            this.pnlCurrentMeds.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, col1W, 300, 20, 20));

            this.flpDashboard.Controls.AddRange(new Control[] { pnlProfileCard, pnlMedInfo, pnlApptHistory, pnlLatestVitals, pnlTreatmentPlan, pnlCurrentMeds });
            this.pnlContent.Controls.Add(flpDashboard);
            this.pnlMain.Controls.Add(pnlContent);
            this.pnlMain.Controls.Add(pnlTopBar);
            this.Controls.Add(pnlMain);
            this.Controls.Add(pnlSidebar);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.flpDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void SetupBaseNav(Panel pnl, Label ico, Label txt, string icon, string title, bool active, Color bg, Color activeBg, Color white)
        {
            pnl.Dock = DockStyle.Top; pnl.Height = 50; pnl.BackColor = active ? activeBg : bg; pnl.Cursor = Cursors.Hand;
            ico.Text = icon; ico.Location = new Point(20, 12); ico.Font = new Font("Segoe UI Semibold", 15); ico.ForeColor = active ? white : Color.FromArgb(64, 64, 64); ico.AutoSize = true;
            txt.Text = title; txt.Location = new Point(64, 13); txt.Font = new Font("Segoe UI Semibold", 11); txt.ForeColor = active ? white : Color.FromArgb(64, 64, 64); txt.AutoSize = true;
            pnl.Controls.AddRange(new Control[] { ico, txt });
            if (active) {
                var accent = new Panel { BackColor = Color.FromArgb(0, 168, 168), Width = 4, Dock = DockStyle.Left };
                pnl.Controls.Add(accent);
            }
        }

        private Panel pnlSidebar, pnlLogoArea, pnlSidebarBottom, btnNavDashboard, btnNavPatients, btnNavAppointments, btnNavReports, btnNavProfile;
        private Label lblNavDashIcon, lblNavDashText, lblNavPatientsIcon, lblNavPatientsText, lblNavApptIcon, lblNavApptText, lblNavReportsIcon, lblNavReportsText, lblNavProfileIcon, lblNavProfileText;
        private PictureBox picLogo;
        private Button btnLogout, btnBack, btnUpdatePlan;
        private Panel pnlMain, pnlTopBar, pnlAvatarTop, pnlContent, pnlProfileCard, pnlPatientAvatar, pnlMedInfo, pnlLatestVitals, pnlApptHistory, pnlTreatmentPlan, pnlCurrentMeds;
        private Label lblPageTitle, lblAvatarInitials, lblPatientInitials, lblPatientName, lblPatientId, lblInfoAgeGenVal, lblInfoContactVal, lblInfoBloodVal, lblInfoAddressVal, lblStatusBadge;
        private Button btnActivate;
        private DataGridView dgvApptHistory;
        private Label lblDiagHeader, lblDiagContent, lblGoalHeader, lblGoalContent, lblNoteHeader, lblNoteContent;
        private FlowLayoutPanel flpDashboard;
    }
}