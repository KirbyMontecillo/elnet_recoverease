using System;
using System.Drawing;
using System.Windows.Forms;
using elnet_recoverease.Data;
using elnet_recoverease.Models;
using elnet_recoverease.Core;

namespace elnet_recoverease.Doctor
{
    public partial class Clinical_Notes : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _patientId;

        // UI Controls
        private RichTextBox rtxtNoteContent = new RichTextBox();
        private Button btnSaveNote = new Button();
        private Button btnCancel = new Button();

        public Clinical_Notes(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Clinical Observation Log";
            this.Size = new Size(550, 450);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(242, 247, 250);
            this.Font = new Font("Segoe UI", 9f);

            Panel pnlHeader = new Panel {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(0, 168, 168),
                Padding = new Padding(20, 15, 0, 0)
            };
            Label lblTitle = new Label {
                Text = "CLINICAL NOTES ENGINE",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblTitle);

            Label lblNote = new Label { 
                Text = "Enter your clinical observations, progress notes, or patient instructions below:", 
                Location = new Point(25, 80), 
                AutoSize = true,
                ForeColor = Color.FromArgb(27, 43, 60)
            };

            rtxtNoteContent.Location = new Point(25, 110);
            rtxtNoteContent.Size = new Size(485, 230);
            rtxtNoteContent.BorderStyle = BorderStyle.None;
            rtxtNoteContent.Font = new Font("Segoe UI", 11f);

            btnSaveNote.Text = "Save Note";
            btnSaveNote.Location = new Point(360, 355);
            btnSaveNote.Size = new Size(150, 40);
            btnSaveNote.BackColor = Color.FromArgb(0, 168, 168);
            btnSaveNote.ForeColor = Color.White;
            btnSaveNote.FlatStyle = FlatStyle.Flat;
            btnSaveNote.FlatAppearance.BorderSize = 0;
            btnSaveNote.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            btnCancel.Text = "Close";
            btnCancel.Location = new Point(270, 355);
            btnCancel.Size = new Size(80, 40);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Click += new EventHandler(btnCancel_Click);

            btnSaveNote.Click += BtnSaveNote_Click;

            this.Controls.Add(pnlHeader);
            this.Controls.Add(lblNote);
            this.Controls.Add(rtxtNoteContent);
            this.Controls.Add(btnSaveNote);
            this.Controls.Add(btnCancel);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSaveNote_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtNoteContent.Text))
            {
                MessageBox.Show("Observation content cannot be empty.");
                return;
            }

            try
            {
                var currentStaff = UserSession.CurrentStaff;
                if (currentStaff == null)
                {
                    MessageBox.Show("Security Session Error: Staff profile not found. Please log in again.");
                    return;
                }

                var note = new ClinicalNote
                {
                    PatientID = _patientId,
                    StaffID = currentStaff.StaffID,
                    NoteContent = rtxtNoteContent.Text,
                    CreatedAt = DateTime.Now
                };

                _db.ClinicalNotes.Add(note);
                await _db.SaveChangesAsync();

                MessageBox.Show("Clinical observation successfully archived.", "Note Saved");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clinical Database Error: " + ex.Message);
            }
        }
    }
}
