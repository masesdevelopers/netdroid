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
    #region CellIdentityNr declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html"/>
    /// </summary>
    public partial class CellIdentityNr : Android.Telephony.CellIdentity
    {
        const string _bridgeClassName = "android.telephony.CellIdentityNr";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CellIdentityNr() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CellIdentityNr(params object[] args) : base(args) { }

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

    #region CellIdentityNr implementation
    public partial class CellIdentityNr
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getNrarfcn()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNrarfcn()
        {
            return IExecuteWithSignature<int>("getNrarfcn", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getPci()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPci()
        {
            return IExecuteWithSignature<int>("getPci", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getTac()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTac()
        {
            return IExecuteWithSignature<int>("getTac", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getBands()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetBands()
        {
            return IExecuteWithSignatureArray<int>("getBands", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getMccString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMccString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMccString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getMncString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMncString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMncString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getAdditionalPlmns()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetAdditionalPlmns()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getAdditionalPlmns", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/CellIdentityNr.html#getNci()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetNci()
        {
            return IExecuteWithSignature<long>("getNci", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}