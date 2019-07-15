using AVFoundation;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using UIKit;

namespace XamarinIosCameraSample
{
    public partial class ViewController : UIViewController
    {
        private UIImagePickerController _picker;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // フロントカメラが利用可能か確認する
            if (UIImagePickerController.IsCameraDeviceAvailable(UIImagePickerControllerCameraDevice.Front) == true)
            {
                // カメラを利用するにはUIImagePickerControllerを利用する
                _picker = new UIImagePickerController();

                // ソースはカメラで、編集を許可する
                _picker.SourceType = UIImagePickerControllerSourceType.Camera;
                _picker.AllowsEditing = true;

                // 画像が撮影され終えた際のイベントハンドラーを設定する
                _picker.FinishedPickingMedia += _picker_FinishedPickingMedia;

                // カメラ撮影がキャンセルされた際のイベントハンドラーを設定する
                _picker.Canceled += _picker_Canceled;
            }

        }

        // Take Photoボタンが押された
        partial void takeButtonClick(UIKit.UIButton sender)
        {
            // カメラ撮影を開始する
            this.PresentViewController(_picker, true, null);
        }


        private void _picker_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            // 取得した画像をImageViewにセットする
            this.image.Image = e.Info[UIImagePickerController.OriginalImage] as UIImage;

            // 元の表示に戻る
            this.DismissModalViewController(true);
        }

        private void _picker_Canceled(object sender, EventArgs e)
        {
            // 元の表示に戻る
            this.DismissModalViewController(true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}