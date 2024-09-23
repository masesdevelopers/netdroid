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

namespace Android.Telephony
{
    #region NetworkScan declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html"/>
    /// </summary>
    public partial class NetworkScan : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NetworkScan>
    {
        const string _bridgeClassName = "android.telephony.NetworkScan";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NetworkScan() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NetworkScan(params object[] args) : base(args) { }

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

    #region NetworkScan implementation
    public partial class NetworkScan
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#ERROR_INTERRUPTED"/>
        /// </summary>
        public static int ERROR_INTERRUPTED { get { if (!_ERROR_INTERRUPTEDReady) { _ERROR_INTERRUPTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_INTERRUPTED"); _ERROR_INTERRUPTEDReady = true; } return _ERROR_INTERRUPTEDContent; } }
        private static int _ERROR_INTERRUPTEDContent = default;
        private static bool _ERROR_INTERRUPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#ERROR_INVALID_SCAN"/>
        /// </summary>
        public static int ERROR_INVALID_SCAN { get { if (!_ERROR_INVALID_SCANReady) { _ERROR_INVALID_SCANContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_SCAN"); _ERROR_INVALID_SCANReady = true; } return _ERROR_INVALID_SCANContent; } }
        private static int _ERROR_INVALID_SCANContent = default;
        private static bool _ERROR_INVALID_SCANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#ERROR_INVALID_SCANID"/>
        /// </summary>
        public static int ERROR_INVALID_SCANID { get { if (!_ERROR_INVALID_SCANIDReady) { _ERROR_INVALID_SCANIDContent = SGetField<int>(LocalBridgeClazz, "ERROR_INVALID_SCANID"); _ERROR_INVALID_SCANIDReady = true; } return _ERROR_INVALID_SCANIDContent; } }
        private static int _ERROR_INVALID_SCANIDContent = default;
        private static bool _ERROR_INVALID_SCANIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#ERROR_MODEM_ERROR"/>
        /// </summary>
        public static int ERROR_MODEM_ERROR { get { if (!_ERROR_MODEM_ERRORReady) { _ERROR_MODEM_ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR_MODEM_ERROR"); _ERROR_MODEM_ERRORReady = true; } return _ERROR_MODEM_ERRORContent; } }
        private static int _ERROR_MODEM_ERRORContent = default;
        private static bool _ERROR_MODEM_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#ERROR_MODEM_UNAVAILABLE"/>
        /// </summary>
        public static int ERROR_MODEM_UNAVAILABLE { get { if (!_ERROR_MODEM_UNAVAILABLEReady) { _ERROR_MODEM_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "ERROR_MODEM_UNAVAILABLE"); _ERROR_MODEM_UNAVAILABLEReady = true; } return _ERROR_MODEM_UNAVAILABLEContent; } }
        private static int _ERROR_MODEM_UNAVAILABLEContent = default;
        private static bool _ERROR_MODEM_UNAVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#ERROR_RADIO_INTERFACE_ERROR"/>
        /// </summary>
        public static int ERROR_RADIO_INTERFACE_ERROR { get { if (!_ERROR_RADIO_INTERFACE_ERRORReady) { _ERROR_RADIO_INTERFACE_ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR_RADIO_INTERFACE_ERROR"); _ERROR_RADIO_INTERFACE_ERRORReady = true; } return _ERROR_RADIO_INTERFACE_ERRORContent; } }
        private static int _ERROR_RADIO_INTERFACE_ERRORContent = default;
        private static bool _ERROR_RADIO_INTERFACE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#ERROR_UNSUPPORTED"/>
        /// </summary>
        public static int ERROR_UNSUPPORTED { get { if (!_ERROR_UNSUPPORTEDReady) { _ERROR_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNSUPPORTED"); _ERROR_UNSUPPORTEDReady = true; } return _ERROR_UNSUPPORTEDContent; } }
        private static int _ERROR_UNSUPPORTEDContent = default;
        private static bool _ERROR_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#SUCCESS"/>
        /// </summary>
        public static int SUCCESS { get { if (!_SUCCESSReady) { _SUCCESSContent = SGetField<int>(LocalBridgeClazz, "SUCCESS"); _SUCCESSReady = true; } return _SUCCESSContent; } }
        private static int _SUCCESSContent = default;
        private static bool _SUCCESSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/NetworkScan.html#stopScan()"/>
        /// </summary>
        public void StopScan()
        {
            IExecuteWithSignature("stopScan", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}