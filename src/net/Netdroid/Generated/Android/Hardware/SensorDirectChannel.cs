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
    #region SensorDirectChannel
    public partial class SensorDirectChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#RATE_FAST"/>
        /// </summary>
        public static int RATE_FAST { get { if (!_RATE_FASTReady) { _RATE_FASTContent = SGetField<int>(LocalBridgeClazz, "RATE_FAST"); _RATE_FASTReady = true; } return _RATE_FASTContent; } }
        private static int _RATE_FASTContent = default;
        private static bool _RATE_FASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#RATE_NORMAL"/>
        /// </summary>
        public static int RATE_NORMAL { get { if (!_RATE_NORMALReady) { _RATE_NORMALContent = SGetField<int>(LocalBridgeClazz, "RATE_NORMAL"); _RATE_NORMALReady = true; } return _RATE_NORMALContent; } }
        private static int _RATE_NORMALContent = default;
        private static bool _RATE_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#RATE_STOP"/>
        /// </summary>
        public static int RATE_STOP { get { if (!_RATE_STOPReady) { _RATE_STOPContent = SGetField<int>(LocalBridgeClazz, "RATE_STOP"); _RATE_STOPReady = true; } return _RATE_STOPContent; } }
        private static int _RATE_STOPContent = default;
        private static bool _RATE_STOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#RATE_VERY_FAST"/>
        /// </summary>
        public static int RATE_VERY_FAST { get { if (!_RATE_VERY_FASTReady) { _RATE_VERY_FASTContent = SGetField<int>(LocalBridgeClazz, "RATE_VERY_FAST"); _RATE_VERY_FASTReady = true; } return _RATE_VERY_FASTContent; } }
        private static int _RATE_VERY_FASTContent = default;
        private static bool _RATE_VERY_FASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#TYPE_HARDWARE_BUFFER"/>
        /// </summary>
        public static int TYPE_HARDWARE_BUFFER { get { if (!_TYPE_HARDWARE_BUFFERReady) { _TYPE_HARDWARE_BUFFERContent = SGetField<int>(LocalBridgeClazz, "TYPE_HARDWARE_BUFFER"); _TYPE_HARDWARE_BUFFERReady = true; } return _TYPE_HARDWARE_BUFFERContent; } }
        private static int _TYPE_HARDWARE_BUFFERContent = default;
        private static bool _TYPE_HARDWARE_BUFFERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#TYPE_MEMORY_FILE"/>
        /// </summary>
        public static int TYPE_MEMORY_FILE { get { if (!_TYPE_MEMORY_FILEReady) { _TYPE_MEMORY_FILEContent = SGetField<int>(LocalBridgeClazz, "TYPE_MEMORY_FILE"); _TYPE_MEMORY_FILEReady = true; } return _TYPE_MEMORY_FILEContent; } }
        private static int _TYPE_MEMORY_FILEContent = default;
        private static bool _TYPE_MEMORY_FILEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#isOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#configure(android.hardware.Sensor,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Sensor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Configure(Android.Hardware.Sensor arg0, int arg1)
        {
            return IExecute<int>("configure", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorDirectChannel.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}