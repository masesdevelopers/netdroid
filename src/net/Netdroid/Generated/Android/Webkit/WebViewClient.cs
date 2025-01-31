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

namespace Android.Webkit
{
    #region WebViewClient declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html"/>
    /// </summary>
    public partial class WebViewClient : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WebViewClient>
    {
        const string _bridgeClassName = "android.webkit.WebViewClient";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WebViewClient() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public WebViewClient(params object[] args) : base(args) { }
    
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

    #region WebViewClient implementation
    public partial class WebViewClient
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_AUTHENTICATION"/>
        /// </summary>
        public static int ERROR_AUTHENTICATION { get { if (!_ERROR_AUTHENTICATIONReady) { _ERROR_AUTHENTICATIONContent = SGetField<int>(LocalBridgeClazz, "ERROR_AUTHENTICATION"); _ERROR_AUTHENTICATIONReady = true; } return _ERROR_AUTHENTICATIONContent; } }
        private static int _ERROR_AUTHENTICATIONContent = default;
        private static bool _ERROR_AUTHENTICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_BAD_URL"/>
        /// </summary>
        public static int ERROR_BAD_URL { get { if (!_ERROR_BAD_URLReady) { _ERROR_BAD_URLContent = SGetField<int>(LocalBridgeClazz, "ERROR_BAD_URL"); _ERROR_BAD_URLReady = true; } return _ERROR_BAD_URLContent; } }
        private static int _ERROR_BAD_URLContent = default;
        private static bool _ERROR_BAD_URLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_CONNECT"/>
        /// </summary>
        public static int ERROR_CONNECT { get { if (!_ERROR_CONNECTReady) { _ERROR_CONNECTContent = SGetField<int>(LocalBridgeClazz, "ERROR_CONNECT"); _ERROR_CONNECTReady = true; } return _ERROR_CONNECTContent; } }
        private static int _ERROR_CONNECTContent = default;
        private static bool _ERROR_CONNECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_FAILED_SSL_HANDSHAKE"/>
        /// </summary>
        public static int ERROR_FAILED_SSL_HANDSHAKE { get { if (!_ERROR_FAILED_SSL_HANDSHAKEReady) { _ERROR_FAILED_SSL_HANDSHAKEContent = SGetField<int>(LocalBridgeClazz, "ERROR_FAILED_SSL_HANDSHAKE"); _ERROR_FAILED_SSL_HANDSHAKEReady = true; } return _ERROR_FAILED_SSL_HANDSHAKEContent; } }
        private static int _ERROR_FAILED_SSL_HANDSHAKEContent = default;
        private static bool _ERROR_FAILED_SSL_HANDSHAKEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_FILE"/>
        /// </summary>
        public static int ERROR_FILE { get { if (!_ERROR_FILEReady) { _ERROR_FILEContent = SGetField<int>(LocalBridgeClazz, "ERROR_FILE"); _ERROR_FILEReady = true; } return _ERROR_FILEContent; } }
        private static int _ERROR_FILEContent = default;
        private static bool _ERROR_FILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_FILE_NOT_FOUND"/>
        /// </summary>
        public static int ERROR_FILE_NOT_FOUND { get { if (!_ERROR_FILE_NOT_FOUNDReady) { _ERROR_FILE_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "ERROR_FILE_NOT_FOUND"); _ERROR_FILE_NOT_FOUNDReady = true; } return _ERROR_FILE_NOT_FOUNDContent; } }
        private static int _ERROR_FILE_NOT_FOUNDContent = default;
        private static bool _ERROR_FILE_NOT_FOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_HOST_LOOKUP"/>
        /// </summary>
        public static int ERROR_HOST_LOOKUP { get { if (!_ERROR_HOST_LOOKUPReady) { _ERROR_HOST_LOOKUPContent = SGetField<int>(LocalBridgeClazz, "ERROR_HOST_LOOKUP"); _ERROR_HOST_LOOKUPReady = true; } return _ERROR_HOST_LOOKUPContent; } }
        private static int _ERROR_HOST_LOOKUPContent = default;
        private static bool _ERROR_HOST_LOOKUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_IO"/>
        /// </summary>
        public static int ERROR_IO { get { if (!_ERROR_IOReady) { _ERROR_IOContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO"); _ERROR_IOReady = true; } return _ERROR_IOContent; } }
        private static int _ERROR_IOContent = default;
        private static bool _ERROR_IOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_PROXY_AUTHENTICATION"/>
        /// </summary>
        public static int ERROR_PROXY_AUTHENTICATION { get { if (!_ERROR_PROXY_AUTHENTICATIONReady) { _ERROR_PROXY_AUTHENTICATIONContent = SGetField<int>(LocalBridgeClazz, "ERROR_PROXY_AUTHENTICATION"); _ERROR_PROXY_AUTHENTICATIONReady = true; } return _ERROR_PROXY_AUTHENTICATIONContent; } }
        private static int _ERROR_PROXY_AUTHENTICATIONContent = default;
        private static bool _ERROR_PROXY_AUTHENTICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_REDIRECT_LOOP"/>
        /// </summary>
        public static int ERROR_REDIRECT_LOOP { get { if (!_ERROR_REDIRECT_LOOPReady) { _ERROR_REDIRECT_LOOPContent = SGetField<int>(LocalBridgeClazz, "ERROR_REDIRECT_LOOP"); _ERROR_REDIRECT_LOOPReady = true; } return _ERROR_REDIRECT_LOOPContent; } }
        private static int _ERROR_REDIRECT_LOOPContent = default;
        private static bool _ERROR_REDIRECT_LOOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_TIMEOUT"/>
        /// </summary>
        public static int ERROR_TIMEOUT { get { if (!_ERROR_TIMEOUTReady) { _ERROR_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "ERROR_TIMEOUT"); _ERROR_TIMEOUTReady = true; } return _ERROR_TIMEOUTContent; } }
        private static int _ERROR_TIMEOUTContent = default;
        private static bool _ERROR_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_TOO_MANY_REQUESTS"/>
        /// </summary>
        public static int ERROR_TOO_MANY_REQUESTS { get { if (!_ERROR_TOO_MANY_REQUESTSReady) { _ERROR_TOO_MANY_REQUESTSContent = SGetField<int>(LocalBridgeClazz, "ERROR_TOO_MANY_REQUESTS"); _ERROR_TOO_MANY_REQUESTSReady = true; } return _ERROR_TOO_MANY_REQUESTSContent; } }
        private static int _ERROR_TOO_MANY_REQUESTSContent = default;
        private static bool _ERROR_TOO_MANY_REQUESTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_UNKNOWN"/>
        /// </summary>
        public static int ERROR_UNKNOWN { get { if (!_ERROR_UNKNOWNReady) { _ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNKNOWN"); _ERROR_UNKNOWNReady = true; } return _ERROR_UNKNOWNContent; } }
        private static int _ERROR_UNKNOWNContent = default;
        private static bool _ERROR_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_UNSAFE_RESOURCE"/>
        /// </summary>
        public static int ERROR_UNSAFE_RESOURCE { get { if (!_ERROR_UNSAFE_RESOURCEReady) { _ERROR_UNSAFE_RESOURCEContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNSAFE_RESOURCE"); _ERROR_UNSAFE_RESOURCEReady = true; } return _ERROR_UNSAFE_RESOURCEContent; } }
        private static int _ERROR_UNSAFE_RESOURCEContent = default;
        private static bool _ERROR_UNSAFE_RESOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_UNSUPPORTED_AUTH_SCHEME"/>
        /// </summary>
        public static int ERROR_UNSUPPORTED_AUTH_SCHEME { get { if (!_ERROR_UNSUPPORTED_AUTH_SCHEMEReady) { _ERROR_UNSUPPORTED_AUTH_SCHEMEContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNSUPPORTED_AUTH_SCHEME"); _ERROR_UNSUPPORTED_AUTH_SCHEMEReady = true; } return _ERROR_UNSUPPORTED_AUTH_SCHEMEContent; } }
        private static int _ERROR_UNSUPPORTED_AUTH_SCHEMEContent = default;
        private static bool _ERROR_UNSUPPORTED_AUTH_SCHEMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#ERROR_UNSUPPORTED_SCHEME"/>
        /// </summary>
        public static int ERROR_UNSUPPORTED_SCHEME { get { if (!_ERROR_UNSUPPORTED_SCHEMEReady) { _ERROR_UNSUPPORTED_SCHEMEContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNSUPPORTED_SCHEME"); _ERROR_UNSUPPORTED_SCHEMEReady = true; } return _ERROR_UNSUPPORTED_SCHEMEContent; } }
        private static int _ERROR_UNSUPPORTED_SCHEMEContent = default;
        private static bool _ERROR_UNSUPPORTED_SCHEMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#SAFE_BROWSING_THREAT_BILLING"/>
        /// </summary>
        public static int SAFE_BROWSING_THREAT_BILLING { get { if (!_SAFE_BROWSING_THREAT_BILLINGReady) { _SAFE_BROWSING_THREAT_BILLINGContent = SGetField<int>(LocalBridgeClazz, "SAFE_BROWSING_THREAT_BILLING"); _SAFE_BROWSING_THREAT_BILLINGReady = true; } return _SAFE_BROWSING_THREAT_BILLINGContent; } }
        private static int _SAFE_BROWSING_THREAT_BILLINGContent = default;
        private static bool _SAFE_BROWSING_THREAT_BILLINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#SAFE_BROWSING_THREAT_MALWARE"/>
        /// </summary>
        public static int SAFE_BROWSING_THREAT_MALWARE { get { if (!_SAFE_BROWSING_THREAT_MALWAREReady) { _SAFE_BROWSING_THREAT_MALWAREContent = SGetField<int>(LocalBridgeClazz, "SAFE_BROWSING_THREAT_MALWARE"); _SAFE_BROWSING_THREAT_MALWAREReady = true; } return _SAFE_BROWSING_THREAT_MALWAREContent; } }
        private static int _SAFE_BROWSING_THREAT_MALWAREContent = default;
        private static bool _SAFE_BROWSING_THREAT_MALWAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#SAFE_BROWSING_THREAT_PHISHING"/>
        /// </summary>
        public static int SAFE_BROWSING_THREAT_PHISHING { get { if (!_SAFE_BROWSING_THREAT_PHISHINGReady) { _SAFE_BROWSING_THREAT_PHISHINGContent = SGetField<int>(LocalBridgeClazz, "SAFE_BROWSING_THREAT_PHISHING"); _SAFE_BROWSING_THREAT_PHISHINGReady = true; } return _SAFE_BROWSING_THREAT_PHISHINGContent; } }
        private static int _SAFE_BROWSING_THREAT_PHISHINGContent = default;
        private static bool _SAFE_BROWSING_THREAT_PHISHINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#SAFE_BROWSING_THREAT_UNKNOWN"/>
        /// </summary>
        public static int SAFE_BROWSING_THREAT_UNKNOWN { get { if (!_SAFE_BROWSING_THREAT_UNKNOWNReady) { _SAFE_BROWSING_THREAT_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "SAFE_BROWSING_THREAT_UNKNOWN"); _SAFE_BROWSING_THREAT_UNKNOWNReady = true; } return _SAFE_BROWSING_THREAT_UNKNOWNContent; } }
        private static int _SAFE_BROWSING_THREAT_UNKNOWNContent = default;
        private static bool _SAFE_BROWSING_THREAT_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#SAFE_BROWSING_THREAT_UNWANTED_SOFTWARE"/>
        /// </summary>
        public static int SAFE_BROWSING_THREAT_UNWANTED_SOFTWARE { get { if (!_SAFE_BROWSING_THREAT_UNWANTED_SOFTWAREReady) { _SAFE_BROWSING_THREAT_UNWANTED_SOFTWAREContent = SGetField<int>(LocalBridgeClazz, "SAFE_BROWSING_THREAT_UNWANTED_SOFTWARE"); _SAFE_BROWSING_THREAT_UNWANTED_SOFTWAREReady = true; } return _SAFE_BROWSING_THREAT_UNWANTED_SOFTWAREContent; } }
        private static int _SAFE_BROWSING_THREAT_UNWANTED_SOFTWAREContent = default;
        private static bool _SAFE_BROWSING_THREAT_UNWANTED_SOFTWAREReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#shouldInterceptRequest(android.webkit.WebView,android.webkit.WebResourceRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebResourceRequest"/></param>
        /// <returns><see cref="Android.Webkit.WebResourceResponse"/></returns>
        public Android.Webkit.WebResourceResponse ShouldInterceptRequest(Android.Webkit.WebView arg0, Android.Webkit.WebResourceRequest arg1)
        {
            return IExecuteWithSignature<Android.Webkit.WebResourceResponse>("shouldInterceptRequest", "(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Landroid/webkit/WebResourceResponse;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#shouldInterceptRequest(android.webkit.WebView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Webkit.WebResourceResponse"/></returns>
        [global::System.Obsolete()]
        public Android.Webkit.WebResourceResponse ShouldInterceptRequest(Android.Webkit.WebView arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.Webkit.WebResourceResponse>("shouldInterceptRequest", "(Landroid/webkit/WebView;Ljava/lang/String;)Landroid/webkit/WebResourceResponse;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onRenderProcessGone(android.webkit.WebView,android.webkit.RenderProcessGoneDetail)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.RenderProcessGoneDetail"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnRenderProcessGone(Android.Webkit.WebView arg0, Android.Webkit.RenderProcessGoneDetail arg1)
        {
            return IExecuteWithSignature<bool>("onRenderProcessGone", "(Landroid/webkit/WebView;Landroid/webkit/RenderProcessGoneDetail;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#shouldOverrideKeyEvent(android.webkit.WebView,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldOverrideKeyEvent(Android.Webkit.WebView arg0, Android.View.KeyEvent arg1)
        {
            return IExecuteWithSignature<bool>("shouldOverrideKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#shouldOverrideUrlLoading(android.webkit.WebView,android.webkit.WebResourceRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebResourceRequest"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldOverrideUrlLoading(Android.Webkit.WebView arg0, Android.Webkit.WebResourceRequest arg1)
        {
            return IExecuteWithSignature<bool>("shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#shouldOverrideUrlLoading(android.webkit.WebView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool ShouldOverrideUrlLoading(Android.Webkit.WebView arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<bool>("shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#doUpdateVisitedHistory(android.webkit.WebView,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void DoUpdateVisitedHistory(Android.Webkit.WebView arg0, Java.Lang.String arg1, bool arg2)
        {
            IExecuteWithSignature("doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onFormResubmission(android.webkit.WebView,android.os.Message,android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Os.Message"/></param>
        /// <param name="arg2"><see cref="Android.Os.Message"/></param>
        public void OnFormResubmission(Android.Webkit.WebView arg0, Android.Os.Message arg1, Android.Os.Message arg2)
        {
            IExecuteWithSignature("onFormResubmission", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onLoadResource(android.webkit.WebView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnLoadResource(Android.Webkit.WebView arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("onLoadResource", "(Landroid/webkit/WebView;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onPageCommitVisible(android.webkit.WebView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnPageCommitVisible(Android.Webkit.WebView arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("onPageCommitVisible", "(Landroid/webkit/WebView;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onPageFinished(android.webkit.WebView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnPageFinished(Android.Webkit.WebView arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("onPageFinished", "(Landroid/webkit/WebView;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onPageStarted(android.webkit.WebView,java.lang.String,android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Bitmap"/></param>
        public void OnPageStarted(Android.Webkit.WebView arg0, Java.Lang.String arg1, Android.Graphics.Bitmap arg2)
        {
            IExecuteWithSignature("onPageStarted", "(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onReceivedClientCertRequest(android.webkit.WebView,android.webkit.ClientCertRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.ClientCertRequest"/></param>
        public void OnReceivedClientCertRequest(Android.Webkit.WebView arg0, Android.Webkit.ClientCertRequest arg1)
        {
            IExecuteWithSignature("onReceivedClientCertRequest", "(Landroid/webkit/WebView;Landroid/webkit/ClientCertRequest;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onReceivedError(android.webkit.WebView,android.webkit.WebResourceRequest,android.webkit.WebResourceError)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebResourceRequest"/></param>
        /// <param name="arg2"><see cref="Android.Webkit.WebResourceError"/></param>
        public void OnReceivedError(Android.Webkit.WebView arg0, Android.Webkit.WebResourceRequest arg1, Android.Webkit.WebResourceError arg2)
        {
            IExecuteWithSignature("onReceivedError", "(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;Landroid/webkit/WebResourceError;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onReceivedError(android.webkit.WebView,int,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void OnReceivedError(Android.Webkit.WebView arg0, int arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            IExecuteWithSignature("onReceivedError", "(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onReceivedHttpAuthRequest(android.webkit.WebView,android.webkit.HttpAuthHandler,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.HttpAuthHandler"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public void OnReceivedHttpAuthRequest(Android.Webkit.WebView arg0, Android.Webkit.HttpAuthHandler arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            IExecuteWithSignature("onReceivedHttpAuthRequest", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onReceivedHttpError(android.webkit.WebView,android.webkit.WebResourceRequest,android.webkit.WebResourceResponse)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebResourceRequest"/></param>
        /// <param name="arg2"><see cref="Android.Webkit.WebResourceResponse"/></param>
        public void OnReceivedHttpError(Android.Webkit.WebView arg0, Android.Webkit.WebResourceRequest arg1, Android.Webkit.WebResourceResponse arg2)
        {
            IExecuteWithSignature("onReceivedHttpError", "(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;Landroid/webkit/WebResourceResponse;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onReceivedLoginRequest(android.webkit.WebView,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public void OnReceivedLoginRequest(Android.Webkit.WebView arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            IExecuteWithSignature("onReceivedLoginRequest", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onReceivedSslError(android.webkit.WebView,android.webkit.SslErrorHandler,android.net.http.SslError)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.SslErrorHandler"/></param>
        /// <param name="arg2"><see cref="Android.Net.Http.SslError"/></param>
        public void OnReceivedSslError(Android.Webkit.WebView arg0, Android.Webkit.SslErrorHandler arg1, Android.Net.Http.SslError arg2)
        {
            IExecuteWithSignature("onReceivedSslError", "(Landroid/webkit/WebView;Landroid/webkit/SslErrorHandler;Landroid/net/http/SslError;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onSafeBrowsingHit(android.webkit.WebView,android.webkit.WebResourceRequest,int,android.webkit.SafeBrowsingResponse)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebResourceRequest"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Webkit.SafeBrowsingResponse"/></param>
        public void OnSafeBrowsingHit(Android.Webkit.WebView arg0, Android.Webkit.WebResourceRequest arg1, int arg2, Android.Webkit.SafeBrowsingResponse arg3)
        {
            IExecuteWithSignature("onSafeBrowsingHit", "(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;ILandroid/webkit/SafeBrowsingResponse;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onScaleChanged(android.webkit.WebView,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void OnScaleChanged(Android.Webkit.WebView arg0, float arg1, float arg2)
        {
            IExecuteWithSignature("onScaleChanged", "(Landroid/webkit/WebView;FF)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onTooManyRedirects(android.webkit.WebView,android.os.Message,android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.Os.Message"/></param>
        /// <param name="arg2"><see cref="Android.Os.Message"/></param>
        [global::System.Obsolete()]
        public void OnTooManyRedirects(Android.Webkit.WebView arg0, Android.Os.Message arg1, Android.Os.Message arg2)
        {
            IExecuteWithSignature("onTooManyRedirects", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebViewClient.html#onUnhandledKeyEvent(android.webkit.WebView,android.view.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Webkit.WebView"/></param>
        /// <param name="arg1"><see cref="Android.View.KeyEvent"/></param>
        public void OnUnhandledKeyEvent(Android.Webkit.WebView arg0, Android.View.KeyEvent arg1)
        {
            IExecuteWithSignature("onUnhandledKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}