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

namespace Android.Text.Style
{
    #region ILineHeightSpan
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILineHeightSpan
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LineHeightSpan
    public partial class LineHeightSpan : Android.Text.Style.ILineHeightSpan, Android.Text.Style.IParagraphStyle, Android.Text.Style.IWrapTogetherSpan
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.LineHeightSpan"/> to <see cref="Android.Text.Style.ParagraphStyle"/>
        /// </summary>
        public static implicit operator Android.Text.Style.ParagraphStyle(Android.Text.Style.LineHeightSpan t) => t.Cast<Android.Text.Style.ParagraphStyle>();
        /// <summary>
        /// Converter from <see cref="Android.Text.Style.LineHeightSpan"/> to <see cref="Android.Text.Style.WrapTogetherSpan"/>
        /// </summary>
        public static implicit operator Android.Text.Style.WrapTogetherSpan(Android.Text.Style.LineHeightSpan t) => t.Cast<Android.Text.Style.WrapTogetherSpan>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.html#chooseHeight(java.lang.CharSequence,int,int,int,int,android.graphics.Paint.FontMetricsInt)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.Graphics.Paint.FontMetricsInt"/></param>
        public void ChooseHeight(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, Android.Graphics.Paint.FontMetricsInt arg5)
        {
            IExecute("chooseHeight", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes
        #region Standard
        public partial class Standard : Android.Text.Style.ILineHeightSpan, Android.Text.IParcelableSpan
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.Standard.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public Standard(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.Standard.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Standard(int arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Text.Style.LineHeightSpan.Standard"/> to <see cref="Android.Text.Style.LineHeightSpan"/>
            /// </summary>
            public static implicit operator Android.Text.Style.LineHeightSpan(Android.Text.Style.LineHeightSpan.Standard t) => t.Cast<Android.Text.Style.LineHeightSpan>();
            /// <summary>
            /// Converter from <see cref="Android.Text.Style.LineHeightSpan.Standard"/> to <see cref="Android.Text.ParcelableSpan"/>
            /// </summary>
            public static implicit operator Android.Text.ParcelableSpan(Android.Text.Style.LineHeightSpan.Standard t) => t.Cast<Android.Text.ParcelableSpan>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.Standard.html#getHeight()"/> 
            /// </summary>
            public int Height
            {
                get { return IExecuteWithSignature<int>("getHeight", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.Standard.html#getSpanTypeId()"/> 
            /// </summary>
            public int SpanTypeId
            {
                get { return IExecuteWithSignature<int>("getSpanTypeId", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.Standard.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.Standard.html#chooseHeight(java.lang.CharSequence,int,int,int,int,android.graphics.Paint.FontMetricsInt)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <param name="arg5"><see cref="Android.Graphics.Paint.FontMetricsInt"/></param>
            public void ChooseHeight(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, Android.Graphics.Paint.FontMetricsInt arg5)
            {
                IExecute("chooseHeight", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.Standard.html#writeToParcel(android.os.Parcel,int)"/>
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

        #region WithDensity
        public partial class WithDensity
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineHeightSpan.WithDensity.html#chooseHeight(java.lang.CharSequence,int,int,int,int,android.graphics.Paint.FontMetricsInt,android.text.TextPaint)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <param name="arg5"><see cref="Android.Graphics.Paint.FontMetricsInt"/></param>
            /// <param name="arg6"><see cref="Android.Text.TextPaint"/></param>
            public void ChooseHeight(Java.Lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, Android.Graphics.Paint.FontMetricsInt arg5, Android.Text.TextPaint arg6)
            {
                IExecute("chooseHeight", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}