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

namespace Android.Widget
{
    #region AbsSeekBar
    public partial class AbsSeekBar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public AbsSeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public AbsSeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public AbsSeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public AbsSeekBar(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getKeyProgressIncrement()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setKeyProgressIncrement(int)"/>
        /// </summary>
        public int KeyProgressIncrement
        {
            get { return IExecuteWithSignature<int>("getKeyProgressIncrement", "()I"); } set { IExecuteWithSignature("setKeyProgressIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getSplitTrack()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setSplitTrack(boolean)"/>
        /// </summary>
        public bool SplitTrack
        {
            get { return IExecuteWithSignature<bool>("getSplitTrack", "()Z"); } set { IExecuteWithSignature("setSplitTrack", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumb()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumb(android.graphics.drawable.Drawable)"/>
        /// </summary>
        public Android.Graphics.Drawable.Drawable Thumb
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getThumb", "()Landroid/graphics/drawable/Drawable;"); } set { IExecuteWithSignature("setThumb", "(Landroid/graphics/drawable/Drawable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbOffset()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbOffset(int)"/>
        /// </summary>
        public int ThumbOffset
        {
            get { return IExecuteWithSignature<int>("getThumbOffset", "()I"); } set { IExecuteWithSignature("setThumbOffset", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbTintBlendMode()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        public Android.Graphics.BlendMode ThumbTintBlendMode
        {
            get { return IExecuteWithSignature<Android.Graphics.BlendMode>("getThumbTintBlendMode", "()Landroid/graphics/BlendMode;"); } set { IExecuteWithSignature("setThumbTintBlendMode", "(Landroid/graphics/BlendMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbTintList()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        public Android.Content.Res.ColorStateList ThumbTintList
        {
            get { return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getThumbTintList", "()Landroid/content/res/ColorStateList;"); } set { IExecuteWithSignature("setThumbTintList", "(Landroid/content/res/ColorStateList;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getThumbTintMode()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setThumbTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        public Android.Graphics.PorterDuff.Mode ThumbTintMode
        {
            get { return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getThumbTintMode", "()Landroid/graphics/PorterDuff$Mode;"); } set { IExecuteWithSignature("setThumbTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMark()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMark(android.graphics.drawable.Drawable)"/>
        /// </summary>
        public Android.Graphics.Drawable.Drawable TickMark
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getTickMark", "()Landroid/graphics/drawable/Drawable;"); } set { IExecuteWithSignature("setTickMark", "(Landroid/graphics/drawable/Drawable;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMarkTintBlendMode()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMarkTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        public Android.Graphics.BlendMode TickMarkTintBlendMode
        {
            get { return IExecuteWithSignature<Android.Graphics.BlendMode>("getTickMarkTintBlendMode", "()Landroid/graphics/BlendMode;"); } set { IExecuteWithSignature("setTickMarkTintBlendMode", "(Landroid/graphics/BlendMode;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMarkTintList()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMarkTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        public Android.Content.Res.ColorStateList TickMarkTintList
        {
            get { return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getTickMarkTintList", "()Landroid/content/res/ColorStateList;"); } set { IExecuteWithSignature("setTickMarkTintList", "(Landroid/content/res/ColorStateList;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#getTickMarkTintMode()"/> <see href="https://developer.android.com/reference/android/widget/AbsSeekBar.html#setTickMarkTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        public Android.Graphics.PorterDuff.Mode TickMarkTintMode
        {
            get { return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getTickMarkTintMode", "()Landroid/graphics/PorterDuff$Mode;"); } set { IExecuteWithSignature("setTickMarkTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}