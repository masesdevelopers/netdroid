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

namespace Android.Adservices.Customaudience
{
    #region CustomAudience declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html"/>
    /// </summary>
    public partial class CustomAudience : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.adservices.customaudience.CustomAudience";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CustomAudience() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CustomAudience(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.customaudience.CustomAudience$Builder";
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

    #region CustomAudience implementation
    public partial class CustomAudience
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#FLAG_AUCTION_SERVER_REQUEST_OMIT_ADS"/>
        /// </summary>
        public static int FLAG_AUCTION_SERVER_REQUEST_OMIT_ADS { get { if (!_FLAG_AUCTION_SERVER_REQUEST_OMIT_ADSReady) { _FLAG_AUCTION_SERVER_REQUEST_OMIT_ADSContent = SGetField<int>(LocalBridgeClazz, "FLAG_AUCTION_SERVER_REQUEST_OMIT_ADS"); _FLAG_AUCTION_SERVER_REQUEST_OMIT_ADSReady = true; } return _FLAG_AUCTION_SERVER_REQUEST_OMIT_ADSContent; } }
        private static int _FLAG_AUCTION_SERVER_REQUEST_OMIT_ADSContent = default;
        private static bool _FLAG_AUCTION_SERVER_REQUEST_OMIT_ADSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getUserBiddingSignals()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdSelectionSignals"/></returns>
        public Android.Adservices.Common.AdSelectionSignals GetUserBiddingSignals()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdSelectionSignals>("getUserBiddingSignals", "()Landroid/adservices/common/AdSelectionSignals;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getBuyer()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdTechIdentifier"/></returns>
        public Android.Adservices.Common.AdTechIdentifier GetBuyer()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdTechIdentifier>("getBuyer", "()Landroid/adservices/common/AdTechIdentifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getTrustedBiddingData()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Customaudience.TrustedBiddingData"/></returns>
        public Android.Adservices.Customaudience.TrustedBiddingData GetTrustedBiddingData()
        {
            return IExecuteWithSignature<Android.Adservices.Customaudience.TrustedBiddingData>("getTrustedBiddingData", "()Landroid/adservices/customaudience/TrustedBiddingData;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getBiddingLogicUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetBiddingLogicUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getBiddingLogicUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getDailyUpdateUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetDailyUpdateUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getDailyUpdateUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getAuctionServerRequestFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAuctionServerRequestFlags()
        {
            return IExecuteWithSignature<int>("getAuctionServerRequestFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getActivationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetActivationTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getActivationTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getExpirationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant GetExpirationTime()
        {
            return IExecuteWithSignature<Java.Time.Instant>("getExpirationTime", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#getAds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Common.AdData> GetAds()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Common.AdData>>("getAds", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience"/></returns>
            public Android.Adservices.Customaudience.CustomAudience Build()
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience>("build", "()Landroid/adservices/customaudience/CustomAudience;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setActivationTime(java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetActivationTime(Java.Time.Instant arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setActivationTime", "(Ljava/time/Instant;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setAds(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetAds(Java.Util.List<Android.Adservices.Common.AdData> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setAds", "(Ljava/util/List;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setAuctionServerRequestFlags(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetAuctionServerRequestFlags(int arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setAuctionServerRequestFlags", "(I)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setBiddingLogicUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetBiddingLogicUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setBiddingLogicUri", "(Landroid/net/Uri;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setBuyer(android.adservices.common.AdTechIdentifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdTechIdentifier"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetBuyer(Android.Adservices.Common.AdTechIdentifier arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setBuyer", "(Landroid/adservices/common/AdTechIdentifier;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setDailyUpdateUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetDailyUpdateUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setDailyUpdateUri", "(Landroid/net/Uri;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setExpirationTime(java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetExpirationTime(Java.Time.Instant arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setExpirationTime", "(Ljava/time/Instant;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setName", "(Ljava/lang/String;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setTrustedBiddingData(android.adservices.customaudience.TrustedBiddingData)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Customaudience.TrustedBiddingData"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetTrustedBiddingData(Android.Adservices.Customaudience.TrustedBiddingData arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setTrustedBiddingData", "(Landroid/adservices/customaudience/TrustedBiddingData;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/CustomAudience.Builder.html#setUserBiddingSignals(android.adservices.common.AdSelectionSignals)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdSelectionSignals"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.CustomAudience.Builder"/></returns>
            public Android.Adservices.Customaudience.CustomAudience.Builder SetUserBiddingSignals(Android.Adservices.Common.AdSelectionSignals arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.CustomAudience.Builder>("setUserBiddingSignals", "(Landroid/adservices/common/AdSelectionSignals;)Landroid/adservices/customaudience/CustomAudience$Builder;", arg0);
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