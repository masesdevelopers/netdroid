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

namespace Android.App.Appsearch
{
    #region AppSearchManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.html"/>
    /// </summary>
    public partial class AppSearchManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AppSearchManager>
    {
        const string _bridgeClassName = "android.app.appsearch.AppSearchManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AppSearchManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AppSearchManager(params object[] args) : base(args) { }

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
        #region SearchContext declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.html"/>
        /// </summary>
        public partial class SearchContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SearchContext>
        {
            const string _bridgeClassName = "android.app.appsearch.AppSearchManager$SearchContext";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SearchContext() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SearchContext(params object[] args) : base(args) { }

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
            #region Builder declaration
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.Builder.html"/>
            /// </summary>
            public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
            {
                const string _bridgeClassName = "android.app.appsearch.AppSearchManager$SearchContext$Builder";
                /// <summary>
                /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
                /// </summary>
                public Builder() { }
                /// <summary>
                /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
                /// </summary>
                public Builder(params object[] args) : base(args) { }

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

        
        }
        #endregion

    
    }
    #endregion

    #region AppSearchManager implementation
    public partial class AppSearchManager
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.html#createEnterpriseGlobalSearchSession(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void CreateEnterpriseGlobalSearchSession(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.EnterpriseGlobalSearchSession>> arg1)
        {
            IExecute("createEnterpriseGlobalSearchSession", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.html#createGlobalSearchSession(java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Consumer"/></param>
        public void CreateGlobalSearchSession(Java.Util.Concurrent.Executor arg0, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.GlobalSearchSession>> arg1)
        {
            IExecute("createGlobalSearchSession", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.html#createSearchSession(android.app.appsearch.AppSearchManager.SearchContext,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.Appsearch.AppSearchManager.SearchContext"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public void CreateSearchSession(Android.App.Appsearch.AppSearchManager.SearchContext arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.App.Appsearch.AppSearchResult<Android.App.Appsearch.AppSearchSession>> arg2)
        {
            IExecute("createSearchSession", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region SearchContext implementation
        public partial class SearchContext
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.html#getDatabaseName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetDatabaseName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getDatabaseName", "()Ljava/lang/String;");
            }

            #endregion

            #region Nested classes
            #region Builder implementation
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.Builder.html#%3Cinit%3E(java.lang.String)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.String"/></param>
                public Builder(Java.Lang.String arg0)
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
                /// <see href="https://developer.android.com/reference/android/app/appsearch/AppSearchManager.SearchContext.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.App.Appsearch.AppSearchManager.SearchContext"/></returns>
                public Android.App.Appsearch.AppSearchManager.SearchContext Build()
                {
                    return IExecuteWithSignature<Android.App.Appsearch.AppSearchManager.SearchContext>("build", "()Landroid/app/appsearch/AppSearchManager$SearchContext;");
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}