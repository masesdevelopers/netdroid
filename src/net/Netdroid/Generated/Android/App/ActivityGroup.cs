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

namespace Android.App
{
    #region ActivityGroup declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/ActivityGroup.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ActivityGroup : Android.App.Activity
    {
        const string _bridgeClassName = "android.app.ActivityGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ActivityGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ActivityGroup(params object[] args) : base(args) { }
    
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

    #region ActivityGroup implementation
    public partial class ActivityGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityGroup.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public ActivityGroup(bool arg0)
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
        /// <see href="https://developer.android.com/reference/android/app/ActivityGroup.html#getCurrentActivity()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Activity"/></returns>
        [global::System.Obsolete()]
        public Android.App.Activity GetCurrentActivity()
        {
            return IExecuteWithSignature<Android.App.Activity>("getCurrentActivity", "()Landroid/app/Activity;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityGroup.html#getCurrentActivity()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Activity"/></returns>
        [global::System.Obsolete()]
        public Android.App.Activity GetCurrentActivityDirect()
        {
            return IExecuteWithSignature<Android.App.ActivityDirect, Android.App.Activity>("getCurrentActivity", "()Landroid/app/Activity;");
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/app/ActivityGroup.html#getLocalActivityManager()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetLocalActivityManager"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.App.LocalActivityManager> OnGetLocalActivityManager { get; set; } = null;
        
        bool hasOverrideGetLocalActivityManager = true;
        void GetLocalActivityManagerEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetLocalActivityManager = true;
            var methodToExecute = (OnGetLocalActivityManager != null) ? OnGetLocalActivityManager : GetLocalActivityManager;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetLocalActivityManager, executionResult);
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ActivityGroup.html#getLocalActivityManager()"/>
        /// </summary>
        /// <returns><see cref="Android.App.LocalActivityManager"/></returns>
        [global::System.Obsolete()]
        public virtual Android.App.LocalActivityManager GetLocalActivityManager()
        {
            hasOverrideGetLocalActivityManager = false; return default;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}