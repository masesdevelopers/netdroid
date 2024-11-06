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

namespace Java.Io
{
    #region OutputStream declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/io/OutputStream.html"/>
    /// </summary>
    public partial class OutputStream : MASES.JCOBridge.C2JBridge.JVMBridgeBase<OutputStream>
    {
        const string _bridgeClassName = "java.io.OutputStream";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("OutputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public OutputStream() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("OutputStream class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public OutputStream(params object[] args) : base(args) { }
    
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

    #region OutputStream implementation
    public partial class OutputStream : Java.Io.ICloseable, Java.Io.IFlushable
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.OutputStream"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Io.OutputStream t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.OutputStream"/> to <see cref="Java.Io.Flushable"/>
        /// </summary>
        public static implicit operator Java.Io.Flushable(Java.Io.OutputStream t) => t.Cast<Java.Io.Flushable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#nullOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        public static Java.Io.OutputStream NullOutputStream()
        {
            return SExecuteWithSignature<Java.Io.OutputStream>(LocalBridgeClazz, "nullOutputStream", "()Ljava/io/OutputStream;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#write(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(int arg0)
        {
            IExecuteWithSignature("write", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#write(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("write", "([BII)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/OutputStream.html#write(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0)
        {
            IExecuteWithSignature("write", "([B)V", new object[] { arg0 });
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}