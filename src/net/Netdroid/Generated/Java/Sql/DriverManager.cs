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

namespace Java.Sql
{
    #region DriverManager
    public partial class DriverManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getLoginTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetLoginTimeout()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getLoginTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getLogStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.PrintStream"/></returns>
        [global::System.Obsolete()]
        public static Java.Io.PrintStream GetLogStream()
        {
            return SExecuteWithSignature<Java.Io.PrintStream>(LocalBridgeClazz, "getLogStream", "()Ljava/io/PrintStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getLogWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        public static Java.Io.PrintWriter GetLogWriter()
        {
            return SExecuteWithSignature<Java.Io.PrintWriter>(LocalBridgeClazz, "getLogWriter", "()Ljava/io/PrintWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getConnection(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecute<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getConnection(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(Java.Lang.String arg0, Java.Util.Properties arg1)
        {
            return SExecute<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getConnection(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", "(Ljava/lang/String;)Ljava/sql/Connection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getDriver(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Driver"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Driver GetDriver(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.Driver>(LocalBridgeClazz, "getDriver", "(Ljava/lang/String;)Ljava/sql/Driver;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#getDrivers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public static Java.Util.Enumeration<Java.Sql.Driver> GetDrivers()
        {
            return SExecuteWithSignature<Java.Util.Enumeration<Java.Sql.Driver>>(LocalBridgeClazz, "getDrivers", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#drivers()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream<Java.Sql.Driver> Drivers()
        {
            return SExecuteWithSignature<Java.Util.Stream.Stream<Java.Sql.Driver>>(LocalBridgeClazz, "drivers", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#deregisterDriver(java.sql.Driver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void DeregisterDriver(Java.Sql.Driver arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "deregisterDriver", "(Ljava/sql/Driver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#println(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Println(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "println", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#registerDriver(java.sql.Driver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void RegisterDriver(Java.Sql.Driver arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "registerDriver", "(Ljava/sql/Driver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#setLoginTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void SetLoginTimeout(int arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setLoginTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#setLogStream(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        [global::System.Obsolete()]
        public static void SetLogStream(Java.Io.PrintStream arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setLogStream", "(Ljava/io/PrintStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/DriverManager.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        public static void SetLogWriter(Java.Io.PrintWriter arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setLogWriter", "(Ljava/io/PrintWriter;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}