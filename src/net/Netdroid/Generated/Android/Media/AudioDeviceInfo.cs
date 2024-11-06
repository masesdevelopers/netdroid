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

namespace Android.Media
{
    #region AudioDeviceInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html"/>
    /// </summary>
    public partial class AudioDeviceInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AudioDeviceInfo>
    {
        const string _bridgeClassName = "android.media.AudioDeviceInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AudioDeviceInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AudioDeviceInfo(params object[] args) : base(args) { }
    
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

    #region AudioDeviceInfo implementation
    public partial class AudioDeviceInfo
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_AUX_LINE"/>
        /// </summary>
        public static int TYPE_AUX_LINE { get { if (!_TYPE_AUX_LINEReady) { _TYPE_AUX_LINEContent = SGetField<int>(LocalBridgeClazz, "TYPE_AUX_LINE"); _TYPE_AUX_LINEReady = true; } return _TYPE_AUX_LINEContent; } }
        private static int _TYPE_AUX_LINEContent = default;
        private static bool _TYPE_AUX_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BLE_BROADCAST"/>
        /// </summary>
        public static int TYPE_BLE_BROADCAST { get { if (!_TYPE_BLE_BROADCASTReady) { _TYPE_BLE_BROADCASTContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLE_BROADCAST"); _TYPE_BLE_BROADCASTReady = true; } return _TYPE_BLE_BROADCASTContent; } }
        private static int _TYPE_BLE_BROADCASTContent = default;
        private static bool _TYPE_BLE_BROADCASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BLE_HEADSET"/>
        /// </summary>
        public static int TYPE_BLE_HEADSET { get { if (!_TYPE_BLE_HEADSETReady) { _TYPE_BLE_HEADSETContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLE_HEADSET"); _TYPE_BLE_HEADSETReady = true; } return _TYPE_BLE_HEADSETContent; } }
        private static int _TYPE_BLE_HEADSETContent = default;
        private static bool _TYPE_BLE_HEADSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BLE_SPEAKER"/>
        /// </summary>
        public static int TYPE_BLE_SPEAKER { get { if (!_TYPE_BLE_SPEAKERReady) { _TYPE_BLE_SPEAKERContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLE_SPEAKER"); _TYPE_BLE_SPEAKERReady = true; } return _TYPE_BLE_SPEAKERContent; } }
        private static int _TYPE_BLE_SPEAKERContent = default;
        private static bool _TYPE_BLE_SPEAKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BLUETOOTH_A2DP"/>
        /// </summary>
        public static int TYPE_BLUETOOTH_A2DP { get { if (!_TYPE_BLUETOOTH_A2DPReady) { _TYPE_BLUETOOTH_A2DPContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLUETOOTH_A2DP"); _TYPE_BLUETOOTH_A2DPReady = true; } return _TYPE_BLUETOOTH_A2DPContent; } }
        private static int _TYPE_BLUETOOTH_A2DPContent = default;
        private static bool _TYPE_BLUETOOTH_A2DPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BLUETOOTH_SCO"/>
        /// </summary>
        public static int TYPE_BLUETOOTH_SCO { get { if (!_TYPE_BLUETOOTH_SCOReady) { _TYPE_BLUETOOTH_SCOContent = SGetField<int>(LocalBridgeClazz, "TYPE_BLUETOOTH_SCO"); _TYPE_BLUETOOTH_SCOReady = true; } return _TYPE_BLUETOOTH_SCOContent; } }
        private static int _TYPE_BLUETOOTH_SCOContent = default;
        private static bool _TYPE_BLUETOOTH_SCOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BUILTIN_EARPIECE"/>
        /// </summary>
        public static int TYPE_BUILTIN_EARPIECE { get { if (!_TYPE_BUILTIN_EARPIECEReady) { _TYPE_BUILTIN_EARPIECEContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUILTIN_EARPIECE"); _TYPE_BUILTIN_EARPIECEReady = true; } return _TYPE_BUILTIN_EARPIECEContent; } }
        private static int _TYPE_BUILTIN_EARPIECEContent = default;
        private static bool _TYPE_BUILTIN_EARPIECEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BUILTIN_MIC"/>
        /// </summary>
        public static int TYPE_BUILTIN_MIC { get { if (!_TYPE_BUILTIN_MICReady) { _TYPE_BUILTIN_MICContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUILTIN_MIC"); _TYPE_BUILTIN_MICReady = true; } return _TYPE_BUILTIN_MICContent; } }
        private static int _TYPE_BUILTIN_MICContent = default;
        private static bool _TYPE_BUILTIN_MICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BUILTIN_SPEAKER"/>
        /// </summary>
        public static int TYPE_BUILTIN_SPEAKER { get { if (!_TYPE_BUILTIN_SPEAKERReady) { _TYPE_BUILTIN_SPEAKERContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUILTIN_SPEAKER"); _TYPE_BUILTIN_SPEAKERReady = true; } return _TYPE_BUILTIN_SPEAKERContent; } }
        private static int _TYPE_BUILTIN_SPEAKERContent = default;
        private static bool _TYPE_BUILTIN_SPEAKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BUILTIN_SPEAKER_SAFE"/>
        /// </summary>
        public static int TYPE_BUILTIN_SPEAKER_SAFE { get { if (!_TYPE_BUILTIN_SPEAKER_SAFEReady) { _TYPE_BUILTIN_SPEAKER_SAFEContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUILTIN_SPEAKER_SAFE"); _TYPE_BUILTIN_SPEAKER_SAFEReady = true; } return _TYPE_BUILTIN_SPEAKER_SAFEContent; } }
        private static int _TYPE_BUILTIN_SPEAKER_SAFEContent = default;
        private static bool _TYPE_BUILTIN_SPEAKER_SAFEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_BUS"/>
        /// </summary>
        public static int TYPE_BUS { get { if (!_TYPE_BUSReady) { _TYPE_BUSContent = SGetField<int>(LocalBridgeClazz, "TYPE_BUS"); _TYPE_BUSReady = true; } return _TYPE_BUSContent; } }
        private static int _TYPE_BUSContent = default;
        private static bool _TYPE_BUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_DOCK"/>
        /// </summary>
        public static int TYPE_DOCK { get { if (!_TYPE_DOCKReady) { _TYPE_DOCKContent = SGetField<int>(LocalBridgeClazz, "TYPE_DOCK"); _TYPE_DOCKReady = true; } return _TYPE_DOCKContent; } }
        private static int _TYPE_DOCKContent = default;
        private static bool _TYPE_DOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_DOCK_ANALOG"/>
        /// </summary>
        public static int TYPE_DOCK_ANALOG { get { if (!_TYPE_DOCK_ANALOGReady) { _TYPE_DOCK_ANALOGContent = SGetField<int>(LocalBridgeClazz, "TYPE_DOCK_ANALOG"); _TYPE_DOCK_ANALOGReady = true; } return _TYPE_DOCK_ANALOGContent; } }
        private static int _TYPE_DOCK_ANALOGContent = default;
        private static bool _TYPE_DOCK_ANALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_FM"/>
        /// </summary>
        public static int TYPE_FM { get { if (!_TYPE_FMReady) { _TYPE_FMContent = SGetField<int>(LocalBridgeClazz, "TYPE_FM"); _TYPE_FMReady = true; } return _TYPE_FMContent; } }
        private static int _TYPE_FMContent = default;
        private static bool _TYPE_FMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_FM_TUNER"/>
        /// </summary>
        public static int TYPE_FM_TUNER { get { if (!_TYPE_FM_TUNERReady) { _TYPE_FM_TUNERContent = SGetField<int>(LocalBridgeClazz, "TYPE_FM_TUNER"); _TYPE_FM_TUNERReady = true; } return _TYPE_FM_TUNERContent; } }
        private static int _TYPE_FM_TUNERContent = default;
        private static bool _TYPE_FM_TUNERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_HDMI"/>
        /// </summary>
        public static int TYPE_HDMI { get { if (!_TYPE_HDMIReady) { _TYPE_HDMIContent = SGetField<int>(LocalBridgeClazz, "TYPE_HDMI"); _TYPE_HDMIReady = true; } return _TYPE_HDMIContent; } }
        private static int _TYPE_HDMIContent = default;
        private static bool _TYPE_HDMIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_HDMI_ARC"/>
        /// </summary>
        public static int TYPE_HDMI_ARC { get { if (!_TYPE_HDMI_ARCReady) { _TYPE_HDMI_ARCContent = SGetField<int>(LocalBridgeClazz, "TYPE_HDMI_ARC"); _TYPE_HDMI_ARCReady = true; } return _TYPE_HDMI_ARCContent; } }
        private static int _TYPE_HDMI_ARCContent = default;
        private static bool _TYPE_HDMI_ARCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_HDMI_EARC"/>
        /// </summary>
        public static int TYPE_HDMI_EARC { get { if (!_TYPE_HDMI_EARCReady) { _TYPE_HDMI_EARCContent = SGetField<int>(LocalBridgeClazz, "TYPE_HDMI_EARC"); _TYPE_HDMI_EARCReady = true; } return _TYPE_HDMI_EARCContent; } }
        private static int _TYPE_HDMI_EARCContent = default;
        private static bool _TYPE_HDMI_EARCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_HEARING_AID"/>
        /// </summary>
        public static int TYPE_HEARING_AID { get { if (!_TYPE_HEARING_AIDReady) { _TYPE_HEARING_AIDContent = SGetField<int>(LocalBridgeClazz, "TYPE_HEARING_AID"); _TYPE_HEARING_AIDReady = true; } return _TYPE_HEARING_AIDContent; } }
        private static int _TYPE_HEARING_AIDContent = default;
        private static bool _TYPE_HEARING_AIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_IP"/>
        /// </summary>
        public static int TYPE_IP { get { if (!_TYPE_IPReady) { _TYPE_IPContent = SGetField<int>(LocalBridgeClazz, "TYPE_IP"); _TYPE_IPReady = true; } return _TYPE_IPContent; } }
        private static int _TYPE_IPContent = default;
        private static bool _TYPE_IPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_LINE_ANALOG"/>
        /// </summary>
        public static int TYPE_LINE_ANALOG { get { if (!_TYPE_LINE_ANALOGReady) { _TYPE_LINE_ANALOGContent = SGetField<int>(LocalBridgeClazz, "TYPE_LINE_ANALOG"); _TYPE_LINE_ANALOGReady = true; } return _TYPE_LINE_ANALOGContent; } }
        private static int _TYPE_LINE_ANALOGContent = default;
        private static bool _TYPE_LINE_ANALOGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_LINE_DIGITAL"/>
        /// </summary>
        public static int TYPE_LINE_DIGITAL { get { if (!_TYPE_LINE_DIGITALReady) { _TYPE_LINE_DIGITALContent = SGetField<int>(LocalBridgeClazz, "TYPE_LINE_DIGITAL"); _TYPE_LINE_DIGITALReady = true; } return _TYPE_LINE_DIGITALContent; } }
        private static int _TYPE_LINE_DIGITALContent = default;
        private static bool _TYPE_LINE_DIGITALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_REMOTE_SUBMIX"/>
        /// </summary>
        public static int TYPE_REMOTE_SUBMIX { get { if (!_TYPE_REMOTE_SUBMIXReady) { _TYPE_REMOTE_SUBMIXContent = SGetField<int>(LocalBridgeClazz, "TYPE_REMOTE_SUBMIX"); _TYPE_REMOTE_SUBMIXReady = true; } return _TYPE_REMOTE_SUBMIXContent; } }
        private static int _TYPE_REMOTE_SUBMIXContent = default;
        private static bool _TYPE_REMOTE_SUBMIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_TELEPHONY"/>
        /// </summary>
        public static int TYPE_TELEPHONY { get { if (!_TYPE_TELEPHONYReady) { _TYPE_TELEPHONYContent = SGetField<int>(LocalBridgeClazz, "TYPE_TELEPHONY"); _TYPE_TELEPHONYReady = true; } return _TYPE_TELEPHONYContent; } }
        private static int _TYPE_TELEPHONYContent = default;
        private static bool _TYPE_TELEPHONYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_TV_TUNER"/>
        /// </summary>
        public static int TYPE_TV_TUNER { get { if (!_TYPE_TV_TUNERReady) { _TYPE_TV_TUNERContent = SGetField<int>(LocalBridgeClazz, "TYPE_TV_TUNER"); _TYPE_TV_TUNERReady = true; } return _TYPE_TV_TUNERContent; } }
        private static int _TYPE_TV_TUNERContent = default;
        private static bool _TYPE_TV_TUNERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static int TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static int _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_USB_ACCESSORY"/>
        /// </summary>
        public static int TYPE_USB_ACCESSORY { get { if (!_TYPE_USB_ACCESSORYReady) { _TYPE_USB_ACCESSORYContent = SGetField<int>(LocalBridgeClazz, "TYPE_USB_ACCESSORY"); _TYPE_USB_ACCESSORYReady = true; } return _TYPE_USB_ACCESSORYContent; } }
        private static int _TYPE_USB_ACCESSORYContent = default;
        private static bool _TYPE_USB_ACCESSORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_USB_DEVICE"/>
        /// </summary>
        public static int TYPE_USB_DEVICE { get { if (!_TYPE_USB_DEVICEReady) { _TYPE_USB_DEVICEContent = SGetField<int>(LocalBridgeClazz, "TYPE_USB_DEVICE"); _TYPE_USB_DEVICEReady = true; } return _TYPE_USB_DEVICEContent; } }
        private static int _TYPE_USB_DEVICEContent = default;
        private static bool _TYPE_USB_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_USB_HEADSET"/>
        /// </summary>
        public static int TYPE_USB_HEADSET { get { if (!_TYPE_USB_HEADSETReady) { _TYPE_USB_HEADSETContent = SGetField<int>(LocalBridgeClazz, "TYPE_USB_HEADSET"); _TYPE_USB_HEADSETReady = true; } return _TYPE_USB_HEADSETContent; } }
        private static int _TYPE_USB_HEADSETContent = default;
        private static bool _TYPE_USB_HEADSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_WIRED_HEADPHONES"/>
        /// </summary>
        public static int TYPE_WIRED_HEADPHONES { get { if (!_TYPE_WIRED_HEADPHONESReady) { _TYPE_WIRED_HEADPHONESContent = SGetField<int>(LocalBridgeClazz, "TYPE_WIRED_HEADPHONES"); _TYPE_WIRED_HEADPHONESReady = true; } return _TYPE_WIRED_HEADPHONESContent; } }
        private static int _TYPE_WIRED_HEADPHONESContent = default;
        private static bool _TYPE_WIRED_HEADPHONESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#TYPE_WIRED_HEADSET"/>
        /// </summary>
        public static int TYPE_WIRED_HEADSET { get { if (!_TYPE_WIRED_HEADSETReady) { _TYPE_WIRED_HEADSETContent = SGetField<int>(LocalBridgeClazz, "TYPE_WIRED_HEADSET"); _TYPE_WIRED_HEADSETReady = true; } return _TYPE_WIRED_HEADSETContent; } }
        private static int _TYPE_WIRED_HEADSETContent = default;
        private static bool _TYPE_WIRED_HEADSETReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#isSink()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSink()
        {
            return IExecuteWithSignature<bool>("isSink", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#isSource()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSource()
        {
            return IExecuteWithSignature<bool>("isSource", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getChannelCounts()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetChannelCounts()
        {
            return IExecuteWithSignatureArray<int>("getChannelCounts", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getChannelIndexMasks()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetChannelIndexMasks()
        {
            return IExecuteWithSignatureArray<int>("getChannelIndexMasks", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getChannelMasks()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetChannelMasks()
        {
            return IExecuteWithSignatureArray<int>("getChannelMasks", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getEncapsulationMetadataTypes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetEncapsulationMetadataTypes()
        {
            return IExecuteWithSignatureArray<int>("getEncapsulationMetadataTypes", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getEncapsulationModes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetEncapsulationModes()
        {
            return IExecuteWithSignatureArray<int>("getEncapsulationModes", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getEncodings()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetEncodings()
        {
            return IExecuteWithSignatureArray<int>("getEncodings", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getSampleRates()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetSampleRates()
        {
            return IExecuteWithSignatureArray<int>("getSampleRates", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getProductName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetProductName()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getProductName", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getAudioDescriptors()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.AudioDescriptor> GetAudioDescriptors()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.AudioDescriptor>>("getAudioDescriptors", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/AudioDeviceInfo.html#getAudioProfiles()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Media.AudioProfile> GetAudioProfiles()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Media.AudioProfile>>("getAudioProfiles", "()Ljava/util/List;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}