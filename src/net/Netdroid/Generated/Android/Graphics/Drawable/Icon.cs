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

namespace Android.Graphics.Drawable
{
    #region Icon declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html"/>
    /// </summary>
    public partial class Icon : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.graphics.drawable.Icon";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Icon() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Icon(params object[] args) : base(args) { }
    
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
        #region OnDrawableLoadedListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.OnDrawableLoadedListener.html"/>
        /// </summary>
        public partial class OnDrawableLoadedListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnDrawableLoadedListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.graphics.drawable.Icon_OnDrawableLoadedListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnDrawableLoadedListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnDrawableLoadedListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnDrawableLoadedListenerDirect : OnDrawableLoadedListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.graphics.drawable.Icon$OnDrawableLoadedListener";
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

    #region Icon implementation
    public partial class Icon
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#TYPE_ADAPTIVE_BITMAP"/>
        /// </summary>
        public static int TYPE_ADAPTIVE_BITMAP { get { if (!_TYPE_ADAPTIVE_BITMAPReady) { _TYPE_ADAPTIVE_BITMAPContent = SGetField<int>(LocalBridgeClazz, "TYPE_ADAPTIVE_BITMAP"); _TYPE_ADAPTIVE_BITMAPReady = true; } return _TYPE_ADAPTIVE_BITMAPContent; } }
        private static int _TYPE_ADAPTIVE_BITMAPContent = default;
        private static bool _TYPE_ADAPTIVE_BITMAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#TYPE_BITMAP"/>
        /// </summary>
        public static int TYPE_BITMAP { get { if (!_TYPE_BITMAPReady) { _TYPE_BITMAPContent = SGetField<int>(LocalBridgeClazz, "TYPE_BITMAP"); _TYPE_BITMAPReady = true; } return _TYPE_BITMAPContent; } }
        private static int _TYPE_BITMAPContent = default;
        private static bool _TYPE_BITMAPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#TYPE_DATA"/>
        /// </summary>
        public static int TYPE_DATA { get { if (!_TYPE_DATAReady) { _TYPE_DATAContent = SGetField<int>(LocalBridgeClazz, "TYPE_DATA"); _TYPE_DATAReady = true; } return _TYPE_DATAContent; } }
        private static int _TYPE_DATAContent = default;
        private static bool _TYPE_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#TYPE_RESOURCE"/>
        /// </summary>
        public static int TYPE_RESOURCE { get { if (!_TYPE_RESOURCEReady) { _TYPE_RESOURCEContent = SGetField<int>(LocalBridgeClazz, "TYPE_RESOURCE"); _TYPE_RESOURCEReady = true; } return _TYPE_RESOURCEContent; } }
        private static int _TYPE_RESOURCEContent = default;
        private static bool _TYPE_RESOURCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#TYPE_URI"/>
        /// </summary>
        public static int TYPE_URI { get { if (!_TYPE_URIReady) { _TYPE_URIContent = SGetField<int>(LocalBridgeClazz, "TYPE_URI"); _TYPE_URIReady = true; } return _TYPE_URIContent; } }
        private static int _TYPE_URIContent = default;
        private static bool _TYPE_URIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#TYPE_URI_ADAPTIVE_BITMAP"/>
        /// </summary>
        public static int TYPE_URI_ADAPTIVE_BITMAP { get { if (!_TYPE_URI_ADAPTIVE_BITMAPReady) { _TYPE_URI_ADAPTIVE_BITMAPContent = SGetField<int>(LocalBridgeClazz, "TYPE_URI_ADAPTIVE_BITMAP"); _TYPE_URI_ADAPTIVE_BITMAPReady = true; } return _TYPE_URI_ADAPTIVE_BITMAPContent; } }
        private static int _TYPE_URI_ADAPTIVE_BITMAPContent = default;
        private static bool _TYPE_URI_ADAPTIVE_BITMAPReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithAdaptiveBitmap(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithAdaptiveBitmap(Android.Graphics.Bitmap arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithAdaptiveBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithAdaptiveBitmapContentUri(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithAdaptiveBitmapContentUri(Android.Net.Uri arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithAdaptiveBitmapContentUri", "(Landroid/net/Uri;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithAdaptiveBitmapContentUri(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithAdaptiveBitmapContentUri(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithAdaptiveBitmapContentUri", "(Ljava/lang/String;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithBitmap(android.graphics.Bitmap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithBitmap(Android.Graphics.Bitmap arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithContentUri(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithContentUri(Android.Net.Uri arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithContentUri", "(Landroid/net/Uri;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithContentUri(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithContentUri(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithContentUri", "(Ljava/lang/String;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithData(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithData(byte[] arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithData", "([BII)Landroid/graphics/drawable/Icon;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithFilePath(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithFilePath(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithFilePath", "(Ljava/lang/String;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithResource(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithResource(Android.Content.Context arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithResource", "(Landroid/content/Context;I)Landroid/graphics/drawable/Icon;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#createWithResource(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public static Android.Graphics.Drawable.Icon CreateWithResource(Java.Lang.String arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Graphics.Drawable.Icon>(LocalBridgeClazz, "createWithResource", "(Ljava/lang/String;I)Landroid/graphics/drawable/Icon;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#loadDrawable(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable LoadDrawable(Android.Content.Context arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("loadDrawable", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#setTint(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon SetTint(int arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("setTint", "(I)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#setTintBlendMode(android.graphics.BlendMode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.BlendMode"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon SetTintBlendMode(Android.Graphics.BlendMode arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("setTintBlendMode", "(Landroid/graphics/BlendMode;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#setTintList(android.content.res.ColorStateList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.ColorStateList"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon SetTintList(Android.Content.Res.ColorStateList arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("setTintList", "(Landroid/content/res/ColorStateList;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#setTintMode(android.graphics.PorterDuff.Mode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.PorterDuff.Mode"/></param>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        public Android.Graphics.Drawable.Icon SetTintMode(Android.Graphics.PorterDuff.Mode arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("setTintMode", "(Landroid/graphics/PorterDuff$Mode;)Landroid/graphics/drawable/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#getUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#getResId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetResId()
        {
            return IExecuteWithSignature<int>("getResId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#getResPackage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetResPackage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getResPackage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#loadDrawableAsync(android.content.Context,android.graphics.drawable.Icon.OnDrawableLoadedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Drawable.Icon.OnDrawableLoadedListener"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        public void LoadDrawableAsync(Android.Content.Context arg0, Android.Graphics.Drawable.Icon.OnDrawableLoadedListener arg1, Android.Os.Handler arg2)
        {
            IExecuteWithSignature("loadDrawableAsync", "(Landroid/content/Context;Landroid/graphics/drawable/Icon$OnDrawableLoadedListener;Landroid/os/Handler;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#loadDrawableAsync(android.content.Context,android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Os.Message"/></param>
        public void LoadDrawableAsync(Android.Content.Context arg0, Android.Os.Message arg1)
        {
            IExecuteWithSignature("loadDrawableAsync", "(Landroid/content/Context;Landroid/os/Message;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region OnDrawableLoadedListener implementation
        public partial class OnDrawableLoadedListener
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
            /// Handlers initializer for <see cref="OnDrawableLoadedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDrawableLoaded", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnDrawableLoadedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.OnDrawableLoadedListener.html#onDrawableLoaded(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDrawableLoaded"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Graphics.Drawable.Drawable> OnOnDrawableLoaded { get; set; } = null;
            
            bool hasOverrideOnDrawableLoaded = true;
            void OnDrawableLoadedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnDrawableLoaded = true;
                var methodToExecute = (OnOnDrawableLoaded != null) ? OnOnDrawableLoaded : OnDrawableLoaded;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Graphics.Drawable.Drawable>(0));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnDrawableLoaded;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.OnDrawableLoadedListener.html#onDrawableLoaded(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            public virtual void OnDrawableLoaded(Android.Graphics.Drawable.Drawable arg0)
            {
                hasOverrideOnDrawableLoaded = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnDrawableLoadedListenerDirect implementation
        public partial class OnDrawableLoadedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/graphics/drawable/Icon.OnDrawableLoadedListener.html#onDrawableLoaded(android.graphics.drawable.Drawable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
            public override void OnDrawableLoaded(Android.Graphics.Drawable.Drawable arg0)
            {
                IExecuteWithSignature("onDrawableLoaded", "(Landroid/graphics/drawable/Drawable;)V", arg0);
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