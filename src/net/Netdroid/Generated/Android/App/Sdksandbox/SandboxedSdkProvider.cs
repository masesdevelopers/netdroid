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

namespace Android.App.Sdksandbox
{
    #region SandboxedSdkProvider declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SandboxedSdkProvider.html"/>
    /// </summary>
    public partial class SandboxedSdkProvider : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SandboxedSdkProvider>
    {
        const string _bridgeClassName = "android.app.sdksandbox.SandboxedSdkProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SandboxedSdkProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SandboxedSdkProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SandboxedSdkProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SandboxedSdkProvider(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region SandboxedSdkProvider implementation
    public partial class SandboxedSdkProvider
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
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SandboxedSdkProvider.html#onLoadSdk(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.App.Sdksandbox.SandboxedSdk"/></returns>
        /// <exception cref="Android.App.Sdksandbox.LoadSdkException"/>
        public Android.App.Sdksandbox.SandboxedSdk OnLoadSdk(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.App.Sdksandbox.SandboxedSdk>("onLoadSdk", "(Landroid/os/Bundle;)Landroid/app/sdksandbox/SandboxedSdk;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SandboxedSdkProvider.html#getView(android.content.Context,android.os.Bundle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        [global::System.Obsolete()]
        public Android.View.View GetView(Android.Content.Context arg0, Android.Os.Bundle arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<Android.View.View>("getView", "(Landroid/content/Context;Landroid/os/Bundle;II)Landroid/view/View;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SandboxedSdkProvider.html#getContext()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Context"/></returns>
        public Android.Content.Context GetContext()
        {
            return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SandboxedSdkProvider.html#attachContext(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public void AttachContext(Android.Content.Context arg0)
        {
            IExecuteWithSignature("attachContext", "(Landroid/content/Context;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/sdksandbox/SandboxedSdkProvider.html#beforeUnloadSdk()"/>
        /// </summary>
        public void BeforeUnloadSdk()
        {
            IExecuteWithSignature("beforeUnloadSdk", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}