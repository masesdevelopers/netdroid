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

namespace Java.Security.Cert
{
    #region PKIXBuilderParameters declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/cert/PKIXBuilderParameters.html"/>
    /// </summary>
    public partial class PKIXBuilderParameters : Java.Security.Cert.PKIXParameters
    {
        const string _bridgeClassName = "java.security.cert.PKIXBuilderParameters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PKIXBuilderParameters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PKIXBuilderParameters(params object[] args) : base(args) { }
    
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

    #region PKIXBuilderParameters implementation
    public partial class PKIXBuilderParameters
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXBuilderParameters.html#%3Cinit%3E(java.security.KeyStore,java.security.cert.CertSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.CertSelector"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXBuilderParameters(Java.Security.KeyStore arg0, Java.Security.Cert.CertSelector arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXBuilderParameters.html#%3Cinit%3E(java.util.Set,java.security.cert.CertSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.CertSelector"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXBuilderParameters(Java.Util.Set<Java.Security.Cert.TrustAnchor> arg0, Java.Security.Cert.CertSelector arg1)
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
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXBuilderParameters.html#getMaxPathLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxPathLength()
        {
            return IExecuteWithSignature<int>("getMaxPathLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/cert/PKIXBuilderParameters.html#setMaxPathLength(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxPathLength(int arg0)
        {
            IExecuteWithSignature("setMaxPathLength", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}