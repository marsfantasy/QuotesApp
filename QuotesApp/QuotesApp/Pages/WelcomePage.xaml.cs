using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            //BindingContext = new WelcomePageModel();
        }
    }
}