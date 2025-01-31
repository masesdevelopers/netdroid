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

namespace Java.Security
{
    #region AlgorithmParameterGenerator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html"/>
    /// </summary>
    public partial class AlgorithmParameterGenerator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AlgorithmParameterGenerator>
    {
        const string _bridgeClassName = "java.security.AlgorithmParameterGenerator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AlgorithmParameterGenerator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AlgorithmParameterGenerator(params object[] args) : base(args) { }
    
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

    #region AlgorithmParameterGenerator implementation
    public partial class AlgorithmParameterGenerator
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameterGenerator"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.AlgorithmParameterGenerator GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Security.AlgorithmParameterGenerator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameterGenerator"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.AlgorithmParameterGenerator GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecuteWithSignature<Java.Security.AlgorithmParameterGenerator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameterGenerator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.AlgorithmParameterGenerator"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.AlgorithmParameterGenerator GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Security.AlgorithmParameterGenerator>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#generateParameters()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.AlgorithmParameters"/></returns>
        public Java.Security.AlgorithmParameters GenerateParameters()
        {
            return IExecuteWithSignature<Java.Security.AlgorithmParameters>("generateParameters", "()Ljava/security/AlgorithmParameters;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#init(int,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandom"/></param>
        public void Init(int arg0, Java.Security.SecureRandom arg1)
        {
            IExecuteWithSignature("init", "(ILjava/security/SecureRandom;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#init(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Init(int arg0)
        {
            IExecuteWithSignature("init", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#init(java.security.spec.AlgorithmParameterSpec,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg1"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(Java.Security.Spec.AlgorithmParameterSpec arg0, Java.Security.SecureRandom arg1)
        {
            IExecuteWithSignature("init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/AlgorithmParameterGenerator.html#init(java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(Java.Security.Spec.AlgorithmParameterSpec arg0)
        {
            IExecuteWithSignature("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}