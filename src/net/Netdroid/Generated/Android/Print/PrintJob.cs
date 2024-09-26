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

namespace Android.Print
{
    #region PrintJob declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/print/PrintJob.html"/>
    /// </summary>
    public partial class PrintJob : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PrintJob>
    {
        const string _bridgeClassName = "android.print.PrintJob";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintJob() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrintJob(params object[] args) : base(args) { }

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

    #region PrintJob implementation
    public partial class PrintJob
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
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrintJobId"/></returns>
        public Android.Print.PrintJobId GetId()
        {
            return IExecuteWithSignature<Android.Print.PrintJobId>("getId", "()Landroid/print/PrintJobId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#getInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Print.PrintJobInfo"/></returns>
        public Android.Print.PrintJobInfo GetInfo()
        {
            return IExecuteWithSignature<Android.Print.PrintJobInfo>("getInfo", "()Landroid/print/PrintJobInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#isBlocked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBlocked()
        {
            return IExecuteWithSignature<bool>("isBlocked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#isCancelled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCancelled()
        {
            return IExecuteWithSignature<bool>("isCancelled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#isCompleted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompleted()
        {
            return IExecuteWithSignature<bool>("isCompleted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#isFailed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFailed()
        {
            return IExecuteWithSignature<bool>("isFailed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#isQueued()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsQueued()
        {
            return IExecuteWithSignature<bool>("isQueued", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#isStarted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStarted()
        {
            return IExecuteWithSignature<bool>("isStarted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/print/PrintJob.html#restart()"/>
        /// </summary>
        public void Restart()
        {
            IExecuteWithSignature("restart", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}