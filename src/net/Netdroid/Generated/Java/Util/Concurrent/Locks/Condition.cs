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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent.Locks
{
    #region ICondition
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICondition
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#await(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        bool Await(long arg0, Java.Util.Concurrent.TimeUnit arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#awaitUntil(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        bool AwaitUntil(Java.Util.Date arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#awaitNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        long AwaitNanos(long arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#await()"/>
        /// </summary>
        /// <exception cref="Java.Lang.InterruptedException"/>
        void Await();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#awaitUninterruptibly()"/>
        /// </summary>
        void AwaitUninterruptibly();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#signal()"/>
        /// </summary>
        void Signal();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#signalAll()"/>
        /// </summary>
        void SignalAll();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Condition
    public partial class Condition : Java.Util.Concurrent.Locks.ICondition
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#await(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool Await(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("await", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#awaitUntil(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool AwaitUntil(Java.Util.Date arg0)
        {
            return IExecuteWithSignature<bool>("awaitUntil", "(Ljava/util/Date;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#awaitNanos(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long AwaitNanos(long arg0)
        {
            return IExecuteWithSignature<long>("awaitNanos", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#await()"/>
        /// </summary>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Await()
        {
            IExecuteWithSignature("await", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#awaitUninterruptibly()"/>
        /// </summary>
        public void AwaitUninterruptibly()
        {
            IExecuteWithSignature("awaitUninterruptibly", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#signal()"/>
        /// </summary>
        public void Signal()
        {
            IExecuteWithSignature("signal", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/concurrent/locks/Condition.html#signalAll()"/>
        /// </summary>
        public void SignalAll()
        {
            IExecuteWithSignature("signalAll", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}