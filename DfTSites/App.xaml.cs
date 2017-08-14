using Xamarin.Forms;



namespace DfTSites
{
    public partial class App : Application
    {
        static SiteDB db;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DfTSitesPage());
        }

        public static SiteDB DB
        {
            get
            {
                // if (db == null) 
                // {
                db = new SiteDB(DependencyService.Get<ISqliteDB>().GetLocalFilePath("DfTSites.sqlite"));

                //}
                return db;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }




    }

}
