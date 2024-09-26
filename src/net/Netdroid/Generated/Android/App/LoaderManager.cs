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

namespace Android.App
{
    #region LoaderManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/LoaderManager.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class LoaderManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LoaderManager>
    {
        const string _bridgeClassName = "android.app.LoaderManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("LoaderManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LoaderManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("LoaderManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LoaderManager(params object[] args) : base(args) { }

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
        #region LoaderCallbacks declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html"/>
        /// </summary>
        [global::System.Obsolete()]
        public partial class LoaderCallbacks : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LoaderCallbacks>
        {
            const string _bridgeClassName = "android.app.LoaderManager$LoaderCallbacks";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("LoaderCallbacks class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public LoaderCallbacks() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("LoaderCallbacks class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public LoaderCallbacks(params object[] args) : base(args) { }

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

        #region LoaderCallbacks<D> declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html"/>
        /// </summary>
        /// <typeparam name="D"></typeparam>
        [global::System.Obsolete()]
        public partial class LoaderCallbacks<D> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LoaderCallbacks<D>>
        {
            const string _bridgeClassName = "android.app.LoaderManager$LoaderCallbacks";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("LoaderCallbacks class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public LoaderCallbacks() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("LoaderCallbacks class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public LoaderCallbacks(params object[] args) : base(args) { }

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

    #region LoaderManager implementation
    public partial class LoaderManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.html#enableDebugLogging(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public static void EnableDebugLogging(bool arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "enableDebugLogging", "(Z)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.html#getLoader(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <typeparam name="D"></typeparam>
        /// <returns><see cref="Android.Content.Loader"/></returns>
        [global::System.Obsolete()]
        public Android.Content.Loader<D> GetLoader<D>(int arg0)
        {
            return IExecuteWithSignature<Android.Content.Loader<D>>("getLoader", "(I)Landroid/content/Loader;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.html#initLoader(int,android.os.Bundle,android.app.LoaderManager.LoaderCallbacks)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.App.LoaderManager.LoaderCallbacks"/></param>
        /// <typeparam name="D"></typeparam>
        /// <returns><see cref="Android.Content.Loader"/></returns>
        [global::System.Obsolete()]
        public Android.Content.Loader<D> InitLoader<D>(int arg0, Android.Os.Bundle arg1, Android.App.LoaderManager.LoaderCallbacks<D> arg2)
        {
            return IExecuteWithSignature<Android.Content.Loader<D>>("initLoader", "(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallbacks;)Landroid/content/Loader;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.html#restartLoader(int,android.os.Bundle,android.app.LoaderManager.LoaderCallbacks)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.App.LoaderManager.LoaderCallbacks"/></param>
        /// <typeparam name="D"></typeparam>
        /// <returns><see cref="Android.Content.Loader"/></returns>
        [global::System.Obsolete()]
        public Android.Content.Loader<D> RestartLoader<D>(int arg0, Android.Os.Bundle arg1, Android.App.LoaderManager.LoaderCallbacks<D> arg2)
        {
            return IExecuteWithSignature<Android.Content.Loader<D>>("restartLoader", "(ILandroid/os/Bundle;Landroid/app/LoaderManager$LoaderCallbacks;)Landroid/content/Loader;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.html#destroyLoader(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void DestroyLoader(int arg0)
        {
            IExecuteWithSignature("destroyLoader", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/LoaderManager.html#dump(java.lang.String,java.io.FileDescriptor,java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg2"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void Dump(Java.Lang.String arg0, Java.Io.FileDescriptor arg1, Java.Io.PrintWriter arg2, Java.Lang.String[] arg3)
        {
            IExecuteWithSignature("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region LoaderCallbacks implementation
        public partial class LoaderCallbacks
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
            /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html#onCreateLoader(int,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Content.Loader"/></returns>
            [global::System.Obsolete()]
            public Android.Content.Loader OnCreateLoader(int arg0, Android.Os.Bundle arg1)
            {
                return IExecuteWithSignature<Android.Content.Loader>("onCreateLoader", "(ILandroid/os/Bundle;)Landroid/content/Loader;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html#onLoaderReset(android.content.Loader)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Loader"/></param>
            [global::System.Obsolete()]
            public void OnLoaderReset(Android.Content.Loader arg0)
            {
                IExecuteWithSignature("onLoaderReset", "(Landroid/content/Loader;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html#onLoadFinished(android.content.Loader,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Loader"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            [global::System.Obsolete()]
            public void OnLoadFinished(Android.Content.Loader arg0, object arg1)
            {
                IExecuteWithSignature("onLoadFinished", "(Landroid/content/Loader;Ljava/lang/Object;)V", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LoaderCallbacks<D> implementation
        public partial class LoaderCallbacks<D>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.App.LoaderManager.LoaderCallbacks{D}"/> to <see cref="Android.App.LoaderManager.LoaderCallbacks"/>
            /// </summary>
            public static implicit operator Android.App.LoaderManager.LoaderCallbacks(Android.App.LoaderManager.LoaderCallbacks<D> t) => t.Cast<Android.App.LoaderManager.LoaderCallbacks>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html#onCreateLoader(int,android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Content.Loader"/></returns>
            [global::System.Obsolete()]
            public Android.Content.Loader<D> OnCreateLoader(int arg0, Android.Os.Bundle arg1)
            {
                return IExecuteWithSignature<Android.Content.Loader<D>>("onCreateLoader", "(ILandroid/os/Bundle;)Landroid/content/Loader;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html#onLoaderReset(android.content.Loader)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Loader"/></param>
            [global::System.Obsolete()]
            public void OnLoaderReset(Android.Content.Loader<D> arg0)
            {
                IExecuteWithSignature("onLoaderReset", "(Landroid/content/Loader;)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/LoaderManager.LoaderCallbacks.html#onLoadFinished(android.content.Loader,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Loader"/></param>
            /// <param name="arg1"><typeparamref name="D"/></param>
            [global::System.Obsolete()]
            public void OnLoadFinished(Android.Content.Loader<D> arg0, D arg1)
            {
                IExecuteWithSignature("onLoadFinished", "(Landroid/content/Loader;Ljava/lang/Object;)V", arg0, arg1);
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