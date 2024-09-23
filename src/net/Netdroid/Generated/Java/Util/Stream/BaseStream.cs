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

namespace Java.Util.Stream
{
    #region BaseStream declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html"/>
    /// </summary>
    public partial class BaseStream : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "java.util.stream.BaseStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BaseStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BaseStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BaseStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BaseStream(params object[] args) : base(args) { }

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

    #region BaseStream<T, S> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="S"><see cref="Java.Util.Stream.BaseStream{T, S}"/></typeparam>
    public partial class BaseStream<T, S> : Java.Lang.AutoCloseable where S : Java.Util.Stream.BaseStream<T, S>
    {
        const string _bridgeClassName = "java.util.stream.BaseStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BaseStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BaseStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BaseStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BaseStream(params object[] args) : base(args) { }

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

    #region BaseStream implementation
    public partial class BaseStream
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
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#isParallel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsParallel()
        {
            return IExecuteWithSignature<bool>("isParallel", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#spliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator>("spliterator", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#onClose(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream OnClose(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("onClose", "(Ljava/lang/Runnable;)Ljava/util/stream/BaseStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#parallel()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Parallel()
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("parallel", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#sequential()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Sequential()
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("sequential", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#unordered()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Unordered()
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("unordered", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IBaseStream<T, S>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBaseStream<T, S> : Java.Lang.IAutoCloseable
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BaseStream<T, S> implementation
    public partial class BaseStream<T, S> : Java.Util.Stream.IBaseStream<T, S>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Stream.BaseStream{T, S}"/> to <see cref="Java.Util.Stream.BaseStream"/>
        /// </summary>
        public static implicit operator Java.Util.Stream.BaseStream(Java.Util.Stream.BaseStream<T, S> t) => t.Cast<Java.Util.Stream.BaseStream>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#isParallel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsParallel()
        {
            return IExecuteWithSignature<bool>("isParallel", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<T> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<T>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#spliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator<T> Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator<T>>("spliterator", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#onClose(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><typeparamref name="S"/></returns>
        public S OnClose(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<S>("onClose", "(Ljava/lang/Runnable;)Ljava/util/stream/BaseStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#parallel()"/>
        /// </summary>
        /// <returns><typeparamref name="S"/></returns>
        public S Parallel()
        {
            return IExecuteWithSignature<S>("parallel", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#sequential()"/>
        /// </summary>
        /// <returns><typeparamref name="S"/></returns>
        public S Sequential()
        {
            return IExecuteWithSignature<S>("sequential", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#unordered()"/>
        /// </summary>
        /// <returns><typeparamref name="S"/></returns>
        public S Unordered()
        {
            return IExecuteWithSignature<S>("unordered", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/BaseStream.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}