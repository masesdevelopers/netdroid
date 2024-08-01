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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View
{
    #region TouchDelegate
    public partial class TouchDelegate
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#%3Cinit%3E(android.graphics.Rect,android.view.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        public TouchDelegate(Android.Graphics.Rect arg0, Android.View.View arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#ABOVE"/>
        /// </summary>
        public static int ABOVE { get { if (!_ABOVEReady) { _ABOVEContent = SGetField<int>(LocalBridgeClazz, "ABOVE"); _ABOVEReady = true; } return _ABOVEContent; } }
        private static int _ABOVEContent = default;
        private static bool _ABOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#BELOW"/>
        /// </summary>
        public static int BELOW { get { if (!_BELOWReady) { _BELOWContent = SGetField<int>(LocalBridgeClazz, "BELOW"); _BELOWReady = true; } return _BELOWContent; } }
        private static int _BELOWContent = default;
        private static bool _BELOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#TO_LEFT"/>
        /// </summary>
        public static int TO_LEFT { get { if (!_TO_LEFTReady) { _TO_LEFTContent = SGetField<int>(LocalBridgeClazz, "TO_LEFT"); _TO_LEFTReady = true; } return _TO_LEFTContent; } }
        private static int _TO_LEFTContent = default;
        private static bool _TO_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#TO_RIGHT"/>
        /// </summary>
        public static int TO_RIGHT { get { if (!_TO_RIGHTReady) { _TO_RIGHTContent = SGetField<int>(LocalBridgeClazz, "TO_RIGHT"); _TO_RIGHTReady = true; } return _TO_RIGHTContent; } }
        private static int _TO_RIGHTContent = default;
        private static bool _TO_RIGHTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#getTouchDelegateInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.AccessibilityNodeInfo.TouchDelegateInfo"/></returns>
        public Android.View.Accessibility.AccessibilityNodeInfo.TouchDelegateInfo GetTouchDelegateInfo()
        {
            return IExecuteWithSignature<Android.View.Accessibility.AccessibilityNodeInfo.TouchDelegateInfo>("getTouchDelegateInfo", "()Landroid/view/accessibility/AccessibilityNodeInfo$TouchDelegateInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#onTouchEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTouchEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onTouchEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/TouchDelegate.html#onTouchExplorationHoverEvent(android.view.MotionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.MotionEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnTouchExplorationHoverEvent(Android.View.MotionEvent arg0)
        {
            return IExecuteWithSignature<bool>("onTouchExplorationHoverEvent", "(Landroid/view/MotionEvent;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}