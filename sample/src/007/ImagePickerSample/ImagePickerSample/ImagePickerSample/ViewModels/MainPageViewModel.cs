using Plugin.Media;
using Plugin.Media.Abstractions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ImagePickerSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private MediaFile _photo;

        private ImageSource _imageSource;

        public ImageSource imageSource
        {
            get { return _imageSource; }
            set { SetProperty(ref _imageSource, value); }
        }

        public MainPageViewModel()
        {
            // Commandを設定する
            selectImageCommand = new DelegateCommand(selectImage);
        }

        public DelegateCommand selectImageCommand { get; set; }

        // Commandの実装
        private async void selectImage()
        {
            if (CrossMedia.Current.IsPickPhotoSupported)
            {
                this._photo = await CrossMedia.Current.PickPhotoAsync();
                this.imageSource = ImageSource.FromStream(() => this._photo.GetStream());
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
