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

namespace Android.Net.Wifi
{
    #region EasyConnectStatusCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html"/>
    /// </summary>
    public partial class EasyConnectStatusCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EasyConnectStatusCallback>
    {
        const string _bridgeClassName = "android.net.wifi.EasyConnectStatusCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("EasyConnectStatusCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EasyConnectStatusCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("EasyConnectStatusCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EasyConnectStatusCallback(params object[] args) : base(args) { }

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

    #region EasyConnectStatusCallback implementation
    public partial class EasyConnectStatusCallback
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_AUTHENTICATION"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_AUTHENTICATION { get { if (!_EASY_CONNECT_EVENT_FAILURE_AUTHENTICATIONReady) { _EASY_CONNECT_EVENT_FAILURE_AUTHENTICATIONContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_AUTHENTICATION"); _EASY_CONNECT_EVENT_FAILURE_AUTHENTICATIONReady = true; } return _EASY_CONNECT_EVENT_FAILURE_AUTHENTICATIONContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_AUTHENTICATIONContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_AUTHENTICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_BUSY"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_BUSY { get { if (!_EASY_CONNECT_EVENT_FAILURE_BUSYReady) { _EASY_CONNECT_EVENT_FAILURE_BUSYContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_BUSY"); _EASY_CONNECT_EVENT_FAILURE_BUSYReady = true; } return _EASY_CONNECT_EVENT_FAILURE_BUSYContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_BUSYContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_BUSYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORK"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORK { get { if (!_EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORKReady) { _EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORKContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORK"); _EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORKReady = true; } return _EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORKContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORKContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_CANNOT_FIND_NETWORKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_CONFIGURATION"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_CONFIGURATION { get { if (!_EASY_CONNECT_EVENT_FAILURE_CONFIGURATIONReady) { _EASY_CONNECT_EVENT_FAILURE_CONFIGURATIONContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_CONFIGURATION"); _EASY_CONNECT_EVENT_FAILURE_CONFIGURATIONReady = true; } return _EASY_CONNECT_EVENT_FAILURE_CONFIGURATIONContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_CONFIGURATIONContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_CONFIGURATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATION"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATION { get { if (!_EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATIONReady) { _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATIONContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATION"); _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATIONReady = true; } return _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATIONContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATIONContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_AUTHENTICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNEL"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNEL { get { if (!_EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNELReady) { _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNELContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNEL"); _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNELReady = true; } return _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNELContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNELContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_FAILED_TO_SCAN_NETWORK_CHANNELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATION"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATION { get { if (!_EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATIONReady) { _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATIONContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATION"); _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATIONReady = true; } return _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATIONContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATIONContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_ENROLLEE_REJECTED_CONFIGURATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_GENERIC"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_GENERIC { get { if (!_EASY_CONNECT_EVENT_FAILURE_GENERICReady) { _EASY_CONNECT_EVENT_FAILURE_GENERICContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_GENERIC"); _EASY_CONNECT_EVENT_FAILURE_GENERICReady = true; } return _EASY_CONNECT_EVENT_FAILURE_GENERICContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_GENERICContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_GENERICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORK"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORK { get { if (!_EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORKReady) { _EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORKContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORK"); _EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORKReady = true; } return _EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORKContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORKContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_INVALID_NETWORKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_INVALID_URI"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_INVALID_URI { get { if (!_EASY_CONNECT_EVENT_FAILURE_INVALID_URIReady) { _EASY_CONNECT_EVENT_FAILURE_INVALID_URIContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_INVALID_URI"); _EASY_CONNECT_EVENT_FAILURE_INVALID_URIReady = true; } return _EASY_CONNECT_EVENT_FAILURE_INVALID_URIContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_INVALID_URIContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_INVALID_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLE"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLE { get { if (!_EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLEReady) { _EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLEContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLE"); _EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLEReady = true; } return _EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLEContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLEContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_NOT_COMPATIBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTED"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTED { get { if (!_EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTEDReady) { _EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTED"); _EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTEDReady = true; } return _EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTEDContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTEDContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_NOT_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_TIMEOUT"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_TIMEOUT { get { if (!_EASY_CONNECT_EVENT_FAILURE_TIMEOUTReady) { _EASY_CONNECT_EVENT_FAILURE_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_TIMEOUT"); _EASY_CONNECT_EVENT_FAILURE_TIMEOUTReady = true; } return _EASY_CONNECT_EVENT_FAILURE_TIMEOUTContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_TIMEOUTContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/EasyConnectStatusCallback.html#EASY_CONNECT_EVENT_FAILURE_URI_GENERATION"/>
        /// </summary>
        public static int EASY_CONNECT_EVENT_FAILURE_URI_GENERATION { get { if (!_EASY_CONNECT_EVENT_FAILURE_URI_GENERATIONReady) { _EASY_CONNECT_EVENT_FAILURE_URI_GENERATIONContent = SGetField<int>(LocalBridgeClazz, "EASY_CONNECT_EVENT_FAILURE_URI_GENERATION"); _EASY_CONNECT_EVENT_FAILURE_URI_GENERATIONReady = true; } return _EASY_CONNECT_EVENT_FAILURE_URI_GENERATIONContent; } }
        private static int _EASY_CONNECT_EVENT_FAILURE_URI_GENERATIONContent = default;
        private static bool _EASY_CONNECT_EVENT_FAILURE_URI_GENERATIONReady = false; // this is used because in case of generics 

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