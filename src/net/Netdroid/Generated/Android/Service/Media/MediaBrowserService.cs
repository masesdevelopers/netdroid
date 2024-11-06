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

namespace Android.Service.Media
{
    #region MediaBrowserService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html"/>
    /// </summary>
    public partial class MediaBrowserService : Android.App.Service
    {
        const string _bridgeClassName = "android.service.media.MediaBrowserService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("MediaBrowserService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MediaBrowserService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("MediaBrowserService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public MediaBrowserService(params object[] args) : base(args) { }
    
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
        #region BrowserRoot declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.BrowserRoot.html"/>
        /// </summary>
        public partial class BrowserRoot : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BrowserRoot>
        {
            const string _bridgeClassName = "android.service.media.MediaBrowserService$BrowserRoot";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public BrowserRoot() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public BrowserRoot(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region Result declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.Result.html"/>
        /// </summary>
        public partial class Result : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Result>
        {
            const string _bridgeClassName = "android.service.media.MediaBrowserService$Result";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Result() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Result(params object[] args) : base(args) { }
        
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

        #region Result<T> declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.Result.html"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public partial class Result<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Result<T>>
        {
            const string _bridgeClassName = "android.service.media.MediaBrowserService$Result";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Result() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Result(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region MediaBrowserService implementation
    public partial class MediaBrowserService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#onGetRoot(java.lang.String,int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Service.Media.MediaBrowserService.BrowserRoot"/></returns>
        public Android.Service.Media.MediaBrowserService.BrowserRoot OnGetRoot(Java.Lang.String arg0, int arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<Android.Service.Media.MediaBrowserService.BrowserRoot>("onGetRoot", "(Ljava/lang/String;ILandroid/os/Bundle;)Landroid/service/media/MediaBrowserService$BrowserRoot;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#onLoadChildren(java.lang.String,android.service.media.MediaBrowserService.Result)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Service.Media.MediaBrowserService.Result"/></param>
        public void OnLoadChildren(Java.Lang.String arg0, Android.Service.Media.MediaBrowserService.Result<Java.Util.List<Android.Media.Browse.MediaBrowser.MediaItem>> arg1)
        {
            IExecuteWithSignature("onLoadChildren", "(Ljava/lang/String;Landroid/service/media/MediaBrowserService$Result;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#getSessionToken()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaSession.Token"/></returns>
        public Android.Media.Session.MediaSession.Token GetSessionToken()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaSession.Token>("getSessionToken", "()Landroid/media/session/MediaSession$Token;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#getCurrentBrowserInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Session.MediaSessionManager.RemoteUserInfo"/></returns>
        public Android.Media.Session.MediaSessionManager.RemoteUserInfo GetCurrentBrowserInfo()
        {
            return IExecuteWithSignature<Android.Media.Session.MediaSessionManager.RemoteUserInfo>("getCurrentBrowserInfo", "()Landroid/media/session/MediaSessionManager$RemoteUserInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#getBrowserRootHints()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetBrowserRootHints()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getBrowserRootHints", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#dump(java.io.FileDescriptor,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void Dump(Java.Io.FileDescriptor arg0, Java.Io.PrintWriter arg1, Java.Lang.String[] arg2)
        {
            IExecuteWithSignature("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#notifyChildrenChanged(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public void NotifyChildrenChanged(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            IExecuteWithSignature("notifyChildrenChanged", "(Ljava/lang/String;Landroid/os/Bundle;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#notifyChildrenChanged(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void NotifyChildrenChanged(Java.Lang.String arg0)
        {
            IExecuteWithSignature("notifyChildrenChanged", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#onLoadChildren(java.lang.String,android.service.media.MediaBrowserService.Result,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Service.Media.MediaBrowserService.Result"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        public void OnLoadChildren(Java.Lang.String arg0, Android.Service.Media.MediaBrowserService.Result<Java.Util.List<Android.Media.Browse.MediaBrowser.MediaItem>> arg1, Android.Os.Bundle arg2)
        {
            IExecuteWithSignature("onLoadChildren", "(Ljava/lang/String;Landroid/service/media/MediaBrowserService$Result;Landroid/os/Bundle;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#onLoadItem(java.lang.String,android.service.media.MediaBrowserService.Result)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Service.Media.MediaBrowserService.Result"/></param>
        public void OnLoadItem(Java.Lang.String arg0, Android.Service.Media.MediaBrowserService.Result<Android.Media.Browse.MediaBrowser.MediaItem> arg1)
        {
            IExecuteWithSignature("onLoadItem", "(Ljava/lang/String;Landroid/service/media/MediaBrowserService$Result;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.html#setSessionToken(android.media.session.MediaSession.Token)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Session.MediaSession.Token"/></param>
        public void SetSessionToken(Android.Media.Session.MediaSession.Token arg0)
        {
            IExecuteWithSignature("setSessionToken", "(Landroid/media/session/MediaSession$Token;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region BrowserRoot implementation
        public partial class BrowserRoot
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.BrowserRoot.html#%3Cinit%3E(java.lang.String,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            public BrowserRoot(Java.Lang.String arg0, Android.Os.Bundle arg1)
                : base(arg0, arg1)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.BrowserRoot.html#EXTRA_OFFLINE"/>
            /// </summary>
            public static Java.Lang.String EXTRA_OFFLINE { get { if (!_EXTRA_OFFLINEReady) { _EXTRA_OFFLINEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_OFFLINE"); _EXTRA_OFFLINEReady = true; } return _EXTRA_OFFLINEContent; } }
            private static Java.Lang.String _EXTRA_OFFLINEContent = default;
            private static bool _EXTRA_OFFLINEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.BrowserRoot.html#EXTRA_RECENT"/>
            /// </summary>
            public static Java.Lang.String EXTRA_RECENT { get { if (!_EXTRA_RECENTReady) { _EXTRA_RECENTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RECENT"); _EXTRA_RECENTReady = true; } return _EXTRA_RECENTContent; } }
            private static Java.Lang.String _EXTRA_RECENTContent = default;
            private static bool _EXTRA_RECENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.BrowserRoot.html#EXTRA_SUGGESTED"/>
            /// </summary>
            public static Java.Lang.String EXTRA_SUGGESTED { get { if (!_EXTRA_SUGGESTEDReady) { _EXTRA_SUGGESTEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SUGGESTED"); _EXTRA_SUGGESTEDReady = true; } return _EXTRA_SUGGESTEDContent; } }
            private static Java.Lang.String _EXTRA_SUGGESTEDContent = default;
            private static bool _EXTRA_SUGGESTEDReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.BrowserRoot.html#getExtras()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetExtras()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.BrowserRoot.html#getRootId()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetRootId()
            {
                return IExecuteWithSignature<Java.Lang.String>("getRootId", "()Ljava/lang/String;");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Result implementation
        public partial class Result
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
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.Result.html#detach()"/>
            /// </summary>
            public void Detach()
            {
                IExecuteWithSignature("detach", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.Result.html#sendResult(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void SendResult(object arg0)
            {
                IExecuteWithSignature("sendResult", "(Ljava/lang/Object;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Result<T> implementation
        public partial class Result<T>
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Service.Media.MediaBrowserService.Result{T}"/> to <see cref="Android.Service.Media.MediaBrowserService.Result"/>
            /// </summary>
            public static implicit operator Android.Service.Media.MediaBrowserService.Result(Android.Service.Media.MediaBrowserService.Result<T> t) => t.Cast<Android.Service.Media.MediaBrowserService.Result>();
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.Result.html#detach()"/>
            /// </summary>
            public void Detach()
            {
                IExecuteWithSignature("detach", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/media/MediaBrowserService.Result.html#sendResult(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="T"/></param>
            public void SendResult(T arg0)
            {
                IExecuteWithSignature("sendResult", "(Ljava/lang/Object;)V", arg0);
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