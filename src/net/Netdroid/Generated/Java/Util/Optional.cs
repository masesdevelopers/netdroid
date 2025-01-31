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

namespace Java.Util
{
    #region Optional declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/Optional.html"/>
    /// </summary>
    public partial class Optional : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Optional>
    {
        const string _bridgeClassName = "java.util.Optional";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Optional() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Optional(params object[] args) : base(args) { }
    
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

    #region Optional<T> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/Optional.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class Optional<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Optional<T>>
    {
        const string _bridgeClassName = "java.util.Optional";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Optional() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Optional(params object[] args) : base(args) { }
    
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

    #region Optional implementation
    public partial class Optional
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#empty()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional Empty()
        {
            return SExecuteWithSignature<Java.Util.Optional>(LocalBridgeClazz, "empty", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#of(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional Of(object arg0)
        {
            return SExecuteWithSignature<Java.Util.Optional>(LocalBridgeClazz, "of", "(Ljava/lang/Object;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#ofNullable(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional OfNullable(object arg0)
        {
            return SExecuteWithSignature<Java.Util.Optional>(LocalBridgeClazz, "ofNullable", "(Ljava/lang/Object;)Ljava/util/Optional;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#flatMap(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional FlatMap(Java.Util.Function.Function arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional>("flatMap", "(Ljava/util/function/Function;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#map(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional Map(Java.Util.Function.Function arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional>("map", "(Ljava/util/function/Function;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElseThrow(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public object OrElseThrow(Java.Util.Function.Supplier arg0)
        {
            return IExecuteWithSignature("orElseThrow", "(Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#isPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecuteWithSignature<bool>("isPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#filter(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional Filter(Java.Util.Function.Predicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional>("filter", "(Ljava/util/function/Predicate;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#or(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional Or(Java.Util.Function.Supplier arg0)
        {
            return IExecuteWithSignature<Java.Util.Optional>("or", "(Ljava/util/function/Supplier;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#stream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream Stream()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream>("stream", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#get()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElse(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object OrElse(object arg0)
        {
            return IExecuteWithSignature("orElse", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElseGet(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <returns><see cref="object"/></returns>
        public object OrElseGet(Java.Util.Function.Supplier arg0)
        {
            return IExecuteWithSignature("orElseGet", "(Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElseThrow()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object OrElseThrow()
        {
            return IExecuteWithSignature("orElseThrow", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#ifPresent(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void IfPresent(Java.Util.Function.Consumer arg0)
        {
            IExecuteWithSignature("ifPresent", "(Ljava/util/function/Consumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#ifPresentOrElse(java.util.function.Consumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void IfPresentOrElse(Java.Util.Function.Consumer arg0, Java.Lang.Runnable arg1)
        {
            IExecuteWithSignature("ifPresentOrElse", "(Ljava/util/function/Consumer;Ljava/lang/Runnable;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region Optional<T> implementation
    public partial class Optional<T>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Optional{T}"/> to <see cref="Java.Util.Optional"/>
        /// </summary>
        public static implicit operator Java.Util.Optional(Java.Util.Optional<T> t) => t.Cast<Java.Util.Optional>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#empty()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<T> Empty()
        {
            return SExecuteWithSignature<Java.Util.Optional<T>>(LocalBridgeClazz, "empty", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#of(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<T> Of(T arg0)
        {
            return SExecuteWithSignature<Java.Util.Optional<T>>(LocalBridgeClazz, "of", "(Ljava/lang/Object;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#ofNullable(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public static Java.Util.Optional<T> OfNullable(T arg0)
        {
            return SExecuteWithSignature<Java.Util.Optional<T>>(LocalBridgeClazz, "ofNullable", "(Ljava/lang/Object;)Ljava/util/Optional;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#flatMap(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_"><see cref="Java.Util.Optional{Arg0ExtendsU}"/></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<U> FlatMap<U, Arg0objectSuperT, Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_, Arg0ExtendsU>(Java.Util.Function.Function<Arg0objectSuperT, Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_> arg0) where Arg0objectSuperT : T where Arg0ExtendsJava_Util_Optional_Arg0ExtendsU_ : Java.Util.Optional<Arg0ExtendsU> where Arg0ExtendsU : U
        {
            return IExecuteWithSignature<Java.Util.Optional<U>>("flatMap", "(Ljava/util/function/Function;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#map(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<U> Map<U, Arg0objectSuperT, Arg0ExtendsU>(Java.Util.Function.Function<Arg0objectSuperT, Arg0ExtendsU> arg0) where Arg0objectSuperT : T where Arg0ExtendsU : U
        {
            return IExecuteWithSignature<Java.Util.Optional<U>>("map", "(Ljava/util/function/Function;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElseThrow(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsX"><typeparamref name="X"/></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public T OrElseThrow<Arg0ExtendsX, X>(Java.Util.Function.Supplier<Arg0ExtendsX> arg0) where Arg0ExtendsX : X
        {
            return IExecuteWithSignature<T>("orElseThrow", "(Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#isPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecuteWithSignature<bool>("isPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#filter(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<T> Filter<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.Optional<T>>("filter", "(Ljava/util/function/Predicate;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#or(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_"><see cref="Java.Util.Optional{Arg0ExtendsT}"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<T> Or<Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_, Arg0ExtendsT>(Java.Util.Function.Supplier<Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_> arg0) where Arg0ExtendsJava_Util_Optional_Arg0ExtendsT_ : Java.Util.Optional<Arg0ExtendsT> where Arg0ExtendsT : T
        {
            return IExecuteWithSignature<Java.Util.Optional<T>>("or", "(Ljava/util/function/Supplier;)Ljava/util/Optional;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#stream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<T> Stream()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<T>>("stream", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#get()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public T Get()
        {
            return IExecuteWithSignature<T>("get", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElse(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T OrElse(T arg0)
        {
            return IExecuteWithSignature<T>("orElse", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElseGet(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T OrElseGet<Arg0ExtendsT>(Java.Util.Function.Supplier<Arg0ExtendsT> arg0) where Arg0ExtendsT : T
        {
            return IExecuteWithSignature<T>("orElseGet", "(Ljava/util/function/Supplier;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#orElseThrow()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public T OrElseThrow()
        {
            return IExecuteWithSignature<T>("orElseThrow", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#ifPresent(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void IfPresent<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            IExecuteWithSignature("ifPresent", "(Ljava/util/function/Consumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Optional.html#ifPresentOrElse(java.util.function.Consumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void IfPresentOrElse<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0, Java.Lang.Runnable arg1) where Arg0objectSuperT : T
        {
            IExecuteWithSignature("ifPresentOrElse", "(Ljava/util/function/Consumer;Ljava/lang/Runnable;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}