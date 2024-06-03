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

namespace Android.Os
{
    #region Bundle
    public partial class Bundle : Java.Lang.ICloneable, Android.Os.IParcelable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#%3Cinit%3E(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public Bundle(Android.Os.Bundle arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#%3Cinit%3E(android.os.PersistableBundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.PersistableBundle"/></param>
        public Bundle(Android.Os.PersistableBundle arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Bundle(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#%3Cinit%3E(java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        public Bundle(Java.Lang.ClassLoader arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Os.Bundle"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Os.Bundle t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Os.Bundle"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Os.Bundle t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#EMPTY"/>
        /// </summary>
        public static Android.Os.Bundle EMPTY { get { if (!_EMPTYReady) { _EMPTYContent = SGetField<Android.Os.Bundle>(LocalBridgeClazz, "EMPTY"); _EMPTYReady = true; } return _EMPTYContent; } }
        private static Android.Os.Bundle _EMPTYContent = default;
        private static bool _EMPTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getSparseParcelableArray(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<T> GetSparseParcelableArray<T>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecute<Android.Util.SparseArray<T>>("getSparseParcelableArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getSparseParcelableArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="T"><see cref="Android.Os.IParcelable"/></typeparam>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        [global::System.Obsolete()]
        public Android.Util.SparseArray<T> GetSparseParcelableArray<T>(Java.Lang.String arg0) where T : Android.Os.IParcelable, new()
        {
            return IExecute<Android.Util.SparseArray<T>>("getSparseParcelableArray", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getParcelableArrayList(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<T> GetParcelableArrayList<T>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Util.ArrayList<T>>("getParcelableArrayList", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getParcelableArrayList(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="T"><see cref="Android.Os.IParcelable"/></typeparam>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        [global::System.Obsolete()]
        public Java.Util.ArrayList<T> GetParcelableArrayList<T>(Java.Lang.String arg0) where T : Android.Os.IParcelable, new()
        {
            return IExecute<Java.Util.ArrayList<T>>("getParcelableArrayList", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getParcelable(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetParcelable<T>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecute<T>("getParcelable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getParcelable(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="T"><see cref="Android.Os.IParcelable"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        [global::System.Obsolete()]
        public T GetParcelable<T>(Java.Lang.String arg0) where T : Android.Os.IParcelable, new()
        {
            return IExecute<T>("getParcelable", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getSerializable(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Io.ISerializable"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetSerializable<T>(Java.Lang.String arg0, Java.Lang.Class arg1) where T : Java.Io.ISerializable, new()
        {
            return IExecute<T>("getSerializable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getParcelableArray(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetParcelableArray<T>(Java.Lang.String arg0, Java.Lang.Class arg1)
        {
            return IExecuteArray<T>("getParcelableArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#deepCopy()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle DeepCopy()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("deepCopy", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getBundle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetBundle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getBinder(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.IBinder"/></returns>
        public Android.Os.IBinder GetBinder(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Os.IBinder>("getBinder", "(Ljava/lang/String;)Landroid/os/IBinder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getParcelableArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.Parcelable"/></returns>
        [global::System.Obsolete()]
        public Android.Os.Parcelable[] GetParcelableArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Android.Os.Parcelable>("getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getSize(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size GetSize(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Util.Size>("getSize", "(Ljava/lang/String;)Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getSizeF(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Util.SizeF"/></returns>
        public Android.Util.SizeF GetSizeF(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Util.SizeF>("getSizeF", "(Ljava/lang/String;)Landroid/util/SizeF;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#hasFileDescriptors()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasFileDescriptors()
        {
            return IExecuteWithSignature<bool>("hasFileDescriptors", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getByte(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte GetByte(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<byte>("getByte", "(Ljava/lang/String;)B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getByteArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetByteArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<byte>("getByteArray", "(Ljava/lang/String;)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getChar(java.lang.String,char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetChar(Java.Lang.String arg0, char arg1)
        {
            return IExecute<char>("getChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getChar(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="char"/></returns>
        public char GetChar(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<char>("getChar", "(Ljava/lang/String;)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getCharArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="char"/></returns>
        public char[] GetCharArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<char>("getCharArray", "(Ljava/lang/String;)[C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(Java.Lang.String arg0, float arg1)
        {
            return IExecute<float>("getFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getFloat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<float>("getFloat", "(Ljava/lang/String;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getFloatArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetFloatArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<float>("getFloatArray", "(Ljava/lang/String;)[F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getSerializable(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.Serializable"/></returns>
        [global::System.Obsolete()]
        public Java.Io.Serializable GetSerializable(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Io.Serializable>("getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getByte(java.lang.String,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        public Java.Lang.Byte GetByte(Java.Lang.String arg0, byte arg1)
        {
            return IExecute<Java.Lang.Byte>("getByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getCharSequence(java.lang.String,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetCharSequence(Java.Lang.String arg0, Java.Lang.CharSequence arg1)
        {
            return IExecute<Java.Lang.CharSequence>("getCharSequence", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getCharSequence(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetCharSequence(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getCharSequenceArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence[] GetCharSequenceArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.CharSequence>("getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getClassLoader()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ClassLoader"/></returns>
        public Java.Lang.ClassLoader GetClassLoader()
        {
            return IExecuteWithSignature<Java.Lang.ClassLoader>("getClassLoader", "()Ljava/lang/ClassLoader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getCharSequenceArrayList(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Java.Lang.CharSequence> GetCharSequenceArrayList(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Java.Lang.CharSequence>>("getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getIntegerArrayList(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Java.Lang.Integer> GetIntegerArrayList(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Java.Lang.Integer>>("getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getStringArrayList(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Java.Lang.String> GetStringArrayList(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Java.Lang.String>>("getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getShort(java.lang.String,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="short"/></returns>
        public short GetShort(Java.Lang.String arg0, short arg1)
        {
            return IExecute<short>("getShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getShort(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="short"/></returns>
        public short GetShort(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<short>("getShort", "(Ljava/lang/String;)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#getShortArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="short"/></returns>
        public short[] GetShortArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<short>("getShortArray", "(Ljava/lang/String;)[S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putAll(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void PutAll(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("putAll", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putBinder(java.lang.String,android.os.IBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.IBinder"/></param>
        public void PutBinder(Java.Lang.String arg0, Android.Os.IBinder arg1)
        {
            IExecute("putBinder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putBundle(java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public void PutBundle(Java.Lang.String arg0, Android.Os.Bundle arg1)
        {
            IExecute("putBundle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putByte(java.lang.String,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void PutByte(Java.Lang.String arg0, byte arg1)
        {
            IExecute("putByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putByteArray(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public void PutByteArray(Java.Lang.String arg0, byte[] arg1)
        {
            IExecute("putByteArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putChar(java.lang.String,char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        public void PutChar(Java.Lang.String arg0, char arg1)
        {
            IExecute("putChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putCharArray(java.lang.String,char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        public void PutCharArray(Java.Lang.String arg0, char[] arg1)
        {
            IExecute("putCharArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putCharSequence(java.lang.String,java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        public void PutCharSequence(Java.Lang.String arg0, Java.Lang.CharSequence arg1)
        {
            IExecute("putCharSequence", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putCharSequenceArray(java.lang.String,java.lang.CharSequence[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.CharSequence"/></param>
        public void PutCharSequenceArray(Java.Lang.String arg0, Java.Lang.CharSequence[] arg1)
        {
            IExecute("putCharSequenceArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putCharSequenceArrayList(java.lang.String,java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.ArrayList"/></param>
        public void PutCharSequenceArrayList(Java.Lang.String arg0, Java.Util.ArrayList<Java.Lang.CharSequence> arg1)
        {
            IExecute("putCharSequenceArrayList", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void PutFloat(Java.Lang.String arg0, float arg1)
        {
            IExecute("putFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putFloatArray(java.lang.String,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public void PutFloatArray(Java.Lang.String arg0, float[] arg1)
        {
            IExecute("putFloatArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putIntegerArrayList(java.lang.String,java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.ArrayList"/></param>
        public void PutIntegerArrayList(Java.Lang.String arg0, Java.Util.ArrayList<Java.Lang.Integer> arg1)
        {
            IExecute("putIntegerArrayList", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putParcelable(java.lang.String,android.os.Parcelable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Parcelable"/></param>
        public void PutParcelable(Java.Lang.String arg0, Android.Os.Parcelable arg1)
        {
            IExecute("putParcelable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putParcelableArray(java.lang.String,android.os.Parcelable[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.Parcelable"/></param>
        public void PutParcelableArray(Java.Lang.String arg0, Android.Os.Parcelable[] arg1)
        {
            IExecute("putParcelableArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putParcelableArrayList(java.lang.String,java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.ArrayList"/></param>
        /// <typeparam name="Arg1ExtendsAndroid_Os_Parcelable"><see cref="Android.Os.Parcelable"/></typeparam>
        public void PutParcelableArrayList<Arg1ExtendsAndroid_Os_Parcelable>(Java.Lang.String arg0, Java.Util.ArrayList<Arg1ExtendsAndroid_Os_Parcelable> arg1) where Arg1ExtendsAndroid_Os_Parcelable : Android.Os.Parcelable
        {
            IExecute("putParcelableArrayList", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putSerializable(java.lang.String,java.io.Serializable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.Serializable"/></param>
        public void PutSerializable(Java.Lang.String arg0, Java.Io.Serializable arg1)
        {
            IExecute("putSerializable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putShort(java.lang.String,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public void PutShort(Java.Lang.String arg0, short arg1)
        {
            IExecute("putShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putShortArray(java.lang.String,short[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        public void PutShortArray(Java.Lang.String arg0, short[] arg1)
        {
            IExecute("putShortArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putSize(java.lang.String,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        public void PutSize(Java.Lang.String arg0, Android.Util.Size arg1)
        {
            IExecute("putSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putSizeF(java.lang.String,android.util.SizeF)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Util.SizeF"/></param>
        public void PutSizeF(Java.Lang.String arg0, Android.Util.SizeF arg1)
        {
            IExecute("putSizeF", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putSparseParcelableArray(java.lang.String,android.util.SparseArray)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Util.SparseArray"/></param>
        /// <typeparam name="Arg1ExtendsAndroid_Os_Parcelable"><see cref="Android.Os.Parcelable"/></typeparam>
        public void PutSparseParcelableArray<Arg1ExtendsAndroid_Os_Parcelable>(Java.Lang.String arg0, Android.Util.SparseArray<Arg1ExtendsAndroid_Os_Parcelable> arg1) where Arg1ExtendsAndroid_Os_Parcelable : Android.Os.Parcelable
        {
            IExecute("putSparseParcelableArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#putStringArrayList(java.lang.String,java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.ArrayList"/></param>
        public void PutStringArrayList(Java.Lang.String arg0, Java.Util.ArrayList<Java.Lang.String> arg1)
        {
            IExecute("putStringArrayList", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#readFromParcel(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public void ReadFromParcel(Android.Os.Parcel arg0)
        {
            IExecuteWithSignature("readFromParcel", "(Landroid/os/Parcel;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#setClassLoader(java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        public void SetClassLoader(Java.Lang.ClassLoader arg0)
        {
            IExecuteWithSignature("setClassLoader", "(Ljava/lang/ClassLoader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Bundle.html#writeToParcel(android.os.Parcel,int)"/>
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