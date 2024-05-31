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

namespace Android.Net.Wifi.Aware
{
    #region DiscoverySession
    public partial class DiscoverySession
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
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#createNetworkSpecifierOpen(android.net.wifi.aware.PeerHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        /// <returns><see cref="Android.Net.NetworkSpecifier"/></returns>
        [System.Obsolete()]
        public Android.Net.NetworkSpecifier CreateNetworkSpecifierOpen(Android.Net.Wifi.Aware.PeerHandle arg0)
        {
            return IExecuteWithSignature<Android.Net.NetworkSpecifier>("createNetworkSpecifierOpen", "(Landroid/net/wifi/aware/PeerHandle;)Landroid/net/NetworkSpecifier;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#createNetworkSpecifierPassphrase(android.net.wifi.aware.PeerHandle,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Net.NetworkSpecifier"/></returns>
        [System.Obsolete()]
        public Android.Net.NetworkSpecifier CreateNetworkSpecifierPassphrase(Android.Net.Wifi.Aware.PeerHandle arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.Net.NetworkSpecifier>("createNetworkSpecifierPassphrase", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#acceptPairingRequest(int,android.net.wifi.aware.PeerHandle,java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        public void AcceptPairingRequest(int arg0, Android.Net.Wifi.Aware.PeerHandle arg1, Java.Lang.String arg2, int arg3, Java.Lang.String arg4)
        {
            IExecute("acceptPairingRequest", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#initiateBootstrappingRequest(android.net.wifi.aware.PeerHandle,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void InitiateBootstrappingRequest(Android.Net.Wifi.Aware.PeerHandle arg0, int arg1)
        {
            IExecute("initiateBootstrappingRequest", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#initiatePairingRequest(android.net.wifi.aware.PeerHandle,java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public void InitiatePairingRequest(Android.Net.Wifi.Aware.PeerHandle arg0, Java.Lang.String arg1, int arg2, Java.Lang.String arg3)
        {
            IExecute("initiatePairingRequest", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#rejectPairingRequest(int,android.net.wifi.aware.PeerHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        public void RejectPairingRequest(int arg0, Android.Net.Wifi.Aware.PeerHandle arg1)
        {
            IExecute("rejectPairingRequest", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#sendMessage(android.net.wifi.aware.PeerHandle,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public void SendMessage(Android.Net.Wifi.Aware.PeerHandle arg0, int arg1, byte[] arg2)
        {
            IExecute("sendMessage", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}