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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os.Health
{
    #region SystemHealthManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/health/SystemHealthManager.html"/>
    /// </summary>
    public partial class SystemHealthManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SystemHealthManager>
    {
        const string _bridgeClassName = "android.os.health.SystemHealthManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SystemHealthManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SystemHealthManager(params object[] args) : base(args) { }

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

    #region SystemHealthManager implementation
    public partial class SystemHealthManager
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
        /// <see href="https://developer.android.com/reference/android/os/health/SystemHealthManager.html#takeMyUidSnapshot()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Health.HealthStats"/></returns>
        public Android.Os.Health.HealthStats TakeMyUidSnapshot()
        {
            return IExecuteWithSignature<Android.Os.Health.HealthStats>("takeMyUidSnapshot", "()Landroid/os/health/HealthStats;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/SystemHealthManager.html#takeUidSnapshot(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Health.HealthStats"/></returns>
        public Android.Os.Health.HealthStats TakeUidSnapshot(int arg0)
        {
            return IExecuteWithSignature<Android.Os.Health.HealthStats>("takeUidSnapshot", "(I)Landroid/os/health/HealthStats;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/SystemHealthManager.html#takeUidSnapshots(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Health.HealthStats"/></returns>
        public Android.Os.Health.HealthStats[] TakeUidSnapshots(int[] arg0)
        {
            return IExecuteWithSignatureArray<Android.Os.Health.HealthStats>("takeUidSnapshots", "([I)[Landroid/os/health/HealthStats;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/SystemHealthManager.html#getPowerMonitorReadings(java.util.List,java.util.concurrent.Executor,android.os.OutcomeReceiver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.OutcomeReceiver"/></param>
        public void GetPowerMonitorReadings(Java.Util.List<Android.Os.PowerMonitor> arg0, Java.Util.Concurrent.Executor arg1, Android.Os.OutcomeReceiver<Android.Os.PowerMonitorReadings, Java.Lang.RuntimeException> arg2)
        {
            IExecute("getPowerMonitorReadings", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/SystemHealthManager.html#getSupportedPowerMonitors(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetSupportedPowerMonitors(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Java.Util.List<Android.Os.PowerMonitor>> arg1)
        {
            IExecute("getSupportedPowerMonitors", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}