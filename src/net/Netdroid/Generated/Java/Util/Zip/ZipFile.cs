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

namespace Java.Util.Zip
{
    #region ZipFile declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html"/>
    /// </summary>
    public partial class ZipFile : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ZipFile>
    {
        const string _bridgeClassName = "java.util.zip.ZipFile";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ZipFile() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ZipFile(params object[] args) : base(args) { }
    
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

    #region ZipFile implementation
    public partial class ZipFile : Java.Io.ICloseable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File,int,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0, int arg1, Java.Nio.Charset.Charset arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Util.Zip.ZipException"/>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#%3Cinit%3E(java.lang.String,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Lang.String arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ZipFile(Java.Lang.String arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Zip.ZipFile"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Util.Zip.ZipFile t) => t.Cast<Java.Io.Closeable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#OPEN_DELETE"/>
        /// </summary>
        public static int OPEN_DELETE { get { if (!_OPEN_DELETEReady) { _OPEN_DELETEContent = SGetField<int>(LocalBridgeClazz, "OPEN_DELETE"); _OPEN_DELETEReady = true; } return _OPEN_DELETEContent; } }
        private static int _OPEN_DELETEContent = default;
        private static bool _OPEN_DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#OPEN_READ"/>
        /// </summary>
        public static int OPEN_READ { get { if (!_OPEN_READReady) { _OPEN_READContent = SGetField<int>(LocalBridgeClazz, "OPEN_READ"); _OPEN_READReady = true; } return _OPEN_READContent; } }
        private static int _OPEN_READContent = default;
        private static bool _OPEN_READReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#getInputStream(java.util.zip.ZipEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.ZipEntry"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetInputStream(Java.Util.Zip.ZipEntry arg0)
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "(Ljava/util/zip/ZipEntry;)Ljava/io/InputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#getComment()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetComment()
        {
            return IExecuteWithSignature<Java.Lang.String>("getComment", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#entries()"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsJava_Util_Zip_ZipEntry"><see cref="Java.Util.Zip.ZipEntry"/></typeparam>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<ReturnExtendsJava_Util_Zip_ZipEntry> Entries<ReturnExtendsJava_Util_Zip_ZipEntry>() where ReturnExtendsJava_Util_Zip_ZipEntry : Java.Util.Zip.ZipEntry
        {
            return IExecuteWithSignature<Java.Util.Enumeration<ReturnExtendsJava_Util_Zip_ZipEntry>>("entries", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#stream()"/>
        /// </summary>
        /// <typeparam name="ReturnExtendsJava_Util_Zip_ZipEntry"><see cref="Java.Util.Zip.ZipEntry"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<ReturnExtendsJava_Util_Zip_ZipEntry> Stream<ReturnExtendsJava_Util_Zip_ZipEntry>() where ReturnExtendsJava_Util_Zip_ZipEntry : Java.Util.Zip.ZipEntry
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<ReturnExtendsJava_Util_Zip_ZipEntry>>("stream", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#getEntry(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry GetEntry(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Zip.ZipEntry>("getEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/ZipFile.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}