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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Wifi.P2p
{
    #region WifiP2pWfdInfo
    public partial class WifiP2pWfdInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#%3Cinit%3E(android.net.wifi.p2p.WifiP2pWfdInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.P2p.WifiP2pWfdInfo"/></param>
        public WifiP2pWfdInfo(Android.Net.Wifi.P2p.WifiP2pWfdInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCE"/>
        /// </summary>
        public static int DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCE { get { if (!_DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCEReady) { _DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCEContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCE"); _DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCEReady = true; } return _DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCEContent; } }
        private static int _DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCEContent = default;
        private static bool _DEVICE_INFO_AUDIO_ONLY_SUPPORT_AT_SOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINK"/>
        /// </summary>
        public static int DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINK { get { if (!_DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINKReady) { _DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINK"); _DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINKReady = true; } return _DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINKContent; } }
        private static int _DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINKContent = default;
        private static bool _DEVICE_INFO_AUDIO_UNSUPPORTED_AT_PRIMARY_SINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_CONTENT_PROTECTION_SUPPORT"/>
        /// </summary>
        public static int DEVICE_INFO_CONTENT_PROTECTION_SUPPORT { get { if (!_DEVICE_INFO_CONTENT_PROTECTION_SUPPORTReady) { _DEVICE_INFO_CONTENT_PROTECTION_SUPPORTContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_CONTENT_PROTECTION_SUPPORT"); _DEVICE_INFO_CONTENT_PROTECTION_SUPPORTReady = true; } return _DEVICE_INFO_CONTENT_PROTECTION_SUPPORTContent; } }
        private static int _DEVICE_INFO_CONTENT_PROTECTION_SUPPORTContent = default;
        private static bool _DEVICE_INFO_CONTENT_PROTECTION_SUPPORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINK"/>
        /// </summary>
        public static int DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINK { get { if (!_DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINKReady) { _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINK"); _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINKReady = true; } return _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINKContent; } }
        private static int _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINKContent = default;
        private static bool _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCE"/>
        /// </summary>
        public static int DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCE { get { if (!_DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCEReady) { _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCEContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCE"); _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCEReady = true; } return _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCEContent; } }
        private static int _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCEContent = default;
        private static bool _DEVICE_INFO_COUPLED_SINK_SUPPORT_AT_SOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_DEVICE_TYPE_MASK"/>
        /// </summary>
        public static int DEVICE_INFO_DEVICE_TYPE_MASK { get { if (!_DEVICE_INFO_DEVICE_TYPE_MASKReady) { _DEVICE_INFO_DEVICE_TYPE_MASKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_DEVICE_TYPE_MASK"); _DEVICE_INFO_DEVICE_TYPE_MASKReady = true; } return _DEVICE_INFO_DEVICE_TYPE_MASKContent; } }
        private static int _DEVICE_INFO_DEVICE_TYPE_MASKContent = default;
        private static bool _DEVICE_INFO_DEVICE_TYPE_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_PREFERRED_CONNECTIVITY_MASK"/>
        /// </summary>
        public static int DEVICE_INFO_PREFERRED_CONNECTIVITY_MASK { get { if (!_DEVICE_INFO_PREFERRED_CONNECTIVITY_MASKReady) { _DEVICE_INFO_PREFERRED_CONNECTIVITY_MASKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_PREFERRED_CONNECTIVITY_MASK"); _DEVICE_INFO_PREFERRED_CONNECTIVITY_MASKReady = true; } return _DEVICE_INFO_PREFERRED_CONNECTIVITY_MASKContent; } }
        private static int _DEVICE_INFO_PREFERRED_CONNECTIVITY_MASKContent = default;
        private static bool _DEVICE_INFO_PREFERRED_CONNECTIVITY_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_SESSION_AVAILABLE_MASK"/>
        /// </summary>
        public static int DEVICE_INFO_SESSION_AVAILABLE_MASK { get { if (!_DEVICE_INFO_SESSION_AVAILABLE_MASKReady) { _DEVICE_INFO_SESSION_AVAILABLE_MASKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_SESSION_AVAILABLE_MASK"); _DEVICE_INFO_SESSION_AVAILABLE_MASKReady = true; } return _DEVICE_INFO_SESSION_AVAILABLE_MASKContent; } }
        private static int _DEVICE_INFO_SESSION_AVAILABLE_MASKContent = default;
        private static bool _DEVICE_INFO_SESSION_AVAILABLE_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_TDLS_PERSISTENT_GROUP"/>
        /// </summary>
        public static int DEVICE_INFO_TDLS_PERSISTENT_GROUP { get { if (!_DEVICE_INFO_TDLS_PERSISTENT_GROUPReady) { _DEVICE_INFO_TDLS_PERSISTENT_GROUPContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_TDLS_PERSISTENT_GROUP"); _DEVICE_INFO_TDLS_PERSISTENT_GROUPReady = true; } return _DEVICE_INFO_TDLS_PERSISTENT_GROUPContent; } }
        private static int _DEVICE_INFO_TDLS_PERSISTENT_GROUPContent = default;
        private static bool _DEVICE_INFO_TDLS_PERSISTENT_GROUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKE"/>
        /// </summary>
        public static int DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKE { get { if (!_DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKEReady) { _DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKEContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKE"); _DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKEReady = true; } return _DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKEContent; } }
        private static int _DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKEContent = default;
        private static bool _DEVICE_INFO_TDLS_PERSISTENT_GROUP_REINVOKEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORT"/>
        /// </summary>
        public static int DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORT { get { if (!_DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORTReady) { _DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORTContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORT"); _DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORTReady = true; } return _DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORTContent; } }
        private static int _DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORTContent = default;
        private static bool _DEVICE_INFO_TIME_SYNCHRONIZATION_SUPPORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORT"/>
        /// </summary>
        public static int DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORT { get { if (!_DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORTReady) { _DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORTContent = SGetField<int>(LocalBridgeClazz, "DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORT"); _DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORTReady = true; } return _DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORTContent; } }
        private static int _DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORTContent = default;
        private static bool _DEVICE_INFO_WFD_SERVICE_DISCOVERY_SUPPORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_TYPE_PRIMARY_SINK"/>
        /// </summary>
        public static int DEVICE_TYPE_PRIMARY_SINK { get { if (!_DEVICE_TYPE_PRIMARY_SINKReady) { _DEVICE_TYPE_PRIMARY_SINKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TYPE_PRIMARY_SINK"); _DEVICE_TYPE_PRIMARY_SINKReady = true; } return _DEVICE_TYPE_PRIMARY_SINKContent; } }
        private static int _DEVICE_TYPE_PRIMARY_SINKContent = default;
        private static bool _DEVICE_TYPE_PRIMARY_SINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_TYPE_SECONDARY_SINK"/>
        /// </summary>
        public static int DEVICE_TYPE_SECONDARY_SINK { get { if (!_DEVICE_TYPE_SECONDARY_SINKReady) { _DEVICE_TYPE_SECONDARY_SINKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TYPE_SECONDARY_SINK"); _DEVICE_TYPE_SECONDARY_SINKReady = true; } return _DEVICE_TYPE_SECONDARY_SINKContent; } }
        private static int _DEVICE_TYPE_SECONDARY_SINKContent = default;
        private static bool _DEVICE_TYPE_SECONDARY_SINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_TYPE_SOURCE_OR_PRIMARY_SINK"/>
        /// </summary>
        public static int DEVICE_TYPE_SOURCE_OR_PRIMARY_SINK { get { if (!_DEVICE_TYPE_SOURCE_OR_PRIMARY_SINKReady) { _DEVICE_TYPE_SOURCE_OR_PRIMARY_SINKContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TYPE_SOURCE_OR_PRIMARY_SINK"); _DEVICE_TYPE_SOURCE_OR_PRIMARY_SINKReady = true; } return _DEVICE_TYPE_SOURCE_OR_PRIMARY_SINKContent; } }
        private static int _DEVICE_TYPE_SOURCE_OR_PRIMARY_SINKContent = default;
        private static bool _DEVICE_TYPE_SOURCE_OR_PRIMARY_SINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#DEVICE_TYPE_WFD_SOURCE"/>
        /// </summary>
        public static int DEVICE_TYPE_WFD_SOURCE { get { if (!_DEVICE_TYPE_WFD_SOURCEReady) { _DEVICE_TYPE_WFD_SOURCEContent = SGetField<int>(LocalBridgeClazz, "DEVICE_TYPE_WFD_SOURCE"); _DEVICE_TYPE_WFD_SOURCEReady = true; } return _DEVICE_TYPE_WFD_SOURCEContent; } }
        private static int _DEVICE_TYPE_WFD_SOURCEContent = default;
        private static bool _DEVICE_TYPE_WFD_SOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#PREFERRED_CONNECTIVITY_P2P"/>
        /// </summary>
        public static int PREFERRED_CONNECTIVITY_P2P { get { if (!_PREFERRED_CONNECTIVITY_P2PReady) { _PREFERRED_CONNECTIVITY_P2PContent = SGetField<int>(LocalBridgeClazz, "PREFERRED_CONNECTIVITY_P2P"); _PREFERRED_CONNECTIVITY_P2PReady = true; } return _PREFERRED_CONNECTIVITY_P2PContent; } }
        private static int _PREFERRED_CONNECTIVITY_P2PContent = default;
        private static bool _PREFERRED_CONNECTIVITY_P2PReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#PREFERRED_CONNECTIVITY_TDLS"/>
        /// </summary>
        public static int PREFERRED_CONNECTIVITY_TDLS { get { if (!_PREFERRED_CONNECTIVITY_TDLSReady) { _PREFERRED_CONNECTIVITY_TDLSContent = SGetField<int>(LocalBridgeClazz, "PREFERRED_CONNECTIVITY_TDLS"); _PREFERRED_CONNECTIVITY_TDLSReady = true; } return _PREFERRED_CONNECTIVITY_TDLSContent; } }
        private static int _PREFERRED_CONNECTIVITY_TDLSContent = default;
        private static bool _PREFERRED_CONNECTIVITY_TDLSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#getControlPort()"/> <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setControlPort(int)"/>
        /// </summary>
        public int ControlPort
        {
            get { return IExecuteWithSignature<int>("getControlPort", "()I"); } set { IExecuteWithSignature("setControlPort", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#getDeviceInfo()"/> 
        /// </summary>
        public int DeviceInfo
        {
            get { return IExecuteWithSignature<int>("getDeviceInfo", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#getDeviceType()"/> 
        /// </summary>
        public int DeviceType
        {
            get { return IExecuteWithSignature<int>("getDeviceType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#getMaxThroughput()"/> <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setMaxThroughput(int)"/>
        /// </summary>
        public int MaxThroughput
        {
            get { return IExecuteWithSignature<int>("getMaxThroughput", "()I"); } set { IExecuteWithSignature("setMaxThroughput", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#getR2DeviceInfo()"/> 
        /// </summary>
        public int R2DeviceInfo
        {
            get { return IExecuteWithSignature<int>("getR2DeviceInfo", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#getR2DeviceType()"/> 
        /// </summary>
        public int R2DeviceType
        {
            get { return IExecuteWithSignature<int>("getR2DeviceType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#isContentProtectionSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsContentProtectionSupported()
        {
            return IExecuteWithSignature<bool>("isContentProtectionSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#isCoupledSinkSupportedAtSink()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCoupledSinkSupportedAtSink()
        {
            return IExecuteWithSignature<bool>("isCoupledSinkSupportedAtSink", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#isCoupledSinkSupportedAtSource()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCoupledSinkSupportedAtSource()
        {
            return IExecuteWithSignature<bool>("isCoupledSinkSupportedAtSource", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#isR2Supported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsR2Supported()
        {
            return IExecuteWithSignature<bool>("isR2Supported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#isSessionAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSessionAvailable()
        {
            return IExecuteWithSignature<bool>("isSessionAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setDeviceType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetDeviceType(int arg0)
        {
            return IExecuteWithSignature<bool>("setDeviceType", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setR2DeviceType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetR2DeviceType(int arg0)
        {
            return IExecuteWithSignature<bool>("setR2DeviceType", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setContentProtectionSupported(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetContentProtectionSupported(bool arg0)
        {
            IExecuteWithSignature("setContentProtectionSupported", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setCoupledSinkSupportAtSink(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCoupledSinkSupportAtSink(bool arg0)
        {
            IExecuteWithSignature("setCoupledSinkSupportAtSink", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setCoupledSinkSupportAtSource(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCoupledSinkSupportAtSource(bool arg0)
        {
            IExecuteWithSignature("setCoupledSinkSupportAtSource", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#setSessionAvailable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSessionAvailable(bool arg0)
        {
            IExecuteWithSignature("setSessionAvailable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pWfdInfo.html#writeToParcel(android.os.Parcel,int)"/>
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