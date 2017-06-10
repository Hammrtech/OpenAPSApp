﻿using Plugin.BluetoothLE;
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
            if (Device.RuntimePlatform == "Android")
            {
                if (!(CrossBleAdapter.Current.Status == AdapterStatus.PoweredOn))
                {
                    CrossBleAdapter.Current.SetAdapterState(true);
                }
            }
            else if(Device.RuntimePlatform == "iOS")
            {
				CrossBleAdapter.Current.WhenStatusChanged().Subscribe(status => { });
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
            var sync = await DisplayAlert("Pair Device", "Do you want to pair with this device?", "Pair", "Cancel");
            if (sync)
            {
                var selectedDevice = (IScanResult)e.SelectedItem;
                var pin = RandomString(5);
                selectedDevice.Device.PairingRequest(pin).Subscribe(pairingAccepted =>
                {
                    if (pairingAccepted)
                    {
                        selectedDevice.Device.Connect();
                    }
                });
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

        private static Random random = new Random();

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
