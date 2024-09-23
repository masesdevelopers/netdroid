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
    #region HealthStats declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html"/>
    /// </summary>
    public partial class HealthStats : MASES.JCOBridge.C2JBridge.JVMBridgeBase<HealthStats>
    {
        const string _bridgeClassName = "android.os.health.HealthStats";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HealthStats() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HealthStats(params object[] args) : base(args) { }

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

    #region HealthStats implementation
    public partial class HealthStats
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
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Health.TimerStat"/></returns>
        public Android.Os.Health.TimerStat GetTimer(int arg0)
        {
            return IExecuteWithSignature<Android.Os.Health.TimerStat>("getTimer", "(I)Landroid/os/health/TimerStat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#hasMeasurement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurement(int arg0)
        {
            return IExecuteWithSignature<bool>("hasMeasurement", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#hasMeasurements(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasMeasurements(int arg0)
        {
            return IExecuteWithSignature<bool>("hasMeasurements", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#hasStats(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasStats(int arg0)
        {
            return IExecuteWithSignature<bool>("hasStats", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#hasTimer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasTimer(int arg0)
        {
            return IExecuteWithSignature<bool>("hasTimer", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#hasTimers(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasTimers(int arg0)
        {
            return IExecuteWithSignature<bool>("hasTimers", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getMeasurementKeyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMeasurementKeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("getMeasurementKeyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getMeasurementKeyCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMeasurementKeyCount()
        {
            return IExecuteWithSignature<int>("getMeasurementKeyCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getMeasurementsKeyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMeasurementsKeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("getMeasurementsKeyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getMeasurementsKeyCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMeasurementsKeyCount()
        {
            return IExecuteWithSignature<int>("getMeasurementsKeyCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getStatsKeyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetStatsKeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("getStatsKeyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getStatsKeyCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatsKeyCount()
        {
            return IExecuteWithSignature<int>("getStatsKeyCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimerCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetTimerCount(int arg0)
        {
            return IExecuteWithSignature<int>("getTimerCount", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimerKeyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetTimerKeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("getTimerKeyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimerKeyCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTimerKeyCount()
        {
            return IExecuteWithSignature<int>("getTimerKeyCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimersKeyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetTimersKeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("getTimersKeyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimersKeyCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTimersKeyCount()
        {
            return IExecuteWithSignature<int>("getTimersKeyCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getDataType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDataType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDataType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getStats(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Android.Os.Health.HealthStats> GetStats(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Android.Os.Health.HealthStats>>("getStats", "(I)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimers(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Android.Os.Health.TimerStat> GetTimers(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Android.Os.Health.TimerStat>>("getTimers", "(I)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getMeasurements(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Lang.Long> GetMeasurements(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.Long>>("getMeasurements", "(I)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getMeasurement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetMeasurement(int arg0)
        {
            return IExecuteWithSignature<long>("getMeasurement", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/health/HealthStats.html#getTimerTime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetTimerTime(int arg0)
        {
            return IExecuteWithSignature<long>("getTimerTime", "(I)J", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}