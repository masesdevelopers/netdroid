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

namespace Android.App.Appsearch
{
    #region AppSearchSession declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html"/>
    /// </summary>
    public partial class AppSearchSession : Java.Io.Closeable
    {
        const string _bridgeClassName = "android.app.appsearch.AppSearchSession";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AppSearchSession() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AppSearchSession(params object[] args) : base(args) { }
    
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

    #region AppSearchSession implementation
    public partial class AppSearchSession
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#search(java.lang.String,android.app.appsearch.SearchSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.App.Appsearch.SearchSpec"/></param>
        /// <returns><see cref="Android.App.Appsearch.SearchResults"/></returns>
        public Android.App.Appsearch.SearchResults Search(Java.Lang.String arg0, Android.App.Appsearch.SearchSpec arg1)
        {
            return IExecuteWithSignature<Android.App.Appsearch.SearchResults>("search", "(Ljava/lang/String;Landroid/app/appsearch/SearchSpec;)Landroid/app/appsearch/SearchResults;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#getByDocumentId(android.app.appsearch.GetByDocumentIdRequest,java.util.concurrent.Executor,android.app.appsearch.BatchResultCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.GetByDocumentIdRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.App.Appsearch.BatchResultCallback"/></param>
        public void GetByDocumentId(Android.App.Appsearch.GetByDocumentIdRequest arg0, Java.Util.Concurrent.Executor arg1, Android.App.Appsearch.BatchResultCallback<Java.Lang.String, Android.App.Appsearch.GenericDocument> arg2)
        {
            IExecuteWithSignature("getByDocumentId", "(Landroid/app/appsearch/GetByDocumentIdRequest;Ljava/util/concurrent/Executor;Landroid/app/appsearch/BatchResultCallback;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#getNamespaces(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetNamespaces(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Java.Util.Set<Java.Lang.String>>> arg1)
        {
            IExecuteWithSignature("getNamespaces", "(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#getSchema(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetSchema(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.GetSchemaResponse>> arg1)
        {
            IExecuteWithSignature("getSchema", "(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#getStorageInfo(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void GetStorageInfo(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.StorageInfo>> arg1)
        {
            IExecuteWithSignature("getStorageInfo", "(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#put(android.app.appsearch.PutDocumentsRequest,java.util.concurrent.Executor,android.app.appsearch.BatchResultCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.PutDocumentsRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.App.Appsearch.BatchResultCallback"/></param>
        public void Put(Android.App.Appsearch.PutDocumentsRequest arg0, Java.Util.Concurrent.Executor arg1, Android.App.Appsearch.BatchResultCallback<Java.Lang.String, Java.Lang.Void> arg2)
        {
            IExecuteWithSignature("put", "(Landroid/app/appsearch/PutDocumentsRequest;Ljava/util/concurrent/Executor;Landroid/app/appsearch/BatchResultCallback;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#remove(android.app.appsearch.RemoveByDocumentIdRequest,java.util.concurrent.Executor,android.app.appsearch.BatchResultCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.RemoveByDocumentIdRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.App.Appsearch.BatchResultCallback"/></param>
        public void Remove(Android.App.Appsearch.RemoveByDocumentIdRequest arg0, Java.Util.Concurrent.Executor arg1, Android.App.Appsearch.BatchResultCallback<Java.Lang.String, Java.Lang.Void> arg2)
        {
            IExecuteWithSignature("remove", "(Landroid/app/appsearch/RemoveByDocumentIdRequest;Ljava/util/concurrent/Executor;Landroid/app/appsearch/BatchResultCallback;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#remove(java.lang.String,android.app.appsearch.SearchSpec,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.App.Appsearch.SearchSpec"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Consumer"/></param>
        public void Remove(Java.Lang.String arg0, Android.App.Appsearch.SearchSpec arg1, Java.Util.Concurrent.Executor arg2, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Java.Lang.Void>> arg3)
        {
            IExecuteWithSignature("remove", "(Ljava/lang/String;Landroid/app/appsearch/SearchSpec;Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#reportUsage(android.app.appsearch.ReportUsageRequest,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.ReportUsageRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void ReportUsage(Android.App.Appsearch.ReportUsageRequest arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Java.Lang.Void>> arg2)
        {
            IExecuteWithSignature("reportUsage", "(Landroid/app/appsearch/ReportUsageRequest;Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#searchSuggestion(java.lang.String,android.app.appsearch.SearchSuggestionSpec,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.App.Appsearch.SearchSuggestionSpec"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Consumer"/></param>
        public void SearchSuggestion(Java.Lang.String arg0, Android.App.Appsearch.SearchSuggestionSpec arg1, Java.Util.Concurrent.Executor arg2, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Java.Util.List<Android.App.Appsearch.SearchSuggestionResult>>> arg3)
        {
            IExecuteWithSignature("searchSuggestion", "(Ljava/lang/String;Landroid/app/appsearch/SearchSuggestionSpec;Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchSession.html#setSchema(android.app.appsearch.SetSchemaRequest,java.util.concurrent.Executor,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.SetSchemaRequest"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Consumer"/></param>
        public void SetSchema(Android.App.Appsearch.SetSchemaRequest arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Concurrent.Executor arg2, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.SetSchemaResponse>> arg3)
        {
            IExecuteWithSignature("setSchema", "(Landroid/app/appsearch/SetSchemaRequest;Ljava/util/concurrent/Executor;Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}