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

namespace Android.Media
{
    #region DrmInitData
    public partial class DrmInitData
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
        /// <see href="https://developer.android.com/reference/android/media/DrmInitData.html#get(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="Android.Media.DrmInitData.SchemeInitData"/></returns>
        [global::System.Obsolete()]
        public Android.Media.DrmInitData.SchemeInitData Get(Java.Util.UUID arg0)
        {
            return IExecuteWithSignature<Android.Media.DrmInitData.SchemeInitData>("get", "(Ljava/util/UUID;)Landroid/media/DrmInitData$SchemeInitData;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/DrmInitData.html#getSchemeInitDataAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.DrmInitData.SchemeInitData"/></returns>
        public Android.Media.DrmInitData.SchemeInitData GetSchemeInitDataAt(int arg0)
        {
            return IExecuteWithSignature<Android.Media.DrmInitData.SchemeInitData>("getSchemeInitDataAt", "(I)Landroid/media/DrmInitData$SchemeInitData;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/DrmInitData.html#getSchemeInitDataCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSchemeInitDataCount()
        {
            return IExecuteWithSignature<int>("getSchemeInitDataCount", "()I");
        }

        #endregion

        #region Nested classes
        #region SchemeInitData
        public partial class SchemeInitData
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#%3Cinit%3E(java.util.UUID,java.lang.String,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            public SchemeInitData(Java.Util.UUID arg0, Java.Lang.String arg1, byte[] arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#data"/>
            /// </summary>
            public byte[] data { get { if (!_dataReady) { _dataContent = IGetFieldArray<byte>("data"); _dataReady = true; } return _dataContent; } }
            private byte[] _dataContent = default;
            private bool _dataReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#mimeType"/>
            /// </summary>
            public Java.Lang.String mimeType { get { if (!_mimeTypeReady) { _mimeTypeContent = IGetField<Java.Lang.String>("mimeType"); _mimeTypeReady = true; } return _mimeTypeContent; } }
            private Java.Lang.String _mimeTypeContent = default;
            private bool _mimeTypeReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#uuid"/>
            /// </summary>
            public Java.Util.UUID uuid { get { if (!_uuidReady) { _uuidContent = IGetField<Java.Util.UUID>("uuid"); _uuidReady = true; } return _uuidContent; } }
            private Java.Util.UUID _uuidContent = default;
            private bool _uuidReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#UUID_NIL"/>
            /// </summary>
            public static Java.Util.UUID UUID_NIL { get { if (!_UUID_NILReady) { _UUID_NILContent = SGetField<Java.Util.UUID>(LocalBridgeClazz, "UUID_NIL"); _UUID_NILReady = true; } return _UUID_NILContent; } }
            private static Java.Util.UUID _UUID_NILContent = default;
            private static bool _UUID_NILReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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