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
    #region BlackLevelPattern
    public partial class BlackLevelPattern
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/BlackLevelPattern.html#%3Cinit%3E(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BlackLevelPattern(int[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/BlackLevelPattern.html#COUNT"/>
        /// </summary>
        public static int COUNT { get { if (!_COUNTReady) { _COUNTContent = SGetField<int>(LocalBridgeClazz, "COUNT"); _COUNTReady = true; } return _COUNTContent; } }
        private static int _COUNTContent = default;
        private static bool _COUNTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/BlackLevelPattern.html#getOffsetForIndex(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetOffsetForIndex(int arg0, int arg1)
        {
            return IExecute<int>("getOffsetForIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/BlackLevelPattern.html#copyTo(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void CopyTo(int[] arg0, int arg1)
        {
            IExecute("copyTo", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}