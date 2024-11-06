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
    #region CameraDevice declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html"/>
    /// </summary>
    public partial class CameraDevice : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.hardware.camera2.CameraDevice";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CameraDevice class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CameraDevice() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CameraDevice class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CameraDevice(params object[] args) : base(args) { }
    
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
        #region CameraDeviceSetup declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.CameraDeviceSetup.html"/>
        /// </summary>
        public partial class CameraDeviceSetup : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CameraDeviceSetup>
        {
            const string _bridgeClassName = "android.hardware.camera2.CameraDevice$CameraDeviceSetup";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("CameraDeviceSetup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CameraDeviceSetup() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("CameraDeviceSetup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CameraDeviceSetup(params object[] args) : base(args) { }
        
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html"/>
        /// </summary>
        public partial class StateCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StateCallback>
        {
            const string _bridgeClassName = "android.hardware.camera2.CameraDevice$StateCallback";
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

    #region CameraDevice implementation
    public partial class CameraDevice
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#AUDIO_RESTRICTION_NONE"/>
        /// </summary>
        public static int AUDIO_RESTRICTION_NONE { get { if (!_AUDIO_RESTRICTION_NONEReady) { _AUDIO_RESTRICTION_NONEContent = SGetField<int>(LocalBridgeClazz, "AUDIO_RESTRICTION_NONE"); _AUDIO_RESTRICTION_NONEReady = true; } return _AUDIO_RESTRICTION_NONEContent; } }
        private static int _AUDIO_RESTRICTION_NONEContent = default;
        private static bool _AUDIO_RESTRICTION_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#AUDIO_RESTRICTION_VIBRATION"/>
        /// </summary>
        public static int AUDIO_RESTRICTION_VIBRATION { get { if (!_AUDIO_RESTRICTION_VIBRATIONReady) { _AUDIO_RESTRICTION_VIBRATIONContent = SGetField<int>(LocalBridgeClazz, "AUDIO_RESTRICTION_VIBRATION"); _AUDIO_RESTRICTION_VIBRATIONReady = true; } return _AUDIO_RESTRICTION_VIBRATIONContent; } }
        private static int _AUDIO_RESTRICTION_VIBRATIONContent = default;
        private static bool _AUDIO_RESTRICTION_VIBRATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#AUDIO_RESTRICTION_VIBRATION_SOUND"/>
        /// </summary>
        public static int AUDIO_RESTRICTION_VIBRATION_SOUND { get { if (!_AUDIO_RESTRICTION_VIBRATION_SOUNDReady) { _AUDIO_RESTRICTION_VIBRATION_SOUNDContent = SGetField<int>(LocalBridgeClazz, "AUDIO_RESTRICTION_VIBRATION_SOUND"); _AUDIO_RESTRICTION_VIBRATION_SOUNDReady = true; } return _AUDIO_RESTRICTION_VIBRATION_SOUNDContent; } }
        private static int _AUDIO_RESTRICTION_VIBRATION_SOUNDContent = default;
        private static bool _AUDIO_RESTRICTION_VIBRATION_SOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#TEMPLATE_MANUAL"/>
        /// </summary>
        public static int TEMPLATE_MANUAL { get { if (!_TEMPLATE_MANUALReady) { _TEMPLATE_MANUALContent = SGetField<int>(LocalBridgeClazz, "TEMPLATE_MANUAL"); _TEMPLATE_MANUALReady = true; } return _TEMPLATE_MANUALContent; } }
        private static int _TEMPLATE_MANUALContent = default;
        private static bool _TEMPLATE_MANUALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#TEMPLATE_PREVIEW"/>
        /// </summary>
        public static int TEMPLATE_PREVIEW { get { if (!_TEMPLATE_PREVIEWReady) { _TEMPLATE_PREVIEWContent = SGetField<int>(LocalBridgeClazz, "TEMPLATE_PREVIEW"); _TEMPLATE_PREVIEWReady = true; } return _TEMPLATE_PREVIEWContent; } }
        private static int _TEMPLATE_PREVIEWContent = default;
        private static bool _TEMPLATE_PREVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#TEMPLATE_RECORD"/>
        /// </summary>
        public static int TEMPLATE_RECORD { get { if (!_TEMPLATE_RECORDReady) { _TEMPLATE_RECORDContent = SGetField<int>(LocalBridgeClazz, "TEMPLATE_RECORD"); _TEMPLATE_RECORDReady = true; } return _TEMPLATE_RECORDContent; } }
        private static int _TEMPLATE_RECORDContent = default;
        private static bool _TEMPLATE_RECORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#TEMPLATE_STILL_CAPTURE"/>
        /// </summary>
        public static int TEMPLATE_STILL_CAPTURE { get { if (!_TEMPLATE_STILL_CAPTUREReady) { _TEMPLATE_STILL_CAPTUREContent = SGetField<int>(LocalBridgeClazz, "TEMPLATE_STILL_CAPTURE"); _TEMPLATE_STILL_CAPTUREReady = true; } return _TEMPLATE_STILL_CAPTUREContent; } }
        private static int _TEMPLATE_STILL_CAPTUREContent = default;
        private static bool _TEMPLATE_STILL_CAPTUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#TEMPLATE_VIDEO_SNAPSHOT"/>
        /// </summary>
        public static int TEMPLATE_VIDEO_SNAPSHOT { get { if (!_TEMPLATE_VIDEO_SNAPSHOTReady) { _TEMPLATE_VIDEO_SNAPSHOTContent = SGetField<int>(LocalBridgeClazz, "TEMPLATE_VIDEO_SNAPSHOT"); _TEMPLATE_VIDEO_SNAPSHOTReady = true; } return _TEMPLATE_VIDEO_SNAPSHOTContent; } }
        private static int _TEMPLATE_VIDEO_SNAPSHOTContent = default;
        private static bool _TEMPLATE_VIDEO_SNAPSHOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#TEMPLATE_ZERO_SHUTTER_LAG"/>
        /// </summary>
        public static int TEMPLATE_ZERO_SHUTTER_LAG { get { if (!_TEMPLATE_ZERO_SHUTTER_LAGReady) { _TEMPLATE_ZERO_SHUTTER_LAGContent = SGetField<int>(LocalBridgeClazz, "TEMPLATE_ZERO_SHUTTER_LAG"); _TEMPLATE_ZERO_SHUTTER_LAGReady = true; } return _TEMPLATE_ZERO_SHUTTER_LAGContent; } }
        private static int _TEMPLATE_ZERO_SHUTTER_LAGContent = default;
        private static bool _TEMPLATE_ZERO_SHUTTER_LAGReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createCaptureRequest(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.CaptureRequest.Builder"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public Android.Hardware.Camera2.CaptureRequest.Builder CreateCaptureRequest(int arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CaptureRequest.Builder>("createCaptureRequest", "(I)Landroid/hardware/camera2/CaptureRequest$Builder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createReprocessCaptureRequest(android.hardware.camera2.TotalCaptureResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.TotalCaptureResult"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.CaptureRequest.Builder"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public Android.Hardware.Camera2.CaptureRequest.Builder CreateReprocessCaptureRequest(Android.Hardware.Camera2.TotalCaptureResult arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CaptureRequest.Builder>("createReprocessCaptureRequest", "(Landroid/hardware/camera2/TotalCaptureResult;)Landroid/hardware/camera2/CaptureRequest$Builder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createCaptureSession(java.util.List,android.hardware.camera2.CameraCaptureSession.StateCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraCaptureSession.StateCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        [global::System.Obsolete()]
        public void CreateCaptureSession(Java.Util.List<Android.View.Surface> arg0, Android.Hardware.Camera2.CameraCaptureSession.StateCallback arg1, Android.Os.Handler arg2)
        {
            IExecuteWithSignature("createCaptureSession", "(Ljava/util/List;Landroid/hardware/camera2/CameraCaptureSession$StateCallback;Landroid/os/Handler;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createCaptureSessionByOutputConfigurations(java.util.List,android.hardware.camera2.CameraCaptureSession.StateCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraCaptureSession.StateCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        [global::System.Obsolete()]
        public void CreateCaptureSessionByOutputConfigurations(Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration> arg0, Android.Hardware.Camera2.CameraCaptureSession.StateCallback arg1, Android.Os.Handler arg2)
        {
            IExecuteWithSignature("createCaptureSessionByOutputConfigurations", "(Ljava/util/List;Landroid/hardware/camera2/CameraCaptureSession$StateCallback;Landroid/os/Handler;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createConstrainedHighSpeedCaptureSession(java.util.List,android.hardware.camera2.CameraCaptureSession.StateCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraCaptureSession.StateCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        [global::System.Obsolete()]
        public void CreateConstrainedHighSpeedCaptureSession(Java.Util.List<Android.View.Surface> arg0, Android.Hardware.Camera2.CameraCaptureSession.StateCallback arg1, Android.Os.Handler arg2)
        {
            IExecuteWithSignature("createConstrainedHighSpeedCaptureSession", "(Ljava/util/List;Landroid/hardware/camera2/CameraCaptureSession$StateCallback;Landroid/os/Handler;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createReprocessableCaptureSession(android.hardware.camera2.params.InputConfiguration,java.util.List,android.hardware.camera2.CameraCaptureSession.StateCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.InputConfiguration"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraCaptureSession.StateCallback"/></param>
        /// <param name="arg3"><see cref="Android.Os.Handler"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        [global::System.Obsolete()]
        public void CreateReprocessableCaptureSession(Android.Hardware.Camera2.Params.InputConfiguration arg0, Java.Util.List<Android.View.Surface> arg1, Android.Hardware.Camera2.CameraCaptureSession.StateCallback arg2, Android.Os.Handler arg3)
        {
            IExecuteWithSignature("createReprocessableCaptureSession", "(Landroid/hardware/camera2/params/InputConfiguration;Ljava/util/List;Landroid/hardware/camera2/CameraCaptureSession$StateCallback;Landroid/os/Handler;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createReprocessableCaptureSessionByConfigurations(android.hardware.camera2.params.InputConfiguration,java.util.List,android.hardware.camera2.CameraCaptureSession.StateCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.InputConfiguration"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraCaptureSession.StateCallback"/></param>
        /// <param name="arg3"><see cref="Android.Os.Handler"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        [global::System.Obsolete()]
        public void CreateReprocessableCaptureSessionByConfigurations(Android.Hardware.Camera2.Params.InputConfiguration arg0, Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration> arg1, Android.Hardware.Camera2.CameraCaptureSession.StateCallback arg2, Android.Os.Handler arg3)
        {
            IExecuteWithSignature("createReprocessableCaptureSessionByConfigurations", "(Landroid/hardware/camera2/params/InputConfiguration;Ljava/util/List;Landroid/hardware/camera2/CameraCaptureSession$StateCallback;Landroid/os/Handler;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createCaptureRequest(int,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.CaptureRequest.Builder"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public Android.Hardware.Camera2.CaptureRequest.Builder CreateCaptureRequest(int arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CaptureRequest.Builder>("createCaptureRequest", "(ILjava/util/Set;)Landroid/hardware/camera2/CaptureRequest$Builder;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#isSessionConfigurationSupported(android.hardware.camera2.params.SessionConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.SessionConfiguration"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public bool IsSessionConfigurationSupported(Android.Hardware.Camera2.Params.SessionConfiguration arg0)
        {
            return IExecuteWithSignature<bool>("isSessionConfigurationSupported", "(Landroid/hardware/camera2/params/SessionConfiguration;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#getCameraAudioRestriction()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int GetCameraAudioRestriction()
        {
            return IExecuteWithSignature<int>("getCameraAudioRestriction", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createCaptureSession(android.hardware.camera2.params.SessionConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.SessionConfiguration"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void CreateCaptureSession(Android.Hardware.Camera2.Params.SessionConfiguration arg0)
        {
            IExecuteWithSignature("createCaptureSession", "(Landroid/hardware/camera2/params/SessionConfiguration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#createExtensionSession(android.hardware.camera2.params.ExtensionSessionConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.ExtensionSessionConfiguration"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void CreateExtensionSession(Android.Hardware.Camera2.Params.ExtensionSessionConfiguration arg0)
        {
            IExecuteWithSignature("createExtensionSession", "(Landroid/hardware/camera2/params/ExtensionSessionConfiguration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.html#setCameraAudioRestriction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void SetCameraAudioRestriction(int arg0)
        {
            IExecuteWithSignature("setCameraAudioRestriction", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region CameraDeviceSetup implementation
        public partial class CameraDeviceSetup
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.CameraDeviceSetup.html#getSessionCharacteristics(android.hardware.camera2.params.SessionConfiguration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.SessionConfiguration"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.CameraCharacteristics"/></returns>
            /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
            public Android.Hardware.Camera2.CameraCharacteristics GetSessionCharacteristics(Android.Hardware.Camera2.Params.SessionConfiguration arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.CameraCharacteristics>("getSessionCharacteristics", "(Landroid/hardware/camera2/params/SessionConfiguration;)Landroid/hardware/camera2/CameraCharacteristics;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.CameraDeviceSetup.html#createCaptureRequest(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.CaptureRequest.Builder"/></returns>
            /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
            public Android.Hardware.Camera2.CaptureRequest.Builder CreateCaptureRequest(int arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.CaptureRequest.Builder>("createCaptureRequest", "(I)Landroid/hardware/camera2/CaptureRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.CameraDeviceSetup.html#isSessionConfigurationSupported(android.hardware.camera2.params.SessionConfiguration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.SessionConfiguration"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
            public bool IsSessionConfigurationSupported(Android.Hardware.Camera2.Params.SessionConfiguration arg0)
            {
                return IExecuteWithSignature<bool>("isSessionConfigurationSupported", "(Landroid/hardware/camera2/params/SessionConfiguration;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.CameraDeviceSetup.html#getId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.CameraDeviceSetup.html#openCamera(java.util.concurrent.Executor,android.hardware.camera2.CameraDevice.StateCallback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraDevice.StateCallback"/></param>
            /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
            public void OpenCamera(Java.Util.Concurrent.Executor arg0, Android.Hardware.Camera2.CameraDevice.StateCallback arg1)
            {
                IExecuteWithSignature("openCamera", "(Ljava/util/concurrent/Executor;Landroid/hardware/camera2/CameraDevice$StateCallback;)V", arg0, arg1);
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#ERROR_CAMERA_DEVICE"/>
            /// </summary>
            public static int ERROR_CAMERA_DEVICE { get { if (!_ERROR_CAMERA_DEVICEReady) { _ERROR_CAMERA_DEVICEContent = SGetField<int>(LocalBridgeClazz, "ERROR_CAMERA_DEVICE"); _ERROR_CAMERA_DEVICEReady = true; } return _ERROR_CAMERA_DEVICEContent; } }
            private static int _ERROR_CAMERA_DEVICEContent = default;
            private static bool _ERROR_CAMERA_DEVICEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#ERROR_CAMERA_DISABLED"/>
            /// </summary>
            public static int ERROR_CAMERA_DISABLED { get { if (!_ERROR_CAMERA_DISABLEDReady) { _ERROR_CAMERA_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_CAMERA_DISABLED"); _ERROR_CAMERA_DISABLEDReady = true; } return _ERROR_CAMERA_DISABLEDContent; } }
            private static int _ERROR_CAMERA_DISABLEDContent = default;
            private static bool _ERROR_CAMERA_DISABLEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#ERROR_CAMERA_IN_USE"/>
            /// </summary>
            public static int ERROR_CAMERA_IN_USE { get { if (!_ERROR_CAMERA_IN_USEReady) { _ERROR_CAMERA_IN_USEContent = SGetField<int>(LocalBridgeClazz, "ERROR_CAMERA_IN_USE"); _ERROR_CAMERA_IN_USEReady = true; } return _ERROR_CAMERA_IN_USEContent; } }
            private static int _ERROR_CAMERA_IN_USEContent = default;
            private static bool _ERROR_CAMERA_IN_USEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#ERROR_CAMERA_SERVICE"/>
            /// </summary>
            public static int ERROR_CAMERA_SERVICE { get { if (!_ERROR_CAMERA_SERVICEReady) { _ERROR_CAMERA_SERVICEContent = SGetField<int>(LocalBridgeClazz, "ERROR_CAMERA_SERVICE"); _ERROR_CAMERA_SERVICEReady = true; } return _ERROR_CAMERA_SERVICEContent; } }
            private static int _ERROR_CAMERA_SERVICEContent = default;
            private static bool _ERROR_CAMERA_SERVICEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#ERROR_MAX_CAMERAS_IN_USE"/>
            /// </summary>
            public static int ERROR_MAX_CAMERAS_IN_USE { get { if (!_ERROR_MAX_CAMERAS_IN_USEReady) { _ERROR_MAX_CAMERAS_IN_USEContent = SGetField<int>(LocalBridgeClazz, "ERROR_MAX_CAMERAS_IN_USE"); _ERROR_MAX_CAMERAS_IN_USEReady = true; } return _ERROR_MAX_CAMERAS_IN_USEContent; } }
            private static int _ERROR_MAX_CAMERAS_IN_USEContent = default;
            private static bool _ERROR_MAX_CAMERAS_IN_USEReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#onDisconnected(android.hardware.camera2.CameraDevice)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraDevice"/></param>
            public void OnDisconnected(Android.Hardware.Camera2.CameraDevice arg0)
            {
                IExecuteWithSignature("onDisconnected", "(Landroid/hardware/camera2/CameraDevice;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#onError(android.hardware.camera2.CameraDevice,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraDevice"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnError(Android.Hardware.Camera2.CameraDevice arg0, int arg1)
            {
                IExecuteWithSignature("onError", "(Landroid/hardware/camera2/CameraDevice;I)V", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#onOpened(android.hardware.camera2.CameraDevice)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraDevice"/></param>
            public void OnOpened(Android.Hardware.Camera2.CameraDevice arg0)
            {
                IExecuteWithSignature("onOpened", "(Landroid/hardware/camera2/CameraDevice;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraDevice.StateCallback.html#onClosed(android.hardware.camera2.CameraDevice)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraDevice"/></param>
            public void OnClosed(Android.Hardware.Camera2.CameraDevice arg0)
            {
                IExecuteWithSignature("onClosed", "(Landroid/hardware/camera2/CameraDevice;)V", arg0);
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