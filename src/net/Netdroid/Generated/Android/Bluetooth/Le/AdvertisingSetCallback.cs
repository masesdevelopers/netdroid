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
    #region AdvertisingSetCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html"/>
    /// </summary>
    public partial class AdvertisingSetCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AdvertisingSetCallback>
    {
        const string _bridgeClassName = "android.bluetooth.le.AdvertisingSetCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AdvertisingSetCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AdvertisingSetCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AdvertisingSetCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AdvertisingSetCallback(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region AdvertisingSetCallback implementation
    public partial class AdvertisingSetCallback
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#ADVERTISE_FAILED_ALREADY_STARTED"/>
        /// </summary>
        public static int ADVERTISE_FAILED_ALREADY_STARTED { get { if (!_ADVERTISE_FAILED_ALREADY_STARTEDReady) { _ADVERTISE_FAILED_ALREADY_STARTEDContent = SGetField<int>(LocalBridgeClazz, "ADVERTISE_FAILED_ALREADY_STARTED"); _ADVERTISE_FAILED_ALREADY_STARTEDReady = true; } return _ADVERTISE_FAILED_ALREADY_STARTEDContent; } }
        private static int _ADVERTISE_FAILED_ALREADY_STARTEDContent = default;
        private static bool _ADVERTISE_FAILED_ALREADY_STARTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#ADVERTISE_FAILED_DATA_TOO_LARGE"/>
        /// </summary>
        public static int ADVERTISE_FAILED_DATA_TOO_LARGE { get { if (!_ADVERTISE_FAILED_DATA_TOO_LARGEReady) { _ADVERTISE_FAILED_DATA_TOO_LARGEContent = SGetField<int>(LocalBridgeClazz, "ADVERTISE_FAILED_DATA_TOO_LARGE"); _ADVERTISE_FAILED_DATA_TOO_LARGEReady = true; } return _ADVERTISE_FAILED_DATA_TOO_LARGEContent; } }
        private static int _ADVERTISE_FAILED_DATA_TOO_LARGEContent = default;
        private static bool _ADVERTISE_FAILED_DATA_TOO_LARGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#ADVERTISE_FAILED_FEATURE_UNSUPPORTED"/>
        /// </summary>
        public static int ADVERTISE_FAILED_FEATURE_UNSUPPORTED { get { if (!_ADVERTISE_FAILED_FEATURE_UNSUPPORTEDReady) { _ADVERTISE_FAILED_FEATURE_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ADVERTISE_FAILED_FEATURE_UNSUPPORTED"); _ADVERTISE_FAILED_FEATURE_UNSUPPORTEDReady = true; } return _ADVERTISE_FAILED_FEATURE_UNSUPPORTEDContent; } }
        private static int _ADVERTISE_FAILED_FEATURE_UNSUPPORTEDContent = default;
        private static bool _ADVERTISE_FAILED_FEATURE_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#ADVERTISE_FAILED_INTERNAL_ERROR"/>
        /// </summary>
        public static int ADVERTISE_FAILED_INTERNAL_ERROR { get { if (!_ADVERTISE_FAILED_INTERNAL_ERRORReady) { _ADVERTISE_FAILED_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "ADVERTISE_FAILED_INTERNAL_ERROR"); _ADVERTISE_FAILED_INTERNAL_ERRORReady = true; } return _ADVERTISE_FAILED_INTERNAL_ERRORContent; } }
        private static int _ADVERTISE_FAILED_INTERNAL_ERRORContent = default;
        private static bool _ADVERTISE_FAILED_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#ADVERTISE_FAILED_TOO_MANY_ADVERTISERS"/>
        /// </summary>
        public static int ADVERTISE_FAILED_TOO_MANY_ADVERTISERS { get { if (!_ADVERTISE_FAILED_TOO_MANY_ADVERTISERSReady) { _ADVERTISE_FAILED_TOO_MANY_ADVERTISERSContent = SGetField<int>(LocalBridgeClazz, "ADVERTISE_FAILED_TOO_MANY_ADVERTISERS"); _ADVERTISE_FAILED_TOO_MANY_ADVERTISERSReady = true; } return _ADVERTISE_FAILED_TOO_MANY_ADVERTISERSContent; } }
        private static int _ADVERTISE_FAILED_TOO_MANY_ADVERTISERSContent = default;
        private static bool _ADVERTISE_FAILED_TOO_MANY_ADVERTISERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#ADVERTISE_SUCCESS"/>
        /// </summary>
        public static int ADVERTISE_SUCCESS { get { if (!_ADVERTISE_SUCCESSReady) { _ADVERTISE_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "ADVERTISE_SUCCESS"); _ADVERTISE_SUCCESSReady = true; } return _ADVERTISE_SUCCESSContent; } }
        private static int _ADVERTISE_SUCCESSContent = default;
        private static bool _ADVERTISE_SUCCESSReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onAdvertisingDataSet(android.bluetooth.le.AdvertisingSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnAdvertisingDataSet(Android.Bluetooth.Le.AdvertisingSet arg0, int arg1)
        {
            IExecuteWithSignature("onAdvertisingDataSet", "(Landroid/bluetooth/le/AdvertisingSet;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onAdvertisingEnabled(android.bluetooth.le.AdvertisingSet,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnAdvertisingEnabled(Android.Bluetooth.Le.AdvertisingSet arg0, bool arg1, int arg2)
        {
            IExecuteWithSignature("onAdvertisingEnabled", "(Landroid/bluetooth/le/AdvertisingSet;ZI)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onAdvertisingParametersUpdated(android.bluetooth.le.AdvertisingSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnAdvertisingParametersUpdated(Android.Bluetooth.Le.AdvertisingSet arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("onAdvertisingParametersUpdated", "(Landroid/bluetooth/le/AdvertisingSet;II)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onAdvertisingSetStarted(android.bluetooth.le.AdvertisingSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnAdvertisingSetStarted(Android.Bluetooth.Le.AdvertisingSet arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("onAdvertisingSetStarted", "(Landroid/bluetooth/le/AdvertisingSet;II)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onAdvertisingSetStopped(android.bluetooth.le.AdvertisingSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        public void OnAdvertisingSetStopped(Android.Bluetooth.Le.AdvertisingSet arg0)
        {
            IExecuteWithSignature("onAdvertisingSetStopped", "(Landroid/bluetooth/le/AdvertisingSet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onPeriodicAdvertisingDataSet(android.bluetooth.le.AdvertisingSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnPeriodicAdvertisingDataSet(Android.Bluetooth.Le.AdvertisingSet arg0, int arg1)
        {
            IExecuteWithSignature("onPeriodicAdvertisingDataSet", "(Landroid/bluetooth/le/AdvertisingSet;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onPeriodicAdvertisingEnabled(android.bluetooth.le.AdvertisingSet,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnPeriodicAdvertisingEnabled(Android.Bluetooth.Le.AdvertisingSet arg0, bool arg1, int arg2)
        {
            IExecuteWithSignature("onPeriodicAdvertisingEnabled", "(Landroid/bluetooth/le/AdvertisingSet;ZI)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onPeriodicAdvertisingParametersUpdated(android.bluetooth.le.AdvertisingSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnPeriodicAdvertisingParametersUpdated(Android.Bluetooth.Le.AdvertisingSet arg0, int arg1)
        {
            IExecuteWithSignature("onPeriodicAdvertisingParametersUpdated", "(Landroid/bluetooth/le/AdvertisingSet;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetCallback.html#onScanResponseDataSet(android.bluetooth.le.AdvertisingSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.Le.AdvertisingSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OnScanResponseDataSet(Android.Bluetooth.Le.AdvertisingSet arg0, int arg1)
        {
            IExecuteWithSignature("onScanResponseDataSet", "(Landroid/bluetooth/le/AdvertisingSet;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}