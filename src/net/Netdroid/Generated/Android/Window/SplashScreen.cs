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

namespace Android.Window
{
    #region ISplashScreen
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISplashScreen
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SplashScreen
    public partial class SplashScreen : Android.Window.ISplashScreen
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SplashScreen.html#SPLASH_SCREEN_STYLE_ICON"/>
        /// </summary>
        public static int SPLASH_SCREEN_STYLE_ICON { get { if (!_SPLASH_SCREEN_STYLE_ICONReady) { _SPLASH_SCREEN_STYLE_ICONContent = SGetField<int>(LocalBridgeClazz, "SPLASH_SCREEN_STYLE_ICON"); _SPLASH_SCREEN_STYLE_ICONReady = true; } return _SPLASH_SCREEN_STYLE_ICONContent; } }
        private static int _SPLASH_SCREEN_STYLE_ICONContent = default;
        private static bool _SPLASH_SCREEN_STYLE_ICONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SplashScreen.html#SPLASH_SCREEN_STYLE_SOLID_COLOR"/>
        /// </summary>
        public static int SPLASH_SCREEN_STYLE_SOLID_COLOR { get { if (!_SPLASH_SCREEN_STYLE_SOLID_COLORReady) { _SPLASH_SCREEN_STYLE_SOLID_COLORContent = SGetField<int>(LocalBridgeClazz, "SPLASH_SCREEN_STYLE_SOLID_COLOR"); _SPLASH_SCREEN_STYLE_SOLID_COLORReady = true; } return _SPLASH_SCREEN_STYLE_SOLID_COLORContent; } }
        private static int _SPLASH_SCREEN_STYLE_SOLID_COLORContent = default;
        private static bool _SPLASH_SCREEN_STYLE_SOLID_COLORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SplashScreen.html#clearOnExitAnimationListener()"/>
        /// </summary>
        public void ClearOnExitAnimationListener()
        {
            IExecuteWithSignature("clearOnExitAnimationListener", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SplashScreen.html#setOnExitAnimationListener(android.window.SplashScreen.OnExitAnimationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Window.SplashScreen.OnExitAnimationListener"/></param>
        public void SetOnExitAnimationListener(Android.Window.SplashScreen.OnExitAnimationListener arg0)
        {
            IExecuteWithSignature("setOnExitAnimationListener", "(Landroid/window/SplashScreen$OnExitAnimationListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/window/SplashScreen.html#setSplashScreenTheme(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSplashScreenTheme(int arg0)
        {
            IExecuteWithSignature("setSplashScreenTheme", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnExitAnimationListener
        public partial class OnExitAnimationListener
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
            /// Handlers initializer for <see cref="OnExitAnimationListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSplashScreenExit", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Window.SplashScreenView>>>(OnSplashScreenExitEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/window/SplashScreen.OnExitAnimationListener.html#onSplashScreenExit(android.window.SplashScreenView)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSplashScreenExit"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Window.SplashScreenView> OnOnSplashScreenExit { get; set; } = null;

            void OnSplashScreenExitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Window.SplashScreenView>> data)
            {
                var methodToExecute = (OnOnSplashScreenExit != null) ? OnOnSplashScreenExit : OnSplashScreenExit;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/window/SplashScreen.OnExitAnimationListener.html#onSplashScreenExit(android.window.SplashScreenView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Window.SplashScreenView"/></param>
            public virtual void OnSplashScreenExit(Android.Window.SplashScreenView arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnExitAnimationListenerDirect
        public partial class OnExitAnimationListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/window/SplashScreen.OnExitAnimationListener.html#onSplashScreenExit(android.window.SplashScreenView)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Window.SplashScreenView"/></param>
            public override void OnSplashScreenExit(Android.Window.SplashScreenView arg0)
            {
                IExecuteWithSignature("onSplashScreenExit", "(Landroid/window/SplashScreenView;)V", arg0);
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