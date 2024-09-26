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

namespace Android.Telephony
{
    #region CellInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html"/>
    /// </summary>
    public partial class CellInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.telephony.CellInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CellInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CellInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CellInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CellInfo(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region CellInfo implementation
    public partial class CellInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#CONNECTION_NONE"/>
        /// </summary>
        public static int CONNECTION_NONE { get { if (!_CONNECTION_NONEReady) { _CONNECTION_NONEContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_NONE"); _CONNECTION_NONEReady = true; } return _CONNECTION_NONEContent; } }
        private static int _CONNECTION_NONEContent = default;
        private static bool _CONNECTION_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#CONNECTION_PRIMARY_SERVING"/>
        /// </summary>
        public static int CONNECTION_PRIMARY_SERVING { get { if (!_CONNECTION_PRIMARY_SERVINGReady) { _CONNECTION_PRIMARY_SERVINGContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_PRIMARY_SERVING"); _CONNECTION_PRIMARY_SERVINGReady = true; } return _CONNECTION_PRIMARY_SERVINGContent; } }
        private static int _CONNECTION_PRIMARY_SERVINGContent = default;
        private static bool _CONNECTION_PRIMARY_SERVINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#CONNECTION_SECONDARY_SERVING"/>
        /// </summary>
        public static int CONNECTION_SECONDARY_SERVING { get { if (!_CONNECTION_SECONDARY_SERVINGReady) { _CONNECTION_SECONDARY_SERVINGContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_SECONDARY_SERVING"); _CONNECTION_SECONDARY_SERVINGReady = true; } return _CONNECTION_SECONDARY_SERVINGContent; } }
        private static int _CONNECTION_SECONDARY_SERVINGContent = default;
        private static bool _CONNECTION_SECONDARY_SERVINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#CONNECTION_UNKNOWN"/>
        /// </summary>
        public static int CONNECTION_UNKNOWN { get { if (!_CONNECTION_UNKNOWNReady) { _CONNECTION_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "CONNECTION_UNKNOWN"); _CONNECTION_UNKNOWNReady = true; } return _CONNECTION_UNKNOWNContent; } }
        private static int _CONNECTION_UNKNOWNContent = default;
        private static bool _CONNECTION_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#UNAVAILABLE"/>
        /// </summary>
        public static int UNAVAILABLE { get { if (!_UNAVAILABLEReady) { _UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "UNAVAILABLE"); _UNAVAILABLEReady = true; } return _UNAVAILABLEContent; } }
        private static int _UNAVAILABLEContent = default;
        private static bool _UNAVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#UNAVAILABLE_LONG"/>
        /// </summary>
        public static long UNAVAILABLE_LONG { get { if (!_UNAVAILABLE_LONGReady) { _UNAVAILABLE_LONGContent = SGetField<long>(LocalBridgeClazz, "UNAVAILABLE_LONG"); _UNAVAILABLE_LONGReady = true; } return _UNAVAILABLE_LONGContent; } }
        private static long _UNAVAILABLE_LONGContent = default;
        private static bool _UNAVAILABLE_LONGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#getCellIdentity()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.CellIdentity"/></returns>
        public Android.Telephony.CellIdentity GetCellIdentity()
        {
            return IExecuteWithSignature<Android.Telephony.CellIdentity>("getCellIdentity", "()Landroid/telephony/CellIdentity;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#getCellSignalStrength()"/>
        /// </summary>
        /// <returns><see cref="Android.Telephony.CellSignalStrength"/></returns>
        public Android.Telephony.CellSignalStrength GetCellSignalStrength()
        {
            return IExecuteWithSignature<Android.Telephony.CellSignalStrength>("getCellSignalStrength", "()Landroid/telephony/CellSignalStrength;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#isRegistered()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRegistered()
        {
            return IExecuteWithSignature<bool>("isRegistered", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#getCellConnectionStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCellConnectionStatus()
        {
            return IExecuteWithSignature<int>("getCellConnectionStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#getTimeStamp()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetTimeStamp()
        {
            return IExecuteWithSignature<long>("getTimeStamp", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellInfo.html#getTimestampMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimestampMillis()
        {
            return IExecuteWithSignature<long>("getTimestampMillis", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}