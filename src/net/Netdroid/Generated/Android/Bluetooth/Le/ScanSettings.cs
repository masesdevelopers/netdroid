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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Bluetooth.Le
{
    #region ScanSettings declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html"/>
    /// </summary>
    public partial class ScanSettings : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.bluetooth.le.ScanSettings";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScanSettings() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScanSettings(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.bluetooth.le.ScanSettings$Builder";
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

    #region ScanSettings implementation
    public partial class ScanSettings
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#CALLBACK_TYPE_ALL_MATCHES"/>
        /// </summary>
        public static int CALLBACK_TYPE_ALL_MATCHES { get { if (!_CALLBACK_TYPE_ALL_MATCHESReady) { _CALLBACK_TYPE_ALL_MATCHESContent = SGetField<int>(LocalBridgeClazz, "CALLBACK_TYPE_ALL_MATCHES"); _CALLBACK_TYPE_ALL_MATCHESReady = true; } return _CALLBACK_TYPE_ALL_MATCHESContent; } }
        private static int _CALLBACK_TYPE_ALL_MATCHESContent = default;
        private static bool _CALLBACK_TYPE_ALL_MATCHESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCH"/>
        /// </summary>
        public static int CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCH { get { if (!_CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCHReady) { _CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCHContent = SGetField<int>(LocalBridgeClazz, "CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCH"); _CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCHReady = true; } return _CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCHContent; } }
        private static int _CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCHContent = default;
        private static bool _CALLBACK_TYPE_ALL_MATCHES_AUTO_BATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#CALLBACK_TYPE_FIRST_MATCH"/>
        /// </summary>
        public static int CALLBACK_TYPE_FIRST_MATCH { get { if (!_CALLBACK_TYPE_FIRST_MATCHReady) { _CALLBACK_TYPE_FIRST_MATCHContent = SGetField<int>(LocalBridgeClazz, "CALLBACK_TYPE_FIRST_MATCH"); _CALLBACK_TYPE_FIRST_MATCHReady = true; } return _CALLBACK_TYPE_FIRST_MATCHContent; } }
        private static int _CALLBACK_TYPE_FIRST_MATCHContent = default;
        private static bool _CALLBACK_TYPE_FIRST_MATCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#CALLBACK_TYPE_MATCH_LOST"/>
        /// </summary>
        public static int CALLBACK_TYPE_MATCH_LOST { get { if (!_CALLBACK_TYPE_MATCH_LOSTReady) { _CALLBACK_TYPE_MATCH_LOSTContent = SGetField<int>(LocalBridgeClazz, "CALLBACK_TYPE_MATCH_LOST"); _CALLBACK_TYPE_MATCH_LOSTReady = true; } return _CALLBACK_TYPE_MATCH_LOSTContent; } }
        private static int _CALLBACK_TYPE_MATCH_LOSTContent = default;
        private static bool _CALLBACK_TYPE_MATCH_LOSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#MATCH_MODE_AGGRESSIVE"/>
        /// </summary>
        public static int MATCH_MODE_AGGRESSIVE { get { if (!_MATCH_MODE_AGGRESSIVEReady) { _MATCH_MODE_AGGRESSIVEContent = SGetField<int>(LocalBridgeClazz, "MATCH_MODE_AGGRESSIVE"); _MATCH_MODE_AGGRESSIVEReady = true; } return _MATCH_MODE_AGGRESSIVEContent; } }
        private static int _MATCH_MODE_AGGRESSIVEContent = default;
        private static bool _MATCH_MODE_AGGRESSIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#MATCH_MODE_STICKY"/>
        /// </summary>
        public static int MATCH_MODE_STICKY { get { if (!_MATCH_MODE_STICKYReady) { _MATCH_MODE_STICKYContent = SGetField<int>(LocalBridgeClazz, "MATCH_MODE_STICKY"); _MATCH_MODE_STICKYReady = true; } return _MATCH_MODE_STICKYContent; } }
        private static int _MATCH_MODE_STICKYContent = default;
        private static bool _MATCH_MODE_STICKYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#MATCH_NUM_FEW_ADVERTISEMENT"/>
        /// </summary>
        public static int MATCH_NUM_FEW_ADVERTISEMENT { get { if (!_MATCH_NUM_FEW_ADVERTISEMENTReady) { _MATCH_NUM_FEW_ADVERTISEMENTContent = SGetField<int>(LocalBridgeClazz, "MATCH_NUM_FEW_ADVERTISEMENT"); _MATCH_NUM_FEW_ADVERTISEMENTReady = true; } return _MATCH_NUM_FEW_ADVERTISEMENTContent; } }
        private static int _MATCH_NUM_FEW_ADVERTISEMENTContent = default;
        private static bool _MATCH_NUM_FEW_ADVERTISEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#MATCH_NUM_MAX_ADVERTISEMENT"/>
        /// </summary>
        public static int MATCH_NUM_MAX_ADVERTISEMENT { get { if (!_MATCH_NUM_MAX_ADVERTISEMENTReady) { _MATCH_NUM_MAX_ADVERTISEMENTContent = SGetField<int>(LocalBridgeClazz, "MATCH_NUM_MAX_ADVERTISEMENT"); _MATCH_NUM_MAX_ADVERTISEMENTReady = true; } return _MATCH_NUM_MAX_ADVERTISEMENTContent; } }
        private static int _MATCH_NUM_MAX_ADVERTISEMENTContent = default;
        private static bool _MATCH_NUM_MAX_ADVERTISEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#MATCH_NUM_ONE_ADVERTISEMENT"/>
        /// </summary>
        public static int MATCH_NUM_ONE_ADVERTISEMENT { get { if (!_MATCH_NUM_ONE_ADVERTISEMENTReady) { _MATCH_NUM_ONE_ADVERTISEMENTContent = SGetField<int>(LocalBridgeClazz, "MATCH_NUM_ONE_ADVERTISEMENT"); _MATCH_NUM_ONE_ADVERTISEMENTReady = true; } return _MATCH_NUM_ONE_ADVERTISEMENTContent; } }
        private static int _MATCH_NUM_ONE_ADVERTISEMENTContent = default;
        private static bool _MATCH_NUM_ONE_ADVERTISEMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#PHY_LE_ALL_SUPPORTED"/>
        /// </summary>
        public static int PHY_LE_ALL_SUPPORTED { get { if (!_PHY_LE_ALL_SUPPORTEDReady) { _PHY_LE_ALL_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "PHY_LE_ALL_SUPPORTED"); _PHY_LE_ALL_SUPPORTEDReady = true; } return _PHY_LE_ALL_SUPPORTEDContent; } }
        private static int _PHY_LE_ALL_SUPPORTEDContent = default;
        private static bool _PHY_LE_ALL_SUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#SCAN_MODE_BALANCED"/>
        /// </summary>
        public static int SCAN_MODE_BALANCED { get { if (!_SCAN_MODE_BALANCEDReady) { _SCAN_MODE_BALANCEDContent = SGetField<int>(LocalBridgeClazz, "SCAN_MODE_BALANCED"); _SCAN_MODE_BALANCEDReady = true; } return _SCAN_MODE_BALANCEDContent; } }
        private static int _SCAN_MODE_BALANCEDContent = default;
        private static bool _SCAN_MODE_BALANCEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#SCAN_MODE_LOW_LATENCY"/>
        /// </summary>
        public static int SCAN_MODE_LOW_LATENCY { get { if (!_SCAN_MODE_LOW_LATENCYReady) { _SCAN_MODE_LOW_LATENCYContent = SGetField<int>(LocalBridgeClazz, "SCAN_MODE_LOW_LATENCY"); _SCAN_MODE_LOW_LATENCYReady = true; } return _SCAN_MODE_LOW_LATENCYContent; } }
        private static int _SCAN_MODE_LOW_LATENCYContent = default;
        private static bool _SCAN_MODE_LOW_LATENCYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#SCAN_MODE_LOW_POWER"/>
        /// </summary>
        public static int SCAN_MODE_LOW_POWER { get { if (!_SCAN_MODE_LOW_POWERReady) { _SCAN_MODE_LOW_POWERContent = SGetField<int>(LocalBridgeClazz, "SCAN_MODE_LOW_POWER"); _SCAN_MODE_LOW_POWERReady = true; } return _SCAN_MODE_LOW_POWERContent; } }
        private static int _SCAN_MODE_LOW_POWERContent = default;
        private static bool _SCAN_MODE_LOW_POWERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#SCAN_MODE_OPPORTUNISTIC"/>
        /// </summary>
        public static int SCAN_MODE_OPPORTUNISTIC { get { if (!_SCAN_MODE_OPPORTUNISTICReady) { _SCAN_MODE_OPPORTUNISTICContent = SGetField<int>(LocalBridgeClazz, "SCAN_MODE_OPPORTUNISTIC"); _SCAN_MODE_OPPORTUNISTICReady = true; } return _SCAN_MODE_OPPORTUNISTICContent; } }
        private static int _SCAN_MODE_OPPORTUNISTICContent = default;
        private static bool _SCAN_MODE_OPPORTUNISTICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#AUTO_BATCH_MIN_REPORT_DELAY_MILLIS"/>
        /// </summary>
        public static long AUTO_BATCH_MIN_REPORT_DELAY_MILLIS { get { if (!_AUTO_BATCH_MIN_REPORT_DELAY_MILLISReady) { _AUTO_BATCH_MIN_REPORT_DELAY_MILLISContent = SGetField<long>(LocalBridgeClazz, "AUTO_BATCH_MIN_REPORT_DELAY_MILLIS"); _AUTO_BATCH_MIN_REPORT_DELAY_MILLISReady = true; } return _AUTO_BATCH_MIN_REPORT_DELAY_MILLISContent; } }
        private static long _AUTO_BATCH_MIN_REPORT_DELAY_MILLISContent = default;
        private static bool _AUTO_BATCH_MIN_REPORT_DELAY_MILLISReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#getLegacy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetLegacy()
        {
            return IExecuteWithSignature<bool>("getLegacy", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#getCallbackType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCallbackType()
        {
            return IExecuteWithSignature<int>("getCallbackType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#getPhy()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPhy()
        {
            return IExecuteWithSignature<int>("getPhy", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#getScanMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScanMode()
        {
            return IExecuteWithSignature<int>("getScanMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#getScanResultType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScanResultType()
        {
            return IExecuteWithSignature<int>("getScanResultType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#getReportDelayMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetReportDelayMillis()
        {
            return IExecuteWithSignature<long>("getReportDelayMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
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
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings"/></returns>
            public Android.Bluetooth.Le.ScanSettings Build()
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings>("build", "()Landroid/bluetooth/le/ScanSettings;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#setCallbackType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings.Builder"/></returns>
            public Android.Bluetooth.Le.ScanSettings.Builder SetCallbackType(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings.Builder>("setCallbackType", "(I)Landroid/bluetooth/le/ScanSettings$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#setLegacy(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings.Builder"/></returns>
            public Android.Bluetooth.Le.ScanSettings.Builder SetLegacy(bool arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings.Builder>("setLegacy", "(Z)Landroid/bluetooth/le/ScanSettings$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#setMatchMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings.Builder"/></returns>
            public Android.Bluetooth.Le.ScanSettings.Builder SetMatchMode(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings.Builder>("setMatchMode", "(I)Landroid/bluetooth/le/ScanSettings$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#setNumOfMatches(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings.Builder"/></returns>
            public Android.Bluetooth.Le.ScanSettings.Builder SetNumOfMatches(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings.Builder>("setNumOfMatches", "(I)Landroid/bluetooth/le/ScanSettings$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#setPhy(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings.Builder"/></returns>
            public Android.Bluetooth.Le.ScanSettings.Builder SetPhy(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings.Builder>("setPhy", "(I)Landroid/bluetooth/le/ScanSettings$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#setReportDelay(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings.Builder"/></returns>
            public Android.Bluetooth.Le.ScanSettings.Builder SetReportDelay(long arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings.Builder>("setReportDelay", "(J)Landroid/bluetooth/le/ScanSettings$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/bluetooth/le/ScanSettings.Builder.html#setScanMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Bluetooth.Le.ScanSettings.Builder"/></returns>
            public Android.Bluetooth.Le.ScanSettings.Builder SetScanMode(int arg0)
            {
                return IExecuteWithSignature<Android.Bluetooth.Le.ScanSettings.Builder>("setScanMode", "(I)Landroid/bluetooth/le/ScanSettings$Builder;", arg0);
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