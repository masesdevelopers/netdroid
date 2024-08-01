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

namespace Android.Adservices.Adid
{
    #region AdIdManager
    public partial class AdIdManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adid/AdIdManager.html#get(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Adservices.Adid.AdIdManager"/></returns>
        public static Android.Adservices.Adid.AdIdManager Get(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Adservices.Adid.AdIdManager>(LocalBridgeClazz, "get", "(Landroid/content/Context;)Landroid/adservices/adid/AdIdManager;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adid/AdIdManager.html#getAdId(java.util.concurrent.Executor,android.adservices.common.AdServicesOutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Adservices.Common.AdServicesOutcomeReceiver"/></param>
        public void GetAdId(Java.Util.Concurrent.Executor arg0, Android.Adservices.Common.AdServicesOutcomeReceiver<Android.Adservices.Adid.AdId, Java.Lang.Exception> arg1)
        {
            IExecute("getAdId", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adid/AdIdManager.html#getAdId(java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void GetAdId(Java.Util.Concurrent.Executor arg0, Android.Os.OutcomeReceiver<Android.Adservices.Adid.AdId, Java.Lang.Exception> arg1)
        {
            IExecute("getAdId", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}