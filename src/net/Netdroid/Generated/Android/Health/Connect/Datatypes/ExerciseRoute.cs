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

namespace Android.Health.Connect.Datatypes
{
    #region ExerciseRoute declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.html"/>
    /// </summary>
    public partial class ExerciseRoute : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.health.connect.datatypes.ExerciseRoute";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ExerciseRoute() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ExerciseRoute(params object[] args) : base(args) { }

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
        #region Location declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html"/>
        /// </summary>
        public partial class Location : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.health.connect.datatypes.ExerciseRoute$Location";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Location() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Location(params object[] args) : base(args) { }

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
            #region Builder declaration
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.Builder.html"/>
            /// </summary>
            public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
            {
                const string _bridgeClassName = "android.health.connect.datatypes.ExerciseRoute$Location$Builder";
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

    
    }
    #endregion

    #region ExerciseRoute implementation
    public partial class ExerciseRoute
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.html#%3Cinit%3E(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public ExerciseRoute(Java.Util.List<Android.Health.Connect.Datatypes.ExerciseRoute.Location> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.html#getRouteLocations()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Health.Connect.Datatypes.ExerciseRoute.Location> GetRouteLocations()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.ExerciseRoute.Location>>("getRouteLocations", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Location implementation
        public partial class Location
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#getAltitude()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Length"/></returns>
            public Android.Health.Connect.Datatypes.Units.Length GetAltitude()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Length>("getAltitude", "()Landroid/health/connect/datatypes/units/Length;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#getHorizontalAccuracy()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Length"/></returns>
            public Android.Health.Connect.Datatypes.Units.Length GetHorizontalAccuracy()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Length>("getHorizontalAccuracy", "()Landroid/health/connect/datatypes/units/Length;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#getVerticalAccuracy()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.Units.Length"/></returns>
            public Android.Health.Connect.Datatypes.Units.Length GetVerticalAccuracy()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.Units.Length>("getVerticalAccuracy", "()Landroid/health/connect/datatypes/units/Length;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#getLatitude()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetLatitude()
            {
                return IExecuteWithSignature<double>("getLatitude", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#getLongitude()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetLongitude()
            {
                return IExecuteWithSignature<double>("getLongitude", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#getTime()"/>
            /// </summary>
            /// <returns><see cref="Java.Time.Instant"/></returns>
            public Java.Time.Instant GetTime()
            {
                return IExecuteWithSignature<Java.Time.Instant>("getTime", "()Ljava/time/Instant;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.html#writeToParcel(android.os.Parcel,int)"/>
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
                /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.Builder.html#%3Cinit%3E(java.time.Instant,double,double)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
                /// <param name="arg1"><see cref="double"/></param>
                /// <param name="arg2"><see cref="double"/></param>
                public Builder(Java.Time.Instant arg0, double arg1, double arg2)
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
                /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseRoute.Location"/></returns>
                public Android.Health.Connect.Datatypes.ExerciseRoute.Location Build()
                {
                    return IExecute<Android.Health.Connect.Datatypes.ExerciseRoute.Location>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.Builder.html#setAltitude(android.health.connect.datatypes.units.Length)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.Length"/></param>
                /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder"/></returns>
                public Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder SetAltitude(Android.Health.Connect.Datatypes.Units.Length arg0)
                {
                    return IExecute<Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder>("setAltitude", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.Builder.html#setHorizontalAccuracy(android.health.connect.datatypes.units.Length)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.Length"/></param>
                /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder"/></returns>
                public Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder SetHorizontalAccuracy(Android.Health.Connect.Datatypes.Units.Length arg0)
                {
                    return IExecute<Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder>("setHorizontalAccuracy", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/ExerciseRoute.Location.Builder.html#setVerticalAccuracy(android.health.connect.datatypes.units.Length)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Units.Length"/></param>
                /// <returns><see cref="Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder"/></returns>
                public Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder SetVerticalAccuracy(Android.Health.Connect.Datatypes.Units.Length arg0)
                {
                    return IExecute<Android.Health.Connect.Datatypes.ExerciseRoute.Location.Builder>("setVerticalAccuracy", arg0);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}