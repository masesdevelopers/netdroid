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

namespace Android.View.Inputmethod
{
    #region ConnectionlessHandwritingCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/ConnectionlessHandwritingCallback.html"/>
    /// </summary>
    public partial class ConnectionlessHandwritingCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConnectionlessHandwritingCallback>
    {
        const string _bridgeClassName = "android.view.inputmethod.ConnectionlessHandwritingCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConnectionlessHandwritingCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectionlessHandwritingCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConnectionlessHandwritingCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConnectionlessHandwritingCallback(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region IConnectionlessHandwritingCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConnectionlessHandwritingCallback
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region ConnectionlessHandwritingCallback implementation
    public partial class ConnectionlessHandwritingCallback : Android.View.Inputmethod.IConnectionlessHandwritingCallback
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ConnectionlessHandwritingCallback.html#CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZED"/>
        /// </summary>
        public static int CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZED { get { if (!_CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZEDReady) { _CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZEDContent = SGetField<int>(LocalBridgeClazz, "CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZED"); _CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZEDReady = true; } return _CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZEDContent; } }
        private static int _CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZEDContent = default;
        private static bool _CONNECTIONLESS_HANDWRITING_ERROR_NO_TEXT_RECOGNIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ConnectionlessHandwritingCallback.html#CONNECTIONLESS_HANDWRITING_ERROR_OTHER"/>
        /// </summary>
        public static int CONNECTIONLESS_HANDWRITING_ERROR_OTHER { get { if (!_CONNECTIONLESS_HANDWRITING_ERROR_OTHERReady) { _CONNECTIONLESS_HANDWRITING_ERROR_OTHERContent = SGetField<int>(LocalBridgeClazz, "CONNECTIONLESS_HANDWRITING_ERROR_OTHER"); _CONNECTIONLESS_HANDWRITING_ERROR_OTHERReady = true; } return _CONNECTIONLESS_HANDWRITING_ERROR_OTHERContent; } }
        private static int _CONNECTIONLESS_HANDWRITING_ERROR_OTHERContent = default;
        private static bool _CONNECTIONLESS_HANDWRITING_ERROR_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ConnectionlessHandwritingCallback.html#CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTED"/>
        /// </summary>
        public static int CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTED { get { if (!_CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTEDReady) { _CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTED"); _CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTEDReady = true; } return _CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTEDContent; } }
        private static int _CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTEDContent = default;
        private static bool _CONNECTIONLESS_HANDWRITING_ERROR_UNSUPPORTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ConnectionlessHandwritingCallback.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnError(int arg0)
        {
            IExecuteWithSignature("onError", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ConnectionlessHandwritingCallback.html#onResult(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void OnResult(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("onResult", "(Ljava/lang/CharSequence;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}