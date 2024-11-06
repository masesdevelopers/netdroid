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

namespace Android.View.Textservice
{
    #region SuggestionsInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html"/>
    /// </summary>
    public partial class SuggestionsInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.textservice.SuggestionsInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SuggestionsInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SuggestionsInfo(params object[] args) : base(args) { }
    
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

    #region SuggestionsInfo implementation
    public partial class SuggestionsInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public SuggestionsInfo(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#%3Cinit%3E(int,java.lang.String[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SuggestionsInfo(int arg0, Java.Lang.String[] arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#%3Cinit%3E(int,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public SuggestionsInfo(int arg0, Java.Lang.String[] arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONS"/>
        /// </summary>
        public static int RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONS { get { if (!_RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONSReady) { _RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONSContent = SGetField<int>(LocalBridgeClazz, "RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONS"); _RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONSReady = true; } return _RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONSContent; } }
        private static int _RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONSContent = default;
        private static bool _RESULT_ATTR_DONT_SHOW_UI_FOR_SUGGESTIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS"/>
        /// </summary>
        public static int RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS { get { if (!_RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONSReady) { _RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONSContent = SGetField<int>(LocalBridgeClazz, "RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONS"); _RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONSReady = true; } return _RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONSContent; } }
        private static int _RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONSContent = default;
        private static bool _RESULT_ATTR_HAS_RECOMMENDED_SUGGESTIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#RESULT_ATTR_IN_THE_DICTIONARY"/>
        /// </summary>
        public static int RESULT_ATTR_IN_THE_DICTIONARY { get { if (!_RESULT_ATTR_IN_THE_DICTIONARYReady) { _RESULT_ATTR_IN_THE_DICTIONARYContent = SGetField<int>(LocalBridgeClazz, "RESULT_ATTR_IN_THE_DICTIONARY"); _RESULT_ATTR_IN_THE_DICTIONARYReady = true; } return _RESULT_ATTR_IN_THE_DICTIONARYContent; } }
        private static int _RESULT_ATTR_IN_THE_DICTIONARYContent = default;
        private static bool _RESULT_ATTR_IN_THE_DICTIONARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERROR"/>
        /// </summary>
        public static int RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERROR { get { if (!_RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERRORReady) { _RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERRORContent = SGetField<int>(LocalBridgeClazz, "RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERROR"); _RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERRORReady = true; } return _RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERRORContent; } }
        private static int _RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERRORContent = default;
        private static bool _RESULT_ATTR_LOOKS_LIKE_GRAMMAR_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#RESULT_ATTR_LOOKS_LIKE_TYPO"/>
        /// </summary>
        public static int RESULT_ATTR_LOOKS_LIKE_TYPO { get { if (!_RESULT_ATTR_LOOKS_LIKE_TYPOReady) { _RESULT_ATTR_LOOKS_LIKE_TYPOContent = SGetField<int>(LocalBridgeClazz, "RESULT_ATTR_LOOKS_LIKE_TYPO"); _RESULT_ATTR_LOOKS_LIKE_TYPOReady = true; } return _RESULT_ATTR_LOOKS_LIKE_TYPOContent; } }
        private static int _RESULT_ATTR_LOOKS_LIKE_TYPOContent = default;
        private static bool _RESULT_ATTR_LOOKS_LIKE_TYPOReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#getCookie()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCookie()
        {
            return IExecuteWithSignature<int>("getCookie", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#getSequence()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSequence()
        {
            return IExecuteWithSignature<int>("getSequence", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#getSuggestionsAttributes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSuggestionsAttributes()
        {
            return IExecuteWithSignature<int>("getSuggestionsAttributes", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#getSuggestionsCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSuggestionsCount()
        {
            return IExecuteWithSignature<int>("getSuggestionsCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#getSuggestionAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSuggestionAt(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getSuggestionAt", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#setCookieAndSequence(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetCookieAndSequence(int arg0, int arg1)
        {
            IExecuteWithSignature("setCookieAndSequence", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textservice/SuggestionsInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}