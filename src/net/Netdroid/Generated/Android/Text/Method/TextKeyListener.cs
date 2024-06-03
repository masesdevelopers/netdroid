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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Method
{
    #region TextKeyListener
    public partial class TextKeyListener
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.Method.TextKeyListener"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Android.Text.Method.TextKeyListener GetInstance()
        {
            return SExecuteWithSignature<Android.Text.Method.TextKeyListener>(LocalBridgeClazz, "getInstance", "()Landroid/text/method/TextKeyListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#getInstance(boolean,android.text.method.TextKeyListener.Capitalize)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="Android.Text.Method.TextKeyListener.Capitalize"/></param>
        /// <returns><see cref="Android.Text.Method.TextKeyListener"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Android.Text.Method.TextKeyListener GetInstance(bool arg0, Android.Text.Method.TextKeyListener.Capitalize arg1)
        {
            return SExecute<Android.Text.Method.TextKeyListener>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#isMetaTracker(java.lang.CharSequence,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static bool IsMetaTracker(Java.Lang.CharSequence arg0, object arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isMetaTracker", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#isSelectingMetaTracker(java.lang.CharSequence,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static bool IsSelectingMetaTracker(Java.Lang.CharSequence arg0, object arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "isSelectingMetaTracker", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#shouldCap(android.text.method.TextKeyListener.Capitalize,java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Method.TextKeyListener.Capitalize"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static bool ShouldCap(Android.Text.Method.TextKeyListener.Capitalize arg0, Java.Lang.CharSequence arg1, int arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "shouldCap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0, Android.View.KeyEvent arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(Java.Lang.CharSequence arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(long arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#getMetaState(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static int GetMetaState(long arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getMetaState", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#adjustMetaAfterKeypress(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long AdjustMetaAfterKeypress(long arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "adjustMetaAfterKeypress", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#handleKeyDown(long,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long HandleKeyDown(long arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<long>(LocalBridgeClazz, "handleKeyDown", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#handleKeyUp(long,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long HandleKeyUp(long arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return SExecute<long>(LocalBridgeClazz, "handleKeyUp", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#resetLockedMeta(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static long ResetLockedMeta(long arg0)
        {
            return SExecute<long>(LocalBridgeClazz, "resetLockedMeta", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#adjustMetaAfterKeypress(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static void AdjustMetaAfterKeypress(Android.Text.Spannable arg0)
        {
            SExecute(LocalBridgeClazz, "adjustMetaAfterKeypress", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static void ClearMetaKeyState(Android.Text.Editable arg0, int arg1)
        {
            SExecute(LocalBridgeClazz, "clearMetaKeyState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#resetMetaState(android.text.Spannable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static void ResetMetaState(Android.Text.Spannable arg0)
        {
            SExecute(LocalBridgeClazz, "resetMetaState", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#clear(android.text.Editable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Editable"/></param>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static void Clear(Android.Text.Editable arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "clear", "(Landroid/text/Editable;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="TextKeyListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("backspace", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(BackspaceEventHandler));
            AddEventHandler("forwardDelete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(ForwardDeleteEventHandler));
            AddEventHandler("clearMetaKeyState", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ClearMetaKeyStateEventHandler));
            AddEventHandler("clearMetaKeyState3", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(ClearMetaKeyState3EventHandler));
            AddEventHandler("onSpanAdded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Text.Spannable>>>(OnSpanAddedEventHandler));
            AddEventHandler("onSpanChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Text.Spannable>>>(OnSpanChangedEventHandler));
            AddEventHandler("onSpanRemoved", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Text.Spannable>>>(OnSpanRemovedEventHandler));
            AddEventHandler("release", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(ReleaseEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#backspace(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnBackspace"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, int, Android.View.KeyEvent, bool> OnBackspace { get; set; } = null;

        void BackspaceEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnBackspace != null) ? OnBackspace : Backspace;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Text.Editable>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<Android.View.KeyEvent>(2));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#backspace(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Backspace(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#forwardDelete(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnForwardDelete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.View.View, Android.Text.Editable, int, Android.View.KeyEvent, bool> OnForwardDelete { get; set; } = null;

        void ForwardDeleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnForwardDelete != null) ? OnForwardDelete : ForwardDelete;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Text.Editable>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<Android.View.KeyEvent>(2));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#forwardDelete(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool ForwardDelete(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(long,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnClearMetaKeyState"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<long, int, long> OnClearMetaKeyState { get; set; } = null;

        void ClearMetaKeyStateEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var methodToExecute = (OnClearMetaKeyState != null) ? OnClearMetaKeyState : ClearMetaKeyState;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long ClearMetaKeyState(long arg0, int arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnClearMetaKeyState3"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.View.View, Android.Text.Editable, int> OnClearMetaKeyState3 { get; set; } = null;

        void ClearMetaKeyState3EventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnClearMetaKeyState3 != null) ? OnClearMetaKeyState3 : ClearMetaKeyState;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Text.Editable>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public virtual void ClearMetaKeyState(Android.View.View arg0, Android.Text.Editable arg1, int arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanAdded(android.text.Spannable,java.lang.Object,int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSpanAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Text.Spannable, object, int, int> OnOnSpanAdded { get; set; } = null;

        void OnSpanAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Text.Spannable>> data)
        {
            var methodToExecute = (OnOnSpanAdded != null) ? OnOnSpanAdded : OnSpanAdded;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanAdded(android.text.Spannable,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public virtual void OnSpanAdded(Android.Text.Spannable arg0, object arg1, int arg2, int arg3)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanChanged(android.text.Spannable,java.lang.Object,int,int,int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSpanChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Text.Spannable, object, int, int, int, int> OnOnSpanChanged { get; set; } = null;

        void OnSpanChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Text.Spannable>> data)
        {
            var methodToExecute = (OnOnSpanChanged != null) ? OnOnSpanChanged : OnSpanChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanChanged(android.text.Spannable,java.lang.Object,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public virtual void OnSpanChanged(Android.Text.Spannable arg0, object arg1, int arg2, int arg3, int arg4, int arg5)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanRemoved(android.text.Spannable,java.lang.Object,int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSpanRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Text.Spannable, object, int, int> OnOnSpanRemoved { get; set; } = null;

        void OnSpanRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Text.Spannable>> data)
        {
            var methodToExecute = (OnOnSpanRemoved != null) ? OnOnSpanRemoved : OnSpanRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanRemoved(android.text.Spannable,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public virtual void OnSpanRemoved(Android.Text.Spannable arg0, object arg1, int arg2, int arg3)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#release()"/>
        /// </summary>
        /// <remarks>If <see cref="OnRelease"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnRelease { get; set; } = null;

        void ReleaseEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnRelease != null) ? OnRelease : Release;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#release()"/>
        /// </summary>
        public virtual void Release()
        {
            
        }

        #endregion

        #region Nested classes
        #region Capitalize
        public partial class Capitalize
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.Capitalize.html#CHARACTERS"/>
            /// </summary>
            public static Android.Text.Method.TextKeyListener.Capitalize CHARACTERS { get { if (!_CHARACTERSReady) { _CHARACTERSContent = SGetField<Android.Text.Method.TextKeyListener.Capitalize>(LocalBridgeClazz, "CHARACTERS"); _CHARACTERSReady = true; } return _CHARACTERSContent; } }
            private static Android.Text.Method.TextKeyListener.Capitalize _CHARACTERSContent = default;
            private static bool _CHARACTERSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.Capitalize.html#NONE"/>
            /// </summary>
            public static Android.Text.Method.TextKeyListener.Capitalize NONE { get { if (!_NONEReady) { _NONEContent = SGetField<Android.Text.Method.TextKeyListener.Capitalize>(LocalBridgeClazz, "NONE"); _NONEReady = true; } return _NONEContent; } }
            private static Android.Text.Method.TextKeyListener.Capitalize _NONEContent = default;
            private static bool _NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.Capitalize.html#SENTENCES"/>
            /// </summary>
            public static Android.Text.Method.TextKeyListener.Capitalize SENTENCES { get { if (!_SENTENCESReady) { _SENTENCESContent = SGetField<Android.Text.Method.TextKeyListener.Capitalize>(LocalBridgeClazz, "SENTENCES"); _SENTENCESReady = true; } return _SENTENCESContent; } }
            private static Android.Text.Method.TextKeyListener.Capitalize _SENTENCESContent = default;
            private static bool _SENTENCESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.Capitalize.html#WORDS"/>
            /// </summary>
            public static Android.Text.Method.TextKeyListener.Capitalize WORDS { get { if (!_WORDSReady) { _WORDSContent = SGetField<Android.Text.Method.TextKeyListener.Capitalize>(LocalBridgeClazz, "WORDS"); _WORDSReady = true; } return _WORDSContent; } }
            private static Android.Text.Method.TextKeyListener.Capitalize _WORDSContent = default;
            private static bool _WORDSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.Capitalize.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Text.Method.TextKeyListener.Capitalize"/></returns>
            public static Android.Text.Method.TextKeyListener.Capitalize ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Text.Method.TextKeyListener.Capitalize>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/text/method/TextKeyListener$Capitalize;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.Capitalize.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Text.Method.TextKeyListener.Capitalize"/></returns>
            public static Android.Text.Method.TextKeyListener.Capitalize[] Values()
            {
                return SExecuteWithSignatureArray<Android.Text.Method.TextKeyListener.Capitalize>(LocalBridgeClazz, "values", "()[Landroid/text/method/TextKeyListener$Capitalize;");
            }

            #endregion

            #region Instance methods

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

    #region TextKeyListenerDirect
    public partial class TextKeyListenerDirect
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
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#backspace(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Backspace(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("backspace", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/BaseKeyListener.html#forwardDelete(android.view.View,android.text.Editable,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool ForwardDelete(Android.View.View arg0, Android.Text.Editable arg1, int arg2, Android.View.KeyEvent arg3)
        {
            return IExecute<bool>("forwardDelete", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ClearMetaKeyState(long arg0, int arg1)
        {
            return IExecute<long>("clearMetaKeyState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/MetaKeyKeyListener.html#clearMetaKeyState(android.view.View,android.text.Editable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Text.Editable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public override void ClearMetaKeyState(Android.View.View arg0, Android.Text.Editable arg1, int arg2)
        {
            IExecute("clearMetaKeyState", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanAdded(android.text.Spannable,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public override void OnSpanAdded(Android.Text.Spannable arg0, object arg1, int arg2, int arg3)
        {
            IExecute("onSpanAdded", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanChanged(android.text.Spannable,java.lang.Object,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public override void OnSpanChanged(Android.Text.Spannable arg0, object arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("onSpanChanged", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#onSpanRemoved(android.text.Spannable,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.Spannable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public override void OnSpanRemoved(Android.Text.Spannable arg0, object arg1, int arg2, int arg3)
        {
            IExecute("onSpanRemoved", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/TextKeyListener.html#release()"/>
        /// </summary>
        public override void Release()
        {
            IExecuteWithSignature("release", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}