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

namespace Android.Hardware
{
    #region BatteryState
    public partial class BatteryState
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_CHARGING"/>
        /// </summary>
        public static int STATUS_CHARGING { get { if (!_STATUS_CHARGINGReady) { _STATUS_CHARGINGContent = SGetField<int>(LocalBridgeClazz, "STATUS_CHARGING"); _STATUS_CHARGINGReady = true; } return _STATUS_CHARGINGContent; } }
        private static int _STATUS_CHARGINGContent = default;
        private static bool _STATUS_CHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_DISCHARGING"/>
        /// </summary>
        public static int STATUS_DISCHARGING { get { if (!_STATUS_DISCHARGINGReady) { _STATUS_DISCHARGINGContent = SGetField<int>(LocalBridgeClazz, "STATUS_DISCHARGING"); _STATUS_DISCHARGINGReady = true; } return _STATUS_DISCHARGINGContent; } }
        private static int _STATUS_DISCHARGINGContent = default;
        private static bool _STATUS_DISCHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_FULL"/>
        /// </summary>
        public static int STATUS_FULL { get { if (!_STATUS_FULLReady) { _STATUS_FULLContent = SGetField<int>(LocalBridgeClazz, "STATUS_FULL"); _STATUS_FULLReady = true; } return _STATUS_FULLContent; } }
        private static int _STATUS_FULLContent = default;
        private static bool _STATUS_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_NOT_CHARGING"/>
        /// </summary>
        public static int STATUS_NOT_CHARGING { get { if (!_STATUS_NOT_CHARGINGReady) { _STATUS_NOT_CHARGINGContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_CHARGING"); _STATUS_NOT_CHARGINGReady = true; } return _STATUS_NOT_CHARGINGContent; } }
        private static int _STATUS_NOT_CHARGINGContent = default;
        private static bool _STATUS_NOT_CHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_UNKNOWN"/>
        /// </summary>
        public static int STATUS_UNKNOWN { get { if (!_STATUS_UNKNOWNReady) { _STATUS_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNKNOWN"); _STATUS_UNKNOWNReady = true; } return _STATUS_UNKNOWNContent; } }
        private static int _STATUS_UNKNOWNContent = default;
        private static bool _STATUS_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#getCapacity()"/> 
        /// </summary>
        public float Capacity
        {
            get { return IExecuteWithSignature<float>("getCapacity", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#getStatus()"/> 
        /// </summary>
        public int Status
        {
            get { return IExecuteWithSignature<int>("getStatus", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#isPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecuteWithSignature<bool>("isPresent", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}