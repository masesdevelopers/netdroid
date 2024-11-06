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

namespace Java.Net
{
    #region SocketOptions declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html"/>
    /// </summary>
    public partial class SocketOptions : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SocketOptions>
    {
        const string _bridgeClassName = "java.net.SocketOptions";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SocketOptions class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SocketOptions() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SocketOptions class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SocketOptions(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region ISocketOptions
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISocketOptions
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region SocketOptions implementation
    public partial class SocketOptions : Java.Net.ISocketOptions
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#IP_MULTICAST_IF"/>
        /// </summary>
        public static int IP_MULTICAST_IF { get { if (!_IP_MULTICAST_IFReady) { _IP_MULTICAST_IFContent = SGetField<int>(LocalBridgeClazz, "IP_MULTICAST_IF"); _IP_MULTICAST_IFReady = true; } return _IP_MULTICAST_IFContent; } }
        private static int _IP_MULTICAST_IFContent = default;
        private static bool _IP_MULTICAST_IFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#IP_MULTICAST_IF2"/>
        /// </summary>
        public static int IP_MULTICAST_IF2 { get { if (!_IP_MULTICAST_IF2Ready) { _IP_MULTICAST_IF2Content = SGetField<int>(LocalBridgeClazz, "IP_MULTICAST_IF2"); _IP_MULTICAST_IF2Ready = true; } return _IP_MULTICAST_IF2Content; } }
        private static int _IP_MULTICAST_IF2Content = default;
        private static bool _IP_MULTICAST_IF2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#IP_MULTICAST_LOOP"/>
        /// </summary>
        public static int IP_MULTICAST_LOOP { get { if (!_IP_MULTICAST_LOOPReady) { _IP_MULTICAST_LOOPContent = SGetField<int>(LocalBridgeClazz, "IP_MULTICAST_LOOP"); _IP_MULTICAST_LOOPReady = true; } return _IP_MULTICAST_LOOPContent; } }
        private static int _IP_MULTICAST_LOOPContent = default;
        private static bool _IP_MULTICAST_LOOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#IP_TOS"/>
        /// </summary>
        public static int IP_TOS { get { if (!_IP_TOSReady) { _IP_TOSContent = SGetField<int>(LocalBridgeClazz, "IP_TOS"); _IP_TOSReady = true; } return _IP_TOSContent; } }
        private static int _IP_TOSContent = default;
        private static bool _IP_TOSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_BINDADDR"/>
        /// </summary>
        public static int SO_BINDADDR { get { if (!_SO_BINDADDRReady) { _SO_BINDADDRContent = SGetField<int>(LocalBridgeClazz, "SO_BINDADDR"); _SO_BINDADDRReady = true; } return _SO_BINDADDRContent; } }
        private static int _SO_BINDADDRContent = default;
        private static bool _SO_BINDADDRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_BROADCAST"/>
        /// </summary>
        public static int SO_BROADCAST { get { if (!_SO_BROADCASTReady) { _SO_BROADCASTContent = SGetField<int>(LocalBridgeClazz, "SO_BROADCAST"); _SO_BROADCASTReady = true; } return _SO_BROADCASTContent; } }
        private static int _SO_BROADCASTContent = default;
        private static bool _SO_BROADCASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_KEEPALIVE"/>
        /// </summary>
        public static int SO_KEEPALIVE { get { if (!_SO_KEEPALIVEReady) { _SO_KEEPALIVEContent = SGetField<int>(LocalBridgeClazz, "SO_KEEPALIVE"); _SO_KEEPALIVEReady = true; } return _SO_KEEPALIVEContent; } }
        private static int _SO_KEEPALIVEContent = default;
        private static bool _SO_KEEPALIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_LINGER"/>
        /// </summary>
        public static int SO_LINGER { get { if (!_SO_LINGERReady) { _SO_LINGERContent = SGetField<int>(LocalBridgeClazz, "SO_LINGER"); _SO_LINGERReady = true; } return _SO_LINGERContent; } }
        private static int _SO_LINGERContent = default;
        private static bool _SO_LINGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_OOBINLINE"/>
        /// </summary>
        public static int SO_OOBINLINE { get { if (!_SO_OOBINLINEReady) { _SO_OOBINLINEContent = SGetField<int>(LocalBridgeClazz, "SO_OOBINLINE"); _SO_OOBINLINEReady = true; } return _SO_OOBINLINEContent; } }
        private static int _SO_OOBINLINEContent = default;
        private static bool _SO_OOBINLINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_RCVBUF"/>
        /// </summary>
        public static int SO_RCVBUF { get { if (!_SO_RCVBUFReady) { _SO_RCVBUFContent = SGetField<int>(LocalBridgeClazz, "SO_RCVBUF"); _SO_RCVBUFReady = true; } return _SO_RCVBUFContent; } }
        private static int _SO_RCVBUFContent = default;
        private static bool _SO_RCVBUFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_REUSEADDR"/>
        /// </summary>
        public static int SO_REUSEADDR { get { if (!_SO_REUSEADDRReady) { _SO_REUSEADDRContent = SGetField<int>(LocalBridgeClazz, "SO_REUSEADDR"); _SO_REUSEADDRReady = true; } return _SO_REUSEADDRContent; } }
        private static int _SO_REUSEADDRContent = default;
        private static bool _SO_REUSEADDRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_REUSEPORT"/>
        /// </summary>
        public static int SO_REUSEPORT { get { if (!_SO_REUSEPORTReady) { _SO_REUSEPORTContent = SGetField<int>(LocalBridgeClazz, "SO_REUSEPORT"); _SO_REUSEPORTReady = true; } return _SO_REUSEPORTContent; } }
        private static int _SO_REUSEPORTContent = default;
        private static bool _SO_REUSEPORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_SNDBUF"/>
        /// </summary>
        public static int SO_SNDBUF { get { if (!_SO_SNDBUFReady) { _SO_SNDBUFContent = SGetField<int>(LocalBridgeClazz, "SO_SNDBUF"); _SO_SNDBUFReady = true; } return _SO_SNDBUFContent; } }
        private static int _SO_SNDBUFContent = default;
        private static bool _SO_SNDBUFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#SO_TIMEOUT"/>
        /// </summary>
        public static int SO_TIMEOUT { get { if (!_SO_TIMEOUTReady) { _SO_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "SO_TIMEOUT"); _SO_TIMEOUTReady = true; } return _SO_TIMEOUTContent; } }
        private static int _SO_TIMEOUTContent = default;
        private static bool _SO_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#TCP_NODELAY"/>
        /// </summary>
        public static int TCP_NODELAY { get { if (!_TCP_NODELAYReady) { _TCP_NODELAYContent = SGetField<int>(LocalBridgeClazz, "TCP_NODELAY"); _TCP_NODELAYReady = true; } return _TCP_NODELAYContent; } }
        private static int _TCP_NODELAYContent = default;
        private static bool _TCP_NODELAYReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#getOption(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public object GetOption(int arg0)
        {
            return IExecuteWithSignature("getOption", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/SocketOptions.html#setOption(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetOption(int arg0, object arg1)
        {
            IExecuteWithSignature("setOption", "(ILjava/lang/Object;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}