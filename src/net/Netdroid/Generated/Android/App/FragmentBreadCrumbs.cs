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

namespace Android.App
{
    #region FragmentBreadCrumbs declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class FragmentBreadCrumbs : Android.View.ViewGroup
    {
        const string _bridgeClassName = "android.app.FragmentBreadCrumbs";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FragmentBreadCrumbs() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FragmentBreadCrumbs(params object[] args) : base(args) { }

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
        #region OnBreadCrumbClickListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.OnBreadCrumbClickListener.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class OnBreadCrumbClickListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnBreadCrumbClickListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.app.FragmentBreadCrumbs_OnBreadCrumbClickListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region OnBreadCrumbClickListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnBreadCrumbClickListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnBreadCrumbClickListenerDirect : OnBreadCrumbClickListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.app.FragmentBreadCrumbs$OnBreadCrumbClickListener";
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

    #region FragmentBreadCrumbs implementation
    public partial class FragmentBreadCrumbs
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public FragmentBreadCrumbs(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public FragmentBreadCrumbs(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public FragmentBreadCrumbs(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#onBackStackChanged()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void OnBackStackChanged()
        {
            IExecuteWithSignature("onBackStackChanged", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setActivity(android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        [global::System.Obsolete()]
        public void SetActivity(Android.App.Activity arg0)
        {
            IExecuteWithSignature("setActivity", "(Landroid/app/Activity;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setMaxVisible(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetMaxVisible(int arg0)
        {
            IExecuteWithSignature("setMaxVisible", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setOnBreadCrumbClickListener(android.app.FragmentBreadCrumbs.OnBreadCrumbClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentBreadCrumbs.OnBreadCrumbClickListener"/></param>
        [global::System.Obsolete()]
        public void SetOnBreadCrumbClickListener(Android.App.FragmentBreadCrumbs.OnBreadCrumbClickListener arg0)
        {
            IExecuteWithSignature("setOnBreadCrumbClickListener", "(Landroid/app/FragmentBreadCrumbs$OnBreadCrumbClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setParentTitle(java.lang.CharSequence,java.lang.CharSequence,android.view.View.OnClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg2"><see cref="Android.View.View.OnClickListener"/></param>
        [global::System.Obsolete()]
        public void SetParentTitle(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1, Android.View.View.OnClickListener arg2)
        {
            IExecute("setParentTitle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.html#setTitle(java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void SetTitle(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1)
        {
            IExecute("setTitle", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region OnBreadCrumbClickListener implementation
        public partial class OnBreadCrumbClickListener
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
            /// Handlers initializer for <see cref="OnBreadCrumbClickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onBreadCrumbClick", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnBreadCrumbClickEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.OnBreadCrumbClickListener.html#onBreadCrumbClick(android.app.FragmentManager.BackStackEntry,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnBreadCrumbClick"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.App.FragmentManager.BackStackEntry, int, bool> OnOnBreadCrumbClick { get; set; } = null;

            bool hasOverrideOnBreadCrumbClick = true;
            void OnBreadCrumbClickEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnBreadCrumbClick = true;
                var methodToExecute = (OnOnBreadCrumbClick != null) ? OnOnBreadCrumbClick : OnBreadCrumbClick;
                var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.App.FragmentManager.BackStackEntry>(0), data.EventData.GetAt<int>(1));
                data.EventData.TypedEventData.SetReturnData(hasOverrideOnBreadCrumbClick, executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.OnBreadCrumbClickListener.html#onBreadCrumbClick(android.app.FragmentManager.BackStackEntry,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager.BackStackEntry"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            [global::System.Obsolete()]
            public virtual bool OnBreadCrumbClick(Android.App.FragmentManager.BackStackEntry arg0, int arg1)
            {
                hasOverrideOnBreadCrumbClick = false; return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnBreadCrumbClickListenerDirect implementation
        public partial class OnBreadCrumbClickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/FragmentBreadCrumbs.OnBreadCrumbClickListener.html#onBreadCrumbClick(android.app.FragmentManager.BackStackEntry,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.FragmentManager.BackStackEntry"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            [global::System.Obsolete()]
            public override bool OnBreadCrumbClick(Android.App.FragmentManager.BackStackEntry arg0, int arg1)
            {
                return IExecute<bool>("onBreadCrumbClick", arg0, arg1);
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