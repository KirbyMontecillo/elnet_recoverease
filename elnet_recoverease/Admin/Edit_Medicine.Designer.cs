using System.Windows.Forms;
using System.Drawing;

namespace elnet_recoverease.Admin
{
    partial class Edit_Medicine
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
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.btnClose = new Button();
            this.pnlDivider1 = new Panel();
            
            this.lblMedName = new Label();
            this.txtMedName = new TextBox();
            
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            
            this.lblDosage = new Label();
            this.txtDosage = new TextBox();
            
            this.lblForm = new Label();
            this.cmbForm = new ComboBox();
            
            this.lblFrequency = new Label();
            this.txtFrequency = new TextBox();
            
            this.lblDescription = new Label();
            this.txtDescription = new TextBox();
            
            this.pnlFooter = new Panel();
            this.lblRequired = new Label();
            this.btnCancel = new Button();
            this.btnSave = new Button();

            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // Colors & Fonts
            Color clrMain = Color.FromArgb(45, 55, 72);
            Color clrSec = Color.FromArgb(113, 128, 150);
            Color clrBorder = Color.FromArgb(226, 232, 240);
            Color clrTeal = Color.FromArgb(0, 168, 168);
            Font fntLabel = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font fntInput = new Font("Segoe UI", 10.5F);

            // Header
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 85;
            this.pnlHeader.BackColor = Color.White;
            
            this.lblTitle.Text = "Edit medication";
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(24, 18);
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = clrMain;

            this.lblSubtitle.Text = "Update the clinical details for this item";
            this.lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = clrSec;
            this.lblSubtitle.Location = new Point(24, 48);
            this.lblSubtitle.AutoSize = true;

            this.btnClose.Text = "✕";
            this.btnClose.Size = new Size(32, 32);
            this.btnClose.Location = new Point(490, 18);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor = Cursors.Hand;
            this.pnlHeader.Controls.AddRange(new Control[] { this.lblTitle, this.lblSubtitle, this.btnClose });

            this.pnlDivider1.Dock = DockStyle.Top;
            this.pnlDivider1.Height = 1;
            this.pnlDivider1.BackColor = clrBorder;

            // Fields
            this.lblMedName.Text = "Medication Name *";
            this.lblMedName.Font = fntLabel;
            this.lblMedName.ForeColor = clrMain;
            this.lblMedName.Location = new Point(24, 105);
            this.lblMedName.AutoSize = true;
            this.txtMedName.Location = new Point(24, 127);
            this.txtMedName.Width = 480;
            this.txtMedName.Font = fntInput;
            this.txtMedName.BorderStyle = BorderStyle.FixedSingle;

            this.lblCategory.Text = "Category *";
            this.lblCategory.Font = fntLabel;
            this.lblCategory.Location = new Point(24, 175);
            this.lblCategory.AutoSize = true;
            this.cmbCategory.Location = new Point(24, 197);
            this.cmbCategory.Width = 230;
            this.cmbCategory.Font = fntInput;
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] { "Antibiotic", "Analgesic", "Antipyretic", "Antihistamine", "Antiviral", "Supplement", "Vaccine" });

            this.lblDosage.Text = "Dosage Unit *";
            this.lblDosage.Font = fntLabel;
            this.lblDosage.Location = new Point(274, 175);
            this.lblDosage.AutoSize = true;
            this.txtDosage.Location = new Point(274, 197);
            this.txtDosage.Width = 230;
            this.txtDosage.Font = fntInput;
            this.txtDosage.BorderStyle = BorderStyle.FixedSingle;

            this.lblForm.Text = "Form *";
            this.lblForm.Font = fntLabel;
            this.lblForm.Location = new Point(24, 245);
            this.lblForm.AutoSize = true;
            this.cmbForm.Location = new Point(24, 267);
            this.cmbForm.Width = 230;
            this.cmbForm.Font = fntInput;
            this.cmbForm.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbForm.Items.AddRange(new object[] { "Tablet", "Capsule", "Syrup", "Injection", "Cream", "Ointment" });

            this.lblFrequency.Text = "Frequency *";
            this.lblFrequency.Font = fntLabel;
            this.lblFrequency.Location = new Point(274, 245);
            this.lblFrequency.AutoSize = true;
            this.txtFrequency.Location = new Point(274, 267);
            this.txtFrequency.Width = 230;
            this.txtFrequency.Font = fntInput;
            this.txtFrequency.BorderStyle = BorderStyle.FixedSingle;

            this.lblDescription.Text = "Description";
            this.lblDescription.Font = fntLabel;
            this.lblDescription.Location = new Point(24, 315);
            this.lblDescription.AutoSize = true;

            this.txtDescription.Location = new Point(24, 337);
            this.txtDescription.Width = 480;
            this.txtDescription.Height = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Font = fntInput;
            this.txtDescription.BorderStyle = BorderStyle.FixedSingle;

            // Footer
            this.pnlFooter.Dock = DockStyle.Bottom;
            this.pnlFooter.Height = 80;
            this.pnlFooter.BackColor = Color.FromArgb(248, 250, 252);
            this.lblRequired.Text = "* Required fields";
            this.lblRequired.ForeColor = Color.IndianRed;
            this.lblRequired.Location = new Point(24, 30);
            this.lblRequired.AutoSize = true;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new Point(270, 22);
            this.btnCancel.Size = new Size(100, 36);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = clrBorder;
            this.btnCancel.Font = new Font("Segoe UI", 9F);
            this.btnSave.Text = "Save changes";
            this.btnSave.Location = new Point(380, 22);
            this.btnSave.Size = new Size(130, 36);
            this.btnSave.BackColor = clrTeal;
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.pnlFooter.Controls.AddRange(new Control[] { this.lblRequired, this.btnCancel, this.btnSave });

            // Form
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(540, 600);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Controls.AddRange(new Control[] {
                this.pnlFooter,
                this.lblDescription, this.txtDescription,
                this.lblFrequency, this.txtFrequency,
                this.lblForm, this.cmbForm,
                this.lblDosage, this.txtDosage,
                this.lblCategory, this.cmbCategory,
                this.lblMedName, this.txtMedName,
                this.pnlDivider1,
                this.pnlHeader
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnClose;
        private Panel pnlDivider1;
        private Label lblMedName;
        private TextBox txtMedName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDosage;
        private TextBox txtDosage;
        private Label lblForm;
        private ComboBox cmbForm;
        private Label lblFrequency;
        private TextBox txtFrequency;
        
        private Label lblDescription;
        private TextBox txtDescription;
        
        private Panel pnlFooter;
        private Label lblRequired;
        private Button btnCancel;
        private Button btnSave;
    }
}