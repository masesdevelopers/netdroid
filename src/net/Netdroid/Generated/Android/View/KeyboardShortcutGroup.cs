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

namespace Android.View
{
    #region KeyboardShortcutGroup declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html"/>
    /// </summary>
    public partial class KeyboardShortcutGroup : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.KeyboardShortcutGroup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KeyboardShortcutGroup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public KeyboardShortcutGroup(params object[] args) : base(args) { }
    
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

    #region KeyboardShortcutGroup implementation
    public partial class KeyboardShortcutGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#%3Cinit%3E(java.lang.CharSequence,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        public KeyboardShortcutGroup(Java.Lang.CharSequence arg0, Java.Util.List<Android.View.KeyboardShortcutInfo> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#%3Cinit%3E(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public KeyboardShortcutGroup(Java.Lang.CharSequence arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#getLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#getItems()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.KeyboardShortcutInfo> GetItems()
        {
            return IExecuteWithSignature<Java.Util.List<Android.View.KeyboardShortcutInfo>>("getItems", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#addItem(android.view.KeyboardShortcutInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.KeyboardShortcutInfo"/></param>
        public void AddItem(Android.View.KeyboardShortcutInfo arg0)
        {
            IExecuteWithSignature("addItem", "(Landroid/view/KeyboardShortcutInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/KeyboardShortcutGroup.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
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