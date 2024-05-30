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
    #region CameraExtensionSession
    public partial class CameraExtensionSession
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
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.html#getDevice()"/> 
        /// </summary>
        public Android.Hardware.Camera2.CameraDevice Device
        {
            get { return IExecuteWithSignature<Android.Hardware.Camera2.CameraDevice>("getDevice", "()Landroid/hardware/camera2/CameraDevice;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.html#getRealtimeStillCaptureLatency()"/> 
        /// </summary>
        public Android.Hardware.Camera2.CameraExtensionSession.StillCaptureLatency RealtimeStillCaptureLatency
        {
            get { return IExecuteWithSignature<Android.Hardware.Camera2.CameraExtensionSession.StillCaptureLatency>("getRealtimeStillCaptureLatency", "()Landroid/hardware/camera2/CameraExtensionSession$StillCaptureLatency;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.html#capture(android.hardware.camera2.CaptureRequest,java.util.concurrent.Executor,android.hardware.camera2.CameraExtensionSession.ExtensionCaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraExtensionSession.ExtensionCaptureCallback"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int Capture(Android.Hardware.Camera2.CaptureRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraExtensionSession.ExtensionCaptureCallback arg2)
        {
            return IExecute<int>("capture", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.html#setRepeatingRequest(android.hardware.camera2.CaptureRequest,java.util.concurrent.Executor,android.hardware.camera2.CameraExtensionSession.ExtensionCaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Hardware.Camera2.CameraExtensionSession.ExtensionCaptureCallback"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public int SetRepeatingRequest(Android.Hardware.Camera2.CaptureRequest arg0, Java.Util.Concurrent.Executor arg1, Android.Hardware.Camera2.CameraExtensionSession.ExtensionCaptureCallback arg2)
        {
            return IExecute<int>("setRepeatingRequest", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.html#close()"/>
        /// </summary>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.html#stopRepeating()"/>
        /// </summary>
        /// <exception cref="Android.Hardware.Camera2.CameraAccessException"/>
        public void StopRepeating()
        {
            IExecuteWithSignature("stopRepeating", "()V");
        }

        #endregion

        #region Nested classes
        #region ExtensionCaptureCallback
        public partial class ExtensionCaptureCallback
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.ExtensionCaptureCallback.html#onCaptureFailed(android.hardware.camera2.CameraExtensionSession,android.hardware.camera2.CaptureRequest)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            public void OnCaptureFailed(Android.Hardware.Camera2.CameraExtensionSession arg0, Android.Hardware.Camera2.CaptureRequest arg1)
            {
                IExecute("onCaptureFailed", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.ExtensionCaptureCallback.html#onCaptureProcessProgressed(android.hardware.camera2.CameraExtensionSession,android.hardware.camera2.CaptureRequest,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void OnCaptureProcessProgressed(Android.Hardware.Camera2.CameraExtensionSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, int arg2)
            {
                IExecute("onCaptureProcessProgressed", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.ExtensionCaptureCallback.html#onCaptureProcessStarted(android.hardware.camera2.CameraExtensionSession,android.hardware.camera2.CaptureRequest)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            public void OnCaptureProcessStarted(Android.Hardware.Camera2.CameraExtensionSession arg0, Android.Hardware.Camera2.CaptureRequest arg1)
            {
                IExecute("onCaptureProcessStarted", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.ExtensionCaptureCallback.html#onCaptureResultAvailable(android.hardware.camera2.CameraExtensionSession,android.hardware.camera2.CaptureRequest,android.hardware.camera2.TotalCaptureResult)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="Android.Hardware.Camera2.TotalCaptureResult"/></param>
            public void OnCaptureResultAvailable(Android.Hardware.Camera2.CameraExtensionSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, Android.Hardware.Camera2.TotalCaptureResult arg2)
            {
                IExecute("onCaptureResultAvailable", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.ExtensionCaptureCallback.html#onCaptureSequenceAborted(android.hardware.camera2.CameraExtensionSession,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnCaptureSequenceAborted(Android.Hardware.Camera2.CameraExtensionSession arg0, int arg1)
            {
                IExecute("onCaptureSequenceAborted", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.ExtensionCaptureCallback.html#onCaptureSequenceCompleted(android.hardware.camera2.CameraExtensionSession,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnCaptureSequenceCompleted(Android.Hardware.Camera2.CameraExtensionSession arg0, int arg1)
            {
                IExecute("onCaptureSequenceCompleted", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.ExtensionCaptureCallback.html#onCaptureStarted(android.hardware.camera2.CameraExtensionSession,android.hardware.camera2.CaptureRequest,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            /// <param name="arg1"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public void OnCaptureStarted(Android.Hardware.Camera2.CameraExtensionSession arg0, Android.Hardware.Camera2.CaptureRequest arg1, long arg2)
            {
                IExecute("onCaptureStarted", arg0, arg1, arg2);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StateCallback
        public partial class StateCallback
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.StateCallback.html#onConfigured(android.hardware.camera2.CameraExtensionSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            public void OnConfigured(Android.Hardware.Camera2.CameraExtensionSession arg0)
            {
                IExecuteWithSignature("onConfigured", "(Landroid/hardware/camera2/CameraExtensionSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.StateCallback.html#onConfigureFailed(android.hardware.camera2.CameraExtensionSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            public void OnConfigureFailed(Android.Hardware.Camera2.CameraExtensionSession arg0)
            {
                IExecuteWithSignature("onConfigureFailed", "(Landroid/hardware/camera2/CameraExtensionSession;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.StateCallback.html#onClosed(android.hardware.camera2.CameraExtensionSession)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.CameraExtensionSession"/></param>
            public void OnClosed(Android.Hardware.Camera2.CameraExtensionSession arg0)
            {
                IExecuteWithSignature("onClosed", "(Landroid/hardware/camera2/CameraExtensionSession;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StillCaptureLatency
        public partial class StillCaptureLatency
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.StillCaptureLatency.html#%3Cinit%3E(long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public StillCaptureLatency(long arg0, long arg1)
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
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.StillCaptureLatency.html#getCaptureLatency()"/> 
            /// </summary>
            public long CaptureLatency
            {
                get { return IExecuteWithSignature<long>("getCaptureLatency", "()J"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/CameraExtensionSession.StillCaptureLatency.html#getProcessingLatency()"/> 
            /// </summary>
            public long ProcessingLatency
            {
                get { return IExecuteWithSignature<long>("getProcessingLatency", "()J"); }
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