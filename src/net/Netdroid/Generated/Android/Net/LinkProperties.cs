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
    #region LinkProperties declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html"/>
    /// </summary>
    public partial class LinkProperties : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.LinkProperties";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LinkProperties() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public LinkProperties(params object[] args) : base(args) { }

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

    #region LinkProperties implementation
    public partial class LinkProperties
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getNat64Prefix()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.IpPrefix"/></returns>
        public Android.Net.IpPrefix GetNat64Prefix()
        {
            return IExecuteWithSignature<Android.Net.IpPrefix>("getNat64Prefix", "()Landroid/net/IpPrefix;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getHttpProxy()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.ProxyInfo"/></returns>
        public Android.Net.ProxyInfo GetHttpProxy()
        {
            return IExecuteWithSignature<Android.Net.ProxyInfo>("getHttpProxy", "()Landroid/net/ProxyInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#addRoute(android.net.RouteInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.RouteInfo"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddRoute(Android.Net.RouteInfo arg0)
        {
            return IExecuteWithSignature<bool>("addRoute", "(Landroid/net/RouteInfo;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#isPrivateDnsActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPrivateDnsActive()
        {
            return IExecuteWithSignature<bool>("isPrivateDnsActive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#isWakeOnLanSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWakeOnLanSupported()
        {
            return IExecuteWithSignature<bool>("isWakeOnLanSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getMtu()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMtu()
        {
            return IExecuteWithSignature<int>("getMtu", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getDomains()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDomains()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDomains", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getInterfaceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetInterfaceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getInterfaceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getPrivateDnsServerName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPrivateDnsServerName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPrivateDnsServerName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getDhcpServerAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Inet4Address"/></returns>
        public Java.Net.Inet4Address GetDhcpServerAddress()
        {
            return IExecuteWithSignature<Java.Net.Inet4Address>("getDhcpServerAddress", "()Ljava/net/Inet4Address;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getLinkAddresses()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.LinkAddress> GetLinkAddresses()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.LinkAddress>>("getLinkAddresses", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getRoutes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.RouteInfo> GetRoutes()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.RouteInfo>>("getRoutes", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#getDnsServers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Net.InetAddress> GetDnsServers()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Net.InetAddress>>("getDnsServers", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setDhcpServerAddress(java.net.Inet4Address)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Inet4Address"/></param>
        public void SetDhcpServerAddress(Java.Net.Inet4Address arg0)
        {
            IExecuteWithSignature("setDhcpServerAddress", "(Ljava/net/Inet4Address;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setDnsServers(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void SetDnsServers(Java.Util.Collection<Java.Net.InetAddress> arg0)
        {
            IExecuteWithSignature("setDnsServers", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setDomains(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetDomains(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDomains", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setHttpProxy(android.net.ProxyInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.ProxyInfo"/></param>
        public void SetHttpProxy(Android.Net.ProxyInfo arg0)
        {
            IExecuteWithSignature("setHttpProxy", "(Landroid/net/ProxyInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setInterfaceName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetInterfaceName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setInterfaceName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setLinkAddresses(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void SetLinkAddresses(Java.Util.Collection<Android.Net.LinkAddress> arg0)
        {
            IExecuteWithSignature("setLinkAddresses", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setMtu(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMtu(int arg0)
        {
            IExecuteWithSignature("setMtu", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#setNat64Prefix(android.net.IpPrefix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.IpPrefix"/></param>
        public void SetNat64Prefix(Android.Net.IpPrefix arg0)
        {
            IExecuteWithSignature("setNat64Prefix", "(Landroid/net/IpPrefix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/LinkProperties.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}