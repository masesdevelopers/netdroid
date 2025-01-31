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
    #region Identity declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/Identity.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class Identity : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Identity>
    {
        const string _bridgeClassName = "java.security.Identity";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Identity class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Identity() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Identity class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Identity(params object[] args) : base(args) { }
    
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

    #region Identity implementation
    public partial class Identity : Java.Security.IPrincipal, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#%3Cinit%3E(java.lang.String,java.security.IdentityScope)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.IdentityScope"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public Identity(Java.Lang.String arg0, Java.Security.IdentityScope arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public Identity(Java.Lang.String arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Identity"/> to <see cref="Java.Security.Principal"/>
        /// </summary>
        public static implicit operator Java.Security.Principal(Java.Security.Identity t) => t.Cast<Java.Security.Principal>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Identity"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Security.Identity t) => t.Cast<Java.Io.Serializable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#getScope()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.IdentityScope"/></returns>
        public Java.Security.IdentityScope GetScope()
        {
            return IExecuteWithSignature<Java.Security.IdentityScope>("getScope", "()Ljava/security/IdentityScope;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#getInfo()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetInfo()
        {
            return IExecuteWithSignature<Java.Lang.String>("getInfo", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#toString(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToString(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toString", "(Z)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#certificates()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Certificate"/></returns>
        public Java.Security.Certificate[] Certificates()
        {
            return IExecuteWithSignatureArray<Java.Security.Certificate>("certificates", "()[Ljava/security/Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#getPublicKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.PublicKey"/></returns>
        public Java.Security.PublicKey GetPublicKey()
        {
            return IExecuteWithSignature<Java.Security.PublicKey>("getPublicKey", "()Ljava/security/PublicKey;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#addCertificate(java.security.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Certificate"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public void AddCertificate(Java.Security.Certificate arg0)
        {
            IExecuteWithSignature("addCertificate", "(Ljava/security/Certificate;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#removeCertificate(java.security.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Certificate"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public void RemoveCertificate(Java.Security.Certificate arg0)
        {
            IExecuteWithSignature("removeCertificate", "(Ljava/security/Certificate;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#setInfo(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetInfo(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setInfo", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/Identity.html#setPublicKey(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <exception cref="Java.Security.KeyManagementException"/>
        public void SetPublicKey(Java.Security.PublicKey arg0)
        {
            IExecuteWithSignature("setPublicKey", "(Ljava/security/PublicKey;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}