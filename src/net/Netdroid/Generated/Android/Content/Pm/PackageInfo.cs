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

namespace Android.Content.Pm
{
    #region PackageInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html"/>
    /// </summary>
    public partial class PackageInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.pm.PackageInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PackageInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PackageInfo(params object[] args) : base(args) { }

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

    #region PackageInfo implementation
    public partial class PackageInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#activities"/>
        /// </summary>
        public Android.Content.Pm.ActivityInfo[] activities { get { return IGetFieldArray<Android.Content.Pm.ActivityInfo>("activities"); } set { ISetField("activities", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#receivers"/>
        /// </summary>
        public Android.Content.Pm.ActivityInfo[] receivers { get { return IGetFieldArray<Android.Content.Pm.ActivityInfo>("receivers"); } set { ISetField("receivers", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#applicationInfo"/>
        /// </summary>
        public Android.Content.Pm.ApplicationInfo applicationInfo { get { return IGetField<Android.Content.Pm.ApplicationInfo>("applicationInfo"); } set { ISetField("applicationInfo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#attributions"/>
        /// </summary>
        public Android.Content.Pm.Attribution[] attributions { get { return IGetFieldArray<Android.Content.Pm.Attribution>("attributions"); } set { ISetField("attributions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#configPreferences"/>
        /// </summary>
        public Android.Content.Pm.ConfigurationInfo[] configPreferences { get { return IGetFieldArray<Android.Content.Pm.ConfigurationInfo>("configPreferences"); } set { ISetField("configPreferences", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#featureGroups"/>
        /// </summary>
        public Android.Content.Pm.FeatureGroupInfo[] featureGroups { get { return IGetFieldArray<Android.Content.Pm.FeatureGroupInfo>("featureGroups"); } set { ISetField("featureGroups", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#reqFeatures"/>
        /// </summary>
        public Android.Content.Pm.FeatureInfo[] reqFeatures { get { return IGetFieldArray<Android.Content.Pm.FeatureInfo>("reqFeatures"); } set { ISetField("reqFeatures", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#instrumentation"/>
        /// </summary>
        public Android.Content.Pm.InstrumentationInfo[] instrumentation { get { return IGetFieldArray<Android.Content.Pm.InstrumentationInfo>("instrumentation"); } set { ISetField("instrumentation", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#permissions"/>
        /// </summary>
        public Android.Content.Pm.PermissionInfo[] permissions { get { return IGetFieldArray<Android.Content.Pm.PermissionInfo>("permissions"); } set { ISetField("permissions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#providers"/>
        /// </summary>
        public Android.Content.Pm.ProviderInfo[] providers { get { return IGetFieldArray<Android.Content.Pm.ProviderInfo>("providers"); } set { ISetField("providers", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#services"/>
        /// </summary>
        public Android.Content.Pm.ServiceInfo[] services { get { return IGetFieldArray<Android.Content.Pm.ServiceInfo>("services"); } set { ISetField("services", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#signatures"/>
        /// </summary>
        [global::System.Obsolete()]
        public Android.Content.Pm.Signature[] signatures { get { return IGetFieldArray<Android.Content.Pm.Signature>("signatures"); } set { ISetField("signatures", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#signingInfo"/>
        /// </summary>
        public Android.Content.Pm.SigningInfo signingInfo { get { return IGetField<Android.Content.Pm.SigningInfo>("signingInfo"); } set { ISetField("signingInfo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#isApex"/>
        /// </summary>
        public bool isApex { get { return IGetField<bool>("isApex"); } set { ISetField("isApex", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#baseRevisionCode"/>
        /// </summary>
        public int baseRevisionCode { get { return IGetField<int>("baseRevisionCode"); } set { ISetField("baseRevisionCode", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#installLocation"/>
        /// </summary>
        public int installLocation { get { return IGetField<int>("installLocation"); } set { ISetField("installLocation", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#sharedUserLabel"/>
        /// </summary>
        public int sharedUserLabel { get { return IGetField<int>("sharedUserLabel"); } set { ISetField("sharedUserLabel", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#versionCode"/>
        /// </summary>
        [global::System.Obsolete()]
        public int versionCode { get { return IGetField<int>("versionCode"); } set { ISetField("versionCode", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#gids"/>
        /// </summary>
        public int[] gids { get { return IGetFieldArray<int>("gids"); } set { ISetField("gids", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#requestedPermissionsFlags"/>
        /// </summary>
        public int[] requestedPermissionsFlags { get { return IGetFieldArray<int>("requestedPermissionsFlags"); } set { ISetField("requestedPermissionsFlags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#splitRevisionCodes"/>
        /// </summary>
        public int[] splitRevisionCodes { get { return IGetFieldArray<int>("splitRevisionCodes"); } set { ISetField("splitRevisionCodes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#packageName"/>
        /// </summary>
        public Java.Lang.String packageName { get { return IGetField<Java.Lang.String>("packageName"); } set { ISetField("packageName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#sharedUserId"/>
        /// </summary>
        public Java.Lang.String sharedUserId { get { return IGetField<Java.Lang.String>("sharedUserId"); } set { ISetField("sharedUserId", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#versionName"/>
        /// </summary>
        public Java.Lang.String versionName { get { return IGetField<Java.Lang.String>("versionName"); } set { ISetField("versionName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#requestedPermissions"/>
        /// </summary>
        public Java.Lang.String[] requestedPermissions { get { return IGetFieldArray<Java.Lang.String>("requestedPermissions"); } set { ISetField("requestedPermissions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#splitNames"/>
        /// </summary>
        public Java.Lang.String[] splitNames { get { return IGetFieldArray<Java.Lang.String>("splitNames"); } set { ISetField("splitNames", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#firstInstallTime"/>
        /// </summary>
        public long firstInstallTime { get { return IGetField<long>("firstInstallTime"); } set { ISetField("firstInstallTime", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#lastUpdateTime"/>
        /// </summary>
        public long lastUpdateTime { get { return IGetField<long>("lastUpdateTime"); } set { ISetField("lastUpdateTime", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#INSTALL_LOCATION_AUTO"/>
        /// </summary>
        public static int INSTALL_LOCATION_AUTO { get { if (!_INSTALL_LOCATION_AUTOReady) { _INSTALL_LOCATION_AUTOContent = SGetField<int>(LocalBridgeClazz, "INSTALL_LOCATION_AUTO"); _INSTALL_LOCATION_AUTOReady = true; } return _INSTALL_LOCATION_AUTOContent; } }
        private static int _INSTALL_LOCATION_AUTOContent = default;
        private static bool _INSTALL_LOCATION_AUTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#INSTALL_LOCATION_INTERNAL_ONLY"/>
        /// </summary>
        public static int INSTALL_LOCATION_INTERNAL_ONLY { get { if (!_INSTALL_LOCATION_INTERNAL_ONLYReady) { _INSTALL_LOCATION_INTERNAL_ONLYContent = SGetField<int>(LocalBridgeClazz, "INSTALL_LOCATION_INTERNAL_ONLY"); _INSTALL_LOCATION_INTERNAL_ONLYReady = true; } return _INSTALL_LOCATION_INTERNAL_ONLYContent; } }
        private static int _INSTALL_LOCATION_INTERNAL_ONLYContent = default;
        private static bool _INSTALL_LOCATION_INTERNAL_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#INSTALL_LOCATION_PREFER_EXTERNAL"/>
        /// </summary>
        public static int INSTALL_LOCATION_PREFER_EXTERNAL { get { if (!_INSTALL_LOCATION_PREFER_EXTERNALReady) { _INSTALL_LOCATION_PREFER_EXTERNALContent = SGetField<int>(LocalBridgeClazz, "INSTALL_LOCATION_PREFER_EXTERNAL"); _INSTALL_LOCATION_PREFER_EXTERNALReady = true; } return _INSTALL_LOCATION_PREFER_EXTERNALContent; } }
        private static int _INSTALL_LOCATION_PREFER_EXTERNALContent = default;
        private static bool _INSTALL_LOCATION_PREFER_EXTERNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#REQUESTED_PERMISSION_GRANTED"/>
        /// </summary>
        public static int REQUESTED_PERMISSION_GRANTED { get { if (!_REQUESTED_PERMISSION_GRANTEDReady) { _REQUESTED_PERMISSION_GRANTEDContent = SGetField<int>(LocalBridgeClazz, "REQUESTED_PERMISSION_GRANTED"); _REQUESTED_PERMISSION_GRANTEDReady = true; } return _REQUESTED_PERMISSION_GRANTEDContent; } }
        private static int _REQUESTED_PERMISSION_GRANTEDContent = default;
        private static bool _REQUESTED_PERMISSION_GRANTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#REQUESTED_PERMISSION_IMPLICIT"/>
        /// </summary>
        public static int REQUESTED_PERMISSION_IMPLICIT { get { if (!_REQUESTED_PERMISSION_IMPLICITReady) { _REQUESTED_PERMISSION_IMPLICITContent = SGetField<int>(LocalBridgeClazz, "REQUESTED_PERMISSION_IMPLICIT"); _REQUESTED_PERMISSION_IMPLICITReady = true; } return _REQUESTED_PERMISSION_IMPLICITContent; } }
        private static int _REQUESTED_PERMISSION_IMPLICITContent = default;
        private static bool _REQUESTED_PERMISSION_IMPLICITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#REQUESTED_PERMISSION_NEVER_FOR_LOCATION"/>
        /// </summary>
        public static int REQUESTED_PERMISSION_NEVER_FOR_LOCATION { get { if (!_REQUESTED_PERMISSION_NEVER_FOR_LOCATIONReady) { _REQUESTED_PERMISSION_NEVER_FOR_LOCATIONContent = SGetField<int>(LocalBridgeClazz, "REQUESTED_PERMISSION_NEVER_FOR_LOCATION"); _REQUESTED_PERMISSION_NEVER_FOR_LOCATIONReady = true; } return _REQUESTED_PERMISSION_NEVER_FOR_LOCATIONContent; } }
        private static int _REQUESTED_PERMISSION_NEVER_FOR_LOCATIONContent = default;
        private static bool _REQUESTED_PERMISSION_NEVER_FOR_LOCATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#getApexPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetApexPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getApexPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#getArchiveTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetArchiveTimeMillis()
        {
            return IExecuteWithSignature<long>("getArchiveTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#getLongVersionCode()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetLongVersionCode()
        {
            return IExecuteWithSignature<long>("getLongVersionCode", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#setLongVersionCode(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetLongVersionCode(long arg0)
        {
            IExecuteWithSignature("setLongVersionCode", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PackageInfo.html#writeToParcel(android.os.Parcel,int)"/>
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