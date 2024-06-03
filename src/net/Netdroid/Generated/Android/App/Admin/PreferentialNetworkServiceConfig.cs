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

namespace Android.App.Admin
{
    #region PreferentialNetworkServiceConfig
    public partial class PreferentialNetworkServiceConfig
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#PREFERENTIAL_NETWORK_ID_1"/>
        /// </summary>
        public static int PREFERENTIAL_NETWORK_ID_1 { get { if (!_PREFERENTIAL_NETWORK_ID_1Ready) { _PREFERENTIAL_NETWORK_ID_1Content = SGetField<int>(LocalBridgeClazz, "PREFERENTIAL_NETWORK_ID_1"); _PREFERENTIAL_NETWORK_ID_1Ready = true; } return _PREFERENTIAL_NETWORK_ID_1Content; } }
        private static int _PREFERENTIAL_NETWORK_ID_1Content = default;
        private static bool _PREFERENTIAL_NETWORK_ID_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#PREFERENTIAL_NETWORK_ID_2"/>
        /// </summary>
        public static int PREFERENTIAL_NETWORK_ID_2 { get { if (!_PREFERENTIAL_NETWORK_ID_2Ready) { _PREFERENTIAL_NETWORK_ID_2Content = SGetField<int>(LocalBridgeClazz, "PREFERENTIAL_NETWORK_ID_2"); _PREFERENTIAL_NETWORK_ID_2Ready = true; } return _PREFERENTIAL_NETWORK_ID_2Content; } }
        private static int _PREFERENTIAL_NETWORK_ID_2Content = default;
        private static bool _PREFERENTIAL_NETWORK_ID_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#PREFERENTIAL_NETWORK_ID_3"/>
        /// </summary>
        public static int PREFERENTIAL_NETWORK_ID_3 { get { if (!_PREFERENTIAL_NETWORK_ID_3Ready) { _PREFERENTIAL_NETWORK_ID_3Content = SGetField<int>(LocalBridgeClazz, "PREFERENTIAL_NETWORK_ID_3"); _PREFERENTIAL_NETWORK_ID_3Ready = true; } return _PREFERENTIAL_NETWORK_ID_3Content; } }
        private static int _PREFERENTIAL_NETWORK_ID_3Content = default;
        private static bool _PREFERENTIAL_NETWORK_ID_3Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#PREFERENTIAL_NETWORK_ID_4"/>
        /// </summary>
        public static int PREFERENTIAL_NETWORK_ID_4 { get { if (!_PREFERENTIAL_NETWORK_ID_4Ready) { _PREFERENTIAL_NETWORK_ID_4Content = SGetField<int>(LocalBridgeClazz, "PREFERENTIAL_NETWORK_ID_4"); _PREFERENTIAL_NETWORK_ID_4Ready = true; } return _PREFERENTIAL_NETWORK_ID_4Content; } }
        private static int _PREFERENTIAL_NETWORK_ID_4Content = default;
        private static bool _PREFERENTIAL_NETWORK_ID_4Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#PREFERENTIAL_NETWORK_ID_5"/>
        /// </summary>
        public static int PREFERENTIAL_NETWORK_ID_5 { get { if (!_PREFERENTIAL_NETWORK_ID_5Ready) { _PREFERENTIAL_NETWORK_ID_5Content = SGetField<int>(LocalBridgeClazz, "PREFERENTIAL_NETWORK_ID_5"); _PREFERENTIAL_NETWORK_ID_5Ready = true; } return _PREFERENTIAL_NETWORK_ID_5Content; } }
        private static int _PREFERENTIAL_NETWORK_ID_5Content = default;
        private static bool _PREFERENTIAL_NETWORK_ID_5Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#isFallbackToDefaultConnectionAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFallbackToDefaultConnectionAllowed()
        {
            return IExecuteWithSignature<bool>("isFallbackToDefaultConnectionAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#shouldBlockNonMatchingNetworks()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldBlockNonMatchingNetworks()
        {
            return IExecuteWithSignature<bool>("shouldBlockNonMatchingNetworks", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#getNetworkId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNetworkId()
        {
            return IExecuteWithSignature<int>("getNetworkId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#getExcludedUids()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetExcludedUids()
        {
            return IExecuteWithSignatureArray<int>("getExcludedUids", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#getIncludedUids()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetIncludedUids()
        {
            return IExecuteWithSignatureArray<int>("getIncludedUids", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Admin.PreferentialNetworkServiceConfig"/></returns>
            public Android.App.Admin.PreferentialNetworkServiceConfig Build()
            {
                return IExecuteWithSignature<Android.App.Admin.PreferentialNetworkServiceConfig>("build", "()Landroid/app/admin/PreferentialNetworkServiceConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.Builder.html#setEnabled(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Admin.PreferentialNetworkServiceConfig.Builder"/></returns>
            public Android.App.Admin.PreferentialNetworkServiceConfig.Builder SetEnabled(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.PreferentialNetworkServiceConfig.Builder>("setEnabled", "(Z)Landroid/app/admin/PreferentialNetworkServiceConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.Builder.html#setExcludedUids(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Admin.PreferentialNetworkServiceConfig.Builder"/></returns>
            public Android.App.Admin.PreferentialNetworkServiceConfig.Builder SetExcludedUids(int[] arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.PreferentialNetworkServiceConfig.Builder>("setExcludedUids", "([I)Landroid/app/admin/PreferentialNetworkServiceConfig$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.Builder.html#setFallbackToDefaultConnectionAllowed(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Admin.PreferentialNetworkServiceConfig.Builder"/></returns>
            public Android.App.Admin.PreferentialNetworkServiceConfig.Builder SetFallbackToDefaultConnectionAllowed(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.PreferentialNetworkServiceConfig.Builder>("setFallbackToDefaultConnectionAllowed", "(Z)Landroid/app/admin/PreferentialNetworkServiceConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.Builder.html#setIncludedUids(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Admin.PreferentialNetworkServiceConfig.Builder"/></returns>
            public Android.App.Admin.PreferentialNetworkServiceConfig.Builder SetIncludedUids(int[] arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.PreferentialNetworkServiceConfig.Builder>("setIncludedUids", "([I)Landroid/app/admin/PreferentialNetworkServiceConfig$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.Builder.html#setNetworkId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Admin.PreferentialNetworkServiceConfig.Builder"/></returns>
            public Android.App.Admin.PreferentialNetworkServiceConfig.Builder SetNetworkId(int arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.PreferentialNetworkServiceConfig.Builder>("setNetworkId", "(I)Landroid/app/admin/PreferentialNetworkServiceConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/admin/PreferentialNetworkServiceConfig.Builder.html#setShouldBlockNonMatchingNetworks(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Admin.PreferentialNetworkServiceConfig.Builder"/></returns>
            public Android.App.Admin.PreferentialNetworkServiceConfig.Builder SetShouldBlockNonMatchingNetworks(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Admin.PreferentialNetworkServiceConfig.Builder>("setShouldBlockNonMatchingNetworks", "(Z)Landroid/app/admin/PreferentialNetworkServiceConfig$Builder;", arg0);
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