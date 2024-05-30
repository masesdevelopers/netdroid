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

namespace Android.Opengl
{
    #region EGLExt
    public partial class EGLExt
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_CONTEXT_FLAGS_KHR"/>
        /// </summary>
        public static int EGL_CONTEXT_FLAGS_KHR { get { if (!_EGL_CONTEXT_FLAGS_KHRReady) { _EGL_CONTEXT_FLAGS_KHRContent = SGetField<int>(LocalBridgeClazz, "EGL_CONTEXT_FLAGS_KHR"); _EGL_CONTEXT_FLAGS_KHRReady = true; } return _EGL_CONTEXT_FLAGS_KHRContent; } }
        private static int _EGL_CONTEXT_FLAGS_KHRContent = default;
        private static bool _EGL_CONTEXT_FLAGS_KHRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_CONTEXT_MAJOR_VERSION_KHR"/>
        /// </summary>
        public static int EGL_CONTEXT_MAJOR_VERSION_KHR { get { if (!_EGL_CONTEXT_MAJOR_VERSION_KHRReady) { _EGL_CONTEXT_MAJOR_VERSION_KHRContent = SGetField<int>(LocalBridgeClazz, "EGL_CONTEXT_MAJOR_VERSION_KHR"); _EGL_CONTEXT_MAJOR_VERSION_KHRReady = true; } return _EGL_CONTEXT_MAJOR_VERSION_KHRContent; } }
        private static int _EGL_CONTEXT_MAJOR_VERSION_KHRContent = default;
        private static bool _EGL_CONTEXT_MAJOR_VERSION_KHRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_CONTEXT_MINOR_VERSION_KHR"/>
        /// </summary>
        public static int EGL_CONTEXT_MINOR_VERSION_KHR { get { if (!_EGL_CONTEXT_MINOR_VERSION_KHRReady) { _EGL_CONTEXT_MINOR_VERSION_KHRContent = SGetField<int>(LocalBridgeClazz, "EGL_CONTEXT_MINOR_VERSION_KHR"); _EGL_CONTEXT_MINOR_VERSION_KHRReady = true; } return _EGL_CONTEXT_MINOR_VERSION_KHRContent; } }
        private static int _EGL_CONTEXT_MINOR_VERSION_KHRContent = default;
        private static bool _EGL_CONTEXT_MINOR_VERSION_KHRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_NO_NATIVE_FENCE_FD_ANDROID"/>
        /// </summary>
        public static int EGL_NO_NATIVE_FENCE_FD_ANDROID { get { if (!_EGL_NO_NATIVE_FENCE_FD_ANDROIDReady) { _EGL_NO_NATIVE_FENCE_FD_ANDROIDContent = SGetField<int>(LocalBridgeClazz, "EGL_NO_NATIVE_FENCE_FD_ANDROID"); _EGL_NO_NATIVE_FENCE_FD_ANDROIDReady = true; } return _EGL_NO_NATIVE_FENCE_FD_ANDROIDContent; } }
        private static int _EGL_NO_NATIVE_FENCE_FD_ANDROIDContent = default;
        private static bool _EGL_NO_NATIVE_FENCE_FD_ANDROIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_OPENGL_ES3_BIT_KHR"/>
        /// </summary>
        public static int EGL_OPENGL_ES3_BIT_KHR { get { if (!_EGL_OPENGL_ES3_BIT_KHRReady) { _EGL_OPENGL_ES3_BIT_KHRContent = SGetField<int>(LocalBridgeClazz, "EGL_OPENGL_ES3_BIT_KHR"); _EGL_OPENGL_ES3_BIT_KHRReady = true; } return _EGL_OPENGL_ES3_BIT_KHRContent; } }
        private static int _EGL_OPENGL_ES3_BIT_KHRContent = default;
        private static bool _EGL_OPENGL_ES3_BIT_KHRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_RECORDABLE_ANDROID"/>
        /// </summary>
        public static int EGL_RECORDABLE_ANDROID { get { if (!_EGL_RECORDABLE_ANDROIDReady) { _EGL_RECORDABLE_ANDROIDContent = SGetField<int>(LocalBridgeClazz, "EGL_RECORDABLE_ANDROID"); _EGL_RECORDABLE_ANDROIDReady = true; } return _EGL_RECORDABLE_ANDROIDContent; } }
        private static int _EGL_RECORDABLE_ANDROIDContent = default;
        private static bool _EGL_RECORDABLE_ANDROIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_SYNC_NATIVE_FENCE_ANDROID"/>
        /// </summary>
        public static int EGL_SYNC_NATIVE_FENCE_ANDROID { get { if (!_EGL_SYNC_NATIVE_FENCE_ANDROIDReady) { _EGL_SYNC_NATIVE_FENCE_ANDROIDContent = SGetField<int>(LocalBridgeClazz, "EGL_SYNC_NATIVE_FENCE_ANDROID"); _EGL_SYNC_NATIVE_FENCE_ANDROIDReady = true; } return _EGL_SYNC_NATIVE_FENCE_ANDROIDContent; } }
        private static int _EGL_SYNC_NATIVE_FENCE_ANDROIDContent = default;
        private static bool _EGL_SYNC_NATIVE_FENCE_ANDROIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_SYNC_NATIVE_FENCE_FD_ANDROID"/>
        /// </summary>
        public static int EGL_SYNC_NATIVE_FENCE_FD_ANDROID { get { if (!_EGL_SYNC_NATIVE_FENCE_FD_ANDROIDReady) { _EGL_SYNC_NATIVE_FENCE_FD_ANDROIDContent = SGetField<int>(LocalBridgeClazz, "EGL_SYNC_NATIVE_FENCE_FD_ANDROID"); _EGL_SYNC_NATIVE_FENCE_FD_ANDROIDReady = true; } return _EGL_SYNC_NATIVE_FENCE_FD_ANDROIDContent; } }
        private static int _EGL_SYNC_NATIVE_FENCE_FD_ANDROIDContent = default;
        private static bool _EGL_SYNC_NATIVE_FENCE_FD_ANDROIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROID"/>
        /// </summary>
        public static int EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROID { get { if (!_EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROIDReady) { _EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROIDContent = SGetField<int>(LocalBridgeClazz, "EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROID"); _EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROIDReady = true; } return _EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROIDContent; } }
        private static int _EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROIDContent = default;
        private static bool _EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#eglDupNativeFenceFDANDROID(android.opengl.EGLDisplay,android.opengl.EGLSync)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Opengl.EGLDisplay"/></param>
        /// <param name="arg1"><see cref="Android.Opengl.EGLSync"/></param>
        /// <returns><see cref="Android.Hardware.SyncFence"/></returns>
        public static Android.Hardware.SyncFence EglDupNativeFenceFDANDROID(Android.Opengl.EGLDisplay arg0, Android.Opengl.EGLSync arg1)
        {
            return SExecute<Android.Hardware.SyncFence>(LocalBridgeClazz, "eglDupNativeFenceFDANDROID", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/opengl/EGLExt.html#eglPresentationTimeANDROID(android.opengl.EGLDisplay,android.opengl.EGLSurface,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Opengl.EGLDisplay"/></param>
        /// <param name="arg1"><see cref="Android.Opengl.EGLSurface"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool EglPresentationTimeANDROID(Android.Opengl.EGLDisplay arg0, Android.Opengl.EGLSurface arg1, long arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "eglPresentationTimeANDROID", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}