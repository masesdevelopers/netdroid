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

namespace Android.Util
{
    #region SparseLongArray
    public partial class SparseLongArray
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public SparseLongArray(int arg0)
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
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseLongArray"/></returns>
        public Android.Util.SparseLongArray Clone()
        {
            return IExecuteWithSignature<Android.Util.SparseLongArray>("clone", "()Landroid/util/SparseLongArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#indexOfKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfKey(int arg0)
        {
            return IExecuteWithSignature<int>("indexOfKey", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#indexOfValue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfValue(long arg0)
        {
            return IExecuteWithSignature<int>("indexOfValue", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#keyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int KeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("keyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#get(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(int arg0, long arg1)
        {
            return IExecute<long>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(int arg0)
        {
            return IExecuteWithSignature<long>("get", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#valueAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long ValueAt(int arg0)
        {
            return IExecuteWithSignature<long>("valueAt", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#append(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Append(int arg0, long arg1)
        {
            IExecute("append", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#delete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Delete(int arg0)
        {
            IExecuteWithSignature("delete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#put(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Put(int arg0, long arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseLongArray.html#removeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveAt(int arg0)
        {
            IExecuteWithSignature("removeAt", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}