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
    #region DataInputStream
    public partial class DataInputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public DataInputStream(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.DataInputStream"/> to <see cref="Java.Io.DataInput"/>
        /// </summary>
        public static implicit operator Java.Io.DataInput(Java.Io.DataInputStream t) => t.Cast<Java.Io.DataInput>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readUTF(java.io.DataInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataInput"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Lang.String ReadUTF(Java.Io.DataInput arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "readUTF", "(Ljava/io/DataInput;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool ReadBoolean()
        {
            return IExecuteWithSignature<bool>("readBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte ReadByte()
        {
            return IExecuteWithSignature<byte>("readByte", "()B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public char ReadChar()
        {
            return IExecuteWithSignature<char>("readChar", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double ReadDouble()
        {
            return IExecuteWithSignature<double>("readDouble", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float ReadFloat()
        {
            return IExecuteWithSignature<float>("readFloat", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadInt()
        {
            return IExecuteWithSignature<int>("readInt", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedByte()
        {
            return IExecuteWithSignature<int>("readUnsignedByte", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedShort()
        {
            return IExecuteWithSignature<int>("readUnsignedShort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecuteWithSignature<int>("skipBytes", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [System.Obsolete()]
        public Java.Lang.String ReadLine()
        {
            return IExecuteWithSignature<Java.Lang.String>("readLine", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadUTF()
        {
            return IExecuteWithSignature<Java.Lang.String>("readUTF", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadLong()
        {
            return IExecuteWithSignature<long>("readLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public short ReadShort()
        {
            return IExecuteWithSignature<short>("readShort", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readFully(byte[],int,int)"/>
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
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecuteWithSignature("readFully", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}