using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnReportIssues;
        private Button btnLocalEvents;
        private Button btnServiceStatus;
        private Label lblTitle;

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
            this.lblTitle = new Label();
            this.btnReportIssues = new Button();
            this.btnLocalEvents = new Button();
            this.btnServiceStatus = new Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(80, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(340, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Municipal Services Portal";

            // btnReportIssues
            this.btnReportIssues.Location = new Point(150, 100);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new Size(200, 40);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // btnLocalEvents
            this.btnLocalEvents.Enabled = true;
            this.btnLocalEvents.Location = new Point(150, 160);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new Size(200, 40);
            this.btnLocalEvents.TabIndex = 2;
            this.btnLocalEvents.Text = "Local Events and Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = true;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);

            // btnServiceStatus
            this.btnServiceStatus.Enabled = true;
            this.btnServiceStatus.Location = new Point(150, 220);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new Size(200, 40);
            this.btnServiceStatus.TabIndex = 3;
            this.btnServiceStatus.Text = "Service Request Status";
            this.btnServiceStatus.UseVisualStyleBackColor = true;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);

            // FormMain
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 350);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Municipal Services";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}