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

namespace Android.Animation
{
    #region AnimatorListenerAdapter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/animation/AnimatorListenerAdapter.html"/>
    /// </summary>
    public partial class AnimatorListenerAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AnimatorListenerAdapter>
    {
        const string _bridgeClassName = "android.animation.AnimatorListenerAdapter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AnimatorListenerAdapter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AnimatorListenerAdapter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AnimatorListenerAdapter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AnimatorListenerAdapter(params object[] args) : base(args) { }
    
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

    #region AnimatorListenerAdapter implementation
    public partial class AnimatorListenerAdapter
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
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorListenerAdapter.html#onAnimationCancel(android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void OnAnimationCancel(Android.Animation.Animator arg0)
        {
            IExecuteWithSignature("onAnimationCancel", "(Landroid/animation/Animator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorListenerAdapter.html#onAnimationEnd(android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void OnAnimationEnd(Android.Animation.Animator arg0)
        {
            IExecuteWithSignature("onAnimationEnd", "(Landroid/animation/Animator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorListenerAdapter.html#onAnimationPause(android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void OnAnimationPause(Android.Animation.Animator arg0)
        {
            IExecuteWithSignature("onAnimationPause", "(Landroid/animation/Animator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorListenerAdapter.html#onAnimationRepeat(android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void OnAnimationRepeat(Android.Animation.Animator arg0)
        {
            IExecuteWithSignature("onAnimationRepeat", "(Landroid/animation/Animator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorListenerAdapter.html#onAnimationResume(android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void OnAnimationResume(Android.Animation.Animator arg0)
        {
            IExecuteWithSignature("onAnimationResume", "(Landroid/animation/Animator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorListenerAdapter.html#onAnimationStart(android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void OnAnimationStart(Android.Animation.Animator arg0)
        {
            IExecuteWithSignature("onAnimationStart", "(Landroid/animation/Animator;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}