using FreshMvvm;
using QuotesApp.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QuotesApp.PageModels
{
    public class HomePageModel : FreshBasePageModel
    {
        public Command GoBackCommand { get; set; }

        public HomePageModel()
        {
            GoBackCommand = new Command(GoBack);
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            string parameter = (string)initData;
        }

        private void GoBack()
        {
            CoreMethods.PopPageModel("Hello... I'm back");
        }
    }
}