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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto.Spec
{
    #region RC5ParameterSpec
    public partial class RC5ParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/RC5ParameterSpec.html#%3Cinit%3E(int,int,int,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public RC5ParameterSpec(int arg0, int arg1, int arg2, byte[] arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/RC5ParameterSpec.html#%3Cinit%3E(int,int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        public RC5ParameterSpec(int arg0, int arg1, int arg2, byte[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/RC5ParameterSpec.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public RC5ParameterSpec(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/RC5ParameterSpec.html#getIV()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetIV()
        {
            return IExecuteWithSignatureArray<byte>("getIV", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/RC5ParameterSpec.html#getRounds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRounds()
        {
            return IExecuteWithSignature<int>("getRounds", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/RC5ParameterSpec.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/crypto/spec/RC5ParameterSpec.html#getWordSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWordSize()
        {
            return IExecuteWithSignature<int>("getWordSize", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}