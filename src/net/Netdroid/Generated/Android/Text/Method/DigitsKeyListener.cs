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

namespace Android.Text.Method
{
    #region DigitsKeyListener
    public partial class DigitsKeyListener
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#%3Cinit%3E(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public DigitsKeyListener(bool arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#%3Cinit%3E(java.util.Locale,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public DigitsKeyListener(Java.Util.Locale arg0, bool arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DigitsKeyListener(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.Method.DigitsKeyListener"/></returns>
        [global::System.Obsolete()]
        public static Android.Text.Method.DigitsKeyListener GetInstance()
        {
            return SExecuteWithSignature<Android.Text.Method.DigitsKeyListener>(LocalBridgeClazz, "getInstance", "()Landroid/text/method/DigitsKeyListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#getInstance(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Android.Text.Method.DigitsKeyListener"/></returns>
        [global::System.Obsolete()]
        public static Android.Text.Method.DigitsKeyListener GetInstance(bool arg0, bool arg1)
        {
            return SExecute<Android.Text.Method.DigitsKeyListener>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Text.Method.DigitsKeyListener"/></returns>
        public static Android.Text.Method.DigitsKeyListener GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Text.Method.DigitsKeyListener>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Landroid/text/method/DigitsKeyListener;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#getInstance(java.util.Locale,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Android.Text.Method.DigitsKeyListener"/></returns>
        public static Android.Text.Method.DigitsKeyListener GetInstance(Java.Util.Locale arg0, bool arg1, bool arg2)
        {
            return SExecute<Android.Text.Method.DigitsKeyListener>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DigitsKeyListener.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Text.Method.DigitsKeyListener"/></returns>
        public static Android.Text.Method.DigitsKeyListener GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Text.Method.DigitsKeyListener>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/text/method/DigitsKeyListener;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}