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
    #region CameraOfflineSession
    public partial class CameraOfflineSession
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

        #endregion

        #region Nested classes
        #region CameraOfflineSessionCallback
        public partial class CameraOfflineSessionCallback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraOfflineSession.CameraOfflineSessionCallback.html#STATUS_INTERNAL_ERROR"/>
            /// </summary>
            public static int STATUS_INTERNAL_ERROR { get { if (!_STATUS_INTERNAL_ERRORReady) { _STATUS_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATUS_INTERNAL_ERROR"); _STATUS_INTERNAL_ERRORReady = true; } return _STATUS_INTERNAL_ERRORContent; } }
            private static int _STATUS_INTERNAL_ERRORContent = default;
            private static bool _STATUS_INTERNAL_ERRORReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraOfflineSession.CameraOfflineSessionCallback.html#onClosed(android.hardware.camera2.CameraOfflineSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraOfflineSession"/></param>
            public void OnClosed(Android.Hardware.Camera2.CameraOfflineSession arg0)
            {
                IExecuteWithSignature("onClosed", "(Landroid/hardware/camera2/CameraOfflineSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraOfflineSession.CameraOfflineSessionCallback.html#onError(android.hardware.camera2.CameraOfflineSession,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraOfflineSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnError(Android.Hardware.Camera2.CameraOfflineSession arg0, int arg1)
            {
                IExecute("onError", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraOfflineSession.CameraOfflineSessionCallback.html#onIdle(android.hardware.camera2.CameraOfflineSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraOfflineSession"/></param>
            public void OnIdle(Android.Hardware.Camera2.CameraOfflineSession arg0)
            {
                IExecuteWithSignature("onIdle", "(Landroid/hardware/camera2/CameraOfflineSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraOfflineSession.CameraOfflineSessionCallback.html#onReady(android.hardware.camera2.CameraOfflineSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraOfflineSession"/></param>
            public void OnReady(Android.Hardware.Camera2.CameraOfflineSession arg0)
            {
                IExecuteWithSignature("onReady", "(Landroid/hardware/camera2/CameraOfflineSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraOfflineSession.CameraOfflineSessionCallback.html#onSwitchFailed(android.hardware.camera2.CameraOfflineSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraOfflineSession"/></param>
            public void OnSwitchFailed(Android.Hardware.Camera2.CameraOfflineSession arg0)
            {
                IExecuteWithSignature("onSwitchFailed", "(Landroid/hardware/camera2/CameraOfflineSession;)V", arg0);
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