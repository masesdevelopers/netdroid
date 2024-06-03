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

namespace Android.Animation
{
    #region PropertyValuesHolder
    public partial class PropertyValuesHolder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofObject(android.util.Property,android.animation.TypeConverter,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg3"><typeparamref name="T"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfObject<V, T>(Android.Util.Property<object, V> arg0, Android.Animation.TypeConverter<T, V> arg1, Android.Animation.TypeEvaluator<T> arg2, params T[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1, arg2); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiFloat(java.lang.String,android.animation.TypeConverter,android.animation.TypeEvaluator,android.animation.Keyframe[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg3"><see cref="Android.Animation.Keyframe"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiFloat<T>(Java.Lang.String arg0, Android.Animation.TypeConverter<T, float[]> arg1, Android.Animation.TypeEvaluator<T> arg2, params Android.Animation.Keyframe[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiFloat", arg0, arg1, arg2); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiFloat", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiInt(java.lang.String,android.animation.TypeConverter,android.animation.TypeEvaluator,android.animation.Keyframe[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg3"><see cref="Android.Animation.Keyframe"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiInt<T>(Java.Lang.String arg0, Android.Animation.TypeConverter<T, int[]> arg1, Android.Animation.TypeEvaluator<T> arg2, params Android.Animation.Keyframe[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiInt", arg0, arg1, arg2); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiInt", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiFloat(java.lang.String,android.animation.TypeConverter,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg3"><typeparamref name="V"/></param>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiFloat<V>(Java.Lang.String arg0, Android.Animation.TypeConverter<V, float[]> arg1, Android.Animation.TypeEvaluator<V> arg2, params V[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiFloat", arg0, arg1, arg2); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiFloat", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiInt(java.lang.String,android.animation.TypeConverter,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg3"><typeparamref name="V"/></param>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiInt<V>(Java.Lang.String arg0, Android.Animation.TypeConverter<V, int[]> arg1, Android.Animation.TypeEvaluator<V> arg2, params V[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiInt", arg0, arg1, arg2); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiInt", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofObject(android.util.Property,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg2"><typeparamref name="V"/></param>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfObject<V>(Android.Util.Property arg0, Android.Animation.TypeEvaluator<V> arg1, params V[] arg2)
        {
            if (arg2.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofObject(android.util.Property,android.animation.TypeConverter,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path"/></param>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfObject<V>(Android.Util.Property<object, V> arg0, Android.Animation.TypeConverter<Android.Graphics.PointF, V> arg1, Android.Graphics.Path arg2)
        {
            return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofFloat(android.util.Property,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfFloat(Android.Util.Property<object, Java.Lang.Float> arg0, params float[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofFloat", arg0); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofFloat(java.lang.String,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfFloat(Java.Lang.String arg0, params float[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofFloat", arg0); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofInt(android.util.Property,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfInt(Android.Util.Property<object, Java.Lang.Integer> arg0, params int[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofInt", arg0); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofInt(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfInt(Java.Lang.String arg0, params int[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofInt", arg0); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofKeyframe(android.util.Property,android.animation.Keyframe[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        /// <param name="arg1"><see cref="Android.Animation.Keyframe"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfKeyframe(Android.Util.Property arg0, params Android.Animation.Keyframe[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofKeyframe", arg0); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofKeyframe", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofKeyframe(java.lang.String,android.animation.Keyframe[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Animation.Keyframe"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfKeyframe(Java.Lang.String arg0, params Android.Animation.Keyframe[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofKeyframe", arg0); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofKeyframe", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiFloat(java.lang.String,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiFloat(Java.Lang.String arg0, Android.Graphics.Path arg1)
        {
            return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiFloat(java.lang.String,float[][])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiFloat(Java.Lang.String arg0, float[][] arg1)
        {
            return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiInt(java.lang.String,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiInt(Java.Lang.String arg0, Android.Graphics.Path arg1)
        {
            return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofMultiInt(java.lang.String,int[][])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfMultiInt(Java.Lang.String arg0, int[][] arg1)
        {
            return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofMultiInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofObject(java.lang.String,android.animation.TypeConverter,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfObject(Java.Lang.String arg0, Android.Animation.TypeConverter<Android.Graphics.PointF, object> arg1, Android.Graphics.Path arg2)
        {
            return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#ofObject(java.lang.String,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public static Android.Animation.PropertyValuesHolder OfObject(Java.Lang.String arg0, Android.Animation.TypeEvaluator arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1); else return SExecute<Android.Animation.PropertyValuesHolder>(LocalBridgeClazz, "ofObject", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Animation.PropertyValuesHolder"/></returns>
        public Android.Animation.PropertyValuesHolder Clone()
        {
            return IExecuteWithSignature<Android.Animation.PropertyValuesHolder>("clone", "()Landroid/animation/PropertyValuesHolder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#getPropertyName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPropertyName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPropertyName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setConverter(android.animation.TypeConverter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.TypeConverter"/></param>
        public void SetConverter(Android.Animation.TypeConverter arg0)
        {
            IExecuteWithSignature("setConverter", "(Landroid/animation/TypeConverter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setEvaluator(android.animation.TypeEvaluator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.TypeEvaluator"/></param>
        public void SetEvaluator(Android.Animation.TypeEvaluator arg0)
        {
            IExecuteWithSignature("setEvaluator", "(Landroid/animation/TypeEvaluator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setFloatValues(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetFloatValues(params float[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("setFloatValues", "([F)V"); else IExecuteWithSignature("setFloatValues", "([F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setIntValues(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIntValues(params int[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("setIntValues", "([I)V"); else IExecuteWithSignature("setIntValues", "([I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setKeyframes(android.animation.Keyframe[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Keyframe"/></param>
        public void SetKeyframes(params Android.Animation.Keyframe[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("setKeyframes", "([Landroid/animation/Keyframe;)V"); else IExecuteWithSignature("setKeyframes", "([Landroid/animation/Keyframe;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setObjectValues(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetObjectValues(params object[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("setObjectValues", "([Ljava/lang/Object;)V"); else IExecuteWithSignature("setObjectValues", "([Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setProperty(android.util.Property)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        public void SetProperty(Android.Util.Property arg0)
        {
            IExecuteWithSignature("setProperty", "(Landroid/util/Property;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/PropertyValuesHolder.html#setPropertyName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPropertyName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPropertyName", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}