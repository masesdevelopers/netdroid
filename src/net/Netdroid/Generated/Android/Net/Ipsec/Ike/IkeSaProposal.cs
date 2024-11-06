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

namespace Android.Net.Ipsec.Ike
{
    #region IkeSaProposal declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.html"/>
    /// </summary>
    public partial class IkeSaProposal : Android.Net.Ipsec.Ike.SaProposal
    {
        const string _bridgeClassName = "android.net.ipsec.ike.IkeSaProposal";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IkeSaProposal() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IkeSaProposal(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.ipsec.ike.IkeSaProposal$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region IkeSaProposal implementation
    public partial class IkeSaProposal
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.html#getSupportedEncryptionAlgorithms()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.Integer> GetSupportedEncryptionAlgorithms()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>(LocalBridgeClazz, "getSupportedEncryptionAlgorithms", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.html#getSupportedIntegrityAlgorithms()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.Integer> GetSupportedIntegrityAlgorithms()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>(LocalBridgeClazz, "getSupportedIntegrityAlgorithms", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.html#getSupportedPseudorandomFunctions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.Integer> GetSupportedPseudorandomFunctions()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>(LocalBridgeClazz, "getSupportedPseudorandomFunctions", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.html#getPseudorandomFunctions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> GetPseudorandomFunctions()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("getPseudorandomFunctions", "()Ljava/util/List;");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSaProposal"/></returns>
            public Android.Net.Ipsec.Ike.IkeSaProposal Build()
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSaProposal>("build", "()Landroid/net/ipsec/ike/IkeSaProposal;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.Builder.html#addDhGroup(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSaProposal.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSaProposal.Builder AddDhGroup(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSaProposal.Builder>("addDhGroup", "(I)Landroid/net/ipsec/ike/IkeSaProposal$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.Builder.html#addEncryptionAlgorithm(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSaProposal.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSaProposal.Builder AddEncryptionAlgorithm(int arg0, int arg1)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSaProposal.Builder>("addEncryptionAlgorithm", "(II)Landroid/net/ipsec/ike/IkeSaProposal$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.Builder.html#addIntegrityAlgorithm(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSaProposal.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSaProposal.Builder AddIntegrityAlgorithm(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSaProposal.Builder>("addIntegrityAlgorithm", "(I)Landroid/net/ipsec/ike/IkeSaProposal$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSaProposal.Builder.html#addPseudorandomFunction(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Ipsec.Ike.IkeSaProposal.Builder"/></returns>
            public Android.Net.Ipsec.Ike.IkeSaProposal.Builder AddPseudorandomFunction(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Ipsec.Ike.IkeSaProposal.Builder>("addPseudorandomFunction", "(I)Landroid/net/ipsec/ike/IkeSaProposal$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}