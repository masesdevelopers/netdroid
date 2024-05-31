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
    #region ISSLSession
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISSLSession
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SSLSession
    public partial class SSLSession : Javax.Net.Ssl.ISSLSession
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
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getApplicationBufferSize()"/> 
        /// </summary>
        public int ApplicationBufferSize
        {
            get { return IExecuteWithSignature<int>("getApplicationBufferSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getCipherSuite()"/> 
        /// </summary>
        public Java.Lang.String CipherSuite
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCipherSuite", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getCreationTime()"/> 
        /// </summary>
        public long CreationTime
        {
            get { return IExecuteWithSignature<long>("getCreationTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getId()"/> 
        /// </summary>
        public byte[] Id
        {
            get { return IExecuteWithSignatureArray<byte>("getId", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getLastAccessedTime()"/> 
        /// </summary>
        public long LastAccessedTime
        {
            get { return IExecuteWithSignature<long>("getLastAccessedTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getLocalCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] LocalCertificates
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getLocalCertificates", "()[Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getLocalPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal LocalPrincipal
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getLocalPrincipal", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getPacketBufferSize()"/> 
        /// </summary>
        public int PacketBufferSize
        {
            get { return IExecuteWithSignature<int>("getPacketBufferSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getPeerCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] PeerCertificates
        {
            get { return IExecuteWithSignatureArray<Java.Security.Cert.Certificate>("getPeerCertificates", "()[Ljava/security/cert/Certificate;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getPeerHost()"/> 
        /// </summary>
        public Java.Lang.String PeerHost
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPeerHost", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getPeerPort()"/> 
        /// </summary>
        public int PeerPort
        {
            get { return IExecuteWithSignature<int>("getPeerPort", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getPeerPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal PeerPrincipal
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getPeerPrincipal", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getProtocol()"/> 
        /// </summary>
        public Java.Lang.String Protocol
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getProtocol", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getSessionContext()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSessionContext SessionContext
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLSessionContext>("getSessionContext", "()Ljavax/net/ssl/SSLSessionContext;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getValueNames()"/> 
        /// </summary>
        public Java.Lang.String[] ValueNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getValueNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#isValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getValue", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#invalidate()"/>
        /// </summary>
        public void Invalidate()
        {
            IExecuteWithSignature("invalidate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void PutValue(Java.Lang.String arg0, object arg1)
        {
            IExecute("putValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/javax/net/ssl/SSLSession.html#removeValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveValue(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeValue", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}