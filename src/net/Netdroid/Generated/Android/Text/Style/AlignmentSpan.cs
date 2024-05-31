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
    #region IAlignmentSpan
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAlignmentSpan : Android.Text.Style.IParagraphStyle
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AlignmentSpan
    public partial class AlignmentSpan : Android.Text.Style.IAlignmentSpan
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
        /// <see href="https://developer.android.com/reference/android/text/style/AlignmentSpan.html#getAlignment()"/> 
        /// </summary>
        public Android.Text.Layout.Alignment Alignment
        {
            get { return IExecuteWithSignature<Android.Text.Layout.Alignment>("getAlignment", "()Landroid/text/Layout$Alignment;"); }
        }

        #endregion

        #region Nested classes
        #region Standard
        public partial class Standard : Android.Text.Style.IAlignmentSpan, Android.Text.IParcelableSpan
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/AlignmentSpan.Standard.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public Standard(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/AlignmentSpan.Standard.html#%3Cinit%3E(android.text.Layout.Alignment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.Layout.Alignment"/></param>
            public Standard(Android.Text.Layout.Alignment arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Text.Style.AlignmentSpan.Standard"/> to <see cref="Android.Text.Style.AlignmentSpan"/>
            /// </summary>
            public static implicit operator Android.Text.Style.AlignmentSpan(Android.Text.Style.AlignmentSpan.Standard t) => t.Cast<Android.Text.Style.AlignmentSpan>();
            /// <summary>
            /// Converter from <see cref="Android.Text.Style.AlignmentSpan.Standard"/> to <see cref="Android.Text.ParcelableSpan"/>
            /// </summary>
            public static implicit operator Android.Text.ParcelableSpan(Android.Text.Style.AlignmentSpan.Standard t) => t.Cast<Android.Text.ParcelableSpan>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/AlignmentSpan.Standard.html#getAlignment()"/> 
            /// </summary>
            public Android.Text.Layout.Alignment Alignment
            {
                get { return IExecuteWithSignature<Android.Text.Layout.Alignment>("getAlignment", "()Landroid/text/Layout$Alignment;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/AlignmentSpan.Standard.html#getSpanTypeId()"/> 
            /// </summary>
            public int SpanTypeId
            {
                get { return IExecuteWithSignature<int>("getSpanTypeId", "()I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/AlignmentSpan.Standard.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/AlignmentSpan.Standard.html#writeToParcel(android.os.Parcel,int)"/>
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}