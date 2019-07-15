using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using RssXamarinSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RssXamarinSample.ViewModels
{
    public class DetailPageViewModel : BindableBase, INavigationAware
    {
        private string _title;

        public string title
        {
            set
            {
                SetProperty(ref _title, value);
            }
            get
            {
                return this._title;
            }
        }

        private string _description;
        public string description
        {
            set
            {
                SetProperty(ref _description, value);
            }
            get
            {
                return this._description;
            }
        }


        public DetailPageViewModel()
        {

        }
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            var article = parameters["article"] as Article;

            this.title = article.title;
            this.description = article.description;
        }
    }
}
