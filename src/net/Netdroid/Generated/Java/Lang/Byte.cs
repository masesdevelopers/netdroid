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

namespace Java.Lang
{
    #region Byte
    public partial class Byte : Java.Lang.IComparable<Java.Lang.Byte>, Java.Lang.Constant.IConstable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Byte"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Lang.Byte t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Byte"/> to <see cref="Java.Lang.Constant.Constable"/>
        /// </summary>
        public static implicit operator Java.Lang.Constant.Constable(Java.Lang.Byte t) => t.Cast<Java.Lang.Constant.Constable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#MAX_VALUE"/>
        /// </summary>
        public static byte MAX_VALUE { get { if (!_MAX_VALUEReady) { _MAX_VALUEContent = SGetField<byte>(LocalBridgeClazz, "MAX_VALUE"); _MAX_VALUEReady = true; } return _MAX_VALUEContent; } }
        private static byte _MAX_VALUEContent = default;
        private static bool _MAX_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#MIN_VALUE"/>
        /// </summary>
        public static byte MIN_VALUE { get { if (!_MIN_VALUEReady) { _MIN_VALUEContent = SGetField<byte>(LocalBridgeClazz, "MIN_VALUE"); _MIN_VALUEReady = true; } return _MIN_VALUEContent; } }
        private static byte _MIN_VALUEContent = default;
        private static bool _MIN_VALUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#BYTES"/>
        /// </summary>
        public static int BYTES { get { if (!_BYTESReady) { _BYTESContent = SGetField<int>(LocalBridgeClazz, "BYTES"); _BYTESReady = true; } return _BYTESContent; } }
        private static int _BYTESContent = default;
        private static bool _BYTESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#SIZE"/>
        /// </summary>
        public static int SIZE { get { if (!_SIZEReady) { _SIZEContent = SGetField<int>(LocalBridgeClazz, "SIZE"); _SIZEReady = true; } return _SIZEContent; } }
        private static int _SIZEContent = default;
        private static bool _SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#TYPE"/>
        /// </summary>
        public static Java.Lang.Class TYPE { get { if (!_TYPEReady) { _TYPEContent = SGetField<Java.Lang.Class>(LocalBridgeClazz, "TYPE"); _TYPEReady = true; } return _TYPEContent; } }
        private static Java.Lang.Class _TYPEContent = default;
        private static bool _TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#parseByte(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static byte ParseByte(Java.Lang.String arg0, int arg1)
        {
            return SExecute<byte>(LocalBridgeClazz, "parseByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#parseByte(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static byte ParseByte(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<byte>(LocalBridgeClazz, "parseByte", "(Ljava/lang/String;)B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#compare(byte,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Compare(byte arg0, byte arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compare", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#compareUnsigned(byte,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        public static int CompareUnsigned(byte arg0, byte arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "compareUnsigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#hashCode(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HashCode(byte arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "hashCode", "(B)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#toUnsignedInt(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ToUnsignedInt(byte arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "toUnsignedInt", "(B)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#decode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Byte Decode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Byte>(LocalBridgeClazz, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#valueOf(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        public static Java.Lang.Byte ValueOf(byte arg0)
        {
            return SExecuteWithSignature<Java.Lang.Byte>(LocalBridgeClazz, "valueOf", "(B)Ljava/lang/Byte;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#valueOf(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Byte ValueOf(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Java.Lang.Byte>(LocalBridgeClazz, "valueOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public static Java.Lang.Byte ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Byte>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#toString(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(byte arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(B)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#toUnsignedLong(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="long"/></returns>
        public static long ToUnsignedLong(byte arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "toUnsignedLong", "(B)J", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#compareTo(java.lang.Byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Byte"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Lang.Byte arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Byte;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/Byte.html#describeConstable()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Lang.Constant.DynamicConstantDesc<Java.Lang.Byte>> DescribeConstable()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Lang.Constant.DynamicConstantDesc<Java.Lang.Byte>>>("describeConstable", "()Ljava/util/Optional;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}