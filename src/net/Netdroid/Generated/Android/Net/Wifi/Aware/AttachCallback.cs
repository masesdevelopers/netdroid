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

namespace Android.Net.Wifi.Aware
{
    #region AttachCallback
    public partial class AttachCallback
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
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AttachCallback.html#onAttached(android.net.wifi.aware.WifiAwareSession)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.WifiAwareSession"/></param>
        public void OnAttached(Android.Net.Wifi.Aware.WifiAwareSession arg0)
        {
            IExecuteWithSignature("onAttached", "(Landroid/net/wifi/aware/WifiAwareSession;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AttachCallback.html#onAttachFailed()"/>
        /// </summary>
        public void OnAttachFailed()
        {
            IExecuteWithSignature("onAttachFailed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/AttachCallback.html#onAwareSessionTerminated()"/>
        /// </summary>
        public void OnAwareSessionTerminated()
        {
            IExecuteWithSignature("onAwareSessionTerminated", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}