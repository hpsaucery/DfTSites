using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;
using System;
using System.IO;


namespace DfTSites
{

    public partial class DfTSitesPage : ContentPage
    {
        // private SQLiteAsyncConnection _connection;
        //private ObservableCollection<Site> _sites;

        // private ObservableCollection<Site> _sites;

        public DfTSitesPage()
        {
            InitializeComponent();
            this.Title = "DfT Site Locations";

            var toolbarAdd = new ToolbarItem
            {
                Text = "+"
            };

            toolbarAdd.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SiteDetails() { BindingContext = new Site() });
            };

            ToolbarItems.Add(toolbarAdd);
            //need to add to the page after initialising

            // db = DependencyService.Get<ISqliteDB>().GetConnection();

            //var connection = DependencyService.Get<ISqliteDB>().GetConnection(); 
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            SiteListView.ItemsSource = await App.DB.GetSitesAsync();

            //db.CreateTable<Site>();


            /*  await _db.CreateTableAsync<Site>();
              var sites = await _db.Table<Site>().ToListAsync();
              _sites = new ObservableCollection<Site>(sites);
              sitesListView.ItemsSource = _sites; */


        }

        async void ListView_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new SiteDetails() { BindingContext = e.SelectedItem as Site });
            }
        }

        async public void OnAdd(object sender, System.EventArgs e)
        {
            Site site0 = new Site { ID = 50, Name = "DVLA 111111" };
            await App.DB.SaveSiteAsync(site0);
            await Navigation.PopAsync();


        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            Site site2 = new Site { ID = 1, Name = "Update entry" };
            await App.DB.SaveSiteAsync(site2);
            await Navigation.PopAsync();
            /*var table = db.Table<Site>();

            foreach (var item in table)
            {
                Site site = new Site(item.ID, item.Name);

            }*/
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            Site site2 = new Site { ID = 2, Name = "Delete entry" };
            await App.DB.SaveSiteAsync(site2);
            await Navigation.PopAsync();

        }


        // Stream dbStream = a


    }


}