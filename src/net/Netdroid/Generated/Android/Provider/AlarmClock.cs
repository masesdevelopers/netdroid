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

namespace Android.Provider
{
    #region AlarmClock
    public partial class AlarmClock
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ACTION_DISMISS_ALARM"/>
        /// </summary>
        public static Java.Lang.String ACTION_DISMISS_ALARM { get { if (!_ACTION_DISMISS_ALARMReady) { _ACTION_DISMISS_ALARMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_DISMISS_ALARM"); _ACTION_DISMISS_ALARMReady = true; } return _ACTION_DISMISS_ALARMContent; } }
        private static Java.Lang.String _ACTION_DISMISS_ALARMContent = default;
        private static bool _ACTION_DISMISS_ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ACTION_DISMISS_TIMER"/>
        /// </summary>
        public static Java.Lang.String ACTION_DISMISS_TIMER { get { if (!_ACTION_DISMISS_TIMERReady) { _ACTION_DISMISS_TIMERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_DISMISS_TIMER"); _ACTION_DISMISS_TIMERReady = true; } return _ACTION_DISMISS_TIMERContent; } }
        private static Java.Lang.String _ACTION_DISMISS_TIMERContent = default;
        private static bool _ACTION_DISMISS_TIMERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ACTION_SET_ALARM"/>
        /// </summary>
        public static Java.Lang.String ACTION_SET_ALARM { get { if (!_ACTION_SET_ALARMReady) { _ACTION_SET_ALARMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SET_ALARM"); _ACTION_SET_ALARMReady = true; } return _ACTION_SET_ALARMContent; } }
        private static Java.Lang.String _ACTION_SET_ALARMContent = default;
        private static bool _ACTION_SET_ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ACTION_SET_TIMER"/>
        /// </summary>
        public static Java.Lang.String ACTION_SET_TIMER { get { if (!_ACTION_SET_TIMERReady) { _ACTION_SET_TIMERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SET_TIMER"); _ACTION_SET_TIMERReady = true; } return _ACTION_SET_TIMERContent; } }
        private static Java.Lang.String _ACTION_SET_TIMERContent = default;
        private static bool _ACTION_SET_TIMERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ACTION_SHOW_ALARMS"/>
        /// </summary>
        public static Java.Lang.String ACTION_SHOW_ALARMS { get { if (!_ACTION_SHOW_ALARMSReady) { _ACTION_SHOW_ALARMSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SHOW_ALARMS"); _ACTION_SHOW_ALARMSReady = true; } return _ACTION_SHOW_ALARMSContent; } }
        private static Java.Lang.String _ACTION_SHOW_ALARMSContent = default;
        private static bool _ACTION_SHOW_ALARMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ACTION_SHOW_TIMERS"/>
        /// </summary>
        public static Java.Lang.String ACTION_SHOW_TIMERS { get { if (!_ACTION_SHOW_TIMERSReady) { _ACTION_SHOW_TIMERSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SHOW_TIMERS"); _ACTION_SHOW_TIMERSReady = true; } return _ACTION_SHOW_TIMERSContent; } }
        private static Java.Lang.String _ACTION_SHOW_TIMERSContent = default;
        private static bool _ACTION_SHOW_TIMERSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ACTION_SNOOZE_ALARM"/>
        /// </summary>
        public static Java.Lang.String ACTION_SNOOZE_ALARM { get { if (!_ACTION_SNOOZE_ALARMReady) { _ACTION_SNOOZE_ALARMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_SNOOZE_ALARM"); _ACTION_SNOOZE_ALARMReady = true; } return _ACTION_SNOOZE_ALARMContent; } }
        private static Java.Lang.String _ACTION_SNOOZE_ALARMContent = default;
        private static bool _ACTION_SNOOZE_ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ALARM_SEARCH_MODE_ALL"/>
        /// </summary>
        public static Java.Lang.String ALARM_SEARCH_MODE_ALL { get { if (!_ALARM_SEARCH_MODE_ALLReady) { _ALARM_SEARCH_MODE_ALLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ALARM_SEARCH_MODE_ALL"); _ALARM_SEARCH_MODE_ALLReady = true; } return _ALARM_SEARCH_MODE_ALLContent; } }
        private static Java.Lang.String _ALARM_SEARCH_MODE_ALLContent = default;
        private static bool _ALARM_SEARCH_MODE_ALLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ALARM_SEARCH_MODE_LABEL"/>
        /// </summary>
        public static Java.Lang.String ALARM_SEARCH_MODE_LABEL { get { if (!_ALARM_SEARCH_MODE_LABELReady) { _ALARM_SEARCH_MODE_LABELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ALARM_SEARCH_MODE_LABEL"); _ALARM_SEARCH_MODE_LABELReady = true; } return _ALARM_SEARCH_MODE_LABELContent; } }
        private static Java.Lang.String _ALARM_SEARCH_MODE_LABELContent = default;
        private static bool _ALARM_SEARCH_MODE_LABELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ALARM_SEARCH_MODE_NEXT"/>
        /// </summary>
        public static Java.Lang.String ALARM_SEARCH_MODE_NEXT { get { if (!_ALARM_SEARCH_MODE_NEXTReady) { _ALARM_SEARCH_MODE_NEXTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ALARM_SEARCH_MODE_NEXT"); _ALARM_SEARCH_MODE_NEXTReady = true; } return _ALARM_SEARCH_MODE_NEXTContent; } }
        private static Java.Lang.String _ALARM_SEARCH_MODE_NEXTContent = default;
        private static bool _ALARM_SEARCH_MODE_NEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#ALARM_SEARCH_MODE_TIME"/>
        /// </summary>
        public static Java.Lang.String ALARM_SEARCH_MODE_TIME { get { if (!_ALARM_SEARCH_MODE_TIMEReady) { _ALARM_SEARCH_MODE_TIMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ALARM_SEARCH_MODE_TIME"); _ALARM_SEARCH_MODE_TIMEReady = true; } return _ALARM_SEARCH_MODE_TIMEContent; } }
        private static Java.Lang.String _ALARM_SEARCH_MODE_TIMEContent = default;
        private static bool _ALARM_SEARCH_MODE_TIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_ALARM_SEARCH_MODE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ALARM_SEARCH_MODE { get { if (!_EXTRA_ALARM_SEARCH_MODEReady) { _EXTRA_ALARM_SEARCH_MODEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ALARM_SEARCH_MODE"); _EXTRA_ALARM_SEARCH_MODEReady = true; } return _EXTRA_ALARM_SEARCH_MODEContent; } }
        private static Java.Lang.String _EXTRA_ALARM_SEARCH_MODEContent = default;
        private static bool _EXTRA_ALARM_SEARCH_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_ALARM_SNOOZE_DURATION"/>
        /// </summary>
        public static Java.Lang.String EXTRA_ALARM_SNOOZE_DURATION { get { if (!_EXTRA_ALARM_SNOOZE_DURATIONReady) { _EXTRA_ALARM_SNOOZE_DURATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_ALARM_SNOOZE_DURATION"); _EXTRA_ALARM_SNOOZE_DURATIONReady = true; } return _EXTRA_ALARM_SNOOZE_DURATIONContent; } }
        private static Java.Lang.String _EXTRA_ALARM_SNOOZE_DURATIONContent = default;
        private static bool _EXTRA_ALARM_SNOOZE_DURATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_DAYS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_DAYS { get { if (!_EXTRA_DAYSReady) { _EXTRA_DAYSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_DAYS"); _EXTRA_DAYSReady = true; } return _EXTRA_DAYSContent; } }
        private static Java.Lang.String _EXTRA_DAYSContent = default;
        private static bool _EXTRA_DAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_HOUR"/>
        /// </summary>
        public static Java.Lang.String EXTRA_HOUR { get { if (!_EXTRA_HOURReady) { _EXTRA_HOURContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_HOUR"); _EXTRA_HOURReady = true; } return _EXTRA_HOURContent; } }
        private static Java.Lang.String _EXTRA_HOURContent = default;
        private static bool _EXTRA_HOURReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_IS_PM"/>
        /// </summary>
        public static Java.Lang.String EXTRA_IS_PM { get { if (!_EXTRA_IS_PMReady) { _EXTRA_IS_PMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_IS_PM"); _EXTRA_IS_PMReady = true; } return _EXTRA_IS_PMContent; } }
        private static Java.Lang.String _EXTRA_IS_PMContent = default;
        private static bool _EXTRA_IS_PMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_LENGTH"/>
        /// </summary>
        public static Java.Lang.String EXTRA_LENGTH { get { if (!_EXTRA_LENGTHReady) { _EXTRA_LENGTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_LENGTH"); _EXTRA_LENGTHReady = true; } return _EXTRA_LENGTHContent; } }
        private static Java.Lang.String _EXTRA_LENGTHContent = default;
        private static bool _EXTRA_LENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_MESSAGE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MESSAGE { get { if (!_EXTRA_MESSAGEReady) { _EXTRA_MESSAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MESSAGE"); _EXTRA_MESSAGEReady = true; } return _EXTRA_MESSAGEContent; } }
        private static Java.Lang.String _EXTRA_MESSAGEContent = default;
        private static bool _EXTRA_MESSAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_MINUTES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_MINUTES { get { if (!_EXTRA_MINUTESReady) { _EXTRA_MINUTESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_MINUTES"); _EXTRA_MINUTESReady = true; } return _EXTRA_MINUTESContent; } }
        private static Java.Lang.String _EXTRA_MINUTESContent = default;
        private static bool _EXTRA_MINUTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_RINGTONE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RINGTONE { get { if (!_EXTRA_RINGTONEReady) { _EXTRA_RINGTONEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RINGTONE"); _EXTRA_RINGTONEReady = true; } return _EXTRA_RINGTONEContent; } }
        private static Java.Lang.String _EXTRA_RINGTONEContent = default;
        private static bool _EXTRA_RINGTONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_SKIP_UI"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SKIP_UI { get { if (!_EXTRA_SKIP_UIReady) { _EXTRA_SKIP_UIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SKIP_UI"); _EXTRA_SKIP_UIReady = true; } return _EXTRA_SKIP_UIContent; } }
        private static Java.Lang.String _EXTRA_SKIP_UIContent = default;
        private static bool _EXTRA_SKIP_UIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#EXTRA_VIBRATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_VIBRATE { get { if (!_EXTRA_VIBRATEReady) { _EXTRA_VIBRATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_VIBRATE"); _EXTRA_VIBRATEReady = true; } return _EXTRA_VIBRATEContent; } }
        private static Java.Lang.String _EXTRA_VIBRATEContent = default;
        private static bool _EXTRA_VIBRATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/provider/AlarmClock.html#VALUE_RINGTONE_SILENT"/>
        /// </summary>
        public static Java.Lang.String VALUE_RINGTONE_SILENT { get { if (!_VALUE_RINGTONE_SILENTReady) { _VALUE_RINGTONE_SILENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VALUE_RINGTONE_SILENT"); _VALUE_RINGTONE_SILENTReady = true; } return _VALUE_RINGTONE_SILENTContent; } }
        private static Java.Lang.String _VALUE_RINGTONE_SILENTContent = default;
        private static bool _VALUE_RINGTONE_SILENTReady = false; // this is used because in case of generics 

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