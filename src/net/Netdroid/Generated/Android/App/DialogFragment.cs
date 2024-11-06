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

namespace Android.App
{
    #region DialogFragment declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class DialogFragment : Android.App.Fragment
    {
        const string _bridgeClassName = "android.app.DialogFragment";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DialogFragment() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DialogFragment(params object[] args) : base(args) { }
    
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

    #region DialogFragment implementation
    public partial class DialogFragment
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#STYLE_NO_FRAME"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STYLE_NO_FRAME { get { if (!_STYLE_NO_FRAMEReady) { _STYLE_NO_FRAMEContent = SGetField<int>(LocalBridgeClazz, "STYLE_NO_FRAME"); _STYLE_NO_FRAMEReady = true; } return _STYLE_NO_FRAMEContent; } }
        private static int _STYLE_NO_FRAMEContent = default;
        private static bool _STYLE_NO_FRAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#STYLE_NO_INPUT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STYLE_NO_INPUT { get { if (!_STYLE_NO_INPUTReady) { _STYLE_NO_INPUTContent = SGetField<int>(LocalBridgeClazz, "STYLE_NO_INPUT"); _STYLE_NO_INPUTReady = true; } return _STYLE_NO_INPUTContent; } }
        private static int _STYLE_NO_INPUTContent = default;
        private static bool _STYLE_NO_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#STYLE_NO_TITLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STYLE_NO_TITLE { get { if (!_STYLE_NO_TITLEReady) { _STYLE_NO_TITLEContent = SGetField<int>(LocalBridgeClazz, "STYLE_NO_TITLE"); _STYLE_NO_TITLEReady = true; } return _STYLE_NO_TITLEContent; } }
        private static int _STYLE_NO_TITLEContent = default;
        private static bool _STYLE_NO_TITLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#STYLE_NORMAL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int STYLE_NORMAL { get { if (!_STYLE_NORMALReady) { _STYLE_NORMALContent = SGetField<int>(LocalBridgeClazz, "STYLE_NORMAL"); _STYLE_NORMALReady = true; } return _STYLE_NORMALContent; } }
        private static int _STYLE_NORMALContent = default;
        private static bool _STYLE_NORMALReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#getDialog()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Dialog"/></returns>
        [global::System.Obsolete()]
        public Android.App.Dialog GetDialog()
        {
            return IExecuteWithSignature<Android.App.Dialog>("getDialog", "()Landroid/app/Dialog;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#onCreateDialog(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.App.Dialog"/></returns>
        [global::System.Obsolete()]
        public Android.App.Dialog OnCreateDialog(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.App.Dialog>("onCreateDialog", "(Landroid/os/Bundle;)Landroid/app/Dialog;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#getShowsDialog()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetShowsDialog()
        {
            return IExecuteWithSignature<bool>("getShowsDialog", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#isCancelable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsCancelable()
        {
            return IExecuteWithSignature<bool>("isCancelable", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#getTheme()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetTheme()
        {
            return IExecuteWithSignature<int>("getTheme", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#show(android.app.FragmentTransaction,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentTransaction"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int Show(Android.App.FragmentTransaction arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<int>("show", "(Landroid/app/FragmentTransaction;Ljava/lang/String;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#dismiss()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Dismiss()
        {
            IExecuteWithSignature("dismiss", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#dismissAllowingStateLoss()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DismissAllowingStateLoss()
        {
            IExecuteWithSignature("dismissAllowingStateLoss", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#onCancel(android.content.DialogInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.DialogInterface"/></param>
        [global::System.Obsolete()]
        public void OnCancel(Android.Content.DialogInterface arg0)
        {
            IExecuteWithSignature("onCancel", "(Landroid/content/DialogInterface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#onDismiss(android.content.DialogInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.DialogInterface"/></param>
        [global::System.Obsolete()]
        public void OnDismiss(Android.Content.DialogInterface arg0)
        {
            IExecuteWithSignature("onDismiss", "(Landroid/content/DialogInterface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#setCancelable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetCancelable(bool arg0)
        {
            IExecuteWithSignature("setCancelable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#setShowsDialog(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetShowsDialog(bool arg0)
        {
            IExecuteWithSignature("setShowsDialog", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#setStyle(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetStyle(int arg0, int arg1)
        {
            IExecuteWithSignature("setStyle", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/DialogFragment.html#show(android.app.FragmentManager,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.FragmentManager"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Show(Android.App.FragmentManager arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("show", "(Landroid/app/FragmentManager;Ljava/lang/String;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}