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

namespace Android.Net.Wifi
{
    #region WifiNetworkSpecifier
    public partial class WifiNetworkSpecifier
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Net.Wifi.WifiNetworkSpecifier"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Net.Wifi.WifiNetworkSpecifier t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.html#redact()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.NetworkSpecifier"/></returns>
        public Android.Net.NetworkSpecifier Redact()
        {
            return IExecuteWithSignature<Android.Net.NetworkSpecifier>("redact", "()Landroid/net/NetworkSpecifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.html#canBeSatisfiedBy(android.net.NetworkSpecifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.NetworkSpecifier"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanBeSatisfiedBy(Android.Net.NetworkSpecifier arg0)
        {
            return IExecuteWithSignature<bool>("canBeSatisfiedBy", "(Landroid/net/NetworkSpecifier;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.html#getBand()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBand()
        {
            return IExecuteWithSignature<int>("getBand", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.html#getPreferredChannelFrequenciesMhz()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetPreferredChannelFrequenciesMhz()
        {
            return IExecuteWithSignatureArray<int>("getPreferredChannelFrequenciesMhz", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier>("build", "()Landroid/net/wifi/WifiNetworkSpecifier;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setBand(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetBand(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setBand", "(I)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setBssid(android.net.MacAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.MacAddress"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetBssid(Android.Net.MacAddress arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setBssid", "(Landroid/net/MacAddress;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setBssidPattern(android.net.MacAddress,android.net.MacAddress)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.MacAddress"/></param>
            /// <param name="arg1"><see cref="Android.Net.MacAddress"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetBssidPattern(Android.Net.MacAddress arg0, Android.Net.MacAddress arg1)
            {
                return IExecute<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setBssidPattern", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setIsEnhancedOpen(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetIsEnhancedOpen(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setIsEnhancedOpen", "(Z)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setIsHiddenSsid(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetIsHiddenSsid(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setIsHiddenSsid", "(Z)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setPreferredChannelsFrequenciesMhz(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetPreferredChannelsFrequenciesMhz(int[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setPreferredChannelsFrequenciesMhz", "([I)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setSsid(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetSsid(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setSsid", "(Ljava/lang/String;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setSsidPattern(android.os.PatternMatcher)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.PatternMatcher"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetSsidPattern(Android.Os.PatternMatcher arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setSsidPattern", "(Landroid/os/PatternMatcher;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setWpa2EnterpriseConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetWpa2EnterpriseConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setWpa2EnterpriseConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setWpa2Passphrase(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetWpa2Passphrase(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setWpa2Passphrase", "(Ljava/lang/String;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setWpa3Enterprise192BitModeConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetWpa3Enterprise192BitModeConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setWpa3Enterprise192BitModeConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setWpa3EnterpriseConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetWpa3EnterpriseConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setWpa3EnterpriseConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setWpa3EnterpriseStandardModeConfig(android.net.wifi.WifiEnterpriseConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Wifi.WifiEnterpriseConfig"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetWpa3EnterpriseStandardModeConfig(Android.Net.Wifi.WifiEnterpriseConfig arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setWpa3EnterpriseStandardModeConfig", "(Landroid/net/wifi/WifiEnterpriseConfig;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/WifiNetworkSpecifier.Builder.html#setWpa3Passphrase(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.WifiNetworkSpecifier.Builder"/></returns>
            public Android.Net.Wifi.WifiNetworkSpecifier.Builder SetWpa3Passphrase(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.WifiNetworkSpecifier.Builder>("setWpa3Passphrase", "(Ljava/lang/String;)Landroid/net/wifi/WifiNetworkSpecifier$Builder;", arg0);
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