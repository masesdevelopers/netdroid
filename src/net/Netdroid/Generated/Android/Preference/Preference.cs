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

namespace Android.Preference
{
    #region Preference
    public partial class Preference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [System.Obsolete()]
        public Preference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [System.Obsolete()]
        public Preference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [System.Obsolete()]
        public Preference(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [System.Obsolete()]
        public Preference(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#DEFAULT_ORDER"/>
        /// </summary>
        [System.Obsolete()]
        public static int DEFAULT_ORDER { get { if (!_DEFAULT_ORDERReady) { _DEFAULT_ORDERContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_ORDER"); _DEFAULT_ORDERReady = true; } return _DEFAULT_ORDERContent; } }
        private static int _DEFAULT_ORDERContent = default;
        private static bool _DEFAULT_ORDERReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getContext()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Content.Context Context
        {
            get { return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getDependency()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setDependency(java.lang.String)"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String Dependency
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDependency", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setDependency", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getEditor()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Content.SharedPreferences.Editor Editor
        {
            get { return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("getEditor", "()Landroid/content/SharedPreferences$Editor;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getExtras()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Os.Bundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getFragment()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setFragment(java.lang.String)"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String Fragment
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFragment", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setFragment", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getOnPreferenceChangeListener()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Preference.Preference.OnPreferenceChangeListener GetOnPreferenceChangeListener
        {
            get { return IExecuteWithSignature<Android.Preference.Preference.OnPreferenceChangeListener>("getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getOnPreferenceClickListener()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Preference.Preference.OnPreferenceClickListener GetOnPreferenceClickListener
        {
            get { return IExecuteWithSignature<Android.Preference.Preference.OnPreferenceClickListener>("getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getIcon()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Graphics.Drawable.Drawable Icon
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getIcon", "()Landroid/graphics/drawable/Drawable;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getIntent()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setIntent(android.content.Intent)"/>
        /// </summary>
        [System.Obsolete()]
        public Android.Content.Intent Intent
        {
            get { return IExecuteWithSignature<Android.Content.Intent>("getIntent", "()Landroid/content/Intent;"); } set { IExecuteWithSignature("setIntent", "(Landroid/content/Intent;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getKey()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setKey(java.lang.String)"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String Key
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getKey", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setKey", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getLayoutResource()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setLayoutResource(int)"/>
        /// </summary>
        [System.Obsolete()]
        public int LayoutResource
        {
            get { return IExecuteWithSignature<int>("getLayoutResource", "()I"); } set { IExecuteWithSignature("setLayoutResource", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getOrder()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setOrder(int)"/>
        /// </summary>
        [System.Obsolete()]
        public int Order
        {
            get { return IExecuteWithSignature<int>("getOrder", "()I"); } set { IExecuteWithSignature("setOrder", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getParent()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Preference.PreferenceGroup Parent
        {
            get { return IExecuteWithSignature<Android.Preference.PreferenceGroup>("getParent", "()Landroid/preference/PreferenceGroup;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getPreferenceDataStore()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setPreferenceDataStore(android.preference.PreferenceDataStore)"/>
        /// </summary>
        [System.Obsolete()]
        public Android.Preference.PreferenceDataStore PreferenceDataStore
        {
            get { return IExecuteWithSignature<Android.Preference.PreferenceDataStore>("getPreferenceDataStore", "()Landroid/preference/PreferenceDataStore;"); } set { IExecuteWithSignature("setPreferenceDataStore", "(Landroid/preference/PreferenceDataStore;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getPreferenceManager()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Preference.PreferenceManager PreferenceManager
        {
            get { return IExecuteWithSignature<Android.Preference.PreferenceManager>("getPreferenceManager", "()Landroid/preference/PreferenceManager;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getSharedPreferences()"/> 
        /// </summary>
        [System.Obsolete()]
        public Android.Content.SharedPreferences SharedPreferences
        {
            get { return IExecuteWithSignature<Android.Content.SharedPreferences>("getSharedPreferences", "()Landroid/content/SharedPreferences;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getShouldDisableView()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setShouldDisableView(boolean)"/>
        /// </summary>
        [System.Obsolete()]
        public bool ShouldDisableView
        {
            get { return IExecuteWithSignature<bool>("getShouldDisableView", "()Z"); } set { IExecuteWithSignature("setShouldDisableView", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getSummary()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.CharSequence Summary
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getSummary", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getTitle()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.CharSequence Title
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getTitleRes()"/> 
        /// </summary>
        [System.Obsolete()]
        public int TitleRes
        {
            get { return IExecuteWithSignature<int>("getTitleRes", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getWidgetLayoutResource()"/> <see href="https://developer.android.com/reference/android/preference/Preference.html#setWidgetLayoutResource(int)"/>
        /// </summary>
        [System.Obsolete()]
        public int WidgetLayoutResource
        {
            get { return IExecuteWithSignature<int>("getWidgetLayoutResource", "()I"); } set { IExecuteWithSignature("setWidgetLayoutResource", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#peekExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        [System.Obsolete()]
        public Android.Os.Bundle PeekExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("peekExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getView(android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        [System.Obsolete()]
        public Android.View.View GetView(Android.View.View arg0, Android.View.ViewGroup arg1)
        {
            return IExecute<Android.View.View>("getView", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#hasKey()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool HasKey()
        {
            return IExecuteWithSignature<bool>("hasKey", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#isIconSpaceReserved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsIconSpaceReserved()
        {
            return IExecuteWithSignature<bool>("isIconSpaceReserved", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#isPersistent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsPersistent()
        {
            return IExecuteWithSignature<bool>("isPersistent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#isRecycleEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsRecycleEnabled()
        {
            return IExecuteWithSignature<bool>("isRecycleEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#isSelectable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsSelectable()
        {
            return IExecuteWithSignature<bool>("isSelectable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#isSingleLineTitle()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsSingleLineTitle()
        {
            return IExecuteWithSignature<bool>("isSingleLineTitle", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#persistStringSet(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool PersistStringSet(Java.Util.Set<Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<bool>("persistStringSet", "(Ljava/util/Set;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#shouldCommit()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool ShouldCommit()
        {
            return IExecuteWithSignature<bool>("shouldCommit", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#shouldDisableDependents()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool ShouldDisableDependents()
        {
            return IExecuteWithSignature<bool>("shouldDisableDependents", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#compareTo(android.preference.Preference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
        /// <returns><see cref="int"/></returns>
        [System.Obsolete()]
        public int CompareTo(Android.Preference.Preference arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/preference/Preference;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        [System.Obsolete()]
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#getPersistedStringSet(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        [System.Obsolete()]
        public Java.Util.Set<Java.Lang.String> GetPersistedStringSet(Java.Util.Set<Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getPersistedStringSet", "(Ljava/util/Set;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#notifyDependencyChange(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void NotifyDependencyChange(bool arg0)
        {
            IExecuteWithSignature("notifyDependencyChange", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#onDependencyChanged(android.preference.Preference,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [System.Obsolete()]
        public void OnDependencyChanged(Android.Preference.Preference arg0, bool arg1)
        {
            IExecute("onDependencyChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#onParentChanged(android.preference.Preference,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [System.Obsolete()]
        public void OnParentChanged(Android.Preference.Preference arg0, bool arg1)
        {
            IExecute("onParentChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#restoreHierarchyState(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        [System.Obsolete()]
        public void RestoreHierarchyState(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("restoreHierarchyState", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#saveHierarchyState(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        [System.Obsolete()]
        public void SaveHierarchyState(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("saveHierarchyState", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setDefaultValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        [System.Obsolete()]
        public void SetDefaultValue(object arg0)
        {
            IExecuteWithSignature("setDefaultValue", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setIcon(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        [System.Obsolete()]
        public void SetIcon(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setIcon", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetIcon(int arg0)
        {
            IExecuteWithSignature("setIcon", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setIconSpaceReserved(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetIconSpaceReserved(bool arg0)
        {
            IExecuteWithSignature("setIconSpaceReserved", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setOnPreferenceChangeListener(android.preference.Preference.OnPreferenceChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference.OnPreferenceChangeListener"/></param>
        [System.Obsolete()]
        public void SetOnPreferenceChangeListener(Android.Preference.Preference.OnPreferenceChangeListener arg0)
        {
            IExecuteWithSignature("setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setOnPreferenceClickListener(android.preference.Preference.OnPreferenceClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.Preference.OnPreferenceClickListener"/></param>
        [System.Obsolete()]
        public void SetOnPreferenceClickListener(Android.Preference.Preference.OnPreferenceClickListener arg0)
        {
            IExecuteWithSignature("setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setPersistent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetPersistent(bool arg0)
        {
            IExecuteWithSignature("setPersistent", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setRecycleEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetRecycleEnabled(bool arg0)
        {
            IExecuteWithSignature("setRecycleEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setSelectable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetSelectable(bool arg0)
        {
            IExecuteWithSignature("setSelectable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setSingleLineTitle(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetSingleLineTitle(bool arg0)
        {
            IExecuteWithSignature("setSingleLineTitle", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setSummary(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetSummary(int arg0)
        {
            IExecuteWithSignature("setSummary", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setSummary(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        [System.Obsolete()]
        public void SetSummary(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setSummary", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [System.Obsolete()]
        public void SetTitle(int arg0)
        {
            IExecuteWithSignature("setTitle", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/Preference.html#setTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        [System.Obsolete()]
        public void SetTitle(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setTitle", "(Ljava/lang/CharSequence;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region BaseSavedState
        public partial class BaseSavedState
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/Preference.BaseSavedState.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            [System.Obsolete()]
            public BaseSavedState(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/Preference.BaseSavedState.html#%3Cinit%3E(android.os.Parcelable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcelable"/></param>
            [System.Obsolete()]
            public BaseSavedState(Android.Os.Parcelable arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/Preference.BaseSavedState.html#CREATOR"/>
            /// </summary>
            [System.Obsolete()]
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 

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

        #region OnPreferenceChangeListener
        public partial class OnPreferenceChangeListener
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
            /// Handlers initializer for <see cref="OnPreferenceChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onPreferenceChange", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Preference.Preference>>>(OnPreferenceChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/preference/Preference.OnPreferenceChangeListener.html#onPreferenceChange(android.preference.Preference,java.lang.Object)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnPreferenceChange"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Func<Android.Preference.Preference, object, bool> OnOnPreferenceChange { get; set; } = null;

            void OnPreferenceChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Preference.Preference>> data)
            {
                var methodToExecute = (OnOnPreferenceChange != null) ? OnOnPreferenceChange : OnPreferenceChange;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/Preference.OnPreferenceChangeListener.html#onPreferenceChange(android.preference.Preference,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            [System.Obsolete()]
            public virtual bool OnPreferenceChange(Android.Preference.Preference arg0, object arg1)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnPreferenceChangeListenerDirect
        public partial class OnPreferenceChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/preference/Preference.OnPreferenceChangeListener.html#onPreferenceChange(android.preference.Preference,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            [System.Obsolete()]
            public override bool OnPreferenceChange(Android.Preference.Preference arg0, object arg1)
            {
                return IExecute<bool>("onPreferenceChange", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnPreferenceClickListener
        public partial class OnPreferenceClickListener
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
            /// Handlers initializer for <see cref="OnPreferenceClickListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onPreferenceClick", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Preference.Preference>>>(OnPreferenceClickEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/preference/Preference.OnPreferenceClickListener.html#onPreferenceClick(android.preference.Preference)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnPreferenceClick"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Func<Android.Preference.Preference, bool> OnOnPreferenceClick { get; set; } = null;

            void OnPreferenceClickEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Preference.Preference>> data)
            {
                var methodToExecute = (OnOnPreferenceClick != null) ? OnOnPreferenceClick : OnPreferenceClick;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/preference/Preference.OnPreferenceClickListener.html#onPreferenceClick(android.preference.Preference)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
            /// <returns><see cref="bool"/></returns>
            [System.Obsolete()]
            public virtual bool OnPreferenceClick(Android.Preference.Preference arg0)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnPreferenceClickListenerDirect
        public partial class OnPreferenceClickListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/preference/Preference.OnPreferenceClickListener.html#onPreferenceClick(android.preference.Preference)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Preference.Preference"/></param>
            /// <returns><see cref="bool"/></returns>
            [System.Obsolete()]
            public override bool OnPreferenceClick(Android.Preference.Preference arg0)
            {
                return IExecuteWithSignature<bool>("onPreferenceClick", "(Landroid/preference/Preference;)Z", arg0);
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