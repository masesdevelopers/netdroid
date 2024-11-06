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
    #region BluetoothCodecStatus declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html"/>
    /// </summary>
    public partial class BluetoothCodecStatus : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.bluetooth.BluetoothCodecStatus";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BluetoothCodecStatus() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BluetoothCodecStatus(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.bluetooth.BluetoothCodecStatus$Builder";
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

    #region BluetoothCodecStatus implementation
    public partial class BluetoothCodecStatus
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#EXTRA_CODEC_STATUS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CODEC_STATUS { get { if (!_EXTRA_CODEC_STATUSReady) { _EXTRA_CODEC_STATUSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CODEC_STATUS"); _EXTRA_CODEC_STATUSReady = true; } return _EXTRA_CODEC_STATUSContent; } }
        private static Java.Lang.String _EXTRA_CODEC_STATUSContent = default;
        private static bool _EXTRA_CODEC_STATUSReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#getCodecConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Bluetooth.BluetoothCodecConfig"/></returns>
        public Android.Bluetooth.BluetoothCodecConfig GetCodecConfig()
        {
            return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecConfig>("getCodecConfig", "()Landroid/bluetooth/BluetoothCodecConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#isCodecConfigSelectable(android.bluetooth.BluetoothCodecConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothCodecConfig"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCodecConfigSelectable(Android.Bluetooth.BluetoothCodecConfig arg0)
        {
            return IExecuteWithSignature<bool>("isCodecConfigSelectable", "(Landroid/bluetooth/BluetoothCodecConfig;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#getCodecsLocalCapabilities()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothCodecConfig> GetCodecsLocalCapabilities()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothCodecConfig>>("getCodecsLocalCapabilities", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#getCodecsSelectableCapabilities()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Bluetooth.BluetoothCodecConfig> GetCodecsSelectableCapabilities()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Bluetooth.BluetoothCodecConfig>>("getCodecsSelectableCapabilities", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecStatus"/></returns>
            public Android.Bluetooth.BluetoothCodecStatus Build()
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecStatus>("build", "()Landroid/bluetooth/BluetoothCodecStatus;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.Builder.html#setCodecConfig(android.bluetooth.BluetoothCodecConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothCodecConfig"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecStatus.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecStatus.Builder SetCodecConfig(Android.Bluetooth.BluetoothCodecConfig arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecStatus.Builder>("setCodecConfig", "(Landroid/bluetooth/BluetoothCodecConfig;)Landroid/bluetooth/BluetoothCodecStatus$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.Builder.html#setCodecsLocalCapabilities(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecStatus.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecStatus.Builder SetCodecsLocalCapabilities(Java.Util.List<Android.Bluetooth.BluetoothCodecConfig> arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecStatus.Builder>("setCodecsLocalCapabilities", "(Ljava/util/List;)Landroid/bluetooth/BluetoothCodecStatus$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/BluetoothCodecStatus.Builder.html#setCodecsSelectableCapabilities(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Bluetooth.BluetoothCodecStatus.Builder"/></returns>
            public Android.Bluetooth.BluetoothCodecStatus.Builder SetCodecsSelectableCapabilities(Java.Util.List<Android.Bluetooth.BluetoothCodecConfig> arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.BluetoothCodecStatus.Builder>("setCodecsSelectableCapabilities", "(Ljava/util/List;)Landroid/bluetooth/BluetoothCodecStatus$Builder;", arg0);
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