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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto
{
    #region KeyAgreement
    public partial class KeyAgreement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.KeyAgreement"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Crypto.KeyAgreement GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Crypto.KeyAgreement>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Crypto.KeyAgreement"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.KeyAgreement GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Crypto.KeyAgreement>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.KeyAgreement"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.KeyAgreement GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Crypto.KeyAgreement>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyAgreement;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#generateSecret()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public byte[] GenerateSecret()
        {
            return IExecuteWithSignatureArray<byte>("generateSecret", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#generateSecret(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        public int GenerateSecret(byte[] arg0, int arg1)
        {
            return IExecute<int>("generateSecret", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#doPhase(java.security.Key,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Security.Key"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public Java.Security.Key DoPhase(Java.Security.Key arg0, bool arg1)
        {
            return IExecute<Java.Security.Key>("doPhase", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#generateSecret(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKey"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Javax.Crypto.SecretKey GenerateSecret(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Crypto.SecretKey>("generateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#init(java.security.Key,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(Java.Security.Key arg0, Java.Security.SecureRandom arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#init(java.security.Key,java.security.spec.AlgorithmParameterSpec,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(Java.Security.Key arg0, Java.Security.Spec.AlgorithmParameterSpec arg1, Java.Security.SecureRandom arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#init(java.security.Key,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(Java.Security.Key arg0, Java.Security.Spec.AlgorithmParameterSpec arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/KeyAgreement.html#init(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(Java.Security.Key arg0)
        {
            IExecuteWithSignature("init", "(Ljava/security/Key;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}