using FreshMvvm;
using QuotesApp.Interfaces;
using QuotesApp.Models;
using QuotesApp.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuotesApp.PageModels
{
    public class QuotesListPageModel : FreshBasePageModel
    {
        public Category Category;
        public ObservableCollection<Quote> Quotes { get; set; }
        private IRestService _restService;

        public QuotesListPageModel(IRestService restService)
        {
            _restService = restService;
            Quotes = new ObservableCollection<Quote>();
        }

        public override async void Init(object initData)
        {
            base.Init(initData);
            Category = (Category)initData;
            var quotes = await _restService.GetQuotes(Category.Title);
            foreach (var quote in quotes)
            {
                Quotes.Add(quote);
            }
        }

        private Quote selectedQuote;

        public Quote SelectedQuote
        {
            get { return selectedQuote; }
            set
            {
                selectedQuote = value;
                if (selectedQuote != null)
                {
                    CoreMethods.PushPageModel<QuoteDetailPageModel>(selectedQuote);
                }
            }
        }
    }
}