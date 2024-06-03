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
    #region WifiP2pConfig
    public partial class WifiP2pConfig
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#%3Cinit%3E(android.net.wifi.p2p.WifiP2pConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.P2p.WifiP2pConfig"/></param>
        public WifiP2pConfig(Android.Net.Wifi.P2p.WifiP2pConfig arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#wps"/>
        /// </summary>
        public Android.Net.Wifi.WpsInfo wps { get { return IGetField<Android.Net.Wifi.WpsInfo>("wps"); } set { ISetField("wps", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#groupOwnerIntent"/>
        /// </summary>
        public int groupOwnerIntent { get { return IGetField<int>("groupOwnerIntent"); } set { ISetField("groupOwnerIntent", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#deviceAddress"/>
        /// </summary>
        public Java.Lang.String deviceAddress { get { return IGetField<Java.Lang.String>("deviceAddress"); } set { ISetField("deviceAddress", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCP"/>
        /// </summary>
        public static int GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCP { get { if (!_GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCPReady) { _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCPContent = SGetField<int>(LocalBridgeClazz, "GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCP"); _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCPReady = true; } return _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCPContent; } }
        private static int _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCPContent = default;
        private static bool _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV4_DHCPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCAL"/>
        /// </summary>
        public static int GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCAL { get { if (!_GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCALReady) { _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCALContent = SGetField<int>(LocalBridgeClazz, "GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCAL"); _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCALReady = true; } return _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCALContent; } }
        private static int _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCALContent = default;
        private static bool _GROUP_CLIENT_IP_PROVISIONING_MODE_IPV6_LINK_LOCALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_OWNER_BAND_2GHZ"/>
        /// </summary>
        public static int GROUP_OWNER_BAND_2GHZ { get { if (!_GROUP_OWNER_BAND_2GHZReady) { _GROUP_OWNER_BAND_2GHZContent = SGetField<int>(LocalBridgeClazz, "GROUP_OWNER_BAND_2GHZ"); _GROUP_OWNER_BAND_2GHZReady = true; } return _GROUP_OWNER_BAND_2GHZContent; } }
        private static int _GROUP_OWNER_BAND_2GHZContent = default;
        private static bool _GROUP_OWNER_BAND_2GHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_OWNER_BAND_5GHZ"/>
        /// </summary>
        public static int GROUP_OWNER_BAND_5GHZ { get { if (!_GROUP_OWNER_BAND_5GHZReady) { _GROUP_OWNER_BAND_5GHZContent = SGetField<int>(LocalBridgeClazz, "GROUP_OWNER_BAND_5GHZ"); _GROUP_OWNER_BAND_5GHZReady = true; } return _GROUP_OWNER_BAND_5GHZContent; } }
        private static int _GROUP_OWNER_BAND_5GHZContent = default;
        private static bool _GROUP_OWNER_BAND_5GHZReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_OWNER_BAND_AUTO"/>
        /// </summary>
        public static int GROUP_OWNER_BAND_AUTO { get { if (!_GROUP_OWNER_BAND_AUTOReady) { _GROUP_OWNER_BAND_AUTOContent = SGetField<int>(LocalBridgeClazz, "GROUP_OWNER_BAND_AUTO"); _GROUP_OWNER_BAND_AUTOReady = true; } return _GROUP_OWNER_BAND_AUTOContent; } }
        private static int _GROUP_OWNER_BAND_AUTOContent = default;
        private static bool _GROUP_OWNER_BAND_AUTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_OWNER_INTENT_AUTO"/>
        /// </summary>
        public static int GROUP_OWNER_INTENT_AUTO { get { if (!_GROUP_OWNER_INTENT_AUTOReady) { _GROUP_OWNER_INTENT_AUTOContent = SGetField<int>(LocalBridgeClazz, "GROUP_OWNER_INTENT_AUTO"); _GROUP_OWNER_INTENT_AUTOReady = true; } return _GROUP_OWNER_INTENT_AUTOContent; } }
        private static int _GROUP_OWNER_INTENT_AUTOContent = default;
        private static bool _GROUP_OWNER_INTENT_AUTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_OWNER_INTENT_MAX"/>
        /// </summary>
        public static int GROUP_OWNER_INTENT_MAX { get { if (!_GROUP_OWNER_INTENT_MAXReady) { _GROUP_OWNER_INTENT_MAXContent = SGetField<int>(LocalBridgeClazz, "GROUP_OWNER_INTENT_MAX"); _GROUP_OWNER_INTENT_MAXReady = true; } return _GROUP_OWNER_INTENT_MAXContent; } }
        private static int _GROUP_OWNER_INTENT_MAXContent = default;
        private static bool _GROUP_OWNER_INTENT_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#GROUP_OWNER_INTENT_MIN"/>
        /// </summary>
        public static int GROUP_OWNER_INTENT_MIN { get { if (!_GROUP_OWNER_INTENT_MINReady) { _GROUP_OWNER_INTENT_MINContent = SGetField<int>(LocalBridgeClazz, "GROUP_OWNER_INTENT_MIN"); _GROUP_OWNER_INTENT_MINReady = true; } return _GROUP_OWNER_INTENT_MINContent; } }
        private static int _GROUP_OWNER_INTENT_MINContent = default;
        private static bool _GROUP_OWNER_INTENT_MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#getGroupClientIpProvisioningMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGroupClientIpProvisioningMode()
        {
            return IExecuteWithSignature<int>("getGroupClientIpProvisioningMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#getGroupOwnerBand()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGroupOwnerBand()
        {
            return IExecuteWithSignature<int>("getGroupOwnerBand", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#getNetworkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNetworkId()
        {
            return IExecuteWithSignature<int>("getNetworkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#getNetworkName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNetworkName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNetworkName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#getPassphrase()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPassphrase()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPassphrase", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
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
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig>("build", "()Landroid/net/wifi/p2p/WifiP2pConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#enablePersistentMode(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig.Builder"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig.Builder EnablePersistentMode(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig.Builder>("enablePersistentMode", "(Z)Landroid/net/wifi/p2p/WifiP2pConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#setDeviceAddress(android.net.MacAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.MacAddress"/></param>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig.Builder"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig.Builder SetDeviceAddress(Android.Net.MacAddress arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig.Builder>("setDeviceAddress", "(Landroid/net/MacAddress;)Landroid/net/wifi/p2p/WifiP2pConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#setGroupClientIpProvisioningMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig.Builder"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig.Builder SetGroupClientIpProvisioningMode(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig.Builder>("setGroupClientIpProvisioningMode", "(I)Landroid/net/wifi/p2p/WifiP2pConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#setGroupOperatingBand(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig.Builder"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig.Builder SetGroupOperatingBand(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig.Builder>("setGroupOperatingBand", "(I)Landroid/net/wifi/p2p/WifiP2pConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#setGroupOperatingFrequency(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig.Builder"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig.Builder SetGroupOperatingFrequency(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig.Builder>("setGroupOperatingFrequency", "(I)Landroid/net/wifi/p2p/WifiP2pConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#setNetworkName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig.Builder"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig.Builder SetNetworkName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig.Builder>("setNetworkName", "(Ljava/lang/String;)Landroid/net/wifi/p2p/WifiP2pConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pConfig.Builder.html#setPassphrase(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.P2p.WifiP2pConfig.Builder"/></returns>
            public Android.Net.Wifi.P2p.WifiP2pConfig.Builder SetPassphrase(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pConfig.Builder>("setPassphrase", "(Ljava/lang/String;)Landroid/net/wifi/p2p/WifiP2pConfig$Builder;", arg0);
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