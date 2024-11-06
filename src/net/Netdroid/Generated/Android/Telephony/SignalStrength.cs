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

namespace Android.Telephony
{
    #region SignalStrength declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html"/>
    /// </summary>
    public partial class SignalStrength : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.telephony.SignalStrength";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SignalStrength() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SignalStrength(params object[] args) : base(args) { }
    
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

    #region SignalStrength implementation
    public partial class SignalStrength
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#%3Cinit%3E(android.telephony.SignalStrength)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telephony.SignalStrength"/></param>
        public SignalStrength(Android.Telephony.SignalStrength arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#INVALID"/>
        /// </summary>
        public static int INVALID { get { if (!_INVALIDReady) { _INVALIDContent = SGetField<int>(LocalBridgeClazz, "INVALID"); _INVALIDReady = true; } return _INVALIDContent; } }
        private static int _INVALIDContent = default;
        private static bool _INVALIDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getCellSignalStrengths(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Android.Telephony.CellSignalStrength"/></typeparam>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> GetCellSignalStrengths<T>(Java.Lang.Class arg0) where T : Android.Telephony.CellSignalStrength
        {
            return IExecuteWithSignature<Java.Util.List<T>>("getCellSignalStrengths", "(Ljava/lang/Class;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#isGsm()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsGsm()
        {
            return IExecuteWithSignature<bool>("isGsm", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getCdmaDbm()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetCdmaDbm()
        {
            return IExecuteWithSignature<int>("getCdmaDbm", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getCdmaEcio()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetCdmaEcio()
        {
            return IExecuteWithSignature<int>("getCdmaEcio", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getEvdoDbm()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetEvdoDbm()
        {
            return IExecuteWithSignature<int>("getEvdoDbm", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getEvdoEcio()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetEvdoEcio()
        {
            return IExecuteWithSignature<int>("getEvdoEcio", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getEvdoSnr()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetEvdoSnr()
        {
            return IExecuteWithSignature<int>("getEvdoSnr", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getGsmBitErrorRate()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetGsmBitErrorRate()
        {
            return IExecuteWithSignature<int>("getGsmBitErrorRate", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getGsmSignalStrength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetGsmSignalStrength()
        {
            return IExecuteWithSignature<int>("getGsmSignalStrength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getLevel()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLevel()
        {
            return IExecuteWithSignature<int>("getLevel", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getCellSignalStrengths()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Telephony.CellSignalStrength> GetCellSignalStrengths()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Telephony.CellSignalStrength>>("getCellSignalStrengths", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#getTimestampMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimestampMillis()
        {
            return IExecuteWithSignature<long>("getTimestampMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/SignalStrength.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}