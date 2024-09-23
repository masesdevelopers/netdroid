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

namespace Android.Net
{
    #region NetworkRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html"/>
    /// </summary>
    public partial class NetworkRequest : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.NetworkRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NetworkRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NetworkRequest(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.NetworkRequest$Builder";
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

    #region NetworkRequest implementation
    public partial class NetworkRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#getNetworkSpecifier()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.NetworkSpecifier"/></returns>
        public Android.Net.NetworkSpecifier GetNetworkSpecifier()
        {
            return IExecuteWithSignature<Android.Net.NetworkSpecifier>("getNetworkSpecifier", "()Landroid/net/NetworkSpecifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#canBeSatisfiedBy(android.net.NetworkCapabilities)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.NetworkCapabilities"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanBeSatisfiedBy(Android.Net.NetworkCapabilities arg0)
        {
            return IExecuteWithSignature<bool>("canBeSatisfiedBy", "(Landroid/net/NetworkCapabilities;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#hasCapability(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCapability(int arg0)
        {
            return IExecuteWithSignature<bool>("hasCapability", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#hasTransport(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasTransport(int arg0)
        {
            return IExecuteWithSignature<bool>("hasTransport", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#getCapabilities()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetCapabilities()
        {
            return IExecuteWithSignatureArray<int>("getCapabilities", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#getTransportTypes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetTransportTypes()
        {
            return IExecuteWithSignatureArray<int>("getTransportTypes", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#getSubscriptionIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetSubscriptionIds()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getSubscriptionIds", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#%3Cinit%3E(android.net.NetworkRequest)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.NetworkRequest"/></param>
            public Builder(Android.Net.NetworkRequest arg0)
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
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.NetworkRequest"/></returns>
            public Android.Net.NetworkRequest Build()
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest>("build", "()Landroid/net/NetworkRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#addCapability(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder AddCapability(int arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("addCapability", "(I)Landroid/net/NetworkRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#addTransportType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder AddTransportType(int arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("addTransportType", "(I)Landroid/net/NetworkRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#clearCapabilities()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder ClearCapabilities()
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("clearCapabilities", "()Landroid/net/NetworkRequest$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#removeCapability(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder RemoveCapability(int arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("removeCapability", "(I)Landroid/net/NetworkRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#removeTransportType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder RemoveTransportType(int arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("removeTransportType", "(I)Landroid/net/NetworkRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#setIncludeOtherUidNetworks(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder SetIncludeOtherUidNetworks(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("setIncludeOtherUidNetworks", "(Z)Landroid/net/NetworkRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#setNetworkSpecifier(android.net.NetworkSpecifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.NetworkSpecifier"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder SetNetworkSpecifier(Android.Net.NetworkSpecifier arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("setNetworkSpecifier", "(Landroid/net/NetworkSpecifier;)Landroid/net/NetworkRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#setNetworkSpecifier(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.NetworkRequest.Builder SetNetworkSpecifier(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("setNetworkSpecifier", "(Ljava/lang/String;)Landroid/net/NetworkRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/NetworkRequest.Builder.html#setSubscriptionIds(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Net.NetworkRequest.Builder"/></returns>
            public Android.Net.NetworkRequest.Builder SetSubscriptionIds(Java.Util.Set<Java.Lang.Integer> arg0)
            {
                return IExecuteWithSignature<Android.Net.NetworkRequest.Builder>("setSubscriptionIds", "(Ljava/util/Set;)Landroid/net/NetworkRequest$Builder;", arg0);
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