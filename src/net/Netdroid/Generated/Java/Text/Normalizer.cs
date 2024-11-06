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

namespace Java.Text
{
    #region Normalizer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/text/Normalizer.html"/>
    /// </summary>
    public partial class Normalizer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Normalizer>
    {
        const string _bridgeClassName = "java.text.Normalizer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Normalizer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Normalizer(params object[] args) : base(args) { }
    
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
        #region Form declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Normalizer.Form.html"/>
        /// </summary>
        public partial class Form : Java.Lang.Enum<Java.Text.Normalizer.Form>
        {
            const string _bridgeClassName = "java.text.Normalizer$Form";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Form() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Form(params object[] args) : base(args) { }
        
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

    #region Normalizer implementation
    public partial class Normalizer
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Normalizer.html#isNormalized(java.lang.CharSequence,java.text.Normalizer.Form)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.Normalizer.Form"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNormalized(Java.Lang.CharSequence arg0, Java.Text.Normalizer.Form arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNormalized", "(Ljava/lang/CharSequence;Ljava/text/Normalizer$Form;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Normalizer.html#normalize(java.lang.CharSequence,java.text.Normalizer.Form)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Text.Normalizer.Form"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Normalize(Java.Lang.CharSequence arg0, Java.Text.Normalizer.Form arg1)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "normalize", "(Ljava/lang/CharSequence;Ljava/text/Normalizer$Form;)Ljava/lang/String;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
        #region Form implementation
        public partial class Form
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/Normalizer.Form.html#NFC"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFC { get { if (!_NFCReady) { _NFCContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFC"); _NFCReady = true; } return _NFCContent; } }
            private static Java.Text.Normalizer.Form _NFCContent = default;
            private static bool _NFCReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/Normalizer.Form.html#NFD"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFD { get { if (!_NFDReady) { _NFDContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFD"); _NFDReady = true; } return _NFDContent; } }
            private static Java.Text.Normalizer.Form _NFDContent = default;
            private static bool _NFDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/Normalizer.Form.html#NFKC"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFKC { get { if (!_NFKCReady) { _NFKCContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFKC"); _NFKCReady = true; } return _NFKCContent; } }
            private static Java.Text.Normalizer.Form _NFKCContent = default;
            private static bool _NFKCReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/Normalizer.Form.html#NFKD"/>
            /// </summary>
            public static Java.Text.Normalizer.Form NFKD { get { if (!_NFKDReady) { _NFKDContent = SGetField<Java.Text.Normalizer.Form>(LocalBridgeClazz, "NFKD"); _NFKDReady = true; } return _NFKDContent; } }
            private static Java.Text.Normalizer.Form _NFKDContent = default;
            private static bool _NFKDReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/Normalizer.Form.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Text.Normalizer.Form"/></returns>
            public static Java.Text.Normalizer.Form ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Text.Normalizer.Form>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/text/Normalizer$Form;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/Normalizer.Form.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Text.Normalizer.Form"/></returns>
            public static Java.Text.Normalizer.Form[] Values()
            {
                return SExecuteWithSignatureArray<Java.Text.Normalizer.Form>(LocalBridgeClazz, "values", "()[Ljava/text/Normalizer$Form;");
            }
        
            #endregion
        
            #region Instance methods
        
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