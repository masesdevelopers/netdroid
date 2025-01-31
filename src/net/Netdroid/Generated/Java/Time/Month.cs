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

namespace Java.Time
{
    #region Month declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/Month.html"/>
    /// </summary>
    public partial class Month : Java.Lang.Enum<Java.Time.Month>
    {
        const string _bridgeClassName = "java.time.Month";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Month() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Month(params object[] args) : base(args) { }
    
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

    #region Month implementation
    public partial class Month : Java.Time.Temporal.ITemporalAccessor, Java.Time.Temporal.ITemporalAdjuster
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Month"/> to <see cref="Java.Time.Temporal.TemporalAccessor"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAccessor(Java.Time.Month t) => t.Cast<Java.Time.Temporal.TemporalAccessor>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Month"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.Month t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#APRIL"/>
        /// </summary>
        public static Java.Time.Month APRIL { get { if (!_APRILReady) { _APRILContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "APRIL"); _APRILReady = true; } return _APRILContent; } }
        private static Java.Time.Month _APRILContent = default;
        private static bool _APRILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#AUGUST"/>
        /// </summary>
        public static Java.Time.Month AUGUST { get { if (!_AUGUSTReady) { _AUGUSTContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "AUGUST"); _AUGUSTReady = true; } return _AUGUSTContent; } }
        private static Java.Time.Month _AUGUSTContent = default;
        private static bool _AUGUSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#DECEMBER"/>
        /// </summary>
        public static Java.Time.Month DECEMBER { get { if (!_DECEMBERReady) { _DECEMBERContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "DECEMBER"); _DECEMBERReady = true; } return _DECEMBERContent; } }
        private static Java.Time.Month _DECEMBERContent = default;
        private static bool _DECEMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#FEBRUARY"/>
        /// </summary>
        public static Java.Time.Month FEBRUARY { get { if (!_FEBRUARYReady) { _FEBRUARYContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "FEBRUARY"); _FEBRUARYReady = true; } return _FEBRUARYContent; } }
        private static Java.Time.Month _FEBRUARYContent = default;
        private static bool _FEBRUARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#JANUARY"/>
        /// </summary>
        public static Java.Time.Month JANUARY { get { if (!_JANUARYReady) { _JANUARYContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "JANUARY"); _JANUARYReady = true; } return _JANUARYContent; } }
        private static Java.Time.Month _JANUARYContent = default;
        private static bool _JANUARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#JULY"/>
        /// </summary>
        public static Java.Time.Month JULY { get { if (!_JULYReady) { _JULYContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "JULY"); _JULYReady = true; } return _JULYContent; } }
        private static Java.Time.Month _JULYContent = default;
        private static bool _JULYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#JUNE"/>
        /// </summary>
        public static Java.Time.Month JUNE { get { if (!_JUNEReady) { _JUNEContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "JUNE"); _JUNEReady = true; } return _JUNEContent; } }
        private static Java.Time.Month _JUNEContent = default;
        private static bool _JUNEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#MARCH"/>
        /// </summary>
        public static Java.Time.Month MARCH { get { if (!_MARCHReady) { _MARCHContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "MARCH"); _MARCHReady = true; } return _MARCHContent; } }
        private static Java.Time.Month _MARCHContent = default;
        private static bool _MARCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#MAY"/>
        /// </summary>
        public static Java.Time.Month MAY { get { if (!_MAYReady) { _MAYContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "MAY"); _MAYReady = true; } return _MAYContent; } }
        private static Java.Time.Month _MAYContent = default;
        private static bool _MAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#NOVEMBER"/>
        /// </summary>
        public static Java.Time.Month NOVEMBER { get { if (!_NOVEMBERReady) { _NOVEMBERContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "NOVEMBER"); _NOVEMBERReady = true; } return _NOVEMBERContent; } }
        private static Java.Time.Month _NOVEMBERContent = default;
        private static bool _NOVEMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#OCTOBER"/>
        /// </summary>
        public static Java.Time.Month OCTOBER { get { if (!_OCTOBERReady) { _OCTOBERContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "OCTOBER"); _OCTOBERReady = true; } return _OCTOBERContent; } }
        private static Java.Time.Month _OCTOBERContent = default;
        private static bool _OCTOBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#SEPTEMBER"/>
        /// </summary>
        public static Java.Time.Month SEPTEMBER { get { if (!_SEPTEMBERReady) { _SEPTEMBERContent = SGetField<Java.Time.Month>(LocalBridgeClazz, "SEPTEMBER"); _SEPTEMBERReady = true; } return _SEPTEMBERContent; } }
        private static Java.Time.Month _SEPTEMBERContent = default;
        private static bool _SEPTEMBERReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public static Java.Time.Month From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.Month>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/Month;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public static Java.Time.Month Of(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Month>(LocalBridgeClazz, "of", "(I)Ljava/time/Month;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public static Java.Time.Month ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Month>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/Month;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public static Java.Time.Month[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Month>(LocalBridgeClazz, "values", "()[Ljava/time/Month;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#firstDayOfYear(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int FirstDayOfYear(bool arg0)
        {
            return IExecuteWithSignature<int>("firstDayOfYear", "(Z)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetValue()
        {
            return IExecuteWithSignature<int>("getValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#length(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int Length(bool arg0)
        {
            return IExecuteWithSignature<int>("length", "(Z)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#maxLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int MaxLength()
        {
            return IExecuteWithSignature<int>("maxLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#minLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int MinLength()
        {
            return IExecuteWithSignature<int>("minLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "(Ljava/time/format/TextStyle;Ljava/util/Locale;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#firstMonthOfQuarter()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month FirstMonthOfQuarter()
        {
            return IExecuteWithSignature<Java.Time.Month>("firstMonthOfQuarter", "()Ljava/time/Month;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#minus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month Minus(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Month>("minus", "(J)Ljava/time/Month;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#plus(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month Plus(long arg0)
        {
            return IExecuteWithSignature<Java.Time.Month>("plus", "(J)Ljava/time/Month;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/Month.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/time/temporal/TemporalField;)J", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}