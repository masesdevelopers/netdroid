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
    #region TabHost declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/TabHost.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class TabHost : Android.Widget.FrameLayout
    {
        const string _bridgeClassName = "android.widget.TabHost";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TabHost() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TabHost(params object[] args) : base(args) { }
    
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
        #region OnTabChangeListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.OnTabChangeListener.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class OnTabChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnTabChangeListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.TabHost_OnTabChangeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnTabChangeListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnTabChangeListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnTabChangeListenerDirect : OnTabChangeListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.widget.TabHost$OnTabChangeListener";
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

        #region TabContentFactory declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabContentFactory.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class TabContentFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TabContentFactory>
        {
            const string _bridgeClassName = "android.widget.TabHost$TabContentFactory";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("TabContentFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public TabContentFactory() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("TabContentFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public TabContentFactory(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
        
            // TODO: complete the class
        
        }
        #endregion

        #region TabSpec declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class TabSpec : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TabSpec>
        {
            const string _bridgeClassName = "android.widget.TabHost$TabSpec";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public TabSpec() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public TabSpec(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region TabHost implementation
    public partial class TabHost
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [global::System.Obsolete()]
        public TabHost(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public TabHost(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public TabHost(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public TabHost(Android.Content.Context arg0)
            : base(arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#getCurrentTabView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        [global::System.Obsolete()]
        public Android.View.View GetCurrentTabView()
        {
            return IExecuteWithSignature<Android.View.View>("getCurrentTabView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#getCurrentView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        [global::System.Obsolete()]
        public Android.View.View GetCurrentView()
        {
            return IExecuteWithSignature<Android.View.View>("getCurrentView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#getTabContentView()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.FrameLayout"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.FrameLayout GetTabContentView()
        {
            return IExecuteWithSignature<Android.Widget.FrameLayout>("getTabContentView", "()Landroid/widget/FrameLayout;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#newTabSpec(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Widget.TabHost.TabSpec"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.TabHost.TabSpec NewTabSpec(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Widget.TabHost.TabSpec>("newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#getTabWidget()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.TabWidget"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.TabWidget GetTabWidget()
        {
            return IExecuteWithSignature<Android.Widget.TabWidget>("getTabWidget", "()Landroid/widget/TabWidget;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#getCurrentTab()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetCurrentTab()
        {
            return IExecuteWithSignature<int>("getCurrentTab", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#getCurrentTabTag()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetCurrentTabTag()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCurrentTabTag", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#addTab(android.widget.TabHost.TabSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TabHost.TabSpec"/></param>
        [global::System.Obsolete()]
        public void AddTab(Android.Widget.TabHost.TabSpec arg0)
        {
            IExecuteWithSignature("addTab", "(Landroid/widget/TabHost$TabSpec;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#clearAllTabs()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void ClearAllTabs()
        {
            IExecuteWithSignature("clearAllTabs", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#onTouchModeChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void OnTouchModeChanged(bool arg0)
        {
            IExecuteWithSignature("onTouchModeChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#setCurrentTab(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetCurrentTab(int arg0)
        {
            IExecuteWithSignature("setCurrentTab", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#setCurrentTabByTag(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void SetCurrentTabByTag(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setCurrentTabByTag", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#setOnTabChangedListener(android.widget.TabHost.OnTabChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TabHost.OnTabChangeListener"/></param>
        [global::System.Obsolete()]
        public void SetOnTabChangedListener(Android.Widget.TabHost.OnTabChangeListener arg0)
        {
            IExecuteWithSignature("setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#setup()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Setup()
        {
            IExecuteWithSignature("setup", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/TabHost.html#setup(android.app.LocalActivityManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.LocalActivityManager"/></param>
        [global::System.Obsolete()]
        public void Setup(Android.App.LocalActivityManager arg0)
        {
            IExecuteWithSignature("setup", "(Landroid/app/LocalActivityManager;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region OnTabChangeListener implementation
        public partial class OnTabChangeListener
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
            /// Handlers initializer for <see cref="OnTabChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onTabChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnTabChangedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/TabHost.OnTabChangeListener.html#onTabChanged(java.lang.String)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnTabChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Lang.String> OnOnTabChanged { get; set; } = null;
            
            bool hasOverrideOnTabChanged = true;
            void OnTabChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnTabChanged = true;
                var methodToExecute = (OnOnTabChanged != null) ? OnOnTabChanged : OnTabChanged;
                methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnTabChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.OnTabChangeListener.html#onTabChanged(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public virtual void OnTabChanged(Java.Lang.String arg0)
            {
                hasOverrideOnTabChanged = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnTabChangeListenerDirect implementation
        public partial class OnTabChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.OnTabChangeListener.html#onTabChanged(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            [global::System.Obsolete()]
            public override void OnTabChanged(Java.Lang.String arg0)
            {
                IExecuteWithSignature("onTabChanged", "(Ljava/lang/String;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region TabContentFactory implementation
        public partial class TabContentFactory
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
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabContentFactory.html#createTabContent(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.View"/></returns>
            [global::System.Obsolete()]
            public Android.View.View CreateTabContent(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.View>("createTabContent", "(Ljava/lang/String;)Landroid/view/View;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region TabSpec implementation
        public partial class TabSpec
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
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html#setContent(android.content.Intent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
            /// <returns><see cref="Android.Widget.TabHost.TabSpec"/></returns>
            [global::System.Obsolete()]
            public Android.Widget.TabHost.TabSpec SetContent(Android.Content.Intent arg0)
            {
                return IExecuteWithSignature<Android.Widget.TabHost.TabSpec>("setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html#setContent(android.widget.TabHost.TabContentFactory)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.TabHost.TabContentFactory"/></param>
            /// <returns><see cref="Android.Widget.TabHost.TabSpec"/></returns>
            [global::System.Obsolete()]
            public Android.Widget.TabHost.TabSpec SetContent(Android.Widget.TabHost.TabContentFactory arg0)
            {
                return IExecuteWithSignature<Android.Widget.TabHost.TabSpec>("setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html#setContent(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Widget.TabHost.TabSpec"/></returns>
            [global::System.Obsolete()]
            public Android.Widget.TabHost.TabSpec SetContent(int arg0)
            {
                return IExecuteWithSignature<Android.Widget.TabHost.TabSpec>("setContent", "(I)Landroid/widget/TabHost$TabSpec;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html#setIndicator(android.view.View)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <returns><see cref="Android.Widget.TabHost.TabSpec"/></returns>
            [global::System.Obsolete()]
            public Android.Widget.TabHost.TabSpec SetIndicator(Android.View.View arg0)
            {
                return IExecuteWithSignature<Android.Widget.TabHost.TabSpec>("setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html#setIndicator(java.lang.CharSequence,android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            /// <returns><see cref="Android.Widget.TabHost.TabSpec"/></returns>
            [global::System.Obsolete()]
            public Android.Widget.TabHost.TabSpec SetIndicator(Java.Lang.CharSequence arg0, Android.Graphics.Drawable.Drawable arg1)
            {
                return IExecuteWithSignature<Android.Widget.TabHost.TabSpec>("setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/TabHost$TabSpec;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html#setIndicator(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Widget.TabHost.TabSpec"/></returns>
            [global::System.Obsolete()]
            public Android.Widget.TabHost.TabSpec SetIndicator(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Widget.TabHost.TabSpec>("setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/TabHost.TabSpec.html#getTag()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            [global::System.Obsolete()]
            public Java.Lang.String GetTag()
            {
                return IExecuteWithSignature<Java.Lang.String>("getTag", "()Ljava/lang/String;");
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