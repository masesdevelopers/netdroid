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

namespace Android.Net.Wifi.Aware
{
    #region PublishConfig declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html"/>
    /// </summary>
    public partial class PublishConfig : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.wifi.aware.PublishConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PublishConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PublishConfig(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.wifi.aware.PublishConfig$Builder";
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

    #region PublishConfig implementation
    public partial class PublishConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#PUBLISH_TYPE_SOLICITED"/>
        /// </summary>
        public static int PUBLISH_TYPE_SOLICITED { get { if (!_PUBLISH_TYPE_SOLICITEDReady) { _PUBLISH_TYPE_SOLICITEDContent = SGetField<int>(LocalBridgeClazz, "PUBLISH_TYPE_SOLICITED"); _PUBLISH_TYPE_SOLICITEDReady = true; } return _PUBLISH_TYPE_SOLICITEDContent; } }
        private static int _PUBLISH_TYPE_SOLICITEDContent = default;
        private static bool _PUBLISH_TYPE_SOLICITEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#PUBLISH_TYPE_UNSOLICITED"/>
        /// </summary>
        public static int PUBLISH_TYPE_UNSOLICITED { get { if (!_PUBLISH_TYPE_UNSOLICITEDReady) { _PUBLISH_TYPE_UNSOLICITEDContent = SGetField<int>(LocalBridgeClazz, "PUBLISH_TYPE_UNSOLICITED"); _PUBLISH_TYPE_UNSOLICITEDReady = true; } return _PUBLISH_TYPE_UNSOLICITEDContent; } }
        private static int _PUBLISH_TYPE_UNSOLICITEDContent = default;
        private static bool _PUBLISH_TYPE_UNSOLICITEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#getPairingConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.Aware.AwarePairingConfig"/></returns>
        public Android.Net.Wifi.Aware.AwarePairingConfig GetPairingConfig()
        {
            return IExecuteWithSignature<Android.Net.Wifi.Aware.AwarePairingConfig>("getPairingConfig", "()Landroid/net/wifi/aware/AwarePairingConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#getSecurityConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig"/></returns>
        public Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig GetSecurityConfig()
        {
            return IExecuteWithSignature<Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig>("getSecurityConfig", "()Landroid/net/wifi/aware/WifiAwareDataPathSecurityConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#isInstantCommunicationModeEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInstantCommunicationModeEnabled()
        {
            return IExecuteWithSignature<bool>("isInstantCommunicationModeEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#getInstantCommunicationBand()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInstantCommunicationBand()
        {
            return IExecuteWithSignature<int>("getInstantCommunicationBand", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
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
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig>("build", "()Landroid/net/wifi/aware/PublishConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setDataPathSecurityConfig(android.net.wifi.aware.WifiAwareDataPathSecurityConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetDataPathSecurityConfig(Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setDataPathSecurityConfig", "(Landroid/net/wifi/aware/WifiAwareDataPathSecurityConfig;)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setInstantCommunicationModeEnabled(boolean,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetInstantCommunicationModeEnabled(bool arg0, int arg1)
            {
                return IExecute<Android.Net.Wifi.Aware.PublishConfig.Builder>("setInstantCommunicationModeEnabled", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setMatchFilter(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetMatchFilter(Java.Util.List<byte[]> arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setMatchFilter", "(Ljava/util/List;)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setPairingConfig(android.net.wifi.aware.AwarePairingConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.AwarePairingConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetPairingConfig(Android.Net.Wifi.Aware.AwarePairingConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setPairingConfig", "(Landroid/net/wifi/aware/AwarePairingConfig;)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setPublishType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetPublishType(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setPublishType", "(I)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setRangingEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetRangingEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setRangingEnabled", "(Z)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setServiceName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetServiceName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setServiceName", "(Ljava/lang/String;)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setServiceSpecificInfo(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetServiceSpecificInfo(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setServiceSpecificInfo", "([B)Landroid/net/wifi/aware/PublishConfig$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setTerminateNotificationEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetTerminateNotificationEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setTerminateNotificationEnabled", "(Z)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/PublishConfig.Builder.html#setTtlSec(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.PublishConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.PublishConfig.Builder SetTtlSec(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.PublishConfig.Builder>("setTtlSec", "(I)Landroid/net/wifi/aware/PublishConfig$Builder;", arg0);
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