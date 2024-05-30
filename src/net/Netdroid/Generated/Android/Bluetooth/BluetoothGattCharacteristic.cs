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
    #region BluetoothGattCharacteristic
    public partial class BluetoothGattCharacteristic
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#%3Cinit%3E(java.util.UUID,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BluetoothGattCharacteristic(Java.Util.UUID arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_FLOAT"/>
        /// </summary>
        public static int FORMAT_FLOAT { get { if (!_FORMAT_FLOATReady) { _FORMAT_FLOATContent = SGetField<int>(LocalBridgeClazz, "FORMAT_FLOAT"); _FORMAT_FLOATReady = true; } return _FORMAT_FLOATContent; } }
        private static int _FORMAT_FLOATContent = default;
        private static bool _FORMAT_FLOATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_SFLOAT"/>
        /// </summary>
        public static int FORMAT_SFLOAT { get { if (!_FORMAT_SFLOATReady) { _FORMAT_SFLOATContent = SGetField<int>(LocalBridgeClazz, "FORMAT_SFLOAT"); _FORMAT_SFLOATReady = true; } return _FORMAT_SFLOATContent; } }
        private static int _FORMAT_SFLOATContent = default;
        private static bool _FORMAT_SFLOATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_SINT16"/>
        /// </summary>
        public static int FORMAT_SINT16 { get { if (!_FORMAT_SINT16Ready) { _FORMAT_SINT16Content = SGetField<int>(LocalBridgeClazz, "FORMAT_SINT16"); _FORMAT_SINT16Ready = true; } return _FORMAT_SINT16Content; } }
        private static int _FORMAT_SINT16Content = default;
        private static bool _FORMAT_SINT16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_SINT32"/>
        /// </summary>
        public static int FORMAT_SINT32 { get { if (!_FORMAT_SINT32Ready) { _FORMAT_SINT32Content = SGetField<int>(LocalBridgeClazz, "FORMAT_SINT32"); _FORMAT_SINT32Ready = true; } return _FORMAT_SINT32Content; } }
        private static int _FORMAT_SINT32Content = default;
        private static bool _FORMAT_SINT32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_SINT8"/>
        /// </summary>
        public static int FORMAT_SINT8 { get { if (!_FORMAT_SINT8Ready) { _FORMAT_SINT8Content = SGetField<int>(LocalBridgeClazz, "FORMAT_SINT8"); _FORMAT_SINT8Ready = true; } return _FORMAT_SINT8Content; } }
        private static int _FORMAT_SINT8Content = default;
        private static bool _FORMAT_SINT8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_UINT16"/>
        /// </summary>
        public static int FORMAT_UINT16 { get { if (!_FORMAT_UINT16Ready) { _FORMAT_UINT16Content = SGetField<int>(LocalBridgeClazz, "FORMAT_UINT16"); _FORMAT_UINT16Ready = true; } return _FORMAT_UINT16Content; } }
        private static int _FORMAT_UINT16Content = default;
        private static bool _FORMAT_UINT16Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_UINT32"/>
        /// </summary>
        public static int FORMAT_UINT32 { get { if (!_FORMAT_UINT32Ready) { _FORMAT_UINT32Content = SGetField<int>(LocalBridgeClazz, "FORMAT_UINT32"); _FORMAT_UINT32Ready = true; } return _FORMAT_UINT32Content; } }
        private static int _FORMAT_UINT32Content = default;
        private static bool _FORMAT_UINT32Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#FORMAT_UINT8"/>
        /// </summary>
        public static int FORMAT_UINT8 { get { if (!_FORMAT_UINT8Ready) { _FORMAT_UINT8Content = SGetField<int>(LocalBridgeClazz, "FORMAT_UINT8"); _FORMAT_UINT8Ready = true; } return _FORMAT_UINT8Content; } }
        private static int _FORMAT_UINT8Content = default;
        private static bool _FORMAT_UINT8Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_READ"/>
        /// </summary>
        public static int PERMISSION_READ { get { if (!_PERMISSION_READReady) { _PERMISSION_READContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_READ"); _PERMISSION_READReady = true; } return _PERMISSION_READContent; } }
        private static int _PERMISSION_READContent = default;
        private static bool _PERMISSION_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_READ_ENCRYPTED"/>
        /// </summary>
        public static int PERMISSION_READ_ENCRYPTED { get { if (!_PERMISSION_READ_ENCRYPTEDReady) { _PERMISSION_READ_ENCRYPTEDContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_READ_ENCRYPTED"); _PERMISSION_READ_ENCRYPTEDReady = true; } return _PERMISSION_READ_ENCRYPTEDContent; } }
        private static int _PERMISSION_READ_ENCRYPTEDContent = default;
        private static bool _PERMISSION_READ_ENCRYPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_READ_ENCRYPTED_MITM"/>
        /// </summary>
        public static int PERMISSION_READ_ENCRYPTED_MITM { get { if (!_PERMISSION_READ_ENCRYPTED_MITMReady) { _PERMISSION_READ_ENCRYPTED_MITMContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_READ_ENCRYPTED_MITM"); _PERMISSION_READ_ENCRYPTED_MITMReady = true; } return _PERMISSION_READ_ENCRYPTED_MITMContent; } }
        private static int _PERMISSION_READ_ENCRYPTED_MITMContent = default;
        private static bool _PERMISSION_READ_ENCRYPTED_MITMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_WRITE"/>
        /// </summary>
        public static int PERMISSION_WRITE { get { if (!_PERMISSION_WRITEReady) { _PERMISSION_WRITEContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE"); _PERMISSION_WRITEReady = true; } return _PERMISSION_WRITEContent; } }
        private static int _PERMISSION_WRITEContent = default;
        private static bool _PERMISSION_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_WRITE_ENCRYPTED"/>
        /// </summary>
        public static int PERMISSION_WRITE_ENCRYPTED { get { if (!_PERMISSION_WRITE_ENCRYPTEDReady) { _PERMISSION_WRITE_ENCRYPTEDContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_ENCRYPTED"); _PERMISSION_WRITE_ENCRYPTEDReady = true; } return _PERMISSION_WRITE_ENCRYPTEDContent; } }
        private static int _PERMISSION_WRITE_ENCRYPTEDContent = default;
        private static bool _PERMISSION_WRITE_ENCRYPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_WRITE_ENCRYPTED_MITM"/>
        /// </summary>
        public static int PERMISSION_WRITE_ENCRYPTED_MITM { get { if (!_PERMISSION_WRITE_ENCRYPTED_MITMReady) { _PERMISSION_WRITE_ENCRYPTED_MITMContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_ENCRYPTED_MITM"); _PERMISSION_WRITE_ENCRYPTED_MITMReady = true; } return _PERMISSION_WRITE_ENCRYPTED_MITMContent; } }
        private static int _PERMISSION_WRITE_ENCRYPTED_MITMContent = default;
        private static bool _PERMISSION_WRITE_ENCRYPTED_MITMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_WRITE_SIGNED"/>
        /// </summary>
        public static int PERMISSION_WRITE_SIGNED { get { if (!_PERMISSION_WRITE_SIGNEDReady) { _PERMISSION_WRITE_SIGNEDContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_SIGNED"); _PERMISSION_WRITE_SIGNEDReady = true; } return _PERMISSION_WRITE_SIGNEDContent; } }
        private static int _PERMISSION_WRITE_SIGNEDContent = default;
        private static bool _PERMISSION_WRITE_SIGNEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PERMISSION_WRITE_SIGNED_MITM"/>
        /// </summary>
        public static int PERMISSION_WRITE_SIGNED_MITM { get { if (!_PERMISSION_WRITE_SIGNED_MITMReady) { _PERMISSION_WRITE_SIGNED_MITMContent = SGetField<int>(LocalBridgeClazz, "PERMISSION_WRITE_SIGNED_MITM"); _PERMISSION_WRITE_SIGNED_MITMReady = true; } return _PERMISSION_WRITE_SIGNED_MITMContent; } }
        private static int _PERMISSION_WRITE_SIGNED_MITMContent = default;
        private static bool _PERMISSION_WRITE_SIGNED_MITMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_BROADCAST"/>
        /// </summary>
        public static int PROPERTY_BROADCAST { get { if (!_PROPERTY_BROADCASTReady) { _PROPERTY_BROADCASTContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_BROADCAST"); _PROPERTY_BROADCASTReady = true; } return _PROPERTY_BROADCASTContent; } }
        private static int _PROPERTY_BROADCASTContent = default;
        private static bool _PROPERTY_BROADCASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_EXTENDED_PROPS"/>
        /// </summary>
        public static int PROPERTY_EXTENDED_PROPS { get { if (!_PROPERTY_EXTENDED_PROPSReady) { _PROPERTY_EXTENDED_PROPSContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_EXTENDED_PROPS"); _PROPERTY_EXTENDED_PROPSReady = true; } return _PROPERTY_EXTENDED_PROPSContent; } }
        private static int _PROPERTY_EXTENDED_PROPSContent = default;
        private static bool _PROPERTY_EXTENDED_PROPSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_INDICATE"/>
        /// </summary>
        public static int PROPERTY_INDICATE { get { if (!_PROPERTY_INDICATEReady) { _PROPERTY_INDICATEContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_INDICATE"); _PROPERTY_INDICATEReady = true; } return _PROPERTY_INDICATEContent; } }
        private static int _PROPERTY_INDICATEContent = default;
        private static bool _PROPERTY_INDICATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_NOTIFY"/>
        /// </summary>
        public static int PROPERTY_NOTIFY { get { if (!_PROPERTY_NOTIFYReady) { _PROPERTY_NOTIFYContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_NOTIFY"); _PROPERTY_NOTIFYReady = true; } return _PROPERTY_NOTIFYContent; } }
        private static int _PROPERTY_NOTIFYContent = default;
        private static bool _PROPERTY_NOTIFYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_READ"/>
        /// </summary>
        public static int PROPERTY_READ { get { if (!_PROPERTY_READReady) { _PROPERTY_READContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_READ"); _PROPERTY_READReady = true; } return _PROPERTY_READContent; } }
        private static int _PROPERTY_READContent = default;
        private static bool _PROPERTY_READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_SIGNED_WRITE"/>
        /// </summary>
        public static int PROPERTY_SIGNED_WRITE { get { if (!_PROPERTY_SIGNED_WRITEReady) { _PROPERTY_SIGNED_WRITEContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_SIGNED_WRITE"); _PROPERTY_SIGNED_WRITEReady = true; } return _PROPERTY_SIGNED_WRITEContent; } }
        private static int _PROPERTY_SIGNED_WRITEContent = default;
        private static bool _PROPERTY_SIGNED_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_WRITE"/>
        /// </summary>
        public static int PROPERTY_WRITE { get { if (!_PROPERTY_WRITEReady) { _PROPERTY_WRITEContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_WRITE"); _PROPERTY_WRITEReady = true; } return _PROPERTY_WRITEContent; } }
        private static int _PROPERTY_WRITEContent = default;
        private static bool _PROPERTY_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#PROPERTY_WRITE_NO_RESPONSE"/>
        /// </summary>
        public static int PROPERTY_WRITE_NO_RESPONSE { get { if (!_PROPERTY_WRITE_NO_RESPONSEReady) { _PROPERTY_WRITE_NO_RESPONSEContent = SGetField<int>(LocalBridgeClazz, "PROPERTY_WRITE_NO_RESPONSE"); _PROPERTY_WRITE_NO_RESPONSEReady = true; } return _PROPERTY_WRITE_NO_RESPONSEContent; } }
        private static int _PROPERTY_WRITE_NO_RESPONSEContent = default;
        private static bool _PROPERTY_WRITE_NO_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#WRITE_TYPE_DEFAULT"/>
        /// </summary>
        public static int WRITE_TYPE_DEFAULT { get { if (!_WRITE_TYPE_DEFAULTReady) { _WRITE_TYPE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "WRITE_TYPE_DEFAULT"); _WRITE_TYPE_DEFAULTReady = true; } return _WRITE_TYPE_DEFAULTContent; } }
        private static int _WRITE_TYPE_DEFAULTContent = default;
        private static bool _WRITE_TYPE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#WRITE_TYPE_NO_RESPONSE"/>
        /// </summary>
        public static int WRITE_TYPE_NO_RESPONSE { get { if (!_WRITE_TYPE_NO_RESPONSEReady) { _WRITE_TYPE_NO_RESPONSEContent = SGetField<int>(LocalBridgeClazz, "WRITE_TYPE_NO_RESPONSE"); _WRITE_TYPE_NO_RESPONSEReady = true; } return _WRITE_TYPE_NO_RESPONSEContent; } }
        private static int _WRITE_TYPE_NO_RESPONSEContent = default;
        private static bool _WRITE_TYPE_NO_RESPONSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#WRITE_TYPE_SIGNED"/>
        /// </summary>
        public static int WRITE_TYPE_SIGNED { get { if (!_WRITE_TYPE_SIGNEDReady) { _WRITE_TYPE_SIGNEDContent = SGetField<int>(LocalBridgeClazz, "WRITE_TYPE_SIGNED"); _WRITE_TYPE_SIGNEDReady = true; } return _WRITE_TYPE_SIGNEDContent; } }
        private static int _WRITE_TYPE_SIGNEDContent = default;
        private static bool _WRITE_TYPE_SIGNEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getDescriptors()"/> 
        /// </summary>
        public Java.Util.List<Android.Bluetooth.BluetoothGattDescriptor> Descriptors
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothGattDescriptor>>("getDescriptors", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getInstanceId()"/> 
        /// </summary>
        public int InstanceId
        {
            get { return IExecuteWithSignature<int>("getInstanceId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getPermissions()"/> 
        /// </summary>
        public int Permissions
        {
            get { return IExecuteWithSignature<int>("getPermissions", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getProperties()"/> 
        /// </summary>
        public int Properties
        {
            get { return IExecuteWithSignature<int>("getProperties", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getService()"/> 
        /// </summary>
        public Android.Bluetooth.BluetoothGattService Service
        {
            get { return IExecuteWithSignature<Android.Bluetooth.BluetoothGattService>("getService", "()Landroid/bluetooth/BluetoothGattService;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getUuid()"/> 
        /// </summary>
        public Java.Util.UUID Uuid
        {
            get { return IExecuteWithSignature<Java.Util.UUID>("getUuid", "()Ljava/util/UUID;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getWriteType()"/> <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#setWriteType(int)"/>
        /// </summary>
        public int WriteType
        {
            get { return IExecuteWithSignature<int>("getWriteType", "()I"); } set { IExecuteWithSignature("setWriteType", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#getDescriptor(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothGattDescriptor"/></returns>
        public Android.Bluetooth.BluetoothGattDescriptor GetDescriptor(Java.Util.UUID arg0)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothGattDescriptor>("getDescriptor", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothGattDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#addDescriptor(android.bluetooth.BluetoothGattDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothGattDescriptor"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddDescriptor(Android.Bluetooth.BluetoothGattDescriptor arg0)
        {
            return IExecuteWithSignature<bool>("addDescriptor", "(Landroid/bluetooth/BluetoothGattDescriptor;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothGattCharacteristic.html#writeToParcel(android.os.Parcel,int)"/>
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