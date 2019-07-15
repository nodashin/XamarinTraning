using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Xamarin_Android_Multi_Page_App
{
    [Activity(Label = "Xamarin_Android_Multi_Page_App", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);


            //イベントハンドラーを変更する。
            //delegateキーワードを使わず別メソッドとしてイベントハンドラーを用意する。
            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            //新しいActivityを開始する。
            Intent intent = new Intent(this, typeof(SubActivity));
            StartActivity(intent);
        }
    }
}

