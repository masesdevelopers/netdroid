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
    #region Geocoder declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/location/Geocoder.html"/>
    /// </summary>
    public partial class Geocoder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Geocoder>
    {
        const string _bridgeClassName = "android.location.Geocoder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Geocoder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Geocoder(params object[] args) : base(args) { }

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
        #region GeocodeListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html"/>
        /// </summary>
        public partial class GeocodeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public GeocodeListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.location.Geocoder_GeocodeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region GeocodeListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="GeocodeListener"/> or its generic type if there is one
        /// </summary>
        public partial class GeocodeListenerDirect : GeocodeListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.location.Geocoder$GeocodeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        }
        #endregion

    
    }
    #endregion

    #region Geocoder implementation
    public partial class Geocoder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#%3Cinit%3E(android.content.Context,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public Geocoder(Android.Content.Context arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public Geocoder(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#isPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPresent()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isPresent", "()Z");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#getFromLocation(double,double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Location.Address> GetFromLocation(double arg0, double arg1, int arg2)
        {
            return IExecute<Java.Util.List<Android.Location.Address>>("getFromLocation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#getFromLocationName(java.lang.String,int,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Location.Address> GetFromLocationName(Java.Lang.String arg0, int arg1, double arg2, double arg3, double arg4, double arg5)
        {
            return IExecute<Java.Util.List<Android.Location.Address>>("getFromLocationName", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#getFromLocationName(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Location.Address> GetFromLocationName(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Java.Util.List<Android.Location.Address>>("getFromLocationName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#getFromLocation(double,double,int,android.location.Geocoder.GeocodeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Location.Geocoder.GeocodeListener"/></param>
        public void GetFromLocation(double arg0, double arg1, int arg2, Android.Location.Geocoder.GeocodeListener arg3)
        {
            IExecute("getFromLocation", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#getFromLocationName(java.lang.String,int,android.location.Geocoder.GeocodeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Location.Geocoder.GeocodeListener"/></param>
        public void GetFromLocationName(Java.Lang.String arg0, int arg1, Android.Location.Geocoder.GeocodeListener arg2)
        {
            IExecute("getFromLocationName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/Geocoder.html#getFromLocationName(java.lang.String,int,double,double,double,double,android.location.Geocoder.GeocodeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="Android.Location.Geocoder.GeocodeListener"/></param>
        public void GetFromLocationName(Java.Lang.String arg0, int arg1, double arg2, double arg3, double arg4, double arg5, Android.Location.Geocoder.GeocodeListener arg6)
        {
            IExecute("getFromLocationName", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Nested classes
        #region GeocodeListener implementation
        public partial class GeocodeListener
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
            /// Handlers initializer for <see cref="GeocodeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onGeocode", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnGeocodeEventHandler));
                AddEventHandler("onError", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnErrorEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html#onGeocode(java.util.List)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnGeocode"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Util.List<Android.Location.Address>> OnOnGeocode { get; set; } = null;

            bool hasOverrideOnGeocode = true;
            void OnGeocodeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnGeocode = true;
                var methodToExecute = (OnOnGeocode != null) ? OnOnGeocode : OnGeocode;
                methodToExecute.Invoke(data.EventData.GetAt<Java.Util.List<Android.Location.Address>>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnGeocode;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html#onGeocode(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public virtual void OnGeocode(Java.Util.List<Android.Location.Address> arg0)
            {
                hasOverrideOnGeocode = false;
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html#onError(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
            public void OnErrorDefault(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onErrorDefault", "(Ljava/lang/String;)V", arg0);
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html#onError(java.lang.String)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnError"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Lang.String> OnOnError { get; set; } = null;

            bool hasOverrideOnError = true;
            void OnErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnError = true;
                var methodToExecute = (OnOnError != null) ? OnOnError : OnError;
                methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnError;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html#onError(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnErrorDefault"/>; override the method to implement a different behavior</remarks>
            public virtual void OnError(Java.Lang.String arg0)
            {
                hasOverrideOnError = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region GeocodeListenerDirect implementation
        public partial class GeocodeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html#onGeocode(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public override void OnGeocode(Java.Util.List<Android.Location.Address> arg0)
            {
                IExecuteWithSignature("onGeocode", "(Ljava/util/List;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/Geocoder.GeocodeListener.html#onError(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public override void OnError(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onError", "(Ljava/lang/String;)V", arg0);
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