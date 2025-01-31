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
    #region AdResponse declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html"/>
    /// </summary>
    public partial class AdResponse : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.media.tv.AdResponse";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdResponse() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdResponse(params object[] args) : base(args) { }
    
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

    #region AdResponse implementation
    public partial class AdResponse
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#%3Cinit%3E(int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public AdResponse(int arg0, int arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#RESPONSE_TYPE_BUFFERING"/>
        /// </summary>
        public static int RESPONSE_TYPE_BUFFERING { get { if (!_RESPONSE_TYPE_BUFFERINGReady) { _RESPONSE_TYPE_BUFFERINGContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_TYPE_BUFFERING"); _RESPONSE_TYPE_BUFFERINGReady = true; } return _RESPONSE_TYPE_BUFFERINGContent; } }
        private static int _RESPONSE_TYPE_BUFFERINGContent = default;
        private static bool _RESPONSE_TYPE_BUFFERINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#RESPONSE_TYPE_ERROR"/>
        /// </summary>
        public static int RESPONSE_TYPE_ERROR { get { if (!_RESPONSE_TYPE_ERRORReady) { _RESPONSE_TYPE_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_TYPE_ERROR"); _RESPONSE_TYPE_ERRORReady = true; } return _RESPONSE_TYPE_ERRORContent; } }
        private static int _RESPONSE_TYPE_ERRORContent = default;
        private static bool _RESPONSE_TYPE_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#RESPONSE_TYPE_FINISHED"/>
        /// </summary>
        public static int RESPONSE_TYPE_FINISHED { get { if (!_RESPONSE_TYPE_FINISHEDReady) { _RESPONSE_TYPE_FINISHEDContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_TYPE_FINISHED"); _RESPONSE_TYPE_FINISHEDReady = true; } return _RESPONSE_TYPE_FINISHEDContent; } }
        private static int _RESPONSE_TYPE_FINISHEDContent = default;
        private static bool _RESPONSE_TYPE_FINISHEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#RESPONSE_TYPE_PLAYING"/>
        /// </summary>
        public static int RESPONSE_TYPE_PLAYING { get { if (!_RESPONSE_TYPE_PLAYINGReady) { _RESPONSE_TYPE_PLAYINGContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_TYPE_PLAYING"); _RESPONSE_TYPE_PLAYINGReady = true; } return _RESPONSE_TYPE_PLAYINGContent; } }
        private static int _RESPONSE_TYPE_PLAYINGContent = default;
        private static bool _RESPONSE_TYPE_PLAYINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#RESPONSE_TYPE_STOPPED"/>
        /// </summary>
        public static int RESPONSE_TYPE_STOPPED { get { if (!_RESPONSE_TYPE_STOPPEDReady) { _RESPONSE_TYPE_STOPPEDContent = SGetField<int>(LocalBridgeClazz, "RESPONSE_TYPE_STOPPED"); _RESPONSE_TYPE_STOPPEDReady = true; } return _RESPONSE_TYPE_STOPPEDContent; } }
        private static int _RESPONSE_TYPE_STOPPEDContent = default;
        private static bool _RESPONSE_TYPE_STOPPEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#getResponseType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetResponseType()
        {
            return IExecuteWithSignature<int>("getResponseType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#getElapsedTimeMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetElapsedTimeMillis()
        {
            return IExecuteWithSignature<long>("getElapsedTimeMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdResponse.html#writeToParcel(android.os.Parcel,int)"/>
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