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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.View.Accessibility
{
    #region AccessibilityManager
    public partial class AccessibilityManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#FLAG_CONTENT_CONTROLS"/>
        /// </summary>
        public static int FLAG_CONTENT_CONTROLS { get { if (!_FLAG_CONTENT_CONTROLSReady) { _FLAG_CONTENT_CONTROLSContent = SGetField<int>(LocalBridgeClazz, "FLAG_CONTENT_CONTROLS"); _FLAG_CONTENT_CONTROLSReady = true; } return _FLAG_CONTENT_CONTROLSContent; } }
        private static int _FLAG_CONTENT_CONTROLSContent = default;
        private static bool _FLAG_CONTENT_CONTROLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#FLAG_CONTENT_ICONS"/>
        /// </summary>
        public static int FLAG_CONTENT_ICONS { get { if (!_FLAG_CONTENT_ICONSReady) { _FLAG_CONTENT_ICONSContent = SGetField<int>(LocalBridgeClazz, "FLAG_CONTENT_ICONS"); _FLAG_CONTENT_ICONSReady = true; } return _FLAG_CONTENT_ICONSContent; } }
        private static int _FLAG_CONTENT_ICONSContent = default;
        private static bool _FLAG_CONTENT_ICONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#FLAG_CONTENT_TEXT"/>
        /// </summary>
        public static int FLAG_CONTENT_TEXT { get { if (!_FLAG_CONTENT_TEXTReady) { _FLAG_CONTENT_TEXTContent = SGetField<int>(LocalBridgeClazz, "FLAG_CONTENT_TEXT"); _FLAG_CONTENT_TEXTReady = true; } return _FLAG_CONTENT_TEXTContent; } }
        private static int _FLAG_CONTENT_TEXTContent = default;
        private static bool _FLAG_CONTENT_TEXTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#isAccessibilityButtonSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAccessibilityButtonSupported()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isAccessibilityButtonSupported", "()Z");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addAccessibilityStateChangeListener(android.view.accessibility.AccessibilityManager.AccessibilityStateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.AccessibilityStateChangeListener"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAccessibilityStateChangeListener(Android.View.Accessibility.AccessibilityManager.AccessibilityStateChangeListener arg0)
        {
            return IExecuteWithSignature<bool>("addAccessibilityStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityStateChangeListener;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addTouchExplorationStateChangeListener(android.view.accessibility.AccessibilityManager.TouchExplorationStateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.TouchExplorationStateChangeListener"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddTouchExplorationStateChangeListener(Android.View.Accessibility.AccessibilityManager.TouchExplorationStateChangeListener arg0)
        {
            return IExecuteWithSignature<bool>("addTouchExplorationStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$TouchExplorationStateChangeListener;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#isAudioDescriptionRequested()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAudioDescriptionRequested()
        {
            return IExecuteWithSignature<bool>("isAudioDescriptionRequested", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#isRequestFromAccessibilityTool()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRequestFromAccessibilityTool()
        {
            return IExecuteWithSignature<bool>("isRequestFromAccessibilityTool", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#isTouchExplorationEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTouchExplorationEnabled()
        {
            return IExecuteWithSignature<bool>("isTouchExplorationEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#removeAccessibilityServicesStateChangeListener(android.view.accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAccessibilityServicesStateChangeListener(Android.View.Accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener arg0)
        {
            return IExecuteWithSignature<bool>("removeAccessibilityServicesStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityServicesStateChangeListener;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#removeAccessibilityStateChangeListener(android.view.accessibility.AccessibilityManager.AccessibilityStateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.AccessibilityStateChangeListener"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAccessibilityStateChangeListener(Android.View.Accessibility.AccessibilityManager.AccessibilityStateChangeListener arg0)
        {
            return IExecuteWithSignature<bool>("removeAccessibilityStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityStateChangeListener;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#removeAudioDescriptionRequestedChangeListener(android.view.accessibility.AccessibilityManager.AudioDescriptionRequestedChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.AudioDescriptionRequestedChangeListener"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAudioDescriptionRequestedChangeListener(Android.View.Accessibility.AccessibilityManager.AudioDescriptionRequestedChangeListener arg0)
        {
            return IExecuteWithSignature<bool>("removeAudioDescriptionRequestedChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AudioDescriptionRequestedChangeListener;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#removeTouchExplorationStateChangeListener(android.view.accessibility.AccessibilityManager.TouchExplorationStateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.TouchExplorationStateChangeListener"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveTouchExplorationStateChangeListener(Android.View.Accessibility.AccessibilityManager.TouchExplorationStateChangeListener arg0)
        {
            return IExecuteWithSignature<bool>("removeTouchExplorationStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$TouchExplorationStateChangeListener;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#getAccessibilityFocusColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAccessibilityFocusColor()
        {
            return IExecuteWithSignature<int>("getAccessibilityFocusColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#getAccessibilityFocusStrokeWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAccessibilityFocusStrokeWidth()
        {
            return IExecuteWithSignature<int>("getAccessibilityFocusStrokeWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#getRecommendedTimeoutMillis(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRecommendedTimeoutMillis(int arg0, int arg1)
        {
            return IExecute<int>("getRecommendedTimeoutMillis", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#getEnabledAccessibilityServiceList(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Accessibilityservice.AccessibilityServiceInfo> GetEnabledAccessibilityServiceList(int arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Accessibilityservice.AccessibilityServiceInfo>>("getEnabledAccessibilityServiceList", "(I)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#getInstalledAccessibilityServiceList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Accessibilityservice.AccessibilityServiceInfo> GetInstalledAccessibilityServiceList()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Accessibilityservice.AccessibilityServiceInfo>>("getInstalledAccessibilityServiceList", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#getAccessibilityServiceList()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Content.Pm.ServiceInfo> GetAccessibilityServiceList()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Content.Pm.ServiceInfo>>("getAccessibilityServiceList", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addAccessibilityRequestPreparer(android.view.accessibility.AccessibilityRequestPreparer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityRequestPreparer"/></param>
        public void AddAccessibilityRequestPreparer(Android.View.Accessibility.AccessibilityRequestPreparer arg0)
        {
            IExecuteWithSignature("addAccessibilityRequestPreparer", "(Landroid/view/accessibility/AccessibilityRequestPreparer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addAccessibilityServicesStateChangeListener(android.view.accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener"/></param>
        public void AddAccessibilityServicesStateChangeListener(Android.View.Accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener arg0)
        {
            IExecuteWithSignature("addAccessibilityServicesStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityServicesStateChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addAccessibilityServicesStateChangeListener(java.util.concurrent.Executor,android.view.accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.View.Accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener"/></param>
        public void AddAccessibilityServicesStateChangeListener(Java.Util.Concurrent.Executor arg0, Android.View.Accessibility.AccessibilityManager.AccessibilityServicesStateChangeListener arg1)
        {
            IExecute("addAccessibilityServicesStateChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addAccessibilityStateChangeListener(android.view.accessibility.AccessibilityManager.AccessibilityStateChangeListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.AccessibilityStateChangeListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void AddAccessibilityStateChangeListener(Android.View.Accessibility.AccessibilityManager.AccessibilityStateChangeListener arg0, Android.Os.Handler arg1)
        {
            IExecute("addAccessibilityStateChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addAudioDescriptionRequestedChangeListener(java.util.concurrent.Executor,android.view.accessibility.AccessibilityManager.AudioDescriptionRequestedChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Android.View.Accessibility.AccessibilityManager.AudioDescriptionRequestedChangeListener"/></param>
        public void AddAudioDescriptionRequestedChangeListener(Java.Util.Concurrent.Executor arg0, Android.View.Accessibility.AccessibilityManager.AudioDescriptionRequestedChangeListener arg1)
        {
            IExecute("addAudioDescriptionRequestedChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#addTouchExplorationStateChangeListener(android.view.accessibility.AccessibilityManager.TouchExplorationStateChangeListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager.TouchExplorationStateChangeListener"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        public void AddTouchExplorationStateChangeListener(Android.View.Accessibility.AccessibilityManager.TouchExplorationStateChangeListener arg0, Android.Os.Handler arg1)
        {
            IExecute("addTouchExplorationStateChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#interrupt()"/>
        /// </summary>
        public void Interrupt()
        {
            IExecuteWithSignature("interrupt", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#removeAccessibilityRequestPreparer(android.view.accessibility.AccessibilityRequestPreparer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityRequestPreparer"/></param>
        public void RemoveAccessibilityRequestPreparer(Android.View.Accessibility.AccessibilityRequestPreparer arg0)
        {
            IExecuteWithSignature("removeAccessibilityRequestPreparer", "(Landroid/view/accessibility/AccessibilityRequestPreparer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.html#sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityEvent"/></param>
        public void SendAccessibilityEvent(Android.View.Accessibility.AccessibilityEvent arg0)
        {
            IExecuteWithSignature("sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region AccessibilityServicesStateChangeListener
        public partial class AccessibilityServicesStateChangeListener
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
            /// Handlers initializer for <see cref="AccessibilityServicesStateChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAccessibilityServicesStateChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.Accessibility.AccessibilityManager>>>(OnAccessibilityServicesStateChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AccessibilityServicesStateChangeListener.html#onAccessibilityServicesStateChanged(android.view.accessibility.AccessibilityManager)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAccessibilityServicesStateChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.View.Accessibility.AccessibilityManager> OnOnAccessibilityServicesStateChanged { get; set; } = null;

            void OnAccessibilityServicesStateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.Accessibility.AccessibilityManager>> data)
            {
                var methodToExecute = (OnOnAccessibilityServicesStateChanged != null) ? OnOnAccessibilityServicesStateChanged : OnAccessibilityServicesStateChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AccessibilityServicesStateChangeListener.html#onAccessibilityServicesStateChanged(android.view.accessibility.AccessibilityManager)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager"/></param>
            public virtual void OnAccessibilityServicesStateChanged(Android.View.Accessibility.AccessibilityManager arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AccessibilityServicesStateChangeListenerDirect
        public partial class AccessibilityServicesStateChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AccessibilityServicesStateChangeListener.html#onAccessibilityServicesStateChanged(android.view.accessibility.AccessibilityManager)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Accessibility.AccessibilityManager"/></param>
            public override void OnAccessibilityServicesStateChanged(Android.View.Accessibility.AccessibilityManager arg0)
            {
                IExecuteWithSignature("onAccessibilityServicesStateChanged", "(Landroid/view/accessibility/AccessibilityManager;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AccessibilityStateChangeListener
        public partial class AccessibilityStateChangeListener
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
            /// Handlers initializer for <see cref="AccessibilityStateChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAccessibilityStateChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnAccessibilityStateChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AccessibilityStateChangeListener.html#onAccessibilityStateChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAccessibilityStateChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnAccessibilityStateChanged { get; set; } = null;

            void OnAccessibilityStateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnAccessibilityStateChanged != null) ? OnOnAccessibilityStateChanged : OnAccessibilityStateChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AccessibilityStateChangeListener.html#onAccessibilityStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public virtual void OnAccessibilityStateChanged(bool arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AccessibilityStateChangeListenerDirect
        public partial class AccessibilityStateChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AccessibilityStateChangeListener.html#onAccessibilityStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public override void OnAccessibilityStateChanged(bool arg0)
            {
                IExecuteWithSignature("onAccessibilityStateChanged", "(Z)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AudioDescriptionRequestedChangeListener
        public partial class AudioDescriptionRequestedChangeListener
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
            /// Handlers initializer for <see cref="AudioDescriptionRequestedChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onAudioDescriptionRequestedChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnAudioDescriptionRequestedChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AudioDescriptionRequestedChangeListener.html#onAudioDescriptionRequestedChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnAudioDescriptionRequestedChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnAudioDescriptionRequestedChanged { get; set; } = null;

            void OnAudioDescriptionRequestedChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnAudioDescriptionRequestedChanged != null) ? OnOnAudioDescriptionRequestedChanged : OnAudioDescriptionRequestedChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AudioDescriptionRequestedChangeListener.html#onAudioDescriptionRequestedChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public virtual void OnAudioDescriptionRequestedChanged(bool arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AudioDescriptionRequestedChangeListenerDirect
        public partial class AudioDescriptionRequestedChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.AudioDescriptionRequestedChangeListener.html#onAudioDescriptionRequestedChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public override void OnAudioDescriptionRequestedChanged(bool arg0)
            {
                IExecuteWithSignature("onAudioDescriptionRequestedChanged", "(Z)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TouchExplorationStateChangeListener
        public partial class TouchExplorationStateChangeListener
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
            /// Handlers initializer for <see cref="TouchExplorationStateChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onTouchExplorationStateChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<bool>>>(OnTouchExplorationStateChangedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.TouchExplorationStateChangeListener.html#onTouchExplorationStateChanged(boolean)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnTouchExplorationStateChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<bool> OnOnTouchExplorationStateChanged { get; set; } = null;

            void OnTouchExplorationStateChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<bool>> data)
            {
                var methodToExecute = (OnOnTouchExplorationStateChanged != null) ? OnOnTouchExplorationStateChanged : OnTouchExplorationStateChanged;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.TouchExplorationStateChangeListener.html#onTouchExplorationStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public virtual void OnTouchExplorationStateChanged(bool arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TouchExplorationStateChangeListenerDirect
        public partial class TouchExplorationStateChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/accessibility/AccessibilityManager.TouchExplorationStateChangeListener.html#onTouchExplorationStateChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public override void OnTouchExplorationStateChanged(bool arg0)
            {
                IExecuteWithSignature("onTouchExplorationStateChanged", "(Z)V", arg0);
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