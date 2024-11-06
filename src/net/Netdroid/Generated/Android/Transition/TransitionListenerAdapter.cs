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

namespace Android.Transition
{
    #region TransitionListenerAdapter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html"/>
    /// </summary>
    public partial class TransitionListenerAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TransitionListenerAdapter() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.android.transition.TransitionListenerAdapter";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region TransitionListenerAdapterDirect declaration
    /// <summary>
    /// Direct override of <see cref="TransitionListenerAdapter"/> or its generic type if there is one
    /// </summary>
    public partial class TransitionListenerAdapterDirect : TransitionListenerAdapter
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "android.transition.TransitionListenerAdapter";
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region TransitionListenerAdapter implementation
    public partial class TransitionListenerAdapter
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
        /// Handlers initializer for <see cref="TransitionListenerAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onTransitionCancel", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnTransitionCancelEventHandler));
            AddEventHandler("onTransitionEnd", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnTransitionEndEventHandler));
            AddEventHandler("onTransitionPause", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnTransitionPauseEventHandler));
            AddEventHandler("onTransitionResume", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnTransitionResumeEventHandler));
            AddEventHandler("onTransitionStart", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnTransitionStartEventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionCancel(android.transition.Transition)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnTransitionCancel"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Transition.Transition> OnOnTransitionCancel { get; set; } = null;
        
        bool hasOverrideOnTransitionCancel = true;
        void OnTransitionCancelEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnTransitionCancel = true;
            var methodToExecute = (OnOnTransitionCancel != null) ? OnOnTransitionCancel : OnTransitionCancel;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Transition.Transition>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnTransitionCancel;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionCancel(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public virtual void OnTransitionCancel(Android.Transition.Transition arg0)
        {
            hasOverrideOnTransitionCancel = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionEnd(android.transition.Transition)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnTransitionEnd"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Transition.Transition> OnOnTransitionEnd { get; set; } = null;
        
        bool hasOverrideOnTransitionEnd = true;
        void OnTransitionEndEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnTransitionEnd = true;
            var methodToExecute = (OnOnTransitionEnd != null) ? OnOnTransitionEnd : OnTransitionEnd;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Transition.Transition>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnTransitionEnd;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionEnd(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public virtual void OnTransitionEnd(Android.Transition.Transition arg0)
        {
            hasOverrideOnTransitionEnd = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionPause(android.transition.Transition)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnTransitionPause"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Transition.Transition> OnOnTransitionPause { get; set; } = null;
        
        bool hasOverrideOnTransitionPause = true;
        void OnTransitionPauseEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnTransitionPause = true;
            var methodToExecute = (OnOnTransitionPause != null) ? OnOnTransitionPause : OnTransitionPause;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Transition.Transition>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnTransitionPause;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionPause(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public virtual void OnTransitionPause(Android.Transition.Transition arg0)
        {
            hasOverrideOnTransitionPause = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionResume(android.transition.Transition)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnTransitionResume"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Transition.Transition> OnOnTransitionResume { get; set; } = null;
        
        bool hasOverrideOnTransitionResume = true;
        void OnTransitionResumeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnTransitionResume = true;
            var methodToExecute = (OnOnTransitionResume != null) ? OnOnTransitionResume : OnTransitionResume;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Transition.Transition>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnTransitionResume;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionResume(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public virtual void OnTransitionResume(Android.Transition.Transition arg0)
        {
            hasOverrideOnTransitionResume = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionStart(android.transition.Transition)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnTransitionStart"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Transition.Transition> OnOnTransitionStart { get; set; } = null;
        
        bool hasOverrideOnTransitionStart = true;
        void OnTransitionStartEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnTransitionStart = true;
            var methodToExecute = (OnOnTransitionStart != null) ? OnOnTransitionStart : OnTransitionStart;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Transition.Transition>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnTransitionStart;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionStart(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public virtual void OnTransitionStart(Android.Transition.Transition arg0)
        {
            hasOverrideOnTransitionStart = false;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region TransitionListenerAdapterDirect implementation
    public partial class TransitionListenerAdapterDirect
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
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionCancel(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public override void OnTransitionCancel(Android.Transition.Transition arg0)
        {
            IExecuteWithSignature("onTransitionCancel", "(Landroid/transition/Transition;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionEnd(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public override void OnTransitionEnd(Android.Transition.Transition arg0)
        {
            IExecuteWithSignature("onTransitionEnd", "(Landroid/transition/Transition;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionPause(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public override void OnTransitionPause(Android.Transition.Transition arg0)
        {
            IExecuteWithSignature("onTransitionPause", "(Landroid/transition/Transition;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionResume(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public override void OnTransitionResume(Android.Transition.Transition arg0)
        {
            IExecuteWithSignature("onTransitionResume", "(Landroid/transition/Transition;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/transition/TransitionListenerAdapter.html#onTransitionStart(android.transition.Transition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Transition.Transition"/></param>
        public override void OnTransitionStart(Android.Transition.Transition arg0)
        {
            IExecuteWithSignature("onTransitionStart", "(Landroid/transition/Transition;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}