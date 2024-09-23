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

namespace Android.Media.Tv.Interactive
{
    #region TvInteractiveAppServiceInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html"/>
    /// </summary>
    public partial class TvInteractiveAppServiceInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.media.tv.interactive.TvInteractiveAppServiceInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TvInteractiveAppServiceInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TvInteractiveAppServiceInfo(params object[] args) : base(args) { }

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

    #region TvInteractiveAppServiceInfo implementation
    public partial class TvInteractiveAppServiceInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#%3Cinit%3E(android.content.Context,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        public TvInteractiveAppServiceInfo(Android.Content.Context arg0, Android.Content.ComponentName arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#INTERACTIVE_APP_TYPE_ATSC"/>
        /// </summary>
        public static int INTERACTIVE_APP_TYPE_ATSC { get { if (!_INTERACTIVE_APP_TYPE_ATSCReady) { _INTERACTIVE_APP_TYPE_ATSCContent = SGetField<int>(LocalBridgeClazz, "INTERACTIVE_APP_TYPE_ATSC"); _INTERACTIVE_APP_TYPE_ATSCReady = true; } return _INTERACTIVE_APP_TYPE_ATSCContent; } }
        private static int _INTERACTIVE_APP_TYPE_ATSCContent = default;
        private static bool _INTERACTIVE_APP_TYPE_ATSCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#INTERACTIVE_APP_TYPE_GINGA"/>
        /// </summary>
        public static int INTERACTIVE_APP_TYPE_GINGA { get { if (!_INTERACTIVE_APP_TYPE_GINGAReady) { _INTERACTIVE_APP_TYPE_GINGAContent = SGetField<int>(LocalBridgeClazz, "INTERACTIVE_APP_TYPE_GINGA"); _INTERACTIVE_APP_TYPE_GINGAReady = true; } return _INTERACTIVE_APP_TYPE_GINGAContent; } }
        private static int _INTERACTIVE_APP_TYPE_GINGAContent = default;
        private static bool _INTERACTIVE_APP_TYPE_GINGAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#INTERACTIVE_APP_TYPE_HBBTV"/>
        /// </summary>
        public static int INTERACTIVE_APP_TYPE_HBBTV { get { if (!_INTERACTIVE_APP_TYPE_HBBTVReady) { _INTERACTIVE_APP_TYPE_HBBTVContent = SGetField<int>(LocalBridgeClazz, "INTERACTIVE_APP_TYPE_HBBTV"); _INTERACTIVE_APP_TYPE_HBBTVReady = true; } return _INTERACTIVE_APP_TYPE_HBBTVContent; } }
        private static int _INTERACTIVE_APP_TYPE_HBBTVContent = default;
        private static bool _INTERACTIVE_APP_TYPE_HBBTVReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#INTERACTIVE_APP_TYPE_OTHER"/>
        /// </summary>
        public static int INTERACTIVE_APP_TYPE_OTHER { get { if (!_INTERACTIVE_APP_TYPE_OTHERReady) { _INTERACTIVE_APP_TYPE_OTHERContent = SGetField<int>(LocalBridgeClazz, "INTERACTIVE_APP_TYPE_OTHER"); _INTERACTIVE_APP_TYPE_OTHERReady = true; } return _INTERACTIVE_APP_TYPE_OTHERContent; } }
        private static int _INTERACTIVE_APP_TYPE_OTHERContent = default;
        private static bool _INTERACTIVE_APP_TYPE_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#INTERACTIVE_APP_TYPE_TARGETED_AD"/>
        /// </summary>
        public static int INTERACTIVE_APP_TYPE_TARGETED_AD { get { if (!_INTERACTIVE_APP_TYPE_TARGETED_ADReady) { _INTERACTIVE_APP_TYPE_TARGETED_ADContent = SGetField<int>(LocalBridgeClazz, "INTERACTIVE_APP_TYPE_TARGETED_AD"); _INTERACTIVE_APP_TYPE_TARGETED_ADReady = true; } return _INTERACTIVE_APP_TYPE_TARGETED_ADContent; } }
        private static int _INTERACTIVE_APP_TYPE_TARGETED_ADContent = default;
        private static bool _INTERACTIVE_APP_TYPE_TARGETED_ADReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#getServiceInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.ServiceInfo"/></returns>
        public Android.Content.Pm.ServiceInfo GetServiceInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.ServiceInfo>("getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#getSupportedTypes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSupportedTypes()
        {
            return IExecuteWithSignature<int>("getSupportedTypes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#getCustomSupportedTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetCustomSupportedTypes()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getCustomSupportedTypes", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/interactive/TvInteractiveAppServiceInfo.html#writeToParcel(android.os.Parcel,int)"/>
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