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

namespace Android.Nfc
{
    #region NfcAntennaInfo
    public partial class NfcAntennaInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#%3Cinit%3E(int,int,boolean,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        public NfcAntennaInfo(int arg0, int arg1, bool arg2, Java.Util.List<Android.Nfc.AvailableNfcAntenna> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#isDeviceFoldable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeviceFoldable()
        {
            return IExecuteWithSignature<bool>("isDeviceFoldable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#getDeviceHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceHeight()
        {
            return IExecuteWithSignature<int>("getDeviceHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#getDeviceWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceWidth()
        {
            return IExecuteWithSignature<int>("getDeviceWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#getAvailableNfcAntennas()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Nfc.AvailableNfcAntenna> GetAvailableNfcAntennas()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Nfc.AvailableNfcAntenna>>("getAvailableNfcAntennas", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/NfcAntennaInfo.html#writeToParcel(android.os.Parcel,int)"/>
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