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
    #region AttributedCharacterIterator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html"/>
    /// </summary>
    public partial class AttributedCharacterIterator : Java.Text.CharacterIterator
    {
        const string _bridgeClassName = "java.text.AttributedCharacterIterator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AttributedCharacterIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AttributedCharacterIterator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AttributedCharacterIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AttributedCharacterIterator(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region Attribute declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.Attribute.html"/>
        /// </summary>
        public partial class Attribute : Java.Io.Serializable
        {
            const string _bridgeClassName = "java.text.AttributedCharacterIterator$Attribute";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Attribute() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Attribute(params object[] args) : base(args) { }
        
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

    #region IAttributedCharacterIterator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAttributedCharacterIterator : Java.Text.ICharacterIterator
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region AttributedCharacterIterator implementation
    public partial class AttributedCharacterIterator : Java.Text.IAttributedCharacterIterator
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
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getRunLimit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRunLimit()
        {
            return IExecuteWithSignature<int>("getRunLimit", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getRunLimit(java.text.AttributedCharacterIterator.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunLimit(Java.Text.AttributedCharacterIterator.Attribute arg0)
        {
            return IExecuteWithSignature<int>("getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getRunLimit(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int GetRunLimit<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute>(Java.Util.Set<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute> arg0) where Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute : Java.Text.AttributedCharacterIterator.Attribute
        {
            return IExecuteWithSignature<int>("getRunLimit", "(Ljava/util/Set;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getRunStart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRunStart()
        {
            return IExecuteWithSignature<int>("getRunStart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getRunStart(java.text.AttributedCharacterIterator.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRunStart(Java.Text.AttributedCharacterIterator.Attribute arg0)
        {
            return IExecuteWithSignature<int>("getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getRunStart(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <typeparam name="Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int GetRunStart<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute>(Java.Util.Set<Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute> arg0) where Arg0ExtendsJava_Text_AttributedCharacterIterator_Attribute : Java.Text.AttributedCharacterIterator.Attribute
        {
            return IExecuteWithSignature<int>("getRunStart", "(Ljava/util/Set;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getAttribute(java.text.AttributedCharacterIterator.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(Java.Text.AttributedCharacterIterator.Attribute arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Text.AttributedCharacterIterator.Attribute, object> GetAttributes()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Text.AttributedCharacterIterator.Attribute, object>>("getAttributes", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.html#getAllAttributeKeys()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Text.AttributedCharacterIterator.Attribute> GetAllAttributeKeys()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Text.AttributedCharacterIterator.Attribute>>("getAllAttributeKeys", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Nested classes
        #region Attribute implementation
        public partial class Attribute
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.Attribute.html#INPUT_METHOD_SEGMENT"/>
            /// </summary>
            public static Java.Text.AttributedCharacterIterator.Attribute INPUT_METHOD_SEGMENT { get { if (!_INPUT_METHOD_SEGMENTReady) { _INPUT_METHOD_SEGMENTContent = SGetField<Java.Text.AttributedCharacterIterator.Attribute>(LocalBridgeClazz, "INPUT_METHOD_SEGMENT"); _INPUT_METHOD_SEGMENTReady = true; } return _INPUT_METHOD_SEGMENTContent; } }
            private static Java.Text.AttributedCharacterIterator.Attribute _INPUT_METHOD_SEGMENTContent = default;
            private static bool _INPUT_METHOD_SEGMENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.Attribute.html#LANGUAGE"/>
            /// </summary>
            public static Java.Text.AttributedCharacterIterator.Attribute LANGUAGE { get { if (!_LANGUAGEReady) { _LANGUAGEContent = SGetField<Java.Text.AttributedCharacterIterator.Attribute>(LocalBridgeClazz, "LANGUAGE"); _LANGUAGEReady = true; } return _LANGUAGEContent; } }
            private static Java.Text.AttributedCharacterIterator.Attribute _LANGUAGEContent = default;
            private static bool _LANGUAGEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/text/AttributedCharacterIterator.Attribute.html#READING"/>
            /// </summary>
            public static Java.Text.AttributedCharacterIterator.Attribute READING { get { if (!_READINGReady) { _READINGContent = SGetField<Java.Text.AttributedCharacterIterator.Attribute>(LocalBridgeClazz, "READING"); _READINGReady = true; } return _READINGContent; } }
            private static Java.Text.AttributedCharacterIterator.Attribute _READINGContent = default;
            private static bool _READINGReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
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