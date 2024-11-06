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

namespace Java.Sql
{
    #region Driver declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/sql/Driver.html"/>
    /// </summary>
    public partial class Driver : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Driver>
    {
        const string _bridgeClassName = "java.sql.Driver";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Driver class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Driver() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Driver class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Driver(params object[] args) : base(args) { }
    
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

    #region IDriver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDriver
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region Driver implementation
    public partial class Driver : Java.Sql.IDriver
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
        /// <see href="https://developer.android.com/reference/java/sql/Driver.html#acceptsURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool AcceptsURL(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("acceptsURL", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Driver.html#jdbcCompliant()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool JdbcCompliant()
        {
            return IExecuteWithSignature<bool>("jdbcCompliant", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Driver.html#getMajorVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMajorVersion()
        {
            return IExecuteWithSignature<int>("getMajorVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Driver.html#getMinorVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinorVersion()
        {
            return IExecuteWithSignature<int>("getMinorVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Driver.html#connect(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection Connect(Java.Lang.String arg0, Java.Util.Properties arg1)
        {
            return IExecuteWithSignature<Java.Sql.Connection>("connect", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Driver.html#getPropertyInfo(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Sql.DriverPropertyInfo"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.DriverPropertyInfo[] GetPropertyInfo(Java.Lang.String arg0, Java.Util.Properties arg1)
        {
            return IExecuteWithSignatureArray<Java.Sql.DriverPropertyInfo>("getPropertyInfo", "(Ljava/lang/String;Ljava/util/Properties;)[Ljava/sql/DriverPropertyInfo;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Driver.html#getParentLogger()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        /// <exception cref="Java.Sql.SQLFeatureNotSupportedException"/>
        public Java.Util.Logging.Logger GetParentLogger()
        {
            return IExecuteWithSignature<Java.Util.Logging.Logger>("getParentLogger", "()Ljava/util/logging/Logger;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}