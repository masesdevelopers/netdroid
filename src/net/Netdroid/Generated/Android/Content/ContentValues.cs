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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Content
{
    #region ContentValues declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/ContentValues.html"/>
    /// </summary>
    public partial class ContentValues : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.ContentValues";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ContentValues() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ContentValues(params object[] args) : base(args) { }

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

    #region ContentValues implementation
    public partial class ContentValues
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#%3Cinit%3E(android.content.ContentValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ContentValues"/></param>
        public ContentValues(Android.Content.ContentValues arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ContentValues(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#TAG"/>
        /// </summary>
        public static Java.Lang.String TAG { get { if (!_TAGReady) { _TAGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TAG"); _TAGReady = true; } return _TAGContent; } }
        private static Java.Lang.String _TAGContent = default;
        private static bool _TAGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#containsKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("containsKey", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsByteArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetAsByteArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<byte>("getAsByteArray", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsBoolean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean GetAsBoolean(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsByte(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        public Java.Lang.Byte GetAsByte(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Byte>("getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsDouble(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Double"/></returns>
        public Java.Lang.Double GetAsDouble(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Double>("getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsFloat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Float"/></returns>
        public Java.Lang.Float GetAsFloat(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Float>("getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsInteger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        public Java.Lang.Integer GetAsInteger(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Integer>("getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsLong(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        public Java.Lang.Long GetAsLong(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Long>("getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsShort(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        public Java.Lang.Short GetAsShort(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Short>("getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#getAsString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAsString(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getAsString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#valueSet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Util.Map.Entry<Java.Lang.String, object>> ValueSet()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Util.Map.Entry<Java.Lang.String, object>>>("valueSet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void Put(Java.Lang.String arg0, byte[] arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;[B)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Boolean"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.Boolean arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Boolean;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.Byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Byte"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.Byte arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Byte;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.Double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Double"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.Double arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Double;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.Float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Float"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.Float arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Float;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Integer"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.Integer arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Integer;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.Long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Long"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.Long arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Long;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.Short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Short"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.Short arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/Short;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#put(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Put(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("put", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#putAll(android.content.ContentValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ContentValues"/></param>
        public void PutAll(Android.Content.ContentValues arg0)
        {
            IExecuteWithSignature("putAll", "(Landroid/content/ContentValues;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#putNull(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void PutNull(Java.Lang.String arg0)
        {
            IExecuteWithSignature("putNull", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#remove(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Remove(Java.Lang.String arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentValues.html#writeToParcel(android.os.Parcel,int)"/>
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