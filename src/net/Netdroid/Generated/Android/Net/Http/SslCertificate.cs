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

namespace Android.Net.Http
{
    #region SslCertificate declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html"/>
    /// </summary>
    public partial class SslCertificate : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SslCertificate>
    {
        const string _bridgeClassName = "android.net.http.SslCertificate";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SslCertificate() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SslCertificate(params object[] args) : base(args) { }
    
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
        #region DName declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.DName.html"/>
        /// </summary>
        public partial class DName : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DName>
        {
            const string _bridgeClassName = "android.net.http.SslCertificate$DName";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public DName() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public DName(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region SslCertificate implementation
    public partial class SslCertificate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public SslCertificate(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#%3Cinit%3E(java.lang.String,java.lang.String,java.util.Date,java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Date"/></param>
        /// <param name="arg3"><see cref="Java.Util.Date"/></param>
        [global::System.Obsolete()]
        public SslCertificate(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.Date arg2, Java.Util.Date arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#%3Cinit%3E(java.security.cert.X509Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        public SslCertificate(Java.Security.Cert.X509Certificate arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#restoreState(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Net.Http.SslCertificate"/></returns>
        public static Android.Net.Http.SslCertificate RestoreState(Android.Os.Bundle arg0)
        {
            return SExecuteWithSignature<Android.Net.Http.SslCertificate>(LocalBridgeClazz, "restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#saveState(android.net.http.SslCertificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Http.SslCertificate"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public static Android.Os.Bundle SaveState(Android.Net.Http.SslCertificate arg0)
        {
            return SExecuteWithSignature<Android.Os.Bundle>(LocalBridgeClazz, "saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#getIssuedBy()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Http.SslCertificate.DName"/></returns>
        public Android.Net.Http.SslCertificate.DName GetIssuedBy()
        {
            return IExecuteWithSignature<Android.Net.Http.SslCertificate.DName>("getIssuedBy", "()Landroid/net/http/SslCertificate$DName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#getIssuedTo()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Http.SslCertificate.DName"/></returns>
        public Android.Net.Http.SslCertificate.DName GetIssuedTo()
        {
            return IExecuteWithSignature<Android.Net.Http.SslCertificate.DName>("getIssuedTo", "()Landroid/net/http/SslCertificate$DName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#getValidNotAfter()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetValidNotAfter()
        {
            return IExecuteWithSignature<Java.Lang.String>("getValidNotAfter", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#getValidNotBefore()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetValidNotBefore()
        {
            return IExecuteWithSignature<Java.Lang.String>("getValidNotBefore", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#getX509Certificate()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Cert.X509Certificate"/></returns>
        public Java.Security.Cert.X509Certificate GetX509Certificate()
        {
            return IExecuteWithSignature<Java.Security.Cert.X509Certificate>("getX509Certificate", "()Ljava/security/cert/X509Certificate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#getValidNotAfterDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetValidNotAfterDate()
        {
            return IExecuteWithSignature<Java.Util.Date>("getValidNotAfterDate", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.html#getValidNotBeforeDate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date GetValidNotBeforeDate()
        {
            return IExecuteWithSignature<Java.Util.Date>("getValidNotBeforeDate", "()Ljava/util/Date;");
        }
    
        #endregion
    
        #region Nested classes
        #region DName implementation
        public partial class DName
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.DName.html#%3Cinit%3E(android.net.http.SslCertificate,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Http.SslCertificate"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public DName(Android.Net.Http.SslCertificate arg0, Java.Lang.String arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.DName.html#getCName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetCName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getCName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.DName.html#getDName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.DName.html#getOName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetOName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getOName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/SslCertificate.DName.html#getUName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetUName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getUName", "()Ljava/lang/String;");
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