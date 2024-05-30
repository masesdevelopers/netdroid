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

namespace Android.Content
{
    #region SyncStats
    public partial class SyncStats
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public SyncStats(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numAuthExceptions"/>
        /// </summary>
        public long numAuthExceptions { get { return IGetField<long>("numAuthExceptions"); } set { ISetField("numAuthExceptions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numConflictDetectedExceptions"/>
        /// </summary>
        public long numConflictDetectedExceptions { get { return IGetField<long>("numConflictDetectedExceptions"); } set { ISetField("numConflictDetectedExceptions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numDeletes"/>
        /// </summary>
        public long numDeletes { get { return IGetField<long>("numDeletes"); } set { ISetField("numDeletes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numEntries"/>
        /// </summary>
        public long numEntries { get { return IGetField<long>("numEntries"); } set { ISetField("numEntries", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numInserts"/>
        /// </summary>
        public long numInserts { get { return IGetField<long>("numInserts"); } set { ISetField("numInserts", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numIoExceptions"/>
        /// </summary>
        public long numIoExceptions { get { return IGetField<long>("numIoExceptions"); } set { ISetField("numIoExceptions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numParseExceptions"/>
        /// </summary>
        public long numParseExceptions { get { return IGetField<long>("numParseExceptions"); } set { ISetField("numParseExceptions", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numSkippedEntries"/>
        /// </summary>
        public long numSkippedEntries { get { return IGetField<long>("numSkippedEntries"); } set { ISetField("numSkippedEntries", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#numUpdates"/>
        /// </summary>
        public long numUpdates { get { return IGetField<long>("numUpdates"); } set { ISetField("numUpdates", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncStats.html#writeToParcel(android.os.Parcel,int)"/>
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