using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.ShowDialog();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm eventsForm = new LocalEventsForm();
            eventsForm.ShowDialog();
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status will be implemented in a later task.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}