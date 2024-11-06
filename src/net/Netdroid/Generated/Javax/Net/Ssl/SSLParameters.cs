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
    #region SSLParameters declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html"/>
    /// </summary>
    public partial class SSLParameters : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SSLParameters>
    {
        const string _bridgeClassName = "javax.net.ssl.SSLParameters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SSLParameters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SSLParameters(params object[] args) : base(args) { }
    
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

    #region SSLParameters implementation
    public partial class SSLParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#%3Cinit%3E(java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public SSLParameters(Java.Lang.String[] arg0, Java.Lang.String[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public SSLParameters(Java.Lang.String[] arg0)
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getEnableRetransmissions()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetEnableRetransmissions()
        {
            return IExecuteWithSignature<bool>("getEnableRetransmissions", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getNeedClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetNeedClientAuth()
        {
            return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getWantClientAuth()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetWantClientAuth()
        {
            return IExecuteWithSignature<bool>("getWantClientAuth", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getUseCipherSuitesOrder()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseCipherSuitesOrder()
        {
            return IExecuteWithSignature<bool>("getUseCipherSuitesOrder", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getSNIMatchers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Javax.Net.Ssl.SNIMatcher> GetSNIMatchers()
        {
            return IExecuteWithSignature<Java.Util.Collection<Javax.Net.Ssl.SNIMatcher>>("getSNIMatchers", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getServerNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Javax.Net.Ssl.SNIServerName> GetServerNames()
        {
            return IExecuteWithSignature<Java.Util.List<Javax.Net.Ssl.SNIServerName>>("getServerNames", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setServerNames(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void SetServerNames(Java.Util.List<Javax.Net.Ssl.SNIServerName> arg0)
        {
            IExecuteWithSignature("setServerNames", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setSNIMatchers(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void SetSNIMatchers(Java.Util.Collection<Javax.Net.Ssl.SNIMatcher> arg0)
        {
            IExecuteWithSignature("setSNIMatchers", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setUseCipherSuitesOrder(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseCipherSuitesOrder(bool arg0)
        {
            IExecuteWithSignature("setUseCipherSuitesOrder", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getMaximumPacketSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaximumPacketSize()
        {
            return IExecuteWithSignature<int>("getMaximumPacketSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getEndpointIdentificationAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEndpointIdentificationAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEndpointIdentificationAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getApplicationProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetApplicationProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getApplicationProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getCipherSuites()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetCipherSuites()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getCipherSuites", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getProtocols()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetProtocols()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getProtocols", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#getAlgorithmConstraints()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.AlgorithmConstraints"/></returns>
        public Java.Security.AlgorithmConstraints GetAlgorithmConstraints()
        {
            return IExecuteWithSignature<Java.Security.AlgorithmConstraints>("getAlgorithmConstraints", "()Ljava/security/AlgorithmConstraints;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setAlgorithmConstraints(java.security.AlgorithmConstraints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.AlgorithmConstraints"/></param>
        public void SetAlgorithmConstraints(Java.Security.AlgorithmConstraints arg0)
        {
            IExecuteWithSignature("setAlgorithmConstraints", "(Ljava/security/AlgorithmConstraints;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setApplicationProtocols(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetApplicationProtocols(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setApplicationProtocols", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setCipherSuites(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetCipherSuites(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setCipherSuites", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setEnableRetransmissions(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnableRetransmissions(bool arg0)
        {
            IExecuteWithSignature("setEnableRetransmissions", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setEndpointIdentificationAlgorithm(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEndpointIdentificationAlgorithm(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setEndpointIdentificationAlgorithm", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setMaximumPacketSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaximumPacketSize(int arg0)
        {
            IExecuteWithSignature("setMaximumPacketSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNeedClientAuth(bool arg0)
        {
            IExecuteWithSignature("setNeedClientAuth", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setProtocols(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetProtocols(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setProtocols", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLParameters.html#setWantClientAuth(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWantClientAuth(bool arg0)
        {
            IExecuteWithSignature("setWantClientAuth", "(Z)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}