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

namespace Android.Telecom
{
    #region PhoneAccountSuggestion declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html"/>
    /// </summary>
    public partial class PhoneAccountSuggestion : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.telecom.PhoneAccountSuggestion";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PhoneAccountSuggestion() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PhoneAccountSuggestion(params object[] args) : base(args) { }

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

    #region PhoneAccountSuggestion implementation
    public partial class PhoneAccountSuggestion
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#%3Cinit%3E(android.telecom.PhoneAccountHandle,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Telecom.PhoneAccountHandle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public PhoneAccountSuggestion(Android.Telecom.PhoneAccountHandle arg0, int arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#REASON_FREQUENT"/>
        /// </summary>
        public static int REASON_FREQUENT { get { if (!_REASON_FREQUENTReady) { _REASON_FREQUENTContent = SGetField<int>(LocalBridgeClazz, "REASON_FREQUENT"); _REASON_FREQUENTReady = true; } return _REASON_FREQUENTContent; } }
        private static int _REASON_FREQUENTContent = default;
        private static bool _REASON_FREQUENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#REASON_INTRA_CARRIER"/>
        /// </summary>
        public static int REASON_INTRA_CARRIER { get { if (!_REASON_INTRA_CARRIERReady) { _REASON_INTRA_CARRIERContent = SGetField<int>(LocalBridgeClazz, "REASON_INTRA_CARRIER"); _REASON_INTRA_CARRIERReady = true; } return _REASON_INTRA_CARRIERContent; } }
        private static int _REASON_INTRA_CARRIERContent = default;
        private static bool _REASON_INTRA_CARRIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#REASON_NONE"/>
        /// </summary>
        public static int REASON_NONE { get { if (!_REASON_NONEReady) { _REASON_NONEContent = SGetField<int>(LocalBridgeClazz, "REASON_NONE"); _REASON_NONEReady = true; } return _REASON_NONEContent; } }
        private static int _REASON_NONEContent = default;
        private static bool _REASON_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#REASON_OTHER"/>
        /// </summary>
        public static int REASON_OTHER { get { if (!_REASON_OTHERReady) { _REASON_OTHERContent = SGetField<int>(LocalBridgeClazz, "REASON_OTHER"); _REASON_OTHERReady = true; } return _REASON_OTHERContent; } }
        private static int _REASON_OTHERContent = default;
        private static bool _REASON_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#REASON_USER_SET"/>
        /// </summary>
        public static int REASON_USER_SET { get { if (!_REASON_USER_SETReady) { _REASON_USER_SETContent = SGetField<int>(LocalBridgeClazz, "REASON_USER_SET"); _REASON_USER_SETReady = true; } return _REASON_USER_SETContent; } }
        private static int _REASON_USER_SETContent = default;
        private static bool _REASON_USER_SETReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#getPhoneAccountHandle()"/>
        /// </summary>
        /// <returns><see cref="Android.Telecom.PhoneAccountHandle"/></returns>
        public Android.Telecom.PhoneAccountHandle GetPhoneAccountHandle()
        {
            return IExecuteWithSignature<Android.Telecom.PhoneAccountHandle>("getPhoneAccountHandle", "()Landroid/telecom/PhoneAccountHandle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#shouldAutoSelect()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldAutoSelect()
        {
            return IExecuteWithSignature<bool>("shouldAutoSelect", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#getReason()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReason()
        {
            return IExecuteWithSignature<int>("getReason", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telecom/PhoneAccountSuggestion.html#writeToParcel(android.os.Parcel,int)"/>
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