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
    #region IdentityChangedListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/wifi/aware/IdentityChangedListener.html"/>
    /// </summary>
    public partial class IdentityChangedListener : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IdentityChangedListener>
    {
        const string _bridgeClassName = "android.net.wifi.aware.IdentityChangedListener";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IdentityChangedListener() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IdentityChangedListener(params object[] args) : base(args) { }
    
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

    #region IdentityChangedListener implementation
    public partial class IdentityChangedListener
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/IdentityChangedListener.html#CLUSTER_CHANGE_EVENT_JOINED"/>
        /// </summary>
        public static int CLUSTER_CHANGE_EVENT_JOINED { get { if (!_CLUSTER_CHANGE_EVENT_JOINEDReady) { _CLUSTER_CHANGE_EVENT_JOINEDContent = SGetField<int>(LocalBridgeClazz, "CLUSTER_CHANGE_EVENT_JOINED"); _CLUSTER_CHANGE_EVENT_JOINEDReady = true; } return _CLUSTER_CHANGE_EVENT_JOINEDContent; } }
        private static int _CLUSTER_CHANGE_EVENT_JOINEDContent = default;
        private static bool _CLUSTER_CHANGE_EVENT_JOINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/IdentityChangedListener.html#CLUSTER_CHANGE_EVENT_STARTED"/>
        /// </summary>
        public static int CLUSTER_CHANGE_EVENT_STARTED { get { if (!_CLUSTER_CHANGE_EVENT_STARTEDReady) { _CLUSTER_CHANGE_EVENT_STARTEDContent = SGetField<int>(LocalBridgeClazz, "CLUSTER_CHANGE_EVENT_STARTED"); _CLUSTER_CHANGE_EVENT_STARTEDReady = true; } return _CLUSTER_CHANGE_EVENT_STARTEDContent; } }
        private static int _CLUSTER_CHANGE_EVENT_STARTEDContent = default;
        private static bool _CLUSTER_CHANGE_EVENT_STARTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/IdentityChangedListener.html#onClusterIdChanged(int,android.net.MacAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Net.MacAddress"/></param>
        public void OnClusterIdChanged(int arg0, Android.Net.MacAddress arg1)
        {
            IExecuteWithSignature("onClusterIdChanged", "(ILandroid/net/MacAddress;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/wifi/aware/IdentityChangedListener.html#onIdentityChanged(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void OnIdentityChanged(byte[] arg0)
        {
            IExecuteWithSignature("onIdentityChanged", "([B)V", new object[] { arg0 });
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}