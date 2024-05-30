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

namespace Android.App
{
    #region ActionBar
    public partial class ActionBar
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#DISPLAY_HOME_AS_UP"/>
        /// </summary>
        public static int DISPLAY_HOME_AS_UP { get { if (!_DISPLAY_HOME_AS_UPReady) { _DISPLAY_HOME_AS_UPContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_HOME_AS_UP"); _DISPLAY_HOME_AS_UPReady = true; } return _DISPLAY_HOME_AS_UPContent; } }
        private static int _DISPLAY_HOME_AS_UPContent = default;
        private static bool _DISPLAY_HOME_AS_UPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#DISPLAY_SHOW_CUSTOM"/>
        /// </summary>
        public static int DISPLAY_SHOW_CUSTOM { get { if (!_DISPLAY_SHOW_CUSTOMReady) { _DISPLAY_SHOW_CUSTOMContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_SHOW_CUSTOM"); _DISPLAY_SHOW_CUSTOMReady = true; } return _DISPLAY_SHOW_CUSTOMContent; } }
        private static int _DISPLAY_SHOW_CUSTOMContent = default;
        private static bool _DISPLAY_SHOW_CUSTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#DISPLAY_SHOW_HOME"/>
        /// </summary>
        public static int DISPLAY_SHOW_HOME { get { if (!_DISPLAY_SHOW_HOMEReady) { _DISPLAY_SHOW_HOMEContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_SHOW_HOME"); _DISPLAY_SHOW_HOMEReady = true; } return _DISPLAY_SHOW_HOMEContent; } }
        private static int _DISPLAY_SHOW_HOMEContent = default;
        private static bool _DISPLAY_SHOW_HOMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#DISPLAY_SHOW_TITLE"/>
        /// </summary>
        public static int DISPLAY_SHOW_TITLE { get { if (!_DISPLAY_SHOW_TITLEReady) { _DISPLAY_SHOW_TITLEContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_SHOW_TITLE"); _DISPLAY_SHOW_TITLEReady = true; } return _DISPLAY_SHOW_TITLEContent; } }
        private static int _DISPLAY_SHOW_TITLEContent = default;
        private static bool _DISPLAY_SHOW_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#DISPLAY_USE_LOGO"/>
        /// </summary>
        public static int DISPLAY_USE_LOGO { get { if (!_DISPLAY_USE_LOGOReady) { _DISPLAY_USE_LOGOContent = SGetField<int>(LocalBridgeClazz, "DISPLAY_USE_LOGO"); _DISPLAY_USE_LOGOReady = true; } return _DISPLAY_USE_LOGOContent; } }
        private static int _DISPLAY_USE_LOGOContent = default;
        private static bool _DISPLAY_USE_LOGOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getCustomView()"/> 
        /// </summary>
        public Android.View.View CustomView
        {
            get { return IExecuteWithSignature<Android.View.View>("getCustomView", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getDisplayOptions()"/> <see href="https://developer.android.com/reference/android/app/ActionBar.html#setDisplayOptions(int)"/>
        /// </summary>
        public int DisplayOptions
        {
            get { return IExecuteWithSignature<int>("getDisplayOptions", "()I"); } set { IExecuteWithSignature("setDisplayOptions", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getElevation()"/> <see href="https://developer.android.com/reference/android/app/ActionBar.html#setElevation(float)"/>
        /// </summary>
        public float Elevation
        {
            get { return IExecuteWithSignature<float>("getElevation", "()F"); } set { IExecuteWithSignature("setElevation", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getHideOffset()"/> <see href="https://developer.android.com/reference/android/app/ActionBar.html#setHideOffset(int)"/>
        /// </summary>
        public int HideOffset
        {
            get { return IExecuteWithSignature<int>("getHideOffset", "()I"); } set { IExecuteWithSignature("setHideOffset", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getSubtitle()"/> 
        /// </summary>
        public Java.Lang.CharSequence Subtitle
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getSubtitle", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getThemedContext()"/> 
        /// </summary>
        public Android.Content.Context ThemedContext
        {
            get { return IExecuteWithSignature<Android.Content.Context>("getThemedContext", "()Landroid/content/Context;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#getTitle()"/> 
        /// </summary>
        public Java.Lang.CharSequence Title
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#isShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShowing()
        {
            return IExecuteWithSignature<bool>("isShowing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#addOnMenuVisibilityListener(android.app.ActionBar.OnMenuVisibilityListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.ActionBar.OnMenuVisibilityListener"/></param>
        public void AddOnMenuVisibilityListener(Android.App.ActionBar.OnMenuVisibilityListener arg0)
        {
            IExecuteWithSignature("addOnMenuVisibilityListener", "(Landroid/app/ActionBar$OnMenuVisibilityListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#hide()"/>
        /// </summary>
        public void Hide()
        {
            IExecuteWithSignature("hide", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#removeOnMenuVisibilityListener(android.app.ActionBar.OnMenuVisibilityListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.ActionBar.OnMenuVisibilityListener"/></param>
        public void RemoveOnMenuVisibilityListener(Android.App.ActionBar.OnMenuVisibilityListener arg0)
        {
            IExecuteWithSignature("removeOnMenuVisibilityListener", "(Landroid/app/ActionBar$OnMenuVisibilityListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setBackgroundDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetBackgroundDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setCustomView(android.view.View,android.app.ActionBar.LayoutParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.App.ActionBar.LayoutParams"/></param>
        public void SetCustomView(Android.View.View arg0, Android.App.ActionBar.LayoutParams arg1)
        {
            IExecute("setCustomView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setCustomView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetCustomView(Android.View.View arg0)
        {
            IExecuteWithSignature("setCustomView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setCustomView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetCustomView(int arg0)
        {
            IExecuteWithSignature("setCustomView", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setDisplayHomeAsUpEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDisplayHomeAsUpEnabled(bool arg0)
        {
            IExecuteWithSignature("setDisplayHomeAsUpEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setDisplayOptions(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetDisplayOptions(int arg0, int arg1)
        {
            IExecute("setDisplayOptions", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setDisplayShowCustomEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDisplayShowCustomEnabled(bool arg0)
        {
            IExecuteWithSignature("setDisplayShowCustomEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setDisplayShowHomeEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDisplayShowHomeEnabled(bool arg0)
        {
            IExecuteWithSignature("setDisplayShowHomeEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setDisplayShowTitleEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDisplayShowTitleEnabled(bool arg0)
        {
            IExecuteWithSignature("setDisplayShowTitleEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setDisplayUseLogoEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDisplayUseLogoEnabled(bool arg0)
        {
            IExecuteWithSignature("setDisplayUseLogoEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setIcon", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetIcon(int arg0)
        {
            IExecuteWithSignature("setIcon", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setLogo(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetLogo(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setLogo", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setLogo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLogo(int arg0)
        {
            IExecuteWithSignature("setLogo", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setSubtitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSubtitle(int arg0)
        {
            IExecuteWithSignature("setSubtitle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setSubtitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetSubtitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setSubtitle", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetTitle(int arg0)
        {
            IExecuteWithSignature("setTitle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetTitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setTitle", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#show()"/>
        /// </summary>
        public void Show()
        {
            IExecuteWithSignature("show", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#isHideOnContentScrollEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHideOnContentScrollEnabled()
        {
            return IExecuteWithSignature<bool>("isHideOnContentScrollEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setHideOnContentScrollEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetHideOnContentScrollEnabled(bool arg0)
        {
            IExecuteWithSignature("setHideOnContentScrollEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setHomeActionContentDescription(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHomeActionContentDescription(int arg0)
        {
            IExecuteWithSignature("setHomeActionContentDescription", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setHomeActionContentDescription(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetHomeActionContentDescription(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setHomeActionContentDescription", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setHomeAsUpIndicator(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetHomeAsUpIndicator(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setHomeAsUpIndicator", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setHomeAsUpIndicator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHomeAsUpIndicator(int arg0)
        {
            IExecuteWithSignature("setHomeAsUpIndicator", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setHomeButtonEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetHomeButtonEnabled(bool arg0)
        {
            IExecuteWithSignature("setHomeButtonEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setSplitBackgroundDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetSplitBackgroundDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActionBar.html#setStackedBackgroundDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetStackedBackgroundDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region LayoutParams
        public partial class LayoutParams
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.LayoutParams.html#%3Cinit%3E(android.app.ActionBar.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.ActionBar.LayoutParams"/></param>
            public LayoutParams(Android.App.ActionBar.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.LayoutParams.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
            public LayoutParams(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.LayoutParams.html#%3Cinit%3E(int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public LayoutParams(int arg0, int arg1, int arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.LayoutParams.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public LayoutParams(int arg0, int arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.LayoutParams.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public LayoutParams(int arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.LayoutParams.html#gravity"/>
            /// </summary>
            public int gravity { get { return IGetField<int>("gravity"); } set { ISetField("gravity", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMenuVisibilityListener
        public partial class OnMenuVisibilityListener
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
            /// Handlers initializer for <see cref="OnMenuVisibilityListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onMenuVisibilityChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnMenuVisibilityChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/ActionBar.OnMenuVisibilityListener.html#onMenuVisibilityChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnMenuVisibilityChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<bool> OnOnMenuVisibilityChanged { get; set; } = null;

            void OnMenuVisibilityChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnMenuVisibilityChanged != null) ? OnOnMenuVisibilityChanged : OnMenuVisibilityChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.OnMenuVisibilityListener.html#onMenuVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public virtual void OnMenuVisibilityChanged(bool arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMenuVisibilityListenerDirect
        public partial class OnMenuVisibilityListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/ActionBar.OnMenuVisibilityListener.html#onMenuVisibilityChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public override void OnMenuVisibilityChanged(bool arg0)
            {
                IExecuteWithSignature("onMenuVisibilityChanged", "(Z)V", arg0);
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