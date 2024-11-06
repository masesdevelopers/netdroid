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
    #region Consumer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html"/>
    /// </summary>
    public partial class Consumer : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Consumer() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.Consumer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region ConsumerDirect declaration
    /// <summary>
    /// Direct override of <see cref="Consumer"/> or its generic type if there is one
    /// </summary>
    public partial class ConsumerDirect : Consumer
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "java.util.function.Consumer";
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

    #region Consumer<T> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class Consumer<T> : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Consumer() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.Consumer";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region ConsumerDirect<T> declaration
    /// <summary>
    /// Direct override of <see cref="Consumer"/> or its generic type if there is one
    /// </summary>
    public partial class ConsumerDirect<T> : Consumer<T>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "java.util.function.Consumer";
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

    #region Consumer implementation
    public partial class Consumer
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
        /// Handlers initializer for <see cref="Consumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AcceptEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThenEventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<object> OnAccept { get; set; } = null;
        
        bool hasOverrideAccept = true;
        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAccept = true;
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.GetAt<object>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideAccept;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public virtual void Accept(object arg0)
        {
            hasOverrideAccept = false;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Consumer AndThenDefault(Java.Util.Function.Consumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.Consumer>("andThenDefault", "(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.Consumer, Java.Util.Function.Consumer> OnAndThen { get; set; } = null;
        
        bool hasOverrideAndThen = true;
        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAndThen = true;
            var methodToExecute = (OnAndThen != null) ? OnAndThen : AndThen;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.Consumer>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThenDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Consumer AndThen(Java.Util.Function.Consumer arg0)
        {
            hasOverrideAndThen = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region ConsumerDirect implementation
    public partial class ConsumerDirect
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
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public override void Accept(object arg0)
        {
            IExecuteWithSignature("accept", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        public override Java.Util.Function.Consumer AndThen(Java.Util.Function.Consumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.ConsumerDirect, Java.Util.Function.Consumer>("andThen", "(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IConsumer<T>
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.Consumer implementing <see href="https://developer.android.com/reference/java/util/function/Consumer.html"/>
    /// </summary>
    public partial interface IConsumer<T>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region Consumer<T> implementation
    public partial class Consumer<T> : Java.Util.Function.IConsumer<T>
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
        /// Handlers initializer for <see cref="Consumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AcceptEventHandler));
            AddEventHandler("andThen", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndThen<Arg0objectSuperT>EventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAccept"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<T> OnAccept { get; set; } = null;
        
        bool hasOverrideAccept = true;
        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAccept = true;
            var methodToExecute = (OnAccept != null) ? OnAccept : Accept;
            methodToExecute.Invoke(data.EventData.GetAt<T>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideAccept;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public virtual void Accept(T arg0)
        {
            hasOverrideAccept = false;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.Consumer<T> AndThen<Arg0objectSuperT>Default(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.Function.Consumer<T>>("andThenDefault", "(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAndThen<Arg0objectSuperT>"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.Consumer<Arg0objectSuperT>, Java.Util.Function.Consumer<T>> OnAndThen<Arg0objectSuperT> { get; set; } = null;
        
        bool hasOverrideAndThen<Arg0objectSuperT> = true;
        void AndThen<Arg0objectSuperT>EventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAndThen<Arg0objectSuperT> = true;
            var methodToExecute = (OnAndThen<Arg0objectSuperT> != null) ? OnAndThen<Arg0objectSuperT> : AndThen<Arg0objectSuperT>;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.Consumer<Arg0objectSuperT>>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAndThen<Arg0objectSuperT>, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndThen<Arg0objectSuperT>Default"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.Consumer<T> AndThen<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            hasOverrideAndThen<Arg0objectSuperT> = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region ConsumerDirect<T> implementation
    public partial class ConsumerDirect<T> : Java.Util.Function.IConsumer<T>
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
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public override void Accept(T arg0)
        {
            IExecuteWithSignature("accept", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        public override Java.Util.Function.Consumer<T> AndThen<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.Function.ConsumerDirect<T>, Java.Util.Function.Consumer<T>>("andThen", "(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}