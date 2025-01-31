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

namespace Android.Media.Metrics
{
    #region BundleSession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/metrics/BundleSession.html"/>
    /// </summary>
    public partial class BundleSession : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.media.metrics.BundleSession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BundleSession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BundleSession(params object[] args) : base(args) { }
    
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

    #region BundleSession implementation
    public partial class BundleSession
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/BundleSession.html#KEY_STATSD_ATOM"/>
        /// </summary>
        public static Java.Lang.String KEY_STATSD_ATOM { get { if (!_KEY_STATSD_ATOMReady) { _KEY_STATSD_ATOMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "KEY_STATSD_ATOM"); _KEY_STATSD_ATOMReady = true; } return _KEY_STATSD_ATOMContent; } }
        private static Java.Lang.String _KEY_STATSD_ATOMContent = default;
        private static bool _KEY_STATSD_ATOMReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/BundleSession.html#getSessionId()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Metrics.LogSessionId"/></returns>
        public Android.Media.Metrics.LogSessionId GetSessionId()
        {
            return IExecuteWithSignature<Android.Media.Metrics.LogSessionId>("getSessionId", "()Landroid/media/metrics/LogSessionId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/BundleSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/BundleSession.html#reportBundleMetrics(android.os.PersistableBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.PersistableBundle"/></param>
        public void ReportBundleMetrics(Android.Os.PersistableBundle arg0)
        {
            IExecuteWithSignature("reportBundleMetrics", "(Landroid/os/PersistableBundle;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}