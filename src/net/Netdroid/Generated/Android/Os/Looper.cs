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
    #region Looper declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/Looper.html"/>
    /// </summary>
    public partial class Looper : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Looper>
    {
        const string _bridgeClassName = "android.os.Looper";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Looper() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Looper(params object[] args) : base(args) { }
    
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

    #region Looper implementation
    public partial class Looper
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#getMainLooper()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Looper"/></returns>
        public static Android.Os.Looper GetMainLooper()
        {
            return SExecuteWithSignature<Android.Os.Looper>(LocalBridgeClazz, "getMainLooper", "()Landroid/os/Looper;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#myLooper()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Looper"/></returns>
        public static Android.Os.Looper MyLooper()
        {
            return SExecuteWithSignature<Android.Os.Looper>(LocalBridgeClazz, "myLooper", "()Landroid/os/Looper;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#myQueue()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.MessageQueue"/></returns>
        public static Android.Os.MessageQueue MyQueue()
        {
            return SExecuteWithSignature<Android.Os.MessageQueue>(LocalBridgeClazz, "myQueue", "()Landroid/os/MessageQueue;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#loop()"/>
        /// </summary>
        public static void Loop()
        {
            SExecuteWithSignature(LocalBridgeClazz, "loop", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#prepare()"/>
        /// </summary>
        public static void Prepare()
        {
            SExecuteWithSignature(LocalBridgeClazz, "prepare", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#prepareMainLooper()"/>
        /// </summary>
        [global::System.Obsolete()]
        public static void PrepareMainLooper()
        {
            SExecuteWithSignature(LocalBridgeClazz, "prepareMainLooper", "()V");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#getQueue()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.MessageQueue"/></returns>
        public Android.Os.MessageQueue GetQueue()
        {
            return IExecuteWithSignature<Android.Os.MessageQueue>("getQueue", "()Landroid/os/MessageQueue;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#isCurrentThread()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCurrentThread()
        {
            return IExecuteWithSignature<bool>("isCurrentThread", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#getThread()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Thread"/></returns>
        public Java.Lang.Thread GetThread()
        {
            return IExecuteWithSignature<Java.Lang.Thread>("getThread", "()Ljava/lang/Thread;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#quit()"/>
        /// </summary>
        public void Quit()
        {
            IExecuteWithSignature("quit", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#quitSafely()"/>
        /// </summary>
        public void QuitSafely()
        {
            IExecuteWithSignature("quitSafely", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Looper.html#setMessageLogging(android.util.Printer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        public void SetMessageLogging(Android.Util.Printer arg0)
        {
            IExecuteWithSignature("setMessageLogging", "(Landroid/util/Printer;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}