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

namespace Android.View
{
    #region ScrollCaptureTarget declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html"/>
    /// </summary>
    public partial class ScrollCaptureTarget : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ScrollCaptureTarget>
    {
        const string _bridgeClassName = "android.view.ScrollCaptureTarget";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScrollCaptureTarget() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScrollCaptureTarget(params object[] args) : base(args) { }

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

    #region ScrollCaptureTarget implementation
    public partial class ScrollCaptureTarget
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#%3Cinit%3E(android.view.View,android.graphics.Rect,android.graphics.Point,android.view.ScrollCaptureCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Point"/></param>
        /// <param name="arg3"><see cref="Android.View.ScrollCaptureCallback"/></param>
        public ScrollCaptureTarget(Android.View.View arg0, Android.Graphics.Rect arg1, Android.Graphics.Point arg2, Android.View.ScrollCaptureCallback arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getPositionInWindow()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetPositionInWindow()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getPositionInWindow", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getLocalVisibleRect()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public Android.Graphics.Rect GetLocalVisibleRect()
        {
            return IExecuteWithSignature<Android.Graphics.Rect>("getLocalVisibleRect", "()Landroid/graphics/Rect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getScrollBounds()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public Android.Graphics.Rect GetScrollBounds()
        {
            return IExecuteWithSignature<Android.Graphics.Rect>("getScrollBounds", "()Landroid/graphics/Rect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getCallback()"/>
        /// </summary>
        /// <returns><see cref="Android.View.ScrollCaptureCallback"/></returns>
        public Android.View.ScrollCaptureCallback GetCallback()
        {
            return IExecuteWithSignature<Android.View.ScrollCaptureCallback>("getCallback", "()Landroid/view/ScrollCaptureCallback;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getContainingView()"/>
        /// </summary>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View GetContainingView()
        {
            return IExecuteWithSignature<Android.View.View>("getContainingView", "()Landroid/view/View;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#getHint()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetHint()
        {
            return IExecuteWithSignature<int>("getHint", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#setScrollBounds(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void SetScrollBounds(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("setScrollBounds", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ScrollCaptureTarget.html#updatePositionInWindow()"/>
        /// </summary>
        public void UpdatePositionInWindow()
        {
            IExecuteWithSignature("updatePositionInWindow", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}