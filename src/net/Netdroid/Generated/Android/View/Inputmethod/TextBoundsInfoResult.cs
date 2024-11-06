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
    #region TextBoundsInfoResult declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html"/>
    /// </summary>
    public partial class TextBoundsInfoResult : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TextBoundsInfoResult>
    {
        const string _bridgeClassName = "android.view.inputmethod.TextBoundsInfoResult";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextBoundsInfoResult() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextBoundsInfoResult(params object[] args) : base(args) { }
    
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

    #region TextBoundsInfoResult implementation
    public partial class TextBoundsInfoResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#%3Cinit%3E(int,android.view.inputmethod.TextBoundsInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Inputmethod.TextBoundsInfo"/></param>
        public TextBoundsInfoResult(int arg0, Android.View.Inputmethod.TextBoundsInfo arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public TextBoundsInfoResult(int arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#CODE_CANCELLED"/>
        /// </summary>
        public static int CODE_CANCELLED { get { if (!_CODE_CANCELLEDReady) { _CODE_CANCELLEDContent = SGetField<int>(LocalBridgeClazz, "CODE_CANCELLED"); _CODE_CANCELLEDReady = true; } return _CODE_CANCELLEDContent; } }
        private static int _CODE_CANCELLEDContent = default;
        private static bool _CODE_CANCELLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#CODE_FAILED"/>
        /// </summary>
        public static int CODE_FAILED { get { if (!_CODE_FAILEDReady) { _CODE_FAILEDContent = SGetField<int>(LocalBridgeClazz, "CODE_FAILED"); _CODE_FAILEDReady = true; } return _CODE_FAILEDContent; } }
        private static int _CODE_FAILEDContent = default;
        private static bool _CODE_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#CODE_SUCCESS"/>
        /// </summary>
        public static int CODE_SUCCESS { get { if (!_CODE_SUCCESSReady) { _CODE_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "CODE_SUCCESS"); _CODE_SUCCESSReady = true; } return _CODE_SUCCESSContent; } }
        private static int _CODE_SUCCESSContent = default;
        private static bool _CODE_SUCCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#CODE_UNSUPPORTED"/>
        /// </summary>
        public static int CODE_UNSUPPORTED { get { if (!_CODE_UNSUPPORTEDReady) { _CODE_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "CODE_UNSUPPORTED"); _CODE_UNSUPPORTEDReady = true; } return _CODE_UNSUPPORTEDContent; } }
        private static int _CODE_UNSUPPORTEDContent = default;
        private static bool _CODE_UNSUPPORTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#getTextBoundsInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Inputmethod.TextBoundsInfo"/></returns>
        public Android.View.Inputmethod.TextBoundsInfo GetTextBoundsInfo()
        {
            return IExecuteWithSignature<Android.View.Inputmethod.TextBoundsInfo>("getTextBoundsInfo", "()Landroid/view/inputmethod/TextBoundsInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextBoundsInfoResult.html#getResultCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetResultCode()
        {
            return IExecuteWithSignature<int>("getResultCode", "()I");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}