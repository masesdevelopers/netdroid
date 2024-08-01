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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Animation
{
    #region TypeConverter
    public partial class TypeConverter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/TypeConverter.html#%3Cinit%3E(java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public TypeConverter(Java.Lang.Class arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/animation/TypeConverter.html#convert(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Convert(object arg0)
        {
            return IExecuteWithSignature("convert", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeConverter<T, V>
    public partial class TypeConverter<T, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/TypeConverter.html#%3Cinit%3E(java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public TypeConverter(Java.Lang.Class arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Animation.TypeConverter{T, V}"/> to <see cref="Android.Animation.TypeConverter"/>
        /// </summary>
        public static implicit operator Android.Animation.TypeConverter(Android.Animation.TypeConverter<T, V> t) => t.Cast<Android.Animation.TypeConverter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/TypeConverter.html#convert(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V Convert(T arg0)
        {
            return IExecuteWithSignature<V>("convert", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}