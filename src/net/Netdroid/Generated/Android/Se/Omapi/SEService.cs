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

namespace Android.Se.Omapi
{
    #region SEService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html"/>
    /// </summary>
    public partial class SEService : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SEService>
    {
        const string _bridgeClassName = "android.se.omapi.SEService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SEService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SEService(params object[] args) : base(args) { }

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
        #region OnConnectedListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.OnConnectedListener.html"/>
        /// </summary>
        public partial class OnConnectedListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnConnectedListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.se.omapi.SEService_OnConnectedListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnConnectedListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnConnectedListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnConnectedListenerDirect : OnConnectedListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.se.omapi.SEService$OnConnectedListener";
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

    #region SEService implementation
    public partial class SEService
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#%3Cinit%3E(android.content.Context,java.util.concurrent.Executor,android.se.omapi.SEService.OnConnectedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Se.Omapi.SEService.OnConnectedListener"/></param>
        public SEService(Android.Content.Context arg0, Java.Util.Concurrent.Executor arg1, Android.Se.Omapi.SEService.OnConnectedListener arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#ACTION_SECURE_ELEMENT_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_SECURE_ELEMENT_STATE_CHANGED { get { if (!_ACTION_SECURE_ELEMENT_STATE_CHANGEDReady) { _ACTION_SECURE_ELEMENT_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SECURE_ELEMENT_STATE_CHANGED"); _ACTION_SECURE_ELEMENT_STATE_CHANGEDReady = true; } return _ACTION_SECURE_ELEMENT_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_SECURE_ELEMENT_STATE_CHANGEDContent = default;
        private static bool _ACTION_SECURE_ELEMENT_STATE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#EXTRA_READER_NAME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_READER_NAME { get { if (!_EXTRA_READER_NAMEReady) { _EXTRA_READER_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_READER_NAME"); _EXTRA_READER_NAMEReady = true; } return _EXTRA_READER_NAMEContent; } }
        private static Java.Lang.String _EXTRA_READER_NAMEContent = default;
        private static bool _EXTRA_READER_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#EXTRA_READER_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_READER_STATE { get { if (!_EXTRA_READER_STATEReady) { _EXTRA_READER_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_READER_STATE"); _EXTRA_READER_STATEReady = true; } return _EXTRA_READER_STATEContent; } }
        private static Java.Lang.String _EXTRA_READER_STATEContent = default;
        private static bool _EXTRA_READER_STATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#getUiccReader(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Se.Omapi.Reader"/></returns>
        public Android.Se.Omapi.Reader GetUiccReader(int arg0)
        {
            return IExecuteWithSignature<Android.Se.Omapi.Reader>("getUiccReader", "(I)Landroid/se/omapi/Reader;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#getReaders()"/>
        /// </summary>
        /// <returns><see cref="Android.Se.Omapi.Reader"/></returns>
        public Android.Se.Omapi.Reader[] GetReaders()
        {
            return IExecuteWithSignatureArray<Android.Se.Omapi.Reader>("getReaders", "()[Landroid/se/omapi/Reader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.html#shutdown()"/>
        /// </summary>
        public void Shutdown()
        {
            IExecuteWithSignature("shutdown", "()V");
        }

        #endregion

        #region Nested classes
        #region OnConnectedListener implementation
        public partial class OnConnectedListener
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
            /// Handlers initializer for <see cref="OnConnectedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onConnected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnConnectedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/se/omapi/SEService.OnConnectedListener.html#onConnected()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnConnected"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnConnected { get; set; } = null;

            bool hasOverrideOnConnected = true;
            void OnConnectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnConnected = true;
                var methodToExecute = (OnOnConnected != null) ? OnOnConnected : OnConnected;
                methodToExecute.Invoke();
                data.EventData.TypedEventData.HasOverride = hasOverrideOnConnected;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.OnConnectedListener.html#onConnected()"/>
            /// </summary>
            public virtual void OnConnected()
            {
                hasOverrideOnConnected = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnConnectedListenerDirect implementation
        public partial class OnConnectedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/se/omapi/SEService.OnConnectedListener.html#onConnected()"/>
            /// </summary>
            public override void OnConnected()
            {
                IExecuteWithSignature("onConnected", "()V");
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