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
    #region RecognitionListener declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html"/>
    /// </summary>
    public partial class RecognitionListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RecognitionListener() { InitializeHandlers(); }
    
        const string _bridgeClassName = "org.mases.netdroid.generated.android.speech.RecognitionListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
    
    
        // TODO: complete the class
    
    }
    #endregion
    
    #region RecognitionListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="RecognitionListener"/> or its generic type if there is one
    /// </summary>
    public partial class RecognitionListenerDirect : RecognitionListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;
    
        /// <inheritdoc />
        protected override void InitializeHandlers() { }
    
        const string _bridgeClassName = "android.speech.RecognitionListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    }
    #endregion

    #region IRecognitionListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.speech.RecognitionListener implementing <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html"/>
    /// </summary>
    public partial interface IRecognitionListener
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region RecognitionListener implementation
    public partial class RecognitionListener : Android.Speech.IRecognitionListener
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
        /// Handlers initializer for <see cref="RecognitionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onBeginningOfSpeech", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnBeginningOfSpeechEventHandler));
            AddEventHandler("onBufferReceived", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnBufferReceivedEventHandler));
            AddEventHandler("onEndOfSpeech", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnEndOfSpeechEventHandler));
            AddEventHandler("onError", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnErrorEventHandler));
            AddEventHandler("onEvent", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnEventEventHandler));
            AddEventHandler("onPartialResults", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnPartialResultsEventHandler));
            AddEventHandler("onReadyForSpeech", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnReadyForSpeechEventHandler));
            AddEventHandler("onResults", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnResultsEventHandler));
            AddEventHandler("onRmsChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnRmsChangedEventHandler));
            AddEventHandler("onEndOfSegmentedSession", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnEndOfSegmentedSessionEventHandler));
            AddEventHandler("onLanguageDetection", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnLanguageDetectionEventHandler));
            AddEventHandler("onSegmentResults", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSegmentResultsEventHandler));

        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBeginningOfSpeech()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnBeginningOfSpeech"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnBeginningOfSpeech { get; set; } = null;
        
        bool hasOverrideOnBeginningOfSpeech = true;
        void OnBeginningOfSpeechEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnBeginningOfSpeech = true;
            var methodToExecute = (OnOnBeginningOfSpeech != null) ? OnOnBeginningOfSpeech : OnBeginningOfSpeech;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideOnBeginningOfSpeech;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBeginningOfSpeech()"/>
        /// </summary>
        public virtual void OnBeginningOfSpeech()
        {
            hasOverrideOnBeginningOfSpeech = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBufferReceived(byte[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnBufferReceived"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<byte[]> OnOnBufferReceived { get; set; } = null;
        
        bool hasOverrideOnBufferReceived = true;
        void OnBufferReceivedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnBufferReceived = true;
            var methodToExecute = (OnOnBufferReceived != null) ? OnOnBufferReceived : OnBufferReceived;
            methodToExecute.Invoke(data.EventData.GetAt<byte[]>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnBufferReceived;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBufferReceived(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public virtual void OnBufferReceived(byte[] arg0)
        {
            hasOverrideOnBufferReceived = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSpeech()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnEndOfSpeech"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnEndOfSpeech { get; set; } = null;
        
        bool hasOverrideOnEndOfSpeech = true;
        void OnEndOfSpeechEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnEndOfSpeech = true;
            var methodToExecute = (OnOnEndOfSpeech != null) ? OnOnEndOfSpeech : OnEndOfSpeech;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideOnEndOfSpeech;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSpeech()"/>
        /// </summary>
        public virtual void OnEndOfSpeech()
        {
            hasOverrideOnEndOfSpeech = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onError(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnError"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnOnError { get; set; } = null;
        
        bool hasOverrideOnError = true;
        void OnErrorEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnError = true;
            var methodToExecute = (OnOnError != null) ? OnOnError : OnError;
            methodToExecute.Invoke(data.EventData.GetAt<int>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnError;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void OnError(int arg0)
        {
            hasOverrideOnError = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEvent(int,android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnEvent"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, Android.Os.Bundle> OnOnEvent { get; set; } = null;
        
        bool hasOverrideOnEvent = true;
        void OnEventEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnEvent = true;
            var methodToExecute = (OnOnEvent != null) ? OnOnEvent : OnEvent;
            methodToExecute.Invoke(data.EventData.GetAt<int>(0), data.EventData.GetAt<Android.Os.Bundle>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnEvent;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEvent(int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnEvent(int arg0, Android.Os.Bundle arg1)
        {
            hasOverrideOnEvent = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onPartialResults(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnPartialResults"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnPartialResults { get; set; } = null;
        
        bool hasOverrideOnPartialResults = true;
        void OnPartialResultsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnPartialResults = true;
            var methodToExecute = (OnOnPartialResults != null) ? OnOnPartialResults : OnPartialResults;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Os.Bundle>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnPartialResults;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onPartialResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnPartialResults(Android.Os.Bundle arg0)
        {
            hasOverrideOnPartialResults = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onReadyForSpeech(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnReadyForSpeech"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnReadyForSpeech { get; set; } = null;
        
        bool hasOverrideOnReadyForSpeech = true;
        void OnReadyForSpeechEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnReadyForSpeech = true;
            var methodToExecute = (OnOnReadyForSpeech != null) ? OnOnReadyForSpeech : OnReadyForSpeech;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Os.Bundle>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnReadyForSpeech;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onReadyForSpeech(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnReadyForSpeech(Android.Os.Bundle arg0)
        {
            hasOverrideOnReadyForSpeech = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onResults(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnResults"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnResults { get; set; } = null;
        
        bool hasOverrideOnResults = true;
        void OnResultsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnResults = true;
            var methodToExecute = (OnOnResults != null) ? OnOnResults : OnResults;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Os.Bundle>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnResults;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public virtual void OnResults(Android.Os.Bundle arg0)
        {
            hasOverrideOnResults = false;
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onRmsChanged(float)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnRmsChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<float> OnOnRmsChanged { get; set; } = null;
        
        bool hasOverrideOnRmsChanged = true;
        void OnRmsChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnRmsChanged = true;
            var methodToExecute = (OnOnRmsChanged != null) ? OnOnRmsChanged : OnRmsChanged;
            methodToExecute.Invoke(data.EventData.GetAt<float>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnRmsChanged;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onRmsChanged(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public virtual void OnRmsChanged(float arg0)
        {
            hasOverrideOnRmsChanged = false;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnEndOfSegmentedSessionDefault()
        {
            IExecuteWithSignature("onEndOfSegmentedSessionDefault", "()V");
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnEndOfSegmentedSession"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnOnEndOfSegmentedSession { get; set; } = null;
        
        bool hasOverrideOnEndOfSegmentedSession = true;
        void OnEndOfSegmentedSessionEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnEndOfSegmentedSession = true;
            var methodToExecute = (OnOnEndOfSegmentedSession != null) ? OnOnEndOfSegmentedSession : OnEndOfSegmentedSession;
            methodToExecute.Invoke();
            data.EventData.TypedEventData.HasOverride = hasOverrideOnEndOfSegmentedSession;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnEndOfSegmentedSessionDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnEndOfSegmentedSession()
        {
            hasOverrideOnEndOfSegmentedSession = false;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnLanguageDetectionDefault(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onLanguageDetectionDefault", "(Landroid/os/Bundle;)V", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnLanguageDetection"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnLanguageDetection { get; set; } = null;
        
        bool hasOverrideOnLanguageDetection = true;
        void OnLanguageDetectionEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnLanguageDetection = true;
            var methodToExecute = (OnOnLanguageDetection != null) ? OnOnLanguageDetection : OnLanguageDetection;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Os.Bundle>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnLanguageDetection;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnLanguageDetectionDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnLanguageDetection(Android.Os.Bundle arg0)
        {
            hasOverrideOnLanguageDetection = false;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public void OnSegmentResultsDefault(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onSegmentResultsDefault", "(Landroid/os/Bundle;)V", arg0);
        }
        
        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSegmentResults"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Os.Bundle> OnOnSegmentResults { get; set; } = null;
        
        bool hasOverrideOnSegmentResults = true;
        void OnSegmentResultsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideOnSegmentResults = true;
            var methodToExecute = (OnOnSegmentResults != null) ? OnOnSegmentResults : OnSegmentResults;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Os.Bundle>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideOnSegmentResults;
        }
        
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="OnSegmentResultsDefault"/>; override the method to implement a different behavior</remarks>
        public virtual void OnSegmentResults(Android.Os.Bundle arg0)
        {
            hasOverrideOnSegmentResults = false;
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region RecognitionListenerDirect implementation
    public partial class RecognitionListenerDirect : Android.Speech.IRecognitionListener
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
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBeginningOfSpeech()"/>
        /// </summary>
        public override void OnBeginningOfSpeech()
        {
            IExecuteWithSignature("onBeginningOfSpeech", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onBufferReceived(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public override void OnBufferReceived(byte[] arg0)
        {
            IExecuteWithSignature("onBufferReceived", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSpeech()"/>
        /// </summary>
        public override void OnEndOfSpeech()
        {
            IExecuteWithSignature("onEndOfSpeech", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onError(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void OnError(int arg0)
        {
            IExecuteWithSignature("onError", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEvent(int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public override void OnEvent(int arg0, Android.Os.Bundle arg1)
        {
            IExecuteWithSignature("onEvent", "(ILandroid/os/Bundle;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onPartialResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnPartialResults(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onPartialResults", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onReadyForSpeech(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnReadyForSpeech(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onReadyForSpeech", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnResults(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onResults", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onRmsChanged(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public override void OnRmsChanged(float arg0)
        {
            IExecuteWithSignature("onRmsChanged", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onEndOfSegmentedSession()"/>
        /// </summary>
        public override void OnEndOfSegmentedSession()
        {
            IExecuteWithSignature("onEndOfSegmentedSession", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onLanguageDetection(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnLanguageDetection(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onLanguageDetection", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/RecognitionListener.html#onSegmentResults(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public override void OnSegmentResults(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("onSegmentResults", "(Landroid/os/Bundle;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}