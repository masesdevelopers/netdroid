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

namespace Android.View
{
    #region ScrollCaptureSession
    public partial class ScrollCaptureSession
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureSession.html#%3Cinit%3E(android.view.Surface,android.graphics.Rect,android.graphics.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Point"/></param>
        public ScrollCaptureSession(Android.View.Surface arg0, Android.Graphics.Rect arg1, Android.Graphics.Point arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureSession.html#getPositionInWindow()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetPositionInWindow()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getPositionInWindow", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureSession.html#getScrollBounds()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public Android.Graphics.Rect GetScrollBounds()
        {
            return IExecuteWithSignature<Android.Graphics.Rect>("getScrollBounds", "()Landroid/graphics/Rect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureSession.html#getSurface()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Surface"/></returns>
        public Android.View.Surface GetSurface()
        {
            return IExecuteWithSignature<Android.View.Surface>("getSurface", "()Landroid/view/Surface;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}