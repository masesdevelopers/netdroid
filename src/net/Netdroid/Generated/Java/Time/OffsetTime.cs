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

namespace Java.Time
{
    #region OffsetTime
    public partial class OffsetTime : Java.Time.Temporal.ITemporal, Java.Time.Temporal.ITemporalAdjuster, Java.Lang.IComparable<Java.Time.OffsetTime>, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.OffsetTime"/> to <see cref="Java.Time.Temporal.Temporal"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.Temporal(Java.Time.OffsetTime t) => t.Cast<Java.Time.Temporal.Temporal>();
        /// <summary>
        /// Converter from <see cref="Java.Time.OffsetTime"/> to <see cref="Java.Time.Temporal.TemporalAdjuster"/>
        /// </summary>
        public static implicit operator Java.Time.Temporal.TemporalAdjuster(Java.Time.OffsetTime t) => t.Cast<Java.Time.Temporal.TemporalAdjuster>();
        /// <summary>
        /// Converter from <see cref="Java.Time.OffsetTime"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.OffsetTime t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Time.OffsetTime"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.OffsetTime t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#MAX"/>
        /// </summary>
        public static Java.Time.OffsetTime MAX { get { if (!_MAXReady) { _MAXContent = SGetField<Java.Time.OffsetTime>(LocalBridgeClazz, "MAX"); _MAXReady = true; } return _MAXContent; } }
        private static Java.Time.OffsetTime _MAXContent = default;
        private static bool _MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#MIN"/>
        /// </summary>
        public static Java.Time.OffsetTime MIN { get { if (!_MINReady) { _MINContent = SGetField<Java.Time.OffsetTime>(LocalBridgeClazz, "MIN"); _MINReady = true; } return _MINContent; } }
        private static Java.Time.OffsetTime _MINContent = default;
        private static bool _MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.OffsetTime>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#now()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime Now()
        {
            return SExecuteWithSignature<Java.Time.OffsetTime>(LocalBridgeClazz, "now", "()Ljava/time/OffsetTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#now(java.time.Clock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Clock"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime Now(Java.Time.Clock arg0)
        {
            return SExecuteWithSignature<Java.Time.OffsetTime>(LocalBridgeClazz, "now", "(Ljava/time/Clock;)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#now(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime Now(Java.Time.ZoneId arg0)
        {
            return SExecuteWithSignature<Java.Time.OffsetTime>(LocalBridgeClazz, "now", "(Ljava/time/ZoneId;)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#of(int,int,int,int,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime Of(int arg0, int arg1, int arg2, int arg3, Java.Time.ZoneOffset arg4)
        {
            return SExecute<Java.Time.OffsetTime>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#of(java.time.LocalTime,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime Of(Java.Time.LocalTime arg0, Java.Time.ZoneOffset arg1)
        {
            return SExecute<Java.Time.OffsetTime>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#ofInstant(java.time.Instant,java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime OfInstant(Java.Time.Instant arg0, Java.Time.ZoneId arg1)
        {
            return SExecute<Java.Time.OffsetTime>(LocalBridgeClazz, "ofInstant", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#parse(java.lang.CharSequence,java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime Parse(Java.Lang.CharSequence arg0, Java.Time.Format.DateTimeFormatter arg1)
        {
            return SExecute<Java.Time.OffsetTime>(LocalBridgeClazz, "parse", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#parse(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public static Java.Time.OffsetTime Parse(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignature<Java.Time.OffsetTime>(LocalBridgeClazz, "parse", "(Ljava/lang/CharSequence;)Ljava/time/OffsetTime;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#getHour()"/> 
        /// </summary>
        public int Hour
        {
            get { return IExecuteWithSignature<int>("getHour", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#getMinute()"/> 
        /// </summary>
        public int Minute
        {
            get { return IExecuteWithSignature<int>("getMinute", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#getNano()"/> 
        /// </summary>
        public int Nano
        {
            get { return IExecuteWithSignature<int>("getNano", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#getOffset()"/> 
        /// </summary>
        public Java.Time.ZoneOffset Offset
        {
            get { return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffset", "()Ljava/time/ZoneOffset;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#getSecond()"/> 
        /// </summary>
        public int Second
        {
            get { return IExecuteWithSignature<int>("getSecond", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#query(java.time.temporal.TemporalQuery)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalQuery"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Query<R>(Java.Time.Temporal.TemporalQuery<R> arg0)
        {
            return IExecuteWithSignature<R>("query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#isAfter(java.time.OffsetTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.OffsetTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfter(Java.Time.OffsetTime arg0)
        {
            return IExecuteWithSignature<bool>("isAfter", "(Ljava/time/OffsetTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#isBefore(java.time.OffsetTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.OffsetTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBefore(Java.Time.OffsetTime arg0)
        {
            return IExecuteWithSignature<bool>("isBefore", "(Ljava/time/OffsetTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#isEqual(java.time.OffsetTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.OffsetTime"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqual(Java.Time.OffsetTime arg0)
        {
            return IExecuteWithSignature<bool>("isEqual", "(Ljava/time/OffsetTime;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#isSupported(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalField;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#isSupported(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<bool>("isSupported", "(Ljava/time/temporal/TemporalUnit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#compareTo(java.time.OffsetTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.OffsetTime"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.OffsetTime arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/OffsetTime;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#get(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<int>("get", "(Ljava/time/temporal/TemporalField;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#format(java.time.format.DateTimeFormatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.DateTimeFormatter"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Format(Java.Time.Format.DateTimeFormatter arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#toLocalTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.LocalTime"/></returns>
        public Java.Time.LocalTime ToLocalTime()
        {
            return IExecuteWithSignature<Java.Time.LocalTime>("toLocalTime", "()Ljava/time/LocalTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#atDate(java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="Java.Time.OffsetDateTime"/></returns>
        public Java.Time.OffsetDateTime AtDate(Java.Time.LocalDate arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetDateTime>("atDate", "(Ljava/time/LocalDate;)Ljava/time/OffsetDateTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#minusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime MinusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("minusHours", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#minusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime MinusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("minusMinutes", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#minusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime MinusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("minusNanos", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#minusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime MinusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("minusSeconds", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#plusHours(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime PlusHours(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("plusHours", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#plusMinutes(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime PlusMinutes(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("plusMinutes", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#plusNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime PlusNanos(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("plusNanos", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#plusSeconds(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime PlusSeconds(long arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("plusSeconds", "(J)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#truncatedTo(java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime TruncatedTo(Java.Time.Temporal.TemporalUnit arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#withHour(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime WithHour(int arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("withHour", "(I)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#withMinute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime WithMinute(int arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("withMinute", "(I)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#withNano(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime WithNano(int arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("withNano", "(I)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#withOffsetSameInstant(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime WithOffsetSameInstant(Java.Time.ZoneOffset arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("withOffsetSameInstant", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#withOffsetSameLocal(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime WithOffsetSameLocal(Java.Time.ZoneOffset arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("withOffsetSameLocal", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#withSecond(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.OffsetTime"/></returns>
        public Java.Time.OffsetTime WithSecond(int arg0)
        {
            return IExecuteWithSignature<Java.Time.OffsetTime>("withSecond", "(I)Ljava/time/OffsetTime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#adjustInto(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal AdjustInto(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#minus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("minus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#minus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Minus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("minus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#plus(java.time.temporal.TemporalAmount)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAmount"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(Java.Time.Temporal.TemporalAmount arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("plus", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#plus(long,java.time.temporal.TemporalUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.TemporalUnit"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal Plus(long arg0, Java.Time.Temporal.TemporalUnit arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("plus", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#with(java.time.temporal.TemporalAdjuster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAdjuster"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalAdjuster arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.Temporal>("with", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#with(java.time.temporal.TemporalField,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Time.Temporal.Temporal"/></returns>
        public Java.Time.Temporal.Temporal With(Java.Time.Temporal.TemporalField arg0, long arg1)
        {
            return IExecute<Java.Time.Temporal.Temporal>("with", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#range(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="Java.Time.Temporal.ValueRange"/></returns>
        public Java.Time.Temporal.ValueRange Range(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<Java.Time.Temporal.ValueRange>("range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#getLong(java.time.temporal.TemporalField)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalField"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Time.Temporal.TemporalField arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/time/temporal/TemporalField;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#toEpochSecond(java.time.LocalDate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDate"/></param>
        /// <returns><see cref="long"/></returns>
        public long ToEpochSecond(Java.Time.LocalDate arg0)
        {
            return IExecuteWithSignature<long>("toEpochSecond", "(Ljava/time/LocalDate;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/OffsetTime.html#until(java.time.temporal.Temporal,java.time.temporal.TemporalUnit)"/>
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