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
    #region ActivityOptions
    public partial class ActivityOptions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#MODE_BACKGROUND_ACTIVITY_START_ALLOWED"/>
        /// </summary>
        public static int MODE_BACKGROUND_ACTIVITY_START_ALLOWED { get { if (!_MODE_BACKGROUND_ACTIVITY_START_ALLOWEDReady) { _MODE_BACKGROUND_ACTIVITY_START_ALLOWEDContent = SGetField<int>(LocalBridgeClazz, "MODE_BACKGROUND_ACTIVITY_START_ALLOWED"); _MODE_BACKGROUND_ACTIVITY_START_ALLOWEDReady = true; } return _MODE_BACKGROUND_ACTIVITY_START_ALLOWEDContent; } }
        private static int _MODE_BACKGROUND_ACTIVITY_START_ALLOWEDContent = default;
        private static bool _MODE_BACKGROUND_ACTIVITY_START_ALLOWEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#MODE_BACKGROUND_ACTIVITY_START_DENIED"/>
        /// </summary>
        public static int MODE_BACKGROUND_ACTIVITY_START_DENIED { get { if (!_MODE_BACKGROUND_ACTIVITY_START_DENIEDReady) { _MODE_BACKGROUND_ACTIVITY_START_DENIEDContent = SGetField<int>(LocalBridgeClazz, "MODE_BACKGROUND_ACTIVITY_START_DENIED"); _MODE_BACKGROUND_ACTIVITY_START_DENIEDReady = true; } return _MODE_BACKGROUND_ACTIVITY_START_DENIEDContent; } }
        private static int _MODE_BACKGROUND_ACTIVITY_START_DENIEDContent = default;
        private static bool _MODE_BACKGROUND_ACTIVITY_START_DENIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINED"/>
        /// </summary>
        public static int MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINED { get { if (!_MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINEDReady) { _MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINEDContent = SGetField<int>(LocalBridgeClazz, "MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINED"); _MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINEDReady = true; } return _MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINEDContent; } }
        private static int _MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINEDContent = default;
        private static bool _MODE_BACKGROUND_ACTIVITY_START_SYSTEM_DEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#EXTRA_USAGE_TIME_REPORT"/>
        /// </summary>
        public static Java.Lang.String EXTRA_USAGE_TIME_REPORT { get { if (!_EXTRA_USAGE_TIME_REPORTReady) { _EXTRA_USAGE_TIME_REPORTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_USAGE_TIME_REPORT"); _EXTRA_USAGE_TIME_REPORTReady = true; } return _EXTRA_USAGE_TIME_REPORTContent; } }
        private static Java.Lang.String _EXTRA_USAGE_TIME_REPORTContent = default;
        private static bool _EXTRA_USAGE_TIME_REPORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#EXTRA_USAGE_TIME_REPORT_PACKAGES"/>
        /// </summary>
        public static Java.Lang.String EXTRA_USAGE_TIME_REPORT_PACKAGES { get { if (!_EXTRA_USAGE_TIME_REPORT_PACKAGESReady) { _EXTRA_USAGE_TIME_REPORT_PACKAGESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_USAGE_TIME_REPORT_PACKAGES"); _EXTRA_USAGE_TIME_REPORT_PACKAGESReady = true; } return _EXTRA_USAGE_TIME_REPORT_PACKAGESContent; } }
        private static Java.Lang.String _EXTRA_USAGE_TIME_REPORT_PACKAGESContent = default;
        private static bool _EXTRA_USAGE_TIME_REPORT_PACKAGESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeBasic()"/>
        /// </summary>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeBasic()
        {
            return SExecuteWithSignature<Android.App.ActivityOptions>(LocalBridgeClazz, "makeBasic", "()Landroid/app/ActivityOptions;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeClipRevealAnimation(android.view.View,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeClipRevealAnimation(Android.View.View arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeClipRevealAnimation", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeCustomAnimation(android.content.Context,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeCustomAnimation(Android.Content.Context arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeCustomAnimation", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeCustomAnimation(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeCustomAnimation(Android.Content.Context arg0, int arg1, int arg2)
        {
            return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeCustomAnimation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeLaunchIntoPip(android.app.PictureInPictureParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PictureInPictureParams"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeLaunchIntoPip(Android.App.PictureInPictureParams arg0)
        {
            return SExecuteWithSignature<Android.App.ActivityOptions>(LocalBridgeClazz, "makeLaunchIntoPip", "(Landroid/app/PictureInPictureParams;)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeScaleUpAnimation(android.view.View,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeScaleUpAnimation(Android.View.View arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeScaleUpAnimation", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeSceneTransitionAnimation(android.app.Activity,android.util.Pair[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.Util.Pair"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeSceneTransitionAnimation(Android.App.Activity arg0, params Android.Util.Pair<Android.View.View, Java.Lang.String>[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeSceneTransitionAnimation", arg0); else return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeSceneTransitionAnimation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeSceneTransitionAnimation(android.app.Activity,android.view.View,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Activity"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeSceneTransitionAnimation(Android.App.Activity arg0, Android.View.View arg1, Java.Lang.String arg2)
        {
            return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeSceneTransitionAnimation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeTaskLaunchBehind()"/>
        /// </summary>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeTaskLaunchBehind()
        {
            return SExecuteWithSignature<Android.App.ActivityOptions>(LocalBridgeClazz, "makeTaskLaunchBehind", "()Landroid/app/ActivityOptions;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#makeThumbnailScaleUpAnimation(android.view.View,android.graphics.Bitmap,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public static Android.App.ActivityOptions MakeThumbnailScaleUpAnimation(Android.View.View arg0, Android.Graphics.Bitmap arg1, int arg2, int arg3)
        {
            return SExecute<Android.App.ActivityOptions>(LocalBridgeClazz, "makeThumbnailScaleUpAnimation", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#getLaunchBounds()"/> 
        /// </summary>
        public Android.Graphics.Rect LaunchBounds
        {
            get { return IExecuteWithSignature<Android.Graphics.Rect>("getLaunchBounds", "()Landroid/graphics/Rect;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#getLaunchDisplayId()"/> 
        /// </summary>
        public int LaunchDisplayId
        {
            get { return IExecuteWithSignature<int>("getLaunchDisplayId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#getLockTaskMode()"/> 
        /// </summary>
        public bool LockTaskMode
        {
            get { return IExecuteWithSignature<bool>("getLockTaskMode", "()Z"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#getPendingIntentBackgroundActivityStartMode()"/> 
        /// </summary>
        public int PendingIntentBackgroundActivityStartMode
        {
            get { return IExecuteWithSignature<int>("getPendingIntentBackgroundActivityStartMode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#getPendingIntentCreatorBackgroundActivityStartMode()"/> 
        /// </summary>
        public int PendingIntentCreatorBackgroundActivityStartMode
        {
            get { return IExecuteWithSignature<int>("getPendingIntentCreatorBackgroundActivityStartMode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#getSplashScreenStyle()"/> 
        /// </summary>
        public int SplashScreenStyle
        {
            get { return IExecuteWithSignature<int>("getSplashScreenStyle", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setAppVerificationBundle(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetAppVerificationBundle(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setAppVerificationBundle", "(Landroid/os/Bundle;)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setLaunchBounds(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetLaunchBounds(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setLaunchBounds", "(Landroid/graphics/Rect;)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setLaunchDisplayId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetLaunchDisplayId(int arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setLaunchDisplayId", "(I)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setLockTaskEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetLockTaskEnabled(bool arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setLockTaskEnabled", "(Z)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setPendingIntentBackgroundActivityStartMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetPendingIntentBackgroundActivityStartMode(int arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setPendingIntentBackgroundActivityStartMode", "(I)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setPendingIntentCreatorBackgroundActivityStartMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetPendingIntentCreatorBackgroundActivityStartMode(int arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setPendingIntentCreatorBackgroundActivityStartMode", "(I)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setShareIdentityEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetShareIdentityEnabled(bool arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setShareIdentityEnabled", "(Z)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setSplashScreenStyle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.App.ActivityOptions"/></returns>
        public Android.App.ActivityOptions SetSplashScreenStyle(int arg0)
        {
            return IExecuteWithSignature<Android.App.ActivityOptions>("setSplashScreenStyle", "(I)Landroid/app/ActivityOptions;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#toBundle()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle ToBundle()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("toBundle", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#isPendingIntentBackgroundActivityLaunchAllowed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [System.Obsolete()]
        public bool IsPendingIntentBackgroundActivityLaunchAllowed()
        {
            return IExecuteWithSignature<bool>("isPendingIntentBackgroundActivityLaunchAllowed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#isShareIdentityEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShareIdentityEnabled()
        {
            return IExecuteWithSignature<bool>("isShareIdentityEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#requestUsageTimeReport(android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
        public void RequestUsageTimeReport(Android.App.PendingIntent arg0)
        {
            IExecuteWithSignature("requestUsageTimeReport", "(Landroid/app/PendingIntent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#setPendingIntentBackgroundActivityLaunchAllowed(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [System.Obsolete()]
        public void SetPendingIntentBackgroundActivityLaunchAllowed(bool arg0)
        {
            IExecuteWithSignature("setPendingIntentBackgroundActivityLaunchAllowed", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityOptions.html#update(android.app.ActivityOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.ActivityOptions"/></param>
        public void Update(Android.App.ActivityOptions arg0)
        {
            IExecuteWithSignature("update", "(Landroid/app/ActivityOptions;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}