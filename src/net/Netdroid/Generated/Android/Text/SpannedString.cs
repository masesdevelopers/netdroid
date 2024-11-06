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
    #region SpannedString declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/SpannedString.html"/>
    /// </summary>
    public partial class SpannedString : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SpannedString>
    {
        const string _bridgeClassName = "android.text.SpannedString";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SpannedString() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SpannedString(params object[] args) : base(args) { }
    
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

    #region SpannedString implementation
    public partial class SpannedString : Java.Lang.ICharSequence, Android.Text.IGetChars, Android.Text.ISpanned
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#%3Cinit%3E(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public SpannedString(Java.Lang.CharSequence arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannedString"/> to <see cref="Java.Lang.CharSequence"/>
        /// </summary>
        public static implicit operator Java.Lang.CharSequence(Android.Text.SpannedString t) => t.Cast<Java.Lang.CharSequence>();
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannedString"/> to <see cref="Android.Text.GetChars"/>
        /// </summary>
        public static implicit operator Android.Text.GetChars(Android.Text.SpannedString t) => t.Cast<Android.Text.GetChars>();
        /// <summary>
        /// Converter from <see cref="Android.Text.SpannedString"/> to <see cref="Android.Text.Spanned"/>
        /// </summary>
        public static implicit operator Android.Text.Spanned(Android.Text.SpannedString t) => t.Cast<Android.Text.Spanned>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#valueOf(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.SpannedString"/></returns>
        public static Android.Text.SpannedString ValueOf(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Android.Text.SpannedString>(LocalBridgeClazz, "valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannedString;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#getSpans(int,int,java.lang.Class)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#charAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char CharAt(int arg0)
        {
            return IExecuteWithSignature<char>("charAt", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#getChars(int,int,char[],int)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#getSpanEnd(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanEnd(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanEnd", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#getSpanFlags(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanFlags(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanFlags", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#getSpanStart(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanStart(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanStart", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#nextSpanTransition(int,int,java.lang.Class)"/>
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
        /// <see href="https://developer.android.com/reference/android/text/SpannedString.html#subSequence(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence SubSequence(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("subSequence", "(II)Ljava/lang/CharSequence;", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}