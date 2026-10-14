using System;

namespace MunicipalServicesApp
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }

        // 1 = High, 2 = Medium, 3 = Low
        public int Priority { get; set; }

        public override string ToString()
        {
            return Title + " (" + EventDate.ToShortDateString() + ")";
        }
    }
}