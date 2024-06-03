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

namespace Android.App
{
    #region KeyguardManager
    public partial class KeyguardManager
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
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#newKeyguardLock(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.KeyguardManager.KeyguardLock"/></returns>
        [global::System.Obsolete()]
        public Android.App.KeyguardManager.KeyguardLock NewKeyguardLock(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.App.KeyguardManager.KeyguardLock>("newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#createConfirmDeviceCredentialIntent(java.lang.CharSequence,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        [global::System.Obsolete()]
        public Android.Content.Intent CreateConfirmDeviceCredentialIntent(Java.Lang.CharSequence arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Android.Content.Intent>("createConfirmDeviceCredentialIntent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#inKeyguardRestrictedInputMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool InKeyguardRestrictedInputMode()
        {
            return IExecuteWithSignature<bool>("inKeyguardRestrictedInputMode", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#isDeviceLocked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeviceLocked()
        {
            return IExecuteWithSignature<bool>("isDeviceLocked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#isDeviceSecure()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDeviceSecure()
        {
            return IExecuteWithSignature<bool>("isDeviceSecure", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#isKeyguardLocked()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsKeyguardLocked()
        {
            return IExecuteWithSignature<bool>("isKeyguardLocked", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#isKeyguardSecure()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsKeyguardSecure()
        {
            return IExecuteWithSignature<bool>("isKeyguardSecure", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#addKeyguardLockedStateListener(java.util.concurrent.Executor,android.app.KeyguardManager.KeyguardLockedStateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.App.KeyguardManager.KeyguardLockedStateListener"/></param>
        public void AddKeyguardLockedStateListener(Java.Util.Concurrent.Executor arg0, Android.App.KeyguardManager.KeyguardLockedStateListener arg1)
        {
            IExecute("addKeyguardLockedStateListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#exitKeyguardSecurely(android.app.KeyguardManager.OnKeyguardExitResult)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.KeyguardManager.OnKeyguardExitResult"/></param>
        [global::System.Obsolete()]
        public void ExitKeyguardSecurely(Android.App.KeyguardManager.OnKeyguardExitResult arg0)
        {
            IExecuteWithSignature("exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#removeKeyguardLockedStateListener(android.app.KeyguardManager.KeyguardLockedStateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.KeyguardManager.KeyguardLockedStateListener"/></param>
        public void RemoveKeyguardLockedStateListener(Android.App.KeyguardManager.KeyguardLockedStateListener arg0)
        {
            IExecuteWithSignature("removeKeyguardLockedStateListener", "(Landroid/app/KeyguardManager$KeyguardLockedStateListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.html#requestDismissKeyguard(android.app.Activity,android.app.KeyguardManager.KeyguardDismissCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.App.KeyguardManager.KeyguardDismissCallback"/></param>
        public void RequestDismissKeyguard(Android.App.Activity arg0, Android.App.KeyguardManager.KeyguardDismissCallback arg1)
        {
            IExecute("requestDismissKeyguard", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region KeyguardDismissCallback
        public partial class KeyguardDismissCallback
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
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardDismissCallback.html#onDismissCancelled()"/>
            /// </summary>
            public void OnDismissCancelled()
            {
                IExecuteWithSignature("onDismissCancelled", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardDismissCallback.html#onDismissError()"/>
            /// </summary>
            public void OnDismissError()
            {
                IExecuteWithSignature("onDismissError", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardDismissCallback.html#onDismissSucceeded()"/>
            /// </summary>
            public void OnDismissSucceeded()
            {
                IExecuteWithSignature("onDismissSucceeded", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyguardLock
        public partial class KeyguardLock
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
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardLock.html#disableKeyguard()"/>
            /// </summary>
            [global::System.Obsolete()]
            public void DisableKeyguard()
            {
                IExecuteWithSignature("disableKeyguard", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardLock.html#reenableKeyguard()"/>
            /// </summary>
            [global::System.Obsolete()]
            public void ReenableKeyguard()
            {
                IExecuteWithSignature("reenableKeyguard", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyguardLockedStateListener
        public partial class KeyguardLockedStateListener
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
            /// Handlers initializer for <see cref="KeyguardLockedStateListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onKeyguardLockedStateChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnKeyguardLockedStateChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardLockedStateListener.html#onKeyguardLockedStateChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnKeyguardLockedStateChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnKeyguardLockedStateChanged { get; set; } = null;

            void OnKeyguardLockedStateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnKeyguardLockedStateChanged != null) ? OnOnKeyguardLockedStateChanged : OnKeyguardLockedStateChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardLockedStateListener.html#onKeyguardLockedStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public virtual void OnKeyguardLockedStateChanged(bool arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyguardLockedStateListenerDirect
        public partial class KeyguardLockedStateListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.KeyguardLockedStateListener.html#onKeyguardLockedStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public override void OnKeyguardLockedStateChanged(bool arg0)
            {
                IExecuteWithSignature("onKeyguardLockedStateChanged", "(Z)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnKeyguardExitResult
        public partial class OnKeyguardExitResult
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
            /// <see href="https://developer.android.com/reference/android/app/KeyguardManager.OnKeyguardExitResult.html#onKeyguardExitResult(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            [global::System.Obsolete()]
            public void OnKeyguardExitResultMethod(bool arg0)
            {
                IExecuteWithSignature("onKeyguardExitResult", "(Z)V", arg0);
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