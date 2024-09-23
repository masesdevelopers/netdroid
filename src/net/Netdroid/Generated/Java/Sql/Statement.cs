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

namespace Java.Sql
{
    #region Statement declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/sql/Statement.html"/>
    /// </summary>
    public partial class Statement : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Statement>
    {
        const string _bridgeClassName = "java.sql.Statement";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Statement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Statement() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Statement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Statement(params object[] args) : base(args) { }

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

    #region IStatement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStatement
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Statement implementation
    public partial class Statement : Java.Sql.IStatement, Java.Sql.IWrapper, Java.Lang.IAutoCloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Sql.Statement"/> to <see cref="Java.Sql.Wrapper"/>
        /// </summary>
        public static implicit operator Java.Sql.Wrapper(Java.Sql.Statement t) => t.Cast<Java.Sql.Wrapper>();
        /// <summary>
        /// Converter from <see cref="Java.Sql.Statement"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Sql.Statement t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#CLOSE_ALL_RESULTS"/>
        /// </summary>
        public static int CLOSE_ALL_RESULTS { get { if (!_CLOSE_ALL_RESULTSReady) { _CLOSE_ALL_RESULTSContent = SGetField<int>(LocalBridgeClazz, "CLOSE_ALL_RESULTS"); _CLOSE_ALL_RESULTSReady = true; } return _CLOSE_ALL_RESULTSContent; } }
        private static int _CLOSE_ALL_RESULTSContent = default;
        private static bool _CLOSE_ALL_RESULTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#CLOSE_CURRENT_RESULT"/>
        /// </summary>
        public static int CLOSE_CURRENT_RESULT { get { if (!_CLOSE_CURRENT_RESULTReady) { _CLOSE_CURRENT_RESULTContent = SGetField<int>(LocalBridgeClazz, "CLOSE_CURRENT_RESULT"); _CLOSE_CURRENT_RESULTReady = true; } return _CLOSE_CURRENT_RESULTContent; } }
        private static int _CLOSE_CURRENT_RESULTContent = default;
        private static bool _CLOSE_CURRENT_RESULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#EXECUTE_FAILED"/>
        /// </summary>
        public static int EXECUTE_FAILED { get { if (!_EXECUTE_FAILEDReady) { _EXECUTE_FAILEDContent = SGetField<int>(LocalBridgeClazz, "EXECUTE_FAILED"); _EXECUTE_FAILEDReady = true; } return _EXECUTE_FAILEDContent; } }
        private static int _EXECUTE_FAILEDContent = default;
        private static bool _EXECUTE_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#KEEP_CURRENT_RESULT"/>
        /// </summary>
        public static int KEEP_CURRENT_RESULT { get { if (!_KEEP_CURRENT_RESULTReady) { _KEEP_CURRENT_RESULTContent = SGetField<int>(LocalBridgeClazz, "KEEP_CURRENT_RESULT"); _KEEP_CURRENT_RESULTReady = true; } return _KEEP_CURRENT_RESULTContent; } }
        private static int _KEEP_CURRENT_RESULTContent = default;
        private static bool _KEEP_CURRENT_RESULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#NO_GENERATED_KEYS"/>
        /// </summary>
        public static int NO_GENERATED_KEYS { get { if (!_NO_GENERATED_KEYSReady) { _NO_GENERATED_KEYSContent = SGetField<int>(LocalBridgeClazz, "NO_GENERATED_KEYS"); _NO_GENERATED_KEYSReady = true; } return _NO_GENERATED_KEYSContent; } }
        private static int _NO_GENERATED_KEYSContent = default;
        private static bool _NO_GENERATED_KEYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#RETURN_GENERATED_KEYS"/>
        /// </summary>
        public static int RETURN_GENERATED_KEYS { get { if (!_RETURN_GENERATED_KEYSReady) { _RETURN_GENERATED_KEYSContent = SGetField<int>(LocalBridgeClazz, "RETURN_GENERATED_KEYS"); _RETURN_GENERATED_KEYSReady = true; } return _RETURN_GENERATED_KEYSContent; } }
        private static int _RETURN_GENERATED_KEYSContent = default;
        private static bool _RETURN_GENERATED_KEYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#SUCCESS_NO_INFO"/>
        /// </summary>
        public static int SUCCESS_NO_INFO { get { if (!_SUCCESS_NO_INFOReady) { _SUCCESS_NO_INFOContent = SGetField<int>(LocalBridgeClazz, "SUCCESS_NO_INFO"); _SUCCESS_NO_INFOReady = true; } return _SUCCESS_NO_INFOContent; } }
        private static int _SUCCESS_NO_INFOContent = default;
        private static bool _SUCCESS_NO_INFOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#execute(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(Java.Lang.String arg0, int arg1)
        {
            return IExecute<bool>("execute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#execute(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(Java.Lang.String arg0, int[] arg1)
        {
            return IExecute<bool>("execute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#execute(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(Java.Lang.String arg0, Java.Lang.String[] arg1)
        {
            return IExecute<bool>("execute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#execute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("execute", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getMoreResults()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool GetMoreResults()
        {
            return IExecuteWithSignature<bool>("getMoreResults", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getMoreResults(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool GetMoreResults(int arg0)
        {
            return IExecuteWithSignature<bool>("getMoreResults", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#isCloseOnCompletion()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsCloseOnCompletion()
        {
            return IExecuteWithSignature<bool>("isCloseOnCompletion", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#isPoolable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsPoolable()
        {
            return IExecuteWithSignature<bool>("isPoolable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeUpdate(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("executeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeUpdate(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(Java.Lang.String arg0, int[] arg1)
        {
            return IExecute<int>("executeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeUpdate(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(Java.Lang.String arg0, Java.Lang.String[] arg1)
        {
            return IExecute<int>("executeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeUpdate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("executeUpdate", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getFetchDirection()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetFetchDirection()
        {
            return IExecuteWithSignature<int>("getFetchDirection", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getFetchSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetFetchSize()
        {
            return IExecuteWithSignature<int>("getFetchSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getMaxFieldSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetMaxFieldSize()
        {
            return IExecuteWithSignature<int>("getMaxFieldSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getMaxRows()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetMaxRows()
        {
            return IExecuteWithSignature<int>("getMaxRows", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getQueryTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetQueryTimeout()
        {
            return IExecuteWithSignature<int>("getQueryTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getResultSetConcurrency()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetResultSetConcurrency()
        {
            return IExecuteWithSignature<int>("getResultSetConcurrency", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getResultSetHoldability()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetResultSetHoldability()
        {
            return IExecuteWithSignature<int>("getResultSetHoldability", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getResultSetType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetResultSetType()
        {
            return IExecuteWithSignature<int>("getResultSetType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getUpdateCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetUpdateCount()
        {
            return IExecuteWithSignature<int>("getUpdateCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeBatch()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int[] ExecuteBatch()
        {
            return IExecuteWithSignatureArray<int>("executeBatch", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getConnection()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection GetConnection()
        {
            return IExecuteWithSignature<Java.Sql.Connection>("getConnection", "()Ljava/sql/Connection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeQuery(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet ExecuteQuery(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Sql.ResultSet>("executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getGeneratedKeys()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet GetGeneratedKeys()
        {
            return IExecuteWithSignature<Java.Sql.ResultSet>("getGeneratedKeys", "()Ljava/sql/ResultSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getResultSet()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet GetResultSet()
        {
            return IExecuteWithSignature<Java.Sql.ResultSet>("getResultSet", "()Ljava/sql/ResultSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getWarnings()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.SQLWarning"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.SQLWarning GetWarnings()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getWarnings", "()Ljava/sql/SQLWarning;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Sql.SQLWarning>(obj);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#addBatch(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddBatch(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addBatch", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#cancel()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#clearBatch()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ClearBatch()
        {
            IExecuteWithSignature("clearBatch", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#clearWarnings()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ClearWarnings()
        {
            IExecuteWithSignature("clearWarnings", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#closeOnCompletion()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void CloseOnCompletion()
        {
            IExecuteWithSignature("closeOnCompletion", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setCursorName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCursorName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setCursorName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setEscapeProcessing(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetEscapeProcessing(bool arg0)
        {
            IExecuteWithSignature("setEscapeProcessing", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setFetchDirection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetFetchDirection(int arg0)
        {
            IExecuteWithSignature("setFetchDirection", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setFetchSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetFetchSize(int arg0)
        {
            IExecuteWithSignature("setFetchSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setMaxFieldSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetMaxFieldSize(int arg0)
        {
            IExecuteWithSignature("setMaxFieldSize", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setMaxRows(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetMaxRows(int arg0)
        {
            IExecuteWithSignature("setMaxRows", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setPoolable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetPoolable(bool arg0)
        {
            IExecuteWithSignature("setPoolable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setQueryTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetQueryTimeout(int arg0)
        {
            IExecuteWithSignature("setQueryTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#isSimpleIdentifier(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSimpleIdentifier(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isSimpleIdentifier", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#enquoteIdentifier(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String EnquoteIdentifier(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<Java.Lang.String>("enquoteIdentifier", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#enquoteLiteral(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String EnquoteLiteral(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("enquoteLiteral", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#enquoteNCharLiteral(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String EnquoteNCharLiteral(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("enquoteNCharLiteral", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeLargeUpdate(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(Java.Lang.String arg0, int arg1)
        {
            return IExecute<long>("executeLargeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeLargeUpdate(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(Java.Lang.String arg0, int[] arg1)
        {
            return IExecute<long>("executeLargeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeLargeUpdate(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(Java.Lang.String arg0, Java.Lang.String[] arg1)
        {
            return IExecute<long>("executeLargeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeLargeUpdate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<long>("executeLargeUpdate", "(Ljava/lang/String;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getLargeMaxRows()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long GetLargeMaxRows()
        {
            return IExecuteWithSignature<long>("getLargeMaxRows", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#getLargeUpdateCount()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long GetLargeUpdateCount()
        {
            return IExecuteWithSignature<long>("getLargeUpdateCount", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#executeLargeBatch()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long[] ExecuteLargeBatch()
        {
            return IExecuteWithSignatureArray<long>("executeLargeBatch", "()[J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Statement.html#setLargeMaxRows(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetLargeMaxRows(long arg0)
        {
            IExecuteWithSignature("setLargeMaxRows", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}