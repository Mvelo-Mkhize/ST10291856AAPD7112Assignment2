using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        private readonly EventRepository _repo = EventRepository.Instance;

        public LocalEventsForm()
        {
            InitializeComponent();
            PopulateCategories();
            LoadAllEvents();
            UpdateRecommendations();
            UpdateRecentlyViewed();
        }

        private void PopulateCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            foreach (string cat in _repo.UniqueCategories.OrderBy(c => c))
                cmbCategory.Items.Add(cat);

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            cmbNewCategory.Items.Clear();
            foreach (string cat in _repo.UniqueCategories.OrderBy(c => c))
                cmbNewCategory.Items.Add(cat);
        }

        private void LoadAllEvents()
        {
            lvEvents.Items.Clear();
            foreach (var ev in _repo.AllEvents.OrderBy(e => e.EventDate))
                AddEventToListView(lvEvents, ev);

            lblResultCount.Text = _repo.AllEvents.Count + " event(s) found";
        }

        private void AddEventToListView(ListView lv, Event ev)
        {
            var item = new ListViewItem(ev.Title);
            item.SubItems.Add(ev.Category);
            item.SubItems.Add(ev.EventDate.ToString("dd MMM yyyy"));
            item.SubItems.Add(ev.Location);
            item.SubItems.Add(PriorityText(ev.Priority));
            item.Tag = ev;

            if (ev.Priority == 1)
                item.ForeColor = Color.DarkRed;
            else if (ev.Priority == 2)
                item.ForeColor = Color.DarkOrange;

            lv.Items.Add(item);
        }

        private string PriorityText(int p)
        {
            if (p == 1) return "High";
            if (p == 2) return "Medium";
            return "Low";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.SelectedItem as string;
            DateTime? date = chkUseDate.Checked ? (DateTime?)dtpFilterDate.Value.Date : null;

            List<Event> results = _repo.Search(category, date);

            lvEvents.Items.Clear();
            foreach (var ev in results)
                AddEventToListView(lvEvents, ev);

            lblResultCount.Text = results.Count + " event(s) found";

            if (results.Count == 0)
                MessageBox.Show("No events matched your search criteria.",
                    "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateRecommendations();
            UpdateRecentlyViewed();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
            chkUseDate.Checked = false;
            LoadAllEvents();
        }

        private void chkUseDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterDate.Enabled = chkUseDate.Checked;
        }

        private void lvEvents_DoubleClick(object sender, EventArgs e)
        {
            if (lvEvents.SelectedItems.Count == 0) return;
            var ev = lvEvents.SelectedItems[0].Tag as Event;
            if (ev == null) return;

            _repo.MarkAsViewed(ev);
            UpdateRecentlyViewed();
            UpdateRecommendations();

            MessageBox.Show(
                ev.Title + "\n\n" +
                "Category:  " + ev.Category + "\n" +
                "Date:      " + ev.EventDate.ToString("dddd, dd MMMM yyyy") + "\n" +
                "Location:  " + ev.Location + "\n" +
                "Priority:  " + PriorityText(ev.Priority) + "\n\n" +
                ev.Description,
                "Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewTitle.Text))
            {
                MessageBox.Show("Please enter an event title.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbNewCategory.Text))
            {
                MessageBox.Show("Please enter or select a category.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int priority = 3;
            if (cmbNewPriority.SelectedItem != null)
            {
                string p = cmbNewPriority.SelectedItem.ToString();
                if (p == "High") priority = 1;
                else if (p == "Medium") priority = 2;
            }

            var ev = new Event
            {
                Title = txtNewTitle.Text.Trim(),
                Category = cmbNewCategory.Text.Trim(),
                Description = txtNewDescription.Text.Trim(),
                EventDate = dtpNewDate.Value.Date,
                Location = txtNewLocation.Text.Trim(),
                Priority = priority
            };

            _repo.AddEvent(ev);

            PopulateCategories();
            LoadAllEvents();
            UpdateRecommendations();

            txtNewTitle.Clear();
            cmbNewCategory.Text = "";
            txtNewDescription.Clear();
            txtNewLocation.Clear();
            if (cmbNewPriority.Items.Count > 0)
                cmbNewPriority.SelectedIndex = 1;

            MessageBox.Show("Event added successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateRecommendations()
        {
            lvRecommended.Items.Clear();
            List<Event> recs = _repo.GetRecommendations(5);
            foreach (var ev in recs)
            {
                var item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Category);
                item.SubItems.Add(ev.EventDate.ToString("dd MMM"));
                item.Tag = ev;
                lvRecommended.Items.Add(item);
            }

            if (recs.Count == 0)
            {
                var empty = new ListViewItem("Search for events to get recommendations");
                empty.ForeColor = Color.Gray;
                lvRecommended.Items.Add(empty);
            }
        }

        private void UpdateRecentlyViewed()
        {
            lvRecentlyViewed.Items.Clear();
            foreach (var ev in _repo.RecentlyViewed)
            {
                var item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Category);
                item.SubItems.Add(ev.EventDate.ToString("dd MMM"));
                lvRecentlyViewed.Items.Add(item);
            }

            if (_repo.RecentlyViewed.Count == 0)
            {
                var empty = new ListViewItem("Nothing viewed yet");
                empty.ForeColor = Color.Gray;
                lvRecentlyViewed.Items.Add(empty);
            }

            lblSearched.Text = "Top searches: " +
                (_repo.CategorySearchCounts.Count == 0
                    ? "none yet"
                    : string.Join(", ", _repo.CategorySearchCounts
                        .OrderByDescending(kv => kv.Value)
                        .Take(3)
                        .Select(kv => kv.Key + " (" + kv.Value + ")")));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}