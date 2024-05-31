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

namespace Org.Apache.Http.Conn.Ssl
{
    #region SSLSocketFactory
    public partial class SSLSocketFactory
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#%3Cinit%3E(java.lang.String,java.security.KeyStore,java.lang.String,java.security.KeyStore,java.security.SecureRandom,org.apache.http.conn.scheme.HostNameResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.KeyStore"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Security.KeyStore"/></param>
        /// <param name="arg4"><see cref="Java.Security.SecureRandom"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Http.Conn.Scheme.HostNameResolver"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        [System.Obsolete()]
        public SSLSocketFactory(Java.Lang.String arg0, Java.Security.KeyStore arg1, Java.Lang.String arg2, Java.Security.KeyStore arg3, Java.Security.SecureRandom arg4, Org.Apache.Http.Conn.Scheme.HostNameResolver arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#%3Cinit%3E(java.security.KeyStore,java.lang.String,java.security.KeyStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Security.KeyStore"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        [System.Obsolete()]
        public SSLSocketFactory(Java.Security.KeyStore arg0, Java.Lang.String arg1, Java.Security.KeyStore arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#%3Cinit%3E(java.security.KeyStore,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        [System.Obsolete()]
        public SSLSocketFactory(Java.Security.KeyStore arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#%3Cinit%3E(java.security.KeyStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        [System.Obsolete()]
        public SSLSocketFactory(Java.Security.KeyStore arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#SSL"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String SSL { get { if (!_SSLReady) { _SSLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSL"); _SSLReady = true; } return _SSLContent; } }
        private static Java.Lang.String _SSLContent = default;
        private static bool _SSLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#SSLV2"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String SSLV2 { get { if (!_SSLV2Ready) { _SSLV2Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "SSLV2"); _SSLV2Ready = true; } return _SSLV2Content; } }
        private static Java.Lang.String _SSLV2Content = default;
        private static bool _SSLV2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#TLS"/>
        /// </summary>
        [System.Obsolete()]
        public static Java.Lang.String TLS { get { if (!_TLSReady) { _TLSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TLS"); _TLSReady = true; } return _TLSContent; } }
        private static Java.Lang.String _TLSContent = default;
        private static bool _TLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#ALLOW_ALL_HOSTNAME_VERIFIER"/>
        /// </summary>
        [System.Obsolete()]
        public static Org.Apache.Http.Conn.Ssl.X509HostnameVerifier ALLOW_ALL_HOSTNAME_VERIFIER { get { if (!_ALLOW_ALL_HOSTNAME_VERIFIERReady) { _ALLOW_ALL_HOSTNAME_VERIFIERContent = SGetField<Org.Apache.Http.Conn.Ssl.X509HostnameVerifier>(LocalBridgeClazz, "ALLOW_ALL_HOSTNAME_VERIFIER"); _ALLOW_ALL_HOSTNAME_VERIFIERReady = true; } return _ALLOW_ALL_HOSTNAME_VERIFIERContent; } }
        private static Org.Apache.Http.Conn.Ssl.X509HostnameVerifier _ALLOW_ALL_HOSTNAME_VERIFIERContent = default;
        private static bool _ALLOW_ALL_HOSTNAME_VERIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#BROWSER_COMPATIBLE_HOSTNAME_VERIFIER"/>
        /// </summary>
        [System.Obsolete()]
        public static Org.Apache.Http.Conn.Ssl.X509HostnameVerifier BROWSER_COMPATIBLE_HOSTNAME_VERIFIER { get { if (!_BROWSER_COMPATIBLE_HOSTNAME_VERIFIERReady) { _BROWSER_COMPATIBLE_HOSTNAME_VERIFIERContent = SGetField<Org.Apache.Http.Conn.Ssl.X509HostnameVerifier>(LocalBridgeClazz, "BROWSER_COMPATIBLE_HOSTNAME_VERIFIER"); _BROWSER_COMPATIBLE_HOSTNAME_VERIFIERReady = true; } return _BROWSER_COMPATIBLE_HOSTNAME_VERIFIERContent; } }
        private static Org.Apache.Http.Conn.Ssl.X509HostnameVerifier _BROWSER_COMPATIBLE_HOSTNAME_VERIFIERContent = default;
        private static bool _BROWSER_COMPATIBLE_HOSTNAME_VERIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#STRICT_HOSTNAME_VERIFIER"/>
        /// </summary>
        [System.Obsolete()]
        public static Org.Apache.Http.Conn.Ssl.X509HostnameVerifier STRICT_HOSTNAME_VERIFIER { get { if (!_STRICT_HOSTNAME_VERIFIERReady) { _STRICT_HOSTNAME_VERIFIERContent = SGetField<Org.Apache.Http.Conn.Ssl.X509HostnameVerifier>(LocalBridgeClazz, "STRICT_HOSTNAME_VERIFIER"); _STRICT_HOSTNAME_VERIFIERReady = true; } return _STRICT_HOSTNAME_VERIFIERContent; } }
        private static Org.Apache.Http.Conn.Ssl.X509HostnameVerifier _STRICT_HOSTNAME_VERIFIERContent = default;
        private static bool _STRICT_HOSTNAME_VERIFIERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#getSocketFactory()"/> 
        /// </summary>
        [System.Obsolete()]
        public static Org.Apache.Http.Conn.Ssl.SSLSocketFactory SocketFactory
        {
            get { return SExecuteWithSignature<Org.Apache.Http.Conn.Ssl.SSLSocketFactory>(LocalBridgeClazz, "getSocketFactory", "()Lorg/apache/http/conn/ssl/SSLSocketFactory;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#getHostnameVerifier()"/> <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#setHostnameVerifier(org.apache.http.conn.ssl.X509HostnameVerifier)"/>
        /// </summary>
        [System.Obsolete()]
        public Org.Apache.Http.Conn.Ssl.X509HostnameVerifier HostnameVerifier
        {
            get { return IExecuteWithSignature<Org.Apache.Http.Conn.Ssl.X509HostnameVerifier>("getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;"); } set { IExecuteWithSignature("setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#isSecure(java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        [System.Obsolete()]
        public bool IsSecure(Java.Net.Socket arg0)
        {
            return IExecuteWithSignature<bool>("isSecure", "(Ljava/net/Socket;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#connectSocket(java.net.Socket,java.lang.String,int,java.net.InetAddress,int,org.apache.http.params.HttpParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Org.Apache.Http.Params.HttpParams"/></param>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [System.Obsolete()]
        public Java.Net.Socket ConnectSocket(Java.Net.Socket arg0, Java.Lang.String arg1, int arg2, Java.Net.InetAddress arg3, int arg4, Org.Apache.Http.Params.HttpParams arg5)
        {
            return IExecute<Java.Net.Socket>("connectSocket", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#createSocket()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [System.Obsolete()]
        public Java.Net.Socket CreateSocket()
        {
            return IExecuteWithSignature<Java.Net.Socket>("createSocket", "()Ljava/net/Socket;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/apache/http/conn/ssl/SSLSocketFactory.html#createSocket(java.net.Socket,java.lang.String,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Net.UnknownHostException"/>
        [System.Obsolete()]
        public Java.Net.Socket CreateSocket(Java.Net.Socket arg0, Java.Lang.String arg1, int arg2, bool arg3)
        {
            return IExecute<Java.Net.Socket>("createSocket", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}