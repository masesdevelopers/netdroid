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
    #region AnimatorSet declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html"/>
    /// </summary>
    public partial class AnimatorSet : Android.Animation.Animator
    {
        const string _bridgeClassName = "android.animation.AnimatorSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AnimatorSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AnimatorSet(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.animation.AnimatorSet$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region AnimatorSet implementation
    public partial class AnimatorSet
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
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#play(android.animation.Animator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        /// <returns><see cref="Android.Animation.AnimatorSet.Builder"/></returns>
        public Android.Animation.AnimatorSet.Builder Play(Android.Animation.Animator arg0)
        {
            return IExecuteWithSignature<Android.Animation.AnimatorSet.Builder>("play", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#getChildAnimations()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Android.Animation.Animator> GetChildAnimations()
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Android.Animation.Animator>>("getChildAnimations", "()Ljava/util/ArrayList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#getCurrentPlayTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCurrentPlayTime()
        {
            return IExecuteWithSignature<long>("getCurrentPlayTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#playSequentially(android.animation.Animator[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void PlaySequentially(params Android.Animation.Animator[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("playSequentially", "([Landroid/animation/Animator;)V"); else IExecuteWithSignature("playSequentially", "([Landroid/animation/Animator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#playSequentially(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        public void PlaySequentially(Java.Util.List<Android.Animation.Animator> arg0)
        {
            IExecuteWithSignature("playSequentially", "(Ljava/util/List;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#playTogether(android.animation.Animator[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
        public void PlayTogether(params Android.Animation.Animator[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("playTogether", "([Landroid/animation/Animator;)V"); else IExecuteWithSignature("playTogether", "([Landroid/animation/Animator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#playTogether(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void PlayTogether(Java.Util.Collection<Android.Animation.Animator> arg0)
        {
            IExecuteWithSignature("playTogether", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#reverse()"/>
        /// </summary>
        public void Reverse()
        {
            IExecuteWithSignature("reverse", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.html#setCurrentPlayTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetCurrentPlayTime(long arg0)
        {
            IExecuteWithSignature("setCurrentPlayTime", "(J)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.Builder.html#after(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <returns><see cref="Android.Animation.AnimatorSet.Builder"/></returns>
            public Android.Animation.AnimatorSet.Builder After(Android.Animation.Animator arg0)
            {
                return IExecuteWithSignature<Android.Animation.AnimatorSet.Builder>("after", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.Builder.html#after(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Animation.AnimatorSet.Builder"/></returns>
            public Android.Animation.AnimatorSet.Builder After(long arg0)
            {
                return IExecuteWithSignature<Android.Animation.AnimatorSet.Builder>("after", "(J)Landroid/animation/AnimatorSet$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.Builder.html#before(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <returns><see cref="Android.Animation.AnimatorSet.Builder"/></returns>
            public Android.Animation.AnimatorSet.Builder Before(Android.Animation.Animator arg0)
            {
                return IExecuteWithSignature<Android.Animation.AnimatorSet.Builder>("before", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/animation/AnimatorSet.Builder.html#with(android.animation.Animator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Animation.Animator"/></param>
            /// <returns><see cref="Android.Animation.AnimatorSet.Builder"/></returns>
            public Android.Animation.AnimatorSet.Builder With(Android.Animation.Animator arg0)
            {
                return IExecuteWithSignature<Android.Animation.AnimatorSet.Builder>("with", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", arg0);
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