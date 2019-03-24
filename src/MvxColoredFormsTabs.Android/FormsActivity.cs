
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Forms.Platforms.Android.Core;

namespace MvxColoredFormsTabs.Droid
{
    [Activity(Label = "MvxColoredFormsTabs", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class FormsActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<CoreApp, App>, CoreApp, App>
    {
    }
}