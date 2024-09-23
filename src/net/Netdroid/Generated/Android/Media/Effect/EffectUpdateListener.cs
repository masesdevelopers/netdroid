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

namespace Android.Media.Effect
{
    #region EffectUpdateListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/effect/EffectUpdateListener.html"/>
    /// </summary>
    public partial class EffectUpdateListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EffectUpdateListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.android.media.effect.EffectUpdateListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region EffectUpdateListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="EffectUpdateListener"/> or its generic type if there is one
    /// </summary>
    public partial class EffectUpdateListenerDirect : EffectUpdateListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "android.media.effect.EffectUpdateListener";
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

    #region IEffectUpdateListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.media.effect.EffectUpdateListener implementing <see href="https://developer.android.com/reference/android/media/effect/EffectUpdateListener.html"/>
    /// </summary>
    public partial interface IEffectUpdateListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EffectUpdateListener implementation
    public partial class EffectUpdateListener : Android.Media.Effect.IEffectUpdateListener
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
        /// Handlers initializer for <see cref="EffectUpdateListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onEffectUpdated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnEffectUpdatedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/media/effect/EffectUpdateListener.html#onEffectUpdated(android.media.effect.Effect,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnEffectUpdated"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Media.Effect.Effect, object> OnOnEffectUpdated { get; set; } = null;

        bool hasOverrideOnEffectUpdated = true;
        void OnEffectUpdatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnEffectUpdated = true;
            var methodToExecute = (OnOnEffectUpdated != null) ? OnOnEffectUpdated : OnEffectUpdated;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Media.Effect.Effect>(0), data.EventData.GetAt<object>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnEffectUpdated;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectUpdateListener.html#onEffectUpdated(android.media.effect.Effect,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Effect.Effect"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public virtual void OnEffectUpdated(Android.Media.Effect.Effect arg0, object arg1)
        {
            hasOverrideOnEffectUpdated = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EffectUpdateListenerDirect implementation
    public partial class EffectUpdateListenerDirect : Android.Media.Effect.IEffectUpdateListener
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
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectUpdateListener.html#onEffectUpdated(android.media.effect.Effect,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Effect.Effect"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public override void OnEffectUpdated(Android.Media.Effect.Effect arg0, object arg1)
        {
            IExecute("onEffectUpdated", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}