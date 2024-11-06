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

namespace Javax.Net.Ssl
{
    #region SSLSessionContext declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html"/>
    /// </summary>
    public partial class SSLSessionContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SSLSessionContext>
    {
        const string _bridgeClassName = "javax.net.ssl.SSLSessionContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SSLSessionContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SSLSessionContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SSLSessionContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SSLSessionContext(params object[] args) : base(args) { }
    
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

    #region ISSLSessionContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISSLSessionContext
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region SSLSessionContext implementation
    public partial class SSLSessionContext : Javax.Net.Ssl.ISSLSessionContext
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getSessionCacheSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSessionCacheSize()
        {
            return IExecuteWithSignature<int>("getSessionCacheSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getSessionTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSessionTimeout()
        {
            return IExecuteWithSignature<int>("getSessionTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<byte[]> GetIds()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<byte[]>>("getIds", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#getSession(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        public Javax.Net.Ssl.SSLSession GetSession(byte[] arg0)
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSession>("getSession", "([B)Ljavax/net/ssl/SSLSession;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#setSessionCacheSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetSessionCacheSize(int arg0)
        {
            IExecuteWithSignature("setSessionCacheSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionContext.html#setSessionTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetSessionTimeout(int arg0)
        {
            IExecuteWithSignature("setSessionTimeout", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}