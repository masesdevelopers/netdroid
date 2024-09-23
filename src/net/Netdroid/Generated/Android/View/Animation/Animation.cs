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

namespace Android.View.Animation
{
    #region Animation declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html"/>
    /// </summary>
    public partial class Animation : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "android.view.animation.Animation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Animation class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Animation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Animation class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Animation(params object[] args) : base(args) { }

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
        #region AnimationListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html"/>
        /// </summary>
        public partial class AnimationListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AnimationListener() { InitializeHandlers(); }

            const string _bridgeClassName = "org.mases.netdroid.generated.android.view.animation.Animation_AnimationListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;

        
            // TODO: complete the class

        }
        #endregion

        #region AnimationListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="AnimationListener"/> or its generic type if there is one
        /// </summary>
        public partial class AnimationListenerDirect : AnimationListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;

            /// <inheritdoc />
            protected override void InitializeHandlers() { }

            const string _bridgeClassName = "android.view.animation.Animation$AnimationListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        }
        #endregion

    
    }
    #endregion

    #region Animation implementation
    public partial class Animation
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public Animation(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#ABSOLUTE"/>
        /// </summary>
        public static int ABSOLUTE { get { if (!_ABSOLUTEReady) { _ABSOLUTEContent = SGetField<int>(LocalBridgeClazz, "ABSOLUTE"); _ABSOLUTEReady = true; } return _ABSOLUTEContent; } }
        private static int _ABSOLUTEContent = default;
        private static bool _ABSOLUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#INFINITE"/>
        /// </summary>
        public static int INFINITE { get { if (!_INFINITEReady) { _INFINITEContent = SGetField<int>(LocalBridgeClazz, "INFINITE"); _INFINITEReady = true; } return _INFINITEContent; } }
        private static int _INFINITEContent = default;
        private static bool _INFINITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#RELATIVE_TO_PARENT"/>
        /// </summary>
        public static int RELATIVE_TO_PARENT { get { if (!_RELATIVE_TO_PARENTReady) { _RELATIVE_TO_PARENTContent = SGetField<int>(LocalBridgeClazz, "RELATIVE_TO_PARENT"); _RELATIVE_TO_PARENTReady = true; } return _RELATIVE_TO_PARENTContent; } }
        private static int _RELATIVE_TO_PARENTContent = default;
        private static bool _RELATIVE_TO_PARENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#RELATIVE_TO_SELF"/>
        /// </summary>
        public static int RELATIVE_TO_SELF { get { if (!_RELATIVE_TO_SELFReady) { _RELATIVE_TO_SELFContent = SGetField<int>(LocalBridgeClazz, "RELATIVE_TO_SELF"); _RELATIVE_TO_SELFReady = true; } return _RELATIVE_TO_SELFContent; } }
        private static int _RELATIVE_TO_SELFContent = default;
        private static bool _RELATIVE_TO_SELFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#RESTART"/>
        /// </summary>
        public static int RESTART { get { if (!_RESTARTReady) { _RESTARTContent = SGetField<int>(LocalBridgeClazz, "RESTART"); _RESTARTReady = true; } return _RESTARTContent; } }
        private static int _RESTARTContent = default;
        private static bool _RESTARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#REVERSE"/>
        /// </summary>
        public static int REVERSE { get { if (!_REVERSEReady) { _REVERSEContent = SGetField<int>(LocalBridgeClazz, "REVERSE"); _REVERSEReady = true; } return _REVERSEContent; } }
        private static int _REVERSEContent = default;
        private static bool _REVERSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#START_ON_FIRST_FRAME"/>
        /// </summary>
        public static int START_ON_FIRST_FRAME { get { if (!_START_ON_FIRST_FRAMEReady) { _START_ON_FIRST_FRAMEContent = SGetField<int>(LocalBridgeClazz, "START_ON_FIRST_FRAME"); _START_ON_FIRST_FRAMEReady = true; } return _START_ON_FIRST_FRAMEContent; } }
        private static int _START_ON_FIRST_FRAMEContent = default;
        private static bool _START_ON_FIRST_FRAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#ZORDER_BOTTOM"/>
        /// </summary>
        public static int ZORDER_BOTTOM { get { if (!_ZORDER_BOTTOMReady) { _ZORDER_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "ZORDER_BOTTOM"); _ZORDER_BOTTOMReady = true; } return _ZORDER_BOTTOMContent; } }
        private static int _ZORDER_BOTTOMContent = default;
        private static bool _ZORDER_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#ZORDER_NORMAL"/>
        /// </summary>
        public static int ZORDER_NORMAL { get { if (!_ZORDER_NORMALReady) { _ZORDER_NORMALContent = SGetField<int>(LocalBridgeClazz, "ZORDER_NORMAL"); _ZORDER_NORMALReady = true; } return _ZORDER_NORMALContent; } }
        private static int _ZORDER_NORMALContent = default;
        private static bool _ZORDER_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#ZORDER_TOP"/>
        /// </summary>
        public static int ZORDER_TOP { get { if (!_ZORDER_TOPReady) { _ZORDER_TOPContent = SGetField<int>(LocalBridgeClazz, "ZORDER_TOP"); _ZORDER_TOPReady = true; } return _ZORDER_TOPContent; } }
        private static int _ZORDER_TOPContent = default;
        private static bool _ZORDER_TOPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getInterpolator()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Animation.Interpolator"/></returns>
        public Android.View.Animation.Interpolator GetInterpolator()
        {
            return IExecuteWithSignature<Android.View.Animation.Interpolator>("getInterpolator", "()Landroid/view/animation/Interpolator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getDetachWallpaper()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetDetachWallpaper()
        {
            return IExecuteWithSignature<bool>("getDetachWallpaper", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getFillAfter()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetFillAfter()
        {
            return IExecuteWithSignature<bool>("getFillAfter", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getFillBefore()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetFillBefore()
        {
            return IExecuteWithSignature<bool>("getFillBefore", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getShowBackdrop()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetShowBackdrop()
        {
            return IExecuteWithSignature<bool>("getShowBackdrop", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getTransformation(long,android.view.animation.Transformation,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Android.View.Animation.Transformation"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetTransformation(long arg0, Android.View.Animation.Transformation arg1, float arg2)
        {
            return IExecute<bool>("getTransformation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getTransformation(long,android.view.animation.Transformation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Android.View.Animation.Transformation"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetTransformation(long arg0, Android.View.Animation.Transformation arg1)
        {
            return IExecute<bool>("getTransformation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#hasEnded()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasEnded()
        {
            return IExecuteWithSignature<bool>("hasEnded", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#hasStarted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasStarted()
        {
            return IExecuteWithSignature<bool>("hasStarted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#isFillEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFillEnabled()
        {
            return IExecuteWithSignature<bool>("isFillEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#isInitialized()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsInitialized()
        {
            return IExecuteWithSignature<bool>("isInitialized", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#willChangeBounds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WillChangeBounds()
        {
            return IExecuteWithSignature<bool>("willChangeBounds", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#willChangeTransformationMatrix()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WillChangeTransformationMatrix()
        {
            return IExecuteWithSignature<bool>("willChangeTransformationMatrix", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getBackdropColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBackdropColor()
        {
            return IExecuteWithSignature<int>("getBackdropColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getBackgroundColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetBackgroundColor()
        {
            return IExecuteWithSignature<int>("getBackgroundColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getRepeatCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRepeatCount()
        {
            return IExecuteWithSignature<int>("getRepeatCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getRepeatMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRepeatMode()
        {
            return IExecuteWithSignature<int>("getRepeatMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getZAdjustment()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetZAdjustment()
        {
            return IExecuteWithSignature<int>("getZAdjustment", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#computeDurationHint()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ComputeDurationHint()
        {
            return IExecuteWithSignature<long>("computeDurationHint", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDuration()
        {
            return IExecuteWithSignature<long>("getDuration", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getStartOffset()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStartOffset()
        {
            return IExecuteWithSignature<long>("getStartOffset", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#getStartTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStartTime()
        {
            return IExecuteWithSignature<long>("getStartTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#initialize(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void Initialize(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("initialize", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#restrictDuration(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void RestrictDuration(long arg0)
        {
            IExecuteWithSignature("restrictDuration", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#scaleCurrentDuration(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void ScaleCurrentDuration(float arg0)
        {
            IExecuteWithSignature("scaleCurrentDuration", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setAnimationListener(android.view.animation.Animation.AnimationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Animation.AnimationListener"/></param>
        public void SetAnimationListener(Android.View.Animation.Animation.AnimationListener arg0)
        {
            IExecuteWithSignature("setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setBackdropColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetBackdropColor(int arg0)
        {
            IExecuteWithSignature("setBackdropColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setBackgroundColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetBackgroundColor(int arg0)
        {
            IExecuteWithSignature("setBackgroundColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setDetachWallpaper(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void SetDetachWallpaper(bool arg0)
        {
            IExecuteWithSignature("setDetachWallpaper", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setDuration(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetDuration(long arg0)
        {
            IExecuteWithSignature("setDuration", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setFillAfter(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFillAfter(bool arg0)
        {
            IExecuteWithSignature("setFillAfter", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setFillBefore(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFillBefore(bool arg0)
        {
            IExecuteWithSignature("setFillBefore", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setFillEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFillEnabled(bool arg0)
        {
            IExecuteWithSignature("setFillEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setInterpolator(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetInterpolator(Android.Content.Context arg0, int arg1)
        {
            IExecute("setInterpolator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setInterpolator(android.view.animation.Interpolator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Animation.Interpolator"/></param>
        public void SetInterpolator(Android.View.Animation.Interpolator arg0)
        {
            IExecuteWithSignature("setInterpolator", "(Landroid/view/animation/Interpolator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setRepeatCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRepeatCount(int arg0)
        {
            IExecuteWithSignature("setRepeatCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setRepeatMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRepeatMode(int arg0)
        {
            IExecuteWithSignature("setRepeatMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setShowBackdrop(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetShowBackdrop(bool arg0)
        {
            IExecuteWithSignature("setShowBackdrop", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setStartOffset(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetStartOffset(long arg0)
        {
            IExecuteWithSignature("setStartOffset", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setStartTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetStartTime(long arg0)
        {
            IExecuteWithSignature("setStartTime", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#setZAdjustment(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetZAdjustment(int arg0)
        {
            IExecuteWithSignature("setZAdjustment", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#start()"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/animation/Animation.html#startNow()"/>
        /// </summary>
        public void StartNow()
        {
            IExecuteWithSignature("startNow", "()V");
        }

        #endregion

        #region Nested classes
        #region AnimationListener implementation
        public partial class AnimationListener
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
            /// Handlers initializer for <see cref="AnimationListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAnimationEnd", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnAnimationEndEventHandler));
                AddEventHandler("onAnimationRepeat", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnAnimationRepeatEventHandler));
                AddEventHandler("onAnimationStart", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnAnimationStartEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationEnd(android.view.animation.Animation)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationEnd"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.Animation.Animation> OnOnAnimationEnd { get; set; } = null;

            bool hasOverrideOnAnimationEnd = true;
            void OnAnimationEndEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnAnimationEnd = true;
                var methodToExecute = (OnOnAnimationEnd != null) ? OnOnAnimationEnd : OnAnimationEnd;
                methodToExecute.Invoke(data.EventData.GetAt<Android.View.Animation.Animation>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnAnimationEnd;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationEnd(android.view.animation.Animation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
            public virtual void OnAnimationEnd(Android.View.Animation.Animation arg0)
            {
                hasOverrideOnAnimationEnd = false;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationRepeat(android.view.animation.Animation)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationRepeat"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.Animation.Animation> OnOnAnimationRepeat { get; set; } = null;

            bool hasOverrideOnAnimationRepeat = true;
            void OnAnimationRepeatEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnAnimationRepeat = true;
                var methodToExecute = (OnOnAnimationRepeat != null) ? OnOnAnimationRepeat : OnAnimationRepeat;
                methodToExecute.Invoke(data.EventData.GetAt<Android.View.Animation.Animation>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnAnimationRepeat;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationRepeat(android.view.animation.Animation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
            public virtual void OnAnimationRepeat(Android.View.Animation.Animation arg0)
            {
                hasOverrideOnAnimationRepeat = false;
            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationStart(android.view.animation.Animation)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAnimationStart"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.Animation.Animation> OnOnAnimationStart { get; set; } = null;

            bool hasOverrideOnAnimationStart = true;
            void OnAnimationStartEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnAnimationStart = true;
                var methodToExecute = (OnOnAnimationStart != null) ? OnOnAnimationStart : OnAnimationStart;
                methodToExecute.Invoke(data.EventData.GetAt<Android.View.Animation.Animation>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnAnimationStart;
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationStart(android.view.animation.Animation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
            public virtual void OnAnimationStart(Android.View.Animation.Animation arg0)
            {
                hasOverrideOnAnimationStart = false;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AnimationListenerDirect implementation
        public partial class AnimationListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationEnd(android.view.animation.Animation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
            public override void OnAnimationEnd(Android.View.Animation.Animation arg0)
            {
                IExecuteWithSignature("onAnimationEnd", "(Landroid/view/animation/Animation;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationRepeat(android.view.animation.Animation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
            public override void OnAnimationRepeat(Android.View.Animation.Animation arg0)
            {
                IExecuteWithSignature("onAnimationRepeat", "(Landroid/view/animation/Animation;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/animation/Animation.AnimationListener.html#onAnimationStart(android.view.animation.Animation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Animation.Animation"/></param>
            public override void OnAnimationStart(Android.View.Animation.Animation arg0)
            {
                IExecuteWithSignature("onAnimationStart", "(Landroid/view/animation/Animation;)V", arg0);
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