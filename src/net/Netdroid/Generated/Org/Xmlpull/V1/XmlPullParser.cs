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

namespace Org.Xmlpull.V1
{
    #region IXmlPullParser
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXmlPullParser
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XmlPullParser
    public partial class XmlPullParser : Org.Xmlpull.V1.IXmlPullParser
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#CDSECT"/>
        /// </summary>
        public static int CDSECT { get { if (!_CDSECTReady) { _CDSECTContent = SGetField<int>(LocalBridgeClazz, "CDSECT"); _CDSECTReady = true; } return _CDSECTContent; } }
        private static int _CDSECTContent = default;
        private static bool _CDSECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#COMMENT"/>
        /// </summary>
        public static int COMMENT { get { if (!_COMMENTReady) { _COMMENTContent = SGetField<int>(LocalBridgeClazz, "COMMENT"); _COMMENTReady = true; } return _COMMENTContent; } }
        private static int _COMMENTContent = default;
        private static bool _COMMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#DOCDECL"/>
        /// </summary>
        public static int DOCDECL { get { if (!_DOCDECLReady) { _DOCDECLContent = SGetField<int>(LocalBridgeClazz, "DOCDECL"); _DOCDECLReady = true; } return _DOCDECLContent; } }
        private static int _DOCDECLContent = default;
        private static bool _DOCDECLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#END_DOCUMENT"/>
        /// </summary>
        public static int END_DOCUMENT { get { if (!_END_DOCUMENTReady) { _END_DOCUMENTContent = SGetField<int>(LocalBridgeClazz, "END_DOCUMENT"); _END_DOCUMENTReady = true; } return _END_DOCUMENTContent; } }
        private static int _END_DOCUMENTContent = default;
        private static bool _END_DOCUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#END_TAG"/>
        /// </summary>
        public static int END_TAG { get { if (!_END_TAGReady) { _END_TAGContent = SGetField<int>(LocalBridgeClazz, "END_TAG"); _END_TAGReady = true; } return _END_TAGContent; } }
        private static int _END_TAGContent = default;
        private static bool _END_TAGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#ENTITY_REF"/>
        /// </summary>
        public static int ENTITY_REF { get { if (!_ENTITY_REFReady) { _ENTITY_REFContent = SGetField<int>(LocalBridgeClazz, "ENTITY_REF"); _ENTITY_REFReady = true; } return _ENTITY_REFContent; } }
        private static int _ENTITY_REFContent = default;
        private static bool _ENTITY_REFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#IGNORABLE_WHITESPACE"/>
        /// </summary>
        public static int IGNORABLE_WHITESPACE { get { if (!_IGNORABLE_WHITESPACEReady) { _IGNORABLE_WHITESPACEContent = SGetField<int>(LocalBridgeClazz, "IGNORABLE_WHITESPACE"); _IGNORABLE_WHITESPACEReady = true; } return _IGNORABLE_WHITESPACEContent; } }
        private static int _IGNORABLE_WHITESPACEContent = default;
        private static bool _IGNORABLE_WHITESPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#PROCESSING_INSTRUCTION"/>
        /// </summary>
        public static int PROCESSING_INSTRUCTION { get { if (!_PROCESSING_INSTRUCTIONReady) { _PROCESSING_INSTRUCTIONContent = SGetField<int>(LocalBridgeClazz, "PROCESSING_INSTRUCTION"); _PROCESSING_INSTRUCTIONReady = true; } return _PROCESSING_INSTRUCTIONContent; } }
        private static int _PROCESSING_INSTRUCTIONContent = default;
        private static bool _PROCESSING_INSTRUCTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#START_DOCUMENT"/>
        /// </summary>
        public static int START_DOCUMENT { get { if (!_START_DOCUMENTReady) { _START_DOCUMENTContent = SGetField<int>(LocalBridgeClazz, "START_DOCUMENT"); _START_DOCUMENTReady = true; } return _START_DOCUMENTContent; } }
        private static int _START_DOCUMENTContent = default;
        private static bool _START_DOCUMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#START_TAG"/>
        /// </summary>
        public static int START_TAG { get { if (!_START_TAGReady) { _START_TAGContent = SGetField<int>(LocalBridgeClazz, "START_TAG"); _START_TAGReady = true; } return _START_TAGContent; } }
        private static int _START_TAGContent = default;
        private static bool _START_TAGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#TEXT"/>
        /// </summary>
        public static int TEXT { get { if (!_TEXTReady) { _TEXTContent = SGetField<int>(LocalBridgeClazz, "TEXT"); _TEXTReady = true; } return _TEXTContent; } }
        private static int _TEXTContent = default;
        private static bool _TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#FEATURE_PROCESS_DOCDECL"/>
        /// </summary>
        public static Java.Lang.String FEATURE_PROCESS_DOCDECL { get { if (!_FEATURE_PROCESS_DOCDECLReady) { _FEATURE_PROCESS_DOCDECLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_PROCESS_DOCDECL"); _FEATURE_PROCESS_DOCDECLReady = true; } return _FEATURE_PROCESS_DOCDECLContent; } }
        private static Java.Lang.String _FEATURE_PROCESS_DOCDECLContent = default;
        private static bool _FEATURE_PROCESS_DOCDECLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#FEATURE_PROCESS_NAMESPACES"/>
        /// </summary>
        public static Java.Lang.String FEATURE_PROCESS_NAMESPACES { get { if (!_FEATURE_PROCESS_NAMESPACESReady) { _FEATURE_PROCESS_NAMESPACESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_PROCESS_NAMESPACES"); _FEATURE_PROCESS_NAMESPACESReady = true; } return _FEATURE_PROCESS_NAMESPACESContent; } }
        private static Java.Lang.String _FEATURE_PROCESS_NAMESPACESContent = default;
        private static bool _FEATURE_PROCESS_NAMESPACESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#FEATURE_REPORT_NAMESPACE_ATTRIBUTES"/>
        /// </summary>
        public static Java.Lang.String FEATURE_REPORT_NAMESPACE_ATTRIBUTES { get { if (!_FEATURE_REPORT_NAMESPACE_ATTRIBUTESReady) { _FEATURE_REPORT_NAMESPACE_ATTRIBUTESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_REPORT_NAMESPACE_ATTRIBUTES"); _FEATURE_REPORT_NAMESPACE_ATTRIBUTESReady = true; } return _FEATURE_REPORT_NAMESPACE_ATTRIBUTESContent; } }
        private static Java.Lang.String _FEATURE_REPORT_NAMESPACE_ATTRIBUTESContent = default;
        private static bool _FEATURE_REPORT_NAMESPACE_ATTRIBUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#FEATURE_VALIDATION"/>
        /// </summary>
        public static Java.Lang.String FEATURE_VALIDATION { get { if (!_FEATURE_VALIDATIONReady) { _FEATURE_VALIDATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE_VALIDATION"); _FEATURE_VALIDATIONReady = true; } return _FEATURE_VALIDATIONContent; } }
        private static Java.Lang.String _FEATURE_VALIDATIONContent = default;
        private static bool _FEATURE_VALIDATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#NO_NAMESPACE"/>
        /// </summary>
        public static Java.Lang.String NO_NAMESPACE { get { if (!_NO_NAMESPACEReady) { _NO_NAMESPACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NO_NAMESPACE"); _NO_NAMESPACEReady = true; } return _NO_NAMESPACEContent; } }
        private static Java.Lang.String _NO_NAMESPACEContent = default;
        private static bool _NO_NAMESPACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#TYPES"/>
        /// </summary>
        public static Java.Lang.String[] TYPES { get { if (!_TYPESReady) { _TYPESContent = SGetFieldArray<Java.Lang.String>(LocalBridgeClazz, "TYPES"); _TYPESReady = true; } return _TYPESContent; } }
        private static Java.Lang.String[] _TYPESContent = default;
        private static bool _TYPESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getAttributeCount()"/> 
        /// </summary>
        public int AttributeCount
        {
            get { return IExecuteWithSignature<int>("getAttributeCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getColumnNumber()"/> 
        /// </summary>
        public int ColumnNumber
        {
            get { return IExecuteWithSignature<int>("getColumnNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getDepth()"/> 
        /// </summary>
        public int Depth
        {
            get { return IExecuteWithSignature<int>("getDepth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getEventType()"/> 
        /// </summary>
        public int EventType
        {
            get { return IExecuteWithSignature<int>("getEventType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getInputEncoding()"/> 
        /// </summary>
        public Java.Lang.String InputEncoding
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getInputEncoding", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getLineNumber()"/> 
        /// </summary>
        public int LineNumber
        {
            get { return IExecuteWithSignature<int>("getLineNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getNamespace()"/> 
        /// </summary>
        public Java.Lang.String Namespace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNamespace", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getPositionDescription()"/> 
        /// </summary>
        public Java.Lang.String PositionDescription
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPositionDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getPrefix()"/> 
        /// </summary>
        public Java.Lang.String Prefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrefix", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getText()"/> 
        /// </summary>
        public Java.Lang.String Text
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#isAttributeDefault(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAttributeDefault(int arg0)
        {
            return IExecuteWithSignature<bool>("isAttributeDefault", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#isEmptyElementTag()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public bool IsEmptyElementTag()
        {
            return IExecuteWithSignature<bool>("isEmptyElementTag", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#isWhitespace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public bool IsWhitespace()
        {
            return IExecuteWithSignature<bool>("isWhitespace", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getTextCharacters(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char[] GetTextCharacters(int[] arg0)
        {
            return IExecuteWithSignatureArray<char>("getTextCharacters", "([I)[C", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getNamespaceCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public int GetNamespaceCount(int arg0)
        {
            return IExecuteWithSignature<int>("getNamespaceCount", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#next()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public int Next()
        {
            return IExecuteWithSignature<int>("next", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#nextTag()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public int NextTag()
        {
            return IExecuteWithSignature<int>("nextTag", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#nextToken()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public int NextToken()
        {
            return IExecuteWithSignature<int>("nextToken", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getAttributeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getAttributeNamespace(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeNamespace(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeNamespace", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getAttributePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributePrefix(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributePrefix", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getAttributeType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeType(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeType", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getAttributeValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeValue(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAttributeValue", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getAttributeValue(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAttributeValue(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("getAttributeValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNamespace(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespace", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getNamespacePrefix(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public Java.Lang.String GetNamespacePrefix(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespacePrefix", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#getNamespaceUri(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public Java.Lang.String GetNamespaceUri(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getNamespaceUri", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#nextText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public Java.Lang.String NextText()
        {
            return IExecuteWithSignature<Java.Lang.String>("nextText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#defineEntityReplacementText(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public void DefineEntityReplacementText(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("defineEntityReplacementText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#require(int,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public void Require(int arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("require", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#setInput(java.io.InputStream,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public void SetInput(Java.Io.InputStream arg0, Java.Lang.String arg1)
        {
            IExecute("setInput", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#setInput(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public void SetInput(Java.Io.Reader arg0)
        {
            IExecuteWithSignature("setInput", "(Ljava/io/Reader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xmlpull/v1/XmlPullParser.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xmlpull.V1.XmlPullParserException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}