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
    #region WorkSource
    public partial class WorkSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#%3Cinit%3E(android.os.WorkSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.WorkSource"/></param>
        public WorkSource(Android.Os.WorkSource arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#add(android.os.WorkSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.WorkSource"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(Android.Os.WorkSource arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Landroid/os/WorkSource;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#diff(android.os.WorkSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.WorkSource"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Diff(Android.Os.WorkSource arg0)
        {
            return IExecuteWithSignature<bool>("diff", "(Landroid/os/WorkSource;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#remove(android.os.WorkSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.WorkSource"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Android.Os.WorkSource arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Landroid/os/WorkSource;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#set(android.os.WorkSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.WorkSource"/></param>
        public void Set(Android.Os.WorkSource arg0)
        {
            IExecuteWithSignature("set", "(Landroid/os/WorkSource;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/WorkSource.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}