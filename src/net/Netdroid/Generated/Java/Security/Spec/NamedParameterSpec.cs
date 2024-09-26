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

namespace Java.Security.Spec
{
    #region NamedParameterSpec declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/security/spec/NamedParameterSpec.html"/>
    /// </summary>
    public partial class NamedParameterSpec : Java.Security.Spec.AlgorithmParameterSpec
    {
        const string _bridgeClassName = "java.security.spec.NamedParameterSpec";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public NamedParameterSpec() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public NamedParameterSpec(params object[] args) : base(args) { }

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

    #region NamedParameterSpec implementation
    public partial class NamedParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/NamedParameterSpec.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public NamedParameterSpec(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/NamedParameterSpec.html#ED25519"/>
        /// </summary>
        public static Java.Security.Spec.NamedParameterSpec ED25519 { get { if (!_ED25519Ready) { _ED25519Content = SGetField<Java.Security.Spec.NamedParameterSpec>(LocalBridgeClazz, "ED25519"); _ED25519Ready = true; } return _ED25519Content; } }
        private static Java.Security.Spec.NamedParameterSpec _ED25519Content = default;
        private static bool _ED25519Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/NamedParameterSpec.html#ED448"/>
        /// </summary>
        public static Java.Security.Spec.NamedParameterSpec ED448 { get { if (!_ED448Ready) { _ED448Content = SGetField<Java.Security.Spec.NamedParameterSpec>(LocalBridgeClazz, "ED448"); _ED448Ready = true; } return _ED448Content; } }
        private static Java.Security.Spec.NamedParameterSpec _ED448Content = default;
        private static bool _ED448Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/NamedParameterSpec.html#X25519"/>
        /// </summary>
        public static Java.Security.Spec.NamedParameterSpec X25519 { get { if (!_X25519Ready) { _X25519Content = SGetField<Java.Security.Spec.NamedParameterSpec>(LocalBridgeClazz, "X25519"); _X25519Ready = true; } return _X25519Content; } }
        private static Java.Security.Spec.NamedParameterSpec _X25519Content = default;
        private static bool _X25519Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/NamedParameterSpec.html#X448"/>
        /// </summary>
        public static Java.Security.Spec.NamedParameterSpec X448 { get { if (!_X448Ready) { _X448Content = SGetField<Java.Security.Spec.NamedParameterSpec>(LocalBridgeClazz, "X448"); _X448Ready = true; } return _X448Content; } }
        private static Java.Security.Spec.NamedParameterSpec _X448Content = default;
        private static bool _X448Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/security/spec/NamedParameterSpec.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}