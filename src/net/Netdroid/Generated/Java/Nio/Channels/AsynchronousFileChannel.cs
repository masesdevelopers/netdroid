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

namespace Java.Nio.Channels
{
    #region AsynchronousFileChannel declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html"/>
    /// </summary>
    public partial class AsynchronousFileChannel : Java.Nio.Channels.AsynchronousChannel
    {
        const string _bridgeClassName = "java.nio.channels.AsynchronousFileChannel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AsynchronousFileChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsynchronousFileChannel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AsynchronousFileChannel class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AsynchronousFileChannel(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region AsynchronousFileChannel implementation
    public partial class AsynchronousFileChannel
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#open(java.nio.file.Path,java.nio.file.OpenOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.OpenOption"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousFileChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousFileChannel Open(Java.Nio.File.Path arg0, params Java.Nio.File.OpenOption[] arg1)
        {
            if (arg1.Length == 0) return SExecuteWithSignature<Java.Nio.Channels.AsynchronousFileChannel>(LocalBridgeClazz, "open", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/AsynchronousFileChannel;", arg0); else return SExecuteWithSignature<Java.Nio.Channels.AsynchronousFileChannel>(LocalBridgeClazz, "open", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#open(java.nio.file.Path,java.util.Set,java.util.concurrent.ExecutorService,java.nio.file.attribute.FileAttribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <param name="arg3"><see cref="Java.Nio.File.Attribute.FileAttribute"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_OpenOption"><see cref="Java.Nio.File.OpenOption"/></typeparam>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousFileChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.AsynchronousFileChannel Open<Arg1ExtendsJava_Nio_File_OpenOption>(Java.Nio.File.Path arg0, Java.Util.Set<Arg1ExtendsJava_Nio_File_OpenOption> arg1, Java.Util.Concurrent.ExecutorService arg2, params Java.Nio.File.Attribute.FileAttribute<object>[] arg3) where Arg1ExtendsJava_Nio_File_OpenOption : Java.Nio.File.OpenOption
        {
            if (arg3.Length == 0) return SExecuteWithSignature<Java.Nio.Channels.AsynchronousFileChannel>(LocalBridgeClazz, "open", "(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1, arg2); else return SExecuteWithSignature<Java.Nio.Channels.AsynchronousFileChannel>(LocalBridgeClazz, "open", "(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#lock(long,long,boolean,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><typeparamref name="A"/></param>
        /// <param name="arg4"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg4objectSuperA"><typeparamref name="A"/></typeparam>
        public void Lock<A, Arg4objectSuperA>(long arg0, long arg1, bool arg2, A arg3, Java.Nio.Channels.CompletionHandler<Java.Nio.Channels.FileLock, Arg4objectSuperA> arg4) where Arg4objectSuperA : A
        {
            IExecuteWithSignature("lock", "(JJZLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#read(java.nio.ByteBuffer,long,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><typeparamref name="A"/></param>
        /// <param name="arg3"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg3objectSuperA"><typeparamref name="A"/></typeparam>
        public void Read<A, Arg3objectSuperA>(Java.Nio.ByteBuffer arg0, long arg1, A arg2, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg3objectSuperA> arg3) where Arg3objectSuperA : A
        {
            IExecuteWithSignature("read", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#write(java.nio.ByteBuffer,long,java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><typeparamref name="A"/></param>
        /// <param name="arg3"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg3objectSuperA"><typeparamref name="A"/></typeparam>
        public void Write<A, Arg3objectSuperA>(Java.Nio.ByteBuffer arg0, long arg1, A arg2, Java.Nio.Channels.CompletionHandler<Java.Lang.Integer, Arg3objectSuperA> arg3) where Arg3objectSuperA : A
        {
            IExecuteWithSignature("write", "(Ljava/nio/ByteBuffer;JLjava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#truncate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousFileChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousFileChannel Truncate(long arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.AsynchronousFileChannel>("truncate", "(J)Ljava/nio/channels/AsynchronousFileChannel;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#tryLock(long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Nio.Channels.FileLock"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.FileLock TryLock(long arg0, long arg1, bool arg2)
        {
            return IExecuteWithSignature<Java.Nio.Channels.FileLock>("tryLock", "(JJZ)Ljava/nio/channels/FileLock;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#read(java.nio.ByteBuffer,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Integer> Read(Java.Nio.ByteBuffer arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Lang.Integer>>("read", "(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#write(java.nio.ByteBuffer,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Lang.Integer> Write(Java.Nio.ByteBuffer arg0, long arg1)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Lang.Integer>>("write", "(Ljava/nio/ByteBuffer;J)Ljava/util/concurrent/Future;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#lock(long,long,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Nio.Channels.FileLock> Lock(long arg0, long arg1, bool arg2)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Nio.Channels.FileLock>>("lock", "(JJZ)Ljava/util/concurrent/Future;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#size()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Size()
        {
            return IExecuteWithSignature<long>("size", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#force(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Force(bool arg0)
        {
            IExecuteWithSignature("force", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#lock(java.lang.Object,java.nio.channels.CompletionHandler)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="A"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Channels.CompletionHandler"/></param>
        /// <typeparam name="A"></typeparam>
        /// <typeparam name="Arg1objectSuperA"><typeparamref name="A"/></typeparam>
        public void Lock<A, Arg1objectSuperA>(A arg0, Java.Nio.Channels.CompletionHandler<Java.Nio.Channels.FileLock, Arg1objectSuperA> arg1) where Arg1objectSuperA : A
        {
            IExecuteWithSignature("lock", "(Ljava/lang/Object;Ljava/nio/channels/CompletionHandler;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#tryLock()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.Channels.FileLock"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.FileLock TryLock()
        {
            return IExecuteWithSignature<Java.Nio.Channels.FileLock>("tryLock", "()Ljava/nio/channels/FileLock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/AsynchronousFileChannel.html#lock()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Future"/></returns>
        public Java.Util.Concurrent.Future<Java.Nio.Channels.FileLock> Lock()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Future<Java.Nio.Channels.FileLock>>("lock", "()Ljava/util/concurrent/Future;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}