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

namespace Android.Text.Style
{
    #region TextAppearanceSpan declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html"/>
    /// </summary>
    public partial class TextAppearanceSpan : Android.Text.Style.MetricAffectingSpan
    {
        const string _bridgeClassName = "android.text.style.TextAppearanceSpan";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextAppearanceSpan() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextAppearanceSpan(params object[] args) : base(args) { }
    
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

    #region TextAppearanceSpan implementation
    public partial class TextAppearanceSpan
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#%3Cinit%3E(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TextAppearanceSpan(Android.Content.Context arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public TextAppearanceSpan(Android.Content.Context arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public TextAppearanceSpan(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#%3Cinit%3E(java.lang.String,int,int,android.content.res.ColorStateList,android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Content.Res.ColorStateList"/></param>
        /// <param name="arg4"><see cref="Android.Content.Res.ColorStateList"/></param>
        public TextAppearanceSpan(Java.Lang.String arg0, int arg1, int arg2, Android.Content.Res.ColorStateList arg3, Android.Content.Res.ColorStateList arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.TextAppearanceSpan"/> to <see cref="Android.Text.ParcelableSpan"/>
        /// </summary>
        public static implicit operator Android.Text.ParcelableSpan(Android.Text.Style.TextAppearanceSpan t) => t.Cast<Android.Text.ParcelableSpan>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getLinkTextColor()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetLinkTextColor()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getLinkTextColor", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getTextColor()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetTextColor()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getTextColor", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getTypeface()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Typeface"/></returns>
        public Android.Graphics.Typeface GetTypeface()
        {
            return IExecuteWithSignature<Android.Graphics.Typeface>("getTypeface", "()Landroid/graphics/Typeface;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getTextLocales()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.LocaleList"/></returns>
        public Android.Os.LocaleList GetTextLocales()
        {
            return IExecuteWithSignature<Android.Os.LocaleList>("getTextLocales", "()Landroid/os/LocaleList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#isElegantTextHeight()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsElegantTextHeight()
        {
            return IExecuteWithSignature<bool>("isElegantTextHeight", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getLetterSpacing()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetLetterSpacing()
        {
            return IExecuteWithSignature<float>("getLetterSpacing", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getShadowDx()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetShadowDx()
        {
            return IExecuteWithSignature<float>("getShadowDx", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getShadowDy()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetShadowDy()
        {
            return IExecuteWithSignature<float>("getShadowDy", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getShadowRadius()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetShadowRadius()
        {
            return IExecuteWithSignature<float>("getShadowRadius", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getShadowColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetShadowColor()
        {
            return IExecuteWithSignature<int>("getShadowColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getSpanTypeId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSpanTypeId()
        {
            return IExecuteWithSignature<int>("getSpanTypeId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getTextFontWeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextFontWeight()
        {
            return IExecuteWithSignature<int>("getTextFontWeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getTextSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextSize()
        {
            return IExecuteWithSignature<int>("getTextSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getTextStyle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextStyle()
        {
            return IExecuteWithSignature<int>("getTextStyle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getFamily()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFamily()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFamily", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getFontFeatureSettings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFontFeatureSettings()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFontFeatureSettings", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#getFontVariationSettings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFontVariationSettings()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFontVariationSettings", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/TextAppearanceSpan.html#writeToParcel(android.os.Parcel,int)"/>
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