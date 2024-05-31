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
    #region ViewConfiguration
    public partial class ViewConfiguration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getAmbiguousGestureMultiplier()"/> 
        /// </summary>
        [System.Obsolete()]
        public static float AmbiguousGestureMultiplier
        {
            get { return SExecuteWithSignature<float>(LocalBridgeClazz, "getAmbiguousGestureMultiplier", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getDefaultActionModeHideDuration()"/> 
        /// </summary>
        public static long DefaultActionModeHideDuration
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getDefaultActionModeHideDuration", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getDoubleTapTimeout()"/> 
        /// </summary>
        public static int DoubleTapTimeout
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getDoubleTapTimeout", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getEdgeSlop()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int EdgeSlop
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getEdgeSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getFadingEdgeLength()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int FadingEdgeLength
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getFadingEdgeLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getGlobalActionKeyTimeout()"/> 
        /// </summary>
        [System.Obsolete()]
        public static long GlobalActionKeyTimeout
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getGlobalActionKeyTimeout", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getJumpTapTimeout()"/> 
        /// </summary>
        public static int JumpTapTimeout
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getJumpTapTimeout", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getKeyRepeatDelay()"/> 
        /// </summary>
        public static int KeyRepeatDelay
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getKeyRepeatDelay", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getKeyRepeatTimeout()"/> 
        /// </summary>
        public static int KeyRepeatTimeout
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getKeyRepeatTimeout", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getLongPressTimeout()"/> 
        /// </summary>
        public static int LongPressTimeout
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getLongPressTimeout", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMaximumDrawingCacheSize()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int MaximumDrawingCacheSize
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaximumDrawingCacheSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMaximumFlingVelocity()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int MaximumFlingVelocity
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaximumFlingVelocity", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMinimumFlingVelocity()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int MinimumFlingVelocity
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMinimumFlingVelocity", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getMultiPressTimeout()"/> 
        /// </summary>
        public static int MultiPressTimeout
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getMultiPressTimeout", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getPressedStateDuration()"/> 
        /// </summary>
        public static int PressedStateDuration
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getPressedStateDuration", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollBarFadeDuration()"/> 
        /// </summary>
        public static int ScrollBarFadeDuration
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getScrollBarFadeDuration", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollBarSize()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int ScrollBarSize
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getScrollBarSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollDefaultDelay()"/> 
        /// </summary>
        public static int ScrollDefaultDelay
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getScrollDefaultDelay", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScrollFriction()"/> 
        /// </summary>
        public static float ScrollFriction
        {
            get { return SExecuteWithSignature<float>(LocalBridgeClazz, "getScrollFriction", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getTapTimeout()"/> 
        /// </summary>
        public static int TapTimeout
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getTapTimeout", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getTouchSlop()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int TouchSlop
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getTouchSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getWindowTouchSlop()"/> 
        /// </summary>
        [System.Obsolete()]
        public static int WindowTouchSlop
        {
            get { return SExecuteWithSignature<int>(LocalBridgeClazz, "getWindowTouchSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getZoomControlsTimeout()"/> 
        /// </summary>
        public static long ZoomControlsTimeout
        {
            get { return SExecuteWithSignature<long>(LocalBridgeClazz, "getZoomControlsTimeout", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#get(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.View.ViewConfiguration"/></returns>
        public static Android.View.ViewConfiguration Get(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.View.ViewConfiguration>(LocalBridgeClazz, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledAmbiguousGestureMultiplier()"/> 
        /// </summary>
        public float ScaledAmbiguousGestureMultiplier
        {
            get { return IExecuteWithSignature<float>("getScaledAmbiguousGestureMultiplier", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledDoubleTapSlop()"/> 
        /// </summary>
        public int ScaledDoubleTapSlop
        {
            get { return IExecuteWithSignature<int>("getScaledDoubleTapSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledEdgeSlop()"/> 
        /// </summary>
        public int ScaledEdgeSlop
        {
            get { return IExecuteWithSignature<int>("getScaledEdgeSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledFadingEdgeLength()"/> 
        /// </summary>
        public int ScaledFadingEdgeLength
        {
            get { return IExecuteWithSignature<int>("getScaledFadingEdgeLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHandwritingGestureLineMargin()"/> 
        /// </summary>
        public int ScaledHandwritingGestureLineMargin
        {
            get { return IExecuteWithSignature<int>("getScaledHandwritingGestureLineMargin", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHandwritingSlop()"/> 
        /// </summary>
        public int ScaledHandwritingSlop
        {
            get { return IExecuteWithSignature<int>("getScaledHandwritingSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHorizontalScrollFactor()"/> 
        /// </summary>
        public float ScaledHorizontalScrollFactor
        {
            get { return IExecuteWithSignature<float>("getScaledHorizontalScrollFactor", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledHoverSlop()"/> 
        /// </summary>
        public int ScaledHoverSlop
        {
            get { return IExecuteWithSignature<int>("getScaledHoverSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMaximumDrawingCacheSize()"/> 
        /// </summary>
        public int ScaledMaximumDrawingCacheSize
        {
            get { return IExecuteWithSignature<int>("getScaledMaximumDrawingCacheSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMaximumFlingVelocity()"/> 
        /// </summary>
        public int ScaledMaximumFlingVelocity
        {
            get { return IExecuteWithSignature<int>("getScaledMaximumFlingVelocity", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMinimumFlingVelocity()"/> 
        /// </summary>
        public int ScaledMinimumFlingVelocity
        {
            get { return IExecuteWithSignature<int>("getScaledMinimumFlingVelocity", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMinimumScalingSpan()"/> 
        /// </summary>
        public int ScaledMinimumScalingSpan
        {
            get { return IExecuteWithSignature<int>("getScaledMinimumScalingSpan", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledOverflingDistance()"/> 
        /// </summary>
        public int ScaledOverflingDistance
        {
            get { return IExecuteWithSignature<int>("getScaledOverflingDistance", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledOverscrollDistance()"/> 
        /// </summary>
        public int ScaledOverscrollDistance
        {
            get { return IExecuteWithSignature<int>("getScaledOverscrollDistance", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledPagingTouchSlop()"/> 
        /// </summary>
        public int ScaledPagingTouchSlop
        {
            get { return IExecuteWithSignature<int>("getScaledPagingTouchSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledScrollBarSize()"/> 
        /// </summary>
        public int ScaledScrollBarSize
        {
            get { return IExecuteWithSignature<int>("getScaledScrollBarSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledTouchSlop()"/> 
        /// </summary>
        public int ScaledTouchSlop
        {
            get { return IExecuteWithSignature<int>("getScaledTouchSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledVerticalScrollFactor()"/> 
        /// </summary>
        public float ScaledVerticalScrollFactor
        {
            get { return IExecuteWithSignature<float>("getScaledVerticalScrollFactor", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledWindowTouchSlop()"/> 
        /// </summary>
        public int ScaledWindowTouchSlop
        {
            get { return IExecuteWithSignature<int>("getScaledWindowTouchSlop", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#hasPermanentMenuKey()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasPermanentMenuKey()
        {
            return IExecuteWithSignature<bool>("hasPermanentMenuKey", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#shouldShowMenuShortcutsWhenKeyboardPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldShowMenuShortcutsWhenKeyboardPresent()
        {
            return IExecuteWithSignature<bool>("shouldShowMenuShortcutsWhenKeyboardPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMaximumFlingVelocity(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMaximumFlingVelocity(int arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScaledMaximumFlingVelocity", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewConfiguration.html#getScaledMinimumFlingVelocity(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScaledMinimumFlingVelocity(int arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScaledMinimumFlingVelocity", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}