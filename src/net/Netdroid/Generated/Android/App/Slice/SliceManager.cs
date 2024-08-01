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

namespace Android.App.Slice
{
    #region SliceManager
    public partial class SliceManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#CATEGORY_SLICE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String CATEGORY_SLICE { get { if (!_CATEGORY_SLICEReady) { _CATEGORY_SLICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CATEGORY_SLICE"); _CATEGORY_SLICEReady = true; } return _CATEGORY_SLICEContent; } }
        private static Java.Lang.String _CATEGORY_SLICEContent = default;
        private static bool _CATEGORY_SLICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#SLICE_METADATA_KEY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SLICE_METADATA_KEY { get { if (!_SLICE_METADATA_KEYReady) { _SLICE_METADATA_KEYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SLICE_METADATA_KEY"); _SLICE_METADATA_KEYReady = true; } return _SLICE_METADATA_KEYContent; } }
        private static Java.Lang.String _SLICE_METADATA_KEYContent = default;
        private static bool _SLICE_METADATA_KEYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#bindSlice(android.content.Intent,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Android.App.Slice.Slice"/></returns>
        [global::System.Obsolete()]
        public Android.App.Slice.Slice BindSlice(Android.Content.Intent arg0, Java.Util.Set<Android.App.Slice.SliceSpec> arg1)
        {
            return IExecute<Android.App.Slice.Slice>("bindSlice", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#bindSlice(android.net.Uri,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Android.App.Slice.Slice"/></returns>
        [global::System.Obsolete()]
        public Android.App.Slice.Slice BindSlice(Android.Net.Uri arg0, Java.Util.Set<Android.App.Slice.SliceSpec> arg1)
        {
            return IExecute<Android.App.Slice.Slice>("bindSlice", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#mapIntentToUri(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        [global::System.Obsolete()]
        public Android.Net.Uri MapIntentToUri(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<Android.Net.Uri>("mapIntentToUri", "(Landroid/content/Intent;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#checkSlicePermission(android.net.Uri,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int CheckSlicePermission(Android.Net.Uri arg0, int arg1, int arg2)
        {
            return IExecute<int>("checkSlicePermission", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#getSliceDescendants(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Collection<Android.Net.Uri> GetSliceDescendants(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Java.Util.Collection<Android.Net.Uri>>("getSliceDescendants", "(Landroid/net/Uri;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#getPinnedSlices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Net.Uri> GetPinnedSlices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Uri>>("getPinnedSlices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#getPinnedSpecs(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Set<Android.App.Slice.SliceSpec> GetPinnedSpecs(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.App.Slice.SliceSpec>>("getPinnedSpecs", "(Landroid/net/Uri;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#grantSlicePermission(java.lang.String,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        [global::System.Obsolete()]
        public void GrantSlicePermission(Java.Lang.String arg0, Android.Net.Uri arg1)
        {
            IExecute("grantSlicePermission", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#pinSlice(android.net.Uri,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        [global::System.Obsolete()]
        public void PinSlice(Android.Net.Uri arg0, Java.Util.Set<Android.App.Slice.SliceSpec> arg1)
        {
            IExecute("pinSlice", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#revokeSlicePermission(java.lang.String,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        [global::System.Obsolete()]
        public void RevokeSlicePermission(Java.Lang.String arg0, Android.Net.Uri arg1)
        {
            IExecute("revokeSlicePermission", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceManager.html#unpinSlice(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        [global::System.Obsolete()]
        public void UnpinSlice(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("unpinSlice", "(Landroid/net/Uri;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}