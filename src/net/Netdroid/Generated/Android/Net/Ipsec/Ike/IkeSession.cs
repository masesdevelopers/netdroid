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

namespace Android.Net.Ipsec.Ike
{
    #region IkeSession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSession.html"/>
    /// </summary>
    public partial class IkeSession : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.net.ipsec.ike.IkeSession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IkeSession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IkeSession(params object[] args) : base(args) { }

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

    #region IkeSession implementation
    public partial class IkeSession
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSession.html#%3Cinit%3E(android.content.Context,android.net.ipsec.ike.IkeSessionParams,android.net.ipsec.ike.ChildSessionParams,java.util.concurrent.Executor,android.net.ipsec.ike.IkeSessionCallback,android.net.ipsec.ike.ChildSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Net.Ipsec.Ike.IkeSessionParams"/></param>
        /// <param name="arg2"><see cref="Android.Net.Ipsec.Ike.ChildSessionParams"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg4"><see cref="Android.Net.Ipsec.Ike.IkeSessionCallback"/></param>
        /// <param name="arg5"><see cref="Android.Net.Ipsec.Ike.ChildSessionCallback"/></param>
        public IkeSession(Android.Content.Context arg0, Android.Net.Ipsec.Ike.IkeSessionParams arg1, Android.Net.Ipsec.Ike.ChildSessionParams arg2, Java.Util.Concurrent.Executor arg3, Android.Net.Ipsec.Ike.IkeSessionCallback arg4, Android.Net.Ipsec.Ike.ChildSessionCallback arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
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
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSession.html#closeChildSession(android.net.ipsec.ike.ChildSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.ChildSessionCallback"/></param>
        public void CloseChildSession(Android.Net.Ipsec.Ike.ChildSessionCallback arg0)
        {
            IExecuteWithSignature("closeChildSession", "(Landroid/net/ipsec/ike/ChildSessionCallback;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSession.html#dump(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        public void Dump(Java.Io.PrintWriter arg0)
        {
            IExecuteWithSignature("dump", "(Ljava/io/PrintWriter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSession.html#kill()"/>
        /// </summary>
        public void Kill()
        {
            IExecuteWithSignature("kill", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeSession.html#openChildSession(android.net.ipsec.ike.ChildSessionParams,android.net.ipsec.ike.ChildSessionCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Ipsec.Ike.ChildSessionParams"/></param>
        /// <param name="arg1"><see cref="Android.Net.Ipsec.Ike.ChildSessionCallback"/></param>
        public void OpenChildSession(Android.Net.Ipsec.Ike.ChildSessionParams arg0, Android.Net.Ipsec.Ike.ChildSessionCallback arg1)
        {
            IExecute("openChildSession", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}