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

namespace Android.Adservices.Ondevicepersonalization
{
    #region ExecuteOutput declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.html"/>
    /// </summary>
    public partial class ExecuteOutput : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ExecuteOutput>
    {
        const string _bridgeClassName = "android.adservices.ondevicepersonalization.ExecuteOutput";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ExecuteOutput() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ExecuteOutput(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.ondevicepersonalization.ExecuteOutput$Builder";
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

    
    }
    #endregion

    #region ExecuteOutput implementation
    public partial class ExecuteOutput
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
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.html#getRenderingConfig()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.RenderingConfig"/></returns>
        public Android.Adservices.Ondevicepersonalization.RenderingConfig GetRenderingConfig()
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.RenderingConfig>("getRenderingConfig", "()Landroid/adservices/ondevicepersonalization/RenderingConfig;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.html#getRequestLogRecord()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Ondevicepersonalization.RequestLogRecord"/></returns>
        public Android.Adservices.Ondevicepersonalization.RequestLogRecord GetRequestLogRecord()
        {
            return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.RequestLogRecord>("getRequestLogRecord", "()Landroid/adservices/ondevicepersonalization/RequestLogRecord;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.html#getOutputData()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetOutputData()
        {
            return IExecuteWithSignatureArray<byte>("getOutputData", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.html#getEventLogRecords()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Adservices.Ondevicepersonalization.EventLogRecord> GetEventLogRecords()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Adservices.Ondevicepersonalization.EventLogRecord>>("getEventLogRecords", "()Ljava/util/List;");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ExecuteOutput"/></returns>
            public Android.Adservices.Ondevicepersonalization.ExecuteOutput Build()
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ExecuteOutput>("build", "()Landroid/adservices/ondevicepersonalization/ExecuteOutput;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.Builder.html#addEventLogRecord(android.adservices.ondevicepersonalization.EventLogRecord)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.EventLogRecord"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder AddEventLogRecord(Android.Adservices.Ondevicepersonalization.EventLogRecord arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder>("addEventLogRecord", "(Landroid/adservices/ondevicepersonalization/EventLogRecord;)Landroid/adservices/ondevicepersonalization/ExecuteOutput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.Builder.html#setEventLogRecords(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder SetEventLogRecords(Java.Util.List<Android.Adservices.Ondevicepersonalization.EventLogRecord> arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder>("setEventLogRecords", "(Ljava/util/List;)Landroid/adservices/ondevicepersonalization/ExecuteOutput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.Builder.html#setOutputData(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder SetOutputData(params byte[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder>("setOutputData", "([B)Landroid/adservices/ondevicepersonalization/ExecuteOutput$Builder;"); else return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder>("setOutputData", "([B)Landroid/adservices/ondevicepersonalization/ExecuteOutput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.Builder.html#setRenderingConfig(android.adservices.ondevicepersonalization.RenderingConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RenderingConfig"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder SetRenderingConfig(Android.Adservices.Ondevicepersonalization.RenderingConfig arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder>("setRenderingConfig", "(Landroid/adservices/ondevicepersonalization/RenderingConfig;)Landroid/adservices/ondevicepersonalization/ExecuteOutput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/ondevicepersonalization/ExecuteOutput.Builder.html#setRequestLogRecord(android.adservices.ondevicepersonalization.RequestLogRecord)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Ondevicepersonalization.RequestLogRecord"/></param>
            /// <returns><see cref="Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder"/></returns>
            public Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder SetRequestLogRecord(Android.Adservices.Ondevicepersonalization.RequestLogRecord arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Ondevicepersonalization.ExecuteOutput.Builder>("setRequestLogRecord", "(Landroid/adservices/ondevicepersonalization/RequestLogRecord;)Landroid/adservices/ondevicepersonalization/ExecuteOutput$Builder;", arg0);
            }
        
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