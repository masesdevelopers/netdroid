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
    #region BreakIterator
    public partial class BreakIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#DONE"/>
        /// </summary>
        public static int DONE { get { if (!_DONEReady) { _DONEContent = SGetField<int>(LocalBridgeClazz, "DONE"); _DONEReady = true; } return _DONEContent; } }
        private static int _DONEContent = default;
        private static bool _DONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#KIND_CHARACTER"/>
        /// </summary>
        public static int KIND_CHARACTER { get { if (!_KIND_CHARACTERReady) { _KIND_CHARACTERContent = SGetField<int>(LocalBridgeClazz, "KIND_CHARACTER"); _KIND_CHARACTERReady = true; } return _KIND_CHARACTERContent; } }
        private static int _KIND_CHARACTERContent = default;
        private static bool _KIND_CHARACTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#KIND_LINE"/>
        /// </summary>
        public static int KIND_LINE { get { if (!_KIND_LINEReady) { _KIND_LINEContent = SGetField<int>(LocalBridgeClazz, "KIND_LINE"); _KIND_LINEReady = true; } return _KIND_LINEContent; } }
        private static int _KIND_LINEContent = default;
        private static bool _KIND_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#KIND_SENTENCE"/>
        /// </summary>
        public static int KIND_SENTENCE { get { if (!_KIND_SENTENCEReady) { _KIND_SENTENCEContent = SGetField<int>(LocalBridgeClazz, "KIND_SENTENCE"); _KIND_SENTENCEReady = true; } return _KIND_SENTENCEContent; } }
        private static int _KIND_SENTENCEContent = default;
        private static bool _KIND_SENTENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#KIND_TITLE"/>
        /// </summary>
        [System.Obsolete()]
        public static int KIND_TITLE { get { if (!_KIND_TITLEReady) { _KIND_TITLEContent = SGetField<int>(LocalBridgeClazz, "KIND_TITLE"); _KIND_TITLEReady = true; } return _KIND_TITLEContent; } }
        private static int _KIND_TITLEContent = default;
        private static bool _KIND_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#KIND_WORD"/>
        /// </summary>
        public static int KIND_WORD { get { if (!_KIND_WORDReady) { _KIND_WORDContent = SGetField<int>(LocalBridgeClazz, "KIND_WORD"); _KIND_WORDReady = true; } return _KIND_WORDContent; } }
        private static int _KIND_WORDContent = default;
        private static bool _KIND_WORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_IDEO"/>
        /// </summary>
        public static int WORD_IDEO { get { if (!_WORD_IDEOReady) { _WORD_IDEOContent = SGetField<int>(LocalBridgeClazz, "WORD_IDEO"); _WORD_IDEOReady = true; } return _WORD_IDEOContent; } }
        private static int _WORD_IDEOContent = default;
        private static bool _WORD_IDEOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_IDEO_LIMIT"/>
        /// </summary>
        public static int WORD_IDEO_LIMIT { get { if (!_WORD_IDEO_LIMITReady) { _WORD_IDEO_LIMITContent = SGetField<int>(LocalBridgeClazz, "WORD_IDEO_LIMIT"); _WORD_IDEO_LIMITReady = true; } return _WORD_IDEO_LIMITContent; } }
        private static int _WORD_IDEO_LIMITContent = default;
        private static bool _WORD_IDEO_LIMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_KANA"/>
        /// </summary>
        public static int WORD_KANA { get { if (!_WORD_KANAReady) { _WORD_KANAContent = SGetField<int>(LocalBridgeClazz, "WORD_KANA"); _WORD_KANAReady = true; } return _WORD_KANAContent; } }
        private static int _WORD_KANAContent = default;
        private static bool _WORD_KANAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_KANA_LIMIT"/>
        /// </summary>
        public static int WORD_KANA_LIMIT { get { if (!_WORD_KANA_LIMITReady) { _WORD_KANA_LIMITContent = SGetField<int>(LocalBridgeClazz, "WORD_KANA_LIMIT"); _WORD_KANA_LIMITReady = true; } return _WORD_KANA_LIMITContent; } }
        private static int _WORD_KANA_LIMITContent = default;
        private static bool _WORD_KANA_LIMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_LETTER"/>
        /// </summary>
        public static int WORD_LETTER { get { if (!_WORD_LETTERReady) { _WORD_LETTERContent = SGetField<int>(LocalBridgeClazz, "WORD_LETTER"); _WORD_LETTERReady = true; } return _WORD_LETTERContent; } }
        private static int _WORD_LETTERContent = default;
        private static bool _WORD_LETTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_LETTER_LIMIT"/>
        /// </summary>
        public static int WORD_LETTER_LIMIT { get { if (!_WORD_LETTER_LIMITReady) { _WORD_LETTER_LIMITContent = SGetField<int>(LocalBridgeClazz, "WORD_LETTER_LIMIT"); _WORD_LETTER_LIMITReady = true; } return _WORD_LETTER_LIMITContent; } }
        private static int _WORD_LETTER_LIMITContent = default;
        private static bool _WORD_LETTER_LIMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_NONE"/>
        /// </summary>
        public static int WORD_NONE { get { if (!_WORD_NONEReady) { _WORD_NONEContent = SGetField<int>(LocalBridgeClazz, "WORD_NONE"); _WORD_NONEReady = true; } return _WORD_NONEContent; } }
        private static int _WORD_NONEContent = default;
        private static bool _WORD_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_NONE_LIMIT"/>
        /// </summary>
        public static int WORD_NONE_LIMIT { get { if (!_WORD_NONE_LIMITReady) { _WORD_NONE_LIMITContent = SGetField<int>(LocalBridgeClazz, "WORD_NONE_LIMIT"); _WORD_NONE_LIMITReady = true; } return _WORD_NONE_LIMITContent; } }
        private static int _WORD_NONE_LIMITContent = default;
        private static bool _WORD_NONE_LIMITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_NUMBER"/>
        /// </summary>
        public static int WORD_NUMBER { get { if (!_WORD_NUMBERReady) { _WORD_NUMBERContent = SGetField<int>(LocalBridgeClazz, "WORD_NUMBER"); _WORD_NUMBERReady = true; } return _WORD_NUMBERContent; } }
        private static int _WORD_NUMBERContent = default;
        private static bool _WORD_NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#WORD_NUMBER_LIMIT"/>
        /// </summary>
        public static int WORD_NUMBER_LIMIT { get { if (!_WORD_NUMBER_LIMITReady) { _WORD_NUMBER_LIMITContent = SGetField<int>(LocalBridgeClazz, "WORD_NUMBER_LIMIT"); _WORD_NUMBER_LIMITReady = true; } return _WORD_NUMBER_LIMITContent; } }
        private static int _WORD_NUMBER_LIMITContent = default;
        private static bool _WORD_NUMBER_LIMITReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getCharacterInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.BreakIterator CharacterInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getCharacterInstance", "()Landroid/icu/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getLineInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.BreakIterator LineInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getLineInstance", "()Landroid/icu/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getSentenceInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.BreakIterator SentenceInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getSentenceInstance", "()Landroid/icu/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getTitleInstance()"/> 
        /// </summary>
        [System.Obsolete()]
        public static Android.Icu.Text.BreakIterator TitleInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getTitleInstance", "()Landroid/icu/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getWordInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.BreakIterator WordInstance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getWordInstance", "()Landroid/icu/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getCharacterInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetCharacterInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getCharacterInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getCharacterInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetCharacterInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getCharacterInstance", "(Ljava/util/Locale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getLineInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetLineInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getLineInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getLineInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetLineInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getLineInstance", "(Ljava/util/Locale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getSentenceInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetSentenceInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getSentenceInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getSentenceInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetSentenceInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getSentenceInstance", "(Ljava/util/Locale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getTitleInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        [System.Obsolete()]
        public static Android.Icu.Text.BreakIterator GetTitleInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getTitleInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getTitleInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        [System.Obsolete()]
        public static Android.Icu.Text.BreakIterator GetTitleInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getTitleInstance", "(Ljava/util/Locale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getWordInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetWordInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getWordInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getWordInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.BreakIterator"/></returns>
        public static Android.Icu.Text.BreakIterator GetWordInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.BreakIterator>(LocalBridgeClazz, "getWordInstance", "(Ljava/util/Locale;)Landroid/icu/text/BreakIterator;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getRuleStatus()"/> 
        /// </summary>
        public int RuleStatus
        {
            get { return IExecuteWithSignature<int>("getRuleStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getText()"/> 
        /// </summary>
        public Java.Text.CharacterIterator Text
        {
            get { return IExecuteWithSignature<Java.Text.CharacterIterator>("getText", "()Ljava/text/CharacterIterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#current()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Current()
        {
            return IExecuteWithSignature<int>("current", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#first()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int First()
        {
            return IExecuteWithSignature<int>("first", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#following(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Following(int arg0)
        {
            return IExecuteWithSignature<int>("following", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#last()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Last()
        {
            return IExecuteWithSignature<int>("last", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Next()
        {
            return IExecuteWithSignature<int>("next", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#next(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Next(int arg0)
        {
            return IExecuteWithSignature<int>("next", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Previous()
        {
            return IExecuteWithSignature<int>("previous", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#setText(java.text.CharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        public void SetText(Java.Text.CharacterIterator arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/text/CharacterIterator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#isBoundary(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBoundary(int arg0)
        {
            return IExecuteWithSignature<bool>("isBoundary", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#getRuleStatusVec(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRuleStatusVec(int[] arg0)
        {
            return IExecuteWithSignature<int>("getRuleStatusVec", "([I)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#preceding(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Preceding(int arg0)
        {
            return IExecuteWithSignature<int>("preceding", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#setText(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetText(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BreakIterator.html#setText(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetText(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}