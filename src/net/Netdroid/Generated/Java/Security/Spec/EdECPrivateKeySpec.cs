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
    #region EdECPrivateKeySpec declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/spec/EdECPrivateKeySpec.html"/>
    /// </summary>
    public partial class EdECPrivateKeySpec : Java.Security.Spec.KeySpec
    {
        const string _bridgeClassName = "java.security.spec.EdECPrivateKeySpec";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EdECPrivateKeySpec() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EdECPrivateKeySpec(params object[] args) : base(args) { }
    
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

    #region EdECPrivateKeySpec implementation
    public partial class EdECPrivateKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/EdECPrivateKeySpec.html#%3Cinit%3E(java.security.spec.NamedParameterSpec,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.NamedParameterSpec"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public EdECPrivateKeySpec(Java.Security.Spec.NamedParameterSpec arg0, byte[] arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/java/security/spec/EdECPrivateKeySpec.html#getBytes()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetBytes()
        {
            return IExecuteWithSignatureArray<byte>("getBytes", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/EdECPrivateKeySpec.html#getParams()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Spec.NamedParameterSpec"/></returns>
        public Java.Security.Spec.NamedParameterSpec GetParams()
        {
            return IExecuteWithSignature<Java.Security.Spec.NamedParameterSpec>("getParams", "()Ljava/security/spec/NamedParameterSpec;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}