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

namespace Android.Content.Pm
{
    #region CrossProfileApps declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html"/>
    /// </summary>
    public partial class CrossProfileApps : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CrossProfileApps>
    {
        const string _bridgeClassName = "android.content.pm.CrossProfileApps";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CrossProfileApps() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CrossProfileApps(params object[] args) : base(args) { }
    
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

    #region CrossProfileApps implementation
    public partial class CrossProfileApps
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGED { get { if (!_ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGEDReady) { _ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGED"); _ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGEDReady = true; } return _ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGEDContent = default;
        private static bool _ACTION_CAN_INTERACT_ACROSS_PROFILES_CHANGEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#createRequestInteractAcrossProfilesIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateRequestInteractAcrossProfilesIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("createRequestInteractAcrossProfilesIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#getProfileSwitchingIconDrawable(android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetProfileSwitchingIconDrawable(Android.Os.UserHandle arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getProfileSwitchingIconDrawable", "(Landroid/os/UserHandle;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#canInteractAcrossProfiles()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanInteractAcrossProfiles()
        {
            return IExecuteWithSignature<bool>("canInteractAcrossProfiles", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#canRequestInteractAcrossProfiles()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanRequestInteractAcrossProfiles()
        {
            return IExecuteWithSignature<bool>("canRequestInteractAcrossProfiles", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#isManagedProfile(android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsManagedProfile(Android.Os.UserHandle arg0)
        {
            return IExecuteWithSignature<bool>("isManagedProfile", "(Landroid/os/UserHandle;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#isProfile(android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsProfile(Android.Os.UserHandle arg0)
        {
            return IExecuteWithSignature<bool>("isProfile", "(Landroid/os/UserHandle;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#getProfileSwitchingLabel(android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetProfileSwitchingLabel(Android.Os.UserHandle arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getProfileSwitchingLabel", "(Landroid/os/UserHandle;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#getTargetUserProfiles()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Os.UserHandle> GetTargetUserProfiles()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Os.UserHandle>>("getTargetUserProfiles", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#startActivity(android.content.Intent,android.os.UserHandle,android.app.Activity,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <param name="arg2"><see cref="Android.App.Activity"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public void StartActivity(Android.Content.Intent arg0, Android.Os.UserHandle arg1, Android.App.Activity arg2, Android.Os.Bundle arg3)
        {
            IExecuteWithSignature("startActivity", "(Landroid/content/Intent;Landroid/os/UserHandle;Landroid/app/Activity;Landroid/os/Bundle;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#startActivity(android.content.Intent,android.os.UserHandle,android.app.Activity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <param name="arg2"><see cref="Android.App.Activity"/></param>
        public void StartActivity(Android.Content.Intent arg0, Android.Os.UserHandle arg1, Android.App.Activity arg2)
        {
            IExecuteWithSignature("startActivity", "(Landroid/content/Intent;Landroid/os/UserHandle;Landroid/app/Activity;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#startMainActivity(android.content.ComponentName,android.os.UserHandle,android.app.Activity,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <param name="arg2"><see cref="Android.App.Activity"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        public void StartMainActivity(Android.Content.ComponentName arg0, Android.Os.UserHandle arg1, Android.App.Activity arg2, Android.Os.Bundle arg3)
        {
            IExecuteWithSignature("startMainActivity", "(Landroid/content/ComponentName;Landroid/os/UserHandle;Landroid/app/Activity;Landroid/os/Bundle;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/CrossProfileApps.html#startMainActivity(android.content.ComponentName,android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        public void StartMainActivity(Android.Content.ComponentName arg0, Android.Os.UserHandle arg1)
        {
            IExecuteWithSignature("startMainActivity", "(Landroid/content/ComponentName;Landroid/os/UserHandle;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}