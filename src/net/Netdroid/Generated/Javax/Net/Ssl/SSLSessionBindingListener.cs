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

namespace Javax.Net.Ssl
{
    #region SSLSessionBindingListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html"/>
    /// </summary>
    public partial class SSLSessionBindingListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SSLSessionBindingListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.javax.net.ssl.SSLSessionBindingListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region SSLSessionBindingListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="SSLSessionBindingListener"/> or its generic type if there is one
    /// </summary>
    public partial class SSLSessionBindingListenerDirect : SSLSessionBindingListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.net.ssl.SSLSessionBindingListener";
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

    #region ISSLSessionBindingListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.javax.net.ssl.SSLSessionBindingListener implementing <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html"/>
    /// </summary>
    public partial interface ISSLSessionBindingListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SSLSessionBindingListener implementation
    public partial class SSLSessionBindingListener : Javax.Net.Ssl.ISSLSessionBindingListener
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
        /// Handlers initializer for <see cref="SSLSessionBindingListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("valueBound", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ValueBoundEventHandler));
            AddEventHandler("valueUnbound", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ValueUnboundEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html#valueBound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnValueBound"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Net.Ssl.SSLSessionBindingEvent> OnValueBound { get; set; } = null;

        bool hasOverrideValueBound = true;
        void ValueBoundEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideValueBound = true;
            var methodToExecute = (OnValueBound != null) ? OnValueBound : ValueBound;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Net.Ssl.SSLSessionBindingEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideValueBound;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html#valueBound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        public virtual void ValueBound(Javax.Net.Ssl.SSLSessionBindingEvent arg0)
        {
            hasOverrideValueBound = false;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html#valueUnbound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnValueUnbound"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Net.Ssl.SSLSessionBindingEvent> OnValueUnbound { get; set; } = null;

        bool hasOverrideValueUnbound = true;
        void ValueUnboundEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideValueUnbound = true;
            var methodToExecute = (OnValueUnbound != null) ? OnValueUnbound : ValueUnbound;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Net.Ssl.SSLSessionBindingEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideValueUnbound;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html#valueUnbound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        public virtual void ValueUnbound(Javax.Net.Ssl.SSLSessionBindingEvent arg0)
        {
            hasOverrideValueUnbound = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SSLSessionBindingListenerDirect implementation
    public partial class SSLSessionBindingListenerDirect : Javax.Net.Ssl.ISSLSessionBindingListener
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
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html#valueBound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        public override void ValueBound(Javax.Net.Ssl.SSLSessionBindingEvent arg0)
        {
            IExecuteWithSignature("valueBound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/net/ssl/SSLSessionBindingListener.html#valueUnbound(javax.net.ssl.SSLSessionBindingEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLSessionBindingEvent"/></param>
        public override void ValueUnbound(Javax.Net.Ssl.SSLSessionBindingEvent arg0)
        {
            IExecuteWithSignature("valueUnbound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}