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

namespace Android.Security
{
    #region ConfirmationPrompt
    public partial class ConfirmationPrompt
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/ConfirmationPrompt.html#isSupported(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSupported(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSupported", "(Landroid/content/Context;)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/ConfirmationPrompt.html#cancelPrompt()"/>
        /// </summary>
        public void CancelPrompt()
        {
            IExecuteWithSignature("cancelPrompt", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/security/ConfirmationPrompt.html#presentPrompt(java.util.concurrent.Executor,android.security.ConfirmationCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.Security.ConfirmationCallback"/></param>
        /// <exception cref="Android.Security.ConfirmationAlreadyPresentingException"/>
        /// <exception cref="Android.Security.ConfirmationNotAvailableException"/>
        public void PresentPrompt(Java.Util.Concurrent.Executor arg0, Android.Security.ConfirmationCallback arg1)
        {
            IExecute("presentPrompt", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/ConfirmationPrompt.Builder.html#%3Cinit%3E(android.content.Context)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            public Builder(Android.Content.Context arg0)
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
            /// <see href="https://developer.android.com/reference/android/security/ConfirmationPrompt.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Security.ConfirmationPrompt"/></returns>
            public Android.Security.ConfirmationPrompt Build()
            {
                return IExecuteWithSignature<Android.Security.ConfirmationPrompt>("build", "()Landroid/security/ConfirmationPrompt;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/ConfirmationPrompt.Builder.html#setExtraData(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Security.ConfirmationPrompt.Builder"/></returns>
            public Android.Security.ConfirmationPrompt.Builder SetExtraData(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Security.ConfirmationPrompt.Builder>("setExtraData", "([B)Landroid/security/ConfirmationPrompt$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/security/ConfirmationPrompt.Builder.html#setPromptText(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Security.ConfirmationPrompt.Builder"/></returns>
            public Android.Security.ConfirmationPrompt.Builder SetPromptText(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Security.ConfirmationPrompt.Builder>("setPromptText", "(Ljava/lang/CharSequence;)Landroid/security/ConfirmationPrompt$Builder;", arg0);
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