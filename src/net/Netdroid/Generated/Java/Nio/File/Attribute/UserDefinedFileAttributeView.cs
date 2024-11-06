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

namespace Java.Nio.File.Attribute
{
    #region UserDefinedFileAttributeView declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html"/>
    /// </summary>
    public partial class UserDefinedFileAttributeView : Java.Nio.File.Attribute.FileAttributeView
    {
        const string _bridgeClassName = "java.nio.file.attribute.UserDefinedFileAttributeView";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("UserDefinedFileAttributeView class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public UserDefinedFileAttributeView() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("UserDefinedFileAttributeView class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public UserDefinedFileAttributeView(params object[] args) : base(args) { }
    
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

    #region IUserDefinedFileAttributeView
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IUserDefinedFileAttributeView : Java.Nio.File.Attribute.IFileAttributeView
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region UserDefinedFileAttributeView implementation
    public partial class UserDefinedFileAttributeView : Java.Nio.File.Attribute.IUserDefinedFileAttributeView
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
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#read(java.lang.String,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Lang.String arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecuteWithSignature<int>("read", "(Ljava/lang/String;Ljava/nio/ByteBuffer;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#size(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Size(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("size", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#write(java.lang.String,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Java.Lang.String arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecuteWithSignature<int>("write", "(Ljava/lang/String;Ljava/nio/ByteBuffer;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#name()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#list()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.List<Java.Lang.String> List()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("list", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/UserDefinedFileAttributeView.html#delete(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Delete(Java.Lang.String arg0)
        {
            IExecuteWithSignature("delete", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}