/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware.Usb
{
    #region UsbManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html"/>
    /// </summary>
    public partial class UsbManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UsbManager>
    {
        const string _bridgeClassName = "android.hardware.usb.UsbManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UsbManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UsbManager(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region UsbManager implementation
    public partial class UsbManager
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#ACTION_USB_ACCESSORY_ATTACHED"/>
        /// </summary>
        public static Java.Lang.String ACTION_USB_ACCESSORY_ATTACHED { get { if (!_ACTION_USB_ACCESSORY_ATTACHEDReady) { _ACTION_USB_ACCESSORY_ATTACHEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_USB_ACCESSORY_ATTACHED"); _ACTION_USB_ACCESSORY_ATTACHEDReady = true; } return _ACTION_USB_ACCESSORY_ATTACHEDContent; } }
        private static Java.Lang.String _ACTION_USB_ACCESSORY_ATTACHEDContent = default;
        private static bool _ACTION_USB_ACCESSORY_ATTACHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#ACTION_USB_ACCESSORY_DETACHED"/>
        /// </summary>
        public static Java.Lang.String ACTION_USB_ACCESSORY_DETACHED { get { if (!_ACTION_USB_ACCESSORY_DETACHEDReady) { _ACTION_USB_ACCESSORY_DETACHEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_USB_ACCESSORY_DETACHED"); _ACTION_USB_ACCESSORY_DETACHEDReady = true; } return _ACTION_USB_ACCESSORY_DETACHEDContent; } }
        private static Java.Lang.String _ACTION_USB_ACCESSORY_DETACHEDContent = default;
        private static bool _ACTION_USB_ACCESSORY_DETACHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#ACTION_USB_DEVICE_ATTACHED"/>
        /// </summary>
        public static Java.Lang.String ACTION_USB_DEVICE_ATTACHED { get { if (!_ACTION_USB_DEVICE_ATTACHEDReady) { _ACTION_USB_DEVICE_ATTACHEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_USB_DEVICE_ATTACHED"); _ACTION_USB_DEVICE_ATTACHEDReady = true; } return _ACTION_USB_DEVICE_ATTACHEDContent; } }
        private static Java.Lang.String _ACTION_USB_DEVICE_ATTACHEDContent = default;
        private static bool _ACTION_USB_DEVICE_ATTACHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#ACTION_USB_DEVICE_DETACHED"/>
        /// </summary>
        public static Java.Lang.String ACTION_USB_DEVICE_DETACHED { get { if (!_ACTION_USB_DEVICE_DETACHEDReady) { _ACTION_USB_DEVICE_DETACHEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_USB_DEVICE_DETACHED"); _ACTION_USB_DEVICE_DETACHEDReady = true; } return _ACTION_USB_DEVICE_DETACHEDContent; } }
        private static Java.Lang.String _ACTION_USB_DEVICE_DETACHEDContent = default;
        private static bool _ACTION_USB_DEVICE_DETACHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#EXTRA_ACCESSORY"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ACCESSORY { get { if (!_EXTRA_ACCESSORYReady) { _EXTRA_ACCESSORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ACCESSORY"); _EXTRA_ACCESSORYReady = true; } return _EXTRA_ACCESSORYContent; } }
        private static Java.Lang.String _EXTRA_ACCESSORYContent = default;
        private static bool _EXTRA_ACCESSORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#EXTRA_DEVICE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_DEVICE { get { if (!_EXTRA_DEVICEReady) { _EXTRA_DEVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_DEVICE"); _EXTRA_DEVICEReady = true; } return _EXTRA_DEVICEContent; } }
        private static Java.Lang.String _EXTRA_DEVICEContent = default;
        private static bool _EXTRA_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#EXTRA_PERMISSION_GRANTED"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PERMISSION_GRANTED { get { if (!_EXTRA_PERMISSION_GRANTEDReady) { _EXTRA_PERMISSION_GRANTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PERMISSION_GRANTED"); _EXTRA_PERMISSION_GRANTEDReady = true; } return _EXTRA_PERMISSION_GRANTEDContent; } }
        private static Java.Lang.String _EXTRA_PERMISSION_GRANTEDContent = default;
        private static bool _EXTRA_PERMISSION_GRANTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#getAccessoryList()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Usb.UsbAccessory"/></returns>
        public Android.Hardware.Usb.UsbAccessory[] GetAccessoryList()
        {
            return IExecuteWithSignatureArray<Android.Hardware.Usb.UsbAccessory>("getAccessoryList", "()[Landroid/hardware/usb/UsbAccessory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#openDevice(android.hardware.usb.UsbDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDevice"/></param>
        /// <returns><see cref="Android.Hardware.Usb.UsbDeviceConnection"/></returns>
        public Android.Hardware.Usb.UsbDeviceConnection OpenDevice(Android.Hardware.Usb.UsbDevice arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Usb.UsbDeviceConnection>("openDevice", "(Landroid/hardware/usb/UsbDevice;)Landroid/hardware/usb/UsbDeviceConnection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#openAccessory(android.hardware.usb.UsbAccessory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbAccessory"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public Android.Os.ParcelFileDescriptor OpenAccessory(Android.Hardware.Usb.UsbAccessory arg0)
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("openAccessory", "(Landroid/hardware/usb/UsbAccessory;)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#hasPermission(android.hardware.usb.UsbAccessory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbAccessory"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasPermission(Android.Hardware.Usb.UsbAccessory arg0)
        {
            return IExecuteWithSignature<bool>("hasPermission", "(Landroid/hardware/usb/UsbAccessory;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#hasPermission(android.hardware.usb.UsbDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDevice"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasPermission(Android.Hardware.Usb.UsbDevice arg0)
        {
            return IExecuteWithSignature<bool>("hasPermission", "(Landroid/hardware/usb/UsbDevice;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#getDeviceList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.HashMap"/></returns>
        public Java.Util.HashMap<Java.Lang.String, Android.Hardware.Usb.UsbDevice> GetDeviceList()
        {
            return IExecuteWithSignature<Java.Util.HashMap<Java.Lang.String, Android.Hardware.Usb.UsbDevice>>("getDeviceList", "()Ljava/util/HashMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#requestPermission(android.hardware.usb.UsbAccessory,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbAccessory"/></param>
        /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
        public void RequestPermission(Android.Hardware.Usb.UsbAccessory arg0, Android.App.PendingIntent arg1)
        {
            IExecuteWithSignature("requestPermission", "(Landroid/hardware/usb/UsbAccessory;Landroid/app/PendingIntent;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbManager.html#requestPermission(android.hardware.usb.UsbDevice,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDevice"/></param>
        /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
        public void RequestPermission(Android.Hardware.Usb.UsbDevice arg0, Android.App.PendingIntent arg1)
        {
            IExecuteWithSignature("requestPermission", "(Landroid/hardware/usb/UsbDevice;Landroid/app/PendingIntent;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}