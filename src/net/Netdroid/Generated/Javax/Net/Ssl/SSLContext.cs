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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region SSLContext
    public partial class SSLContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLContext"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Net.Ssl.SSLContext GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Net.Ssl.SSLContext>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLContext"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Net.Ssl.SSLContext GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Net.Ssl.SSLContext>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLContext"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Net.Ssl.SSLContext GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Net.Ssl.SSLContext>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/SSLContext;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getDefault()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLContext"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Net.Ssl.SSLContext GetDefault()
        {
            return SExecute<Javax.Net.Ssl.SSLContext>(LocalBridgeClazz, "getDefault");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#setDefault(javax.net.ssl.SSLContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLContext"/></param>
        public static void SetDefault(Javax.Net.Ssl.SSLContext arg0)
        {
            SExecute(LocalBridgeClazz, "setDefault", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getProtocol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetProtocol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProtocol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#createSSLEngine()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngine"/></returns>
        public Javax.Net.Ssl.SSLEngine CreateSSLEngine()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLEngine>("createSSLEngine", "()Ljavax/net/ssl/SSLEngine;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#createSSLEngine(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngine"/></returns>
        public Javax.Net.Ssl.SSLEngine CreateSSLEngine(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngine>("createSSLEngine", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getDefaultSSLParameters()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLParameters"/></returns>
        public Javax.Net.Ssl.SSLParameters GetDefaultSSLParameters()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getDefaultSSLParameters", "()Ljavax/net/ssl/SSLParameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getSupportedSSLParameters()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLParameters"/></returns>
        public Javax.Net.Ssl.SSLParameters GetSupportedSSLParameters()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getSupportedSSLParameters", "()Ljavax/net/ssl/SSLParameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getServerSocketFactory()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLServerSocketFactory"/></returns>
        public Javax.Net.Ssl.SSLServerSocketFactory GetServerSocketFactory()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLServerSocketFactory>("getServerSocketFactory", "()Ljavax/net/ssl/SSLServerSocketFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getClientSessionContext()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSessionContext"/></returns>
        public Javax.Net.Ssl.SSLSessionContext GetClientSessionContext()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSessionContext>("getClientSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getServerSessionContext()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSessionContext"/></returns>
        public Javax.Net.Ssl.SSLSessionContext GetServerSessionContext()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSessionContext>("getServerSessionContext", "()Ljavax/net/ssl/SSLSessionContext;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#getSocketFactory()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLSocketFactory"/></returns>
        public Javax.Net.Ssl.SSLSocketFactory GetSocketFactory()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLSocketFactory>("getSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLContext.html#init(javax.net.ssl.KeyManager[],javax.net.ssl.TrustManager[],java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.KeyManager"/></param>
        /// <param name="arg1"><see cref="Javax.Net.Ssl.TrustManager"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public void Init(Javax.Net.Ssl.KeyManager[] arg0, Javax.Net.Ssl.TrustManager[] arg1, Java.Security.SecureRandom arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}