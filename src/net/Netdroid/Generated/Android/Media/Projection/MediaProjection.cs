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

namespace Android.Media.Projection
{
    #region MediaProjection
    public partial class MediaProjection
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
        /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjection.html#createVirtualDisplay(java.lang.String,int,int,int,int,android.view.Surface,android.hardware.display.VirtualDisplay.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.View.Surface"/></param>
        /// <param name="arg6"><see cref="Android.Hardware.Display.VirtualDisplay.Callback"/></param>
        /// <param name="arg7"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="Android.Hardware.Display.VirtualDisplay"/></returns>
        public Android.Hardware.Display.VirtualDisplay CreateVirtualDisplay(Java.Lang.String arg0, int arg1, int arg2, int arg3, int arg4, Android.View.Surface arg5, Android.Hardware.Display.VirtualDisplay.Callback arg6, Android.Os.Handler arg7)
        {
            return IExecute<Android.Hardware.Display.VirtualDisplay>("createVirtualDisplay", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjection.html#registerCallback(android.media.projection.MediaProjection.Callback,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Projection.MediaProjection.Callback"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void RegisterCallback(Android.Media.Projection.MediaProjection.Callback arg0, Android.Os.Handler arg1)
        {
            IExecute("registerCallback", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjection.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjection.html#unregisterCallback(android.media.projection.MediaProjection.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Projection.MediaProjection.Callback"/></param>
        public void UnregisterCallback(Android.Media.Projection.MediaProjection.Callback arg0)
        {
            IExecuteWithSignature("unregisterCallback", "(Landroid/media/projection/MediaProjection$Callback;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjection.Callback.html#onCapturedContentResize(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void OnCapturedContentResize(int arg0, int arg1)
            {
                IExecute("onCapturedContentResize", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjection.Callback.html#onCapturedContentVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void OnCapturedContentVisibilityChanged(bool arg0)
            {
                IExecuteWithSignature("onCapturedContentVisibilityChanged", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjection.Callback.html#onStop()"/>
            /// </summary>
            public void OnStop()
            {
                IExecuteWithSignature("onStop", "()V");
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