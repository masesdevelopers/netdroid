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

namespace Android.Icu.Number
{
    #region NumberFormatter
    public partial class NumberFormatter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.html#withLocale(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Number.LocalizedNumberFormatter"/></returns>
        public static Android.Icu.Number.LocalizedNumberFormatter WithLocale(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.LocalizedNumberFormatter>(LocalBridgeClazz, "withLocale", "(Landroid/icu/util/ULocale;)Landroid/icu/number/LocalizedNumberFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.html#withLocale(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Number.LocalizedNumberFormatter"/></returns>
        public static Android.Icu.Number.LocalizedNumberFormatter WithLocale(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.LocalizedNumberFormatter>(LocalBridgeClazz, "withLocale", "(Ljava/util/Locale;)Landroid/icu/number/LocalizedNumberFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.html#with()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.UnlocalizedNumberFormatter"/></returns>
        public static Android.Icu.Number.UnlocalizedNumberFormatter With()
        {
            return SExecuteWithSignature<Android.Icu.Number.UnlocalizedNumberFormatter>(LocalBridgeClazz, "with", "()Landroid/icu/number/UnlocalizedNumberFormatter;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region DecimalSeparatorDisplay
        public partial class DecimalSeparatorDisplay
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.DecimalSeparatorDisplay.html#ALWAYS"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay ALWAYS { get { if (!_ALWAYSReady) { _ALWAYSContent = SGetField<Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay>(LocalBridgeClazz, "ALWAYS"); _ALWAYSReady = true; } return _ALWAYSContent; } }
            private static Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay _ALWAYSContent = default;
            private static bool _ALWAYSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.DecimalSeparatorDisplay.html#AUTO"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay AUTO { get { if (!_AUTOReady) { _AUTOContent = SGetField<Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay>(LocalBridgeClazz, "AUTO"); _AUTOReady = true; } return _AUTOContent; } }
            private static Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay _AUTOContent = default;
            private static bool _AUTOReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.DecimalSeparatorDisplay.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay"/></returns>
            public static Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatter$DecimalSeparatorDisplay;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.DecimalSeparatorDisplay.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay"/></returns>
            public static Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Number.NumberFormatter.DecimalSeparatorDisplay>(LocalBridgeClazz, "values", "()[Landroid/icu/number/NumberFormatter$DecimalSeparatorDisplay;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region GroupingStrategy
        public partial class GroupingStrategy
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.GroupingStrategy.html#AUTO"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.GroupingStrategy AUTO { get { if (!_AUTOReady) { _AUTOContent = SGetField<Android.Icu.Number.NumberFormatter.GroupingStrategy>(LocalBridgeClazz, "AUTO"); _AUTOReady = true; } return _AUTOContent; } }
            private static Android.Icu.Number.NumberFormatter.GroupingStrategy _AUTOContent = default;
            private static bool _AUTOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.GroupingStrategy.html#MIN2"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.GroupingStrategy MIN2 { get { if (!_MIN2Ready) { _MIN2Content = SGetField<Android.Icu.Number.NumberFormatter.GroupingStrategy>(LocalBridgeClazz, "MIN2"); _MIN2Ready = true; } return _MIN2Content; } }
            private static Android.Icu.Number.NumberFormatter.GroupingStrategy _MIN2Content = default;
            private static bool _MIN2Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.GroupingStrategy.html#OFF"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.GroupingStrategy OFF { get { if (!_OFFReady) { _OFFContent = SGetField<Android.Icu.Number.NumberFormatter.GroupingStrategy>(LocalBridgeClazz, "OFF"); _OFFReady = true; } return _OFFContent; } }
            private static Android.Icu.Number.NumberFormatter.GroupingStrategy _OFFContent = default;
            private static bool _OFFReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.GroupingStrategy.html#ON_ALIGNED"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.GroupingStrategy ON_ALIGNED { get { if (!_ON_ALIGNEDReady) { _ON_ALIGNEDContent = SGetField<Android.Icu.Number.NumberFormatter.GroupingStrategy>(LocalBridgeClazz, "ON_ALIGNED"); _ON_ALIGNEDReady = true; } return _ON_ALIGNEDContent; } }
            private static Android.Icu.Number.NumberFormatter.GroupingStrategy _ON_ALIGNEDContent = default;
            private static bool _ON_ALIGNEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.GroupingStrategy.html#THOUSANDS"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.GroupingStrategy THOUSANDS { get { if (!_THOUSANDSReady) { _THOUSANDSContent = SGetField<Android.Icu.Number.NumberFormatter.GroupingStrategy>(LocalBridgeClazz, "THOUSANDS"); _THOUSANDSReady = true; } return _THOUSANDSContent; } }
            private static Android.Icu.Number.NumberFormatter.GroupingStrategy _THOUSANDSContent = default;
            private static bool _THOUSANDSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.GroupingStrategy.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.GroupingStrategy"/></returns>
            public static Android.Icu.Number.NumberFormatter.GroupingStrategy ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Number.NumberFormatter.GroupingStrategy>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatter$GroupingStrategy;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.GroupingStrategy.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.GroupingStrategy"/></returns>
            public static Android.Icu.Number.NumberFormatter.GroupingStrategy[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Number.NumberFormatter.GroupingStrategy>(LocalBridgeClazz, "values", "()[Landroid/icu/number/NumberFormatter$GroupingStrategy;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RoundingPriority
        public partial class RoundingPriority
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.RoundingPriority.html#RELAXED"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.RoundingPriority RELAXED { get { if (!_RELAXEDReady) { _RELAXEDContent = SGetField<Android.Icu.Number.NumberFormatter.RoundingPriority>(LocalBridgeClazz, "RELAXED"); _RELAXEDReady = true; } return _RELAXEDContent; } }
            private static Android.Icu.Number.NumberFormatter.RoundingPriority _RELAXEDContent = default;
            private static bool _RELAXEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.RoundingPriority.html#STRICT"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.RoundingPriority STRICT { get { if (!_STRICTReady) { _STRICTContent = SGetField<Android.Icu.Number.NumberFormatter.RoundingPriority>(LocalBridgeClazz, "STRICT"); _STRICTReady = true; } return _STRICTContent; } }
            private static Android.Icu.Number.NumberFormatter.RoundingPriority _STRICTContent = default;
            private static bool _STRICTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.RoundingPriority.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.RoundingPriority"/></returns>
            public static Android.Icu.Number.NumberFormatter.RoundingPriority ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Number.NumberFormatter.RoundingPriority>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatter$RoundingPriority;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.RoundingPriority.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.RoundingPriority"/></returns>
            public static Android.Icu.Number.NumberFormatter.RoundingPriority[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Number.NumberFormatter.RoundingPriority>(LocalBridgeClazz, "values", "()[Landroid/icu/number/NumberFormatter$RoundingPriority;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SignDisplay
        public partial class SignDisplay
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#ACCOUNTING"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay ACCOUNTING { get { if (!_ACCOUNTINGReady) { _ACCOUNTINGContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "ACCOUNTING"); _ACCOUNTINGReady = true; } return _ACCOUNTINGContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _ACCOUNTINGContent = default;
            private static bool _ACCOUNTINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#ACCOUNTING_ALWAYS"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay ACCOUNTING_ALWAYS { get { if (!_ACCOUNTING_ALWAYSReady) { _ACCOUNTING_ALWAYSContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "ACCOUNTING_ALWAYS"); _ACCOUNTING_ALWAYSReady = true; } return _ACCOUNTING_ALWAYSContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _ACCOUNTING_ALWAYSContent = default;
            private static bool _ACCOUNTING_ALWAYSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#ACCOUNTING_EXCEPT_ZERO"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay ACCOUNTING_EXCEPT_ZERO { get { if (!_ACCOUNTING_EXCEPT_ZEROReady) { _ACCOUNTING_EXCEPT_ZEROContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "ACCOUNTING_EXCEPT_ZERO"); _ACCOUNTING_EXCEPT_ZEROReady = true; } return _ACCOUNTING_EXCEPT_ZEROContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _ACCOUNTING_EXCEPT_ZEROContent = default;
            private static bool _ACCOUNTING_EXCEPT_ZEROReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#ACCOUNTING_NEGATIVE"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay ACCOUNTING_NEGATIVE { get { if (!_ACCOUNTING_NEGATIVEReady) { _ACCOUNTING_NEGATIVEContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "ACCOUNTING_NEGATIVE"); _ACCOUNTING_NEGATIVEReady = true; } return _ACCOUNTING_NEGATIVEContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _ACCOUNTING_NEGATIVEContent = default;
            private static bool _ACCOUNTING_NEGATIVEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#ALWAYS"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay ALWAYS { get { if (!_ALWAYSReady) { _ALWAYSContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "ALWAYS"); _ALWAYSReady = true; } return _ALWAYSContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _ALWAYSContent = default;
            private static bool _ALWAYSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#AUTO"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay AUTO { get { if (!_AUTOReady) { _AUTOContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "AUTO"); _AUTOReady = true; } return _AUTOContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _AUTOContent = default;
            private static bool _AUTOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#EXCEPT_ZERO"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay EXCEPT_ZERO { get { if (!_EXCEPT_ZEROReady) { _EXCEPT_ZEROContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "EXCEPT_ZERO"); _EXCEPT_ZEROReady = true; } return _EXCEPT_ZEROContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _EXCEPT_ZEROContent = default;
            private static bool _EXCEPT_ZEROReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#NEGATIVE"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay NEGATIVE { get { if (!_NEGATIVEReady) { _NEGATIVEContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "NEGATIVE"); _NEGATIVEReady = true; } return _NEGATIVEContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _NEGATIVEContent = default;
            private static bool _NEGATIVEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#NEVER"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.SignDisplay NEVER { get { if (!_NEVERReady) { _NEVERContent = SGetField<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "NEVER"); _NEVERReady = true; } return _NEVERContent; } }
            private static Android.Icu.Number.NumberFormatter.SignDisplay _NEVERContent = default;
            private static bool _NEVERReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.SignDisplay"/></returns>
            public static Android.Icu.Number.NumberFormatter.SignDisplay ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatter$SignDisplay;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.SignDisplay.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.SignDisplay"/></returns>
            public static Android.Icu.Number.NumberFormatter.SignDisplay[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Number.NumberFormatter.SignDisplay>(LocalBridgeClazz, "values", "()[Landroid/icu/number/NumberFormatter$SignDisplay;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TrailingZeroDisplay
        public partial class TrailingZeroDisplay
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.TrailingZeroDisplay.html#AUTO"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.TrailingZeroDisplay AUTO { get { if (!_AUTOReady) { _AUTOContent = SGetField<Android.Icu.Number.NumberFormatter.TrailingZeroDisplay>(LocalBridgeClazz, "AUTO"); _AUTOReady = true; } return _AUTOContent; } }
            private static Android.Icu.Number.NumberFormatter.TrailingZeroDisplay _AUTOContent = default;
            private static bool _AUTOReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.TrailingZeroDisplay.html#HIDE_IF_WHOLE"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.TrailingZeroDisplay HIDE_IF_WHOLE { get { if (!_HIDE_IF_WHOLEReady) { _HIDE_IF_WHOLEContent = SGetField<Android.Icu.Number.NumberFormatter.TrailingZeroDisplay>(LocalBridgeClazz, "HIDE_IF_WHOLE"); _HIDE_IF_WHOLEReady = true; } return _HIDE_IF_WHOLEContent; } }
            private static Android.Icu.Number.NumberFormatter.TrailingZeroDisplay _HIDE_IF_WHOLEContent = default;
            private static bool _HIDE_IF_WHOLEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.TrailingZeroDisplay.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.TrailingZeroDisplay"/></returns>
            public static Android.Icu.Number.NumberFormatter.TrailingZeroDisplay ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Number.NumberFormatter.TrailingZeroDisplay>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatter$TrailingZeroDisplay;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.TrailingZeroDisplay.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.TrailingZeroDisplay"/></returns>
            public static Android.Icu.Number.NumberFormatter.TrailingZeroDisplay[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Number.NumberFormatter.TrailingZeroDisplay>(LocalBridgeClazz, "values", "()[Landroid/icu/number/NumberFormatter$TrailingZeroDisplay;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region UnitWidth
        public partial class UnitWidth
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#FORMAL"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.UnitWidth FORMAL { get { if (!_FORMALReady) { _FORMALContent = SGetField<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "FORMAL"); _FORMALReady = true; } return _FORMALContent; } }
            private static Android.Icu.Number.NumberFormatter.UnitWidth _FORMALContent = default;
            private static bool _FORMALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#FULL_NAME"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.UnitWidth FULL_NAME { get { if (!_FULL_NAMEReady) { _FULL_NAMEContent = SGetField<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "FULL_NAME"); _FULL_NAMEReady = true; } return _FULL_NAMEContent; } }
            private static Android.Icu.Number.NumberFormatter.UnitWidth _FULL_NAMEContent = default;
            private static bool _FULL_NAMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#HIDDEN"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.UnitWidth HIDDEN { get { if (!_HIDDENReady) { _HIDDENContent = SGetField<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "HIDDEN"); _HIDDENReady = true; } return _HIDDENContent; } }
            private static Android.Icu.Number.NumberFormatter.UnitWidth _HIDDENContent = default;
            private static bool _HIDDENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#ISO_CODE"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.UnitWidth ISO_CODE { get { if (!_ISO_CODEReady) { _ISO_CODEContent = SGetField<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "ISO_CODE"); _ISO_CODEReady = true; } return _ISO_CODEContent; } }
            private static Android.Icu.Number.NumberFormatter.UnitWidth _ISO_CODEContent = default;
            private static bool _ISO_CODEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#NARROW"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.UnitWidth NARROW { get { if (!_NARROWReady) { _NARROWContent = SGetField<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "NARROW"); _NARROWReady = true; } return _NARROWContent; } }
            private static Android.Icu.Number.NumberFormatter.UnitWidth _NARROWContent = default;
            private static bool _NARROWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#SHORT"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.UnitWidth SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
            private static Android.Icu.Number.NumberFormatter.UnitWidth _SHORTContent = default;
            private static bool _SHORTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#VARIANT"/>
            /// </summary>
            public static Android.Icu.Number.NumberFormatter.UnitWidth VARIANT { get { if (!_VARIANTReady) { _VARIANTContent = SGetField<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "VARIANT"); _VARIANTReady = true; } return _VARIANTContent; } }
            private static Android.Icu.Number.NumberFormatter.UnitWidth _VARIANTContent = default;
            private static bool _VARIANTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.UnitWidth"/></returns>
            public static Android.Icu.Number.NumberFormatter.UnitWidth ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/number/NumberFormatter$UnitWidth;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/number/NumberFormatter.UnitWidth.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Number.NumberFormatter.UnitWidth"/></returns>
            public static Android.Icu.Number.NumberFormatter.UnitWidth[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Number.NumberFormatter.UnitWidth>(LocalBridgeClazz, "values", "()[Landroid/icu/number/NumberFormatter$UnitWidth;");
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