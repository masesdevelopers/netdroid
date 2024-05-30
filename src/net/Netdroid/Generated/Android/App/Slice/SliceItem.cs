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

namespace Android.App.Slice
{
    #region SliceItem
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
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_ACTION"/>
        /// </summary>
        public static Java.Lang.String FORMAT_ACTION { get { if (!_FORMAT_ACTIONReady) { _FORMAT_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_ACTION"); _FORMAT_ACTIONReady = true; } return _FORMAT_ACTIONContent; } }
        private static Java.Lang.String _FORMAT_ACTIONContent = default;
        private static bool _FORMAT_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_BUNDLE"/>
        /// </summary>
        public static Java.Lang.String FORMAT_BUNDLE { get { if (!_FORMAT_BUNDLEReady) { _FORMAT_BUNDLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_BUNDLE"); _FORMAT_BUNDLEReady = true; } return _FORMAT_BUNDLEContent; } }
        private static Java.Lang.String _FORMAT_BUNDLEContent = default;
        private static bool _FORMAT_BUNDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_IMAGE"/>
        /// </summary>
        public static Java.Lang.String FORMAT_IMAGE { get { if (!_FORMAT_IMAGEReady) { _FORMAT_IMAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_IMAGE"); _FORMAT_IMAGEReady = true; } return _FORMAT_IMAGEContent; } }
        private static Java.Lang.String _FORMAT_IMAGEContent = default;
        private static bool _FORMAT_IMAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_INT"/>
        /// </summary>
        public static Java.Lang.String FORMAT_INT { get { if (!_FORMAT_INTReady) { _FORMAT_INTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_INT"); _FORMAT_INTReady = true; } return _FORMAT_INTContent; } }
        private static Java.Lang.String _FORMAT_INTContent = default;
        private static bool _FORMAT_INTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_LONG"/>
        /// </summary>
        public static Java.Lang.String FORMAT_LONG { get { if (!_FORMAT_LONGReady) { _FORMAT_LONGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_LONG"); _FORMAT_LONGReady = true; } return _FORMAT_LONGContent; } }
        private static Java.Lang.String _FORMAT_LONGContent = default;
        private static bool _FORMAT_LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_REMOTE_INPUT"/>
        /// </summary>
        public static Java.Lang.String FORMAT_REMOTE_INPUT { get { if (!_FORMAT_REMOTE_INPUTReady) { _FORMAT_REMOTE_INPUTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_REMOTE_INPUT"); _FORMAT_REMOTE_INPUTReady = true; } return _FORMAT_REMOTE_INPUTContent; } }
        private static Java.Lang.String _FORMAT_REMOTE_INPUTContent = default;
        private static bool _FORMAT_REMOTE_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_SLICE"/>
        /// </summary>
        public static Java.Lang.String FORMAT_SLICE { get { if (!_FORMAT_SLICEReady) { _FORMAT_SLICEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FORMAT_SLICE"); _FORMAT_SLICEReady = true; } return _FORMAT_SLICEContent; } }
        private static Java.Lang.String _FORMAT_SLICEContent = default;
        private static bool _FORMAT_SLICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#FORMAT_TEXT"/>
        /// </summary>
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
        public Android.App.PendingIntent Action
        {
            get { return IExecuteWithSignature<Android.App.PendingIntent>("getAction", "()Landroid/app/PendingIntent;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getBundle()"/> 
        /// </summary>
        public Android.Os.Bundle Bundle
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getBundle", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getFormat()"/> 
        /// </summary>
        public Java.Lang.String Format
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFormat", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getHints()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> Hints
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getHints", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getIcon()"/> 
        /// </summary>
        public Android.Graphics.Drawable.Icon Icon
        {
            get { return IExecuteWithSignature<Android.Graphics.Drawable.Icon>("getIcon", "()Landroid/graphics/drawable/Icon;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getInt()"/> 
        /// </summary>
        public int Int
        {
            get { return IExecuteWithSignature<int>("getInt", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getLong()"/> 
        /// </summary>
        public long Long
        {
            get { return IExecuteWithSignature<long>("getLong", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getRemoteInput()"/> 
        /// </summary>
        public Android.App.RemoteInput RemoteInput
        {
            get { return IExecuteWithSignature<Android.App.RemoteInput>("getRemoteInput", "()Landroid/app/RemoteInput;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getSlice()"/> 
        /// </summary>
        public Android.App.Slice.Slice Slice
        {
            get { return IExecuteWithSignature<Android.App.Slice.Slice>("getSlice", "()Landroid/app/slice/Slice;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getSubType()"/> 
        /// </summary>
        public Java.Lang.String SubType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSubType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#getText()"/> 
        /// </summary>
        public Java.Lang.CharSequence Text
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getText", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#hasHint(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasHint(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("hasHint", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/slice/SliceItem.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}