using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace MvxColoredFormsTabs.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<CoreApp, App>, CoreApp, App>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var result = base.FinishedLaunching(app, options);


            //UITabBar.Appearance.TintColor = UIColor.Black;
            // Color of the selected tab icon:
            //UITabBar.Appearance.SelectedImageTintColor = UIColor.Green;
            //UITabBar.Appearance.BarTintColor = UIColor.Green;
            UITabBar.Appearance.TintColor = UIColor.Green;

            UITabBarItem.Appearance.SetTitleTextAttributes(
                new UITextAttributes()
                {
                    TextColor = UIColor.Green
                },
                UIControlState.Selected);

            // Color of the unselected tab icon & text:
            UITabBarItem.Appearance.SetTitleTextAttributes(
                new UITextAttributes()
                {
                    TextColor = UIColor.Gray

                },
                UIControlState.Normal);


            global::Xamarin.Forms.FormsMaterial.Init();

            return result;

        }
    }
}
