using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

// 以下の2行のusingを追加
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomRenderersSample.CustomLabel), typeof(CustomRenderersSample.iOS.CustomLabelRenderer))]
namespace CustomRenderersSample.iOS
{
    class CustomLabelRenderer : Xamarin.Forms.Platform.iOS.LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var label = (CustomLabel)Element;

            label.customText = "iOS";
        }
    }
}