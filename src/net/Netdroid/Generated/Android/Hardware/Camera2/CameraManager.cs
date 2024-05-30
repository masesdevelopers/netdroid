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
    #region CameraManager
    public partial class CameraManager
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#getCameraIdList()"/> 
        /// </summary>
        public Java.Lang.String[] CameraIdList
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getCameraIdList", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#getConcurrentCameraIds()"/> 
        /// </summary>
        public Java.Util.Set<Java.Util.Set<Java.Lang.String>> ConcurrentCameraIds
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Util.Set<Java.Lang.String>>>("getConcurrentCameraIds", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#getCameraCharacteristics(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.CameraCharacteristics"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public Android.Hardware.Camera2.CameraCharacteristics GetCameraCharacteristics(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CameraCharacteristics>("getCameraCharacteristics", "(Ljava/lang/String;)Landroid/hardware/camera2/CameraCharacteristics;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#getCameraExtensionCharacteristics(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Hardware.Camera2.CameraExtensionCharacteristics"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public Android.Hardware.Camera2.CameraExtensionCharacteristics GetCameraExtensionCharacteristics(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CameraExtensionCharacteristics>("getCameraExtensionCharacteristics", "(Ljava/lang/String;)Landroid/hardware/camera2/CameraExtensionCharacteristics;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#isConcurrentSessionConfigurationSupported(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public bool IsConcurrentSessionConfigurationSupported(Java.Util.Map<Java.Lang.String, Android.Hardware.Camera2.Params.SessionConfiguration> arg0)
        {
            return IExecuteWithSignature<bool>("isConcurrentSessionConfigurationSupported", "(Ljava/util/Map;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#getTorchStrengthLevel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int GetTorchStrengthLevel(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getTorchStrengthLevel", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#openCamera(java.lang.String,android.hardware.camera2.CameraDevice.StateCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraDevice.StateCallback"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void OpenCamera(Java.Lang.String arg0, Android.Hardware.Camera2.CameraDevice.StateCallback arg1, Android.Os.Handler arg2)
        {
            IExecute("openCamera", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#openCamera(java.lang.String,java.util.concurrent.Executor,android.hardware.camera2.CameraDevice.StateCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraDevice.StateCallback"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void OpenCamera(Java.Lang.String arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraDevice.StateCallback arg2)
        {
            IExecute("openCamera", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#registerAvailabilityCallback(android.hardware.camera2.CameraManager.AvailabilityCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraManager.AvailabilityCallback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterAvailabilityCallback(Android.Hardware.Camera2.CameraManager.AvailabilityCallback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerAvailabilityCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#registerAvailabilityCallback(java.util.concurrent.Executor,android.hardware.camera2.CameraManager.AvailabilityCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraManager.AvailabilityCallback"/></param>
        public void RegisterAvailabilityCallback(Java.Util.Concurrent.Executor arg0, Android.Hardware.Camera2.CameraManager.AvailabilityCallback arg1)
        {
            IExecute("registerAvailabilityCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#registerTorchCallback(android.hardware.camera2.CameraManager.TorchCallback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraManager.TorchCallback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterTorchCallback(Android.Hardware.Camera2.CameraManager.TorchCallback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerTorchCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#registerTorchCallback(java.util.concurrent.Executor,android.hardware.camera2.CameraManager.TorchCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.CameraManager.TorchCallback"/></param>
        public void RegisterTorchCallback(Java.Util.Concurrent.Executor arg0, Android.Hardware.Camera2.CameraManager.TorchCallback arg1)
        {
            IExecute("registerTorchCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#setTorchMode(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void SetTorchMode(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setTorchMode", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#turnOnTorchWithStrengthLevel(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void TurnOnTorchWithStrengthLevel(Java.Lang.String arg0, int arg1)
        {
            IExecute("turnOnTorchWithStrengthLevel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#unregisterAvailabilityCallback(android.hardware.camera2.CameraManager.AvailabilityCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraManager.AvailabilityCallback"/></param>
        public void UnregisterAvailabilityCallback(Android.Hardware.Camera2.CameraManager.AvailabilityCallback arg0)
        {
            IExecuteWithSignature("unregisterAvailabilityCallback", "(Landroid/hardware/camera2/CameraManager$AvailabilityCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.html#unregisterTorchCallback(android.hardware.camera2.CameraManager.TorchCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraManager.TorchCallback"/></param>
        public void UnregisterTorchCallback(Android.Hardware.Camera2.CameraManager.TorchCallback arg0)
        {
            IExecuteWithSignature("unregisterTorchCallback", "(Landroid/hardware/camera2/CameraManager$TorchCallback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region AvailabilityCallback
        public partial class AvailabilityCallback
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.AvailabilityCallback.html#onCameraAccessPrioritiesChanged()"/>
            /// </summary>
            public void OnCameraAccessPrioritiesChanged()
            {
                IExecuteWithSignature("onCameraAccessPrioritiesChanged", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.AvailabilityCallback.html#onCameraAvailable(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void OnCameraAvailable(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onCameraAvailable", "(Ljava/lang/String;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.AvailabilityCallback.html#onCameraUnavailable(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void OnCameraUnavailable(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onCameraUnavailable", "(Ljava/lang/String;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.AvailabilityCallback.html#onPhysicalCameraAvailable(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void OnPhysicalCameraAvailable(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                IExecute("onPhysicalCameraAvailable", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.AvailabilityCallback.html#onPhysicalCameraUnavailable(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void OnPhysicalCameraUnavailable(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                IExecute("onPhysicalCameraUnavailable", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TorchCallback
        public partial class TorchCallback
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.TorchCallback.html#onTorchModeChanged(java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void OnTorchModeChanged(Java.Lang.String arg0, bool arg1)
            {
                IExecute("onTorchModeChanged", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.TorchCallback.html#onTorchModeUnavailable(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void OnTorchModeUnavailable(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onTorchModeUnavailable", "(Ljava/lang/String;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraManager.TorchCallback.html#onTorchStrengthLevelChanged(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnTorchStrengthLevelChanged(Java.Lang.String arg0, int arg1)
            {
                IExecute("onTorchStrengthLevelChanged", arg0, arg1);
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