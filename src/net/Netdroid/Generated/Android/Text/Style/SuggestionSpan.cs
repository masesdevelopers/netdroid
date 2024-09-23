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

namespace Android.Text.Style
{
    #region SuggestionSpan declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html"/>
    /// </summary>
    public partial class SuggestionSpan : Android.Text.Style.CharacterStyle
    {
        const string _bridgeClassName = "android.text.style.SuggestionSpan";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SuggestionSpan() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SuggestionSpan(params object[] args) : base(args) { }

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

    #region SuggestionSpan implementation
    public partial class SuggestionSpan
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#%3Cinit%3E(android.content.Context,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public SuggestionSpan(Android.Content.Context arg0, Java.Lang.String[] arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#%3Cinit%3E(android.content.Context,java.util.Locale,java.lang.String[],int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Class"/></param>
        public SuggestionSpan(Android.Content.Context arg0, Java.Util.Locale arg1, Java.Lang.String[] arg2, int arg3, Java.Lang.Class arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public SuggestionSpan(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#%3Cinit%3E(java.util.Locale,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public SuggestionSpan(Java.Util.Locale arg0, Java.Lang.String[] arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.SuggestionSpan"/> to <see cref="Android.Text.ParcelableSpan"/>
        /// </summary>
        public static implicit operator Android.Text.ParcelableSpan(Android.Text.Style.SuggestionSpan t) => t.Cast<Android.Text.ParcelableSpan>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#FLAG_AUTO_CORRECTION"/>
        /// </summary>
        public static int FLAG_AUTO_CORRECTION { get { if (!_FLAG_AUTO_CORRECTIONReady) { _FLAG_AUTO_CORRECTIONContent = SGetField<int>(LocalBridgeClazz, "FLAG_AUTO_CORRECTION"); _FLAG_AUTO_CORRECTIONReady = true; } return _FLAG_AUTO_CORRECTIONContent; } }
        private static int _FLAG_AUTO_CORRECTIONContent = default;
        private static bool _FLAG_AUTO_CORRECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#FLAG_EASY_CORRECT"/>
        /// </summary>
        public static int FLAG_EASY_CORRECT { get { if (!_FLAG_EASY_CORRECTReady) { _FLAG_EASY_CORRECTContent = SGetField<int>(LocalBridgeClazz, "FLAG_EASY_CORRECT"); _FLAG_EASY_CORRECTReady = true; } return _FLAG_EASY_CORRECTContent; } }
        private static int _FLAG_EASY_CORRECTContent = default;
        private static bool _FLAG_EASY_CORRECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#FLAG_GRAMMAR_ERROR"/>
        /// </summary>
        public static int FLAG_GRAMMAR_ERROR { get { if (!_FLAG_GRAMMAR_ERRORReady) { _FLAG_GRAMMAR_ERRORContent = SGetField<int>(LocalBridgeClazz, "FLAG_GRAMMAR_ERROR"); _FLAG_GRAMMAR_ERRORReady = true; } return _FLAG_GRAMMAR_ERRORContent; } }
        private static int _FLAG_GRAMMAR_ERRORContent = default;
        private static bool _FLAG_GRAMMAR_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#FLAG_MISSPELLED"/>
        /// </summary>
        public static int FLAG_MISSPELLED { get { if (!_FLAG_MISSPELLEDReady) { _FLAG_MISSPELLEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_MISSPELLED"); _FLAG_MISSPELLEDReady = true; } return _FLAG_MISSPELLEDContent; } }
        private static int _FLAG_MISSPELLEDContent = default;
        private static bool _FLAG_MISSPELLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#SUGGESTIONS_MAX_SIZE"/>
        /// </summary>
        public static int SUGGESTIONS_MAX_SIZE { get { if (!_SUGGESTIONS_MAX_SIZEReady) { _SUGGESTIONS_MAX_SIZEContent = SGetField<int>(LocalBridgeClazz, "SUGGESTIONS_MAX_SIZE"); _SUGGESTIONS_MAX_SIZEReady = true; } return _SUGGESTIONS_MAX_SIZEContent; } }
        private static int _SUGGESTIONS_MAX_SIZEContent = default;
        private static bool _SUGGESTIONS_MAX_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#ACTION_SUGGESTION_PICKED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String ACTION_SUGGESTION_PICKED { get { if (!_ACTION_SUGGESTION_PICKEDReady) { _ACTION_SUGGESTION_PICKEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SUGGESTION_PICKED"); _ACTION_SUGGESTION_PICKEDReady = true; } return _ACTION_SUGGESTION_PICKEDContent; } }
        private static Java.Lang.String _ACTION_SUGGESTION_PICKEDContent = default;
        private static bool _ACTION_SUGGESTION_PICKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#SUGGESTION_SPAN_PICKED_AFTER"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SUGGESTION_SPAN_PICKED_AFTER { get { if (!_SUGGESTION_SPAN_PICKED_AFTERReady) { _SUGGESTION_SPAN_PICKED_AFTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUGGESTION_SPAN_PICKED_AFTER"); _SUGGESTION_SPAN_PICKED_AFTERReady = true; } return _SUGGESTION_SPAN_PICKED_AFTERContent; } }
        private static Java.Lang.String _SUGGESTION_SPAN_PICKED_AFTERContent = default;
        private static bool _SUGGESTION_SPAN_PICKED_AFTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#SUGGESTION_SPAN_PICKED_BEFORE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SUGGESTION_SPAN_PICKED_BEFORE { get { if (!_SUGGESTION_SPAN_PICKED_BEFOREReady) { _SUGGESTION_SPAN_PICKED_BEFOREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUGGESTION_SPAN_PICKED_BEFORE"); _SUGGESTION_SPAN_PICKED_BEFOREReady = true; } return _SUGGESTION_SPAN_PICKED_BEFOREContent; } }
        private static Java.Lang.String _SUGGESTION_SPAN_PICKED_BEFOREContent = default;
        private static bool _SUGGESTION_SPAN_PICKED_BEFOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#SUGGESTION_SPAN_PICKED_HASHCODE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SUGGESTION_SPAN_PICKED_HASHCODE { get { if (!_SUGGESTION_SPAN_PICKED_HASHCODEReady) { _SUGGESTION_SPAN_PICKED_HASHCODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUGGESTION_SPAN_PICKED_HASHCODE"); _SUGGESTION_SPAN_PICKED_HASHCODEReady = true; } return _SUGGESTION_SPAN_PICKED_HASHCODEContent; } }
        private static Java.Lang.String _SUGGESTION_SPAN_PICKED_HASHCODEContent = default;
        private static bool _SUGGESTION_SPAN_PICKED_HASHCODEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#getFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFlags()
        {
            return IExecuteWithSignature<int>("getFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#getSpanTypeId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSpanTypeId()
        {
            return IExecuteWithSignature<int>("getSpanTypeId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#getUnderlineColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetUnderlineColor()
        {
            return IExecuteWithSignature<int>("getUnderlineColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetLocale()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLocale", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#getSuggestions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetSuggestions()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getSuggestions", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#getLocaleObject()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetLocaleObject()
        {
            return IExecuteWithSignature<Java.Util.Locale>("getLocaleObject", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#setFlags(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFlags(int arg0)
        {
            IExecuteWithSignature("setFlags", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/SuggestionSpan.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}