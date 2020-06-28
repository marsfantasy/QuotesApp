using FreshMvvm;
using QuotesApp.Interfaces;
using QuotesApp.Models;
using QuotesApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuotesApp.PageModels
{
    public class CategoryPageModel : FreshBasePageModel
    {
        public ObservableCollection<Category> Categories { get; set; }
        private IRestService _restService;

        //ctor
        public CategoryPageModel(IRestService restService)
        {
            _restService = restService;
            Categories = new ObservableCollection<Category>();
            LoadCategories();
        }

        /// <summary>
        ///
        /// </summary>
        private async void LoadCategories()
        {
            var categories = await _restService.GetCategories();
            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }

        private Category selectedCategory;

        public Category SelectedCategory
        {
            get { return selectedCategory; }
            set
            {
                selectedCategory = value;
                if (selectedCategory != null)
                {
                    CoreMethods.PushPageModel<QuotesListPageModel>(selectedCategory);
                }
            }
        }
    }
}