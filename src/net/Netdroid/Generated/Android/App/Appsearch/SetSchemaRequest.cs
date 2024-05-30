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

namespace Android.App.Appsearch
{
    #region SetSchemaRequest
    public partial class SetSchemaRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#READ_ASSISTANT_APP_SEARCH_DATA"/>
        /// </summary>
        public static int READ_ASSISTANT_APP_SEARCH_DATA { get { if (!_READ_ASSISTANT_APP_SEARCH_DATAReady) { _READ_ASSISTANT_APP_SEARCH_DATAContent = SGetField<int>(LocalBridgeClazz, "READ_ASSISTANT_APP_SEARCH_DATA"); _READ_ASSISTANT_APP_SEARCH_DATAReady = true; } return _READ_ASSISTANT_APP_SEARCH_DATAContent; } }
        private static int _READ_ASSISTANT_APP_SEARCH_DATAContent = default;
        private static bool _READ_ASSISTANT_APP_SEARCH_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#READ_CALENDAR"/>
        /// </summary>
        public static int READ_CALENDAR { get { if (!_READ_CALENDARReady) { _READ_CALENDARContent = SGetField<int>(LocalBridgeClazz, "READ_CALENDAR"); _READ_CALENDARReady = true; } return _READ_CALENDARContent; } }
        private static int _READ_CALENDARContent = default;
        private static bool _READ_CALENDARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#READ_CONTACTS"/>
        /// </summary>
        public static int READ_CONTACTS { get { if (!_READ_CONTACTSReady) { _READ_CONTACTSContent = SGetField<int>(LocalBridgeClazz, "READ_CONTACTS"); _READ_CONTACTSReady = true; } return _READ_CONTACTSContent; } }
        private static int _READ_CONTACTSContent = default;
        private static bool _READ_CONTACTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#READ_EXTERNAL_STORAGE"/>
        /// </summary>
        public static int READ_EXTERNAL_STORAGE { get { if (!_READ_EXTERNAL_STORAGEReady) { _READ_EXTERNAL_STORAGEContent = SGetField<int>(LocalBridgeClazz, "READ_EXTERNAL_STORAGE"); _READ_EXTERNAL_STORAGEReady = true; } return _READ_EXTERNAL_STORAGEContent; } }
        private static int _READ_EXTERNAL_STORAGEContent = default;
        private static bool _READ_EXTERNAL_STORAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#READ_HOME_APP_SEARCH_DATA"/>
        /// </summary>
        public static int READ_HOME_APP_SEARCH_DATA { get { if (!_READ_HOME_APP_SEARCH_DATAReady) { _READ_HOME_APP_SEARCH_DATAContent = SGetField<int>(LocalBridgeClazz, "READ_HOME_APP_SEARCH_DATA"); _READ_HOME_APP_SEARCH_DATAReady = true; } return _READ_HOME_APP_SEARCH_DATAContent; } }
        private static int _READ_HOME_APP_SEARCH_DATAContent = default;
        private static bool _READ_HOME_APP_SEARCH_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#READ_SMS"/>
        /// </summary>
        public static int READ_SMS { get { if (!_READ_SMSReady) { _READ_SMSContent = SGetField<int>(LocalBridgeClazz, "READ_SMS"); _READ_SMSReady = true; } return _READ_SMSContent; } }
        private static int _READ_SMSContent = default;
        private static bool _READ_SMSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#getMigrators()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Android.App.Appsearch.Migrator> Migrators
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Android.App.Appsearch.Migrator>>("getMigrators", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#getRequiredPermissionsForSchemaTypeVisibility()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Util.Set<Java.Util.Set<Java.Lang.Integer>>> RequiredPermissionsForSchemaTypeVisibility
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Set<Java.Util.Set<Java.Lang.Integer>>>>("getRequiredPermissionsForSchemaTypeVisibility", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#getSchemas()"/> 
        /// </summary>
        public Java.Util.Set<Android.App.Appsearch.AppSearchSchema> Schemas
        {
            get { return IExecuteWithSignature<Java.Util.Set<Android.App.Appsearch.AppSearchSchema>>("getSchemas", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#getSchemasNotDisplayedBySystem()"/> 
        /// </summary>
        public Java.Util.Set<Java.Lang.String> SchemasNotDisplayedBySystem
        {
            get { return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getSchemasNotDisplayedBySystem", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#getSchemasVisibleToPackages()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Util.Set<Android.App.Appsearch.PackageIdentifier>> SchemasVisibleToPackages
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Set<Android.App.Appsearch.PackageIdentifier>>>("getSchemasVisibleToPackages", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#getVersion()"/> 
        /// </summary>
        public int Version
        {
            get { return IExecuteWithSignature<int>("getVersion", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.html#isForceOverride()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsForceOverride()
        {
            return IExecuteWithSignature<bool>("isForceOverride", "()Z");
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
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest"/></returns>
            public Android.App.Appsearch.SetSchemaRequest Build()
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest>("build", "()Landroid/app/appsearch/SetSchemaRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#addRequiredPermissionsForSchemaTypeVisibility(java.lang.String,java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder AddRequiredPermissionsForSchemaTypeVisibility(Java.Lang.String arg0, Java.Util.Set<Java.Lang.Integer> arg1)
            {
                return IExecute<Android.App.Appsearch.SetSchemaRequest.Builder>("addRequiredPermissionsForSchemaTypeVisibility", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#addSchemas(android.app.appsearch.AppSearchSchema[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.Appsearch.AppSearchSchema"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder AddSchemas(params Android.App.Appsearch.AppSearchSchema[] arg0)
            {
                if (arg0.Length == 0) return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest.Builder>("addSchemas", "([Landroid/app/appsearch/AppSearchSchema;)Landroid/app/appsearch/SetSchemaRequest$Builder;"); else return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest.Builder>("addSchemas", "([Landroid/app/appsearch/AppSearchSchema;)Landroid/app/appsearch/SetSchemaRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#addSchemas(java.util.Collection)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder AddSchemas(Java.Util.Collection<Android.App.Appsearch.AppSearchSchema> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest.Builder>("addSchemas", "(Ljava/util/Collection;)Landroid/app/appsearch/SetSchemaRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#clearRequiredPermissionsForSchemaTypeVisibility(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder ClearRequiredPermissionsForSchemaTypeVisibility(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest.Builder>("clearRequiredPermissionsForSchemaTypeVisibility", "(Ljava/lang/String;)Landroid/app/appsearch/SetSchemaRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#setForceOverride(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder SetForceOverride(bool arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest.Builder>("setForceOverride", "(Z)Landroid/app/appsearch/SetSchemaRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#setMigrator(java.lang.String,android.app.appsearch.Migrator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.App.Appsearch.Migrator"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder SetMigrator(Java.Lang.String arg0, Android.App.Appsearch.Migrator arg1)
            {
                return IExecute<Android.App.Appsearch.SetSchemaRequest.Builder>("setMigrator", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#setMigrators(java.util.Map)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder SetMigrators(Java.Util.Map<Java.Lang.String, Android.App.Appsearch.Migrator> arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest.Builder>("setMigrators", "(Ljava/util/Map;)Landroid/app/appsearch/SetSchemaRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#setSchemaTypeDisplayedBySystem(java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder SetSchemaTypeDisplayedBySystem(Java.Lang.String arg0, bool arg1)
            {
                return IExecute<Android.App.Appsearch.SetSchemaRequest.Builder>("setSchemaTypeDisplayedBySystem", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#setSchemaTypeVisibilityForPackage(java.lang.String,boolean,android.app.appsearch.PackageIdentifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <param name="arg2"><see cref="Android.App.Appsearch.PackageIdentifier"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder SetSchemaTypeVisibilityForPackage(Java.Lang.String arg0, bool arg1, Android.App.Appsearch.PackageIdentifier arg2)
            {
                return IExecute<Android.App.Appsearch.SetSchemaRequest.Builder>("setSchemaTypeVisibilityForPackage", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/appsearch/SetSchemaRequest.Builder.html#setVersion(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.Appsearch.SetSchemaRequest.Builder"/></returns>
            public Android.App.Appsearch.SetSchemaRequest.Builder SetVersion(int arg0)
            {
                return IExecuteWithSignature<Android.App.Appsearch.SetSchemaRequest.Builder>("setVersion", "(I)Landroid/app/appsearch/SetSchemaRequest$Builder;", arg0);
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