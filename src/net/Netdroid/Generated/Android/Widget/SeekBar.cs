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
    #region SeekBar declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/SeekBar.html"/>
    /// </summary>
    public partial class SeekBar : Android.Widget.AbsSeekBar
    {
        const string _bridgeClassName = "android.widget.SeekBar";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SeekBar() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SeekBar(params object[] args) : base(args) { }
    
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
        #region OnSeekBarChangeListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html"/>
        /// </summary>
        public partial class OnSeekBarChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnSeekBarChangeListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.SeekBar_OnSeekBarChangeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnSeekBarChangeListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnSeekBarChangeListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnSeekBarChangeListenerDirect : OnSeekBarChangeListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.widget.SeekBar$OnSeekBarChangeListener";
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

    #region SeekBar implementation
    public partial class SeekBar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public SeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SeekBar.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public SeekBar(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SeekBar.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public SeekBar(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/SeekBar.html#setOnSeekBarChangeListener(android.widget.SeekBar.OnSeekBarChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SeekBar.OnSeekBarChangeListener"/></param>
        public void SetOnSeekBarChangeListener(Android.Widget.SeekBar.OnSeekBarChangeListener arg0)
        {
            IExecuteWithSignature("setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region OnSeekBarChangeListener implementation
        public partial class OnSeekBarChangeListener
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
            /// Handlers initializer for <see cref="OnSeekBarChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onProgressChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnProgressChangedEventHandler));
                AddEventHandler("onStartTrackingTouch", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnStartTrackingTouchEventHandler));
                AddEventHandler("onStopTrackingTouch", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnStopTrackingTouchEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onProgressChanged(android.widget.SeekBar,int,boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnProgressChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.SeekBar, int, bool> OnOnProgressChanged { get; set; } = null;
            
            bool hasOverrideOnProgressChanged = true;
            void OnProgressChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnProgressChanged = true;
                var methodToExecute = (OnOnProgressChanged != null) ? OnOnProgressChanged : OnProgressChanged;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.SeekBar>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<bool>(2));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnProgressChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onProgressChanged(android.widget.SeekBar,int,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.SeekBar"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            public virtual void OnProgressChanged(Android.Widget.SeekBar arg0, int arg1, bool arg2)
            {
                hasOverrideOnProgressChanged = false;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onStartTrackingTouch(android.widget.SeekBar)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnStartTrackingTouch"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.SeekBar> OnOnStartTrackingTouch { get; set; } = null;
            
            bool hasOverrideOnStartTrackingTouch = true;
            void OnStartTrackingTouchEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnStartTrackingTouch = true;
                var methodToExecute = (OnOnStartTrackingTouch != null) ? OnOnStartTrackingTouch : OnStartTrackingTouch;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.SeekBar>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnStartTrackingTouch;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onStartTrackingTouch(android.widget.SeekBar)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.SeekBar"/></param>
            public virtual void OnStartTrackingTouch(Android.Widget.SeekBar arg0)
            {
                hasOverrideOnStartTrackingTouch = false;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onStopTrackingTouch(android.widget.SeekBar)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnStopTrackingTouch"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.SeekBar> OnOnStopTrackingTouch { get; set; } = null;
            
            bool hasOverrideOnStopTrackingTouch = true;
            void OnStopTrackingTouchEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnStopTrackingTouch = true;
                var methodToExecute = (OnOnStopTrackingTouch != null) ? OnOnStopTrackingTouch : OnStopTrackingTouch;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.SeekBar>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnStopTrackingTouch;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onStopTrackingTouch(android.widget.SeekBar)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.SeekBar"/></param>
            public virtual void OnStopTrackingTouch(Android.Widget.SeekBar arg0)
            {
                hasOverrideOnStopTrackingTouch = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnSeekBarChangeListenerDirect implementation
        public partial class OnSeekBarChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onProgressChanged(android.widget.SeekBar,int,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.SeekBar"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            public override void OnProgressChanged(Android.Widget.SeekBar arg0, int arg1, bool arg2)
            {
                IExecuteWithSignature("onProgressChanged", "(Landroid/widget/SeekBar;IZ)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onStartTrackingTouch(android.widget.SeekBar)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.SeekBar"/></param>
            public override void OnStartTrackingTouch(Android.Widget.SeekBar arg0)
            {
                IExecuteWithSignature("onStartTrackingTouch", "(Landroid/widget/SeekBar;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SeekBar.OnSeekBarChangeListener.html#onStopTrackingTouch(android.widget.SeekBar)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.SeekBar"/></param>
            public override void OnStopTrackingTouch(Android.Widget.SeekBar arg0)
            {
                IExecuteWithSignature("onStopTrackingTouch", "(Landroid/widget/SeekBar;)V", arg0);
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