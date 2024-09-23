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

namespace Android.Accounts
{
    #region AbstractAccountAuthenticator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html"/>
    /// </summary>
    public partial class AbstractAccountAuthenticator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AbstractAccountAuthenticator>
    {
        const string _bridgeClassName = "android.accounts.AbstractAccountAuthenticator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AbstractAccountAuthenticator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractAccountAuthenticator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AbstractAccountAuthenticator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AbstractAccountAuthenticator(params object[] args) : base(args) { }

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

    #region AbstractAccountAuthenticator implementation
    public partial class AbstractAccountAuthenticator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public AbstractAccountAuthenticator(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#KEY_CUSTOM_TOKEN_EXPIRY"/>
        /// </summary>
        public static Java.Lang.String KEY_CUSTOM_TOKEN_EXPIRY { get { if (!_KEY_CUSTOM_TOKEN_EXPIRYReady) { _KEY_CUSTOM_TOKEN_EXPIRYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_CUSTOM_TOKEN_EXPIRY"); _KEY_CUSTOM_TOKEN_EXPIRYReady = true; } return _KEY_CUSTOM_TOKEN_EXPIRYContent; } }
        private static Java.Lang.String _KEY_CUSTOM_TOKEN_EXPIRYContent = default;
        private static bool _KEY_CUSTOM_TOKEN_EXPIRYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#addAccount(android.accounts.AccountAuthenticatorResponse,java.lang.String,java.lang.String,java.lang.String[],android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle AddAccount(Android.Accounts.AccountAuthenticatorResponse arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String[] arg3, Android.Os.Bundle arg4)
        {
            return IExecute<Android.Os.Bundle>("addAccount", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#confirmCredentials(android.accounts.AccountAuthenticatorResponse,android.accounts.Account,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle ConfirmCredentials(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1, Android.Os.Bundle arg2)
        {
            return IExecute<Android.Os.Bundle>("confirmCredentials", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#editProperties(android.accounts.AccountAuthenticatorResponse,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle EditProperties(Android.Accounts.AccountAuthenticatorResponse arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.Os.Bundle>("editProperties", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#getAuthToken(android.accounts.AccountAuthenticatorResponse,android.accounts.Account,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle GetAuthToken(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1, Java.Lang.String arg2, Android.Os.Bundle arg3)
        {
            return IExecute<Android.Os.Bundle>("getAuthToken", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#hasFeatures(android.accounts.AccountAuthenticatorResponse,android.accounts.Account,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle HasFeatures(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1, Java.Lang.String[] arg2)
        {
            return IExecute<Android.Os.Bundle>("hasFeatures", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#updateCredentials(android.accounts.AccountAuthenticatorResponse,android.accounts.Account,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle UpdateCredentials(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1, Java.Lang.String arg2, Android.Os.Bundle arg3)
        {
            return IExecute<Android.Os.Bundle>("updateCredentials", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#getAuthTokenLabel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAuthTokenLabel(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#addAccountFromCredentials(android.accounts.AccountAuthenticatorResponse,android.accounts.Account,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle AddAccountFromCredentials(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1, Android.Os.Bundle arg2)
        {
            return IExecute<Android.Os.Bundle>("addAccountFromCredentials", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#finishSession(android.accounts.AccountAuthenticatorResponse,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle FinishSession(Android.Accounts.AccountAuthenticatorResponse arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
        {
            return IExecute<Android.Os.Bundle>("finishSession", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#getAccountCredentialsForCloning(android.accounts.AccountAuthenticatorResponse,android.accounts.Account)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle GetAccountCredentialsForCloning(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1)
        {
            return IExecute<Android.Os.Bundle>("getAccountCredentialsForCloning", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#getAccountRemovalAllowed(android.accounts.AccountAuthenticatorResponse,android.accounts.Account)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle GetAccountRemovalAllowed(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1)
        {
            return IExecute<Android.Os.Bundle>("getAccountRemovalAllowed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#isCredentialsUpdateSuggested(android.accounts.AccountAuthenticatorResponse,android.accounts.Account,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle IsCredentialsUpdateSuggested(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1, Java.Lang.String arg2)
        {
            return IExecute<Android.Os.Bundle>("isCredentialsUpdateSuggested", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#startAddAccountSession(android.accounts.AccountAuthenticatorResponse,java.lang.String,java.lang.String,java.lang.String[],android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle StartAddAccountSession(Android.Accounts.AccountAuthenticatorResponse arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String[] arg3, Android.Os.Bundle arg4)
        {
            return IExecute<Android.Os.Bundle>("startAddAccountSession", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#startUpdateCredentialsSession(android.accounts.AccountAuthenticatorResponse,android.accounts.Account,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Accounts.AccountAuthenticatorResponse"/></param>
        /// <param name="arg1"><see cref="Android.Accounts.Account"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Accounts.NetworkErrorException"/>
        public Android.Os.Bundle StartUpdateCredentialsSession(Android.Accounts.AccountAuthenticatorResponse arg0, Android.Accounts.Account arg1, Java.Lang.String arg2, Android.Os.Bundle arg3)
        {
            return IExecute<Android.Os.Bundle>("startUpdateCredentialsSession", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accounts/AbstractAccountAuthenticator.html#getIBinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.IBinder"/></returns>
        public Android.Os.IBinder GetIBinder()
        {
            return IExecuteWithSignature<Android.Os.IBinder>("getIBinder", "()Landroid/os/IBinder;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}