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

namespace Android.View.Inputmethod
{
    #region ExtractedText declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html"/>
    /// </summary>
    public partial class ExtractedText : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.inputmethod.ExtractedText";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ExtractedText() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ExtractedText(params object[] args) : base(args) { }
    
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

    #region ExtractedText implementation
    public partial class ExtractedText
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#flags"/>
        /// </summary>
        public int flags { get { return IGetField<int>("flags"); } set { ISetField("flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#partialEndOffset"/>
        /// </summary>
        public int partialEndOffset { get { return IGetField<int>("partialEndOffset"); } set { ISetField("partialEndOffset", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#partialStartOffset"/>
        /// </summary>
        public int partialStartOffset { get { return IGetField<int>("partialStartOffset"); } set { ISetField("partialStartOffset", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#selectionEnd"/>
        /// </summary>
        public int selectionEnd { get { return IGetField<int>("selectionEnd"); } set { ISetField("selectionEnd", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#selectionStart"/>
        /// </summary>
        public int selectionStart { get { return IGetField<int>("selectionStart"); } set { ISetField("selectionStart", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#startOffset"/>
        /// </summary>
        public int startOffset { get { return IGetField<int>("startOffset"); } set { ISetField("startOffset", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#hint"/>
        /// </summary>
        public Java.Lang.CharSequence hint { get { return IGetField<Java.Lang.CharSequence>("hint"); } set { ISetField("hint", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#text"/>
        /// </summary>
        public Java.Lang.CharSequence text { get { return IGetField<Java.Lang.CharSequence>("text"); } set { ISetField("text", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#FLAG_SELECTING"/>
        /// </summary>
        public static int FLAG_SELECTING { get { if (!_FLAG_SELECTINGReady) { _FLAG_SELECTINGContent = SGetField<int>(LocalBridgeClazz, "FLAG_SELECTING"); _FLAG_SELECTINGReady = true; } return _FLAG_SELECTINGContent; } }
        private static int _FLAG_SELECTINGContent = default;
        private static bool _FLAG_SELECTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#FLAG_SINGLE_LINE"/>
        /// </summary>
        public static int FLAG_SINGLE_LINE { get { if (!_FLAG_SINGLE_LINEReady) { _FLAG_SINGLE_LINEContent = SGetField<int>(LocalBridgeClazz, "FLAG_SINGLE_LINE"); _FLAG_SINGLE_LINEReady = true; } return _FLAG_SINGLE_LINEContent; } }
        private static int _FLAG_SINGLE_LINEContent = default;
        private static bool _FLAG_SINGLE_LINEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/ExtractedText.html#writeToParcel(android.os.Parcel,int)"/>
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