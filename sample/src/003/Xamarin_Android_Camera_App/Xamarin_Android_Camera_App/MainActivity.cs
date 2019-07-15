using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Xamarin_Android_Camera_App
{
    [Activity(Label = "Xamarin_Android_Camera_App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                Intent intent = new Intent(Android.Provider.MediaStore.ActionImageCapture);

                StartActivityForResult(intent, 0);
            };
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Bitmapデータを取得する
            Android.Graphics.Bitmap bitmap = (Android.Graphics.Bitmap)data.Extras.Get("data");

            // ImageViewコントロールを取得する
            ImageView image = FindViewById<ImageView>(Resource.Id.imageView1);

            // ImageViewにBitmapデータをセットする
            image.SetImageBitmap(bitmap);

        }
    }
}

