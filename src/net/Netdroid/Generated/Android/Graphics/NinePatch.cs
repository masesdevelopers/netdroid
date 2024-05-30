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
    #region NinePatch
    public partial class NinePatch
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#%3Cinit%3E(android.graphics.Bitmap,byte[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public NinePatch(Android.Graphics.Bitmap arg0, byte[] arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#%3Cinit%3E(android.graphics.Bitmap,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public NinePatch(Android.Graphics.Bitmap arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#isNinePatchChunk(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNinePatchChunk(byte[] arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isNinePatchChunk", "([B)Z", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getBitmap()"/> 
        /// </summary>
        public Android.Graphics.Bitmap Bitmap
        {
            get { return IExecuteWithSignature<Android.Graphics.Bitmap>("getBitmap", "()Landroid/graphics/Bitmap;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getDensity()"/> 
        /// </summary>
        public int Density
        {
            get { return IExecuteWithSignature<int>("getDensity", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getPaint()"/> <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#setPaint(android.graphics.Paint)"/>
        /// </summary>
        public Android.Graphics.Paint Paint
        {
            get { return IExecuteWithSignature<Android.Graphics.Paint>("getPaint", "()Landroid/graphics/Paint;"); } set { IExecuteWithSignature("setPaint", "(Landroid/graphics/Paint;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#getTransparentRegion(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.Graphics.Region"/></returns>
        public Android.Graphics.Region GetTransparentRegion(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Region>("getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#hasAlpha()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAlpha()
        {
            return IExecuteWithSignature<bool>("hasAlpha", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#draw(android.graphics.Canvas,android.graphics.Rect,android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Paint"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Android.Graphics.Rect arg1, Android.Graphics.Paint arg2)
        {
            IExecute("draw", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#draw(android.graphics.Canvas,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Android.Graphics.Rect arg1)
        {
            IExecute("draw", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/NinePatch.html#draw(android.graphics.Canvas,android.graphics.RectF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.RectF"/></param>
        public void Draw(Android.Graphics.Canvas arg0, Android.Graphics.RectF arg1)
        {
            IExecute("draw", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}