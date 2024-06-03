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

namespace Android.Accessibilityservice
{
    #region GestureDescription
    public partial class GestureDescription
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getMaxStrokeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetMaxStrokeCount()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaxStrokeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getMaxGestureDuration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public static long GetMaxGestureDuration()
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "getMaxGestureDuration", "()J");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getStroke(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Accessibilityservice.GestureDescription.StrokeDescription"/></returns>
        public Android.Accessibilityservice.GestureDescription.StrokeDescription GetStroke(int arg0)
        {
            return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription.StrokeDescription>("getStroke", "(I)Landroid/accessibilityservice/GestureDescription$StrokeDescription;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getDisplayId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDisplayId()
        {
            return IExecuteWithSignature<int>("getDisplayId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.html#getStrokeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStrokeCount()
        {
            return IExecuteWithSignature<int>("getStrokeCount", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription"/></returns>
            public Android.Accessibilityservice.GestureDescription Build()
            {
                return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription>("build", "()Landroid/accessibilityservice/GestureDescription;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.Builder.html#addStroke(android.accessibilityservice.GestureDescription.StrokeDescription)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Accessibilityservice.GestureDescription.StrokeDescription"/></param>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription.Builder"/></returns>
            public Android.Accessibilityservice.GestureDescription.Builder AddStroke(Android.Accessibilityservice.GestureDescription.StrokeDescription arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription.Builder>("addStroke", "(Landroid/accessibilityservice/GestureDescription$StrokeDescription;)Landroid/accessibilityservice/GestureDescription$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.Builder.html#setDisplayId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription.Builder"/></returns>
            public Android.Accessibilityservice.GestureDescription.Builder SetDisplayId(int arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.GestureDescription.Builder>("setDisplayId", "(I)Landroid/accessibilityservice/GestureDescription$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region StrokeDescription
        public partial class StrokeDescription
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#%3Cinit%3E(android.graphics.Path,long,long,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="bool"/></param>
            public StrokeDescription(Android.Graphics.Path arg0, long arg1, long arg2, bool arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#%3Cinit%3E(android.graphics.Path,long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public StrokeDescription(Android.Graphics.Path arg0, long arg1, long arg2)
                : base(arg0, arg1, arg2)
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#continueStroke(android.graphics.Path,long,long,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            /// <param name="arg3"><see cref="bool"/></param>
            /// <returns><see cref="Android.Accessibilityservice.GestureDescription.StrokeDescription"/></returns>
            public Android.Accessibilityservice.GestureDescription.StrokeDescription ContinueStroke(Android.Graphics.Path arg0, long arg1, long arg2, bool arg3)
            {
                return IExecute<Android.Accessibilityservice.GestureDescription.StrokeDescription>("continueStroke", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#getPath()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Path"/></returns>
            public Android.Graphics.Path GetPath()
            {
                return IExecuteWithSignature<Android.Graphics.Path>("getPath", "()Landroid/graphics/Path;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#willContinue()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool WillContinue()
            {
                return IExecuteWithSignature<bool>("willContinue", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#getDuration()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetDuration()
            {
                return IExecuteWithSignature<long>("getDuration", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/GestureDescription.StrokeDescription.html#getStartTime()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetStartTime()
            {
                return IExecuteWithSignature<long>("getStartTime", "()J");
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