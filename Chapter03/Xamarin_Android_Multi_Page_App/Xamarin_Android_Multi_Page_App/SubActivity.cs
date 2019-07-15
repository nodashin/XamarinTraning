using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Xamarin_Android_Multi_Page_App
{
    [Activity(Label = "SubActivity")]
    public class SubActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //レイアウトファイルはSub.axml
            SetContentView(Resource.Layout.Sub);
        }
    }
}