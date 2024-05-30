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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.App.Appsearch.Observer
{
    #region ObserverSpec
    public partial class ObserverSpec
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
        /// <see href="https://developer.android.com/reference/android/app/appsearch/observer/ObserverSpec.html#getFilterSchemas()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> FilterSchemas
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getFilterSchemas", "()Ljava/util/Set;"); }
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/observer/ObserverSpec.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.Observer.ObserverSpec"/></returns>
            public Android.App.Appsearch.Observer.ObserverSpec Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.Observer.ObserverSpec>("build", "()Landroid/app/appsearch/observer/ObserverSpec;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/observer/ObserverSpec.Builder.html#addFilterSchemas(java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.Observer.ObserverSpec.Builder"/></returns>
            public Android.App.Appsearch.Observer.ObserverSpec.Builder AddFilterSchemas(params Java.Lang.String[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.App.Appsearch.Observer.ObserverSpec.Builder>("addFilterSchemas", "([Ljava/lang/String;)Landroid/app/appsearch/observer/ObserverSpec$Builder;"); else return IExecuteWithSignature<Android.App.Appsearch.Observer.ObserverSpec.Builder>("addFilterSchemas", "([Ljava/lang/String;)Landroid/app/appsearch/observer/ObserverSpec$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/observer/ObserverSpec.Builder.html#addFilterSchemas(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.Observer.ObserverSpec.Builder"/></returns>
            public Android.App.Appsearch.Observer.ObserverSpec.Builder AddFilterSchemas(Java.Util.Collection<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.Observer.ObserverSpec.Builder>("addFilterSchemas", "(Ljava/util/Collection;)Landroid/app/appsearch/observer/ObserverSpec$Builder;", arg0);
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