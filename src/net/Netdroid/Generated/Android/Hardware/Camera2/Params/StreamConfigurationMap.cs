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

namespace Android.Hardware.Camera2.Params
{
    #region StreamConfigurationMap
    public partial class StreamConfigurationMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#isOutputSupportedFor(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsOutputSupportedFor(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isOutputSupportedFor", "(Ljava/lang/Class;)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getHighSpeedVideoFpsRanges()"/> 
        /// </summary>
        public Android.Util.Range<Java.Lang.Integer>[] HighSpeedVideoFpsRanges
        {
            get { return IExecuteWithSignatureArray<Android.Util.Range<Java.Lang.Integer>>("getHighSpeedVideoFpsRanges", "()[Landroid/util/Range;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getHighSpeedVideoSizes()"/> 
        /// </summary>
        public Android.Util.Size[] HighSpeedVideoSizes
        {
            get { return IExecuteWithSignatureArray<Android.Util.Size>("getHighSpeedVideoSizes", "()[Landroid/util/Size;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getInputFormats()"/> 
        /// </summary>
        public int[] InputFormats
        {
            get { return IExecuteWithSignatureArray<int>("getInputFormats", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputFormats()"/> 
        /// </summary>
        public int[] OutputFormats
        {
            get { return IExecuteWithSignatureArray<int>("getOutputFormats", "()[I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputSizes(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetOutputSizes(Java.Lang.Class arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getOutputSizes", "(Ljava/lang/Class;)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputMinFrameDuration(java.lang.Class,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputMinFrameDuration(Java.Lang.Class arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputMinFrameDuration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputStallDuration(java.lang.Class,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputStallDuration(Java.Lang.Class arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputStallDuration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getHighSpeedVideoFpsRangesFor(android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="Android.Util.Range"/></returns>
        public Android.Util.Range<Java.Lang.Integer>[] GetHighSpeedVideoFpsRangesFor(Android.Util.Size arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Range<Java.Lang.Integer>>("getHighSpeedVideoFpsRangesFor", "(Landroid/util/Size;)[Landroid/util/Range;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getHighResolutionOutputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetHighResolutionOutputSizes(int arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getHighResolutionOutputSizes", "(I)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getHighSpeedVideoSizesFor(android.util.Range)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Range"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetHighSpeedVideoSizesFor(Android.Util.Range<Java.Lang.Integer> arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getHighSpeedVideoSizesFor", "(Landroid/util/Range;)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getInputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetInputSizes(int arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getInputSizes", "(I)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetOutputSizes(int arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getOutputSizes", "(I)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#isOutputSupportedFor(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputSupportedFor(Android.View.Surface arg0)
        {
            return IExecuteWithSignature<bool>("isOutputSupportedFor", "(Landroid/view/Surface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#isOutputSupportedFor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputSupportedFor(int arg0)
        {
            return IExecuteWithSignature<bool>("isOutputSupportedFor", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getValidOutputFormatsForInput(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetValidOutputFormatsForInput(int arg0)
        {
            return IExecuteWithSignatureArray<int>("getValidOutputFormatsForInput", "(I)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputMinFrameDuration(int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputMinFrameDuration(int arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputMinFrameDuration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputStallDuration(int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputStallDuration(int arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputStallDuration", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}