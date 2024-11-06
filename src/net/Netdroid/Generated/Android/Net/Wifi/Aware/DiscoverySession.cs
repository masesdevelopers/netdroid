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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Net.Wifi.Aware
{
    #region DiscoverySession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html"/>
    /// </summary>
    public partial class DiscoverySession : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.net.wifi.aware.DiscoverySession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DiscoverySession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DiscoverySession(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region DiscoverySession implementation
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
        [global::System.Obsolete()]
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
        [global::System.Obsolete()]
        public Android.Net.NetworkSpecifier CreateNetworkSpecifierPassphrase(Android.Net.Wifi.Aware.PeerHandle arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.Net.NetworkSpecifier>("createNetworkSpecifierPassphrase", "(Landroid/net/wifi/aware/PeerHandle;Ljava/lang/String;)Landroid/net/NetworkSpecifier;", arg0, arg1);
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
            IExecuteWithSignature("acceptPairingRequest", "(ILandroid/net/wifi/aware/PeerHandle;Ljava/lang/String;ILjava/lang/String;)V", arg0, arg1, arg2, arg3, arg4);
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
            IExecuteWithSignature("initiateBootstrappingRequest", "(Landroid/net/wifi/aware/PeerHandle;I)V", arg0, arg1);
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
            IExecuteWithSignature("initiatePairingRequest", "(Landroid/net/wifi/aware/PeerHandle;Ljava/lang/String;ILjava/lang/String;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#rejectPairingRequest(int,android.net.wifi.aware.PeerHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        public void RejectPairingRequest(int arg0, Android.Net.Wifi.Aware.PeerHandle arg1)
        {
            IExecuteWithSignature("rejectPairingRequest", "(ILandroid/net/wifi/aware/PeerHandle;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/DiscoverySession.html#sendMessage(android.net.wifi.aware.PeerHandle,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Wifi.Aware.PeerHandle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public void SendMessage(Android.Net.Wifi.Aware.PeerHandle arg0, int arg1, byte[] arg2)
        {
            IExecuteWithSignature("sendMessage", "(Landroid/net/wifi/aware/PeerHandle;I[B)V", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}