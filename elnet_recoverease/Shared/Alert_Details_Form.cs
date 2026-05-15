using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace elnet_recoverease.Shared
{
    public partial class Alert_Details_Form : Form
    {
        // Properties to hold the data
        public string AlertIcon { get; set; }
        public string AlertTitle { get; set; }
        public string AlertMessage { get; set; }
        public string AlertTime { get; set; }
        public Color PriorityColor { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        // Standard parameterless constructor for the Designer
        public Alert_Details_Form()
        {
            InitializeComponent();
        }

        // Modern constructor used by your code
        public Alert_Details_Form(string icon, string title, string message, string time, Color priorityColor) : this()
        {
            this.AlertIcon = icon;
            this.AlertTitle = title;
            this.AlertMessage = message;
            this.AlertTime = time;
            this.PriorityColor = priorityColor;
            
            // Apply the data to the UI after initialization
            ApplyAlertData();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(400, 300);
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ApplyAlertData()
        {
            this.Controls.Clear();

            var pnlHeader = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(248, 250, 252) };
            var lblIcon = new Label { Text = AlertIcon, Font = new Font("Segoe UI", 18), Location = new Point(20, 15), AutoSize = true };
            var lblTitle = new Label { Text = "Alert Details", Font = new Font("Segoe UI", 12F, FontStyle.Bold), Location = new Point(75, 20), ForeColor = Color.FromArgb(30, 41, 59), AutoSize = true };
            pnlHeader.Controls.Add(lblIcon);
            pnlHeader.Controls.Add(lblTitle);

            var lblSubject = new Label { Text = AlertTitle, Font = new Font("Segoe UI", 11F, FontStyle.Bold), Location = new Point(20, 80), Size = new Size(360, 50), ForeColor = PriorityColor };
            var lblTime = new Label { Text = $"Received: {AlertTime}", Font = new Font("Segoe UI", 9F), Location = new Point(20, 135), ForeColor = Color.Gray, AutoSize = true };
            
            var lblInfo = new Label { 
                Text = AlertMessage, 
                Font = new Font("Segoe UI", 10F), 
                Location = new Point(20, 165), 
                Size = new Size(360, 60), 
                ForeColor = Color.FromArgb(71, 85, 105) 
            };

            var btnMarkRead = new Button { 
                Text = "Mark as Read", 
                Size = new Size(150, 40), 
                Location = new Point(230, 240), 
                BackColor = Color.FromArgb(0, 168, 168), 
                ForeColor = Color.White, 
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnMarkRead.FlatAppearance.BorderSize = 0;
            btnMarkRead.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

            var btnClose = new Button { 
                Text = "Close", 
                Size = new Size(100, 40), 
                Location = new Point(120, 240), 
                BackColor = Color.White, 
                ForeColor = Color.Gray, 
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(btnMarkRead);
            this.Controls.Add(btnClose);
            this.Controls.Add(lblInfo);
            this.Controls.Add(lblTime);
            this.Controls.Add(lblSubject);
            this.Controls.Add(pnlHeader);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84) m.Result = (IntPtr)0x2; // WM_NCHITTEST -> HTCAPTION
        }
    }
}
