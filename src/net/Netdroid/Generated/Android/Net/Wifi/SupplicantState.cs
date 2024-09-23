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
    #region SupplicantState declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html"/>
    /// </summary>
    public partial class SupplicantState : Java.Lang.Enum<Android.Net.Wifi.SupplicantState>
    {
        const string _bridgeClassName = "android.net.wifi.SupplicantState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SupplicantState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SupplicantState(params object[] args) : base(args) { }

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

    #region SupplicantState implementation
    public partial class SupplicantState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Net.Wifi.SupplicantState"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Net.Wifi.SupplicantState t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#ASSOCIATED"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState ASSOCIATED { get { if (!_ASSOCIATEDReady) { _ASSOCIATEDContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "ASSOCIATED"); _ASSOCIATEDReady = true; } return _ASSOCIATEDContent; } }
        private static Android.Net.Wifi.SupplicantState _ASSOCIATEDContent = default;
        private static bool _ASSOCIATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#ASSOCIATING"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState ASSOCIATING { get { if (!_ASSOCIATINGReady) { _ASSOCIATINGContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "ASSOCIATING"); _ASSOCIATINGReady = true; } return _ASSOCIATINGContent; } }
        private static Android.Net.Wifi.SupplicantState _ASSOCIATINGContent = default;
        private static bool _ASSOCIATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#AUTHENTICATING"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState AUTHENTICATING { get { if (!_AUTHENTICATINGReady) { _AUTHENTICATINGContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "AUTHENTICATING"); _AUTHENTICATINGReady = true; } return _AUTHENTICATINGContent; } }
        private static Android.Net.Wifi.SupplicantState _AUTHENTICATINGContent = default;
        private static bool _AUTHENTICATINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#COMPLETED"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState COMPLETED { get { if (!_COMPLETEDReady) { _COMPLETEDContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "COMPLETED"); _COMPLETEDReady = true; } return _COMPLETEDContent; } }
        private static Android.Net.Wifi.SupplicantState _COMPLETEDContent = default;
        private static bool _COMPLETEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#DISCONNECTED"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState DISCONNECTED { get { if (!_DISCONNECTEDReady) { _DISCONNECTEDContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "DISCONNECTED"); _DISCONNECTEDReady = true; } return _DISCONNECTEDContent; } }
        private static Android.Net.Wifi.SupplicantState _DISCONNECTEDContent = default;
        private static bool _DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#DORMANT"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState DORMANT { get { if (!_DORMANTReady) { _DORMANTContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "DORMANT"); _DORMANTReady = true; } return _DORMANTContent; } }
        private static Android.Net.Wifi.SupplicantState _DORMANTContent = default;
        private static bool _DORMANTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#FOUR_WAY_HANDSHAKE"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState FOUR_WAY_HANDSHAKE { get { if (!_FOUR_WAY_HANDSHAKEReady) { _FOUR_WAY_HANDSHAKEContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "FOUR_WAY_HANDSHAKE"); _FOUR_WAY_HANDSHAKEReady = true; } return _FOUR_WAY_HANDSHAKEContent; } }
        private static Android.Net.Wifi.SupplicantState _FOUR_WAY_HANDSHAKEContent = default;
        private static bool _FOUR_WAY_HANDSHAKEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#GROUP_HANDSHAKE"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState GROUP_HANDSHAKE { get { if (!_GROUP_HANDSHAKEReady) { _GROUP_HANDSHAKEContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "GROUP_HANDSHAKE"); _GROUP_HANDSHAKEReady = true; } return _GROUP_HANDSHAKEContent; } }
        private static Android.Net.Wifi.SupplicantState _GROUP_HANDSHAKEContent = default;
        private static bool _GROUP_HANDSHAKEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#INACTIVE"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState INACTIVE { get { if (!_INACTIVEReady) { _INACTIVEContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "INACTIVE"); _INACTIVEReady = true; } return _INACTIVEContent; } }
        private static Android.Net.Wifi.SupplicantState _INACTIVEContent = default;
        private static bool _INACTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#INTERFACE_DISABLED"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState INTERFACE_DISABLED { get { if (!_INTERFACE_DISABLEDReady) { _INTERFACE_DISABLEDContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "INTERFACE_DISABLED"); _INTERFACE_DISABLEDReady = true; } return _INTERFACE_DISABLEDContent; } }
        private static Android.Net.Wifi.SupplicantState _INTERFACE_DISABLEDContent = default;
        private static bool _INTERFACE_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#INVALID"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState INVALID { get { if (!_INVALIDReady) { _INVALIDContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "INVALID"); _INVALIDReady = true; } return _INVALIDContent; } }
        private static Android.Net.Wifi.SupplicantState _INVALIDContent = default;
        private static bool _INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#SCANNING"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState SCANNING { get { if (!_SCANNINGReady) { _SCANNINGContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "SCANNING"); _SCANNINGReady = true; } return _SCANNINGContent; } }
        private static Android.Net.Wifi.SupplicantState _SCANNINGContent = default;
        private static bool _SCANNINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#UNINITIALIZED"/>
        /// </summary>
        public static Android.Net.Wifi.SupplicantState UNINITIALIZED { get { if (!_UNINITIALIZEDReady) { _UNINITIALIZEDContent = SGetField<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "UNINITIALIZED"); _UNINITIALIZEDReady = true; } return _UNINITIALIZEDContent; } }
        private static Android.Net.Wifi.SupplicantState _UNINITIALIZEDContent = default;
        private static bool _UNINITIALIZEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Net.Wifi.SupplicantState"/></returns>
        public static Android.Net.Wifi.SupplicantState ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#values()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.SupplicantState"/></returns>
        public static Android.Net.Wifi.SupplicantState[] Values()
        {
            return SExecuteWithSignatureArray<Android.Net.Wifi.SupplicantState>(LocalBridgeClazz, "values", "()[Landroid/net/wifi/SupplicantState;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#isValidState(android.net.wifi.SupplicantState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.SupplicantState"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsValidState(Android.Net.Wifi.SupplicantState arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isValidState", "(Landroid/net/wifi/SupplicantState;)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/SupplicantState.html#writeToParcel(android.os.Parcel,int)"/>
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