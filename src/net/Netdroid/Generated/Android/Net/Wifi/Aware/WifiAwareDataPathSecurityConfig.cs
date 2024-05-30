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
    #region WifiAwareDataPathSecurityConfig
    public partial class WifiAwareDataPathSecurityConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.html#getCipherSuite()"/> 
        /// </summary>
        public int CipherSuite
        {
            get { return IExecuteWithSignature<int>("getCipherSuite", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.html#getPmk()"/> 
        /// </summary>
        public byte[] Pmk
        {
            get { return IExecuteWithSignatureArray<byte>("getPmk", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.html#getPmkId()"/> 
        /// </summary>
        public byte[] PmkId
        {
            get { return IExecuteWithSignatureArray<byte>("getPmkId", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.html#getPskPassphrase()"/> 
        /// </summary>
        public Java.Lang.String PskPassphrase
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPskPassphrase", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig"/></returns>
            public Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig Build()
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig>("build", "()Landroid/net/wifi/aware/WifiAwareDataPathSecurityConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.Builder.html#setPmk(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder SetPmk(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder>("setPmk", "([B)Landroid/net/wifi/aware/WifiAwareDataPathSecurityConfig$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.Builder.html#setPmkId(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder SetPmkId(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder>("setPmkId", "([B)Landroid/net/wifi/aware/WifiAwareDataPathSecurityConfig$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/wifi/aware/WifiAwareDataPathSecurityConfig.Builder.html#setPskPassphrase(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder"/></returns>
            public Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder SetPskPassphrase(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Wifi.Aware.WifiAwareDataPathSecurityConfig.Builder>("setPskPassphrase", "(Ljava/lang/String;)Landroid/net/wifi/aware/WifiAwareDataPathSecurityConfig$Builder;", arg0);
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