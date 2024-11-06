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

namespace Android.Text
{
    #region SpannableStringBuilder declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html"/>
    /// </summary>
    public partial class SpannableStringBuilder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SpannableStringBuilder>
    {
        const string _bridgeClassName = "android.text.SpannableStringBuilder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SpannableStringBuilder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SpannableStringBuilder(params object[] args) : base(args) { }
    
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

    #region SpannableStringBuilder implementation
    public partial class SpannableStringBuilder : Java.Lang.ICharSequence, Android.Text.IGetChars, Android.Text.ISpannable, Android.Text.IEditable, Java.Lang.IAppendable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#%3Cinit%3E(java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public SpannableStringBuilder(Java.Lang.CharSequence arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#%3Cinit%3E(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public SpannableStringBuilder(Java.Lang.CharSequence arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannableStringBuilder"/> to <see cref="Java.Lang.CharSequence"/>
        /// </summary>
        public static implicit operator Java.Lang.CharSequence(Android.Text.SpannableStringBuilder t) => t.Cast<Java.Lang.CharSequence>();
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannableStringBuilder"/> to <see cref="Android.Text.GetChars"/>
        /// </summary>
        public static implicit operator Android.Text.GetChars(Android.Text.SpannableStringBuilder t) => t.Cast<Android.Text.GetChars>();
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannableStringBuilder"/> to <see cref="Android.Text.Spannable"/>
        /// </summary>
        public static implicit operator Android.Text.Spannable(Android.Text.SpannableStringBuilder t) => t.Cast<Android.Text.Spannable>();
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannableStringBuilder"/> to <see cref="Android.Text.Editable"/>
        /// </summary>
        public static implicit operator Android.Text.Editable(Android.Text.SpannableStringBuilder t) => t.Cast<Android.Text.Editable>();
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannableStringBuilder"/> to <see cref="Java.Lang.Appendable"/>
        /// </summary>
        public static implicit operator Java.Lang.Appendable(Android.Text.SpannableStringBuilder t) => t.Cast<Java.Lang.Appendable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#valueOf(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.SpannableStringBuilder"/></returns>
        public static Android.Text.SpannableStringBuilder ValueOf(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Android.Text.SpannableStringBuilder>(LocalBridgeClazz, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getSpans(int,int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetSpans<T>(int arg0, int arg1, Java.Lang.Class arg2)
        {
            return IExecuteWithSignatureArray<T>("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#delete(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Delete(int arg0, int arg1)
        {
            return IExecuteWithSignature<Android.Text.Editable>("delete", "(II)Landroid/text/Editable;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#insert(int,java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Insert(int arg0, Java.Lang.CharSequence arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<Android.Text.Editable>("insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#insert(int,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Insert(int arg0, Java.Lang.CharSequence arg1)
        {
            return IExecuteWithSignature<Android.Text.Editable>("insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#replace(int,int,java.lang.CharSequence,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Replace(int arg0, int arg1, Java.Lang.CharSequence arg2, int arg3, int arg4)
        {
            return IExecuteWithSignature<Android.Text.Editable>("replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#replace(int,int,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.Editable"/></returns>
        public Android.Text.Editable Replace(int arg0, int arg1, Java.Lang.CharSequence arg2)
        {
            return IExecuteWithSignature<Android.Text.Editable>("replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getFilters()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.InputFilter"/></returns>
        public Android.Text.InputFilter[] GetFilters()
        {
            return IExecuteWithSignatureArray<Android.Text.InputFilter>("getFilters", "()[Landroid/text/InputFilter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#append(java.lang.CharSequence,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Text.SpannableStringBuilder"/></returns>
        public Android.Text.SpannableStringBuilder Append(Java.Lang.CharSequence arg0, object arg1, int arg2)
        {
            return IExecuteWithSignature<Android.Text.SpannableStringBuilder>("append", "(Ljava/lang/CharSequence;Ljava/lang/Object;I)Landroid/text/SpannableStringBuilder;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#charAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char CharAt(int arg0)
        {
            return IExecuteWithSignature<char>("charAt", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getSpanEnd(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanEnd(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanEnd", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getSpanFlags(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanFlags(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanFlags", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getSpanStart(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanStart(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanStart", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getTextRunCursor(int,int,int,int,int,android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.Graphics.Paint"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetTextRunCursor(int arg0, int arg1, int arg2, int arg3, int arg4, Android.Graphics.Paint arg5)
        {
            return IExecuteWithSignature<int>("getTextRunCursor", "(IIIIILandroid/graphics/Paint;)I", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getTextWatcherDepth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextWatcherDepth()
        {
            return IExecuteWithSignature<int>("getTextWatcherDepth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#nextSpanTransition(int,int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextSpanTransition(int arg0, int arg1, Java.Lang.Class arg2)
        {
            return IExecuteWithSignature<int>("nextSpanTransition", "(IILjava/lang/Class;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#subSequence(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence SubSequence(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("subSequence", "(II)Ljava/lang/CharSequence;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#clearSpans()"/>
        /// </summary>
        public void ClearSpans()
        {
            IExecuteWithSignature("clearSpans", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#getChars(int,int,char[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="char"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void GetChars(int arg0, int arg1, char[] arg2, int arg3)
        {
            IExecuteWithSignature("getChars", "(II[CI)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#removeSpan(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveSpan(object arg0)
        {
            IExecuteWithSignature("removeSpan", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#setFilters(android.text.InputFilter[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.InputFilter"/></param>
        public void SetFilters(Android.Text.InputFilter[] arg0)
        {
            IExecuteWithSignature("setFilters", "([Landroid/text/InputFilter;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannableStringBuilder.html#setSpan(java.lang.Object,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetSpan(object arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("setSpan", "(Ljava/lang/Object;III)V", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}