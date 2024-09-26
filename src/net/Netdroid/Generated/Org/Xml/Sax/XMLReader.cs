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

namespace Org.Xml.Sax
{
    #region XMLReader declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html"/>
    /// </summary>
    public partial class XMLReader : MASES.JCOBridge.C2JBridge.JVMBridgeBase<XMLReader>
    {
        const string _bridgeClassName = "org.xml.sax.XMLReader";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("XMLReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XMLReader() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("XMLReader class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public XMLReader(params object[] args) : base(args) { }

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

    }
    #endregion

    #region IXMLReader
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXMLReader
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XMLReader implementation
    public partial class XMLReader : Org.Xml.Sax.IXMLReader
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
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#getContentHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.ContentHandler"/></returns>
        public Org.Xml.Sax.ContentHandler GetContentHandler()
        {
            return IExecuteWithSignature<Org.Xml.Sax.ContentHandler>("getContentHandler", "()Lorg/xml/sax/ContentHandler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#getDTDHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.DTDHandler"/></returns>
        public Org.Xml.Sax.DTDHandler GetDTDHandler()
        {
            return IExecuteWithSignature<Org.Xml.Sax.DTDHandler>("getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#getEntityResolver()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.EntityResolver"/></returns>
        public Org.Xml.Sax.EntityResolver GetEntityResolver()
        {
            return IExecuteWithSignature<Org.Xml.Sax.EntityResolver>("getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#getErrorHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.ErrorHandler"/></returns>
        public Org.Xml.Sax.ErrorHandler GetErrorHandler()
        {
            return IExecuteWithSignature<Org.Xml.Sax.ErrorHandler>("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Parse(Java.Lang.String arg0)
        {
            IExecuteWithSignature("parse", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Parse(Org.Xml.Sax.InputSource arg0)
        {
            IExecuteWithSignature("parse", "(Lorg/xml/sax/InputSource;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ContentHandler"/></param>
        public void SetContentHandler(Org.Xml.Sax.ContentHandler arg0)
        {
            IExecuteWithSignature("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.DTDHandler"/></param>
        public void SetDTDHandler(Org.Xml.Sax.DTDHandler arg0)
        {
            IExecuteWithSignature("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.EntityResolver"/></param>
        public void SetEntityResolver(Org.Xml.Sax.EntityResolver arg0)
        {
            IExecuteWithSignature("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("setFeature", "(Ljava/lang/String;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/XMLReader.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecuteWithSignature("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}