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

namespace Java.Time
{
    #region LocalDate
    public partial class LocalDate : Java.Time.Temporal.ITemporal, Java.Time.Temporal.ITemporalAdjuster, Java.Time.Chrono.IChronoLocalDate, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.LocalDate t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.LocalDate t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Time.Chrono.ChronoLocalDate"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.ChronoLocalDate(Java.Time.LocalDate t) => t.Cast<Java.Time.Chrono.ChronoLocalDate>();
        /// <summary>
        /// Converter from <see cref="Java.Time.LocalDate"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.LocalDate t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#EPOCH"/>
        /// </summary>
        public static Java.Time.LocalDate EPOCH { get { if (!_EPOCHReady) { _EPOCHContent = SGetField<Java.Time.LocalDate>(LocalBridgeClazz, "EPOCH"); _EPOCHReady = true; } return _EPOCHContent; } }
        private static Java.Time.LocalDate _EPOCHContent = default;
        private static bool _EPOCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#MAX"/>
        /// </summary>
        public static Java.Time.LocalDate MAX { get { if (!_MAXReady) { _MAXContent = SGetField<Java.Time.LocalDate>(LocalBridgeClazz, "MAX"); _MAXReady = true; } return _MAXContent; } }
        private static Java.Time.LocalDate _MAXContent = default;
        private static bool _MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#MIN"/>
        /// </summary>
        public static Java.Time.LocalDate MIN { get { if (!_MINReady) { _MINContent = SGetField<Java.Time.LocalDate>(LocalBridgeClazz, "MIN"); _MINReady = true; } return _MINContent; } }
        private static Java.Time.LocalDate _MINContent = default;
        private static bool _MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#now()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Now()
        {
            return SExecuteWithSignature<Java.Time.LocalDate>(LocalBridgeClazz, "now", "()Ljava/time/LocalDate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Now(Java.Time.Clock arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalDate>(LocalBridgeClazz, "now", "(Ljava/time/Clock;)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Now(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalDate>(LocalBridgeClazz, "now", "(Ljava/time/ZoneId;)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#of(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Of(int arg0, int arg1, int arg2)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#of(int,java.time.Month,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Time.Month"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Of(int arg0, Java.Time.Month arg1, int arg2)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#ofEpochDay(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate OfEpochDay(long arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalDate>(LocalBridgeClazz, "ofEpochDay", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#ofYearDay(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate OfYearDay(int arg0, int arg1)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "ofYearDay", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.LocalDate>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public static Java.Time.LocalDate Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.LocalDate>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/LocalDate;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#isAfter(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<bool>("isAfter", "(Ljava/time/chrono/ChronoLocalDate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#isBefore(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<bool>("isBefore", "(Ljava/time/chrono/ChronoLocalDate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#isEqual(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<bool>("isEqual", "(Ljava/time/chrono/ChronoLocalDate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#isLeapYear()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLeapYear()
        {
            return IExecuteWithSignature<bool>("isLeapYear", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#compareTo(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/chrono/ChronoLocalDate;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfMonth()
        {
            return IExecuteWithSignature<int>("getDayOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getDayOfYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDayOfYear()
        {
            return IExecuteWithSignature<int>("getDayOfYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getMonthValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMonthValue()
        {
            return IExecuteWithSignature<int>("getMonthValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetYear()
        {
            return IExecuteWithSignature<int>("getYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#lengthOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LengthOfMonth()
        {
            return IExecuteWithSignature<int>("lengthOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#lengthOfYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LengthOfYear()
        {
            return IExecuteWithSignature<int>("lengthOfYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getChronology()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.Chronology"/></returns>
        public Java.Time.Chrono.Chronology GetChronology()
        {
            return IExecuteWithSignature<Java.Time.Chrono.Chronology>("getChronology", "()Ljava/time/chrono/Chronology;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#until(java.time.chrono.ChronoLocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Chrono.ChronoLocalDate"/></param>
        /// <returns><see cref="Java.Time.Chrono.ChronoPeriod"/></returns>
        public Java.Time.Chrono.ChronoPeriod Until(Java.Time.Chrono.ChronoLocalDate arg0)
        {
            return IExecuteWithSignature<Java.Time.Chrono.ChronoPeriod>("until", "(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getEra()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.Era"/></returns>
        public Java.Time.Chrono.Era GetEra()
        {
            return IExecuteWithSignature<Java.Time.Chrono.Era>("getEra", "()Ljava/time/chrono/Era;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getDayOfWeek()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.DayOfWeek"/></returns>
        public Java.Time.DayOfWeek GetDayOfWeek()
        {
            return IExecuteWithSignature<Java.Time.DayOfWeek>("getDayOfWeek", "()Ljava/time/DayOfWeek;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#minusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("minusDays", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#minusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("minusMonths", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#minusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusWeeks(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("minusWeeks", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#minusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate MinusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("minusYears", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#plusDays(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusDays(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("plusDays", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#plusMonths(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusMonths(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("plusMonths", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#plusWeeks(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusWeeks(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("plusWeeks", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#plusYears(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate PlusYears(long arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("plusYears", "(J)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#withDayOfMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithDayOfMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("withDayOfMonth", "(I)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#withDayOfYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithDayOfYear(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("withDayOfYear", "(I)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#withMonth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithMonth(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("withMonth", "(I)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#withYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDate"/></returns>
        public Java.Time.LocalDate WithYear(int arg0)
        {
            return IExecuteWithSignature<Java.Time.LocalDate>("withYear", "(I)Ljava/time/LocalDate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#atStartOfDay()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtStartOfDay()
        {
            return IExecuteWithSignature<Java.Time.LocalDateTime>("atStartOfDay", "()Ljava/time/LocalDateTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#atTime(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtTime(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Time.LocalDateTime>("atTime", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#atTime(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtTime(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Time.LocalDateTime>("atTime", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#atTime(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime AtTime(int arg0, int arg1)
        {
            return IExecute<Java.Time.LocalDateTime>("atTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getMonth()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Month"/></returns>
        public Java.Time.Month GetMonth()
        {
            return IExecuteWithSignature<Java.Time.Month>("getMonth", "()Ljava/time/Month;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#atTime(java.time.OffsetTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.OffsetTime"/></param>
        /// <returns><see cref="Java.Time.OffsetDateTime"/></returns>
        public Java.Time.OffsetDateTime AtTime(Java.Time.OffsetTime arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetDateTime>("atTime", "(Ljava/time/OffsetTime;)Ljava/time/OffsetDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#atStartOfDay(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.ZonedDateTime"/></returns>
        public Java.Time.ZonedDateTime AtStartOfDay(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.ZonedDateTime>("atStartOfDay", "(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#datesUntil(java.time.LocalDate,java.time.Period)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <param name="arg1"><see cref="Java.Time.Period"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Time.LocalDate> DatesUntil(Java.Time.LocalDate arg0, Java.Time.Period arg1)
        {
            return IExecute<Java.Util.Stream.Stream<Java.Time.LocalDate>>("datesUntil", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#datesUntil(java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Time.LocalDate> DatesUntil(Java.Time.LocalDate arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Time.LocalDate>>("datesUntil", "(Ljava/time/LocalDate;)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/time/temporal/TemporalField;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#toEpochDay()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToEpochDay()
        {
            return IExecuteWithSignature<long>("toEpochDay", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#toEpochSecond(java.time.LocalTime,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToEpochSecond(Java.Time.LocalTime arg0, Java.Time.ZoneOffset arg1)
        {
            return IExecute<long>("toEpochSecond", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/LocalDate.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long Until(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<long>("until", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}