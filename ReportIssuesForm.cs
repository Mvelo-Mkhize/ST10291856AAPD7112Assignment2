using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        public ReportIssuesForm()
        {
            InitializeComponent();
            progressEngagement.Value = 0;
        }

        private void UpdateProgress()
        {
            int progress = 0;
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                progress += 25;
            if (cmbCategory.SelectedIndex >= 0)
                progress += 25;
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
                progress += 25;
            if (!string.IsNullOrEmpty(lblAttachmentPath.Text) && lblAttachmentPath.Text != "No file attached")
                progress += 25;

            progressEngagement.Value = progress;

            if (progress == 100)
                lblEngagement.Text = "Excellent! You're ready to submit.";
            else if (progress >= 50)
                lblEngagement.Text = "Great! Halfway there.";
            else if (progress > 0)
                lblEngagement.Text = "Good start! Keep going.";
            else
                lblEngagement.Text = "Let's report an issue!";
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|Document Files (*.pdf;*.doc;*.docx)|*.pdf;*.doc;*.docx|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblAttachmentPath.Text = openFileDialog.FileName;
                    UpdateProgress();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }
            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus();
                return;
            }

            IssueReport report = new IssueReport
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                AttachmentPath = lblAttachmentPath.Text == "No file attached" ? null : lblAttachmentPath.Text
            };

            ReportStorage.Reports.Add(report);

            MessageBox.Show("Thank you! Your report has been submitted.\nReference Number: " + Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                "Report Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblAttachmentPath.Text = "No file attached";
            progressEngagement.Value = 0;
            lblEngagement.Text = "Let's report an issue!";
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e) => UpdateProgress();
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) => UpdateProgress();
        private void rtbDescription_TextChanged(object sender, EventArgs e) => UpdateProgress();
    }
}