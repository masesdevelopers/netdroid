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
    #region LocalActivityManager
    public partial class LocalActivityManager
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#%3Cinit%3E(android.app.Activity,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public LocalActivityManager(Android.App.Activity arg0, bool arg1)
            : base(arg0, arg1)
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
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#getActivity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.Activity"/></returns>
        [global::System.Obsolete()]
        public Android.App.Activity GetActivity(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.App.Activity>("getActivity", "(Ljava/lang/String;)Landroid/app/Activity;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#getCurrentActivity()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Activity"/></returns>
        [global::System.Obsolete()]
        public Android.App.Activity GetCurrentActivity()
        {
            return IExecuteWithSignature<Android.App.Activity>("getCurrentActivity", "()Landroid/app/Activity;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#saveInstanceState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        [global::System.Obsolete()]
        public Android.Os.Bundle SaveInstanceState()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("saveInstanceState", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#destroyActivity(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Android.View.Window"/></returns>
        [global::System.Obsolete()]
        public Android.View.Window DestroyActivity(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<Android.View.Window>("destroyActivity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#startActivity(java.lang.String,android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.View.Window"/></returns>
        [global::System.Obsolete()]
        public Android.View.Window StartActivity(Java.Lang.String arg0, Android.Content.Intent arg1)
        {
            return IExecute<Android.View.Window>("startActivity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#getCurrentId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetCurrentId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCurrentId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#dispatchCreate(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        [global::System.Obsolete()]
        public void DispatchCreate(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("dispatchCreate", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#dispatchDestroy(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void DispatchDestroy(bool arg0)
        {
            IExecuteWithSignature("dispatchDestroy", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#dispatchPause(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public void DispatchPause(bool arg0)
        {
            IExecuteWithSignature("dispatchPause", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#dispatchResume()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchResume()
        {
            IExecuteWithSignature("dispatchResume", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#dispatchStop()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void DispatchStop()
        {
            IExecuteWithSignature("dispatchStop", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LocalActivityManager.html#removeAllActivities()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void RemoveAllActivities()
        {
            IExecuteWithSignature("removeAllActivities", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}