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

namespace Android.Net
{
    #region IpSecAlgorithm declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html"/>
    /// </summary>
    public partial class IpSecAlgorithm : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.IpSecAlgorithm";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IpSecAlgorithm() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IpSecAlgorithm(params object[] args) : base(args) { }
    
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

    #region IpSecAlgorithm implementation
    public partial class IpSecAlgorithm
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#%3Cinit%3E(java.lang.String,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public IpSecAlgorithm(Java.Lang.String arg0, byte[] arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#%3Cinit%3E(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public IpSecAlgorithm(Java.Lang.String arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_AES_CMAC"/>
        /// </summary>
        public static Java.Lang.String AUTH_AES_CMAC { get { if (!_AUTH_AES_CMACReady) { _AUTH_AES_CMACContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_AES_CMAC"); _AUTH_AES_CMACReady = true; } return _AUTH_AES_CMACContent; } }
        private static Java.Lang.String _AUTH_AES_CMACContent = default;
        private static bool _AUTH_AES_CMACReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_AES_XCBC"/>
        /// </summary>
        public static Java.Lang.String AUTH_AES_XCBC { get { if (!_AUTH_AES_XCBCReady) { _AUTH_AES_XCBCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_AES_XCBC"); _AUTH_AES_XCBCReady = true; } return _AUTH_AES_XCBCContent; } }
        private static Java.Lang.String _AUTH_AES_XCBCContent = default;
        private static bool _AUTH_AES_XCBCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_CRYPT_AES_GCM"/>
        /// </summary>
        public static Java.Lang.String AUTH_CRYPT_AES_GCM { get { if (!_AUTH_CRYPT_AES_GCMReady) { _AUTH_CRYPT_AES_GCMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_CRYPT_AES_GCM"); _AUTH_CRYPT_AES_GCMReady = true; } return _AUTH_CRYPT_AES_GCMContent; } }
        private static Java.Lang.String _AUTH_CRYPT_AES_GCMContent = default;
        private static bool _AUTH_CRYPT_AES_GCMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_CRYPT_CHACHA20_POLY1305"/>
        /// </summary>
        public static Java.Lang.String AUTH_CRYPT_CHACHA20_POLY1305 { get { if (!_AUTH_CRYPT_CHACHA20_POLY1305Ready) { _AUTH_CRYPT_CHACHA20_POLY1305Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_CRYPT_CHACHA20_POLY1305"); _AUTH_CRYPT_CHACHA20_POLY1305Ready = true; } return _AUTH_CRYPT_CHACHA20_POLY1305Content; } }
        private static Java.Lang.String _AUTH_CRYPT_CHACHA20_POLY1305Content = default;
        private static bool _AUTH_CRYPT_CHACHA20_POLY1305Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_HMAC_MD5"/>
        /// </summary>
        public static Java.Lang.String AUTH_HMAC_MD5 { get { if (!_AUTH_HMAC_MD5Ready) { _AUTH_HMAC_MD5Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_HMAC_MD5"); _AUTH_HMAC_MD5Ready = true; } return _AUTH_HMAC_MD5Content; } }
        private static Java.Lang.String _AUTH_HMAC_MD5Content = default;
        private static bool _AUTH_HMAC_MD5Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_HMAC_SHA1"/>
        /// </summary>
        public static Java.Lang.String AUTH_HMAC_SHA1 { get { if (!_AUTH_HMAC_SHA1Ready) { _AUTH_HMAC_SHA1Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_HMAC_SHA1"); _AUTH_HMAC_SHA1Ready = true; } return _AUTH_HMAC_SHA1Content; } }
        private static Java.Lang.String _AUTH_HMAC_SHA1Content = default;
        private static bool _AUTH_HMAC_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_HMAC_SHA256"/>
        /// </summary>
        public static Java.Lang.String AUTH_HMAC_SHA256 { get { if (!_AUTH_HMAC_SHA256Ready) { _AUTH_HMAC_SHA256Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_HMAC_SHA256"); _AUTH_HMAC_SHA256Ready = true; } return _AUTH_HMAC_SHA256Content; } }
        private static Java.Lang.String _AUTH_HMAC_SHA256Content = default;
        private static bool _AUTH_HMAC_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_HMAC_SHA384"/>
        /// </summary>
        public static Java.Lang.String AUTH_HMAC_SHA384 { get { if (!_AUTH_HMAC_SHA384Ready) { _AUTH_HMAC_SHA384Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_HMAC_SHA384"); _AUTH_HMAC_SHA384Ready = true; } return _AUTH_HMAC_SHA384Content; } }
        private static Java.Lang.String _AUTH_HMAC_SHA384Content = default;
        private static bool _AUTH_HMAC_SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#AUTH_HMAC_SHA512"/>
        /// </summary>
        public static Java.Lang.String AUTH_HMAC_SHA512 { get { if (!_AUTH_HMAC_SHA512Ready) { _AUTH_HMAC_SHA512Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTH_HMAC_SHA512"); _AUTH_HMAC_SHA512Ready = true; } return _AUTH_HMAC_SHA512Content; } }
        private static Java.Lang.String _AUTH_HMAC_SHA512Content = default;
        private static bool _AUTH_HMAC_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#CRYPT_AES_CBC"/>
        /// </summary>
        public static Java.Lang.String CRYPT_AES_CBC { get { if (!_CRYPT_AES_CBCReady) { _CRYPT_AES_CBCContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CRYPT_AES_CBC"); _CRYPT_AES_CBCReady = true; } return _CRYPT_AES_CBCContent; } }
        private static Java.Lang.String _CRYPT_AES_CBCContent = default;
        private static bool _CRYPT_AES_CBCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#CRYPT_AES_CTR"/>
        /// </summary>
        public static Java.Lang.String CRYPT_AES_CTR { get { if (!_CRYPT_AES_CTRReady) { _CRYPT_AES_CTRContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CRYPT_AES_CTR"); _CRYPT_AES_CTRReady = true; } return _CRYPT_AES_CTRContent; } }
        private static Java.Lang.String _CRYPT_AES_CTRContent = default;
        private static bool _CRYPT_AES_CTRReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#getSupportedAlgorithms()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.String> GetSupportedAlgorithms()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "getSupportedAlgorithms", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#getKey()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetKey()
        {
            return IExecuteWithSignatureArray<byte>("getKey", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#getTruncationLengthBits()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTruncationLengthBits()
        {
            return IExecuteWithSignature<int>("getTruncationLengthBits", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecAlgorithm.html#writeToParcel(android.os.Parcel,int)"/>
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