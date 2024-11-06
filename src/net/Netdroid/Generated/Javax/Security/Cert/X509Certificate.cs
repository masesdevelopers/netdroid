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

namespace Javax.Security.Cert
{
    #region X509Certificate declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class X509Certificate : Javax.Security.Cert.Certificate
    {
        const string _bridgeClassName = "javax.security.cert.X509Certificate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("X509Certificate class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public X509Certificate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("X509Certificate class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public X509Certificate(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region X509Certificate implementation
    public partial class X509Certificate
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getInstance(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Javax.Security.Cert.X509Certificate"/></returns>
        /// <exception cref="Javax.Security.Cert.CertificateException"/>
        public static Javax.Security.Cert.X509Certificate GetInstance(byte[] arg0)
        {
            return SExecuteWithSignature<Javax.Security.Cert.X509Certificate>(LocalBridgeClazz, "getInstance", "([B)Ljavax/security/cert/X509Certificate;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getInstance(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Javax.Security.Cert.X509Certificate"/></returns>
        /// <exception cref="Javax.Security.Cert.CertificateException"/>
        public static Javax.Security.Cert.X509Certificate GetInstance(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Javax.Security.Cert.X509Certificate>(LocalBridgeClazz, "getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getSigAlgParams()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetSigAlgParams()
        {
            return IExecuteWithSignatureArray<byte>("getSigAlgParams", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getSigAlgName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSigAlgName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSigAlgName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getSigAlgOID()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSigAlgOID()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSigAlgOID", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getSerialNumber()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetSerialNumber()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getSerialNumber", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getIssuerDN()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        public Java.Security.Principal GetIssuerDN()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getIssuerDN", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getSubjectDN()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Principal"/></returns>
        public Java.Security.Principal GetSubjectDN()
        {
            return IExecuteWithSignature<Java.Security.Principal>("getSubjectDN", "()Ljava/security/Principal;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getNotAfter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetNotAfter()
        {
            return IExecuteWithSignature<Java.Util.Date>("getNotAfter", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#getNotBefore()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetNotBefore()
        {
            return IExecuteWithSignature<Java.Util.Date>("getNotBefore", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#checkValidity()"/>
        /// </summary>
        /// <exception cref="Javax.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Javax.Security.Cert.CertificateNotYetValidException"/>
        public void CheckValidity()
        {
            IExecuteWithSignature("checkValidity", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/security/cert/X509Certificate.html#checkValidity(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <exception cref="Javax.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Javax.Security.Cert.CertificateNotYetValidException"/>
        public void CheckValidity(Java.Util.Date arg0)
        {
            IExecuteWithSignature("checkValidity", "(Ljava/util/Date;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}