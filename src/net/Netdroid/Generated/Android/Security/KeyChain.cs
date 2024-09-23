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

namespace Android.Security
{
    #region KeyChain declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/security/KeyChain.html"/>
    /// </summary>
    public partial class KeyChain : MASES.JCOBridge.C2JBridge.JVMBridgeBase<KeyChain>
    {
        const string _bridgeClassName = "android.security.KeyChain";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KeyChain() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KeyChain(params object[] args) : base(args) { }

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

    #region KeyChain implementation
    public partial class KeyChain
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#ACTION_KEY_ACCESS_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_KEY_ACCESS_CHANGED { get { if (!_ACTION_KEY_ACCESS_CHANGEDReady) { _ACTION_KEY_ACCESS_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_KEY_ACCESS_CHANGED"); _ACTION_KEY_ACCESS_CHANGEDReady = true; } return _ACTION_KEY_ACCESS_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_KEY_ACCESS_CHANGEDContent = default;
        private static bool _ACTION_KEY_ACCESS_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#ACTION_KEYCHAIN_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_KEYCHAIN_CHANGED { get { if (!_ACTION_KEYCHAIN_CHANGEDReady) { _ACTION_KEYCHAIN_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_KEYCHAIN_CHANGED"); _ACTION_KEYCHAIN_CHANGEDReady = true; } return _ACTION_KEYCHAIN_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_KEYCHAIN_CHANGEDContent = default;
        private static bool _ACTION_KEYCHAIN_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#ACTION_STORAGE_CHANGED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String ACTION_STORAGE_CHANGED { get { if (!_ACTION_STORAGE_CHANGEDReady) { _ACTION_STORAGE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_STORAGE_CHANGED"); _ACTION_STORAGE_CHANGEDReady = true; } return _ACTION_STORAGE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_STORAGE_CHANGEDContent = default;
        private static bool _ACTION_STORAGE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#ACTION_TRUST_STORE_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_TRUST_STORE_CHANGED { get { if (!_ACTION_TRUST_STORE_CHANGEDReady) { _ACTION_TRUST_STORE_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_TRUST_STORE_CHANGED"); _ACTION_TRUST_STORE_CHANGEDReady = true; } return _ACTION_TRUST_STORE_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_TRUST_STORE_CHANGEDContent = default;
        private static bool _ACTION_TRUST_STORE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#EXTRA_CERTIFICATE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CERTIFICATE { get { if (!_EXTRA_CERTIFICATEReady) { _EXTRA_CERTIFICATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CERTIFICATE"); _EXTRA_CERTIFICATEReady = true; } return _EXTRA_CERTIFICATEContent; } }
        private static Java.Lang.String _EXTRA_CERTIFICATEContent = default;
        private static bool _EXTRA_CERTIFICATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#EXTRA_KEY_ACCESSIBLE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_KEY_ACCESSIBLE { get { if (!_EXTRA_KEY_ACCESSIBLEReady) { _EXTRA_KEY_ACCESSIBLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_KEY_ACCESSIBLE"); _EXTRA_KEY_ACCESSIBLEReady = true; } return _EXTRA_KEY_ACCESSIBLEContent; } }
        private static Java.Lang.String _EXTRA_KEY_ACCESSIBLEContent = default;
        private static bool _EXTRA_KEY_ACCESSIBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#EXTRA_KEY_ALIAS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_KEY_ALIAS { get { if (!_EXTRA_KEY_ALIASReady) { _EXTRA_KEY_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_KEY_ALIAS"); _EXTRA_KEY_ALIASReady = true; } return _EXTRA_KEY_ALIASContent; } }
        private static Java.Lang.String _EXTRA_KEY_ALIASContent = default;
        private static bool _EXTRA_KEY_ALIASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#EXTRA_NAME"/>
        /// </summary>
        public static Java.Lang.String EXTRA_NAME { get { if (!_EXTRA_NAMEReady) { _EXTRA_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_NAME"); _EXTRA_NAMEReady = true; } return _EXTRA_NAMEContent; } }
        private static Java.Lang.String _EXTRA_NAMEContent = default;
        private static bool _EXTRA_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#EXTRA_PKCS12"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PKCS12 { get { if (!_EXTRA_PKCS12Ready) { _EXTRA_PKCS12Content = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PKCS12"); _EXTRA_PKCS12Ready = true; } return _EXTRA_PKCS12Content; } }
        private static Java.Lang.String _EXTRA_PKCS12Content = default;
        private static bool _EXTRA_PKCS12Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#KEY_ALIAS_SELECTION_DENIED"/>
        /// </summary>
        public static Java.Lang.String KEY_ALIAS_SELECTION_DENIED { get { if (!_KEY_ALIAS_SELECTION_DENIEDReady) { _KEY_ALIAS_SELECTION_DENIEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_ALIAS_SELECTION_DENIED"); _KEY_ALIAS_SELECTION_DENIEDReady = true; } return _KEY_ALIAS_SELECTION_DENIEDContent; } }
        private static Java.Lang.String _KEY_ALIAS_SELECTION_DENIEDContent = default;
        private static bool _KEY_ALIAS_SELECTION_DENIEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#createInstallIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public static Android.Content.Intent CreateInstallIntent()
        {
            return SExecuteWithSignature<Android.Content.Intent>(LocalBridgeClazz, "createInstallIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#createManageCredentialsIntent(android.security.AppUriAuthenticationPolicy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Security.AppUriAuthenticationPolicy"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public static Android.Content.Intent CreateManageCredentialsIntent(Android.Security.AppUriAuthenticationPolicy arg0)
        {
            return SExecuteWithSignature<Android.Content.Intent>(LocalBridgeClazz, "createManageCredentialsIntent", "(Landroid/security/AppUriAuthenticationPolicy;)Landroid/content/Intent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#getCredentialManagementAppPolicy(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Security.AppUriAuthenticationPolicy"/></returns>
        /// <exception cref="Java.Lang.SecurityException"/>
        public static Android.Security.AppUriAuthenticationPolicy GetCredentialManagementAppPolicy(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Security.AppUriAuthenticationPolicy>(LocalBridgeClazz, "getCredentialManagementAppPolicy", "(Landroid/content/Context;)Landroid/security/AppUriAuthenticationPolicy;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#isBoundKeyAlgorithm(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public static bool IsBoundKeyAlgorithm(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isBoundKeyAlgorithm", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#isCredentialManagementApp(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsCredentialManagementApp(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isCredentialManagementApp", "(Landroid/content/Context;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#isKeyAlgorithmSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsKeyAlgorithmSupported(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isKeyAlgorithmSupported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#removeCredentialManagementApp(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool RemoveCredentialManagementApp(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "removeCredentialManagementApp", "(Landroid/content/Context;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#getCertificateChain(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.Cert.X509Certificate"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Android.Security.KeyChainException"/>
        public static Java.Security.Cert.X509Certificate[] GetCertificateChain(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            return SExecuteArray<Java.Security.Cert.X509Certificate>(LocalBridgeClazz, "getCertificateChain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#getPrivateKey(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Security.PrivateKey"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        /// <exception cref="Android.Security.KeyChainException"/>
        public static Java.Security.PrivateKey GetPrivateKey(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Security.PrivateKey>(LocalBridgeClazz, "getPrivateKey", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#choosePrivateKeyAlias(android.app.Activity,android.security.KeyChainAliasCallback,java.lang.String[],java.security.Principal[],android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.Security.KeyChainAliasCallback"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Security.Principal"/></param>
        /// <param name="arg4"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        public static void ChoosePrivateKeyAlias(Android.App.Activity arg0, Android.Security.KeyChainAliasCallback arg1, Java.Lang.String[] arg2, Java.Security.Principal[] arg3, Android.Net.Uri arg4, Java.Lang.String arg5)
        {
            SExecute(LocalBridgeClazz, "choosePrivateKeyAlias", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/KeyChain.html#choosePrivateKeyAlias(android.app.Activity,android.security.KeyChainAliasCallback,java.lang.String[],java.security.Principal[],java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.Security.KeyChainAliasCallback"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Security.Principal"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        public static void ChoosePrivateKeyAlias(Android.App.Activity arg0, Android.Security.KeyChainAliasCallback arg1, Java.Lang.String[] arg2, Java.Security.Principal[] arg3, Java.Lang.String arg4, int arg5, Java.Lang.String arg6)
        {
            SExecute(LocalBridgeClazz, "choosePrivateKeyAlias", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}