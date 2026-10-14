using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Label lblAttachment;
        private Button btnAttach;
        private Label lblAttachmentPath;
        private Button btnSubmit;
        private Button btnBackToMain;
        private ProgressBar progressEngagement;
        private Label lblEngagement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLocation = new Label();
            this.txtLocation = new TextBox();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.lblDescription = new Label();
            this.rtbDescription = new RichTextBox();
            this.lblAttachment = new Label();
            this.btnAttach = new Button();
            this.lblAttachmentPath = new Label();
            this.btnSubmit = new Button();
            this.btnBackToMain = new Button();
            this.progressEngagement = new ProgressBar();
            this.lblEngagement = new Label();
            this.SuspendLayout();

            // lblLocation
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new Point(20, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new Size(51, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";

            // txtLocation
            this.txtLocation.Location = new Point(120, 17);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new Size(250, 20);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new Point(20, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";

            // cmbCategory
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities", "Street Lighting", "Water & Sewage", "Parks & Recreation", "Other" });
            this.cmbCategory.Location = new Point(120, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new Size(250, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(20, 85);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(63, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";

            // rtbDescription
            this.rtbDescription.Location = new Point(120, 85);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new Size(250, 100);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);

            // lblAttachment
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new Point(20, 200);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new Size(90, 13);
            this.lblAttachment.TabIndex = 6;
            this.lblAttachment.Text = "Attach Media:";

            // btnAttach
            this.btnAttach.Location = new Point(120, 195);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new Size(100, 23);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "Browse...";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);

            // lblAttachmentPath
            this.lblAttachmentPath.AutoSize = true;
            this.lblAttachmentPath.Location = new Point(230, 200);
            this.lblAttachmentPath.Name = "lblAttachmentPath";
            this.lblAttachmentPath.Size = new Size(82, 13);
            this.lblAttachmentPath.TabIndex = 7;
            this.lblAttachmentPath.Text = "No file attached";

            // progressEngagement
            this.progressEngagement.Location = new Point(120, 240);
            this.progressEngagement.Name = "progressEngagement";
            this.progressEngagement.Size = new Size(250, 20);
            this.progressEngagement.TabIndex = 8;

            // lblEngagement
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Location = new Point(120, 270);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new Size(150, 13);
            this.lblEngagement.TabIndex = 9;
            this.lblEngagement.Text = "Let's report an issue!";

            // btnSubmit
            this.btnSubmit.Location = new Point(120, 310);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new Size(100, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnBackToMain
            this.btnBackToMain.Location = new Point(240, 310);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new Size(130, 30);
            this.btnBackToMain.TabIndex = 6;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);

            // ReportIssuesForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 360);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.progressEngagement);
            this.Controls.Add(this.lblAttachmentPath);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Name = "ReportIssuesForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Report an Issue";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}