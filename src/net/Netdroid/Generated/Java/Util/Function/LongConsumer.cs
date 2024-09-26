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

namespace Java.Util.Function
{
    #region LongConsumer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html"/>
    /// </summary>
    public partial class LongConsumer : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LongConsumer() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.LongConsumer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region LongConsumerDirect declaration
    /// <summary>
    /// Direct override of <see cref="LongConsumer"/> or its generic type if there is one
    /// </summary>
    public partial class LongConsumerDirect : LongConsumer
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.function.LongConsumer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region ILongConsumer
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.LongConsumer implementing <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html"/>
    /// </summary>
    public partial interface ILongConsumer
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongConsumer implementation
    public partial class LongConsumer : Java.Util.Function.ILongConsumer
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
        /// Handlers initializer for <see cref="LongConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AcceptEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThenEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html#accept(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<long> OnAccept { get; set; } = null;

        bool hasOverrideAccept = true;
        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAccept = true;
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.GetAt<long>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideAccept;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html#accept(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public virtual void Accept(long arg0)
        {
            hasOverrideAccept = false;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html#andThen(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.LongConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.LongConsumer AndThenDefault(Java.Util.Function.LongConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongConsumer>("andThenDefault", "(Ljava/util/function/LongConsumer;)Ljava/util/function/LongConsumer;", arg0);
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html#andThen(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.LongConsumer, Java.Util.Function.LongConsumer> OnAndThen { get; set; } = null;

        bool hasOverrideAndThen = true;
        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAndThen = true;
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.LongConsumer>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html#andThen(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.LongConsumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.LongConsumer AndThen(Java.Util.Function.LongConsumer arg0)
        {
            hasOverrideAndThen = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongConsumerDirect implementation
    public partial class LongConsumerDirect : Java.Util.Function.ILongConsumer
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
        /// <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html#accept(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public override void Accept(long arg0)
        {
            IExecuteWithSignature("accept", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongConsumer.html#andThen(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.LongConsumer"/></returns>
        public override Java.Util.Function.LongConsumer AndThen(Java.Util.Function.LongConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongConsumerDirect, Java.Util.Function.LongConsumer>("andThen", "(Ljava/util/function/LongConsumer;)Ljava/util/function/LongConsumer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}