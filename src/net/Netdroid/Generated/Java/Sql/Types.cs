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
    #region Types declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/sql/Types.html"/>
    /// </summary>
    public partial class Types : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Types>
    {
        const string _bridgeClassName = "java.sql.Types";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Types() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Types(params object[] args) : base(args) { }
    
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

    #region Types implementation
    public partial class Types
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#ARRAY"/>
        /// </summary>
        public static int ARRAY { get { if (!_ARRAYReady) { _ARRAYContent = SGetField<int>(LocalBridgeClazz, "ARRAY"); _ARRAYReady = true; } return _ARRAYContent; } }
        private static int _ARRAYContent = default;
        private static bool _ARRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#BIGINT"/>
        /// </summary>
        public static int BIGINT { get { if (!_BIGINTReady) { _BIGINTContent = SGetField<int>(LocalBridgeClazz, "BIGINT"); _BIGINTReady = true; } return _BIGINTContent; } }
        private static int _BIGINTContent = default;
        private static bool _BIGINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#BINARY"/>
        /// </summary>
        public static int BINARY { get { if (!_BINARYReady) { _BINARYContent = SGetField<int>(LocalBridgeClazz, "BINARY"); _BINARYReady = true; } return _BINARYContent; } }
        private static int _BINARYContent = default;
        private static bool _BINARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#BIT"/>
        /// </summary>
        public static int BIT { get { if (!_BITReady) { _BITContent = SGetField<int>(LocalBridgeClazz, "BIT"); _BITReady = true; } return _BITContent; } }
        private static int _BITContent = default;
        private static bool _BITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#BLOB"/>
        /// </summary>
        public static int BLOB { get { if (!_BLOBReady) { _BLOBContent = SGetField<int>(LocalBridgeClazz, "BLOB"); _BLOBReady = true; } return _BLOBContent; } }
        private static int _BLOBContent = default;
        private static bool _BLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#BOOLEAN"/>
        /// </summary>
        public static int BOOLEAN { get { if (!_BOOLEANReady) { _BOOLEANContent = SGetField<int>(LocalBridgeClazz, "BOOLEAN"); _BOOLEANReady = true; } return _BOOLEANContent; } }
        private static int _BOOLEANContent = default;
        private static bool _BOOLEANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#CHAR"/>
        /// </summary>
        public static int CHAR { get { if (!_CHARReady) { _CHARContent = SGetField<int>(LocalBridgeClazz, "CHAR"); _CHARReady = true; } return _CHARContent; } }
        private static int _CHARContent = default;
        private static bool _CHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#CLOB"/>
        /// </summary>
        public static int CLOB { get { if (!_CLOBReady) { _CLOBContent = SGetField<int>(LocalBridgeClazz, "CLOB"); _CLOBReady = true; } return _CLOBContent; } }
        private static int _CLOBContent = default;
        private static bool _CLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#DATALINK"/>
        /// </summary>
        public static int DATALINK { get { if (!_DATALINKReady) { _DATALINKContent = SGetField<int>(LocalBridgeClazz, "DATALINK"); _DATALINKReady = true; } return _DATALINKContent; } }
        private static int _DATALINKContent = default;
        private static bool _DATALINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#DATE"/>
        /// </summary>
        public static int DATE { get { if (!_DATEReady) { _DATEContent = SGetField<int>(LocalBridgeClazz, "DATE"); _DATEReady = true; } return _DATEContent; } }
        private static int _DATEContent = default;
        private static bool _DATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#DECIMAL"/>
        /// </summary>
        public static int DECIMAL { get { if (!_DECIMALReady) { _DECIMALContent = SGetField<int>(LocalBridgeClazz, "DECIMAL"); _DECIMALReady = true; } return _DECIMALContent; } }
        private static int _DECIMALContent = default;
        private static bool _DECIMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#DISTINCT"/>
        /// </summary>
        public static int DISTINCT { get { if (!_DISTINCTReady) { _DISTINCTContent = SGetField<int>(LocalBridgeClazz, "DISTINCT"); _DISTINCTReady = true; } return _DISTINCTContent; } }
        private static int _DISTINCTContent = default;
        private static bool _DISTINCTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#DOUBLE"/>
        /// </summary>
        public static int DOUBLE { get { if (!_DOUBLEReady) { _DOUBLEContent = SGetField<int>(LocalBridgeClazz, "DOUBLE"); _DOUBLEReady = true; } return _DOUBLEContent; } }
        private static int _DOUBLEContent = default;
        private static bool _DOUBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#FLOAT"/>
        /// </summary>
        public static int FLOAT { get { if (!_FLOATReady) { _FLOATContent = SGetField<int>(LocalBridgeClazz, "FLOAT"); _FLOATReady = true; } return _FLOATContent; } }
        private static int _FLOATContent = default;
        private static bool _FLOATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#INTEGER"/>
        /// </summary>
        public static int INTEGER { get { if (!_INTEGERReady) { _INTEGERContent = SGetField<int>(LocalBridgeClazz, "INTEGER"); _INTEGERReady = true; } return _INTEGERContent; } }
        private static int _INTEGERContent = default;
        private static bool _INTEGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#JAVA_OBJECT"/>
        /// </summary>
        public static int JAVA_OBJECT { get { if (!_JAVA_OBJECTReady) { _JAVA_OBJECTContent = SGetField<int>(LocalBridgeClazz, "JAVA_OBJECT"); _JAVA_OBJECTReady = true; } return _JAVA_OBJECTContent; } }
        private static int _JAVA_OBJECTContent = default;
        private static bool _JAVA_OBJECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#LONGNVARCHAR"/>
        /// </summary>
        public static int LONGNVARCHAR { get { if (!_LONGNVARCHARReady) { _LONGNVARCHARContent = SGetField<int>(LocalBridgeClazz, "LONGNVARCHAR"); _LONGNVARCHARReady = true; } return _LONGNVARCHARContent; } }
        private static int _LONGNVARCHARContent = default;
        private static bool _LONGNVARCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#LONGVARBINARY"/>
        /// </summary>
        public static int LONGVARBINARY { get { if (!_LONGVARBINARYReady) { _LONGVARBINARYContent = SGetField<int>(LocalBridgeClazz, "LONGVARBINARY"); _LONGVARBINARYReady = true; } return _LONGVARBINARYContent; } }
        private static int _LONGVARBINARYContent = default;
        private static bool _LONGVARBINARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#LONGVARCHAR"/>
        /// </summary>
        public static int LONGVARCHAR { get { if (!_LONGVARCHARReady) { _LONGVARCHARContent = SGetField<int>(LocalBridgeClazz, "LONGVARCHAR"); _LONGVARCHARReady = true; } return _LONGVARCHARContent; } }
        private static int _LONGVARCHARContent = default;
        private static bool _LONGVARCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#NCHAR"/>
        /// </summary>
        public static int NCHAR { get { if (!_NCHARReady) { _NCHARContent = SGetField<int>(LocalBridgeClazz, "NCHAR"); _NCHARReady = true; } return _NCHARContent; } }
        private static int _NCHARContent = default;
        private static bool _NCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#NCLOB"/>
        /// </summary>
        public static int NCLOB { get { if (!_NCLOBReady) { _NCLOBContent = SGetField<int>(LocalBridgeClazz, "NCLOB"); _NCLOBReady = true; } return _NCLOBContent; } }
        private static int _NCLOBContent = default;
        private static bool _NCLOBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#NULL"/>
        /// </summary>
        public static int NULL { get { if (!_NULLReady) { _NULLContent = SGetField<int>(LocalBridgeClazz, "NULL"); _NULLReady = true; } return _NULLContent; } }
        private static int _NULLContent = default;
        private static bool _NULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#NUMERIC"/>
        /// </summary>
        public static int NUMERIC { get { if (!_NUMERICReady) { _NUMERICContent = SGetField<int>(LocalBridgeClazz, "NUMERIC"); _NUMERICReady = true; } return _NUMERICContent; } }
        private static int _NUMERICContent = default;
        private static bool _NUMERICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#NVARCHAR"/>
        /// </summary>
        public static int NVARCHAR { get { if (!_NVARCHARReady) { _NVARCHARContent = SGetField<int>(LocalBridgeClazz, "NVARCHAR"); _NVARCHARReady = true; } return _NVARCHARContent; } }
        private static int _NVARCHARContent = default;
        private static bool _NVARCHARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#OTHER"/>
        /// </summary>
        public static int OTHER { get { if (!_OTHERReady) { _OTHERContent = SGetField<int>(LocalBridgeClazz, "OTHER"); _OTHERReady = true; } return _OTHERContent; } }
        private static int _OTHERContent = default;
        private static bool _OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#REAL"/>
        /// </summary>
        public static int REAL { get { if (!_REALReady) { _REALContent = SGetField<int>(LocalBridgeClazz, "REAL"); _REALReady = true; } return _REALContent; } }
        private static int _REALContent = default;
        private static bool _REALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#REF"/>
        /// </summary>
        public static int REF { get { if (!_REFReady) { _REFContent = SGetField<int>(LocalBridgeClazz, "REF"); _REFReady = true; } return _REFContent; } }
        private static int _REFContent = default;
        private static bool _REFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#REF_CURSOR"/>
        /// </summary>
        public static int REF_CURSOR { get { if (!_REF_CURSORReady) { _REF_CURSORContent = SGetField<int>(LocalBridgeClazz, "REF_CURSOR"); _REF_CURSORReady = true; } return _REF_CURSORContent; } }
        private static int _REF_CURSORContent = default;
        private static bool _REF_CURSORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#ROWID"/>
        /// </summary>
        public static int ROWID { get { if (!_ROWIDReady) { _ROWIDContent = SGetField<int>(LocalBridgeClazz, "ROWID"); _ROWIDReady = true; } return _ROWIDContent; } }
        private static int _ROWIDContent = default;
        private static bool _ROWIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#SMALLINT"/>
        /// </summary>
        public static int SMALLINT { get { if (!_SMALLINTReady) { _SMALLINTContent = SGetField<int>(LocalBridgeClazz, "SMALLINT"); _SMALLINTReady = true; } return _SMALLINTContent; } }
        private static int _SMALLINTContent = default;
        private static bool _SMALLINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#SQLXML"/>
        /// </summary>
        public static int SQLXML { get { if (!_SQLXMLReady) { _SQLXMLContent = SGetField<int>(LocalBridgeClazz, "SQLXML"); _SQLXMLReady = true; } return _SQLXMLContent; } }
        private static int _SQLXMLContent = default;
        private static bool _SQLXMLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#STRUCT"/>
        /// </summary>
        public static int STRUCT { get { if (!_STRUCTReady) { _STRUCTContent = SGetField<int>(LocalBridgeClazz, "STRUCT"); _STRUCTReady = true; } return _STRUCTContent; } }
        private static int _STRUCTContent = default;
        private static bool _STRUCTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#TIME"/>
        /// </summary>
        public static int TIME { get { if (!_TIMEReady) { _TIMEContent = SGetField<int>(LocalBridgeClazz, "TIME"); _TIMEReady = true; } return _TIMEContent; } }
        private static int _TIMEContent = default;
        private static bool _TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#TIME_WITH_TIMEZONE"/>
        /// </summary>
        public static int TIME_WITH_TIMEZONE { get { if (!_TIME_WITH_TIMEZONEReady) { _TIME_WITH_TIMEZONEContent = SGetField<int>(LocalBridgeClazz, "TIME_WITH_TIMEZONE"); _TIME_WITH_TIMEZONEReady = true; } return _TIME_WITH_TIMEZONEContent; } }
        private static int _TIME_WITH_TIMEZONEContent = default;
        private static bool _TIME_WITH_TIMEZONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#TIMESTAMP"/>
        /// </summary>
        public static int TIMESTAMP { get { if (!_TIMESTAMPReady) { _TIMESTAMPContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP"); _TIMESTAMPReady = true; } return _TIMESTAMPContent; } }
        private static int _TIMESTAMPContent = default;
        private static bool _TIMESTAMPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#TIMESTAMP_WITH_TIMEZONE"/>
        /// </summary>
        public static int TIMESTAMP_WITH_TIMEZONE { get { if (!_TIMESTAMP_WITH_TIMEZONEReady) { _TIMESTAMP_WITH_TIMEZONEContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_WITH_TIMEZONE"); _TIMESTAMP_WITH_TIMEZONEReady = true; } return _TIMESTAMP_WITH_TIMEZONEContent; } }
        private static int _TIMESTAMP_WITH_TIMEZONEContent = default;
        private static bool _TIMESTAMP_WITH_TIMEZONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#TINYINT"/>
        /// </summary>
        public static int TINYINT { get { if (!_TINYINTReady) { _TINYINTContent = SGetField<int>(LocalBridgeClazz, "TINYINT"); _TINYINTReady = true; } return _TINYINTContent; } }
        private static int _TINYINTContent = default;
        private static bool _TINYINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#VARBINARY"/>
        /// </summary>
        public static int VARBINARY { get { if (!_VARBINARYReady) { _VARBINARYContent = SGetField<int>(LocalBridgeClazz, "VARBINARY"); _VARBINARYReady = true; } return _VARBINARYContent; } }
        private static int _VARBINARYContent = default;
        private static bool _VARBINARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Types.html#VARCHAR"/>
        /// </summary>
        public static int VARCHAR { get { if (!_VARCHARReady) { _VARCHARContent = SGetField<int>(LocalBridgeClazz, "VARCHAR"); _VARCHARReady = true; } return _VARCHARContent; } }
        private static int _VARCHARContent = default;
        private static bool _VARCHARReady = false; // this is used because in case of generics 
    
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