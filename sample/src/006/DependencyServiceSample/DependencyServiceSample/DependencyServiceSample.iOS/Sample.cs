using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DependencyServiceSample.iOS.Sample))]
namespace DependencyServiceSample.iOS
{
    class Sample : ISample
    {
        public string getOSName()
        {
            return "iOSÇ≈Ç∑ÅB";
        }
    }
}