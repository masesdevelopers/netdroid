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

namespace Android.Health.Connect.Datatypes
{
    #region WeightRecord
    public partial class WeightRecord
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.html#WEIGHT_AVG"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType WEIGHT_AVG { get { if (!_WEIGHT_AVGReady) { _WEIGHT_AVGContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "WEIGHT_AVG"); _WEIGHT_AVGReady = true; } return _WEIGHT_AVGContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _WEIGHT_AVGContent = default;
        private static bool _WEIGHT_AVGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.html#WEIGHT_MAX"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType WEIGHT_MAX { get { if (!_WEIGHT_MAXReady) { _WEIGHT_MAXContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "WEIGHT_MAX"); _WEIGHT_MAXReady = true; } return _WEIGHT_MAXContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _WEIGHT_MAXContent = default;
        private static bool _WEIGHT_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.html#WEIGHT_MIN"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType WEIGHT_MIN { get { if (!_WEIGHT_MINReady) { _WEIGHT_MINContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "WEIGHT_MIN"); _WEIGHT_MINReady = true; } return _WEIGHT_MINContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _WEIGHT_MINContent = default;
        private static bool _WEIGHT_MINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.html#getWeight()"/>
        /// </summary>
        /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Mass"/></returns>
        public Android.Health.Connect.Datatypes.Units.Mass GetWeight()
        {
            return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Mass>("getWeight", "()Landroid/health/connect/datatypes/units/Mass;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,android.health.connect.datatypes.units.Mass)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="Android.Health.Connect.Datatypes.Units.Mass"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, Android.Health.Connect.Datatypes.Units.Mass arg2)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.WeightRecord"/></returns>
            public Android.Health.Connect.Datatypes.WeightRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.WeightRecord>("build", "()Landroid/health/connect/datatypes/WeightRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.Builder.html#clearZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.WeightRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.WeightRecord.Builder ClearZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.WeightRecord.Builder>("clearZoneOffset", "()Landroid/health/connect/datatypes/WeightRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/WeightRecord.Builder.html#setZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.WeightRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.WeightRecord.Builder SetZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.WeightRecord.Builder>("setZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/WeightRecord$Builder;", arg0);
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