﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms_Multi_Page
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // 上部のバーを消す
            // 消したいページ毎に実行する必要がある
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // SubPageに遷移する
            Navigation.PushAsync(new SubPage());

            // このようにMainPageプロパティに遷移したいページを渡すことで画面を切り替えることができる
            // この場合NavigationPageのように遷移したページをスタックしないので、前のページに戻る処理などは自前で管理する必要がある
            //App.Current.MainPage = new SubPage();
        }
    }
}
