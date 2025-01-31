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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Admin
{
    #region DeviceAdminInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html"/>
    /// </summary>
    public partial class DeviceAdminInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.admin.DeviceAdminInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DeviceAdminInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DeviceAdminInfo(params object[] args) : base(args) { }
    
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

    #region DeviceAdminInfo implementation
    public partial class DeviceAdminInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#%3Cinit%3E(android.content.Context,android.content.pm.ResolveInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Content.Pm.ResolveInfo"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public DeviceAdminInfo(Android.Content.Context arg0, Android.Content.Pm.ResolveInfo arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#HEADLESS_DEVICE_OWNER_MODE_AFFILIATED"/>
        /// </summary>
        public static int HEADLESS_DEVICE_OWNER_MODE_AFFILIATED { get { if (!_HEADLESS_DEVICE_OWNER_MODE_AFFILIATEDReady) { _HEADLESS_DEVICE_OWNER_MODE_AFFILIATEDContent = SGetField<int>(LocalBridgeClazz, "HEADLESS_DEVICE_OWNER_MODE_AFFILIATED"); _HEADLESS_DEVICE_OWNER_MODE_AFFILIATEDReady = true; } return _HEADLESS_DEVICE_OWNER_MODE_AFFILIATEDContent; } }
        private static int _HEADLESS_DEVICE_OWNER_MODE_AFFILIATEDContent = default;
        private static bool _HEADLESS_DEVICE_OWNER_MODE_AFFILIATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#HEADLESS_DEVICE_OWNER_MODE_SINGLE_USER"/>
        /// </summary>
        public static int HEADLESS_DEVICE_OWNER_MODE_SINGLE_USER { get { if (!_HEADLESS_DEVICE_OWNER_MODE_SINGLE_USERReady) { _HEADLESS_DEVICE_OWNER_MODE_SINGLE_USERContent = SGetField<int>(LocalBridgeClazz, "HEADLESS_DEVICE_OWNER_MODE_SINGLE_USER"); _HEADLESS_DEVICE_OWNER_MODE_SINGLE_USERReady = true; } return _HEADLESS_DEVICE_OWNER_MODE_SINGLE_USERContent; } }
        private static int _HEADLESS_DEVICE_OWNER_MODE_SINGLE_USERContent = default;
        private static bool _HEADLESS_DEVICE_OWNER_MODE_SINGLE_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTED"/>
        /// </summary>
        public static int HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTED { get { if (!_HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTEDReady) { _HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTED"); _HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTEDReady = true; } return _HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTEDContent; } }
        private static int _HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTEDContent = default;
        private static bool _HEADLESS_DEVICE_OWNER_MODE_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_ENCRYPTED_STORAGE"/>
        /// </summary>
        public static int USES_ENCRYPTED_STORAGE { get { if (!_USES_ENCRYPTED_STORAGEReady) { _USES_ENCRYPTED_STORAGEContent = SGetField<int>(LocalBridgeClazz, "USES_ENCRYPTED_STORAGE"); _USES_ENCRYPTED_STORAGEReady = true; } return _USES_ENCRYPTED_STORAGEContent; } }
        private static int _USES_ENCRYPTED_STORAGEContent = default;
        private static bool _USES_ENCRYPTED_STORAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_DISABLE_CAMERA"/>
        /// </summary>
        public static int USES_POLICY_DISABLE_CAMERA { get { if (!_USES_POLICY_DISABLE_CAMERAReady) { _USES_POLICY_DISABLE_CAMERAContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_DISABLE_CAMERA"); _USES_POLICY_DISABLE_CAMERAReady = true; } return _USES_POLICY_DISABLE_CAMERAContent; } }
        private static int _USES_POLICY_DISABLE_CAMERAContent = default;
        private static bool _USES_POLICY_DISABLE_CAMERAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_DISABLE_KEYGUARD_FEATURES"/>
        /// </summary>
        public static int USES_POLICY_DISABLE_KEYGUARD_FEATURES { get { if (!_USES_POLICY_DISABLE_KEYGUARD_FEATURESReady) { _USES_POLICY_DISABLE_KEYGUARD_FEATURESContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_DISABLE_KEYGUARD_FEATURES"); _USES_POLICY_DISABLE_KEYGUARD_FEATURESReady = true; } return _USES_POLICY_DISABLE_KEYGUARD_FEATURESContent; } }
        private static int _USES_POLICY_DISABLE_KEYGUARD_FEATURESContent = default;
        private static bool _USES_POLICY_DISABLE_KEYGUARD_FEATURESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_EXPIRE_PASSWORD"/>
        /// </summary>
        public static int USES_POLICY_EXPIRE_PASSWORD { get { if (!_USES_POLICY_EXPIRE_PASSWORDReady) { _USES_POLICY_EXPIRE_PASSWORDContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_EXPIRE_PASSWORD"); _USES_POLICY_EXPIRE_PASSWORDReady = true; } return _USES_POLICY_EXPIRE_PASSWORDContent; } }
        private static int _USES_POLICY_EXPIRE_PASSWORDContent = default;
        private static bool _USES_POLICY_EXPIRE_PASSWORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_FORCE_LOCK"/>
        /// </summary>
        public static int USES_POLICY_FORCE_LOCK { get { if (!_USES_POLICY_FORCE_LOCKReady) { _USES_POLICY_FORCE_LOCKContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_FORCE_LOCK"); _USES_POLICY_FORCE_LOCKReady = true; } return _USES_POLICY_FORCE_LOCKContent; } }
        private static int _USES_POLICY_FORCE_LOCKContent = default;
        private static bool _USES_POLICY_FORCE_LOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_LIMIT_PASSWORD"/>
        /// </summary>
        public static int USES_POLICY_LIMIT_PASSWORD { get { if (!_USES_POLICY_LIMIT_PASSWORDReady) { _USES_POLICY_LIMIT_PASSWORDContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_LIMIT_PASSWORD"); _USES_POLICY_LIMIT_PASSWORDReady = true; } return _USES_POLICY_LIMIT_PASSWORDContent; } }
        private static int _USES_POLICY_LIMIT_PASSWORDContent = default;
        private static bool _USES_POLICY_LIMIT_PASSWORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_RESET_PASSWORD"/>
        /// </summary>
        public static int USES_POLICY_RESET_PASSWORD { get { if (!_USES_POLICY_RESET_PASSWORDReady) { _USES_POLICY_RESET_PASSWORDContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_RESET_PASSWORD"); _USES_POLICY_RESET_PASSWORDReady = true; } return _USES_POLICY_RESET_PASSWORDContent; } }
        private static int _USES_POLICY_RESET_PASSWORDContent = default;
        private static bool _USES_POLICY_RESET_PASSWORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_WATCH_LOGIN"/>
        /// </summary>
        public static int USES_POLICY_WATCH_LOGIN { get { if (!_USES_POLICY_WATCH_LOGINReady) { _USES_POLICY_WATCH_LOGINContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_WATCH_LOGIN"); _USES_POLICY_WATCH_LOGINReady = true; } return _USES_POLICY_WATCH_LOGINContent; } }
        private static int _USES_POLICY_WATCH_LOGINContent = default;
        private static bool _USES_POLICY_WATCH_LOGINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#USES_POLICY_WIPE_DATA"/>
        /// </summary>
        public static int USES_POLICY_WIPE_DATA { get { if (!_USES_POLICY_WIPE_DATAReady) { _USES_POLICY_WIPE_DATAContent = SGetField<int>(LocalBridgeClazz, "USES_POLICY_WIPE_DATA"); _USES_POLICY_WIPE_DATAReady = true; } return _USES_POLICY_WIPE_DATAContent; } }
        private static int _USES_POLICY_WIPE_DATAContent = default;
        private static bool _USES_POLICY_WIPE_DATAReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#getComponent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName GetComponent()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("getComponent", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#getActivityInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.ActivityInfo"/></returns>
        public Android.Content.Pm.ActivityInfo GetActivityInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.ActivityInfo>("getActivityInfo", "()Landroid/content/pm/ActivityInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#loadIcon(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadIcon(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#isVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecuteWithSignature<bool>("isVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#supportsTransferOwnership()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsTransferOwnership()
        {
            return IExecuteWithSignature<bool>("supportsTransferOwnership", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#usesPolicy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UsesPolicy(int arg0)
        {
            return IExecuteWithSignature<bool>("usesPolicy", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#getHeadlessDeviceOwnerMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeadlessDeviceOwnerMode()
        {
            return IExecuteWithSignature<int>("getHeadlessDeviceOwnerMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#loadDescription(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <exception cref="Android.Content.Res.Resources.NotFoundException"/>
        public Java.Lang.CharSequence LoadDescription(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#loadLabel(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadLabel(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#getReceiverName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetReceiverName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getReceiverName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#getTagForPolicy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTagForPolicy(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getTagForPolicy", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/admin/DeviceAdminInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}