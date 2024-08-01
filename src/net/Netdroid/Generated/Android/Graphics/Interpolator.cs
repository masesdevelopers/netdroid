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

namespace Android.Graphics
{
    #region Interpolator
    public partial class Interpolator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public Interpolator(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Interpolator(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#timeToValues(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
        public Android.Graphics.Interpolator.Result TimeToValues(float[] arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Interpolator.Result>("timeToValues", "([F)Landroid/graphics/Interpolator$Result;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#timeToValues(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
        public Android.Graphics.Interpolator.Result TimeToValues(int arg0, float[] arg1)
        {
            return IExecute<Android.Graphics.Interpolator.Result>("timeToValues", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#getKeyFrameCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetKeyFrameCount()
        {
            return IExecuteWithSignature<int>("getKeyFrameCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#getValueCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetValueCount()
        {
            return IExecuteWithSignature<int>("getValueCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#reset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Reset(int arg0, int arg1)
        {
            IExecute("reset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#reset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Reset(int arg0)
        {
            IExecuteWithSignature("reset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#setKeyFrame(int,int,float[],float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3)
        {
            IExecute("setKeyFrame", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#setKeyFrame(int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetKeyFrame(int arg0, int arg1, float[] arg2)
        {
            IExecute("setKeyFrame", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#setRepeatMirror(float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetRepeatMirror(float arg0, bool arg1)
        {
            IExecute("setRepeatMirror", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Result
        public partial class Result
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#FREEZE_END"/>
            /// </summary>
            public static Android.Graphics.Interpolator.Result FREEZE_END { get { if (!_FREEZE_ENDReady) { _FREEZE_ENDContent = SGetField<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "FREEZE_END"); _FREEZE_ENDReady = true; } return _FREEZE_ENDContent; } }
            private static Android.Graphics.Interpolator.Result _FREEZE_ENDContent = default;
            private static bool _FREEZE_ENDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#FREEZE_START"/>
            /// </summary>
            public static Android.Graphics.Interpolator.Result FREEZE_START { get { if (!_FREEZE_STARTReady) { _FREEZE_STARTContent = SGetField<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "FREEZE_START"); _FREEZE_STARTReady = true; } return _FREEZE_STARTContent; } }
            private static Android.Graphics.Interpolator.Result _FREEZE_STARTContent = default;
            private static bool _FREEZE_STARTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#NORMAL"/>
            /// </summary>
            public static Android.Graphics.Interpolator.Result NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
            private static Android.Graphics.Interpolator.Result _NORMALContent = default;
            private static bool _NORMALReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
            public static Android.Graphics.Interpolator.Result ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
            public static Android.Graphics.Interpolator.Result[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "values", "()[Landroid/graphics/Interpolator$Result;");
            }

            #endregion

            #region Instance methods

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