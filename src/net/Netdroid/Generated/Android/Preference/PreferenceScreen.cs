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
    #region PreferenceScreen declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/preference/PreferenceScreen.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class PreferenceScreen : Android.Preference.PreferenceGroup
    {
        const string _bridgeClassName = "android.preference.PreferenceScreen";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PreferenceScreen() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PreferenceScreen(params object[] args) : base(args) { }

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

    }
    #endregion

    #region PreferenceScreen implementation
    public partial class PreferenceScreen
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
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceScreen.html#getDialog()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Dialog"/></returns>
        [global::System.Obsolete()]
        public Android.App.Dialog GetDialog()
        {
            return IExecuteWithSignature<Android.App.Dialog>("getDialog", "()Landroid/app/Dialog;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceScreen.html#getRootAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ListAdapter GetRootAdapter()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapter>("getRootAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceScreen.html#getRootAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.ListAdapter GetRootAdapterDirect()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapterDirect, Android.Widget.ListAdapter>("getRootAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceScreen.html#bind(android.widget.ListView)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ListView"/></param>
        [global::System.Obsolete()]
        public void Bind(Android.Widget.ListView arg0)
        {
            IExecuteWithSignature("bind", "(Landroid/widget/ListView;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceScreen.html#onDismiss(android.content.DialogInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.DialogInterface"/></param>
        [global::System.Obsolete()]
        public void OnDismiss(Android.Content.DialogInterface arg0)
        {
            IExecuteWithSignature("onDismiss", "(Landroid/content/DialogInterface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/PreferenceScreen.html#onItemClick(android.widget.AdapterView,android.view.View,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.AdapterView"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        [global::System.Obsolete()]
        public void OnItemClick(Android.Widget.AdapterView arg0, Android.View.View arg1, int arg2, long arg3)
        {
            IExecuteWithSignature("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}