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

namespace Android.Bluetooth.Le
{
    #region AdvertiseData
    public partial class AdvertiseData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#getManufacturerSpecificData()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<byte[]> GetManufacturerSpecificData()
        {
            return IExecuteWithSignature<Android.Util.SparseArray<byte[]>>("getManufacturerSpecificData", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#getIncludeDeviceName()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetIncludeDeviceName()
        {
            return IExecuteWithSignature<bool>("getIncludeDeviceName", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#getIncludeTxPowerLevel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetIncludeTxPowerLevel()
        {
            return IExecuteWithSignature<bool>("getIncludeTxPowerLevel", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#getTransportDiscoveryData()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.Le.TransportDiscoveryData> GetTransportDiscoveryData()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.Le.TransportDiscoveryData>>("getTransportDiscoveryData", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#getServiceSolicitationUuids()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Os.ParcelUuid> GetServiceSolicitationUuids()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Os.ParcelUuid>>("getServiceSolicitationUuids", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#getServiceUuids()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Os.ParcelUuid> GetServiceUuids()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Os.ParcelUuid>>("getServiceUuids", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#getServiceData()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Android.Os.ParcelUuid, byte[]> GetServiceData()
        {
            return IExecuteWithSignature<Java.Util.Map<Android.Os.ParcelUuid, byte[]>>("getServiceData", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData"/></returns>
            public Android.Bluetooth.Le.AdvertiseData Build()
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertiseData>("build", "()Landroid/bluetooth/le/AdvertiseData;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#addManufacturerData(int,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertiseData.Builder AddManufacturerData(int arg0, byte[] arg1)
            {
                return IExecute<Android.Bluetooth.Le.AdvertiseData.Builder>("addManufacturerData", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#addServiceData(android.os.ParcelUuid,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertiseData.Builder AddServiceData(Android.Os.ParcelUuid arg0, byte[] arg1)
            {
                return IExecute<Android.Bluetooth.Le.AdvertiseData.Builder>("addServiceData", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#addServiceSolicitationUuid(android.os.ParcelUuid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertiseData.Builder AddServiceSolicitationUuid(Android.Os.ParcelUuid arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertiseData.Builder>("addServiceSolicitationUuid", "(Landroid/os/ParcelUuid;)Landroid/bluetooth/le/AdvertiseData$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#addServiceUuid(android.os.ParcelUuid)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelUuid"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertiseData.Builder AddServiceUuid(Android.Os.ParcelUuid arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertiseData.Builder>("addServiceUuid", "(Landroid/os/ParcelUuid;)Landroid/bluetooth/le/AdvertiseData$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#addTransportDiscoveryData(android.bluetooth.le.TransportDiscoveryData)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Bluetooth.Le.TransportDiscoveryData"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertiseData.Builder AddTransportDiscoveryData(Android.Bluetooth.Le.TransportDiscoveryData arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertiseData.Builder>("addTransportDiscoveryData", "(Landroid/bluetooth/le/TransportDiscoveryData;)Landroid/bluetooth/le/AdvertiseData$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#setIncludeDeviceName(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertiseData.Builder SetIncludeDeviceName(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertiseData.Builder>("setIncludeDeviceName", "(Z)Landroid/bluetooth/le/AdvertiseData$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertiseData.Builder.html#setIncludeTxPowerLevel(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertiseData.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertiseData.Builder SetIncludeTxPowerLevel(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertiseData.Builder>("setIncludeTxPowerLevel", "(Z)Landroid/bluetooth/le/AdvertiseData$Builder;", arg0);
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