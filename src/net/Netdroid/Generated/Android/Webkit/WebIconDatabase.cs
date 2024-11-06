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
    #region WebIconDatabase declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class WebIconDatabase : MASES.JCOBridge.C2JBridge.JVMBridgeBase<WebIconDatabase>
    {
        const string _bridgeClassName = "android.webkit.WebIconDatabase";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("WebIconDatabase class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WebIconDatabase() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("WebIconDatabase class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WebIconDatabase(params object[] args) : base(args) { }
    
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
        #region IconListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.IconListener.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class IconListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public IconListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.webkit.WebIconDatabase_IconListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region IconListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="IconListener"/> or its generic type if there is one
        /// </summary>
        public partial class IconListenerDirect : IconListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.webkit.WebIconDatabase$IconListener";
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
            public override bool IsBridgeStatic => true;
        }
        #endregion

    
    }
    #endregion

    #region WebIconDatabase implementation
    public partial class WebIconDatabase
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Webkit.WebIconDatabase"/></returns>
        [global::System.Obsolete()]
        public static Android.Webkit.WebIconDatabase GetInstance()
        {
            return SExecuteWithSignature<Android.Webkit.WebIconDatabase>(LocalBridgeClazz, "getInstance", "()Landroid/webkit/WebIconDatabase;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#close()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#open(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Open(Java.Lang.String arg0)
        {
            IExecuteWithSignature("open", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#releaseIconForPageUrl(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void ReleaseIconForPageUrl(Java.Lang.String arg0)
        {
            IExecuteWithSignature("releaseIconForPageUrl", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#removeAllIcons()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void RemoveAllIcons()
        {
            IExecuteWithSignature("removeAllIcons", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#requestIconForPageUrl(java.lang.String,android.webkit.WebIconDatabase.IconListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Webkit.WebIconDatabase.IconListener"/></param>
        [global::System.Obsolete()]
        public void RequestIconForPageUrl(Java.Lang.String arg0, Android.Webkit.WebIconDatabase.IconListener arg1)
        {
            IExecuteWithSignature("requestIconForPageUrl", "(Ljava/lang/String;Landroid/webkit/WebIconDatabase$IconListener;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.html#retainIconForPageUrl(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void RetainIconForPageUrl(Java.Lang.String arg0)
        {
            IExecuteWithSignature("retainIconForPageUrl", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region IconListener implementation
        public partial class IconListener
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
            /// Handlers initializer for <see cref="IconListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onReceivedIcon", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnReceivedIconEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.IconListener.html#onReceivedIcon(java.lang.String,android.graphics.Bitmap)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnReceivedIcon"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Java.Lang.String, Android.Graphics.Bitmap> OnOnReceivedIcon { get; set; } = null;
            
            bool hasOverrideOnReceivedIcon = true;
            void OnReceivedIconEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnReceivedIcon = true;
                var methodToExecute = (OnOnReceivedIcon != null) ? OnOnReceivedIcon : OnReceivedIcon;
                methodToExecute.Invoke(data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Android.Graphics.Bitmap>(1));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnReceivedIcon;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.IconListener.html#onReceivedIcon(java.lang.String,android.graphics.Bitmap)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
            [global::System.Obsolete()]
            public virtual void OnReceivedIcon(Java.Lang.String arg0, Android.Graphics.Bitmap arg1)
            {
                hasOverrideOnReceivedIcon = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region IconListenerDirect implementation
        public partial class IconListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/webkit/WebIconDatabase.IconListener.html#onReceivedIcon(java.lang.String,android.graphics.Bitmap)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
            [global::System.Obsolete()]
            public override void OnReceivedIcon(Java.Lang.String arg0, Android.Graphics.Bitmap arg1)
            {
                IExecuteWithSignature("onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", arg0, arg1);
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