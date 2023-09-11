using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BluetoothClientApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BluetoothPermissionsPage : ContentPage
    {
        readonly IPermissionService service;

        public BluetoothPermissionsPage()
        {
            InitializeComponent();
            service = DependencyService.Get<IPermissionService>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CheckBluetooothPermission();
        }

        void HasBluetooth_Clicked(System.Object sender, System.EventArgs e)
        {
            CheckBluetooothPermission();
        }

        private void CheckBluetooothPermission()
        {
            LabelHasPermission.Text = service.HasBluetoothPermission() ? "YES" : "NO";
        }

        void RequestBluetooth_Clicked(System.Object sender, System.EventArgs e)
        {
            service.RequestBluetoothPermission(() =>
            {
                CheckBluetooothPermission();
            });
        }
    }
}