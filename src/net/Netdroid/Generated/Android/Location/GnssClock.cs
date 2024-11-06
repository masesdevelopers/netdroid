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
    #region GnssClock declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/location/GnssClock.html"/>
    /// </summary>
    public partial class GnssClock : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.location.GnssClock";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GnssClock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GnssClock(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region GnssClock implementation
    public partial class GnssClock
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasBiasNanos()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasBiasNanos()
        {
            return IExecuteWithSignature<bool>("hasBiasNanos", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasBiasUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasBiasUncertaintyNanos()
        {
            return IExecuteWithSignature<bool>("hasBiasUncertaintyNanos", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasDriftNanosPerSecond()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasDriftNanosPerSecond()
        {
            return IExecuteWithSignature<bool>("hasDriftNanosPerSecond", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasDriftUncertaintyNanosPerSecond()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasDriftUncertaintyNanosPerSecond()
        {
            return IExecuteWithSignature<bool>("hasDriftUncertaintyNanosPerSecond", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasElapsedRealtimeNanos()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasElapsedRealtimeNanos()
        {
            return IExecuteWithSignature<bool>("hasElapsedRealtimeNanos", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasElapsedRealtimeUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasElapsedRealtimeUncertaintyNanos()
        {
            return IExecuteWithSignature<bool>("hasElapsedRealtimeUncertaintyNanos", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasFullBiasNanos()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasFullBiasNanos()
        {
            return IExecuteWithSignature<bool>("hasFullBiasNanos", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasLeapSecond()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasLeapSecond()
        {
            return IExecuteWithSignature<bool>("hasLeapSecond", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasReferenceCarrierFrequencyHzForIsb()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasReferenceCarrierFrequencyHzForIsb()
        {
            return IExecuteWithSignature<bool>("hasReferenceCarrierFrequencyHzForIsb", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasReferenceCodeTypeForIsb()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasReferenceCodeTypeForIsb()
        {
            return IExecuteWithSignature<bool>("hasReferenceCodeTypeForIsb", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasReferenceConstellationTypeForIsb()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasReferenceConstellationTypeForIsb()
        {
            return IExecuteWithSignature<bool>("hasReferenceConstellationTypeForIsb", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#hasTimeUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasTimeUncertaintyNanos()
        {
            return IExecuteWithSignature<bool>("hasTimeUncertaintyNanos", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getBiasNanos()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetBiasNanos()
        {
            return IExecuteWithSignature<double>("getBiasNanos", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getBiasUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetBiasUncertaintyNanos()
        {
            return IExecuteWithSignature<double>("getBiasUncertaintyNanos", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getDriftNanosPerSecond()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetDriftNanosPerSecond()
        {
            return IExecuteWithSignature<double>("getDriftNanosPerSecond", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getDriftUncertaintyNanosPerSecond()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetDriftUncertaintyNanosPerSecond()
        {
            return IExecuteWithSignature<double>("getDriftUncertaintyNanosPerSecond", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getElapsedRealtimeUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetElapsedRealtimeUncertaintyNanos()
        {
            return IExecuteWithSignature<double>("getElapsedRealtimeUncertaintyNanos", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getReferenceCarrierFrequencyHzForIsb()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetReferenceCarrierFrequencyHzForIsb()
        {
            return IExecuteWithSignature<double>("getReferenceCarrierFrequencyHzForIsb", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getTimeUncertaintyNanos()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetTimeUncertaintyNanos()
        {
            return IExecuteWithSignature<double>("getTimeUncertaintyNanos", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getHardwareClockDiscontinuityCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHardwareClockDiscontinuityCount()
        {
            return IExecuteWithSignature<int>("getHardwareClockDiscontinuityCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getLeapSecond()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLeapSecond()
        {
            return IExecuteWithSignature<int>("getLeapSecond", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getReferenceConstellationTypeForIsb()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReferenceConstellationTypeForIsb()
        {
            return IExecuteWithSignature<int>("getReferenceConstellationTypeForIsb", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getReferenceCodeTypeForIsb()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetReferenceCodeTypeForIsb()
        {
            return IExecuteWithSignature<Java.Lang.String>("getReferenceCodeTypeForIsb", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getElapsedRealtimeNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetElapsedRealtimeNanos()
        {
            return IExecuteWithSignature<long>("getElapsedRealtimeNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getFullBiasNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetFullBiasNanos()
        {
            return IExecuteWithSignature<long>("getFullBiasNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#getTimeNanos()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimeNanos()
        {
            return IExecuteWithSignature<long>("getTimeNanos", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssClock.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}