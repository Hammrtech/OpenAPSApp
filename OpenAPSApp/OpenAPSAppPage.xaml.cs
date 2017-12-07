using System.Threading.Tasks;
using Xamarin.Forms;
using OpenAPSApp.Models;
using System.Net.Http;
using System;
using System.Collections.Generic;
using OpenAPSApp.Helpers;
using Newtonsoft.Json;
using System.Linq;
using Microcharts;
using SkiaSharp;

namespace OpenAPSApp
{
    public partial class OpenAPSAppPage : ContentPage
    {
        Status currentStatus = new Status();
        Profile currentProfile = new Profile();
        List<Glucose> gluList;
        TempBasal tmpBasal;
        List<IOB> iobList;
        SMBSuggested smbSuggest;

        public OpenAPSAppPage()
        {
            InitializeComponent();

            //ToolbarItems.Add(new ToolbarItem("Settings", "", async () =>
                             //  await Navigation.PushAsync(new BluetoothSetup())
                             //,0,0));

            //currentStatus.CurrentBG = gluList.FirstOrDefault().BloodGlucose;
            //currentStatus.CurrentDelta = "+2";
            //currentStatus.CurrentTrendArrow = "Flat";
            //currentStatus.MinutesSinceLastBG = 2;
            //currentStatus.CurrentIOB = 1.1;
            //currentStatus.CurrentCOB = 20;
            //currentStatus.EventualBG = 120;
            //currentStatus.LoopStatus = "Enacted 2m ago";
            //currentStatus.CurrentTempBasal = "2.2U/hr; 10m remaining";
            //currentStatus.OpenAPSReason = "A really big long string I won't try to simulate here";


            //BindingContext = currentStatus;

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            gluList = JsonConvert.DeserializeObject<List<Glucose>>(await Utility.GetJsonFromURL("http://172.20.10.5/monitor/glucose.json"));
            lblCurrentBG.Text = "Current BG:  " + gluList.FirstOrDefault().BloodGlucose.ToString();

            chartViewBG.Chart = new PointChart() { Entries = Utility.ConvertGlucoseListToEntry(gluList) };
            //chartViewBG.Chart.LabelTextSize = 0;
            tmpBasal = JsonConvert.DeserializeObject<TempBasal>(await Utility.GetJsonFromURL("http://172.20.10.5/monitor/temp_basal.json"));
            lblCurrentTempBasal.Text = $"Current temp basal: {tmpBasal.Rate} u/hr for {tmpBasal.Duration} min";



            iobList = JsonConvert.DeserializeObject<List<IOB>>(await Utility.GetJsonFromURL("http://172.20.10.5/monitor/iob.json"));
            lblCurrentIOB.Text = "Current IOB:  " + iobList.FirstOrDefault().Iob.ToString();


            smbSuggest = JsonConvert.DeserializeObject<SMBSuggested>(await Utility.GetJsonFromURL("http://172.20.10.5/enact/smb-suggested.json"));
            lblOpenAPSReason.Text = $"{smbSuggest.Reason.Substring(0,7)} g";
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
