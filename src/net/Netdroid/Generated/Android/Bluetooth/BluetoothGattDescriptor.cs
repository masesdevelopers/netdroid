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

namespace Android.Bluetooth
{
    #region BluetoothGattDescriptor
    public partial class BluetoothGattDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#%3Cinit%3E(java.util.UUID,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BluetoothGattDescriptor(Java.Util.UUID arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#DISABLE_NOTIFICATION_VALUE"/>
        /// </summary>
        public static byte[] DISABLE_NOTIFICATION_VALUE { get { if (!_DISABLE_NOTIFICATION_VALUEReady) { _DISABLE_NOTIFICATION_VALUEContent = SGetFieldArray<byte>(LocalBridgeClazz, "DISABLE_NOTIFICATION_VALUE"); _DISABLE_NOTIFICATION_VALUEReady = true; } return _DISABLE_NOTIFICATION_VALUEContent; } }
        private static byte[] _DISABLE_NOTIFICATION_VALUEContent = default;
        private static bool _DISABLE_NOTIFICATION_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#ENABLE_INDICATION_VALUE"/>
        /// </summary>
        public static byte[] ENABLE_INDICATION_VALUE { get { if (!_ENABLE_INDICATION_VALUEReady) { _ENABLE_INDICATION_VALUEContent = SGetFieldArray<byte>(LocalBridgeClazz, "ENABLE_INDICATION_VALUE"); _ENABLE_INDICATION_VALUEReady = true; } return _ENABLE_INDICATION_VALUEContent; } }
        private static byte[] _ENABLE_INDICATION_VALUEContent = default;
        private static bool _ENABLE_INDICATION_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#ENABLE_NOTIFICATION_VALUE"/>
        /// </summary>
        public static byte[] ENABLE_NOTIFICATION_VALUE { get { if (!_ENABLE_NOTIFICATION_VALUEReady) { _ENABLE_NOTIFICATION_VALUEContent = SGetFieldArray<byte>(LocalBridgeClazz, "ENABLE_NOTIFICATION_VALUE"); _ENABLE_NOTIFICATION_VALUEReady = true; } return _ENABLE_NOTIFICATION_VALUEContent; } }
        private static byte[] _ENABLE_NOTIFICATION_VALUEContent = default;
        private static bool _ENABLE_NOTIFICATION_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_READ"/>
        /// </summary>
        public static int PERMISSION_READ { get { if (!_PERMISSION_READReady) { _PERMISSION_READContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_READ"); _PERMISSION_READReady = true; } return _PERMISSION_READContent; } }
        private static int _PERMISSION_READContent = default;
        private static bool _PERMISSION_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_READ_ENCRYPTED"/>
        /// </summary>
        public static int PERMISSION_READ_ENCRYPTED { get { if (!_PERMISSION_READ_ENCRYPTEDReady) { _PERMISSION_READ_ENCRYPTEDContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_READ_ENCRYPTED"); _PERMISSION_READ_ENCRYPTEDReady = true; } return _PERMISSION_READ_ENCRYPTEDContent; } }
        private static int _PERMISSION_READ_ENCRYPTEDContent = default;
        private static bool _PERMISSION_READ_ENCRYPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_READ_ENCRYPTED_MITM"/>
        /// </summary>
        public static int PERMISSION_READ_ENCRYPTED_MITM { get { if (!_PERMISSION_READ_ENCRYPTED_MITMReady) { _PERMISSION_READ_ENCRYPTED_MITMContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_READ_ENCRYPTED_MITM"); _PERMISSION_READ_ENCRYPTED_MITMReady = true; } return _PERMISSION_READ_ENCRYPTED_MITMContent; } }
        private static int _PERMISSION_READ_ENCRYPTED_MITMContent = default;
        private static bool _PERMISSION_READ_ENCRYPTED_MITMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_WRITE"/>
        /// </summary>
        public static int PERMISSION_WRITE { get { if (!_PERMISSION_WRITEReady) { _PERMISSION_WRITEContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE"); _PERMISSION_WRITEReady = true; } return _PERMISSION_WRITEContent; } }
        private static int _PERMISSION_WRITEContent = default;
        private static bool _PERMISSION_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_WRITE_ENCRYPTED"/>
        /// </summary>
        public static int PERMISSION_WRITE_ENCRYPTED { get { if (!_PERMISSION_WRITE_ENCRYPTEDReady) { _PERMISSION_WRITE_ENCRYPTEDContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_ENCRYPTED"); _PERMISSION_WRITE_ENCRYPTEDReady = true; } return _PERMISSION_WRITE_ENCRYPTEDContent; } }
        private static int _PERMISSION_WRITE_ENCRYPTEDContent = default;
        private static bool _PERMISSION_WRITE_ENCRYPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_WRITE_ENCRYPTED_MITM"/>
        /// </summary>
        public static int PERMISSION_WRITE_ENCRYPTED_MITM { get { if (!_PERMISSION_WRITE_ENCRYPTED_MITMReady) { _PERMISSION_WRITE_ENCRYPTED_MITMContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_ENCRYPTED_MITM"); _PERMISSION_WRITE_ENCRYPTED_MITMReady = true; } return _PERMISSION_WRITE_ENCRYPTED_MITMContent; } }
        private static int _PERMISSION_WRITE_ENCRYPTED_MITMContent = default;
        private static bool _PERMISSION_WRITE_ENCRYPTED_MITMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_WRITE_SIGNED"/>
        /// </summary>
        public static int PERMISSION_WRITE_SIGNED { get { if (!_PERMISSION_WRITE_SIGNEDReady) { _PERMISSION_WRITE_SIGNEDContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_SIGNED"); _PERMISSION_WRITE_SIGNEDReady = true; } return _PERMISSION_WRITE_SIGNEDContent; } }
        private static int _PERMISSION_WRITE_SIGNEDContent = default;
        private static bool _PERMISSION_WRITE_SIGNEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#PERMISSION_WRITE_SIGNED_MITM"/>
        /// </summary>
        public static int PERMISSION_WRITE_SIGNED_MITM { get { if (!_PERMISSION_WRITE_SIGNED_MITMReady) { _PERMISSION_WRITE_SIGNED_MITMContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_SIGNED_MITM"); _PERMISSION_WRITE_SIGNED_MITMReady = true; } return _PERMISSION_WRITE_SIGNED_MITMContent; } }
        private static int _PERMISSION_WRITE_SIGNED_MITMContent = default;
        private static bool _PERMISSION_WRITE_SIGNED_MITMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#getCharacteristic()"/> 
        /// </summary>
        public Android.Bluetooth.BluetoothGattCharacteristic Characteristic
        {
            get { return IExecuteWithSignature<Android.Bluetooth.BluetoothGattCharacteristic>("getCharacteristic", "()Landroid/bluetooth/BluetoothGattCharacteristic;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#getPermissions()"/> 
        /// </summary>
        public int Permissions
        {
            get { return IExecuteWithSignature<int>("getPermissions", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#getUuid()"/> 
        /// </summary>
        public Java.Util.UUID Uuid
        {
            get { return IExecuteWithSignature<Java.Util.UUID>("getUuid", "()Ljava/util/UUID;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattDescriptor.html#writeToParcel(android.os.Parcel,int)"/>
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