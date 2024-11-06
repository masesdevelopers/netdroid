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
    #region Chronometer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html"/>
    /// </summary>
    public partial class Chronometer : Android.Widget.TextView
    {
        const string _bridgeClassName = "android.widget.Chronometer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Chronometer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Chronometer(params object[] args) : base(args) { }
    
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
        #region OnChronometerTickListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.OnChronometerTickListener.html"/>
        /// </summary>
        public partial class OnChronometerTickListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnChronometerTickListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.Chronometer_OnChronometerTickListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnChronometerTickListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnChronometerTickListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnChronometerTickListenerDirect : OnChronometerTickListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.widget.Chronometer$OnChronometerTickListener";
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

    #region Chronometer implementation
    public partial class Chronometer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public Chronometer(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public Chronometer(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public Chronometer(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public Chronometer(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#getOnChronometerTickListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Chronometer.OnChronometerTickListener"/></returns>
        public Android.Widget.Chronometer.OnChronometerTickListener GetOnChronometerTickListener()
        {
            return IExecuteWithSignature<Android.Widget.Chronometer.OnChronometerTickListener>("getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#getOnChronometerTickListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Chronometer.OnChronometerTickListener"/></returns>
        public Android.Widget.Chronometer.OnChronometerTickListener GetOnChronometerTickListenerDirect()
        {
            return IExecuteWithSignature<Android.Widget.Chronometer.OnChronometerTickListenerDirect, Android.Widget.Chronometer.OnChronometerTickListener>("getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#isCountDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCountDown()
        {
            return IExecuteWithSignature<bool>("isCountDown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#isTheFinalCountDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTheFinalCountDown()
        {
            return IExecuteWithSignature<bool>("isTheFinalCountDown", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#getFormat()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFormat()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#getBase()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetBase()
        {
            return IExecuteWithSignature<long>("getBase", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setBase(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetBase(long arg0)
        {
            IExecuteWithSignature("setBase", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setCountDown(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCountDown(bool arg0)
        {
            IExecuteWithSignature("setCountDown", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetFormat(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setFormat", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#setOnChronometerTickListener(android.widget.Chronometer.OnChronometerTickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.Chronometer.OnChronometerTickListener"/></param>
        public void SetOnChronometerTickListener(Android.Widget.Chronometer.OnChronometerTickListener arg0)
        {
            IExecuteWithSignature("setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Chronometer.html#stop()"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }
    
        #endregion
    
        #region Nested classes
        #region OnChronometerTickListener implementation
        public partial class OnChronometerTickListener
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
            /// Handlers initializer for <see cref="OnChronometerTickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onChronometerTick", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnChronometerTickEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/Chronometer.OnChronometerTickListener.html#onChronometerTick(android.widget.Chronometer)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnChronometerTick"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.Chronometer> OnOnChronometerTick { get; set; } = null;
            
            bool hasOverrideOnChronometerTick = true;
            void OnChronometerTickEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnChronometerTick = true;
                var methodToExecute = (OnOnChronometerTick != null) ? OnOnChronometerTick : OnChronometerTick;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Widget.Chronometer>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnChronometerTick;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Chronometer.OnChronometerTickListener.html#onChronometerTick(android.widget.Chronometer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.Chronometer"/></param>
            public virtual void OnChronometerTick(Android.Widget.Chronometer arg0)
            {
                hasOverrideOnChronometerTick = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnChronometerTickListenerDirect implementation
        public partial class OnChronometerTickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/Chronometer.OnChronometerTickListener.html#onChronometerTick(android.widget.Chronometer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.Chronometer"/></param>
            public override void OnChronometerTick(Android.Widget.Chronometer arg0)
            {
                IExecuteWithSignature("onChronometerTick", "(Landroid/widget/Chronometer;)V", arg0);
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