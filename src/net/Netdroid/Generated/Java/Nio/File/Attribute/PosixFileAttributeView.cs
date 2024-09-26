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

namespace Java.Nio.File.Attribute
{
    #region PosixFileAttributeView declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/nio/file/attribute/PosixFileAttributeView.html"/>
    /// </summary>
    public partial class PosixFileAttributeView : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PosixFileAttributeView>
    {
        const string _bridgeClassName = "java.nio.file.attribute.PosixFileAttributeView";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PosixFileAttributeView class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PosixFileAttributeView() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PosixFileAttributeView class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PosixFileAttributeView(params object[] args) : base(args) { }

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

    #region IPosixFileAttributeView
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPosixFileAttributeView
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PosixFileAttributeView implementation
    public partial class PosixFileAttributeView : Java.Nio.File.Attribute.IPosixFileAttributeView, Java.Nio.File.Attribute.IBasicFileAttributeView, Java.Nio.File.Attribute.IFileOwnerAttributeView
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Attribute.PosixFileAttributeView"/> to <see cref="Java.Nio.File.Attribute.BasicFileAttributeView"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Attribute.BasicFileAttributeView(Java.Nio.File.Attribute.PosixFileAttributeView t) => t.Cast<Java.Nio.File.Attribute.BasicFileAttributeView>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Attribute.PosixFileAttributeView"/> to <see cref="Java.Nio.File.Attribute.FileOwnerAttributeView"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Attribute.FileOwnerAttributeView(Java.Nio.File.Attribute.PosixFileAttributeView t) => t.Cast<Java.Nio.File.Attribute.FileOwnerAttributeView>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/PosixFileAttributeView.html#name()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Name()
        {
            return IExecuteWithSignature<Java.Lang.String>("name", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/PosixFileAttributeView.html#setGroup(java.nio.file.attribute.GroupPrincipal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.GroupPrincipal"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetGroup(Java.Nio.File.Attribute.GroupPrincipal arg0)
        {
            IExecuteWithSignature("setGroup", "(Ljava/nio/file/attribute/GroupPrincipal;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/PosixFileAttributeView.html#setPermissions(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetPermissions(Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission> arg0)
        {
            IExecuteWithSignature("setPermissions", "(Ljava/util/Set;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/attribute/PosixFileAttributeView.html#readAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Attribute.BasicFileAttributes ReadAttributes()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.BasicFileAttributes>("readAttributes", "()Ljava/nio/file/attribute/BasicFileAttributes;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}