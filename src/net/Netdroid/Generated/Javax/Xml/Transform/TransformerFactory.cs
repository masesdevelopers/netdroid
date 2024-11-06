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

namespace Javax.Xml.Transform
{
    #region TransformerFactory declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html"/>
    /// </summary>
    public partial class TransformerFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TransformerFactory>
    {
        const string _bridgeClassName = "javax.xml.transform.TransformerFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TransformerFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TransformerFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TransformerFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TransformerFactory(params object[] args) : base(args) { }
    
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

    #region TransformerFactory implementation
    public partial class TransformerFactory
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#newDefaultInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.TransformerFactory"/></returns>
        public static Javax.Xml.Transform.TransformerFactory NewDefaultInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Transform.TransformerFactory>(LocalBridgeClazz, "newDefaultInstance", "()Ljavax/xml/transform/TransformerFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.TransformerFactory"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerFactoryConfigurationError"/>
        public static Javax.Xml.Transform.TransformerFactory NewInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Transform.TransformerFactory>(LocalBridgeClazz, "newInstance", "()Ljavax/xml/transform/TransformerFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#newInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Transform.TransformerFactory"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerFactoryConfigurationError"/>
        public static Javax.Xml.Transform.TransformerFactory NewInstance(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecuteWithSignature<Javax.Xml.Transform.TransformerFactory>(LocalBridgeClazz, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/transform/TransformerFactory;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#getErrorListener()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.ErrorListener"/></returns>
        public Javax.Xml.Transform.ErrorListener GetErrorListener()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.ErrorListener>("getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#getErrorListener()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.ErrorListener"/></returns>
        public Javax.Xml.Transform.ErrorListener GetErrorListenerDirect()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.ErrorListenerDirect, Javax.Xml.Transform.ErrorListener>("getErrorListener", "()Ljavax/xml/transform/ErrorListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#getAssociatedStylesheet(javax.xml.transform.Source,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Source"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Source GetAssociatedStylesheet(Javax.Xml.Transform.Source arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Source>("getAssociatedStylesheet", "(Ljavax/xml/transform/Source;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#newTemplates(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Templates"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Templates NewTemplates(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Templates>("newTemplates", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Templates;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#newTransformer()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.Transformer"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Transformer NewTransformer()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Transformer>("newTransformer", "()Ljavax/xml/transform/Transformer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#newTransformer(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Transform.Transformer"/></returns>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public Javax.Xml.Transform.Transformer NewTransformer(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Transform.Transformer>("newTransformer", "(Ljavax/xml/transform/Source;)Ljavax/xml/transform/Transformer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#getURIResolver()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Transform.URIResolver"/></returns>
        public Javax.Xml.Transform.URIResolver GetURIResolver()
        {
            return IExecuteWithSignature<Javax.Xml.Transform.URIResolver>("getURIResolver", "()Ljavax/xml/transform/URIResolver;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#setAttribute(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetAttribute(Java.Lang.String arg0, object arg1)
        {
            IExecuteWithSignature("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#setErrorListener(javax.xml.transform.ErrorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.ErrorListener"/></param>
        public void SetErrorListener(Javax.Xml.Transform.ErrorListener arg0)
        {
            IExecuteWithSignature("setErrorListener", "(Ljavax/xml/transform/ErrorListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Xml.Transform.TransformerConfigurationException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("setFeature", "(Ljava/lang/String;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/TransformerFactory.html#setURIResolver(javax.xml.transform.URIResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.URIResolver"/></param>
        public void SetURIResolver(Javax.Xml.Transform.URIResolver arg0)
        {
            IExecuteWithSignature("setURIResolver", "(Ljavax/xml/transform/URIResolver;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}