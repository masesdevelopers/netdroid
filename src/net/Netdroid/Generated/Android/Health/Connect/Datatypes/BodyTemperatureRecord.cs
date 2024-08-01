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

namespace Android.Health.Connect.Datatypes
{
    #region BodyTemperatureRecord
    public partial class BodyTemperatureRecord
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
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureRecord.html#getTemperature()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Temperature"/></returns>
        public Android.Health.Connect.Datatypes.Units.Temperature GetTemperature()
        {
            return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Temperature>("getTemperature", "()Landroid/health/connect/datatypes/units/Temperature;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureRecord.html#getMeasurementLocation()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMeasurementLocation()
        {
            return IExecuteWithSignature<int>("getMeasurementLocation", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,int,android.health.connect.datatypes.units.Temperature)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Android.Health.Connect.Datatypes.Units.Temperature"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, int arg2, Android.Health.Connect.Datatypes.Units.Temperature arg3)
                : base(arg0, arg1, arg2, arg3)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BodyTemperatureRecord"/></returns>
            public Android.Health.Connect.Datatypes.BodyTemperatureRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BodyTemperatureRecord>("build", "()Landroid/health/connect/datatypes/BodyTemperatureRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureRecord.Builder.html#clearZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BodyTemperatureRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.BodyTemperatureRecord.Builder ClearZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BodyTemperatureRecord.Builder>("clearZoneOffset", "()Landroid/health/connect/datatypes/BodyTemperatureRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureRecord.Builder.html#setZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.BodyTemperatureRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.BodyTemperatureRecord.Builder SetZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.BodyTemperatureRecord.Builder>("setZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/BodyTemperatureRecord$Builder;", arg0);
            }

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