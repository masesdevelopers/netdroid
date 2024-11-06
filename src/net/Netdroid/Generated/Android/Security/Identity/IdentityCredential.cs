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

namespace Android.Security.Identity
{
    #region IdentityCredential declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html"/>
    /// </summary>
    public partial class IdentityCredential : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IdentityCredential>
    {
        const string _bridgeClassName = "android.security.identity.IdentityCredential";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("IdentityCredential class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IdentityCredential() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("IdentityCredential class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IdentityCredential(params object[] args) : base(args) { }
    
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

    #region IdentityCredential implementation
    public partial class IdentityCredential
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
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#getEntries(byte[],java.util.Map,byte[],byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <returns><see cref="Android.Security.Identity.ResultData"/></returns>
        /// <exception cref="Android.Security.Identity.EphemeralPublicKeyNotFoundException"/>
        /// <exception cref="Android.Security.Identity.InvalidReaderSignatureException"/>
        /// <exception cref="Android.Security.Identity.InvalidRequestMessageException"/>
        /// <exception cref="Android.Security.Identity.NoAuthenticationKeyAvailableException"/>
        /// <exception cref="Android.Security.Identity.SessionTranscriptMismatchException"/>
        [global::System.Obsolete()]
        public Android.Security.Identity.ResultData GetEntries(byte[] arg0, Java.Util.Map<Java.Lang.String, Java.Util.Collection<Java.Lang.String>> arg1, byte[] arg2, byte[] arg3)
        {
            return IExecuteWithSignature<Android.Security.Identity.ResultData>("getEntries", "([BLjava/util/Map;[B[B)Landroid/security/identity/ResultData;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#decryptMessageFromReader(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Android.Security.Identity.MessageDecryptionException"/>
        [global::System.Obsolete()]
        public byte[] DecryptMessageFromReader(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("decryptMessageFromReader", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#encryptMessageToReader(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        [global::System.Obsolete()]
        public byte[] EncryptMessageToReader(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("encryptMessageToReader", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#getAuthenticationDataUsageCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int[] GetAuthenticationDataUsageCount()
        {
            return IExecuteWithSignatureArray<int>("getAuthenticationDataUsageCount", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#createEphemeralKeyPair()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.KeyPair"/></returns>
        [global::System.Obsolete()]
        public Java.Security.KeyPair CreateEphemeralKeyPair()
        {
            return IExecuteWithSignature<Java.Security.KeyPair>("createEphemeralKeyPair", "()Ljava/security/KeyPair;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#getAuthKeysNeedingCertification()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Security.Cert.X509Certificate> GetAuthKeysNeedingCertification()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Security.Cert.X509Certificate>>("getAuthKeysNeedingCertification", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#getCredentialKeyCertificateChain()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Security.Cert.X509Certificate> GetCredentialKeyCertificateChain()
        {
            return IExecuteWithSignature<Java.Util.Collection<Java.Security.Cert.X509Certificate>>("getCredentialKeyCertificateChain", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#setAllowUsingExhaustedKeys(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetAllowUsingExhaustedKeys(bool arg0)
        {
            IExecuteWithSignature("setAllowUsingExhaustedKeys", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#setAvailableAuthenticationKeys(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetAvailableAuthenticationKeys(int arg0, int arg1)
        {
            IExecuteWithSignature("setAvailableAuthenticationKeys", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#setReaderEphemeralPublicKey(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        [global::System.Obsolete()]
        public void SetReaderEphemeralPublicKey(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("setReaderEphemeralPublicKey", "(Ljava/security/PublicKey;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#storeStaticAuthenticationData(java.security.cert.X509Certificate,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Android.Security.Identity.UnknownAuthenticationKeyException"/>
        [global::System.Obsolete()]
        public void StoreStaticAuthenticationData(Java.Security.Cert.X509Certificate arg0, byte[] arg1)
        {
            IExecuteWithSignature("storeStaticAuthenticationData", "(Ljava/security/cert/X509Certificate;[B)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#delete(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Delete(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("delete", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#proveOwnership(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] ProveOwnership(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("proveOwnership", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#update(android.security.identity.PersonalizationData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Security.Identity.PersonalizationData"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Update(Android.Security.Identity.PersonalizationData arg0)
        {
            return IExecuteWithSignatureArray<byte>("update", "(Landroid/security/identity/PersonalizationData;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#getAuthenticationKeyMetadata()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Security.Identity.AuthenticationKeyMetadata> GetAuthenticationKeyMetadata()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Security.Identity.AuthenticationKeyMetadata>>("getAuthenticationKeyMetadata", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#setAllowUsingExpiredKeys(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetAllowUsingExpiredKeys(bool arg0)
        {
            IExecuteWithSignature("setAllowUsingExpiredKeys", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#setAvailableAuthenticationKeys(int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public void SetAvailableAuthenticationKeys(int arg0, int arg1, long arg2)
        {
            IExecuteWithSignature("setAvailableAuthenticationKeys", "(IIJ)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredential.html#storeStaticAuthenticationData(java.security.cert.X509Certificate,java.time.Instant,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        /// <exception cref="Android.Security.Identity.UnknownAuthenticationKeyException"/>
        public void StoreStaticAuthenticationData(Java.Security.Cert.X509Certificate arg0, Java.Time.Instant arg1, byte[] arg2)
        {
            IExecuteWithSignature("storeStaticAuthenticationData", "(Ljava/security/cert/X509Certificate;Ljava/time/Instant;[B)V", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}