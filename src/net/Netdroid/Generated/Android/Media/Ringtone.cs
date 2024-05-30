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

namespace Android.Media
{
    #region Ringtone
    public partial class Ringtone
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
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#getAudioAttributes()"/> <see href="https://developer.android.com/reference/android/media/Ringtone.html#setAudioAttributes(android.media.AudioAttributes)"/>
        /// </summary>
        public Android.Media.AudioAttributes AudioAttributes
        {
            get { return IExecuteWithSignature<Android.Media.AudioAttributes>("getAudioAttributes", "()Landroid/media/AudioAttributes;"); } set { IExecuteWithSignature("setAudioAttributes", "(Landroid/media/AudioAttributes;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#getVolume()"/> <see href="https://developer.android.com/reference/android/media/Ringtone.html#setVolume(float)"/>
        /// </summary>
        public float Volume
        {
            get { return IExecuteWithSignature<float>("getVolume", "()F"); } set { IExecuteWithSignature("setVolume", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#isHapticGeneratorEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHapticGeneratorEnabled()
        {
            return IExecuteWithSignature<bool>("isHapticGeneratorEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#isLooping()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLooping()
        {
            return IExecuteWithSignature<bool>("isLooping", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#isPlaying()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPlaying()
        {
            return IExecuteWithSignature<bool>("isPlaying", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#setHapticGeneratorEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetHapticGeneratorEnabled(bool arg0)
        {
            return IExecuteWithSignature<bool>("setHapticGeneratorEnabled", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#getTitle(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTitle(Android.Content.Context arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getTitle", "(Landroid/content/Context;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#play()"/>
        /// </summary>
        public void Play()
        {
            IExecuteWithSignature("play", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#setLooping(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLooping(bool arg0)
        {
            IExecuteWithSignature("setLooping", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/Ringtone.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}