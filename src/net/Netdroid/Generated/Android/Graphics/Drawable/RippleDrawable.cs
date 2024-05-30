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
    #region RippleDrawable
    public partial class RippleDrawable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RippleDrawable.html#%3Cinit%3E(android.content.res.ColorStateList,android.graphics.drawable.Drawable,android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public RippleDrawable(Android.Content.Res.ColorStateList arg0, Android.Graphics.Drawable.Drawable arg1, Android.Graphics.Drawable.Drawable arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RippleDrawable.html#RADIUS_AUTO"/>
        /// </summary>
        public static int RADIUS_AUTO { get { if (!_RADIUS_AUTOReady) { _RADIUS_AUTOContent = SGetField<int>(LocalBridgeClazz, "RADIUS_AUTO"); _RADIUS_AUTOReady = true; } return _RADIUS_AUTOContent; } }
        private static int _RADIUS_AUTOContent = default;
        private static bool _RADIUS_AUTOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RippleDrawable.html#getEffectColor()"/> <see href="https://developer.android.com/reference/android/graphics/drawable/RippleDrawable.html#setEffectColor(android.content.res.ColorStateList)"/>
        /// </summary>
        public Android.Content.Res.ColorStateList EffectColor
        {
            get { return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getEffectColor", "()Landroid/content/res/ColorStateList;"); } set { IExecuteWithSignature("setEffectColor", "(Landroid/content/res/ColorStateList;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RippleDrawable.html#getRadius()"/> <see href="https://developer.android.com/reference/android/graphics/drawable/RippleDrawable.html#setRadius(int)"/>
        /// </summary>
        public int Radius
        {
            get { return IExecuteWithSignature<int>("getRadius", "()I"); } set { IExecuteWithSignature("setRadius", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/RippleDrawable.html#setColor(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        public void SetColor(Android.Content.Res.ColorStateList arg0)
        {
            IExecuteWithSignature("setColor", "(Landroid/content/res/ColorStateList;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}