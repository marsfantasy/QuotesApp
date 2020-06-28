using FreshMvvm;
using QuotesApp.Interfaces;
using QuotesApp.PageModels;
using QuotesApp.Services;
using Xamarin.Forms;

namespace QuotesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FreshIOC.Container.Register<IRestService, RestServices>();

            var mainPage = FreshPageModelResolver.ResolvePageModel<CategoryPageModel>();
            var navigationContainer = new FreshNavigationContainer(mainPage);
            MainPage = navigationContainer;
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