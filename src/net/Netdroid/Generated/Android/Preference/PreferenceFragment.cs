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

namespace Android.Preference
{
    #region PreferenceFragment declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class PreferenceFragment : Android.App.Fragment
    {
        const string _bridgeClassName = "android.preference.PreferenceFragment";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PreferenceFragment class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreferenceFragment() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PreferenceFragment class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PreferenceFragment(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region OnPreferenceStartFragmentCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.OnPreferenceStartFragmentCallback.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class OnPreferenceStartFragmentCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<OnPreferenceStartFragmentCallback>
        {
            const string _bridgeClassName = "android.preference.PreferenceFragment$OnPreferenceStartFragmentCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("OnPreferenceStartFragmentCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OnPreferenceStartFragmentCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("OnPreferenceStartFragmentCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public OnPreferenceStartFragmentCallback(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
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

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region PreferenceFragment implementation
    public partial class PreferenceFragment
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
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html#findPreference(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Preference.Preference"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.Preference FindPreference(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.Preference.Preference>("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html#getPreferenceManager()"/>
        /// </summary>
        /// <returns><see cref="Android.Preference.PreferenceManager"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.PreferenceManager GetPreferenceManager()
        {
            return IExecuteWithSignature<Android.Preference.PreferenceManager>("getPreferenceManager", "()Landroid/preference/PreferenceManager;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html#getPreferenceScreen()"/>
        /// </summary>
        /// <returns><see cref="Android.Preference.PreferenceScreen"/></returns>
        [global::System.Obsolete()]
        public Android.Preference.PreferenceScreen GetPreferenceScreen()
        {
            return IExecuteWithSignature<Android.Preference.PreferenceScreen>("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html#onPreferenceTreeClick(android.preference.PreferenceScreen,android.preference.Preference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.PreferenceScreen"/></param>
        /// <param name="arg1"><see cref="Android.Preference.Preference"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool OnPreferenceTreeClick(Android.Preference.PreferenceScreen arg0, Android.Preference.Preference arg1)
        {
            return IExecute<bool>("onPreferenceTreeClick", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html#addPreferencesFromIntent(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        [global::System.Obsolete()]
        public void AddPreferencesFromIntent(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("addPreferencesFromIntent", "(Landroid/content/Intent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html#addPreferencesFromResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void AddPreferencesFromResource(int arg0)
        {
            IExecuteWithSignature("addPreferencesFromResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.html#setPreferenceScreen(android.preference.PreferenceScreen)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Preference.PreferenceScreen"/></param>
        [global::System.Obsolete()]
        public void SetPreferenceScreen(Android.Preference.PreferenceScreen arg0)
        {
            IExecuteWithSignature("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnPreferenceStartFragmentCallback implementation
        public partial class OnPreferenceStartFragmentCallback
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
            /// <see href="https://developer.android.com/reference/android/preference/PreferenceFragment.OnPreferenceStartFragmentCallback.html#onPreferenceStartFragment(android.preference.PreferenceFragment,android.preference.Preference)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Preference.PreferenceFragment"/></param>
            /// <param name="arg1"><see cref="Android.Preference.Preference"/></param>
            /// <returns><see cref="bool"/></returns>
            [global::System.Obsolete()]
            public bool OnPreferenceStartFragment(Android.Preference.PreferenceFragment arg0, Android.Preference.Preference arg1)
            {
                return IExecute<bool>("onPreferenceStartFragment", arg0, arg1);
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