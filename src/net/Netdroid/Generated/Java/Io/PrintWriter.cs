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
    #region PrintWriter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html"/>
    /// </summary>
    public partial class PrintWriter : Java.Io.Writer
    {
        const string _bridgeClassName = "java.io.PrintWriter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrintWriter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrintWriter(params object[] args) : base(args) { }
    
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

    #region PrintWriter implementation
    public partial class PrintWriter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public PrintWriter(Java.Io.File arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.File,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public PrintWriter(Java.Io.File arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public PrintWriter(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.OutputStream,boolean,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Charset.Charset"/></param>
        public PrintWriter(Java.Io.OutputStream arg0, bool arg1, Java.Nio.Charset.Charset arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.OutputStream,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public PrintWriter(Java.Io.OutputStream arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public PrintWriter(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.Writer,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public PrintWriter(Java.Io.Writer arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        public PrintWriter(Java.Io.Writer arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public PrintWriter(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.lang.String,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public PrintWriter(Java.Lang.String arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public PrintWriter(Java.Lang.String arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#checkError()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CheckError()
        {
            return IExecuteWithSignature<bool>("checkError", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#format(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        public Java.Io.PrintWriter Format(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature<Java.Io.PrintWriter>("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0); else return IExecuteWithSignature<Java.Io.PrintWriter>("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#format(java.util.Locale,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        public Java.Io.PrintWriter Format(Java.Util.Locale arg0, Java.Lang.String arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return IExecuteWithSignature<Java.Io.PrintWriter>("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1); else return IExecuteWithSignature<Java.Io.PrintWriter>("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#printf(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        public Java.Io.PrintWriter Printf(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecuteWithSignature<Java.Io.PrintWriter>("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0); else return IExecuteWithSignature<Java.Io.PrintWriter>("printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#printf(java.util.Locale,java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        public Java.Io.PrintWriter Printf(Java.Util.Locale arg0, Java.Lang.String arg1, params object[] arg2)
        {
            if (arg2.Length == 0) return IExecuteWithSignature<Java.Io.PrintWriter>("printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1); else return IExecuteWithSignature<Java.Io.PrintWriter>("printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Print(bool arg0)
        {
            IExecuteWithSignature("print", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Print(char arg0)
        {
            IExecuteWithSignature("print", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Print(char[] arg0)
        {
            IExecuteWithSignature("print", "([C)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Print(double arg0)
        {
            IExecuteWithSignature("print", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void Print(float arg0)
        {
            IExecuteWithSignature("print", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Print(int arg0)
        {
            IExecuteWithSignature("print", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Print(object arg0)
        {
            IExecuteWithSignature("print", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Print(Java.Lang.String arg0)
        {
            IExecuteWithSignature("print", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#print(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Print(long arg0)
        {
            IExecuteWithSignature("print", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println()"/>
        /// </summary>
        public void Println()
        {
            IExecuteWithSignature("println", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void Println(bool arg0)
        {
            IExecuteWithSignature("println", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Println(char arg0)
        {
            IExecuteWithSignature("println", "(C)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void Println(char[] arg0)
        {
            IExecuteWithSignature("println", "([C)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Println(double arg0)
        {
            IExecuteWithSignature("println", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void Println(float arg0)
        {
            IExecuteWithSignature("println", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Println(int arg0)
        {
            IExecuteWithSignature("println", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Println(object arg0)
        {
            IExecuteWithSignature("println", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Println(Java.Lang.String arg0)
        {
            IExecuteWithSignature("println", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/io/PrintWriter.html#println(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Println(long arg0)
        {
            IExecuteWithSignature("println", "(J)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}