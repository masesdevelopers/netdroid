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

namespace Android.Graphics.Drawable
{
    #region AnimatedStateListDrawable
    public partial class AnimatedStateListDrawable
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
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedStateListDrawable.html#addTransition(int,int,android.graphics.drawable.Drawable,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <typeparam name="T"><see cref="Android.Graphics.Drawable.Drawable, Android.Graphics.Drawable.IAnimatable"/></typeparam>
        public void AddTransition<T>(int arg0, int arg1, T arg2, bool arg3) where T: Android.Graphics.Drawable.Drawable, Android.Graphics.Drawable.IAnimatable, new()
        {
            IExecute("addTransition", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/AnimatedStateListDrawable.html#addState(int[],android.graphics.drawable.Drawable,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void AddState(int[] arg0, Android.Graphics.Drawable.Drawable arg1, int arg2)
        {
            IExecute("addState", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}