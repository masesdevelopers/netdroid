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

namespace Android.Webkit
{
    #region DateSorter
    public partial class DateSorter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/DateSorter.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public DateSorter(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/DateSorter.html#DAY_COUNT"/>
        /// </summary>
        public static int DAY_COUNT { get { if (!_DAY_COUNTReady) { _DAY_COUNTContent = SGetField<int>(LocalBridgeClazz, "DAY_COUNT"); _DAY_COUNTReady = true; } return _DAY_COUNTContent; } }
        private static int _DAY_COUNTContent = default;
        private static bool _DAY_COUNTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/DateSorter.html#getIndex(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndex(long arg0)
        {
            return IExecuteWithSignature<int>("getIndex", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/DateSorter.html#getLabel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLabel(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getLabel", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/DateSorter.html#getBoundary(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetBoundary(int arg0)
        {
            return IExecuteWithSignature<long>("getBoundary", "(I)J", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}