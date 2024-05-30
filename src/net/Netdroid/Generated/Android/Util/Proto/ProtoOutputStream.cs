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

namespace Android.Util.Proto
{
    #region ProtoOutputStream
    public partial class ProtoOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ProtoOutputStream(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public ProtoOutputStream(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_COUNT_SHIFT"/>
        /// </summary>
        public static int FIELD_COUNT_SHIFT { get { if (!_FIELD_COUNT_SHIFTReady) { _FIELD_COUNT_SHIFTContent = SGetField<int>(LocalBridgeClazz, "FIELD_COUNT_SHIFT"); _FIELD_COUNT_SHIFTReady = true; } return _FIELD_COUNT_SHIFTContent; } }
        private static int _FIELD_COUNT_SHIFTContent = default;
        private static bool _FIELD_COUNT_SHIFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_ID_SHIFT"/>
        /// </summary>
        public static int FIELD_ID_SHIFT { get { if (!_FIELD_ID_SHIFTReady) { _FIELD_ID_SHIFTContent = SGetField<int>(LocalBridgeClazz, "FIELD_ID_SHIFT"); _FIELD_ID_SHIFTReady = true; } return _FIELD_ID_SHIFTContent; } }
        private static int _FIELD_ID_SHIFTContent = default;
        private static bool _FIELD_ID_SHIFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_SHIFT"/>
        /// </summary>
        public static int FIELD_TYPE_SHIFT { get { if (!_FIELD_TYPE_SHIFTReady) { _FIELD_TYPE_SHIFTContent = SGetField<int>(LocalBridgeClazz, "FIELD_TYPE_SHIFT"); _FIELD_TYPE_SHIFTReady = true; } return _FIELD_TYPE_SHIFTContent; } }
        private static int _FIELD_TYPE_SHIFTContent = default;
        private static bool _FIELD_TYPE_SHIFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#WIRE_TYPE_END_GROUP"/>
        /// </summary>
        public static int WIRE_TYPE_END_GROUP { get { if (!_WIRE_TYPE_END_GROUPReady) { _WIRE_TYPE_END_GROUPContent = SGetField<int>(LocalBridgeClazz, "WIRE_TYPE_END_GROUP"); _WIRE_TYPE_END_GROUPReady = true; } return _WIRE_TYPE_END_GROUPContent; } }
        private static int _WIRE_TYPE_END_GROUPContent = default;
        private static bool _WIRE_TYPE_END_GROUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#WIRE_TYPE_FIXED32"/>
        /// </summary>
        public static int WIRE_TYPE_FIXED32 { get { if (!_WIRE_TYPE_FIXED32Ready) { _WIRE_TYPE_FIXED32Content = SGetField<int>(LocalBridgeClazz, "WIRE_TYPE_FIXED32"); _WIRE_TYPE_FIXED32Ready = true; } return _WIRE_TYPE_FIXED32Content; } }
        private static int _WIRE_TYPE_FIXED32Content = default;
        private static bool _WIRE_TYPE_FIXED32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#WIRE_TYPE_FIXED64"/>
        /// </summary>
        public static int WIRE_TYPE_FIXED64 { get { if (!_WIRE_TYPE_FIXED64Ready) { _WIRE_TYPE_FIXED64Content = SGetField<int>(LocalBridgeClazz, "WIRE_TYPE_FIXED64"); _WIRE_TYPE_FIXED64Ready = true; } return _WIRE_TYPE_FIXED64Content; } }
        private static int _WIRE_TYPE_FIXED64Content = default;
        private static bool _WIRE_TYPE_FIXED64Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#WIRE_TYPE_LENGTH_DELIMITED"/>
        /// </summary>
        public static int WIRE_TYPE_LENGTH_DELIMITED { get { if (!_WIRE_TYPE_LENGTH_DELIMITEDReady) { _WIRE_TYPE_LENGTH_DELIMITEDContent = SGetField<int>(LocalBridgeClazz, "WIRE_TYPE_LENGTH_DELIMITED"); _WIRE_TYPE_LENGTH_DELIMITEDReady = true; } return _WIRE_TYPE_LENGTH_DELIMITEDContent; } }
        private static int _WIRE_TYPE_LENGTH_DELIMITEDContent = default;
        private static bool _WIRE_TYPE_LENGTH_DELIMITEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#WIRE_TYPE_MASK"/>
        /// </summary>
        public static int WIRE_TYPE_MASK { get { if (!_WIRE_TYPE_MASKReady) { _WIRE_TYPE_MASKContent = SGetField<int>(LocalBridgeClazz, "WIRE_TYPE_MASK"); _WIRE_TYPE_MASKReady = true; } return _WIRE_TYPE_MASKContent; } }
        private static int _WIRE_TYPE_MASKContent = default;
        private static bool _WIRE_TYPE_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#WIRE_TYPE_START_GROUP"/>
        /// </summary>
        public static int WIRE_TYPE_START_GROUP { get { if (!_WIRE_TYPE_START_GROUPReady) { _WIRE_TYPE_START_GROUPContent = SGetField<int>(LocalBridgeClazz, "WIRE_TYPE_START_GROUP"); _WIRE_TYPE_START_GROUPReady = true; } return _WIRE_TYPE_START_GROUPContent; } }
        private static int _WIRE_TYPE_START_GROUPContent = default;
        private static bool _WIRE_TYPE_START_GROUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#WIRE_TYPE_VARINT"/>
        /// </summary>
        public static int WIRE_TYPE_VARINT { get { if (!_WIRE_TYPE_VARINTReady) { _WIRE_TYPE_VARINTContent = SGetField<int>(LocalBridgeClazz, "WIRE_TYPE_VARINT"); _WIRE_TYPE_VARINTReady = true; } return _WIRE_TYPE_VARINTContent; } }
        private static int _WIRE_TYPE_VARINTContent = default;
        private static bool _WIRE_TYPE_VARINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_COUNT_MASK"/>
        /// </summary>
        public static long FIELD_COUNT_MASK { get { if (!_FIELD_COUNT_MASKReady) { _FIELD_COUNT_MASKContent = SGetField<long>(LocalBridgeClazz, "FIELD_COUNT_MASK"); _FIELD_COUNT_MASKReady = true; } return _FIELD_COUNT_MASKContent; } }
        private static long _FIELD_COUNT_MASKContent = default;
        private static bool _FIELD_COUNT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_COUNT_PACKED"/>
        /// </summary>
        public static long FIELD_COUNT_PACKED { get { if (!_FIELD_COUNT_PACKEDReady) { _FIELD_COUNT_PACKEDContent = SGetField<long>(LocalBridgeClazz, "FIELD_COUNT_PACKED"); _FIELD_COUNT_PACKEDReady = true; } return _FIELD_COUNT_PACKEDContent; } }
        private static long _FIELD_COUNT_PACKEDContent = default;
        private static bool _FIELD_COUNT_PACKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_COUNT_REPEATED"/>
        /// </summary>
        public static long FIELD_COUNT_REPEATED { get { if (!_FIELD_COUNT_REPEATEDReady) { _FIELD_COUNT_REPEATEDContent = SGetField<long>(LocalBridgeClazz, "FIELD_COUNT_REPEATED"); _FIELD_COUNT_REPEATEDReady = true; } return _FIELD_COUNT_REPEATEDContent; } }
        private static long _FIELD_COUNT_REPEATEDContent = default;
        private static bool _FIELD_COUNT_REPEATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_COUNT_SINGLE"/>
        /// </summary>
        public static long FIELD_COUNT_SINGLE { get { if (!_FIELD_COUNT_SINGLEReady) { _FIELD_COUNT_SINGLEContent = SGetField<long>(LocalBridgeClazz, "FIELD_COUNT_SINGLE"); _FIELD_COUNT_SINGLEReady = true; } return _FIELD_COUNT_SINGLEContent; } }
        private static long _FIELD_COUNT_SINGLEContent = default;
        private static bool _FIELD_COUNT_SINGLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_COUNT_UNKNOWN"/>
        /// </summary>
        public static long FIELD_COUNT_UNKNOWN { get { if (!_FIELD_COUNT_UNKNOWNReady) { _FIELD_COUNT_UNKNOWNContent = SGetField<long>(LocalBridgeClazz, "FIELD_COUNT_UNKNOWN"); _FIELD_COUNT_UNKNOWNReady = true; } return _FIELD_COUNT_UNKNOWNContent; } }
        private static long _FIELD_COUNT_UNKNOWNContent = default;
        private static bool _FIELD_COUNT_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_BOOL"/>
        /// </summary>
        public static long FIELD_TYPE_BOOL { get { if (!_FIELD_TYPE_BOOLReady) { _FIELD_TYPE_BOOLContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_BOOL"); _FIELD_TYPE_BOOLReady = true; } return _FIELD_TYPE_BOOLContent; } }
        private static long _FIELD_TYPE_BOOLContent = default;
        private static bool _FIELD_TYPE_BOOLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_BYTES"/>
        /// </summary>
        public static long FIELD_TYPE_BYTES { get { if (!_FIELD_TYPE_BYTESReady) { _FIELD_TYPE_BYTESContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_BYTES"); _FIELD_TYPE_BYTESReady = true; } return _FIELD_TYPE_BYTESContent; } }
        private static long _FIELD_TYPE_BYTESContent = default;
        private static bool _FIELD_TYPE_BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_DOUBLE"/>
        /// </summary>
        public static long FIELD_TYPE_DOUBLE { get { if (!_FIELD_TYPE_DOUBLEReady) { _FIELD_TYPE_DOUBLEContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_DOUBLE"); _FIELD_TYPE_DOUBLEReady = true; } return _FIELD_TYPE_DOUBLEContent; } }
        private static long _FIELD_TYPE_DOUBLEContent = default;
        private static bool _FIELD_TYPE_DOUBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_ENUM"/>
        /// </summary>
        public static long FIELD_TYPE_ENUM { get { if (!_FIELD_TYPE_ENUMReady) { _FIELD_TYPE_ENUMContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_ENUM"); _FIELD_TYPE_ENUMReady = true; } return _FIELD_TYPE_ENUMContent; } }
        private static long _FIELD_TYPE_ENUMContent = default;
        private static bool _FIELD_TYPE_ENUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_FIXED32"/>
        /// </summary>
        public static long FIELD_TYPE_FIXED32 { get { if (!_FIELD_TYPE_FIXED32Ready) { _FIELD_TYPE_FIXED32Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_FIXED32"); _FIELD_TYPE_FIXED32Ready = true; } return _FIELD_TYPE_FIXED32Content; } }
        private static long _FIELD_TYPE_FIXED32Content = default;
        private static bool _FIELD_TYPE_FIXED32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_FIXED64"/>
        /// </summary>
        public static long FIELD_TYPE_FIXED64 { get { if (!_FIELD_TYPE_FIXED64Ready) { _FIELD_TYPE_FIXED64Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_FIXED64"); _FIELD_TYPE_FIXED64Ready = true; } return _FIELD_TYPE_FIXED64Content; } }
        private static long _FIELD_TYPE_FIXED64Content = default;
        private static bool _FIELD_TYPE_FIXED64Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_FLOAT"/>
        /// </summary>
        public static long FIELD_TYPE_FLOAT { get { if (!_FIELD_TYPE_FLOATReady) { _FIELD_TYPE_FLOATContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_FLOAT"); _FIELD_TYPE_FLOATReady = true; } return _FIELD_TYPE_FLOATContent; } }
        private static long _FIELD_TYPE_FLOATContent = default;
        private static bool _FIELD_TYPE_FLOATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_INT32"/>
        /// </summary>
        public static long FIELD_TYPE_INT32 { get { if (!_FIELD_TYPE_INT32Ready) { _FIELD_TYPE_INT32Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_INT32"); _FIELD_TYPE_INT32Ready = true; } return _FIELD_TYPE_INT32Content; } }
        private static long _FIELD_TYPE_INT32Content = default;
        private static bool _FIELD_TYPE_INT32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_INT64"/>
        /// </summary>
        public static long FIELD_TYPE_INT64 { get { if (!_FIELD_TYPE_INT64Ready) { _FIELD_TYPE_INT64Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_INT64"); _FIELD_TYPE_INT64Ready = true; } return _FIELD_TYPE_INT64Content; } }
        private static long _FIELD_TYPE_INT64Content = default;
        private static bool _FIELD_TYPE_INT64Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_MASK"/>
        /// </summary>
        public static long FIELD_TYPE_MASK { get { if (!_FIELD_TYPE_MASKReady) { _FIELD_TYPE_MASKContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_MASK"); _FIELD_TYPE_MASKReady = true; } return _FIELD_TYPE_MASKContent; } }
        private static long _FIELD_TYPE_MASKContent = default;
        private static bool _FIELD_TYPE_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_MESSAGE"/>
        /// </summary>
        public static long FIELD_TYPE_MESSAGE { get { if (!_FIELD_TYPE_MESSAGEReady) { _FIELD_TYPE_MESSAGEContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_MESSAGE"); _FIELD_TYPE_MESSAGEReady = true; } return _FIELD_TYPE_MESSAGEContent; } }
        private static long _FIELD_TYPE_MESSAGEContent = default;
        private static bool _FIELD_TYPE_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_SFIXED32"/>
        /// </summary>
        public static long FIELD_TYPE_SFIXED32 { get { if (!_FIELD_TYPE_SFIXED32Ready) { _FIELD_TYPE_SFIXED32Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_SFIXED32"); _FIELD_TYPE_SFIXED32Ready = true; } return _FIELD_TYPE_SFIXED32Content; } }
        private static long _FIELD_TYPE_SFIXED32Content = default;
        private static bool _FIELD_TYPE_SFIXED32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_SFIXED64"/>
        /// </summary>
        public static long FIELD_TYPE_SFIXED64 { get { if (!_FIELD_TYPE_SFIXED64Ready) { _FIELD_TYPE_SFIXED64Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_SFIXED64"); _FIELD_TYPE_SFIXED64Ready = true; } return _FIELD_TYPE_SFIXED64Content; } }
        private static long _FIELD_TYPE_SFIXED64Content = default;
        private static bool _FIELD_TYPE_SFIXED64Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_SINT32"/>
        /// </summary>
        public static long FIELD_TYPE_SINT32 { get { if (!_FIELD_TYPE_SINT32Ready) { _FIELD_TYPE_SINT32Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_SINT32"); _FIELD_TYPE_SINT32Ready = true; } return _FIELD_TYPE_SINT32Content; } }
        private static long _FIELD_TYPE_SINT32Content = default;
        private static bool _FIELD_TYPE_SINT32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_SINT64"/>
        /// </summary>
        public static long FIELD_TYPE_SINT64 { get { if (!_FIELD_TYPE_SINT64Ready) { _FIELD_TYPE_SINT64Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_SINT64"); _FIELD_TYPE_SINT64Ready = true; } return _FIELD_TYPE_SINT64Content; } }
        private static long _FIELD_TYPE_SINT64Content = default;
        private static bool _FIELD_TYPE_SINT64Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_STRING"/>
        /// </summary>
        public static long FIELD_TYPE_STRING { get { if (!_FIELD_TYPE_STRINGReady) { _FIELD_TYPE_STRINGContent = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_STRING"); _FIELD_TYPE_STRINGReady = true; } return _FIELD_TYPE_STRINGContent; } }
        private static long _FIELD_TYPE_STRINGContent = default;
        private static bool _FIELD_TYPE_STRINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_UINT32"/>
        /// </summary>
        public static long FIELD_TYPE_UINT32 { get { if (!_FIELD_TYPE_UINT32Ready) { _FIELD_TYPE_UINT32Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_UINT32"); _FIELD_TYPE_UINT32Ready = true; } return _FIELD_TYPE_UINT32Content; } }
        private static long _FIELD_TYPE_UINT32Content = default;
        private static bool _FIELD_TYPE_UINT32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#FIELD_TYPE_UINT64"/>
        /// </summary>
        public static long FIELD_TYPE_UINT64 { get { if (!_FIELD_TYPE_UINT64Ready) { _FIELD_TYPE_UINT64Content = SGetField<long>(LocalBridgeClazz, "FIELD_TYPE_UINT64"); _FIELD_TYPE_UINT64Ready = true; } return _FIELD_TYPE_UINT64Content; } }
        private static long _FIELD_TYPE_UINT64Content = default;
        private static bool _FIELD_TYPE_UINT64Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#checkFieldId(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CheckFieldId(long arg0, long arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "checkFieldId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#getFieldCountString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetFieldCountString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getFieldCountString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#getFieldIdString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetFieldIdString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getFieldIdString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#getFieldTypeString(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetFieldTypeString(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getFieldTypeString", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#getWireTypeString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetWireTypeString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getWireTypeString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#token2String(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Token2String(long arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "token2String", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#makeFieldId(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MakeFieldId(int arg0, long arg1)
        {
            return SExecute<long>(LocalBridgeClazz, "makeFieldId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#makeToken(int,boolean,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long MakeToken(int arg0, bool arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<long>(LocalBridgeClazz, "makeToken", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#getBytes()"/> 
        /// </summary>
        public byte[] Bytes
        {
            get { return IExecuteWithSignatureArray<byte>("getBytes", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#getRawSize()"/> 
        /// </summary>
        public int RawSize
        {
            get { return IExecuteWithSignature<int>("getRawSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#start(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long Start(long arg0)
        {
            return IExecuteWithSignature<long>("start", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#dump(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Dump(Java.Lang.String arg0)
        {
            IExecuteWithSignature("dump", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#end(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void End(long arg0)
        {
            IExecuteWithSignature("end", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#write(long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void Write(long arg0, bool arg1)
        {
            IExecute("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#write(long,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void Write(long arg0, byte[] arg1)
        {
            IExecute("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#write(long,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        public void Write(long arg0, double arg1)
        {
            IExecute("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#write(long,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Write(long arg0, float arg1)
        {
            IExecute("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#write(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Write(long arg0, int arg1)
        {
            IExecute("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#write(long,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Write(long arg0, Java.Lang.String arg1)
        {
            IExecute("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#write(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Write(long arg0, long arg1)
        {
            IExecute("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/proto/ProtoOutputStream.html#writeTag(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteTag(int arg0, int arg1)
        {
            IExecute("writeTag", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}