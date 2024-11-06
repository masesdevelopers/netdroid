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

namespace Android.Net
{
    #region MacAddress declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/MacAddress.html"/>
    /// </summary>
    public partial class MacAddress : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.MacAddress";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MacAddress() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MacAddress(params object[] args) : base(args) { }
    
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

    #region MacAddress implementation
    public partial class MacAddress
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#BROADCAST_ADDRESS"/>
        /// </summary>
        public static Android.Net.MacAddress BROADCAST_ADDRESS { get { if (!_BROADCAST_ADDRESSReady) { _BROADCAST_ADDRESSContent = SGetField<Android.Net.MacAddress>(LocalBridgeClazz, "BROADCAST_ADDRESS"); _BROADCAST_ADDRESSReady = true; } return _BROADCAST_ADDRESSContent; } }
        private static Android.Net.MacAddress _BROADCAST_ADDRESSContent = default;
        private static bool _BROADCAST_ADDRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#TYPE_BROADCAST"/>
        /// </summary>
        public static int TYPE_BROADCAST { get { if (!_TYPE_BROADCASTReady) { _TYPE_BROADCASTContent = SGetField<int>(LocalBridgeClazz, "TYPE_BROADCAST"); _TYPE_BROADCASTReady = true; } return _TYPE_BROADCASTContent; } }
        private static int _TYPE_BROADCASTContent = default;
        private static bool _TYPE_BROADCASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#TYPE_MULTICAST"/>
        /// </summary>
        public static int TYPE_MULTICAST { get { if (!_TYPE_MULTICASTReady) { _TYPE_MULTICASTContent = SGetField<int>(LocalBridgeClazz, "TYPE_MULTICAST"); _TYPE_MULTICASTReady = true; } return _TYPE_MULTICASTContent; } }
        private static int _TYPE_MULTICASTContent = default;
        private static bool _TYPE_MULTICASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#TYPE_UNICAST"/>
        /// </summary>
        public static int TYPE_UNICAST { get { if (!_TYPE_UNICASTReady) { _TYPE_UNICASTContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNICAST"); _TYPE_UNICASTReady = true; } return _TYPE_UNICASTContent; } }
        private static int _TYPE_UNICASTContent = default;
        private static bool _TYPE_UNICASTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#fromBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public static Android.Net.MacAddress FromBytes(byte[] arg0)
        {
            return SExecuteWithSignature<Android.Net.MacAddress>(LocalBridgeClazz, "fromBytes", "([B)Landroid/net/MacAddress;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#fromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Net.MacAddress"/></returns>
        public static Android.Net.MacAddress FromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Net.MacAddress>(LocalBridgeClazz, "fromString", "(Ljava/lang/String;)Landroid/net/MacAddress;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#isLocallyAssigned()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLocallyAssigned()
        {
            return IExecuteWithSignature<bool>("isLocallyAssigned", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#matches(android.net.MacAddress,android.net.MacAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.MacAddress"/></param>
        /// <param name="arg1"><see cref="Android.Net.MacAddress"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Matches(Android.Net.MacAddress arg0, Android.Net.MacAddress arg1)
        {
            return IExecuteWithSignature<bool>("matches", "(Landroid/net/MacAddress;Landroid/net/MacAddress;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#toByteArray()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] ToByteArray()
        {
            return IExecuteWithSignatureArray<byte>("toByteArray", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#getAddressType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAddressType()
        {
            return IExecuteWithSignature<int>("getAddressType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#toOuiString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToOuiString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toOuiString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#getLinkLocalIpv6FromEui48Mac()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Inet6Address"/></returns>
        public Java.Net.Inet6Address GetLinkLocalIpv6FromEui48Mac()
        {
            return IExecuteWithSignature<Java.Net.Inet6Address>("getLinkLocalIpv6FromEui48Mac", "()Ljava/net/Inet6Address;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/MacAddress.html#writeToParcel(android.os.Parcel,int)"/>
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