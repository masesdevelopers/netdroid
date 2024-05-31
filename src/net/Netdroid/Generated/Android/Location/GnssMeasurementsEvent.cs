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

namespace Android.Location
{
    #region GnssMeasurementsEvent
    public partial class GnssMeasurementsEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#getClock()"/> 
        /// </summary>
        public Android.Location.GnssClock Clock
        {
            get { return IExecuteWithSignature<Android.Location.GnssClock>("getClock", "()Landroid/location/GnssClock;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#getGnssAutomaticGainControls()"/> 
        /// </summary>
        public Java.Util.Collection<Android.Location.GnssAutomaticGainControl> GnssAutomaticGainControls
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Android.Location.GnssAutomaticGainControl>>("getGnssAutomaticGainControls", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#getMeasurements()"/> 
        /// </summary>
        public Java.Util.Collection<Android.Location.GnssMeasurement> Measurements
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Android.Location.GnssMeasurement>>("getMeasurements", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#hasIsFullTracking()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasIsFullTracking()
        {
            return IExecuteWithSignature<bool>("hasIsFullTracking", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#isFullTracking()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFullTracking()
        {
            return IExecuteWithSignature<bool>("isFullTracking", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Builder.html#%3Cinit%3E(android.location.GnssMeasurementsEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssMeasurementsEvent"/></param>
            public Builder(Android.Location.GnssMeasurementsEvent arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssMeasurementsEvent"/></returns>
            public Android.Location.GnssMeasurementsEvent Build()
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementsEvent>("build", "()Landroid/location/GnssMeasurementsEvent;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Builder.html#clearIsFullTracking()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssMeasurementsEvent.Builder"/></returns>
            public Android.Location.GnssMeasurementsEvent.Builder ClearIsFullTracking()
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementsEvent.Builder>("clearIsFullTracking", "()Landroid/location/GnssMeasurementsEvent$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Builder.html#setClock(android.location.GnssClock)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssClock"/></param>
            /// <returns><see cref="Android.Location.GnssMeasurementsEvent.Builder"/></returns>
            public Android.Location.GnssMeasurementsEvent.Builder SetClock(Android.Location.GnssClock arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementsEvent.Builder>("setClock", "(Landroid/location/GnssClock;)Landroid/location/GnssMeasurementsEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Builder.html#setGnssAutomaticGainControls(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.Location.GnssMeasurementsEvent.Builder"/></returns>
            public Android.Location.GnssMeasurementsEvent.Builder SetGnssAutomaticGainControls(Java.Util.Collection<Android.Location.GnssAutomaticGainControl> arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementsEvent.Builder>("setGnssAutomaticGainControls", "(Ljava/util/Collection;)Landroid/location/GnssMeasurementsEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Builder.html#setIsFullTracking(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssMeasurementsEvent.Builder"/></returns>
            public Android.Location.GnssMeasurementsEvent.Builder SetIsFullTracking(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementsEvent.Builder>("setIsFullTracking", "(Z)Landroid/location/GnssMeasurementsEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Builder.html#setMeasurements(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.Location.GnssMeasurementsEvent.Builder"/></returns>
            public Android.Location.GnssMeasurementsEvent.Builder SetMeasurements(Java.Util.Collection<Android.Location.GnssMeasurement> arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssMeasurementsEvent.Builder>("setMeasurements", "(Ljava/util/Collection;)Landroid/location/GnssMeasurementsEvent$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Callback
        public partial class Callback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Callback.html#STATUS_LOCATION_DISABLED"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_LOCATION_DISABLED { get { if (!_STATUS_LOCATION_DISABLEDReady) { _STATUS_LOCATION_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_LOCATION_DISABLED"); _STATUS_LOCATION_DISABLEDReady = true; } return _STATUS_LOCATION_DISABLEDContent; } }
            private static int _STATUS_LOCATION_DISABLEDContent = default;
            private static bool _STATUS_LOCATION_DISABLEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Callback.html#STATUS_NOT_ALLOWED"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_NOT_ALLOWED { get { if (!_STATUS_NOT_ALLOWEDReady) { _STATUS_NOT_ALLOWEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_ALLOWED"); _STATUS_NOT_ALLOWEDReady = true; } return _STATUS_NOT_ALLOWEDContent; } }
            private static int _STATUS_NOT_ALLOWEDContent = default;
            private static bool _STATUS_NOT_ALLOWEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Callback.html#STATUS_NOT_SUPPORTED"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_NOT_SUPPORTED { get { if (!_STATUS_NOT_SUPPORTEDReady) { _STATUS_NOT_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_SUPPORTED"); _STATUS_NOT_SUPPORTEDReady = true; } return _STATUS_NOT_SUPPORTEDContent; } }
            private static int _STATUS_NOT_SUPPORTEDContent = default;
            private static bool _STATUS_NOT_SUPPORTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Callback.html#STATUS_READY"/>
            /// </summary>
            [System.Obsolete()]
            public static int STATUS_READY { get { if (!_STATUS_READYReady) { _STATUS_READYContent = SGetField<int>(LocalBridgeClazz, "STATUS_READY"); _STATUS_READYReady = true; } return _STATUS_READYContent; } }
            private static int _STATUS_READYContent = default;
            private static bool _STATUS_READYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Callback.html#onGnssMeasurementsReceived(android.location.GnssMeasurementsEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssMeasurementsEvent"/></param>
            public void OnGnssMeasurementsReceived(Android.Location.GnssMeasurementsEvent arg0)
            {
                IExecuteWithSignature("onGnssMeasurementsReceived", "(Landroid/location/GnssMeasurementsEvent;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssMeasurementsEvent.Callback.html#onStatusChanged(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            [System.Obsolete()]
            public void OnStatusChanged(int arg0)
            {
                IExecuteWithSignature("onStatusChanged", "(I)V", arg0);
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