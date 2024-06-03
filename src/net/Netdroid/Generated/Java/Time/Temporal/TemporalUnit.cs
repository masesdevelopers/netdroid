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

namespace Java.Time.Temporal
{
    #region ITemporalUnit
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITemporalUnit
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TemporalUnit
    public partial class TemporalUnit : Java.Time.Temporal.ITemporalUnit
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
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#addTo(java.time.temporal.Temporal,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="R"><see cref="Java.Time.Temporal.ITemporal"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R AddTo<R>(R arg0, long arg1) where R : Java.Time.Temporal.ITemporal, new()
        {
            return IExecute<R>("addTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isDateBased()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDateBased()
        {
            return IExecuteWithSignature<bool>("isDateBased", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isDurationEstimated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDurationEstimated()
        {
            return IExecuteWithSignature<bool>("isDurationEstimated", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isTimeBased()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTimeBased()
        {
            return IExecuteWithSignature<bool>("isTimeBased", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#getDuration()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GetDuration()
        {
            return IExecuteWithSignature<Java.Time.Duration>("getDuration", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#between(java.time.temporal.Temporal,java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="long"/></returns>
        public long Between(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.Temporal arg1)
        {
            return IExecute<long>("between", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isSupportedBy(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupportedBy(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<bool>("isSupportedBy", "(Ljava/time/temporal/Temporal;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}