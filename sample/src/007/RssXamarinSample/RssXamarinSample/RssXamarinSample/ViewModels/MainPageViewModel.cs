using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using RssXamarinSample.Models;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Xml;

namespace RssXamarinSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public ObservableCollection<Article> articleList { set; get; }

        public MainPageViewModel()
        {
        }

        private readonly INavigationService navigationService;
        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            this.articleList = new ObservableCollection<Article>();

            listViewChangeCommand = new DelegateCommand<Article>(listViewChange);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStreamAsync("http://coelacanth.jp.net/feed/rss");

            StreamReader stream = new StreamReader(response);

            XmlReader reader = XmlReader.Create(stream);

            while (reader.Read())
            {
                // 要素なら処理を行う
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "item")
                    {
                        Article article = new Article();

                        reader.ReadToDescendant("title");
                        article.title = reader.ReadElementContentAsString();

                        reader.ReadToNextSibling("description");
                        article.description = reader.ReadElementContentAsString();

                        this.articleList.Add(article);

                    }
                }
            }
        }

        public DelegateCommand<Article> listViewChangeCommand { get; set; }
        private void listViewChange(Article article)
        {
            NavigationParameters param = new NavigationParameters();
            param.Add("article", article);

            this.navigationService.NavigateAsync("DetailPage", param);
        }
    }
}
