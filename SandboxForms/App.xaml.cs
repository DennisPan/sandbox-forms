using Xamarin.Forms;

namespace SandboxForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SandboxFormsPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
