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

namespace Android.View
{
    #region ViewParent declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/ViewParent.html"/>
    /// </summary>
    public partial class ViewParent : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ViewParent>
    {
        const string _bridgeClassName = "android.view.ViewParent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ViewParent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ViewParent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ViewParent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ViewParent(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region IViewParent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IViewParent
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region ViewParent implementation
    public partial class ViewParent : Android.View.IViewParent
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
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#startActionModeForChild(android.view.View,android.view.ActionMode.Callback,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.ActionMode.Callback"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.View.ActionMode"/></returns>
        public Android.View.ActionMode StartActionModeForChild(Android.View.View arg0, Android.View.ActionMode.Callback arg1, int arg2)
        {
            return IExecuteWithSignature<Android.View.ActionMode>("startActionModeForChild", "(Landroid/view/View;Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#startActionModeForChild(android.view.View,android.view.ActionMode.Callback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.ActionMode.Callback"/></param>
        /// <returns><see cref="Android.View.ActionMode"/></returns>
        public Android.View.ActionMode StartActionModeForChild(Android.View.View arg0, Android.View.ActionMode.Callback arg1)
        {
            return IExecuteWithSignature<Android.View.ActionMode>("startActionModeForChild", "(Landroid/view/View;Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#focusSearch(android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View FocusSearch(Android.View.View arg0, int arg1)
        {
            return IExecuteWithSignature<Android.View.View>("focusSearch", "(Landroid/view/View;I)Landroid/view/View;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#keyboardNavigationClusterSearch(android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View KeyboardNavigationClusterSearch(Android.View.View arg0, int arg1)
        {
            return IExecuteWithSignature<Android.View.View>("keyboardNavigationClusterSearch", "(Landroid/view/View;I)Landroid/view/View;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#getParent()"/>
        /// </summary>
        /// <returns><see cref="Android.View.ViewParent"/></returns>
        public Android.View.ViewParent GetParent()
        {
            return IExecuteWithSignature<Android.View.ViewParent>("getParent", "()Landroid/view/ViewParent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#getParentForAccessibility()"/>
        /// </summary>
        /// <returns><see cref="Android.View.ViewParent"/></returns>
        public Android.View.ViewParent GetParentForAccessibility()
        {
            return IExecuteWithSignature<Android.View.ViewParent>("getParentForAccessibility", "()Landroid/view/ViewParent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#invalidateChildInParent(int[],android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.View.ViewParent"/></returns>
        [global::System.Obsolete()]
        public Android.View.ViewParent InvalidateChildInParent(int[] arg0, Android.Graphics.Rect arg1)
        {
            return IExecuteWithSignature<Android.View.ViewParent>("invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#canResolveLayoutDirection()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanResolveLayoutDirection()
        {
            return IExecuteWithSignature<bool>("canResolveLayoutDirection", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#canResolveTextAlignment()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanResolveTextAlignment()
        {
            return IExecuteWithSignature<bool>("canResolveTextAlignment", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#canResolveTextDirection()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanResolveTextDirection()
        {
            return IExecuteWithSignature<bool>("canResolveTextDirection", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#getChildVisibleRect(android.view.View,android.graphics.Rect,android.graphics.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Point"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetChildVisibleRect(Android.View.View arg0, Android.Graphics.Rect arg1, Android.Graphics.Point arg2)
        {
            return IExecuteWithSignature<bool>("getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#isLayoutDirectionResolved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLayoutDirectionResolved()
        {
            return IExecuteWithSignature<bool>("isLayoutDirectionResolved", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#isLayoutRequested()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLayoutRequested()
        {
            return IExecuteWithSignature<bool>("isLayoutRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#isTextAlignmentResolved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTextAlignmentResolved()
        {
            return IExecuteWithSignature<bool>("isTextAlignmentResolved", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#isTextDirectionResolved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTextDirectionResolved()
        {
            return IExecuteWithSignature<bool>("isTextDirectionResolved", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onNestedFling(android.view.View,float,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnNestedFling(Android.View.View arg0, float arg1, float arg2, bool arg3)
        {
            return IExecuteWithSignature<bool>("onNestedFling", "(Landroid/view/View;FFZ)Z", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onNestedPreFling(android.view.View,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnNestedPreFling(Android.View.View arg0, float arg1, float arg2)
        {
            return IExecuteWithSignature<bool>("onNestedPreFling", "(Landroid/view/View;FF)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onNestedPrePerformAccessibilityAction(android.view.View,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnNestedPrePerformAccessibilityAction(Android.View.View arg0, int arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<bool>("onNestedPrePerformAccessibilityAction", "(Landroid/view/View;ILandroid/os/Bundle;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onStartNestedScroll(android.view.View,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnStartNestedScroll(Android.View.View arg0, Android.View.View arg1, int arg2)
        {
            return IExecuteWithSignature<bool>("onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;I)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#requestChildRectangleOnScreen(android.view.View,android.graphics.Rect,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestChildRectangleOnScreen(Android.View.View arg0, Android.Graphics.Rect arg1, bool arg2)
        {
            return IExecuteWithSignature<bool>("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#requestSendAccessibilityEvent(android.view.View,android.view.accessibility.AccessibilityEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.Accessibility.AccessibilityEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestSendAccessibilityEvent(Android.View.View arg0, Android.View.Accessibility.AccessibilityEvent arg1)
        {
            return IExecuteWithSignature<bool>("requestSendAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#showContextMenuForChild(android.view.View,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShowContextMenuForChild(Android.View.View arg0, float arg1, float arg2)
        {
            return IExecuteWithSignature<bool>("showContextMenuForChild", "(Landroid/view/View;FF)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#showContextMenuForChild(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShowContextMenuForChild(Android.View.View arg0)
        {
            return IExecuteWithSignature<bool>("showContextMenuForChild", "(Landroid/view/View;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#getLayoutDirection()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLayoutDirection()
        {
            return IExecuteWithSignature<int>("getLayoutDirection", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#getTextAlignment()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextAlignment()
        {
            return IExecuteWithSignature<int>("getTextAlignment", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#getTextDirection()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextDirection()
        {
            return IExecuteWithSignature<int>("getTextDirection", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#bringChildToFront(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void BringChildToFront(Android.View.View arg0)
        {
            IExecuteWithSignature("bringChildToFront", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#childDrawableStateChanged(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void ChildDrawableStateChanged(Android.View.View arg0)
        {
            IExecuteWithSignature("childDrawableStateChanged", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#childHasTransientStateChanged(android.view.View,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void ChildHasTransientStateChanged(Android.View.View arg0, bool arg1)
        {
            IExecuteWithSignature("childHasTransientStateChanged", "(Landroid/view/View;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#clearChildFocus(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void ClearChildFocus(Android.View.View arg0)
        {
            IExecuteWithSignature("clearChildFocus", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#createContextMenu(android.view.ContextMenu)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.ContextMenu"/></param>
        public void CreateContextMenu(Android.View.ContextMenu arg0)
        {
            IExecuteWithSignature("createContextMenu", "(Landroid/view/ContextMenu;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#focusableViewAvailable(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void FocusableViewAvailable(Android.View.View arg0)
        {
            IExecuteWithSignature("focusableViewAvailable", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#invalidateChild(android.view.View,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        [global::System.Obsolete()]
        public void InvalidateChild(Android.View.View arg0, Android.Graphics.Rect arg1)
        {
            IExecuteWithSignature("invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#notifySubtreeAccessibilityStateChanged(android.view.View,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void NotifySubtreeAccessibilityStateChanged(Android.View.View arg0, Android.View.View arg1, int arg2)
        {
            IExecuteWithSignature("notifySubtreeAccessibilityStateChanged", "(Landroid/view/View;Landroid/view/View;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onNestedPreScroll(android.view.View,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void OnNestedPreScroll(Android.View.View arg0, int arg1, int arg2, int[] arg3)
        {
            IExecuteWithSignature("onNestedPreScroll", "(Landroid/view/View;II[I)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onNestedScroll(android.view.View,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void OnNestedScroll(Android.View.View arg0, int arg1, int arg2, int arg3, int arg4)
        {
            IExecuteWithSignature("onNestedScroll", "(Landroid/view/View;IIII)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onNestedScrollAccepted(android.view.View,android.view.View,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnNestedScrollAccepted(Android.View.View arg0, Android.View.View arg1, int arg2)
        {
            IExecuteWithSignature("onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onStopNestedScroll(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void OnStopNestedScroll(Android.View.View arg0)
        {
            IExecuteWithSignature("onStopNestedScroll", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#recomputeViewAttributes(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void RecomputeViewAttributes(Android.View.View arg0)
        {
            IExecuteWithSignature("recomputeViewAttributes", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#requestChildFocus(android.view.View,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        public void RequestChildFocus(Android.View.View arg0, Android.View.View arg1)
        {
            IExecuteWithSignature("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#requestDisallowInterceptTouchEvent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void RequestDisallowInterceptTouchEvent(bool arg0)
        {
            IExecuteWithSignature("requestDisallowInterceptTouchEvent", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#requestFitSystemWindows()"/>
        /// </summary>
        public void RequestFitSystemWindows()
        {
            IExecuteWithSignature("requestFitSystemWindows", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#requestLayout()"/>
        /// </summary>
        public void RequestLayout()
        {
            IExecuteWithSignature("requestLayout", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#requestTransparentRegion(android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        public void RequestTransparentRegion(Android.View.View arg0)
        {
            IExecuteWithSignature("requestTransparentRegion", "(Landroid/view/View;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#findOnBackInvokedDispatcherForChild(android.view.View,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <returns><see cref="Android.Window.OnBackInvokedDispatcher"/></returns>
        public Android.Window.OnBackInvokedDispatcher FindOnBackInvokedDispatcherForChild(Android.View.View arg0, Android.View.View arg1)
        {
            return IExecuteWithSignature<Android.Window.OnBackInvokedDispatcher>("findOnBackInvokedDispatcherForChild", "(Landroid/view/View;Landroid/view/View;)Landroid/window/OnBackInvokedDispatcher;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewParent.html#onDescendantInvalidated(android.view.View,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        public void OnDescendantInvalidated(Android.View.View arg0, Android.View.View arg1)
        {
            IExecuteWithSignature("onDescendantInvalidated", "(Landroid/view/View;Landroid/view/View;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}