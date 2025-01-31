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

namespace Android.View.Accessibility
{
    #region CaptioningManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html"/>
    /// </summary>
    public partial class CaptioningManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CaptioningManager>
    {
        const string _bridgeClassName = "android.view.accessibility.CaptioningManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CaptioningManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CaptioningManager(params object[] args) : base(args) { }
    
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
        #region CaptioningChangeListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptioningChangeListener.html"/>
        /// </summary>
        public partial class CaptioningChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CaptioningChangeListener>
        {
            const string _bridgeClassName = "android.view.accessibility.CaptioningManager$CaptioningChangeListener";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("CaptioningChangeListener class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CaptioningChangeListener() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("CaptioningChangeListener class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CaptioningChangeListener(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region CaptionStyle declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html"/>
        /// </summary>
        public partial class CaptionStyle : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CaptionStyle>
        {
            const string _bridgeClassName = "android.view.accessibility.CaptioningManager$CaptionStyle";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CaptionStyle() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CaptionStyle(params object[] args) : base(args) { }
        
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

    #region CaptioningManager implementation
    public partial class CaptioningManager
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
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#getUserStyle()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Accessibility.CaptioningManager.CaptionStyle"/></returns>
        public Android.View.Accessibility.CaptioningManager.CaptionStyle GetUserStyle()
        {
            return IExecuteWithSignature<Android.View.Accessibility.CaptioningManager.CaptionStyle>("getUserStyle", "()Landroid/view/accessibility/CaptioningManager$CaptionStyle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#isCallCaptioningEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCallCaptioningEnabled()
        {
            return IExecuteWithSignature<bool>("isCallCaptioningEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#isSystemAudioCaptioningEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSystemAudioCaptioningEnabled()
        {
            return IExecuteWithSignature<bool>("isSystemAudioCaptioningEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#isSystemAudioCaptioningUiEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSystemAudioCaptioningUiEnabled()
        {
            return IExecuteWithSignature<bool>("isSystemAudioCaptioningUiEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#getFontScale()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetFontScale()
        {
            return IExecuteWithSignature<float>("getFontScale", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public Java.Util.Locale GetLocale()
        {
            return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#addCaptioningChangeListener(android.view.accessibility.CaptioningManager.CaptioningChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.CaptioningManager.CaptioningChangeListener"/></param>
        public void AddCaptioningChangeListener(Android.View.Accessibility.CaptioningManager.CaptioningChangeListener arg0)
        {
            IExecuteWithSignature("addCaptioningChangeListener", "(Landroid/view/accessibility/CaptioningManager$CaptioningChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.html#removeCaptioningChangeListener(android.view.accessibility.CaptioningManager.CaptioningChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Accessibility.CaptioningManager.CaptioningChangeListener"/></param>
        public void RemoveCaptioningChangeListener(Android.View.Accessibility.CaptioningManager.CaptioningChangeListener arg0)
        {
            IExecuteWithSignature("removeCaptioningChangeListener", "(Landroid/view/accessibility/CaptioningManager$CaptioningChangeListener;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region CaptioningChangeListener implementation
        public partial class CaptioningChangeListener
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
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptioningChangeListener.html#onEnabledChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void OnEnabledChanged(bool arg0)
            {
                IExecuteWithSignature("onEnabledChanged", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptioningChangeListener.html#onFontScaleChanged(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void OnFontScaleChanged(float arg0)
            {
                IExecuteWithSignature("onFontScaleChanged", "(F)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptioningChangeListener.html#onLocaleChanged(java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
            public void OnLocaleChanged(Java.Util.Locale arg0)
            {
                IExecuteWithSignature("onLocaleChanged", "(Ljava/util/Locale;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptioningChangeListener.html#onSystemAudioCaptioningChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void OnSystemAudioCaptioningChanged(bool arg0)
            {
                IExecuteWithSignature("onSystemAudioCaptioningChanged", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptioningChangeListener.html#onSystemAudioCaptioningUiChanged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public void OnSystemAudioCaptioningUiChanged(bool arg0)
            {
                IExecuteWithSignature("onSystemAudioCaptioningUiChanged", "(Z)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptioningChangeListener.html#onUserStyleChanged(android.view.accessibility.CaptioningManager.CaptionStyle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Accessibility.CaptioningManager.CaptionStyle"/></param>
            public void OnUserStyleChanged(Android.View.Accessibility.CaptioningManager.CaptionStyle arg0)
            {
                IExecuteWithSignature("onUserStyleChanged", "(Landroid/view/accessibility/CaptioningManager$CaptionStyle;)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region CaptionStyle implementation
        public partial class CaptionStyle
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#backgroundColor"/>
            /// </summary>
            public int backgroundColor { get { if (!_backgroundColorReady) { _backgroundColorContent = IGetField<int>("backgroundColor"); _backgroundColorReady = true; } return _backgroundColorContent; } }
            private int _backgroundColorContent = default;
            private bool _backgroundColorReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#edgeColor"/>
            /// </summary>
            public int edgeColor { get { if (!_edgeColorReady) { _edgeColorContent = IGetField<int>("edgeColor"); _edgeColorReady = true; } return _edgeColorContent; } }
            private int _edgeColorContent = default;
            private bool _edgeColorReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#edgeType"/>
            /// </summary>
            public int edgeType { get { if (!_edgeTypeReady) { _edgeTypeContent = IGetField<int>("edgeType"); _edgeTypeReady = true; } return _edgeTypeContent; } }
            private int _edgeTypeContent = default;
            private bool _edgeTypeReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#foregroundColor"/>
            /// </summary>
            public int foregroundColor { get { if (!_foregroundColorReady) { _foregroundColorContent = IGetField<int>("foregroundColor"); _foregroundColorReady = true; } return _foregroundColorContent; } }
            private int _foregroundColorContent = default;
            private bool _foregroundColorReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#windowColor"/>
            /// </summary>
            public int windowColor { get { if (!_windowColorReady) { _windowColorContent = IGetField<int>("windowColor"); _windowColorReady = true; } return _windowColorContent; } }
            private int _windowColorContent = default;
            private bool _windowColorReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#EDGE_TYPE_DEPRESSED"/>
            /// </summary>
            public static int EDGE_TYPE_DEPRESSED { get { if (!_EDGE_TYPE_DEPRESSEDReady) { _EDGE_TYPE_DEPRESSEDContent = SGetField<int>(LocalBridgeClazz, "EDGE_TYPE_DEPRESSED"); _EDGE_TYPE_DEPRESSEDReady = true; } return _EDGE_TYPE_DEPRESSEDContent; } }
            private static int _EDGE_TYPE_DEPRESSEDContent = default;
            private static bool _EDGE_TYPE_DEPRESSEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#EDGE_TYPE_DROP_SHADOW"/>
            /// </summary>
            public static int EDGE_TYPE_DROP_SHADOW { get { if (!_EDGE_TYPE_DROP_SHADOWReady) { _EDGE_TYPE_DROP_SHADOWContent = SGetField<int>(LocalBridgeClazz, "EDGE_TYPE_DROP_SHADOW"); _EDGE_TYPE_DROP_SHADOWReady = true; } return _EDGE_TYPE_DROP_SHADOWContent; } }
            private static int _EDGE_TYPE_DROP_SHADOWContent = default;
            private static bool _EDGE_TYPE_DROP_SHADOWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#EDGE_TYPE_NONE"/>
            /// </summary>
            public static int EDGE_TYPE_NONE { get { if (!_EDGE_TYPE_NONEReady) { _EDGE_TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "EDGE_TYPE_NONE"); _EDGE_TYPE_NONEReady = true; } return _EDGE_TYPE_NONEContent; } }
            private static int _EDGE_TYPE_NONEContent = default;
            private static bool _EDGE_TYPE_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#EDGE_TYPE_OUTLINE"/>
            /// </summary>
            public static int EDGE_TYPE_OUTLINE { get { if (!_EDGE_TYPE_OUTLINEReady) { _EDGE_TYPE_OUTLINEContent = SGetField<int>(LocalBridgeClazz, "EDGE_TYPE_OUTLINE"); _EDGE_TYPE_OUTLINEReady = true; } return _EDGE_TYPE_OUTLINEContent; } }
            private static int _EDGE_TYPE_OUTLINEContent = default;
            private static bool _EDGE_TYPE_OUTLINEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#EDGE_TYPE_RAISED"/>
            /// </summary>
            public static int EDGE_TYPE_RAISED { get { if (!_EDGE_TYPE_RAISEDReady) { _EDGE_TYPE_RAISEDContent = SGetField<int>(LocalBridgeClazz, "EDGE_TYPE_RAISED"); _EDGE_TYPE_RAISEDReady = true; } return _EDGE_TYPE_RAISEDContent; } }
            private static int _EDGE_TYPE_RAISEDContent = default;
            private static bool _EDGE_TYPE_RAISEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#EDGE_TYPE_UNSPECIFIED"/>
            /// </summary>
            public static int EDGE_TYPE_UNSPECIFIED { get { if (!_EDGE_TYPE_UNSPECIFIEDReady) { _EDGE_TYPE_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "EDGE_TYPE_UNSPECIFIED"); _EDGE_TYPE_UNSPECIFIEDReady = true; } return _EDGE_TYPE_UNSPECIFIEDContent; } }
            private static int _EDGE_TYPE_UNSPECIFIEDContent = default;
            private static bool _EDGE_TYPE_UNSPECIFIEDReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#getTypeface()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Typeface"/></returns>
            public Android.Graphics.Typeface GetTypeface()
            {
                return IExecuteWithSignature<Android.Graphics.Typeface>("getTypeface", "()Landroid/graphics/Typeface;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#hasBackgroundColor()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasBackgroundColor()
            {
                return IExecuteWithSignature<bool>("hasBackgroundColor", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#hasEdgeColor()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasEdgeColor()
            {
                return IExecuteWithSignature<bool>("hasEdgeColor", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#hasEdgeType()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasEdgeType()
            {
                return IExecuteWithSignature<bool>("hasEdgeType", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#hasForegroundColor()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasForegroundColor()
            {
                return IExecuteWithSignature<bool>("hasForegroundColor", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/accessibility/CaptioningManager.CaptionStyle.html#hasWindowColor()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasWindowColor()
            {
                return IExecuteWithSignature<bool>("hasWindowColor", "()Z");
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