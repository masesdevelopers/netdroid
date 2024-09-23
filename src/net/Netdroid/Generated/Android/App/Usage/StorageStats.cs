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

namespace Android.App.Usage
{
    #region StorageStats declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html"/>
    /// </summary>
    public partial class StorageStats : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.usage.StorageStats";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StorageStats() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StorageStats(params object[] args) : base(args) { }

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

    #region StorageStats implementation
    public partial class StorageStats
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#APP_DATA_TYPE_FILE_TYPE_APK"/>
        /// </summary>
        public static int APP_DATA_TYPE_FILE_TYPE_APK { get { if (!_APP_DATA_TYPE_FILE_TYPE_APKReady) { _APP_DATA_TYPE_FILE_TYPE_APKContent = SGetField<int>(LocalBridgeClazz, "APP_DATA_TYPE_FILE_TYPE_APK"); _APP_DATA_TYPE_FILE_TYPE_APKReady = true; } return _APP_DATA_TYPE_FILE_TYPE_APKContent; } }
        private static int _APP_DATA_TYPE_FILE_TYPE_APKContent = default;
        private static bool _APP_DATA_TYPE_FILE_TYPE_APKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILE"/>
        /// </summary>
        public static int APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILE { get { if (!_APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILEReady) { _APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILEContent = SGetField<int>(LocalBridgeClazz, "APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILE"); _APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILEReady = true; } return _APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILEContent; } }
        private static int _APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILEContent = default;
        private static bool _APP_DATA_TYPE_FILE_TYPE_CURRENT_PROFILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACT"/>
        /// </summary>
        public static int APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACT { get { if (!_APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACTReady) { _APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACTContent = SGetField<int>(LocalBridgeClazz, "APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACT"); _APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACTReady = true; } return _APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACTContent; } }
        private static int _APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACTContent = default;
        private static bool _APP_DATA_TYPE_FILE_TYPE_DEXOPT_ARTIFACTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#APP_DATA_TYPE_FILE_TYPE_DM"/>
        /// </summary>
        public static int APP_DATA_TYPE_FILE_TYPE_DM { get { if (!_APP_DATA_TYPE_FILE_TYPE_DMReady) { _APP_DATA_TYPE_FILE_TYPE_DMContent = SGetField<int>(LocalBridgeClazz, "APP_DATA_TYPE_FILE_TYPE_DM"); _APP_DATA_TYPE_FILE_TYPE_DMReady = true; } return _APP_DATA_TYPE_FILE_TYPE_DMContent; } }
        private static int _APP_DATA_TYPE_FILE_TYPE_DMContent = default;
        private static bool _APP_DATA_TYPE_FILE_TYPE_DMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILE"/>
        /// </summary>
        public static int APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILE { get { if (!_APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILEReady) { _APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILEContent = SGetField<int>(LocalBridgeClazz, "APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILE"); _APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILEReady = true; } return _APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILEContent; } }
        private static int _APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILEContent = default;
        private static bool _APP_DATA_TYPE_FILE_TYPE_REFERENCE_PROFILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#APP_DATA_TYPE_LIB"/>
        /// </summary>
        public static int APP_DATA_TYPE_LIB { get { if (!_APP_DATA_TYPE_LIBReady) { _APP_DATA_TYPE_LIBContent = SGetField<int>(LocalBridgeClazz, "APP_DATA_TYPE_LIB"); _APP_DATA_TYPE_LIBReady = true; } return _APP_DATA_TYPE_LIBContent; } }
        private static int _APP_DATA_TYPE_LIBContent = default;
        private static bool _APP_DATA_TYPE_LIBReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#getAppBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetAppBytes()
        {
            return IExecuteWithSignature<long>("getAppBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#getAppBytesByDataType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAppBytesByDataType(int arg0)
        {
            return IExecuteWithSignature<long>("getAppBytesByDataType", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#getCacheBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCacheBytes()
        {
            return IExecuteWithSignature<long>("getCacheBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#getDataBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDataBytes()
        {
            return IExecuteWithSignature<long>("getDataBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#getExternalCacheBytes()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetExternalCacheBytes()
        {
            return IExecuteWithSignature<long>("getExternalCacheBytes", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/usage/StorageStats.html#writeToParcel(android.os.Parcel,int)"/>
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