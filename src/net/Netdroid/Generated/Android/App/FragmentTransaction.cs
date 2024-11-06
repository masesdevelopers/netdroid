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
    #region FragmentTransaction declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class FragmentTransaction : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FragmentTransaction>
    {
        const string _bridgeClassName = "android.app.FragmentTransaction";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FragmentTransaction class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FragmentTransaction() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FragmentTransaction class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FragmentTransaction(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region FragmentTransaction implementation
    public partial class FragmentTransaction
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#TRANSIT_ENTER_MASK"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSIT_ENTER_MASK { get { if (!_TRANSIT_ENTER_MASKReady) { _TRANSIT_ENTER_MASKContent = SGetField<int>(LocalBridgeClazz, "TRANSIT_ENTER_MASK"); _TRANSIT_ENTER_MASKReady = true; } return _TRANSIT_ENTER_MASKContent; } }
        private static int _TRANSIT_ENTER_MASKContent = default;
        private static bool _TRANSIT_ENTER_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#TRANSIT_EXIT_MASK"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSIT_EXIT_MASK { get { if (!_TRANSIT_EXIT_MASKReady) { _TRANSIT_EXIT_MASKContent = SGetField<int>(LocalBridgeClazz, "TRANSIT_EXIT_MASK"); _TRANSIT_EXIT_MASKReady = true; } return _TRANSIT_EXIT_MASKContent; } }
        private static int _TRANSIT_EXIT_MASKContent = default;
        private static bool _TRANSIT_EXIT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#TRANSIT_FRAGMENT_CLOSE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSIT_FRAGMENT_CLOSE { get { if (!_TRANSIT_FRAGMENT_CLOSEReady) { _TRANSIT_FRAGMENT_CLOSEContent = SGetField<int>(LocalBridgeClazz, "TRANSIT_FRAGMENT_CLOSE"); _TRANSIT_FRAGMENT_CLOSEReady = true; } return _TRANSIT_FRAGMENT_CLOSEContent; } }
        private static int _TRANSIT_FRAGMENT_CLOSEContent = default;
        private static bool _TRANSIT_FRAGMENT_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#TRANSIT_FRAGMENT_FADE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSIT_FRAGMENT_FADE { get { if (!_TRANSIT_FRAGMENT_FADEReady) { _TRANSIT_FRAGMENT_FADEContent = SGetField<int>(LocalBridgeClazz, "TRANSIT_FRAGMENT_FADE"); _TRANSIT_FRAGMENT_FADEReady = true; } return _TRANSIT_FRAGMENT_FADEContent; } }
        private static int _TRANSIT_FRAGMENT_FADEContent = default;
        private static bool _TRANSIT_FRAGMENT_FADEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#TRANSIT_FRAGMENT_OPEN"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSIT_FRAGMENT_OPEN { get { if (!_TRANSIT_FRAGMENT_OPENReady) { _TRANSIT_FRAGMENT_OPENContent = SGetField<int>(LocalBridgeClazz, "TRANSIT_FRAGMENT_OPEN"); _TRANSIT_FRAGMENT_OPENReady = true; } return _TRANSIT_FRAGMENT_OPENContent; } }
        private static int _TRANSIT_FRAGMENT_OPENContent = default;
        private static bool _TRANSIT_FRAGMENT_OPENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#TRANSIT_NONE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSIT_NONE { get { if (!_TRANSIT_NONEReady) { _TRANSIT_NONEContent = SGetField<int>(LocalBridgeClazz, "TRANSIT_NONE"); _TRANSIT_NONEReady = true; } return _TRANSIT_NONEContent; } }
        private static int _TRANSIT_NONEContent = default;
        private static bool _TRANSIT_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#TRANSIT_UNSET"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRANSIT_UNSET { get { if (!_TRANSIT_UNSETReady) { _TRANSIT_UNSETContent = SGetField<int>(LocalBridgeClazz, "TRANSIT_UNSET"); _TRANSIT_UNSETReady = true; } return _TRANSIT_UNSETContent; } }
        private static int _TRANSIT_UNSETContent = default;
        private static bool _TRANSIT_UNSETReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#add(android.app.Fragment,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Add(Android.App.Fragment arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("add", "(Landroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#add(int,android.app.Fragment,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Add(int arg0, Android.App.Fragment arg1, Java.Lang.String arg2)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("add", "(ILandroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#add(int,android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Add(int arg0, Android.App.Fragment arg1)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("add", "(ILandroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#addSharedElement(android.view.View,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction AddSharedElement(Android.View.View arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("addSharedElement", "(Landroid/view/View;Ljava/lang/String;)Landroid/app/FragmentTransaction;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#addToBackStack(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction AddToBackStack(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("addToBackStack", "(Ljava/lang/String;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#attach(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Attach(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("attach", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#detach(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Detach(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("detach", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#disallowAddToBackStack()"/>
        /// </summary>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction DisallowAddToBackStack()
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("disallowAddToBackStack", "()Landroid/app/FragmentTransaction;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#hide(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Hide(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("hide", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#remove(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Remove(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("remove", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#replace(int,android.app.Fragment,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Replace(int arg0, Android.App.Fragment arg1, Java.Lang.String arg2)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("replace", "(ILandroid/app/Fragment;Ljava/lang/String;)Landroid/app/FragmentTransaction;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#replace(int,android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Replace(int arg0, Android.App.Fragment arg1)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("replace", "(ILandroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#runOnCommit(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction RunOnCommit(Java.Lang.Runnable arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("runOnCommit", "(Ljava/lang/Runnable;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setBreadCrumbShortTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetBreadCrumbShortTitle(int arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setBreadCrumbShortTitle", "(I)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setBreadCrumbShortTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetBreadCrumbShortTitle(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setBreadCrumbShortTitle", "(Ljava/lang/CharSequence;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setBreadCrumbTitle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetBreadCrumbTitle(int arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setBreadCrumbTitle", "(I)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setBreadCrumbTitle(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetBreadCrumbTitle(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setBreadCrumbTitle", "(Ljava/lang/CharSequence;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setCustomAnimations(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetCustomAnimations(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setCustomAnimations", "(IIII)Landroid/app/FragmentTransaction;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setCustomAnimations(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetCustomAnimations(int arg0, int arg1)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setCustomAnimations", "(II)Landroid/app/FragmentTransaction;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setPrimaryNavigationFragment(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetPrimaryNavigationFragment(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setPrimaryNavigationFragment", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setReorderingAllowed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetReorderingAllowed(bool arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setReorderingAllowed", "(Z)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setTransition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetTransition(int arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setTransition", "(I)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#setTransitionStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction SetTransitionStyle(int arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("setTransitionStyle", "(I)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#show(android.app.Fragment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Fragment"/></param>
        /// <returns><see cref="Android.App.FragmentTransaction"/></returns>
        [global::System.Obsolete()]
        public Android.App.FragmentTransaction Show(Android.App.Fragment arg0)
        {
            return IExecuteWithSignature<Android.App.FragmentTransaction>("show", "(Landroid/app/Fragment;)Landroid/app/FragmentTransaction;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#isAddToBackStackAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsAddToBackStackAllowed()
        {
            return IExecuteWithSignature<bool>("isAddToBackStackAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#commit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int Commit()
        {
            return IExecuteWithSignature<int>("commit", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#commitAllowingStateLoss()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int CommitAllowingStateLoss()
        {
            return IExecuteWithSignature<int>("commitAllowingStateLoss", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#commitNow()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void CommitNow()
        {
            IExecuteWithSignature("commitNow", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/FragmentTransaction.html#commitNowAllowingStateLoss()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void CommitNowAllowingStateLoss()
        {
            IExecuteWithSignature("commitNowAllowingStateLoss", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}