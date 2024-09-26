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

namespace Android.View.Inputmethod
{
    #region TextSnapshot declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html"/>
    /// </summary>
    public partial class TextSnapshot : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TextSnapshot>
    {
        const string _bridgeClassName = "android.view.inputmethod.TextSnapshot";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextSnapshot() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextSnapshot(params object[] args) : base(args) { }

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

    #region TextSnapshot implementation
    public partial class TextSnapshot
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#%3Cinit%3E(android.view.inputmethod.SurroundingText,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.SurroundingText"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TextSnapshot(Android.View.Inputmethod.SurroundingText arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getSurroundingText()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Inputmethod.SurroundingText"/></returns>
        public Android.View.Inputmethod.SurroundingText GetSurroundingText()
        {
            return IExecuteWithSignature<Android.View.Inputmethod.SurroundingText>("getSurroundingText", "()Landroid/view/inputmethod/SurroundingText;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getCompositionEnd()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCompositionEnd()
        {
            return IExecuteWithSignature<int>("getCompositionEnd", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getCompositionStart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCompositionStart()
        {
            return IExecuteWithSignature<int>("getCompositionStart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getCursorCapsMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCursorCapsMode()
        {
            return IExecuteWithSignature<int>("getCursorCapsMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getSelectionEnd()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSelectionEnd()
        {
            return IExecuteWithSignature<int>("getSelectionEnd", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/TextSnapshot.html#getSelectionStart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSelectionStart()
        {
            return IExecuteWithSignature<int>("getSelectionStart", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}