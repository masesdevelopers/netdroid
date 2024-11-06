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

namespace Android.Media.Tv
{
    #region TableRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html"/>
    /// </summary>
    public partial class TableRequest : Android.Media.Tv.BroadcastInfoRequest
    {
        const string _bridgeClassName = "android.media.tv.TableRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TableRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TableRequest(params object[] args) : base(args) { }
    
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

    #region TableRequest implementation
    public partial class TableRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#%3Cinit%3E(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public TableRequest(int arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_BAT"/>
        /// </summary>
        public static int TABLE_NAME_BAT { get { if (!_TABLE_NAME_BATReady) { _TABLE_NAME_BATContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_BAT"); _TABLE_NAME_BATReady = true; } return _TABLE_NAME_BATContent; } }
        private static int _TABLE_NAME_BATContent = default;
        private static bool _TABLE_NAME_BATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_CAT"/>
        /// </summary>
        public static int TABLE_NAME_CAT { get { if (!_TABLE_NAME_CATReady) { _TABLE_NAME_CATContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_CAT"); _TABLE_NAME_CATReady = true; } return _TABLE_NAME_CATContent; } }
        private static int _TABLE_NAME_CATContent = default;
        private static bool _TABLE_NAME_CATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_EIT"/>
        /// </summary>
        public static int TABLE_NAME_EIT { get { if (!_TABLE_NAME_EITReady) { _TABLE_NAME_EITContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_EIT"); _TABLE_NAME_EITReady = true; } return _TABLE_NAME_EITContent; } }
        private static int _TABLE_NAME_EITContent = default;
        private static bool _TABLE_NAME_EITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_NIT"/>
        /// </summary>
        public static int TABLE_NAME_NIT { get { if (!_TABLE_NAME_NITReady) { _TABLE_NAME_NITContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_NIT"); _TABLE_NAME_NITReady = true; } return _TABLE_NAME_NITContent; } }
        private static int _TABLE_NAME_NITContent = default;
        private static bool _TABLE_NAME_NITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_PAT"/>
        /// </summary>
        public static int TABLE_NAME_PAT { get { if (!_TABLE_NAME_PATReady) { _TABLE_NAME_PATContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_PAT"); _TABLE_NAME_PATReady = true; } return _TABLE_NAME_PATContent; } }
        private static int _TABLE_NAME_PATContent = default;
        private static bool _TABLE_NAME_PATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_PMT"/>
        /// </summary>
        public static int TABLE_NAME_PMT { get { if (!_TABLE_NAME_PMTReady) { _TABLE_NAME_PMTContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_PMT"); _TABLE_NAME_PMTReady = true; } return _TABLE_NAME_PMTContent; } }
        private static int _TABLE_NAME_PMTContent = default;
        private static bool _TABLE_NAME_PMTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_SDT"/>
        /// </summary>
        public static int TABLE_NAME_SDT { get { if (!_TABLE_NAME_SDTReady) { _TABLE_NAME_SDTContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_SDT"); _TABLE_NAME_SDTReady = true; } return _TABLE_NAME_SDTContent; } }
        private static int _TABLE_NAME_SDTContent = default;
        private static bool _TABLE_NAME_SDTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_SIT"/>
        /// </summary>
        public static int TABLE_NAME_SIT { get { if (!_TABLE_NAME_SITReady) { _TABLE_NAME_SITContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_SIT"); _TABLE_NAME_SITReady = true; } return _TABLE_NAME_SITContent; } }
        private static int _TABLE_NAME_SITContent = default;
        private static bool _TABLE_NAME_SITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_TDT"/>
        /// </summary>
        public static int TABLE_NAME_TDT { get { if (!_TABLE_NAME_TDTReady) { _TABLE_NAME_TDTContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_TDT"); _TABLE_NAME_TDTReady = true; } return _TABLE_NAME_TDTContent; } }
        private static int _TABLE_NAME_TDTContent = default;
        private static bool _TABLE_NAME_TDTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#TABLE_NAME_TOT"/>
        /// </summary>
        public static int TABLE_NAME_TOT { get { if (!_TABLE_NAME_TOTReady) { _TABLE_NAME_TOTContent = SGetField<int>(LocalBridgeClazz, "TABLE_NAME_TOT"); _TABLE_NAME_TOTReady = true; } return _TABLE_NAME_TOTContent; } }
        private static int _TABLE_NAME_TOTContent = default;
        private static bool _TABLE_NAME_TOTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#getTableId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTableId()
        {
            return IExecuteWithSignature<int>("getTableId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#getTableName()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTableName()
        {
            return IExecuteWithSignature<int>("getTableName", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TableRequest.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}