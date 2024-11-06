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

namespace Java.Security.Spec
{
    #region ECParameterSpec declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/spec/ECParameterSpec.html"/>
    /// </summary>
    public partial class ECParameterSpec : Java.Security.Spec.AlgorithmParameterSpec
    {
        const string _bridgeClassName = "java.security.spec.ECParameterSpec";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ECParameterSpec() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ECParameterSpec(params object[] args) : base(args) { }
    
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

    #region ECParameterSpec implementation
    public partial class ECParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/ECParameterSpec.html#%3Cinit%3E(java.security.spec.EllipticCurve,java.security.spec.ECPoint,java.math.BigInteger,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.EllipticCurve"/></param>
        /// <param name="arg1"><see cref="Java.Security.Spec.ECPoint"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ECParameterSpec(Java.Security.Spec.EllipticCurve arg0, Java.Security.Spec.ECPoint arg1, Java.Math.BigInteger arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/java/security/spec/ECParameterSpec.html#getCofactor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCofactor()
        {
            return IExecuteWithSignature<int>("getCofactor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/ECParameterSpec.html#getOrder()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetOrder()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getOrder", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/ECParameterSpec.html#getGenerator()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.ECPoint"/></returns>
        public Java.Security.Spec.ECPoint GetGenerator()
        {
            return IExecuteWithSignature<Java.Security.Spec.ECPoint>("getGenerator", "()Ljava/security/spec/ECPoint;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/ECParameterSpec.html#getCurve()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.EllipticCurve"/></returns>
        public Java.Security.Spec.EllipticCurve GetCurve()
        {
            return IExecuteWithSignature<Java.Security.Spec.EllipticCurve>("getCurve", "()Ljava/security/spec/EllipticCurve;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}