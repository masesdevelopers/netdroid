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
    #region IBinder declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/IBinder.html"/>
    /// </summary>
    public partial class IBinder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IBinder>
    {
        const string _bridgeClassName = "android.os.IBinder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("IBinder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IBinder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("IBinder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public IBinder(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region DeathRecipient declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.DeathRecipient.html"/>
        /// </summary>
        public partial class DeathRecipient : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DeathRecipient>
        {
            const string _bridgeClassName = "android.os.IBinder$DeathRecipient";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("DeathRecipient class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public DeathRecipient() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("DeathRecipient class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public DeathRecipient(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region IIBinder
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IIBinder
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region IBinder implementation
    public partial class IBinder : Android.Os.IIBinder
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#DUMP_TRANSACTION"/>
        /// </summary>
        public static int DUMP_TRANSACTION { get { if (!_DUMP_TRANSACTIONReady) { _DUMP_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "DUMP_TRANSACTION"); _DUMP_TRANSACTIONReady = true; } return _DUMP_TRANSACTIONContent; } }
        private static int _DUMP_TRANSACTIONContent = default;
        private static bool _DUMP_TRANSACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#FIRST_CALL_TRANSACTION"/>
        /// </summary>
        public static int FIRST_CALL_TRANSACTION { get { if (!_FIRST_CALL_TRANSACTIONReady) { _FIRST_CALL_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "FIRST_CALL_TRANSACTION"); _FIRST_CALL_TRANSACTIONReady = true; } return _FIRST_CALL_TRANSACTIONContent; } }
        private static int _FIRST_CALL_TRANSACTIONContent = default;
        private static bool _FIRST_CALL_TRANSACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#FLAG_ONEWAY"/>
        /// </summary>
        public static int FLAG_ONEWAY { get { if (!_FLAG_ONEWAYReady) { _FLAG_ONEWAYContent = SGetField<int>(LocalBridgeClazz, "FLAG_ONEWAY"); _FLAG_ONEWAYReady = true; } return _FLAG_ONEWAYContent; } }
        private static int _FLAG_ONEWAYContent = default;
        private static bool _FLAG_ONEWAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#INTERFACE_TRANSACTION"/>
        /// </summary>
        public static int INTERFACE_TRANSACTION { get { if (!_INTERFACE_TRANSACTIONReady) { _INTERFACE_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "INTERFACE_TRANSACTION"); _INTERFACE_TRANSACTIONReady = true; } return _INTERFACE_TRANSACTIONContent; } }
        private static int _INTERFACE_TRANSACTIONContent = default;
        private static bool _INTERFACE_TRANSACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#LAST_CALL_TRANSACTION"/>
        /// </summary>
        public static int LAST_CALL_TRANSACTION { get { if (!_LAST_CALL_TRANSACTIONReady) { _LAST_CALL_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "LAST_CALL_TRANSACTION"); _LAST_CALL_TRANSACTIONReady = true; } return _LAST_CALL_TRANSACTIONContent; } }
        private static int _LAST_CALL_TRANSACTIONContent = default;
        private static bool _LAST_CALL_TRANSACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#LIKE_TRANSACTION"/>
        /// </summary>
        public static int LIKE_TRANSACTION { get { if (!_LIKE_TRANSACTIONReady) { _LIKE_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "LIKE_TRANSACTION"); _LIKE_TRANSACTIONReady = true; } return _LIKE_TRANSACTIONContent; } }
        private static int _LIKE_TRANSACTIONContent = default;
        private static bool _LIKE_TRANSACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#PING_TRANSACTION"/>
        /// </summary>
        public static int PING_TRANSACTION { get { if (!_PING_TRANSACTIONReady) { _PING_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "PING_TRANSACTION"); _PING_TRANSACTIONReady = true; } return _PING_TRANSACTIONContent; } }
        private static int _PING_TRANSACTIONContent = default;
        private static bool _PING_TRANSACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#TWEET_TRANSACTION"/>
        /// </summary>
        public static int TWEET_TRANSACTION { get { if (!_TWEET_TRANSACTIONReady) { _TWEET_TRANSACTIONContent = SGetField<int>(LocalBridgeClazz, "TWEET_TRANSACTION"); _TWEET_TRANSACTIONReady = true; } return _TWEET_TRANSACTIONContent; } }
        private static int _TWEET_TRANSACTIONContent = default;
        private static bool _TWEET_TRANSACTIONReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#getSuggestedMaxIpcSizeBytes()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public static int GetSuggestedMaxIpcSizeBytes()
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getSuggestedMaxIpcSizeBytes", "()I");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#queryLocalInterface(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.IInterface"/></returns>
        public Android.Os.IInterface QueryLocalInterface(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Os.IInterface>("queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#isBinderAlive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBinderAlive()
        {
            return IExecuteWithSignature<bool>("isBinderAlive", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#pingBinder()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool PingBinder()
        {
            return IExecuteWithSignature<bool>("pingBinder", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#transact(int,android.os.Parcel,android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg2"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public bool Transact(int arg0, Android.Os.Parcel arg1, Android.Os.Parcel arg2, int arg3)
        {
            return IExecuteWithSignature<bool>("transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#unlinkToDeath(android.os.IBinder.DeathRecipient,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder.DeathRecipient"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool UnlinkToDeath(Android.Os.IBinder.DeathRecipient arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#getInterfaceDescriptor()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Java.Lang.String GetInterfaceDescriptor()
        {
            return IExecuteWithSignature<Java.Lang.String>("getInterfaceDescriptor", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#dump(java.io.FileDescriptor,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Android.Os.RemoteException"/>
        public void Dump(Java.Io.FileDescriptor arg0, Java.Lang.String[] arg1)
        {
            IExecuteWithSignature("dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#dumpAsync(java.io.FileDescriptor,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Android.Os.RemoteException"/>
        public void DumpAsync(Java.Io.FileDescriptor arg0, Java.Lang.String[] arg1)
        {
            IExecuteWithSignature("dumpAsync", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/IBinder.html#linkToDeath(android.os.IBinder.DeathRecipient,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.IBinder.DeathRecipient"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Android.Os.RemoteException"/>
        public void LinkToDeath(Android.Os.IBinder.DeathRecipient arg0, int arg1)
        {
            IExecuteWithSignature("linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region DeathRecipient implementation
        public partial class DeathRecipient
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
            /// <see href="https://developer.android.com/reference/android/os/IBinder.DeathRecipient.html#binderDied()"/>
            /// </summary>
            public void BinderDied()
            {
                IExecuteWithSignature("binderDied", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/IBinder.DeathRecipient.html#binderDied(android.os.IBinder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.IBinder"/></param>
            public void BinderDied(Android.Os.IBinder arg0)
            {
                IExecuteWithSignature("binderDied", "(Landroid/os/IBinder;)V", arg0);
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