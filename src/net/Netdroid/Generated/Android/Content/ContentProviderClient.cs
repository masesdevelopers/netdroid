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

namespace Android.Content
{
    #region ContentProviderClient declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html"/>
    /// </summary>
    public partial class ContentProviderClient : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "android.content.ContentProviderClient";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ContentProviderClient() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ContentProviderClient(params object[] args) : base(args) { }
    
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

    #region ContentProviderClient implementation
    public partial class ContentProviderClient
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
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#getLocalContentProvider()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ContentProvider"/></returns>
        public Android.Content.ContentProvider GetLocalContentProvider()
        {
            return IExecuteWithSignature<Android.Content.ContentProvider>("getLocalContentProvider", "()Landroid/content/ContentProvider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#applyBatch(java.lang.String,java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.ArrayList"/></param>
        /// <returns><see cref="Android.Content.ContentProviderResult"/></returns>
        /// <exception cref="Android.Content.OperationApplicationException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Content.ContentProviderResult[] ApplyBatch(Java.Lang.String arg0, Java.Util.ArrayList<Android.Content.ContentProviderOperation> arg1)
        {
            return IExecuteWithSignatureArray<Android.Content.ContentProviderResult>("applyBatch", "(Ljava/lang/String;Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#applyBatch(java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.ArrayList"/></param>
        /// <returns><see cref="Android.Content.ContentProviderResult"/></returns>
        /// <exception cref="Android.Content.OperationApplicationException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Content.ContentProviderResult[] ApplyBatch(Java.Util.ArrayList<Android.Content.ContentProviderOperation> arg0)
        {
            return IExecuteWithSignatureArray<Android.Content.ContentProviderResult>("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#openAssetFile(android.net.Uri,java.lang.String,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Content.Res.AssetFileDescriptor OpenAssetFile(Android.Net.Uri arg0, Java.Lang.String arg1, Android.Os.CancellationSignal arg2)
        {
            return IExecuteWithSignature<Android.Content.Res.AssetFileDescriptor>("openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/CancellationSignal;)Landroid/content/res/AssetFileDescriptor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#openAssetFile(android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Content.Res.AssetFileDescriptor OpenAssetFile(Android.Net.Uri arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.Content.Res.AssetFileDescriptor>("openAssetFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#query(android.net.Uri,java.lang.String[],android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg3"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Database.Cursor Query(Android.Net.Uri arg0, Java.Lang.String[] arg1, Android.Os.Bundle arg2, Android.Os.CancellationSignal arg3)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("query", "(Landroid/net/Uri;[Ljava/lang/String;Landroid/os/Bundle;Landroid/os/CancellationSignal;)Landroid/database/Cursor;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#query(android.net.Uri,java.lang.String[],java.lang.String,java.lang.String[],java.lang.String,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Database.Cursor Query(Android.Net.Uri arg0, Java.Lang.String[] arg1, Java.Lang.String arg2, Java.Lang.String[] arg3, Java.Lang.String arg4, Android.Os.CancellationSignal arg5)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Landroid/os/CancellationSignal;)Landroid/database/Cursor;", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#query(android.net.Uri,java.lang.String[],java.lang.String,java.lang.String[],java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Database.Cursor Query(Android.Net.Uri arg0, Java.Lang.String[] arg1, Java.Lang.String arg2, Java.Lang.String[] arg3, Java.Lang.String arg4)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#insert(android.net.Uri,android.content.ContentValues,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Content.ContentValues"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Net.Uri Insert(Android.Net.Uri arg0, Android.Content.ContentValues arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<Android.Net.Uri>("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;Landroid/os/Bundle;)Landroid/net/Uri;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#insert(android.net.Uri,android.content.ContentValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Content.ContentValues"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Net.Uri Insert(Android.Net.Uri arg0, Android.Content.ContentValues arg1)
        {
            return IExecuteWithSignature<Android.Net.Uri>("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#call(java.lang.String,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Os.Bundle Call(Java.Lang.String arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("call", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#call(java.lang.String,java.lang.String,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Os.Bundle Call(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Os.Bundle arg3)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("call", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#openFile(android.net.Uri,java.lang.String,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Os.ParcelFileDescriptor OpenFile(Android.Net.Uri arg0, Java.Lang.String arg1, Android.Os.CancellationSignal arg2)
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("openFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/CancellationSignal;)Landroid/os/ParcelFileDescriptor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#openFile(android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Os.ParcelFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Os.ParcelFileDescriptor OpenFile(Android.Net.Uri arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("openFile", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#refresh(android.net.Uri,android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public bool Refresh(Android.Net.Uri arg0, Android.Os.Bundle arg1, Android.Os.CancellationSignal arg2)
        {
            return IExecuteWithSignature<bool>("refresh", "(Landroid/net/Uri;Landroid/os/Bundle;Landroid/os/CancellationSignal;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#release()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Release()
        {
            return IExecuteWithSignature<bool>("release", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#openTypedAssetFile(android.net.Uri,java.lang.String,android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg3"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Content.Res.AssetFileDescriptor OpenTypedAssetFile(Android.Net.Uri arg0, Java.Lang.String arg1, Android.Os.Bundle arg2, Android.Os.CancellationSignal arg3)
        {
            return IExecuteWithSignature<Android.Content.Res.AssetFileDescriptor>("openTypedAssetFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/CancellationSignal;)Landroid/content/res/AssetFileDescriptor;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#openTypedAssetFileDescriptor(android.net.Uri,java.lang.String,android.os.Bundle,android.os.CancellationSignal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg3"><see cref="Android.Os.CancellationSignal"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Content.Res.AssetFileDescriptor OpenTypedAssetFileDescriptor(Android.Net.Uri arg0, Java.Lang.String arg1, Android.Os.Bundle arg2, Android.Os.CancellationSignal arg3)
        {
            return IExecuteWithSignature<Android.Content.Res.AssetFileDescriptor>("openTypedAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;Landroid/os/CancellationSignal;)Landroid/content/res/AssetFileDescriptor;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#openTypedAssetFileDescriptor(android.net.Uri,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Content.Res.AssetFileDescriptor"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Content.Res.AssetFileDescriptor OpenTypedAssetFileDescriptor(Android.Net.Uri arg0, Java.Lang.String arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<Android.Content.Res.AssetFileDescriptor>("openTypedAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/AssetFileDescriptor;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#canonicalize(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Net.Uri Canonicalize(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Android.Net.Uri>("canonicalize", "(Landroid/net/Uri;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#uncanonicalize(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Android.Net.Uri Uncanonicalize(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Android.Net.Uri>("uncanonicalize", "(Landroid/net/Uri;)Landroid/net/Uri;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#bulkInsert(android.net.Uri,android.content.ContentValues[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Content.ContentValues"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public int BulkInsert(Android.Net.Uri arg0, Android.Content.ContentValues[] arg1)
        {
            return IExecuteWithSignature<int>("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#delete(android.net.Uri,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public int Delete(Android.Net.Uri arg0, Android.Os.Bundle arg1)
        {
            return IExecuteWithSignature<int>("delete", "(Landroid/net/Uri;Landroid/os/Bundle;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#delete(android.net.Uri,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public int Delete(Android.Net.Uri arg0, Java.Lang.String arg1, Java.Lang.String[] arg2)
        {
            return IExecuteWithSignature<int>("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#update(android.net.Uri,android.content.ContentValues,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Content.ContentValues"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public int Update(Android.Net.Uri arg0, Android.Content.ContentValues arg1, Android.Os.Bundle arg2)
        {
            return IExecuteWithSignature<int>("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Landroid/os/Bundle;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#update(android.net.Uri,android.content.ContentValues,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Content.ContentValues"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public int Update(Android.Net.Uri arg0, Android.Content.ContentValues arg1, Java.Lang.String arg2, Java.Lang.String[] arg3)
        {
            return IExecuteWithSignature<int>("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#getType(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Java.Lang.String GetType(Android.Net.Uri arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getType", "(Landroid/net/Uri;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#getStreamTypes(android.net.Uri,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Android.Os.RemoteException"/>
        public Java.Lang.String[] GetStreamTypes(Android.Net.Uri arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ContentProviderClient.html#close()"/>
        /// </summary>
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