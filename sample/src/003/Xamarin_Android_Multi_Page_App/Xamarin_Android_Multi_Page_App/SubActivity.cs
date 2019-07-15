using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Xamarin_Android_Multi_Page_App
{
    [Activity(Label = "SubActivity", MainLauncher = true)]
    public class SubActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // レイアウトファイルはSub.axml
            SetContentView(Resource.Layout.Sub);   // <--追加
        }
    }
}


