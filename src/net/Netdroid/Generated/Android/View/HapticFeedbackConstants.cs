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

namespace Android.View
{
    #region HapticFeedbackConstants
    public partial class HapticFeedbackConstants
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#CLOCK_TICK"/>
        /// </summary>
        public static int CLOCK_TICK { get { if (!_CLOCK_TICKReady) { _CLOCK_TICKContent = SGetField<int>(LocalBridgeClazz, "CLOCK_TICK"); _CLOCK_TICKReady = true; } return _CLOCK_TICKContent; } }
        private static int _CLOCK_TICKContent = default;
        private static bool _CLOCK_TICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#CONFIRM"/>
        /// </summary>
        public static int CONFIRM { get { if (!_CONFIRMReady) { _CONFIRMContent = SGetField<int>(LocalBridgeClazz, "CONFIRM"); _CONFIRMReady = true; } return _CONFIRMContent; } }
        private static int _CONFIRMContent = default;
        private static bool _CONFIRMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#CONTEXT_CLICK"/>
        /// </summary>
        public static int CONTEXT_CLICK { get { if (!_CONTEXT_CLICKReady) { _CONTEXT_CLICKContent = SGetField<int>(LocalBridgeClazz, "CONTEXT_CLICK"); _CONTEXT_CLICKReady = true; } return _CONTEXT_CLICKContent; } }
        private static int _CONTEXT_CLICKContent = default;
        private static bool _CONTEXT_CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#DRAG_START"/>
        /// </summary>
        public static int DRAG_START { get { if (!_DRAG_STARTReady) { _DRAG_STARTContent = SGetField<int>(LocalBridgeClazz, "DRAG_START"); _DRAG_STARTReady = true; } return _DRAG_STARTContent; } }
        private static int _DRAG_STARTContent = default;
        private static bool _DRAG_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#FLAG_IGNORE_GLOBAL_SETTING"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int FLAG_IGNORE_GLOBAL_SETTING { get { if (!_FLAG_IGNORE_GLOBAL_SETTINGReady) { _FLAG_IGNORE_GLOBAL_SETTINGContent = SGetField<int>(LocalBridgeClazz, "FLAG_IGNORE_GLOBAL_SETTING"); _FLAG_IGNORE_GLOBAL_SETTINGReady = true; } return _FLAG_IGNORE_GLOBAL_SETTINGContent; } }
        private static int _FLAG_IGNORE_GLOBAL_SETTINGContent = default;
        private static bool _FLAG_IGNORE_GLOBAL_SETTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#FLAG_IGNORE_VIEW_SETTING"/>
        /// </summary>
        public static int FLAG_IGNORE_VIEW_SETTING { get { if (!_FLAG_IGNORE_VIEW_SETTINGReady) { _FLAG_IGNORE_VIEW_SETTINGContent = SGetField<int>(LocalBridgeClazz, "FLAG_IGNORE_VIEW_SETTING"); _FLAG_IGNORE_VIEW_SETTINGReady = true; } return _FLAG_IGNORE_VIEW_SETTINGContent; } }
        private static int _FLAG_IGNORE_VIEW_SETTINGContent = default;
        private static bool _FLAG_IGNORE_VIEW_SETTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#GESTURE_END"/>
        /// </summary>
        public static int GESTURE_END { get { if (!_GESTURE_ENDReady) { _GESTURE_ENDContent = SGetField<int>(LocalBridgeClazz, "GESTURE_END"); _GESTURE_ENDReady = true; } return _GESTURE_ENDContent; } }
        private static int _GESTURE_ENDContent = default;
        private static bool _GESTURE_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#GESTURE_START"/>
        /// </summary>
        public static int GESTURE_START { get { if (!_GESTURE_STARTReady) { _GESTURE_STARTContent = SGetField<int>(LocalBridgeClazz, "GESTURE_START"); _GESTURE_STARTReady = true; } return _GESTURE_STARTContent; } }
        private static int _GESTURE_STARTContent = default;
        private static bool _GESTURE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#GESTURE_THRESHOLD_ACTIVATE"/>
        /// </summary>
        public static int GESTURE_THRESHOLD_ACTIVATE { get { if (!_GESTURE_THRESHOLD_ACTIVATEReady) { _GESTURE_THRESHOLD_ACTIVATEContent = SGetField<int>(LocalBridgeClazz, "GESTURE_THRESHOLD_ACTIVATE"); _GESTURE_THRESHOLD_ACTIVATEReady = true; } return _GESTURE_THRESHOLD_ACTIVATEContent; } }
        private static int _GESTURE_THRESHOLD_ACTIVATEContent = default;
        private static bool _GESTURE_THRESHOLD_ACTIVATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#GESTURE_THRESHOLD_DEACTIVATE"/>
        /// </summary>
        public static int GESTURE_THRESHOLD_DEACTIVATE { get { if (!_GESTURE_THRESHOLD_DEACTIVATEReady) { _GESTURE_THRESHOLD_DEACTIVATEContent = SGetField<int>(LocalBridgeClazz, "GESTURE_THRESHOLD_DEACTIVATE"); _GESTURE_THRESHOLD_DEACTIVATEReady = true; } return _GESTURE_THRESHOLD_DEACTIVATEContent; } }
        private static int _GESTURE_THRESHOLD_DEACTIVATEContent = default;
        private static bool _GESTURE_THRESHOLD_DEACTIVATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#KEYBOARD_PRESS"/>
        /// </summary>
        public static int KEYBOARD_PRESS { get { if (!_KEYBOARD_PRESSReady) { _KEYBOARD_PRESSContent = SGetField<int>(LocalBridgeClazz, "KEYBOARD_PRESS"); _KEYBOARD_PRESSReady = true; } return _KEYBOARD_PRESSContent; } }
        private static int _KEYBOARD_PRESSContent = default;
        private static bool _KEYBOARD_PRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#KEYBOARD_RELEASE"/>
        /// </summary>
        public static int KEYBOARD_RELEASE { get { if (!_KEYBOARD_RELEASEReady) { _KEYBOARD_RELEASEContent = SGetField<int>(LocalBridgeClazz, "KEYBOARD_RELEASE"); _KEYBOARD_RELEASEReady = true; } return _KEYBOARD_RELEASEContent; } }
        private static int _KEYBOARD_RELEASEContent = default;
        private static bool _KEYBOARD_RELEASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#KEYBOARD_TAP"/>
        /// </summary>
        public static int KEYBOARD_TAP { get { if (!_KEYBOARD_TAPReady) { _KEYBOARD_TAPContent = SGetField<int>(LocalBridgeClazz, "KEYBOARD_TAP"); _KEYBOARD_TAPReady = true; } return _KEYBOARD_TAPContent; } }
        private static int _KEYBOARD_TAPContent = default;
        private static bool _KEYBOARD_TAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#LONG_PRESS"/>
        /// </summary>
        public static int LONG_PRESS { get { if (!_LONG_PRESSReady) { _LONG_PRESSContent = SGetField<int>(LocalBridgeClazz, "LONG_PRESS"); _LONG_PRESSReady = true; } return _LONG_PRESSContent; } }
        private static int _LONG_PRESSContent = default;
        private static bool _LONG_PRESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#NO_HAPTICS"/>
        /// </summary>
        public static int NO_HAPTICS { get { if (!_NO_HAPTICSReady) { _NO_HAPTICSContent = SGetField<int>(LocalBridgeClazz, "NO_HAPTICS"); _NO_HAPTICSReady = true; } return _NO_HAPTICSContent; } }
        private static int _NO_HAPTICSContent = default;
        private static bool _NO_HAPTICSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#REJECT"/>
        /// </summary>
        public static int REJECT { get { if (!_REJECTReady) { _REJECTContent = SGetField<int>(LocalBridgeClazz, "REJECT"); _REJECTReady = true; } return _REJECTContent; } }
        private static int _REJECTContent = default;
        private static bool _REJECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#SEGMENT_FREQUENT_TICK"/>
        /// </summary>
        public static int SEGMENT_FREQUENT_TICK { get { if (!_SEGMENT_FREQUENT_TICKReady) { _SEGMENT_FREQUENT_TICKContent = SGetField<int>(LocalBridgeClazz, "SEGMENT_FREQUENT_TICK"); _SEGMENT_FREQUENT_TICKReady = true; } return _SEGMENT_FREQUENT_TICKContent; } }
        private static int _SEGMENT_FREQUENT_TICKContent = default;
        private static bool _SEGMENT_FREQUENT_TICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#SEGMENT_TICK"/>
        /// </summary>
        public static int SEGMENT_TICK { get { if (!_SEGMENT_TICKReady) { _SEGMENT_TICKContent = SGetField<int>(LocalBridgeClazz, "SEGMENT_TICK"); _SEGMENT_TICKReady = true; } return _SEGMENT_TICKContent; } }
        private static int _SEGMENT_TICKContent = default;
        private static bool _SEGMENT_TICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#TEXT_HANDLE_MOVE"/>
        /// </summary>
        public static int TEXT_HANDLE_MOVE { get { if (!_TEXT_HANDLE_MOVEReady) { _TEXT_HANDLE_MOVEContent = SGetField<int>(LocalBridgeClazz, "TEXT_HANDLE_MOVE"); _TEXT_HANDLE_MOVEReady = true; } return _TEXT_HANDLE_MOVEContent; } }
        private static int _TEXT_HANDLE_MOVEContent = default;
        private static bool _TEXT_HANDLE_MOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#TOGGLE_OFF"/>
        /// </summary>
        public static int TOGGLE_OFF { get { if (!_TOGGLE_OFFReady) { _TOGGLE_OFFContent = SGetField<int>(LocalBridgeClazz, "TOGGLE_OFF"); _TOGGLE_OFFReady = true; } return _TOGGLE_OFFContent; } }
        private static int _TOGGLE_OFFContent = default;
        private static bool _TOGGLE_OFFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#TOGGLE_ON"/>
        /// </summary>
        public static int TOGGLE_ON { get { if (!_TOGGLE_ONReady) { _TOGGLE_ONContent = SGetField<int>(LocalBridgeClazz, "TOGGLE_ON"); _TOGGLE_ONReady = true; } return _TOGGLE_ONContent; } }
        private static int _TOGGLE_ONContent = default;
        private static bool _TOGGLE_ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#VIRTUAL_KEY"/>
        /// </summary>
        public static int VIRTUAL_KEY { get { if (!_VIRTUAL_KEYReady) { _VIRTUAL_KEYContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_KEY"); _VIRTUAL_KEYReady = true; } return _VIRTUAL_KEYContent; } }
        private static int _VIRTUAL_KEYContent = default;
        private static bool _VIRTUAL_KEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/HapticFeedbackConstants.html#VIRTUAL_KEY_RELEASE"/>
        /// </summary>
        public static int VIRTUAL_KEY_RELEASE { get { if (!_VIRTUAL_KEY_RELEASEReady) { _VIRTUAL_KEY_RELEASEContent = SGetField<int>(LocalBridgeClazz, "VIRTUAL_KEY_RELEASE"); _VIRTUAL_KEY_RELEASEReady = true; } return _VIRTUAL_KEY_RELEASEContent; } }
        private static int _VIRTUAL_KEY_RELEASEContent = default;
        private static bool _VIRTUAL_KEY_RELEASEReady = false; // this is used because in case of generics 

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