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

namespace Android.Location
{
    #region GnssCapabilities declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html"/>
    /// </summary>
    public partial class GnssCapabilities : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.location.GnssCapabilities";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GnssCapabilities() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GnssCapabilities(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.location.GnssCapabilities$Builder";
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

    
    }
    #endregion

    #region GnssCapabilities implementation
    public partial class GnssCapabilities
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#CAPABILITY_SUPPORTED"/>
        /// </summary>
        public static int CAPABILITY_SUPPORTED { get { if (!_CAPABILITY_SUPPORTEDReady) { _CAPABILITY_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_SUPPORTED"); _CAPABILITY_SUPPORTEDReady = true; } return _CAPABILITY_SUPPORTEDContent; } }
        private static int _CAPABILITY_SUPPORTEDContent = default;
        private static bool _CAPABILITY_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#CAPABILITY_UNKNOWN"/>
        /// </summary>
        public static int CAPABILITY_UNKNOWN { get { if (!_CAPABILITY_UNKNOWNReady) { _CAPABILITY_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_UNKNOWN"); _CAPABILITY_UNKNOWNReady = true; } return _CAPABILITY_UNKNOWNContent; } }
        private static int _CAPABILITY_UNKNOWNContent = default;
        private static bool _CAPABILITY_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#CAPABILITY_UNSUPPORTED"/>
        /// </summary>
        public static int CAPABILITY_UNSUPPORTED { get { if (!_CAPABILITY_UNSUPPORTEDReady) { _CAPABILITY_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_UNSUPPORTED"); _CAPABILITY_UNSUPPORTEDReady = true; } return _CAPABILITY_UNSUPPORTEDContent; } }
        private static int _CAPABILITY_UNSUPPORTEDContent = default;
        private static bool _CAPABILITY_UNSUPPORTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasAntennaInfo()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAntennaInfo()
        {
            return IExecuteWithSignature<bool>("hasAntennaInfo", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasGeofencing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasGeofencing()
        {
            return IExecuteWithSignature<bool>("hasGeofencing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasGnssAntennaInfo()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool HasGnssAntennaInfo()
        {
            return IExecuteWithSignature<bool>("hasGnssAntennaInfo", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasLowPowerMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasLowPowerMode()
        {
            return IExecuteWithSignature<bool>("hasLowPowerMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMeasurementCorrections()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurementCorrections()
        {
            return IExecuteWithSignature<bool>("hasMeasurementCorrections", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMeasurementCorrectionsExcessPathLength()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurementCorrectionsExcessPathLength()
        {
            return IExecuteWithSignature<bool>("hasMeasurementCorrectionsExcessPathLength", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMeasurementCorrectionsForDriving()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurementCorrectionsForDriving()
        {
            return IExecuteWithSignature<bool>("hasMeasurementCorrectionsForDriving", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMeasurementCorrectionsLosSats()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurementCorrectionsLosSats()
        {
            return IExecuteWithSignature<bool>("hasMeasurementCorrectionsLosSats", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMeasurementCorrectionsReflectingPlane()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurementCorrectionsReflectingPlane()
        {
            return IExecuteWithSignature<bool>("hasMeasurementCorrectionsReflectingPlane", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMeasurementCorrelationVectors()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurementCorrelationVectors()
        {
            return IExecuteWithSignature<bool>("hasMeasurementCorrelationVectors", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMeasurements()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurements()
        {
            return IExecuteWithSignature<bool>("hasMeasurements", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMsa()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMsa()
        {
            return IExecuteWithSignature<bool>("hasMsa", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasMsb()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMsb()
        {
            return IExecuteWithSignature<bool>("hasMsb", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasNavigationMessages()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasNavigationMessages()
        {
            return IExecuteWithSignature<bool>("hasNavigationMessages", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasOnDemandTime()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasOnDemandTime()
        {
            return IExecuteWithSignature<bool>("hasOnDemandTime", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasPowerMultibandAcquisition()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPowerMultibandAcquisition()
        {
            return IExecuteWithSignature<bool>("hasPowerMultibandAcquisition", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasPowerMultibandTracking()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPowerMultibandTracking()
        {
            return IExecuteWithSignature<bool>("hasPowerMultibandTracking", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasPowerOtherModes()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPowerOtherModes()
        {
            return IExecuteWithSignature<bool>("hasPowerOtherModes", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasPowerSinglebandAcquisition()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPowerSinglebandAcquisition()
        {
            return IExecuteWithSignature<bool>("hasPowerSinglebandAcquisition", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasPowerSinglebandTracking()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPowerSinglebandTracking()
        {
            return IExecuteWithSignature<bool>("hasPowerSinglebandTracking", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasPowerTotal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPowerTotal()
        {
            return IExecuteWithSignature<bool>("hasPowerTotal", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasSatelliteBlocklist()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSatelliteBlocklist()
        {
            return IExecuteWithSignature<bool>("hasSatelliteBlocklist", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasSatellitePvt()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSatellitePvt()
        {
            return IExecuteWithSignature<bool>("hasSatellitePvt", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasScheduling()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasScheduling()
        {
            return IExecuteWithSignature<bool>("hasScheduling", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasSingleShotFix()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSingleShotFix()
        {
            return IExecuteWithSignature<bool>("hasSingleShotFix", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#hasAccumulatedDeltaRange()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int HasAccumulatedDeltaRange()
        {
            return IExecuteWithSignature<int>("hasAccumulatedDeltaRange", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#getGnssSignalTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Location.GnssSignalType> GetGnssSignalTypes()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Location.GnssSignalType>>("getGnssSignalTypes", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#%3Cinit%3E(android.location.GnssCapabilities)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssCapabilities"/></param>
            public Builder(Android.Location.GnssCapabilities arg0)
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
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssCapabilities"/></returns>
            public Android.Location.GnssCapabilities Build()
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities>("build", "()Landroid/location/GnssCapabilities;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setGnssSignalTypes(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetGnssSignalTypes(Java.Util.List<Android.Location.GnssSignalType> arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setGnssSignalTypes", "(Ljava/util/List;)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasAccumulatedDeltaRange(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasAccumulatedDeltaRange(int arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasAccumulatedDeltaRange", "(I)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasAntennaInfo(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasAntennaInfo(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasAntennaInfo", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasGeofencing(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasGeofencing(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasGeofencing", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasLowPowerMode(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasLowPowerMode(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasLowPowerMode", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMeasurementCorrections(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMeasurementCorrections(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMeasurementCorrections", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMeasurementCorrectionsExcessPathLength(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMeasurementCorrectionsExcessPathLength(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMeasurementCorrectionsExcessPathLength", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMeasurementCorrectionsForDriving(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMeasurementCorrectionsForDriving(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMeasurementCorrectionsForDriving", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMeasurementCorrectionsLosSats(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMeasurementCorrectionsLosSats(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMeasurementCorrectionsLosSats", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMeasurementCorrectionsReflectingPlane(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMeasurementCorrectionsReflectingPlane(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMeasurementCorrectionsReflectingPlane", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMeasurementCorrelationVectors(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMeasurementCorrelationVectors(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMeasurementCorrelationVectors", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMeasurements(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMeasurements(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMeasurements", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMsa(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMsa(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMsa", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasMsb(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasMsb(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasMsb", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasNavigationMessages(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasNavigationMessages(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasNavigationMessages", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasOnDemandTime(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasOnDemandTime(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasOnDemandTime", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasPowerMultibandAcquisition(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasPowerMultibandAcquisition(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasPowerMultibandAcquisition", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasPowerMultibandTracking(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasPowerMultibandTracking(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasPowerMultibandTracking", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasPowerOtherModes(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasPowerOtherModes(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasPowerOtherModes", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasPowerSinglebandAcquisition(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasPowerSinglebandAcquisition(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasPowerSinglebandAcquisition", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasPowerSinglebandTracking(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasPowerSinglebandTracking(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasPowerSinglebandTracking", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasPowerTotal(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasPowerTotal(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasPowerTotal", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasSatelliteBlocklist(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasSatelliteBlocklist(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasSatelliteBlocklist", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasSatellitePvt(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasSatellitePvt(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasSatellitePvt", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasScheduling(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasScheduling(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasScheduling", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssCapabilities.Builder.html#setHasSingleShotFix(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Location.GnssCapabilities.Builder"/></returns>
            public Android.Location.GnssCapabilities.Builder SetHasSingleShotFix(bool arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssCapabilities.Builder>("setHasSingleShotFix", "(Z)Landroid/location/GnssCapabilities$Builder;", arg0);
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