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

namespace Android.Icu.Text
{
    #region Normalizer2
    public partial class Normalizer2
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getNFCInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.Normalizer2 NFCInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.Normalizer2>(LocalBridgeClazz, "getNFCInstance", "()Landroid/icu/text/Normalizer2;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getNFDInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.Normalizer2 NFDInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.Normalizer2>(LocalBridgeClazz, "getNFDInstance", "()Landroid/icu/text/Normalizer2;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getNFKCCasefoldInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.Normalizer2 NFKCCasefoldInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.Normalizer2>(LocalBridgeClazz, "getNFKCCasefoldInstance", "()Landroid/icu/text/Normalizer2;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getNFKCInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.Normalizer2 NFKCInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.Normalizer2>(LocalBridgeClazz, "getNFKCInstance", "()Landroid/icu/text/Normalizer2;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getNFKDInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.Normalizer2 NFKDInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.Normalizer2>(LocalBridgeClazz, "getNFKDInstance", "()Landroid/icu/text/Normalizer2;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getInstance(java.io.InputStream,java.lang.String,android.icu.text.Normalizer2.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.Normalizer2.Mode"/></param>
        /// <returns><see cref="Android.Icu.Text.Normalizer2"/></returns>
        [System.Obsolete()]
        public static Android.Icu.Text.Normalizer2 GetInstance(Java.Io.InputStream arg0, Java.Lang.String arg1, Android.Icu.Text.Normalizer2.Mode arg2)
        {
            return SExecute<Android.Icu.Text.Normalizer2>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#quickCheck(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Icu.Text.Normalizer.QuickCheckResult"/></returns>
        public Android.Icu.Text.Normalizer.QuickCheckResult QuickCheck(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.Normalizer.QuickCheckResult>("quickCheck", "(Ljava/lang/CharSequence;)Landroid/icu/text/Normalizer$QuickCheckResult;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#hasBoundaryAfter(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasBoundaryAfter(int arg0)
        {
            return IExecuteWithSignature<bool>("hasBoundaryAfter", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#hasBoundaryBefore(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasBoundaryBefore(int arg0)
        {
            return IExecuteWithSignature<bool>("hasBoundaryBefore", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#isInert(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsInert(int arg0)
        {
            return IExecuteWithSignature<bool>("isInert", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#isNormalized(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNormalized(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<bool>("isNormalized", "(Ljava/lang/CharSequence;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#spanQuickCheckYes(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="int"/></returns>
        public int SpanQuickCheckYes(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<int>("spanQuickCheckYes", "(Ljava/lang/CharSequence;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#normalize(java.lang.CharSequence,java.lang.Appendable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Appendable"/></param>
        /// <returns><see cref="Java.Lang.Appendable"/></returns>
        public Java.Lang.Appendable Normalize(Java.Lang.CharSequence arg0, Java.Lang.Appendable arg1)
        {
            return IExecute<Java.Lang.Appendable>("normalize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getDecomposition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDecomposition(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDecomposition", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#append(java.lang.StringBuilder,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder Append(Java.Lang.StringBuilder arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Java.Lang.StringBuilder>("append", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#normalize(java.lang.CharSequence,java.lang.StringBuilder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuilder"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder Normalize(Java.Lang.CharSequence arg0, Java.Lang.StringBuilder arg1)
        {
            return IExecute<Java.Lang.StringBuilder>("normalize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#normalizeSecondAndAppend(java.lang.StringBuilder,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder NormalizeSecondAndAppend(Java.Lang.StringBuilder arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Java.Lang.StringBuilder>("normalizeSecondAndAppend", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#composePair(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ComposePair(int arg0, int arg1)
        {
            return IExecute<int>("composePair", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getCombiningClass(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetCombiningClass(int arg0)
        {
            return IExecuteWithSignature<int>("getCombiningClass", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#getRawDecomposition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRawDecomposition(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getRawDecomposition", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.html#normalize(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Normalize(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("normalize", "(Ljava/lang/CharSequence;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes
        #region Mode
        public partial class Mode
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.Mode.html#COMPOSE"/>
            /// </summary>
            public static Android.Icu.Text.Normalizer2.Mode COMPOSE { get { if (!_COMPOSEReady) { _COMPOSEContent = SGetField<Android.Icu.Text.Normalizer2.Mode>(LocalBridgeClazz, "COMPOSE"); _COMPOSEReady = true; } return _COMPOSEContent; } }
            private static Android.Icu.Text.Normalizer2.Mode _COMPOSEContent = default;
            private static bool _COMPOSEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.Mode.html#COMPOSE_CONTIGUOUS"/>
            /// </summary>
            public static Android.Icu.Text.Normalizer2.Mode COMPOSE_CONTIGUOUS { get { if (!_COMPOSE_CONTIGUOUSReady) { _COMPOSE_CONTIGUOUSContent = SGetField<Android.Icu.Text.Normalizer2.Mode>(LocalBridgeClazz, "COMPOSE_CONTIGUOUS"); _COMPOSE_CONTIGUOUSReady = true; } return _COMPOSE_CONTIGUOUSContent; } }
            private static Android.Icu.Text.Normalizer2.Mode _COMPOSE_CONTIGUOUSContent = default;
            private static bool _COMPOSE_CONTIGUOUSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.Mode.html#DECOMPOSE"/>
            /// </summary>
            public static Android.Icu.Text.Normalizer2.Mode DECOMPOSE { get { if (!_DECOMPOSEReady) { _DECOMPOSEContent = SGetField<Android.Icu.Text.Normalizer2.Mode>(LocalBridgeClazz, "DECOMPOSE"); _DECOMPOSEReady = true; } return _DECOMPOSEContent; } }
            private static Android.Icu.Text.Normalizer2.Mode _DECOMPOSEContent = default;
            private static bool _DECOMPOSEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.Mode.html#FCD"/>
            /// </summary>
            public static Android.Icu.Text.Normalizer2.Mode FCD { get { if (!_FCDReady) { _FCDContent = SGetField<Android.Icu.Text.Normalizer2.Mode>(LocalBridgeClazz, "FCD"); _FCDReady = true; } return _FCDContent; } }
            private static Android.Icu.Text.Normalizer2.Mode _FCDContent = default;
            private static bool _FCDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.Mode.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.Normalizer2.Mode"/></returns>
            public static Android.Icu.Text.Normalizer2.Mode ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.Normalizer2.Mode>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/Normalizer2$Mode;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/Normalizer2.Mode.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.Normalizer2.Mode"/></returns>
            public static Android.Icu.Text.Normalizer2.Mode[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.Normalizer2.Mode>(LocalBridgeClazz, "values", "()[Landroid/icu/text/Normalizer2$Mode;");
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
}