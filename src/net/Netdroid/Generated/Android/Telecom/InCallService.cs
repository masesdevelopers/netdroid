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

namespace Android.Telecom
{
    #region InCallService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html"/>
    /// </summary>
    public partial class InCallService : Android.App.Service
    {
        const string _bridgeClassName = "android.telecom.InCallService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InCallService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InCallService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InCallService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InCallService(params object[] args) : base(args) { }

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
        #region VideoCall declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html"/>
        /// </summary>
        public partial class VideoCall : MASES.JCOBridge.C2JBridge.JVMBridgeBase<VideoCall>
        {
            const string _bridgeClassName = "android.telecom.InCallService$VideoCall";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("VideoCall class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public VideoCall() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("VideoCall class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public VideoCall(params object[] args) : base(args) { }

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
            #region Callback declaration
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html"/>
            /// </summary>
            public partial class Callback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Callback>
            {
                const string _bridgeClassName = "android.telecom.InCallService$VideoCall$Callback";
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

        
        }
        #endregion

    
    }
    #endregion

    #region InCallService implementation
    public partial class InCallService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#getCallAudioState()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.CallAudioState"/></returns>
        [global::System.Obsolete()]
        public Android.Telecom.CallAudioState GetCallAudioState()
        {
            return IExecuteWithSignature<Android.Telecom.CallAudioState>("getCallAudioState", "()Landroid/telecom/CallAudioState;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#getCurrentCallEndpoint()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.CallEndpoint"/></returns>
        public Android.Telecom.CallEndpoint GetCurrentCallEndpoint()
        {
            return IExecuteWithSignature<Android.Telecom.CallEndpoint>("getCurrentCallEndpoint", "()Landroid/telecom/CallEndpoint;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#canAddCall()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanAddCall()
        {
            return IExecuteWithSignature<bool>("canAddCall", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#getCalls()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telecom.Call> GetCalls()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telecom.Call>>("getCalls", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#requestBluetoothAudio(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        [global::System.Obsolete()]
        public void RequestBluetoothAudio(Android.Bluetooth.BluetoothDevice arg0)
        {
            IExecuteWithSignature("requestBluetoothAudio", "(Landroid/bluetooth/BluetoothDevice;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#requestCallEndpointChange(android.telecom.CallEndpoint,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallEndpoint"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void RequestCallEndpointChange(Android.Telecom.CallEndpoint arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Java.Lang.Void, Android.Telecom.CallEndpointException> arg2)
        {
            IExecuteWithSignature("requestCallEndpointChange", "(Landroid/telecom/CallEndpoint;Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#setAudioRoute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetAudioRoute(int arg0)
        {
            IExecuteWithSignature("setAudioRoute", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#setMuted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMuted(bool arg0)
        {
            IExecuteWithSignature("setMuted", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onAvailableCallEndpointsChanged(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void OnAvailableCallEndpointsChanged(Java.Util.List<Android.Telecom.CallEndpoint> arg0)
        {
            IExecuteWithSignature("onAvailableCallEndpointsChanged", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onBringToForeground(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnBringToForeground(bool arg0)
        {
            IExecuteWithSignature("onBringToForeground", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onCallAdded(android.telecom.Call)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Call"/></param>
        public void OnCallAdded(Android.Telecom.Call arg0)
        {
            IExecuteWithSignature("onCallAdded", "(Landroid/telecom/Call;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onCallAudioStateChanged(android.telecom.CallAudioState)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallAudioState"/></param>
        [global::System.Obsolete()]
        public void OnCallAudioStateChanged(Android.Telecom.CallAudioState arg0)
        {
            IExecuteWithSignature("onCallAudioStateChanged", "(Landroid/telecom/CallAudioState;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onCallEndpointChanged(android.telecom.CallEndpoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.CallEndpoint"/></param>
        public void OnCallEndpointChanged(Android.Telecom.CallEndpoint arg0)
        {
            IExecuteWithSignature("onCallEndpointChanged", "(Landroid/telecom/CallEndpoint;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onCallRemoved(android.telecom.Call)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Call"/></param>
        public void OnCallRemoved(Android.Telecom.Call arg0)
        {
            IExecuteWithSignature("onCallRemoved", "(Landroid/telecom/Call;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onCanAddCallChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnCanAddCallChanged(bool arg0)
        {
            IExecuteWithSignature("onCanAddCallChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onConnectionEvent(android.telecom.Call,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.Call"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        public void OnConnectionEvent(Android.Telecom.Call arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
        {
            IExecuteWithSignature("onConnectionEvent", "(Landroid/telecom/Call;Ljava/lang/String;Landroid/os/Bundle;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onMuteStateChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnMuteStateChanged(bool arg0)
        {
            IExecuteWithSignature("onMuteStateChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/InCallService.html#onSilenceRinger()"/>
        /// </summary>
        public void OnSilenceRinger()
        {
            IExecuteWithSignature("onSilenceRinger", "()V");
        }

        #endregion

        #region Nested classes
        #region VideoCall implementation
        public partial class VideoCall
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
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#registerCallback(android.telecom.InCallService.VideoCall.Callback,android.os.Handler)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.InCallService.VideoCall.Callback"/></param>
            /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
            public void RegisterCallback(Android.Telecom.InCallService.VideoCall.Callback arg0, Android.Os.Handler arg1)
            {
                IExecuteWithSignature("registerCallback", "(Landroid/telecom/InCallService$VideoCall$Callback;Landroid/os/Handler;)V", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#registerCallback(android.telecom.InCallService.VideoCall.Callback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.InCallService.VideoCall.Callback"/></param>
            public void RegisterCallback(Android.Telecom.InCallService.VideoCall.Callback arg0)
            {
                IExecuteWithSignature("registerCallback", "(Landroid/telecom/InCallService$VideoCall$Callback;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#requestCallDataUsage()"/>
            /// </summary>
            public void RequestCallDataUsage()
            {
                IExecuteWithSignature("requestCallDataUsage", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#requestCameraCapabilities()"/>
            /// </summary>
            public void RequestCameraCapabilities()
            {
                IExecuteWithSignature("requestCameraCapabilities", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#sendSessionModifyRequest(android.telecom.VideoProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.VideoProfile"/></param>
            public void SendSessionModifyRequest(Android.Telecom.VideoProfile arg0)
            {
                IExecuteWithSignature("sendSessionModifyRequest", "(Landroid/telecom/VideoProfile;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#sendSessionModifyResponse(android.telecom.VideoProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.VideoProfile"/></param>
            public void SendSessionModifyResponse(Android.Telecom.VideoProfile arg0)
            {
                IExecuteWithSignature("sendSessionModifyResponse", "(Landroid/telecom/VideoProfile;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#setCamera(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void SetCamera(Java.Lang.String arg0)
            {
                IExecuteWithSignature("setCamera", "(Ljava/lang/String;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#setDeviceOrientation(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetDeviceOrientation(int arg0)
            {
                IExecuteWithSignature("setDeviceOrientation", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#setDisplaySurface(android.view.Surface)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Surface"/></param>
            public void SetDisplaySurface(Android.View.Surface arg0)
            {
                IExecuteWithSignature("setDisplaySurface", "(Landroid/view/Surface;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#setPauseImage(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            public void SetPauseImage(Android.Net.Uri arg0)
            {
                IExecuteWithSignature("setPauseImage", "(Landroid/net/Uri;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#setPreviewSurface(android.view.Surface)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Surface"/></param>
            public void SetPreviewSurface(Android.View.Surface arg0)
            {
                IExecuteWithSignature("setPreviewSurface", "(Landroid/view/Surface;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#setZoom(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void SetZoom(float arg0)
            {
                IExecuteWithSignature("setZoom", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.html#unregisterCallback(android.telecom.InCallService.VideoCall.Callback)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Telecom.InCallService.VideoCall.Callback"/></param>
            public void UnregisterCallback(Android.Telecom.InCallService.VideoCall.Callback arg0)
            {
                IExecuteWithSignature("unregisterCallback", "(Landroid/telecom/InCallService$VideoCall$Callback;)V", arg0);
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
                /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html#onCallDataUsageChanged(long)"/>
                /// </summary>
                /// <param name="arg0"><see cref="long"/></param>
                public void OnCallDataUsageChanged(long arg0)
                {
                    IExecuteWithSignature("onCallDataUsageChanged", "(J)V", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html#onCallSessionEvent(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                public void OnCallSessionEvent(int arg0)
                {
                    IExecuteWithSignature("onCallSessionEvent", "(I)V", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html#onCameraCapabilitiesChanged(android.telecom.VideoProfile.CameraCapabilities)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.VideoProfile.CameraCapabilities"/></param>
                public void OnCameraCapabilitiesChanged(Android.Telecom.VideoProfile.CameraCapabilities arg0)
                {
                    IExecuteWithSignature("onCameraCapabilitiesChanged", "(Landroid/telecom/VideoProfile$CameraCapabilities;)V", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html#onPeerDimensionsChanged(int,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                public void OnPeerDimensionsChanged(int arg0, int arg1)
                {
                    IExecuteWithSignature("onPeerDimensionsChanged", "(II)V", arg0, arg1);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html#onSessionModifyRequestReceived(android.telecom.VideoProfile)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Telecom.VideoProfile"/></param>
                public void OnSessionModifyRequestReceived(Android.Telecom.VideoProfile arg0)
                {
                    IExecuteWithSignature("onSessionModifyRequestReceived", "(Landroid/telecom/VideoProfile;)V", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html#onSessionModifyResponseReceived(int,android.telecom.VideoProfile,android.telecom.VideoProfile)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <param name="arg1"><see cref="Android.Telecom.VideoProfile"/></param>
                /// <param name="arg2"><see cref="Android.Telecom.VideoProfile"/></param>
                public void OnSessionModifyResponseReceived(int arg0, Android.Telecom.VideoProfile arg1, Android.Telecom.VideoProfile arg2)
                {
                    IExecuteWithSignature("onSessionModifyResponseReceived", "(ILandroid/telecom/VideoProfile;Landroid/telecom/VideoProfile;)V", arg0, arg1, arg2);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/telecom/InCallService.VideoCall.Callback.html#onVideoQualityChanged(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                public void OnVideoQualityChanged(int arg0)
                {
                    IExecuteWithSignature("onVideoQualityChanged", "(I)V", arg0);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}