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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region Signature declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/Signature.html"/>
    /// </summary>
    public partial class Signature : Java.Security.SignatureSpi
    {
        const string _bridgeClassName = "java.security.Signature";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Signature class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Signature() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Signature class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Signature(params object[] args) : base(args) { }

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

    #region Signature implementation
    public partial class Signature
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Signature"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.Signature GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Security.Signature>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.Signature"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Signature GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Java.Security.Signature>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Signature"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Signature GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.Signature>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljava/security/Signature;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#verify(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Security.SignatureException"/>
        public bool Verify(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<bool>("verify", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#verify(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Security.SignatureException"/>
        public bool Verify(byte[] arg0)
        {
            return IExecuteWithSignature<bool>("verify", "([B)Z", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#sign()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Security.SignatureException"/>
        public byte[] Sign()
        {
            return IExecuteWithSignatureArray<byte>("sign", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#sign(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Security.SignatureException"/>
        public int Sign(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("sign", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Security.InvalidParameterException"/>
        [global::System.Obsolete()]
        public object GetParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#getParameters()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        public Java.Security.AlgorithmParameters GetParameters()
        {
            return IExecuteWithSignature<Java.Security.AlgorithmParameters>("getParameters", "()Ljava/security/AlgorithmParameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#initSign(java.security.PrivateKey,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivateKey"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void InitSign(Java.Security.PrivateKey arg0, Java.Security.SecureRandom arg1)
        {
            IExecute("initSign", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#initSign(java.security.PrivateKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivateKey"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void InitSign(Java.Security.PrivateKey arg0)
        {
            IExecuteWithSignature("initSign", "(Ljava/security/PrivateKey;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#initVerify(java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void InitVerify(Java.Security.Cert.Certificate arg0)
        {
            IExecuteWithSignature("initVerify", "(Ljava/security/cert/Certificate;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#initVerify(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void InitVerify(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("initVerify", "(Ljava/security/PublicKey;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#setParameter(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Security.InvalidParameterException"/>
        [global::System.Obsolete()]
        public void SetParameter(Java.Lang.String arg0, object arg1)
        {
            IExecute("setParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#setParameter(java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void SetParameter(Java.Security.Spec.AlgorithmParameterSpec arg0)
        {
            IExecuteWithSignature("setParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#update(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Update(byte arg0)
        {
            IExecuteWithSignature("update", "(B)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#update(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Update(byte[] arg0, int arg1, int arg2)
        {
            IExecute("update", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#update(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Update(byte[] arg0)
        {
            IExecuteWithSignature("update", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Signature.html#update(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <exception cref="Java.Security.SignatureException"/>
        public void Update(Java.Nio.ByteBuffer arg0)
        {
            IExecuteWithSignature("update", "(Ljava/nio/ByteBuffer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}