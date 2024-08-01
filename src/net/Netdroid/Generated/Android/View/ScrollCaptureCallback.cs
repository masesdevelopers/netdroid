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

namespace Android.View
{
    #region IScrollCaptureCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScrollCaptureCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScrollCaptureCallback
    public partial class ScrollCaptureCallback : Android.View.IScrollCaptureCallback
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
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureCallback.html#onScrollCaptureEnd(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void OnScrollCaptureEnd(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("onScrollCaptureEnd", "(Ljava/lang/Runnable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureCallback.html#onScrollCaptureImageRequest(android.view.ScrollCaptureSession,android.os.CancellationSignal,android.graphics.Rect,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ScrollCaptureSession"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Consumer"/></param>
        public void OnScrollCaptureImageRequest(Android.View.ScrollCaptureSession arg0, Android.Os.CancellationSignal arg1, Android.Graphics.Rect arg2, Java.Util.Function.Consumer<Android.Graphics.Rect> arg3)
        {
            IExecute("onScrollCaptureImageRequest", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureCallback.html#onScrollCaptureSearch(android.os.CancellationSignal,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void OnScrollCaptureSearch(Android.Os.CancellationSignal arg0, Java.Util.Function.Consumer<Android.Graphics.Rect> arg1)
        {
            IExecute("onScrollCaptureSearch", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureCallback.html#onScrollCaptureStart(android.view.ScrollCaptureSession,android.os.CancellationSignal,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ScrollCaptureSession"/></param>
        /// <param name="arg1"><see cref="Android.Os.CancellationSignal"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Runnable"/></param>
        public void OnScrollCaptureStart(Android.View.ScrollCaptureSession arg0, Android.Os.CancellationSignal arg1, Java.Lang.Runnable arg2)
        {
            IExecute("onScrollCaptureStart", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}