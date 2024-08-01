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

namespace Android.Icu.Util
{
    #region TaiwanCalendar
    public partial class TaiwanCalendar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        public TaiwanCalendar(Android.Icu.Util.TimeZone arg0, Android.Icu.Util.ULocale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public TaiwanCalendar(Android.Icu.Util.TimeZone arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(android.icu.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        public TaiwanCalendar(Android.Icu.Util.TimeZone arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public TaiwanCalendar(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public TaiwanCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TaiwanCalendar(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public TaiwanCalendar(Java.Util.Date arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public TaiwanCalendar(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#BEFORE_MINGUO"/>
        /// </summary>
        public static int BEFORE_MINGUO { get { if (!_BEFORE_MINGUOReady) { _BEFORE_MINGUOContent = SGetField<int>(LocalBridgeClazz, "BEFORE_MINGUO"); _BEFORE_MINGUOReady = true; } return _BEFORE_MINGUOContent; } }
        private static int _BEFORE_MINGUOContent = default;
        private static bool _BEFORE_MINGUOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/TaiwanCalendar.html#MINGUO"/>
        /// </summary>
        public static int MINGUO { get { if (!_MINGUOReady) { _MINGUOContent = SGetField<int>(LocalBridgeClazz, "MINGUO"); _MINGUOReady = true; } return _MINGUOContent; } }
        private static int _MINGUOContent = default;
        private static bool _MINGUOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}