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

namespace Android.Icu.Text
{
    #region BidiRun
    public partial class BidiRun
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
        /// <see href="https://developer.android.com/reference/android/icu/text/BidiRun.html#getDirection()"/> 
        /// </summary>
        public byte Direction
        {
            get { return IExecuteWithSignature<byte>("getDirection", "()B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BidiRun.html#getEmbeddingLevel()"/> 
        /// </summary>
        public byte EmbeddingLevel
        {
            get { return IExecuteWithSignature<byte>("getEmbeddingLevel", "()B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BidiRun.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecuteWithSignature<int>("getLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BidiRun.html#getLimit()"/> 
        /// </summary>
        public int Limit
        {
            get { return IExecuteWithSignature<int>("getLimit", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BidiRun.html#getStart()"/> 
        /// </summary>
        public int Start
        {
            get { return IExecuteWithSignature<int>("getStart", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BidiRun.html#isEvenRun()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEvenRun()
        {
            return IExecuteWithSignature<bool>("isEvenRun", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/BidiRun.html#isOddRun()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOddRun()
        {
            return IExecuteWithSignature<bool>("isOddRun", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}