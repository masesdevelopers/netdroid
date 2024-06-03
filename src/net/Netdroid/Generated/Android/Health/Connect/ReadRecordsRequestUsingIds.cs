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

namespace Android.Health.Connect
{
    #region ReadRecordsRequestUsingIds
    public partial class ReadRecordsRequestUsingIds
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
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.html#getRecordIdFilters()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List GetRecordIdFilters()
        {
            return IExecuteWithSignature<Java.Util.List>("getRecordIdFilters", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#%3Cinit%3E(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Builder(Java.Lang.Class arg0)
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
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingIds"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingIds Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingIds>("build", "()Landroid/health/connect/ReadRecordsRequestUsingIds;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#addClientRecordId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingIds.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingIds.Builder AddClientRecordId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingIds.Builder>("addClientRecordId", "(Ljava/lang/String;)Landroid/health/connect/ReadRecordsRequestUsingIds$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#addId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingIds.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingIds.Builder AddId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingIds.Builder>("addId", "(Ljava/lang/String;)Landroid/health/connect/ReadRecordsRequestUsingIds$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Builder<T>
        public partial class Builder<T>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#%3Cinit%3E(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Builder(Java.Lang.Class arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Health.Connect.ReadRecordsRequestUsingIds.Builder{T}"/> to <see cref="Android.Health.Connect.ReadRecordsRequestUsingIds.Builder"/>
            /// </summary>
            public static implicit operator Android.Health.Connect.ReadRecordsRequestUsingIds.Builder(Android.Health.Connect.ReadRecordsRequestUsingIds.Builder<T> t) => t.Cast<Android.Health.Connect.ReadRecordsRequestUsingIds.Builder>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingIds"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingIds<T> Build()
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingIds<T>>("build", "()Landroid/health/connect/ReadRecordsRequestUsingIds;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#addClientRecordId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingIds.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingIds.Builder<T> AddClientRecordId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingIds.Builder<T>>("addClientRecordId", "(Ljava/lang/String;)Landroid/health/connect/ReadRecordsRequestUsingIds$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.Builder.html#addId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Health.Connect.ReadRecordsRequestUsingIds.Builder"/></returns>
            public Android.Health.Connect.ReadRecordsRequestUsingIds.Builder<T> AddId(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Health.Connect.ReadRecordsRequestUsingIds.Builder<T>>("addId", "(Ljava/lang/String;)Landroid/health/connect/ReadRecordsRequestUsingIds$Builder;", arg0);
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

    #region ReadRecordsRequestUsingIds<T>
    public partial class ReadRecordsRequestUsingIds<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Health.Connect.ReadRecordsRequestUsingIds{T}"/> to <see cref="Android.Health.Connect.ReadRecordsRequestUsingIds"/>
        /// </summary>
        public static implicit operator Android.Health.Connect.ReadRecordsRequestUsingIds(Android.Health.Connect.ReadRecordsRequestUsingIds<T> t) => t.Cast<Android.Health.Connect.ReadRecordsRequestUsingIds>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/ReadRecordsRequestUsingIds.html#getRecordIdFilters()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Health.Connect.RecordIdFilter> GetRecordIdFilters()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Health.Connect.RecordIdFilter>>("getRecordIdFilters", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}