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

namespace Android.Speech
{
    #region RecognitionService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html"/>
    /// </summary>
    public partial class RecognitionService : Android.App.Service
    {
        const string _bridgeClassName = "android.speech.RecognitionService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RecognitionService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RecognitionService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RecognitionService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RecognitionService(params object[] args) : base(args) { }
    
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
        #region Callback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html"/>
        /// </summary>
        public partial class Callback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Callback>
        {
            const string _bridgeClassName = "android.speech.RecognitionService$Callback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Callback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Callback(params object[] args) : base(args) { }
        
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

        #region SupportCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.SupportCallback.html"/>
        /// </summary>
        public partial class SupportCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SupportCallback>
        {
            const string _bridgeClassName = "android.speech.RecognitionService$SupportCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SupportCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SupportCallback(params object[] args) : base(args) { }
        
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

    
    }
    #endregion

    #region RecognitionService implementation
    public partial class RecognitionService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#getMaxConcurrentSessionsCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxConcurrentSessionsCount()
        {
            return IExecuteWithSignature<int>("getMaxConcurrentSessionsCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onCheckRecognitionSupport(android.content.Intent,android.content.AttributionSource,android.speech.RecognitionService.SupportCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Content.AttributionSource"/></param>
        /// <param name="arg2"><see cref="Android.Speech.RecognitionService.SupportCallback"/></param>
        public void OnCheckRecognitionSupport(Android.Content.Intent arg0, Android.Content.AttributionSource arg1, Android.Speech.RecognitionService.SupportCallback arg2)
        {
            IExecuteWithSignature("onCheckRecognitionSupport", "(Landroid/content/Intent;Landroid/content/AttributionSource;Landroid/speech/RecognitionService$SupportCallback;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onCheckRecognitionSupport(android.content.Intent,android.speech.RecognitionService.SupportCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Speech.RecognitionService.SupportCallback"/></param>
        public void OnCheckRecognitionSupport(Android.Content.Intent arg0, Android.Speech.RecognitionService.SupportCallback arg1)
        {
            IExecuteWithSignature("onCheckRecognitionSupport", "(Landroid/content/Intent;Landroid/speech/RecognitionService$SupportCallback;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onTriggerModelDownload(android.content.Intent,android.content.AttributionSource,android.speech.ModelDownloadListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Content.AttributionSource"/></param>
        /// <param name="arg2"><see cref="Android.Speech.ModelDownloadListener"/></param>
        public void OnTriggerModelDownload(Android.Content.Intent arg0, Android.Content.AttributionSource arg1, Android.Speech.ModelDownloadListener arg2)
        {
            IExecuteWithSignature("onTriggerModelDownload", "(Landroid/content/Intent;Landroid/content/AttributionSource;Landroid/speech/ModelDownloadListener;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onTriggerModelDownload(android.content.Intent,android.content.AttributionSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Android.Content.AttributionSource"/></param>
        public void OnTriggerModelDownload(Android.Content.Intent arg0, Android.Content.AttributionSource arg1)
        {
            IExecuteWithSignature("onTriggerModelDownload", "(Landroid/content/Intent;Landroid/content/AttributionSource;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.html#onTriggerModelDownload(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        public void OnTriggerModelDownload(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("onTriggerModelDownload", "(Landroid/content/Intent;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Callback implementation
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#getCallingAttributionSource()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.AttributionSource"/></returns>
            public Android.Content.AttributionSource GetCallingAttributionSource()
            {
                return IExecuteWithSignature<Android.Content.AttributionSource>("getCallingAttributionSource", "()Landroid/content/AttributionSource;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#getCallingUid()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetCallingUid()
            {
                return IExecuteWithSignature<int>("getCallingUid", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#beginningOfSpeech()"/>
            /// </summary>
            /// <exception cref="Android.Os.RemoteException"/>
            public void BeginningOfSpeech()
            {
                IExecuteWithSignature("beginningOfSpeech", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#bufferReceived(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void BufferReceived(byte[] arg0)
            {
                IExecuteWithSignature("bufferReceived", "([B)V", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#endOfSegmentedSession()"/>
            /// </summary>
            /// <exception cref="Android.Os.RemoteException"/>
            public void EndOfSegmentedSession()
            {
                IExecuteWithSignature("endOfSegmentedSession", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#endOfSpeech()"/>
            /// </summary>
            /// <exception cref="Android.Os.RemoteException"/>
            public void EndOfSpeech()
            {
                IExecuteWithSignature("endOfSpeech", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#error(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void Error(int arg0)
            {
                IExecuteWithSignature("error", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#languageDetection(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            public void LanguageDetection(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("languageDetection", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#partialResults(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void PartialResults(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("partialResults", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#readyForSpeech(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void ReadyForSpeech(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("readyForSpeech", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#results(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void Results(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("results", "(Landroid/os/Bundle;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#rmsChanged(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void RmsChanged(float arg0)
            {
                IExecuteWithSignature("rmsChanged", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.Callback.html#segmentResults(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <exception cref="Android.Os.RemoteException"/>
            public void SegmentResults(Android.Os.Bundle arg0)
            {
                IExecuteWithSignature("segmentResults", "(Landroid/os/Bundle;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region SupportCallback implementation
        public partial class SupportCallback
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
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.SupportCallback.html#onError(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnError(int arg0)
            {
                IExecuteWithSignature("onError", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/speech/RecognitionService.SupportCallback.html#onSupportResult(android.speech.RecognitionSupport)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Speech.RecognitionSupport"/></param>
            public void OnSupportResult(Android.Speech.RecognitionSupport arg0)
            {
                IExecuteWithSignature("onSupportResult", "(Landroid/speech/RecognitionSupport;)V", arg0);
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