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
    #region VolumeProvider
    public partial class VolumeProvider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#%3Cinit%3E(int,int,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public VolumeProvider(int arg0, int arg1, int arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public VolumeProvider(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#VOLUME_CONTROL_ABSOLUTE"/>
        /// </summary>
        public static int VOLUME_CONTROL_ABSOLUTE { get { if (!_VOLUME_CONTROL_ABSOLUTEReady) { _VOLUME_CONTROL_ABSOLUTEContent = SGetField<int>(LocalBridgeClazz, "VOLUME_CONTROL_ABSOLUTE"); _VOLUME_CONTROL_ABSOLUTEReady = true; } return _VOLUME_CONTROL_ABSOLUTEContent; } }
        private static int _VOLUME_CONTROL_ABSOLUTEContent = default;
        private static bool _VOLUME_CONTROL_ABSOLUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#VOLUME_CONTROL_FIXED"/>
        /// </summary>
        public static int VOLUME_CONTROL_FIXED { get { if (!_VOLUME_CONTROL_FIXEDReady) { _VOLUME_CONTROL_FIXEDContent = SGetField<int>(LocalBridgeClazz, "VOLUME_CONTROL_FIXED"); _VOLUME_CONTROL_FIXEDReady = true; } return _VOLUME_CONTROL_FIXEDContent; } }
        private static int _VOLUME_CONTROL_FIXEDContent = default;
        private static bool _VOLUME_CONTROL_FIXEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#VOLUME_CONTROL_RELATIVE"/>
        /// </summary>
        public static int VOLUME_CONTROL_RELATIVE { get { if (!_VOLUME_CONTROL_RELATIVEReady) { _VOLUME_CONTROL_RELATIVEContent = SGetField<int>(LocalBridgeClazz, "VOLUME_CONTROL_RELATIVE"); _VOLUME_CONTROL_RELATIVEReady = true; } return _VOLUME_CONTROL_RELATIVEContent; } }
        private static int _VOLUME_CONTROL_RELATIVEContent = default;
        private static bool _VOLUME_CONTROL_RELATIVEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#getCurrentVolume()"/> <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#setCurrentVolume(int)"/>
        /// </summary>
        public int CurrentVolume
        {
            get { return IExecuteWithSignature<int>("getCurrentVolume", "()I"); } set { IExecuteWithSignature("setCurrentVolume", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#getMaxVolume()"/> 
        /// </summary>
        public int MaxVolume
        {
            get { return IExecuteWithSignature<int>("getMaxVolume", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#getVolumeControl()"/> 
        /// </summary>
        public int VolumeControl
        {
            get { return IExecuteWithSignature<int>("getVolumeControl", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#getVolumeControlId()"/> 
        /// </summary>
        public Java.Lang.String VolumeControlId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVolumeControlId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#onAdjustVolume(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnAdjustVolume(int arg0)
        {
            IExecuteWithSignature("onAdjustVolume", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/VolumeProvider.html#onSetVolumeTo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnSetVolumeTo(int arg0)
        {
            IExecuteWithSignature("onSetVolumeTo", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}