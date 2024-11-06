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

namespace Android.Widget
{
    #region ShareActionProvider declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.html"/>
    /// </summary>
    public partial class ShareActionProvider : Android.View.ActionProvider
    {
        const string _bridgeClassName = "android.widget.ShareActionProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ShareActionProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ShareActionProvider(params object[] args) : base(args) { }
    
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
        #region OnShareTargetSelectedListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.OnShareTargetSelectedListener.html"/>
        /// </summary>
        public partial class OnShareTargetSelectedListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnShareTargetSelectedListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.ShareActionProvider_OnShareTargetSelectedListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnShareTargetSelectedListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnShareTargetSelectedListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnShareTargetSelectedListenerDirect : OnShareTargetSelectedListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.widget.ShareActionProvider$OnShareTargetSelectedListener";
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

    #region ShareActionProvider implementation
    public partial class ShareActionProvider
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ShareActionProvider(Android.Content.Context arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.html#DEFAULT_SHARE_HISTORY_FILE_NAME"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_SHARE_HISTORY_FILE_NAME { get { if (!_DEFAULT_SHARE_HISTORY_FILE_NAMEReady) { _DEFAULT_SHARE_HISTORY_FILE_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_SHARE_HISTORY_FILE_NAME"); _DEFAULT_SHARE_HISTORY_FILE_NAMEReady = true; } return _DEFAULT_SHARE_HISTORY_FILE_NAMEContent; } }
        private static Java.Lang.String _DEFAULT_SHARE_HISTORY_FILE_NAMEContent = default;
        private static bool _DEFAULT_SHARE_HISTORY_FILE_NAMEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.html#setOnShareTargetSelectedListener(android.widget.ShareActionProvider.OnShareTargetSelectedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ShareActionProvider.OnShareTargetSelectedListener"/></param>
        public void SetOnShareTargetSelectedListener(Android.Widget.ShareActionProvider.OnShareTargetSelectedListener arg0)
        {
            IExecuteWithSignature("setOnShareTargetSelectedListener", "(Landroid/widget/ShareActionProvider$OnShareTargetSelectedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.html#setShareHistoryFileName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetShareHistoryFileName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setShareHistoryFileName", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.html#setShareIntent(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        public void SetShareIntent(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("setShareIntent", "(Landroid/content/Intent;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region OnShareTargetSelectedListener implementation
        public partial class OnShareTargetSelectedListener
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
            /// Handlers initializer for <see cref="OnShareTargetSelectedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onShareTargetSelected", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnShareTargetSelectedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.OnShareTargetSelectedListener.html#onShareTargetSelected(android.widget.ShareActionProvider,android.content.Intent)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnShareTargetSelected"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.Widget.ShareActionProvider, Android.Content.Intent, bool> OnOnShareTargetSelected { get; set; } = null;
            
            bool hasOverrideOnShareTargetSelected = true;
            void OnShareTargetSelectedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnShareTargetSelected = true;
                var methodToExecute = (OnOnShareTargetSelected != null) ? OnOnShareTargetSelected : OnShareTargetSelected;
                var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.ShareActionProvider>(0), data.EventData.GetAt<Android.Content.Intent>(1));
                data.EventData.TypedEventData.SetReturnData(hasOverrideOnShareTargetSelected, executionResult);
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.OnShareTargetSelectedListener.html#onShareTargetSelected(android.widget.ShareActionProvider,android.content.Intent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.ShareActionProvider"/></param>
            /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnShareTargetSelected(Android.Widget.ShareActionProvider arg0, Android.Content.Intent arg1)
            {
                hasOverrideOnShareTargetSelected = false; return default;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnShareTargetSelectedListenerDirect implementation
        public partial class OnShareTargetSelectedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/ShareActionProvider.OnShareTargetSelectedListener.html#onShareTargetSelected(android.widget.ShareActionProvider,android.content.Intent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.ShareActionProvider"/></param>
            /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnShareTargetSelected(Android.Widget.ShareActionProvider arg0, Android.Content.Intent arg1)
            {
                return IExecuteWithSignature<bool>("onShareTargetSelected", "(Landroid/widget/ShareActionProvider;Landroid/content/Intent;)Z", arg0, arg1);
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