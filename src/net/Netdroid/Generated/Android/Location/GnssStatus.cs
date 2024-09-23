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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Location
{
    #region GnssStatus declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html"/>
    /// </summary>
    public partial class GnssStatus : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.location.GnssStatus";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GnssStatus() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GnssStatus(params object[] args) : base(args) { }

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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.location.GnssStatus$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Callback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Callback.html"/>
        /// </summary>
        public partial class Callback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Callback>
        {
            const string _bridgeClassName = "android.location.GnssStatus$Callback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Callback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Callback(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region GnssStatus implementation
    public partial class GnssStatus
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_BEIDOU"/>
        /// </summary>
        public static int CONSTELLATION_BEIDOU { get { if (!_CONSTELLATION_BEIDOUReady) { _CONSTELLATION_BEIDOUContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_BEIDOU"); _CONSTELLATION_BEIDOUReady = true; } return _CONSTELLATION_BEIDOUContent; } }
        private static int _CONSTELLATION_BEIDOUContent = default;
        private static bool _CONSTELLATION_BEIDOUReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_GALILEO"/>
        /// </summary>
        public static int CONSTELLATION_GALILEO { get { if (!_CONSTELLATION_GALILEOReady) { _CONSTELLATION_GALILEOContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_GALILEO"); _CONSTELLATION_GALILEOReady = true; } return _CONSTELLATION_GALILEOContent; } }
        private static int _CONSTELLATION_GALILEOContent = default;
        private static bool _CONSTELLATION_GALILEOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_GLONASS"/>
        /// </summary>
        public static int CONSTELLATION_GLONASS { get { if (!_CONSTELLATION_GLONASSReady) { _CONSTELLATION_GLONASSContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_GLONASS"); _CONSTELLATION_GLONASSReady = true; } return _CONSTELLATION_GLONASSContent; } }
        private static int _CONSTELLATION_GLONASSContent = default;
        private static bool _CONSTELLATION_GLONASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_GPS"/>
        /// </summary>
        public static int CONSTELLATION_GPS { get { if (!_CONSTELLATION_GPSReady) { _CONSTELLATION_GPSContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_GPS"); _CONSTELLATION_GPSReady = true; } return _CONSTELLATION_GPSContent; } }
        private static int _CONSTELLATION_GPSContent = default;
        private static bool _CONSTELLATION_GPSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_IRNSS"/>
        /// </summary>
        public static int CONSTELLATION_IRNSS { get { if (!_CONSTELLATION_IRNSSReady) { _CONSTELLATION_IRNSSContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_IRNSS"); _CONSTELLATION_IRNSSReady = true; } return _CONSTELLATION_IRNSSContent; } }
        private static int _CONSTELLATION_IRNSSContent = default;
        private static bool _CONSTELLATION_IRNSSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_QZSS"/>
        /// </summary>
        public static int CONSTELLATION_QZSS { get { if (!_CONSTELLATION_QZSSReady) { _CONSTELLATION_QZSSContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_QZSS"); _CONSTELLATION_QZSSReady = true; } return _CONSTELLATION_QZSSContent; } }
        private static int _CONSTELLATION_QZSSContent = default;
        private static bool _CONSTELLATION_QZSSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_SBAS"/>
        /// </summary>
        public static int CONSTELLATION_SBAS { get { if (!_CONSTELLATION_SBASReady) { _CONSTELLATION_SBASContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_SBAS"); _CONSTELLATION_SBASReady = true; } return _CONSTELLATION_SBASContent; } }
        private static int _CONSTELLATION_SBASContent = default;
        private static bool _CONSTELLATION_SBASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#CONSTELLATION_UNKNOWN"/>
        /// </summary>
        public static int CONSTELLATION_UNKNOWN { get { if (!_CONSTELLATION_UNKNOWNReady) { _CONSTELLATION_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CONSTELLATION_UNKNOWN"); _CONSTELLATION_UNKNOWNReady = true; } return _CONSTELLATION_UNKNOWNContent; } }
        private static int _CONSTELLATION_UNKNOWNContent = default;
        private static bool _CONSTELLATION_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#hasAlmanacData(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasAlmanacData(int arg0)
        {
            return IExecuteWithSignature<bool>("hasAlmanacData", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#hasBasebandCn0DbHz(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasBasebandCn0DbHz(int arg0)
        {
            return IExecuteWithSignature<bool>("hasBasebandCn0DbHz", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#hasCarrierFrequencyHz(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCarrierFrequencyHz(int arg0)
        {
            return IExecuteWithSignature<bool>("hasCarrierFrequencyHz", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#hasEphemerisData(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasEphemerisData(int arg0)
        {
            return IExecuteWithSignature<bool>("hasEphemerisData", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#usedInFix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UsedInFix(int arg0)
        {
            return IExecuteWithSignature<bool>("usedInFix", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getAzimuthDegrees(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetAzimuthDegrees(int arg0)
        {
            return IExecuteWithSignature<float>("getAzimuthDegrees", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getBasebandCn0DbHz(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetBasebandCn0DbHz(int arg0)
        {
            return IExecuteWithSignature<float>("getBasebandCn0DbHz", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getCarrierFrequencyHz(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetCarrierFrequencyHz(int arg0)
        {
            return IExecuteWithSignature<float>("getCarrierFrequencyHz", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getCn0DbHz(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetCn0DbHz(int arg0)
        {
            return IExecuteWithSignature<float>("getCn0DbHz", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getElevationDegrees(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetElevationDegrees(int arg0)
        {
            return IExecuteWithSignature<float>("getElevationDegrees", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getConstellationType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConstellationType(int arg0)
        {
            return IExecuteWithSignature<int>("getConstellationType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getSatelliteCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSatelliteCount()
        {
            return IExecuteWithSignature<int>("getSatelliteCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#getSvid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSvid(int arg0)
        {
            return IExecuteWithSignature<int>("getSvid", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssStatus.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssStatus"/></returns>
            public Android.Location.GnssStatus Build()
            {
                return IExecuteWithSignature<Android.Location.GnssStatus>("build", "()Landroid/location/GnssStatus;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Builder.html#addSatellite(int,int,float,float,float,boolean,boolean,boolean,boolean,float,boolean,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="bool"/></param>
            /// <param name="arg6"><see cref="bool"/></param>
            /// <param name="arg7"><see cref="bool"/></param>
            /// <param name="arg8"><see cref="bool"/></param>
            /// <param name="arg9"><see cref="float"/></param>
            /// <param name="arg10"><see cref="bool"/></param>
            /// <param name="arg11"><see cref="float"/></param>
            /// <returns><see cref="Android.Location.GnssStatus.Builder"/></returns>
            public Android.Location.GnssStatus.Builder AddSatellite(int arg0, int arg1, float arg2, float arg3, float arg4, bool arg5, bool arg6, bool arg7, bool arg8, float arg9, bool arg10, float arg11)
            {
                return IExecute<Android.Location.GnssStatus.Builder>("addSatellite", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Builder.html#clearSatellites()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssStatus.Builder"/></returns>
            public Android.Location.GnssStatus.Builder ClearSatellites()
            {
                return IExecuteWithSignature<Android.Location.GnssStatus.Builder>("clearSatellites", "()Landroid/location/GnssStatus$Builder;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Callback implementation
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Callback.html#onFirstFix(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnFirstFix(int arg0)
            {
                IExecuteWithSignature("onFirstFix", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Callback.html#onSatelliteStatusChanged(android.location.GnssStatus)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssStatus"/></param>
            public void OnSatelliteStatusChanged(Android.Location.GnssStatus arg0)
            {
                IExecuteWithSignature("onSatelliteStatusChanged", "(Landroid/location/GnssStatus;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Callback.html#onStarted()"/>
            /// </summary>
            public void OnStarted()
            {
                IExecuteWithSignature("onStarted", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssStatus.Callback.html#onStopped()"/>
            /// </summary>
            public void OnStopped()
            {
                IExecuteWithSignature("onStopped", "()V");
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