//using句 Androidから始まるAndroid用の名前空間が多数読み込まれている。
using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloXamarin_Android
{
    //属性。ActivityAttributeクラス参照
    //MainLauncher = trueでこのクラスがアプリケーション起動時に
    //呼び出されるクラスであることを示している。
    [Activity(Label = "HelloXamarin_Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        //Activity生成時に呼び出されるOnCreateメソッド
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            //Resources.Layout.Mainを指定することでMain.xamlの内容が表示される。
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //FindViewByIdでIDを元にMain.xamlからButtonコントロールを取得している。
            Button button = FindViewById<Button>(Resource.Id.myButton);

            //ボタンがクリックされた際のイベントをデリゲート(delegte)を使って指定している。
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

