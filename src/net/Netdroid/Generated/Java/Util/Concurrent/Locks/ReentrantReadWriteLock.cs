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

namespace Java.Util.Concurrent.Locks
{
    #region ReentrantReadWriteLock declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html"/>
    /// </summary>
    public partial class ReentrantReadWriteLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReentrantReadWriteLock>
    {
        const string _bridgeClassName = "java.util.concurrent.locks.ReentrantReadWriteLock";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReentrantReadWriteLock() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReentrantReadWriteLock(params object[] args) : base(args) { }

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
        #region ReadLock declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html"/>
        /// </summary>
        public partial class ReadLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReadLock>
        {
            const string _bridgeClassName = "java.util.concurrent.locks.ReentrantReadWriteLock$ReadLock";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ReadLock() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ReadLock(params object[] args) : base(args) { }

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

        #region WriteLock declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html"/>
        /// </summary>
        public partial class WriteLock : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WriteLock>
        {
            const string _bridgeClassName = "java.util.concurrent.locks.ReentrantReadWriteLock$WriteLock";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public WriteLock() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public WriteLock(params object[] args) : base(args) { }

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

    #region ReentrantReadWriteLock implementation
    public partial class ReentrantReadWriteLock : Java.Util.Concurrent.Locks.IReadWriteLock, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public ReentrantReadWriteLock(bool arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantReadWriteLock"/> to <see cref="Java.Util.Concurrent.Locks.ReadWriteLock"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Locks.ReadWriteLock(Java.Util.Concurrent.Locks.ReentrantReadWriteLock t) => t.Cast<Java.Util.Concurrent.Locks.ReadWriteLock>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantReadWriteLock"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.ReentrantReadWriteLock t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#hasWaiters(java.util.concurrent.locks.Condition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.Condition"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasWaiters(Java.Util.Concurrent.Locks.Condition arg0)
        {
            return IExecuteWithSignature<bool>("hasWaiters", "(Ljava/util/concurrent/locks/Condition;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#isWriteLocked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWriteLocked()
        {
            return IExecuteWithSignature<bool>("isWriteLocked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#isWriteLockedByCurrentThread()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWriteLockedByCurrentThread()
        {
            return IExecuteWithSignature<bool>("isWriteLockedByCurrentThread", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#hasQueuedThread(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedThread(Java.Lang.Thread arg0)
        {
            return IExecuteWithSignature<bool>("hasQueuedThread", "(Ljava/lang/Thread;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#hasQueuedThreads()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedThreads()
        {
            return IExecuteWithSignature<bool>("hasQueuedThreads", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#isFair()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFair()
        {
            return IExecuteWithSignature<bool>("isFair", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#getQueueLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetQueueLength()
        {
            return IExecuteWithSignature<int>("getQueueLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#getReadHoldCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReadHoldCount()
        {
            return IExecuteWithSignature<int>("getReadHoldCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#getReadLockCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReadLockCount()
        {
            return IExecuteWithSignature<int>("getReadLockCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#getWaitQueueLength(java.util.concurrent.locks.Condition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.Condition"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetWaitQueueLength(Java.Util.Concurrent.Locks.Condition arg0)
        {
            return IExecuteWithSignature<int>("getWaitQueueLength", "(Ljava/util/concurrent/locks/Condition;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#getWriteHoldCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWriteHoldCount()
        {
            return IExecuteWithSignature<int>("getWriteHoldCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#readLock()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Locks.Lock"/></returns>
        public Java.Util.Concurrent.Locks.Lock ReadLockMethod()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Locks.Lock>("readLock", "()Ljava/util/concurrent/locks/Lock;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.html#writeLock()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Locks.Lock"/></returns>
        public Java.Util.Concurrent.Locks.Lock WriteLockMethod()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Locks.Lock>("writeLock", "()Ljava/util/concurrent/locks/Lock;");
        }

        #endregion

        #region Nested classes
        #region ReadLock implementation
        public partial class ReadLock : Java.Util.Concurrent.Locks.ILock, Java.Io.ISerializable
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantReadWriteLock.ReadLock"/> to <see cref="Java.Util.Concurrent.Locks.Lock"/>
            /// </summary>
            public static implicit operator Java.Util.Concurrent.Locks.Lock(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.ReadLock t) => t.Cast<Java.Util.Concurrent.Locks.Lock>();
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantReadWriteLock.ReadLock"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.ReadLock t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#tryLock()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool TryLock()
            {
                return IExecuteWithSignature<bool>("tryLock", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#tryLock(long,java.util.concurrent.TimeUnit)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public bool TryLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
            {
                return IExecute<bool>("tryLock", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#newCondition()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Concurrent.Locks.Condition"/></returns>
            public Java.Util.Concurrent.Locks.Condition NewCondition()
            {
                return IExecuteWithSignature<Java.Util.Concurrent.Locks.Condition>("newCondition", "()Ljava/util/concurrent/locks/Condition;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#lock()"/>
            /// </summary>
            public void Lock()
            {
                IExecuteWithSignature("lock", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#lockInterruptibly()"/>
            /// </summary>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void LockInterruptibly()
            {
                IExecuteWithSignature("lockInterruptibly", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#unlock()"/>
            /// </summary>
            public void Unlock()
            {
                IExecuteWithSignature("unlock", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region WriteLock implementation
        public partial class WriteLock : Java.Util.Concurrent.Locks.ILock, Java.Io.ISerializable
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantReadWriteLock.WriteLock"/> to <see cref="Java.Util.Concurrent.Locks.Lock"/>
            /// </summary>
            public static implicit operator Java.Util.Concurrent.Locks.Lock(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.WriteLock t) => t.Cast<Java.Util.Concurrent.Locks.Lock>();
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantReadWriteLock.WriteLock"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.WriteLock t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#isHeldByCurrentThread()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsHeldByCurrentThread()
            {
                return IExecuteWithSignature<bool>("isHeldByCurrentThread", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#tryLock()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool TryLock()
            {
                return IExecuteWithSignature<bool>("tryLock", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#tryLock(long,java.util.concurrent.TimeUnit)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public bool TryLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
            {
                return IExecute<bool>("tryLock", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#getHoldCount()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetHoldCount()
            {
                return IExecuteWithSignature<int>("getHoldCount", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#newCondition()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Concurrent.Locks.Condition"/></returns>
            public Java.Util.Concurrent.Locks.Condition NewCondition()
            {
                return IExecuteWithSignature<Java.Util.Concurrent.Locks.Condition>("newCondition", "()Ljava/util/concurrent/locks/Condition;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#lock()"/>
            /// </summary>
            public void Lock()
            {
                IExecuteWithSignature("lock", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#lockInterruptibly()"/>
            /// </summary>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void LockInterruptibly()
            {
                IExecuteWithSignature("lockInterruptibly", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#unlock()"/>
            /// </summary>
            public void Unlock()
            {
                IExecuteWithSignature("unlock", "()V");
            }

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
}