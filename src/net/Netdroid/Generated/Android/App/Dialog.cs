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
    #region Dialog
    public partial class Dialog : Android.Content.IDialogInterface
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public Dialog(Android.Content.Context arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public Dialog(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.App.Dialog"/> to <see cref="Android.Content.DialogInterface"/>
        /// </summary>
        public static implicit operator Android.Content.DialogInterface(Android.App.Dialog t) => t.Cast<Android.Content.DialogInterface>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getActionBar()"/> 
        /// </summary>
        public Android.App.ActionBar ActionBar
        {
            get { return IExecuteWithSignature<Android.App.ActionBar>("getActionBar", "()Landroid/app/ActionBar;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getContext()"/> 
        /// </summary>
        public Android.Content.Context Context
        {
            get { return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getCurrentFocus()"/> 
        /// </summary>
        public Android.View.View CurrentFocus
        {
            get { return IExecuteWithSignature<Android.View.View>("getCurrentFocus", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getLayoutInflater()"/> 
        /// </summary>
        public Android.View.LayoutInflater LayoutInflater
        {
            get { return IExecuteWithSignature<Android.View.LayoutInflater>("getLayoutInflater", "()Landroid/view/LayoutInflater;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getOnBackInvokedDispatcher()"/> 
        /// </summary>
        public Android.Window.OnBackInvokedDispatcher OnBackInvokedDispatcher
        {
            get { return IExecuteWithSignature<Android.Window.OnBackInvokedDispatcher>("getOnBackInvokedDispatcher", "()Landroid/window/OnBackInvokedDispatcher;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getOwnerActivity()"/> <see href="https://developer.android.com/reference/android/app/Dialog.html#setOwnerActivity(android.app.Activity)"/>
        /// </summary>
        public Android.App.Activity OwnerActivity
        {
            get { return IExecuteWithSignature<Android.App.Activity>("getOwnerActivity", "()Landroid/app/Activity;"); } set { IExecuteWithSignature("setOwnerActivity", "(Landroid/app/Activity;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getSearchEvent()"/> 
        /// </summary>
        public Android.View.SearchEvent SearchEvent
        {
            get { return IExecuteWithSignature<Android.View.SearchEvent>("getSearchEvent", "()Landroid/view/SearchEvent;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getVolumeControlStream()"/> <see href="https://developer.android.com/reference/android/app/Dialog.html#setVolumeControlStream(int)"/>
        /// </summary>
        public int VolumeControlStream
        {
            get { return IExecuteWithSignature<int>("getVolumeControlStream", "()I"); } set { IExecuteWithSignature("setVolumeControlStream", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#getWindow()"/> 
        /// </summary>
        public Android.View.Window Window
        {
            get { return IExecuteWithSignature<Android.View.Window>("getWindow", "()Landroid/view/Window;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#findViewById(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <typeparam name="T"><see cref="Android.View.View"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T FindViewById<T>(int arg0) where T: Android.View.View
        {
            return IExecuteWithSignature<T>("findViewById", "(I)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onSaveInstanceState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle OnSaveInstanceState()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("onSaveInstanceState", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onWindowStartingActionMode(android.view.ActionMode.Callback,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode.Callback"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.ActionMode"/></returns>
        public Android.View.ActionMode OnWindowStartingActionMode(Android.View.ActionMode.Callback arg0, int arg1)
        {
            return IExecute<Android.View.ActionMode>("onWindowStartingActionMode", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onWindowStartingActionMode(android.view.ActionMode.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode.Callback"/></param>
        /// <returns><see cref="Android.View.ActionMode"/></returns>
        public Android.View.ActionMode OnWindowStartingActionMode(Android.View.ActionMode.Callback arg0)
        {
            return IExecuteWithSignature<Android.View.ActionMode>("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onCreatePanelView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View OnCreatePanelView(int arg0)
        {
            return IExecuteWithSignature<Android.View.View>("onCreatePanelView", "(I)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#dispatchGenericMotionEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchGenericMotionEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#dispatchKeyEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchKeyEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#dispatchKeyShortcutEvent(android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchKeyShortcutEvent(Android.View.KeyEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchPopulateAccessibilityEvent(Android.View.Accessibility.AccessibilityEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#dispatchTouchEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchTouchEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#dispatchTrackballEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DispatchTrackballEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#isShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShowing()
        {
            return IExecuteWithSignature<bool>("isShowing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onContextItemSelected(android.view.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnContextItemSelected(Android.View.MenuItem arg0)
        {
            return IExecuteWithSignature<bool>("onContextItemSelected", "(Landroid/view/MenuItem;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onCreateOptionsMenu(android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnCreateOptionsMenu(Android.View.Menu arg0)
        {
            return IExecuteWithSignature<bool>("onCreateOptionsMenu", "(Landroid/view/Menu;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onCreatePanelMenu(int,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnCreatePanelMenu(int arg0, Android.View.Menu arg1)
        {
            return IExecute<bool>("onCreatePanelMenu", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onGenericMotionEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnGenericMotionEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onKeyDown(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyDown(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecute<bool>("onKeyDown", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onKeyLongPress(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyLongPress(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecute<bool>("onKeyLongPress", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onKeyMultiple(int,int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyMultiple(int arg0, int arg1, Android.View.KeyEvent arg2)
        {
            return IExecute<bool>("onKeyMultiple", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onKeyShortcut(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyShortcut(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecute<bool>("onKeyShortcut", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onKeyUp(int,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnKeyUp(int arg0, Android.View.KeyEvent arg1)
        {
            return IExecute<bool>("onKeyUp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onMenuItemSelected(int,android.view.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnMenuItemSelected(int arg0, Android.View.MenuItem arg1)
        {
            return IExecute<bool>("onMenuItemSelected", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onMenuOpened(int,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnMenuOpened(int arg0, Android.View.Menu arg1)
        {
            return IExecute<bool>("onMenuOpened", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onOptionsItemSelected(android.view.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnOptionsItemSelected(Android.View.MenuItem arg0)
        {
            return IExecuteWithSignature<bool>("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onPrepareOptionsMenu(android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnPrepareOptionsMenu(Android.View.Menu arg0)
        {
            return IExecuteWithSignature<bool>("onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onPreparePanel(int,android.view.View,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.Menu"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnPreparePanel(int arg0, Android.View.View arg1, Android.View.Menu arg2)
        {
            return IExecute<bool>("onPreparePanel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onSearchRequested()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool OnSearchRequested()
        {
            return IExecuteWithSignature<bool>("onSearchRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onSearchRequested(android.view.SearchEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SearchEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnSearchRequested(Android.View.SearchEvent arg0)
        {
            return IExecuteWithSignature<bool>("onSearchRequested", "(Landroid/view/SearchEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onTouchEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTouchEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onTouchEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onTrackballEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTrackballEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#requireViewById(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <typeparam name="T"><see cref="Android.View.View"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T RequireViewById<T>(int arg0) where T: Android.View.View
        {
            return IExecuteWithSignature<T>("requireViewById", "(I)Landroid/view/View;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#requestWindowFeature(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestWindowFeature(int arg0)
        {
            return IExecuteWithSignature<bool>("requestWindowFeature", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setFeatureDrawable(int,android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetFeatureDrawable(int arg0, Android.Graphics.Drawable.Drawable arg1)
        {
            IExecute("setFeatureDrawable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setFeatureDrawableAlpha(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetFeatureDrawableAlpha(int arg0, int arg1)
        {
            IExecute("setFeatureDrawableAlpha", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setFeatureDrawableResource(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetFeatureDrawableResource(int arg0, int arg1)
        {
            IExecute("setFeatureDrawableResource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setFeatureDrawableUri(int,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        public void SetFeatureDrawableUri(int arg0, Android.Net.Uri arg1)
        {
            IExecute("setFeatureDrawableUri", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#addContentView(android.view.View,android.view.ViewGroup.LayoutParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
        public void AddContentView(Android.View.View arg0, Android.View.ViewGroup.LayoutParams arg1)
        {
            IExecute("addContentView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#closeOptionsMenu()"/>
        /// </summary>
        public void CloseOptionsMenu()
        {
            IExecuteWithSignature("closeOptionsMenu", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#create()"/>
        /// </summary>
        public void Create()
        {
            IExecuteWithSignature("create", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#dismiss()"/>
        /// </summary>
        public void Dismiss()
        {
            IExecuteWithSignature("dismiss", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#hide()"/>
        /// </summary>
        public void Hide()
        {
            IExecuteWithSignature("hide", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#invalidateOptionsMenu()"/>
        /// </summary>
        public void InvalidateOptionsMenu()
        {
            IExecuteWithSignature("invalidateOptionsMenu", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onActionModeFinished(android.view.ActionMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
        public void OnActionModeFinished(Android.View.ActionMode arg0)
        {
            IExecuteWithSignature("onActionModeFinished", "(Landroid/view/ActionMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onActionModeStarted(android.view.ActionMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionMode"/></param>
        public void OnActionModeStarted(Android.View.ActionMode arg0)
        {
            IExecuteWithSignature("onActionModeStarted", "(Landroid/view/ActionMode;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onAttachedToWindow()"/>
        /// </summary>
        public void OnAttachedToWindow()
        {
            IExecuteWithSignature("onAttachedToWindow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onBackPressed()"/>
        /// </summary>
        [System.Obsolete()]
        public void OnBackPressed()
        {
            IExecuteWithSignature("onBackPressed", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onContentChanged()"/>
        /// </summary>
        public void OnContentChanged()
        {
            IExecuteWithSignature("onContentChanged", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onContextMenuClosed(android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Menu"/></param>
        public void OnContextMenuClosed(Android.View.Menu arg0)
        {
            IExecuteWithSignature("onContextMenuClosed", "(Landroid/view/Menu;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onCreateContextMenu(android.view.ContextMenu,android.view.View,android.view.ContextMenu.ContextMenuInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ContextMenu"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.ContextMenu.ContextMenuInfo"/></param>
        public void OnCreateContextMenu(Android.View.ContextMenu arg0, Android.View.View arg1, Android.View.ContextMenu.ContextMenuInfo arg2)
        {
            IExecute("onCreateContextMenu", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onDetachedFromWindow()"/>
        /// </summary>
        public void OnDetachedFromWindow()
        {
            IExecuteWithSignature("onDetachedFromWindow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onOptionsMenuClosed(android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Menu"/></param>
        public void OnOptionsMenuClosed(Android.View.Menu arg0)
        {
            IExecuteWithSignature("onOptionsMenuClosed", "(Landroid/view/Menu;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onPanelClosed(int,android.view.Menu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Menu"/></param>
        public void OnPanelClosed(int arg0, Android.View.Menu arg1)
        {
            IExecute("onPanelClosed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onRestoreInstanceState(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void OnRestoreInstanceState(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onRestoreInstanceState", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onWindowAttributesChanged(android.view.WindowManager.LayoutParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.WindowManager.LayoutParams"/></param>
        public void OnWindowAttributesChanged(Android.View.WindowManager.LayoutParams arg0)
        {
            IExecuteWithSignature("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#onWindowFocusChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void OnWindowFocusChanged(bool arg0)
        {
            IExecuteWithSignature("onWindowFocusChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#openContextMenu(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void OpenContextMenu(Android.View.View arg0)
        {
            IExecuteWithSignature("openContextMenu", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#openOptionsMenu()"/>
        /// </summary>
        public void OpenOptionsMenu()
        {
            IExecuteWithSignature("openOptionsMenu", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#registerForContextMenu(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void RegisterForContextMenu(Android.View.View arg0)
        {
            IExecuteWithSignature("registerForContextMenu", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setCancelable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCancelable(bool arg0)
        {
            IExecuteWithSignature("setCancelable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setCanceledOnTouchOutside(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCanceledOnTouchOutside(bool arg0)
        {
            IExecuteWithSignature("setCanceledOnTouchOutside", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setCancelMessage(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        public void SetCancelMessage(Android.Os.Message arg0)
        {
            IExecuteWithSignature("setCancelMessage", "(Landroid/os/Message;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setContentView(android.view.View,android.view.ViewGroup.LayoutParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
        public void SetContentView(Android.View.View arg0, Android.View.ViewGroup.LayoutParams arg1)
        {
            IExecute("setContentView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setContentView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void SetContentView(Android.View.View arg0)
        {
            IExecuteWithSignature("setContentView", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setContentView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetContentView(int arg0)
        {
            IExecuteWithSignature("setContentView", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setDismissMessage(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        public void SetDismissMessage(Android.Os.Message arg0)
        {
            IExecuteWithSignature("setDismissMessage", "(Landroid/os/Message;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setOnCancelListener(android.content.DialogInterface.OnCancelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.DialogInterface.OnCancelListener"/></param>
        public void SetOnCancelListener(Android.Content.DialogInterface.OnCancelListener arg0)
        {
            IExecuteWithSignature("setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setOnDismissListener(android.content.DialogInterface.OnDismissListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.DialogInterface.OnDismissListener"/></param>
        public void SetOnDismissListener(Android.Content.DialogInterface.OnDismissListener arg0)
        {
            IExecuteWithSignature("setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setOnKeyListener(android.content.DialogInterface.OnKeyListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.DialogInterface.OnKeyListener"/></param>
        public void SetOnKeyListener(Android.Content.DialogInterface.OnKeyListener arg0)
        {
            IExecuteWithSignature("setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setOnShowListener(android.content.DialogInterface.OnShowListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.DialogInterface.OnShowListener"/></param>
        public void SetOnShowListener(Android.Content.DialogInterface.OnShowListener arg0)
        {
            IExecuteWithSignature("setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetTitle(int arg0)
        {
            IExecuteWithSignature("setTitle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#setTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetTitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setTitle", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#show()"/>
        /// </summary>
        public void Show()
        {
            IExecuteWithSignature("show", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#takeKeyEvents(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void TakeKeyEvents(bool arg0)
        {
            IExecuteWithSignature("takeKeyEvents", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/Dialog.html#unregisterForContextMenu(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void UnregisterForContextMenu(Android.View.View arg0)
        {
            IExecuteWithSignature("unregisterForContextMenu", "(Landroid/view/View;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}