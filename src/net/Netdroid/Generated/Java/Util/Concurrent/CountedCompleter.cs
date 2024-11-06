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
    #region CountedCompleter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html"/>
    /// </summary>
    public partial class CountedCompleter : Java.Util.Concurrent.ForkJoinTask
    {
        const string _bridgeClassName = "java.util.concurrent.CountedCompleter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CountedCompleter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CountedCompleter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CountedCompleter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CountedCompleter(params object[] args) : base(args) { }
    
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

    #region CountedCompleter<T> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class CountedCompleter<T> : Java.Util.Concurrent.ForkJoinTask<T>
    {
        const string _bridgeClassName = "java.util.concurrent.CountedCompleter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CountedCompleter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CountedCompleter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CountedCompleter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CountedCompleter(params object[] args) : base(args) { }
    
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

    #region CountedCompleter implementation
    public partial class CountedCompleter
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
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#compute()"/>
        /// </summary>
        public void Compute()
        {
            IExecuteWithSignature("compute", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#onExceptionalCompletion(java.lang.Throwable,java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnExceptionalCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, Java.Util.Concurrent.CountedCompleter arg1)
        {
            return IExecuteWithSignature<bool>("onExceptionalCompletion", "(Ljava/lang/Throwable;Ljava/util/concurrent/CountedCompleter;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#compareAndSetPendingCount(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetPendingCount(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("compareAndSetPendingCount", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#decrementPendingCountUnlessZero()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DecrementPendingCountUnlessZero()
        {
            return IExecuteWithSignature<int>("decrementPendingCountUnlessZero", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#getPendingCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPendingCount()
        {
            return IExecuteWithSignature<int>("getPendingCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#firstComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter FirstComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("firstComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#getCompleter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter GetCompleter()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("getCompleter", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#getRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter GetRoot()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("getRoot", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#nextComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter NextComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("nextComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#addToPendingCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddToPendingCount(int arg0)
        {
            IExecuteWithSignature("addToPendingCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#helpComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void HelpComplete(int arg0)
        {
            IExecuteWithSignature("helpComplete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#propagateCompletion()"/>
        /// </summary>
        public void PropagateCompletion()
        {
            IExecuteWithSignature("propagateCompletion", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#quietlyCompleteRoot()"/>
        /// </summary>
        public void QuietlyCompleteRoot()
        {
            IExecuteWithSignature("quietlyCompleteRoot", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#setPendingCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPendingCount(int arg0)
        {
            IExecuteWithSignature("setPendingCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#tryComplete()"/>
        /// </summary>
        public void TryComplete()
        {
            IExecuteWithSignature("tryComplete", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#onCompletion(java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        public void OnCompletion(Java.Util.Concurrent.CountedCompleter arg0)
        {
            IExecuteWithSignature("onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region CountedCompleter<T> implementation
    public partial class CountedCompleter<T>
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CountedCompleter{T}"/> to <see cref="Java.Util.Concurrent.CountedCompleter"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.CountedCompleter(Java.Util.Concurrent.CountedCompleter<T> t) => t.Cast<Java.Util.Concurrent.CountedCompleter>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#compute()"/>
        /// </summary>
        public void Compute()
        {
            IExecuteWithSignature("compute", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#onExceptionalCompletion(java.lang.Throwable,java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnExceptionalCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, Java.Util.Concurrent.CountedCompleter<object> arg1)
        {
            return IExecuteWithSignature<bool>("onExceptionalCompletion", "(Ljava/lang/Throwable;Ljava/util/concurrent/CountedCompleter;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#compareAndSetPendingCount(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetPendingCount(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("compareAndSetPendingCount", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#decrementPendingCountUnlessZero()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DecrementPendingCountUnlessZero()
        {
            return IExecuteWithSignature<int>("decrementPendingCountUnlessZero", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#getPendingCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPendingCount()
        {
            return IExecuteWithSignature<int>("getPendingCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#firstComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter<object> FirstComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("firstComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#getCompleter()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter<object> GetCompleter()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("getCompleter", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#getRoot()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter<object> GetRoot()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("getRoot", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#nextComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter<object> NextComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("nextComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#addToPendingCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddToPendingCount(int arg0)
        {
            IExecuteWithSignature("addToPendingCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#helpComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void HelpComplete(int arg0)
        {
            IExecuteWithSignature("helpComplete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#propagateCompletion()"/>
        /// </summary>
        public void PropagateCompletion()
        {
            IExecuteWithSignature("propagateCompletion", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#quietlyCompleteRoot()"/>
        /// </summary>
        public void QuietlyCompleteRoot()
        {
            IExecuteWithSignature("quietlyCompleteRoot", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#setPendingCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetPendingCount(int arg0)
        {
            IExecuteWithSignature("setPendingCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#tryComplete()"/>
        /// </summary>
        public void TryComplete()
        {
            IExecuteWithSignature("tryComplete", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CountedCompleter.html#onCompletion(java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        public void OnCompletion(Java.Util.Concurrent.CountedCompleter<object> arg0)
        {
            IExecuteWithSignature("onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}