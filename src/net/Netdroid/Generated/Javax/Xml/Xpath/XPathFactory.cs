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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Xpath
{
    #region XPathFactory
    public partial class XPathFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#DEFAULT_OBJECT_MODEL_URI"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_OBJECT_MODEL_URI { get { if (!_DEFAULT_OBJECT_MODEL_URIReady) { _DEFAULT_OBJECT_MODEL_URIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_OBJECT_MODEL_URI"); _DEFAULT_OBJECT_MODEL_URIReady = true; } return _DEFAULT_OBJECT_MODEL_URIContent; } }
        private static Java.Lang.String _DEFAULT_OBJECT_MODEL_URIContent = default;
        private static bool _DEFAULT_OBJECT_MODEL_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#DEFAULT_PROPERTY_NAME"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_PROPERTY_NAME { get { if (!_DEFAULT_PROPERTY_NAMEReady) { _DEFAULT_PROPERTY_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_PROPERTY_NAME"); _DEFAULT_PROPERTY_NAMEReady = true; } return _DEFAULT_PROPERTY_NAMEContent; } }
        private static Java.Lang.String _DEFAULT_PROPERTY_NAMEContent = default;
        private static bool _DEFAULT_PROPERTY_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#newDefaultInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Xpath.XPathFactory"/></returns>
        public static Javax.Xml.Xpath.XPathFactory NewDefaultInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Xpath.XPathFactory>(LocalBridgeClazz, "newDefaultInstance", "()Ljavax/xml/xpath/XPathFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Xpath.XPathFactory"/></returns>
        public static Javax.Xml.Xpath.XPathFactory NewInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Xpath.XPathFactory>(LocalBridgeClazz, "newInstance", "()Ljavax/xml/xpath/XPathFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#newInstance(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathFactory"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathFactoryConfigurationException"/>
        public static Javax.Xml.Xpath.XPathFactory NewInstance(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Javax.Xml.Xpath.XPathFactory>(LocalBridgeClazz, "newInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#newInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Xpath.XPathFactory"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathFactoryConfigurationException"/>
        public static Javax.Xml.Xpath.XPathFactory NewInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Xml.Xpath.XPathFactory>(LocalBridgeClazz, "newInstance", "(Ljava/lang/String;)Ljavax/xml/xpath/XPathFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Xpath.XPathFactoryConfigurationException"/>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#isObjectModelSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsObjectModelSupported(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isObjectModelSupported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#newXPath()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Xpath.XPath"/></returns>
        public Javax.Xml.Xpath.XPath NewXPath()
        {
            return IExecuteWithSignature<Javax.Xml.Xpath.XPath>("newXPath", "()Ljavax/xml/xpath/XPath;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Xml.Xpath.XPathFactoryConfigurationException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#setXPathFunctionResolver(javax.xml.xpath.XPathFunctionResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Xpath.XPathFunctionResolver"/></param>
        public void SetXPathFunctionResolver(Javax.Xml.Xpath.XPathFunctionResolver arg0)
        {
            IExecuteWithSignature("setXPathFunctionResolver", "(Ljavax/xml/xpath/XPathFunctionResolver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/xpath/XPathFactory.html#setXPathVariableResolver(javax.xml.xpath.XPathVariableResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Xpath.XPathVariableResolver"/></param>
        public void SetXPathVariableResolver(Javax.Xml.Xpath.XPathVariableResolver arg0)
        {
            IExecuteWithSignature("setXPathVariableResolver", "(Ljavax/xml/xpath/XPathVariableResolver;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}