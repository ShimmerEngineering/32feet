﻿// 32feet.NET - Personal Area Networking for .NET
//
// InTheHand.Net.BluetoothAddress (iOS)
// 
// Copyright (c) 2003-2023 In The Hand Ltd, All rights reserved.
// This source code is licensed under the MIT License

using ExternalAccessory;

namespace InTheHand.Net
{
    partial class BluetoothAddress
    {
        private readonly EAAccessory _accessory;

        internal BluetoothAddress(EAAccessory accessory)
        {
            _accessory = accessory;
            _address = (ulong)accessory.GetHashCode() & 0xFFFFFFFFFFFFU;
        }

        internal EAAccessory Accessory
        {
            get
            {
                return _accessory;
            }
        }
    }
}