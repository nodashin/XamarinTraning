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
using DependencyServiceSample;

[assembly: Xamarin.Forms.Dependency(typeof(DependencyServiceSample.Droid.Sample))]
namespace DependencyServiceSample.Droid
{
    class Sample : ISample
    {
        public string getOSName()
        {
            return "AndroidÇ≈Ç∑ÅB";
        }
    }
}