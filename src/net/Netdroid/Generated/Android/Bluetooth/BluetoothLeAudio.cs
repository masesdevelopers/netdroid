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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Bluetooth
{
    #region BluetoothLeAudio declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html"/>
    /// </summary>
    public partial class BluetoothLeAudio : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BluetoothLeAudio>
    {
        const string _bridgeClassName = "android.bluetooth.BluetoothLeAudio";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BluetoothLeAudio() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BluetoothLeAudio(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region BluetoothLeAudio implementation
    public partial class BluetoothLeAudio : Android.Bluetooth.IBluetoothProfile, Java.Lang.IAutoCloseable
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Bluetooth.BluetoothLeAudio"/> to <see cref="Android.Bluetooth.BluetoothProfile"/>
        /// </summary>
        public static implicit operator Android.Bluetooth.BluetoothProfile(Android.Bluetooth.BluetoothLeAudio t) => t.Cast<Android.Bluetooth.BluetoothProfile>();
        /// <summary>
        /// Converter from <see cref="Android.Bluetooth.BluetoothLeAudio"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Android.Bluetooth.BluetoothLeAudio t) => t.Cast<Java.Lang.AutoCloseable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#GROUP_ID_INVALID"/>
        /// </summary>
        public static int GROUP_ID_INVALID { get { if (!_GROUP_ID_INVALIDReady) { _GROUP_ID_INVALIDContent = SGetField<int>(LocalBridgeClazz, "GROUP_ID_INVALID"); _GROUP_ID_INVALIDReady = true; } return _GROUP_ID_INVALIDContent; } }
        private static int _GROUP_ID_INVALIDContent = default;
        private static bool _GROUP_ID_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#ACTION_LE_AUDIO_CONNECTION_STATE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_LE_AUDIO_CONNECTION_STATE_CHANGED { get { if (!_ACTION_LE_AUDIO_CONNECTION_STATE_CHANGEDReady) { _ACTION_LE_AUDIO_CONNECTION_STATE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_LE_AUDIO_CONNECTION_STATE_CHANGED"); _ACTION_LE_AUDIO_CONNECTION_STATE_CHANGEDReady = true; } return _ACTION_LE_AUDIO_CONNECTION_STATE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_LE_AUDIO_CONNECTION_STATE_CHANGEDContent = default;
        private static bool _ACTION_LE_AUDIO_CONNECTION_STATE_CHANGEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#getConnectedGroupLeadDevice(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Bluetooth.BluetoothDevice"/></returns>
        public Android.Bluetooth.BluetoothDevice GetConnectedGroupLeadDevice(int arg0)
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothDevice>("getConnectedGroupLeadDevice", "(I)Landroid/bluetooth/BluetoothDevice;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#getConnectionState(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetConnectionState(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<int>("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#getGroupId(android.bluetooth.BluetoothDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetGroupId(Android.Bluetooth.BluetoothDevice arg0)
        {
            return IExecuteWithSignature<int>("getGroupId", "(Landroid/bluetooth/BluetoothDevice;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#getConnectedDevices()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetConnectedDevices()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getConnectedDevices", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#getDevicesMatchingConnectionStates(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothDevice>>("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothLeAudio.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}