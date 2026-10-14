using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private CheckBox chkUseDate;
        private DateTimePicker dtpFilterDate;
        private Button btnSearch;
        private Button btnClear;
        private Label lblResultCount;

        private ListView lvEvents;
        private ColumnHeader colTitle;
        private ColumnHeader colCategory;
        private ColumnHeader colDate;
        private ColumnHeader colLocation;
        private ColumnHeader colPriority;

        private GroupBox grpRecommendations;
        private ListView lvRecommended;
        private ColumnHeader colRecTitle;
        private ColumnHeader colRecCategory;
        private ColumnHeader colRecDate;

        private GroupBox grpRecentlyViewed;
        private ListView lvRecentlyViewed;
        private ColumnHeader colRvTitle;
        private ColumnHeader colRvCategory;
        private ColumnHeader colRvDate;

        private Label lblSearched;
        private Button btnBack;

        // Add Event controls
        private GroupBox grpAddEvent;
        private Label lblNewTitle;
        private TextBox txtNewTitle;
        private Label lblNewCategory;
        private ComboBox cmbNewCategory;
        private Label lblNewPriority;
        private ComboBox cmbNewPriority;
        private Label lblNewDate;
        private DateTimePicker dtpNewDate;
        private Label lblNewLocation;
        private TextBox txtNewLocation;
        private Label lblNewDescription;
        private RichTextBox txtNewDescription;
        private Button btnAddEvent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.chkUseDate = new CheckBox();
            this.dtpFilterDate = new DateTimePicker();
            this.btnSearch = new Button();
            this.btnClear = new Button();
            this.lblResultCount = new Label();

            this.lvEvents = new ListView();
            this.colTitle = new ColumnHeader();
            this.colCategory = new ColumnHeader();
            this.colDate = new ColumnHeader();
            this.colLocation = new ColumnHeader();
            this.colPriority = new ColumnHeader();

            this.grpRecommendations = new GroupBox();
            this.lvRecommended = new ListView();
            this.colRecTitle = new ColumnHeader();
            this.colRecCategory = new ColumnHeader();
            this.colRecDate = new ColumnHeader();

            this.grpRecentlyViewed = new GroupBox();
            this.lvRecentlyViewed = new ListView();
            this.colRvTitle = new ColumnHeader();
            this.colRvCategory = new ColumnHeader();
            this.colRvDate = new ColumnHeader();

            this.lblSearched = new Label();
            this.btnBack = new Button();

            this.grpAddEvent = new GroupBox();
            this.lblNewTitle = new Label();
            this.txtNewTitle = new TextBox();
            this.lblNewCategory = new Label();
            this.cmbNewCategory = new ComboBox();
            this.lblNewPriority = new Label();
            this.cmbNewPriority = new ComboBox();
            this.lblNewDate = new Label();
            this.dtpNewDate = new DateTimePicker();
            this.lblNewLocation = new Label();
            this.txtNewLocation = new TextBox();
            this.lblNewDescription = new Label();
            this.txtNewDescription = new RichTextBox();
            this.btnAddEvent = new Button();

            this.grpRecommendations.SuspendLayout();
            this.grpRecentlyViewed.SuspendLayout();
            this.grpAddEvent.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(320, 22);
            this.lblTitle.Text = "Local Events and Announcements";

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new Point(18, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(55, 13);
            this.lblCategory.Text = "Category:";

            // cmbCategory
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new Point(80, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new Size(160, 21);

            // chkUseDate
            this.chkUseDate.AutoSize = true;
            this.chkUseDate.Location = new Point(260, 49);
            this.chkUseDate.Name = "chkUseDate";
            this.chkUseDate.Size = new Size(85, 17);
            this.chkUseDate.Text = "Filter by date";
            this.chkUseDate.CheckedChanged += new System.EventHandler(this.chkUseDate_CheckedChanged);

            // dtpFilterDate
            this.dtpFilterDate.Enabled = false;
            this.dtpFilterDate.Format = DateTimePickerFormat.Short;
            this.dtpFilterDate.Location = new Point(350, 47);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new Size(130, 20);

            // btnSearch
            this.btnSearch.Location = new Point(495, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(90, 25);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnClear
            this.btnClear.Location = new Point(590, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(75, 25);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResultCount
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.ForeColor = Color.DimGray;
            this.lblResultCount.Location = new Point(18, 80);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new Size(90, 13);
            this.lblResultCount.Text = "0 event(s) found";

            // lvEvents
            this.lvEvents.Columns.AddRange(new ColumnHeader[] {
                this.colTitle, this.colCategory, this.colDate, this.colLocation, this.colPriority });
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.HideSelection = false;
            this.lvEvents.Location = new Point(18, 100);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new Size(650, 320);
            this.lvEvents.TabIndex = 5;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = View.Details;
            this.lvEvents.DoubleClick += new System.EventHandler(this.lvEvents_DoubleClick);

            // columns
            this.colTitle.Text = "Title"; this.colTitle.Width = 200;
            this.colCategory.Text = "Category"; this.colCategory.Width = 110;
            this.colDate.Text = "Date"; this.colDate.Width = 100;
            this.colLocation.Text = "Location"; this.colLocation.Width = 140;
            this.colPriority.Text = "Priority"; this.colPriority.Width = 80;

            // grpRecommendations
            this.grpRecommendations.Controls.Add(this.lvRecommended);
            this.grpRecommendations.Location = new Point(685, 100);
            this.grpRecommendations.Name = "grpRecommendations";
            this.grpRecommendations.Size = new Size(300, 200);
            this.grpRecommendations.Text = "Recommended for You";

            // lvRecommended
            this.lvRecommended.Columns.AddRange(new ColumnHeader[] {
                this.colRecTitle, this.colRecCategory, this.colRecDate });
            this.lvRecommended.Dock = DockStyle.Fill;
            this.lvRecommended.FullRowSelect = true;
            this.lvRecommended.GridLines = true;
            this.lvRecommended.HideSelection = false;
            this.lvRecommended.View = View.Details;
            this.lvRecommended.DoubleClick += new System.EventHandler(this.lvEvents_DoubleClick);

            this.colRecTitle.Text = "Event"; this.colRecTitle.Width = 150;
            this.colRecCategory.Text = "Category"; this.colRecCategory.Width = 90;
            this.colRecDate.Text = "Date"; this.colRecDate.Width = 55;

            // grpRecentlyViewed
            this.grpRecentlyViewed.Controls.Add(this.lvRecentlyViewed);
            this.grpRecentlyViewed.Location = new Point(685, 310);
            this.grpRecentlyViewed.Name = "grpRecentlyViewed";
            this.grpRecentlyViewed.Size = new Size(300, 150);
            this.grpRecentlyViewed.Text = "Recently Viewed";

            // lvRecentlyViewed
            this.lvRecentlyViewed.Columns.AddRange(new ColumnHeader[] {
                this.colRvTitle, this.colRvCategory, this.colRvDate });
            this.lvRecentlyViewed.Dock = DockStyle.Fill;
            this.lvRecentlyViewed.FullRowSelect = true;
            this.lvRecentlyViewed.GridLines = true;
            this.lvRecentlyViewed.HideSelection = false;
            this.lvRecentlyViewed.View = View.Details;

            this.colRvTitle.Text = "Event"; this.colRvTitle.Width = 150;
            this.colRvCategory.Text = "Category"; this.colRvCategory.Width = 90;
            this.colRvDate.Text = "Date"; this.colRvDate.Width = 55;

            // lblSearched
            this.lblSearched.AutoSize = true;
            this.lblSearched.Font = new Font("Arial", 8.5F, FontStyle.Italic);
            this.lblSearched.ForeColor = Color.DimGray;
            this.lblSearched.Location = new Point(18, 430);
            this.lblSearched.Name = "lblSearched";
            this.lblSearched.Size = new Size(150, 14);
            this.lblSearched.Text = "Top searches: none yet";

            // btnBack
            this.btnBack.Location = new Point(900, 425);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(85, 28);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // grpAddEvent
            this.grpAddEvent.Controls.Add(this.lblNewTitle);
            this.grpAddEvent.Controls.Add(this.txtNewTitle);
            this.grpAddEvent.Controls.Add(this.lblNewCategory);
            this.grpAddEvent.Controls.Add(this.cmbNewCategory);
            this.grpAddEvent.Controls.Add(this.lblNewPriority);
            this.grpAddEvent.Controls.Add(this.cmbNewPriority);
            this.grpAddEvent.Controls.Add(this.lblNewDate);
            this.grpAddEvent.Controls.Add(this.dtpNewDate);
            this.grpAddEvent.Controls.Add(this.lblNewLocation);
            this.grpAddEvent.Controls.Add(this.txtNewLocation);
            this.grpAddEvent.Controls.Add(this.lblNewDescription);
            this.grpAddEvent.Controls.Add(this.txtNewDescription);
            this.grpAddEvent.Controls.Add(this.btnAddEvent);
            this.grpAddEvent.Location = new Point(18, 455);
            this.grpAddEvent.Name = "grpAddEvent";
            this.grpAddEvent.Size = new Size(650, 180);
            this.grpAddEvent.Text = "Add New Event";

            // lblNewTitle
            this.lblNewTitle.AutoSize = true;
            this.lblNewTitle.Location = new Point(10, 25);
            this.lblNewTitle.Size = new Size(30, 13);
            this.lblNewTitle.Text = "Title:";

            // txtNewTitle
            this.txtNewTitle.Location = new Point(80, 22);
            this.txtNewTitle.Name = "txtNewTitle";
            this.txtNewTitle.Size = new Size(200, 20);

            // lblNewCategory
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Location = new Point(300, 25);
            this.lblNewCategory.Size = new Size(55, 13);
            this.lblNewCategory.Text = "Category:";

            // cmbNewCategory
            this.cmbNewCategory.DropDownStyle = ComboBoxStyle.DropDown;
            this.cmbNewCategory.Location = new Point(365, 22);
            this.cmbNewCategory.Name = "cmbNewCategory";
            this.cmbNewCategory.Size = new Size(130, 21);

            // lblNewPriority
            this.lblNewPriority.AutoSize = true;
            this.lblNewPriority.Location = new Point(510, 25);
            this.lblNewPriority.Size = new Size(42, 13);
            this.lblNewPriority.Text = "Priority:";

            // cmbNewPriority
            this.cmbNewPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbNewPriority.Items.AddRange(new object[] { "High", "Medium", "Low" });
            this.cmbNewPriority.Location = new Point(560, 22);
            this.cmbNewPriority.Name = "cmbNewPriority";
            this.cmbNewPriority.Size = new Size(80, 21);
            this.cmbNewPriority.SelectedIndex = 1;

            // lblNewDate
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Location = new Point(10, 55);
            this.lblNewDate.Size = new Size(33, 13);
            this.lblNewDate.Text = "Date:";

            // dtpNewDate
            this.dtpNewDate.Format = DateTimePickerFormat.Short;
            this.dtpNewDate.Location = new Point(80, 52);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new Size(200, 20);

            // lblNewLocation
            this.lblNewLocation.AutoSize = true;
            this.lblNewLocation.Location = new Point(300, 55);
            this.lblNewLocation.Size = new Size(51, 13);
            this.lblNewLocation.Text = "Location:";

            // txtNewLocation
            this.txtNewLocation.Location = new Point(365, 52);
            this.txtNewLocation.Name = "txtNewLocation";
            this.txtNewLocation.Size = new Size(275, 20);

            // lblNewDescription
            this.lblNewDescription.AutoSize = true;
            this.lblNewDescription.Location = new Point(10, 85);
            this.lblNewDescription.Size = new Size(63, 13);
            this.lblNewDescription.Text = "Description:";

            // txtNewDescription
            this.txtNewDescription.Location = new Point(80, 82);
            this.txtNewDescription.Name = "txtNewDescription";
            this.txtNewDescription.Size = new Size(560, 60);

            // btnAddEvent
            this.btnAddEvent.Location = new Point(535, 148);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new Size(105, 25);
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);

            // LocalEventsForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 650);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.chkUseDate);
            this.Controls.Add(this.dtpFilterDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.lvEvents);
            this.Controls.Add(this.grpRecommendations);
            this.Controls.Add(this.grpRecentlyViewed);
            this.Controls.Add(this.lblSearched);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpAddEvent);
            this.MinimumSize = new Size(900, 600);
            this.Name = "LocalEventsForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Local Events and Announcements";

            this.grpRecommendations.ResumeLayout(false);
            this.grpRecentlyViewed.ResumeLayout(false);
            this.grpAddEvent.ResumeLayout(false);
            this.grpAddEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}