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

namespace Android.Drm
{
    #region DrmErrorEvent
    public partial class DrmErrorEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#%3Cinit%3E(int,int,java.lang.String,java.util.HashMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.HashMap"/></param>
        [System.Obsolete()]
        public DrmErrorEvent(int arg0, int arg1, Java.Lang.String arg2, Java.Util.HashMap<Java.Lang.String, object> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#%3Cinit%3E(int,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        [System.Obsolete()]
        public DrmErrorEvent(int arg0, int arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_ACQUIRE_DRM_INFO_FAILED"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_ACQUIRE_DRM_INFO_FAILED { get { if (!_TYPE_ACQUIRE_DRM_INFO_FAILEDReady) { _TYPE_ACQUIRE_DRM_INFO_FAILEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_ACQUIRE_DRM_INFO_FAILED"); _TYPE_ACQUIRE_DRM_INFO_FAILEDReady = true; } return _TYPE_ACQUIRE_DRM_INFO_FAILEDContent; } }
        private static int _TYPE_ACQUIRE_DRM_INFO_FAILEDContent = default;
        private static bool _TYPE_ACQUIRE_DRM_INFO_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_NO_INTERNET_CONNECTION"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_NO_INTERNET_CONNECTION { get { if (!_TYPE_NO_INTERNET_CONNECTIONReady) { _TYPE_NO_INTERNET_CONNECTIONContent = SGetField<int>(LocalBridgeClazz, "TYPE_NO_INTERNET_CONNECTION"); _TYPE_NO_INTERNET_CONNECTIONReady = true; } return _TYPE_NO_INTERNET_CONNECTIONContent; } }
        private static int _TYPE_NO_INTERNET_CONNECTIONContent = default;
        private static bool _TYPE_NO_INTERNET_CONNECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_NOT_SUPPORTED"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_NOT_SUPPORTED { get { if (!_TYPE_NOT_SUPPORTEDReady) { _TYPE_NOT_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_NOT_SUPPORTED"); _TYPE_NOT_SUPPORTEDReady = true; } return _TYPE_NOT_SUPPORTEDContent; } }
        private static int _TYPE_NOT_SUPPORTEDContent = default;
        private static bool _TYPE_NOT_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_OUT_OF_MEMORY"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_OUT_OF_MEMORY { get { if (!_TYPE_OUT_OF_MEMORYReady) { _TYPE_OUT_OF_MEMORYContent = SGetField<int>(LocalBridgeClazz, "TYPE_OUT_OF_MEMORY"); _TYPE_OUT_OF_MEMORYReady = true; } return _TYPE_OUT_OF_MEMORYContent; } }
        private static int _TYPE_OUT_OF_MEMORYContent = default;
        private static bool _TYPE_OUT_OF_MEMORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_PROCESS_DRM_INFO_FAILED"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_PROCESS_DRM_INFO_FAILED { get { if (!_TYPE_PROCESS_DRM_INFO_FAILEDReady) { _TYPE_PROCESS_DRM_INFO_FAILEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_PROCESS_DRM_INFO_FAILED"); _TYPE_PROCESS_DRM_INFO_FAILEDReady = true; } return _TYPE_PROCESS_DRM_INFO_FAILEDContent; } }
        private static int _TYPE_PROCESS_DRM_INFO_FAILEDContent = default;
        private static bool _TYPE_PROCESS_DRM_INFO_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_REMOVE_ALL_RIGHTS_FAILED"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_REMOVE_ALL_RIGHTS_FAILED { get { if (!_TYPE_REMOVE_ALL_RIGHTS_FAILEDReady) { _TYPE_REMOVE_ALL_RIGHTS_FAILEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_REMOVE_ALL_RIGHTS_FAILED"); _TYPE_REMOVE_ALL_RIGHTS_FAILEDReady = true; } return _TYPE_REMOVE_ALL_RIGHTS_FAILEDContent; } }
        private static int _TYPE_REMOVE_ALL_RIGHTS_FAILEDContent = default;
        private static bool _TYPE_REMOVE_ALL_RIGHTS_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_RIGHTS_NOT_INSTALLED"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_RIGHTS_NOT_INSTALLED { get { if (!_TYPE_RIGHTS_NOT_INSTALLEDReady) { _TYPE_RIGHTS_NOT_INSTALLEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_RIGHTS_NOT_INSTALLED"); _TYPE_RIGHTS_NOT_INSTALLEDReady = true; } return _TYPE_RIGHTS_NOT_INSTALLEDContent; } }
        private static int _TYPE_RIGHTS_NOT_INSTALLEDContent = default;
        private static bool _TYPE_RIGHTS_NOT_INSTALLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmErrorEvent.html#TYPE_RIGHTS_RENEWAL_NOT_ALLOWED"/>
        /// </summary>
        [System.Obsolete()]
        public static int TYPE_RIGHTS_RENEWAL_NOT_ALLOWED { get { if (!_TYPE_RIGHTS_RENEWAL_NOT_ALLOWEDReady) { _TYPE_RIGHTS_RENEWAL_NOT_ALLOWEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_RIGHTS_RENEWAL_NOT_ALLOWED"); _TYPE_RIGHTS_RENEWAL_NOT_ALLOWEDReady = true; } return _TYPE_RIGHTS_RENEWAL_NOT_ALLOWEDContent; } }
        private static int _TYPE_RIGHTS_RENEWAL_NOT_ALLOWEDContent = default;
        private static bool _TYPE_RIGHTS_RENEWAL_NOT_ALLOWEDReady = false; // this is used because in case of generics 

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
}