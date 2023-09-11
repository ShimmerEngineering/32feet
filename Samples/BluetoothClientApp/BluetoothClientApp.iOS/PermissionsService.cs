using CoreBluetooth;
using CoreFoundation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace BluetoothClientApp.iOS
{
    public class PermissionService : IPermissionService
    {
        
        public bool HasBluetoothPermission()
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                return CBCentralManager.Authorization == CBManagerAuthorization.AllowedAlways;
            }
            else
            {
                return true;
            }
        }

        public void RequestBluetoothPermission(Action bluetoothAction)
        {
            var myDelegate = new PermissionCBCentralManager(this);
            var centralManger = new CBCentralManager(myDelegate, DispatchQueue.MainQueue, new CBCentralInitOptions() { ShowPowerAlert = false });
        }

        internal void CurrentUpdatedState(CBCentralManager central)
        {
            
        }
    }

    public class PermissionCBCentralManager : CBCentralManagerDelegate
    {
        PermissionService permissionService = null;

        public PermissionCBCentralManager(PermissionService controller)
        {
            permissionService = controller;
        }

        public override void UpdatedState(CBCentralManager central)
        {
            permissionService.CurrentUpdatedState(central);
        }
    }

}