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

namespace Java.Time.Zone
{
    #region ZoneOffsetTransition
    public partial class ZoneOffsetTransition : Java.Lang.IComparable<Java.Time.Zone.ZoneOffsetTransition>, Java.Io.ISerializable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Zone.ZoneOffsetTransition"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Time.Zone.ZoneOffsetTransition t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Time.Zone.ZoneOffsetTransition"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Time.Zone.ZoneOffsetTransition t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#of(java.time.LocalDateTime,java.time.ZoneOffset,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <param name="arg2"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneOffsetTransition"/></returns>
        public static Java.Time.Zone.ZoneOffsetTransition Of(Java.Time.LocalDateTime arg0, Java.Time.ZoneOffset arg1, Java.Time.ZoneOffset arg2)
        {
            return SExecute<Java.Time.Zone.ZoneOffsetTransition>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#getDateTimeAfter()"/> 
        /// </summary>
        public Java.Time.LocalDateTime DateTimeAfter
        {
            get { return IExecuteWithSignature<Java.Time.LocalDateTime>("getDateTimeAfter", "()Ljava/time/LocalDateTime;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#getDateTimeBefore()"/> 
        /// </summary>
        public Java.Time.LocalDateTime DateTimeBefore
        {
            get { return IExecuteWithSignature<Java.Time.LocalDateTime>("getDateTimeBefore", "()Ljava/time/LocalDateTime;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#getDuration()"/> 
        /// </summary>
        public Java.Time.Duration Duration
        {
            get { return IExecuteWithSignature<Java.Time.Duration>("getDuration", "()Ljava/time/Duration;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#getInstant()"/> 
        /// </summary>
        public Java.Time.Instant Instant
        {
            get { return IExecuteWithSignature<Java.Time.Instant>("getInstant", "()Ljava/time/Instant;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#getOffsetAfter()"/> 
        /// </summary>
        public Java.Time.ZoneOffset OffsetAfter
        {
            get { return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffsetAfter", "()Ljava/time/ZoneOffset;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#getOffsetBefore()"/> 
        /// </summary>
        public Java.Time.ZoneOffset OffsetBefore
        {
            get { return IExecuteWithSignature<Java.Time.ZoneOffset>("getOffsetBefore", "()Ljava/time/ZoneOffset;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#isGap()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsGap()
        {
            return IExecuteWithSignature<bool>("isGap", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#isOverlap()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOverlap()
        {
            return IExecuteWithSignature<bool>("isOverlap", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#isValidOffset(java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidOffset(Java.Time.ZoneOffset arg0)
        {
            return IExecuteWithSignature<bool>("isValidOffset", "(Ljava/time/ZoneOffset;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#compareTo(java.time.zone.ZoneOffsetTransition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Zone.ZoneOffsetTransition"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Time.Zone.ZoneOffsetTransition arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/time/zone/ZoneOffsetTransition;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/time/zone/ZoneOffsetTransition.html#toEpochSecond()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ToEpochSecond()
        {
            return IExecuteWithSignature<long>("toEpochSecond", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}