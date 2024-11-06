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

namespace Android.App.Sdksandbox
{
    #region SdkSandboxManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html"/>
    /// </summary>
    public partial class SdkSandboxManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SdkSandboxManager>
    {
        const string _bridgeClassName = "android.app.sdksandbox.SdkSandboxManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SdkSandboxManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SdkSandboxManager(params object[] args) : base(args) { }
    
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
        #region SdkSandboxProcessDeathCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.SdkSandboxProcessDeathCallback.html"/>
        /// </summary>
        public partial class SdkSandboxProcessDeathCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SdkSandboxProcessDeathCallback>
        {
            const string _bridgeClassName = "android.app.sdksandbox.SdkSandboxManager$SdkSandboxProcessDeathCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("SdkSandboxProcessDeathCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public SdkSandboxProcessDeathCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("SdkSandboxProcessDeathCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public SdkSandboxProcessDeathCallback(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region SdkSandboxManager implementation
    public partial class SdkSandboxManager
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#LOAD_SDK_ALREADY_LOADED"/>
        /// </summary>
        public static int LOAD_SDK_ALREADY_LOADED { get { if (!_LOAD_SDK_ALREADY_LOADEDReady) { _LOAD_SDK_ALREADY_LOADEDContent = SGetField<int>(LocalBridgeClazz, "LOAD_SDK_ALREADY_LOADED"); _LOAD_SDK_ALREADY_LOADEDReady = true; } return _LOAD_SDK_ALREADY_LOADEDContent; } }
        private static int _LOAD_SDK_ALREADY_LOADEDContent = default;
        private static bool _LOAD_SDK_ALREADY_LOADEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#LOAD_SDK_INTERNAL_ERROR"/>
        /// </summary>
        public static int LOAD_SDK_INTERNAL_ERROR { get { if (!_LOAD_SDK_INTERNAL_ERRORReady) { _LOAD_SDK_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "LOAD_SDK_INTERNAL_ERROR"); _LOAD_SDK_INTERNAL_ERRORReady = true; } return _LOAD_SDK_INTERNAL_ERRORContent; } }
        private static int _LOAD_SDK_INTERNAL_ERRORContent = default;
        private static bool _LOAD_SDK_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#LOAD_SDK_NOT_FOUND"/>
        /// </summary>
        public static int LOAD_SDK_NOT_FOUND { get { if (!_LOAD_SDK_NOT_FOUNDReady) { _LOAD_SDK_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "LOAD_SDK_NOT_FOUND"); _LOAD_SDK_NOT_FOUNDReady = true; } return _LOAD_SDK_NOT_FOUNDContent; } }
        private static int _LOAD_SDK_NOT_FOUNDContent = default;
        private static bool _LOAD_SDK_NOT_FOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#LOAD_SDK_SDK_DEFINED_ERROR"/>
        /// </summary>
        public static int LOAD_SDK_SDK_DEFINED_ERROR { get { if (!_LOAD_SDK_SDK_DEFINED_ERRORReady) { _LOAD_SDK_SDK_DEFINED_ERRORContent = SGetField<int>(LocalBridgeClazz, "LOAD_SDK_SDK_DEFINED_ERROR"); _LOAD_SDK_SDK_DEFINED_ERRORReady = true; } return _LOAD_SDK_SDK_DEFINED_ERRORContent; } }
        private static int _LOAD_SDK_SDK_DEFINED_ERRORContent = default;
        private static bool _LOAD_SDK_SDK_DEFINED_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#LOAD_SDK_SDK_SANDBOX_DISABLED"/>
        /// </summary>
        public static int LOAD_SDK_SDK_SANDBOX_DISABLED { get { if (!_LOAD_SDK_SDK_SANDBOX_DISABLEDReady) { _LOAD_SDK_SDK_SANDBOX_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "LOAD_SDK_SDK_SANDBOX_DISABLED"); _LOAD_SDK_SDK_SANDBOX_DISABLEDReady = true; } return _LOAD_SDK_SDK_SANDBOX_DISABLEDContent; } }
        private static int _LOAD_SDK_SDK_SANDBOX_DISABLEDContent = default;
        private static bool _LOAD_SDK_SDK_SANDBOX_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#REQUEST_SURFACE_PACKAGE_INTERNAL_ERROR"/>
        /// </summary>
        public static int REQUEST_SURFACE_PACKAGE_INTERNAL_ERROR { get { if (!_REQUEST_SURFACE_PACKAGE_INTERNAL_ERRORReady) { _REQUEST_SURFACE_PACKAGE_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "REQUEST_SURFACE_PACKAGE_INTERNAL_ERROR"); _REQUEST_SURFACE_PACKAGE_INTERNAL_ERRORReady = true; } return _REQUEST_SURFACE_PACKAGE_INTERNAL_ERRORContent; } }
        private static int _REQUEST_SURFACE_PACKAGE_INTERNAL_ERRORContent = default;
        private static bool _REQUEST_SURFACE_PACKAGE_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADED"/>
        /// </summary>
        public static int REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADED { get { if (!_REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADEDReady) { _REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADEDContent = SGetField<int>(LocalBridgeClazz, "REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADED"); _REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADEDReady = true; } return _REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADEDContent; } }
        private static int _REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADEDContent = default;
        private static bool _REQUEST_SURFACE_PACKAGE_SDK_NOT_LOADEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#SDK_SANDBOX_PROCESS_NOT_AVAILABLE"/>
        /// </summary>
        public static int SDK_SANDBOX_PROCESS_NOT_AVAILABLE { get { if (!_SDK_SANDBOX_PROCESS_NOT_AVAILABLEReady) { _SDK_SANDBOX_PROCESS_NOT_AVAILABLEContent = SGetField<int>(LocalBridgeClazz, "SDK_SANDBOX_PROCESS_NOT_AVAILABLE"); _SDK_SANDBOX_PROCESS_NOT_AVAILABLEReady = true; } return _SDK_SANDBOX_PROCESS_NOT_AVAILABLEContent; } }
        private static int _SDK_SANDBOX_PROCESS_NOT_AVAILABLEContent = default;
        private static bool _SDK_SANDBOX_PROCESS_NOT_AVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#SDK_SANDBOX_STATE_DISABLED"/>
        /// </summary>
        public static int SDK_SANDBOX_STATE_DISABLED { get { if (!_SDK_SANDBOX_STATE_DISABLEDReady) { _SDK_SANDBOX_STATE_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "SDK_SANDBOX_STATE_DISABLED"); _SDK_SANDBOX_STATE_DISABLEDReady = true; } return _SDK_SANDBOX_STATE_DISABLEDContent; } }
        private static int _SDK_SANDBOX_STATE_DISABLEDContent = default;
        private static bool _SDK_SANDBOX_STATE_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATION"/>
        /// </summary>
        public static int SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATION { get { if (!_SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATIONReady) { _SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATIONContent = SGetField<int>(LocalBridgeClazz, "SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATION"); _SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATIONReady = true; } return _SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATIONContent; } }
        private static int _SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATIONContent = default;
        private static bool _SDK_SANDBOX_STATE_ENABLED_PROCESS_ISOLATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#EXTRA_DISPLAY_ID"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_DISPLAY_ID { get { if (!_EXTRA_DISPLAY_IDReady) { _EXTRA_DISPLAY_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_DISPLAY_ID"); _EXTRA_DISPLAY_IDReady = true; } return _EXTRA_DISPLAY_IDContent; } }
        private static Java.Lang.String _EXTRA_DISPLAY_IDContent = default;
        private static bool _EXTRA_DISPLAY_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#EXTRA_HEIGHT_IN_PIXELS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_HEIGHT_IN_PIXELS { get { if (!_EXTRA_HEIGHT_IN_PIXELSReady) { _EXTRA_HEIGHT_IN_PIXELSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_HEIGHT_IN_PIXELS"); _EXTRA_HEIGHT_IN_PIXELSReady = true; } return _EXTRA_HEIGHT_IN_PIXELSContent; } }
        private static Java.Lang.String _EXTRA_HEIGHT_IN_PIXELSContent = default;
        private static bool _EXTRA_HEIGHT_IN_PIXELSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#EXTRA_HOST_TOKEN"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_HOST_TOKEN { get { if (!_EXTRA_HOST_TOKENReady) { _EXTRA_HOST_TOKENContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_HOST_TOKEN"); _EXTRA_HOST_TOKENReady = true; } return _EXTRA_HOST_TOKENContent; } }
        private static Java.Lang.String _EXTRA_HOST_TOKENContent = default;
        private static bool _EXTRA_HOST_TOKENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#EXTRA_SURFACE_PACKAGE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_SURFACE_PACKAGE { get { if (!_EXTRA_SURFACE_PACKAGEReady) { _EXTRA_SURFACE_PACKAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SURFACE_PACKAGE"); _EXTRA_SURFACE_PACKAGEReady = true; } return _EXTRA_SURFACE_PACKAGEContent; } }
        private static Java.Lang.String _EXTRA_SURFACE_PACKAGEContent = default;
        private static bool _EXTRA_SURFACE_PACKAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#EXTRA_WIDTH_IN_PIXELS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String EXTRA_WIDTH_IN_PIXELS { get { if (!_EXTRA_WIDTH_IN_PIXELSReady) { _EXTRA_WIDTH_IN_PIXELSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_WIDTH_IN_PIXELS"); _EXTRA_WIDTH_IN_PIXELSReady = true; } return _EXTRA_WIDTH_IN_PIXELSContent; } }
        private static Java.Lang.String _EXTRA_WIDTH_IN_PIXELSContent = default;
        private static bool _EXTRA_WIDTH_IN_PIXELSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#SDK_SANDBOX_SERVICE"/>
        /// </summary>
        public static Java.Lang.String SDK_SANDBOX_SERVICE { get { if (!_SDK_SANDBOX_SERVICEReady) { _SDK_SANDBOX_SERVICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SDK_SANDBOX_SERVICE"); _SDK_SANDBOX_SERVICEReady = true; } return _SDK_SANDBOX_SERVICEContent; } }
        private static Java.Lang.String _SDK_SANDBOX_SERVICEContent = default;
        private static bool _SDK_SANDBOX_SERVICEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#getSdkSandboxState()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetSdkSandboxState()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSdkSandboxState", "()I");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#getAppOwnedSdkSandboxInterfaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Sdksandbox.AppOwnedSdkSandboxInterface> GetAppOwnedSdkSandboxInterfaces()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Sdksandbox.AppOwnedSdkSandboxInterface>>("getAppOwnedSdkSandboxInterfaces", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#getSandboxedSdks()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.App.Sdksandbox.SandboxedSdk> GetSandboxedSdks()
        {
            return IExecuteWithSignature<Java.Util.List<Android.App.Sdksandbox.SandboxedSdk>>("getSandboxedSdks", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#getSyncedSharedPreferencesKeys()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetSyncedSharedPreferencesKeys()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSyncedSharedPreferencesKeys", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#addSdkSandboxProcessDeathCallback(java.util.concurrent.Executor,android.app.sdksandbox.SdkSandboxManager.SdkSandboxProcessDeathCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.App.Sdksandbox.SdkSandboxManager.SdkSandboxProcessDeathCallback"/></param>
        public void AddSdkSandboxProcessDeathCallback(Java.Util.Concurrent.Executor arg0, Android.App.Sdksandbox.SdkSandboxManager.SdkSandboxProcessDeathCallback arg1)
        {
            IExecuteWithSignature("addSdkSandboxProcessDeathCallback", "(Ljava/util/concurrent/Executor;Landroid/app/sdksandbox/SdkSandboxManager$SdkSandboxProcessDeathCallback;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#addSyncedSharedPreferencesKeys(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        public void AddSyncedSharedPreferencesKeys(Java.Util.Set<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("addSyncedSharedPreferencesKeys", "(Ljava/util/Set;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#loadSdk(java.lang.String,android.os.Bundle,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void LoadSdk(Java.Lang.String arg0, Android.Os.Bundle arg1, Java.Util.Concurrent.Executor arg2, Android.Os.OutcomeReceiver<Android.App.Sdksandbox.SandboxedSdk, Android.App.Sdksandbox.LoadSdkException> arg3)
        {
            IExecuteWithSignature("loadSdk", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#registerAppOwnedSdkSandboxInterface(android.app.sdksandbox.AppOwnedSdkSandboxInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Sdksandbox.AppOwnedSdkSandboxInterface"/></param>
        public void RegisterAppOwnedSdkSandboxInterface(Android.App.Sdksandbox.AppOwnedSdkSandboxInterface arg0)
        {
            IExecuteWithSignature("registerAppOwnedSdkSandboxInterface", "(Landroid/app/sdksandbox/AppOwnedSdkSandboxInterface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#removeSdkSandboxProcessDeathCallback(android.app.sdksandbox.SdkSandboxManager.SdkSandboxProcessDeathCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Sdksandbox.SdkSandboxManager.SdkSandboxProcessDeathCallback"/></param>
        public void RemoveSdkSandboxProcessDeathCallback(Android.App.Sdksandbox.SdkSandboxManager.SdkSandboxProcessDeathCallback arg0)
        {
            IExecuteWithSignature("removeSdkSandboxProcessDeathCallback", "(Landroid/app/sdksandbox/SdkSandboxManager$SdkSandboxProcessDeathCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#removeSyncedSharedPreferencesKeys(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        public void RemoveSyncedSharedPreferencesKeys(Java.Util.Set<Java.Lang.String> arg0)
        {
            IExecuteWithSignature("removeSyncedSharedPreferencesKeys", "(Ljava/util/Set;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#requestSurfacePackage(java.lang.String,android.os.Bundle,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Android.Os.OutcomeReceiver"/></param>
        [global::System.Obsolete()]
        public void RequestSurfacePackage(Java.Lang.String arg0, Android.Os.Bundle arg1, Java.Util.Concurrent.Executor arg2, Android.Os.OutcomeReceiver<Android.Os.Bundle, Android.App.Sdksandbox.RequestSurfacePackageException> arg3)
        {
            IExecuteWithSignature("requestSurfacePackage", "(Ljava/lang/String;Landroid/os/Bundle;Ljava/util/concurrent/Executor;Landroid/os/OutcomeReceiver;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#startSdkSandboxActivity(android.app.Activity,android.os.IBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.Os.IBinder"/></param>
        public void StartSdkSandboxActivity(Android.App.Activity arg0, Android.Os.IBinder arg1)
        {
            IExecuteWithSignature("startSdkSandboxActivity", "(Landroid/app/Activity;Landroid/os/IBinder;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#unloadSdk(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void UnloadSdk(Java.Lang.String arg0)
        {
            IExecuteWithSignature("unloadSdk", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.html#unregisterAppOwnedSdkSandboxInterface(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void UnregisterAppOwnedSdkSandboxInterface(Java.Lang.String arg0)
        {
            IExecuteWithSignature("unregisterAppOwnedSdkSandboxInterface", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region SdkSandboxProcessDeathCallback implementation
        public partial class SdkSandboxProcessDeathCallback
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
            /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SdkSandboxManager.SdkSandboxProcessDeathCallback.html#onSdkSandboxDied()"/>
            /// </summary>
            public void OnSdkSandboxDied()
            {
                IExecuteWithSignature("onSdkSandboxDied", "()V");
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