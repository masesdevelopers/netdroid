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

namespace Android.Webkit
{
    #region DownloadListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html"/>
    /// </summary>
    public partial class DownloadListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DownloadListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.android.webkit.DownloadListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region DownloadListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="DownloadListener"/> or its generic type if there is one
    /// </summary>
    public partial class DownloadListenerDirect : DownloadListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "android.webkit.DownloadListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region IDownloadListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.webkit.DownloadListener implementing <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html"/>
    /// </summary>
    public partial interface IDownloadListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DownloadListener implementation
    public partial class DownloadListener : Android.Webkit.IDownloadListener
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
        /// Handlers initializer for <see cref="DownloadListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onDownloadStart", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnDownloadStartEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html#onDownloadStart(java.lang.String,java.lang.String,java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnDownloadStart"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String, Java.Lang.String, Java.Lang.String, Java.Lang.String, long> OnOnDownloadStart { get; set; } = null;

        bool hasOverrideOnDownloadStart = true;
        void OnDownloadStartEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnDownloadStart = true;
            var methodToExecute = (OnOnDownloadStart != null) ? OnOnDownloadStart : OnDownloadStart;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Java.Lang.String>(1), data.EventData.GetAt<Java.Lang.String>(2), data.EventData.GetAt<Java.Lang.String>(3), data.EventData.GetAt<long>(4));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnDownloadStart;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html#onDownloadStart(java.lang.String,java.lang.String,java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        public virtual void OnDownloadStart(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, long arg4)
        {
            hasOverrideOnDownloadStart = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DownloadListenerDirect implementation
    public partial class DownloadListenerDirect : Android.Webkit.IDownloadListener
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
        /// <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html#onDownloadStart(java.lang.String,java.lang.String,java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        public override void OnDownloadStart(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, long arg4)
        {
            IExecuteWithSignature("onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}