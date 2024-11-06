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
    #region Clob declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/sql/Clob.html"/>
    /// </summary>
    public partial class Clob : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Clob>
    {
        const string _bridgeClassName = "java.sql.Clob";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Clob class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Clob() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Clob class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Clob(params object[] args) : base(args) { }
    
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

    #region IClob
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IClob
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region Clob implementation
    public partial class Clob : Java.Sql.IClob
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
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#setString(long,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int SetString(long arg0, Java.Lang.String arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<int>("setString", "(JLjava/lang/String;II)I", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#setString(long,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int SetString(long arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<int>("setString", "(JLjava/lang/String;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#getAsciiStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.InputStream GetAsciiStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getAsciiStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#setAsciiStream(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.OutputStream SetAsciiStream(long arg0)
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("setAsciiStream", "(J)Ljava/io/OutputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#getCharacterStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Reader GetCharacterStream()
        {
            return IExecuteWithSignature<Java.Io.Reader>("getCharacterStream", "()Ljava/io/Reader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#getCharacterStream(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Reader GetCharacterStream(long arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Io.Reader>("getCharacterStream", "(JJ)Ljava/io/Reader;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#setCharacterStream(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Writer SetCharacterStream(long arg0)
        {
            return IExecuteWithSignature<Java.Io.Writer>("setCharacterStream", "(J)Ljava/io/Writer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#getSubString(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetSubString(long arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubString", "(JI)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#length()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long Length()
        {
            return IExecuteWithSignature<long>("length", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#position(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long Position(Java.Lang.String arg0, long arg1)
        {
            return IExecuteWithSignature<long>("position", "(Ljava/lang/String;J)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#position(java.sql.Clob,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Clob"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long Position(Java.Sql.Clob arg0, long arg1)
        {
            return IExecuteWithSignature<long>("position", "(Ljava/sql/Clob;J)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#free()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Free()
        {
            IExecuteWithSignature("free", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Clob.html#truncate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Truncate(long arg0)
        {
            IExecuteWithSignature("truncate", "(J)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}