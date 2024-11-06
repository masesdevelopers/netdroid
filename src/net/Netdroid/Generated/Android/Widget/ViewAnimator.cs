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

namespace Android.Widget
{
    #region ViewAnimator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html"/>
    /// </summary>
    public partial class ViewAnimator : Android.Widget.FrameLayout
    {
        const string _bridgeClassName = "android.widget.ViewAnimator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ViewAnimator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ViewAnimator(params object[] args) : base(args) { }
    
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

    #region ViewAnimator implementation
    public partial class ViewAnimator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public ViewAnimator(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public ViewAnimator(Android.Content.Context arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getInAnimation()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Animation.Animation"/></returns>
        public Android.View.Animation.Animation GetInAnimation()
        {
            return IExecuteWithSignature<Android.View.Animation.Animation>("getInAnimation", "()Landroid/view/animation/Animation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getOutAnimation()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Animation.Animation"/></returns>
        public Android.View.Animation.Animation GetOutAnimation()
        {
            return IExecuteWithSignature<Android.View.Animation.Animation>("getOutAnimation", "()Landroid/view/animation/Animation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getCurrentView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetCurrentView()
        {
            return IExecuteWithSignature<Android.View.View>("getCurrentView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getAnimateFirstView()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAnimateFirstView()
        {
            return IExecuteWithSignature<bool>("getAnimateFirstView", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#getDisplayedChild()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDisplayedChild()
        {
            return IExecuteWithSignature<int>("getDisplayedChild", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setAnimateFirstView(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAnimateFirstView(bool arg0)
        {
            IExecuteWithSignature("setAnimateFirstView", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setDisplayedChild(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDisplayedChild(int arg0)
        {
            IExecuteWithSignature("setDisplayedChild", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setInAnimation(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetInAnimation(Android.Content.Context arg0, int arg1)
        {
            IExecuteWithSignature("setInAnimation", "(Landroid/content/Context;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setInAnimation(android.view.animation.Animation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
        public void SetInAnimation(Android.View.Animation.Animation arg0)
        {
            IExecuteWithSignature("setInAnimation", "(Landroid/view/animation/Animation;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setOutAnimation(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetOutAnimation(Android.Content.Context arg0, int arg1)
        {
            IExecuteWithSignature("setOutAnimation", "(Landroid/content/Context;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#setOutAnimation(android.view.animation.Animation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
        public void SetOutAnimation(Android.View.Animation.Animation arg0)
        {
            IExecuteWithSignature("setOutAnimation", "(Landroid/view/animation/Animation;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#showNext()"/>
        /// </summary>
        public void ShowNext()
        {
            IExecuteWithSignature("showNext", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ViewAnimator.html#showPrevious()"/>
        /// </summary>
        public void ShowPrevious()
        {
            IExecuteWithSignature("showPrevious", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}