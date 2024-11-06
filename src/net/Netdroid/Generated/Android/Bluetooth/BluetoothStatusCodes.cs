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

namespace Android.Bluetooth
{
    #region BluetoothStatusCodes declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html"/>
    /// </summary>
    public partial class BluetoothStatusCodes : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BluetoothStatusCodes>
    {
        const string _bridgeClassName = "android.bluetooth.BluetoothStatusCodes";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BluetoothStatusCodes() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BluetoothStatusCodes(params object[] args) : base(args) { }
    
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

    #region BluetoothStatusCodes implementation
    public partial class BluetoothStatusCodes
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_BLUETOOTH_NOT_ALLOWED"/>
        /// </summary>
        public static int ERROR_BLUETOOTH_NOT_ALLOWED { get { if (!_ERROR_BLUETOOTH_NOT_ALLOWEDReady) { _ERROR_BLUETOOTH_NOT_ALLOWEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_BLUETOOTH_NOT_ALLOWED"); _ERROR_BLUETOOTH_NOT_ALLOWEDReady = true; } return _ERROR_BLUETOOTH_NOT_ALLOWEDContent; } }
        private static int _ERROR_BLUETOOTH_NOT_ALLOWEDContent = default;
        private static bool _ERROR_BLUETOOTH_NOT_ALLOWEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_BLUETOOTH_NOT_ENABLED"/>
        /// </summary>
        public static int ERROR_BLUETOOTH_NOT_ENABLED { get { if (!_ERROR_BLUETOOTH_NOT_ENABLEDReady) { _ERROR_BLUETOOTH_NOT_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_BLUETOOTH_NOT_ENABLED"); _ERROR_BLUETOOTH_NOT_ENABLEDReady = true; } return _ERROR_BLUETOOTH_NOT_ENABLEDContent; } }
        private static int _ERROR_BLUETOOTH_NOT_ENABLEDContent = default;
        private static bool _ERROR_BLUETOOTH_NOT_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_DEVICE_NOT_BONDED"/>
        /// </summary>
        public static int ERROR_DEVICE_NOT_BONDED { get { if (!_ERROR_DEVICE_NOT_BONDEDReady) { _ERROR_DEVICE_NOT_BONDEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DEVICE_NOT_BONDED"); _ERROR_DEVICE_NOT_BONDEDReady = true; } return _ERROR_DEVICE_NOT_BONDEDContent; } }
        private static int _ERROR_DEVICE_NOT_BONDEDContent = default;
        private static bool _ERROR_DEVICE_NOT_BONDEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_GATT_WRITE_NOT_ALLOWED"/>
        /// </summary>
        public static int ERROR_GATT_WRITE_NOT_ALLOWED { get { if (!_ERROR_GATT_WRITE_NOT_ALLOWEDReady) { _ERROR_GATT_WRITE_NOT_ALLOWEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_GATT_WRITE_NOT_ALLOWED"); _ERROR_GATT_WRITE_NOT_ALLOWEDReady = true; } return _ERROR_GATT_WRITE_NOT_ALLOWEDContent; } }
        private static int _ERROR_GATT_WRITE_NOT_ALLOWEDContent = default;
        private static bool _ERROR_GATT_WRITE_NOT_ALLOWEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_GATT_WRITE_REQUEST_BUSY"/>
        /// </summary>
        public static int ERROR_GATT_WRITE_REQUEST_BUSY { get { if (!_ERROR_GATT_WRITE_REQUEST_BUSYReady) { _ERROR_GATT_WRITE_REQUEST_BUSYContent = SGetField<int>(LocalBridgeClazz, "ERROR_GATT_WRITE_REQUEST_BUSY"); _ERROR_GATT_WRITE_REQUEST_BUSYReady = true; } return _ERROR_GATT_WRITE_REQUEST_BUSYContent; } }
        private static int _ERROR_GATT_WRITE_REQUEST_BUSYContent = default;
        private static bool _ERROR_GATT_WRITE_REQUEST_BUSYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSION"/>
        /// </summary>
        public static int ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSION { get { if (!_ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSIONReady) { _ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSIONContent = SGetField<int>(LocalBridgeClazz, "ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSION"); _ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSIONReady = true; } return _ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSIONContent; } }
        private static int _ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSIONContent = default;
        private static bool _ERROR_MISSING_BLUETOOTH_CONNECT_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_PROFILE_SERVICE_NOT_BOUND"/>
        /// </summary>
        public static int ERROR_PROFILE_SERVICE_NOT_BOUND { get { if (!_ERROR_PROFILE_SERVICE_NOT_BOUNDReady) { _ERROR_PROFILE_SERVICE_NOT_BOUNDContent = SGetField<int>(LocalBridgeClazz, "ERROR_PROFILE_SERVICE_NOT_BOUND"); _ERROR_PROFILE_SERVICE_NOT_BOUNDReady = true; } return _ERROR_PROFILE_SERVICE_NOT_BOUNDContent; } }
        private static int _ERROR_PROFILE_SERVICE_NOT_BOUNDContent = default;
        private static bool _ERROR_PROFILE_SERVICE_NOT_BOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#ERROR_UNKNOWN"/>
        /// </summary>
        public static int ERROR_UNKNOWN { get { if (!_ERROR_UNKNOWNReady) { _ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNKNOWN"); _ERROR_UNKNOWNReady = true; } return _ERROR_UNKNOWNContent; } }
        private static int _ERROR_UNKNOWNContent = default;
        private static bool _ERROR_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#FEATURE_NOT_CONFIGURED"/>
        /// </summary>
        public static int FEATURE_NOT_CONFIGURED { get { if (!_FEATURE_NOT_CONFIGUREDReady) { _FEATURE_NOT_CONFIGUREDContent = SGetField<int>(LocalBridgeClazz, "FEATURE_NOT_CONFIGURED"); _FEATURE_NOT_CONFIGUREDReady = true; } return _FEATURE_NOT_CONFIGUREDContent; } }
        private static int _FEATURE_NOT_CONFIGUREDContent = default;
        private static bool _FEATURE_NOT_CONFIGUREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#FEATURE_NOT_SUPPORTED"/>
        /// </summary>
        public static int FEATURE_NOT_SUPPORTED { get { if (!_FEATURE_NOT_SUPPORTEDReady) { _FEATURE_NOT_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "FEATURE_NOT_SUPPORTED"); _FEATURE_NOT_SUPPORTEDReady = true; } return _FEATURE_NOT_SUPPORTEDContent; } }
        private static int _FEATURE_NOT_SUPPORTEDContent = default;
        private static bool _FEATURE_NOT_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#FEATURE_SUPPORTED"/>
        /// </summary>
        public static int FEATURE_SUPPORTED { get { if (!_FEATURE_SUPPORTEDReady) { _FEATURE_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "FEATURE_SUPPORTED"); _FEATURE_SUPPORTEDReady = true; } return _FEATURE_SUPPORTEDContent; } }
        private static int _FEATURE_SUPPORTEDContent = default;
        private static bool _FEATURE_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothStatusCodes.html#SUCCESS"/>
        /// </summary>
        public static int SUCCESS { get { if (!_SUCCESSReady) { _SUCCESSContent = SGetField<int>(LocalBridgeClazz, "SUCCESS"); _SUCCESSReady = true; } return _SUCCESSContent; } }
        private static int _SUCCESSContent = default;
        private static bool _SUCCESSReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}