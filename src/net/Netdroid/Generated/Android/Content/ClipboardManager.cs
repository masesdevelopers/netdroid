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

namespace Android.Content
{
    #region ClipboardManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html"/>
    /// </summary>
    public partial class ClipboardManager : Android.Text.ClipboardManager
    {
        const string _bridgeClassName = "android.content.ClipboardManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ClipboardManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ClipboardManager(params object[] args) : base(args) { }
    
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
        #region OnPrimaryClipChangedListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.OnPrimaryClipChangedListener.html"/>
        /// </summary>
        public partial class OnPrimaryClipChangedListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnPrimaryClipChangedListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.content.ClipboardManager_OnPrimaryClipChangedListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnPrimaryClipChangedListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnPrimaryClipChangedListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnPrimaryClipChangedListenerDirect : OnPrimaryClipChangedListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.content.ClipboardManager$OnPrimaryClipChangedListener";
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
            public override bool IsBridgeStatic => true;
        }
        #endregion

    
    }
    #endregion

    #region ClipboardManager implementation
    public partial class ClipboardManager
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
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#getPrimaryClip()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ClipData"/></returns>
        public Android.Content.ClipData GetPrimaryClip()
        {
            return IExecuteWithSignature<Android.Content.ClipData>("getPrimaryClip", "()Landroid/content/ClipData;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#getPrimaryClipDescription()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ClipDescription"/></returns>
        public Android.Content.ClipDescription GetPrimaryClipDescription()
        {
            return IExecuteWithSignature<Android.Content.ClipDescription>("getPrimaryClipDescription", "()Landroid/content/ClipDescription;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#hasPrimaryClip()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPrimaryClip()
        {
            return IExecuteWithSignature<bool>("hasPrimaryClip", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#addPrimaryClipChangedListener(android.content.ClipboardManager.OnPrimaryClipChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ClipboardManager.OnPrimaryClipChangedListener"/></param>
        public void AddPrimaryClipChangedListener(Android.Content.ClipboardManager.OnPrimaryClipChangedListener arg0)
        {
            IExecuteWithSignature("addPrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#clearPrimaryClip()"/>
        /// </summary>
        public void ClearPrimaryClip()
        {
            IExecuteWithSignature("clearPrimaryClip", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#removePrimaryClipChangedListener(android.content.ClipboardManager.OnPrimaryClipChangedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ClipboardManager.OnPrimaryClipChangedListener"/></param>
        public void RemovePrimaryClipChangedListener(Android.Content.ClipboardManager.OnPrimaryClipChangedListener arg0)
        {
            IExecuteWithSignature("removePrimaryClipChangedListener", "(Landroid/content/ClipboardManager$OnPrimaryClipChangedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.html#setPrimaryClip(android.content.ClipData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ClipData"/></param>
        public void SetPrimaryClip(Android.Content.ClipData arg0)
        {
            IExecuteWithSignature("setPrimaryClip", "(Landroid/content/ClipData;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region OnPrimaryClipChangedListener implementation
        public partial class OnPrimaryClipChangedListener
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
            /// Handlers initializer for <see cref="OnPrimaryClipChangedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onPrimaryClipChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnPrimaryClipChangedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/content/ClipboardManager.OnPrimaryClipChangedListener.html#onPrimaryClipChanged()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnPrimaryClipChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnPrimaryClipChanged { get; set; } = null;
            
            bool hasOverrideOnPrimaryClipChanged = true;
            void OnPrimaryClipChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnPrimaryClipChanged = true;
                var methodToExecute = (OnOnPrimaryClipChanged != null) ? OnOnPrimaryClipChanged : OnPrimaryClipChanged;
                methodToExecute.Invoke();
                data.EventData.TypedEventData.HasOverride = hasOverrideOnPrimaryClipChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.OnPrimaryClipChangedListener.html#onPrimaryClipChanged()"/>
            /// </summary>
            public virtual void OnPrimaryClipChanged()
            {
                hasOverrideOnPrimaryClipChanged = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnPrimaryClipChangedListenerDirect implementation
        public partial class OnPrimaryClipChangedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/content/ClipboardManager.OnPrimaryClipChangedListener.html#onPrimaryClipChanged()"/>
            /// </summary>
            public override void OnPrimaryClipChanged()
            {
                IExecuteWithSignature("onPrimaryClipChanged", "()V");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}