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
    #region GnssAutomaticGainControl
    public partial class GnssAutomaticGainControl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.html#getCarrierFrequencyHz()"/> 
        /// </summary>
        public long CarrierFrequencyHz
        {
            get { return IExecuteWithSignature<long>("getCarrierFrequencyHz", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.html#getConstellationType()"/> 
        /// </summary>
        public int ConstellationType
        {
            get { return IExecuteWithSignature<int>("getConstellationType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.html#getLevelDb()"/> 
        /// </summary>
        public double LevelDb
        {
            get { return IExecuteWithSignature<double>("getLevelDb", "()D"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.Builder.html#%3Cinit%3E(android.location.GnssAutomaticGainControl)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssAutomaticGainControl"/></param>
            public Builder(Android.Location.GnssAutomaticGainControl arg0)
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
            /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssAutomaticGainControl"/></returns>
            public Android.Location.GnssAutomaticGainControl Build()
            {
                return IExecuteWithSignature<Android.Location.GnssAutomaticGainControl>("build", "()Landroid/location/GnssAutomaticGainControl;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.Builder.html#setCarrierFrequencyHz(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Location.GnssAutomaticGainControl.Builder"/></returns>
            public Android.Location.GnssAutomaticGainControl.Builder SetCarrierFrequencyHz(long arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssAutomaticGainControl.Builder>("setCarrierFrequencyHz", "(J)Landroid/location/GnssAutomaticGainControl$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.Builder.html#setConstellationType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Location.GnssAutomaticGainControl.Builder"/></returns>
            public Android.Location.GnssAutomaticGainControl.Builder SetConstellationType(int arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssAutomaticGainControl.Builder>("setConstellationType", "(I)Landroid/location/GnssAutomaticGainControl$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAutomaticGainControl.Builder.html#setLevelDb(double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="Android.Location.GnssAutomaticGainControl.Builder"/></returns>
            public Android.Location.GnssAutomaticGainControl.Builder SetLevelDb(double arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssAutomaticGainControl.Builder>("setLevelDb", "(D)Landroid/location/GnssAutomaticGainControl$Builder;", arg0);
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