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

namespace Android.Hardware.Camera2
{
    #region CameraCaptureSession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html"/>
    /// </summary>
    public partial class CameraCaptureSession : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.hardware.camera2.CameraCaptureSession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CameraCaptureSession class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CameraCaptureSession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CameraCaptureSession class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CameraCaptureSession(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region CaptureCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html"/>
        /// </summary>
        public partial class CaptureCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CaptureCallback>
        {
            const string _bridgeClassName = "android.hardware.camera2.CameraCaptureSession$CaptureCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("CaptureCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CaptureCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("CaptureCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CaptureCallback(params object[] args) : base(args) { }
        
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

        #region StateCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html"/>
        /// </summary>
        public partial class StateCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StateCallback>
        {
            const string _bridgeClassName = "android.hardware.camera2.CameraCaptureSession$StateCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("StateCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public StateCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("StateCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public StateCallback(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region CameraCaptureSession implementation
    public partial class CameraCaptureSession
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#getDevice()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Camera2.CameraDevice"/></returns>
        public Android.Hardware.Camera2.CameraDevice GetDevice()
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CameraDevice>("getDevice", "()Landroid/hardware/camera2/CameraDevice;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#getInputSurface()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Surface"/></returns>
        public Android.View.Surface GetInputSurface()
        {
            return IExecuteWithSignature<Android.View.Surface>("getInputSurface", "()Landroid/view/Surface;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#isReprocessable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReprocessable()
        {
            return IExecuteWithSignature<bool>("isReprocessable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#capture(android.hardware.camera2.CaptureRequest,android.hardware.camera2.CameraCaptureSession.CaptureCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int Capture(Android.Hardware.Camera2.CaptureRequest arg0, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg1, Android.Os.Handler arg2)
        {
            return IExecuteWithSignature<int>("capture", "(Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;Landroid/os/Handler;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#captureBurst(java.util.List,android.hardware.camera2.CameraCaptureSession.CaptureCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int CaptureBurst(Java.Util.List<Android.Hardware.Camera2.CaptureRequest> arg0, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg1, Android.Os.Handler arg2)
        {
            return IExecuteWithSignature<int>("captureBurst", "(Ljava/util/List;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;Landroid/os/Handler;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#setRepeatingBurst(java.util.List,android.hardware.camera2.CameraCaptureSession.CaptureCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int SetRepeatingBurst(Java.Util.List<Android.Hardware.Camera2.CaptureRequest> arg0, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg1, Android.Os.Handler arg2)
        {
            return IExecuteWithSignature<int>("setRepeatingBurst", "(Ljava/util/List;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;Landroid/os/Handler;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#setRepeatingRequest(android.hardware.camera2.CaptureRequest,android.hardware.camera2.CameraCaptureSession.CaptureCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int SetRepeatingRequest(Android.Hardware.Camera2.CaptureRequest arg0, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg1, Android.Os.Handler arg2)
        {
            return IExecuteWithSignature<int>("setRepeatingRequest", "(Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;Landroid/os/Handler;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#abortCaptures()"/>
        /// </summary>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void AbortCaptures()
        {
            IExecuteWithSignature("abortCaptures", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#finalizeOutputConfigurations(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void FinalizeOutputConfigurations(Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration> arg0)
        {
            IExecuteWithSignature("finalizeOutputConfigurations", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#prepare(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void Prepare(Android.View.Surface arg0)
        {
            IExecuteWithSignature("prepare", "(Landroid/view/Surface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#stopRepeating()"/>
        /// </summary>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void StopRepeating()
        {
            IExecuteWithSignature("stopRepeating", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#switchToOffline(java.util.Collection,java.util.concurrent.Executor,android.hardware.camera2.CameraOfflineSession.CameraOfflineSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraOfflineSession.CameraOfflineSessionCallback"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.CameraOfflineSession"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public Android.Hardware.Camera2.CameraOfflineSession SwitchToOffline(Java.Util.Collection<Android.View.Surface> arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraOfflineSession.CameraOfflineSessionCallback arg2)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CameraOfflineSession>("switchToOffline", "(Ljava/util/Collection;Ljava/util/concurrent/Executor;Landroid/hardware/camera2/CameraOfflineSession$CameraOfflineSessionCallback;)Landroid/hardware/camera2/CameraOfflineSession;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#supportsOfflineProcessing(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsOfflineProcessing(Android.View.Surface arg0)
        {
            return IExecuteWithSignature<bool>("supportsOfflineProcessing", "(Landroid/view/Surface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#captureBurstRequests(java.util.List,java.util.concurrent.Executor,android.hardware.camera2.CameraCaptureSession.CaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int CaptureBurstRequests(Java.Util.List<Android.Hardware.Camera2.CaptureRequest> arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg2)
        {
            return IExecuteWithSignature<int>("captureBurstRequests", "(Ljava/util/List;Ljava/util/concurrent/Executor;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#captureSingleRequest(android.hardware.camera2.CaptureRequest,java.util.concurrent.Executor,android.hardware.camera2.CameraCaptureSession.CaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int CaptureSingleRequest(Android.Hardware.Camera2.CaptureRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg2)
        {
            return IExecuteWithSignature<int>("captureSingleRequest", "(Landroid/hardware/camera2/CaptureRequest;Ljava/util/concurrent/Executor;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#setRepeatingBurstRequests(java.util.List,java.util.concurrent.Executor,android.hardware.camera2.CameraCaptureSession.CaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int SetRepeatingBurstRequests(Java.Util.List<Android.Hardware.Camera2.CaptureRequest> arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg2)
        {
            return IExecuteWithSignature<int>("setRepeatingBurstRequests", "(Ljava/util/List;Ljava/util/concurrent/Executor;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#setSingleRepeatingRequest(android.hardware.camera2.CaptureRequest,java.util.concurrent.Executor,android.hardware.camera2.CameraCaptureSession.CaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int SetSingleRepeatingRequest(Android.Hardware.Camera2.CaptureRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraCaptureSession.CaptureCallback arg2)
        {
            return IExecuteWithSignature<int>("setSingleRepeatingRequest", "(Landroid/hardware/camera2/CaptureRequest;Ljava/util/concurrent/Executor;Landroid/hardware/camera2/CameraCaptureSession$CaptureCallback;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.html#updateOutputConfiguration(android.hardware.camera2.params.OutputConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.OutputConfiguration"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void UpdateOutputConfiguration(Android.Hardware.Camera2.Params.OutputConfiguration arg0)
        {
            IExecuteWithSignature("updateOutputConfiguration", "(Landroid/hardware/camera2/params/OutputConfiguration;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region CaptureCallback implementation
        public partial class CaptureCallback
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onCaptureBufferLost(android.hardware.camera2.CameraCaptureSession,android.hardware.camera2.CaptureRequest,android.view.Surface,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="Android.View.Surface"/></param>
            /// <param name="arg3"><see cref="long"/></param>
            public void OnCaptureBufferLost(Android.Hardware.Camera2.CameraCaptureSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, Android.View.Surface arg2, long arg3)
            {
                IExecuteWithSignature("onCaptureBufferLost", "(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/view/Surface;J)V", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onCaptureCompleted(android.hardware.camera2.CameraCaptureSession,android.hardware.camera2.CaptureRequest,android.hardware.camera2.TotalCaptureResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="Android.Hardware.Camera2.TotalCaptureResult"/></param>
            public void OnCaptureCompleted(Android.Hardware.Camera2.CameraCaptureSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, Android.Hardware.Camera2.TotalCaptureResult arg2)
            {
                IExecuteWithSignature("onCaptureCompleted", "(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/TotalCaptureResult;)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onCaptureFailed(android.hardware.camera2.CameraCaptureSession,android.hardware.camera2.CaptureRequest,android.hardware.camera2.CaptureFailure)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="Android.Hardware.Camera2.CaptureFailure"/></param>
            public void OnCaptureFailed(Android.Hardware.Camera2.CameraCaptureSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, Android.Hardware.Camera2.CaptureFailure arg2)
            {
                IExecuteWithSignature("onCaptureFailed", "(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/CaptureFailure;)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onCaptureProgressed(android.hardware.camera2.CameraCaptureSession,android.hardware.camera2.CaptureRequest,android.hardware.camera2.CaptureResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="Android.Hardware.Camera2.CaptureResult"/></param>
            public void OnCaptureProgressed(Android.Hardware.Camera2.CameraCaptureSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, Android.Hardware.Camera2.CaptureResult arg2)
            {
                IExecuteWithSignature("onCaptureProgressed", "(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/CaptureResult;)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onCaptureSequenceAborted(android.hardware.camera2.CameraCaptureSession,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnCaptureSequenceAborted(Android.Hardware.Camera2.CameraCaptureSession arg0, int arg1)
            {
                IExecuteWithSignature("onCaptureSequenceAborted", "(Landroid/hardware/camera2/CameraCaptureSession;I)V", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onCaptureSequenceCompleted(android.hardware.camera2.CameraCaptureSession,int,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public void OnCaptureSequenceCompleted(Android.Hardware.Camera2.CameraCaptureSession arg0, int arg1, long arg2)
            {
                IExecuteWithSignature("onCaptureSequenceCompleted", "(Landroid/hardware/camera2/CameraCaptureSession;IJ)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onCaptureStarted(android.hardware.camera2.CameraCaptureSession,android.hardware.camera2.CaptureRequest,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="long"/></param>
            public void OnCaptureStarted(Android.Hardware.Camera2.CameraCaptureSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, long arg2, long arg3)
            {
                IExecuteWithSignature("onCaptureStarted", "(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;JJ)V", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.CaptureCallback.html#onReadoutStarted(android.hardware.camera2.CameraCaptureSession,android.hardware.camera2.CaptureRequest,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="long"/></param>
            public void OnReadoutStarted(Android.Hardware.Camera2.CameraCaptureSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, long arg2, long arg3)
            {
                IExecuteWithSignature("onReadoutStarted", "(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;JJ)V", arg0, arg1, arg2, arg3);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region StateCallback implementation
        public partial class StateCallback
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html#onConfigured(android.hardware.camera2.CameraCaptureSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            public void OnConfigured(Android.Hardware.Camera2.CameraCaptureSession arg0)
            {
                IExecuteWithSignature("onConfigured", "(Landroid/hardware/camera2/CameraCaptureSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html#onConfigureFailed(android.hardware.camera2.CameraCaptureSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            public void OnConfigureFailed(Android.Hardware.Camera2.CameraCaptureSession arg0)
            {
                IExecuteWithSignature("onConfigureFailed", "(Landroid/hardware/camera2/CameraCaptureSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html#onActive(android.hardware.camera2.CameraCaptureSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            public void OnActive(Android.Hardware.Camera2.CameraCaptureSession arg0)
            {
                IExecuteWithSignature("onActive", "(Landroid/hardware/camera2/CameraCaptureSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html#onCaptureQueueEmpty(android.hardware.camera2.CameraCaptureSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            public void OnCaptureQueueEmpty(Android.Hardware.Camera2.CameraCaptureSession arg0)
            {
                IExecuteWithSignature("onCaptureQueueEmpty", "(Landroid/hardware/camera2/CameraCaptureSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html#onClosed(android.hardware.camera2.CameraCaptureSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            public void OnClosed(Android.Hardware.Camera2.CameraCaptureSession arg0)
            {
                IExecuteWithSignature("onClosed", "(Landroid/hardware/camera2/CameraCaptureSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html#onReady(android.hardware.camera2.CameraCaptureSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            public void OnReady(Android.Hardware.Camera2.CameraCaptureSession arg0)
            {
                IExecuteWithSignature("onReady", "(Landroid/hardware/camera2/CameraCaptureSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraCaptureSession.StateCallback.html#onSurfacePrepared(android.hardware.camera2.CameraCaptureSession,android.view.Surface)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraCaptureSession"/></param>
            /// <param name="arg1"><see cref="Android.View.Surface"/></param>
            public void OnSurfacePrepared(Android.Hardware.Camera2.CameraCaptureSession arg0, Android.View.Surface arg1)
            {
                IExecuteWithSignature("onSurfacePrepared", "(Landroid/hardware/camera2/CameraCaptureSession;Landroid/view/Surface;)V", arg0, arg1);
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