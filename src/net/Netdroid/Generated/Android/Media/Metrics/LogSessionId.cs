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

namespace Android.Media.Metrics
{
    #region LogSessionId
    public partial class LogSessionId
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/LogSessionId.html#LOG_SESSION_ID_NONE"/>
        /// </summary>
        public static Android.Media.Metrics.LogSessionId LOG_SESSION_ID_NONE { get { if (!_LOG_SESSION_ID_NONEReady) { _LOG_SESSION_ID_NONEContent = SGetField<Android.Media.Metrics.LogSessionId>(LocalBridgeClazz, "LOG_SESSION_ID_NONE"); _LOG_SESSION_ID_NONEReady = true; } return _LOG_SESSION_ID_NONEContent; } }
        private static Android.Media.Metrics.LogSessionId _LOG_SESSION_ID_NONEContent = default;
        private static bool _LOG_SESSION_ID_NONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/LogSessionId.html#getStringId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetStringId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getStringId", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}