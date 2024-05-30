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

namespace Java.Security.Interfaces
{
    #region IRSAPrivateKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRSAPrivateKey
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/interfaces/RSAPrivateKey.html#getPrivateExponent()"/> 
        /// </summary>
        Java.Math.BigInteger PrivateExponent { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RSAPrivateKey
    public partial class RSAPrivateKey : Java.Security.Interfaces.IRSAPrivateKey, Java.Security.IPrivateKey, Java.Security.Interfaces.IRSAKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.RSAPrivateKey"/> to <see cref="Java.Security.PrivateKey"/>
        /// </summary>
        public static implicit operator Java.Security.PrivateKey(Java.Security.Interfaces.RSAPrivateKey t) => t.Cast<Java.Security.PrivateKey>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Interfaces.RSAPrivateKey"/> to <see cref="Java.Security.Interfaces.RSAKey"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.RSAKey(Java.Security.Interfaces.RSAPrivateKey t) => t.Cast<Java.Security.Interfaces.RSAKey>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/interfaces/RSAPrivateKey.html#getPrivateExponent()"/> 
        /// </summary>
        public Java.Math.BigInteger PrivateExponent
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getPrivateExponent", "()Ljava/math/BigInteger;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}