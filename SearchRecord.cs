using System;

namespace MunicipalServicesApp
{
    public class SearchRecord
    {
        public string Category { get; set; }
        public DateTime? DateFilter { get; set; }
        public DateTime Timestamp { get; set; }

        public SearchRecord()
        {
            Timestamp = DateTime.Now;
        }
    }
}