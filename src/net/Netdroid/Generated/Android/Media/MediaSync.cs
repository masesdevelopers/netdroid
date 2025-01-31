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

namespace Android.Media
{
    #region MediaSync declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/MediaSync.html"/>
    /// </summary>
    public partial class MediaSync : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MediaSync>
    {
        const string _bridgeClassName = "android.media.MediaSync";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MediaSync() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MediaSync(params object[] args) : base(args) { }
    
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
        #region Callback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.Callback.html"/>
        /// </summary>
        public partial class Callback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Callback>
        {
            const string _bridgeClassName = "android.media.MediaSync$Callback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
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

        #region OnErrorListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.OnErrorListener.html"/>
        /// </summary>
        public partial class OnErrorListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnErrorListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.media.MediaSync_OnErrorListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnErrorListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnErrorListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnErrorListenerDirect : OnErrorListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.media.MediaSync$OnErrorListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        }
        #endregion

    
    }
    #endregion

    #region MediaSync implementation
    public partial class MediaSync
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#MEDIASYNC_ERROR_AUDIOTRACK_FAIL"/>
        /// </summary>
        public static int MEDIASYNC_ERROR_AUDIOTRACK_FAIL { get { if (!_MEDIASYNC_ERROR_AUDIOTRACK_FAILReady) { _MEDIASYNC_ERROR_AUDIOTRACK_FAILContent = SGetField<int>(LocalBridgeClazz, "MEDIASYNC_ERROR_AUDIOTRACK_FAIL"); _MEDIASYNC_ERROR_AUDIOTRACK_FAILReady = true; } return _MEDIASYNC_ERROR_AUDIOTRACK_FAILContent; } }
        private static int _MEDIASYNC_ERROR_AUDIOTRACK_FAILContent = default;
        private static bool _MEDIASYNC_ERROR_AUDIOTRACK_FAILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#MEDIASYNC_ERROR_SURFACE_FAIL"/>
        /// </summary>
        public static int MEDIASYNC_ERROR_SURFACE_FAIL { get { if (!_MEDIASYNC_ERROR_SURFACE_FAILReady) { _MEDIASYNC_ERROR_SURFACE_FAILContent = SGetField<int>(LocalBridgeClazz, "MEDIASYNC_ERROR_SURFACE_FAIL"); _MEDIASYNC_ERROR_SURFACE_FAILReady = true; } return _MEDIASYNC_ERROR_SURFACE_FAILContent; } }
        private static int _MEDIASYNC_ERROR_SURFACE_FAILContent = default;
        private static bool _MEDIASYNC_ERROR_SURFACE_FAILReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#getTimestamp()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.MediaTimestamp"/></returns>
        public Android.Media.MediaTimestamp GetTimestamp()
        {
            return IExecuteWithSignature<Android.Media.MediaTimestamp>("getTimestamp", "()Landroid/media/MediaTimestamp;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#getPlaybackParams()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.PlaybackParams"/></returns>
        public Android.Media.PlaybackParams GetPlaybackParams()
        {
            return IExecuteWithSignature<Android.Media.PlaybackParams>("getPlaybackParams", "()Landroid/media/PlaybackParams;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#getSyncParams()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.SyncParams"/></returns>
        public Android.Media.SyncParams GetSyncParams()
        {
            return IExecuteWithSignature<Android.Media.SyncParams>("getSyncParams", "()Landroid/media/SyncParams;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#createInputSurface()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Surface"/></returns>
        public Android.View.Surface CreateInputSurface()
        {
            return IExecuteWithSignature<Android.View.Surface>("createInputSurface", "()Landroid/view/Surface;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#queueAudio(java.nio.ByteBuffer,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void QueueAudio(Java.Nio.ByteBuffer arg0, int arg1, long arg2)
        {
            IExecuteWithSignature("queueAudio", "(Ljava/nio/ByteBuffer;IJ)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#setAudioTrack(android.media.AudioTrack)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.AudioTrack"/></param>
        public void SetAudioTrack(Android.Media.AudioTrack arg0)
        {
            IExecuteWithSignature("setAudioTrack", "(Landroid/media/AudioTrack;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#setCallback(android.media.MediaSync.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaSync.Callback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void SetCallback(Android.Media.MediaSync.Callback arg0, Android.Os.Handler arg1)
        {
            IExecuteWithSignature("setCallback", "(Landroid/media/MediaSync$Callback;Landroid/os/Handler;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#setOnErrorListener(android.media.MediaSync.OnErrorListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaSync.OnErrorListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void SetOnErrorListener(Android.Media.MediaSync.OnErrorListener arg0, Android.Os.Handler arg1)
        {
            IExecuteWithSignature("setOnErrorListener", "(Landroid/media/MediaSync$OnErrorListener;Landroid/os/Handler;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#setPlaybackParams(android.media.PlaybackParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.PlaybackParams"/></param>
        public void SetPlaybackParams(Android.Media.PlaybackParams arg0)
        {
            IExecuteWithSignature("setPlaybackParams", "(Landroid/media/PlaybackParams;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#setSurface(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        public void SetSurface(Android.View.Surface arg0)
        {
            IExecuteWithSignature("setSurface", "(Landroid/view/Surface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaSync.html#setSyncParams(android.media.SyncParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.SyncParams"/></param>
        public void SetSyncParams(Android.Media.SyncParams arg0)
        {
            IExecuteWithSignature("setSyncParams", "(Landroid/media/SyncParams;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Callback implementation
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/media/MediaSync.Callback.html#onAudioBufferConsumed(android.media.MediaSync,java.nio.ByteBuffer,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaSync"/></param>
            /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void OnAudioBufferConsumed(Android.Media.MediaSync arg0, Java.Nio.ByteBuffer arg1, int arg2)
            {
                IExecuteWithSignature("onAudioBufferConsumed", "(Landroid/media/MediaSync;Ljava/nio/ByteBuffer;I)V", arg0, arg1, arg2);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnErrorListener implementation
        public partial class OnErrorListener
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
            /// Handlers initializer for <see cref="OnErrorListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onError", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnErrorEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/MediaSync.OnErrorListener.html#onError(android.media.MediaSync,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnError"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.MediaSync, int, int> OnOnError { get; set; } = null;
            
            bool hasOverrideOnError = true;
            void OnErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnError = true;
                var methodToExecute = (OnOnError != null) ? OnOnError : OnError;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Media.MediaSync>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnError;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaSync.OnErrorListener.html#onError(android.media.MediaSync,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaSync"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public virtual void OnError(Android.Media.MediaSync arg0, int arg1, int arg2)
            {
                hasOverrideOnError = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnErrorListenerDirect implementation
        public partial class OnErrorListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/MediaSync.OnErrorListener.html#onError(android.media.MediaSync,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaSync"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public override void OnError(Android.Media.MediaSync arg0, int arg1, int arg2)
            {
                IExecuteWithSignature("onError", "(Landroid/media/MediaSync;II)V", arg0, arg1, arg2);
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