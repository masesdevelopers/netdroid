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

namespace Android.Os
{
    #region Vibrator
    public partial class Vibrator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#VIBRATION_EFFECT_SUPPORT_NO"/>
        /// </summary>
        public static int VIBRATION_EFFECT_SUPPORT_NO { get { if (!_VIBRATION_EFFECT_SUPPORT_NOReady) { _VIBRATION_EFFECT_SUPPORT_NOContent = SGetField<int>(LocalBridgeClazz, "VIBRATION_EFFECT_SUPPORT_NO"); _VIBRATION_EFFECT_SUPPORT_NOReady = true; } return _VIBRATION_EFFECT_SUPPORT_NOContent; } }
        private static int _VIBRATION_EFFECT_SUPPORT_NOContent = default;
        private static bool _VIBRATION_EFFECT_SUPPORT_NOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#VIBRATION_EFFECT_SUPPORT_UNKNOWN"/>
        /// </summary>
        public static int VIBRATION_EFFECT_SUPPORT_UNKNOWN { get { if (!_VIBRATION_EFFECT_SUPPORT_UNKNOWNReady) { _VIBRATION_EFFECT_SUPPORT_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "VIBRATION_EFFECT_SUPPORT_UNKNOWN"); _VIBRATION_EFFECT_SUPPORT_UNKNOWNReady = true; } return _VIBRATION_EFFECT_SUPPORT_UNKNOWNContent; } }
        private static int _VIBRATION_EFFECT_SUPPORT_UNKNOWNContent = default;
        private static bool _VIBRATION_EFFECT_SUPPORT_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#VIBRATION_EFFECT_SUPPORT_YES"/>
        /// </summary>
        public static int VIBRATION_EFFECT_SUPPORT_YES { get { if (!_VIBRATION_EFFECT_SUPPORT_YESReady) { _VIBRATION_EFFECT_SUPPORT_YESContent = SGetField<int>(LocalBridgeClazz, "VIBRATION_EFFECT_SUPPORT_YES"); _VIBRATION_EFFECT_SUPPORT_YESReady = true; } return _VIBRATION_EFFECT_SUPPORT_YESContent; } }
        private static int _VIBRATION_EFFECT_SUPPORT_YESContent = default;
        private static bool _VIBRATION_EFFECT_SUPPORT_YESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#hasAmplitudeControl()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAmplitudeControl()
        {
            return IExecuteWithSignature<bool>("hasAmplitudeControl", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#hasVibrator()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasVibrator()
        {
            return IExecuteWithSignature<bool>("hasVibrator", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#arePrimitivesSupported(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool[] ArePrimitivesSupported(params int[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignatureArray<bool>("arePrimitivesSupported", "([I)[Z"); else return IExecuteWithSignatureArray<bool>("arePrimitivesSupported", "([I)[Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#areAllPrimitivesSupported(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AreAllPrimitivesSupported(params int[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<bool>("areAllPrimitivesSupported", "([I)Z"); else return IExecuteWithSignature<bool>("areAllPrimitivesSupported", "([I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#areAllEffectsSupported(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int AreAllEffectsSupported(params int[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<int>("areAllEffectsSupported", "([I)I"); else return IExecuteWithSignature<int>("areAllEffectsSupported", "([I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#getQFactor()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetQFactor()
        {
            return IExecuteWithSignature<float>("getQFactor", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#getResonantFrequency()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetResonantFrequency()
        {
            return IExecuteWithSignature<float>("getResonantFrequency", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#areEffectsSupported(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] AreEffectsSupported(params int[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignatureArray<int>("areEffectsSupported", "([I)[I"); else return IExecuteWithSignatureArray<int>("areEffectsSupported", "([I)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#getPrimitiveDurations(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetPrimitiveDurations(params int[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignatureArray<int>("getPrimitiveDurations", "([I)[I"); else return IExecuteWithSignatureArray<int>("getPrimitiveDurations", "([I)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#vibrate(android.os.VibrationEffect,android.media.AudioAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.VibrationEffect"/></param>
        /// <param name="arg1"><see cref="Android.Media.AudioAttributes"/></param>
        [global::System.Obsolete()]
        public void Vibrate(Android.Os.VibrationEffect arg0, Android.Media.AudioAttributes arg1)
        {
            IExecute("vibrate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#vibrate(android.os.VibrationEffect,android.os.VibrationAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.VibrationEffect"/></param>
        /// <param name="arg1"><see cref="Android.Os.VibrationAttributes"/></param>
        public void Vibrate(Android.Os.VibrationEffect arg0, Android.Os.VibrationAttributes arg1)
        {
            IExecute("vibrate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#vibrate(android.os.VibrationEffect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.VibrationEffect"/></param>
        public void Vibrate(Android.Os.VibrationEffect arg0)
        {
            IExecuteWithSignature("vibrate", "(Landroid/os/VibrationEffect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#vibrate(long,android.media.AudioAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Android.Media.AudioAttributes"/></param>
        [global::System.Obsolete()]
        public void Vibrate(long arg0, Android.Media.AudioAttributes arg1)
        {
            IExecute("vibrate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#vibrate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void Vibrate(long arg0)
        {
            IExecuteWithSignature("vibrate", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#vibrate(long[],int,android.media.AudioAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Media.AudioAttributes"/></param>
        [global::System.Obsolete()]
        public void Vibrate(long[] arg0, int arg1, Android.Media.AudioAttributes arg2)
        {
            IExecute("vibrate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Vibrator.html#vibrate(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void Vibrate(long[] arg0, int arg1)
        {
            IExecute("vibrate", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}