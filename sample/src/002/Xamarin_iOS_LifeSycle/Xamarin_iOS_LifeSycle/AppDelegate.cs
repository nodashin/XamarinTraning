using Foundation;
using System.Diagnostics;
using UIKit;

namespace Xamarin_iOS_LifeSycle
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Debug.WriteLine("AppDelegate::FinishedLaunching");
            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            Debug.WriteLine("AppDelegate::OnResignActivation");

        }

        public override void DidEnterBackground(UIApplication application)
        {
            Debug.WriteLine("AppDelegate::DidEnterBackground");

        }

        public override void WillEnterForeground(UIApplication application)
        {
            Debug.WriteLine("AppDelegate::WillEnterForeground");

        }

        public override void OnActivated(UIApplication application)
        {
            Debug.WriteLine("AppDelegate::OnActivated");
        }

        public override void WillTerminate(UIApplication application)
        {
            Debug.WriteLine("AppDelegate::WillTerminate");
        }
    }
}