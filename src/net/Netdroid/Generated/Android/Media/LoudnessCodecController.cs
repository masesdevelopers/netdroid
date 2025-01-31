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
    #region LoudnessCodecController declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.html"/>
    /// </summary>
    public partial class LoudnessCodecController : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.media.LoudnessCodecController";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LoudnessCodecController() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LoudnessCodecController(params object[] args) : base(args) { }
    
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
        #region OnLoudnessCodecUpdateListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.OnLoudnessCodecUpdateListener.html"/>
        /// </summary>
        public partial class OnLoudnessCodecUpdateListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnLoudnessCodecUpdateListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.media.LoudnessCodecController_OnLoudnessCodecUpdateListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnLoudnessCodecUpdateListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnLoudnessCodecUpdateListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnLoudnessCodecUpdateListenerDirect : OnLoudnessCodecUpdateListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.media.LoudnessCodecController$OnLoudnessCodecUpdateListener";
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

    #region LoudnessCodecController implementation
    public partial class LoudnessCodecController
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.html#create(int,java.util.concurrent.Executor,android.media.LoudnessCodecController.OnLoudnessCodecUpdateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Media.LoudnessCodecController.OnLoudnessCodecUpdateListener"/></param>
        /// <returns><see cref="Android.Media.LoudnessCodecController"/></returns>
        public static Android.Media.LoudnessCodecController Create(int arg0, Java.Util.Concurrent.Executor arg1, Android.Media.LoudnessCodecController.OnLoudnessCodecUpdateListener arg2)
        {
            return SExecuteWithSignature<Android.Media.LoudnessCodecController>(LocalBridgeClazz, "create", "(ILjava/util/concurrent/Executor;Landroid/media/LoudnessCodecController$OnLoudnessCodecUpdateListener;)Landroid/media/LoudnessCodecController;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.html#create(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.LoudnessCodecController"/></returns>
        public static Android.Media.LoudnessCodecController Create(int arg0)
        {
            return SExecuteWithSignature<Android.Media.LoudnessCodecController>(LocalBridgeClazz, "create", "(I)Landroid/media/LoudnessCodecController;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.html#getLoudnessCodecParams(android.media.MediaCodec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaCodec"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetLoudnessCodecParams(Android.Media.MediaCodec arg0)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getLoudnessCodecParams", "(Landroid/media/MediaCodec;)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.html#addMediaCodec(android.media.MediaCodec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaCodec"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddMediaCodec(Android.Media.MediaCodec arg0)
        {
            return IExecuteWithSignature<bool>("addMediaCodec", "(Landroid/media/MediaCodec;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.html#removeMediaCodec(android.media.MediaCodec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.MediaCodec"/></param>
        public void RemoveMediaCodec(Android.Media.MediaCodec arg0)
        {
            IExecuteWithSignature("removeMediaCodec", "(Landroid/media/MediaCodec;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region OnLoudnessCodecUpdateListener implementation
        public partial class OnLoudnessCodecUpdateListener
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
            /// Handlers initializer for <see cref="OnLoudnessCodecUpdateListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onLoudnessCodecUpdate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnLoudnessCodecUpdateEventHandler));

            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.OnLoudnessCodecUpdateListener.html#onLoudnessCodecUpdate(android.media.MediaCodec,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaCodec"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
            public Android.Os.Bundle OnLoudnessCodecUpdateDefault(Android.Media.MediaCodec arg0, Android.Os.Bundle arg1)
            {
                return IExecuteWithSignature<Android.Os.Bundle>("onLoudnessCodecUpdateDefault", "(Landroid/media/MediaCodec;Landroid/os/Bundle;)Landroid/os/Bundle;", arg0, arg1);
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.OnLoudnessCodecUpdateListener.html#onLoudnessCodecUpdate(android.media.MediaCodec,android.os.Bundle)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnLoudnessCodecUpdate"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.Media.MediaCodec, Android.Os.Bundle, Android.Os.Bundle> OnOnLoudnessCodecUpdate { get; set; } = null;
            
            bool hasOverrideOnLoudnessCodecUpdate = true;
            void OnLoudnessCodecUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnLoudnessCodecUpdate = true;
                var methodToExecute = (OnOnLoudnessCodecUpdate != null) ? OnOnLoudnessCodecUpdate : OnLoudnessCodecUpdate;
                var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.Media.MediaCodec>(0), data.EventData.GetAt<Android.Os.Bundle>(1));
                data.EventData.TypedEventData.SetReturnData(hasOverrideOnLoudnessCodecUpdate, executionResult);
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.OnLoudnessCodecUpdateListener.html#onLoudnessCodecUpdate(android.media.MediaCodec,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaCodec"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnLoudnessCodecUpdateDefault"/>; override the method to implement a different behavior</remarks>
            public virtual Android.Os.Bundle OnLoudnessCodecUpdate(Android.Media.MediaCodec arg0, Android.Os.Bundle arg1)
            {
                hasOverrideOnLoudnessCodecUpdate = false; return default;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnLoudnessCodecUpdateListenerDirect implementation
        public partial class OnLoudnessCodecUpdateListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/LoudnessCodecController.OnLoudnessCodecUpdateListener.html#onLoudnessCodecUpdate(android.media.MediaCodec,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.MediaCodec"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public override Android.Os.Bundle OnLoudnessCodecUpdate(Android.Media.MediaCodec arg0, Android.Os.Bundle arg1)
            {
                return IExecuteWithSignature<Android.Os.Bundle>("onLoudnessCodecUpdate", "(Landroid/media/MediaCodec;Landroid/os/Bundle;)Landroid/os/Bundle;", arg0, arg1);
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