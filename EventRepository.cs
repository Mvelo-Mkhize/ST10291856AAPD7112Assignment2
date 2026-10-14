using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp
{
    public class EventRepository
    {
        private static EventRepository _instance;
        public static EventRepository Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EventRepository();
                return _instance;
            }
        }

        public SortedDictionary<DateTime, List<Event>> EventsByDate { get; private set; }

        public Dictionary<string, List<Event>> EventsByCategory { get; private set; }

        public HashSet<string> UniqueCategories { get; private set; }

        public HashSet<DateTime> UniqueDates { get; private set; }

        public SimplePriorityQueue<Event> PriorityEvents { get; private set; }

        public Queue<SearchRecord> RecentSearches { get; private set; }

        public Stack<Event> RecentlyViewed { get; private set; }

        public Dictionary<string, int> CategorySearchCounts { get; private set; }

        public HashSet<int> ViewedEventIds { get; private set; }

        public List<Event> AllEvents { get; private set; }

        private int _nextId = 1;

        private EventRepository()
        {
            EventsByDate = new SortedDictionary<DateTime, List<Event>>();
            EventsByCategory = new Dictionary<string, List<Event>>(StringComparer.OrdinalIgnoreCase);
            UniqueCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            UniqueDates = new HashSet<DateTime>();
            PriorityEvents = new SimplePriorityQueue<Event>();
            RecentSearches = new Queue<SearchRecord>();
            RecentlyViewed = new Stack<Event>();
            CategorySearchCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            ViewedEventIds = new HashSet<int>();
            AllEvents = new List<Event>();

        }

        public int NextId()
        {
            return _nextId++;
        }

        public void AddEvent(Event ev)
        {
            if (ev == null) return;
            if (ev.Id == 0) ev.Id = NextId();

            AllEvents.Add(ev);

            DateTime day = ev.EventDate.Date;
            if (!EventsByDate.ContainsKey(day))
                EventsByDate[day] = new List<Event>();
            EventsByDate[day].Add(ev);

            if (!EventsByCategory.ContainsKey(ev.Category))
                EventsByCategory[ev.Category] = new List<Event>();
            EventsByCategory[ev.Category].Add(ev);

            UniqueCategories.Add(ev.Category);
            UniqueDates.Add(day);

            PriorityEvents.Enqueue(ev, ev.Priority);
        }

        public List<Event> Search(string category, DateTime? date)
        {
            IEnumerable<Event> results = AllEvents;

            if (!string.IsNullOrEmpty(category) && !category.Equals("All", StringComparison.OrdinalIgnoreCase))
                results = results.Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase));

            if (date.HasValue)
                results = results.Where(e => e.EventDate.Date == date.Value.Date);

            var record = new SearchRecord { Category = category, DateFilter = date };
            RecentSearches.Enqueue(record);
            while (RecentSearches.Count > 20)
                RecentSearches.Dequeue();

            if (!string.IsNullOrEmpty(category) && !category.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                if (!CategorySearchCounts.ContainsKey(category))
                    CategorySearchCounts[category] = 0;
                CategorySearchCounts[category]++;
            }

            return results.OrderBy(e => e.EventDate).ToList();
        }

        public void MarkAsViewed(Event ev)
        {
            if (ev == null) return;
            ViewedEventIds.Add(ev.Id);
            RecentlyViewed.Push(ev);
            if (RecentlyViewed.Count > 10)
            {
                var kept = RecentlyViewed.Take(10).Reverse().ToList();
                RecentlyViewed.Clear();
                foreach (var e in kept)
                    RecentlyViewed.Push(e);
            }
        }

        public List<Event> GetRecommendations(int topN)
        {
            var candidates = AllEvents
                .Where(e => !ViewedEventIds.Contains(e.Id) && e.EventDate.Date >= DateTime.Today)
                .Select(e => new
                {
                    Event = e,
                    Score =
                        (CategorySearchCounts.ContainsKey(e.Category) ? CategorySearchCounts[e.Category] : 0) * 10
                        + (e.Priority == 1 ? 30 : e.Priority == 2 ? 20 : 10)
                        + Math.Max(0, 25 - (int)(e.EventDate.Date - DateTime.Today).TotalDays)
                })
                .OrderByDescending(x => x.Score)
                .ThenBy(x => x.Event.EventDate)
                .Take(topN)
                .Select(x => x.Event)
                .ToList();

            return candidates;
        }
    }
}