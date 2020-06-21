using FreshMvvm;
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
            var user = UserName;
        }
    }
}