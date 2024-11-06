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
    #region IntUnaryOperator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html"/>
    /// </summary>
    public partial class IntUnaryOperator : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IntUnaryOperator() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.IntUnaryOperator";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region IntUnaryOperatorDirect declaration
    /// <summary>
    /// Direct override of <see cref="IntUnaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class IntUnaryOperatorDirect : IntUnaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "java.util.function.IntUnaryOperator";
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

    #region IIntUnaryOperator
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.IntUnaryOperator implementing <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html"/>
    /// </summary>
    public partial interface IIntUnaryOperator
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IntUnaryOperator implementation
    public partial class IntUnaryOperator : Java.Util.Function.IIntUnaryOperator
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#identity()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the static implementation in the JVM interface</remarks>
        public static Java.Util.Function.IntUnaryOperator Identity()
        {
            return SExecuteWithSignature<Java.Util.Function.IntUnaryOperator>(LocalBridgeClazz, "identity", "()Ljava/util/function/IntUnaryOperator;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="IntUnaryOperator"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("applyAsInt", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ApplyAsIntEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThenEventHandler));
            AddEventHandler("compose", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ComposeEventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#applyAsInt(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnApplyAsInt"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, int> OnApplyAsInt { get; set; } = null;
        
        bool hasOverrideApplyAsInt = true;
        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideApplyAsInt = true;
            var methodToExecute = (OnApplyAsInt != null) ? OnApplyAsInt : ApplyAsInt;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<int>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideApplyAsInt, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#applyAsInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int ApplyAsInt(int arg0)
        {
            hasOverrideApplyAsInt = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntUnaryOperator AndThenDefault(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperator>("andThenDefault", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntUnaryOperator, Java.Util.Function.IntUnaryOperator> OnAndThen { get; set; } = null;
        
        bool hasOverrideAndThen = true;
        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAndThen = true;
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.IntUnaryOperator>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntUnaryOperator AndThen(Java.Util.Function.IntUnaryOperator arg0)
        {
            hasOverrideAndThen = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.IntUnaryOperator ComposeDefault(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperator>("composeDefault", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCompose"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.IntUnaryOperator, Java.Util.Function.IntUnaryOperator> OnCompose { get; set; } = null;
        
        bool hasOverrideCompose = true;
        void ComposeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideCompose = true;
            var methodToExecute = (OnCompose != null) ? OnCompose : Compose;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.IntUnaryOperator>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideCompose, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="ComposeDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.IntUnaryOperator Compose(Java.Util.Function.IntUnaryOperator arg0)
        {
            hasOverrideCompose = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IntUnaryOperatorDirect implementation
    public partial class IntUnaryOperatorDirect : Java.Util.Function.IIntUnaryOperator
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
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#applyAsInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(int arg0)
        {
            return IExecuteWithSignature<int>("applyAsInt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#andThen(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        public override Java.Util.Function.IntUnaryOperator AndThen(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperatorDirect, Java.Util.Function.IntUnaryOperator>("andThen", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/IntUnaryOperator.html#compose(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.IntUnaryOperator"/></returns>
        public override Java.Util.Function.IntUnaryOperator Compose(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntUnaryOperatorDirect, Java.Util.Function.IntUnaryOperator>("compose", "(Ljava/util/function/IntUnaryOperator;)Ljava/util/function/IntUnaryOperator;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}