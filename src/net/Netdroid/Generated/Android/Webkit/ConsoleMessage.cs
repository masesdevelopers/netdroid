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
    #region ConsoleMessage declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.html"/>
    /// </summary>
    public partial class ConsoleMessage : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConsoleMessage>
    {
        const string _bridgeClassName = "android.webkit.ConsoleMessage";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConsoleMessage() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConsoleMessage(params object[] args) : base(args) { }
    
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
        #region MessageLevel declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html"/>
        /// </summary>
        public partial class MessageLevel : Java.Lang.Enum<Android.Webkit.ConsoleMessage.MessageLevel>
        {
            const string _bridgeClassName = "android.webkit.ConsoleMessage$MessageLevel";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public MessageLevel() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public MessageLevel(params object[] args) : base(args) { }
        
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

    #region ConsoleMessage implementation
    public partial class ConsoleMessage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.html#%3Cinit%3E(java.lang.String,java.lang.String,int,android.webkit.ConsoleMessage.MessageLevel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Webkit.ConsoleMessage.MessageLevel"/></param>
        public ConsoleMessage(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, Android.Webkit.ConsoleMessage.MessageLevel arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.html#messageLevel()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.ConsoleMessage.MessageLevel"/></returns>
        public Android.Webkit.ConsoleMessage.MessageLevel MessageLevelMethod()
        {
            return IExecuteWithSignature<Android.Webkit.ConsoleMessage.MessageLevel>("messageLevel", "()Landroid/webkit/ConsoleMessage$MessageLevel;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.html#lineNumber()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LineNumber()
        {
            return IExecuteWithSignature<int>("lineNumber", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.html#message()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Message()
        {
            return IExecuteWithSignature<Java.Lang.String>("message", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.html#sourceId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String SourceId()
        {
            return IExecuteWithSignature<Java.Lang.String>("sourceId", "()Ljava/lang/String;");
        }
    
        #endregion
    
        #region Nested classes
        #region MessageLevel implementation
        public partial class MessageLevel
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html#DEBUG"/>
            /// </summary>
            public static Android.Webkit.ConsoleMessage.MessageLevel DEBUG { get { if (!_DEBUGReady) { _DEBUGContent = SGetField<Android.Webkit.ConsoleMessage.MessageLevel>(LocalBridgeClazz, "DEBUG"); _DEBUGReady = true; } return _DEBUGContent; } }
            private static Android.Webkit.ConsoleMessage.MessageLevel _DEBUGContent = default;
            private static bool _DEBUGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html#ERROR"/>
            /// </summary>
            public static Android.Webkit.ConsoleMessage.MessageLevel ERROR { get { if (!_ERRORReady) { _ERRORContent = SGetField<Android.Webkit.ConsoleMessage.MessageLevel>(LocalBridgeClazz, "ERROR"); _ERRORReady = true; } return _ERRORContent; } }
            private static Android.Webkit.ConsoleMessage.MessageLevel _ERRORContent = default;
            private static bool _ERRORReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html#LOG"/>
            /// </summary>
            public static Android.Webkit.ConsoleMessage.MessageLevel LOG { get { if (!_LOGReady) { _LOGContent = SGetField<Android.Webkit.ConsoleMessage.MessageLevel>(LocalBridgeClazz, "LOG"); _LOGReady = true; } return _LOGContent; } }
            private static Android.Webkit.ConsoleMessage.MessageLevel _LOGContent = default;
            private static bool _LOGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html#TIP"/>
            /// </summary>
            public static Android.Webkit.ConsoleMessage.MessageLevel TIP { get { if (!_TIPReady) { _TIPContent = SGetField<Android.Webkit.ConsoleMessage.MessageLevel>(LocalBridgeClazz, "TIP"); _TIPReady = true; } return _TIPContent; } }
            private static Android.Webkit.ConsoleMessage.MessageLevel _TIPContent = default;
            private static bool _TIPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html#WARNING"/>
            /// </summary>
            public static Android.Webkit.ConsoleMessage.MessageLevel WARNING { get { if (!_WARNINGReady) { _WARNINGContent = SGetField<Android.Webkit.ConsoleMessage.MessageLevel>(LocalBridgeClazz, "WARNING"); _WARNINGReady = true; } return _WARNINGContent; } }
            private static Android.Webkit.ConsoleMessage.MessageLevel _WARNINGContent = default;
            private static bool _WARNINGReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Webkit.ConsoleMessage.MessageLevel"/></returns>
            public static Android.Webkit.ConsoleMessage.MessageLevel ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Webkit.ConsoleMessage.MessageLevel>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/webkit/ConsoleMessage$MessageLevel;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/ConsoleMessage.MessageLevel.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Webkit.ConsoleMessage.MessageLevel"/></returns>
            public static Android.Webkit.ConsoleMessage.MessageLevel[] Values()
            {
                return SExecuteWithSignatureArray<Android.Webkit.ConsoleMessage.MessageLevel>(LocalBridgeClazz, "values", "()[Landroid/webkit/ConsoleMessage$MessageLevel;");
            }
        
            #endregion
        
            #region Instance methods
        
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