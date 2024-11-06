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

namespace Android.Bluetooth.Le
{
    #region ScanFilter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html"/>
    /// </summary>
    public partial class ScanFilter : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.bluetooth.le.ScanFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScanFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScanFilter(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.bluetooth.le.ScanFilter$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region ScanFilter implementation
    public partial class ScanFilter
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getServiceDataUuid()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetServiceDataUuid()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getServiceDataUuid", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getServiceSolicitationUuid()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetServiceSolicitationUuid()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getServiceSolicitationUuid", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getServiceSolicitationUuidMask()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetServiceSolicitationUuidMask()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getServiceSolicitationUuidMask", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getServiceUuid()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetServiceUuid()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getServiceUuid", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getServiceUuidMask()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelUuid"/></returns>
        public Android.Os.ParcelUuid GetServiceUuidMask()
        {
            return IExecuteWithSignature<Android.Os.ParcelUuid>("getServiceUuidMask", "()Landroid/os/ParcelUuid;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#matches(android.bluetooth.le.ScanResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.ScanResult"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Matches(Android.Bluetooth.Le.ScanResult arg0)
        {
            return IExecuteWithSignature<bool>("matches", "(Landroid/bluetooth/le/ScanResult;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getAdvertisingData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetAdvertisingData()
        {
            return IExecuteWithSignatureArray<byte>("getAdvertisingData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getAdvertisingDataMask()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetAdvertisingDataMask()
        {
            return IExecuteWithSignatureArray<byte>("getAdvertisingDataMask", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getManufacturerData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetManufacturerData()
        {
            return IExecuteWithSignatureArray<byte>("getManufacturerData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getManufacturerDataMask()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetManufacturerDataMask()
        {
            return IExecuteWithSignatureArray<byte>("getManufacturerDataMask", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getServiceData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetServiceData()
        {
            return IExecuteWithSignatureArray<byte>("getServiceData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getServiceDataMask()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetServiceDataMask()
        {
            return IExecuteWithSignatureArray<byte>("getServiceDataMask", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getAdvertisingDataType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAdvertisingDataType()
        {
            return IExecuteWithSignature<int>("getAdvertisingDataType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getManufacturerId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetManufacturerId()
        {
            return IExecuteWithSignature<int>("getManufacturerId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getDeviceAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDeviceAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDeviceAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#getDeviceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDeviceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDeviceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter"/></returns>
            public Android.Bluetooth.Le.ScanFilter Build()
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter>("build", "()Landroid/bluetooth/le/ScanFilter;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setAdvertisingDataType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetAdvertisingDataType(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setAdvertisingDataType", "(I)Landroid/bluetooth/le/ScanFilter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setAdvertisingDataTypeWithData(int,byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetAdvertisingDataTypeWithData(int arg0, byte[] arg1, byte[] arg2)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setAdvertisingDataTypeWithData", "(I[B[B)Landroid/bluetooth/le/ScanFilter$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setDeviceAddress(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetDeviceAddress(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setDeviceAddress", "(Ljava/lang/String;)Landroid/bluetooth/le/ScanFilter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setDeviceName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetDeviceName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setDeviceName", "(Ljava/lang/String;)Landroid/bluetooth/le/ScanFilter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setManufacturerData(int,byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetManufacturerData(int arg0, byte[] arg1, byte[] arg2)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setManufacturerData", "(I[B[B)Landroid/bluetooth/le/ScanFilter$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setManufacturerData(int,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetManufacturerData(int arg0, byte[] arg1)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setManufacturerData", "(I[B)Landroid/bluetooth/le/ScanFilter$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setServiceData(android.os.ParcelUuid,byte[],byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetServiceData(Android.Os.ParcelUuid arg0, byte[] arg1, byte[] arg2)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setServiceData", "(Landroid/os/ParcelUuid;[B[B)Landroid/bluetooth/le/ScanFilter$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setServiceData(android.os.ParcelUuid,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetServiceData(Android.Os.ParcelUuid arg0, byte[] arg1)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setServiceData", "(Landroid/os/ParcelUuid;[B)Landroid/bluetooth/le/ScanFilter$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setServiceSolicitationUuid(android.os.ParcelUuid,android.os.ParcelUuid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <param name="arg1"><see cref="Android.Os.ParcelUuid"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetServiceSolicitationUuid(Android.Os.ParcelUuid arg0, Android.Os.ParcelUuid arg1)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setServiceSolicitationUuid", "(Landroid/os/ParcelUuid;Landroid/os/ParcelUuid;)Landroid/bluetooth/le/ScanFilter$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setServiceSolicitationUuid(android.os.ParcelUuid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetServiceSolicitationUuid(Android.Os.ParcelUuid arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setServiceSolicitationUuid", "(Landroid/os/ParcelUuid;)Landroid/bluetooth/le/ScanFilter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setServiceUuid(android.os.ParcelUuid,android.os.ParcelUuid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <param name="arg1"><see cref="Android.Os.ParcelUuid"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetServiceUuid(Android.Os.ParcelUuid arg0, Android.Os.ParcelUuid arg1)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setServiceUuid", "(Landroid/os/ParcelUuid;Landroid/os/ParcelUuid;)Landroid/bluetooth/le/ScanFilter$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanFilter.Builder.html#setServiceUuid(android.os.ParcelUuid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanFilter.Builder"/></returns>
            public Android.Bluetooth.Le.ScanFilter.Builder SetServiceUuid(Android.Os.ParcelUuid arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanFilter.Builder>("setServiceUuid", "(Landroid/os/ParcelUuid;)Landroid/bluetooth/le/ScanFilter$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}