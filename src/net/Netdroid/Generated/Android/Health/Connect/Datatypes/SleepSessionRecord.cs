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

namespace Android.Health.Connect.Datatypes
{
    #region SleepSessionRecord declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.html"/>
    /// </summary>
    public partial class SleepSessionRecord : Android.Health.Connect.Datatypes.IntervalRecord
    {
        const string _bridgeClassName = "android.health.connect.datatypes.SleepSessionRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SleepSessionRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SleepSessionRecord(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.health.connect.datatypes.SleepSessionRecord$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region Stage declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Stage.html"/>
        /// </summary>
        public partial class Stage : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Stage>
        {
            const string _bridgeClassName = "android.health.connect.datatypes.SleepSessionRecord$Stage";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Stage() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Stage(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region StageType declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html"/>
        /// </summary>
        public partial class StageType : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StageType>
        {
            const string _bridgeClassName = "android.health.connect.datatypes.SleepSessionRecord$StageType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public StageType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public StageType(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region SleepSessionRecord implementation
    public partial class SleepSessionRecord
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.html#SLEEP_DURATION_TOTAL"/>
        /// </summary>
        public static Android.Health.Connect.Datatypes.AggregationType SLEEP_DURATION_TOTAL { get { if (!_SLEEP_DURATION_TOTALReady) { _SLEEP_DURATION_TOTALContent = SGetField<Android.Health.Connect.Datatypes.AggregationType>(LocalBridgeClazz, "SLEEP_DURATION_TOTAL"); _SLEEP_DURATION_TOTALReady = true; } return _SLEEP_DURATION_TOTALContent; } }
        private static Android.Health.Connect.Datatypes.AggregationType _SLEEP_DURATION_TOTALContent = default;
        private static bool _SLEEP_DURATION_TOTALReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.html#getNotes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetNotes()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getNotes", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.html#getStages()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Health.Connect.Datatypes.SleepSessionRecord.Stage> GetStages()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.Datatypes.SleepSessionRecord.Stage>>("getStages", "()Ljava/util/List;");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#%3Cinit%3E(android.health.connect.datatypes.Metadata,java.time.Instant,java.time.Instant)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Health.Connect.Datatypes.Metadata"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="Java.Time.Instant"/></param>
            public Builder(Android.Health.Connect.Datatypes.Metadata arg0, Java.Time.Instant arg1, Java.Time.Instant arg2)
                : base(arg0, arg1, arg2)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord>("build", "()Landroid/health/connect/datatypes/SleepSessionRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#clearEndZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord.Builder ClearEndZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord.Builder>("clearEndZoneOffset", "()Landroid/health/connect/datatypes/SleepSessionRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#clearStartZoneOffset()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord.Builder ClearStartZoneOffset()
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord.Builder>("clearStartZoneOffset", "()Landroid/health/connect/datatypes/SleepSessionRecord$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#setEndZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord.Builder SetEndZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord.Builder>("setEndZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/SleepSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#setNotes(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord.Builder SetNotes(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord.Builder>("setNotes", "(Ljava/lang/CharSequence;)Landroid/health/connect/datatypes/SleepSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#setStages(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord.Builder SetStages(Java.Util.List<Android.Health.Connect.Datatypes.SleepSessionRecord.Stage> arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord.Builder>("setStages", "(Ljava/util/List;)Landroid/health/connect/datatypes/SleepSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#setStartZoneOffset(java.time.ZoneOffset)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.ZoneOffset"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord.Builder SetStartZoneOffset(Java.Time.ZoneOffset arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord.Builder>("setStartZoneOffset", "(Ljava/time/ZoneOffset;)Landroid/health/connect/datatypes/SleepSessionRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Builder.html#setTitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Health.Connect.Datatypes.SleepSessionRecord.Builder"/></returns>
            public Android.Health.Connect.Datatypes.SleepSessionRecord.Builder SetTitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.Datatypes.SleepSessionRecord.Builder>("setTitle", "(Ljava/lang/CharSequence;)Landroid/health/connect/datatypes/SleepSessionRecord$Builder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Stage implementation
        public partial class Stage
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Stage.html#%3Cinit%3E(java.time.Instant,java.time.Instant,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg1"><see cref="Java.Time.Instant"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public Stage(Java.Time.Instant arg0, Java.Time.Instant arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Stage.html#getType()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetType()
            {
                return IExecuteWithSignature<int>("getType", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Stage.html#getEndTime()"/>
            /// </summary>
            /// <returns><see cref="Java.Time.Instant"/></returns>
            public Java.Time.Instant GetEndTime()
            {
                return IExecuteWithSignature<Java.Time.Instant>("getEndTime", "()Ljava/time/Instant;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.Stage.html#getStartTime()"/>
            /// </summary>
            /// <returns><see cref="Java.Time.Instant"/></returns>
            public Java.Time.Instant GetStartTime()
            {
                return IExecuteWithSignature<Java.Time.Instant>("getStartTime", "()Ljava/time/Instant;");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region StageType implementation
        public partial class StageType
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_AWAKE"/>
            /// </summary>
            public static int STAGE_TYPE_AWAKE { get { if (!_STAGE_TYPE_AWAKEReady) { _STAGE_TYPE_AWAKEContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_AWAKE"); _STAGE_TYPE_AWAKEReady = true; } return _STAGE_TYPE_AWAKEContent; } }
            private static int _STAGE_TYPE_AWAKEContent = default;
            private static bool _STAGE_TYPE_AWAKEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_AWAKE_IN_BED"/>
            /// </summary>
            public static int STAGE_TYPE_AWAKE_IN_BED { get { if (!_STAGE_TYPE_AWAKE_IN_BEDReady) { _STAGE_TYPE_AWAKE_IN_BEDContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_AWAKE_IN_BED"); _STAGE_TYPE_AWAKE_IN_BEDReady = true; } return _STAGE_TYPE_AWAKE_IN_BEDContent; } }
            private static int _STAGE_TYPE_AWAKE_IN_BEDContent = default;
            private static bool _STAGE_TYPE_AWAKE_IN_BEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_AWAKE_OUT_OF_BED"/>
            /// </summary>
            public static int STAGE_TYPE_AWAKE_OUT_OF_BED { get { if (!_STAGE_TYPE_AWAKE_OUT_OF_BEDReady) { _STAGE_TYPE_AWAKE_OUT_OF_BEDContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_AWAKE_OUT_OF_BED"); _STAGE_TYPE_AWAKE_OUT_OF_BEDReady = true; } return _STAGE_TYPE_AWAKE_OUT_OF_BEDContent; } }
            private static int _STAGE_TYPE_AWAKE_OUT_OF_BEDContent = default;
            private static bool _STAGE_TYPE_AWAKE_OUT_OF_BEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_SLEEPING"/>
            /// </summary>
            public static int STAGE_TYPE_SLEEPING { get { if (!_STAGE_TYPE_SLEEPINGReady) { _STAGE_TYPE_SLEEPINGContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_SLEEPING"); _STAGE_TYPE_SLEEPINGReady = true; } return _STAGE_TYPE_SLEEPINGContent; } }
            private static int _STAGE_TYPE_SLEEPINGContent = default;
            private static bool _STAGE_TYPE_SLEEPINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_SLEEPING_DEEP"/>
            /// </summary>
            public static int STAGE_TYPE_SLEEPING_DEEP { get { if (!_STAGE_TYPE_SLEEPING_DEEPReady) { _STAGE_TYPE_SLEEPING_DEEPContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_SLEEPING_DEEP"); _STAGE_TYPE_SLEEPING_DEEPReady = true; } return _STAGE_TYPE_SLEEPING_DEEPContent; } }
            private static int _STAGE_TYPE_SLEEPING_DEEPContent = default;
            private static bool _STAGE_TYPE_SLEEPING_DEEPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_SLEEPING_LIGHT"/>
            /// </summary>
            public static int STAGE_TYPE_SLEEPING_LIGHT { get { if (!_STAGE_TYPE_SLEEPING_LIGHTReady) { _STAGE_TYPE_SLEEPING_LIGHTContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_SLEEPING_LIGHT"); _STAGE_TYPE_SLEEPING_LIGHTReady = true; } return _STAGE_TYPE_SLEEPING_LIGHTContent; } }
            private static int _STAGE_TYPE_SLEEPING_LIGHTContent = default;
            private static bool _STAGE_TYPE_SLEEPING_LIGHTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_SLEEPING_REM"/>
            /// </summary>
            public static int STAGE_TYPE_SLEEPING_REM { get { if (!_STAGE_TYPE_SLEEPING_REMReady) { _STAGE_TYPE_SLEEPING_REMContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_SLEEPING_REM"); _STAGE_TYPE_SLEEPING_REMReady = true; } return _STAGE_TYPE_SLEEPING_REMContent; } }
            private static int _STAGE_TYPE_SLEEPING_REMContent = default;
            private static bool _STAGE_TYPE_SLEEPING_REMReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/SleepSessionRecord.StageType.html#STAGE_TYPE_UNKNOWN"/>
            /// </summary>
            public static int STAGE_TYPE_UNKNOWN { get { if (!_STAGE_TYPE_UNKNOWNReady) { _STAGE_TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "STAGE_TYPE_UNKNOWN"); _STAGE_TYPE_UNKNOWNReady = true; } return _STAGE_TYPE_UNKNOWNContent; } }
            private static int _STAGE_TYPE_UNKNOWNContent = default;
            private static bool _STAGE_TYPE_UNKNOWNReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}