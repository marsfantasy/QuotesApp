using FreshMvvm;
using QuotesApp.PageModels;
using Xamarin.Forms;

namespace QuotesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new WelcomPage();
            MainPage = FreshPageModelResolver.ResolvePageModel<WelcomePageModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}