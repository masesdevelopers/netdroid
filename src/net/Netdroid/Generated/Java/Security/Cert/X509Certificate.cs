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

namespace Java.Security.Cert
{
    #region X509Certificate
    public partial class X509Certificate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509Certificate"/> to <see cref="Java.Security.Cert.X509Extension"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.X509Extension(Java.Security.Cert.X509Certificate t) => t.Cast<Java.Security.Cert.X509Extension>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getBasicConstraints()"/> 
        /// </summary>
        public int BasicConstraints
        {
            get { return IExecuteWithSignature<int>("getBasicConstraints", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getExtendedKeyUsage()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> ExtendedKeyUsage
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getExtendedKeyUsage", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getIssuerAlternativeNames()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Util.List<object>> IssuerAlternativeNames
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getIssuerAlternativeNames", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getIssuerDN()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Security.Principal IssuerDN
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getIssuerDN", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getIssuerUniqueID()"/> 
        /// </summary>
        public bool[] IssuerUniqueID
        {
            get { return IExecuteWithSignatureArray<bool>("getIssuerUniqueID", "()[Z"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getIssuerX500Principal()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal IssuerX500Principal
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getKeyUsage()"/> 
        /// </summary>
        public bool[] KeyUsage
        {
            get { return IExecuteWithSignatureArray<bool>("getKeyUsage", "()[Z"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getNotAfter()"/> 
        /// </summary>
        public Java.Util.Date NotAfter
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getNotAfter", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getNotBefore()"/> 
        /// </summary>
        public Java.Util.Date NotBefore
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getNotBefore", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSerialNumber()"/> 
        /// </summary>
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getSerialNumber", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSigAlgName()"/> 
        /// </summary>
        public Java.Lang.String SigAlgName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSigAlgName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSigAlgOID()"/> 
        /// </summary>
        public Java.Lang.String SigAlgOID
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSigAlgOID", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSigAlgParams()"/> 
        /// </summary>
        public byte[] SigAlgParams
        {
            get { return IExecuteWithSignatureArray<byte>("getSigAlgParams", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSignature()"/> 
        /// </summary>
        public byte[] Signature
        {
            get { return IExecuteWithSignatureArray<byte>("getSignature", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSubjectAlternativeNames()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Util.List<object>> SubjectAlternativeNames
        {
            get { return IExecuteWithSignature<Java.Util.Collection<Java.Util.List<object>>>("getSubjectAlternativeNames", "()Ljava/util/Collection;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSubjectDN()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Security.Principal SubjectDN
        {
            get { return IExecuteWithSignature<Java.Security.Principal>("getSubjectDN", "()Ljava/security/Principal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSubjectUniqueID()"/> 
        /// </summary>
        public bool[] SubjectUniqueID
        {
            get { return IExecuteWithSignatureArray<bool>("getSubjectUniqueID", "()[Z"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getSubjectX500Principal()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal SubjectX500Principal
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getTBSCertificate()"/> 
        /// </summary>
        public byte[] TBSCertificate
        {
            get { return IExecuteWithSignatureArray<byte>("getTBSCertificate", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#getVersion()"/> 
        /// </summary>
        public int Version
        {
            get { return IExecuteWithSignature<int>("getVersion", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#checkValidity()"/>
        /// </summary>
        /// <exception cref="Java.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Java.Security.Cert.CertificateNotYetValidException"/>
        public void CheckValidity()
        {
            IExecuteWithSignature("checkValidity", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/cert/X509Certificate.html#checkValidity(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <exception cref="Java.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Java.Security.Cert.CertificateNotYetValidException"/>
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