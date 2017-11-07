using System.Threading.Tasks;
using Xamarin.Forms;
using OpenAPSApp.Models;

namespace OpenAPSApp
{
    public partial class OpenAPSAppPage : ContentPage
    {
        Status currentStatus = new Status();

        public OpenAPSAppPage()
        {
            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem("Setup", "", async () =>
                               await Navigation.PushAsync(new BluetoothSetup())
                             ,0,0));

            currentStatus.CurrentBG = 100;
            currentStatus.CurrentDelta = "+2";
            currentStatus.CurrentTrendArrow = "Flat";
            currentStatus.MinutesSinceLastBG = 2;
            currentStatus.CurrentIOB = 1.1;
            currentStatus.CurrentCOB = 20;
            currentStatus.EventualBG = 120;
            currentStatus.LoopStatus = "Enacted 2m ago";
            currentStatus.CurrentTempBasal = "2.2U/hr; 10m remaining";
            currentStatus.OpenAPSReason = "A really big long string I won't try to simulate here";

            BindingContext = currentStatus;

        }

        void btnEatingSoon_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Test", "We are eating soon", "Yay!");
        }

        void btnActivityMode_Clicked(object sender, System.EventArgs e)
        {

        }

        void btnCancelTempTarget_Clicked(object sender, System.EventArgs e)
        {

        }
        void btnSmallMeal_Clicked(object sender, System.EventArgs e)
        {


        }
        void btnMediumMeal_Clicked(object sender, System.EventArgs e)
        {


        }
        void btnLargeMeal_Clicked(object sender, System.EventArgs e)
        {


        }


    }
}
