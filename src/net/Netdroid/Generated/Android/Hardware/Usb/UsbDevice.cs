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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware.Usb
{
    #region UsbDevice declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html"/>
    /// </summary>
    public partial class UsbDevice : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.hardware.usb.UsbDevice";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public UsbDevice() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public UsbDevice(params object[] args) : base(args) { }

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

    #region UsbDevice implementation
    public partial class UsbDevice
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getDeviceId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetDeviceId(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getDeviceId", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getDeviceName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDeviceName(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getDeviceName", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getConfiguration(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Usb.UsbConfiguration"/></returns>
        public Android.Hardware.Usb.UsbConfiguration GetConfiguration(int arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Usb.UsbConfiguration>("getConfiguration", "(I)Landroid/hardware/usb/UsbConfiguration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getInterface(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Usb.UsbInterface"/></returns>
        public Android.Hardware.Usb.UsbInterface GetInterface(int arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Usb.UsbInterface>("getInterface", "(I)Landroid/hardware/usb/UsbInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getConfigurationCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConfigurationCount()
        {
            return IExecuteWithSignature<int>("getConfigurationCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getDeviceClass()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceClass()
        {
            return IExecuteWithSignature<int>("getDeviceClass", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getDeviceId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceId()
        {
            return IExecuteWithSignature<int>("getDeviceId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getDeviceProtocol()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceProtocol()
        {
            return IExecuteWithSignature<int>("getDeviceProtocol", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getDeviceSubclass()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceSubclass()
        {
            return IExecute<int>("getDeviceSubclass");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getInterfaceCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInterfaceCount()
        {
            return IExecuteWithSignature<int>("getInterfaceCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getProductId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProductId()
        {
            return IExecuteWithSignature<int>("getProductId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getVendorId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVendorId()
        {
            return IExecuteWithSignature<int>("getVendorId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getDeviceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDeviceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDeviceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getManufacturerName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetManufacturerName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getManufacturerName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getProductName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProductName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProductName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getSerialNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSerialNumber()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSerialNumber", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/usb/UsbDevice.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}