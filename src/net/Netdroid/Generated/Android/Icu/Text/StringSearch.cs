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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Text
{
    #region StringSearch
    public partial class StringSearch
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public StringSearch(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#%3Cinit%3E(java.lang.String,java.text.CharacterIterator,android.icu.text.RuleBasedCollator,android.icu.text.BreakIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.RuleBasedCollator"/></param>
        /// <param name="arg3"><see cref="Android.Icu.Text.BreakIterator"/></param>
        public StringSearch(Java.Lang.String arg0, Java.Text.CharacterIterator arg1, Android.Icu.Text.RuleBasedCollator arg2, Android.Icu.Text.BreakIterator arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#%3Cinit%3E(java.lang.String,java.text.CharacterIterator,android.icu.text.RuleBasedCollator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.RuleBasedCollator"/></param>
        public StringSearch(Java.Lang.String arg0, Java.Text.CharacterIterator arg1, Android.Icu.Text.RuleBasedCollator arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#%3Cinit%3E(java.lang.String,java.text.CharacterIterator,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Util.ULocale"/></param>
        public StringSearch(Java.Lang.String arg0, Java.Text.CharacterIterator arg1, Android.Icu.Util.ULocale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#%3Cinit%3E(java.lang.String,java.text.CharacterIterator,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg2"><see cref="Java.Util.Locale"/></param>
        public StringSearch(Java.Lang.String arg0, Java.Text.CharacterIterator arg1, Java.Util.Locale arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#getCollator()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.RuleBasedCollator"/></returns>
        public Android.Icu.Text.RuleBasedCollator GetCollator()
        {
            return IExecuteWithSignature<Android.Icu.Text.RuleBasedCollator>("getCollator", "()Landroid/icu/text/RuleBasedCollator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#isCanonical()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCanonical()
        {
            return IExecuteWithSignature<bool>("isCanonical", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#getPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#setCanonical(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCanonical(bool arg0)
        {
            IExecuteWithSignature("setCanonical", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#setCollator(android.icu.text.RuleBasedCollator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.RuleBasedCollator"/></param>
        public void SetCollator(Android.Icu.Text.RuleBasedCollator arg0)
        {
            IExecuteWithSignature("setCollator", "(Landroid/icu/text/RuleBasedCollator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/StringSearch.html#setPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPattern", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}