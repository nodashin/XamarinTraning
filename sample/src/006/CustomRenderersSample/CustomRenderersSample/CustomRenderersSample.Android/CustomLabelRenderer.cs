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

// à»â∫ÇÃ2çsÇÃusingÇí«â¡
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomRenderersSample.CustomLabel), typeof(CustomRenderersSample.Droid.CustomLabelRenderer))]
namespace CustomRenderersSample.Droid
{
    class CustomLabelRenderer : Xamarin.Forms.Platform.Android.LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var label = (CustomLabel)Element;

            label.customText = "Android";
        }
    }
}