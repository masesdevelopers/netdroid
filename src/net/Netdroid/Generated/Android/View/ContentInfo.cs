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

namespace Android.View
{
    #region ContentInfo
    public partial class ContentInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#FLAG_CONVERT_TO_PLAIN_TEXT"/>
        /// </summary>
        public static int FLAG_CONVERT_TO_PLAIN_TEXT { get { if (!_FLAG_CONVERT_TO_PLAIN_TEXTReady) { _FLAG_CONVERT_TO_PLAIN_TEXTContent = SGetField<int>(LocalBridgeClazz, "FLAG_CONVERT_TO_PLAIN_TEXT"); _FLAG_CONVERT_TO_PLAIN_TEXTReady = true; } return _FLAG_CONVERT_TO_PLAIN_TEXTContent; } }
        private static int _FLAG_CONVERT_TO_PLAIN_TEXTContent = default;
        private static bool _FLAG_CONVERT_TO_PLAIN_TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#SOURCE_APP"/>
        /// </summary>
        public static int SOURCE_APP { get { if (!_SOURCE_APPReady) { _SOURCE_APPContent = SGetField<int>(LocalBridgeClazz, "SOURCE_APP"); _SOURCE_APPReady = true; } return _SOURCE_APPContent; } }
        private static int _SOURCE_APPContent = default;
        private static bool _SOURCE_APPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#SOURCE_AUTOFILL"/>
        /// </summary>
        public static int SOURCE_AUTOFILL { get { if (!_SOURCE_AUTOFILLReady) { _SOURCE_AUTOFILLContent = SGetField<int>(LocalBridgeClazz, "SOURCE_AUTOFILL"); _SOURCE_AUTOFILLReady = true; } return _SOURCE_AUTOFILLContent; } }
        private static int _SOURCE_AUTOFILLContent = default;
        private static bool _SOURCE_AUTOFILLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#SOURCE_CLIPBOARD"/>
        /// </summary>
        public static int SOURCE_CLIPBOARD { get { if (!_SOURCE_CLIPBOARDReady) { _SOURCE_CLIPBOARDContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CLIPBOARD"); _SOURCE_CLIPBOARDReady = true; } return _SOURCE_CLIPBOARDContent; } }
        private static int _SOURCE_CLIPBOARDContent = default;
        private static bool _SOURCE_CLIPBOARDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#SOURCE_DRAG_AND_DROP"/>
        /// </summary>
        public static int SOURCE_DRAG_AND_DROP { get { if (!_SOURCE_DRAG_AND_DROPReady) { _SOURCE_DRAG_AND_DROPContent = SGetField<int>(LocalBridgeClazz, "SOURCE_DRAG_AND_DROP"); _SOURCE_DRAG_AND_DROPReady = true; } return _SOURCE_DRAG_AND_DROPContent; } }
        private static int _SOURCE_DRAG_AND_DROPContent = default;
        private static bool _SOURCE_DRAG_AND_DROPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#SOURCE_INPUT_METHOD"/>
        /// </summary>
        public static int SOURCE_INPUT_METHOD { get { if (!_SOURCE_INPUT_METHODReady) { _SOURCE_INPUT_METHODContent = SGetField<int>(LocalBridgeClazz, "SOURCE_INPUT_METHOD"); _SOURCE_INPUT_METHODReady = true; } return _SOURCE_INPUT_METHODContent; } }
        private static int _SOURCE_INPUT_METHODContent = default;
        private static bool _SOURCE_INPUT_METHODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#SOURCE_PROCESS_TEXT"/>
        /// </summary>
        public static int SOURCE_PROCESS_TEXT { get { if (!_SOURCE_PROCESS_TEXTReady) { _SOURCE_PROCESS_TEXTContent = SGetField<int>(LocalBridgeClazz, "SOURCE_PROCESS_TEXT"); _SOURCE_PROCESS_TEXTReady = true; } return _SOURCE_PROCESS_TEXTContent; } }
        private static int _SOURCE_PROCESS_TEXTContent = default;
        private static bool _SOURCE_PROCESS_TEXTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#getClip()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ClipData"/></returns>
        public Android.Content.ClipData GetClip()
        {
            return IExecuteWithSignature<Android.Content.ClipData>("getClip", "()Landroid/content/ClipData;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#getLinkUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetLinkUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getLinkUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#getFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFlags()
        {
            return IExecuteWithSignature<int>("getFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#getSource()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSource()
        {
            return IExecuteWithSignature<int>("getSource", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ContentInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#%3Cinit%3E(android.content.ClipData,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ClipData"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Builder(Android.Content.ClipData arg0, int arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#%3Cinit%3E(android.view.ContentInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ContentInfo"/></param>
            public Builder(Android.View.ContentInfo arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.ContentInfo"/></returns>
            public Android.View.ContentInfo Build()
            {
                return IExecuteWithSignature<Android.View.ContentInfo>("build", "()Landroid/view/ContentInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#setClip(android.content.ClipData)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.ClipData"/></param>
            /// <returns><see cref="Android.View.ContentInfo.Builder"/></returns>
            public Android.View.ContentInfo.Builder SetClip(Android.Content.ClipData arg0)
            {
                return IExecuteWithSignature<Android.View.ContentInfo.Builder>("setClip", "(Landroid/content/ClipData;)Landroid/view/ContentInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.View.ContentInfo.Builder"/></returns>
            public Android.View.ContentInfo.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.View.ContentInfo.Builder>("setExtras", "(Landroid/os/Bundle;)Landroid/view/ContentInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#setFlags(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.ContentInfo.Builder"/></returns>
            public Android.View.ContentInfo.Builder SetFlags(int arg0)
            {
                return IExecuteWithSignature<Android.View.ContentInfo.Builder>("setFlags", "(I)Landroid/view/ContentInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#setLinkUri(android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <returns><see cref="Android.View.ContentInfo.Builder"/></returns>
            public Android.View.ContentInfo.Builder SetLinkUri(Android.Net.Uri arg0)
            {
                return IExecuteWithSignature<Android.View.ContentInfo.Builder>("setLinkUri", "(Landroid/net/Uri;)Landroid/view/ContentInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/ContentInfo.Builder.html#setSource(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.ContentInfo.Builder"/></returns>
            public Android.View.ContentInfo.Builder SetSource(int arg0)
            {
                return IExecuteWithSignature<Android.View.ContentInfo.Builder>("setSource", "(I)Landroid/view/ContentInfo$Builder;", arg0);
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