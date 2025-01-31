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

namespace Android.Drm
{
    #region DrmEvent declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class DrmEvent : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DrmEvent>
    {
        const string _bridgeClassName = "android.drm.DrmEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DrmEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DrmEvent(params object[] args) : base(args) { }
    
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

    #region DrmEvent implementation
    public partial class DrmEvent
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#TYPE_ALL_RIGHTS_REMOVED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_ALL_RIGHTS_REMOVED { get { if (!_TYPE_ALL_RIGHTS_REMOVEDReady) { _TYPE_ALL_RIGHTS_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_ALL_RIGHTS_REMOVED"); _TYPE_ALL_RIGHTS_REMOVEDReady = true; } return _TYPE_ALL_RIGHTS_REMOVEDContent; } }
        private static int _TYPE_ALL_RIGHTS_REMOVEDContent = default;
        private static bool _TYPE_ALL_RIGHTS_REMOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#TYPE_DRM_INFO_PROCESSED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_DRM_INFO_PROCESSED { get { if (!_TYPE_DRM_INFO_PROCESSEDReady) { _TYPE_DRM_INFO_PROCESSEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_DRM_INFO_PROCESSED"); _TYPE_DRM_INFO_PROCESSEDReady = true; } return _TYPE_DRM_INFO_PROCESSEDContent; } }
        private static int _TYPE_DRM_INFO_PROCESSEDContent = default;
        private static bool _TYPE_DRM_INFO_PROCESSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#DRM_INFO_OBJECT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String DRM_INFO_OBJECT { get { if (!_DRM_INFO_OBJECTReady) { _DRM_INFO_OBJECTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DRM_INFO_OBJECT"); _DRM_INFO_OBJECTReady = true; } return _DRM_INFO_OBJECTContent; } }
        private static Java.Lang.String _DRM_INFO_OBJECTContent = default;
        private static bool _DRM_INFO_OBJECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#DRM_INFO_STATUS_OBJECT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String DRM_INFO_STATUS_OBJECT { get { if (!_DRM_INFO_STATUS_OBJECTReady) { _DRM_INFO_STATUS_OBJECTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DRM_INFO_STATUS_OBJECT"); _DRM_INFO_STATUS_OBJECTReady = true; } return _DRM_INFO_STATUS_OBJECTContent; } }
        private static Java.Lang.String _DRM_INFO_STATUS_OBJECTContent = default;
        private static bool _DRM_INFO_STATUS_OBJECTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#getUniqueId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetUniqueId()
        {
            return IExecuteWithSignature<int>("getUniqueId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        [global::System.Obsolete()]
        public object GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmEvent.html#getMessage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetMessage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMessage", "()Ljava/lang/String;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}