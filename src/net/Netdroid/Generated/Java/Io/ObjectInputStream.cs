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

namespace Java.Io
{
    #region ObjectInputStream
    public partial class ObjectInputStream : Java.Io.IObjectInput, Java.Io.IObjectStreamConstants
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ObjectInputStream(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.ObjectInputStream"/> to <see cref="Java.Io.ObjectInput"/>
        /// </summary>
        public static implicit operator Java.Io.ObjectInput(Java.Io.ObjectInputStream t) => t.Cast<Java.Io.ObjectInput>();
        /// <summary>
        /// Converter from <see cref="Java.Io.ObjectInputStream"/> to <see cref="Java.Io.ObjectStreamConstants"/>
        /// </summary>
        public static implicit operator Java.Io.ObjectStreamConstants(Java.Io.ObjectInputStream t) => t.Cast<Java.Io.ObjectStreamConstants>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#getObjectInputFilter()"/> <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#setObjectInputFilter(java.io.ObjectInputFilter)"/>
        /// </summary>
        public Java.Io.ObjectInputFilter ObjectInputFilter
        {
            get { return IExecuteWithSignature<Java.Io.ObjectInputFilter>("getObjectInputFilter", "()Ljava/io/ObjectInputFilter;"); } set { IExecuteWithSignature("setObjectInputFilter", "(Ljava/io/ObjectInputFilter;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool ReadBoolean()
        {
            return IExecuteWithSignature<bool>("readBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte ReadByte()
        {
            return IExecuteWithSignature<byte>("readByte", "()B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public char ReadChar()
        {
            return IExecuteWithSignature<char>("readChar", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double ReadDouble()
        {
            return IExecuteWithSignature<double>("readDouble", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readObject()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object ReadObject()
        {
            return IExecuteWithSignature("readObject", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float ReadFloat()
        {
            return IExecuteWithSignature<float>("readFloat", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadInt()
        {
            return IExecuteWithSignature<int>("readInt", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedByte()
        {
            return IExecuteWithSignature<int>("readUnsignedByte", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedShort()
        {
            return IExecuteWithSignature<int>("readUnsignedShort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecuteWithSignature<int>("skipBytes", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readFields()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.ObjectInputStream.GetField"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public Java.Io.ObjectInputStream.GetField ReadFields()
        {
            return IExecuteWithSignature<Java.Io.ObjectInputStream.GetField>("readFields", "()Ljava/io/ObjectInputStream$GetField;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readUnshared()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object ReadUnshared()
        {
            return IExecuteWithSignature("readUnshared", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [System.Obsolete()]
        public Java.Lang.String ReadLine()
        {
            return IExecuteWithSignature<Java.Lang.String>("readLine", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadUTF()
        {
            return IExecuteWithSignature<Java.Lang.String>("readUTF", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadLong()
        {
            return IExecuteWithSignature<long>("readLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public short ReadShort()
        {
            return IExecuteWithSignature<short>("readShort", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#defaultReadObject()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public void DefaultReadObject()
        {
            IExecuteWithSignature("defaultReadObject", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecuteWithSignature("readFully", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.html#registerValidation(java.io.ObjectInputValidation,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputValidation"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.NotActiveException"/>
        /// <exception cref="Java.Io.InvalidObjectException"/>
        public void RegisterValidation(Java.Io.ObjectInputValidation arg0, int arg1)
        {
            IExecute("registerValidation", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region GetField
        public partial class GetField
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
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#getObjectStreamClass()"/> 
            /// </summary>
            public Java.Io.ObjectStreamClass ObjectStreamClass
            {
                get { return IExecuteWithSignature<Java.Io.ObjectStreamClass>("getObjectStreamClass", "()Ljava/io/ObjectStreamClass;"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#defaulted(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public bool Defaulted(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<bool>("defaulted", "(Ljava/lang/String;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public bool Get(Java.Lang.String arg0, bool arg1)
            {
                return IExecute<bool>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,byte)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="byte"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public byte Get(Java.Lang.String arg0, byte arg1)
            {
                return IExecute<byte>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,char)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="char"/></param>
            /// <returns><see cref="char"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public char Get(Java.Lang.String arg0, char arg1)
            {
                return IExecute<char>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <returns><see cref="double"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public double Get(Java.Lang.String arg0, double arg1)
            {
                return IExecute<double>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <returns><see cref="float"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public float Get(Java.Lang.String arg0, float arg1)
            {
                return IExecute<float>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public int Get(Java.Lang.String arg0, int arg1)
            {
                return IExecute<int>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public object Get(Java.Lang.String arg0, object arg1)
            {
                return IExecute("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="long"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public long Get(Java.Lang.String arg0, long arg1)
            {
                return IExecute<long>("get", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/io/ObjectInputStream.GetField.html#get(java.lang.String,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            /// <returns><see cref="short"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public short Get(Java.Lang.String arg0, short arg1)
            {
                return IExecute<short>("get", arg0, arg1);
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