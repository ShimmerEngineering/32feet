﻿// 32feet.NET - Personal Area Networking for .NET
//
// InTheHand.OperatingSystem (Xamarin Android)
// 
// Copyright (c) 2023 In The Hand Ltd, All rights reserved.
// This source code is licensed under the MIT License

using System;
using System.ComponentModel;

#if MONOANDROID
namespace InTheHand
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class OperatingSystem
    {
        public static bool IsAndroidVersionAtLeast(int major)
        {
            return Android.OS.Build.VERSION.SdkInt >= (Android.OS.BuildVersionCodes)major;
        }
    }
}
#endif
