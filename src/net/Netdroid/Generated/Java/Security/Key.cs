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

namespace Java.Security
{
    #region IKey
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IKey : Java.Io.ISerializable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Key
    public partial class Key : Java.Security.IKey
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/Key.html#getAlgorithm()"/> 
        /// </summary>
        public Java.Lang.String Algorithm
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAlgorithm", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/Key.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteWithSignatureArray<byte>("getEncoded", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/security/Key.html#getFormat()"/> 
        /// </summary>
        public Java.Lang.String Format
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}