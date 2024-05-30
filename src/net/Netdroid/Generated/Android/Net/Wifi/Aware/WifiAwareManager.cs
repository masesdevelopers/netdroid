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

namespace Android.Net.Wifi.Aware
{
    #region WifiAwareManager
    public partial class WifiAwareManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#WIFI_AWARE_DATA_PATH_ROLE_INITIATOR"/>
        /// </summary>
        public static int WIFI_AWARE_DATA_PATH_ROLE_INITIATOR { get { if (!_WIFI_AWARE_DATA_PATH_ROLE_INITIATORReady) { _WIFI_AWARE_DATA_PATH_ROLE_INITIATORContent = SGetField<int>(LocalBridgeClazz, "WIFI_AWARE_DATA_PATH_ROLE_INITIATOR"); _WIFI_AWARE_DATA_PATH_ROLE_INITIATORReady = true; } return _WIFI_AWARE_DATA_PATH_ROLE_INITIATORContent; } }
        private static int _WIFI_AWARE_DATA_PATH_ROLE_INITIATORContent = default;
        private static bool _WIFI_AWARE_DATA_PATH_ROLE_INITIATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#WIFI_AWARE_DATA_PATH_ROLE_RESPONDER"/>
        /// </summary>
        public static int WIFI_AWARE_DATA_PATH_ROLE_RESPONDER { get { if (!_WIFI_AWARE_DATA_PATH_ROLE_RESPONDERReady) { _WIFI_AWARE_DATA_PATH_ROLE_RESPONDERContent = SGetField<int>(LocalBridgeClazz, "WIFI_AWARE_DATA_PATH_ROLE_RESPONDER"); _WIFI_AWARE_DATA_PATH_ROLE_RESPONDERReady = true; } return _WIFI_AWARE_DATA_PATH_ROLE_RESPONDERContent; } }
        private static int _WIFI_AWARE_DATA_PATH_ROLE_RESPONDERContent = default;
        private static bool _WIFI_AWARE_DATA_PATH_ROLE_RESPONDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLE"/>
        /// </summary>
        public static int WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLE { get { if (!_WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLEReady) { _WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLEContent = SGetField<int>(LocalBridgeClazz, "WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLE"); _WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLEReady = true; } return _WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLEContent; } }
        private static int _WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLEContent = default;
        private static bool _WIFI_AWARE_DISCOVERY_LOST_REASON_PEER_NOT_VISIBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWN"/>
        /// </summary>
        public static int WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWN { get { if (!_WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWNReady) { _WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWN"); _WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWNReady = true; } return _WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWNContent; } }
        private static int _WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWNContent = default;
        private static bool _WIFI_AWARE_DISCOVERY_LOST_REASON_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#ACTION_WIFI_AWARE_RESOURCE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_WIFI_AWARE_RESOURCE_CHANGED { get { if (!_ACTION_WIFI_AWARE_RESOURCE_CHANGEDReady) { _ACTION_WIFI_AWARE_RESOURCE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_WIFI_AWARE_RESOURCE_CHANGED"); _ACTION_WIFI_AWARE_RESOURCE_CHANGEDReady = true; } return _ACTION_WIFI_AWARE_RESOURCE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_WIFI_AWARE_RESOURCE_CHANGEDContent = default;
        private static bool _ACTION_WIFI_AWARE_RESOURCE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#ACTION_WIFI_AWARE_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_WIFI_AWARE_STATE_CHANGED { get { if (!_ACTION_WIFI_AWARE_STATE_CHANGEDReady) { _ACTION_WIFI_AWARE_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_WIFI_AWARE_STATE_CHANGED"); _ACTION_WIFI_AWARE_STATE_CHANGEDReady = true; } return _ACTION_WIFI_AWARE_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_WIFI_AWARE_STATE_CHANGEDContent = default;
        private static bool _ACTION_WIFI_AWARE_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#EXTRA_AWARE_RESOURCES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_AWARE_RESOURCES { get { if (!_EXTRA_AWARE_RESOURCESReady) { _EXTRA_AWARE_RESOURCESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_AWARE_RESOURCES"); _EXTRA_AWARE_RESOURCESReady = true; } return _EXTRA_AWARE_RESOURCESContent; } }
        private static Java.Lang.String _EXTRA_AWARE_RESOURCESContent = default;
        private static bool _EXTRA_AWARE_RESOURCESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#getAvailableAwareResources()"/> 
        /// </summary>
        public Android.Net.Wifi.Aware.AwareResources AvailableAwareResources
        {
            get { return IExecuteWithSignature<Android.Net.Wifi.Aware.AwareResources>("getAvailableAwareResources", "()Landroid/net/wifi/aware/AwareResources;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#getCharacteristics()"/> 
        /// </summary>
        public Android.Net.Wifi.Aware.Characteristics Characteristics
        {
            get { return IExecuteWithSignature<Android.Net.Wifi.Aware.Characteristics>("getCharacteristics", "()Landroid/net/wifi/aware/Characteristics;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#isAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAvailable()
        {
            return IExecuteWithSignature<bool>("isAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#isDeviceAttached()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeviceAttached()
        {
            return IExecuteWithSignature<bool>("isDeviceAttached", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#isInstantCommunicationModeEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInstantCommunicationModeEnabled()
        {
            return IExecuteWithSignature<bool>("isInstantCommunicationModeEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#isSetChannelOnDataPathSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSetChannelOnDataPathSupported()
        {
            return IExecuteWithSignature<bool>("isSetChannelOnDataPathSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#attach(android.net.wifi.aware.AttachCallback,android.net.wifi.aware.IdentityChangedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.AttachCallback"/></param>
        /// <param name="arg1"><see cref="Android.Net.Wifi.Aware.IdentityChangedListener"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void Attach(Android.Net.Wifi.Aware.AttachCallback arg0, Android.Net.Wifi.Aware.IdentityChangedListener arg1, Android.Os.Handler arg2)
        {
            IExecute("attach", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#attach(android.net.wifi.aware.AttachCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.AttachCallback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void Attach(Android.Net.Wifi.Aware.AttachCallback arg0, Android.Os.Handler arg1)
        {
            IExecute("attach", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#getPairedDevices(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetPairedDevices(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Java.Util.List<Java.Lang.String>> arg1)
        {
            IExecute("getPairedDevices", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#isOpportunisticModeEnabled(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void IsOpportunisticModeEnabled(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Java.Lang.Boolean> arg1)
        {
            IExecute("isOpportunisticModeEnabled", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#removePairedDevice(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemovePairedDevice(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removePairedDevice", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#resetPairedDevices()"/>
        /// </summary>
        public void ResetPairedDevices()
        {
            IExecuteWithSignature("resetPairedDevices", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareManager.html#setOpportunisticModeEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOpportunisticModeEnabled(bool arg0)
        {
            IExecuteWithSignature("setOpportunisticModeEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}