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

namespace Java.Util.Function
{
    #region LongUnaryOperator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html"/>
    /// </summary>
    public partial class LongUnaryOperator : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public LongUnaryOperator() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.LongUnaryOperator";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region LongUnaryOperatorDirect declaration
    /// <summary>
    /// Direct override of <see cref="LongUnaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class LongUnaryOperatorDirect : LongUnaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "java.util.function.LongUnaryOperator";
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

    #region ILongUnaryOperator
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.LongUnaryOperator implementing <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html"/>
    /// </summary>
    public partial interface ILongUnaryOperator
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region LongUnaryOperator implementation
    public partial class LongUnaryOperator : Java.Util.Function.ILongUnaryOperator
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#identity()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.LongUnaryOperator Identity()
        {
            return SExecuteWithSignature<Java.Util.Function.LongUnaryOperator>(LocalBridgeClazz, "identity", "()Ljava/util/function/LongUnaryOperator;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="LongUnaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsLong", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ApplyAsLongEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThenEventHandler));
            AddEventHandler("compose", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ComposeEventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsLong"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<long, long> OnApplyAsLong { get; set; } = null;
        
        bool hasOverrideApplyAsLong = true;
        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideApplyAsLong = true;
            var methodToExecute = (OnApplyAsLong != null) ? OnApplyAsLong : ApplyAsLong;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<long>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideApplyAsLong, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long ApplyAsLong(long arg0)
        {
            hasOverrideApplyAsLong = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.LongUnaryOperator AndThenDefault(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongUnaryOperator>("andThenDefault", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.LongUnaryOperator, Java.Util.Function.LongUnaryOperator> OnAndThen { get; set; } = null;
        
        bool hasOverrideAndThen = true;
        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAndThen = true;
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.LongUnaryOperator>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.LongUnaryOperator AndThen(Java.Util.Function.LongUnaryOperator arg0)
        {
            hasOverrideAndThen = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.LongUnaryOperator ComposeDefault(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongUnaryOperator>("composeDefault", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCompose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.LongUnaryOperator, Java.Util.Function.LongUnaryOperator> OnCompose { get; set; } = null;
        
        bool hasOverrideCompose = true;
        void ComposeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideCompose = true;
            var methodToExecute = (OnCompose != null) ? OnCompose : Compose;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.LongUnaryOperator>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideCompose, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ComposeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.LongUnaryOperator Compose(Java.Util.Function.LongUnaryOperator arg0)
        {
            hasOverrideCompose = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region LongUnaryOperatorDirect implementation
    public partial class LongUnaryOperatorDirect : Java.Util.Function.ILongUnaryOperator
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
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ApplyAsLong(long arg0)
        {
            return IExecuteWithSignature<long>("applyAsLong", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public override Java.Util.Function.LongUnaryOperator AndThen(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongUnaryOperatorDirect, Java.Util.Function.LongUnaryOperator>("andThen", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public override Java.Util.Function.LongUnaryOperator Compose(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongUnaryOperatorDirect, Java.Util.Function.LongUnaryOperator>("compose", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}