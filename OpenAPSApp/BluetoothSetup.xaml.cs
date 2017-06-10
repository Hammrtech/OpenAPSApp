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
        private ObservableCollection<IScanResult> _foundDevices;

        public BluetoothSetup()
        {
            InitializeComponent();
        }

        private void btnTestBluetooth_Clicked(object sender, System.EventArgs e)
        {
            if(!(CrossBleAdapter.Current.Status == AdapterStatus.PoweredOn))
            {
                CrossBleAdapter.Current.SetAdapterState(true);
            }
            _foundDevices = new ObservableCollection<IScanResult>();
            lsvAvailableDevices.ItemsSource = _foundDevices;
            _scanner = CrossBleAdapter.Current.Scan().Subscribe(AddDeviceNameToFoundList);
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

        private void AddDeviceNameToFoundList(IScanResult scanResult)
        {
            if (!string.IsNullOrEmpty(scanResult.Device.Name))
            {
                if (!(_foundDevices.Any(device => device.Device.Name == scanResult.Device.Name)))
                {
                    _foundDevices.Add(scanResult);
                }
            }
        }
    }
}
