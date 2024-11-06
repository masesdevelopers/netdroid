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

namespace Android.Icu.Number
{
    #region Precision declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html"/>
    /// </summary>
    public partial class Precision : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Precision>
    {
        const string _bridgeClassName = "android.icu.number.Precision";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Precision class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Precision() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Precision class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Precision(params object[] args) : base(args) { }
    
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

    #region Precision implementation
    public partial class Precision
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#currency(android.icu.util.Currency.CurrencyUsage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.Currency.CurrencyUsage"/></param>
        /// <returns><see cref="Android.Icu.Number.CurrencyPrecision"/></returns>
        public static Android.Icu.Number.CurrencyPrecision Currency(Android.Icu.Util.Currency.CurrencyUsage arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.CurrencyPrecision>(LocalBridgeClazz, "currency", "(Landroid/icu/util/Currency$CurrencyUsage;)Landroid/icu/number/CurrencyPrecision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#fixedFraction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.FractionPrecision"/></returns>
        public static Android.Icu.Number.FractionPrecision FixedFraction(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.FractionPrecision>(LocalBridgeClazz, "fixedFraction", "(I)Landroid/icu/number/FractionPrecision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#integer()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.FractionPrecision"/></returns>
        public static Android.Icu.Number.FractionPrecision Integer()
        {
            return SExecuteWithSignature<Android.Icu.Number.FractionPrecision>(LocalBridgeClazz, "integer", "()Landroid/icu/number/FractionPrecision;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#maxFraction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.FractionPrecision"/></returns>
        public static Android.Icu.Number.FractionPrecision MaxFraction(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.FractionPrecision>(LocalBridgeClazz, "maxFraction", "(I)Landroid/icu/number/FractionPrecision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#minFraction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.FractionPrecision"/></returns>
        public static Android.Icu.Number.FractionPrecision MinFraction(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.FractionPrecision>(LocalBridgeClazz, "minFraction", "(I)Landroid/icu/number/FractionPrecision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#minMaxFraction(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.FractionPrecision"/></returns>
        public static Android.Icu.Number.FractionPrecision MinMaxFraction(int arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Icu.Number.FractionPrecision>(LocalBridgeClazz, "minMaxFraction", "(II)Landroid/icu/number/FractionPrecision;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#fixedSignificantDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public static Android.Icu.Number.Precision FixedSignificantDigits(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.Precision>(LocalBridgeClazz, "fixedSignificantDigits", "(I)Landroid/icu/number/Precision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#increment(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public static Android.Icu.Number.Precision Increment(Java.Math.BigDecimal arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.Precision>(LocalBridgeClazz, "increment", "(Ljava/math/BigDecimal;)Landroid/icu/number/Precision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#maxSignificantDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public static Android.Icu.Number.Precision MaxSignificantDigits(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.Precision>(LocalBridgeClazz, "maxSignificantDigits", "(I)Landroid/icu/number/Precision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#minMaxSignificantDigits(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public static Android.Icu.Number.Precision MinMaxSignificantDigits(int arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Icu.Number.Precision>(LocalBridgeClazz, "minMaxSignificantDigits", "(II)Landroid/icu/number/Precision;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#minSignificantDigits(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public static Android.Icu.Number.Precision MinSignificantDigits(int arg0)
        {
            return SExecuteWithSignature<Android.Icu.Number.Precision>(LocalBridgeClazz, "minSignificantDigits", "(I)Landroid/icu/number/Precision;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#unlimited()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public static Android.Icu.Number.Precision Unlimited()
        {
            return SExecuteWithSignature<Android.Icu.Number.Precision>(LocalBridgeClazz, "unlimited", "()Landroid/icu/number/Precision;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/number/Precision.html#trailingZeroDisplay(android.icu.number.NumberFormatter.TrailingZeroDisplay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Number.NumberFormatter.TrailingZeroDisplay"/></param>
        /// <returns><see cref="Android.Icu.Number.Precision"/></returns>
        public Android.Icu.Number.Precision TrailingZeroDisplay(Android.Icu.Number.NumberFormatter.TrailingZeroDisplay arg0)
        {
            return IExecuteWithSignature<Android.Icu.Number.Precision>("trailingZeroDisplay", "(Landroid/icu/number/NumberFormatter$TrailingZeroDisplay;)Landroid/icu/number/Precision;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}