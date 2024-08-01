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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Math
{
    #region BigInteger
    public partial class BigInteger
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BigInteger(byte[] arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public BigInteger(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(int,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public BigInteger(int arg0, byte[] arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public BigInteger(int arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(int,int,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Random"/></param>
        public BigInteger(int arg0, int arg1, Java.Util.Random arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(int,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Random"/></param>
        public BigInteger(int arg0, Java.Util.Random arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BigInteger(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public BigInteger(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Math.BigInteger"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Math.BigInteger t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#ONE"/>
        /// </summary>
        public static Java.Math.BigInteger ONE { get { if (!_ONEReady) { _ONEContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "ONE"); _ONEReady = true; } return _ONEContent; } }
        private static Java.Math.BigInteger _ONEContent = default;
        private static bool _ONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#TEN"/>
        /// </summary>
        public static Java.Math.BigInteger TEN { get { if (!_TENReady) { _TENContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "TEN"); _TENReady = true; } return _TENContent; } }
        private static Java.Math.BigInteger _TENContent = default;
        private static bool _TENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#TWO"/>
        /// </summary>
        public static Java.Math.BigInteger TWO { get { if (!_TWOReady) { _TWOContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "TWO"); _TWOReady = true; } return _TWOContent; } }
        private static Java.Math.BigInteger _TWOContent = default;
        private static bool _TWOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#ZERO"/>
        /// </summary>
        public static Java.Math.BigInteger ZERO { get { if (!_ZEROReady) { _ZEROContent = SGetField<Java.Math.BigInteger>(LocalBridgeClazz, "ZERO"); _ZEROReady = true; } return _ZEROContent; } }
        private static Java.Math.BigInteger _ZEROContent = default;
        private static bool _ZEROReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#probablePrime(int,java.util.Random)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Random"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public static Java.Math.BigInteger ProbablePrime(int arg0, Java.Util.Random arg1)
        {
            return SExecute<Java.Math.BigInteger>(LocalBridgeClazz, "probablePrime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#valueOf(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public static Java.Math.BigInteger ValueOf(long arg0)
        {
            return SExecuteWithSignature<Java.Math.BigInteger>(LocalBridgeClazz, "valueOf", "(J)Ljava/math/BigInteger;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#isProbablePrime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsProbablePrime(int arg0)
        {
            return IExecuteWithSignature<bool>("isProbablePrime", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#testBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TestBit(int arg0)
        {
            return IExecuteWithSignature<bool>("testBit", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#byteValueExact()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte ByteValueExact()
        {
            return IExecuteWithSignature<byte>("byteValueExact", "()B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#toByteArray()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] ToByteArray()
        {
            return IExecuteWithSignatureArray<byte>("toByteArray", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#bitCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BitCount()
        {
            return IExecuteWithSignature<int>("bitCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#bitLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int BitLength()
        {
            return IExecuteWithSignature<int>("bitLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#compareTo(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/math/BigInteger;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#getLowestSetBit()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLowestSetBit()
        {
            return IExecuteWithSignature<int>("getLowestSetBit", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#intValueExact()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int IntValueExact()
        {
            return IExecuteWithSignature<int>("intValueExact", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#signum()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Signum()
        {
            return IExecuteWithSignature<int>("signum", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToString(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("toString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#abs()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Abs()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("abs", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#add(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Add(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#and(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger And(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#andNot(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger AndNot(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#clearBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ClearBit(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("clearBit", "(I)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#divide(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Divide(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#flipBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger FlipBit(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("flipBit", "(I)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#gcd(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Gcd(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#max(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Max(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#min(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Min(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#mod(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Mod(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#modInverse(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ModInverse(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#modPow(java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ModPow(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1)
        {
            return IExecute<Java.Math.BigInteger>("modPow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#multiply(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Multiply(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Negate()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("negate", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#nextProbablePrime()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger NextProbablePrime()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("nextProbablePrime", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#not()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Not()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("not", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#or(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Or(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#pow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Pow(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("pow", "(I)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#remainder(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Remainder(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#setBit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger SetBit(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("setBit", "(I)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#shiftLeft(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ShiftLeft(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("shiftLeft", "(I)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#shiftRight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger ShiftRight(int arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("shiftRight", "(I)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#sqrt()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Sqrt()
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("sqrt", "()Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#subtract(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Subtract(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#xor(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger Xor(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignature<Java.Math.BigInteger>("xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#divideAndRemainder(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger[] DivideAndRemainder(Java.Math.BigInteger arg0)
        {
            return IExecuteWithSignatureArray<Java.Math.BigInteger>("divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#sqrtAndRemainder()"/>
        /// </summary>
        /// <returns><see cref="Java.Math.BigInteger"/></returns>
        public Java.Math.BigInteger[] SqrtAndRemainder()
        {
            return IExecuteWithSignatureArray<Java.Math.BigInteger>("sqrtAndRemainder", "()[Ljava/math/BigInteger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#longValueExact()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LongValueExact()
        {
            return IExecuteWithSignature<long>("longValueExact", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/math/BigInteger.html#shortValueExact()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short ShortValueExact()
        {
            return IExecuteWithSignature<short>("shortValueExact", "()S");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}