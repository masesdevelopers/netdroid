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

namespace Android.Media.Metrics
{
    #region TrackChangeEvent declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html"/>
    /// </summary>
    public partial class TrackChangeEvent : Android.Media.Metrics.Event
    {
        const string _bridgeClassName = "android.media.metrics.TrackChangeEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TrackChangeEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TrackChangeEvent(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.media.metrics.TrackChangeEvent$Builder";
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

    #region TrackChangeEvent implementation
    public partial class TrackChangeEvent
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Media.Metrics.TrackChangeEvent"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Media.Metrics.TrackChangeEvent t) => t.Cast<Android.Os.Parcelable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_CHANGE_REASON_ADAPTIVE"/>
        /// </summary>
        public static int TRACK_CHANGE_REASON_ADAPTIVE { get { if (!_TRACK_CHANGE_REASON_ADAPTIVEReady) { _TRACK_CHANGE_REASON_ADAPTIVEContent = SGetField<int>(LocalBridgeClazz, "TRACK_CHANGE_REASON_ADAPTIVE"); _TRACK_CHANGE_REASON_ADAPTIVEReady = true; } return _TRACK_CHANGE_REASON_ADAPTIVEContent; } }
        private static int _TRACK_CHANGE_REASON_ADAPTIVEContent = default;
        private static bool _TRACK_CHANGE_REASON_ADAPTIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_CHANGE_REASON_INITIAL"/>
        /// </summary>
        public static int TRACK_CHANGE_REASON_INITIAL { get { if (!_TRACK_CHANGE_REASON_INITIALReady) { _TRACK_CHANGE_REASON_INITIALContent = SGetField<int>(LocalBridgeClazz, "TRACK_CHANGE_REASON_INITIAL"); _TRACK_CHANGE_REASON_INITIALReady = true; } return _TRACK_CHANGE_REASON_INITIALContent; } }
        private static int _TRACK_CHANGE_REASON_INITIALContent = default;
        private static bool _TRACK_CHANGE_REASON_INITIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_CHANGE_REASON_MANUAL"/>
        /// </summary>
        public static int TRACK_CHANGE_REASON_MANUAL { get { if (!_TRACK_CHANGE_REASON_MANUALReady) { _TRACK_CHANGE_REASON_MANUALContent = SGetField<int>(LocalBridgeClazz, "TRACK_CHANGE_REASON_MANUAL"); _TRACK_CHANGE_REASON_MANUALReady = true; } return _TRACK_CHANGE_REASON_MANUALContent; } }
        private static int _TRACK_CHANGE_REASON_MANUALContent = default;
        private static bool _TRACK_CHANGE_REASON_MANUALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_CHANGE_REASON_OTHER"/>
        /// </summary>
        public static int TRACK_CHANGE_REASON_OTHER { get { if (!_TRACK_CHANGE_REASON_OTHERReady) { _TRACK_CHANGE_REASON_OTHERContent = SGetField<int>(LocalBridgeClazz, "TRACK_CHANGE_REASON_OTHER"); _TRACK_CHANGE_REASON_OTHERReady = true; } return _TRACK_CHANGE_REASON_OTHERContent; } }
        private static int _TRACK_CHANGE_REASON_OTHERContent = default;
        private static bool _TRACK_CHANGE_REASON_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_CHANGE_REASON_UNKNOWN"/>
        /// </summary>
        public static int TRACK_CHANGE_REASON_UNKNOWN { get { if (!_TRACK_CHANGE_REASON_UNKNOWNReady) { _TRACK_CHANGE_REASON_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TRACK_CHANGE_REASON_UNKNOWN"); _TRACK_CHANGE_REASON_UNKNOWNReady = true; } return _TRACK_CHANGE_REASON_UNKNOWNContent; } }
        private static int _TRACK_CHANGE_REASON_UNKNOWNContent = default;
        private static bool _TRACK_CHANGE_REASON_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_STATE_OFF"/>
        /// </summary>
        public static int TRACK_STATE_OFF { get { if (!_TRACK_STATE_OFFReady) { _TRACK_STATE_OFFContent = SGetField<int>(LocalBridgeClazz, "TRACK_STATE_OFF"); _TRACK_STATE_OFFReady = true; } return _TRACK_STATE_OFFContent; } }
        private static int _TRACK_STATE_OFFContent = default;
        private static bool _TRACK_STATE_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_STATE_ON"/>
        /// </summary>
        public static int TRACK_STATE_ON { get { if (!_TRACK_STATE_ONReady) { _TRACK_STATE_ONContent = SGetField<int>(LocalBridgeClazz, "TRACK_STATE_ON"); _TRACK_STATE_ONReady = true; } return _TRACK_STATE_ONContent; } }
        private static int _TRACK_STATE_ONContent = default;
        private static bool _TRACK_STATE_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_TYPE_AUDIO"/>
        /// </summary>
        public static int TRACK_TYPE_AUDIO { get { if (!_TRACK_TYPE_AUDIOReady) { _TRACK_TYPE_AUDIOContent = SGetField<int>(LocalBridgeClazz, "TRACK_TYPE_AUDIO"); _TRACK_TYPE_AUDIOReady = true; } return _TRACK_TYPE_AUDIOContent; } }
        private static int _TRACK_TYPE_AUDIOContent = default;
        private static bool _TRACK_TYPE_AUDIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_TYPE_TEXT"/>
        /// </summary>
        public static int TRACK_TYPE_TEXT { get { if (!_TRACK_TYPE_TEXTReady) { _TRACK_TYPE_TEXTContent = SGetField<int>(LocalBridgeClazz, "TRACK_TYPE_TEXT"); _TRACK_TYPE_TEXTReady = true; } return _TRACK_TYPE_TEXTContent; } }
        private static int _TRACK_TYPE_TEXTContent = default;
        private static bool _TRACK_TYPE_TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#TRACK_TYPE_VIDEO"/>
        /// </summary>
        public static int TRACK_TYPE_VIDEO { get { if (!_TRACK_TYPE_VIDEOReady) { _TRACK_TYPE_VIDEOContent = SGetField<int>(LocalBridgeClazz, "TRACK_TYPE_VIDEO"); _TRACK_TYPE_VIDEOReady = true; } return _TRACK_TYPE_VIDEOContent; } }
        private static int _TRACK_TYPE_VIDEOContent = default;
        private static bool _TRACK_TYPE_VIDEOReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getVideoFrameRate()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetVideoFrameRate()
        {
            return IExecuteWithSignature<float>("getVideoFrameRate", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getAudioSampleRate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAudioSampleRate()
        {
            return IExecuteWithSignature<int>("getAudioSampleRate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getBitrate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBitrate()
        {
            return IExecuteWithSignature<int>("getBitrate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getChannelCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetChannelCount()
        {
            return IExecuteWithSignature<int>("getChannelCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHeight()
        {
            return IExecuteWithSignature<int>("getHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getTrackChangeReason()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTrackChangeReason()
        {
            return IExecuteWithSignature<int>("getTrackChangeReason", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getTrackState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTrackState()
        {
            return IExecuteWithSignature<int>("getTrackState", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getTrackType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTrackType()
        {
            return IExecuteWithSignature<int>("getTrackType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidth()
        {
            return IExecuteWithSignature<int>("getWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getCodecName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCodecName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCodecName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getContainerMimeType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetContainerMimeType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getContainerMimeType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getLanguage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLanguage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLanguage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getLanguageRegion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLanguageRegion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLanguageRegion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#getSampleMimeType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSampleMimeType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSampleMimeType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#%3Cinit%3E(int)"/>
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
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent"/></returns>
            public Android.Media.Metrics.TrackChangeEvent Build()
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent>("build", "()Landroid/media/metrics/TrackChangeEvent;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setAudioSampleRate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetAudioSampleRate(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setAudioSampleRate", "(I)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setBitrate(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetBitrate(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setBitrate", "(I)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setChannelCount(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetChannelCount(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setChannelCount", "(I)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setCodecName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetCodecName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setCodecName", "(Ljava/lang/String;)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setContainerMimeType(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetContainerMimeType(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setContainerMimeType", "(Ljava/lang/String;)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setHeight(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetHeight(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setHeight", "(I)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setLanguage(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetLanguage(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setLanguage", "(Ljava/lang/String;)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setLanguageRegion(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetLanguageRegion(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setLanguageRegion", "(Ljava/lang/String;)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setMetricsBundle(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetMetricsBundle(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setMetricsBundle", "(Landroid/os/Bundle;)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setSampleMimeType(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetSampleMimeType(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setSampleMimeType", "(Ljava/lang/String;)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setTimeSinceCreatedMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetTimeSinceCreatedMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setTimeSinceCreatedMillis", "(J)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setTrackChangeReason(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetTrackChangeReason(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setTrackChangeReason", "(I)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setTrackState(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetTrackState(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setTrackState", "(I)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setVideoFrameRate(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetVideoFrameRate(float arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setVideoFrameRate", "(F)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/TrackChangeEvent.Builder.html#setWidth(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.TrackChangeEvent.Builder"/></returns>
            public Android.Media.Metrics.TrackChangeEvent.Builder SetWidth(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.TrackChangeEvent.Builder>("setWidth", "(I)Landroid/media/metrics/TrackChangeEvent$Builder;", arg0);
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