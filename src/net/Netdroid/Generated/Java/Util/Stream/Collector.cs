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

namespace Java.Util.Stream
{
    #region Collector declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html"/>
    /// </summary>
    public partial class Collector : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Collector>
    {
        const string _bridgeClassName = "java.util.stream.Collector";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Collector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Collector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Collector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Collector(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
    
        // TODO: complete the class
        #region Characteristics declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.Characteristics.html"/>
        /// </summary>
        public partial class Characteristics : Java.Lang.Enum<Java.Util.Stream.Collector.Characteristics>
        {
            const string _bridgeClassName = "java.util.stream.Collector$Characteristics";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Characteristics() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Characteristics(params object[] args) : base(args) { }
        
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

    #region Collector<T, A, R> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="A"></typeparam>
    /// <typeparam name="R"></typeparam>
    public partial class Collector<T, A, R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Collector<T, A, R>>
    {
        const string _bridgeClassName = "java.util.stream.Collector";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Collector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Collector() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Collector class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Collector(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
    
        // TODO: complete the class
    
    }
    #endregion

    #region Collector implementation
    public partial class Collector
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.function.Function,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg4"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector Of(Java.Util.Function.Supplier arg0, Java.Util.Function.BiConsumer arg1, Java.Util.Function.BinaryOperator arg2, Java.Util.Function.Function arg3, params Java.Util.Stream.Collector.Characteristics[] arg4)
        {
            if (arg4.Length == 0) return SExecuteWithSignature<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3); else return SExecuteWithSignature<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector Of(Java.Util.Function.Supplier arg0, Java.Util.Function.BiConsumer arg1, Java.Util.Function.BinaryOperator arg2, params Java.Util.Stream.Collector.Characteristics[] arg3)
        {
            if (arg3.Length == 0) return SExecuteWithSignature<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2); else return SExecuteWithSignature<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#accumulator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public Java.Util.Function.BiConsumer Accumulator()
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumer>("accumulator", "()Ljava/util/function/BiConsumer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#accumulator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public Java.Util.Function.BiConsumer AccumulatorDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumerDirect, Java.Util.Function.BiConsumer>("accumulator", "()Ljava/util/function/BiConsumer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#combiner()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public Java.Util.Function.BinaryOperator Combiner()
        {
            return IExecuteWithSignature<Java.Util.Function.BinaryOperator>("combiner", "()Ljava/util/function/BinaryOperator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#combiner()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public Java.Util.Function.BinaryOperator CombinerDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.BinaryOperatorDirect, Java.Util.Function.BinaryOperator>("combiner", "()Ljava/util/function/BinaryOperator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#finisher()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function Finisher()
        {
            return IExecuteWithSignature<Java.Util.Function.Function>("finisher", "()Ljava/util/function/Function;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#finisher()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function FinisherDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.FunctionDirect, Java.Util.Function.Function>("finisher", "()Ljava/util/function/Function;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#supplier()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Supplier"/></returns>
        public Java.Util.Function.Supplier Supplier()
        {
            return IExecuteWithSignature<Java.Util.Function.Supplier>("supplier", "()Ljava/util/function/Supplier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#supplier()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Supplier"/></returns>
        public Java.Util.Function.Supplier SupplierDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.SupplierDirect, Java.Util.Function.Supplier>("supplier", "()Ljava/util/function/Supplier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#characteristics()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set CharacteristicsMethod()
        {
            return IExecuteWithSignature<Java.Util.Set>("characteristics", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Nested classes
        #region Characteristics implementation
        public partial class Characteristics
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/stream/Collector.Characteristics.html#CONCURRENT"/>
            /// </summary>
            public static Java.Util.Stream.Collector.Characteristics CONCURRENT { get { if (!_CONCURRENTReady) { _CONCURRENTContent = SGetField<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "CONCURRENT"); _CONCURRENTReady = true; } return _CONCURRENTContent; } }
            private static Java.Util.Stream.Collector.Characteristics _CONCURRENTContent = default;
            private static bool _CONCURRENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/stream/Collector.Characteristics.html#IDENTITY_FINISH"/>
            /// </summary>
            public static Java.Util.Stream.Collector.Characteristics IDENTITY_FINISH { get { if (!_IDENTITY_FINISHReady) { _IDENTITY_FINISHContent = SGetField<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "IDENTITY_FINISH"); _IDENTITY_FINISHReady = true; } return _IDENTITY_FINISHContent; } }
            private static Java.Util.Stream.Collector.Characteristics _IDENTITY_FINISHContent = default;
            private static bool _IDENTITY_FINISHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/stream/Collector.Characteristics.html#UNORDERED"/>
            /// </summary>
            public static Java.Util.Stream.Collector.Characteristics UNORDERED { get { if (!_UNORDEREDReady) { _UNORDEREDContent = SGetField<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "UNORDERED"); _UNORDEREDReady = true; } return _UNORDEREDContent; } }
            private static Java.Util.Stream.Collector.Characteristics _UNORDEREDContent = default;
            private static bool _UNORDEREDReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/stream/Collector.Characteristics.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Util.Stream.Collector.Characteristics"/></returns>
            public static Java.Util.Stream.Collector.Characteristics ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/util/stream/Collector$Characteristics;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/stream/Collector.Characteristics.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Stream.Collector.Characteristics"/></returns>
            public static Java.Util.Stream.Collector.Characteristics[] Values()
            {
                return SExecuteWithSignatureArray<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "values", "()[Ljava/util/stream/Collector$Characteristics;");
            }
        
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

    #region ICollector<T, A, R>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICollector<T, A, R>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region Collector<T, A, R> implementation
    public partial class Collector<T, A, R> : Java.Util.Stream.ICollector<T, A, R>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Stream.Collector{T, A, R}"/> to <see cref="Java.Util.Stream.Collector"/>
        /// </summary>
        public static implicit operator Java.Util.Stream.Collector(Java.Util.Stream.Collector<T, A, R> t) => t.Cast<Java.Util.Stream.Collector>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.function.Function,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg4"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector<T, A, R> Of(Java.Util.Function.Supplier<A> arg0, Java.Util.Function.BiConsumer<A, T> arg1, Java.Util.Function.BinaryOperator<A> arg2, Java.Util.Function.Function<A, R> arg3, params Java.Util.Stream.Collector.Characteristics[] arg4)
        {
            if (arg4.Length == 0) return SExecuteWithSignature<Java.Util.Stream.Collector<T, A, R>>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3); else return SExecuteWithSignature<Java.Util.Stream.Collector<T, A, R>>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector<T, R, R> Of(Java.Util.Function.Supplier<R> arg0, Java.Util.Function.BiConsumer<R, T> arg1, Java.Util.Function.BinaryOperator<R> arg2, params Java.Util.Stream.Collector.Characteristics[] arg3)
        {
            if (arg3.Length == 0) return SExecuteWithSignature<Java.Util.Stream.Collector<T, R, R>>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2); else return SExecuteWithSignature<Java.Util.Stream.Collector<T, R, R>>(LocalBridgeClazz, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#accumulator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public Java.Util.Function.BiConsumer<A, T> Accumulator()
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumer<A, T>>("accumulator", "()Ljava/util/function/BiConsumer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#accumulator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiConsumer"/></returns>
        public Java.Util.Function.BiConsumer<A, T> AccumulatorDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.BiConsumerDirect<A, T>, Java.Util.Function.BiConsumer<A, T>>("accumulator", "()Ljava/util/function/BiConsumer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#combiner()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public Java.Util.Function.BinaryOperator<A> Combiner()
        {
            return IExecuteWithSignature<Java.Util.Function.BinaryOperator<A>>("combiner", "()Ljava/util/function/BinaryOperator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#combiner()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public Java.Util.Function.BinaryOperator<A> CombinerDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.BinaryOperatorDirect<A>, Java.Util.Function.BinaryOperator<A>>("combiner", "()Ljava/util/function/BinaryOperator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#finisher()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function<A, R> Finisher()
        {
            return IExecuteWithSignature<Java.Util.Function.Function<A, R>>("finisher", "()Ljava/util/function/Function;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#finisher()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function<A, R> FinisherDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.FunctionDirect<A, R>, Java.Util.Function.Function<A, R>>("finisher", "()Ljava/util/function/Function;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#supplier()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Supplier"/></returns>
        public Java.Util.Function.Supplier<A> Supplier()
        {
            return IExecuteWithSignature<Java.Util.Function.Supplier<A>>("supplier", "()Ljava/util/function/Supplier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#supplier()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Supplier"/></returns>
        public Java.Util.Function.Supplier<A> SupplierDirect()
        {
            return IExecuteWithSignature<Java.Util.Function.SupplierDirect<A>, Java.Util.Function.Supplier<A>>("supplier", "()Ljava/util/function/Supplier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/Collector.html#characteristics()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Util.Stream.Collector.Characteristics> CharacteristicsMethod()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Util.Stream.Collector.Characteristics>>("characteristics", "()Ljava/util/Set;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}