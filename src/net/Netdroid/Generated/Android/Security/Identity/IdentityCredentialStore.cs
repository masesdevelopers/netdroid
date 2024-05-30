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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Security.Identity
{
    #region IdentityCredentialStore
    public partial class IdentityCredentialStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredentialStore.html#CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256"/>
        /// </summary>
        public static int CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256 { get { if (!_CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256Ready) { _CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256Content = SGetField<int>(LocalBridgeClazz, "CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256"); _CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256Ready = true; } return _CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256Content; } }
        private static int _CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256Content = default;
        private static bool _CIPHERSUITE_ECDHE_HKDF_ECDSA_WITH_AES_256_GCM_SHA256Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredentialStore.html#getDirectAccessInstance(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Security.Identity.IdentityCredentialStore"/></returns>
        public static Android.Security.Identity.IdentityCredentialStore GetDirectAccessInstance(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Security.Identity.IdentityCredentialStore>(LocalBridgeClazz, "getDirectAccessInstance", "(Landroid/content/Context;)Landroid/security/identity/IdentityCredentialStore;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredentialStore.html#getInstance(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Security.Identity.IdentityCredentialStore"/></returns>
        public static Android.Security.Identity.IdentityCredentialStore GetInstance(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Security.Identity.IdentityCredentialStore>(LocalBridgeClazz, "getInstance", "(Landroid/content/Context;)Landroid/security/identity/IdentityCredentialStore;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredentialStore.html#getSupportedDocTypes()"/> 
        /// </summary>
        public Java.Lang.String[] SupportedDocTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedDocTypes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredentialStore.html#getCredentialByName(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Security.Identity.IdentityCredential"/></returns>
        /// <exception cref="Android.Security.Identity.CipherSuiteNotSupportedException"/>
        public Android.Security.Identity.IdentityCredential GetCredentialByName(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Android.Security.Identity.IdentityCredential>("getCredentialByName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredentialStore.html#createCredential(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Security.Identity.WritableIdentityCredential"/></returns>
        /// <exception cref="Android.Security.Identity.AlreadyPersonalizedException"/>
        /// <exception cref="Android.Security.Identity.DocTypeNotSupportedException"/>
        public Android.Security.Identity.WritableIdentityCredential CreateCredential(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.Security.Identity.WritableIdentityCredential>("createCredential", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/identity/IdentityCredentialStore.html#createPresentationSession(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Security.Identity.PresentationSession"/></returns>
        /// <exception cref="Android.Security.Identity.CipherSuiteNotSupportedException"/>
        public Android.Security.Identity.PresentationSession CreatePresentationSession(int arg0)
        {
            return IExecuteWithSignature<Android.Security.Identity.PresentationSession>("createPresentationSession", "(I)Landroid/security/identity/PresentationSession;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}