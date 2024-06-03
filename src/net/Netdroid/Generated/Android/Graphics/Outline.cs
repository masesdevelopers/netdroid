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

namespace Android.Graphics
{
    #region Outline
    public partial class Outline
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#%3Cinit%3E(android.graphics.Outline)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Outline"/></param>
        public Outline(Android.Graphics.Outline arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#canClip()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanClip()
        {
            return IExecuteWithSignature<bool>("canClip", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#getRect(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetRect(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<bool>("getRect", "(Landroid/graphics/Rect;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#getAlpha()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetAlpha()
        {
            return IExecuteWithSignature<float>("getAlpha", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#getRadius()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetRadius()
        {
            return IExecuteWithSignature<float>("getRadius", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#offset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Offset(int arg0, int arg1)
        {
            IExecute("offset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#set(android.graphics.Outline)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Outline"/></param>
        public void Set(Android.Graphics.Outline arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/Outline;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setAlpha(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetAlpha(float arg0)
        {
            IExecuteWithSignature("setAlpha", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setConvexPath(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        [global::System.Obsolete()]
        public void SetConvexPath(Android.Graphics.Path arg0)
        {
            IExecuteWithSignature("setConvexPath", "(Landroid/graphics/Path;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setEmpty()"/>
        /// </summary>
        public void SetEmpty()
        {
            IExecuteWithSignature("setEmpty", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setOval(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void SetOval(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("setOval", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setOval(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetOval(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setOval", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setPath(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        public void SetPath(Android.Graphics.Path arg0)
        {
            IExecuteWithSignature("setPath", "(Landroid/graphics/Path;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setRect(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void SetRect(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("setRect", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setRect(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetRect(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setRect", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setRoundRect(android.graphics.Rect,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void SetRoundRect(Android.Graphics.Rect arg0, float arg1)
        {
            IExecute("setRoundRect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Outline.html#setRoundRect(int,int,int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        public void SetRoundRect(int arg0, int arg1, int arg2, int arg3, float arg4)
        {
            IExecute("setRoundRect", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}