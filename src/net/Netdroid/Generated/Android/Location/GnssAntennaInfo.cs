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
    #region GnssAntennaInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html"/>
    /// </summary>
    public partial class GnssAntennaInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.location.GnssAntennaInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GnssAntennaInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GnssAntennaInfo(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.location.GnssAntennaInfo$Builder";
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

        #region Listener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Listener.html"/>
        /// </summary>
        public partial class Listener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Listener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.location.GnssAntennaInfo_Listener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region ListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="Listener"/> or its generic type if there is one
        /// </summary>
        public partial class ListenerDirect : Listener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.location.GnssAntennaInfo$Listener";
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

        #region PhaseCenterOffset declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html"/>
        /// </summary>
        public partial class PhaseCenterOffset : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.location.GnssAntennaInfo$PhaseCenterOffset";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public PhaseCenterOffset() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public PhaseCenterOffset(params object[] args) : base(args) { }
        
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

        #region SphericalCorrections declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html"/>
        /// </summary>
        public partial class SphericalCorrections : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.location.GnssAntennaInfo$SphericalCorrections";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SphericalCorrections() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SphericalCorrections(params object[] args) : base(args) { }
        
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

    #region GnssAntennaInfo implementation
    public partial class GnssAntennaInfo
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html#getPhaseCenterOffset()"/>
        /// </summary>
        /// <returns><see cref="Android.Location.GnssAntennaInfo.PhaseCenterOffset"/></returns>
        public Android.Location.GnssAntennaInfo.PhaseCenterOffset GetPhaseCenterOffset()
        {
            return IExecuteWithSignature<Android.Location.GnssAntennaInfo.PhaseCenterOffset>("getPhaseCenterOffset", "()Landroid/location/GnssAntennaInfo$PhaseCenterOffset;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html#getPhaseCenterVariationCorrections()"/>
        /// </summary>
        /// <returns><see cref="Android.Location.GnssAntennaInfo.SphericalCorrections"/></returns>
        public Android.Location.GnssAntennaInfo.SphericalCorrections GetPhaseCenterVariationCorrections()
        {
            return IExecuteWithSignature<Android.Location.GnssAntennaInfo.SphericalCorrections>("getPhaseCenterVariationCorrections", "()Landroid/location/GnssAntennaInfo$SphericalCorrections;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html#getSignalGainCorrections()"/>
        /// </summary>
        /// <returns><see cref="Android.Location.GnssAntennaInfo.SphericalCorrections"/></returns>
        public Android.Location.GnssAntennaInfo.SphericalCorrections GetSignalGainCorrections()
        {
            return IExecuteWithSignature<Android.Location.GnssAntennaInfo.SphericalCorrections>("getSignalGainCorrections", "()Landroid/location/GnssAntennaInfo$SphericalCorrections;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html#getCarrierFrequencyMHz()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetCarrierFrequencyMHz()
        {
            return IExecuteWithSignature<double>("getCarrierFrequencyMHz", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html#%3Cinit%3E(android.location.GnssAntennaInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssAntennaInfo"/></param>
            public Builder(Android.Location.GnssAntennaInfo arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html#%3Cinit%3E(double,android.location.GnssAntennaInfo.PhaseCenterOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="Android.Location.GnssAntennaInfo.PhaseCenterOffset"/></param>
            public Builder(double arg0, Android.Location.GnssAntennaInfo.PhaseCenterOffset arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Location.GnssAntennaInfo"/></returns>
            public Android.Location.GnssAntennaInfo Build()
            {
                return IExecuteWithSignature<Android.Location.GnssAntennaInfo>("build", "()Landroid/location/GnssAntennaInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html#setCarrierFrequencyMHz(double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <returns><see cref="Android.Location.GnssAntennaInfo.Builder"/></returns>
            public Android.Location.GnssAntennaInfo.Builder SetCarrierFrequencyMHz(double arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssAntennaInfo.Builder>("setCarrierFrequencyMHz", "(D)Landroid/location/GnssAntennaInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html#setPhaseCenterOffset(android.location.GnssAntennaInfo.PhaseCenterOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssAntennaInfo.PhaseCenterOffset"/></param>
            /// <returns><see cref="Android.Location.GnssAntennaInfo.Builder"/></returns>
            public Android.Location.GnssAntennaInfo.Builder SetPhaseCenterOffset(Android.Location.GnssAntennaInfo.PhaseCenterOffset arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssAntennaInfo.Builder>("setPhaseCenterOffset", "(Landroid/location/GnssAntennaInfo$PhaseCenterOffset;)Landroid/location/GnssAntennaInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html#setPhaseCenterVariationCorrections(android.location.GnssAntennaInfo.SphericalCorrections)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssAntennaInfo.SphericalCorrections"/></param>
            /// <returns><see cref="Android.Location.GnssAntennaInfo.Builder"/></returns>
            public Android.Location.GnssAntennaInfo.Builder SetPhaseCenterVariationCorrections(Android.Location.GnssAntennaInfo.SphericalCorrections arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssAntennaInfo.Builder>("setPhaseCenterVariationCorrections", "(Landroid/location/GnssAntennaInfo$SphericalCorrections;)Landroid/location/GnssAntennaInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Builder.html#setSignalGainCorrections(android.location.GnssAntennaInfo.SphericalCorrections)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Location.GnssAntennaInfo.SphericalCorrections"/></param>
            /// <returns><see cref="Android.Location.GnssAntennaInfo.Builder"/></returns>
            public Android.Location.GnssAntennaInfo.Builder SetSignalGainCorrections(Android.Location.GnssAntennaInfo.SphericalCorrections arg0)
            {
                return IExecuteWithSignature<Android.Location.GnssAntennaInfo.Builder>("setSignalGainCorrections", "(Landroid/location/GnssAntennaInfo$SphericalCorrections;)Landroid/location/GnssAntennaInfo$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Listener implementation
        public partial class Listener
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
            /// Handlers initializer for <see cref="Listener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onGnssAntennaInfoReceived", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnGnssAntennaInfoReceivedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Listener.html#onGnssAntennaInfoReceived(java.util.List)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnGnssAntennaInfoReceived"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Util.List<Android.Location.GnssAntennaInfo>> OnOnGnssAntennaInfoReceived { get; set; } = null;
            
            bool hasOverrideOnGnssAntennaInfoReceived = true;
            void OnGnssAntennaInfoReceivedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnGnssAntennaInfoReceived = true;
                var methodToExecute = (OnOnGnssAntennaInfoReceived != null) ? OnOnGnssAntennaInfoReceived : OnGnssAntennaInfoReceived;
                methodToExecute.Invoke(data.EventData.GetAt<Java.Util.List<Android.Location.GnssAntennaInfo>>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnGnssAntennaInfoReceived;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Listener.html#onGnssAntennaInfoReceived(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public virtual void OnGnssAntennaInfoReceived(Java.Util.List<Android.Location.GnssAntennaInfo> arg0)
            {
                hasOverrideOnGnssAntennaInfoReceived = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region ListenerDirect implementation
        public partial class ListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.Listener.html#onGnssAntennaInfoReceived(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            public override void OnGnssAntennaInfoReceived(Java.Util.List<Android.Location.GnssAntennaInfo> arg0)
            {
                IExecuteWithSignature("onGnssAntennaInfoReceived", "(Ljava/util/List;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region PhaseCenterOffset implementation
        public partial class PhaseCenterOffset
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#%3Cinit%3E(double,double,double,double,double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            /// <param name="arg4"><see cref="double"/></param>
            /// <param name="arg5"><see cref="double"/></param>
            public PhaseCenterOffset(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#getXOffsetMm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetXOffsetMm()
            {
                return IExecuteWithSignature<double>("getXOffsetMm", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#getXOffsetUncertaintyMm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetXOffsetUncertaintyMm()
            {
                return IExecuteWithSignature<double>("getXOffsetUncertaintyMm", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#getYOffsetMm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetYOffsetMm()
            {
                return IExecuteWithSignature<double>("getYOffsetMm", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#getYOffsetUncertaintyMm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetYOffsetUncertaintyMm()
            {
                return IExecuteWithSignature<double>("getYOffsetUncertaintyMm", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#getZOffsetMm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetZOffsetMm()
            {
                return IExecuteWithSignature<double>("getZOffsetMm", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#getZOffsetUncertaintyMm()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetZOffsetUncertaintyMm()
            {
                return IExecuteWithSignature<double>("getZOffsetUncertaintyMm", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.PhaseCenterOffset.html#writeToParcel(android.os.Parcel,int)"/>
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

        #region SphericalCorrections implementation
        public partial class SphericalCorrections
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#%3Cinit%3E(double[][],double[][])"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            public SphericalCorrections(double[][] arg0, double[][] arg1)
                : base(arg0, arg1)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#getDeltaPhi()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetDeltaPhi()
            {
                return IExecuteWithSignature<double>("getDeltaPhi", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#getDeltaTheta()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double GetDeltaTheta()
            {
                return IExecuteWithSignature<double>("getDeltaTheta", "()D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#getCorrectionsArray()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double[] GetCorrectionsArray()
            {
                return IExecuteWithSignatureArray<double>("getCorrectionsArray", "()[[D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#getCorrectionUncertaintiesArray()"/>
            /// </summary>
            /// <returns><see cref="double"/></returns>
            public double[] GetCorrectionUncertaintiesArray()
            {
                return IExecuteWithSignatureArray<double>("getCorrectionUncertaintiesArray", "()[[D");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/location/GnssAntennaInfo.SphericalCorrections.html#writeToParcel(android.os.Parcel,int)"/>
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

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}