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

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("EffectSample")]
[assembly: ExportEffect(typeof(EffectSample.Droid.SampleEffect), "SampleEffect")]
namespace EffectSample.Droid
{
    class SampleEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var label = (TextView)Control;

            label.Text = "‚±‚ê‚ÍAndroid‚Å‚·";
        }

        protected override void OnDetached()
        {
        }
    }
}