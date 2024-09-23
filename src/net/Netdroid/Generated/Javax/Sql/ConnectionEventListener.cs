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

namespace Javax.Sql
{
    #region ConnectionEventListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html"/>
    /// </summary>
    public partial class ConnectionEventListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConnectionEventListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.javax.sql.ConnectionEventListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ConnectionEventListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="ConnectionEventListener"/> or its generic type if there is one
    /// </summary>
    public partial class ConnectionEventListenerDirect : ConnectionEventListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.sql.ConnectionEventListener";
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

    #region IConnectionEventListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.javax.sql.ConnectionEventListener implementing <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html"/>
    /// </summary>
    public partial interface IConnectionEventListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectionEventListener implementation
    public partial class ConnectionEventListener : Javax.Sql.IConnectionEventListener
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
        /// Handlers initializer for <see cref="ConnectionEventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("connectionClosed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConnectionClosedEventHandler));
            AddEventHandler("connectionErrorOccurred", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ConnectionErrorOccurredEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html#connectionClosed(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnConnectionClosed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Sql.ConnectionEvent> OnConnectionClosed { get; set; } = null;

        bool hasOverrideConnectionClosed = true;
        void ConnectionClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideConnectionClosed = true;
            var methodToExecute = (OnConnectionClosed != null) ? OnConnectionClosed : ConnectionClosed;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Sql.ConnectionEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideConnectionClosed;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html#connectionClosed(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        public virtual void ConnectionClosed(Javax.Sql.ConnectionEvent arg0)
        {
            hasOverrideConnectionClosed = false;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html#connectionErrorOccurred(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnConnectionErrorOccurred"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Sql.ConnectionEvent> OnConnectionErrorOccurred { get; set; } = null;

        bool hasOverrideConnectionErrorOccurred = true;
        void ConnectionErrorOccurredEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideConnectionErrorOccurred = true;
            var methodToExecute = (OnConnectionErrorOccurred != null) ? OnConnectionErrorOccurred : ConnectionErrorOccurred;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Sql.ConnectionEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideConnectionErrorOccurred;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html#connectionErrorOccurred(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        public virtual void ConnectionErrorOccurred(Javax.Sql.ConnectionEvent arg0)
        {
            hasOverrideConnectionErrorOccurred = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConnectionEventListenerDirect implementation
    public partial class ConnectionEventListenerDirect : Javax.Sql.IConnectionEventListener
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
        /// <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html#connectionClosed(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        public override void ConnectionClosed(Javax.Sql.ConnectionEvent arg0)
        {
            IExecuteWithSignature("connectionClosed", "(Ljavax/sql/ConnectionEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/ConnectionEventListener.html#connectionErrorOccurred(javax.sql.ConnectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.ConnectionEvent"/></param>
        public override void ConnectionErrorOccurred(Javax.Sql.ConnectionEvent arg0)
        {
            IExecuteWithSignature("connectionErrorOccurred", "(Ljavax/sql/ConnectionEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}