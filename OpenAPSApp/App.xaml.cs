using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace OpenAPSApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MobileCenter.Start("ios=8685d2b6-cb0c-4c9f-8818-a11ffb916dc6;" +
                               "android=4da701e6-3394-481e-9f03-b039355f488c",
                   typeof(Analytics), typeof(Crashes));


            MainPage = new NavigationPage(new OpenAPSAppPage());
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
