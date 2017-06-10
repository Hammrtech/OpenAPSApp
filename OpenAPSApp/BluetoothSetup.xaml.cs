using Plugin.BluetoothLE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenAPSApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BluetoothSetup : ContentPage
    {
        private IDisposable _scanner;

        public BluetoothSetup()
        {
            InitializeComponent();
        }

        private async Task btnTestBluetooth_Clicked(object sender, System.EventArgs e)
        {
            if(!(CrossBleAdapter.Current.Status == AdapterStatus.PoweredOn))
            {
                CrossBleAdapter.Current.SetAdapterState(true);
            }
            var devices = new ObservableCollection<IScanResult>();
            lsvAvailableDevices.ItemsSource = devices;
            _scanner = CrossBleAdapter.Current.Scan().Subscribe(scanResult =>
            {
                if (!(devices.Any(device => device.Device.Name == scanResult.Device.Name)))
                {
                    devices.Add(scanResult);
                }
            });
        }

        private void btnStopBluetoothScan_Clicked(object sender, EventArgs e)
        {
            _scanner.Dispose();
        }

        private async Task lsvAvailableDevices_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var sync = await DisplayAlert("Pair Device", "Do you want to pair this device?", "Pair", "Cancel");
            if (sync)
            {
                
            }
        }
    }
}
