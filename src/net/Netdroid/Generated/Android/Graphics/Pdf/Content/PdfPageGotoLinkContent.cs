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

namespace Android.Graphics.Pdf.Content
{
    #region PdfPageGotoLinkContent
    public partial class PdfPageGotoLinkContent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.html#%3Cinit%3E(java.util.List,android.graphics.pdf.content.PdfPageGotoLinkContent.Destination)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Pdf.Content.PdfPageGotoLinkContent.Destination"/></param>
        public PdfPageGotoLinkContent(Java.Util.List<Android.Graphics.RectF> arg0, Android.Graphics.Pdf.Content.PdfPageGotoLinkContent.Destination arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.html#getDestination()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Pdf.Content.PdfPageGotoLinkContent.Destination"/></returns>
        public Android.Graphics.Pdf.Content.PdfPageGotoLinkContent.Destination GetDestination()
        {
            return IExecuteWithSignature<Android.Graphics.Pdf.Content.PdfPageGotoLinkContent.Destination>("getDestination", "()Landroid/graphics/pdf/content/PdfPageGotoLinkContent$Destination;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.html#getBounds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Graphics.RectF> GetBounds()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Graphics.RectF>>("getBounds", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Destination
        public partial class Destination
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#%3Cinit%3E(int,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            public Destination(int arg0, float arg1, float arg2, float arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#getXCoordinate()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetXCoordinate()
            {
                return IExecuteWithSignature<float>("getXCoordinate", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#getYCoordinate()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetYCoordinate()
            {
                return IExecuteWithSignature<float>("getYCoordinate", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#getZoom()"/>
            /// </summary>
            /// <returns><see cref="float"/></returns>
            public float GetZoom()
            {
                return IExecuteWithSignature<float>("getZoom", "()F");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#getPageNumber()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetPageNumber()
            {
                return IExecuteWithSignature<int>("getPageNumber", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/content/PdfPageGotoLinkContent.Destination.html#writeToParcel(android.os.Parcel,int)"/>
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