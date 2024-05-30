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

namespace Android.View.Inputmethod
{
    #region EditorInfo
    public partial class EditorInfo : Android.Text.IInputType, Android.Os.IParcelable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.View.Inputmethod.EditorInfo"/> to <see cref="Android.Text.InputType"/>
        /// </summary>
        public static implicit operator Android.Text.InputType(Android.View.Inputmethod.EditorInfo t) => t.Cast<Android.Text.InputType>();
        /// <summary>
        /// Converter from <see cref="Android.View.Inputmethod.EditorInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.View.Inputmethod.EditorInfo t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#extras"/>
        /// </summary>
        public Android.Os.Bundle extras { get { return IGetField<Android.Os.Bundle>("extras"); } set { ISetField("extras", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#hintLocales"/>
        /// </summary>
        public Android.Os.LocaleList hintLocales { get { return IGetField<Android.Os.LocaleList>("hintLocales"); } set { ISetField("hintLocales", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#actionId"/>
        /// </summary>
        public int actionId { get { return IGetField<int>("actionId"); } set { ISetField("actionId", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#fieldId"/>
        /// </summary>
        public int fieldId { get { return IGetField<int>("fieldId"); } set { ISetField("fieldId", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#imeOptions"/>
        /// </summary>
        public int imeOptions { get { return IGetField<int>("imeOptions"); } set { ISetField("imeOptions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#initialCapsMode"/>
        /// </summary>
        public int initialCapsMode { get { return IGetField<int>("initialCapsMode"); } set { ISetField("initialCapsMode", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#initialSelEnd"/>
        /// </summary>
        public int initialSelEnd { get { return IGetField<int>("initialSelEnd"); } set { ISetField("initialSelEnd", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#initialSelStart"/>
        /// </summary>
        public int initialSelStart { get { return IGetField<int>("initialSelStart"); } set { ISetField("initialSelStart", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#inputType"/>
        /// </summary>
        public int inputType { get { return IGetField<int>("inputType"); } set { ISetField("inputType", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#actionLabel"/>
        /// </summary>
        public Java.Lang.CharSequence actionLabel { get { return IGetField<Java.Lang.CharSequence>("actionLabel"); } set { ISetField("actionLabel", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#hintText"/>
        /// </summary>
        public Java.Lang.CharSequence hintText { get { return IGetField<Java.Lang.CharSequence>("hintText"); } set { ISetField("hintText", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#label"/>
        /// </summary>
        public Java.Lang.CharSequence label { get { return IGetField<Java.Lang.CharSequence>("label"); } set { ISetField("label", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#fieldName"/>
        /// </summary>
        public Java.Lang.String fieldName { get { return IGetField<Java.Lang.String>("fieldName"); } set { ISetField("fieldName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#packageName"/>
        /// </summary>
        public Java.Lang.String packageName { get { return IGetField<Java.Lang.String>("packageName"); } set { ISetField("packageName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#privateImeOptions"/>
        /// </summary>
        public Java.Lang.String privateImeOptions { get { return IGetField<Java.Lang.String>("privateImeOptions"); } set { ISetField("privateImeOptions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#contentMimeTypes"/>
        /// </summary>
        public Java.Lang.String[] contentMimeTypes { get { return IGetFieldArray<Java.Lang.String>("contentMimeTypes"); } set { ISetField("contentMimeTypes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_DONE"/>
        /// </summary>
        public static int IME_ACTION_DONE { get { if (!_IME_ACTION_DONEReady) { _IME_ACTION_DONEContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_DONE"); _IME_ACTION_DONEReady = true; } return _IME_ACTION_DONEContent; } }
        private static int _IME_ACTION_DONEContent = default;
        private static bool _IME_ACTION_DONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_GO"/>
        /// </summary>
        public static int IME_ACTION_GO { get { if (!_IME_ACTION_GOReady) { _IME_ACTION_GOContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_GO"); _IME_ACTION_GOReady = true; } return _IME_ACTION_GOContent; } }
        private static int _IME_ACTION_GOContent = default;
        private static bool _IME_ACTION_GOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_NEXT"/>
        /// </summary>
        public static int IME_ACTION_NEXT { get { if (!_IME_ACTION_NEXTReady) { _IME_ACTION_NEXTContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_NEXT"); _IME_ACTION_NEXTReady = true; } return _IME_ACTION_NEXTContent; } }
        private static int _IME_ACTION_NEXTContent = default;
        private static bool _IME_ACTION_NEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_NONE"/>
        /// </summary>
        public static int IME_ACTION_NONE { get { if (!_IME_ACTION_NONEReady) { _IME_ACTION_NONEContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_NONE"); _IME_ACTION_NONEReady = true; } return _IME_ACTION_NONEContent; } }
        private static int _IME_ACTION_NONEContent = default;
        private static bool _IME_ACTION_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_PREVIOUS"/>
        /// </summary>
        public static int IME_ACTION_PREVIOUS { get { if (!_IME_ACTION_PREVIOUSReady) { _IME_ACTION_PREVIOUSContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_PREVIOUS"); _IME_ACTION_PREVIOUSReady = true; } return _IME_ACTION_PREVIOUSContent; } }
        private static int _IME_ACTION_PREVIOUSContent = default;
        private static bool _IME_ACTION_PREVIOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_SEARCH"/>
        /// </summary>
        public static int IME_ACTION_SEARCH { get { if (!_IME_ACTION_SEARCHReady) { _IME_ACTION_SEARCHContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_SEARCH"); _IME_ACTION_SEARCHReady = true; } return _IME_ACTION_SEARCHContent; } }
        private static int _IME_ACTION_SEARCHContent = default;
        private static bool _IME_ACTION_SEARCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_SEND"/>
        /// </summary>
        public static int IME_ACTION_SEND { get { if (!_IME_ACTION_SENDReady) { _IME_ACTION_SENDContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_SEND"); _IME_ACTION_SENDReady = true; } return _IME_ACTION_SENDContent; } }
        private static int _IME_ACTION_SENDContent = default;
        private static bool _IME_ACTION_SENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_ACTION_UNSPECIFIED"/>
        /// </summary>
        public static int IME_ACTION_UNSPECIFIED { get { if (!_IME_ACTION_UNSPECIFIEDReady) { _IME_ACTION_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "IME_ACTION_UNSPECIFIED"); _IME_ACTION_UNSPECIFIEDReady = true; } return _IME_ACTION_UNSPECIFIEDContent; } }
        private static int _IME_ACTION_UNSPECIFIEDContent = default;
        private static bool _IME_ACTION_UNSPECIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_FORCE_ASCII"/>
        /// </summary>
        public static int IME_FLAG_FORCE_ASCII { get { if (!_IME_FLAG_FORCE_ASCIIReady) { _IME_FLAG_FORCE_ASCIIContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_FORCE_ASCII"); _IME_FLAG_FORCE_ASCIIReady = true; } return _IME_FLAG_FORCE_ASCIIContent; } }
        private static int _IME_FLAG_FORCE_ASCIIContent = default;
        private static bool _IME_FLAG_FORCE_ASCIIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_NAVIGATE_NEXT"/>
        /// </summary>
        public static int IME_FLAG_NAVIGATE_NEXT { get { if (!_IME_FLAG_NAVIGATE_NEXTReady) { _IME_FLAG_NAVIGATE_NEXTContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_NAVIGATE_NEXT"); _IME_FLAG_NAVIGATE_NEXTReady = true; } return _IME_FLAG_NAVIGATE_NEXTContent; } }
        private static int _IME_FLAG_NAVIGATE_NEXTContent = default;
        private static bool _IME_FLAG_NAVIGATE_NEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_NAVIGATE_PREVIOUS"/>
        /// </summary>
        public static int IME_FLAG_NAVIGATE_PREVIOUS { get { if (!_IME_FLAG_NAVIGATE_PREVIOUSReady) { _IME_FLAG_NAVIGATE_PREVIOUSContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_NAVIGATE_PREVIOUS"); _IME_FLAG_NAVIGATE_PREVIOUSReady = true; } return _IME_FLAG_NAVIGATE_PREVIOUSContent; } }
        private static int _IME_FLAG_NAVIGATE_PREVIOUSContent = default;
        private static bool _IME_FLAG_NAVIGATE_PREVIOUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_NO_ACCESSORY_ACTION"/>
        /// </summary>
        public static int IME_FLAG_NO_ACCESSORY_ACTION { get { if (!_IME_FLAG_NO_ACCESSORY_ACTIONReady) { _IME_FLAG_NO_ACCESSORY_ACTIONContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_NO_ACCESSORY_ACTION"); _IME_FLAG_NO_ACCESSORY_ACTIONReady = true; } return _IME_FLAG_NO_ACCESSORY_ACTIONContent; } }
        private static int _IME_FLAG_NO_ACCESSORY_ACTIONContent = default;
        private static bool _IME_FLAG_NO_ACCESSORY_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_NO_ENTER_ACTION"/>
        /// </summary>
        public static int IME_FLAG_NO_ENTER_ACTION { get { if (!_IME_FLAG_NO_ENTER_ACTIONReady) { _IME_FLAG_NO_ENTER_ACTIONContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_NO_ENTER_ACTION"); _IME_FLAG_NO_ENTER_ACTIONReady = true; } return _IME_FLAG_NO_ENTER_ACTIONContent; } }
        private static int _IME_FLAG_NO_ENTER_ACTIONContent = default;
        private static bool _IME_FLAG_NO_ENTER_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_NO_EXTRACT_UI"/>
        /// </summary>
        public static int IME_FLAG_NO_EXTRACT_UI { get { if (!_IME_FLAG_NO_EXTRACT_UIReady) { _IME_FLAG_NO_EXTRACT_UIContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_NO_EXTRACT_UI"); _IME_FLAG_NO_EXTRACT_UIReady = true; } return _IME_FLAG_NO_EXTRACT_UIContent; } }
        private static int _IME_FLAG_NO_EXTRACT_UIContent = default;
        private static bool _IME_FLAG_NO_EXTRACT_UIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_NO_FULLSCREEN"/>
        /// </summary>
        public static int IME_FLAG_NO_FULLSCREEN { get { if (!_IME_FLAG_NO_FULLSCREENReady) { _IME_FLAG_NO_FULLSCREENContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_NO_FULLSCREEN"); _IME_FLAG_NO_FULLSCREENReady = true; } return _IME_FLAG_NO_FULLSCREENContent; } }
        private static int _IME_FLAG_NO_FULLSCREENContent = default;
        private static bool _IME_FLAG_NO_FULLSCREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_FLAG_NO_PERSONALIZED_LEARNING"/>
        /// </summary>
        public static int IME_FLAG_NO_PERSONALIZED_LEARNING { get { if (!_IME_FLAG_NO_PERSONALIZED_LEARNINGReady) { _IME_FLAG_NO_PERSONALIZED_LEARNINGContent = SGetField<int>(LocalBridgeClazz, "IME_FLAG_NO_PERSONALIZED_LEARNING"); _IME_FLAG_NO_PERSONALIZED_LEARNINGReady = true; } return _IME_FLAG_NO_PERSONALIZED_LEARNINGContent; } }
        private static int _IME_FLAG_NO_PERSONALIZED_LEARNINGContent = default;
        private static bool _IME_FLAG_NO_PERSONALIZED_LEARNINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_MASK_ACTION"/>
        /// </summary>
        public static int IME_MASK_ACTION { get { if (!_IME_MASK_ACTIONReady) { _IME_MASK_ACTIONContent = SGetField<int>(LocalBridgeClazz, "IME_MASK_ACTION"); _IME_MASK_ACTIONReady = true; } return _IME_MASK_ACTIONContent; } }
        private static int _IME_MASK_ACTIONContent = default;
        private static bool _IME_MASK_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#IME_NULL"/>
        /// </summary>
        public static int IME_NULL { get { if (!_IME_NULLReady) { _IME_NULLContent = SGetField<int>(LocalBridgeClazz, "IME_NULL"); _IME_NULLReady = true; } return _IME_NULLContent; } }
        private static int _IME_NULLContent = default;
        private static bool _IME_NULLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#getInitialToolType()"/> <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#setInitialToolType(int)"/>
        /// </summary>
        public int InitialToolType
        {
            get { return IExecuteWithSignature<int>("getInitialToolType", "()I"); } set { IExecuteWithSignature("setInitialToolType", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#getSupportedHandwritingGesturePreviews()"/> <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#setSupportedHandwritingGesturePreviews(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set SupportedHandwritingGesturePreviews
        {
            get { return IExecuteWithSignature<Java.Util.Set>("getSupportedHandwritingGesturePreviews", "()Ljava/util/Set;"); } set { IExecuteWithSignature("setSupportedHandwritingGesturePreviews", "(Ljava/util/Set;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#getSupportedHandwritingGestures()"/> <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#setSupportedHandwritingGestures(java.util.List)"/>
        /// </summary>
        public Java.Util.List SupportedHandwritingGestures
        {
            get { return IExecuteWithSignature<Java.Util.List>("getSupportedHandwritingGestures", "()Ljava/util/List;"); } set { IExecuteWithSignature("setSupportedHandwritingGestures", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#getInitialSurroundingText(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.View.Inputmethod.SurroundingText"/></returns>
        public Android.View.Inputmethod.SurroundingText GetInitialSurroundingText(int arg0, int arg1, int arg2)
        {
            return IExecute<Android.View.Inputmethod.SurroundingText>("getInitialSurroundingText", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#makeCompatible(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void MakeCompatible(int arg0)
        {
            IExecuteWithSignature("makeCompatible", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#getInitialSelectedText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetInitialSelectedText(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getInitialSelectedText", "(I)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#getInitialTextAfterCursor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetInitialTextAfterCursor(int arg0, int arg1)
        {
            return IExecute<Java.Lang.CharSequence>("getInitialTextAfterCursor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#getInitialTextBeforeCursor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetInitialTextBeforeCursor(int arg0, int arg1)
        {
            return IExecute<Java.Lang.CharSequence>("getInitialTextBeforeCursor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecute("dump", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#setInitialSurroundingSubText(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetInitialSurroundingSubText(Java.Lang.CharSequence arg0, int arg1)
        {
            IExecute("setInitialSurroundingSubText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#setInitialSurroundingText(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetInitialSurroundingText(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setInitialSurroundingText", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/EditorInfo.html#writeToParcel(android.os.Parcel,int)"/>
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