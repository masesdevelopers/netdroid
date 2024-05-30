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

namespace Android.Os
{
    #region CombinedVibration
    public partial class CombinedVibration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CombinedVibration.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CombinedVibration.html#createParallel(android.os.VibrationEffect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.VibrationEffect"/></param>
        /// <returns><see cref="Android.Os.CombinedVibration"/></returns>
        public static Android.Os.CombinedVibration CreateParallel(Android.Os.VibrationEffect arg0)
        {
            return SExecuteWithSignature<Android.Os.CombinedVibration>(LocalBridgeClazz, "createParallel", "(Landroid/os/VibrationEffect;)Landroid/os/CombinedVibration;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CombinedVibration.html#startParallel()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.CombinedVibration.ParallelCombination"/></returns>
        public static Android.Os.CombinedVibration.ParallelCombination StartParallel()
        {
            return SExecuteWithSignature<Android.Os.CombinedVibration.ParallelCombination>(LocalBridgeClazz, "startParallel", "()Landroid/os/CombinedVibration$ParallelCombination;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CombinedVibration.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }

        #endregion

        #region Nested classes
        #region ParallelCombination
        public partial class ParallelCombination
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
            /// <see href="https://developer.android.com/reference/android/os/CombinedVibration.ParallelCombination.html#combine()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.CombinedVibration"/></returns>
            public Android.Os.CombinedVibration Combine()
            {
                return IExecuteWithSignature<Android.Os.CombinedVibration>("combine", "()Landroid/os/CombinedVibration;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/CombinedVibration.ParallelCombination.html#addVibrator(int,android.os.VibrationEffect)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.Os.VibrationEffect"/></param>
            /// <returns><see cref="Android.Os.CombinedVibration.ParallelCombination"/></returns>
            public Android.Os.CombinedVibration.ParallelCombination AddVibrator(int arg0, Android.Os.VibrationEffect arg1)
            {
                return IExecute<Android.Os.CombinedVibration.ParallelCombination>("addVibrator", arg0, arg1);
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