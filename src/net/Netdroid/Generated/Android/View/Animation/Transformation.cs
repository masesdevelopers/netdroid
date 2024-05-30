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

namespace Android.View.Animation
{
    #region Transformation
    public partial class Transformation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#TYPE_ALPHA"/>
        /// </summary>
        public static int TYPE_ALPHA { get { if (!_TYPE_ALPHAReady) { _TYPE_ALPHAContent = SGetField<int>(LocalBridgeClazz, "TYPE_ALPHA"); _TYPE_ALPHAReady = true; } return _TYPE_ALPHAContent; } }
        private static int _TYPE_ALPHAContent = default;
        private static bool _TYPE_ALPHAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#TYPE_BOTH"/>
        /// </summary>
        public static int TYPE_BOTH { get { if (!_TYPE_BOTHReady) { _TYPE_BOTHContent = SGetField<int>(LocalBridgeClazz, "TYPE_BOTH"); _TYPE_BOTHReady = true; } return _TYPE_BOTHContent; } }
        private static int _TYPE_BOTHContent = default;
        private static bool _TYPE_BOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#TYPE_IDENTITY"/>
        /// </summary>
        public static int TYPE_IDENTITY { get { if (!_TYPE_IDENTITYReady) { _TYPE_IDENTITYContent = SGetField<int>(LocalBridgeClazz, "TYPE_IDENTITY"); _TYPE_IDENTITYReady = true; } return _TYPE_IDENTITYContent; } }
        private static int _TYPE_IDENTITYContent = default;
        private static bool _TYPE_IDENTITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#TYPE_MATRIX"/>
        /// </summary>
        public static int TYPE_MATRIX { get { if (!_TYPE_MATRIXReady) { _TYPE_MATRIXContent = SGetField<int>(LocalBridgeClazz, "TYPE_MATRIX"); _TYPE_MATRIXReady = true; } return _TYPE_MATRIXContent; } }
        private static int _TYPE_MATRIXContent = default;
        private static bool _TYPE_MATRIXReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#getAlpha()"/> <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#setAlpha(float)"/>
        /// </summary>
        public float Alpha
        {
            get { return IExecuteWithSignature<float>("getAlpha", "()F"); } set { IExecuteWithSignature("setAlpha", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#getMatrix()"/> 
        /// </summary>
        public Android.Graphics.Matrix Matrix
        {
            get { return IExecuteWithSignature<Android.Graphics.Matrix>("getMatrix", "()Landroid/graphics/Matrix;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#getTransformationType()"/> <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#setTransformationType(int)"/>
        /// </summary>
        public int TransformationType
        {
            get { return IExecuteWithSignature<int>("getTransformationType", "()I"); } set { IExecuteWithSignature("setTransformationType", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#toShortString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToShortString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toShortString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#compose(android.view.animation.Transformation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Transformation"/></param>
        public void Compose(Android.View.Animation.Transformation arg0)
        {
            IExecuteWithSignature("compose", "(Landroid/view/animation/Transformation;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Transformation.html#set(android.view.animation.Transformation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Transformation"/></param>
        public void Set(Android.View.Animation.Transformation arg0)
        {
            IExecuteWithSignature("set", "(Landroid/view/animation/Transformation;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}