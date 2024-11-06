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
    #region DoublePredicate declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html"/>
    /// </summary>
    public partial class DoublePredicate : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DoublePredicate() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.java.util.function.DoublePredicate";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region DoublePredicateDirect declaration
    /// <summary>
    /// Direct override of <see cref="DoublePredicate"/> or its generic type if there is one
    /// </summary>
    public partial class DoublePredicateDirect : DoublePredicate
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "java.util.function.DoublePredicate";
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

    #region IDoublePredicate
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.DoublePredicate implementing <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html"/>
    /// </summary>
    public partial interface IDoublePredicate
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region DoublePredicate implementation
    public partial class DoublePredicate : Java.Util.Function.IDoublePredicate
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
        /// Handlers initializer for <see cref="DoublePredicate"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("test", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(TestEventHandler));
            AddEventHandler("and", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AndEventHandler));
            AddEventHandler("negate", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(NegateEventHandler));
            AddEventHandler("or", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OrEventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#test(double)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTest"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<double, bool> OnTest { get; set; } = null;
        
        bool hasOverrideTest = true;
        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideTest = true;
            var methodToExecute = (OnTest != null) ? OnTest : Test;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<double>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideTest, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#test(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(double arg0)
        {
            hasOverrideTest = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.DoublePredicate AndDefault(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicate>("andDefault", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.DoublePredicate, Java.Util.Function.DoublePredicate> OnAnd { get; set; } = null;
        
        bool hasOverrideAnd = true;
        void AndEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAnd = true;
            var methodToExecute = (OnAnd != null) ? OnAnd : And;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.DoublePredicate>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideAnd, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="AndDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.DoublePredicate And(Java.Util.Function.DoublePredicate arg0)
        {
            hasOverrideAnd = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.DoublePredicate NegateDefault()
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicate>("negateDefault", "()Ljava/util/function/DoublePredicate;");
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNegate"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.DoublePredicate> OnNegate { get; set; } = null;
        
        bool hasOverrideNegate = true;
        void NegateEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideNegate = true;
            var methodToExecute = (OnNegate != null) ? OnNegate : Negate;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideNegate, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="NegateDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.DoublePredicate Negate()
        {
            hasOverrideNegate = false; return default;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Util.Function.DoublePredicate OrDefault(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicate>("orDefault", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOr"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Util.Function.DoublePredicate, Java.Util.Function.DoublePredicate> OnOr { get; set; } = null;
        
        bool hasOverrideOr = true;
        void OrEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOr = true;
            var methodToExecute = (OnOr != null) ? OnOr : Or;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Java.Util.Function.DoublePredicate>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideOr, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OrDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Util.Function.DoublePredicate Or(Java.Util.Function.DoublePredicate arg0)
        {
            hasOverrideOr = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region DoublePredicateDirect implementation
    public partial class DoublePredicateDirect : Java.Util.Function.IDoublePredicate
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
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#test(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(double arg0)
        {
            return IExecuteWithSignature<bool>("test", "(D)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public override Java.Util.Function.DoublePredicate And(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicateDirect, Java.Util.Function.DoublePredicate>("and", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public override Java.Util.Function.DoublePredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicateDirect, Java.Util.Function.DoublePredicate>("negate", "()Ljava/util/function/DoublePredicate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public override Java.Util.Function.DoublePredicate Or(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicateDirect, Java.Util.Function.DoublePredicate>("or", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}