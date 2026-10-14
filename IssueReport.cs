using System;
using System.Collections.Generic;

namespace MunicipalServicesApp
{
    public class IssueReport
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachmentPath { get; set; }
        public DateTime ReportDate { get; set; }
        public string Status { get; set; }

        public IssueReport()
        {
            ReportDate = DateTime.Now;
            Status = "Logged";
        }
    }

    public static class ReportStorage
    {
        public static List<IssueReport> Reports = new List<IssueReport>();
    }
}