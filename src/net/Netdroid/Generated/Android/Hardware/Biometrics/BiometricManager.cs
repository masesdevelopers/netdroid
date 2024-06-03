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

namespace Android.Hardware.Biometrics
{
    #region BiometricManager
    public partial class BiometricManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#BIOMETRIC_ERROR_HW_UNAVAILABLE"/>
        /// </summary>
        public static int BIOMETRIC_ERROR_HW_UNAVAILABLE { get { if (!_BIOMETRIC_ERROR_HW_UNAVAILABLEReady) { _BIOMETRIC_ERROR_HW_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "BIOMETRIC_ERROR_HW_UNAVAILABLE"); _BIOMETRIC_ERROR_HW_UNAVAILABLEReady = true; } return _BIOMETRIC_ERROR_HW_UNAVAILABLEContent; } }
        private static int _BIOMETRIC_ERROR_HW_UNAVAILABLEContent = default;
        private static bool _BIOMETRIC_ERROR_HW_UNAVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#BIOMETRIC_ERROR_NO_HARDWARE"/>
        /// </summary>
        public static int BIOMETRIC_ERROR_NO_HARDWARE { get { if (!_BIOMETRIC_ERROR_NO_HARDWAREReady) { _BIOMETRIC_ERROR_NO_HARDWAREContent = SGetField<int>(LocalBridgeClazz, "BIOMETRIC_ERROR_NO_HARDWARE"); _BIOMETRIC_ERROR_NO_HARDWAREReady = true; } return _BIOMETRIC_ERROR_NO_HARDWAREContent; } }
        private static int _BIOMETRIC_ERROR_NO_HARDWAREContent = default;
        private static bool _BIOMETRIC_ERROR_NO_HARDWAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#BIOMETRIC_ERROR_NONE_ENROLLED"/>
        /// </summary>
        public static int BIOMETRIC_ERROR_NONE_ENROLLED { get { if (!_BIOMETRIC_ERROR_NONE_ENROLLEDReady) { _BIOMETRIC_ERROR_NONE_ENROLLEDContent = SGetField<int>(LocalBridgeClazz, "BIOMETRIC_ERROR_NONE_ENROLLED"); _BIOMETRIC_ERROR_NONE_ENROLLEDReady = true; } return _BIOMETRIC_ERROR_NONE_ENROLLEDContent; } }
        private static int _BIOMETRIC_ERROR_NONE_ENROLLEDContent = default;
        private static bool _BIOMETRIC_ERROR_NONE_ENROLLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIRED"/>
        /// </summary>
        public static int BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIRED { get { if (!_BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIREDReady) { _BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIREDContent = SGetField<int>(LocalBridgeClazz, "BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIRED"); _BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIREDReady = true; } return _BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIREDContent; } }
        private static int _BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIREDContent = default;
        private static bool _BIOMETRIC_ERROR_SECURITY_UPDATE_REQUIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#BIOMETRIC_SUCCESS"/>
        /// </summary>
        public static int BIOMETRIC_SUCCESS { get { if (!_BIOMETRIC_SUCCESSReady) { _BIOMETRIC_SUCCESSContent = SGetField<int>(LocalBridgeClazz, "BIOMETRIC_SUCCESS"); _BIOMETRIC_SUCCESSReady = true; } return _BIOMETRIC_SUCCESSContent; } }
        private static int _BIOMETRIC_SUCCESSContent = default;
        private static bool _BIOMETRIC_SUCCESSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#getStrings(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Hardware.Biometrics.BiometricManager.Strings"/></returns>
        public Android.Hardware.Biometrics.BiometricManager.Strings GetStrings(int arg0)
        {
            return IExecuteWithSignature<Android.Hardware.Biometrics.BiometricManager.Strings>("getStrings", "(I)Landroid/hardware/biometrics/BiometricManager$Strings;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#canAuthenticate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int CanAuthenticate()
        {
            return IExecuteWithSignature<int>("canAuthenticate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.html#canAuthenticate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CanAuthenticate(int arg0)
        {
            return IExecuteWithSignature<int>("canAuthenticate", "(I)I", arg0);
        }

        #endregion

        #region Nested classes
        #region Authenticators
        public partial class Authenticators
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.Authenticators.html#BIOMETRIC_STRONG"/>
            /// </summary>
            public static int BIOMETRIC_STRONG { get { if (!_BIOMETRIC_STRONGReady) { _BIOMETRIC_STRONGContent = SGetField<int>(LocalBridgeClazz, "BIOMETRIC_STRONG"); _BIOMETRIC_STRONGReady = true; } return _BIOMETRIC_STRONGContent; } }
            private static int _BIOMETRIC_STRONGContent = default;
            private static bool _BIOMETRIC_STRONGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.Authenticators.html#BIOMETRIC_WEAK"/>
            /// </summary>
            public static int BIOMETRIC_WEAK { get { if (!_BIOMETRIC_WEAKReady) { _BIOMETRIC_WEAKContent = SGetField<int>(LocalBridgeClazz, "BIOMETRIC_WEAK"); _BIOMETRIC_WEAKReady = true; } return _BIOMETRIC_WEAKContent; } }
            private static int _BIOMETRIC_WEAKContent = default;
            private static bool _BIOMETRIC_WEAKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.Authenticators.html#DEVICE_CREDENTIAL"/>
            /// </summary>
            public static int DEVICE_CREDENTIAL { get { if (!_DEVICE_CREDENTIALReady) { _DEVICE_CREDENTIALContent = SGetField<int>(LocalBridgeClazz, "DEVICE_CREDENTIAL"); _DEVICE_CREDENTIALReady = true; } return _DEVICE_CREDENTIALContent; } }
            private static int _DEVICE_CREDENTIALContent = default;
            private static bool _DEVICE_CREDENTIALReady = false; // this is used because in case of generics 

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

        #region Strings
        public partial class Strings
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
            /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.Strings.html#getButtonLabel()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetButtonLabel()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getButtonLabel", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.Strings.html#getPromptMessage()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetPromptMessage()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getPromptMessage", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/biometrics/BiometricManager.Strings.html#getSettingName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetSettingName()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getSettingName", "()Ljava/lang/CharSequence;");
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