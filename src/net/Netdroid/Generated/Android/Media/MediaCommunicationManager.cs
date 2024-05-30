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

namespace Android.Media
{
    #region MediaCommunicationManager
    public partial class MediaCommunicationManager
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
        /// <see href="https://developer.android.com/reference/android/media/MediaCommunicationManager.html#getSession2Tokens()"/> 
        /// </summary>
        public Java.Util.List<Android.Media.Session2Token> Session2Tokens
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Media.Session2Token>>("getSession2Tokens", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaCommunicationManager.html#getVersion()"/> 
        /// </summary>
        public int Version
        {
            get { return IExecuteWithSignature<int>("getVersion", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}