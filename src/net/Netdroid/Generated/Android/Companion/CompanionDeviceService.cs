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

namespace Android.Companion
{
    #region CompanionDeviceService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html"/>
    /// </summary>
    public partial class CompanionDeviceService : Android.App.Service
    {
        const string _bridgeClassName = "android.companion.CompanionDeviceService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CompanionDeviceService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CompanionDeviceService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CompanionDeviceService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CompanionDeviceService(params object[] args) : base(args) { }
    
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

    #region CompanionDeviceService implementation
    public partial class CompanionDeviceService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#attachSystemDataTransport(int,java.io.InputStream,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void AttachSystemDataTransport(int arg0, Java.Io.InputStream arg1, Java.Io.OutputStream arg2)
        {
            IExecuteWithSignature("attachSystemDataTransport", "(ILjava/io/InputStream;Ljava/io/OutputStream;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#detachSystemDataTransport(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Android.Companion.DeviceNotAssociatedException"/>
        public void DetachSystemDataTransport(int arg0)
        {
            IExecuteWithSignature("detachSystemDataTransport", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#onDeviceAppeared(android.companion.AssociationInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Companion.AssociationInfo"/></param>
        public void OnDeviceAppeared(Android.Companion.AssociationInfo arg0)
        {
            IExecuteWithSignature("onDeviceAppeared", "(Landroid/companion/AssociationInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#onDeviceAppeared(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void OnDeviceAppeared(Java.Lang.String arg0)
        {
            IExecuteWithSignature("onDeviceAppeared", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#onDeviceDisappeared(android.companion.AssociationInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Companion.AssociationInfo"/></param>
        public void OnDeviceDisappeared(Android.Companion.AssociationInfo arg0)
        {
            IExecuteWithSignature("onDeviceDisappeared", "(Landroid/companion/AssociationInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/CompanionDeviceService.html#onDeviceDisappeared(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void OnDeviceDisappeared(Java.Lang.String arg0)
        {
            IExecuteWithSignature("onDeviceDisappeared", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}