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

namespace Android.Icu.Text
{
    #region UCharacterIterator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html"/>
    /// </summary>
    public partial class UCharacterIterator : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "android.icu.text.UCharacterIterator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("UCharacterIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public UCharacterIterator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("UCharacterIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public UCharacterIterator(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region UCharacterIterator implementation
    public partial class UCharacterIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#DONE"/>
        /// </summary>
        public static int DONE { get { if (!_DONEReady) { _DONEContent = SGetField<int>(LocalBridgeClazz, "DONE"); _DONEReady = true; } return _DONEContent; } }
        private static int _DONEContent = default;
        private static bool _DONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getInstance(android.icu.text.Replaceable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.Replaceable"/></param>
        /// <returns><see cref="Android.Icu.Text.UCharacterIterator"/></returns>
        public static Android.Icu.Text.UCharacterIterator GetInstance(Android.Icu.Text.Replaceable arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.UCharacterIterator>(LocalBridgeClazz, "getInstance", "(Landroid/icu/text/Replaceable;)Landroid/icu/text/UCharacterIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getInstance(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.UCharacterIterator"/></returns>
        public static Android.Icu.Text.UCharacterIterator GetInstance(char[] arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<Android.Icu.Text.UCharacterIterator>(LocalBridgeClazz, "getInstance", "([CII)Landroid/icu/text/UCharacterIterator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getInstance(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Android.Icu.Text.UCharacterIterator"/></returns>
        public static Android.Icu.Text.UCharacterIterator GetInstance(char[] arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.UCharacterIterator>(LocalBridgeClazz, "getInstance", "([C)Landroid/icu/text/UCharacterIterator;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.UCharacterIterator"/></returns>
        public static Android.Icu.Text.UCharacterIterator GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.UCharacterIterator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Landroid/icu/text/UCharacterIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getInstance(java.lang.StringBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuffer"/></param>
        /// <returns><see cref="Android.Icu.Text.UCharacterIterator"/></returns>
        public static Android.Icu.Text.UCharacterIterator GetInstance(Java.Lang.StringBuffer arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.UCharacterIterator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/StringBuffer;)Landroid/icu/text/UCharacterIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getInstance(java.text.CharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        /// <returns><see cref="Android.Icu.Text.UCharacterIterator"/></returns>
        public static Android.Icu.Text.UCharacterIterator GetInstance(Java.Text.CharacterIterator arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.UCharacterIterator>(LocalBridgeClazz, "getInstance", "(Ljava/text/CharacterIterator;)Landroid/icu/text/UCharacterIterator;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#current()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Current()
        {
            return IExecuteWithSignature<int>("current", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIndex()
        {
            return IExecuteWithSignature<int>("getIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLength()
        {
            return IExecuteWithSignature<int>("getLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getText(char[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetText(char[] arg0, int arg1)
        {
            return IExecuteWithSignature<int>("getText", "([CI)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Next()
        {
            return IExecuteWithSignature<int>("next", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Previous()
        {
            return IExecuteWithSignature<int>("previous", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIndex(int arg0)
        {
            IExecuteWithSignature("setIndex", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getText(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetText(char[] arg0)
        {
            return IExecuteWithSignature<int>("getText", "([C)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#currentCodePoint()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int CurrentCodePoint()
        {
            return IExecuteWithSignature<int>("currentCodePoint", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#moveCodePointIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MoveCodePointIndex(int arg0)
        {
            return IExecuteWithSignature<int>("moveCodePointIndex", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#moveIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int MoveIndex(int arg0)
        {
            return IExecuteWithSignature<int>("moveIndex", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#nextCodePoint()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int NextCodePoint()
        {
            return IExecuteWithSignature<int>("nextCodePoint", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#previousCodePoint()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int PreviousCodePoint()
        {
            return IExecuteWithSignature<int>("previousCodePoint", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#getCharacterIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.CharacterIterator"/></returns>
        public Java.Text.CharacterIterator GetCharacterIterator()
        {
            return IExecuteWithSignature<Java.Text.CharacterIterator>("getCharacterIterator", "()Ljava/text/CharacterIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#setToLimit()"/>
        /// </summary>
        public void SetToLimit()
        {
            IExecuteWithSignature("setToLimit", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/UCharacterIterator.html#setToStart()"/>
        /// </summary>
        public void SetToStart()
        {
            IExecuteWithSignature("setToStart", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}