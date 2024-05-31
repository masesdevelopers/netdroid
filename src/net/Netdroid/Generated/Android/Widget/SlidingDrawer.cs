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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region SlidingDrawer
    public partial class SlidingDrawer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [System.Obsolete()]
        public SlidingDrawer(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [System.Obsolete()]
        public SlidingDrawer(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [System.Obsolete()]
        public SlidingDrawer(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#ORIENTATION_HORIZONTAL"/>
        /// </summary>
        [System.Obsolete()]
        public static int ORIENTATION_HORIZONTAL { get { if (!_ORIENTATION_HORIZONTALReady) { _ORIENTATION_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "ORIENTATION_HORIZONTAL"); _ORIENTATION_HORIZONTALReady = true; } return _ORIENTATION_HORIZONTALContent; } }
        private static int _ORIENTATION_HORIZONTALContent = default;
        private static bool _ORIENTATION_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#ORIENTATION_VERTICAL"/>
        /// </summary>
        [System.Obsolete()]
        public static int ORIENTATION_VERTICAL { get { if (!_ORIENTATION_VERTICALReady) { _ORIENTATION_VERTICALContent = SGetField<int>(LocalBridgeClazz, "ORIENTATION_VERTICAL"); _ORIENTATION_VERTICALReady = true; } return _ORIENTATION_VERTICALContent; } }
        private static int _ORIENTATION_VERTICALContent = default;
        private static bool _ORIENTATION_VERTICALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#getContent()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.View.View Content
        {
            get { return IExecuteWithSignature<Android.View.View>("getContent", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#getHandle()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.View.View Handle
        {
            get { return IExecuteWithSignature<Android.View.View>("getHandle", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#isMoving()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsMoving()
        {
            return IExecuteWithSignature<bool>("isMoving", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#isOpened()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsOpened()
        {
            return IExecuteWithSignature<bool>("isOpened", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#animateClose()"/>
        /// </summary>
        [System.Obsolete()]
        public void AnimateClose()
        {
            IExecuteWithSignature("animateClose", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#animateOpen()"/>
        /// </summary>
        [System.Obsolete()]
        public void AnimateOpen()
        {
            IExecuteWithSignature("animateOpen", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#animateToggle()"/>
        /// </summary>
        [System.Obsolete()]
        public void AnimateToggle()
        {
            IExecuteWithSignature("animateToggle", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#close()"/>
        /// </summary>
        [System.Obsolete()]
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#lock()"/>
        /// </summary>
        [System.Obsolete()]
        public void Lock()
        {
            IExecuteWithSignature("lock", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#open()"/>
        /// </summary>
        [System.Obsolete()]
        public void Open()
        {
            IExecuteWithSignature("open", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#setOnDrawerCloseListener(android.widget.SlidingDrawer.OnDrawerCloseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SlidingDrawer.OnDrawerCloseListener"/></param>
        [System.Obsolete()]
        public void SetOnDrawerCloseListener(Android.Widget.SlidingDrawer.OnDrawerCloseListener arg0)
        {
            IExecuteWithSignature("setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#setOnDrawerOpenListener(android.widget.SlidingDrawer.OnDrawerOpenListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SlidingDrawer.OnDrawerOpenListener"/></param>
        [System.Obsolete()]
        public void SetOnDrawerOpenListener(Android.Widget.SlidingDrawer.OnDrawerOpenListener arg0)
        {
            IExecuteWithSignature("setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#setOnDrawerScrollListener(android.widget.SlidingDrawer.OnDrawerScrollListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SlidingDrawer.OnDrawerScrollListener"/></param>
        [System.Obsolete()]
        public void SetOnDrawerScrollListener(Android.Widget.SlidingDrawer.OnDrawerScrollListener arg0)
        {
            IExecuteWithSignature("setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#toggle()"/>
        /// </summary>
        [System.Obsolete()]
        public void Toggle()
        {
            IExecuteWithSignature("toggle", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.html#unlock()"/>
        /// </summary>
        [System.Obsolete()]
        public void Unlock()
        {
            IExecuteWithSignature("unlock", "()V");
        }

        #endregion

        #region Nested classes
        #region OnDrawerCloseListener
        public partial class OnDrawerCloseListener
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
            /// Handlers initializer for <see cref="OnDrawerCloseListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDrawerClosed", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnDrawerClosedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerCloseListener.html#onDrawerClosed()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDrawerClosed"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnOnDrawerClosed { get; set; } = null;

            void OnDrawerClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnDrawerClosed != null) ? OnOnDrawerClosed : OnDrawerClosed;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerCloseListener.html#onDrawerClosed()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void OnDrawerClosed()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDrawerCloseListenerDirect
        public partial class OnDrawerCloseListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerCloseListener.html#onDrawerClosed()"/>
            /// </summary>
            [System.Obsolete()]
            public override void OnDrawerClosed()
            {
                IExecuteWithSignature("onDrawerClosed", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDrawerOpenListener
        public partial class OnDrawerOpenListener
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
            /// Handlers initializer for <see cref="OnDrawerOpenListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDrawerOpened", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnDrawerOpenedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerOpenListener.html#onDrawerOpened()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDrawerOpened"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnOnDrawerOpened { get; set; } = null;

            void OnDrawerOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnDrawerOpened != null) ? OnOnDrawerOpened : OnDrawerOpened;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerOpenListener.html#onDrawerOpened()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void OnDrawerOpened()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDrawerOpenListenerDirect
        public partial class OnDrawerOpenListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerOpenListener.html#onDrawerOpened()"/>
            /// </summary>
            [System.Obsolete()]
            public override void OnDrawerOpened()
            {
                IExecuteWithSignature("onDrawerOpened", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDrawerScrollListener
        public partial class OnDrawerScrollListener
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
            /// Handlers initializer for <see cref="OnDrawerScrollListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onScrollEnded", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnScrollEndedEventHandler));
                AddEventHandler("onScrollStarted", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnScrollStartedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerScrollListener.html#onScrollEnded()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScrollEnded"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnOnScrollEnded { get; set; } = null;

            void OnScrollEndedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnScrollEnded != null) ? OnOnScrollEnded : OnScrollEnded;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerScrollListener.html#onScrollEnded()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void OnScrollEnded()
            {
                
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerScrollListener.html#onScrollStarted()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScrollStarted"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action OnOnScrollStarted { get; set; } = null;

            void OnScrollStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnScrollStarted != null) ? OnOnScrollStarted : OnScrollStarted;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerScrollListener.html#onScrollStarted()"/>
            /// </summary>
            [System.Obsolete()]
            public virtual void OnScrollStarted()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDrawerScrollListenerDirect
        public partial class OnDrawerScrollListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerScrollListener.html#onScrollEnded()"/>
            /// </summary>
            [System.Obsolete()]
            public override void OnScrollEnded()
            {
                IExecuteWithSignature("onScrollEnded", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SlidingDrawer.OnDrawerScrollListener.html#onScrollStarted()"/>
            /// </summary>
            [System.Obsolete()]
            public override void OnScrollStarted()
            {
                IExecuteWithSignature("onScrollStarted", "()V");
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