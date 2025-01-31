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

namespace Android.Bluetooth.Le
{
    #region AdvertisingSetParameters declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html"/>
    /// </summary>
    public partial class AdvertisingSetParameters : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.bluetooth.le.AdvertisingSetParameters";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdvertisingSetParameters() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdvertisingSetParameters(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.bluetooth.le.AdvertisingSetParameters$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region AdvertisingSetParameters implementation
    public partial class AdvertisingSetParameters
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#INTERVAL_HIGH"/>
        /// </summary>
        public static int INTERVAL_HIGH { get { if (!_INTERVAL_HIGHReady) { _INTERVAL_HIGHContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_HIGH"); _INTERVAL_HIGHReady = true; } return _INTERVAL_HIGHContent; } }
        private static int _INTERVAL_HIGHContent = default;
        private static bool _INTERVAL_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#INTERVAL_LOW"/>
        /// </summary>
        public static int INTERVAL_LOW { get { if (!_INTERVAL_LOWReady) { _INTERVAL_LOWContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_LOW"); _INTERVAL_LOWReady = true; } return _INTERVAL_LOWContent; } }
        private static int _INTERVAL_LOWContent = default;
        private static bool _INTERVAL_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#INTERVAL_MAX"/>
        /// </summary>
        public static int INTERVAL_MAX { get { if (!_INTERVAL_MAXReady) { _INTERVAL_MAXContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_MAX"); _INTERVAL_MAXReady = true; } return _INTERVAL_MAXContent; } }
        private static int _INTERVAL_MAXContent = default;
        private static bool _INTERVAL_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#INTERVAL_MEDIUM"/>
        /// </summary>
        public static int INTERVAL_MEDIUM { get { if (!_INTERVAL_MEDIUMReady) { _INTERVAL_MEDIUMContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_MEDIUM"); _INTERVAL_MEDIUMReady = true; } return _INTERVAL_MEDIUMContent; } }
        private static int _INTERVAL_MEDIUMContent = default;
        private static bool _INTERVAL_MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#INTERVAL_MIN"/>
        /// </summary>
        public static int INTERVAL_MIN { get { if (!_INTERVAL_MINReady) { _INTERVAL_MINContent = SGetField<int>(LocalBridgeClazz, "INTERVAL_MIN"); _INTERVAL_MINReady = true; } return _INTERVAL_MINContent; } }
        private static int _INTERVAL_MINContent = default;
        private static bool _INTERVAL_MINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#TX_POWER_HIGH"/>
        /// </summary>
        public static int TX_POWER_HIGH { get { if (!_TX_POWER_HIGHReady) { _TX_POWER_HIGHContent = SGetField<int>(LocalBridgeClazz, "TX_POWER_HIGH"); _TX_POWER_HIGHReady = true; } return _TX_POWER_HIGHContent; } }
        private static int _TX_POWER_HIGHContent = default;
        private static bool _TX_POWER_HIGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#TX_POWER_LOW"/>
        /// </summary>
        public static int TX_POWER_LOW { get { if (!_TX_POWER_LOWReady) { _TX_POWER_LOWContent = SGetField<int>(LocalBridgeClazz, "TX_POWER_LOW"); _TX_POWER_LOWReady = true; } return _TX_POWER_LOWContent; } }
        private static int _TX_POWER_LOWContent = default;
        private static bool _TX_POWER_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#TX_POWER_MAX"/>
        /// </summary>
        public static int TX_POWER_MAX { get { if (!_TX_POWER_MAXReady) { _TX_POWER_MAXContent = SGetField<int>(LocalBridgeClazz, "TX_POWER_MAX"); _TX_POWER_MAXReady = true; } return _TX_POWER_MAXContent; } }
        private static int _TX_POWER_MAXContent = default;
        private static bool _TX_POWER_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#TX_POWER_MEDIUM"/>
        /// </summary>
        public static int TX_POWER_MEDIUM { get { if (!_TX_POWER_MEDIUMReady) { _TX_POWER_MEDIUMContent = SGetField<int>(LocalBridgeClazz, "TX_POWER_MEDIUM"); _TX_POWER_MEDIUMReady = true; } return _TX_POWER_MEDIUMContent; } }
        private static int _TX_POWER_MEDIUMContent = default;
        private static bool _TX_POWER_MEDIUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#TX_POWER_MIN"/>
        /// </summary>
        public static int TX_POWER_MIN { get { if (!_TX_POWER_MINReady) { _TX_POWER_MINContent = SGetField<int>(LocalBridgeClazz, "TX_POWER_MIN"); _TX_POWER_MINReady = true; } return _TX_POWER_MINContent; } }
        private static int _TX_POWER_MINContent = default;
        private static bool _TX_POWER_MINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#TX_POWER_ULTRA_LOW"/>
        /// </summary>
        public static int TX_POWER_ULTRA_LOW { get { if (!_TX_POWER_ULTRA_LOWReady) { _TX_POWER_ULTRA_LOWContent = SGetField<int>(LocalBridgeClazz, "TX_POWER_ULTRA_LOW"); _TX_POWER_ULTRA_LOWReady = true; } return _TX_POWER_ULTRA_LOWContent; } }
        private static int _TX_POWER_ULTRA_LOWContent = default;
        private static bool _TX_POWER_ULTRA_LOWReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#includeTxPower()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IncludeTxPower()
        {
            return IExecuteWithSignature<bool>("includeTxPower", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#isAnonymous()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnonymous()
        {
            return IExecuteWithSignature<bool>("isAnonymous", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#isConnectable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnectable()
        {
            return IExecuteWithSignature<bool>("isConnectable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#isDiscoverable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDiscoverable()
        {
            return IExecuteWithSignature<bool>("isDiscoverable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#isLegacy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLegacy()
        {
            return IExecuteWithSignature<bool>("isLegacy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#isScannable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsScannable()
        {
            return IExecuteWithSignature<bool>("isScannable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#getInterval()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInterval()
        {
            return IExecuteWithSignature<int>("getInterval", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#getPrimaryPhy()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPrimaryPhy()
        {
            return IExecuteWithSignature<int>("getPrimaryPhy", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#getSecondaryPhy()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSecondaryPhy()
        {
            return IExecuteWithSignature<int>("getSecondaryPhy", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#getTxPowerLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTxPowerLevel()
        {
            return IExecuteWithSignature<int>("getTxPowerLevel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
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
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters Build()
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters>("build", "()Landroid/bluetooth/le/AdvertisingSetParameters;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setAnonymous(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetAnonymous(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setAnonymous", "(Z)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setConnectable(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetConnectable(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setConnectable", "(Z)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setDiscoverable(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetDiscoverable(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setDiscoverable", "(Z)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setIncludeTxPower(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetIncludeTxPower(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setIncludeTxPower", "(Z)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setInterval(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetInterval(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setInterval", "(I)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setLegacyMode(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetLegacyMode(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setLegacyMode", "(Z)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setPrimaryPhy(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetPrimaryPhy(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setPrimaryPhy", "(I)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setScannable(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetScannable(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setScannable", "(Z)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setSecondaryPhy(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetSecondaryPhy(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setSecondaryPhy", "(I)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/AdvertisingSetParameters.Builder.html#setTxPowerLevel(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.AdvertisingSetParameters.Builder"/></returns>
            public Android.Bluetooth.Le.AdvertisingSetParameters.Builder SetTxPowerLevel(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.AdvertisingSetParameters.Builder>("setTxPowerLevel", "(I)Landroid/bluetooth/le/AdvertisingSetParameters$Builder;", arg0);
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