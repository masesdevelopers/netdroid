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

namespace Android.View
{
    #region TextureView declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/TextureView.html"/>
    /// </summary>
    public partial class TextureView : Android.View.View
    {
        const string _bridgeClassName = "android.view.TextureView";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextureView() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextureView(params object[] args) : base(args) { }
    
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
        #region SurfaceTextureListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html"/>
        /// </summary>
        public partial class SurfaceTextureListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SurfaceTextureListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.view.TextureView_SurfaceTextureListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region SurfaceTextureListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="SurfaceTextureListener"/> or its generic type if there is one
        /// </summary>
        public partial class SurfaceTextureListenerDirect : SurfaceTextureListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.view.TextureView$SurfaceTextureListener";
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

    #region TextureView implementation
    public partial class TextureView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TextureView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TextureView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public TextureView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public TextureView(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#getBitmap()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetBitmap()
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getBitmap", "()Landroid/graphics/Bitmap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#getBitmap(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetBitmap(Android.Graphics.Bitmap arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#getBitmap(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap GetBitmap(int arg0, int arg1)
        {
            return IExecuteWithSignature<Android.Graphics.Bitmap>("getBitmap", "(II)Landroid/graphics/Bitmap;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#lockCanvas()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Canvas"/></returns>
        public Android.Graphics.Canvas LockCanvas()
        {
            return IExecuteWithSignature<Android.Graphics.Canvas>("lockCanvas", "()Landroid/graphics/Canvas;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#lockCanvas(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.Graphics.Canvas"/></returns>
        public Android.Graphics.Canvas LockCanvas(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Canvas>("lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#getTransform(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        /// <returns><see cref="Android.Graphics.Matrix"/></returns>
        public Android.Graphics.Matrix GetTransform(Android.Graphics.Matrix arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Matrix>("getTransform", "(Landroid/graphics/Matrix;)Landroid/graphics/Matrix;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#getSurfaceTexture()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.SurfaceTexture"/></returns>
        public Android.Graphics.SurfaceTexture GetSurfaceTexture()
        {
            return IExecuteWithSignature<Android.Graphics.SurfaceTexture>("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#getSurfaceTextureListener()"/>
        /// </summary>
        /// <returns><see cref="Android.View.TextureView.SurfaceTextureListener"/></returns>
        public Android.View.TextureView.SurfaceTextureListener GetSurfaceTextureListener()
        {
            return IExecuteWithSignature<Android.View.TextureView.SurfaceTextureListener>("getSurfaceTextureListener", "()Landroid/view/TextureView$SurfaceTextureListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#getSurfaceTextureListener()"/>
        /// </summary>
        /// <returns><see cref="Android.View.TextureView.SurfaceTextureListener"/></returns>
        public Android.View.TextureView.SurfaceTextureListener GetSurfaceTextureListenerDirect()
        {
            return IExecuteWithSignature<Android.View.TextureView.SurfaceTextureListenerDirect, Android.View.TextureView.SurfaceTextureListener>("getSurfaceTextureListener", "()Landroid/view/TextureView$SurfaceTextureListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#isAvailable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAvailable()
        {
            return IExecuteWithSignature<bool>("isAvailable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#setOpaque(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetOpaque(bool arg0)
        {
            IExecuteWithSignature("setOpaque", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#setSurfaceTexture(android.graphics.SurfaceTexture)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
        public void SetSurfaceTexture(Android.Graphics.SurfaceTexture arg0)
        {
            IExecuteWithSignature("setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#setSurfaceTextureListener(android.view.TextureView.SurfaceTextureListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.TextureView.SurfaceTextureListener"/></param>
        public void SetSurfaceTextureListener(Android.View.TextureView.SurfaceTextureListener arg0)
        {
            IExecuteWithSignature("setSurfaceTextureListener", "(Landroid/view/TextureView$SurfaceTextureListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#setTransform(android.graphics.Matrix)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Matrix"/></param>
        public void SetTransform(Android.Graphics.Matrix arg0)
        {
            IExecuteWithSignature("setTransform", "(Landroid/graphics/Matrix;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TextureView.html#unlockCanvasAndPost(android.graphics.Canvas)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        public void UnlockCanvasAndPost(Android.Graphics.Canvas arg0)
        {
            IExecuteWithSignature("unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region SurfaceTextureListener implementation
        public partial class SurfaceTextureListener
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
            /// Handlers initializer for <see cref="SurfaceTextureListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSurfaceTextureDestroyed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSurfaceTextureDestroyedEventHandler));
                AddEventHandler("onSurfaceTextureAvailable", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSurfaceTextureAvailableEventHandler));
                AddEventHandler("onSurfaceTextureSizeChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSurfaceTextureSizeChangedEventHandler));
                AddEventHandler("onSurfaceTextureUpdated", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSurfaceTextureUpdatedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureDestroyed(android.graphics.SurfaceTexture)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSurfaceTextureDestroyed"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Func<Android.Graphics.SurfaceTexture, bool> OnOnSurfaceTextureDestroyed { get; set; } = null;
            
            bool hasOverrideOnSurfaceTextureDestroyed = true;
            void OnSurfaceTextureDestroyedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnSurfaceTextureDestroyed = true;
                var methodToExecute = (OnOnSurfaceTextureDestroyed != null) ? OnOnSurfaceTextureDestroyed : OnSurfaceTextureDestroyed;
                var executionResult = methodToExecute.Invoke(data.EventData.GetAt<Android.Graphics.SurfaceTexture>(0));
                data.EventData.TypedEventData.SetReturnData(hasOverrideOnSurfaceTextureDestroyed, executionResult);
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureDestroyed(android.graphics.SurfaceTexture)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnSurfaceTextureDestroyed(Android.Graphics.SurfaceTexture arg0)
            {
                hasOverrideOnSurfaceTextureDestroyed = false; return default;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureAvailable(android.graphics.SurfaceTexture,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSurfaceTextureAvailable"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Graphics.SurfaceTexture, int, int> OnOnSurfaceTextureAvailable { get; set; } = null;
            
            bool hasOverrideOnSurfaceTextureAvailable = true;
            void OnSurfaceTextureAvailableEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnSurfaceTextureAvailable = true;
                var methodToExecute = (OnOnSurfaceTextureAvailable != null) ? OnOnSurfaceTextureAvailable : OnSurfaceTextureAvailable;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Graphics.SurfaceTexture>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnSurfaceTextureAvailable;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureAvailable(android.graphics.SurfaceTexture,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public virtual void OnSurfaceTextureAvailable(Android.Graphics.SurfaceTexture arg0, int arg1, int arg2)
            {
                hasOverrideOnSurfaceTextureAvailable = false;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureSizeChanged(android.graphics.SurfaceTexture,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSurfaceTextureSizeChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Graphics.SurfaceTexture, int, int> OnOnSurfaceTextureSizeChanged { get; set; } = null;
            
            bool hasOverrideOnSurfaceTextureSizeChanged = true;
            void OnSurfaceTextureSizeChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnSurfaceTextureSizeChanged = true;
                var methodToExecute = (OnOnSurfaceTextureSizeChanged != null) ? OnOnSurfaceTextureSizeChanged : OnSurfaceTextureSizeChanged;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Graphics.SurfaceTexture>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnSurfaceTextureSizeChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureSizeChanged(android.graphics.SurfaceTexture,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public virtual void OnSurfaceTextureSizeChanged(Android.Graphics.SurfaceTexture arg0, int arg1, int arg2)
            {
                hasOverrideOnSurfaceTextureSizeChanged = false;
            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureUpdated(android.graphics.SurfaceTexture)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSurfaceTextureUpdated"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Graphics.SurfaceTexture> OnOnSurfaceTextureUpdated { get; set; } = null;
            
            bool hasOverrideOnSurfaceTextureUpdated = true;
            void OnSurfaceTextureUpdatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnSurfaceTextureUpdated = true;
                var methodToExecute = (OnOnSurfaceTextureUpdated != null) ? OnOnSurfaceTextureUpdated : OnSurfaceTextureUpdated;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Graphics.SurfaceTexture>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnSurfaceTextureUpdated;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureUpdated(android.graphics.SurfaceTexture)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            public virtual void OnSurfaceTextureUpdated(Android.Graphics.SurfaceTexture arg0)
            {
                hasOverrideOnSurfaceTextureUpdated = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region SurfaceTextureListenerDirect implementation
        public partial class SurfaceTextureListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureDestroyed(android.graphics.SurfaceTexture)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnSurfaceTextureDestroyed(Android.Graphics.SurfaceTexture arg0)
            {
                return IExecuteWithSignature<bool>("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureAvailable(android.graphics.SurfaceTexture,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public override void OnSurfaceTextureAvailable(Android.Graphics.SurfaceTexture arg0, int arg1, int arg2)
            {
                IExecuteWithSignature("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureSizeChanged(android.graphics.SurfaceTexture,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public override void OnSurfaceTextureSizeChanged(Android.Graphics.SurfaceTexture arg0, int arg1, int arg2)
            {
                IExecuteWithSignature("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/TextureView.SurfaceTextureListener.html#onSurfaceTextureUpdated(android.graphics.SurfaceTexture)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.SurfaceTexture"/></param>
            public override void OnSurfaceTextureUpdated(Android.Graphics.SurfaceTexture arg0)
            {
                IExecuteWithSignature("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", arg0);
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