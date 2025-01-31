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

namespace Android.Content
{
    #region QuickViewConstants declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/QuickViewConstants.html"/>
    /// </summary>
    public partial class QuickViewConstants : MASES.JCOBridge.C2JBridge.JVMBridgeBase<QuickViewConstants>
    {
        const string _bridgeClassName = "android.content.QuickViewConstants";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public QuickViewConstants() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public QuickViewConstants(params object[] args) : base(args) { }
    
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

    #region QuickViewConstants implementation
    public partial class QuickViewConstants
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/QuickViewConstants.html#FEATURE_DELETE"/>
        /// </summary>
        public static Java.Lang.String FEATURE_DELETE { get { if (!_FEATURE_DELETEReady) { _FEATURE_DELETEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_DELETE"); _FEATURE_DELETEReady = true; } return _FEATURE_DELETEContent; } }
        private static Java.Lang.String _FEATURE_DELETEContent = default;
        private static bool _FEATURE_DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/QuickViewConstants.html#FEATURE_DOWNLOAD"/>
        /// </summary>
        public static Java.Lang.String FEATURE_DOWNLOAD { get { if (!_FEATURE_DOWNLOADReady) { _FEATURE_DOWNLOADContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_DOWNLOAD"); _FEATURE_DOWNLOADReady = true; } return _FEATURE_DOWNLOADContent; } }
        private static Java.Lang.String _FEATURE_DOWNLOADContent = default;
        private static bool _FEATURE_DOWNLOADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/QuickViewConstants.html#FEATURE_EDIT"/>
        /// </summary>
        public static Java.Lang.String FEATURE_EDIT { get { if (!_FEATURE_EDITReady) { _FEATURE_EDITContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_EDIT"); _FEATURE_EDITReady = true; } return _FEATURE_EDITContent; } }
        private static Java.Lang.String _FEATURE_EDITContent = default;
        private static bool _FEATURE_EDITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/QuickViewConstants.html#FEATURE_PRINT"/>
        /// </summary>
        public static Java.Lang.String FEATURE_PRINT { get { if (!_FEATURE_PRINTReady) { _FEATURE_PRINTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_PRINT"); _FEATURE_PRINTReady = true; } return _FEATURE_PRINTContent; } }
        private static Java.Lang.String _FEATURE_PRINTContent = default;
        private static bool _FEATURE_PRINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/QuickViewConstants.html#FEATURE_SEND"/>
        /// </summary>
        public static Java.Lang.String FEATURE_SEND { get { if (!_FEATURE_SENDReady) { _FEATURE_SENDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_SEND"); _FEATURE_SENDReady = true; } return _FEATURE_SENDContent; } }
        private static Java.Lang.String _FEATURE_SENDContent = default;
        private static bool _FEATURE_SENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/QuickViewConstants.html#FEATURE_VIEW"/>
        /// </summary>
        public static Java.Lang.String FEATURE_VIEW { get { if (!_FEATURE_VIEWReady) { _FEATURE_VIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_VIEW"); _FEATURE_VIEWReady = true; } return _FEATURE_VIEWContent; } }
        private static Java.Lang.String _FEATURE_VIEWContent = default;
        private static bool _FEATURE_VIEWReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}