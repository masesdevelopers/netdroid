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

namespace Android.Os
{
    #region ParcelFileDescriptor declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html"/>
    /// </summary>
    public partial class ParcelFileDescriptor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ParcelFileDescriptor>
    {
        const string _bridgeClassName = "android.os.ParcelFileDescriptor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ParcelFileDescriptor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ParcelFileDescriptor(params object[] args) : base(args) { }
    
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
        #region AutoCloseInputStream declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.AutoCloseInputStream.html"/>
        /// </summary>
        public partial class AutoCloseInputStream : Java.Io.FileInputStream
        {
            const string _bridgeClassName = "android.os.ParcelFileDescriptor$AutoCloseInputStream";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AutoCloseInputStream() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public AutoCloseInputStream(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region AutoCloseOutputStream declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.AutoCloseOutputStream.html"/>
        /// </summary>
        public partial class AutoCloseOutputStream : Java.Io.FileOutputStream
        {
            const string _bridgeClassName = "android.os.ParcelFileDescriptor$AutoCloseOutputStream";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public AutoCloseOutputStream() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public AutoCloseOutputStream(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region FileDescriptorDetachedException declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.FileDescriptorDetachedException.html"/>
        /// </summary>
        public partial class FileDescriptorDetachedException : Java.Io.IOException
        {
            const string _bridgeClassName = "android.os.ParcelFileDescriptor$FileDescriptorDetachedException";
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
            // TODO: complete the class
        
        }
        #endregion

        #region OnCloseListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.OnCloseListener.html"/>
        /// </summary>
        public partial class OnCloseListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnCloseListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.os.ParcelFileDescriptor_OnCloseListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnCloseListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnCloseListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnCloseListenerDirect : OnCloseListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.os.ParcelFileDescriptor$OnCloseListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        }
        #endregion

    
    }
    #endregion

    #region ParcelFileDescriptor implementation
    public partial class ParcelFileDescriptor : Android.Os.IParcelable, Java.Io.ICloseable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#%3Cinit%3E(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        public ParcelFileDescriptor(Android.Os.ParcelFileDescriptor arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Os.ParcelFileDescriptor"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Os.ParcelFileDescriptor t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Os.ParcelFileDescriptor"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Android.Os.ParcelFileDescriptor t) => t.Cast<Java.Io.Closeable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_APPEND"/>
        /// </summary>
        public static int MODE_APPEND { get { if (!_MODE_APPENDReady) { _MODE_APPENDContent = SGetField<int>(LocalBridgeClazz, "MODE_APPEND"); _MODE_APPENDReady = true; } return _MODE_APPENDContent; } }
        private static int _MODE_APPENDContent = default;
        private static bool _MODE_APPENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_CREATE"/>
        /// </summary>
        public static int MODE_CREATE { get { if (!_MODE_CREATEReady) { _MODE_CREATEContent = SGetField<int>(LocalBridgeClazz, "MODE_CREATE"); _MODE_CREATEReady = true; } return _MODE_CREATEContent; } }
        private static int _MODE_CREATEContent = default;
        private static bool _MODE_CREATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_READ_ONLY"/>
        /// </summary>
        public static int MODE_READ_ONLY { get { if (!_MODE_READ_ONLYReady) { _MODE_READ_ONLYContent = SGetField<int>(LocalBridgeClazz, "MODE_READ_ONLY"); _MODE_READ_ONLYReady = true; } return _MODE_READ_ONLYContent; } }
        private static int _MODE_READ_ONLYContent = default;
        private static bool _MODE_READ_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_READ_WRITE"/>
        /// </summary>
        public static int MODE_READ_WRITE { get { if (!_MODE_READ_WRITEReady) { _MODE_READ_WRITEContent = SGetField<int>(LocalBridgeClazz, "MODE_READ_WRITE"); _MODE_READ_WRITEReady = true; } return _MODE_READ_WRITEContent; } }
        private static int _MODE_READ_WRITEContent = default;
        private static bool _MODE_READ_WRITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_TRUNCATE"/>
        /// </summary>
        public static int MODE_TRUNCATE { get { if (!_MODE_TRUNCATEReady) { _MODE_TRUNCATEContent = SGetField<int>(LocalBridgeClazz, "MODE_TRUNCATE"); _MODE_TRUNCATEReady = true; } return _MODE_TRUNCATEContent; } }
        private static int _MODE_TRUNCATEContent = default;
        private static bool _MODE_TRUNCATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_WORLD_READABLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MODE_WORLD_READABLE { get { if (!_MODE_WORLD_READABLEReady) { _MODE_WORLD_READABLEContent = SGetField<int>(LocalBridgeClazz, "MODE_WORLD_READABLE"); _MODE_WORLD_READABLEReady = true; } return _MODE_WORLD_READABLEContent; } }
        private static int _MODE_WORLD_READABLEContent = default;
        private static bool _MODE_WORLD_READABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_WORLD_WRITEABLE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int MODE_WORLD_WRITEABLE { get { if (!_MODE_WORLD_WRITEABLEReady) { _MODE_WORLD_WRITEABLEContent = SGetField<int>(LocalBridgeClazz, "MODE_WORLD_WRITEABLE"); _MODE_WORLD_WRITEABLEReady = true; } return _MODE_WORLD_WRITEABLEContent; } }
        private static int _MODE_WORLD_WRITEABLEContent = default;
        private static bool _MODE_WORLD_WRITEABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#MODE_WRITE_ONLY"/>
        /// </summary>
        public static int MODE_WRITE_ONLY { get { if (!_MODE_WRITE_ONLYReady) { _MODE_WRITE_ONLYContent = SGetField<int>(LocalBridgeClazz, "MODE_WRITE_ONLY"); _MODE_WRITE_ONLYReady = true; } return _MODE_WRITE_ONLYContent; } }
        private static int _MODE_WRITE_ONLYContent = default;
        private static bool _MODE_WRITE_ONLYReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#adoptFd(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public static Android.Os.ParcelFileDescriptor AdoptFd(int arg0)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "adoptFd", "(I)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#dup(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor Dup(Java.Io.FileDescriptor arg0)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "dup", "(Ljava/io/FileDescriptor;)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#fromDatagramSocket(java.net.DatagramSocket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocket"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public static Android.Os.ParcelFileDescriptor FromDatagramSocket(Java.Net.DatagramSocket arg0)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "fromDatagramSocket", "(Ljava/net/DatagramSocket;)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#fromFd(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor FromFd(int arg0)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "fromFd", "(I)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#fromSocket(java.net.Socket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Socket"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        public static Android.Os.ParcelFileDescriptor FromSocket(Java.Net.Socket arg0)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "fromSocket", "(Ljava/net/Socket;)Landroid/os/ParcelFileDescriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#open(java.io.File,int,android.os.Handler,android.os.ParcelFileDescriptor.OnCloseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg3"><see cref="Android.Os.ParcelFileDescriptor.OnCloseListener"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor Open(Java.Io.File arg0, int arg1, Android.Os.Handler arg2, Android.Os.ParcelFileDescriptor.OnCloseListener arg3)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "open", "(Ljava/io/File;ILandroid/os/Handler;Landroid/os/ParcelFileDescriptor$OnCloseListener;)Landroid/os/ParcelFileDescriptor;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#open(java.io.File,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        public static Android.Os.ParcelFileDescriptor Open(Java.Io.File arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "open", "(Ljava/io/File;I)Landroid/os/ParcelFileDescriptor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#wrap(android.os.ParcelFileDescriptor,android.os.Handler,android.os.ParcelFileDescriptor.OnCloseListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg2"><see cref="Android.Os.ParcelFileDescriptor.OnCloseListener"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor Wrap(Android.Os.ParcelFileDescriptor arg0, Android.Os.Handler arg1, Android.Os.ParcelFileDescriptor.OnCloseListener arg2)
        {
            return SExecuteWithSignature<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "wrap", "(Landroid/os/ParcelFileDescriptor;Landroid/os/Handler;Landroid/os/ParcelFileDescriptor$OnCloseListener;)Landroid/os/ParcelFileDescriptor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#createPipe()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor[] CreatePipe()
        {
            return SExecuteWithSignatureArray<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "createPipe", "()[Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#createReliablePipe()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor[] CreateReliablePipe()
        {
            return SExecuteWithSignatureArray<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "createReliablePipe", "()[Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#createReliableSocketPair()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor[] CreateReliableSocketPair()
        {
            return SExecuteWithSignatureArray<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "createReliableSocketPair", "()[Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#createSocketPair()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Android.Os.ParcelFileDescriptor[] CreateSocketPair()
        {
            return SExecuteWithSignatureArray<Android.Os.ParcelFileDescriptor>(LocalBridgeClazz, "createSocketPair", "()[Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#parseMode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ParseMode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "parseMode", "(Ljava/lang/String;)I", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#dup()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Os.ParcelFileDescriptor Dup()
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("dup", "()Landroid/os/ParcelFileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#canDetectErrors()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanDetectErrors()
        {
            return IExecuteWithSignature<bool>("canDetectErrors", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#detachFd()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DetachFd()
        {
            return IExecuteWithSignature<int>("detachFd", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#getFd()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFd()
        {
            return IExecuteWithSignature<int>("getFd", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#getFileDescriptor()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.FileDescriptor"/></returns>
        public Java.Io.FileDescriptor GetFileDescriptor()
        {
            return IExecuteWithSignature<Java.Io.FileDescriptor>("getFileDescriptor", "()Ljava/io/FileDescriptor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#getStatSize()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStatSize()
        {
            return IExecuteWithSignature<long>("getStatSize", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#checkError()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void CheckError()
        {
            IExecuteWithSignature("checkError", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#closeWithError(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void CloseWithError(Java.Lang.String arg0)
        {
            IExecuteWithSignature("closeWithError", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region AutoCloseInputStream implementation
        public partial class AutoCloseInputStream
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.AutoCloseInputStream.html#%3Cinit%3E(android.os.ParcelFileDescriptor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
            public AutoCloseInputStream(Android.Os.ParcelFileDescriptor arg0)
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
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region AutoCloseOutputStream implementation
        public partial class AutoCloseOutputStream
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.AutoCloseOutputStream.html#%3Cinit%3E(android.os.ParcelFileDescriptor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
            public AutoCloseOutputStream(Android.Os.ParcelFileDescriptor arg0)
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
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region FileDescriptorDetachedException implementation
        public partial class FileDescriptorDetachedException
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
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnCloseListener implementation
        public partial class OnCloseListener
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
            /// Handlers initializer for <see cref="OnCloseListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onClose", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnCloseEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.OnCloseListener.html#onClose(java.io.IOException)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnClose"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<MASES.JCOBridge.C2JBridge.JVMBridgeException> OnOnClose { get; set; } = null;
            
            bool hasOverrideOnClose = true;
            void OnCloseEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnClose = true;
                var methodToExecute = (OnOnClose != null) ? OnOnClose : OnClose;
                methodToExecute.Invoke(JVMBridgeException.New(data.EventData.ExtraData.Get(0) as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnClose;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.OnCloseListener.html#onClose(java.io.IOException)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.IOException"/></param>
            public virtual void OnClose(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
            {
                hasOverrideOnClose = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnCloseListenerDirect implementation
        public partial class OnCloseListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/os/ParcelFileDescriptor.OnCloseListener.html#onClose(java.io.IOException)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.IOException"/></param>
            public override void OnClose(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
            {
                IExecuteWithSignature("onClose", "(Ljava/io/IOException;)V", arg0);
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