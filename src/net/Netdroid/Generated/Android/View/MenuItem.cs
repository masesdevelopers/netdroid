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

namespace Android.View
{
    #region IMenuItem
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMenuItem
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuItem
    public partial class MenuItem : Android.View.IMenuItem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#SHOW_AS_ACTION_ALWAYS"/>
        /// </summary>
        public static int SHOW_AS_ACTION_ALWAYS { get { if (!_SHOW_AS_ACTION_ALWAYSReady) { _SHOW_AS_ACTION_ALWAYSContent = SGetField<int>(LocalBridgeClazz, "SHOW_AS_ACTION_ALWAYS"); _SHOW_AS_ACTION_ALWAYSReady = true; } return _SHOW_AS_ACTION_ALWAYSContent; } }
        private static int _SHOW_AS_ACTION_ALWAYSContent = default;
        private static bool _SHOW_AS_ACTION_ALWAYSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW"/>
        /// </summary>
        public static int SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW { get { if (!_SHOW_AS_ACTION_COLLAPSE_ACTION_VIEWReady) { _SHOW_AS_ACTION_COLLAPSE_ACTION_VIEWContent = SGetField<int>(LocalBridgeClazz, "SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW"); _SHOW_AS_ACTION_COLLAPSE_ACTION_VIEWReady = true; } return _SHOW_AS_ACTION_COLLAPSE_ACTION_VIEWContent; } }
        private static int _SHOW_AS_ACTION_COLLAPSE_ACTION_VIEWContent = default;
        private static bool _SHOW_AS_ACTION_COLLAPSE_ACTION_VIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#SHOW_AS_ACTION_IF_ROOM"/>
        /// </summary>
        public static int SHOW_AS_ACTION_IF_ROOM { get { if (!_SHOW_AS_ACTION_IF_ROOMReady) { _SHOW_AS_ACTION_IF_ROOMContent = SGetField<int>(LocalBridgeClazz, "SHOW_AS_ACTION_IF_ROOM"); _SHOW_AS_ACTION_IF_ROOMReady = true; } return _SHOW_AS_ACTION_IF_ROOMContent; } }
        private static int _SHOW_AS_ACTION_IF_ROOMContent = default;
        private static bool _SHOW_AS_ACTION_IF_ROOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#SHOW_AS_ACTION_NEVER"/>
        /// </summary>
        public static int SHOW_AS_ACTION_NEVER { get { if (!_SHOW_AS_ACTION_NEVERReady) { _SHOW_AS_ACTION_NEVERContent = SGetField<int>(LocalBridgeClazz, "SHOW_AS_ACTION_NEVER"); _SHOW_AS_ACTION_NEVERReady = true; } return _SHOW_AS_ACTION_NEVERContent; } }
        private static int _SHOW_AS_ACTION_NEVERContent = default;
        private static bool _SHOW_AS_ACTION_NEVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#SHOW_AS_ACTION_WITH_TEXT"/>
        /// </summary>
        public static int SHOW_AS_ACTION_WITH_TEXT { get { if (!_SHOW_AS_ACTION_WITH_TEXTReady) { _SHOW_AS_ACTION_WITH_TEXTContent = SGetField<int>(LocalBridgeClazz, "SHOW_AS_ACTION_WITH_TEXT"); _SHOW_AS_ACTION_WITH_TEXTReady = true; } return _SHOW_AS_ACTION_WITH_TEXTContent; } }
        private static int _SHOW_AS_ACTION_WITH_TEXTContent = default;
        private static bool _SHOW_AS_ACTION_WITH_TEXTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getActionProvider()"/> 
        /// </summary>
        public Android.View.ActionProvider ActionProvider
        {
            get { return IExecuteWithSignature<Android.View.ActionProvider>("getActionProvider", "()Landroid/view/ActionProvider;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getActionView()"/> 
        /// </summary>
        public Android.View.View ActionView
        {
            get { return IExecuteWithSignature<Android.View.View>("getActionView", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getAlphabeticModifiers()"/> 
        /// </summary>
        public int AlphabeticModifiers
        {
            get { return IExecuteWithSignature<int>("getAlphabeticModifiers", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getAlphabeticShortcut()"/> 
        /// </summary>
        public char AlphabeticShortcut
        {
            get { return IExecuteWithSignature<char>("getAlphabeticShortcut", "()C"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getContentDescription()"/> 
        /// </summary>
        public Java.Lang.CharSequence ContentDescription
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getContentDescription", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getGroupId()"/> 
        /// </summary>
        public int GroupId
        {
            get { return IExecuteWithSignature<int>("getGroupId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getIcon()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Drawable Icon
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getIcon", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getIconTintBlendMode()"/> 
        /// </summary>
        public Android.Graphics.BlendMode IconTintBlendMode
        {
            get { return IExecuteWithSignature<Android.Graphics.BlendMode>("getIconTintBlendMode", "()Landroid/graphics/BlendMode;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getIconTintList()"/> 
        /// </summary>
        public Android.Content.Res.ColorStateList IconTintList
        {
            get { return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getIconTintList", "()Landroid/content/res/ColorStateList;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getIconTintMode()"/> 
        /// </summary>
        public Android.Graphics.PorterDuff.Mode IconTintMode
        {
            get { return IExecuteWithSignature<Android.Graphics.PorterDuff.Mode>("getIconTintMode", "()Landroid/graphics/PorterDuff$Mode;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getIntent()"/> 
        /// </summary>
        public Android.Content.Intent Intent
        {
            get { return IExecuteWithSignature<Android.Content.Intent>("getIntent", "()Landroid/content/Intent;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getItemId()"/> 
        /// </summary>
        public int ItemId
        {
            get { return IExecuteWithSignature<int>("getItemId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getMenuInfo()"/> 
        /// </summary>
        public Android.View.ContextMenu.ContextMenuInfo MenuInfo
        {
            get { return IExecuteWithSignature<Android.View.ContextMenu.ContextMenuInfo>("getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getNumericModifiers()"/> 
        /// </summary>
        public int NumericModifiers
        {
            get { return IExecuteWithSignature<int>("getNumericModifiers", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getNumericShortcut()"/> 
        /// </summary>
        public char NumericShortcut
        {
            get { return IExecuteWithSignature<char>("getNumericShortcut", "()C"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getOrder()"/> 
        /// </summary>
        public int Order
        {
            get { return IExecuteWithSignature<int>("getOrder", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getSubMenu()"/> 
        /// </summary>
        public Android.View.SubMenu SubMenu
        {
            get { return IExecuteWithSignature<Android.View.SubMenu>("getSubMenu", "()Landroid/view/SubMenu;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getTitle()"/> 
        /// </summary>
        public Java.Lang.CharSequence Title
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getTitleCondensed()"/> 
        /// </summary>
        public Java.Lang.CharSequence TitleCondensed
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTitleCondensed", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#getTooltipText()"/> 
        /// </summary>
        public Java.Lang.CharSequence TooltipText
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTooltipText", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setActionProvider(android.view.ActionProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ActionProvider"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetActionProvider(Android.View.ActionProvider arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setActionProvider", "(Landroid/view/ActionProvider;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setActionView(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetActionView(Android.View.View arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setActionView", "(Landroid/view/View;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setActionView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetActionView(int arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setActionView", "(I)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setAlphabeticShortcut(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetAlphabeticShortcut(char arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setAlphabeticShortcut", "(C)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setCheckable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetCheckable(bool arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setCheckable", "(Z)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setChecked(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetChecked(bool arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setChecked", "(Z)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetEnabled(bool arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setEnabled", "(Z)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetIcon(int arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setIcon", "(I)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setIntent(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetIntent(Android.Content.Intent arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setNumericShortcut(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetNumericShortcut(char arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setNumericShortcut", "(C)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setOnActionExpandListener(android.view.MenuItem.OnActionExpandListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MenuItem.OnActionExpandListener"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetOnActionExpandListener(Android.View.MenuItem.OnActionExpandListener arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setOnActionExpandListener", "(Landroid/view/MenuItem$OnActionExpandListener;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setOnMenuItemClickListener(android.view.MenuItem.OnMenuItemClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MenuItem.OnMenuItemClickListener"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetOnMenuItemClickListener(Android.View.MenuItem.OnMenuItemClickListener arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setShortcut(char,char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetShortcut(char arg0, char arg1)
        {
            return IExecute<Android.View.MenuItem>("setShortcut", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setShowAsActionFlags(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetShowAsActionFlags(int arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setShowAsActionFlags", "(I)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetTitle(int arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setTitle", "(I)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetTitle(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setTitleCondensed(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetTitleCondensed(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetVisible(bool arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setVisible", "(Z)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#collapseActionView()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CollapseActionView()
        {
            return IExecuteWithSignature<bool>("collapseActionView", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#expandActionView()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ExpandActionView()
        {
            return IExecuteWithSignature<bool>("expandActionView", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#hasSubMenu()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasSubMenu()
        {
            return IExecuteWithSignature<bool>("hasSubMenu", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#isActionViewExpanded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActionViewExpanded()
        {
            return IExecuteWithSignature<bool>("isActionViewExpanded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#isCheckable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCheckable()
        {
            return IExecuteWithSignature<bool>("isCheckable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#isChecked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsChecked()
        {
            return IExecuteWithSignature<bool>("isChecked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#isVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecuteWithSignature<bool>("isVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setShowAsAction(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetShowAsAction(int arg0)
        {
            IExecuteWithSignature("setShowAsAction", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setAlphabeticShortcut(char,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetAlphabeticShortcut(char arg0, int arg1)
        {
            return IExecute<Android.View.MenuItem>("setAlphabeticShortcut", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setContentDescription(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetContentDescription(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setContentDescription", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setIconTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetIconTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setIconTintBlendMode", "(Landroid/graphics/BlendMode;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setIconTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetIconTintList(Android.Content.Res.ColorStateList arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setIconTintList", "(Landroid/content/res/ColorStateList;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setIconTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetIconTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setIconTintMode", "(Landroid/graphics/PorterDuff$Mode;)Landroid/view/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setNumericShortcut(char,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetNumericShortcut(char arg0, int arg1)
        {
            return IExecute<Android.View.MenuItem>("setNumericShortcut", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setShortcut(char,char,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetShortcut(char arg0, char arg1, int arg2, int arg3)
        {
            return IExecute<Android.View.MenuItem>("setShortcut", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/MenuItem.html#setTooltipText(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.View.MenuItem"/></returns>
        public Android.View.MenuItem SetTooltipText(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.View.MenuItem>("setTooltipText", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", arg0);
        }

        #endregion

        #region Nested classes
        #region OnActionExpandListener
        public partial class OnActionExpandListener
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
            /// Handlers initializer for <see cref="OnActionExpandListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onMenuItemActionCollapse", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.MenuItem>>>(OnMenuItemActionCollapseEventHandler));
                AddEventHandler("onMenuItemActionExpand", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.MenuItem>>>(OnMenuItemActionExpandEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/MenuItem.OnActionExpandListener.html#onMenuItemActionCollapse(android.view.MenuItem)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnMenuItemActionCollapse"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Func<Android.View.MenuItem, bool> OnOnMenuItemActionCollapse { get; set; } = null;

            void OnMenuItemActionCollapseEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.MenuItem>> data)
            {
                var methodToExecute = (OnOnMenuItemActionCollapse != null) ? OnOnMenuItemActionCollapse : OnMenuItemActionCollapse;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/MenuItem.OnActionExpandListener.html#onMenuItemActionCollapse(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnMenuItemActionCollapse(Android.View.MenuItem arg0)
            {
                return default;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/MenuItem.OnActionExpandListener.html#onMenuItemActionExpand(android.view.MenuItem)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnMenuItemActionExpand"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Func<Android.View.MenuItem, bool> OnOnMenuItemActionExpand { get; set; } = null;

            void OnMenuItemActionExpandEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.MenuItem>> data)
            {
                var methodToExecute = (OnOnMenuItemActionExpand != null) ? OnOnMenuItemActionExpand : OnMenuItemActionExpand;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/MenuItem.OnActionExpandListener.html#onMenuItemActionExpand(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnMenuItemActionExpand(Android.View.MenuItem arg0)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnActionExpandListenerDirect
        public partial class OnActionExpandListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/MenuItem.OnActionExpandListener.html#onMenuItemActionCollapse(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnMenuItemActionCollapse(Android.View.MenuItem arg0)
            {
                return IExecuteWithSignature<bool>("onMenuItemActionCollapse", "(Landroid/view/MenuItem;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/MenuItem.OnActionExpandListener.html#onMenuItemActionExpand(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnMenuItemActionExpand(Android.View.MenuItem arg0)
            {
                return IExecuteWithSignature<bool>("onMenuItemActionExpand", "(Landroid/view/MenuItem;)Z", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMenuItemClickListener
        public partial class OnMenuItemClickListener
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
            /// Handlers initializer for <see cref="OnMenuItemClickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onMenuItemClick", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.MenuItem>>>(OnMenuItemClickEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/MenuItem.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnMenuItemClick"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Func<Android.View.MenuItem, bool> OnOnMenuItemClick { get; set; } = null;

            void OnMenuItemClickEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.MenuItem>> data)
            {
                var methodToExecute = (OnOnMenuItemClick != null) ? OnOnMenuItemClick : OnMenuItemClick;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/MenuItem.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public virtual bool OnMenuItemClick(Android.View.MenuItem arg0)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnMenuItemClickListenerDirect
        public partial class OnMenuItemClickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/MenuItem.OnMenuItemClickListener.html#onMenuItemClick(android.view.MenuItem)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.MenuItem"/></param>
            /// <returns><see cref="bool"/></returns>
            public override bool OnMenuItemClick(Android.View.MenuItem arg0)
            {
                return IExecuteWithSignature<bool>("onMenuItemClick", "(Landroid/view/MenuItem;)Z", arg0);
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