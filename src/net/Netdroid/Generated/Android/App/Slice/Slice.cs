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

namespace Android.App.Slice
{
    #region Slice
    public partial class Slice
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#EXTRA_RANGE_VALUE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RANGE_VALUE { get { if (!_EXTRA_RANGE_VALUEReady) { _EXTRA_RANGE_VALUEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RANGE_VALUE"); _EXTRA_RANGE_VALUEReady = true; } return _EXTRA_RANGE_VALUEContent; } }
        private static Java.Lang.String _EXTRA_RANGE_VALUEContent = default;
        private static bool _EXTRA_RANGE_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#EXTRA_TOGGLE_STATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_TOGGLE_STATE { get { if (!_EXTRA_TOGGLE_STATEReady) { _EXTRA_TOGGLE_STATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_TOGGLE_STATE"); _EXTRA_TOGGLE_STATEReady = true; } return _EXTRA_TOGGLE_STATEContent; } }
        private static Java.Lang.String _EXTRA_TOGGLE_STATEContent = default;
        private static bool _EXTRA_TOGGLE_STATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_ACTIONS"/>
        /// </summary>
        public static Java.Lang.String HINT_ACTIONS { get { if (!_HINT_ACTIONSReady) { _HINT_ACTIONSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_ACTIONS"); _HINT_ACTIONSReady = true; } return _HINT_ACTIONSContent; } }
        private static Java.Lang.String _HINT_ACTIONSContent = default;
        private static bool _HINT_ACTIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_ERROR"/>
        /// </summary>
        public static Java.Lang.String HINT_ERROR { get { if (!_HINT_ERRORReady) { _HINT_ERRORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_ERROR"); _HINT_ERRORReady = true; } return _HINT_ERRORContent; } }
        private static Java.Lang.String _HINT_ERRORContent = default;
        private static bool _HINT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_HORIZONTAL"/>
        /// </summary>
        public static Java.Lang.String HINT_HORIZONTAL { get { if (!_HINT_HORIZONTALReady) { _HINT_HORIZONTALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_HORIZONTAL"); _HINT_HORIZONTALReady = true; } return _HINT_HORIZONTALContent; } }
        private static Java.Lang.String _HINT_HORIZONTALContent = default;
        private static bool _HINT_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_KEYWORDS"/>
        /// </summary>
        public static Java.Lang.String HINT_KEYWORDS { get { if (!_HINT_KEYWORDSReady) { _HINT_KEYWORDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_KEYWORDS"); _HINT_KEYWORDSReady = true; } return _HINT_KEYWORDSContent; } }
        private static Java.Lang.String _HINT_KEYWORDSContent = default;
        private static bool _HINT_KEYWORDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_LARGE"/>
        /// </summary>
        public static Java.Lang.String HINT_LARGE { get { if (!_HINT_LARGEReady) { _HINT_LARGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_LARGE"); _HINT_LARGEReady = true; } return _HINT_LARGEContent; } }
        private static Java.Lang.String _HINT_LARGEContent = default;
        private static bool _HINT_LARGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_LAST_UPDATED"/>
        /// </summary>
        public static Java.Lang.String HINT_LAST_UPDATED { get { if (!_HINT_LAST_UPDATEDReady) { _HINT_LAST_UPDATEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_LAST_UPDATED"); _HINT_LAST_UPDATEDReady = true; } return _HINT_LAST_UPDATEDContent; } }
        private static Java.Lang.String _HINT_LAST_UPDATEDContent = default;
        private static bool _HINT_LAST_UPDATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_LIST"/>
        /// </summary>
        public static Java.Lang.String HINT_LIST { get { if (!_HINT_LISTReady) { _HINT_LISTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_LIST"); _HINT_LISTReady = true; } return _HINT_LISTContent; } }
        private static Java.Lang.String _HINT_LISTContent = default;
        private static bool _HINT_LISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_LIST_ITEM"/>
        /// </summary>
        public static Java.Lang.String HINT_LIST_ITEM { get { if (!_HINT_LIST_ITEMReady) { _HINT_LIST_ITEMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_LIST_ITEM"); _HINT_LIST_ITEMReady = true; } return _HINT_LIST_ITEMContent; } }
        private static Java.Lang.String _HINT_LIST_ITEMContent = default;
        private static bool _HINT_LIST_ITEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_NO_TINT"/>
        /// </summary>
        public static Java.Lang.String HINT_NO_TINT { get { if (!_HINT_NO_TINTReady) { _HINT_NO_TINTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_NO_TINT"); _HINT_NO_TINTReady = true; } return _HINT_NO_TINTContent; } }
        private static Java.Lang.String _HINT_NO_TINTContent = default;
        private static bool _HINT_NO_TINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_PARTIAL"/>
        /// </summary>
        public static Java.Lang.String HINT_PARTIAL { get { if (!_HINT_PARTIALReady) { _HINT_PARTIALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_PARTIAL"); _HINT_PARTIALReady = true; } return _HINT_PARTIALContent; } }
        private static Java.Lang.String _HINT_PARTIALContent = default;
        private static bool _HINT_PARTIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_PERMISSION_REQUEST"/>
        /// </summary>
        public static Java.Lang.String HINT_PERMISSION_REQUEST { get { if (!_HINT_PERMISSION_REQUESTReady) { _HINT_PERMISSION_REQUESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_PERMISSION_REQUEST"); _HINT_PERMISSION_REQUESTReady = true; } return _HINT_PERMISSION_REQUESTContent; } }
        private static Java.Lang.String _HINT_PERMISSION_REQUESTContent = default;
        private static bool _HINT_PERMISSION_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_SEE_MORE"/>
        /// </summary>
        public static Java.Lang.String HINT_SEE_MORE { get { if (!_HINT_SEE_MOREReady) { _HINT_SEE_MOREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_SEE_MORE"); _HINT_SEE_MOREReady = true; } return _HINT_SEE_MOREContent; } }
        private static Java.Lang.String _HINT_SEE_MOREContent = default;
        private static bool _HINT_SEE_MOREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_SELECTED"/>
        /// </summary>
        public static Java.Lang.String HINT_SELECTED { get { if (!_HINT_SELECTEDReady) { _HINT_SELECTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_SELECTED"); _HINT_SELECTEDReady = true; } return _HINT_SELECTEDContent; } }
        private static Java.Lang.String _HINT_SELECTEDContent = default;
        private static bool _HINT_SELECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_SHORTCUT"/>
        /// </summary>
        public static Java.Lang.String HINT_SHORTCUT { get { if (!_HINT_SHORTCUTReady) { _HINT_SHORTCUTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_SHORTCUT"); _HINT_SHORTCUTReady = true; } return _HINT_SHORTCUTContent; } }
        private static Java.Lang.String _HINT_SHORTCUTContent = default;
        private static bool _HINT_SHORTCUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_SUMMARY"/>
        /// </summary>
        public static Java.Lang.String HINT_SUMMARY { get { if (!_HINT_SUMMARYReady) { _HINT_SUMMARYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_SUMMARY"); _HINT_SUMMARYReady = true; } return _HINT_SUMMARYContent; } }
        private static Java.Lang.String _HINT_SUMMARYContent = default;
        private static bool _HINT_SUMMARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_TITLE"/>
        /// </summary>
        public static Java.Lang.String HINT_TITLE { get { if (!_HINT_TITLEReady) { _HINT_TITLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_TITLE"); _HINT_TITLEReady = true; } return _HINT_TITLEContent; } }
        private static Java.Lang.String _HINT_TITLEContent = default;
        private static bool _HINT_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#HINT_TTL"/>
        /// </summary>
        public static Java.Lang.String HINT_TTL { get { if (!_HINT_TTLReady) { _HINT_TTLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINT_TTL"); _HINT_TTLReady = true; } return _HINT_TTLContent; } }
        private static Java.Lang.String _HINT_TTLContent = default;
        private static bool _HINT_TTLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_COLOR"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_COLOR { get { if (!_SUBTYPE_COLORReady) { _SUBTYPE_COLORContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_COLOR"); _SUBTYPE_COLORReady = true; } return _SUBTYPE_COLORContent; } }
        private static Java.Lang.String _SUBTYPE_COLORContent = default;
        private static bool _SUBTYPE_COLORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_CONTENT_DESCRIPTION"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_CONTENT_DESCRIPTION { get { if (!_SUBTYPE_CONTENT_DESCRIPTIONReady) { _SUBTYPE_CONTENT_DESCRIPTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_CONTENT_DESCRIPTION"); _SUBTYPE_CONTENT_DESCRIPTIONReady = true; } return _SUBTYPE_CONTENT_DESCRIPTIONContent; } }
        private static Java.Lang.String _SUBTYPE_CONTENT_DESCRIPTIONContent = default;
        private static bool _SUBTYPE_CONTENT_DESCRIPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_LAYOUT_DIRECTION"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_LAYOUT_DIRECTION { get { if (!_SUBTYPE_LAYOUT_DIRECTIONReady) { _SUBTYPE_LAYOUT_DIRECTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_LAYOUT_DIRECTION"); _SUBTYPE_LAYOUT_DIRECTIONReady = true; } return _SUBTYPE_LAYOUT_DIRECTIONContent; } }
        private static Java.Lang.String _SUBTYPE_LAYOUT_DIRECTIONContent = default;
        private static bool _SUBTYPE_LAYOUT_DIRECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_MAX"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_MAX { get { if (!_SUBTYPE_MAXReady) { _SUBTYPE_MAXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_MAX"); _SUBTYPE_MAXReady = true; } return _SUBTYPE_MAXContent; } }
        private static Java.Lang.String _SUBTYPE_MAXContent = default;
        private static bool _SUBTYPE_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_MESSAGE"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_MESSAGE { get { if (!_SUBTYPE_MESSAGEReady) { _SUBTYPE_MESSAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_MESSAGE"); _SUBTYPE_MESSAGEReady = true; } return _SUBTYPE_MESSAGEContent; } }
        private static Java.Lang.String _SUBTYPE_MESSAGEContent = default;
        private static bool _SUBTYPE_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_MILLIS"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_MILLIS { get { if (!_SUBTYPE_MILLISReady) { _SUBTYPE_MILLISContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_MILLIS"); _SUBTYPE_MILLISReady = true; } return _SUBTYPE_MILLISContent; } }
        private static Java.Lang.String _SUBTYPE_MILLISContent = default;
        private static bool _SUBTYPE_MILLISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_PRIORITY"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_PRIORITY { get { if (!_SUBTYPE_PRIORITYReady) { _SUBTYPE_PRIORITYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_PRIORITY"); _SUBTYPE_PRIORITYReady = true; } return _SUBTYPE_PRIORITYContent; } }
        private static Java.Lang.String _SUBTYPE_PRIORITYContent = default;
        private static bool _SUBTYPE_PRIORITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_RANGE"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_RANGE { get { if (!_SUBTYPE_RANGEReady) { _SUBTYPE_RANGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_RANGE"); _SUBTYPE_RANGEReady = true; } return _SUBTYPE_RANGEContent; } }
        private static Java.Lang.String _SUBTYPE_RANGEContent = default;
        private static bool _SUBTYPE_RANGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_SOURCE"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_SOURCE { get { if (!_SUBTYPE_SOURCEReady) { _SUBTYPE_SOURCEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_SOURCE"); _SUBTYPE_SOURCEReady = true; } return _SUBTYPE_SOURCEContent; } }
        private static Java.Lang.String _SUBTYPE_SOURCEContent = default;
        private static bool _SUBTYPE_SOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_TOGGLE"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_TOGGLE { get { if (!_SUBTYPE_TOGGLEReady) { _SUBTYPE_TOGGLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_TOGGLE"); _SUBTYPE_TOGGLEReady = true; } return _SUBTYPE_TOGGLEContent; } }
        private static Java.Lang.String _SUBTYPE_TOGGLEContent = default;
        private static bool _SUBTYPE_TOGGLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#SUBTYPE_VALUE"/>
        /// </summary>
        public static Java.Lang.String SUBTYPE_VALUE { get { if (!_SUBTYPE_VALUEReady) { _SUBTYPE_VALUEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SUBTYPE_VALUE"); _SUBTYPE_VALUEReady = true; } return _SUBTYPE_VALUEContent; } }
        private static Java.Lang.String _SUBTYPE_VALUEContent = default;
        private static bool _SUBTYPE_VALUEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#getHints()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> Hints
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getHints", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#getItems()"/> 
        /// </summary>
        public Java.Util.List<Android.App.Slice.SliceItem> Items
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.App.Slice.SliceItem>>("getItems", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#getSpec()"/> 
        /// </summary>
        public Android.App.Slice.SliceSpec Spec
        {
            get { return IExecuteWithSignature<Android.App.Slice.SliceSpec>("getSpec", "()Landroid/app/slice/SliceSpec;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#getUri()"/> 
        /// </summary>
        public Android.Net.Uri Uri
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getUri", "()Landroid/net/Uri;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#isCallerNeeded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCallerNeeded()
        {
            return IExecuteWithSignature<bool>("isCallerNeeded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/Slice.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#%3Cinit%3E(android.app.slice.Slice.Builder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Slice.Slice.Builder"/></param>
            public Builder(Android.App.Slice.Slice.Builder arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#%3Cinit%3E(android.net.Uri,android.app.slice.SliceSpec)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.App.Slice.SliceSpec"/></param>
            public Builder(Android.Net.Uri arg0, Android.App.Slice.SliceSpec arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Slice.Slice"/></returns>
            public Android.App.Slice.Slice Build()
            {
                return IExecuteWithSignature<Android.App.Slice.Slice>("build", "()Landroid/app/slice/Slice;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addAction(android.app.PendingIntent,android.app.slice.Slice,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
            /// <param name="arg1"><see cref="Android.App.Slice.Slice"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddAction(Android.App.PendingIntent arg0, Android.App.Slice.Slice arg1, Java.Lang.String arg2)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addAction", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addBundle(android.os.Bundle,java.lang.String,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddBundle(Android.Os.Bundle arg0, Java.Lang.String arg1, Java.Util.List<Java.Lang.String> arg2)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addBundle", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addHints(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddHints(Java.Util.List<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Slice.Slice.Builder>("addHints", "(Ljava/util/List;)Landroid/app/slice/Slice$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addIcon(android.graphics.drawable.Icon,java.lang.String,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddIcon(Android.Graphics.Drawable.Icon arg0, Java.Lang.String arg1, Java.Util.List<Java.Lang.String> arg2)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addIcon", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addInt(int,java.lang.String,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddInt(int arg0, Java.Lang.String arg1, Java.Util.List<Java.Lang.String> arg2)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addInt", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addLong(long,java.lang.String,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddLong(long arg0, Java.Lang.String arg1, Java.Util.List<Java.Lang.String> arg2)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addLong", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addRemoteInput(android.app.RemoteInput,java.lang.String,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.RemoteInput"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddRemoteInput(Android.App.RemoteInput arg0, Java.Lang.String arg1, Java.Util.List<Java.Lang.String> arg2)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addRemoteInput", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addSubSlice(android.app.slice.Slice,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Slice.Slice"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddSubSlice(Android.App.Slice.Slice arg0, Java.Lang.String arg1)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addSubSlice", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#addText(java.lang.CharSequence,java.lang.String,java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder AddText(Java.Lang.CharSequence arg0, Java.Lang.String arg1, Java.Util.List<Java.Lang.String> arg2)
            {
                return IExecute<Android.App.Slice.Slice.Builder>("addText", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/slice/Slice.Builder.html#setCallerNeeded(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Slice.Slice.Builder"/></returns>
            public Android.App.Slice.Slice.Builder SetCallerNeeded(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Slice.Slice.Builder>("setCallerNeeded", "(Z)Landroid/app/slice/Slice$Builder;", arg0);
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