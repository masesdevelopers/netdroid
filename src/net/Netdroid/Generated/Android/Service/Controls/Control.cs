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

namespace Android.Service.Controls
{
    #region Control declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/controls/Control.html"/>
    /// </summary>
    public partial class Control : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.service.controls.Control";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Control() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Control(params object[] args) : base(args) { }
    
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
        #region StatefulBuilder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html"/>
        /// </summary>
        public partial class StatefulBuilder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StatefulBuilder>
        {
            const string _bridgeClassName = "android.service.controls.Control$StatefulBuilder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public StatefulBuilder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public StatefulBuilder(params object[] args) : base(args) { }
        
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

        #region StatelessBuilder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html"/>
        /// </summary>
        public partial class StatelessBuilder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StatelessBuilder>
        {
            const string _bridgeClassName = "android.service.controls.Control$StatelessBuilder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public StatelessBuilder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public StatelessBuilder(params object[] args) : base(args) { }
        
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

    #region Control implementation
    public partial class Control
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#STATUS_DISABLED"/>
        /// </summary>
        public static int STATUS_DISABLED { get { if (!_STATUS_DISABLEDReady) { _STATUS_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "STATUS_DISABLED"); _STATUS_DISABLEDReady = true; } return _STATUS_DISABLEDContent; } }
        private static int _STATUS_DISABLEDContent = default;
        private static bool _STATUS_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#STATUS_ERROR"/>
        /// </summary>
        public static int STATUS_ERROR { get { if (!_STATUS_ERRORReady) { _STATUS_ERRORContent = SGetField<int>(LocalBridgeClazz, "STATUS_ERROR"); _STATUS_ERRORReady = true; } return _STATUS_ERRORContent; } }
        private static int _STATUS_ERRORContent = default;
        private static bool _STATUS_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#STATUS_NOT_FOUND"/>
        /// </summary>
        public static int STATUS_NOT_FOUND { get { if (!_STATUS_NOT_FOUNDReady) { _STATUS_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_FOUND"); _STATUS_NOT_FOUNDReady = true; } return _STATUS_NOT_FOUNDContent; } }
        private static int _STATUS_NOT_FOUNDContent = default;
        private static bool _STATUS_NOT_FOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#STATUS_OK"/>
        /// </summary>
        public static int STATUS_OK { get { if (!_STATUS_OKReady) { _STATUS_OKContent = SGetField<int>(LocalBridgeClazz, "STATUS_OK"); _STATUS_OKReady = true; } return _STATUS_OKContent; } }
        private static int _STATUS_OKContent = default;
        private static bool _STATUS_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#STATUS_UNKNOWN"/>
        /// </summary>
        public static int STATUS_UNKNOWN { get { if (!_STATUS_UNKNOWNReady) { _STATUS_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNKNOWN"); _STATUS_UNKNOWNReady = true; } return _STATUS_UNKNOWNContent; } }
        private static int _STATUS_UNKNOWNContent = default;
        private static bool _STATUS_UNKNOWNReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getAppIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        public Android.App.PendingIntent GetAppIntent()
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("getAppIntent", "()Landroid/app/PendingIntent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getCustomColor()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.ColorStateList"/></returns>
        public Android.Content.Res.ColorStateList GetCustomColor()
        {
            return IExecuteWithSignature<Android.Content.Res.ColorStateList>("getCustomColor", "()Landroid/content/res/ColorStateList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getCustomIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon GetCustomIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getCustomIcon", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getControlTemplate()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Controls.Templates.ControlTemplate"/></returns>
        public Android.Service.Controls.Templates.ControlTemplate GetControlTemplate()
        {
            return IExecuteWithSignature<Android.Service.Controls.Templates.ControlTemplate>("getControlTemplate", "()Landroid/service/controls/templates/ControlTemplate;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#isAuthRequired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAuthRequired()
        {
            return IExecuteWithSignature<bool>("isAuthRequired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getDeviceType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDeviceType()
        {
            return IExecuteWithSignature<int>("getDeviceType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatus()
        {
            return IExecuteWithSignature<int>("getStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getStatusText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetStatusText()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getStatusText", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getStructure()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetStructure()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getStructure", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getSubtitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetSubtitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getSubtitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetTitle()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getTitle", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getZone()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetZone()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getZone", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#getControlId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetControlId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getControlId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/controls/Control.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region StatefulBuilder implementation
        public partial class StatefulBuilder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#%3Cinit%3E(android.service.controls.Control)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Controls.Control"/></param>
            public StatefulBuilder(Android.Service.Controls.Control arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#%3Cinit%3E(java.lang.String,android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
            public StatefulBuilder(Java.Lang.String arg0, Android.App.PendingIntent arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Controls.Control"/></returns>
            public Android.Service.Controls.Control Build()
            {
                return IExecuteWithSignature<Android.Service.Controls.Control>("build", "()Landroid/service/controls/Control;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setAppIntent(android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetAppIntent(Android.App.PendingIntent arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setAppIntent", "(Landroid/app/PendingIntent;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setAuthRequired(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetAuthRequired(bool arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setAuthRequired", "(Z)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setControlId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetControlId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setControlId", "(Ljava/lang/String;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setControlTemplate(android.service.controls.templates.ControlTemplate)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Controls.Templates.ControlTemplate"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetControlTemplate(Android.Service.Controls.Templates.ControlTemplate arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setControlTemplate", "(Landroid/service/controls/templates/ControlTemplate;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setCustomColor(android.content.res.ColorStateList)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetCustomColor(Android.Content.Res.ColorStateList arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setCustomColor", "(Landroid/content/res/ColorStateList;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setCustomIcon(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetCustomIcon(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setCustomIcon", "(Landroid/graphics/drawable/Icon;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setDeviceType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetDeviceType(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setDeviceType", "(I)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setStatus(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetStatus(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setStatus", "(I)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setStatusText(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetStatusText(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setStatusText", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setStructure(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetStructure(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setStructure", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setSubtitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetSubtitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setSubtitle", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setTitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetTitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setTitle", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatefulBuilder.html#setZone(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatefulBuilder"/></returns>
            public Android.Service.Controls.Control.StatefulBuilder SetZone(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatefulBuilder>("setZone", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatefulBuilder;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region StatelessBuilder implementation
        public partial class StatelessBuilder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#%3Cinit%3E(android.service.controls.Control)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Controls.Control"/></param>
            public StatelessBuilder(Android.Service.Controls.Control arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#%3Cinit%3E(java.lang.String,android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.App.PendingIntent"/></param>
            public StatelessBuilder(Java.Lang.String arg0, Android.App.PendingIntent arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Controls.Control"/></returns>
            public Android.Service.Controls.Control Build()
            {
                return IExecuteWithSignature<Android.Service.Controls.Control>("build", "()Landroid/service/controls/Control;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setAppIntent(android.app.PendingIntent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.PendingIntent"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetAppIntent(Android.App.PendingIntent arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setAppIntent", "(Landroid/app/PendingIntent;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setControlId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetControlId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setControlId", "(Ljava/lang/String;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setCustomColor(android.content.res.ColorStateList)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetCustomColor(Android.Content.Res.ColorStateList arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setCustomColor", "(Landroid/content/res/ColorStateList;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setCustomIcon(android.graphics.drawable.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Icon"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetCustomIcon(Android.Graphics.Drawable.Icon arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setCustomIcon", "(Landroid/graphics/drawable/Icon;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setDeviceType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetDeviceType(int arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setDeviceType", "(I)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setStructure(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetStructure(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setStructure", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setSubtitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetSubtitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setSubtitle", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setTitle(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetTitle(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setTitle", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/controls/Control.StatelessBuilder.html#setZone(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Service.Controls.Control.StatelessBuilder"/></returns>
            public Android.Service.Controls.Control.StatelessBuilder SetZone(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Service.Controls.Control.StatelessBuilder>("setZone", "(Ljava/lang/CharSequence;)Landroid/service/controls/Control$StatelessBuilder;", arg0);
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