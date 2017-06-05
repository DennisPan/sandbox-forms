using Foundation;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Distribute;
using Microsoft.WindowsAzure.MobileServices;
using UIKit;

namespace SandboxForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public static MobileServiceClient MobileService = new MobileServiceClient("https://sandboxforms.azurewebsites.net");

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            CurrentPlatform.Init();
			MobileCenter.Start("31513391-7567-468b-85ac-7fb7b97d0e5b",
				   typeof(Analytics), typeof(Crashes), typeof(Distribute), typeof(Microsoft.Azure.Mobile.Push.Push));

			global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            var assembly = System.Reflection.Assembly.GetAssembly(typeof(AppDelegate));
			var assemblyName = assembly.GetName().Name;
			var gitVersionInformationType = assembly.GetType(assemblyName + ".GitVersionInformation");
			var versionFieldMajor = gitVersionInformationType.GetField("Major").GetValue(null);
            var versionFieldMinor = gitVersionInformationType.GetField("Minor").GetValue(null);
            var versionFieldPatch = gitVersionInformationType.GetField("Patch").GetValue(null);
            System.Diagnostics.Debug.WriteLine($"Version: {versionFieldMajor}.{versionFieldMinor}.{versionFieldPatch}");

			var fields = gitVersionInformationType.GetFields();

			foreach (var field in fields)
			{
				System.Diagnostics.Debug.WriteLine(string.Format("{0}: {1}", field.Name, field.GetValue(null)));
			}

            return base.FinishedLaunching(app, options);
        }
    }
}