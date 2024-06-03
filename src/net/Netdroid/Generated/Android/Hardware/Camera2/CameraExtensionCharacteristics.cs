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

namespace Android.Hardware.Camera2
{
    #region CameraExtensionCharacteristics
    public partial class CameraExtensionCharacteristics
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#EXTENSION_AUTOMATIC"/>
        /// </summary>
        public static int EXTENSION_AUTOMATIC { get { if (!_EXTENSION_AUTOMATICReady) { _EXTENSION_AUTOMATICContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_AUTOMATIC"); _EXTENSION_AUTOMATICReady = true; } return _EXTENSION_AUTOMATICContent; } }
        private static int _EXTENSION_AUTOMATICContent = default;
        private static bool _EXTENSION_AUTOMATICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#EXTENSION_BEAUTY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int EXTENSION_BEAUTY { get { if (!_EXTENSION_BEAUTYReady) { _EXTENSION_BEAUTYContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_BEAUTY"); _EXTENSION_BEAUTYReady = true; } return _EXTENSION_BEAUTYContent; } }
        private static int _EXTENSION_BEAUTYContent = default;
        private static bool _EXTENSION_BEAUTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#EXTENSION_BOKEH"/>
        /// </summary>
        public static int EXTENSION_BOKEH { get { if (!_EXTENSION_BOKEHReady) { _EXTENSION_BOKEHContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_BOKEH"); _EXTENSION_BOKEHReady = true; } return _EXTENSION_BOKEHContent; } }
        private static int _EXTENSION_BOKEHContent = default;
        private static bool _EXTENSION_BOKEHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#EXTENSION_FACE_RETOUCH"/>
        /// </summary>
        public static int EXTENSION_FACE_RETOUCH { get { if (!_EXTENSION_FACE_RETOUCHReady) { _EXTENSION_FACE_RETOUCHContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_FACE_RETOUCH"); _EXTENSION_FACE_RETOUCHReady = true; } return _EXTENSION_FACE_RETOUCHContent; } }
        private static int _EXTENSION_FACE_RETOUCHContent = default;
        private static bool _EXTENSION_FACE_RETOUCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#EXTENSION_HDR"/>
        /// </summary>
        public static int EXTENSION_HDR { get { if (!_EXTENSION_HDRReady) { _EXTENSION_HDRContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_HDR"); _EXTENSION_HDRReady = true; } return _EXTENSION_HDRContent; } }
        private static int _EXTENSION_HDRContent = default;
        private static bool _EXTENSION_HDRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#EXTENSION_NIGHT"/>
        /// </summary>
        public static int EXTENSION_NIGHT { get { if (!_EXTENSION_NIGHTReady) { _EXTENSION_NIGHTContent = SGetField<int>(LocalBridgeClazz, "EXTENSION_NIGHT"); _EXTENSION_NIGHTReady = true; } return _EXTENSION_NIGHTContent; } }
        private static int _EXTENSION_NIGHTContent = default;
        private static bool _EXTENSION_NIGHTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#getExtensionSupportedSizes(int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Util.Size> GetExtensionSupportedSizes(int arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.List<Android.Util.Size>>("getExtensionSupportedSizes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#isCaptureProcessProgressAvailable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCaptureProcessProgressAvailable(int arg0)
        {
            return IExecuteWithSignature<bool>("isCaptureProcessProgressAvailable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#isPostviewAvailable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPostviewAvailable(int arg0)
        {
            return IExecuteWithSignature<bool>("isPostviewAvailable", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#getExtensionSupportedSizes(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Util.Size> GetExtensionSupportedSizes(int arg0, int arg1)
        {
            return IExecute<Java.Util.List<Android.Util.Size>>("getExtensionSupportedSizes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#getPostviewSupportedSizes(int,android.util.Size,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Util.Size> GetPostviewSupportedSizes(int arg0, Android.Util.Size arg1, int arg2)
        {
            return IExecute<Java.Util.List<Android.Util.Size>>("getPostviewSupportedSizes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#getSupportedExtensions()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.Integer> GetSupportedExtensions()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("getSupportedExtensions", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#getAvailableCaptureRequestKeys(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Hardware.Camera2.CaptureRequest.Key> GetAvailableCaptureRequestKeys(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Hardware.Camera2.CaptureRequest.Key>>("getAvailableCaptureRequestKeys", "(I)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionCharacteristics.html#getAvailableCaptureResultKeys(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Hardware.Camera2.CaptureResult.Key> GetAvailableCaptureResultKeys(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Hardware.Camera2.CaptureResult.Key>>("getAvailableCaptureResultKeys", "(I)Ljava/util/Set;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}