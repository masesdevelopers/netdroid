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

namespace Java.Nio
{
    #region IntBuffer declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html"/>
    /// </summary>
    public partial class IntBuffer : Java.Nio.Buffer
    {
        const string _bridgeClassName = "java.nio.IntBuffer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("IntBuffer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IntBuffer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("IntBuffer class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IntBuffer(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    #region IntBuffer implementation
    public partial class IntBuffer
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.IntBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.IntBuffer t) => t.Cast<Java.Lang.Comparable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Allocate(int arg0)
        {
            return SExecute<Java.Nio.IntBuffer>(LocalBridgeClazz, "allocate", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#wrap(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Wrap(int[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.IntBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#wrap(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Wrap(int[] arg0)
        {
            return SExecute<Java.Nio.IntBuffer>(LocalBridgeClazz, "wrap", new object[] { arg0 });
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Get()
        {
            return IExecute<int>("get");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(int arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#order()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecute<Java.Nio.ByteOrder>("order");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer AsReadOnlyBuffer()
        {
            return IExecute<Java.Nio.IntBuffer>("asReadOnlyBuffer");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#compact()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Compact()
        {
            return IExecute<Java.Nio.IntBuffer>("compact");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, int arg1)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int[] arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("put", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#compareTo(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.IntBuffer arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#mismatch(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.IntBuffer arg0)
        {
            return IExecute<int>("mismatch", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int arg0, int[] arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int arg0, int[] arg1)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int[] arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, int[] arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, int[] arg1)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,java.nio.IntBuffer,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Nio.IntBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, Java.Nio.IntBuffer arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(Java.Nio.IntBuffer arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}