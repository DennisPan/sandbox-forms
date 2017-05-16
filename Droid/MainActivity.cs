using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Distribute;
using Microsoft.WindowsAzure.MobileServices;

namespace SandboxForms.Droid
{
    [Activity(Label = "SandboxForms.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static MobileServiceClient MobileService = new MobileServiceClient("https://sandboxforms.azurewebsites.net");

        protected override void OnCreate(Bundle bundle)
        {
            CurrentPlatform.Init();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

			MobileCenter.Start("0ed89836-e6fb-4fee-b7a3-218b1bb59108",
				   typeof(Analytics), typeof(Crashes), typeof(Distribute), typeof(Microsoft.Azure.Mobile.Push.Push));

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}