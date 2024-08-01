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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Style
{
    #region QuoteSpan
    public partial class QuoteSpan : Android.Text.Style.ILeadingMarginSpan, Android.Text.IParcelableSpan
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public QuoteSpan(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public QuoteSpan(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public QuoteSpan(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.QuoteSpan"/> to <see cref="Android.Text.Style.LeadingMarginSpan"/>
        /// </summary>
        public static implicit operator Android.Text.Style.LeadingMarginSpan(Android.Text.Style.QuoteSpan t) => t.Cast<Android.Text.Style.LeadingMarginSpan>();
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.QuoteSpan"/> to <see cref="Android.Text.ParcelableSpan"/>
        /// </summary>
        public static implicit operator Android.Text.ParcelableSpan(Android.Text.Style.QuoteSpan t) => t.Cast<Android.Text.ParcelableSpan>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#STANDARD_COLOR"/>
        /// </summary>
        public static int STANDARD_COLOR { get { if (!_STANDARD_COLORReady) { _STANDARD_COLORContent = SGetField<int>(LocalBridgeClazz, "STANDARD_COLOR"); _STANDARD_COLORReady = true; } return _STANDARD_COLORContent; } }
        private static int _STANDARD_COLORContent = default;
        private static bool _STANDARD_COLORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#STANDARD_GAP_WIDTH_PX"/>
        /// </summary>
        public static int STANDARD_GAP_WIDTH_PX { get { if (!_STANDARD_GAP_WIDTH_PXReady) { _STANDARD_GAP_WIDTH_PXContent = SGetField<int>(LocalBridgeClazz, "STANDARD_GAP_WIDTH_PX"); _STANDARD_GAP_WIDTH_PXReady = true; } return _STANDARD_GAP_WIDTH_PXContent; } }
        private static int _STANDARD_GAP_WIDTH_PXContent = default;
        private static bool _STANDARD_GAP_WIDTH_PXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#STANDARD_STRIPE_WIDTH_PX"/>
        /// </summary>
        public static int STANDARD_STRIPE_WIDTH_PX { get { if (!_STANDARD_STRIPE_WIDTH_PXReady) { _STANDARD_STRIPE_WIDTH_PXContent = SGetField<int>(LocalBridgeClazz, "STANDARD_STRIPE_WIDTH_PX"); _STANDARD_STRIPE_WIDTH_PXReady = true; } return _STANDARD_STRIPE_WIDTH_PXContent; } }
        private static int _STANDARD_STRIPE_WIDTH_PXContent = default;
        private static bool _STANDARD_STRIPE_WIDTH_PXReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#getColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetColor()
        {
            return IExecuteWithSignature<int>("getColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#getGapWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGapWidth()
        {
            return IExecuteWithSignature<int>("getGapWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#getLeadingMargin(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLeadingMargin(bool arg0)
        {
            return IExecuteWithSignature<int>("getLeadingMargin", "(Z)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#getSpanTypeId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSpanTypeId()
        {
            return IExecuteWithSignature<int>("getSpanTypeId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#getStripeWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStripeWidth()
        {
            return IExecuteWithSignature<int>("getStripeWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#drawLeadingMargin(android.graphics.Canvas,android.graphics.Paint,int,int,int,int,int,java.lang.CharSequence,int,int,boolean,android.text.Layout)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Paint"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="bool"/></param>
        /// <param name="arg11"><see cref="Android.Text.Layout"/></param>
        public void DrawLeadingMargin(Android.Graphics.Canvas arg0, Android.Graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Lang.CharSequence arg7, int arg8, int arg9, bool arg10, Android.Text.Layout arg11)
        {
            IExecute("drawLeadingMargin", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/QuoteSpan.html#writeToParcel(android.os.Parcel,int)"/>
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