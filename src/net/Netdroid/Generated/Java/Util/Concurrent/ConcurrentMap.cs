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

namespace Java.Util.Concurrent
{
    #region ConcurrentMap declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html"/>
    /// </summary>
    public partial class ConcurrentMap : Java.Util.Map
    {
        const string _bridgeClassName = "java.util.concurrent.ConcurrentMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConcurrentMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConcurrentMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentMap(params object[] args) : base(args) { }
    
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

    #region ConcurrentMap<K, V> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class ConcurrentMap<K, V> : Java.Util.Map<K, V>
    {
        const string _bridgeClassName = "java.util.concurrent.ConcurrentMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ConcurrentMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ConcurrentMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ConcurrentMap(params object[] args) : base(args) { }
    
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

    #region ConcurrentMap implementation
    public partial class ConcurrentMap
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
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Replace(object arg0, object arg1, object arg2)
        {
            return IExecuteWithSignature<bool>("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#putIfAbsent(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object PutIfAbsent(object arg0, object arg1)
        {
            return IExecuteWithSignature("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Replace(object arg0, object arg1)
        {
            return IExecuteWithSignature("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#compute(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object Compute(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecuteWithSignature("compute", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#computeIfAbsent(java.lang.Object,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfAbsent(object arg0, Java.Util.Function.Function arg1)
        {
            return IExecuteWithSignature("computeIfAbsent", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#computeIfPresent(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfPresent(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecuteWithSignature("computeIfPresent", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#getOrDefault(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetOrDefault(object arg0, object arg1)
        {
            return IExecuteWithSignature("getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#merge(java.lang.Object,java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object Merge(object arg0, object arg1, Java.Util.Function.BiFunction arg2)
        {
            return IExecuteWithSignature("merge", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#forEach(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        public void ForEach(Java.Util.Function.BiConsumer arg0)
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/BiConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#replaceAll(java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        public void ReplaceAll(Java.Util.Function.BiFunction arg0)
        {
            IExecuteWithSignature("replaceAll", "(Ljava/util/function/BiFunction;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IConcurrentMap<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IConcurrentMap<K, V> : Java.Util.IMap<K, V>
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region ConcurrentMap<K, V> implementation
    public partial class ConcurrentMap<K, V> : Java.Util.Concurrent.IConcurrentMap<K, V>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentMap{K, V}"/> to <see cref="Java.Util.Concurrent.ConcurrentMap"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentMap(Java.Util.Concurrent.ConcurrentMap<K, V> t) => t.Cast<Java.Util.Concurrent.ConcurrentMap>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Replace(K arg0, V arg1, V arg2)
        {
            return IExecuteWithSignature<bool>("replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#putIfAbsent(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V PutIfAbsent(K arg0, V arg1)
        {
            return IExecuteWithSignature<V>("putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V Replace(K arg0, V arg1)
        {
            return IExecuteWithSignature<V>("replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#compute(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg1ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V Compute<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV>(K arg0, Java.Util.Function.BiFunction<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV> arg1) where Arg1objectSuperK : K where Arg1objectSuperV : V where Arg1ExtendsV : V
        {
            return IExecuteWithSignature<V>("compute", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#computeIfAbsent(java.lang.Object,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V ComputeIfAbsent<Arg1objectSuperK, Arg1ExtendsV>(K arg0, Java.Util.Function.Function<Arg1objectSuperK, Arg1ExtendsV> arg1) where Arg1objectSuperK : K where Arg1ExtendsV : V
        {
            return IExecuteWithSignature<V>("computeIfAbsent", "(Ljava/lang/Object;Ljava/util/function/Function;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#computeIfPresent(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <typeparam name="Arg1objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg1objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg1ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V ComputeIfPresent<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV>(K arg0, Java.Util.Function.BiFunction<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV> arg1) where Arg1objectSuperK : K where Arg1objectSuperV : V where Arg1ExtendsV : V
        {
            return IExecuteWithSignature<V>("computeIfPresent", "(Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#getOrDefault(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V GetOrDefault(object arg0, V arg1)
        {
            return IExecuteWithSignature<V>("getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#merge(java.lang.Object,java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <typeparam name="Arg2objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg2ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V Merge<Arg2objectSuperV, Arg2ExtendsV>(K arg0, V arg1, Java.Util.Function.BiFunction<Arg2objectSuperV, Arg2objectSuperV, Arg2ExtendsV> arg2) where Arg2objectSuperV : V where Arg2ExtendsV : V
        {
            return IExecuteWithSignature<V>("merge", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/function/BiFunction;)Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#forEach(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="Arg0objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        public void ForEach<Arg0objectSuperK, Arg0objectSuperV>(Java.Util.Function.BiConsumer<Arg0objectSuperK, Arg0objectSuperV> arg0) where Arg0objectSuperK : K where Arg0objectSuperV : V
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/BiConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/ConcurrentMap.html#replaceAll(java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <typeparam name="Arg0objectSuperK"><typeparamref name="K"/></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        public void ReplaceAll<Arg0objectSuperK, Arg0objectSuperV, Arg0ExtendsV>(Java.Util.Function.BiFunction<Arg0objectSuperK, Arg0objectSuperV, Arg0ExtendsV> arg0) where Arg0objectSuperK : K where Arg0objectSuperV : V where Arg0ExtendsV : V
        {
            IExecuteWithSignature("replaceAll", "(Ljava/util/function/BiFunction;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}