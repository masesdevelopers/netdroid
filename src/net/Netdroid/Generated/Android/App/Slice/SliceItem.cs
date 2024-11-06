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

namespace Android.App.Slice
{
    #region SliceItem declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class SliceItem : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.slice.SliceItem";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SliceItem() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SliceItem(params object[] args) : base(args) { }
    
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

    #region SliceItem implementation
    public partial class SliceItem
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#CREATOR"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_ACTION"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_ACTION { get { if (!_FORMAT_ACTIONReady) { _FORMAT_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_ACTION"); _FORMAT_ACTIONReady = true; } return _FORMAT_ACTIONContent; } }
        private static Java.Lang.String _FORMAT_ACTIONContent = default;
        private static bool _FORMAT_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_BUNDLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_BUNDLE { get { if (!_FORMAT_BUNDLEReady) { _FORMAT_BUNDLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_BUNDLE"); _FORMAT_BUNDLEReady = true; } return _FORMAT_BUNDLEContent; } }
        private static Java.Lang.String _FORMAT_BUNDLEContent = default;
        private static bool _FORMAT_BUNDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_IMAGE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_IMAGE { get { if (!_FORMAT_IMAGEReady) { _FORMAT_IMAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_IMAGE"); _FORMAT_IMAGEReady = true; } return _FORMAT_IMAGEContent; } }
        private static Java.Lang.String _FORMAT_IMAGEContent = default;
        private static bool _FORMAT_IMAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_INT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_INT { get { if (!_FORMAT_INTReady) { _FORMAT_INTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_INT"); _FORMAT_INTReady = true; } return _FORMAT_INTContent; } }
        private static Java.Lang.String _FORMAT_INTContent = default;
        private static bool _FORMAT_INTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_LONG"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_LONG { get { if (!_FORMAT_LONGReady) { _FORMAT_LONGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_LONG"); _FORMAT_LONGReady = true; } return _FORMAT_LONGContent; } }
        private static Java.Lang.String _FORMAT_LONGContent = default;
        private static bool _FORMAT_LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_REMOTE_INPUT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_REMOTE_INPUT { get { if (!_FORMAT_REMOTE_INPUTReady) { _FORMAT_REMOTE_INPUTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_REMOTE_INPUT"); _FORMAT_REMOTE_INPUTReady = true; } return _FORMAT_REMOTE_INPUTContent; } }
        private static Java.Lang.String _FORMAT_REMOTE_INPUTContent = default;
        private static bool _FORMAT_REMOTE_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_SLICE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_SLICE { get { if (!_FORMAT_SLICEReady) { _FORMAT_SLICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_SLICE"); _FORMAT_SLICEReady = true; } return _FORMAT_SLICEContent; } }
        private static Java.Lang.String _FORMAT_SLICEContent = default;
        private static bool _FORMAT_SLICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_TEXT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String FORMAT_TEXT { get { if (!_FORMAT_TEXTReady) { _FORMAT_TEXTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_TEXT"); _FORMAT_TEXTReady = true; } return _FORMAT_TEXTContent; } }
        private static Java.Lang.String _FORMAT_TEXTContent = default;
        private static bool _FORMAT_TEXTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getAction()"/>
        /// </summary>
        /// <returns><see cref="Android.App.PendingIntent"/></returns>
        [global::System.Obsolete()]
        public Android.App.PendingIntent GetAction()
        {
            return IExecuteWithSignature<Android.App.PendingIntent>("getAction", "()Landroid/app/PendingIntent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getRemoteInput()"/>
        /// </summary>
        /// <returns><see cref="Android.App.RemoteInput"/></returns>
        [global::System.Obsolete()]
        public Android.App.RemoteInput GetRemoteInput()
        {
            return IExecuteWithSignature<Android.App.RemoteInput>("getRemoteInput", "()Landroid/app/RemoteInput;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getSlice()"/>
        /// </summary>
        /// <returns><see cref="Android.App.Slice.Slice"/></returns>
        [global::System.Obsolete()]
        public Android.App.Slice.Slice GetSlice()
        {
            return IExecuteWithSignature<Android.App.Slice.Slice>("getSlice", "()Landroid/app/slice/Slice;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getIcon()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Icon"/></returns>
        [global::System.Obsolete()]
        public Android.Graphics.Drawable.Icon GetIcon()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getIcon", "()Landroid/graphics/drawable/Icon;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getBundle()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        [global::System.Obsolete()]
        public Android.Os.Bundle GetBundle()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getBundle", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#hasHint(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool HasHint(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("hasHint", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetInt()
        {
            return IExecuteWithSignature<int>("getInt", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence GetText()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getText", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getFormat()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetFormat()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getSubType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetSubType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSubType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getHints()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Java.Lang.String> GetHints()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getHints", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        [global::System.Obsolete()]
        public long GetLong()
        {
            return IExecuteWithSignature<long>("getLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}