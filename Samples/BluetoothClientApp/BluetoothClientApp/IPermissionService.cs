using System;
using System.Collections.Generic;
using System.Text;

namespace BluetoothClientApp
{
    public interface IPermissionService
    {
        bool HasBluetoothPermission();
        void RequestBluetoothPermission(Action bluetoothAction);
    }
}
