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

namespace Android.Content
{
    #region ComponentName declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/ComponentName.html"/>
    /// </summary>
    public partial class ComponentName : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ComponentName>
    {
        const string _bridgeClassName = "android.content.ComponentName";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ComponentName() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ComponentName(params object[] args) : base(args) { }
    
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

    #region ComponentName implementation
    public partial class ComponentName : Android.Os.IParcelable, Java.Lang.ICloneable, Java.Lang.IComparable<Android.Content.ComponentName>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#%3Cinit%3E(android.content.Context,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public ComponentName(Android.Content.Context arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#%3Cinit%3E(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ComponentName(Android.Content.Context arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#%3Cinit%3E(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public ComponentName(Android.Os.Parcel arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ComponentName(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.ComponentName"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Content.ComponentName t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Content.ComponentName"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Content.ComponentName t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Content.ComponentName"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Android.Content.ComponentName t) => t.Cast<Java.Lang.Comparable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#createRelative(android.content.Context,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public static Android.Content.ComponentName CreateRelative(Android.Content.Context arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Android.Content.ComponentName>(LocalBridgeClazz, "createRelative", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/ComponentName;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#createRelative(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public static Android.Content.ComponentName CreateRelative(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Android.Content.ComponentName>(LocalBridgeClazz, "createRelative", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/ComponentName;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#readFromParcel(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public static Android.Content.ComponentName ReadFromParcel(Android.Os.Parcel arg0)
        {
            return SExecuteWithSignature<Android.Content.ComponentName>(LocalBridgeClazz, "readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#unflattenFromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public static Android.Content.ComponentName UnflattenFromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Content.ComponentName>(LocalBridgeClazz, "unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#writeToParcel(android.content.ComponentName,android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Os.Parcel"/></param>
        public static void WriteToParcel(Android.Content.ComponentName arg0, Android.Os.Parcel arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public Android.Content.ComponentName Clone()
        {
            return IExecuteWithSignature<Android.Content.ComponentName>("clone", "()Landroid/content/ComponentName;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#compareTo(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Landroid/content/ComponentName;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#flattenToShortString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FlattenToShortString()
        {
            return IExecuteWithSignature<Java.Lang.String>("flattenToShortString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#flattenToString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FlattenToString()
        {
            return IExecuteWithSignature<Java.Lang.String>("flattenToString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#getClassName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetClassName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#getShortClassName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetShortClassName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getShortClassName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#toShortString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToShortString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toShortString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentName.html#writeToParcel(android.os.Parcel,int)"/>
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