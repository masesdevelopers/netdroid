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

namespace Javax.Xml.Xpath
{
    #region XPathConstants declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathConstants.html"/>
    /// </summary>
    public partial class XPathConstants : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XPathConstants>
    {
        const string _bridgeClassName = "javax.xml.xpath.XPathConstants";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public XPathConstants() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public XPathConstants(params object[] args) : base(args) { }
    
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

    #region XPathConstants implementation
    public partial class XPathConstants
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathConstants.html#DOM_OBJECT_MODEL"/>
        /// </summary>
        public static Java.Lang.String DOM_OBJECT_MODEL { get { if (!_DOM_OBJECT_MODELReady) { _DOM_OBJECT_MODELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DOM_OBJECT_MODEL"); _DOM_OBJECT_MODELReady = true; } return _DOM_OBJECT_MODELContent; } }
        private static Java.Lang.String _DOM_OBJECT_MODELContent = default;
        private static bool _DOM_OBJECT_MODELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathConstants.html#BOOLEAN"/>
        /// </summary>
        public static Javax.Xml.Namespace.QName BOOLEAN { get { if (!_BOOLEANReady) { _BOOLEANContent = SGetField<Javax.Xml.Namespace.QName>(LocalBridgeClazz, "BOOLEAN"); _BOOLEANReady = true; } return _BOOLEANContent; } }
        private static Javax.Xml.Namespace.QName _BOOLEANContent = default;
        private static bool _BOOLEANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathConstants.html#NODE"/>
        /// </summary>
        public static Javax.Xml.Namespace.QName NODE { get { if (!_NODEReady) { _NODEContent = SGetField<Javax.Xml.Namespace.QName>(LocalBridgeClazz, "NODE"); _NODEReady = true; } return _NODEContent; } }
        private static Javax.Xml.Namespace.QName _NODEContent = default;
        private static bool _NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathConstants.html#NODESET"/>
        /// </summary>
        public static Javax.Xml.Namespace.QName NODESET { get { if (!_NODESETReady) { _NODESETContent = SGetField<Javax.Xml.Namespace.QName>(LocalBridgeClazz, "NODESET"); _NODESETReady = true; } return _NODESETContent; } }
        private static Javax.Xml.Namespace.QName _NODESETContent = default;
        private static bool _NODESETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathConstants.html#NUMBER"/>
        /// </summary>
        public static Javax.Xml.Namespace.QName NUMBER { get { if (!_NUMBERReady) { _NUMBERContent = SGetField<Javax.Xml.Namespace.QName>(LocalBridgeClazz, "NUMBER"); _NUMBERReady = true; } return _NUMBERContent; } }
        private static Javax.Xml.Namespace.QName _NUMBERContent = default;
        private static bool _NUMBERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathConstants.html#STRING"/>
        /// </summary>
        public static Javax.Xml.Namespace.QName STRING { get { if (!_STRINGReady) { _STRINGContent = SGetField<Javax.Xml.Namespace.QName>(LocalBridgeClazz, "STRING"); _STRINGReady = true; } return _STRINGContent; } }
        private static Javax.Xml.Namespace.QName _STRINGContent = default;
        private static bool _STRINGReady = false; // this is used because in case of generics 
    
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
}