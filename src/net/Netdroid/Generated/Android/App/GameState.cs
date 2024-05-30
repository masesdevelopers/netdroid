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

namespace Android.App
{
    #region GameState
    public partial class GameState
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#%3Cinit%3E(boolean,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public GameState(bool arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#%3Cinit%3E(boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public GameState(bool arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#MODE_CONTENT"/>
        /// </summary>
        public static int MODE_CONTENT { get { if (!_MODE_CONTENTReady) { _MODE_CONTENTContent = SGetField<int>(LocalBridgeClazz, "MODE_CONTENT"); _MODE_CONTENTReady = true; } return _MODE_CONTENTContent; } }
        private static int _MODE_CONTENTContent = default;
        private static bool _MODE_CONTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#MODE_GAMEPLAY_INTERRUPTIBLE"/>
        /// </summary>
        public static int MODE_GAMEPLAY_INTERRUPTIBLE { get { if (!_MODE_GAMEPLAY_INTERRUPTIBLEReady) { _MODE_GAMEPLAY_INTERRUPTIBLEContent = SGetField<int>(LocalBridgeClazz, "MODE_GAMEPLAY_INTERRUPTIBLE"); _MODE_GAMEPLAY_INTERRUPTIBLEReady = true; } return _MODE_GAMEPLAY_INTERRUPTIBLEContent; } }
        private static int _MODE_GAMEPLAY_INTERRUPTIBLEContent = default;
        private static bool _MODE_GAMEPLAY_INTERRUPTIBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#MODE_GAMEPLAY_UNINTERRUPTIBLE"/>
        /// </summary>
        public static int MODE_GAMEPLAY_UNINTERRUPTIBLE { get { if (!_MODE_GAMEPLAY_UNINTERRUPTIBLEReady) { _MODE_GAMEPLAY_UNINTERRUPTIBLEContent = SGetField<int>(LocalBridgeClazz, "MODE_GAMEPLAY_UNINTERRUPTIBLE"); _MODE_GAMEPLAY_UNINTERRUPTIBLEReady = true; } return _MODE_GAMEPLAY_UNINTERRUPTIBLEContent; } }
        private static int _MODE_GAMEPLAY_UNINTERRUPTIBLEContent = default;
        private static bool _MODE_GAMEPLAY_UNINTERRUPTIBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#MODE_NONE"/>
        /// </summary>
        public static int MODE_NONE { get { if (!_MODE_NONEReady) { _MODE_NONEContent = SGetField<int>(LocalBridgeClazz, "MODE_NONE"); _MODE_NONEReady = true; } return _MODE_NONEContent; } }
        private static int _MODE_NONEContent = default;
        private static bool _MODE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#MODE_UNKNOWN"/>
        /// </summary>
        public static int MODE_UNKNOWN { get { if (!_MODE_UNKNOWNReady) { _MODE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "MODE_UNKNOWN"); _MODE_UNKNOWNReady = true; } return _MODE_UNKNOWNContent; } }
        private static int _MODE_UNKNOWNContent = default;
        private static bool _MODE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#getLabel()"/> 
        /// </summary>
        public int Label
        {
            get { return IExecuteWithSignature<int>("getLabel", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#getMode()"/> 
        /// </summary>
        public int Mode
        {
            get { return IExecuteWithSignature<int>("getMode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#getQuality()"/> 
        /// </summary>
        public int Quality
        {
            get { return IExecuteWithSignature<int>("getQuality", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#isLoading()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLoading()
        {
            return IExecuteWithSignature<bool>("isLoading", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/GameState.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}