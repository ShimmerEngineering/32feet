using InTheHand.Bluetooth;
using ShimmerAPI;
using System;
using System.Diagnostics;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BluetoothClientApp
{
    public partial class MainPage : ContentPage
    {
        ShimmerLogAndStream32FeetBLE shimmerdevice;
        public MainPage()
        {
            InitializeComponent();
            Appearing += MainPage_Appearing;
            
        }

        async void OnButtonConnectClicked(object sender, EventArgs args)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {   //E8EB1B713E36
                //9A05E926-0665-3166-3F3E-1A2CACF095E2
                shimmerdevice = new ShimmerLogAndStream32FeetBLE("shimmer", "9A05E926-0665-3166-3F3E-1A2CACF095E2");

                //e8eb1b9767ad
                //C01B2C3B-7B83-5245-10BD-C0B57733F7D2
                //shimmerdevice = new ShimmerLogAndStream32FeetBLE("shimmer", "C01B2C3B-7B83-5245-10BD-C0B57733F7D2");
            }
            else
            {
                //
                //E8EB1B713E36
                //shimmerdevice = new ShimmerLogAndStream32FeetBLE("shimmer", "e8eb1b9767ad");
                shimmerdevice = new ShimmerLogAndStream32FeetBLE("shimmer", "E8EB1B713E36");
            }
            shimmerdevice.UICallback += this.HandleEvent;
            shimmerdevice.StartConnectThread();
        }
        async void OnButtonDisconnectClicked(object sender, EventArgs args)
        {
            shimmerdevice.Disconnect();
        }
        async void OnButtonStartStreamingClicked(object sender, EventArgs args)
        {
            shimmerdevice?.StartStreaming();
        }
        async void OnButtonStopStreamingClicked(object sender, EventArgs args)
        {
            shimmerdevice.StopStreaming();
        }
        BluetoothLEScan scan;

        int count = 0;
        public async void HandleEvent(object sender, EventArgs args)
        {
            CustomEventArgs eventArgs = (CustomEventArgs)args;
            int indicator = eventArgs.getIndicator();
            switch (indicator)
            {
                case (int)ShimmerBluetooth.ShimmerIdentifier.MSG_IDENTIFIER_STATE_CHANGE:

                    System.Diagnostics.Debug.Write(((ShimmerBluetooth)sender).GetDeviceName() + " State = " + ((ShimmerBluetooth)sender).GetStateString() + System.Environment.NewLine);
                    int state = (int)eventArgs.getObject();
                    if (state == (int)ShimmerBluetooth.SHIMMER_STATE_CONNECTED)
                    {
                        Debug.WriteLine("Connected");
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            labelState.Text = "Connected";
                        });
                    }
                    else if (state == (int)ShimmerBluetooth.SHIMMER_STATE_CONNECTING)
                    {
                        Debug.WriteLine("Connecting");
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            labelState.Text = "Connecting";
                        });
                    }
                    else if (state == (int)ShimmerBluetooth.SHIMMER_STATE_NONE)
                    {
                        Debug.WriteLine("NONE");
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            labelState.Text = "None";
                        });
                    }
                    else if (state == (int)ShimmerBluetooth.SHIMMER_STATE_STREAMING)
                    {
                        Debug.WriteLine("Streaming");
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            labelState.Text = "Streaming";
                        });
                    }
                    break;
                case (int)ShimmerBluetooth.ShimmerIdentifier.MSG_IDENTIFIER_DATA_PACKET:
                    // this is essential to ensure the object is not a reference
                    ObjectCluster objectCluster = new ObjectCluster((ObjectCluster)eventArgs.getObject());
                    SensorData datax = objectCluster.GetData(Shimmer3Configuration.SignalNames.LOW_NOISE_ACCELEROMETER_X, "CAL");
                    SensorData datay = objectCluster.GetData(Shimmer3Configuration.SignalNames.LOW_NOISE_ACCELEROMETER_Y, "CAL");
                    SensorData dataz = objectCluster.GetData(Shimmer3Configuration.SignalNames.LOW_NOISE_ACCELEROMETER_Z, "CAL");
                    string data = "AccelX,Y,Z: " + datax.Data.ToString("F1") + " , " + datay.Data.ToString("F1") + " , " + dataz.Data.ToString("F1");
                    Debug.WriteLine(data);
                    Debug.WriteLine("new packet");
                    count++;
                    if (count % 25 == 0)
                    {
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            labelData.Text = data;
                        });
                    }

                    break;
            }
        }
        private async void MainPage_Appearing(object sender, EventArgs e)
        {
            Debug.WriteLine("MainPage");

            bool availability = false;

            Bluetooth.AvailabilityChanged += Bluetooth_AvailabilityChanged;

            while (!availability)
            {
                availability = await Bluetooth.GetAvailabilityAsync();
                await Task.Delay(500);
            }
            
            /*
            
            foreach (var d in await Bluetooth.GetPairedDevicesAsync())
            {
                Debug.WriteLine($"{d.Id} {d.Name}");
            }

            foreach(var sd in await Bluetooth.ScanForDevicesAsync())
            {
                Debug.WriteLine($"{sd.Id} {sd.Name}");
            }

            //Bluetooth.AdvertisementReceived += Bluetooth_AdvertisementReceived;
            //scan = await Bluetooth.RequestLEScanAsync();

            RequestDeviceOptions options = new RequestDeviceOptions();
            options.AcceptAllDevices = true;
            BluetoothDevice device = await Bluetooth.RequestDeviceAsync(options);
            if (device != null)
            {
                device.GattServerDisconnected += Device_GattServerDisconnected;
                await device.Gatt.ConnectAsync();

                System.Diagnostics.Debug.WriteLine($"Mtu: {device.Gatt.Mtu}");
                await device.Gatt.RequestMtuAsync(16);
                System.Diagnostics.Debug.WriteLine($"Mtu: {device.Gatt.Mtu}");
                await device.Gatt.RequestMtuAsync(517);
                System.Diagnostics.Debug.WriteLine($"Mtu: {device.Gatt.Mtu}");

                var servs = await device.Gatt.GetPrimaryServicesAsync();

                foreach (var serv in servs)
                {
                    var rssi = await device.Gatt.ReadRssi();
                    Debug.WriteLine($"{rssi} {serv.Uuid} Primary:{serv.IsPrimary}");

                    Debug.Indent();

                    foreach (var chars in await serv.GetCharacteristicsAsync())
                    {
                        Debug.WriteLine($"{chars.Uuid} Properties:{chars.Properties}");

                        Debug.Indent();

                        foreach (var descriptors in await chars.GetDescriptorsAsync())
                        {
                            Debug.WriteLine($"Descriptor:{descriptors.Uuid}");

                            var val2 = await descriptors.ReadValueAsync();

                            if (descriptors.Uuid == GattDescriptorUuids.ClientCharacteristicConfiguration)
                            {
                                Debug.WriteLine($"Notifying:{val2[0] > 0}");
                            }
                            else if (descriptors.Uuid == GattDescriptorUuids.CharacteristicUserDescription)
                            {
                                Debug.WriteLine($"UserDescription:{ByteArrayToString(val2)}");
                            }
                            else
                            {
                                Debug.WriteLine(ByteArrayToString(val2));
                            }

                        }

                        Debug.Unindent();
                    }

                    Debug.Unindent();
                }
            }
            */
            
        }

        private async void Bluetooth_AvailabilityChanged(object sender, EventArgs e)
        {
            var current = await Bluetooth.GetAvailabilityAsync();
            System.Diagnostics.Debug.Write($"Availability: {current}");
        }

        private void Bluetooth_AdvertisementReceived(object sender, BluetoothAdvertisingEvent e)
        {
            Debug.WriteLine($"Name:{e.Name} Rssi:{e.Rssi}");
        }

        private async void Device_GattServerDisconnected(object sender, EventArgs e)
        {
            var device = sender as BluetoothDevice;
            await device.Gatt.ConnectAsync();
        }

        private static string ByteArrayToString(byte[] data)
        {
            if (data == null)
                return "<NULL>";

            StringBuilder sb = new StringBuilder();

            foreach(byte b in data)
            {
                sb.Append(b.ToString("X"));
            }

            return sb.ToString();
        }

    }
}
