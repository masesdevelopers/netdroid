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
    #region DSAPublicKeySpec declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/spec/DSAPublicKeySpec.html"/>
    /// </summary>
    public partial class DSAPublicKeySpec : Java.Security.Spec.KeySpec
    {
        const string _bridgeClassName = "java.security.spec.DSAPublicKeySpec";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DSAPublicKeySpec() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DSAPublicKeySpec(params object[] args) : base(args) { }
    
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

    #region DSAPublicKeySpec implementation
    public partial class DSAPublicKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAPublicKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        public DSAPublicKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3)
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
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAPublicKeySpec.html#getG()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetG()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getG", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAPublicKeySpec.html#getP()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetP()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getP", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAPublicKeySpec.html#getQ()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetQ()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getQ", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/DSAPublicKeySpec.html#getY()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger GetY()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("getY", "()Ljava/math/BigInteger;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}