using FreshMvvm;
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

        //ctor
        public CategoryPageModel()
        {
            Categories = new ObservableCollection<Category>();
            LoadCategories();
        }

        /// <summary>
        ///
        /// </summary>
        private async void LoadCategories()
        {
            var restServices = new RestServices();
            var categories = await restServices.GetCategories();
            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }
    }
}