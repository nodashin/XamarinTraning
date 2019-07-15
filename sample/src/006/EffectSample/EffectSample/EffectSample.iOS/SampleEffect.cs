using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("EffectSample")]
[assembly: ExportEffect(typeof(EffectSample.iOS.SampleEffect), "SampleEffect")]
namespace EffectSample.iOS
{
    class SampleEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var label = (UILabel)Control;

            label.Text = "‚±‚ê‚ÍiOS‚Å‚·";
        }

        protected override void OnDetached()
        {
        }
    }
}