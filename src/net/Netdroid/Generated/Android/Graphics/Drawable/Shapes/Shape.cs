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

namespace Android.Graphics.Drawable.Shapes
{
    #region Shape
    public partial class Shape
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
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/shapes/Shape.html#draw(android.graphics.Canvas,android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Paint"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Android.Graphics.Paint arg1)
        {
            IExecute("draw", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/shapes/Shape.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Shapes.Shape"/></returns>
        /// <exception cref="Java.Lang.CloneNotSupportedException"/>
        public Android.Graphics.Drawable.Shapes.Shape Clone()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Shapes.Shape>("clone", "()Landroid/graphics/drawable/shapes/Shape;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/shapes/Shape.html#hasAlpha()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAlpha()
        {
            return IExecuteWithSignature<bool>("hasAlpha", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/shapes/Shape.html#getHeight()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetHeight()
        {
            return IExecuteWithSignature<float>("getHeight", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/shapes/Shape.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetWidth()
        {
            return IExecuteWithSignature<float>("getWidth", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/shapes/Shape.html#resize(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void Resize(float arg0, float arg1)
        {
            IExecute("resize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/shapes/Shape.html#getOutline(android.graphics.Outline)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Outline"/></param>
        public void GetOutline(Android.Graphics.Outline arg0)
        {
            IExecuteWithSignature("getOutline", "(Landroid/graphics/Outline;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}