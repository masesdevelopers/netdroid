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
    #region StandardProtocolFamily declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/net/StandardProtocolFamily.html"/>
    /// </summary>
    public partial class StandardProtocolFamily : Java.Lang.Enum<Java.Net.StandardProtocolFamily>
    {
        const string _bridgeClassName = "java.net.StandardProtocolFamily";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StandardProtocolFamily() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StandardProtocolFamily(params object[] args) : base(args) { }
    
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

    #region StandardProtocolFamily implementation
    public partial class StandardProtocolFamily
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Net.StandardProtocolFamily"/> to <see cref="Java.Net.ProtocolFamily"/>
        /// </summary>
        public static implicit operator Java.Net.ProtocolFamily(Java.Net.StandardProtocolFamily t) => t.Cast<Java.Net.ProtocolFamily>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/StandardProtocolFamily.html#INET"/>
        /// </summary>
        public static Java.Net.StandardProtocolFamily INET { get { if (!_INETReady) { _INETContent = SGetField<Java.Net.StandardProtocolFamily>(LocalBridgeClazz, "INET"); _INETReady = true; } return _INETContent; } }
        private static Java.Net.StandardProtocolFamily _INETContent = default;
        private static bool _INETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/StandardProtocolFamily.html#INET6"/>
        /// </summary>
        public static Java.Net.StandardProtocolFamily INET6 { get { if (!_INET6Ready) { _INET6Content = SGetField<Java.Net.StandardProtocolFamily>(LocalBridgeClazz, "INET6"); _INET6Ready = true; } return _INET6Content; } }
        private static Java.Net.StandardProtocolFamily _INET6Content = default;
        private static bool _INET6Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/StandardProtocolFamily.html#UNIX"/>
        /// </summary>
        public static Java.Net.StandardProtocolFamily UNIX { get { if (!_UNIXReady) { _UNIXContent = SGetField<Java.Net.StandardProtocolFamily>(LocalBridgeClazz, "UNIX"); _UNIXReady = true; } return _UNIXContent; } }
        private static Java.Net.StandardProtocolFamily _UNIXContent = default;
        private static bool _UNIXReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/StandardProtocolFamily.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.StandardProtocolFamily"/></returns>
        public static Java.Net.StandardProtocolFamily ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Net.StandardProtocolFamily>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/net/StandardProtocolFamily;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/StandardProtocolFamily.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.StandardProtocolFamily"/></returns>
        public static Java.Net.StandardProtocolFamily[] Values()
        {
            return SExecuteWithSignatureArray<Java.Net.StandardProtocolFamily>(LocalBridgeClazz, "values", "()[Ljava/net/StandardProtocolFamily;");
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}