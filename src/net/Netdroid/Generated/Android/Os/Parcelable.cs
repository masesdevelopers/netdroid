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

namespace Android.Os
{
    #region IParcelable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IParcelable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Parcelable
    public partial class Parcelable : Android.Os.IParcelable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Parcelable.html#CONTENTS_FILE_DESCRIPTOR"/>
        /// </summary>
        public static int CONTENTS_FILE_DESCRIPTOR { get { if (!_CONTENTS_FILE_DESCRIPTORReady) { _CONTENTS_FILE_DESCRIPTORContent = SGetField<int>(LocalBridgeClazz, "CONTENTS_FILE_DESCRIPTOR"); _CONTENTS_FILE_DESCRIPTORReady = true; } return _CONTENTS_FILE_DESCRIPTORContent; } }
        private static int _CONTENTS_FILE_DESCRIPTORContent = default;
        private static bool _CONTENTS_FILE_DESCRIPTORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Parcelable.html#PARCELABLE_WRITE_RETURN_VALUE"/>
        /// </summary>
        public static int PARCELABLE_WRITE_RETURN_VALUE { get { if (!_PARCELABLE_WRITE_RETURN_VALUEReady) { _PARCELABLE_WRITE_RETURN_VALUEContent = SGetField<int>(LocalBridgeClazz, "PARCELABLE_WRITE_RETURN_VALUE"); _PARCELABLE_WRITE_RETURN_VALUEReady = true; } return _PARCELABLE_WRITE_RETURN_VALUEContent; } }
        private static int _PARCELABLE_WRITE_RETURN_VALUEContent = default;
        private static bool _PARCELABLE_WRITE_RETURN_VALUEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Parcelable.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Parcelable.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region ClassLoaderCreator
        public partial class ClassLoaderCreator
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
            /// <see href="https://developer.android.com/reference/android/os/Parcelable.ClassLoaderCreator.html#createFromParcel(android.os.Parcel,java.lang.ClassLoader)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
            /// <returns><see cref="object"/></returns>
            public object CreateFromParcel(Android.Os.Parcel arg0, Java.Lang.ClassLoader arg1)
            {
                return IExecute("createFromParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ClassLoaderCreator<T>
        public partial class ClassLoaderCreator<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Os.Parcelable.ClassLoaderCreator{T}"/> to <see cref="Android.Os.Parcelable.ClassLoaderCreator"/>
            /// </summary>
            public static implicit operator Android.Os.Parcelable.ClassLoaderCreator(Android.Os.Parcelable.ClassLoaderCreator<T> t) => t.Cast<Android.Os.Parcelable.ClassLoaderCreator>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Parcelable.ClassLoaderCreator.html#createFromParcel(android.os.Parcel,java.lang.ClassLoader)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
            /// <returns><typeparamref name="T"/></returns>
            public T CreateFromParcel(Android.Os.Parcel arg0, Java.Lang.ClassLoader arg1)
            {
                return IExecute<T>("createFromParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Creator
        public partial class Creator
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
            /// <see href="https://developer.android.com/reference/android/os/Parcelable.Creator.html#createFromParcel(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <returns><see cref="object"/></returns>
            public object CreateFromParcel(Android.Os.Parcel arg0)
            {
                return IExecuteWithSignature("createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Parcelable.Creator.html#newArray(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="object"/></returns>
            public object[] NewArray(int arg0)
            {
                return IExecuteWithSignatureArray<object>("newArray", "(I)[Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Creator<T>
        public partial class Creator<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Os.Parcelable.Creator{T}"/> to <see cref="Android.Os.Parcelable.Creator"/>
            /// </summary>
            public static implicit operator Android.Os.Parcelable.Creator(Android.Os.Parcelable.Creator<T> t) => t.Cast<Android.Os.Parcelable.Creator>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Parcelable.Creator.html#createFromParcel(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <returns><typeparamref name="T"/></returns>
            public T CreateFromParcel(Android.Os.Parcel arg0)
            {
                return IExecuteWithSignature<T>("createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/Parcelable.Creator.html#newArray(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><typeparamref name="T"/></returns>
            public T[] NewArray(int arg0)
            {
                return IExecuteWithSignatureArray<T>("newArray", "(I)[Ljava/lang/Object;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}