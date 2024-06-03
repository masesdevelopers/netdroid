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

namespace Javax.Net.Ssl
{
    #region KeyManagerFactory
    public partial class KeyManagerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#getDefaultAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetDefaultAlgorithm()
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getDefaultAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Net.Ssl.KeyManagerFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Net.Ssl.KeyManagerFactory GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Net.Ssl.KeyManagerFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Net.Ssl.KeyManagerFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Net.Ssl.KeyManagerFactory GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Net.Ssl.KeyManagerFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Net.Ssl.KeyManagerFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Net.Ssl.KeyManagerFactory GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Net.Ssl.KeyManagerFactory>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/net/ssl/KeyManagerFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#getAlgorithm()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAlgorithm()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#getProvider()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Provider"/></returns>
        public Java.Security.Provider GetProvider()
        {
            return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#getKeyManagers()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.KeyManager"/></returns>
        public Javax.Net.Ssl.KeyManager[] GetKeyManagers()
        {
            return IExecuteWithSignatureArray<Javax.Net.Ssl.KeyManager>("getKeyManagers", "()[Ljavax/net/ssl/KeyManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#init(java.security.KeyStore,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.UnrecoverableKeyException"/>
        public void Init(Java.Security.KeyStore arg0, char[] arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/KeyManagerFactory.html#init(javax.net.ssl.ManagerFactoryParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.ManagerFactoryParameters"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(Javax.Net.Ssl.ManagerFactoryParameters arg0)
        {
            IExecuteWithSignature("init", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}