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

namespace Android.Text
{
    #region TextPaint
    public partial class TextPaint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#%3Cinit%3E(android.graphics.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Paint"/></param>
        public TextPaint(Android.Graphics.Paint arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public TextPaint(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#density"/>
        /// </summary>
        public float density { get { return IGetField<float>("density"); } set { ISetField("density", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#underlineThickness"/>
        /// </summary>
        public float underlineThickness { get { return IGetField<float>("underlineThickness"); } set { ISetField("underlineThickness", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#baselineShift"/>
        /// </summary>
        public int baselineShift { get { return IGetField<int>("baselineShift"); } set { ISetField("baselineShift", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#bgColor"/>
        /// </summary>
        public int bgColor { get { return IGetField<int>("bgColor"); } set { ISetField("bgColor", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#linkColor"/>
        /// </summary>
        public int linkColor { get { return IGetField<int>("linkColor"); } set { ISetField("linkColor", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#underlineColor"/>
        /// </summary>
        public int underlineColor { get { return IGetField<int>("underlineColor"); } set { ISetField("underlineColor", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#drawableState"/>
        /// </summary>
        public int[] drawableState { get { return IGetFieldArray<int>("drawableState"); } set { ISetField("drawableState", value); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/TextPaint.html#set(android.text.TextPaint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Text.TextPaint"/></param>
        public void Set(Android.Text.TextPaint arg0)
        {
            IExecuteWithSignature("set", "(Landroid/text/TextPaint;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}