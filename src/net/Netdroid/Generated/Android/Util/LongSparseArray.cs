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

namespace Android.Util
{
    #region LongSparseArray
    public partial class LongSparseArray
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public LongSparseArray(int arg0)
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
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.LongSparseArray"/></returns>
        public Android.Util.LongSparseArray Clone()
        {
            return IExecuteWithSignature<Android.Util.LongSparseArray>("clone", "()Landroid/util/LongSparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#get(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(long arg0, object arg1)
        {
            return IExecute("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#get(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(long arg0)
        {
            return IExecuteWithSignature("get", "(J)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#valueAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ValueAt(int arg0)
        {
            return IExecuteWithSignature("valueAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#indexOfKey(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfKey(long arg0)
        {
            return IExecuteWithSignature<int>("indexOfKey", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#indexOfValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfValue(object arg0)
        {
            return IExecuteWithSignature<int>("indexOfValue", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#keyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long KeyAt(int arg0)
        {
            return IExecuteWithSignature<long>("keyAt", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#append(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Append(long arg0, object arg1)
        {
            IExecute("append", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#delete(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Delete(long arg0)
        {
            IExecuteWithSignature("delete", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#put(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(long arg0, object arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#remove(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Remove(long arg0)
        {
            IExecuteWithSignature("remove", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#removeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveAt(int arg0)
        {
            IExecuteWithSignature("removeAt", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#setValueAt(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetValueAt(int arg0, object arg1)
        {
            IExecute("setValueAt", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongSparseArray<E>
    public partial class LongSparseArray<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public LongSparseArray(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Util.LongSparseArray{E}"/> to <see cref="Android.Util.LongSparseArray"/>
        /// </summary>
        public static implicit operator Android.Util.LongSparseArray(Android.Util.LongSparseArray<E> t) => t.Cast<Android.Util.LongSparseArray>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.LongSparseArray"/></returns>
        public Android.Util.LongSparseArray<E> Clone()
        {
            return IExecuteWithSignature<Android.Util.LongSparseArray<E>>("clone", "()Landroid/util/LongSparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#get(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Get(long arg0, E arg1)
        {
            return IExecute<E>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#get(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Get(long arg0)
        {
            return IExecuteWithSignature<E>("get", "(J)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#valueAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E ValueAt(int arg0)
        {
            return IExecuteWithSignature<E>("valueAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#indexOfKey(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfKey(long arg0)
        {
            return IExecuteWithSignature<int>("indexOfKey", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#indexOfValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfValue(E arg0)
        {
            return IExecuteWithSignature<int>("indexOfValue", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#keyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long KeyAt(int arg0)
        {
            return IExecuteWithSignature<long>("keyAt", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#append(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Append(long arg0, E arg1)
        {
            IExecute("append", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#delete(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Delete(long arg0)
        {
            IExecuteWithSignature("delete", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#put(long,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Put(long arg0, E arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#remove(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Remove(long arg0)
        {
            IExecuteWithSignature("remove", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#removeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveAt(int arg0)
        {
            IExecuteWithSignature("removeAt", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/LongSparseArray.html#setValueAt(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void SetValueAt(int arg0, E arg1)
        {
            IExecute("setValueAt", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}