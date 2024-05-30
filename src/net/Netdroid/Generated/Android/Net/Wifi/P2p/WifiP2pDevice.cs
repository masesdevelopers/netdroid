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
    #region WifiP2pDevice
    public partial class WifiP2pDevice
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#%3Cinit%3E(android.net.wifi.p2p.WifiP2pDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.P2p.WifiP2pDevice"/></param>
        public WifiP2pDevice(Android.Net.Wifi.P2p.WifiP2pDevice arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#status"/>
        /// </summary>
        public int status { get { return IGetField<int>("status"); } set { ISetField("status", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#deviceAddress"/>
        /// </summary>
        public Java.Lang.String deviceAddress { get { return IGetField<Java.Lang.String>("deviceAddress"); } set { ISetField("deviceAddress", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#deviceName"/>
        /// </summary>
        public Java.Lang.String deviceName { get { return IGetField<Java.Lang.String>("deviceName"); } set { ISetField("deviceName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#primaryDeviceType"/>
        /// </summary>
        public Java.Lang.String primaryDeviceType { get { return IGetField<Java.Lang.String>("primaryDeviceType"); } set { ISetField("primaryDeviceType", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#secondaryDeviceType"/>
        /// </summary>
        public Java.Lang.String secondaryDeviceType { get { return IGetField<Java.Lang.String>("secondaryDeviceType"); } set { ISetField("secondaryDeviceType", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#AVAILABLE"/>
        /// </summary>
        public static int AVAILABLE { get { if (!_AVAILABLEReady) { _AVAILABLEContent = SGetField<int>(LocalBridgeClazz, "AVAILABLE"); _AVAILABLEReady = true; } return _AVAILABLEContent; } }
        private static int _AVAILABLEContent = default;
        private static bool _AVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#CONNECTED"/>
        /// </summary>
        public static int CONNECTED { get { if (!_CONNECTEDReady) { _CONNECTEDContent = SGetField<int>(LocalBridgeClazz, "CONNECTED"); _CONNECTEDReady = true; } return _CONNECTEDContent; } }
        private static int _CONNECTEDContent = default;
        private static bool _CONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#FAILED"/>
        /// </summary>
        public static int FAILED { get { if (!_FAILEDReady) { _FAILEDContent = SGetField<int>(LocalBridgeClazz, "FAILED"); _FAILEDReady = true; } return _FAILEDContent; } }
        private static int _FAILEDContent = default;
        private static bool _FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#INVITED"/>
        /// </summary>
        public static int INVITED { get { if (!_INVITEDReady) { _INVITEDContent = SGetField<int>(LocalBridgeClazz, "INVITED"); _INVITEDReady = true; } return _INVITEDContent; } }
        private static int _INVITEDContent = default;
        private static bool _INVITEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#UNAVAILABLE"/>
        /// </summary>
        public static int UNAVAILABLE { get { if (!_UNAVAILABLEReady) { _UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "UNAVAILABLE"); _UNAVAILABLEReady = true; } return _UNAVAILABLEContent; } }
        private static int _UNAVAILABLEContent = default;
        private static bool _UNAVAILABLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#getVendorElements()"/> 
        /// </summary>
        public Java.Util.List<Android.Net.Wifi.ScanResult.InformationElement> VendorElements
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Net.Wifi.ScanResult.InformationElement>>("getVendorElements", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#getWfdInfo()"/> 
        /// </summary>
        public Android.Net.Wifi.P2p.WifiP2pWfdInfo WfdInfo
        {
            get { return IExecuteWithSignature<Android.Net.Wifi.P2p.WifiP2pWfdInfo>("getWfdInfo", "()Landroid/net/wifi/p2p/WifiP2pWfdInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#isGroupOwner()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsGroupOwner()
        {
            return IExecuteWithSignature<bool>("isGroupOwner", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#isServiceDiscoveryCapable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsServiceDiscoveryCapable()
        {
            return IExecuteWithSignature<bool>("isServiceDiscoveryCapable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#wpsDisplaySupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WpsDisplaySupported()
        {
            return IExecuteWithSignature<bool>("wpsDisplaySupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#wpsKeypadSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WpsKeypadSupported()
        {
            return IExecuteWithSignature<bool>("wpsKeypadSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#wpsPbcSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WpsPbcSupported()
        {
            return IExecuteWithSignature<bool>("wpsPbcSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#update(android.net.wifi.p2p.WifiP2pDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.P2p.WifiP2pDevice"/></param>
        public void Update(Android.Net.Wifi.P2p.WifiP2pDevice arg0)
        {
            IExecuteWithSignature("update", "(Landroid/net/wifi/p2p/WifiP2pDevice;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/p2p/WifiP2pDevice.html#writeToParcel(android.os.Parcel,int)"/>
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