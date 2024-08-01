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

namespace Android.Icu.Number
{
    #region FormattedNumberRange
    public partial class FormattedNumberRange
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
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#appendTo(java.lang.Appendable)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="A"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.IAppendable"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A AppendTo<A>(A arg0) where A : Java.Lang.IAppendable, new()
        {
            return IExecuteWithSignature<A>("appendTo", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#getIdentityResult()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.NumberRangeFormatter.RangeIdentityResult"/></returns>
        public Android.Icu.Number.NumberRangeFormatter.RangeIdentityResult GetIdentityResult()
        {
            return IExecuteWithSignature<Android.Icu.Number.NumberRangeFormatter.RangeIdentityResult>("getIdentityResult", "()Landroid/icu/number/NumberRangeFormatter$RangeIdentityResult;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#nextPosition(android.icu.text.ConstrainedFieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.ConstrainedFieldPosition"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool NextPosition(Android.Icu.Text.ConstrainedFieldPosition arg0)
        {
            return IExecuteWithSignature<bool>("nextPosition", "(Landroid/icu/text/ConstrainedFieldPosition;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#charAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char CharAt(int arg0)
        {
            return IExecuteWithSignature<char>("charAt", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#subSequence(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence SubSequence(int arg0, int arg1)
        {
            return IExecute<Java.Lang.CharSequence>("subSequence", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#getFirstBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal GetFirstBigDecimal()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("getFirstBigDecimal", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#getSecondBigDecimal()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public Java.Math.BigDecimal GetSecondBigDecimal()
        {
            return IExecuteWithSignature<Java.Math.BigDecimal>("getSecondBigDecimal", "()Ljava/math/BigDecimal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/FormattedNumberRange.html#toCharacterIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        public Java.Text.AttributedCharacterIterator ToCharacterIterator()
        {
            return IExecuteWithSignature<Java.Text.AttributedCharacterIterator>("toCharacterIterator", "()Ljava/text/AttributedCharacterIterator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}