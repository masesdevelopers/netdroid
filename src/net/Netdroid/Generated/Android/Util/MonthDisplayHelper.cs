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
    #region MonthDisplayHelper
    public partial class MonthDisplayHelper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public MonthDisplayHelper(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public MonthDisplayHelper(int arg0, int arg1)
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
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#isWithinCurrentMonth(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsWithinCurrentMonth(int arg0, int arg1)
        {
            return IExecute<bool>("isWithinCurrentMonth", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getColumnOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnOf(int arg0)
        {
            return IExecuteWithSignature<int>("getColumnOf", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getDayAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDayAt(int arg0, int arg1)
        {
            return IExecute<int>("getDayAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getFirstDayOfMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFirstDayOfMonth()
        {
            return IExecuteWithSignature<int>("getFirstDayOfMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMonth()
        {
            return IExecuteWithSignature<int>("getMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getNumberOfDaysInMonth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNumberOfDaysInMonth()
        {
            return IExecuteWithSignature<int>("getNumberOfDaysInMonth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOffset()
        {
            return IExecuteWithSignature<int>("getOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getRowOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRowOf(int arg0)
        {
            return IExecuteWithSignature<int>("getRowOf", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getWeekStartDay()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWeekStartDay()
        {
            return IExecuteWithSignature<int>("getWeekStartDay", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getYear()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetYear()
        {
            return IExecuteWithSignature<int>("getYear", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#getDigitsForRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetDigitsForRow(int arg0)
        {
            return IExecuteWithSignatureArray<int>("getDigitsForRow", "(I)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#nextMonth()"/>
        /// </summary>
        public void NextMonth()
        {
            IExecuteWithSignature("nextMonth", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/MonthDisplayHelper.html#previousMonth()"/>
        /// </summary>
        public void PreviousMonth()
        {
            IExecuteWithSignature("previousMonth", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}