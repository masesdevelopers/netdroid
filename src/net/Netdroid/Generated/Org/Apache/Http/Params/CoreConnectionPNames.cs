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

namespace Org.Apache.Http.Params
{
    #region CoreConnectionPNames declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class CoreConnectionPNames : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CoreConnectionPNames>
    {
        const string _bridgeClassName = "org.apache.http.params.CoreConnectionPNames";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CoreConnectionPNames class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CoreConnectionPNames() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CoreConnectionPNames class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CoreConnectionPNames(params object[] args) : base(args) { }
    
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

    #region ICoreConnectionPNames
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICoreConnectionPNames
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region CoreConnectionPNames implementation
    public partial class CoreConnectionPNames : Org.Apache.Http.Params.ICoreConnectionPNames
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#CONNECTION_TIMEOUT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String CONNECTION_TIMEOUT { get { if (!_CONNECTION_TIMEOUTReady) { _CONNECTION_TIMEOUTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CONNECTION_TIMEOUT"); _CONNECTION_TIMEOUTReady = true; } return _CONNECTION_TIMEOUTContent; } }
        private static Java.Lang.String _CONNECTION_TIMEOUTContent = default;
        private static bool _CONNECTION_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#MAX_HEADER_COUNT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String MAX_HEADER_COUNT { get { if (!_MAX_HEADER_COUNTReady) { _MAX_HEADER_COUNTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MAX_HEADER_COUNT"); _MAX_HEADER_COUNTReady = true; } return _MAX_HEADER_COUNTContent; } }
        private static Java.Lang.String _MAX_HEADER_COUNTContent = default;
        private static bool _MAX_HEADER_COUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#MAX_LINE_LENGTH"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String MAX_LINE_LENGTH { get { if (!_MAX_LINE_LENGTHReady) { _MAX_LINE_LENGTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "MAX_LINE_LENGTH"); _MAX_LINE_LENGTHReady = true; } return _MAX_LINE_LENGTHContent; } }
        private static Java.Lang.String _MAX_LINE_LENGTHContent = default;
        private static bool _MAX_LINE_LENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#SO_LINGER"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SO_LINGER { get { if (!_SO_LINGERReady) { _SO_LINGERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SO_LINGER"); _SO_LINGERReady = true; } return _SO_LINGERContent; } }
        private static Java.Lang.String _SO_LINGERContent = default;
        private static bool _SO_LINGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#SO_TIMEOUT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SO_TIMEOUT { get { if (!_SO_TIMEOUTReady) { _SO_TIMEOUTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SO_TIMEOUT"); _SO_TIMEOUTReady = true; } return _SO_TIMEOUTContent; } }
        private static Java.Lang.String _SO_TIMEOUTContent = default;
        private static bool _SO_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#SOCKET_BUFFER_SIZE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SOCKET_BUFFER_SIZE { get { if (!_SOCKET_BUFFER_SIZEReady) { _SOCKET_BUFFER_SIZEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOCKET_BUFFER_SIZE"); _SOCKET_BUFFER_SIZEReady = true; } return _SOCKET_BUFFER_SIZEContent; } }
        private static Java.Lang.String _SOCKET_BUFFER_SIZEContent = default;
        private static bool _SOCKET_BUFFER_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#STALE_CONNECTION_CHECK"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String STALE_CONNECTION_CHECK { get { if (!_STALE_CONNECTION_CHECKReady) { _STALE_CONNECTION_CHECKContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "STALE_CONNECTION_CHECK"); _STALE_CONNECTION_CHECKReady = true; } return _STALE_CONNECTION_CHECKContent; } }
        private static Java.Lang.String _STALE_CONNECTION_CHECKContent = default;
        private static bool _STALE_CONNECTION_CHECKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/params/CoreConnectionPNames.html#TCP_NODELAY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String TCP_NODELAY { get { if (!_TCP_NODELAYReady) { _TCP_NODELAYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TCP_NODELAY"); _TCP_NODELAYReady = true; } return _TCP_NODELAYContent; } }
        private static Java.Lang.String _TCP_NODELAYContent = default;
        private static bool _TCP_NODELAYReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}