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

namespace Android.Media.Projection
{
    #region MediaProjectionManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjectionManager.html"/>
    /// </summary>
    public partial class MediaProjectionManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MediaProjectionManager>
    {
        const string _bridgeClassName = "android.media.projection.MediaProjectionManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MediaProjectionManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MediaProjectionManager(params object[] args) : base(args) { }

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

    #region MediaProjectionManager implementation
    public partial class MediaProjectionManager
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
        /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjectionManager.html#createScreenCaptureIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateScreenCaptureIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("createScreenCaptureIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjectionManager.html#createScreenCaptureIntent(android.media.projection.MediaProjectionConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Projection.MediaProjectionConfig"/></param>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent CreateScreenCaptureIntent(Android.Media.Projection.MediaProjectionConfig arg0)
        {
            return IExecuteWithSignature<Android.Content.Intent>("createScreenCaptureIntent", "(Landroid/media/projection/MediaProjectionConfig;)Landroid/content/Intent;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/projection/MediaProjectionManager.html#getMediaProjection(int,android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Media.Projection.MediaProjection"/></returns>
        public Android.Media.Projection.MediaProjection GetMediaProjection(int arg0, Android.Content.Intent arg1)
        {
            return IExecute<Android.Media.Projection.MediaProjection>("getMediaProjection", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}