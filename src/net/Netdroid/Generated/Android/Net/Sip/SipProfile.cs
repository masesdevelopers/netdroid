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

namespace Android.Net.Sip
{
    #region SipProfile declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class SipProfile : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SipProfile>
    {
        const string _bridgeClassName = "android.net.sip.SipProfile";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SipProfile() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SipProfile(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.sip.SipProfile$Builder";
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

    #region SipProfile implementation
    public partial class SipProfile : Android.Os.IParcelable, Java.Io.ISerializable, Java.Lang.ICloneable
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Net.Sip.SipProfile"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Net.Sip.SipProfile t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Net.Sip.SipProfile"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Android.Net.Sip.SipProfile t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Android.Net.Sip.SipProfile"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Net.Sip.SipProfile t) => t.Cast<Java.Lang.Cloneable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#CREATOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getAutoRegistration()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetAutoRegistration()
        {
            return IExecuteWithSignature<bool>("getAutoRegistration", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getSendKeepAlive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetSendKeepAlive()
        {
            return IExecuteWithSignature<bool>("getSendKeepAlive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getPort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetPort()
        {
            return IExecuteWithSignature<int>("getPort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getAuthUserName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetAuthUserName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAuthUserName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getDisplayName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetDisplayName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getPassword()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetPassword()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPassword", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getProfileName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetProfileName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProfileName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getProtocol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetProtocol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProtocol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getProxyAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetProxyAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getProxyAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getSipDomain()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetSipDomain()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSipDomain", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getUriString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetUriString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUriString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#getUserName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetUserName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getUserName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#setCallingUid(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetCallingUid(int arg0)
        {
            IExecuteWithSignature("setCallingUid", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#%3Cinit%3E(android.net.sip.SipProfile)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Sip.SipProfile"/></param>
            [global::System.Obsolete()]
            public Builder(Android.Net.Sip.SipProfile arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <exception cref="Java.Text.ParseException"/>
            [global::System.Obsolete()]
            public Builder(Java.Lang.String arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <exception cref="Java.Text.ParseException"/>
            [global::System.Obsolete()]
            public Builder(Java.Lang.String arg0)
                : base(arg0)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Sip.SipProfile"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile Build()
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile>("build", "()Landroid/net/sip/SipProfile;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setAuthUserName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetAuthUserName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setAuthUserName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setAutoRegistration(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetAutoRegistration(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setAutoRegistration", "(Z)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setDisplayName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetDisplayName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setDisplayName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setOutboundProxy(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetOutboundProxy(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setOutboundProxy", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setPassword(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetPassword(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setPassword", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setPort(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            /// <exception cref="Java.Lang.IllegalArgumentException"/>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetPort(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setPort", "(I)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setProfileName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetProfileName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setProfileName", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setProtocol(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            /// <exception cref="Java.Lang.IllegalArgumentException"/>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetProtocol(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setProtocol", "(Ljava/lang/String;)Landroid/net/sip/SipProfile$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/sip/SipProfile.Builder.html#setSendKeepAlive(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Net.Sip.SipProfile.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Net.Sip.SipProfile.Builder SetSendKeepAlive(bool arg0)
            {
                return IExecuteWithSignature<Android.Net.Sip.SipProfile.Builder>("setSendKeepAlive", "(Z)Landroid/net/sip/SipProfile$Builder;", arg0);
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