using FreshMvvm;
using QuotesApp.Pages;
using Xamarin.Forms;

namespace QuotesApp.PageModels
{
    public class WelcomePageModel : FreshBasePageModel
    {
        public Command SignInCommand { get; set; }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                RaisePropertyChanged();
            }
        }

        public WelcomePageModel()
        {
            SignInCommand = new Command(SignIn);
        }

        private void SignIn()
        {
            //var user = UserName;
            //CoreMethods.DisplayAlert("Hi", UserName, "Cancel");
            CoreMethods.PushPageModel<HomePageModel>(UserName);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
            var message = returnedData;
        }
    }
}