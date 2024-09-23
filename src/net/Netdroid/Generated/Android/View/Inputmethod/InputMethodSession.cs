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
    #region InputMethodSession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html"/>
    /// </summary>
    public partial class InputMethodSession : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InputMethodSession>
    {
        const string _bridgeClassName = "android.view.inputmethod.InputMethodSession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InputMethodSession class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethodSession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InputMethodSession class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputMethodSession(params object[] args) : base(args) { }

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
        #region EventCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.EventCallback.html"/>
        /// </summary>
        public partial class EventCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EventCallback>
        {
            const string _bridgeClassName = "android.view.inputmethod.InputMethodSession$EventCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("EventCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public EventCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("EventCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public EventCallback(params object[] args) : base(args) { }

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

    #region IInputMethodSession
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInputMethodSession
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodSession implementation
    public partial class InputMethodSession : Android.View.Inputmethod.IInputMethodSession
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
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#appPrivateCommand(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public void AppPrivateCommand(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            IExecute("appPrivateCommand", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#dispatchGenericMotionEvent(int,android.view.MotionEvent,android.view.inputmethod.InputMethodSession.EventCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.MotionEvent"/></param>
        /// <param name="arg2"><see cref="Android.View.Inputmethod.InputMethodSession.EventCallback"/></param>
        public void DispatchGenericMotionEvent(int arg0, Android.View.MotionEvent arg1, Android.View.Inputmethod.InputMethodSession.EventCallback arg2)
        {
            IExecute("dispatchGenericMotionEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#dispatchKeyEvent(int,android.view.KeyEvent,android.view.inputmethod.InputMethodSession.EventCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <param name="arg2"><see cref="Android.View.Inputmethod.InputMethodSession.EventCallback"/></param>
        public void DispatchKeyEvent(int arg0, Android.View.KeyEvent arg1, Android.View.Inputmethod.InputMethodSession.EventCallback arg2)
        {
            IExecute("dispatchKeyEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#dispatchTrackballEvent(int,android.view.MotionEvent,android.view.inputmethod.InputMethodSession.EventCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.MotionEvent"/></param>
        /// <param name="arg2"><see cref="Android.View.Inputmethod.InputMethodSession.EventCallback"/></param>
        public void DispatchTrackballEvent(int arg0, Android.View.MotionEvent arg1, Android.View.Inputmethod.InputMethodSession.EventCallback arg2)
        {
            IExecute("dispatchTrackballEvent", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#displayCompletions(android.view.inputmethod.CompletionInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.CompletionInfo"/></param>
        public void DisplayCompletions(Android.View.Inputmethod.CompletionInfo[] arg0)
        {
            IExecuteWithSignature("displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#finishInput()"/>
        /// </summary>
        public void FinishInput()
        {
            IExecuteWithSignature("finishInput", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#toggleSoftInput(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void ToggleSoftInput(int arg0, int arg1)
        {
            IExecute("toggleSoftInput", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#updateCursor(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void UpdateCursor(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("updateCursor", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#updateCursorAnchorInfo(android.view.inputmethod.CursorAnchorInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Inputmethod.CursorAnchorInfo"/></param>
        public void UpdateCursorAnchorInfo(Android.View.Inputmethod.CursorAnchorInfo arg0)
        {
            IExecuteWithSignature("updateCursorAnchorInfo", "(Landroid/view/inputmethod/CursorAnchorInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#updateExtractedText(int,android.view.inputmethod.ExtractedText)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Inputmethod.ExtractedText"/></param>
        public void UpdateExtractedText(int arg0, Android.View.Inputmethod.ExtractedText arg1)
        {
            IExecute("updateExtractedText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#updateSelection(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void UpdateSelection(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("updateSelection", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.html#viewClicked(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void ViewClicked(bool arg0)
        {
            IExecuteWithSignature("viewClicked", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region EventCallback implementation
        public partial class EventCallback
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
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/InputMethodSession.EventCallback.html#finishedEvent(int,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void FinishedEvent(int arg0, bool arg1)
            {
                IExecute("finishedEvent", arg0, arg1);
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