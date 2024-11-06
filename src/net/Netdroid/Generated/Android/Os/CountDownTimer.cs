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

namespace Android.Os
{
    #region CountDownTimer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/CountDownTimer.html"/>
    /// </summary>
    public partial class CountDownTimer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CountDownTimer>
    {
        const string _bridgeClassName = "android.os.CountDownTimer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CountDownTimer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CountDownTimer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CountDownTimer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CountDownTimer(params object[] args) : base(args) { }
    
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

    #region CountDownTimer implementation
    public partial class CountDownTimer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CountDownTimer.html#%3Cinit%3E(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public CountDownTimer(long arg0, long arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CountDownTimer.html#onFinish()"/>
        /// </summary>
        public void OnFinish()
        {
            IExecuteWithSignature("onFinish", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CountDownTimer.html#onTick(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void OnTick(long arg0)
        {
            IExecuteWithSignature("onTick", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CountDownTimer.html#start()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.CountDownTimer"/></returns>
        public Android.Os.CountDownTimer Start()
        {
            return IExecuteWithSignature<Android.Os.CountDownTimer>("start", "()Landroid/os/CountDownTimer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/CountDownTimer.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}